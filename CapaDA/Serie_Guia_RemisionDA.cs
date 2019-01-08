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
    class Serie_Guia_RemisionDA
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

    public class ClsSerie_Guia_RemisionDA
    {
        private SqlDataReader dr = null;
        public struct Parametros_SQL
        {
            public const string nombre_error = "@NOMBRE_ERROR";
            public const string numero = "@NUMERO";
            public const string contador = "@CONTADOR";
            public const string numero_lineas = "@NUMERO_LINEAS";
            public const string lugar = "@LUGAR";
            public const string terminal = "@TERMINAL";
            public const string tienda = "@TIENDA";
            public const string estado = "@ESTADO";
            public const string inactiva = "@INACTIVA";
            public const string veces = "@VECES";
            public const string usuario = "@USUARIO";
            public const string numero_anterior = "@NUMERO_ANTERIOR";
        }

        public static ENResultOperation Crear(ClsSerie_Guia_RemisionBE Datos)
        {
            SqlCommand CMD = new SqlCommand("PA_SERIE_GUIA_REMISION_INSERTA");
            CMD.Parameters.Add(Parametros_SQL.nombre_error, SqlDbType.VarChar).Value = "";
            CMD.Parameters.Add(Parametros_SQL.numero, SqlDbType.VarChar).Value = Datos.Serie_numero;
            CMD.Parameters.Add(Parametros_SQL.contador, SqlDbType.Int).Value = Datos.Serie_contador;
            CMD.Parameters.Add(Parametros_SQL.numero_lineas, SqlDbType.Int).Value = Datos.Serie_numero_lineas;
            CMD.Parameters.Add(Parametros_SQL.lugar, SqlDbType.VarChar).Value = Datos.Serie_nombre_lugar;
            CMD.Parameters.Add(Parametros_SQL.terminal, SqlDbType.VarChar).Value = Datos.Serie_terminal_formato;
            CMD.Parameters.Add(Parametros_SQL.tienda, SqlDbType.Int).Value = Datos.Tienda_ide;
            CMD.Parameters.Add(Parametros_SQL.estado, SqlDbType.VarChar).Value = Datos.Serie_estado;
            CMD.Parameters.Add(Parametros_SQL.inactiva, SqlDbType.DateTime).Value = Datos.Serie_fechainac;
            CMD.Parameters.Add(Parametros_SQL.veces, SqlDbType.Int).Value = Datos.Veces;
            CMD.Parameters.Add(Parametros_SQL.usuario, SqlDbType.VarChar).Value = Datos.Usuario;

            CMD.Parameters.Add("@RETURN", SqlDbType.Int);
            CMD.Parameters["@RETURN"].Value = DBNull.Value;
            CMD.Parameters["@RETURN"].Direction = ParameterDirection.ReturnValue;

            return Serie_Guia_RemisionDA.Acceder(CMD);

        }

        public static ENResultOperation Actualizar(ClsSerie_Guia_RemisionBE Datos)
        {
            SqlCommand CMD = new SqlCommand("PA_SERIE_GUIA_REMISION_MODIFICA");
            CMD.Parameters.Add(Parametros_SQL.nombre_error, SqlDbType.VarChar).Value = "";
            CMD.Parameters.Add(Parametros_SQL.numero, SqlDbType.VarChar).Value = Datos.Serie_numero;
            CMD.Parameters.Add(Parametros_SQL.contador, SqlDbType.Int).Value = Datos.Serie_contador;
            CMD.Parameters.Add(Parametros_SQL.numero_lineas, SqlDbType.Int).Value = Datos.Serie_numero_lineas;
            CMD.Parameters.Add(Parametros_SQL.lugar, SqlDbType.VarChar).Value = Datos.Serie_nombre_lugar;
            CMD.Parameters.Add(Parametros_SQL.terminal, SqlDbType.VarChar).Value = Datos.Serie_terminal_formato;
            CMD.Parameters.Add(Parametros_SQL.tienda, SqlDbType.Int).Value = Datos.Tienda_ide;
            CMD.Parameters.Add(Parametros_SQL.estado, SqlDbType.VarChar).Value = Datos.Serie_estado;
            CMD.Parameters.Add(Parametros_SQL.inactiva, SqlDbType.DateTime).Value = Datos.Serie_fechainac;
            CMD.Parameters.Add(Parametros_SQL.veces, SqlDbType.Int).Value = Datos.Veces;
            CMD.Parameters.Add(Parametros_SQL.usuario, SqlDbType.VarChar).Value = Datos.Usuario;
            CMD.Parameters.Add(Parametros_SQL.numero_anterior, SqlDbType.VarChar).Value = Datos.Serie_anterior;

            CMD.Parameters.Add("@RETURN", SqlDbType.Int);
            CMD.Parameters["@RETURN"].Value = DBNull.Value;
            CMD.Parameters["@RETURN"].Direction = ParameterDirection.ReturnValue;

            return Serie_Guia_RemisionDA.Acceder(CMD);

        }

        public static ENResultOperation Eliminar(ClsSerie_Guia_RemisionBE Datos)
        {
            SqlCommand CMD = new SqlCommand("PA_SERIE_GUIA_REMISION_ELIMINA");
            CMD.Parameters.Add(Parametros_SQL.nombre_error, SqlDbType.VarChar).Value = DBNull.Value;
            CMD.Parameters.Add(Parametros_SQL.numero, SqlDbType.VarChar).Value = Datos.Serie_numero;
            CMD.Parameters.Add(Parametros_SQL.veces, SqlDbType.Int).Value = Datos.Veces;
            CMD.Parameters.Add(Parametros_SQL.usuario, SqlDbType.VarChar).Value = Datos.Usuario;

            CMD.Parameters.Add("@RETURN", SqlDbType.Int);
            CMD.Parameters["@RETURN"].Value = DBNull.Value;
            CMD.Parameters["@RETURN"].Direction = ParameterDirection.ReturnValue;


            return Serie_Guia_RemisionDA.Acceder(CMD);
        }

        public static ENResultOperation Listar(string Texto_Buscar)
        {
            SqlCommand CMD = new SqlCommand("SELECT * FROM SERIE_GUIA_REMISION WHERE SERIE_NUMERO LIKE '" +
                   Texto_Buscar + "%'");
            return ProcesarSQLDA.Procesar_SQL(CMD);
            /*
            SqlCommand CMD = new SqlCommand("PA_SERIE_GUIA_REMISION_LISTAR");
            CMD.Parameters.Add(Parametros_SQL.nombre_error, SqlDbType.VarChar).Value = Texto_Buscar;
            CMD.Parameters.Add("@RETURN", SqlDbType.Int);
            CMD.Parameters["@RETURN"].Value = DBNull.Value;
            CMD.Parameters["@RETURN"].Direction = ParameterDirection.ReturnValue;
            return Serie_Guia_RemisionDA.Acceder(CMD);
            */
        }

        public static ENResultOperation Listar_Filtro(string Texto_Buscar)
        {
            SqlCommand CMD = new SqlCommand("PA_SERIE_GUIA_REMISION_LISTAR_FILTRO");
            CMD.Parameters.Add(Parametros_SQL.nombre_error, SqlDbType.VarChar).Value = Texto_Buscar;

            CMD.Parameters.Add("@RETURN", SqlDbType.Int);
            CMD.Parameters["@RETURN"].Value = DBNull.Value;
            CMD.Parameters["@RETURN"].Direction = ParameterDirection.ReturnValue;

            return Serie_Guia_RemisionDA.Acceder(CMD);
        }
    }
}
