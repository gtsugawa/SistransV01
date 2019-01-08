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
    class Correo_ParametroDA
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

    public class ClsCorreo_ParametroDA
    {
        private SqlDataReader dr = null;
        public struct Parametros_SQL
        {
            public const string nombre_error = "@NOMBRE_ERROR";
            public const string ide = "@IDE";
            public const string cfrom = "@FROM";
            public const string cto   = "@TO";
            public const string csmtp = "@SMTP";
            public const string cusuario = "@USUARIOT";
            public const string cclave = "@CLAVE";
        }

        public static ENResultOperation Crear(ClsCorreo_ParametroBE Datos)
        {
            SqlCommand CMD = new SqlCommand("PA_CORREO_PARAMETRO_INSERTA");
            CMD.Parameters.Add(Parametros_SQL.nombre_error, SqlDbType.VarChar, 100).Value = "";
            CMD.Parameters.Add(Parametros_SQL.ide, SqlDbType.Int).Value = Datos.Empre_ide;
            CMD.Parameters.Add(Parametros_SQL.cfrom, SqlDbType.VarChar).Value = Datos.Empre_correo_from;
            CMD.Parameters.Add(Parametros_SQL.cto, SqlDbType.VarChar).Value = Datos.Empre_correo_to;
            CMD.Parameters.Add(Parametros_SQL.csmtp, SqlDbType.VarChar).Value = Datos.Empre_smtp;
            CMD.Parameters.Add(Parametros_SQL.cusuario, SqlDbType.VarChar).Value = Datos.Empre_usuario;
            CMD.Parameters.Add(Parametros_SQL.cclave, SqlDbType.DateTime).Value = Datos.Empre_clave;

            CMD.Parameters.Add("@RETURN", SqlDbType.Int).Value = DBNull.Value;
            CMD.Parameters["@RETURN"].Direction = ParameterDirection.ReturnValue;
            CMD.Parameters["@NOMBRE_ERROR"].Direction = ParameterDirection.Output;
            return Correo_ParametroDA.Acceder(CMD);

        }

        public static ENResultOperation Actualizar(ClsCorreo_ParametroBE Datos)
        {
            SqlCommand CMD = new SqlCommand("PA_CORREO_PARAMETRO_MODIFICA");
            CMD.Parameters.Add(Parametros_SQL.nombre_error, SqlDbType.VarChar, 100).Value = "";
            CMD.Parameters.Add(Parametros_SQL.ide, SqlDbType.Int).Value = Datos.Empre_ide;
            CMD.Parameters.Add(Parametros_SQL.cfrom, SqlDbType.VarChar).Value = Datos.Empre_correo_from;
            CMD.Parameters.Add(Parametros_SQL.cto, SqlDbType.VarChar).Value = Datos.Empre_correo_to;
            CMD.Parameters.Add(Parametros_SQL.csmtp, SqlDbType.VarChar).Value = Datos.Empre_smtp;
            CMD.Parameters.Add(Parametros_SQL.cusuario, SqlDbType.VarChar).Value = Datos.Empre_usuario;
            CMD.Parameters.Add(Parametros_SQL.cclave, SqlDbType.DateTime).Value = Datos.Empre_clave;

            CMD.Parameters.Add("@RETURN", SqlDbType.Int).Value = DBNull.Value;
            CMD.Parameters["@RETURN"].Direction = ParameterDirection.ReturnValue;
            CMD.Parameters["@NOMBRE_ERROR"].Direction = ParameterDirection.Output;
            return Correo_ParametroDA.Acceder(CMD);

        }

        public static ENResultOperation Eliminar(ClsCorreo_ParametroBE Datos)
        {
            SqlCommand CMD = new SqlCommand("PA_CORREO_PARAMETRO_ELIMINA");
            CMD.Parameters.Add(Parametros_SQL.nombre_error, SqlDbType.VarChar, 100).Value = DBNull.Value;
            CMD.Parameters.Add(Parametros_SQL.ide, SqlDbType.Int).Value = Datos.Empre_ide;

            CMD.Parameters.Add("@RETURN", SqlDbType.Int).Value = DBNull.Value;
            CMD.Parameters["@RETURN"].Direction = ParameterDirection.ReturnValue;
            CMD.Parameters["@NOMBRE_ERROR"].Direction = ParameterDirection.Output;
            return Correo_ParametroDA.Acceder(CMD);
        }

        public static ENResultOperation Listar(string Texto_Buscar)
        {
            SqlCommand CMD = new SqlCommand("SELECT * FROM  CORREO_PARAMETRO");
            return ProcesarSQLDA.Procesar_SQL(CMD);
        }

        public static ENResultOperation Listar_Filtro(string Texto_Buscar)
        {
            SqlCommand CMD = new SqlCommand("PA_CORREO_PARAMETRO_FILTRO");
            CMD.Parameters.Add(Parametros_SQL.nombre_error, SqlDbType.VarChar, 100).Value = Texto_Buscar;

            CMD.Parameters.Add("@RETURN", SqlDbType.Int).Value = DBNull.Value;
            CMD.Parameters["@RETURN"].Direction = ParameterDirection.ReturnValue;
            CMD.Parameters["@NOMBRE_ERROR"].Direction = ParameterDirection.Output;
            return Correo_ParametroDA.Acceder(CMD);
        }
    }
}
