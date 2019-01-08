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
    class Recojo_GastoDA
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

    public class ClsRecojo_GastoDA
    {
        public struct Parametros_SQL
        {

            public const string nombre_error = "@NOMBRE_ERROR"; // VARCHAR(100) OUTPUT,
            public const string ide = "@IDE"; //  INT" 
            public const string ide_detalle = "@IDE_DETALLE"; //  INT OUTPUT,
            public const string gasto = "@GASTO";  //  INT,
            public const string tipo_documento = "@TIPO_DOCUMENTO";  // INT,
            public const string serie = "@SERIE";  // VARCHAR(4),
            public const string numero = "@NUMERO";  // INT,
            public const string monto = "@MONTO";  // DECIMAL(18,2),
            public const string fecha = "@FECHA";  // DATETIME,
            public const string observacion = "@OBSERVACION";  // VARCHAR(60),
            public const string veces = "@VECES";  // integer,
            public const string usuario = "@USUARIO";  // CHAR(15)
        }

        public static ENResultOperation Crear(ClsRecojo_GastoBE Datos)
        {
            SqlCommand CMD = new SqlCommand("PA_RECOJO_INSERTA_GASTO");
            CMD.Parameters.Add(Parametros_SQL.nombre_error, SqlDbType.VarChar).Value = "";
            CMD.Parameters.Add(Parametros_SQL.ide, SqlDbType.Int).Value = Datos.Reco_ide;
            CMD.Parameters.Add(Parametros_SQL.ide_detalle, SqlDbType.Int).Value = Datos.Reco_ide_detalle;
            CMD.Parameters.Add(Parametros_SQL.gasto, SqlDbType.Int).Value = Datos.Gto_ope_ide;
            CMD.Parameters.Add(Parametros_SQL.tipo_documento, SqlDbType.Int).Value = Datos.Tipo_doc_ide;
            CMD.Parameters.Add(Parametros_SQL.serie, SqlDbType.VarChar).Value = Datos.Reco_serie_documento;
            CMD.Parameters.Add(Parametros_SQL.numero, SqlDbType.Int).Value = Datos.Reco_numero_documento;
            CMD.Parameters.Add(Parametros_SQL.monto, SqlDbType.Decimal).Value = Datos.Reco_monto;
            CMD.Parameters.Add(Parametros_SQL.fecha, SqlDbType.DateTime).Value = Datos.Reco_fecha;
            CMD.Parameters.Add(Parametros_SQL.observacion, SqlDbType.VarChar).Value = Datos.Reco_observacion;
            CMD.Parameters.Add(Parametros_SQL.veces, SqlDbType.Int).Value = Datos.Veces;
            CMD.Parameters.Add(Parametros_SQL.usuario, SqlDbType.VarChar).Value = Datos.Usuario;

            CMD.Parameters.Add("@RETURN", SqlDbType.Int);
            CMD.Parameters["@RETURN"].Value = DBNull.Value;
            CMD.Parameters["@RETURN"].Direction = ParameterDirection.ReturnValue;
            return Recojo_GastoDA.Acceder(CMD);
        }

        public static ENResultOperation Actualizar(ClsRecojo_GastoBE Datos)
        {
            SqlCommand CMD = new SqlCommand("PA_RECOJO_MODIFICA_GASTO");
            CMD.Parameters.Add(Parametros_SQL.nombre_error, SqlDbType.VarChar).Value = "";
            CMD.Parameters.Add(Parametros_SQL.ide, SqlDbType.Int).Value = Datos.Reco_ide;
            CMD.Parameters.Add(Parametros_SQL.ide_detalle, SqlDbType.Int).Value = Datos.Reco_ide_detalle;
            CMD.Parameters.Add(Parametros_SQL.gasto, SqlDbType.Int).Value = Datos.Gto_ope_ide;
            CMD.Parameters.Add(Parametros_SQL.tipo_documento, SqlDbType.Int).Value = Datos.Tipo_doc_ide;
            CMD.Parameters.Add(Parametros_SQL.serie, SqlDbType.VarChar).Value = Datos.Reco_serie_documento;
            CMD.Parameters.Add(Parametros_SQL.numero, SqlDbType.Int).Value = Datos.Reco_numero_documento;
            CMD.Parameters.Add(Parametros_SQL.monto, SqlDbType.Decimal).Value = Datos.Reco_monto;
            CMD.Parameters.Add(Parametros_SQL.fecha, SqlDbType.DateTime).Value = Datos.Reco_fecha;
            CMD.Parameters.Add(Parametros_SQL.observacion, SqlDbType.VarChar).Value = Datos.Reco_observacion;
            CMD.Parameters.Add(Parametros_SQL.veces, SqlDbType.Int).Value = Datos.Veces;
            CMD.Parameters.Add(Parametros_SQL.usuario, SqlDbType.VarChar).Value = Datos.Usuario;

            CMD.Parameters.Add("@RETURN", SqlDbType.Int);
            CMD.Parameters["@RETURN"].Value = DBNull.Value;
            CMD.Parameters["@RETURN"].Direction = ParameterDirection.ReturnValue;
            return Recojo_GastoDA.Acceder(CMD);

        }

        public static ENResultOperation Eliminar(ClsRecojo_GastoBE Datos)
        {
            SqlCommand CMD = new SqlCommand("PA_RECOJO_ELIMINA_GASTO");
            CMD.Parameters.Add(Parametros_SQL.nombre_error, SqlDbType.VarChar).Value = DBNull.Value;
            CMD.Parameters.Add(Parametros_SQL.ide, SqlDbType.Int).Value = Datos.Reco_ide;
            CMD.Parameters.Add(Parametros_SQL.ide_detalle, SqlDbType.Int).Value = Datos.Reco_ide_detalle;
            CMD.Parameters.Add(Parametros_SQL.veces, SqlDbType.Int).Value = Datos.Veces;
            CMD.Parameters.Add(Parametros_SQL.usuario, SqlDbType.VarChar).Value = Datos.Usuario;

            CMD.Parameters.Add("@RETURN", SqlDbType.Int);
            CMD.Parameters["@RETURN"].Value = DBNull.Value;
            CMD.Parameters["@RETURN"].Direction = ParameterDirection.ReturnValue;
            return Recojo_GastoDA.Acceder(CMD);
        }

        public static ENResultOperation Listar(Int32 Reco_ide)
        {
            string CmdSql = "SELECT RECO_IDE,RECO_IDE_DETALLE,GTO_OPE_IDE,(SELECT GTO_OPE_NOMBRE FROM GASTO_OPERACION WHERE GTO_OPE_IDE = RECOJO_GASTO.GTO_OPE_IDE) AS GTO_OPE_NOMBRE, " +
                            "TIPO_DOC_IDE,(SELECT TIPO_DOC_NOMBRE FROM TIPO_DOCUMENTO WHERE TIPO_DOC_IDE = RECOJO_GASTO.TIPO_DOC_IDE) AS TIPO_DOC_NOMBRE, " +
                            "RECO_SERIE_DOCUMENTO,RECO_NUMERO_DOCUMENTO,RECO_MONTO,RECO_OBSERVACION,RECO_FECHA,CREACION,VECES FROM RECOJO_GASTO " +
                            " WHERE RECO_IDE = @IDE ORDER BY RECO_IDE_DETALLE";
            SqlCommand CMD = new SqlCommand(CmdSql);
            CMD.Parameters.AddWithValue("@IDE", Reco_ide);
            return ProcesarSQLDA.Procesar_SQL(CMD);
            /*
            SqlCommand CMD = new SqlCommand("PA_RECOJO_GASTO_LISTAR");
            CMD.Parameters.Add(Parametros_SQL.nombre_error, SqlDbType.VarChar).Value = DBNull.Value;
            CMD.Parameters.Add(Parametros_SQL.ide, SqlDbType.Int).Value = Reco_ide;

            CMD.Parameters.Add("@RETURN", SqlDbType.Int);
            CMD.Parameters["@RETURN"].Value = DBNull.Value;
            CMD.Parameters["@RETURN"].Direction = ParameterDirection.ReturnValue;
            return Recojo_GastoDA.Acceder(CMD);
            */
        }

        public static ENResultOperation Listar_Filtro(Int32 Reco_Ide, Int32 Reco_Ide_Detalle)
        {
            SqlCommand CMD = new SqlCommand("PA_RECOJO_GASTO_LISTAR_FILTRO");
            CMD.Parameters.Add(Parametros_SQL.nombre_error, SqlDbType.VarChar).Value = DBNull.Value;
            CMD.Parameters.Add(Parametros_SQL.ide, SqlDbType.Int).Value = Reco_Ide;
            CMD.Parameters.Add(Parametros_SQL.ide_detalle, SqlDbType.Int).Value = Reco_Ide_Detalle;

            CMD.Parameters.Add("@RETURN", SqlDbType.Int);
            CMD.Parameters["@RETURN"].Value = DBNull.Value;
            CMD.Parameters["@RETURN"].Direction = ParameterDirection.ReturnValue;
            return Recojo_GastoDA.Acceder(CMD);
        }

        public static ENResultOperation Ultimo_Item(Int32 Reco_Ide)
        {
            SqlCommand CMD = new SqlCommand("PA_RECOJO_GASTO_ITEMS");
            CMD.Parameters.Add(Parametros_SQL.nombre_error, SqlDbType.VarChar).Value = DBNull.Value;
            CMD.Parameters.Add(Parametros_SQL.ide, SqlDbType.Int).Value = Reco_Ide;

            CMD.Parameters.Add("@RETURN", SqlDbType.Int);
            CMD.Parameters["@RETURN"].Value = DBNull.Value;
            CMD.Parameters["@RETURN"].Direction = ParameterDirection.ReturnValue;
            return Recojo_GastoDA.Acceder(CMD);
        }

        public static ENResultOperation Obtener_Registro(Int32 Reco_Ide, Int32 Reco_Ide_Detalle)
        {
            SqlCommand CMD = new SqlCommand("SELECT * FROM V_RECOJO_GASTO WHERE Reco_Ide = " +
                             Reco_Ide.ToString() + " AND Reco_Ide_Detalle = " + Reco_Ide_Detalle.ToString());

            return Recojo_GastoDA.Procesar_SQL(CMD);
        }
    }
}
