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
    class Recojo_CabeceraDA
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
                string NombreError  = cmd.Parameters["@NOMBRE_ERROR"].Value.ToString();
                string ValRetorno   = cmd.Parameters["@RETURN"].Value.ToString();
                
                if (Convert.ToInt32(ValRetorno) < 0)
                {
                    result.Proceder = false;
                    result.Sms = NombreError;
                    result.Valor = temp;
                    result.Ide = Convert.ToInt32(ValRetorno);
                }
                else
                {
                    result.Proceder = true;
                    result.Sms = "Correcto";
                    result.Valor = temp;
                    result.Ide = Convert.ToInt32(ValRetorno);
                }
            }
            catch (Exception E)
            {

                result.Proceder = false;
                result.Sms = E.Message;
                result.Valor = null;
                result.Ide = 0;
            }
            return result;
          }

        public static ENResultOperation Procesar_SQL(SqlCommand cmd)
        {
            ENResultOperation result = new ENResultOperation();
            cmd.Connection = CN;
            //cmd.CommandType = CommandType.StoredProcedure;
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

        /*
        public static ENResultOperation Actualizar(SqlCommand cmd)
        {
            ENResultOperation result = new ENResultOperation();
            cmd.Connection = CN;
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                CN.Open();
                int resultado = Convert.ToInt32(cmd.ExecuteScalar());
                result.Proceder = true;
                result.Sms = "Correcto";
            }
            catch (Exception E)
            {
                result.Proceder = false;
                result.Sms = E.Message;
                result.Valor = null;
            }
            CN.Close();
            return result;
        }
        */
  
    }

    public class clsRecojo_CabeceraDA
    {
        public struct Parametros_SQL
        {
            public const string nombre_error =        "@NOMBRE_ERROR";// VARCHAR(100) OUTPUT,
            public const string serie_numero_recojo = "@SERIE";// CHAR(4),
            public const string reco_numero_recojo  = "@NUMERO_ORDEN";// INT OUTPUT,
            public const string reco_fecha_emision  = "@FECHA_EMISION";// DATETIME,
            public const string reco_fecha_traslado = "@FECHA_TRASLADO";// DATETIME,
            public const string reco_fecha_retorno =  "@FECHA_RETORNO";// DATETIME,
            public const string prov_carga_ide =      "@PROVEEDOR";// INT,
            public const string reco_direccion  =    "@DIRECCION_PROVEEDOR";// VARCHAR(60),
            public const string loca_ide        =    "@LOCALIDAD_PROVEEDOR";// INT,
            public const string contacto        =   "@contacto";// INT,
            public const string tran_ide        =  "@TRANSPORTISTA";// INT,
            public const string tran_chof_ide   =    "@CHOFER";// INT,
            public const string tran_vehi_ide   =    "@VEHICULO";// INT,
            public const string reco_tonelaje   =    "@tonelaje";// INT,
            public const string reco_volumen    =    "@VOLUMEN";// INT,
            public const string reco_udometro_inicial = "@UDOMETRO_INICIAL";// DECIMAL(18,3),
            public const string reco_udometro_final   = "@UDOMETRO_FINAL";// DECIMAL(18,3),
            public const string reco_hora_salida      = "@HORA_SALIDA";// VARCHAR(8),
            public const string reco_hora_retorno     = "@HORA_RETORNO";// VARCHAR(8),
            public const string reco_reparto_destinatario = "@REPARTO_DESTINATARIO";// INT,
            public const string reco_lugar            = "@LUGAR";// INT,
            public const string reco_tipo             = "@TIPO";// INT,
            public const string reco_punto_reparto    = "@PUNTO_REPARTO";// INT,
            public const string veces                 = "@VECES";// integer,
            public const string usuario               = "@USUARIO";// CHAR(15),
            public const string reco_ide              = "@IDE";// int output
            public const string filtro = "@FILTRO";// int output
            public const string estado  = "@ESTADO";// int output

        }

        public static ENResultOperation Crear(clsRecojo_CabeceraBE Datos)
        {
            SqlCommand CMD = new SqlCommand("PA_RECOJO_INSERTA");
            CMD.Parameters.Add(Parametros_SQL.nombre_error,SqlDbType.VarChar).Value = "";
            CMD.Parameters.Add(Parametros_SQL.serie_numero_recojo,SqlDbType.VarChar).Value = Datos.Serie_numero_recojo;
            CMD.Parameters.Add(Parametros_SQL.reco_numero_recojo,SqlDbType.VarChar).Value =  Datos.Reco_numero_recojo;
            CMD.Parameters.Add(Parametros_SQL.reco_fecha_emision, SqlDbType.DateTime).Value = Datos.Reco_fecha_emision;
            CMD.Parameters.Add(Parametros_SQL.reco_fecha_traslado, SqlDbType.DateTime).Value = Datos.Reco_fecha_traslado;
            CMD.Parameters.Add(Parametros_SQL.reco_fecha_retorno, SqlDbType.DateTime).Value = Datos.Reco_fecha_retorno;
            CMD.Parameters.Add(Parametros_SQL.prov_carga_ide, SqlDbType.Int).Value = Datos.Prov_carga_ide;
            CMD.Parameters.Add(Parametros_SQL.reco_direccion, SqlDbType.VarChar).Value = Datos.Reco_direccion;
            CMD.Parameters.Add(Parametros_SQL.loca_ide, SqlDbType.Int).Value = Datos.Loca_ide;
            CMD.Parameters.Add(Parametros_SQL.contacto, SqlDbType.Int).Value = Datos.Prov_carga_cont_ide;
            CMD.Parameters.Add(Parametros_SQL.tran_ide, SqlDbType.Int).Value = Datos.Tran_ide;
            CMD.Parameters.Add(Parametros_SQL.tran_chof_ide, SqlDbType.Int).Value = Datos.Tran_chof_ide;
            CMD.Parameters.Add(Parametros_SQL.tran_vehi_ide, SqlDbType.Int).Value = Datos.Tran_vehi_ide;
            CMD.Parameters.Add(Parametros_SQL.reco_tonelaje, SqlDbType.Int).Value = Datos.Reco_tonelaje;
            CMD.Parameters.Add(Parametros_SQL.reco_volumen, SqlDbType.Int).Value = Datos.Reco_volumen;
            CMD.Parameters.Add(Parametros_SQL.reco_udometro_inicial,SqlDbType.Decimal).Value = Datos.Reco_udometro_inicial;
            CMD.Parameters.Add(Parametros_SQL.reco_udometro_final,SqlDbType.Decimal).Value = Datos.Reco_udometro_final;
            CMD.Parameters.Add(Parametros_SQL.reco_hora_salida, SqlDbType.VarChar).Value = Datos.Reco_hora_salida;
            CMD.Parameters.Add(Parametros_SQL.reco_hora_retorno, SqlDbType.VarChar).Value = Datos.Reco_hora_retorno;
            CMD.Parameters.Add(Parametros_SQL.reco_reparto_destinatario, SqlDbType.Int).Value = Datos.Reco_reparto_destinatario;
            CMD.Parameters.Add(Parametros_SQL.reco_lugar, SqlDbType.Int).Value = Datos.Reco_lugar;
            CMD.Parameters.Add(Parametros_SQL.reco_tipo, SqlDbType.Int).Value = Datos.Reco_tipo;
            CMD.Parameters.Add(Parametros_SQL.reco_punto_reparto, SqlDbType.Int).Value = Datos.Reco_punto_reparto;
            CMD.Parameters.Add(Parametros_SQL.veces, SqlDbType.Int).Value = Datos.Veces;
            CMD.Parameters.Add(Parametros_SQL.usuario, SqlDbType.VarChar).Value = Datos.Usuario;
            CMD.Parameters.Add(Parametros_SQL.reco_ide, SqlDbType.Int).Value = Datos.Reco_ide;

            CMD.Parameters.Add("@RETURN", SqlDbType.Int);
            CMD.Parameters["@RETURN"].Value = DBNull.Value;
            CMD.Parameters["@RETURN"].Direction = ParameterDirection.ReturnValue;
            return Recojo_CabeceraDA.Acceder(CMD);
        }

        public static ENResultOperation Actualizar(clsRecojo_CabeceraBE Datos)
        {
            SqlCommand CMD = new SqlCommand("PA_RECOJO_MODIFICA");
           CMD.Parameters.Add(Parametros_SQL.nombre_error,SqlDbType.VarChar).Value = "";
            CMD.Parameters.Add(Parametros_SQL.serie_numero_recojo,SqlDbType.VarChar).Value = Datos.Serie_numero_recojo;
            CMD.Parameters.Add(Parametros_SQL.reco_numero_recojo,SqlDbType.VarChar).Value =  Datos.Reco_numero_recojo;
            CMD.Parameters.Add(Parametros_SQL.reco_fecha_emision, SqlDbType.DateTime).Value = Datos.Reco_fecha_emision;
            CMD.Parameters.Add(Parametros_SQL.reco_fecha_traslado, SqlDbType.DateTime).Value = Datos.Reco_fecha_traslado;
            CMD.Parameters.Add(Parametros_SQL.reco_fecha_retorno, SqlDbType.DateTime).Value = Datos.Reco_fecha_retorno;
            CMD.Parameters.Add(Parametros_SQL.prov_carga_ide, SqlDbType.Int).Value = Datos.Prov_carga_ide;
            CMD.Parameters.Add(Parametros_SQL.reco_direccion, SqlDbType.VarChar).Value = Datos.Reco_direccion;
            CMD.Parameters.Add(Parametros_SQL.loca_ide, SqlDbType.Int).Value = Datos.Loca_ide;
            CMD.Parameters.Add(Parametros_SQL.contacto, SqlDbType.Int).Value = Datos.Prov_carga_cont_ide;
            CMD.Parameters.Add(Parametros_SQL.tran_ide, SqlDbType.Int).Value = Datos.Tran_ide;
            CMD.Parameters.Add(Parametros_SQL.tran_chof_ide, SqlDbType.Int).Value = Datos.Tran_chof_ide;
            CMD.Parameters.Add(Parametros_SQL.tran_vehi_ide, SqlDbType.Int).Value = Datos.Tran_vehi_ide;
            CMD.Parameters.Add(Parametros_SQL.reco_tonelaje, SqlDbType.Int).Value = Datos.Reco_tonelaje;
            CMD.Parameters.Add(Parametros_SQL.reco_volumen, SqlDbType.Int).Value = Datos.Reco_volumen;
            CMD.Parameters.Add(Parametros_SQL.reco_udometro_inicial,SqlDbType.Decimal).Value = Datos.Reco_udometro_inicial;
            CMD.Parameters.Add(Parametros_SQL.reco_udometro_final,SqlDbType.Decimal).Value = Datos.Reco_udometro_final;
            CMD.Parameters.Add(Parametros_SQL.reco_hora_salida, SqlDbType.VarChar).Value = Datos.Reco_hora_salida;
            CMD.Parameters.Add(Parametros_SQL.reco_hora_retorno, SqlDbType.VarChar).Value = Datos.Reco_hora_retorno;
            CMD.Parameters.Add(Parametros_SQL.reco_reparto_destinatario, SqlDbType.Int).Value = Datos.Reco_reparto_destinatario;
            CMD.Parameters.Add(Parametros_SQL.reco_lugar, SqlDbType.Int).Value = Datos.Reco_lugar;
            CMD.Parameters.Add(Parametros_SQL.reco_tipo, SqlDbType.Int).Value = Datos.Reco_tipo;
            CMD.Parameters.Add(Parametros_SQL.reco_punto_reparto, SqlDbType.Int).Value = Datos.Reco_punto_reparto;
            CMD.Parameters.Add(Parametros_SQL.veces, SqlDbType.Int).Value = Datos.Veces;
            CMD.Parameters.Add(Parametros_SQL.usuario, SqlDbType.VarChar).Value = Datos.Usuario;
            CMD.Parameters.Add(Parametros_SQL.reco_ide, SqlDbType.Int).Value = Datos.Reco_ide;

            CMD.Parameters.Add("@RETURN", SqlDbType.Int);
            CMD.Parameters["@RETURN"].Value = DBNull.Value;
            CMD.Parameters["@RETURN"].Direction = ParameterDirection.ReturnValue;
            return Recojo_CabeceraDA.Acceder(CMD);

        }

        public static ENResultOperation Eliminar(clsRecojo_CabeceraBE Datos)
        {
            SqlCommand CMD = new SqlCommand("PA_RECOJO_ELIMINA");
            CMD.Parameters.Add(Parametros_SQL.nombre_error, SqlDbType.VarChar).Value = DBNull.Value;
            CMD.Parameters.Add(Parametros_SQL.reco_ide, SqlDbType.Int).Value = Datos.Reco_ide;
            CMD.Parameters.Add(Parametros_SQL.veces, SqlDbType.Int).Value = Datos.Veces;
            CMD.Parameters.Add(Parametros_SQL.usuario, SqlDbType.VarChar).Value = Datos.Usuario;

            CMD.Parameters.Add("@RETURN", SqlDbType.Int);
            CMD.Parameters["@RETURN"].Value = DBNull.Value;
            CMD.Parameters["@RETURN"].Direction = ParameterDirection.ReturnValue;
            return Recojo_CabeceraDA.Acceder(CMD);
        }

        public static ENResultOperation Actualiza_Estado_Digitacion(Int32 Reco_Ide, Int32 Estado)
        {
            SqlCommand CMD = new SqlCommand("UPDATE RECOJO_CABECERA SET RECO_ESTADO_DIGITACION = @ESTADO WHERE RECO_IDE = @IDE");
            CMD.Parameters.AddWithValue("@IDE", Reco_Ide);
            CMD.Parameters.AddWithValue("@ESTADO", Estado);
            return ProcesarSQLDA.Procesar_SQL(CMD);

            /*
            SqlCommand CMD = new SqlCommand("PA_RECOJO_LISTAR");
            CMD.Parameters.Add(Parametros_SQL.nombre_error, SqlDbType.VarChar).Value = Texto_Buscar;
            CMD.Parameters.Add(Parametros_SQL.filtro, SqlDbType.VarChar).Value = Texto_Buscar;

            CMD.Parameters.Add("@RETURN", SqlDbType.Int);
            CMD.Parameters["@RETURN"].Value = DBNull.Value;
            CMD.Parameters["@RETURN"].Direction = ParameterDirection.ReturnValue;
            return Recojo_CabeceraDA.Acceder(CMD);
            */
        }
        public static ENResultOperation Listar(string Texto_Buscar)
        {
            SqlCommand CMD = new SqlCommand("SELECT * FROM RECOJO_CABECERA WHERE PAIS_ESTADO = 'Activo' AND (PAIS_NOMBRE LIKE @FILTRO +'%')");
            CMD.Parameters.AddWithValue("@FILTRO",Texto_Buscar);
            return ProcesarSQLDA.Procesar_SQL(CMD);

            /*
            SqlCommand CMD = new SqlCommand("PA_RECOJO_LISTAR");
            CMD.Parameters.Add(Parametros_SQL.nombre_error, SqlDbType.VarChar).Value = Texto_Buscar;
            CMD.Parameters.Add(Parametros_SQL.filtro, SqlDbType.VarChar).Value = Texto_Buscar;

            CMD.Parameters.Add("@RETURN", SqlDbType.Int);
            CMD.Parameters["@RETURN"].Value = DBNull.Value;
            CMD.Parameters["@RETURN"].Direction = ParameterDirection.ReturnValue;
            return Recojo_CabeceraDA.Acceder(CMD);
            */ 
        }

        public static ENResultOperation Listar_Filtro(string Campo_Buscar, string Condicion, Int32 Estado_Digitacion)
        {
            SqlCommand CMD = new SqlCommand("PA_RECOJO_LISTAR_FILTRO");
            CMD.Parameters.Add(Parametros_SQL.nombre_error, SqlDbType.VarChar).Value = DBNull.Value;
            CMD.Parameters.Add("@FILTRO", SqlDbType.VarChar).Value = Campo_Buscar;
            CMD.Parameters.Add("@CONDIC", SqlDbType.VarChar).Value = Condicion;
            CMD.Parameters.Add("@ESTADO", SqlDbType.Int).Value = Estado_Digitacion;

            CMD.Parameters.Add("@RETURN", SqlDbType.Int);
            CMD.Parameters["@RETURN"].Value = DBNull.Value;
            CMD.Parameters["@RETURN"].Direction = ParameterDirection.ReturnValue;
            return Recojo_CabeceraDA.Acceder(CMD);
        }

        public static ENResultOperation Obtener_Registro(Int32 Reco_Ide)
        {
            
            SqlCommand CMD = new SqlCommand("Select * FROM Recojo_Cabecera WHERE Reco_Ide = @IDE");
            CMD.Parameters.AddWithValue("@IDE",Reco_Ide);
            return Recojo_CabeceraDA.Procesar_SQL(CMD);
  
        }
        public static ENResultOperation Buscar_Orden(Int32 Orden)
        {
            SqlCommand CMD = new SqlCommand("Select * FROM Recojo_Cabecera WHERE Reco_Numero_Recojo = @ORDEN");
            CMD.Parameters.AddWithValue("@ORDEN", Orden);
            return Recojo_CabeceraDA.Procesar_SQL(CMD);

        }
    }
}
