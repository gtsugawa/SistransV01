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
    class Recojo_AyudanteDA
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
    
    public class ClsRecojo_AyudanteDA
    {
        public struct Parametros_SQL
        {

            public const string nombre_error = "@NOMBRE_ERROR"; // VARCHAR(100) OUTPUT,
            public const string ide = "@IDE"; //  INT" 
            public const string ide_detalle = "@IDE_DETALLE"; //  INT OUTPUT,
            public const string ayudante = "@AYUDANTE"; // INT,
            public const string veces = "@VECES";  // integer,
            public const string usuario = "@USUARIO";  // CHAR(15)
        }

        public static ENResultOperation Crear(ClsRecojo_AyudanteBE Datos)
        {
            SqlCommand CMD = new SqlCommand("PA_RECOJO_INSERTA_AYUDANTE");
            CMD.Parameters.Add(Parametros_SQL.nombre_error, SqlDbType.VarChar).Value = "";
            CMD.Parameters.Add(Parametros_SQL.ide, SqlDbType.Int).Value = Datos.Reco_ide;
            CMD.Parameters.Add(Parametros_SQL.ide_detalle, SqlDbType.Int).Value = Datos.Reco_ide_detalle;
            CMD.Parameters.Add(Parametros_SQL.ayudante, SqlDbType.Int).Value = Datos.Tran_cont_ide;
            CMD.Parameters.Add(Parametros_SQL.veces, SqlDbType.Int).Value = Datos.Veces;
            CMD.Parameters.Add(Parametros_SQL.usuario, SqlDbType.VarChar).Value = Datos.Usuario;

            CMD.Parameters.Add("@RETURN", SqlDbType.Int);
            CMD.Parameters["@RETURN"].Value = DBNull.Value;
            CMD.Parameters["@RETURN"].Direction = ParameterDirection.ReturnValue;
            return Recojo_AyudanteDA.Acceder(CMD);
        }

        public static ENResultOperation Actualizar(ClsRecojo_AyudanteBE Datos)
        {
            SqlCommand CMD = new SqlCommand("PA_RECOJO_MODIFICA_AYUDANTE");
            CMD.Parameters.Add(Parametros_SQL.nombre_error, SqlDbType.VarChar).Value = "";
            CMD.Parameters.Add(Parametros_SQL.ide, SqlDbType.Int).Value = Datos.Reco_ide;
            CMD.Parameters.Add(Parametros_SQL.ide_detalle, SqlDbType.Int).Value = Datos.Reco_ide_detalle;
            CMD.Parameters.Add(Parametros_SQL.ayudante, SqlDbType.Int).Value = Datos.Tran_cont_ide;
            CMD.Parameters.Add(Parametros_SQL.veces, SqlDbType.Int).Value = Datos.Veces;
            CMD.Parameters.Add(Parametros_SQL.usuario, SqlDbType.VarChar).Value = Datos.Usuario;

            CMD.Parameters.Add("@RETURN", SqlDbType.Int);
            CMD.Parameters["@RETURN"].Value = DBNull.Value;
            CMD.Parameters["@RETURN"].Direction = ParameterDirection.ReturnValue;
            return Recojo_AyudanteDA.Acceder(CMD);

        }

        public static ENResultOperation Eliminar(ClsRecojo_AyudanteBE Datos)
        {
            SqlCommand CMD = new SqlCommand("PA_RECOJO_ELIMINA_AYUDANTE");
            CMD.Parameters.Add(Parametros_SQL.nombre_error, SqlDbType.VarChar).Value = DBNull.Value;
            CMD.Parameters.Add(Parametros_SQL.ide, SqlDbType.Int).Value = Datos.Reco_ide;
            CMD.Parameters.Add(Parametros_SQL.ide_detalle, SqlDbType.Int).Value = Datos.Reco_ide_detalle;
            CMD.Parameters.Add(Parametros_SQL.veces, SqlDbType.Int).Value = Datos.Veces;
            CMD.Parameters.Add(Parametros_SQL.usuario, SqlDbType.VarChar).Value = Datos.Usuario;

            CMD.Parameters.Add("@RETURN", SqlDbType.Int);
            CMD.Parameters["@RETURN"].Value = DBNull.Value;
            CMD.Parameters["@RETURN"].Direction = ParameterDirection.ReturnValue;
            return Recojo_AyudanteDA.Acceder(CMD);
        }

        public static ENResultOperation Listar(Int32 Reco_Ide)
        {
            
             string CmdSql = "SELECT A.RECO_IDE,A.RECO_IDE_DETALLE,A.TRAN_CONT_IDE,(SELECT B.TRAN_IDE FROM RECOJO_CABECERA B WHERE B.RECO_IDE = A.RECO_IDE) AS TRAN_IDE, " +
                      "(SELECT C.TRAN_CONT_PATERNO + ' ' + C.TRAN_CONT_MATERNO + ' ' + C.TRAN_CONT_NOMBRE FROM TRANSPORTISTA_CONTACTO C WHERE C.TRAN_IDE = " +
                      "(SELECT TRAN_IDE FROM RECOJO_CABECERA WHERE RECO_IDE = A.RECO_IDE) AND TRAN_CONT_IDE = A.TRAN_CONT_IDE ) AS NOMBRE_COMPLETO " +
                      "FROM RECOJO_AYUDANTE A  WHERE A.RECO_IDE = @IDE";
            SqlCommand CMD = new SqlCommand(CmdSql);
            CMD.Parameters.AddWithValue("@IDE", Reco_Ide);
            return ProcesarSQLDA.Procesar_SQL(CMD);
            /*
            SqlCommand CMD = new SqlCommand("PA_RECOJO_AYUDANTE_LISTAR");
            CMD.Parameters.Add(Parametros_SQL.nombre_error, SqlDbType.VarChar).Value = DBNull.Value;
            CMD.Parameters.Add(Parametros_SQL.ide, SqlDbType.Int).Value = Reco_ide;

            CMD.Parameters.Add("@RETURN", SqlDbType.Int);
            CMD.Parameters["@RETURN"].Value = DBNull.Value;
            CMD.Parameters["@RETURN"].Direction = ParameterDirection.ReturnValue;
            return Recojo_AyudanteDA.Acceder(CMD);
            */
        }

        public static ENResultOperation Listar_Filtro(Int32 Reco_Ide, Int32 Reco_Ide_Detalle)
        {
            string CmdSql = "SELECT A.RECO_IDE,A.RECO_IDE_DETALLE,A.TRAN_CONT_IDE,(SELECT B.TRAN_IDE FROM RECOJO_CABECERA B WHERE B.RECO_IDE = A.RECO_IDE) AS TRAN_IDE, " +
                            "(SELECT C.TRAN_CONT_PATERNO + ' ' + C.TRAN_CONT_MATERNO + ' ' + C.TRAN_CONT_NOMBRE FROM TRANSPORTISTA_CONTACTO C WHERE C.TRAN_IDE = (SELECT TRAN_IDE FROM RECOJO_CABECERA WHERE RECO_IDE = A.RECO_IDE) AND TRAN_CONT_IDE = A.TRAN_CONT_IDE ) AS NOMBRE_COMPLETO " +
                            "FROM RECOJO_AYUDANTE A  WHERE A.RECO_IDE = @IDE AND A.RECO_IDE_DETALLE = @IDE_DETALLE ";
            SqlCommand CMD = new SqlCommand(CmdSql);
            CMD.Parameters.AddWithValue("@IDE", Reco_Ide);
            CMD.Parameters.AddWithValue("@IDE_DETALLE", Reco_Ide_Detalle);
            return ProcesarSQLDA.Procesar_SQL(CMD);
            /*
            SqlCommand CMD = new SqlCommand("PA_RECOJO_AYUDANTE_LISTAR_FILTRO");
            CMD.Parameters.Add(Parametros_SQL.nombre_error, SqlDbType.VarChar).Value = DBNull.Value;
            CMD.Parameters.Add(Parametros_SQL.ide, SqlDbType.Int).Value = Reco_Ide;
            CMD.Parameters.Add(Parametros_SQL.ide_detalle, SqlDbType.Int).Value = Reco_Ide_Detalle;

            CMD.Parameters.Add("@RETURN", SqlDbType.Int);
            CMD.Parameters["@RETURN"].Value = DBNull.Value;
            CMD.Parameters["@RETURN"].Direction = ParameterDirection.ReturnValue;
            return Recojo_AyudanteDA.Acceder(CMD);
            */
        }

        public static ENResultOperation Ultimo_Item(Int32 Reco_Ide)
        {
            SqlCommand CMD = new SqlCommand("PA_RECOJO_AYUDANTE_ITEMS");
            CMD.Parameters.Add(Parametros_SQL.nombre_error, SqlDbType.VarChar).Value = DBNull.Value;
            CMD.Parameters.Add(Parametros_SQL.ide, SqlDbType.Int).Value = Reco_Ide;

            CMD.Parameters.Add("@RETURN", SqlDbType.Int);
            CMD.Parameters["@RETURN"].Value = DBNull.Value;
            CMD.Parameters["@RETURN"].Direction = ParameterDirection.ReturnValue;
            return Recojo_AyudanteDA.Acceder(CMD);
        }

        public static ENResultOperation Obtener_Registro(Int32 Reco_Ide, Int32 Reco_Ide_Detalle)
        {
            SqlCommand CMD = new SqlCommand("SELECT A.RECO_IDE,A.RECO_IDE_DETALLE,A.TRAN_CONT_IDE," +
                     "(SELECT B.TRAN_IDE FROM RECOJO_CABECERA B WHERE B.RECO_IDE = A.RECO_IDE) AS TRAN_IDE," +
                     "(SELECT C.TRAN_CONT_PATERNO FROM TRANSPORTISTA_CONTACTO C WHERE C.TRAN_IDE = (SELECT TRAN_IDE FROM RECOJO_CABECERA WHERE RECO_IDE = A.RECO_IDE) AND TRAN_CONT_IDE = A.TRAN_CONT_IDE ) AS PATERNO, " +
                     "(SELECT C.TRAN_CONT_MATERNO FROM TRANSPORTISTA_CONTACTO C WHERE C.TRAN_IDE = (SELECT TRAN_IDE FROM RECOJO_CABECERA WHERE RECO_IDE = A.RECO_IDE) AND TRAN_CONT_IDE = A.TRAN_CONT_IDE ) AS MATERNO, " +
                     "(SELECT C.TRAN_CONT_NOMBRE FROM TRANSPORTISTA_CONTACTO C WHERE C.TRAN_IDE = (SELECT TRAN_IDE FROM RECOJO_CABECERA WHERE RECO_IDE = A.RECO_IDE) AND TRAN_CONT_IDE = A.TRAN_CONT_IDE ) AS NOMBRE " +
                     "	 FROM RECOJO_AYUDANTE A  WHERE A.RECO_IDE = " + Reco_Ide.ToString() +
                     "  AND A.RECO_IDE_DETALLE = " + Reco_Ide_Detalle.ToString());
  
            return Recojo_AyudanteDA.Procesar_SQL(CMD);
        }
    }
}
