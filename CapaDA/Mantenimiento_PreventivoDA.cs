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
    class Mantenimiento_PreventivoDA
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

    public class ClsMantenimiento_PreventivoDA
    {
        public struct Parametros_SQL
        {
            public const string nombre_error = "@NOMBRE_ERROR";
            public const string ide = "@IDE";  //  [int] 
            public const string tran_ide = "@TRAN_IDE";  //  [int]
            public const string vehi_ide = "@TRAN_VEHI_IDE";  //  [int]
            public const string kilometraje = "@KILOMETRAJE";  // ] [int]
            public const string fecha = "@FECHA";  // ] [datetime] 
            public const string solicitado = "@SOLICITADO";  // ] [varchar](30) 
            public const string requerimiento = "@REQUERIMIENTO";  // ] [text] 
            public const string responsable = "@RESPONSABLE";  // ] [varchar](30) 
            public const string detalle = "@DETALLE";  // ] [text] 
            public const string servicio = "@SERVICIO";  // ] [nchar](1)
            public const string costo = "@COSTO";  // ] [nvarchar](50) 
            public const string ruc = "@RUC";  // ] [nvarchar](50) 
            public const string proveedor = "@PROVEEDOR";  // ] [nvarchar](50) 
            public const string fecha_factura = "@FECHA_FACTURA";  // ] [nchar](12)
            public const string numero_factura = "@NUMERO_FACTURA";  // ] [nchar](12)
            public const string modo_pago = "@MODOPAGO";  // ] [decimal](18, 2) 
            public const string transferido = "@TRANSFERIDO";  // ] [nvarchar](30) 
            public const string contacto = "@CONTACTO";  // ] [nvarchar](30) 
            public const string estado = "@ESTADO";  // ] [nvarchar](20) 
            public const string observaciones = "@OBSERVACIONES";  // ] [text]
            public const string grupo = "@GRUPO";
            public const string actividad = "@ACTIVIDAD";
            public const string usuario = "@USUARIO";  // ] [text]
        }

        public static ENResultOperation Crear(ClsMantenimiento_PreventivoBE Datos)
        {
            SqlCommand CMD = new SqlCommand("PA_MANTENIMIENTO_PREVENTIVO_INSERTA");
            CMD.Parameters.Add(Parametros_SQL.nombre_error, SqlDbType.VarChar).Value = "";
            CMD.Parameters.Add(Parametros_SQL.ide, SqlDbType.Int).Value = Datos.Mant_ide;
            CMD.Parameters.Add(Parametros_SQL.tran_ide, SqlDbType.Int).Value = Datos.Tran_ide;
            CMD.Parameters.Add(Parametros_SQL.vehi_ide, SqlDbType.Int).Value = Datos.Tran_vehi_ide;
            CMD.Parameters.Add(Parametros_SQL.kilometraje, SqlDbType.Int).Value = Datos.Mant_kilometraje;
            CMD.Parameters.Add(Parametros_SQL.fecha, SqlDbType.DateTime).Value = Datos.Mant_fecha;
            CMD.Parameters.Add(Parametros_SQL.solicitado, SqlDbType.NVarChar).Value = Datos.Mant_solicitado;
            CMD.Parameters.Add(Parametros_SQL.requerimiento, SqlDbType.NVarChar).Value = Datos.Mant_requerimiento;
            CMD.Parameters.Add(Parametros_SQL.responsable, SqlDbType.VarChar).Value = Datos.Mant_responsable;
            CMD.Parameters.Add(Parametros_SQL.detalle, SqlDbType.NVarChar).Value = Datos.Mant_detalle;
            CMD.Parameters.Add(Parametros_SQL.servicio, SqlDbType.NVarChar).Value = Datos.Mant_servicio;
            CMD.Parameters.Add(Parametros_SQL.costo, SqlDbType.Decimal).Value = Datos.Mant_costo_igv;
            CMD.Parameters.Add(Parametros_SQL.ruc, SqlDbType.VarChar).Value = Datos.Mant_ruc;
            CMD.Parameters.Add(Parametros_SQL.proveedor, SqlDbType.VarChar).Value = Datos.Mant_proveedor;
            CMD.Parameters.Add(Parametros_SQL.fecha_factura, SqlDbType.DateTime).Value = Datos.Mant_fecha_factura;
            CMD.Parameters.Add(Parametros_SQL.numero_factura, SqlDbType.VarChar).Value = Datos.Mant_numero_factura;
            CMD.Parameters.Add(Parametros_SQL.modo_pago, SqlDbType.VarChar).Value = Datos.Mant_modo_pago;
            CMD.Parameters.Add(Parametros_SQL.transferido, SqlDbType.VarChar).Value = Datos.Mant_transferido;
            CMD.Parameters.Add(Parametros_SQL.contacto, SqlDbType.VarChar).Value = Datos.Mant_contacto;
            CMD.Parameters.Add(Parametros_SQL.estado, SqlDbType.VarChar).Value = Datos.Mant_estado;
            CMD.Parameters.Add(Parametros_SQL.observaciones, SqlDbType.NVarChar).Value = Datos.Mant_observaciones;
            CMD.Parameters.Add(Parametros_SQL.grupo, SqlDbType.Int).Value = Datos.Mant_grupo_ide;
            CMD.Parameters.Add(Parametros_SQL.actividad, SqlDbType.Int).Value = Datos.Mant_actividad_ide;
            CMD.Parameters.Add(Parametros_SQL.usuario, SqlDbType.Text).Value = Datos.Mant_usuario_crea;

            CMD.Parameters.Add("@RETURN", SqlDbType.Int);
            CMD.Parameters["@RETURN"].Value = DBNull.Value;
            CMD.Parameters["@RETURN"].Direction = ParameterDirection.ReturnValue;

            return Mantenimiento_PreventivoDA.Acceder(CMD);

        }

        public static ENResultOperation Actualizar(ClsMantenimiento_PreventivoBE Datos)
        {
            SqlCommand CMD = new SqlCommand("PA_MANTENIMIENTO_PREVENTIVO_MODIFICA");
            CMD.Parameters.Add(Parametros_SQL.nombre_error, SqlDbType.VarChar).Value = "";
            CMD.Parameters.Add(Parametros_SQL.ide, SqlDbType.Int).Value = Datos.Mant_ide;
            CMD.Parameters.Add(Parametros_SQL.tran_ide, SqlDbType.Int).Value = Datos.Tran_ide;
            CMD.Parameters.Add(Parametros_SQL.vehi_ide, SqlDbType.Int).Value = Datos.Tran_vehi_ide;
            CMD.Parameters.Add(Parametros_SQL.kilometraje, SqlDbType.Int).Value = Datos.Mant_kilometraje;
            CMD.Parameters.Add(Parametros_SQL.fecha, SqlDbType.DateTime).Value = Datos.Mant_fecha;
            CMD.Parameters.Add(Parametros_SQL.solicitado, SqlDbType.VarChar).Value = Datos.Mant_solicitado;
            CMD.Parameters.Add(Parametros_SQL.requerimiento, SqlDbType.Text).Value = Datos.Mant_requerimiento;
            CMD.Parameters.Add(Parametros_SQL.responsable, SqlDbType.VarChar).Value = Datos.Mant_responsable;
            CMD.Parameters.Add(Parametros_SQL.detalle, SqlDbType.Text).Value = Datos.Mant_detalle;
            CMD.Parameters.Add(Parametros_SQL.servicio, SqlDbType.NChar).Value = Datos.Mant_servicio;
            CMD.Parameters.Add(Parametros_SQL.costo, SqlDbType.Decimal).Value = Datos.Mant_costo_igv;
            CMD.Parameters.Add(Parametros_SQL.ruc, SqlDbType.VarChar).Value = Datos.Mant_ruc;
            CMD.Parameters.Add(Parametros_SQL.proveedor, SqlDbType.VarChar).Value = Datos.Mant_proveedor;
            CMD.Parameters.Add(Parametros_SQL.fecha_factura, SqlDbType.DateTime).Value = Datos.Mant_fecha_factura;
            CMD.Parameters.Add(Parametros_SQL.numero_factura, SqlDbType.VarChar).Value = Datos.Mant_numero_factura;
            CMD.Parameters.Add(Parametros_SQL.modo_pago, SqlDbType.VarChar).Value = Datos.Mant_modo_pago;
            CMD.Parameters.Add(Parametros_SQL.transferido, SqlDbType.VarChar).Value = Datos.Mant_transferido;
            CMD.Parameters.Add(Parametros_SQL.contacto, SqlDbType.VarChar).Value = Datos.Mant_contacto;
            CMD.Parameters.Add(Parametros_SQL.estado, SqlDbType.VarChar).Value = Datos.Mant_estado;
            CMD.Parameters.Add(Parametros_SQL.observaciones, SqlDbType.Text).Value = Datos.Mant_observaciones;
            CMD.Parameters.Add(Parametros_SQL.grupo, SqlDbType.Int).Value = Datos.Mant_grupo_ide;
            CMD.Parameters.Add(Parametros_SQL.actividad, SqlDbType.Int).Value = Datos.Mant_actividad_ide;
            CMD.Parameters.Add(Parametros_SQL.usuario, SqlDbType.Text).Value = Datos.Mant_usuario_act;

            CMD.Parameters.Add("@RETURN", SqlDbType.Int);
            CMD.Parameters["@RETURN"].Value = DBNull.Value;
            CMD.Parameters["@RETURN"].Direction = ParameterDirection.ReturnValue;

            return Mantenimiento_PreventivoDA.Acceder(CMD);

        }

        public static ENResultOperation Eliminar(ClsMantenimiento_PreventivoBE Datos)
        {
            SqlCommand CMD = new SqlCommand("PA_MANTENIMIENTO_PREVENTIVO_ELIMINA");
            CMD.Parameters.Add(Parametros_SQL.nombre_error, SqlDbType.VarChar).Value = DBNull.Value;
            CMD.Parameters.Add(Parametros_SQL.ide, SqlDbType.Int).Value = Datos.Mant_ide;

            CMD.Parameters.Add("@RETURN", SqlDbType.Int);
            CMD.Parameters["@RETURN"].Value = DBNull.Value;
            CMD.Parameters["@RETURN"].Direction = ParameterDirection.ReturnValue;


            return Mantenimiento_PreventivoDA.Acceder(CMD);
        }

        public static ENResultOperation Listar(string Texto_Buscar)
        {
            SqlCommand CMD = new SqlCommand("SELECT * FROM V_MANTENIMIENTO_PREVENTIVO");

            return ProcesarSQLDA.Procesar_SQL(CMD);

        }

        public static ENResultOperation Listar_Filtro(string Texto_Buscar, string Condic_Buscar, DateTime FecIni, DateTime FecFin)
        {
            SqlCommand CMD = new SqlCommand("PA_MANTENIMIENTO_PREVENTIVO_LISTAR_FILTRO");
            CMD.Parameters.Add(Parametros_SQL.nombre_error, SqlDbType.VarChar).Value = Texto_Buscar;
            CMD.Parameters.Add("@FILTRO", SqlDbType.VarChar).Value = Texto_Buscar;
            CMD.Parameters.Add("@CONDIC", SqlDbType.VarChar).Value = Condic_Buscar;
            CMD.Parameters.Add("@FECINI", SqlDbType.DateTime).Value = FecIni;
            CMD.Parameters.Add("@FECFIN", SqlDbType.DateTime).Value = FecFin;

            CMD.Parameters.Add("@RETURN", SqlDbType.Int);
            CMD.Parameters["@RETURN"].Value = DBNull.Value;
            CMD.Parameters["@RETURN"].Direction = ParameterDirection.ReturnValue;

            return Mantenimiento_PreventivoDA.Acceder(CMD);
        }
        public static ENResultOperation Listar_por_Fechas(DateTime FecIni, DateTime FecFin)
        {
            SqlCommand CMD = new SqlCommand("PA_MANTENIMIENTO_PREVENTIVO_LISTAR_POR_FECHAS");
            CMD.Parameters.Add(Parametros_SQL.nombre_error, SqlDbType.VarChar).Value = DBNull.Value;
            CMD.Parameters.Add("@FECINI", SqlDbType.DateTime).Value = FecIni;
            CMD.Parameters.Add("@FECFIN", SqlDbType.DateTime).Value = FecFin;

            CMD.Parameters.Add("@RETURN", SqlDbType.Int);
            CMD.Parameters["@RETURN"].Value = DBNull.Value;
            CMD.Parameters["@RETURN"].Direction = ParameterDirection.ReturnValue;

            return Mantenimiento_PreventivoDA.Acceder(CMD);
        }
        public static ENResultOperation Buscar_Registro(Int32 Reco_Ide)
        {
            SqlCommand CMD = new SqlCommand("SELECT * FROM V_MANTENIMIENTO_PREVENTIVO WHERE Mant_Ide = @IDE");

            CMD.Parameters.AddWithValue("@IDE", Reco_Ide);
            return ProcesarSQLDA.Procesar_SQL(CMD);
        }

        public static ENResultOperation Obtener_Registro(Int32 Reco_Ide)
        {
            SqlCommand CMD = new SqlCommand("SELECT * FROM MANTENIMIENTO_PREVENTIVO WHERE Mant_Ide = " + Reco_Ide.ToString());

            return ProcesarSQLDA.Procesar_SQL(CMD);
        }
    }
}