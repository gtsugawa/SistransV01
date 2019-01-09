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
    class Productos_ConsumoDA
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
    public class ClsProductos_ConsumoDA
    {
        private SqlDataReader dr = null;
        public struct Parametros_SQL
        {
            public const string nombre_error = "@NOMBRE_ERROR";
            public const string cons_ide = "@IDE";
            public const string tran_ide = "@TRAN_IDE";
            public const string tran_vehi_ide = "@TRAN_VEHI_IDE";
            public const string cons_fecha = "@FECHA";
            public const string comp_ide = "@COMP_IDE";
            public const string comp_detalle_ide = "COMP_DETALLE_IDE";
            public const string cons_cantidad = "@CANTIDAD";
            public const string estado = "@ESTADO";
        }

        public static ENResultOperation Crear(ClsProductos_ConsumoBE Datos)
        {
            SqlCommand CMD = new SqlCommand("PA_PRODUCTOS_CONSUMO_INSERTA");
            CMD.Parameters.Add(Parametros_SQL.nombre_error, SqlDbType.VarChar).Value = "";
            CMD.Parameters.Add(Parametros_SQL.cons_ide, SqlDbType.Int).Value = Datos.Cons_ide;
            CMD.Parameters.Add(Parametros_SQL.cons_fecha, SqlDbType.DateTime).Value = Datos.Cons_fecha;
            CMD.Parameters.Add(Parametros_SQL.tran_ide, SqlDbType.Int).Value = Datos.Tran_ide;
            CMD.Parameters.Add(Parametros_SQL.tran_vehi_ide, SqlDbType.Int).Value = Datos.Tran_vehi_ide;
            CMD.Parameters.Add(Parametros_SQL.comp_ide, SqlDbType.Int).Value = Datos.Comp_ide;
            CMD.Parameters.Add(Parametros_SQL.comp_detalle_ide, SqlDbType.Int).Value = Datos.Comp_detalle_ide;
            CMD.Parameters.Add(Parametros_SQL.cons_cantidad, SqlDbType.Decimal).Value = Datos.Cons_cantidad;
            CMD.Parameters.Add(Parametros_SQL.estado, SqlDbType.Int).Value = Datos.Estado;

            CMD.Parameters.Add("@RETURN", SqlDbType.Int);
            CMD.Parameters["@RETURN"].Value = DBNull.Value;
            CMD.Parameters["@RETURN"].Direction = ParameterDirection.ReturnValue;

            return Productos_ConsumoDA.Acceder(CMD);

        }

        public static ENResultOperation Actualizar(ClsProductos_ConsumoBE Datos)
        {
            SqlCommand CMD = new SqlCommand("PA_PRODUCTOS_CONSUMO_MODIFICA");
            CMD.Parameters.Add(Parametros_SQL.nombre_error, SqlDbType.VarChar).Value = "";
            CMD.Parameters.Add(Parametros_SQL.cons_ide, SqlDbType.Int).Value = Datos.Cons_ide;
            CMD.Parameters.Add(Parametros_SQL.cons_fecha, SqlDbType.DateTime).Value = Datos.Cons_fecha;
            CMD.Parameters.Add(Parametros_SQL.tran_ide, SqlDbType.Int).Value = Datos.Tran_ide;
            CMD.Parameters.Add(Parametros_SQL.tran_vehi_ide, SqlDbType.Int).Value = Datos.Tran_vehi_ide;
            CMD.Parameters.Add(Parametros_SQL.comp_ide, SqlDbType.Int).Value = Datos.Comp_ide;
            CMD.Parameters.Add(Parametros_SQL.comp_detalle_ide, SqlDbType.Int).Value = Datos.Comp_detalle_ide;
            CMD.Parameters.Add(Parametros_SQL.cons_cantidad, SqlDbType.Decimal).Value = Datos.Cons_cantidad;
            CMD.Parameters.Add(Parametros_SQL.estado, SqlDbType.Int).Value = Datos.Estado;

            CMD.Parameters.Add("@RETURN", SqlDbType.Int);
            CMD.Parameters["@RETURN"].Value = DBNull.Value;
            CMD.Parameters["@RETURN"].Direction = ParameterDirection.ReturnValue;

            return Productos_ConsumoDA.Acceder(CMD);

        }

        public static ENResultOperation Eliminar(ClsProductos_ConsumoBE Datos)
        {
            SqlCommand CMD = new SqlCommand("PA_PRODUCTOS_CONSUMO_ELIMINA");
            CMD.Parameters.Add(Parametros_SQL.nombre_error, SqlDbType.VarChar).Value = DBNull.Value;
            CMD.Parameters.Add(Parametros_SQL.cons_ide, SqlDbType.Int).Value = Datos.Cons_ide;

            CMD.Parameters.Add("@RETURN", SqlDbType.Int);
            CMD.Parameters["@RETURN"].Value = DBNull.Value;
            CMD.Parameters["@RETURN"].Direction = ParameterDirection.ReturnValue;


            return Productos_ConsumoDA.Acceder(CMD);
        }

        public static ENResultOperation Listar(string Texto_Buscar)
        {
            SqlCommand CMD = new SqlCommand("SELECT * FROM V_PRODUCTOS_CONSUMO  WHERE PROV_IDE LIKE '" +
                   Texto_Buscar + "%' ORDER BY COMP_FECHA,COMP_NUMERO");
            return ProcesarSQLDA.Procesar_SQL(CMD);

        }
        public static ENResultOperation Buscar_Comprobante(Int32 nComp_Ide)
        {
            SqlCommand CMD = new SqlCommand("SELECT * FROM V_PRODUCTOS_CONSUMO  WHERE COMP_IDE = @IDE ");

            CMD.Parameters.AddWithValue("@IDE", nComp_Ide);
            return ProcesarSQLDA.Procesar_SQL(CMD);

        }

        public static ENResultOperation Listar_Filtro(string Texto_Buscar, string Condic_Buscar, DateTime FecIni, DateTime FecFin)
        {
            SqlCommand CMD = new SqlCommand("PA_PRODUCTOS_CONSUMO_LISTAR_FILTRO");
            CMD.Parameters.Add(Parametros_SQL.nombre_error, SqlDbType.VarChar).Value = DBNull.Value;
            CMD.Parameters.Add("@FILTRO", SqlDbType.VarChar).Value = Texto_Buscar;
            CMD.Parameters.Add("@CONDIC", SqlDbType.VarChar).Value = Condic_Buscar;
            CMD.Parameters.Add("@FECINI", SqlDbType.DateTime).Value = FecIni;
            CMD.Parameters.Add("@FECFIN", SqlDbType.DateTime).Value = FecFin;

            CMD.Parameters.Add("@RETURN", SqlDbType.Int);
            CMD.Parameters["@RETURN"].Value = DBNull.Value;
            CMD.Parameters["@RETURN"].Direction = ParameterDirection.ReturnValue;
            CMD.Parameters["@RETURN"].Direction = ParameterDirection.ReturnValue;
            CMD.Parameters["@RETURN"].Direction = ParameterDirection.ReturnValue;
            return Productos_ConsumoDA.Acceder(CMD);
        }
        public static ENResultOperation Listar_por_Fechas(DateTime Fecha_Inicio, DateTime Fecha_Fin)
        {
            SqlCommand CMD = new SqlCommand("PA_PRODUCTOS_CONSUMO_LISTAR_POR_FECHAS");
            CMD.Parameters.Add(Parametros_SQL.nombre_error, SqlDbType.VarChar).Value = DBNull.Value;
            CMD.Parameters.Add("@FECINI", SqlDbType.DateTime).Value = Fecha_Inicio;
            CMD.Parameters.Add("@FECFIN", SqlDbType.DateTime).Value = Fecha_Fin;

            CMD.Parameters.Add("@RETURN", SqlDbType.Int);
            CMD.Parameters["@RETURN"].Value = DBNull.Value;
            CMD.Parameters["@RETURN"].Direction = ParameterDirection.ReturnValue;
            return Productos_ConsumoDA.Acceder(CMD);
        }
    }
}
