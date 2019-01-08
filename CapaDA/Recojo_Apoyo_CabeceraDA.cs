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
    class Recojo_Apoyo_CabeceraDA
    {
        private static SqlConnection CN = new SqlConnection(StrConexion.strcn);
        private SqlDataReader dr = null;
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
    public class ClsRecojo_Apoyo_CabeceraDA
    {
        public struct Parametros_SQL
        {

            public const string nombre_error = "@NOMBRE_ERROR"; // VARCHAR(100) OUTPUT,
            public const string numero = "@NUMERO"; // INT,
            public const string fecha_emision = "@FECHA_EMISION"; //  DATETIME,
            public const string fecha_traslado = "@FECHA_TRASLADO"; //  DATETIME,
            public const string fecha_retorno = "@FECHA_RETORNO"; //  DATETIME,
            public const string transportista = "@TRANSPORTISTA"; //  INT,
            public const string chofer = "@CHOFER"; //  INT,
            public const string vehiculo = "@VEHICULO"; //  INT,
            public const string tonelaje = "@TONELAJE"; //  INT,
            public const string volumen = "@VOLUMEN"; //  INT,
            public const string udometro_inicial = "@UDOMETRO_INICIAL"; //  DECIMAL(18,3),
            public const string udometro_final = "@UDOMETRO_FINAL"; //  DECIMAL(18,3),
            public const string hora_salida = "@HORA_SALIDA"; //  VARCHAR(8),
            public const string hora_retorno = "@HORA_RETORNO"; //  VARCHAR(8),
            public const string veces = "@VECES"; //  integer,
            public const string usuario = "@USUARIO"; //  CHAR(15),
            public const string ide = "@IDE";         // int,
            public const string @ide_detalle = "@IDE_DETALLE"; //int output

        }

        public static ENResultOperation Crear(ClsRecojo_Apoyo_CabeceraBE Datos)
        {
            SqlCommand CMD = new SqlCommand("PA_RECOJO_INSERTA_APOYO");
            CMD.Parameters.Add(Parametros_SQL.nombre_error, SqlDbType.VarChar,100).Value = "";
            CMD.Parameters.Add(Parametros_SQL.numero, SqlDbType.Int).Value = Datos.Reco_numero_apoyo;
            CMD.Parameters.Add(Parametros_SQL.fecha_emision, SqlDbType.DateTime).Value = Datos.Reco_fecha_emision;
            CMD.Parameters.Add(Parametros_SQL.fecha_traslado, SqlDbType.DateTime).Value = Datos.Reco_fecha_traslado;
            CMD.Parameters.Add(Parametros_SQL.fecha_retorno, SqlDbType.DateTime).Value = Datos.Reco_fecha_retorno;
            CMD.Parameters.Add(Parametros_SQL.transportista, SqlDbType.Int).Value = Datos.Tran_ide;
            CMD.Parameters.Add(Parametros_SQL.chofer, SqlDbType.Int).Value = Datos.Tran_chof_ide;
            CMD.Parameters.Add(Parametros_SQL.vehiculo, SqlDbType.Int).Value = Datos.Tran_vehi_ide;
            CMD.Parameters.Add(Parametros_SQL.tonelaje, SqlDbType.Int).Value = Datos.Reco_tonelaje;
            CMD.Parameters.Add(Parametros_SQL.volumen, SqlDbType.Int).Value = Datos.Reco_volumen;
            CMD.Parameters.Add(Parametros_SQL.udometro_inicial, SqlDbType.Decimal).Value = Datos.Reco_udometro_inicial;
            CMD.Parameters.Add(Parametros_SQL.udometro_final, SqlDbType.Decimal).Value = Datos.Reco_udometro_final;
            CMD.Parameters.Add(Parametros_SQL.hora_salida, SqlDbType.VarChar).Value = Datos.Reco_hora_salida;
            CMD.Parameters.Add(Parametros_SQL.hora_retorno, SqlDbType.VarChar).Value = Datos.Reco_hora_retorno;
            CMD.Parameters.Add(Parametros_SQL.veces, SqlDbType.Int).Value = Datos.Veces;
            CMD.Parameters.Add(Parametros_SQL.usuario, SqlDbType.VarChar).Value = Datos.Usuario;
            CMD.Parameters.Add(Parametros_SQL.ide, SqlDbType.Int).Value = Datos.Reco_ide;
            CMD.Parameters.Add(Parametros_SQL.ide_detalle, SqlDbType.Int).Value = Datos.Reco_ide_detalle;

            CMD.Parameters.Add("@RETURN", SqlDbType.Int).Value = DBNull.Value;
            CMD.Parameters["@RETURN"].Direction = ParameterDirection.ReturnValue;
            CMD.Parameters["@NOMBRE_ERROR"].Direction = ParameterDirection.Output;
            return Recojo_Apoyo_CabeceraDA.Acceder(CMD);
        }

        public static ENResultOperation Actualizar(ClsRecojo_Apoyo_CabeceraBE Datos)
        {
            SqlCommand CMD = new SqlCommand("PA_RECOJO_MODIFICA_APOYO");
            CMD.Parameters.Add(Parametros_SQL.nombre_error, SqlDbType.VarChar).Value = "";
            CMD.Parameters.Add(Parametros_SQL.numero, SqlDbType.Int).Value = Datos.Reco_numero_apoyo;
            CMD.Parameters.Add(Parametros_SQL.fecha_emision, SqlDbType.DateTime).Value = Datos.Reco_fecha_emision;
            CMD.Parameters.Add(Parametros_SQL.fecha_traslado, SqlDbType.DateTime).Value = Datos.Reco_fecha_traslado;
            CMD.Parameters.Add(Parametros_SQL.fecha_retorno, SqlDbType.DateTime).Value = Datos.Reco_fecha_retorno;
            CMD.Parameters.Add(Parametros_SQL.transportista, SqlDbType.Int).Value = Datos.Tran_ide;
            CMD.Parameters.Add(Parametros_SQL.chofer, SqlDbType.Int).Value = Datos.Tran_chof_ide;
            CMD.Parameters.Add(Parametros_SQL.vehiculo, SqlDbType.Int).Value = Datos.Tran_vehi_ide;
            CMD.Parameters.Add(Parametros_SQL.tonelaje, SqlDbType.Int).Value = Datos.Reco_tonelaje;
            CMD.Parameters.Add(Parametros_SQL.volumen, SqlDbType.Int).Value = Datos.Reco_volumen;
            CMD.Parameters.Add(Parametros_SQL.udometro_inicial, SqlDbType.Decimal).Value = Datos.Reco_udometro_inicial;
            CMD.Parameters.Add(Parametros_SQL.udometro_final, SqlDbType.Decimal).Value = Datos.Reco_udometro_final;
            CMD.Parameters.Add(Parametros_SQL.hora_salida, SqlDbType.VarChar).Value = Datos.Reco_hora_salida;
            CMD.Parameters.Add(Parametros_SQL.hora_retorno, SqlDbType.VarChar).Value = Datos.Reco_hora_retorno;
            CMD.Parameters.Add(Parametros_SQL.veces, SqlDbType.Int).Value = Datos.Veces;
            CMD.Parameters.Add(Parametros_SQL.usuario, SqlDbType.VarChar).Value = Datos.Usuario;
            CMD.Parameters.Add(Parametros_SQL.ide, SqlDbType.Int).Value = Datos.Reco_ide;
            CMD.Parameters.Add(Parametros_SQL.ide_detalle, SqlDbType.Int).Value = Datos.Reco_ide_detalle;

            CMD.Parameters.Add("@RETURN", SqlDbType.Int);
            CMD.Parameters["@RETURN"].Value = DBNull.Value;
            CMD.Parameters["@RETURN"].Direction = ParameterDirection.ReturnValue;
            return Recojo_Apoyo_CabeceraDA.Acceder(CMD);

        }

        public static ENResultOperation Eliminar(ClsRecojo_Apoyo_CabeceraBE Datos)
        {
            SqlCommand CMD = new SqlCommand("PA_RECOJO_ELIMINA_APOYO");
            CMD.Parameters.Add(Parametros_SQL.nombre_error, SqlDbType.VarChar).Value = DBNull.Value;
            CMD.Parameters.Add(Parametros_SQL.ide, SqlDbType.Int).Value = Datos.Reco_ide;
            CMD.Parameters.Add(Parametros_SQL.ide_detalle, SqlDbType.Int).Value = Datos.Reco_ide_detalle;
            CMD.Parameters.Add(Parametros_SQL.veces, SqlDbType.Int).Value = Datos.Veces;
            CMD.Parameters.Add(Parametros_SQL.usuario, SqlDbType.VarChar).Value = Datos.Usuario;

            CMD.Parameters.Add("@RETURN", SqlDbType.Int);
            CMD.Parameters["@RETURN"].Value = DBNull.Value;
            CMD.Parameters["@RETURN"].Direction = ParameterDirection.ReturnValue;
            return Recojo_Apoyo_CabeceraDA.Acceder(CMD);
        }

        public static ENResultOperation Listar(Int32 Reco_ide)
        {
            string CmdSql = "SELECT RECO_IDE,RECO_IDE_DETALLE,RECO_NUMERO_APOYO,RECO_FECHA_EMISION,TRAN_IDE," +
                            "(SELECT TRAN_RAZON_SOCIAL FROM TRANSPORTISTA WHERE TRAN_IDE = RECOJO_APOYO_CABECERA.TRAN_IDE) AS TRAN_NOMBRE," +
                            "TRAN_CHOF_IDE,(SELECT TRAN_CHOF_NOMBRE FROM TRANSPORTISTA_CHOFER WHERE TRAN_IDE = RECOJO_APOYO_CABECERA.TRAN_IDE AND " +
                            "TRAN_CHOF_IDE = RECOJO_APOYO_CABECERA.TRAN_CHOF_IDE) AS CHOF_NOMBRE , " +
                            "TRAN_VEHI_IDE,(SELECT TRAN_VEHI_PLACA  FROM TRANSPORTISTA_VEHICULO WHERE TRAN_IDE = RECOJO_APOYO_CABECERA.TRAN_IDE AND " +
                            "TRAN_VEHI_IDE = RECOJO_APOYO_CABECERA.TRAN_VEHI_IDE) AS VEHI_PLACA, " +
                            "RECO_TONELAJE,RECO_VOLUMEN,RECO_UDOMETRO_INICIAL,RECO_UDOMETRO_FINAL,RECO_FECHA_TRASLADO," +
                            "RECO_HORA_SALIDA,RECO_FECHA_RETORNO,RECO_HORA_RETORNO FROM RECOJO_APOYO_CABECERA WHERE RECO_IDE = @IDE ";

            SqlCommand CMD = new SqlCommand(CmdSql);
            CMD.Parameters.AddWithValue("@IDE", Reco_ide);
            return ProcesarSQLDA.Procesar_SQL(CMD);

            /*
            SqlCommand CMD = new SqlCommand("PA_RECOJO_PEAJE_LISTAR");
            CMD.Parameters.Add(Parametros_SQL.nombre_error, SqlDbType.VarChar).Value = DBNull.Value;
            CMD.Parameters.Add(Parametros_SQL.ide, SqlDbType.Int).Value = Reco_ide;

            CMD.Parameters.Add("@RETURN", SqlDbType.Int);
            CMD.Parameters["@RETURN"].Value = DBNull.Value;
            CMD.Parameters["@RETURN"].Direction = ParameterDirection.ReturnValue;
            return Recojo_PeajeDA.Acceder(CMD);
            */
        }

        public static ENResultOperation Listar_Filtro(Int32 Reco_Ide, Int32 Reco_Ide_Detalle)
        {
            string CmdSql = "SELECT RECO_IDE,RECO_IDE_DETALLE,RECO_NUMERO_APOYO,RECO_FECHA_EMISION,TRAN_IDE," +
                                       "(SELECT TRAN_RAZON_SOCIAL FROM TRANSPORTISTA WHERE TRAN_IDE = RECOJO_APOYO_CABECERA.TRAN_IDE) AS TRAN_NOMBRE," +
                                       "TRAN_CHOF_IDE,(SELECT TRAN_CHOF_NOMBRE FROM TRANSPORTISTA_CHOFER WHERE TRAN_IDE = RECOJO_APOYO_CABECERA.TRAN_IDE AND " +
                                       "TRAN_CHOF_IDE = RECOJO_APOYO_CABECERA.TRAN_CHOF_IDE) AS CHOF_NOMBRE , " +
                                       "TRAN_VEHI_IDE,(SELECT TRAN_VEHI_PLACA  FROM TRANSPORTISTA_VEHICULO WHERE TRAN_IDE = RECOJO_APOYO_CABECERA.TRAN_IDE AND " +
                                       "TRAN_VEHI_IDE = RECOJO_APOYO_CABECERA.TRAN_VEHI_IDE) AS VEHI_PLACA, " +
                                       "(SELECT TIPO_VEHI_NOMBRE FROM TIPO_VEHICULO WHERE TIPO_VEHI_IDE = " + 
                                       "(SELECT TIPO_VEHI_IDE FROM TRANSPORTISTA_VEHICULO WHERE TRAN_IDE = RECOJO_APOYO_CABECERA.TRAN_IDE AND TRAN_VEHI_IDE = RECOJO_APOYO_CABECERA.TRAN_VEHI_IDE)) AS TIPO_NOMBRE," +
                                       "RECO_TONELAJE,RECO_VOLUMEN,RECO_UDOMETRO_INICIAL,RECO_UDOMETRO_FINAL,RECO_FECHA_TRASLADO," +
                                       "RECO_HORA_SALIDA,RECO_FECHA_RETORNO,RECO_HORA_RETORNO," +
                                       "(SELECT RTRIM(STR(TRAN_VEHI_TONELAJE))+'/'+LTRIM(STR(TRAN_VEHI_VOLUMEN))  FROM TRANSPORTISTA_VEHICULO WHERE TRAN_IDE = RECOJO_APOYO_CABECERA.TRAN_IDE AND " +
                                       "TRAN_VEHI_IDE = RECOJO_APOYO_CABECERA.TRAN_VEHI_IDE) AS VEHI_TNM3 " +
                                       " FROM RECOJO_APOYO_CABECERA WHERE RECO_IDE = @IDE AND RECO_IDE_DETALLE = @IDE_DETALLE";

            SqlCommand CMD = new SqlCommand(CmdSql);
            CMD.Parameters.AddWithValue("@IDE", Reco_Ide);
            CMD.Parameters.AddWithValue("@IDE_DETALLE", Reco_Ide_Detalle);
            return ProcesarSQLDA.Procesar_SQL(CMD);
        }

        public static ENResultOperation Ultimo_Item(Int32 Reco_Ide)
        {
            SqlCommand CMD = new SqlCommand("PA_RECOJO_APOYO_ITEMS");
            CMD.Parameters.Add(Parametros_SQL.nombre_error, SqlDbType.VarChar).Value = DBNull.Value;
            CMD.Parameters.Add(Parametros_SQL.ide, SqlDbType.Int).Value = Reco_Ide;

            CMD.Parameters.Add("@RETURN", SqlDbType.Int);
            CMD.Parameters["@RETURN"].Value = DBNull.Value;
            CMD.Parameters["@RETURN"].Direction = ParameterDirection.ReturnValue;
            return Recojo_Apoyo_CabeceraDA.Acceder(CMD);
        }
        public static ENResultOperation Obtener_Registro(Int32 Reco_Ide, Int32 Reco_Ide_Detalle)
        {
            SqlCommand CMD = new SqlCommand("SELECT * FROM RECOJO_PEAJE WHERE Reco_Ide = " +
                             Reco_Ide.ToString() + " AND Reco_Ide_Detalle = " + Reco_Ide_Detalle.ToString());

            return Recojo_Apoyo_CabeceraDA.Procesar_SQL(CMD);
        }
    }

}
