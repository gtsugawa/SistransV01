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
    class Combustible_CompraDA
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
    public class ClsCombustible_CompraDA
    {
        private SqlDataReader dr = null;
        public struct Parametros_SQL
        {

            public const string nombre_error = "@NOMBRE_ERROR";
            public const string comp_ide = "@IDE";
            public const string prov_ide = "@PROV_IDE";
            public const string comp_fecha = "@FECHA";
            public const string comp_numero = "@NUMERO";
            public const string comp_tipo_combustible = "@TIPO_COMBUSTIBLE";
            public const string comp_cantidad = "@CANTIDAD";
            public const string comp_importe = "@IMPORTE";
            public const string comp_kilometraje = "@KILOMETRAJE";
            public const string tran_ide = "@TRAN_IDE";
            public const string tran_vehi_ide = "@VEHI_IDE";
            public const string tran_chof_ide = "@CHOF_IDE";
            public const string comp_lugar = "@LUGAR";
            public const string comp_orden = "@ORDEN";
            public const string creacion = "@CREACION";
            public const string usuario = "@USUARIO";
            public const string estado = "@ESTADO";
            public const string fecha_posterior = "@FECHA_POSTERIOR";
            public const string kms_posterior = "@KMS_POSTERIOR";
            public const string tonelaje = "@TONELAJE";
            public const string comb_inicio = "@COMB_INICIO";
            public const string comb_final = "@COMB_FINAL";
        }

        public static ENResultOperation Crear(ClsCombustible_CompraBE Datos)
        {
            SqlCommand CMD = new SqlCommand("PA_COMBUSTIBLE_COMPRA_INSERTA");
            CMD.Parameters.Add(Parametros_SQL.nombre_error, SqlDbType.VarChar).Value = "";
            CMD.Parameters.Add(Parametros_SQL.comp_ide, SqlDbType.Int).Value = Datos.Comp_ide;
            CMD.Parameters.Add(Parametros_SQL.prov_ide, SqlDbType.Int).Value = Datos.Prov_ide;
            CMD.Parameters.Add(Parametros_SQL.comp_fecha, SqlDbType.DateTime).Value = Datos.Comp_fecha;
            CMD.Parameters.Add(Parametros_SQL.comp_numero, SqlDbType.VarChar).Value = Datos.Comp_numero;
            CMD.Parameters.Add(Parametros_SQL.comp_tipo_combustible, SqlDbType.VarChar).Value = Datos.Comp_tipo_combustible;
            CMD.Parameters.Add(Parametros_SQL.comp_cantidad, SqlDbType.Decimal).Value = Datos.Comp_cantidad;
            CMD.Parameters.Add(Parametros_SQL.comp_importe, SqlDbType.Decimal).Value = Datos.Comp_importe;
            CMD.Parameters.Add(Parametros_SQL.comp_kilometraje, SqlDbType.Int).Value = Datos.Comp_kilometraje;
            CMD.Parameters.Add(Parametros_SQL.tran_ide, SqlDbType.Int).Value = Datos.Tran_ide;
            CMD.Parameters.Add(Parametros_SQL.tran_vehi_ide, SqlDbType.Int).Value = Datos.Tran_vehi_ide;
            CMD.Parameters.Add(Parametros_SQL.tran_chof_ide, SqlDbType.Int).Value = Datos.Tran_chof_ide;
            CMD.Parameters.Add(Parametros_SQL.comp_lugar, SqlDbType.VarChar).Value = Datos.Comp_lugar;
            CMD.Parameters.Add(Parametros_SQL.comp_orden, SqlDbType.Int).Value = Datos.Comp_orden;
            CMD.Parameters.Add(Parametros_SQL.creacion, SqlDbType.DateTime).Value = Datos.Creacion;
            CMD.Parameters.Add(Parametros_SQL.usuario, SqlDbType.VarChar).Value = Datos.Usuario;
            CMD.Parameters.Add(Parametros_SQL.estado, SqlDbType.Int).Value = Datos.Estado;
            CMD.Parameters.Add(Parametros_SQL.tonelaje, SqlDbType.VarChar).Value = Datos.Tonelaje;
            CMD.Parameters.Add(Parametros_SQL.comb_inicio, SqlDbType.VarChar).Value = Datos.Comb_inicio;
            CMD.Parameters.Add(Parametros_SQL.comb_final, SqlDbType.VarChar).Value = Datos.Comb_final;
            //CMD.Parameters.Add(Parametros_SQL.fecha_posterior, SqlDbType.DateTime).Value = Datos.Fecha_posterior;
            //CMD.Parameters.Add(Parametros_SQL.kms_posterior, SqlDbType.Int).Value = Datos.Kms_posterior;

            CMD.Parameters.Add("@RETURN", SqlDbType.Int);
            CMD.Parameters["@RETURN"].Value = DBNull.Value;
            CMD.Parameters["@RETURN"].Direction = ParameterDirection.ReturnValue;

            return Combustible_CompraDA.Acceder(CMD);

        }

        public static ENResultOperation Actualizar(ClsCombustible_CompraBE Datos)
        {
            SqlCommand CMD = new SqlCommand("PA_COMBUSTIBLE_COMPRA_MODIFICA");
            CMD.Parameters.Add(Parametros_SQL.nombre_error, SqlDbType.VarChar).Value = "";
            CMD.Parameters.Add(Parametros_SQL.comp_ide, SqlDbType.Int).Value = Datos.Comp_ide;
            CMD.Parameters.Add(Parametros_SQL.prov_ide, SqlDbType.Int).Value = Datos.Prov_ide;
            CMD.Parameters.Add(Parametros_SQL.comp_fecha, SqlDbType.DateTime).Value = Datos.Comp_fecha;
            CMD.Parameters.Add(Parametros_SQL.comp_numero, SqlDbType.VarChar).Value = Datos.Comp_numero;
            CMD.Parameters.Add(Parametros_SQL.comp_tipo_combustible, SqlDbType.VarChar).Value = Datos.Comp_tipo_combustible;
            CMD.Parameters.Add(Parametros_SQL.comp_cantidad, SqlDbType.Decimal).Value = Datos.Comp_cantidad;
            CMD.Parameters.Add(Parametros_SQL.comp_importe, SqlDbType.Decimal).Value = Datos.Comp_importe;
            CMD.Parameters.Add(Parametros_SQL.comp_kilometraje, SqlDbType.Int).Value = Datos.Comp_kilometraje;
            CMD.Parameters.Add(Parametros_SQL.tran_ide, SqlDbType.Int).Value = Datos.Tran_ide;
            CMD.Parameters.Add(Parametros_SQL.tran_vehi_ide, SqlDbType.Int).Value = Datos.Tran_vehi_ide;
            CMD.Parameters.Add(Parametros_SQL.tran_chof_ide, SqlDbType.Int).Value = Datos.Tran_chof_ide;
            CMD.Parameters.Add(Parametros_SQL.comp_lugar, SqlDbType.VarChar).Value = Datos.Comp_lugar;
            CMD.Parameters.Add(Parametros_SQL.comp_orden, SqlDbType.Int).Value = Datos.Comp_orden;
            CMD.Parameters.Add(Parametros_SQL.creacion, SqlDbType.DateTime).Value = Datos.Creacion;
            CMD.Parameters.Add(Parametros_SQL.usuario, SqlDbType.VarChar).Value = Datos.Usuario;
            CMD.Parameters.Add(Parametros_SQL.estado, SqlDbType.Int).Value = Datos.Estado;
            CMD.Parameters.Add(Parametros_SQL.tonelaje, SqlDbType.VarChar).Value = Datos.Tonelaje;
            CMD.Parameters.Add(Parametros_SQL.comb_inicio, SqlDbType.VarChar).Value = Datos.Comb_inicio;
            CMD.Parameters.Add(Parametros_SQL.comb_final, SqlDbType.VarChar).Value = Datos.Comb_final;
            //CMD.Parameters.Add(Parametros_SQL.fecha_posterior, SqlDbType.DateTime).Value = Datos.Fecha_posterior;
            //CMD.Parameters.Add(Parametros_SQL.kms_posterior, SqlDbType.Int).Value = Datos.Kms_posterior;

            CMD.Parameters.Add("@RETURN", SqlDbType.Int);
            CMD.Parameters["@RETURN"].Value = DBNull.Value;
            CMD.Parameters["@RETURN"].Direction = ParameterDirection.ReturnValue;

            return Combustible_CompraDA.Acceder(CMD);

        }

        public static ENResultOperation Eliminar(ClsCombustible_CompraBE Datos)
        {
            SqlCommand CMD = new SqlCommand("PA_COMBUSTIBLE_COMPRA_ELIMINA");
            CMD.Parameters.Add(Parametros_SQL.nombre_error, SqlDbType.VarChar).Value = DBNull.Value;
            CMD.Parameters.Add(Parametros_SQL.comp_ide, SqlDbType.Int).Value = Datos.Comp_ide;
            CMD.Parameters.Add(Parametros_SQL.usuario, SqlDbType.VarChar).Value = Datos.Usuario;

            CMD.Parameters.Add("@RETURN", SqlDbType.Int);
            CMD.Parameters["@RETURN"].Value = DBNull.Value;
            CMD.Parameters["@RETURN"].Direction = ParameterDirection.ReturnValue;


            return Combustible_CompraDA.Acceder(CMD);
        }

        public static ENResultOperation Listar(string Texto_Buscar)
        {
            SqlCommand CMD = new SqlCommand("SELECT * FROM V_COMBUSTIBLE_COMPRA  WHERE PROV_IDE LIKE '" +
                   Texto_Buscar + "%' ORDER BY COMP_FECHA,COMP_NUMERO" );
            return ProcesarSQLDA.Procesar_SQL(CMD);

        }
        public static ENResultOperation Buscar_Comprobante(Int32 nComp_Ide)
        {
            SqlCommand CMD = new SqlCommand("SELECT * FROM V_COMBUSTIBLE_COMPRA  WHERE COMP_IDE = @IDE ");

            CMD.Parameters.AddWithValue("@IDE", nComp_Ide);
            return ProcesarSQLDA.Procesar_SQL(CMD);

        }

        public static ENResultOperation Listar_Filtro(string Texto_Buscar, string Condic_Buscar, DateTime FecIni, DateTime FecFin)
        {
            SqlCommand CMD = new SqlCommand("PA_COMBUSTIBLE_COMPRA_LISTAR_FILTRO");
            CMD.Parameters.Add(Parametros_SQL.nombre_error, SqlDbType.VarChar).Value = DBNull.Value;
            CMD.Parameters.Add("@FILTRO", SqlDbType.VarChar).Value = Texto_Buscar;
            CMD.Parameters.Add("@CONDIC", SqlDbType.VarChar).Value = Condic_Buscar;
            CMD.Parameters.Add("@FECINI", SqlDbType.DateTime).Value = FecIni;
            CMD.Parameters.Add("@FECFIN", SqlDbType.DateTime).Value = FecFin;

            CMD.Parameters.Add("@RETURN", SqlDbType.Int);
            CMD.Parameters["@RETURN"].Value = DBNull.Value;
            CMD.Parameters["@RETURN"].Direction = ParameterDirection.ReturnValue;
            return Combustible_CompraDA.Acceder(CMD);
        }
        public static ENResultOperation Listar_por_Fechas(DateTime Fecha_Inicio, DateTime Fecha_Fin)
        {
            SqlCommand CMD = new SqlCommand("PA_COMBUSTIBLE_COMPRA_LISTAR_POR_FECHAS");
            CMD.Parameters.Add(Parametros_SQL.nombre_error, SqlDbType.VarChar).Value = DBNull.Value;
            CMD.Parameters.Add("@FECINI", SqlDbType.DateTime).Value = Fecha_Inicio;
            CMD.Parameters.Add("@FECFIN", SqlDbType.DateTime).Value = Fecha_Fin;

            CMD.Parameters.Add("@RETURN", SqlDbType.Int);
            CMD.Parameters["@RETURN"].Value = DBNull.Value;
            CMD.Parameters["@RETURN"].Direction = ParameterDirection.ReturnValue;
            return Combustible_CompraDA.Acceder(CMD);
        }
        public static ENResultOperation Reprocesar_Consumo(DateTime Fecha_Inicio, DateTime Fecha_Fin)
        {
            SqlCommand CMD = new SqlCommand("PA_COMBUSTIBLE_CONSUMO_REPROCESO");
            CMD.Parameters.Add(Parametros_SQL.nombre_error, SqlDbType.VarChar).Value = DBNull.Value;
            CMD.Parameters.Add("@FECINI", SqlDbType.DateTime).Value = Fecha_Inicio;
            CMD.Parameters.Add("@FECFIN", SqlDbType.DateTime).Value = Fecha_Fin;

            CMD.Parameters.Add("@RETURN", SqlDbType.Int);
            CMD.Parameters["@RETURN"].Value = DBNull.Value;
            CMD.Parameters["@RETURN"].Direction = ParameterDirection.ReturnValue;
            return Combustible_CompraDA.Acceder(CMD);
        }
    }
}
