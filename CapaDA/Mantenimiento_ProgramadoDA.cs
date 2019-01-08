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
    class Mantenimiento_ProgramadoDA
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

    public class ClsMantenimiento_ProgramadoDA
    {
        public struct Parametros_SQL
        {
            public const string nombre_error = "@NOMBRE_ERROR";
            public const string mant_prog_ide = "@IDE";
            public const string tran_ide = "@TRAN_IDE";
            public const string tran_vehi_ide = "@TRAN_VEHI_IDE";
            public const string tran_vehi_placa = "@PLACA";
            public const string mant_grupo_ide = "@GRUPO_IDE";
            public const string mant_actividad_ide = "@ACTIVIDAD_IDE";
            public const string mant_prog_dias = "@DIAS";
            public const string mant_prog_kilometros = "@KILOMETRAJE";
            public const string mant_prog_ultima_fecha = "@ULTIMA_FECHA";
            public const string mant_prog_ultimo_kilometraje = "@ULTIMO_KILOMETRAJE";
            public const string mant_prog_proxima_fecha = "@PROXIMA_FECHA";
            public const string mant_prog_proximo_kilometraje = "@PROXIMO_KILOMETRAJE";
            public const string mant_prog_detalle = "@DETALLE";
            public const string mant_prog_usuario = "@USUARIO";
            public const string mant_prog_estado = "@ESTADO";

        }

        public static ENResultOperation Crear(ClsMantenimiento_ProgramadoBE Datos)
        {
            SqlCommand CMD = new SqlCommand("PA_MANTENIMIENTO_PROGRAMADO_INSERTA");
            CMD.Parameters.Add(Parametros_SQL.nombre_error, SqlDbType.VarChar).Value = "";
            CMD.Parameters.Add(Parametros_SQL.mant_prog_ide, SqlDbType.Int).Value = Datos.Mant_prog_ide;
            CMD.Parameters.Add(Parametros_SQL.tran_ide, SqlDbType.Int).Value = Datos.Tran_ide;
            CMD.Parameters.Add(Parametros_SQL.tran_vehi_ide, SqlDbType.Int).Value = Datos.Tran_vehi_ide;
            CMD.Parameters.Add(Parametros_SQL.tran_vehi_placa, SqlDbType.NVarChar).Value = Datos.Tran_vehi_placa;
            CMD.Parameters.Add(Parametros_SQL.mant_grupo_ide, SqlDbType.Int).Value = Datos.Mant_grupo_ide;
            CMD.Parameters.Add(Parametros_SQL.mant_actividad_ide, SqlDbType.Int).Value = Datos.Mant_actividad_ide;
            CMD.Parameters.Add(Parametros_SQL.mant_prog_dias, SqlDbType.Int).Value = Datos.Mant_prog_dias;
            CMD.Parameters.Add(Parametros_SQL.mant_prog_kilometros, SqlDbType.Int).Value = Datos.Mant_prog_kilometros;
            CMD.Parameters.Add(Parametros_SQL.mant_prog_ultima_fecha, SqlDbType.DateTime).Value = Datos.Mant_prog_ultima_fecha;
            CMD.Parameters.Add(Parametros_SQL.mant_prog_ultimo_kilometraje, SqlDbType.Int).Value = Datos.Mant_prog_ultimo_kilometraje;
            CMD.Parameters.Add(Parametros_SQL.mant_prog_proxima_fecha, SqlDbType.DateTime).Value = Datos.Mant_prog_proxima_fecha;
            CMD.Parameters.Add(Parametros_SQL.mant_prog_proximo_kilometraje, SqlDbType.Int).Value = Datos.Mant_prog_proximo_kilometraje;
            CMD.Parameters.Add(Parametros_SQL.mant_prog_detalle, SqlDbType.NVarChar).Value = Datos.Mant_prog_detalle;
            CMD.Parameters.Add(Parametros_SQL.mant_prog_usuario, SqlDbType.NChar).Value = Datos.Mant_prog_usuario;
            CMD.Parameters.Add(Parametros_SQL.mant_prog_estado, SqlDbType.Int).Value = Datos.Mant_prog_estado;

            CMD.Parameters.Add("@RETURN", SqlDbType.Int);
            CMD.Parameters["@RETURN"].Value = DBNull.Value;
            CMD.Parameters["@RETURN"].Direction = ParameterDirection.ReturnValue;

            return Mantenimiento_PreventivoDA.Acceder(CMD);

        }

        public static ENResultOperation Actualizar(ClsMantenimiento_ProgramadoBE Datos)
        {
            SqlCommand CMD = new SqlCommand("PA_MANTENIMIENTO_PROGRAMADO_MODIFICA");
            CMD.Parameters.Add(Parametros_SQL.nombre_error, SqlDbType.VarChar).Value = "";
            CMD.Parameters.Add(Parametros_SQL.mant_prog_ide, SqlDbType.Int).Value = Datos.Mant_prog_ide;
            CMD.Parameters.Add(Parametros_SQL.tran_ide, SqlDbType.Int).Value = Datos.Tran_ide;
            CMD.Parameters.Add(Parametros_SQL.tran_vehi_ide, SqlDbType.Int).Value = Datos.Tran_vehi_ide;
            CMD.Parameters.Add(Parametros_SQL.tran_vehi_placa, SqlDbType.NVarChar).Value = Datos.Tran_vehi_placa;
            CMD.Parameters.Add(Parametros_SQL.mant_grupo_ide, SqlDbType.Int).Value = Datos.Mant_grupo_ide;
            CMD.Parameters.Add(Parametros_SQL.mant_actividad_ide, SqlDbType.Int).Value = Datos.Mant_actividad_ide;
            CMD.Parameters.Add(Parametros_SQL.mant_prog_dias, SqlDbType.Int).Value = Datos.Mant_prog_dias;
            CMD.Parameters.Add(Parametros_SQL.mant_prog_kilometros, SqlDbType.Int).Value = Datos.Mant_prog_kilometros;
            CMD.Parameters.Add(Parametros_SQL.mant_prog_ultima_fecha, SqlDbType.DateTime).Value = Datos.Mant_prog_ultima_fecha;
            CMD.Parameters.Add(Parametros_SQL.mant_prog_ultimo_kilometraje, SqlDbType.Int).Value = Datos.Mant_prog_ultimo_kilometraje;
            CMD.Parameters.Add(Parametros_SQL.mant_prog_proxima_fecha, SqlDbType.DateTime).Value = Datos.Mant_prog_proxima_fecha;
            CMD.Parameters.Add(Parametros_SQL.mant_prog_proximo_kilometraje, SqlDbType.Int).Value = Datos.Mant_prog_proximo_kilometraje;
            CMD.Parameters.Add(Parametros_SQL.mant_prog_detalle, SqlDbType.NVarChar).Value = Datos.Mant_prog_detalle;
            CMD.Parameters.Add(Parametros_SQL.mant_prog_usuario, SqlDbType.NChar).Value = Datos.Mant_prog_usuario;
            CMD.Parameters.Add(Parametros_SQL.mant_prog_estado, SqlDbType.Int).Value = Datos.Mant_prog_estado;

            CMD.Parameters.Add("@RETURN", SqlDbType.Int);
            CMD.Parameters["@RETURN"].Value = DBNull.Value;
            CMD.Parameters["@RETURN"].Direction = ParameterDirection.ReturnValue;

            return Mantenimiento_PreventivoDA.Acceder(CMD);

        }

        public static ENResultOperation Eliminar(ClsMantenimiento_ProgramadoBE Datos)
        {
            SqlCommand CMD = new SqlCommand("PA_MANTENIMIENTO_PROGRAMADO_ELIMINA");
            CMD.Parameters.Add(Parametros_SQL.nombre_error, SqlDbType.VarChar).Value = DBNull.Value;
            CMD.Parameters.Add(Parametros_SQL.mant_prog_ide, SqlDbType.Int).Value = Datos.Mant_prog_ide;

            CMD.Parameters.Add("@RETURN", SqlDbType.Int);
            CMD.Parameters["@RETURN"].Value = DBNull.Value;
            CMD.Parameters["@RETURN"].Direction = ParameterDirection.ReturnValue;


            return Mantenimiento_PreventivoDA.Acceder(CMD);
        }

        public static ENResultOperation Listar(string Texto_Buscar)
        {
            SqlCommand CMD = new SqlCommand("SELECT * FROM V_MANTENIMIENTO_PROGRAMADO");

            return ProcesarSQLDA.Procesar_SQL(CMD);

        }

        public static ENResultOperation Listar_Filtro(string Texto_Buscar, string Condic_Buscar, DateTime FecIni, DateTime FecFin)
        {
            SqlCommand CMD = new SqlCommand("PA_MANTENIMIENTO_PROGRAMADO_LISTAR_FILTRO");
            CMD.Parameters.Add(Parametros_SQL.nombre_error, SqlDbType.VarChar).Value = Texto_Buscar;
            CMD.Parameters.Add("@FILTRO", SqlDbType.VarChar).Value = Texto_Buscar;
            CMD.Parameters.Add("@CONDIC", SqlDbType.VarChar).Value = Condic_Buscar;
            CMD.Parameters.Add("@FECINI", SqlDbType.DateTime).Value = FecIni;
            CMD.Parameters.Add("@FECFIN", SqlDbType.DateTime).Value = FecFin;

            CMD.Parameters.Add("@RETURN", SqlDbType.Int);
            CMD.Parameters["@RETURN"].Value = DBNull.Value;
            CMD.Parameters["@RETURN"].Direction = ParameterDirection.ReturnValue;

            return Mantenimiento_PreventivoDA.Acceder(CMD);
        }
        public static ENResultOperation Listar_por_Fechas(DateTime FecIni, DateTime FecFin)
        {
            SqlCommand CMD = new SqlCommand("PA_MANTENIMIENTO_PROGRAMADO_LISTAR_POR_FECHAS");
            CMD.Parameters.Add(Parametros_SQL.nombre_error, SqlDbType.VarChar).Value = DBNull.Value;
            CMD.Parameters.Add("@FECINI", SqlDbType.DateTime).Value = FecIni;
            CMD.Parameters.Add("@FECFIN", SqlDbType.DateTime).Value = FecFin;

            CMD.Parameters.Add("@RETURN", SqlDbType.Int);
            CMD.Parameters["@RETURN"].Value = DBNull.Value;
            CMD.Parameters["@RETURN"].Direction = ParameterDirection.ReturnValue;

            return Mantenimiento_PreventivoDA.Acceder(CMD);
        }
        public static ENResultOperation Buscar_Registro(Int32 Reco_Ide)
        {
            SqlCommand CMD = new SqlCommand("SELECT * FROM V_MANTENIMIENTO_PROGRAMADO WHERE Mant_Prog_Ide = @IDE");

            CMD.Parameters.AddWithValue("@IDE", Reco_Ide);
            return ProcesarSQLDA.Procesar_SQL(CMD);
        }

        public static ENResultOperation Obtener_Registro(Int32 Reco_Ide)
        {
            SqlCommand CMD = new SqlCommand("SELECT * FROM MANTENIMIENTO_PROGRAMADO WHERE Mant_Prog_Ide = " + Reco_Ide.ToString());

            return ProcesarSQLDA.Procesar_SQL(CMD);
        }
    }

}
