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
    class Actividad_ClienteDA
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
    public class ClsActividad_ClienteDA
    {
        public struct Parametros_SQL
        {
            public const string nombre_error = "@NOMBRE_ERROR";
            public const string codigo = "@CODIGO"; // INT OUTPUT,
            public const string ide = "@IDE"; // INT OUTPUT,
            public const string nombre = "@NOMBRE"; // VARCHAR(20),
            public const string estado = "@ESTADO"; // varchar(8),
            public const string inactiva = "@INACTIVA"; // datetime,
            public const string veces = "@VECES"; // integer,
            public const string usuario = "@USUARIO"; // CHAR(15)

        }

        public static ENResultOperation Crear(ClsActividad_ClienteBE Datos)
        {
            SqlCommand CMD = new SqlCommand("PA_ACTIVIDAD_CLIENTE_INSERTA");
            CMD.Parameters.Add(Parametros_SQL.nombre_error, SqlDbType.VarChar,100).Value = "";
            CMD.Parameters.Add(Parametros_SQL.ide, SqlDbType.Int).Value = Datos.Acti_clie_ide;
            CMD.Parameters.Add(Parametros_SQL.codigo, SqlDbType.VarChar).Value = Datos.Acti_clie_codigo;
            CMD.Parameters.Add(Parametros_SQL.nombre, SqlDbType.VarChar).Value = Datos.Acti_clie_nombre;
            CMD.Parameters.Add(Parametros_SQL.estado, SqlDbType.VarChar).Value = Datos.Acti_clie_estado;
            CMD.Parameters.Add(Parametros_SQL.inactiva, SqlDbType.DateTime).Value = Datos.Acti_clie_fechainac;
            CMD.Parameters.Add(Parametros_SQL.veces, SqlDbType.Int).Value = Datos.Veces;
            CMD.Parameters.Add(Parametros_SQL.usuario, SqlDbType.VarChar).Value = Datos.Usuario;

            CMD.Parameters.Add("@RETURN", SqlDbType.Int).Value = DBNull.Value;
            CMD.Parameters["@RETURN"].Direction = ParameterDirection.ReturnValue;
            CMD.Parameters["@NOMBRE_ERROR"].Direction = ParameterDirection.Output;
            return Actividad_ClienteDA.Acceder(CMD);
        }

        public static ENResultOperation Actualizar(ClsActividad_ClienteBE Datos)
        {
            SqlCommand CMD = new SqlCommand("PA_ACTIVIDAD_CLIENTE_MODIFICA");
            CMD.Parameters.Add(Parametros_SQL.nombre_error, SqlDbType.VarChar,100).Value = "";
            CMD.Parameters.Add(Parametros_SQL.ide, SqlDbType.Int).Value = Datos.Acti_clie_ide;
            CMD.Parameters.Add(Parametros_SQL.codigo, SqlDbType.VarChar).Value = Datos.Acti_clie_codigo;
            CMD.Parameters.Add(Parametros_SQL.nombre, SqlDbType.VarChar).Value = Datos.Acti_clie_nombre;
            CMD.Parameters.Add(Parametros_SQL.estado, SqlDbType.VarChar).Value = Datos.Acti_clie_estado;
            CMD.Parameters.Add(Parametros_SQL.inactiva, SqlDbType.DateTime).Value = Datos.Acti_clie_fechainac;
            CMD.Parameters.Add(Parametros_SQL.veces, SqlDbType.Int).Value = Datos.Veces;
            CMD.Parameters.Add(Parametros_SQL.usuario, SqlDbType.VarChar).Value = Datos.Usuario;

            CMD.Parameters.Add("@RETURN", SqlDbType.Int).Value = DBNull.Value;
            CMD.Parameters["@RETURN"].Direction = ParameterDirection.ReturnValue;
            CMD.Parameters["@NOMBRE_ERROR"].Direction = ParameterDirection.Output;
            return Actividad_ClienteDA.Acceder(CMD);
        }

        public static ENResultOperation Eliminar(ClsActividad_ClienteBE Datos)
        {
            SqlCommand CMD = new SqlCommand("PA_ACTIVIDAD_CLIENTE_ELIMINA");
            CMD.Parameters.Add(Parametros_SQL.nombre_error, SqlDbType.VarChar,100).Value = "";
            CMD.Parameters.Add(Parametros_SQL.ide, SqlDbType.Int).Value = Datos.Acti_clie_ide;
            CMD.Parameters.Add(Parametros_SQL.veces, SqlDbType.Int).Value = Datos.Veces;
            CMD.Parameters.Add(Parametros_SQL.usuario, SqlDbType.VarChar).Value = Datos.Usuario;

            CMD.Parameters.Add("@RETURN", SqlDbType.Int).Value = DBNull.Value;
            CMD.Parameters["@RETURN"].Direction = ParameterDirection.ReturnValue;
            CMD.Parameters["@NOMBRE_ERROR"].Direction = ParameterDirection.Output;
            return Actividad_ClienteDA.Acceder(CMD);
        }

        public static ENResultOperation Listar(string Texto_Buscar)
        {

            SqlCommand CMD = new SqlCommand("SELECT * FROM ACTIVIDAD_CLIENTE WHERE ACTI_CLIE_ESTADO = 'Activo' AND  ACTI_CLIE_NOMBRE LIKE '" +
                                             Texto_Buscar + "%'");
            return Actividad_ClienteDA.Procesar_SQL(CMD);
            /*
            SqlCommand CMD = new SqlCommand("PA_ACTIVIDAD_CLIENTE_LISTAR");
            CMD.Parameters.Add(Parametros_SQL.nombre_error, SqlDbType.VarChar).Value = Texto_Buscar;

            return Actividad_ClienteDA.Acceder(CMD);
            */
        }

        public static ENResultOperation Listar_Filtro(string Texto_Buscar)
        {
            SqlCommand CMD = new SqlCommand("PA_ACTIVIDAD_CLIENTE_LISTAR_FILTRO");
            CMD.Parameters.Add(Parametros_SQL.nombre_error, SqlDbType.VarChar).Value = Texto_Buscar;

            CMD.Parameters.Add("@RETURN", SqlDbType.Int).Value = DBNull.Value;
            CMD.Parameters["@RETURN"].Direction = ParameterDirection.ReturnValue;
            CMD.Parameters["@NOMBRE_ERROR"].Direction = ParameterDirection.Output;
            return Actividad_ClienteDA.Acceder(CMD);
        }
    }
}
