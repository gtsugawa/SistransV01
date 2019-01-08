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
    class Consumo_LubricanteDA
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

    public class ClsConsumo_LubricanteDA
    {
        private SqlDataReader dr = null;
        public struct Parametros_SQL
        {

            public const string nombre_error = "@NOMBRE_ERROR";
            public const string cons_ide = "@IDE";
            public const string comp_ide = "@COMP_IDE";
            public const string cons_fecha = "@FECHA";
            public const string cons_numero = "@NUMERO";
            public const string tran_ide = "@TRAN_IDE";
            public const string mant_grupo_ide = "@GRUPO";
            public const string mant_actividades_ide = "@ACTIVIDAD";
            public const string tran_vehi_ide = "@TRAN_VEHI_IDE";
            public const string cons_cantidad = "@CANTIDAD";
            public const string cons_unidad = "@UNIDAD";
            public const string cons_importe = "@IMPORTE";
            public const string cons_solicitado = "@SOLICITADO";
            public const string cons_autorizado = "@AUTORIZADO";
            public const string cons_realizado = "@REALIZADO";
            public const string cons_observacion = "@OBSERVACION";
            public const string cons_estado = "@ESTADO";
        }

        public static ENResultOperation Crear(ClsConsumo_LubricanteBE Datos)
        {
            SqlCommand CMD = new SqlCommand("PA_CONSUMO_LUBRICANTE_INSERTA");
            CMD.Parameters.Add(Parametros_SQL.nombre_error, SqlDbType.VarChar).Value = "";
            CMD.Parameters.Add(Parametros_SQL.cons_ide, SqlDbType.Int).Value = Datos.Cons_ide;
            CMD.Parameters.Add(Parametros_SQL.comp_ide, SqlDbType.Int).Value = Datos.Comp_ide;
            CMD.Parameters.Add(Parametros_SQL.cons_fecha, SqlDbType.DateTime).Value = Datos.Cons_fecha;
            CMD.Parameters.Add(Parametros_SQL.cons_numero, SqlDbType.VarChar).Value = Datos.Cons_numero;
            CMD.Parameters.Add(Parametros_SQL.tran_ide, SqlDbType.Int).Value = Datos.Tran_ide;
            CMD.Parameters.Add(Parametros_SQL.tran_vehi_ide, SqlDbType.Int).Value = Datos.Tran_vehi_ide;
            CMD.Parameters.Add(Parametros_SQL.mant_grupo_ide, SqlDbType.Int).Value = Datos.Mant_grupo_ide;
            CMD.Parameters.Add(Parametros_SQL.mant_actividades_ide, SqlDbType.Int).Value = Datos.Mant_actividades_ide;
            CMD.Parameters.Add(Parametros_SQL.cons_cantidad, SqlDbType.Decimal).Value = Datos.Cons_cantidad;
            CMD.Parameters.Add(Parametros_SQL.cons_unidad, SqlDbType.VarChar).Value = Datos.Cons_unidad;
            CMD.Parameters.Add(Parametros_SQL.cons_importe, SqlDbType.Decimal).Value = Datos.Cons_importe;
            CMD.Parameters.Add(Parametros_SQL.cons_solicitado, SqlDbType.VarChar).Value = Datos.Cons_solicitado;
            CMD.Parameters.Add(Parametros_SQL.cons_autorizado, SqlDbType.VarChar).Value = Datos.Cons_autorizado;
            CMD.Parameters.Add(Parametros_SQL.cons_realizado, SqlDbType.VarChar).Value = Datos.Cons_realizado;
            CMD.Parameters.Add(Parametros_SQL.cons_observacion, SqlDbType.VarChar).Value = Datos.Cons_observacion;
            CMD.Parameters.Add(Parametros_SQL.cons_estado, SqlDbType.VarChar).Value = Datos.Cons_estado;

            CMD.Parameters.Add("@RETURN", SqlDbType.Int);
            CMD.Parameters["@RETURN"].Value = DBNull.Value;
            CMD.Parameters["@RETURN"].Direction = ParameterDirection.ReturnValue;

            return Consumo_LubricanteDA.Acceder(CMD);

        }

        public static ENResultOperation Actualizar(ClsConsumo_LubricanteBE Datos)
        {
            SqlCommand CMD = new SqlCommand("PA_CONSUMO_LUBRICANTE_MODIFICA");
            CMD.Parameters.Add(Parametros_SQL.nombre_error, SqlDbType.VarChar).Value = "";
            CMD.Parameters.Add(Parametros_SQL.cons_ide, SqlDbType.Int).Value = Datos.Cons_ide;
            CMD.Parameters.Add(Parametros_SQL.comp_ide, SqlDbType.Int).Value = Datos.Comp_ide;
            CMD.Parameters.Add(Parametros_SQL.cons_fecha, SqlDbType.DateTime).Value = Datos.Cons_fecha;
            CMD.Parameters.Add(Parametros_SQL.cons_numero, SqlDbType.VarChar).Value = Datos.Cons_numero;
            CMD.Parameters.Add(Parametros_SQL.tran_ide, SqlDbType.Int).Value = Datos.Tran_ide;
            CMD.Parameters.Add(Parametros_SQL.tran_vehi_ide, SqlDbType.Int).Value = Datos.Tran_vehi_ide;
            CMD.Parameters.Add(Parametros_SQL.mant_grupo_ide, SqlDbType.Int).Value = Datos.Mant_grupo_ide;
            CMD.Parameters.Add(Parametros_SQL.mant_actividades_ide, SqlDbType.Int).Value = Datos.Mant_actividades_ide;
            CMD.Parameters.Add(Parametros_SQL.cons_cantidad, SqlDbType.Decimal).Value = Datos.Cons_cantidad;
            CMD.Parameters.Add(Parametros_SQL.cons_unidad, SqlDbType.VarChar).Value = Datos.Cons_unidad;
            CMD.Parameters.Add(Parametros_SQL.cons_importe, SqlDbType.Decimal).Value = Datos.Cons_importe;
            CMD.Parameters.Add(Parametros_SQL.cons_solicitado, SqlDbType.VarChar).Value = Datos.Cons_solicitado;
            CMD.Parameters.Add(Parametros_SQL.cons_autorizado, SqlDbType.VarChar).Value = Datos.Cons_autorizado;
            CMD.Parameters.Add(Parametros_SQL.cons_realizado, SqlDbType.VarChar).Value = Datos.Cons_realizado;
            CMD.Parameters.Add(Parametros_SQL.cons_observacion, SqlDbType.VarChar).Value = Datos.Cons_observacion;
            CMD.Parameters.Add(Parametros_SQL.cons_estado, SqlDbType.VarChar).Value = Datos.Cons_estado;

            CMD.Parameters.Add("@RETURN", SqlDbType.Int);
            CMD.Parameters["@RETURN"].Value = DBNull.Value;
            CMD.Parameters["@RETURN"].Direction = ParameterDirection.ReturnValue;

            return Consumo_LubricanteDA.Acceder(CMD);

        }

        public static ENResultOperation Eliminar(ClsConsumo_LubricanteBE Datos)
        {
            SqlCommand CMD = new SqlCommand("PA_CONSUMO_LUBRICANTE_ELIMINA");
            CMD.Parameters.Add(Parametros_SQL.nombre_error, SqlDbType.VarChar).Value = DBNull.Value;
            CMD.Parameters.Add(Parametros_SQL.cons_ide, SqlDbType.Int).Value = Datos.Cons_ide;

            CMD.Parameters.Add("@RETURN", SqlDbType.Int);
            CMD.Parameters["@RETURN"].Value = DBNull.Value;
            CMD.Parameters["@RETURN"].Direction = ParameterDirection.ReturnValue;


            return Consumo_LubricanteDA.Acceder(CMD);
        }

        public static ENResultOperation Listar(string Texto_Buscar)
        {
            SqlCommand CMD = new SqlCommand("SELECT * FROM V_CONSUMO_LUBRICANTE  WHERE PROV_IDE LIKE '" +
                   Texto_Buscar + "%' ORDER BY COMP_FECHA,COMP_NUMERO");
            return ProcesarSQLDA.Procesar_SQL(CMD);

        }
        public static ENResultOperation Buscar_Registro(Int32 nCons_Ide)
        {
            SqlCommand CMD = new SqlCommand("SELECT * FROM V_CONSUMO_LUBRICANTE  WHERE CONS_IDE = @IDE ");

            CMD.Parameters.AddWithValue("@IDE", nCons_Ide);
            return ProcesarSQLDA.Procesar_SQL(CMD);

        }

        public static ENResultOperation Listar_Filtro(string Texto_Buscar, string Condic_Buscar, DateTime FecIni, DateTime FecFin)
        {
            SqlCommand CMD = new SqlCommand("PA_CONSUMO_LUBRICANTE_LISTAR_FILTRO");
            CMD.Parameters.Add(Parametros_SQL.nombre_error, SqlDbType.VarChar).Value = DBNull.Value;
            CMD.Parameters.Add("@FILTRO", SqlDbType.VarChar).Value = Texto_Buscar;
            CMD.Parameters.Add("@CONDIC", SqlDbType.VarChar).Value = Condic_Buscar;
            CMD.Parameters.Add("@FECINI", SqlDbType.DateTime).Value = FecIni;
            CMD.Parameters.Add("@FECFIN", SqlDbType.DateTime).Value = FecFin;

            CMD.Parameters.Add("@RETURN", SqlDbType.Int);
            CMD.Parameters["@RETURN"].Value = DBNull.Value;
            CMD.Parameters["@RETURN"].Direction = ParameterDirection.ReturnValue;
            return Consumo_LubricanteDA.Acceder(CMD);
        }
        public static ENResultOperation Listar_por_Fechas(DateTime Fecha_Inicio, DateTime Fecha_Fin)
        {
            SqlCommand CMD = new SqlCommand("PA_CONSUMO_LUBRICANTE_LISTAR_POR_FECHAS");
            CMD.Parameters.Add(Parametros_SQL.nombre_error, SqlDbType.VarChar).Value = DBNull.Value;
            CMD.Parameters.Add("@FECINI", SqlDbType.DateTime).Value = Fecha_Inicio;
            CMD.Parameters.Add("@FECFIN", SqlDbType.DateTime).Value = Fecha_Fin;

            CMD.Parameters.Add("@RETURN", SqlDbType.Int);
            CMD.Parameters["@RETURN"].Value = DBNull.Value;
            CMD.Parameters["@RETURN"].Direction = ParameterDirection.ReturnValue;
            return Consumo_LubricanteDA.Acceder(CMD);
        }
        public static ENResultOperation Reprocesar_Consumo(DateTime Fecha_Inicio, DateTime Fecha_Fin)
        {
            SqlCommand CMD = new SqlCommand("PA_CONSUMO_LUBRICANTE_REPROCESO");
            CMD.Parameters.Add(Parametros_SQL.nombre_error, SqlDbType.VarChar).Value = DBNull.Value;
            CMD.Parameters.Add("@FECINI", SqlDbType.DateTime).Value = Fecha_Inicio;
            CMD.Parameters.Add("@FECFIN", SqlDbType.DateTime).Value = Fecha_Fin;

            CMD.Parameters.Add("@RETURN", SqlDbType.Int);
            CMD.Parameters["@RETURN"].Value = DBNull.Value;
            CMD.Parameters["@RETURN"].Direction = ParameterDirection.ReturnValue;
            return Consumo_LubricanteDA.Acceder(CMD);
        }
    }
}
