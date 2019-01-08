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
    class Factura_Carga_Detalle_RecojoDA
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
    public class ClsFactura_Carga_Detalle_RecojoDA
    {
        public struct Parametros_SQL
        {
            public const string nombre_error = "@NOMBRE_ERROR";
            public const string ide = "@IDE INT";
            public const string ide_detalle = "@IDE_DETALLE"; // INT OUTPUT,
            public const string ide_recojo = "@IDE_RECOJO"; // INT,
            public const string venta = "@VENTA"; // DECIMAL(18,4),
            public const string venta_neto = "@VENTA_NETO"; // DECIMAL(18,4),
            public const string tipo_impuesto = "@TIPO_IMPUESTO"; // VARCHAR(50),
            public const string precio = "@PRECIO"; // DECIMAL(18,4),
            public const string cantidad = "@CANTIDAD"; //DECIMAL(18,3),
            public const string sub_total_detalle = "@SUB_TOTAL_DETALLE"; //DECIMAL(18,2),
            public const string nota = "@NOTA"; // VARCHAR(150),
            public const string sub_total = "@SUB_TOTAL"; //DECIMAL(18,2) OUTPUT,
            public const string impuesto = "@IMPUESTO"; // DECIMAL(18,2) OUTPUT,
            public const string total = "@TOTAL"; // DECIMAL(18,2) OUTPUT,
            public const string veces = "@VECES";  // integer,
            public const string usuario = "@USUARIO"; // CHAR(15)
        }

        public static ENResultOperation Crear(ClsFactura_Carga_Detalle_RecojoBE Datos)
        {
            SqlCommand CMD = new SqlCommand("PA_FACTURA_CARGA_INSERTA_DETALLE_RECOJO");
            CMD.Parameters.Add(Parametros_SQL.nombre_error, SqlDbType.VarChar).Value = "";
            CMD.Parameters.Add(Parametros_SQL.ide, SqlDbType.Int).Value = Datos.Fact_ide;
            CMD.Parameters.Add(Parametros_SQL.ide_detalle, SqlDbType.Int).Value = Datos.Fact_ide_detalle;
            CMD.Parameters.Add(Parametros_SQL.ide_recojo, SqlDbType.Int).Value = Datos.Reco_ide;
            CMD.Parameters.Add(Parametros_SQL.venta, SqlDbType.Decimal).Value = Datos.Fact_valor_bruto;
            CMD.Parameters.Add(Parametros_SQL.venta_neto, SqlDbType.Decimal).Value = Datos.Fact_valor_neto;
            CMD.Parameters.Add(Parametros_SQL.tipo_impuesto, SqlDbType.VarChar).Value = Datos.Fact_tipo_impuesto;
            CMD.Parameters.Add(Parametros_SQL.precio, SqlDbType.Decimal).Value = Datos.Fact_precio_neto;
            CMD.Parameters.Add(Parametros_SQL.cantidad, SqlDbType.Decimal).Value = Datos.Fact_cantidad;
            CMD.Parameters.Add(Parametros_SQL.sub_total_detalle, SqlDbType.Decimal).Value = Datos.Fact_valor_total;
            CMD.Parameters.Add(Parametros_SQL.nota, SqlDbType.VarChar).Value = Datos.Fact_nota;
            CMD.Parameters.Add(Parametros_SQL.sub_total, SqlDbType.Decimal).Value = 0;
            CMD.Parameters.Add(Parametros_SQL.impuesto, SqlDbType.Decimal).Value = Datos.Fact_impuesto;
            CMD.Parameters.Add(Parametros_SQL.total, SqlDbType.Decimal).Value = 0;
            CMD.Parameters.Add(Parametros_SQL.veces, SqlDbType.Int).Value = Datos.Veces;
            CMD.Parameters.Add(Parametros_SQL.usuario, SqlDbType.VarChar).Value = Datos.Usuario;

            CMD.Parameters.Add("@RETURN", SqlDbType.Int);
            CMD.Parameters["@RETURN"].Value = DBNull.Value;
            CMD.Parameters["@RETURN"].Direction = ParameterDirection.ReturnValue;

            return Factura_Carga_Detalle_RecojoDA.Acceder(CMD);

        }

        public static ENResultOperation Actualizar(ClsFactura_Carga_Detalle_RecojoBE Datos)
        {
            SqlCommand CMD = new SqlCommand("PA_FACTURA_CARGA_MODIFICA_DETALLE_RECOJO");
            CMD.Parameters.Add(Parametros_SQL.nombre_error, SqlDbType.VarChar).Value = "";
            CMD.Parameters.Add(Parametros_SQL.ide, SqlDbType.Int).Value = Datos.Fact_ide;
            CMD.Parameters.Add(Parametros_SQL.ide_detalle, SqlDbType.Int).Value = Datos.Fact_ide_detalle;
            CMD.Parameters.Add(Parametros_SQL.ide_recojo, SqlDbType.Int).Value = Datos.Reco_ide;
            CMD.Parameters.Add(Parametros_SQL.venta, SqlDbType.Decimal).Value = Datos.Fact_valor_bruto;
            CMD.Parameters.Add(Parametros_SQL.venta_neto, SqlDbType.Decimal).Value = Datos.Fact_valor_neto;
            CMD.Parameters.Add(Parametros_SQL.tipo_impuesto, SqlDbType.VarChar).Value = Datos.Fact_tipo_impuesto;
            CMD.Parameters.Add(Parametros_SQL.precio, SqlDbType.Decimal).Value = Datos.Fact_precio_neto;
            CMD.Parameters.Add(Parametros_SQL.cantidad, SqlDbType.Decimal).Value = Datos.Fact_cantidad;
            CMD.Parameters.Add(Parametros_SQL.sub_total_detalle, SqlDbType.Decimal).Value = Datos.Fact_valor_total;
            CMD.Parameters.Add(Parametros_SQL.nota, SqlDbType.VarChar).Value = Datos.Fact_nota;
            CMD.Parameters.Add(Parametros_SQL.sub_total, SqlDbType.Decimal).Value = 0;
            CMD.Parameters.Add(Parametros_SQL.impuesto, SqlDbType.Decimal).Value = Datos.Fact_impuesto;
            CMD.Parameters.Add(Parametros_SQL.total, SqlDbType.Decimal).Value = 0;
            CMD.Parameters.Add(Parametros_SQL.veces, SqlDbType.Int).Value = Datos.Veces;
            CMD.Parameters.Add(Parametros_SQL.usuario, SqlDbType.VarChar).Value = Datos.Usuario;

            CMD.Parameters["@RETURN"].Value = DBNull.Value;
            CMD.Parameters["@RETURN"].Direction = ParameterDirection.ReturnValue;

            return Factura_Carga_Detalle_RecojoDA.Acceder(CMD);

        }

        public static ENResultOperation Eliminar(ClsFactura_Carga_Detalle_RecojoBE Datos)
        {
            SqlCommand CMD = new SqlCommand("PA_FACTURA_CARGA_ELIMINA_DETALLE_RECOJO");
            CMD.Parameters.Add(Parametros_SQL.nombre_error, SqlDbType.VarChar).Value = DBNull.Value;
            CMD.Parameters.Add(Parametros_SQL.ide, SqlDbType.Int).Value = Datos.Fact_ide;
            CMD.Parameters.Add(Parametros_SQL.veces, SqlDbType.Int).Value = Datos.Veces;
            CMD.Parameters.Add(Parametros_SQL.usuario, SqlDbType.VarChar).Value = Datos.Usuario;

            CMD.Parameters.Add("@RETURN", SqlDbType.Int);
            CMD.Parameters["@RETURN"].Value = DBNull.Value;
            CMD.Parameters["@RETURN"].Direction = ParameterDirection.ReturnValue;


            return Factura_Carga_Detalle_RecojoDA.Acceder(CMD);
        }

        public static ENResultOperation Listar(int Texto_Buscar)
        {
            SqlCommand CMD = new SqlCommand("SELECT * FROM V_FACTURA_CARGA_DETALLE WHERE FACT_IDE = @IDE ORDER BY FACT_IDE,FACT_IDE_DETALLE") ;

            CMD.Parameters.AddWithValue("@IDE",Texto_Buscar);
            return ProcesarSQLDA.Procesar_SQL(CMD);

        }

        public static ENResultOperation Listar_Filtro(string Texto_Buscar)
        {
            SqlCommand CMD = new SqlCommand("PA_PA_FACTURA_CARGA_DETALLE_RECOJO_FILTRAR");
            CMD.Parameters.Add(Parametros_SQL.nombre_error, SqlDbType.VarChar).Value = Texto_Buscar;

            CMD.Parameters.Add("@RETURN", SqlDbType.Int);
            CMD.Parameters["@RETURN"].Value = DBNull.Value;
            CMD.Parameters["@RETURN"].Direction = ParameterDirection.ReturnValue;

            return Factura_Carga_Detalle_RecojoDA.Acceder(CMD);
        }
    }
}
