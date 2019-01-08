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
    class Compra_ProductosDA
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
    }
    public class ClsCompra_ProductosDA
    {
        private SqlDataReader dr = null;
        public struct Parametros_SQL
        {

            public const string nombre_error = "@NOMBRE_ERROR";
            public const string comp_ide = "@IDE";
            public const string prov_ide = "@PROV_IDE";
            public const string tipo_doc_ide = "@TIPO_DOC";
            public const string comp_serie = "@SERIE";
            public const string comp_numero = "@NUMERO";
            public const string comp_fecha_emision = "@FECHA_EMISION";
            public const string comp_fecha_vencimiento = "@VENCIMIENTO";
            public const string comp_forma_pago = "@FORMA_PAGO";
            public const string comp_moneda = "@MONEDA";
            public const string comp_tcambio = "@TCAMBIO";
            public const string comp_tipo_compra = "@TIPO_COMPRA";
            public const string comp_igv_incluido = "@IGV_INCLUIDO";
            public const string comp_igv_porcentaje = "@IGV_PORCENTAJE";
            public const string comp_descuento_porcentaje = "@DSCTO_PORCENTAJE";
            public const string comp_valor_bruto = "@BRUTO";
            public const string comp_descuento = "@DESCUENTO";
            public const string comp_valor_neto = "@NETO";
            public const string comp_igv = "@IGV";
            public const string comp_valor_total = "@TOTAL";
            public const string usuario_crea = "@USUARIO_CREA";
            public const string fecha_crea = "@FECHA_CREA";
            public const string usuario_modifica = "@USUARIO_MODIFICA";
            public const string fecha_modifica = "@FECHA_MODIFICA";
            public const string estado = "@ESTADO";
        }

        public static ENResultOperation Crear(ClsCompra_ProductosBE Datos)
        {
            SqlCommand CMD = new SqlCommand("PA_COMPRA_PRODUCTOS_INSERTA");
            CMD.Parameters.Add(Parametros_SQL.nombre_error, SqlDbType.VarChar).Value = "";
            CMD.Parameters.Add(Parametros_SQL.comp_ide, SqlDbType.Int).Value = Datos.Comp_ide;
            CMD.Parameters.Add(Parametros_SQL.prov_ide, SqlDbType.Int).Value = Datos.Prov_ide;
            CMD.Parameters.Add(Parametros_SQL.tipo_doc_ide, SqlDbType.Int).Value = Datos.Tipo_doc_ide;
            CMD.Parameters.Add(Parametros_SQL.comp_serie, SqlDbType.VarChar).Value = Datos.Comp_serie;
            CMD.Parameters.Add(Parametros_SQL.comp_numero, SqlDbType.VarChar).Value = Datos.Comp_numero;
            CMD.Parameters.Add(Parametros_SQL.comp_fecha_emision, SqlDbType.DateTime).Value = Datos.Comp_fecha_emision;
            CMD.Parameters.Add(Parametros_SQL.comp_fecha_vencimiento, SqlDbType.DateTime).Value = Datos.Comp_fecha_vencimiento;
            CMD.Parameters.Add(Parametros_SQL.comp_forma_pago, SqlDbType.VarChar).Value = Datos.Comp_forma_pago;
            CMD.Parameters.Add(Parametros_SQL.comp_moneda, SqlDbType.VarChar).Value = Datos.Comp_moneda;
            CMD.Parameters.Add(Parametros_SQL.comp_tcambio, SqlDbType.Decimal).Value = Datos.Comp_tcambio;
            CMD.Parameters.Add(Parametros_SQL.comp_tipo_compra, SqlDbType.VarChar).Value = Datos.Comp_tipo_compra;
            CMD.Parameters.Add(Parametros_SQL.comp_igv_incluido, SqlDbType.NChar).Value = Datos.Comp_igv_incluido;
            CMD.Parameters.Add(Parametros_SQL.comp_igv_porcentaje, SqlDbType.Decimal).Value = Datos.Comp_igv_porcentaje;
            CMD.Parameters.Add(Parametros_SQL.comp_descuento_porcentaje, SqlDbType.Decimal).Value = Datos.Comp_descuento_porcentaje;
            CMD.Parameters.Add(Parametros_SQL.comp_valor_bruto, SqlDbType.Decimal).Value = Datos.Comp_valor_bruto;
            CMD.Parameters.Add(Parametros_SQL.comp_descuento, SqlDbType.Decimal).Value = Datos.Comp_descuento;
            CMD.Parameters.Add(Parametros_SQL.comp_valor_neto, SqlDbType.Decimal).Value = Datos.Comp_valor_neto;
            CMD.Parameters.Add(Parametros_SQL.comp_igv, SqlDbType.Decimal).Value = Datos.Comp_igv;
            CMD.Parameters.Add(Parametros_SQL.comp_valor_total, SqlDbType.Decimal).Value = Datos.Comp_valor_total;
            CMD.Parameters.Add(Parametros_SQL.usuario_crea, SqlDbType.VarChar).Value = Datos.Usuario_crea;
            CMD.Parameters.Add(Parametros_SQL.fecha_crea, SqlDbType.DateTime).Value = Datos.Fecha_crea;
            CMD.Parameters.Add(Parametros_SQL.usuario_modifica, SqlDbType.VarChar).Value = Datos.Usuario_modifica;
            CMD.Parameters.Add(Parametros_SQL.fecha_modifica, SqlDbType.DateTime).Value = Datos.Fecha_modifica;
            CMD.Parameters.Add(Parametros_SQL.estado, SqlDbType.NVarChar).Value = Datos.Estado;

            CMD.Parameters.Add("@RETURN", SqlDbType.Int);
            CMD.Parameters["@RETURN"].Value = DBNull.Value;
            CMD.Parameters["@RETURN"].Direction = ParameterDirection.ReturnValue;

            return Compra_ProductosDA.Acceder(CMD);

        }

        public static ENResultOperation Actualizar(ClsCompra_ProductosBE Datos)
        {
            SqlCommand CMD = new SqlCommand("PA_COMPRA_PRODUCTOS_MODIFICA");
            CMD.Parameters.Add(Parametros_SQL.nombre_error, SqlDbType.VarChar).Value = "";
            CMD.Parameters.Add(Parametros_SQL.comp_ide, SqlDbType.Int).Value = Datos.Comp_ide;
            CMD.Parameters.Add(Parametros_SQL.prov_ide, SqlDbType.Int).Value = Datos.Prov_ide;
            CMD.Parameters.Add(Parametros_SQL.tipo_doc_ide, SqlDbType.Int).Value = Datos.Tipo_doc_ide;
            CMD.Parameters.Add(Parametros_SQL.comp_serie, SqlDbType.VarChar).Value = Datos.Comp_serie;
            CMD.Parameters.Add(Parametros_SQL.comp_numero, SqlDbType.VarChar).Value = Datos.Comp_numero;
            CMD.Parameters.Add(Parametros_SQL.comp_fecha_emision, SqlDbType.DateTime).Value = Datos.Comp_fecha_emision;
            CMD.Parameters.Add(Parametros_SQL.comp_fecha_vencimiento, SqlDbType.DateTime).Value = Datos.Comp_fecha_vencimiento;
            CMD.Parameters.Add(Parametros_SQL.comp_forma_pago, SqlDbType.VarChar).Value = Datos.Comp_forma_pago;
            CMD.Parameters.Add(Parametros_SQL.comp_moneda, SqlDbType.VarChar).Value = Datos.Comp_moneda;
            CMD.Parameters.Add(Parametros_SQL.comp_tcambio, SqlDbType.Decimal).Value = Datos.Comp_tcambio;
            CMD.Parameters.Add(Parametros_SQL.comp_tipo_compra, SqlDbType.VarChar).Value = Datos.Comp_tipo_compra;
            CMD.Parameters.Add(Parametros_SQL.comp_igv_incluido, SqlDbType.NChar).Value = Datos.Comp_igv_incluido;
            CMD.Parameters.Add(Parametros_SQL.comp_igv_porcentaje, SqlDbType.Decimal).Value = Datos.Comp_igv_porcentaje;
            CMD.Parameters.Add(Parametros_SQL.comp_descuento_porcentaje, SqlDbType.Decimal).Value = Datos.Comp_descuento_porcentaje;
            CMD.Parameters.Add(Parametros_SQL.comp_valor_bruto, SqlDbType.Decimal).Value = Datos.Comp_valor_bruto;
            CMD.Parameters.Add(Parametros_SQL.comp_descuento, SqlDbType.Decimal).Value = Datos.Comp_descuento;
            CMD.Parameters.Add(Parametros_SQL.comp_valor_neto, SqlDbType.Decimal).Value = Datos.Comp_valor_neto;
            CMD.Parameters.Add(Parametros_SQL.comp_igv, SqlDbType.Decimal).Value = Datos.Comp_igv;
            CMD.Parameters.Add(Parametros_SQL.comp_valor_total, SqlDbType.Decimal).Value = Datos.Comp_valor_total;
            CMD.Parameters.Add(Parametros_SQL.usuario_crea, SqlDbType.VarChar).Value = Datos.Usuario_crea;
            CMD.Parameters.Add(Parametros_SQL.fecha_crea, SqlDbType.DateTime).Value = Datos.Fecha_crea;
            CMD.Parameters.Add(Parametros_SQL.usuario_modifica, SqlDbType.VarChar).Value = Datos.Usuario_modifica;
            CMD.Parameters.Add(Parametros_SQL.fecha_modifica, SqlDbType.DateTime).Value = Datos.Fecha_modifica;
            CMD.Parameters.Add(Parametros_SQL.estado, SqlDbType.NVarChar).Value = Datos.Estado;

            CMD.Parameters.Add("@RETURN", SqlDbType.Int);
            CMD.Parameters["@RETURN"].Value = DBNull.Value;
            CMD.Parameters["@RETURN"].Direction = ParameterDirection.ReturnValue;

            return Compra_ProductosDA.Acceder(CMD);

        }

        public static ENResultOperation Eliminar(ClsCompra_ProductosBE Datos)
        {
            SqlCommand CMD = new SqlCommand("PA_COMPRA_PRODUCTOS_ELIMINA");
            CMD.Parameters.Add(Parametros_SQL.nombre_error, SqlDbType.VarChar).Value = DBNull.Value;
            CMD.Parameters.Add(Parametros_SQL.comp_ide, SqlDbType.Int).Value = Datos.Comp_ide;

            CMD.Parameters.Add("@RETURN", SqlDbType.Int);
            CMD.Parameters["@RETURN"].Value = DBNull.Value;
            CMD.Parameters["@RETURN"].Direction = ParameterDirection.ReturnValue;


            return Compra_ProductosDA.Acceder(CMD);
        }

        public static ENResultOperation Actualiza_Valores(ClsCompra_ProductosBE Datos)
        {
            SqlCommand CMD = new SqlCommand("PA_COMPRA_PRODUCTOS_ACTUALIZA_VALORES");
            CMD.Parameters.Add(Parametros_SQL.nombre_error, SqlDbType.VarChar).Value = "";
            CMD.Parameters.Add(Parametros_SQL.comp_ide, SqlDbType.Int).Value = Datos.Comp_ide;
            CMD.Parameters.Add(Parametros_SQL.comp_descuento_porcentaje, SqlDbType.Decimal).Value = Datos.Comp_descuento_porcentaje;
            CMD.Parameters.Add(Parametros_SQL.comp_valor_bruto, SqlDbType.Decimal).Value = Datos.Comp_valor_bruto;
            CMD.Parameters.Add(Parametros_SQL.comp_descuento, SqlDbType.Decimal).Value = Datos.Comp_descuento;
            CMD.Parameters.Add(Parametros_SQL.comp_valor_neto, SqlDbType.Decimal).Value = Datos.Comp_valor_neto;
            CMD.Parameters.Add(Parametros_SQL.comp_igv, SqlDbType.Decimal).Value = Datos.Comp_igv;
            CMD.Parameters.Add(Parametros_SQL.comp_valor_total, SqlDbType.Decimal).Value = Datos.Comp_valor_total;

            CMD.Parameters.Add("@RETURN", SqlDbType.Int);
            CMD.Parameters["@RETURN"].Value = DBNull.Value;
            CMD.Parameters["@RETURN"].Direction = ParameterDirection.ReturnValue;

            return Compra_ProductosDA.Acceder(CMD);

        }


        public static ENResultOperation Listar(Int32 nComp_Ide)
        {
            SqlCommand CMD = new SqlCommand("SELECT * FROM V_COMPRA_PRODUCTOS_DETALLE  WHERE COMP_IDE = @IDE");

            CMD.Parameters.AddWithValue("@IDE",nComp_Ide);
            return ProcesarSQLDA.Procesar_SQL(CMD);

        }
        public static ENResultOperation Buscar_Comprobante(Int32 nComp_Ide)
        {
            SqlCommand CMD = new SqlCommand("SELECT * FROM V_COMPRA_PRODUCTOS  WHERE COMP_IDE = @IDE ");

            CMD.Parameters.AddWithValue("@IDE", nComp_Ide);
            return ProcesarSQLDA.Procesar_SQL(CMD);

        }

        public static ENResultOperation Listar_Filtro(string Texto_Buscar, string Condic_Buscar, DateTime FecIni, DateTime FecFin)
        {
            SqlCommand CMD = new SqlCommand("PA_COMPRA_PRODUCTOS_LISTAR_FILTRO");
            CMD.Parameters.Add(Parametros_SQL.nombre_error, SqlDbType.VarChar).Value = DBNull.Value;
            CMD.Parameters.Add("@FILTRO", SqlDbType.VarChar).Value = Texto_Buscar;
            CMD.Parameters.Add("@CONDIC", SqlDbType.VarChar).Value = Condic_Buscar;
            CMD.Parameters.Add("@FECINI", SqlDbType.DateTime).Value = FecIni;
            CMD.Parameters.Add("@FECFIN", SqlDbType.DateTime).Value = FecFin;

            CMD.Parameters.Add("@RETURN", SqlDbType.Int);
            CMD.Parameters["@RETURN"].Value = DBNull.Value;
            CMD.Parameters["@RETURN"].Direction = ParameterDirection.ReturnValue;
            return Compra_ProductosDA.Acceder(CMD);
        }
        public static ENResultOperation Listar_por_Fechas(DateTime Fecha_Inicio, DateTime Fecha_Fin)
        {
            SqlCommand CMD = new SqlCommand("PA_COMPRA_PRODUCTOS_LISTAR_POR_FECHAS");
            CMD.Parameters.Add(Parametros_SQL.nombre_error, SqlDbType.VarChar).Value = DBNull.Value;
            CMD.Parameters.Add("@FECINI", SqlDbType.DateTime).Value = Fecha_Inicio;
            CMD.Parameters.Add("@FECFIN", SqlDbType.DateTime).Value = Fecha_Fin;

            CMD.Parameters.Add("@RETURN", SqlDbType.Int);
            CMD.Parameters["@RETURN"].Value = DBNull.Value;
            CMD.Parameters["@RETURN"].Direction = ParameterDirection.ReturnValue;
            return Compra_ProductosDA.Acceder(CMD);
        }
    }
}
