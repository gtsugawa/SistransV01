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
    class Mantenimiento_GruposDA
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

    public class ClsMantenimiento_GruposDA
    {
        public struct Parametros_SQL
        {
            public const string nombre_error = "@NOMBRE_ERROR";
            public const string ide = "@IDE"; 
            public const string codigo = "@CODIGO"; 
            public const string nombre = "@NOMBRE";
            public const string estado = "@ESTADO"; 
        }

        public static ENResultOperation Crear(ClsMantenimiento_GruposBE Datos)
        {
            SqlCommand CMD = new SqlCommand("PA_MANTENIMIENTO_GRUPOS_INSERTA");
            CMD.Parameters.Add(Parametros_SQL.nombre_error, SqlDbType.VarChar).Value = "";
            CMD.Parameters.Add(Parametros_SQL.ide, SqlDbType.Int).Value = Datos.Mant_grupo_ide;
            CMD.Parameters.Add(Parametros_SQL.codigo, SqlDbType.VarChar).Value = Datos.Mant_grupo_codigo;
            CMD.Parameters.Add(Parametros_SQL.nombre, SqlDbType.VarChar).Value = Datos.Mant_grupo_nombre;
            CMD.Parameters.Add(Parametros_SQL.estado, SqlDbType.Int).Value = Datos.Mant_grupo_estado;

            CMD.Parameters.Add("@RETURN", SqlDbType.Int);
            CMD.Parameters["@RETURN"].Value = DBNull.Value;
            CMD.Parameters["@RETURN"].Direction = ParameterDirection.ReturnValue;

            return Mantenimiento_GruposDA.Acceder(CMD);

        }

        public static ENResultOperation Actualizar(ClsMantenimiento_GruposBE Datos)
        {
            SqlCommand CMD = new SqlCommand("PA_MANTENIMIENTO_GRUPOS_MODIFICA");
            CMD.Parameters.Add(Parametros_SQL.nombre_error, SqlDbType.VarChar).Value = "";
            CMD.Parameters.Add(Parametros_SQL.ide, SqlDbType.Int).Value = Datos.Mant_grupo_ide;
            CMD.Parameters.Add(Parametros_SQL.codigo, SqlDbType.VarChar).Value = Datos.Mant_grupo_codigo;
            CMD.Parameters.Add(Parametros_SQL.nombre, SqlDbType.VarChar).Value = Datos.Mant_grupo_nombre;
            CMD.Parameters.Add(Parametros_SQL.estado, SqlDbType.Int).Value = Datos.Mant_grupo_estado;

            CMD.Parameters.Add("@RETURN", SqlDbType.Int);
            CMD.Parameters["@RETURN"].Value = DBNull.Value;
            CMD.Parameters["@RETURN"].Direction = ParameterDirection.ReturnValue;

            return Mantenimiento_GruposDA.Acceder(CMD);

        }

        public static ENResultOperation Eliminar(ClsMantenimiento_GruposBE Datos)
        {
            SqlCommand CMD = new SqlCommand("PA_MANTENIMIENTO_GRUPOS_ELIMINA");
            CMD.Parameters.Add(Parametros_SQL.nombre_error, SqlDbType.VarChar).Value = DBNull.Value;
            CMD.Parameters.Add(Parametros_SQL.ide, SqlDbType.Int).Value = Datos.Mant_grupo_ide;

            CMD.Parameters.Add("@RETURN", SqlDbType.Int);
            CMD.Parameters["@RETURN"].Value = DBNull.Value;
            CMD.Parameters["@RETURN"].Direction = ParameterDirection.ReturnValue;


            return Mantenimiento_GruposDA.Acceder(CMD);
        }

        public static ENResultOperation Listar(string Texto_Buscar)
        {
            SqlCommand CMD = new SqlCommand("SELECT * FROM MANTENIMIENTO_GRUPOS");

            return ProcesarSQLDA.Procesar_SQL(CMD);

        }

        public static ENResultOperation Listar_Filtro(string Texto_Buscar, string Condic_Buscar, DateTime FecIni, DateTime FecFin)
        {
            SqlCommand CMD = new SqlCommand("PA_MANTENIMIENTO_GRUPOS_LISTAR_FILTRO");
            CMD.Parameters.Add(Parametros_SQL.nombre_error, SqlDbType.VarChar).Value = Texto_Buscar;
            CMD.Parameters.Add("@FILTRO", SqlDbType.VarChar).Value = Texto_Buscar;
            CMD.Parameters.Add("@CONDIC", SqlDbType.VarChar).Value = Condic_Buscar;
            CMD.Parameters.Add("@FECINI", SqlDbType.DateTime).Value = FecIni;
            CMD.Parameters.Add("@FECFIN", SqlDbType.DateTime).Value = FecFin;

            CMD.Parameters.Add("@RETURN", SqlDbType.Int);
            CMD.Parameters["@RETURN"].Value = DBNull.Value;
            CMD.Parameters["@RETURN"].Direction = ParameterDirection.ReturnValue;

            return Mantenimiento_GruposDA.Acceder(CMD);
        }
        public static ENResultOperation Listar_por_Fechas(DateTime FecIni, DateTime FecFin)
        {
            SqlCommand CMD = new SqlCommand("PA_MANTENIMIENTO_GRUPOS_LISTAR_POR_FECHAS");
            CMD.Parameters.Add(Parametros_SQL.nombre_error, SqlDbType.VarChar).Value = DBNull.Value;
            CMD.Parameters.Add("@FECINI", SqlDbType.DateTime).Value = FecIni;
            CMD.Parameters.Add("@FECFIN", SqlDbType.DateTime).Value = FecFin;

            CMD.Parameters.Add("@RETURN", SqlDbType.Int);
            CMD.Parameters["@RETURN"].Value = DBNull.Value;
            CMD.Parameters["@RETURN"].Direction = ParameterDirection.ReturnValue;

            return Mantenimiento_GruposDA.Acceder(CMD);
        }
        public static ENResultOperation Buscar_Registro(Int32 Reco_Ide)
        {
            SqlCommand CMD = new SqlCommand("SELECT * FROM MANTENIMIENTO_GRUPOS WHERE Mant_Grupo_Ide = @IDE");

            CMD.Parameters.AddWithValue("@IDE", Reco_Ide);
            return ProcesarSQLDA.Procesar_SQL(CMD);
        }

        public static ENResultOperation Obtener_Registro(Int32 Reco_Ide)
        {
            SqlCommand CMD = new SqlCommand("SELECT * FROM MANTENIMIENTO_CORRECTIVO WHERE Mant_Grupo_Ide = " + Reco_Ide.ToString());

            return ProcesarSQLDA.Procesar_SQL(CMD);
        }
    }
}