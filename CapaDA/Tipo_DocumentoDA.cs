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
    class Tipo_DocumentoDA
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
    public class ClsTipo_DocumentoDA
    {
        private SqlDataReader dr = null;
        public struct Parametros_SQL
        {
            public const string nombre_error = "@NOMBRE_ERROR";
            public const string ide = "@IDE";
            public const string codigo = "@CODIGO";  // VARCHAR(5),
            public const string nombre = "@NOMBRE";  // VARCHAR(30),
            public const string abreviado = "@ABREVIADO";  // VARCHAR(5),
            public const string tipo = "@TIPO";  // VARCHAR(10),
            public const string chequea_duplicidad = "@CHEQUEA_DUPLICIDAD";  // INT,
            public const string codigo1 = "@CODIGO1";  // VARCHAR(5),
            public const string codigo_sunat = "@CODIGO_SUNAT";  // VARCHAR(6),
            public const string estado = "@ESTADO";  // varchar(8),
            public const string inactiva = "@INACTIVA";  // datetime,
            public const string veces = "@VECES";  // integer,
            public const string usuario = "@USUARIO";  // CHAR(15)
        }

        public static ENResultOperation Crear(ClsTipo_DocumentoBE Datos)
        {
            SqlCommand CMD = new SqlCommand("PA_TIPO_DOCUMENTO_INSERTA");
            CMD.Parameters.Add(Parametros_SQL.nombre_error, SqlDbType.VarChar).Value = "";
            CMD.Parameters.Add(Parametros_SQL.ide, SqlDbType.Int).Value = Datos.Tipo_doc_ide;
            CMD.Parameters.Add(Parametros_SQL.nombre, SqlDbType.VarChar).Value = Datos.Tipo_doc_nombre;
            CMD.Parameters.Add(Parametros_SQL.abreviado, SqlDbType.VarChar).Value = Datos.Tipo_doc_abreviado;
            CMD.Parameters.Add(Parametros_SQL.tipo, SqlDbType.VarChar).Value = Datos.Tipo_doc_tipo;
            CMD.Parameters.Add(Parametros_SQL.chequea_duplicidad, SqlDbType.Int).Value = Datos.Tipo_doc_chequea_duplicidad;
            CMD.Parameters.Add(Parametros_SQL.codigo1, SqlDbType.VarChar).Value = Datos.Tipo_doc_codigo1;
            CMD.Parameters.Add(Parametros_SQL.codigo_sunat, SqlDbType.VarChar).Value = Datos.Tipo_doc_codigo_sunat;
            CMD.Parameters.Add(Parametros_SQL.estado, SqlDbType.VarChar).Value = Datos.Tipo_doc_estado;
            CMD.Parameters.Add(Parametros_SQL.veces, SqlDbType.Int).Value = Datos.Veces;
            CMD.Parameters.Add(Parametros_SQL.usuario, SqlDbType.VarChar).Value = Datos.Usuario;

            CMD.Parameters.Add("@RETURN", SqlDbType.Int);
            CMD.Parameters["@RETURN"].Value = DBNull.Value;
            CMD.Parameters["@RETURN"].Direction = ParameterDirection.ReturnValue;

            return Tipo_DocumentoDA.Acceder(CMD);

        }

        public static ENResultOperation Actualizar(ClsTipo_DocumentoBE Datos)
        {
            SqlCommand CMD = new SqlCommand("PA_TIPO_DOCUMENTO_MODIFICA");
            CMD.Parameters.Add(Parametros_SQL.nombre_error, SqlDbType.VarChar).Value = "";
            CMD.Parameters.Add(Parametros_SQL.ide, SqlDbType.Int).Value = Datos.Tipo_doc_ide;
            CMD.Parameters.Add(Parametros_SQL.nombre, SqlDbType.VarChar).Value = Datos.Tipo_doc_nombre;
            CMD.Parameters.Add(Parametros_SQL.abreviado, SqlDbType.VarChar).Value = Datos.Tipo_doc_abreviado;
            CMD.Parameters.Add(Parametros_SQL.tipo, SqlDbType.VarChar).Value = Datos.Tipo_doc_tipo;
            CMD.Parameters.Add(Parametros_SQL.chequea_duplicidad, SqlDbType.Int).Value = Datos.Tipo_doc_chequea_duplicidad;
            CMD.Parameters.Add(Parametros_SQL.codigo1, SqlDbType.VarChar).Value = Datos.Tipo_doc_codigo1;
            CMD.Parameters.Add(Parametros_SQL.codigo_sunat, SqlDbType.VarChar).Value = Datos.Tipo_doc_codigo_sunat;
            CMD.Parameters.Add(Parametros_SQL.estado, SqlDbType.VarChar).Value = Datos.Tipo_doc_estado;
            CMD.Parameters.Add(Parametros_SQL.veces, SqlDbType.Int).Value = Datos.Veces;
            CMD.Parameters.Add(Parametros_SQL.usuario, SqlDbType.VarChar).Value = Datos.Usuario;

            CMD.Parameters.Add("@RETURN", SqlDbType.Int);
            CMD.Parameters["@RETURN"].Value = DBNull.Value;
            CMD.Parameters["@RETURN"].Direction = ParameterDirection.ReturnValue;

            return Tipo_DocumentoDA.Acceder(CMD);

        }

        public static ENResultOperation Eliminar(ClsTipo_DocumentoBE Datos)
        {
            SqlCommand CMD = new SqlCommand("PA_TIPO_DOCUMENTO_ELIMINA");
            CMD.Parameters.Add(Parametros_SQL.nombre_error, SqlDbType.VarChar).Value = DBNull.Value;
            CMD.Parameters.Add(Parametros_SQL.ide, SqlDbType.Int).Value = Datos.Tipo_doc_ide;
            CMD.Parameters.Add(Parametros_SQL.veces, SqlDbType.Int).Value = Datos.Veces;
            CMD.Parameters.Add(Parametros_SQL.usuario, SqlDbType.VarChar).Value = Datos.Usuario;

            CMD.Parameters.Add("@RETURN", SqlDbType.Int);
            CMD.Parameters["@RETURN"].Value = DBNull.Value;
            CMD.Parameters["@RETURN"].Direction = ParameterDirection.ReturnValue;


            return Tipo_DocumentoDA.Acceder(CMD);
        }

        public static ENResultOperation Listar(string Texto_Buscar)
        {

            SqlCommand CMD = new SqlCommand("SELECT * FROM TIPO_DOCUMENTO WHERE TIPO_DOC_ESTADO = 'Activo' " +
                                            "AND CONVERT(INT, TIPO_DOC_CODIGO_SUNAT) > 0 AND Tipo_Doc_Nombre LIKE @TEXTO + '%'");
            CMD.Parameters.AddWithValue("@TEXTO", Texto_Buscar);
            return Tipo_DocumentoDA.Procesar_SQL(CMD);
        }

        public static ENResultOperation Listar_Filtro(string Texto_Buscar)
        {
            SqlCommand CMD = new SqlCommand("PA_TIPO_DOCUMENTO_LISTAR_FILTRO");
            CMD.Parameters.Add(Parametros_SQL.nombre_error, SqlDbType.VarChar).Value = Texto_Buscar;

            CMD.Parameters.Add("@RETURN", SqlDbType.Int);
            CMD.Parameters["@RETURN"].Value = DBNull.Value;
            CMD.Parameters["@RETURN"].Direction = ParameterDirection.ReturnValue;

            return Tipo_DocumentoDA.Acceder(CMD);
        }

        public static ENResultOperation Obtener_Registro(Int32 Tipo_Doc_Ide)
        {
            SqlCommand CMD = new SqlCommand("SELECT * FROM TIPO_DOCUMENTO WHERE TIPO_DOC_IDE = " +
                             Tipo_Doc_Ide.ToString());

            return Tipo_DocumentoDA.Procesar_SQL(CMD);
        }
    }
}
