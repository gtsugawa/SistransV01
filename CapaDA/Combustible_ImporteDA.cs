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
    class Combustible_ImporteDA
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

    public class ClsCombustible_ImporteDA
    {
        private SqlDataReader dr = null;
        public struct Parametros_SQL
        {
            public const string nombre_error = "@NOMBRE_ERROR";
            public const string ide = "@IDE";
            public const string fecha = "@FECHA";
            public const string proveedor = "@PROVEEDOR";
            public const string tipo = "@TIPO";
            public const string importe = "@IMPORTE";
            public const string veces = "@VECES";
            public const string usuario = "@USUARIO";
        }

        public static ENResultOperation Crear(ClsCombustible_ImporteBE Datos)
        {
            SqlCommand CMD = new SqlCommand("PA_COMBUSTIBLE_IMPORTE_INSERTA");
            CMD.Parameters.Add(Parametros_SQL.nombre_error, SqlDbType.VarChar).Value = "";
            CMD.Parameters.Add(Parametros_SQL.ide, SqlDbType.Int).Value = Datos.Grifo_ide;
            CMD.Parameters.Add(Parametros_SQL.fecha, SqlDbType.DateTime).Value = Datos.Grifo_fecha;
            CMD.Parameters.Add(Parametros_SQL.proveedor, SqlDbType.Int).Value = Datos.Prov_ide;
            CMD.Parameters.Add(Parametros_SQL.tipo, SqlDbType.Int).Value = Datos.Grifo_tipo_combustible;
            CMD.Parameters.Add(Parametros_SQL.importe, SqlDbType.Decimal).Value = Datos.Grifo_importe;
            CMD.Parameters.Add(Parametros_SQL.veces, SqlDbType.Int).Value = Datos.Veces;
            CMD.Parameters.Add(Parametros_SQL.usuario, SqlDbType.VarChar).Value = Datos.Usuario;

            CMD.Parameters.Add("@RETURN", SqlDbType.Int);
            CMD.Parameters["@RETURN"].Value = DBNull.Value;
            CMD.Parameters["@RETURN"].Direction = ParameterDirection.ReturnValue;

            return Combustible_ImporteDA.Acceder(CMD);

        }

        public static ENResultOperation Actualizar(ClsCombustible_ImporteBE Datos)
        {
            SqlCommand CMD = new SqlCommand("PA_COMBUSTIBLE_IMPORTE_MODIFICA");
            CMD.Parameters.Add(Parametros_SQL.nombre_error, SqlDbType.VarChar).Value = "";
            CMD.Parameters.Add(Parametros_SQL.ide, SqlDbType.Int).Value = Datos.Grifo_ide;
            CMD.Parameters.Add(Parametros_SQL.fecha, SqlDbType.DateTime).Value = Datos.Grifo_fecha;
            CMD.Parameters.Add(Parametros_SQL.proveedor, SqlDbType.Int).Value = Datos.Prov_ide;
            CMD.Parameters.Add(Parametros_SQL.tipo, SqlDbType.Int).Value = Datos.Grifo_tipo_combustible;
            CMD.Parameters.Add(Parametros_SQL.importe, SqlDbType.Decimal).Value = Datos.Grifo_importe;

            CMD.Parameters.Add(Parametros_SQL.veces, SqlDbType.Int).Value = Datos.Veces;
            CMD.Parameters.Add(Parametros_SQL.usuario, SqlDbType.VarChar).Value = Datos.Usuario;

            CMD.Parameters.Add("@RETURN", SqlDbType.Int);
            CMD.Parameters["@RETURN"].Value = DBNull.Value;
            CMD.Parameters["@RETURN"].Direction = ParameterDirection.ReturnValue;

            return Combustible_ImporteDA.Acceder(CMD);

        }

        public static ENResultOperation Eliminar(ClsCombustible_ImporteBE Datos)
        {
            SqlCommand CMD = new SqlCommand("PA_COMBUSTIBLE_IMPORTE_ELIMINA");
            CMD.Parameters.Add(Parametros_SQL.nombre_error, SqlDbType.VarChar).Value = DBNull.Value;
            CMD.Parameters.Add(Parametros_SQL.ide, SqlDbType.Int).Value = Datos.Grifo_ide;
            CMD.Parameters.Add(Parametros_SQL.veces, SqlDbType.Int).Value = Datos.Veces;
            CMD.Parameters.Add(Parametros_SQL.usuario, SqlDbType.VarChar).Value = Datos.Usuario;

            CMD.Parameters.Add("@RETURN", SqlDbType.Int);
            CMD.Parameters["@RETURN"].Value = DBNull.Value;
            CMD.Parameters["@RETURN"].Direction = ParameterDirection.ReturnValue;


            return Combustible_ImporteDA.Acceder(CMD);
        }

        public static ENResultOperation Listar(string Texto_Buscar)
        {
            SqlCommand CMD = new SqlCommand("SELECT * FROM COMBUSTIBLE_IMPORTE  WHERE PROV_IDE LIKE '" +
                   Texto_Buscar + "%'");
            return ProcesarSQLDA.Procesar_SQL(CMD);
  
        }

        public static ENResultOperation Listar_Filtro(string Texto_Buscar, DateTime Fecha_Buscar)
        {
            string CmdSql = "SELECT * FROM V_COMBUSTIBLE_IMPORTE WHERE PROV_IDE = @IDE AND (DATEPART(YEAR,GRIFO_FECHA) = DATEPART(YEAR,@FECHA)) AND " +
                            "(DATEPART(MONTH,GRIFO_FECHA) = DATEPART(MONTH,@FECHA)) ORDER BY GRIFO_FECHA,GRIFO_TIPO_COMBUSTIBLE";
            SqlCommand CMD = new SqlCommand(CmdSql);
            CMD.Parameters.AddWithValue("@IDE", Texto_Buscar);
            CMD.Parameters.AddWithValue("@FECHA",Fecha_Buscar);
            return ProcesarSQLDA.Procesar_SQL(CMD);
            
        }

        public static ENResultOperation Obtener_Registro(Int32 Prove_Ide, DateTime Fecha_Buscar, Int32 TipoCombustible)
        {
            string CmdSql = "SELECT * FROM COMBUSTIBLE_IMPORTE WHERE PROV_IDE = @IDE AND GRIFO_FECHA = @FECHA AND GRIFO_TIPO_COMBUSTIBLE = @TIPO";

            SqlCommand CMD = new SqlCommand(CmdSql);
            CMD.Parameters.AddWithValue("@IDE", Prove_Ide);
            CMD.Parameters.AddWithValue("@FECHA", Fecha_Buscar);
            CMD.Parameters.AddWithValue("@TIPO", TipoCombustible);
            return ProcesarSQLDA.Procesar_SQL(CMD);
        }

    }
}
