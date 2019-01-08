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
    class Recojo_DetalleDA
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
    }

    public class clsRecojo_DetalleDA
    {
        public struct Parametros_SQL
        {

            public const string nombre_error = "@NOMBRE_ERROR"; // VARCHAR(100) OUTPUT,
            public const string ide = "@IDE"; //  INT" 
            public const string ide_detalle = "@IDE_DETALLE"; //  INT OUTPUT,
            public const string item = "@ITEM"; //  INT,
            public const string cliente = "@CLIENTE"; //  INT,
            public const string nombre_cliente = "@NOMBRE_CLIENTE"; //  VARCHAR(60),
            public const string direccion = "@DIRECCION"; //  VARCHAR(60),
            public const string localidad = "@LOCALIDAD"; //  INT,
            public const string descripcion = "@DESCRIPCION"; //  VARCHAR(60),
            public const string unidad_medida = "@UNIDAD_MEDIDA"; //  INT,
            public const string tipo_producto = "@TIPO_PRODUCTO"; //  INT,
            public const string cantidad = "@CANTIDAD"; //  DECIMAL(18,0),
            public const string peso = "@PESO"; //  DECIMAL(18,3),
            public const string volumen = "@VOLUMEN"; //  DECIMAL(18,3),
            public const string km_final = "@KM_FINAL"; //  DECIMAL(18,3),
            public const string guia = "@GUIA"; //  VARCHAR(15),
            public const string planilla = "@PLANILLA"; //  VARCHAR(15),
            public const string fecha_llegada = "@FECHA_LLEGADA"; //  DATETIME,
            public const string fecha_inicio_carga = "@FECHA_INICIO_CARGA"; //  DATETIME,
            public const string fecha_fin_carga = "@FECHA_FIN_CARGA"; //  DATETIME,
            public const string fecha_inicio_descarga = "@FECHA_INICIO_DESCARGA"; //  DATETIME,
            public const string fecha_fin_descarga = "@FECHA_FIN_DESCARGA"; //  DATETIME,
            public const string fecha_retiro = "@FECHA_RETIRO"; //  DATETIME,
            public const string hora_llegada = "@HORA_LLEGADA"; //  VARCHAR(8),
            public const string hora_inicio = "@HORA_INICIO_CARGA"; //  VARCHAR(8),
            public const string hora_fin_carga = "@HORA_FIN_CARGA"; //  VARCHAR(8),
            public const string hora_inicio_descarga = "@HORA_INICIO_DESCARGA"; //  VARCHAR(8),
            public const string hora_fin_descarga = "@HORA_FIN_DESCARGA"; //  VARCHAR(8),
            public const string hora_retiro = "@HORA_RETIRO"; //  VARCHAR(8),
            public const string veces = "@VECES"; //  integer,
            public const string usuario = "@USUARIO"; //  CHAR(15)

        }

        public static ENResultOperation Crear(clsRecojo_DetalleBE Datos)
        {
            SqlCommand CMD = new SqlCommand("PA_RECOJO_INSERTA_DETALLE");
            CMD.Parameters.Add(Parametros_SQL.nombre_error, SqlDbType.VarChar).Value = "";
            CMD.Parameters.Add(Parametros_SQL.ide, SqlDbType.Int).Value = Datos.Reco_ide;
            CMD.Parameters.Add(Parametros_SQL.ide_detalle, SqlDbType.Int).Value = Datos.Reco_ide_detalle;  
            CMD.Parameters.Add(Parametros_SQL.item, SqlDbType.Int).Value = Datos.Reco_item;
            CMD.Parameters.Add(Parametros_SQL.cliente, SqlDbType.Int).Value = Datos.Reco_cliente_ide;
            CMD.Parameters.Add(Parametros_SQL.nombre_cliente, SqlDbType.VarChar).Value = Datos.Reco_destinatario;
            CMD.Parameters.Add(Parametros_SQL.direccion, SqlDbType.VarChar).Value = Datos.Reco_direccion;
            CMD.Parameters.Add(Parametros_SQL.localidad, SqlDbType.Int).Value = Datos.Loca_ide;
            CMD.Parameters.Add(Parametros_SQL.descripcion, SqlDbType.VarChar).Value = Datos.Reco_descripcion;
            CMD.Parameters.Add(Parametros_SQL.unidad_medida, SqlDbType.Int).Value = Datos.Unid_medi_ide;
            CMD.Parameters.Add(Parametros_SQL.tipo_producto, SqlDbType.Int).Value = Datos.Tipo_prod_ide;
            CMD.Parameters.Add(Parametros_SQL.cantidad, SqlDbType.Decimal).Value = Datos.Reco_cantidad;
            CMD.Parameters.Add(Parametros_SQL.peso, SqlDbType.Decimal).Value = Datos.Reco_peso;
            CMD.Parameters.Add(Parametros_SQL.volumen, SqlDbType.Decimal).Value = Datos.Reco_volumen;
            CMD.Parameters.Add(Parametros_SQL.km_final, SqlDbType.Decimal).Value = Datos.Reco_km_final;
            CMD.Parameters.Add(Parametros_SQL.guia, SqlDbType.VarChar).Value = Datos.Reco_guia_proveedor;
            CMD.Parameters.Add(Parametros_SQL.planilla, SqlDbType.VarChar).Value = Datos.Reco_planilla;
            CMD.Parameters.Add(Parametros_SQL.fecha_llegada, SqlDbType.DateTime).Value = Datos.Reco_fecha_llegada;
            CMD.Parameters.Add(Parametros_SQL.fecha_inicio_carga, SqlDbType.DateTime).Value = Datos.Reco_fecha_inicio_carga;
            CMD.Parameters.Add(Parametros_SQL.fecha_fin_carga, SqlDbType.DateTime).Value = Datos.Reco_fecha_fin_carga;
            CMD.Parameters.Add(Parametros_SQL.fecha_inicio_descarga, SqlDbType.DateTime).Value = Datos.Reco_fecha_inicio_descarga;
            CMD.Parameters.Add(Parametros_SQL.fecha_fin_descarga, SqlDbType.DateTime).Value = Datos.Reco_fecha_fin_descarga;
            CMD.Parameters.Add(Parametros_SQL.fecha_retiro, SqlDbType.DateTime).Value = Datos.Reco_fecha_retiro;
            CMD.Parameters.Add(Parametros_SQL.hora_llegada, SqlDbType.VarChar).Value = Datos.Reco_hora_llegada;
            CMD.Parameters.Add(Parametros_SQL.hora_inicio, SqlDbType.VarChar).Value = Datos.Reco_hora_inicio_carga;
            CMD.Parameters.Add(Parametros_SQL.hora_fin_carga, SqlDbType.VarChar).Value = Datos.Reco_hora_fin_carga;
            CMD.Parameters.Add(Parametros_SQL.hora_inicio_descarga, SqlDbType.VarChar).Value = Datos.Reco_hora_inicio_descarga;
            CMD.Parameters.Add(Parametros_SQL.hora_fin_descarga, SqlDbType.VarChar).Value = Datos.Reco_hora_fin_descarga;
            CMD.Parameters.Add(Parametros_SQL.hora_retiro, SqlDbType.VarChar).Value = Datos.Reco_hora_retiro;
            CMD.Parameters.Add(Parametros_SQL.veces, SqlDbType.Int).Value = Datos.Veces;
            CMD.Parameters.Add(Parametros_SQL.usuario, SqlDbType.VarChar).Value = Datos.Usuario;

            CMD.Parameters.Add("@RETURN", SqlDbType.Int);
            CMD.Parameters["@RETURN"].Value = DBNull.Value;
            CMD.Parameters["@RETURN"].Direction = ParameterDirection.ReturnValue;
            return Recojo_CabeceraDA.Acceder(CMD);
        }

        public static ENResultOperation Actualizar(clsRecojo_DetalleBE Datos)
        {
            SqlCommand CMD = new SqlCommand("PA_RECOJO_MODIFICA_DETALLE");
            CMD.Parameters.Add(Parametros_SQL.nombre_error, SqlDbType.VarChar).Value = "";
            CMD.Parameters.Add(Parametros_SQL.ide, SqlDbType.Int).Value = Datos.Reco_ide;
            CMD.Parameters.Add(Parametros_SQL.ide_detalle, SqlDbType.Int).Value = Datos.Reco_ide_detalle;
            CMD.Parameters.Add(Parametros_SQL.item, SqlDbType.Int).Value = Datos.Reco_item;
            CMD.Parameters.Add(Parametros_SQL.cliente, SqlDbType.Int).Value = Datos.Reco_cliente_ide;
            CMD.Parameters.Add(Parametros_SQL.nombre_cliente, SqlDbType.VarChar).Value = Datos.Reco_destinatario;
            CMD.Parameters.Add(Parametros_SQL.direccion, SqlDbType.VarChar).Value = Datos.Reco_direccion;
            CMD.Parameters.Add(Parametros_SQL.localidad, SqlDbType.Int).Value = Datos.Loca_ide;
            CMD.Parameters.Add(Parametros_SQL.descripcion, SqlDbType.VarChar).Value = Datos.Reco_descripcion;
            CMD.Parameters.Add(Parametros_SQL.unidad_medida, SqlDbType.Int).Value = Datos.Unid_medi_ide;
            CMD.Parameters.Add(Parametros_SQL.tipo_producto, SqlDbType.Int).Value = Datos.Tipo_prod_ide;
            CMD.Parameters.Add(Parametros_SQL.cantidad, SqlDbType.Decimal).Value = Datos.Reco_cantidad;
            CMD.Parameters.Add(Parametros_SQL.peso, SqlDbType.Decimal).Value = Datos.Reco_peso;
            CMD.Parameters.Add(Parametros_SQL.volumen, SqlDbType.Decimal).Value = Datos.Reco_volumen;
            CMD.Parameters.Add(Parametros_SQL.km_final, SqlDbType.Decimal).Value = Datos.Reco_km_final;
            CMD.Parameters.Add(Parametros_SQL.guia, SqlDbType.VarChar).Value = Datos.Reco_guia_proveedor;
            CMD.Parameters.Add(Parametros_SQL.planilla, SqlDbType.VarChar).Value = Datos.Reco_planilla;
            CMD.Parameters.Add(Parametros_SQL.fecha_llegada, SqlDbType.DateTime).Value = Datos.Reco_fecha_llegada;
            CMD.Parameters.Add(Parametros_SQL.fecha_inicio_carga, SqlDbType.DateTime).Value = Datos.Reco_fecha_inicio_carga;
            CMD.Parameters.Add(Parametros_SQL.fecha_fin_carga, SqlDbType.DateTime).Value = Datos.Reco_fecha_fin_carga;
            CMD.Parameters.Add(Parametros_SQL.fecha_inicio_descarga, SqlDbType.DateTime).Value = Datos.Reco_fecha_inicio_descarga;
            CMD.Parameters.Add(Parametros_SQL.fecha_fin_descarga, SqlDbType.DateTime).Value = Datos.Reco_fecha_fin_descarga;
            CMD.Parameters.Add(Parametros_SQL.fecha_retiro, SqlDbType.DateTime).Value = Datos.Reco_fecha_retiro;
            CMD.Parameters.Add(Parametros_SQL.hora_llegada, SqlDbType.VarChar).Value = Datos.Reco_hora_llegada;
            CMD.Parameters.Add(Parametros_SQL.hora_inicio, SqlDbType.VarChar).Value = Datos.Reco_hora_inicio_carga;
            CMD.Parameters.Add(Parametros_SQL.hora_fin_carga, SqlDbType.VarChar).Value = Datos.Reco_hora_fin_carga;
            CMD.Parameters.Add(Parametros_SQL.hora_inicio_descarga, SqlDbType.VarChar).Value = Datos.Reco_hora_inicio_descarga;
            CMD.Parameters.Add(Parametros_SQL.hora_fin_descarga, SqlDbType.VarChar).Value = Datos.Reco_hora_fin_descarga;
            CMD.Parameters.Add(Parametros_SQL.hora_retiro, SqlDbType.VarChar).Value = Datos.Reco_hora_retiro;
            CMD.Parameters.Add(Parametros_SQL.veces, SqlDbType.Int).Value = Datos.Veces;
            CMD.Parameters.Add(Parametros_SQL.usuario, SqlDbType.VarChar).Value = Datos.Usuario;

            CMD.Parameters.Add("@RETURN", SqlDbType.Int);
            CMD.Parameters["@RETURN"].Value = DBNull.Value;
            CMD.Parameters["@RETURN"].Direction = ParameterDirection.ReturnValue;
            return Recojo_DetalleDA.Acceder(CMD);

        }

        public static ENResultOperation Eliminar(clsRecojo_DetalleBE Datos)
        {
            SqlCommand CMD = new SqlCommand("PA_RECOJO_ELIMINA_DETALLE");
            CMD.Parameters.Add(Parametros_SQL.nombre_error, SqlDbType.VarChar).Value = DBNull.Value;
            CMD.Parameters.Add(Parametros_SQL.ide, SqlDbType.Int).Value = Datos.Reco_ide;
            CMD.Parameters.Add(Parametros_SQL.ide_detalle, SqlDbType.Int).Value = Datos.Reco_ide_detalle;
            CMD.Parameters.Add(Parametros_SQL.veces, SqlDbType.Int).Value = Datos.Veces;
            CMD.Parameters.Add(Parametros_SQL.usuario, SqlDbType.VarChar).Value = Datos.Usuario;

            CMD.Parameters.Add("@RETURN", SqlDbType.Int);
            CMD.Parameters["@RETURN"].Value = DBNull.Value;
            CMD.Parameters["@RETURN"].Direction = ParameterDirection.ReturnValue;
            return Recojo_DetalleDA.Acceder(CMD);
        }

        public static ENResultOperation Listar(Int32 Reco_ide )
        {
            SqlCommand CMD = new SqlCommand("SELECT * FROM V_RECOJO_DETALLE WHERE RECO_IDE = @IDE");
            CMD.Parameters.AddWithValue("@IDE", Reco_ide);
            return ProcesarSQLDA.Procesar_SQL(CMD);

            /*
            SqlCommand CMD = new SqlCommand("PA_RECOJO_DETALLE_LISTAR");
            CMD.Parameters.Add(Parametros_SQL.nombre_error, SqlDbType.VarChar).Value = DBNull.Value;
            CMD.Parameters.Add(Parametros_SQL.ide, SqlDbType.Int).Value = Reco_ide;

            CMD.Parameters.Add("@RETURN", SqlDbType.Int);
            CMD.Parameters["@RETURN"].Value = DBNull.Value;
            CMD.Parameters["@RETURN"].Direction = ParameterDirection.ReturnValue;
            return Recojo_DetalleDA.Acceder(CMD);
            */
        }
        public static ENResultOperation Listar_PuntoReparto(Int32 Reco_Ide)
        {
            SqlCommand CMD = new SqlCommand("SELECT DISTINCT RECO_DESTINATARIO,RECO_DIRECCION,LOCA_IDE,LOCA_NOMBRE,PAIS_NOMBRE FROM V_RECOJO_DETALLE WHERE RECO_IDE = @IDE");
            CMD.Parameters.AddWithValue("@IDE", Reco_Ide);
            return ProcesarSQLDA.Procesar_SQL(CMD);
        }

        public static ENResultOperation Listar_Filtro(Int32 Reco_Ide, Int32 Reco_Ide_Detalle)
        {
            SqlCommand CMD = new SqlCommand("SELECT * FROM V_RECOJO_DETALLE WHERE RECO_IDE = @IDE AND RECO_IDE_DETALLE = @IDE_DETALLE");
            CMD.Parameters.AddWithValue("@IDE", Reco_Ide);
            CMD.Parameters.AddWithValue("@IDE_DETALLE", Reco_Ide_Detalle);
            return ProcesarSQLDA.Procesar_SQL(CMD);

            /*
            SqlCommand CMD = new SqlCommand("PA_RECOJO_DETALLE_LISTAR_FILTRO");
            CMD.Parameters.Add(Parametros_SQL.nombre_error, SqlDbType.VarChar).Value = DBNull.Value;
            CMD.Parameters.Add(Parametros_SQL.ide, SqlDbType.Int).Value = Reco_Ide;
            CMD.Parameters.Add(Parametros_SQL.ide_detalle, SqlDbType.Int).Value = Reco_Ide_Detalle;

            CMD.Parameters.Add("@RETURN", SqlDbType.Int);
            CMD.Parameters["@RETURN"].Value = DBNull.Value;
            CMD.Parameters["@RETURN"].Direction = ParameterDirection.ReturnValue;
            return Recojo_DetalleDA.Acceder(CMD);
            */
        }

        public static ENResultOperation Ultimo_Item(Int32 Reco_Ide)
        {
            SqlCommand CMD = new SqlCommand("PA_RECOJO_DETALLE_ITEMS");
            CMD.Parameters.Add(Parametros_SQL.nombre_error, SqlDbType.VarChar).Value = DBNull.Value;
            CMD.Parameters.Add(Parametros_SQL.ide, SqlDbType.Int).Value = Reco_Ide;

            CMD.Parameters.Add("@RETURN", SqlDbType.Int);
            CMD.Parameters["@RETURN"].Value = DBNull.Value;
            CMD.Parameters["@RETURN"].Direction = ParameterDirection.ReturnValue;
            return Recojo_DetalleDA.Acceder(CMD);
        }
    }
}
