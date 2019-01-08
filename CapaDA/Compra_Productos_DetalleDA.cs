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
    class Compra_Productos_DetalleDA
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
    public class ClsCompra_Productos_DetalleDA
        {
            private SqlDataReader dr = null;
            public struct Parametros_SQL
            {

                public const string nombre_error = "@NOMBRE_ERROR";
                public const string comp_ide = "@IDE";
                public const string comp_detalle_ide = "@DETALLE_IDE";
                public const string comp_codigo = "@CODIGO";
                public const string comp_descripcion = "@DESCRIPCION";
                public const string comp_unidad_compra = "@UNIDAD_COMPRA";
                public const string comp_unidad_salida = "@UNIDAD_SALIDA";
                public const string comp_equivalencia = "@EQUIVALENCIA";
                public const string comp_valor_unitario = "@VALOR_UNITARIO";
                public const string cantidad_salida = "@CANTIDAD_SALIDA";
                public const string estado = "@ESTADO";
            }

            public static ENResultOperation Crear(ClsCompra_Productos_DetalleBE Datos)
            {
                SqlCommand CMD = new SqlCommand("PA_COMPRA_PRODUCTOS_DETALLE_INSERTA");
                CMD.Parameters.Add(Parametros_SQL.nombre_error, SqlDbType.VarChar).Value = "";
                CMD.Parameters.Add(Parametros_SQL.comp_ide, SqlDbType.Int).Value = Datos.Comp_ide;
                CMD.Parameters.Add(Parametros_SQL.comp_detalle_ide, SqlDbType.Int).Value = Datos.Comp_detalle_ide;
                CMD.Parameters.Add(Parametros_SQL.comp_codigo, SqlDbType.VarChar).Value = Datos.Comp_codigo;
                CMD.Parameters.Add(Parametros_SQL.comp_descripcion, SqlDbType.VarChar).Value = Datos.Comp_descripcion;
                CMD.Parameters.Add(Parametros_SQL.comp_unidad_compra, SqlDbType.VarChar).Value = Datos.Comp_unidad_compra;
                CMD.Parameters.Add(Parametros_SQL.comp_unidad_salida, SqlDbType.VarChar).Value = Datos.Comp_unidad_salida;
                CMD.Parameters.Add(Parametros_SQL.comp_equivalencia, SqlDbType.Int).Value = Datos.Comp_equivalencia;
                CMD.Parameters.Add(Parametros_SQL.comp_valor_unitario, SqlDbType.Decimal).Value = Datos.Comp_valor_unitario;
                CMD.Parameters.Add(Parametros_SQL.cantidad_salida, SqlDbType.Decimal).Value = Datos.Cantidad_salida;
                CMD.Parameters.Add(Parametros_SQL.estado, SqlDbType.Int).Value = Datos.Estado;

                CMD.Parameters.Add("@RETURN", SqlDbType.Int);
                CMD.Parameters["@RETURN"].Value = DBNull.Value;
                CMD.Parameters["@RETURN"].Direction = ParameterDirection.ReturnValue;

                return Compra_Productos_DetalleDA.Acceder(CMD);

            }

            public static ENResultOperation Actualizar(ClsCompra_Productos_DetalleBE Datos)
            {
                SqlCommand CMD = new SqlCommand("PA_COMPRA_PRODUCTOS_DETALLE_MODIFICA");
                CMD.Parameters.Add(Parametros_SQL.nombre_error, SqlDbType.VarChar).Value = "";
                CMD.Parameters.Add(Parametros_SQL.comp_ide, SqlDbType.Int).Value = Datos.Comp_ide;
                CMD.Parameters.Add(Parametros_SQL.comp_detalle_ide, SqlDbType.Int).Value = Datos.Comp_detalle_ide;
                CMD.Parameters.Add(Parametros_SQL.comp_codigo, SqlDbType.VarChar).Value = Datos.Comp_codigo;
                CMD.Parameters.Add(Parametros_SQL.comp_descripcion, SqlDbType.VarChar).Value = Datos.Comp_descripcion;
                CMD.Parameters.Add(Parametros_SQL.comp_unidad_compra, SqlDbType.VarChar).Value = Datos.Comp_unidad_compra;
                CMD.Parameters.Add(Parametros_SQL.comp_unidad_salida, SqlDbType.VarChar).Value = Datos.Comp_unidad_salida;
                CMD.Parameters.Add(Parametros_SQL.comp_equivalencia, SqlDbType.Int).Value = Datos.Comp_equivalencia;
                CMD.Parameters.Add(Parametros_SQL.comp_valor_unitario, SqlDbType.Decimal).Value = Datos.Comp_valor_unitario;
                CMD.Parameters.Add(Parametros_SQL.cantidad_salida, SqlDbType.Decimal).Value = Datos.Cantidad_salida;
                CMD.Parameters.Add(Parametros_SQL.estado, SqlDbType.Int).Value = Datos.Estado;

                CMD.Parameters.Add("@RETURN", SqlDbType.Int);
                CMD.Parameters["@RETURN"].Value = DBNull.Value;
                CMD.Parameters["@RETURN"].Direction = ParameterDirection.ReturnValue;

                return Compra_Productos_DetalleDA.Acceder(CMD);

            }

            public static ENResultOperation Eliminar(ClsCompra_Productos_DetalleBE Datos)
            {
                SqlCommand CMD = new SqlCommand("PA_COMPRA_PRODUCTOS_DETALLE_ELIMINA");
                CMD.Parameters.Add(Parametros_SQL.nombre_error, SqlDbType.VarChar).Value = DBNull.Value;
                CMD.Parameters.Add(Parametros_SQL.comp_detalle_ide, SqlDbType.Int).Value = Datos.Comp_detalle_ide;

                CMD.Parameters.Add("@RETURN", SqlDbType.Int);
                CMD.Parameters["@RETURN"].Value = DBNull.Value;
                CMD.Parameters["@RETURN"].Direction = ParameterDirection.ReturnValue;


                return Compra_Productos_DetalleDA.Acceder(CMD);
            }

            public static ENResultOperation Obtener_Registro(Int32 nComp_Ide, Int32 nComp_Detalle_Ide)
            {
                SqlCommand CMD = new SqlCommand("SELECT * FROM V_COMPRA_PRODUCTOS_DETALLE  WHERE COMP_IDE = @IDE AND COMP_DETALLE_IDE = @IDE_DETALLE");

                CMD.Parameters.AddWithValue("@IDE", nComp_Ide);
                CMD.Parameters.AddWithValue("@IDE_DETALLE", nComp_Detalle_Ide);
                return ProcesarSQLDA.Procesar_SQL(CMD);

            }
            public static ENResultOperation Listar(Int32 nComp_Ide)
            {
                SqlCommand CMD = new SqlCommand("SELECT * FROM V_COMPRA_PRODUCTOS_DETALLE  WHERE COMP_IDE = @IDE");

                CMD.Parameters.AddWithValue("@IDE", nComp_Ide);
                return ProcesarSQLDA.Procesar_SQL(CMD);

            }
            public static ENResultOperation Buscar_Comprobante(Int32 nComp_Ide)
            {
                SqlCommand CMD = new SqlCommand("SELECT * FROM V_COMPRA_PRODUCTOSD_DETALLE  WHERE COMP_IDE = @IDE ");

                CMD.Parameters.AddWithValue("@IDE", nComp_Ide);
                return ProcesarSQLDA.Procesar_SQL(CMD);

            }

            public static ENResultOperation Listar_Filtro(string Texto_Buscar, string Condic_Buscar, DateTime FecIni, DateTime FecFin)
            {
                SqlCommand CMD = new SqlCommand("PA_COMPRA_PRODUCTOS_DETALLE_LISTAR_FILTRO");
                CMD.Parameters.Add(Parametros_SQL.nombre_error, SqlDbType.VarChar).Value = DBNull.Value;
                CMD.Parameters.Add("@FILTRO", SqlDbType.VarChar).Value = Texto_Buscar;
                CMD.Parameters.Add("@CONDIC", SqlDbType.VarChar).Value = Condic_Buscar;
                CMD.Parameters.Add("@FECINI", SqlDbType.DateTime).Value = FecIni;
                CMD.Parameters.Add("@FECFIN", SqlDbType.DateTime).Value = FecFin;

                CMD.Parameters.Add("@RETURN", SqlDbType.Int);
                CMD.Parameters["@RETURN"].Value = DBNull.Value;
                CMD.Parameters["@RETURN"].Direction = ParameterDirection.ReturnValue;
                return Compra_Productos_DetalleDA.Acceder(CMD);
            }
            public static ENResultOperation Listar_por_Fechas(DateTime Fecha_Inicio, DateTime Fecha_Fin)
            {
                SqlCommand CMD = new SqlCommand("PA_COMPRA_PRODUCTOS_DETALLE_LISTAR_POR_FECHAS");
                CMD.Parameters.Add(Parametros_SQL.nombre_error, SqlDbType.VarChar).Value = DBNull.Value;
                CMD.Parameters.Add("@FECINI", SqlDbType.DateTime).Value = Fecha_Inicio;
                CMD.Parameters.Add("@FECFIN", SqlDbType.DateTime).Value = Fecha_Fin;

                CMD.Parameters.Add("@RETURN", SqlDbType.Int);
                CMD.Parameters["@RETURN"].Value = DBNull.Value;
                CMD.Parameters["@RETURN"].Direction = ParameterDirection.ReturnValue;
                return Compra_Productos_DetalleDA.Acceder(CMD);
            }
       
    }
}
