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
    class Unidad_MedidaDA
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

    public class ClsUnidad_MedidaDA
    {
        private SqlDataReader dr = null;
        public struct Parametros_SQL
        {
            public const string nombre_error = "@NOMBRE_ERROR";
            public const string ide = "@IDE";
            public const string codigo = "@CODIGO";
            public const string codigo1 = "@CODIGO1";
            public const string nombre = "@NOMBRE";
            public const string abreviado = "@ABREVIADO";
            public const string sunat = "@SUNAT";
            public const string factor = "@FACTOR";
            public const string cantidad = "@CANTIDAD";
            public const string estado = "@ESTADO";
            public const string inactiva = "@INACTIVA";
            public const string veces = "@VECES";
            public const string usuario = "@USUARIO";
        }

        public static ENResultOperation Crear(ClsUnidad_MedidaBE Datos)
        {
            SqlCommand CMD = new SqlCommand("PA_UNIDAD_MEDIDA_INSERTA");
            CMD.Parameters.Add(Parametros_SQL.nombre_error, SqlDbType.VarChar).Value = "";
            CMD.Parameters.Add(Parametros_SQL.codigo, SqlDbType.Int).Value = Datos.Unid_medi_ide;
            CMD.Parameters.Add(Parametros_SQL.codigo1, SqlDbType.VarChar).Value = Datos.Unid_medi_codigo;
            CMD.Parameters.Add(Parametros_SQL.nombre, SqlDbType.VarChar).Value = Datos.Unid_medi_nombre;
            CMD.Parameters.Add(Parametros_SQL.abreviado, SqlDbType.VarChar).Value = Datos.Unid_medi_abreviado;
            CMD.Parameters.Add(Parametros_SQL.sunat, SqlDbType.VarChar).Value = Datos.Unid_medi_codigo_sunat;
            CMD.Parameters.Add(Parametros_SQL.factor, SqlDbType.Decimal).Value = Datos.Unid_medi_factor;
            CMD.Parameters.Add(Parametros_SQL.cantidad, SqlDbType.Decimal).Value = Datos.Unid_medi_cantidad;
            CMD.Parameters.Add(Parametros_SQL.estado, SqlDbType.VarChar).Value = Datos.Unid_medi_estado;
            CMD.Parameters.Add(Parametros_SQL.inactiva, SqlDbType.DateTime).Value = Datos.Unid_medi_fechainac;
            CMD.Parameters.Add(Parametros_SQL.veces, SqlDbType.Int).Value = Datos.Veces;
            CMD.Parameters.Add(Parametros_SQL.usuario, SqlDbType.VarChar).Value = Datos.Usuario;

            CMD.Parameters.Add("@RETURN", SqlDbType.Int);
            CMD.Parameters["@RETURN"].Value = DBNull.Value;
            CMD.Parameters["@RETURN"].Direction = ParameterDirection.ReturnValue;

            return Unidad_MedidaDA.Acceder(CMD);

        }

        public static ENResultOperation Actualizar(ClsUnidad_MedidaBE Datos)
        {
            SqlCommand CMD = new SqlCommand("PA_UNIDAD_MEDIDA_MODIFICA");
            CMD.Parameters.Add(Parametros_SQL.nombre_error, SqlDbType.VarChar).Value = "";
            CMD.Parameters.Add(Parametros_SQL.ide, SqlDbType.Int).Value = Datos.Unid_medi_ide;
            CMD.Parameters.Add(Parametros_SQL.codigo1, SqlDbType.VarChar).Value = Datos.Unid_medi_codigo;
            CMD.Parameters.Add(Parametros_SQL.nombre, SqlDbType.VarChar).Value = Datos.Unid_medi_nombre;
            CMD.Parameters.Add(Parametros_SQL.abreviado, SqlDbType.VarChar).Value = Datos.Unid_medi_abreviado;
            CMD.Parameters.Add(Parametros_SQL.sunat, SqlDbType.VarChar).Value = Datos.Unid_medi_codigo_sunat;
            CMD.Parameters.Add(Parametros_SQL.factor, SqlDbType.Decimal).Value = Datos.Unid_medi_factor;
            CMD.Parameters.Add(Parametros_SQL.cantidad, SqlDbType.Decimal).Value = Datos.Unid_medi_cantidad;
            CMD.Parameters.Add(Parametros_SQL.estado, SqlDbType.VarChar).Value = Datos.Unid_medi_estado;
            CMD.Parameters.Add(Parametros_SQL.inactiva, SqlDbType.DateTime).Value = Datos.Unid_medi_fechainac;
            CMD.Parameters.Add(Parametros_SQL.veces, SqlDbType.Int).Value = Datos.Veces;
            CMD.Parameters.Add(Parametros_SQL.usuario, SqlDbType.VarChar).Value = Datos.Usuario;

            CMD.Parameters.Add("@RETURN", SqlDbType.Int);
            CMD.Parameters["@RETURN"].Value = DBNull.Value;
            CMD.Parameters["@RETURN"].Direction = ParameterDirection.ReturnValue;

            return Unidad_MedidaDA.Acceder(CMD);

        }

        public static ENResultOperation Eliminar(ClsUnidad_MedidaBE Datos)
        {
            SqlCommand CMD = new SqlCommand("PA_UNIDAD_MEDIDA_ELIMINA");
            CMD.Parameters.Add(Parametros_SQL.nombre_error, SqlDbType.VarChar).Value = DBNull.Value;
            CMD.Parameters.Add(Parametros_SQL.ide, SqlDbType.Int).Value = Datos.Unid_medi_ide;
            CMD.Parameters.Add(Parametros_SQL.veces, SqlDbType.Int).Value = Datos.Veces;
            CMD.Parameters.Add(Parametros_SQL.usuario, SqlDbType.VarChar).Value = Datos.Usuario;

            CMD.Parameters.Add("@RETURN", SqlDbType.Int);
            CMD.Parameters["@RETURN"].Value = DBNull.Value;
            CMD.Parameters["@RETURN"].Direction = ParameterDirection.ReturnValue;


            return Unidad_MedidaDA.Acceder(CMD);
        }

        public static ENResultOperation Listar(string Texto_Buscar)
        {
            SqlCommand CMD = new SqlCommand("SELECT * FROM UNIDAD_MEDIDA WHERE UNID_MEDI_ESTADO = 'Activo' AND UNID_MEDI_NOMBRE LIKE '" +
                             Texto_Buscar + "%'");
            return ProcesarSQLDA.Procesar_SQL(CMD);
        }

        public static ENResultOperation ListarTodos(string Texto_Buscar)
        {
            SqlCommand CMD = new SqlCommand("SELECT * FROM UNIDAD_MEDIDA WHERE UNID_MEDI_NOMBRE LIKE '" +
                             Texto_Buscar + "%'");
            return ProcesarSQLDA.Procesar_SQL(CMD);
        }

        public static ENResultOperation Listar_Filtro(string Texto_Buscar)
        {
            SqlCommand CMD = new SqlCommand("PA_UNIDAD_MEDIDA_LISTAR_FILTRO");
            CMD.Parameters.Add(Parametros_SQL.nombre_error, SqlDbType.VarChar).Value = Texto_Buscar;

            CMD.Parameters.Add("@RETURN", SqlDbType.Int);
            CMD.Parameters["@RETURN"].Value = DBNull.Value;
            CMD.Parameters["@RETURN"].Direction = ParameterDirection.ReturnValue;

            return Unidad_MedidaDA.Acceder(CMD);
        }
    }
}
