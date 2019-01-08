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
    class Serie_FacturacionDA
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

    public class ClsSerie_FacturacionDA
    {
        private SqlDataReader dr = null;
        public struct Parametros_SQL
        {
            public const string nombre_error = "@NOMBRE_ERROR"; // VARCHAR(100) OUTPUT,
            public const string numero = "@NUMERO"; //  VARCHAR(4),
            public const string factura_contador = "@FACTURA_CONTADOR"; //  INT,
            public const string factura_numero_lineas = "@FACTURA_NUMERO_LINEAS"; //  INT,
            public const string n_debito_contador = "@N_DEBITO_CONTADOR"; //  INT,
            public const string n_debito_numero_lineas = "@N_DEBITO_NUMERO_LINEAS"; //  INT,
            public const string n_credito_contador = "@N_CREDITO_CONTADOR"; //  INT,
            public const string n_credito_numero_lineas = "@N_CREDITO_NUMERO_LINEAS"; //  INT,
            public const string boleta_contador = "@BOLETA_CONTADOR"; //  INT,
            public const string boleta_numero_lineas = "@BOLETA_NUMERO_LINEAS"; //  INT,
            public const string atribucion_contador = "@ATRIBUCION_CONTADOR"; //  INT,
            public const string atribucion_numero_lineas = "@ATRIBUCION_NUMERO_LINEAS"; //  INT,
            public const string lugar = "@LUGAR"; //  VARCHAR(50),
            public const string terminal = "@TERMINAL"; //  VARCHAR(10),
            public const string tienda = "@TIENDA"; //  INT,
            public const string estado = "@ESTADO"; //  varchar(8),
            public const string inactiva = "@INACTIVA"; //  datetime,
            public const string veces = "@VECES"; //  integer,
            public const string usuario = "@USUARIO"; //  CHAR(15)
            public const string numero_anterior = "@NUMERO_ANTERIOR"; //  CHAR(4)
        }

        public static ENResultOperation Crear(ClsSerie_FacturacionBE Datos)
        {
            SqlCommand CMD = new SqlCommand("PA_SERIE_FACTURACION_INSERTA");
            CMD.Parameters.Add(Parametros_SQL.nombre_error, SqlDbType.VarChar).Value = "";
            CMD.Parameters.Add(Parametros_SQL.numero, SqlDbType.VarChar).Value = Datos.Serie_numero;
            CMD.Parameters.Add(Parametros_SQL.factura_contador, SqlDbType.Int).Value = Datos.Serie_factura_contador;
            CMD.Parameters.Add(Parametros_SQL.factura_numero_lineas, SqlDbType.Int).Value = Datos.Serie_factura_numero_lineas;
            CMD.Parameters.Add(Parametros_SQL.n_debito_contador, SqlDbType.Int).Value = Datos.Serie_n_debito_contador;
            CMD.Parameters.Add(Parametros_SQL.n_debito_numero_lineas, SqlDbType.Int).Value = Datos.Serie_n_debito_numero_lineas;
            CMD.Parameters.Add(Parametros_SQL.n_credito_contador, SqlDbType.Int).Value = Datos.Serie_n_credito_contador;
            CMD.Parameters.Add(Parametros_SQL.n_credito_numero_lineas, SqlDbType.Int).Value = Datos.Serie_n_credito_numero_lineas;
            CMD.Parameters.Add(Parametros_SQL.boleta_contador, SqlDbType.Int).Value = Datos.Serie_boleta_contador;
            CMD.Parameters.Add(Parametros_SQL.boleta_numero_lineas, SqlDbType.Int).Value = Datos.Serie_boleta_numero_lineas;
            CMD.Parameters.Add(Parametros_SQL.atribucion_contador, SqlDbType.Int).Value = Datos.Serie_doc_atribucion_contador;
            CMD.Parameters.Add(Parametros_SQL.atribucion_numero_lineas, SqlDbType.Int).Value = Datos.Serie_doc_atribucion_numero_lineas;
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

            return Serie_FacturacionDA.Acceder(CMD);

        }

        public static ENResultOperation Actualizar(ClsSerie_FacturacionBE Datos)
        {
            SqlCommand CMD = new SqlCommand("PA_SERIE_FACTURACION_MODIFICA");
            CMD.Parameters.Add(Parametros_SQL.nombre_error, SqlDbType.VarChar).Value = "";
            CMD.Parameters.Add(Parametros_SQL.numero, SqlDbType.VarChar).Value = Datos.Serie_numero;
            CMD.Parameters.Add(Parametros_SQL.factura_contador, SqlDbType.Int).Value = Datos.Serie_factura_contador;
            CMD.Parameters.Add(Parametros_SQL.factura_numero_lineas, SqlDbType.Int).Value = Datos.Serie_factura_numero_lineas;
            CMD.Parameters.Add(Parametros_SQL.n_debito_contador, SqlDbType.Int).Value = Datos.Serie_n_debito_contador;
            CMD.Parameters.Add(Parametros_SQL.n_debito_numero_lineas, SqlDbType.Int).Value = Datos.Serie_n_debito_numero_lineas;
            CMD.Parameters.Add(Parametros_SQL.n_credito_contador, SqlDbType.Int).Value = Datos.Serie_n_credito_contador;
            CMD.Parameters.Add(Parametros_SQL.n_credito_numero_lineas, SqlDbType.Int).Value = Datos.Serie_n_credito_numero_lineas;
            CMD.Parameters.Add(Parametros_SQL.boleta_contador, SqlDbType.Int).Value = Datos.Serie_boleta_contador;
            CMD.Parameters.Add(Parametros_SQL.boleta_numero_lineas, SqlDbType.Int).Value = Datos.Serie_boleta_numero_lineas;
            CMD.Parameters.Add(Parametros_SQL.atribucion_contador, SqlDbType.Int).Value = Datos.Serie_doc_atribucion_contador;
            CMD.Parameters.Add(Parametros_SQL.atribucion_numero_lineas, SqlDbType.Int).Value = Datos.Serie_doc_atribucion_numero_lineas;
            CMD.Parameters.Add(Parametros_SQL.lugar, SqlDbType.VarChar).Value = Datos.Serie_nombre_lugar;
            CMD.Parameters.Add(Parametros_SQL.terminal, SqlDbType.VarChar).Value = Datos.Serie_terminal_formato;
            CMD.Parameters.Add(Parametros_SQL.tienda, SqlDbType.Int).Value = Datos.Tienda_ide;
            CMD.Parameters.Add(Parametros_SQL.estado, SqlDbType.VarChar).Value = Datos.Serie_estado;
            CMD.Parameters.Add(Parametros_SQL.inactiva, SqlDbType.DateTime).Value = Datos.Serie_fechainac;
            CMD.Parameters.Add(Parametros_SQL.veces, SqlDbType.Int).Value = Datos.Veces;
            CMD.Parameters.Add(Parametros_SQL.usuario, SqlDbType.VarChar).Value = Datos.Usuario;
            CMD.Parameters.Add(Parametros_SQL.numero_anterior, SqlDbType.VarChar).Value = Datos.Serie_numero_anterior;

            CMD.Parameters.Add("@RETURN", SqlDbType.Int);
            CMD.Parameters["@RETURN"].Value = DBNull.Value;
            CMD.Parameters["@RETURN"].Direction = ParameterDirection.ReturnValue;

            return Serie_FacturacionDA.Acceder(CMD);

        }

        public static ENResultOperation Eliminar(ClsSerie_FacturacionBE Datos)
        {
            
            SqlCommand CMD = new SqlCommand("DELETE SERIE_FACTURACION WHERE SERIE_NUMERO = '" + Datos.Serie_numero + "'");
            return ProcesarSQLDA.Procesar_SQL(CMD);
            /*
            SqlCommand CMD = new SqlCommand("PA_SERIE_FACTURACION_ELIMINA");
            CMD.Parameters.Add(Parametros_SQL.nombre_error, SqlDbType.VarChar).Value = DBNull.Value;
            CMD.Parameters.Add(Parametros_SQL.numero, SqlDbType.Int).Value = Datos.Serie_numero;
            CMD.Parameters.Add(Parametros_SQL.veces, SqlDbType.Int).Value = Datos.Veces;
            CMD.Parameters.Add(Parametros_SQL.usuario, SqlDbType.VarChar).Value = Datos.Usuario;

            CMD.Parameters.Add("@RETURN", SqlDbType.Int);
            CMD.Parameters["@RETURN"].Value = DBNull.Value;
            CMD.Parameters["@RETURN"].Direction = ParameterDirection.ReturnValue;
            return Serie_FacturacionDA.Acceder(CMD);
            */
        }

        public static ENResultOperation Listar(string Texto_Buscar)
        {
            SqlCommand CMD = new SqlCommand("SELECT * FROM SERIE_FACTURACION WHERE SERIE_NUMERO LIKE '" +
                   Texto_Buscar + "%'");
            return ProcesarSQLDA.Procesar_SQL(CMD);
        
        }

        public static ENResultOperation Listar_Filtro(string Texto_Buscar)
        {
            SqlCommand CMD = new SqlCommand("SELECT * FROM SERIE_FACTURACION WHERE SERIE_NUMERO = @SERIE ");

            CMD.Parameters.AddWithValue("@SERIE", Texto_Buscar);
            return ProcesarSQLDA.Procesar_SQL(CMD);
        }
    }
}
