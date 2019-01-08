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
    class Guia_CabeceraDA
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

    public class ClsGuia_CabeceraDA
    {
        public struct Parametros_SQL
        {
            public const string nombre_error = "@NOMBRE_ERROR";
            public const string serie_guia = "@SERIE_GUIA";  // CHAR(4),
            public const string numero_guia = "@NUMERO_GUIA";  //  INT ,
            public const string recojo_ide = "@RECOJO_IDE";  //  INT,
            public const string fecha_emision = "@FECHA_EMISION";  //  DATETIME,
            public const string fecha_traslado = "@FECHA_TRASLADO";  //  DATETIME,
            public const string veces = "@VECES";  //  integer,
            public const string usuario = "@USUARIO";  //  CHAR(15),
            public const string ide = "@IDE";  //  int output
        }

        public static ENResultOperation Crear(ClsGuia_CabeceraBE Datos)
        {
            SqlCommand CMD = new SqlCommand("PA_GUIA_INSERTA");
            CMD.Parameters.Add(Parametros_SQL.nombre_error, SqlDbType.VarChar).Value = "";
            CMD.Parameters.Add(Parametros_SQL.serie_guia, SqlDbType.VarChar).Value = Datos.Serie_numero_guia;
            CMD.Parameters.Add(Parametros_SQL.numero_guia, SqlDbType.Int).Value = Datos.Guia_numero_guia;
            CMD.Parameters.Add(Parametros_SQL.recojo_ide, SqlDbType.Int).Value = Datos.Reco_ide;
            CMD.Parameters.Add(Parametros_SQL.fecha_emision, SqlDbType.DateTime).Value = Datos.Guia_fecha_emision;
            CMD.Parameters.Add(Parametros_SQL.fecha_traslado, SqlDbType.DateTime).Value = Datos.Guia_fecha_traslado;
            CMD.Parameters.Add(Parametros_SQL.veces, SqlDbType.Int).Value = Datos.Veces;
            CMD.Parameters.Add(Parametros_SQL.usuario, SqlDbType.Char).Value = Datos.Usuario;
            CMD.Parameters.Add(Parametros_SQL.ide, SqlDbType.Int).Value = 0;

            CMD.Parameters.Add("@RETURN", SqlDbType.Int);
            CMD.Parameters["@RETURN"].Value = DBNull.Value;
            CMD.Parameters["@RETURN"].Direction = ParameterDirection.ReturnValue;

            return Guia_CabeceraDA.Acceder(CMD);

        }

        public static ENResultOperation Actualizar(ClsGuia_CabeceraBE Datos)
        {
            SqlCommand CMD = new SqlCommand("PA_GUIA_MODIFICA");
            CMD.Parameters.Add(Parametros_SQL.nombre_error, SqlDbType.VarChar).Value = "";
            CMD.Parameters.Add(Parametros_SQL.serie_guia, SqlDbType.VarChar).Value = Datos.Serie_numero_guia;
            CMD.Parameters.Add(Parametros_SQL.numero_guia, SqlDbType.Int).Value = Datos.Guia_numero_guia;
            CMD.Parameters.Add(Parametros_SQL.recojo_ide, SqlDbType.Int).Value = Datos.Reco_ide;
            CMD.Parameters.Add(Parametros_SQL.fecha_emision, SqlDbType.DateTime).Value = Datos.Guia_fecha_emision;
            CMD.Parameters.Add(Parametros_SQL.fecha_traslado, SqlDbType.DateTime).Value = Datos.Guia_fecha_traslado;
            CMD.Parameters.Add(Parametros_SQL.veces, SqlDbType.Int).Value = Datos.Veces;
            CMD.Parameters.Add(Parametros_SQL.usuario, SqlDbType.Char).Value = Datos.Usuario;
            CMD.Parameters.Add(Parametros_SQL.ide, SqlDbType.Int).Value = 0;

            CMD.Parameters.Add("@RETURN", SqlDbType.Int);
            CMD.Parameters["@RETURN"].Value = DBNull.Value;
            CMD.Parameters["@RETURN"].Direction = ParameterDirection.ReturnValue;

            return Guia_CabeceraDA.Acceder(CMD);

        }

        public static ENResultOperation Eliminar(ClsGuia_CabeceraBE Datos)
        {
            SqlCommand CMD = new SqlCommand("PA_GUIA_ELIMINA");
            CMD.Parameters.Add(Parametros_SQL.nombre_error, SqlDbType.VarChar).Value = DBNull.Value;
            CMD.Parameters.Add(Parametros_SQL.ide, SqlDbType.Int).Value = Datos.Reco_ide;
            CMD.Parameters.Add(Parametros_SQL.veces, SqlDbType.Int).Value = Datos.Veces;
            CMD.Parameters.Add(Parametros_SQL.usuario, SqlDbType.VarChar).Value = Datos.Usuario;

            CMD.Parameters.Add("@RETURN", SqlDbType.Int);
            CMD.Parameters["@RETURN"].Value = DBNull.Value;
            CMD.Parameters["@RETURN"].Direction = ParameterDirection.ReturnValue;


            return Guia_CabeceraDA.Acceder(CMD);
        }

        public static ENResultOperation Listar(string Texto_Buscar)
        {
            SqlCommand CMD = new SqlCommand("PA_GUIA_LISTAR");
            CMD.Parameters.Add(Parametros_SQL.nombre_error, SqlDbType.VarChar).Value = Texto_Buscar;

            CMD.Parameters.Add("@RETURN", SqlDbType.Int);
            CMD.Parameters["@RETURN"].Value = DBNull.Value;
            CMD.Parameters["@RETURN"].Direction = ParameterDirection.ReturnValue;

            return Guia_CabeceraDA.Acceder(CMD);
        }

        public static ENResultOperation Listar_Filtro(string Texto_Buscar)
        {
            SqlCommand CMD = new SqlCommand("PA_GUIA_LISTAR_FILTRO");
            CMD.Parameters.Add(Parametros_SQL.nombre_error, SqlDbType.VarChar).Value = Texto_Buscar;

            CMD.Parameters.Add("@RETURN", SqlDbType.Int);
            CMD.Parameters["@RETURN"].Value = DBNull.Value;
            CMD.Parameters["@RETURN"].Direction = ParameterDirection.ReturnValue;

            return Guia_CabeceraDA.Acceder(CMD);
        }

        public static ENResultOperation Obtener_Registro(Int32  Reco_Ide)
        {
            SqlCommand CMD = new SqlCommand("SELECT * FROM GUIA_CABECERA WHERE Reco_Ide = " + Reco_Ide.ToString());

            return Guia_CabeceraDA.Procesar_SQL(CMD);
        }
    }
}
