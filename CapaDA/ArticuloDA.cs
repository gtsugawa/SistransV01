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
    class ArticuloDA
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

        public static ENResultOperation Procesar_SQL(SqlCommand cmd)
        {
            ENResultOperation result = new ENResultOperation();
            cmd.Connection = CN;
            DataTable temp = new DataTable();
            try
            {
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DA.Fill(temp);
                result.Proceder = true;
                result.Sms = "Correcto";
                result.Valor = temp;
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

    public class ClsArticuloDA
    {
        private SqlDataReader dr = null;
        public struct Parametros_SQL
        {
            public const string nombre_error = "@NOMBRE_ERROR";
            public const string ide = "@IDE";
            public const string codigo = "@CODIGO";
            public const string nombre = "@NOMBRE";
            public const string tipo = "@TIPO";
            public const string modelo = "@MODELO";
            public const string estado = "@ESTADO";
            public const string inactiva = "@INACTIVA";
            public const string veces = "@VECES";
            public const string usuario = "@USUARIO";
        }

        public static ENResultOperation Crear(ClsArticuloBE Datos)
        {
            SqlCommand CMD = new SqlCommand("PA_ARTICULO_INSERTA");
            CMD.Parameters.Add(Parametros_SQL.nombre_error, SqlDbType.VarChar,100).Value = "";
            CMD.Parameters.Add(Parametros_SQL.tipo, SqlDbType.VarChar).Value = Datos.Arti_tipo;
            CMD.Parameters.Add(Parametros_SQL.nombre, SqlDbType.VarChar).Value = Datos.Arti_nombre ;
            CMD.Parameters.Add(Parametros_SQL.modelo, SqlDbType.VarChar).Value = Datos.Arti_modelo;
            CMD.Parameters.Add(Parametros_SQL.codigo, SqlDbType.VarChar).Value = Datos.Arti_codigo;
            CMD.Parameters.Add(Parametros_SQL.estado, SqlDbType.VarChar).Value = Datos.Arti_estado;
            CMD.Parameters.Add(Parametros_SQL.inactiva, SqlDbType.DateTime).Value = Datos.Arti_fechainac;
            CMD.Parameters.Add(Parametros_SQL.ide, SqlDbType.Int).Value = Datos.Arti_ide;

            CMD.Parameters.Add("@RETURN", SqlDbType.Int).Value = DBNull.Value;
            CMD.Parameters["@RETURN"].Direction = ParameterDirection.ReturnValue;
            CMD.Parameters["@NOMBRE_ERROR"].Direction = ParameterDirection.Output;
            return ArticuloDA.Acceder(CMD);

        }

        public static ENResultOperation Actualizar(ClsArticuloBE Datos)
        {
            SqlCommand CMD = new SqlCommand("PA_ARTICULO_MODIFICA");
            CMD.Parameters.Add(Parametros_SQL.nombre_error, SqlDbType.VarChar,100).Value = "";
            CMD.Parameters.Add(Parametros_SQL.tipo, SqlDbType.VarChar).Value = Datos.Arti_tipo;
            CMD.Parameters.Add(Parametros_SQL.nombre, SqlDbType.VarChar).Value = Datos.Arti_nombre;
            CMD.Parameters.Add(Parametros_SQL.modelo, SqlDbType.VarChar).Value = Datos.Arti_modelo;
            CMD.Parameters.Add(Parametros_SQL.codigo, SqlDbType.VarChar).Value = Datos.Arti_codigo;
            CMD.Parameters.Add(Parametros_SQL.estado, SqlDbType.VarChar).Value = Datos.Arti_estado;
            CMD.Parameters.Add(Parametros_SQL.inactiva, SqlDbType.DateTime).Value = Datos.Arti_fechainac;
            CMD.Parameters.Add(Parametros_SQL.ide, SqlDbType.Int).Value = Datos.Arti_ide;

            CMD.Parameters.Add("@RETURN", SqlDbType.Int).Value = DBNull.Value;
            CMD.Parameters["@RETURN"].Direction = ParameterDirection.ReturnValue;
            CMD.Parameters["@NOMBRE_ERROR"].Direction = ParameterDirection.Output;
            return ArticuloDA.Acceder(CMD);

        }

        public static ENResultOperation Eliminar(ClsArticuloBE Datos)
        {
            SqlCommand CMD = new SqlCommand("PA_ARTICULO_ELIMINA");
            CMD.Parameters.Add(Parametros_SQL.nombre_error, SqlDbType.VarChar,100).Value = DBNull.Value;
            CMD.Parameters.Add(Parametros_SQL.ide, SqlDbType.Int).Value = Datos.Arti_ide;
            CMD.Parameters.Add(Parametros_SQL.veces, SqlDbType.Int).Value = 0;
            CMD.Parameters.Add(Parametros_SQL.usuario, SqlDbType.VarChar).Value = Datos.Usuario;

            CMD.Parameters.Add("@RETURN", SqlDbType.Int).Value = DBNull.Value;
            CMD.Parameters["@RETURN"].Direction = ParameterDirection.ReturnValue;
            CMD.Parameters["@NOMBRE_ERROR"].Direction = ParameterDirection.Output;
            return ArticuloDA.Acceder(CMD);
        }

        public static ENResultOperation Listar(string Texto_Buscar)
        {
            SqlCommand CMD = new SqlCommand("SELECT * FROM ARTICULO WHERE ARTI_ESTADO = 'Activo' AND ARTI_NOMBRE LIKE '" +
                                             Texto_Buscar + "%'");
            return ArticuloDA.Procesar_SQL(CMD);
            /*
            SqlCommand CMD = new SqlCommand("PA_ARTICULO_LISTAR");
            CMD.Parameters.Add(Parametros_SQL.nombre_error, SqlDbType.VarChar).Value = Texto_Buscar;
            CMD.Parameters.Add("@RETURN", SqlDbType.Int);
            CMD.Parameters["@RETURN"].Value = DBNull.Value;
            CMD.Parameters["@RETURN"].Direction = ParameterDirection.ReturnValue;
            return ArticuloDA.Acceder(CMD);
            */
        }

        public static ENResultOperation Listar_Filtro(string Texto_Buscar)
        {
            SqlCommand CMD = new SqlCommand("PA_ARTICULO_LISTAR_FILTRO");
            CMD.Parameters.Add(Parametros_SQL.nombre_error, SqlDbType.VarChar,100).Value = DBNull.Value;
            CMD.Parameters.Add(Parametros_SQL.nombre, SqlDbType.VarChar).Value = Texto_Buscar;

            CMD.Parameters.Add("@RETURN", SqlDbType.Int).Value = DBNull.Value;
            CMD.Parameters["@RETURN"].Direction = ParameterDirection.ReturnValue;
            CMD.Parameters["@NOMBRE_ERROR"].Direction = ParameterDirection.Output;
            return ArticuloDA.Acceder(CMD);
        }
    }
}
