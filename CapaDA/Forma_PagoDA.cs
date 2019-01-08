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
    class Forma_PagoDA
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

    public class ClsForma_PagoDA
    {
        private SqlDataReader dr = null;
        public struct Parametros_SQL
        {

            public const string nombre_error = "@NOMBRE_ERROR";
            public const string for_pag_ide  = "@CODIGO";
            public const string for_pag_nombre = "@NOMBRE";
            public const string for_pag_nombre_ingles = "@NOMBRE_INGLES";
            public const string for_pag_canje = "@CANJE";
            public const string for_pag_numero_documento = "@NUMERO_DOCUMENTO";
            public const string for_pag_vencimiento1 = "@VENCIMIENTO1";
            public const string for_pag_lista_precio = "@LISTA_PRECIO";
            public const string for_pag_estado = "@ESTADO";
            public const string for_pag_fechainac = "@INACTIVA";
            public const string veces = "@VECES";
            public const string usuario = "@USUARIO";
        }

        public static ENResultOperation Crear(ClsForma_PagoBE Datos)
        {
            SqlCommand CMD = new SqlCommand("PA_FORMA_PAGO_INSERTA");
            CMD.Parameters.Add(Parametros_SQL.nombre_error, SqlDbType.VarChar, 100).Value = "";
            CMD.Parameters.Add(Parametros_SQL.for_pag_ide, SqlDbType.Int).Value = Datos.For_pag_ide;
            CMD.Parameters.Add(Parametros_SQL.for_pag_nombre, SqlDbType.VarChar).Value = Datos.For_pag_nombre;
            CMD.Parameters.Add(Parametros_SQL.for_pag_nombre_ingles, SqlDbType.VarChar).Value = Datos.For_pag_nombre_ingles;
            CMD.Parameters.Add(Parametros_SQL.for_pag_canje, SqlDbType.VarChar).Value = Datos.For_pag_canje;
            CMD.Parameters.Add(Parametros_SQL.for_pag_numero_documento, SqlDbType.Int).Value = Datos.For_pag_numero_documento;
            CMD.Parameters.Add(Parametros_SQL.for_pag_vencimiento1, SqlDbType.Int).Value = Datos.For_pag_vencimiento1;
            CMD.Parameters.Add(Parametros_SQL.for_pag_lista_precio, SqlDbType.VarChar).Value = Datos.For_pag_lista_precio;
            CMD.Parameters.Add(Parametros_SQL.for_pag_estado, SqlDbType.VarChar).Value = Datos.For_pag_estado;
            CMD.Parameters.Add(Parametros_SQL.for_pag_fechainac, SqlDbType.DateTime).Value = Datos.For_pag_fechainac;
            CMD.Parameters.Add(Parametros_SQL.veces, SqlDbType.Int).Value = Datos.Veces;
            CMD.Parameters.Add(Parametros_SQL.usuario, SqlDbType.VarChar).Value = Datos.Usuario;

            CMD.Parameters.Add("@RETURN", SqlDbType.Int).Value = DBNull.Value;
            CMD.Parameters["@RETURN"].Direction = ParameterDirection.ReturnValue;
            CMD.Parameters["@NOMBRE_ERROR"].Direction = ParameterDirection.Output;
            return Forma_PagoDA.Acceder(CMD);

        }

        public static ENResultOperation Actualizar(ClsForma_PagoBE Datos)
        {
            SqlCommand CMD = new SqlCommand("PA_FORMA_PAGO_MODIFICA");
            CMD.Parameters.Add(Parametros_SQL.nombre_error, SqlDbType.VarChar, 100).Value = "";
            CMD.Parameters.Add(Parametros_SQL.for_pag_ide, SqlDbType.Int).Value = Datos.For_pag_ide;
            CMD.Parameters.Add(Parametros_SQL.for_pag_nombre, SqlDbType.VarChar).Value = Datos.For_pag_nombre;
            CMD.Parameters.Add(Parametros_SQL.for_pag_nombre_ingles, SqlDbType.VarChar).Value = Datos.For_pag_nombre_ingles;
            CMD.Parameters.Add(Parametros_SQL.for_pag_canje, SqlDbType.VarChar).Value = Datos.For_pag_canje;
            CMD.Parameters.Add(Parametros_SQL.for_pag_numero_documento, SqlDbType.Int).Value = Datos.For_pag_numero_documento;
            CMD.Parameters.Add(Parametros_SQL.for_pag_vencimiento1, SqlDbType.Int).Value = Datos.For_pag_vencimiento1;
            CMD.Parameters.Add(Parametros_SQL.for_pag_lista_precio, SqlDbType.VarChar).Value = Datos.For_pag_lista_precio;
            CMD.Parameters.Add(Parametros_SQL.for_pag_estado, SqlDbType.VarChar).Value = Datos.For_pag_estado;
            CMD.Parameters.Add(Parametros_SQL.for_pag_fechainac, SqlDbType.DateTime).Value = Datos.For_pag_fechainac;
            CMD.Parameters.Add(Parametros_SQL.veces, SqlDbType.Int).Value = Datos.Veces;
            CMD.Parameters.Add(Parametros_SQL.usuario, SqlDbType.VarChar).Value = Datos.Usuario;

            CMD.Parameters.Add("@RETURN", SqlDbType.Int).Value = DBNull.Value;
            CMD.Parameters["@RETURN"].Direction = ParameterDirection.ReturnValue;
            CMD.Parameters["@NOMBRE_ERROR"].Direction = ParameterDirection.Output;
            return Forma_PagoDA.Acceder(CMD);

        }

        public static ENResultOperation Eliminar(ClsForma_PagoBE Datos)
        {
            SqlCommand CMD = new SqlCommand("PA_FORMA_PAGO_ELIMINA");
            CMD.Parameters.Add(Parametros_SQL.nombre_error, SqlDbType.VarChar, 100).Value = DBNull.Value;
            CMD.Parameters.Add(Parametros_SQL.for_pag_ide, SqlDbType.Int).Value = Datos.For_pag_ide;
            CMD.Parameters.Add(Parametros_SQL.veces, SqlDbType.Int).Value = Datos.Veces;
            CMD.Parameters.Add(Parametros_SQL.usuario, SqlDbType.VarChar).Value = Datos.Usuario;

            CMD.Parameters.Add("@RETURN", SqlDbType.Int).Value = DBNull.Value;
            CMD.Parameters["@RETURN"].Direction = ParameterDirection.ReturnValue;
            CMD.Parameters["@NOMBRE_ERROR"].Direction = ParameterDirection.Output;
            return Forma_PagoDA.Acceder(CMD);
        }

        public static ENResultOperation Listar(string Texto_Buscar)
        {
            SqlCommand CMD = new SqlCommand("SELECT * FROM  FORMA_PAGO WHERE FOR_PAG_ESTADO = 'Activo' AND FOR_PAG_NOMBRE LIKE '" + Texto_Buscar + "%' ORDER BY FOR_PAG_NOMBRE");
            return ProcesarSQLDA.Procesar_SQL(CMD);
        }

        public static ENResultOperation Listar_Filtro(string Texto_Buscar)
        {
            SqlCommand CMD = new SqlCommand("PA_FORMA_PAGO_LISTAR_FILTRO");
            CMD.Parameters.Add(Parametros_SQL.nombre_error, SqlDbType.VarChar, 100).Value = Texto_Buscar;

            CMD.Parameters.Add("@RETURN", SqlDbType.Int).Value = DBNull.Value;
            CMD.Parameters["@RETURN"].Direction = ParameterDirection.ReturnValue;
            CMD.Parameters["@NOMBRE_ERROR"].Direction = ParameterDirection.Output;
            return Forma_PagoDA.Acceder(CMD);
        }
    }
}
