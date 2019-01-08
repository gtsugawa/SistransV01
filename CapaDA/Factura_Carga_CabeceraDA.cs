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
    class Factura_Carga_CabeceraDA
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

    public class ClsFactura_Carga_CabeceraDA
    {
        public struct Parametros_SQL
        {
            public const string nombre_error = "@NOMBRE_ERROR";
            public const string serie_factura = "@SERIE_FACTURA";  // VARCHAR(4),
            public const string numero_factura = "@NUMERO_FACTURA";  //  INT OUTPUT,
            public const string moneda = "@MONEDA";  //  CHAR(5),
            public const string fecha_emision = "@FECHA_EMISION";  //  DATETIME,
            public const string fecha_vencimiento = "@FECHA_VENCIMIENTO";  //  DATETIME,
            public const string tipo_facturacion = "@TIPO_FACTURACION";  //  VARCHAR(20),
            public const string tipo_precio = "@TIPO_PRECIO";  //  VARCHAR(20),
            public const string cliente = "@CLIENTE";  //  INT,
            public const string vendedor = "@VENDEDOR";  //  INT,
            public const string direccion = "@DIRECCION";  //  VARCHAR(60),
            public const string localidad = "@LOCALIDAD";  //  INT,
            public const string forma_pago = "@FORMA_PAGO";  //  INT,
            public const string codigo_contable = "@CODIGO_CONTABLE";  //  INT,
            public const string estado = "@ESTADO";  //  CHAR(8),
            public const string fecha = "@FECHA";  //  DATETIME,
            public const string tipo_documento = "@TIPO_DOCUMENTO";  //  VARCHAR(20),
            public const string serie_documento = "@SERIE_DOCUMENTO";  //  VARCHAR(4),
            public const string numero_documento = "@NUMERO_DOCUMENTO";  //  INT,
            public const string numero_documento_no_facturacion = "@NUMERO_DOCUMENTO_NO_FACTURACION";  //  VARCHAR(15),
            public const string numero_no_existe = "@NUMERO_NO_EXISTE";  // _NO_EXISTE INT,
            public const string redondeo = "@REDONDEO";  //  DECIMAL(18,2),
            public const string incluye_impuesto = "@incluye_impuesto";  //  CHAR(2),
            public const string veces = "@VECES";  //  integer,
            public const string usuario = "@USUARIO";  //  CHAR(15),
            public const string ide = "@IDE";  //  INT OUTPUT,
            public const string sub_total = "@SUB_TOTAL";  //  DECIMAL(18,2) output
            public const string impuesto = "@IMPUESTO";  //  DECIMAL(18,2) output
            public const string total  = "@TOTAL";  //  DECIMAL(18,2) output
            public const string porcentaje_impuesto = "@PORCENTAJE_IMPUESTO";  //  DECIMAL(18,2) output
        }

        public static ENResultOperation Crear(ClsFactura_Carga_CabeceraBE Datos)
        {
            SqlCommand CMD = new SqlCommand("PA_FACTURA_CARGA_INSERTA");
            CMD.Parameters.Add(Parametros_SQL.nombre_error, SqlDbType.VarChar).Value = "";
            CMD.Parameters.Add(Parametros_SQL.serie_factura, SqlDbType.VarChar).Value = Datos.Serie_factura_numero;
            CMD.Parameters.Add(Parametros_SQL.numero_factura, SqlDbType.Int).Value = Datos.Fact_factura_numero;
            CMD.Parameters.Add(Parametros_SQL.moneda, SqlDbType.VarChar).Value = Datos.Fact_moneda;
            CMD.Parameters.Add(Parametros_SQL.fecha_emision, SqlDbType.DateTime).Value =  Datos.Fact_fecha_emision;
            CMD.Parameters.Add(Parametros_SQL.fecha_vencimiento, SqlDbType.DateTime).Value = Datos.Fact_fecha_vencimiento;
            CMD.Parameters.Add(Parametros_SQL.tipo_facturacion, SqlDbType.VarChar).Value = Datos.Fact_tipo_facturacion;
            CMD.Parameters.Add(Parametros_SQL.tipo_precio, SqlDbType.VarChar).Value = Datos.Fact_tipo_precio;
            CMD.Parameters.Add(Parametros_SQL.cliente, SqlDbType.Int).Value = Datos.Clie_ide;
            CMD.Parameters.Add(Parametros_SQL.vendedor, SqlDbType.Int).Value = Datos.Vend_ide;
            CMD.Parameters.Add(Parametros_SQL.direccion, SqlDbType.VarChar).Value = Datos.Fact_direccion;
            CMD.Parameters.Add(Parametros_SQL.localidad, SqlDbType.Int).Value = Datos.Loca_ide;
            CMD.Parameters.Add(Parametros_SQL.forma_pago, SqlDbType.Int).Value = Datos.For_pag_ide;
            CMD.Parameters.Add(Parametros_SQL.codigo_contable, SqlDbType.Int).Value = Datos.Conc_ide;
            CMD.Parameters.Add(Parametros_SQL.estado, SqlDbType.VarChar).Value = Datos.Fact_estado;
            CMD.Parameters.Add(Parametros_SQL.fecha, SqlDbType.DateTime).Value = Datos.Fact_fecha_documento;
            CMD.Parameters.Add(Parametros_SQL.tipo_documento, SqlDbType.VarChar).Value = Datos.Tipo_doc_ide;
            CMD.Parameters.Add(Parametros_SQL.serie_documento, SqlDbType.VarChar).Value = Datos.Serie_documento_numero;
            CMD.Parameters.Add(Parametros_SQL.numero_documento, SqlDbType.Int).Value = Datos.Fact_documento_numero;
            CMD.Parameters.Add(Parametros_SQL.numero_documento_no_facturacion, SqlDbType.VarChar).Value = Datos.Fact_documento_numero_no_facturacion;
            CMD.Parameters.Add(Parametros_SQL.numero_no_existe, SqlDbType.Int).Value = Datos.Fact_documento_no_existe;
            CMD.Parameters.Add(Parametros_SQL.redondeo, SqlDbType.Decimal).Value = Datos.Fact_redondeo;
            CMD.Parameters.Add(Parametros_SQL.incluye_impuesto, SqlDbType.VarChar).Value = Datos.Fact_precio_incluye_impuesto;
            CMD.Parameters.Add(Parametros_SQL.veces, SqlDbType.Int).Value = Datos.Veces;
            CMD.Parameters.Add(Parametros_SQL.usuario, SqlDbType.VarChar).Value = Datos.Usuario;
            CMD.Parameters.Add(Parametros_SQL.ide, SqlDbType.Int).Value = Datos.Fact_ide;
            CMD.Parameters.Add(Parametros_SQL.porcentaje_impuesto, SqlDbType.Decimal).Value = Datos.Fact_porcentaje_impuesto;


            CMD.Parameters.Add("@RETURN", SqlDbType.Int);
            CMD.Parameters["@RETURN"].Value = DBNull.Value;
            CMD.Parameters["@RETURN"].Direction = ParameterDirection.ReturnValue;

            return Factura_Carga_CabeceraDA.Acceder(CMD);

        }

        public static ENResultOperation Actualizar(ClsFactura_Carga_CabeceraBE Datos)
        {
            SqlCommand CMD = new SqlCommand("PA_FACTURA_CARGA_MODIFICA");
            CMD.Parameters.Add(Parametros_SQL.nombre_error, SqlDbType.VarChar).Value = "";
            CMD.Parameters.Add(Parametros_SQL.serie_factura, SqlDbType.VarChar).Value = Datos.Serie_factura_numero;
            CMD.Parameters.Add(Parametros_SQL.moneda, SqlDbType.VarChar).Value = Datos.Fact_moneda;
            CMD.Parameters.Add(Parametros_SQL.fecha_emision, SqlDbType.DateTime).Value =  Datos.Fact_fecha_emision;
            CMD.Parameters.Add(Parametros_SQL.fecha_vencimiento, SqlDbType.DateTime).Value = Datos.Fact_fecha_vencimiento;
            CMD.Parameters.Add(Parametros_SQL.tipo_facturacion, SqlDbType.VarChar).Value = Datos.Fact_tipo_facturacion;
            CMD.Parameters.Add(Parametros_SQL.tipo_precio, SqlDbType.VarChar).Value = Datos.Fact_tipo_precio;
            CMD.Parameters.Add(Parametros_SQL.cliente, SqlDbType.Int).Value = Datos.Clie_ide;
            CMD.Parameters.Add(Parametros_SQL.vendedor, SqlDbType.Int).Value = Datos.Vend_ide;
            CMD.Parameters.Add(Parametros_SQL.direccion, SqlDbType.VarChar).Value = Datos.Fact_direccion;
            CMD.Parameters.Add(Parametros_SQL.localidad, SqlDbType.Int).Value = Datos.Loca_ide;
            CMD.Parameters.Add(Parametros_SQL.forma_pago, SqlDbType.Int).Value = Datos.For_pag_ide;
            CMD.Parameters.Add(Parametros_SQL.codigo_contable, SqlDbType.Int).Value = Datos.Conc_ide;
            CMD.Parameters.Add(Parametros_SQL.estado, SqlDbType.VarChar).Value = Datos.Fact_estado;
            CMD.Parameters.Add(Parametros_SQL.fecha, SqlDbType.DateTime).Value = Datos.Fact_fecha_documento;
            CMD.Parameters.Add(Parametros_SQL.tipo_documento, SqlDbType.VarChar).Value = Datos.Tipo_doc_ide;
            CMD.Parameters.Add(Parametros_SQL.serie_documento, SqlDbType.VarChar).Value = Datos.Serie_documento_numero;
            CMD.Parameters.Add(Parametros_SQL.numero_documento, SqlDbType.Int).Value = Datos.Fact_documento_numero;
            CMD.Parameters.Add(Parametros_SQL.numero_documento_no_facturacion, SqlDbType.VarChar).Value = Datos.Fact_documento_numero_no_facturacion;
            CMD.Parameters.Add(Parametros_SQL.numero_no_existe, SqlDbType.Int).Value = Datos.Fact_documento_no_existe;
            CMD.Parameters.Add(Parametros_SQL.redondeo, SqlDbType.Decimal).Value = Datos.Fact_redondeo;
            CMD.Parameters.Add(Parametros_SQL.incluye_impuesto, SqlDbType.VarChar).Value = Datos.Fact_precio_incluye_impuesto;
            CMD.Parameters.Add(Parametros_SQL.veces, SqlDbType.Int).Value = Datos.Veces;
            CMD.Parameters.Add(Parametros_SQL.usuario, SqlDbType.VarChar).Value = Datos.Usuario;
            CMD.Parameters.Add(Parametros_SQL.ide, SqlDbType.Int).Value = Datos.Fact_ide;
            CMD.Parameters.Add(Parametros_SQL.sub_total, SqlDbType.Decimal).Value = 0;
            CMD.Parameters.Add(Parametros_SQL.impuesto, SqlDbType.Decimal).Value = 0;
            CMD.Parameters.Add(Parametros_SQL.total, SqlDbType.Decimal).Value = 0;
            CMD.Parameters.Add(Parametros_SQL.porcentaje_impuesto, SqlDbType.Decimal).Value = Datos.Fact_porcentaje_impuesto;

            CMD.Parameters.Add("@RETURN", SqlDbType.Int);
            CMD.Parameters["@RETURN"].Value = DBNull.Value;
            CMD.Parameters["@RETURN"].Direction = ParameterDirection.ReturnValue;

            return Factura_Carga_CabeceraDA.Acceder(CMD);

        }

        public static ENResultOperation Eliminar(ClsFactura_Carga_CabeceraBE Datos)
        {
            SqlCommand CMD = new SqlCommand("PA_FACTURA_CARGA_ELIMINA");
            CMD.Parameters.Add(Parametros_SQL.nombre_error, SqlDbType.VarChar).Value = DBNull.Value;
            CMD.Parameters.Add(Parametros_SQL.ide, SqlDbType.Int).Value = Datos.Fact_ide;
            CMD.Parameters.Add(Parametros_SQL.veces, SqlDbType.Int).Value = Datos.Veces;
            CMD.Parameters.Add(Parametros_SQL.usuario, SqlDbType.VarChar).Value = Datos.Usuario;

            CMD.Parameters.Add("@RETURN", SqlDbType.Int);
            CMD.Parameters["@RETURN"].Value = DBNull.Value;
            CMD.Parameters["@RETURN"].Direction = ParameterDirection.ReturnValue;


            return Factura_Carga_CabeceraDA.Acceder(CMD);
        }

        public static ENResultOperation Listar(string Texto_Buscar)
        {

            SqlCommand CMD = new SqlCommand("SELECT TOP 50 * FROM FACTURA_CARGA_CABECERA WHERE FACT_FACTURA_NUMERO LIKE '" +
                 Texto_Buscar + "%'  ORDER BY FACT_IDE DESC");
            return ProcesarSQLDA.Procesar_SQL(CMD);

        }
        public static ENResultOperation Buscar_Id(Int32 Fact_ide)
        {

            SqlCommand CMD = new SqlCommand("SELECT * FROM V_FACTURA_CARGA_CABECERA WHERE FACT_IDE = @IDE");

            CMD.Parameters.AddWithValue("@IDE", Fact_ide);
            return ProcesarSQLDA.Procesar_SQL(CMD);

        }

        public static ENResultOperation Listar_Filtro(string Campo_Buscar, string Condicion)
        {
            SqlCommand CMD = new SqlCommand("PA_FACTURA_CARGA_CABECERA_LISTAR_FILTRO");
            CMD.Parameters.Add(Parametros_SQL.nombre_error, SqlDbType.VarChar).Value = DBNull.Value;
            CMD.Parameters.Add("@FILTRO", SqlDbType.VarChar).Value = Campo_Buscar;
            CMD.Parameters.Add("@CONDIC", SqlDbType.VarChar).Value = Condicion;

            CMD.Parameters.Add("@RETURN", SqlDbType.Int);
            CMD.Parameters["@RETURN"].Value = DBNull.Value;
            CMD.Parameters["@RETURN"].Direction = ParameterDirection.ReturnValue;
            return Factura_Carga_CabeceraDA.Acceder(CMD);
        }
    }
}
