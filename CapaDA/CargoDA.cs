using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaBE;

namespace CapaDA
{
    class CargoDA
    {
        private static SqlConnection CN = new SqlConnection(StrConexion.strcn);
        
        public static ENResultOperation Acceder(SqlCommand cmd)
        {
            ENResultOperation result = new ENResultOperation();
            cmd.Connection = CN;
            cmd.CommandType = CommandType.StoredProcedure;
            DataTable temp = new DataTable();
            try
            {
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DA.Fill(temp);
                string NombreError = cmd.Parameters["@NOMBRE_ERROR"].Value.ToString();
                string ValRetorno = cmd.Parameters["@RETURN"].Value.ToString();
                if (Convert.ToInt32(ValRetorno) != 0)
                {
                    result.Proceder = false;
                    result.Sms = NombreError;
                    result.Valor = temp;
                }
                else
                {
                    result.Proceder = true;
                    result.Sms = "Correcto";
                    result.Valor = temp;
                }
            }
            catch (Exception E)
            {
                result.Proceder = false;
                result.Sms = E.Message;
                result.Valor = null;
            }
            return result;
        }
    }

    public class ClsCargoDA
    {
        private SqlDataReader dr = null;
        public struct Parametros_SQL
        {
            public const string nombre_error = "@NOMBRE_ERROR";
            public const string ide = "@IDE";
            public const string codigo = "@CODIGO";
            public const string nombre = "@NOMBRE";
            public const string codigo_sunat = "@CODIGO_SUNAT";
            public const string nombre_sunat = "@NOMBRE_SUNAT";
            public const string estado = "@ESTADO";
            public const string inactiva = "@INACTIVA";
            public const string veces = "@VECES";
            public const string usuario = "@USUARIO";
        }

        public static ENResultOperation Crear(ClsCargoBE Datos)
        {
            SqlCommand CMD = new SqlCommand("PA_CARGO_INSERTA");
            CMD.Parameters.Add(Parametros_SQL.nombre_error, SqlDbType.VarChar,100).Value = "";
            CMD.Parameters.Add(Parametros_SQL.codigo, SqlDbType.Int).Value = Datos.Carg_ide;
            CMD.Parameters.Add(Parametros_SQL.nombre, SqlDbType.VarChar).Value = Datos.Carg_nombre;
            CMD.Parameters.Add(Parametros_SQL.codigo_sunat, SqlDbType.VarChar).Value = Datos.Carg_codigo_sunat;
            CMD.Parameters.Add(Parametros_SQL.nombre_sunat, SqlDbType.VarChar).Value = Datos.Carg_nombre_sunat;
            CMD.Parameters.Add(Parametros_SQL.estado, SqlDbType.VarChar).Value = Datos.Carg_estado;
            CMD.Parameters.Add(Parametros_SQL.inactiva, SqlDbType.DateTime).Value = Datos.Carg_fechainac;
            CMD.Parameters.Add(Parametros_SQL.veces, SqlDbType.Int).Value = Datos.Veces;
            CMD.Parameters.Add(Parametros_SQL.usuario, SqlDbType.VarChar).Value = Datos.Usuario;

            CMD.Parameters.Add("@RETURN", SqlDbType.Int).Value = DBNull.Value;
            CMD.Parameters["@RETURN"].Direction = ParameterDirection.ReturnValue;
            CMD.Parameters["@NOMBRE_ERROR"].Direction = ParameterDirection.Output;
            return CargoDA.Acceder(CMD);

        }

        public static ENResultOperation Actualizar(ClsCargoBE Datos)
        {
            SqlCommand CMD = new SqlCommand("PA_CARGO_MODIFICA");
            CMD.Parameters.Add(Parametros_SQL.nombre_error, SqlDbType.VarChar,100).Value = "";
            CMD.Parameters.Add(Parametros_SQL.ide, SqlDbType.Int).Value = Datos.Carg_ide;
            CMD.Parameters.Add(Parametros_SQL.nombre, SqlDbType.VarChar).Value = Datos.Carg_nombre;
            CMD.Parameters.Add(Parametros_SQL.codigo_sunat, SqlDbType.VarChar).Value = Datos.Carg_codigo_sunat;
            CMD.Parameters.Add(Parametros_SQL.nombre_sunat, SqlDbType.VarChar).Value = Datos.Carg_nombre_sunat;
            CMD.Parameters.Add(Parametros_SQL.estado, SqlDbType.VarChar).Value = Datos.Carg_estado;
            CMD.Parameters.Add(Parametros_SQL.inactiva, SqlDbType.DateTime).Value = Datos.Carg_fechainac;
            CMD.Parameters.Add(Parametros_SQL.veces, SqlDbType.Int).Value = Datos.Veces;
            CMD.Parameters.Add(Parametros_SQL.usuario, SqlDbType.VarChar).Value = Datos.Usuario;

            CMD.Parameters.Add("@RETURN", SqlDbType.Int).Value = DBNull.Value;
            CMD.Parameters["@RETURN"].Direction = ParameterDirection.ReturnValue;
            CMD.Parameters["@NOMBRE_ERROR"].Direction = ParameterDirection.Output;
            return CargoDA.Acceder(CMD);

        }

        public static ENResultOperation Eliminar(ClsCargoBE Datos)
        {
            SqlCommand CMD = new SqlCommand("PA_CARGO_ELIMINA");
            CMD.Parameters.Add(Parametros_SQL.nombre_error, SqlDbType.VarChar,100).Value = DBNull.Value;
            CMD.Parameters.Add(Parametros_SQL.ide, SqlDbType.Int).Value = Datos.Carg_ide;
            CMD.Parameters.Add(Parametros_SQL.veces, SqlDbType.Int).Value = Datos.Veces;
            CMD.Parameters.Add(Parametros_SQL.usuario, SqlDbType.VarChar).Value = Datos.Usuario;

            CMD.Parameters.Add("@RETURN", SqlDbType.Int).Value = DBNull.Value;
            CMD.Parameters["@RETURN"].Direction = ParameterDirection.ReturnValue;
            CMD.Parameters["@NOMBRE_ERROR"].Direction = ParameterDirection.Output;
            return CargoDA.Acceder(CMD);
        }

        public static ENResultOperation Listar(string Texto_Buscar)
        {
            SqlCommand CMD = new SqlCommand("SELECT * FROM  CARGO WHERE CARG_ESTADO = 'Activo' AND CARG_NOMBRE LIKE '" + Texto_Buscar + "%' ORDER BY CARG_NOMBRE");
            return ProcesarSQLDA.Procesar_SQL(CMD);
            /*
            SqlCommand CMD = new SqlCommand("PA_CARGO_LISTAR");
            CMD.Parameters.Add(Parametros_SQL.nombre_error, SqlDbType.VarChar).Value = Texto_Buscar;
            CMD.Parameters.Add("@RETURN", SqlDbType.Int);
            CMD.Parameters["@RETURN"].Value = DBNull.Value;
            CMD.Parameters["@RETURN"].Direction = ParameterDirection.ReturnValue;
            return CargoDA.Acceder(CMD);
            */
        }

        public static ENResultOperation Listar_Filtro(string Texto_Buscar)
        {
            SqlCommand CMD = new SqlCommand("PA_CARGO_LISTAR_FILTRO");
            CMD.Parameters.Add(Parametros_SQL.nombre_error, SqlDbType.VarChar,100).Value = Texto_Buscar;

            CMD.Parameters.Add("@RETURN", SqlDbType.Int).Value = DBNull.Value;
            CMD.Parameters["@RETURN"].Direction = ParameterDirection.ReturnValue;
            CMD.Parameters["@NOMBRE_ERROR"].Direction = ParameterDirection.Output;
            return CargoDA.Acceder(CMD);
        }
    }
}
