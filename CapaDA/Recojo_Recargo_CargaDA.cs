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
    class Recojo_Recargo_CargaDA
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

    public class ClsRecojo_Recargo_CargaDA
    {
        public struct Parametros_SQL
        {

            public const string nombre_error = "@NOMBRE_ERROR"; // VARCHAR(100) OUTPUT,
            public const string ide = "@IDE"; //  INT" 
            public const string ide_detalle = "@IDE_DETALLE"; //  INT OUTPUT,
            public const string recargo = "@RECARGO";  //  INT,
            public const string porcentaje = "@PORCENTAJE";  //  DECIMAL,
            public const string veces = "@VECES";  // integer,
            public const string usuario = "@USUARIO";  // CHAR(15)
        }

        public static ENResultOperation Crear(ClsRecojo_Recargo_CargaBE Datos)
        {
            SqlCommand CMD = new SqlCommand("PA_RECOJO_INSERTA_RECARGO");
            CMD.Parameters.Add(Parametros_SQL.nombre_error, SqlDbType.VarChar).Value = "";
            CMD.Parameters.Add(Parametros_SQL.ide, SqlDbType.Int).Value = Datos.Reco_ide;
            CMD.Parameters.Add(Parametros_SQL.ide_detalle, SqlDbType.Int).Value = Datos.Reco_ide_detalle;
            CMD.Parameters.Add(Parametros_SQL.recargo, SqlDbType.Int).Value = Datos.Merca_ide;
            CMD.Parameters.Add(Parametros_SQL.porcentaje, SqlDbType.Decimal).Value = Datos.Reco_porcentaje; ;
            CMD.Parameters.Add(Parametros_SQL.veces, SqlDbType.Int).Value = Datos.Veces;
            CMD.Parameters.Add(Parametros_SQL.usuario, SqlDbType.VarChar).Value = Datos.Usuario;

            CMD.Parameters.Add("@RETURN", SqlDbType.Int);
            CMD.Parameters["@RETURN"].Value = DBNull.Value;
            CMD.Parameters["@RETURN"].Direction = ParameterDirection.ReturnValue;
            return Recojo_Recargo_CargaDA.Acceder(CMD);
        }

        public static ENResultOperation Actualizar(ClsRecojo_Recargo_CargaBE Datos)
        {
            SqlCommand CMD = new SqlCommand("PA_RECOJO_MODIFICA_RECARGO");
            CMD.Parameters.Add(Parametros_SQL.nombre_error, SqlDbType.VarChar).Value = "";
            CMD.Parameters.Add(Parametros_SQL.ide, SqlDbType.Int).Value = Datos.Reco_ide;
            CMD.Parameters.Add(Parametros_SQL.ide_detalle, SqlDbType.Int).Value = Datos.Reco_ide_detalle;
            CMD.Parameters.Add(Parametros_SQL.recargo, SqlDbType.Int).Value = Datos.Merca_ide;
            CMD.Parameters.Add(Parametros_SQL.porcentaje, SqlDbType.Decimal).Value = Datos.Reco_porcentaje; ;
            CMD.Parameters.Add(Parametros_SQL.veces, SqlDbType.Int).Value = Datos.Veces;
            CMD.Parameters.Add(Parametros_SQL.usuario, SqlDbType.VarChar).Value = Datos.Usuario;

            CMD.Parameters.Add("@RETURN", SqlDbType.Int);
            CMD.Parameters["@RETURN"].Value = DBNull.Value;
            CMD.Parameters["@RETURN"].Direction = ParameterDirection.ReturnValue;
            return Recojo_Recargo_CargaDA.Acceder(CMD);

        }

        public static ENResultOperation Eliminar(ClsRecojo_Recargo_CargaBE Datos)
        {
            SqlCommand CMD = new SqlCommand("PA_RECOJO_ELIMINA_RECARGO");
            CMD.Parameters.Add(Parametros_SQL.nombre_error, SqlDbType.VarChar).Value = DBNull.Value;
            CMD.Parameters.Add(Parametros_SQL.ide, SqlDbType.Int).Value = Datos.Reco_ide;
            CMD.Parameters.Add(Parametros_SQL.ide_detalle, SqlDbType.Int).Value = Datos.Reco_ide_detalle;
            CMD.Parameters.Add(Parametros_SQL.veces, SqlDbType.Int).Value = Datos.Veces;
            CMD.Parameters.Add(Parametros_SQL.usuario, SqlDbType.VarChar).Value = Datos.Usuario;

            CMD.Parameters.Add("@RETURN", SqlDbType.Int);
            CMD.Parameters["@RETURN"].Value = DBNull.Value;
            CMD.Parameters["@RETURN"].Direction = ParameterDirection.ReturnValue;
            return Recojo_Recargo_CargaDA.Acceder(CMD);
        }

        public static ENResultOperation Listar(Int32 Reco_ide)
        {
            string CmdSql = "SELECT RECO_IDE,RECO_IDE_DETALLE,MERCA_IDE," +
                             "(SELECT ARTI_NOMBRE FROM ARTICULO WHERE ARTI_IDE = RECOJO_RECARGO_CARGA.MERCA_IDE) AS MERCA_NOMBRE," +
                             "RECO_PORCENTAJE FROM RECOJO_RECARGO_CARGA WHERE RECO_IDE = @IDE ORDER BY RECO_IDE_DETALLE ";
            SqlCommand CMD = new SqlCommand(CmdSql);
            CMD.Parameters.AddWithValue("@IDE", Reco_ide);
            return ProcesarSQLDA.Procesar_SQL(CMD);
        }

        public static ENResultOperation Listar_Filtro(Int32 Reco_Ide, Int32 Reco_Ide_Detalle)
        {
            string CmdSql =  "SELECT RECO_IDE,RECO_IDE_DETALLE,MERCA_IDE," +
                             "(SELECT ARTI_NOMBRE FROM ARTICULO WHERE ARTI_IDE = RECOJO_RECARGO_CARGA.MERCA_IDE) AS MERCA_NOMBRE," +
                             "RECO_PORCENTAJE FROM RECOJO_RECARGO_CARGA WHERE RECO_IDE = @IDE AND RECO_IDE_DETALLE = @IDE_DETALLE ORDER BY RECO_IDE " ;
            SqlCommand CMD = new SqlCommand(CmdSql);
            CMD.Parameters.AddWithValue("@IDE", Reco_Ide);
            CMD.Parameters.AddWithValue("@IDE_DETALLE", Reco_Ide_Detalle);
            return ProcesarSQLDA.Procesar_SQL(CMD);
        }

        public static ENResultOperation Ultimo_Item(Int32 Reco_Ide)
        {
            SqlCommand CMD = new SqlCommand("PA_RECOJO_RECARGO_ITEMS");
            CMD.Parameters.Add(Parametros_SQL.nombre_error, SqlDbType.VarChar).Value = DBNull.Value;
            CMD.Parameters.Add(Parametros_SQL.ide, SqlDbType.Int).Value = Reco_Ide;

            CMD.Parameters.Add("@RETURN", SqlDbType.Int);
            CMD.Parameters["@RETURN"].Value = DBNull.Value;
            CMD.Parameters["@RETURN"].Direction = ParameterDirection.ReturnValue;
            return Recojo_Recargo_CargaDA.Acceder(CMD);
        }

        public static ENResultOperation Obtener_Registro(Int32 Reco_Ide, Int32 Reco_Ide_Detalle)
        {
            SqlCommand CMD = new SqlCommand("SELECT * FROM RECOJO_RECARGO_CARGA WHERE Reco_Ide = @IDE " +
                                            " AND Reco_Ide_Detalle = @IDE_DETALLE");
            CMD.Parameters.AddWithValue("@IDE", Reco_Ide);
            CMD.Parameters.AddWithValue("@IDE_DETALLE", Reco_Ide_Detalle);
            return Recojo_Recargo_CargaDA.Procesar_SQL(CMD);
        }
    }
}
