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
    class Compra_LubricantesDA
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
    public class ClsCompra_LubricantesDA
    {
        private SqlDataReader dr = null;
        public struct Parametros_SQL
        {

            public const string nombre_error = "@NOMBRE_ERROR";
            public const string comp_ide = "@IDE";
            public const string prov_ide = "@PROV_IDE";
            public const string comp_fecha = "@FECHA";
            public const string comp_numero = "@NUMERO";
            public const string comp_codigo = "@CODIGO";
            public const string comp_descripcion = "@DESCRIPCION";
            public const string comp_marca = "@MARCA";
            public const string comp_unidad = "@UNIDAD";
            public const string comp_cantidad = "@CANTIDAD";
            public const string comp_importe = "@IMPORTE";
            public const string comp_moneda = "@MONEDA";
            public const string comp_tcambio = "@TCAMBIO";
            public const string unidad_salida = "@UNIDAD_SALIDA";
            public const string unidad_equivalencia = "@EQUIVALENCIA";
            public const string unidad_costo = "@COSTO_UNITARIO";
            public const string cantidad_salida = "@CANTIDAD_SALIDA";
            public const string fecha_inicio_uso = "@FECHA_USO";
            public const string estado = "@ESTADO";
        }

        public static ENResultOperation Crear(ClsCompra_LubricantesBE Datos)
        {
            SqlCommand CMD = new SqlCommand("PA_COMPRA_LUBRICANTES_INSERTA");
            CMD.Parameters.Add(Parametros_SQL.nombre_error, SqlDbType.VarChar).Value = "";
            CMD.Parameters.Add(Parametros_SQL.comp_ide, SqlDbType.Int).Value = Datos.Comp_ide;
            CMD.Parameters.Add(Parametros_SQL.prov_ide, SqlDbType.Int).Value = Datos.Prov_ide;
            CMD.Parameters.Add(Parametros_SQL.comp_fecha, SqlDbType.DateTime).Value = Datos.Comp_fecha;
            CMD.Parameters.Add(Parametros_SQL.comp_numero, SqlDbType.VarChar).Value = Datos.Comp_numero;
            CMD.Parameters.Add(Parametros_SQL.comp_codigo, SqlDbType.VarChar).Value = Datos.Comp_codigo;
            CMD.Parameters.Add(Parametros_SQL.comp_descripcion, SqlDbType.VarChar).Value = Datos.Comp_descripcion;
            CMD.Parameters.Add(Parametros_SQL.comp_marca, SqlDbType.VarChar).Value = Datos.Comp_marca;
            CMD.Parameters.Add(Parametros_SQL.comp_unidad, SqlDbType.VarChar).Value = Datos.Comp_unidad;
            CMD.Parameters.Add(Parametros_SQL.comp_cantidad, SqlDbType.Int).Value = Datos.Comp_cantidad;
            CMD.Parameters.Add(Parametros_SQL.comp_importe, SqlDbType.Decimal).Value = Datos.Comp_importe;
            CMD.Parameters.Add(Parametros_SQL.comp_moneda, SqlDbType.VarChar).Value = Datos.Comp_moneda;
            CMD.Parameters.Add(Parametros_SQL.comp_tcambio, SqlDbType.Decimal).Value = Datos.Comp_tcambio;
            CMD.Parameters.Add(Parametros_SQL.unidad_salida, SqlDbType.VarChar).Value = Datos.Unidad_salida;
            CMD.Parameters.Add(Parametros_SQL.unidad_equivalencia, SqlDbType.Int).Value = Datos.Unidad_equivalencia;
            CMD.Parameters.Add(Parametros_SQL.unidad_costo, SqlDbType.Decimal).Value = Datos.Unidad_costo;
            CMD.Parameters.Add(Parametros_SQL.cantidad_salida, SqlDbType.Decimal).Value = Datos.Cantidad_salida;
            CMD.Parameters.Add(Parametros_SQL.fecha_inicio_uso, SqlDbType.DateTime).Value = Datos.Fecha_inicio_uso;
            CMD.Parameters.Add(Parametros_SQL.estado, SqlDbType.Int).Value = Datos.Estado;

            CMD.Parameters.Add("@RETURN", SqlDbType.Int);
            CMD.Parameters["@RETURN"].Value = DBNull.Value;
            CMD.Parameters["@RETURN"].Direction = ParameterDirection.ReturnValue;

            return Compra_LubricantesDA.Acceder(CMD);

        }

        public static ENResultOperation Actualizar(ClsCompra_LubricantesBE Datos)
        {
            SqlCommand CMD = new SqlCommand("PA_COMPRA_LUBRICANTES_MODIFICA");
            CMD.Parameters.Add(Parametros_SQL.nombre_error, SqlDbType.VarChar).Value = "";
            CMD.Parameters.Add(Parametros_SQL.comp_ide, SqlDbType.Int).Value = Datos.Comp_ide;
            CMD.Parameters.Add(Parametros_SQL.prov_ide, SqlDbType.Int).Value = Datos.Prov_ide;
            CMD.Parameters.Add(Parametros_SQL.comp_fecha, SqlDbType.DateTime).Value = Datos.Comp_fecha;
            CMD.Parameters.Add(Parametros_SQL.comp_numero, SqlDbType.VarChar).Value = Datos.Comp_numero;
            CMD.Parameters.Add(Parametros_SQL.comp_codigo, SqlDbType.VarChar).Value = Datos.Comp_codigo;
            CMD.Parameters.Add(Parametros_SQL.comp_descripcion, SqlDbType.VarChar).Value = Datos.Comp_descripcion;
            CMD.Parameters.Add(Parametros_SQL.comp_marca, SqlDbType.VarChar).Value = Datos.Comp_marca;
            CMD.Parameters.Add(Parametros_SQL.comp_unidad, SqlDbType.VarChar).Value = Datos.Comp_unidad;
            CMD.Parameters.Add(Parametros_SQL.comp_cantidad, SqlDbType.Int).Value = Datos.Comp_cantidad;
            CMD.Parameters.Add(Parametros_SQL.comp_importe, SqlDbType.Decimal).Value = Datos.Comp_importe;
            CMD.Parameters.Add(Parametros_SQL.comp_moneda, SqlDbType.VarChar).Value = Datos.Comp_moneda;
            CMD.Parameters.Add(Parametros_SQL.comp_tcambio, SqlDbType.Decimal).Value = Datos.Comp_tcambio;
            CMD.Parameters.Add(Parametros_SQL.unidad_salida, SqlDbType.VarChar).Value = Datos.Unidad_salida;
            CMD.Parameters.Add(Parametros_SQL.unidad_equivalencia, SqlDbType.Int).Value = Datos.Unidad_equivalencia;
            CMD.Parameters.Add(Parametros_SQL.unidad_costo, SqlDbType.Decimal).Value = Datos.Unidad_costo;
            CMD.Parameters.Add(Parametros_SQL.cantidad_salida, SqlDbType.Decimal).Value = Datos.Cantidad_salida;
            CMD.Parameters.Add(Parametros_SQL.fecha_inicio_uso, SqlDbType.DateTime).Value = Datos.Fecha_inicio_uso;
            CMD.Parameters.Add(Parametros_SQL.estado, SqlDbType.Int).Value = Datos.Estado;

            CMD.Parameters.Add("@RETURN", SqlDbType.Int);
            CMD.Parameters["@RETURN"].Value = DBNull.Value;
            CMD.Parameters["@RETURN"].Direction = ParameterDirection.ReturnValue;

            return Compra_LubricantesDA.Acceder(CMD);

        }

        public static ENResultOperation Eliminar(ClsCompra_LubricantesBE Datos)
        {
            SqlCommand CMD = new SqlCommand("PA_COMPRA_LUBRICANTES_ELIMINA");
            CMD.Parameters.Add(Parametros_SQL.nombre_error, SqlDbType.VarChar).Value = DBNull.Value;
            CMD.Parameters.Add(Parametros_SQL.comp_ide, SqlDbType.Int).Value = Datos.Comp_ide;

            CMD.Parameters.Add("@RETURN", SqlDbType.Int);
            CMD.Parameters["@RETURN"].Value = DBNull.Value;
            CMD.Parameters["@RETURN"].Direction = ParameterDirection.ReturnValue;


            return Compra_LubricantesDA.Acceder(CMD);
        }

        public static ENResultOperation Listar(string Texto_Buscar)
        {
            SqlCommand CMD = new SqlCommand("SELECT * FROM V_COMPRA_LUBRICANTES  WHERE PROV_IDE LIKE '" +
                   Texto_Buscar + "%' ORDER BY COMP_FECHA,COMP_NUMERO");
            return ProcesarSQLDA.Procesar_SQL(CMD);

        }
        public static ENResultOperation Buscar_Comprobante(Int32 nComp_Ide)
        {
            SqlCommand CMD = new SqlCommand("SELECT * FROM V_COMPRA_LUBRICANTES  WHERE COMP_IDE = @IDE ");

            CMD.Parameters.AddWithValue("@IDE", nComp_Ide);
            return ProcesarSQLDA.Procesar_SQL(CMD);

        }

        public static ENResultOperation Listar_Filtro(string Texto_Buscar, string Condic_Buscar, DateTime FecIni, DateTime FecFin)
        {
            SqlCommand CMD = new SqlCommand("PA_COMPRA_LUBRICANTES_LISTAR_FILTRO");
            CMD.Parameters.Add(Parametros_SQL.nombre_error, SqlDbType.VarChar).Value = DBNull.Value;
            CMD.Parameters.Add("@FILTRO", SqlDbType.VarChar).Value = Texto_Buscar;
            CMD.Parameters.Add("@CONDIC", SqlDbType.VarChar).Value = Condic_Buscar;
            CMD.Parameters.Add("@FECINI", SqlDbType.DateTime).Value = FecIni;
            CMD.Parameters.Add("@FECFIN", SqlDbType.DateTime).Value = FecFin;

            CMD.Parameters.Add("@RETURN", SqlDbType.Int);
            CMD.Parameters["@RETURN"].Value = DBNull.Value;
            CMD.Parameters["@RETURN"].Direction = ParameterDirection.ReturnValue;
            return Compra_LubricantesDA.Acceder(CMD);
        }
        public static ENResultOperation Listar_por_Fechas(DateTime Fecha_Inicio, DateTime Fecha_Fin)
        {
            SqlCommand CMD = new SqlCommand("PA_COMPRA_LUBRICANTES_LISTAR_POR_FECHAS");
            CMD.Parameters.Add(Parametros_SQL.nombre_error, SqlDbType.VarChar).Value = DBNull.Value;
            CMD.Parameters.Add("@FECINI", SqlDbType.DateTime).Value = Fecha_Inicio;
            CMD.Parameters.Add("@FECFIN", SqlDbType.DateTime).Value = Fecha_Fin;

            CMD.Parameters.Add("@RETURN", SqlDbType.Int);
            CMD.Parameters["@RETURN"].Value = DBNull.Value;
            CMD.Parameters["@RETURN"].Direction = ParameterDirection.ReturnValue;
            return Compra_LubricantesDA.Acceder(CMD);
        }
    }
}
