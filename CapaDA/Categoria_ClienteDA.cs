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
    class Categoria_ClienteDA
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

                result.Proceder = true;
                result.Sms = "Correcto";
                result.Valor = temp;

                string Nerror = cmd.Parameters["@NOMBRE_ERROR"].Value.ToString();

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
        public class ClsCategoria_ClienteDA
        {
            public struct Parametros_SQL
            {
                public const string nombre_error = "@NOMBRE_ERROR";
                public const string codigo = "@CODIGO"; // INT OUTPUT,
                public const string ide = "@IDE"; // INT OUTPUT,
                public const string nombre = "@NOMBRE"; // VARCHAR(20),
                public const string estado = "@ESTADO"; // varchar(8),
                public const string inactiva = "@INACTIVA"; // datetime,
                public const string veces = "@VECES"; // integer,
                public const string usuario = "@USUARIO"; // CHAR(15)

            }

            public static ENResultOperation Crear(ClsCategoria_ClienteBE Datos)
            {
                SqlCommand CMD = new SqlCommand("PA_CATEGORIA_CLIENTE_INSERTA");
                CMD.Parameters.Add(Parametros_SQL.nombre_error, SqlDbType.VarChar).Value = "";
                CMD.Parameters.Add(Parametros_SQL.codigo, SqlDbType.Int).Value = Datos.Cate_clie_ide;
                CMD.Parameters.Add(Parametros_SQL.nombre, SqlDbType.VarChar).Value = Datos.Cate_clie_nombre;
                CMD.Parameters.Add(Parametros_SQL.estado, SqlDbType.VarChar).Value = Datos.Cate_clie_estado;
                CMD.Parameters.Add(Parametros_SQL.inactiva, SqlDbType.DateTime).Value = Datos.Cate_clie_fechainac;
                CMD.Parameters.Add(Parametros_SQL.veces, SqlDbType.Int).Value = Datos.Veces;
                CMD.Parameters.Add(Parametros_SQL.usuario, SqlDbType.VarChar).Value = Datos.Usuario;
                return Categoria_ClienteDA.Acceder(CMD);
            }

            public static ENResultOperation Actualizar(ClsCategoria_ClienteBE Datos)
            {
                SqlCommand CMD = new SqlCommand("PA_CATEGORIA_CLIENTE_MODIFICA");
                CMD.Parameters.Add(Parametros_SQL.nombre_error, SqlDbType.VarChar).Value = "";
                CMD.Parameters.Add(Parametros_SQL.ide, SqlDbType.Int).Value = Datos.Cate_clie_ide;
                CMD.Parameters.Add(Parametros_SQL.nombre, SqlDbType.VarChar).Value = Datos.Cate_clie_nombre;
                CMD.Parameters.Add(Parametros_SQL.estado, SqlDbType.VarChar).Value = Datos.Cate_clie_estado;
                CMD.Parameters.Add(Parametros_SQL.inactiva, SqlDbType.DateTime).Value = Datos.Cate_clie_fechainac;
                CMD.Parameters.Add(Parametros_SQL.veces, SqlDbType.Int).Value = Datos.Veces;
                CMD.Parameters.Add(Parametros_SQL.usuario, SqlDbType.VarChar).Value = Datos.Usuario;
                return Categoria_ClienteDA.Acceder(CMD);
            }

            public static ENResultOperation Eliminar(ClsCategoria_ClienteBE Datos)
            {
                SqlCommand CMD = new SqlCommand("PA_CATEGORIA_CLIENTE_ELIMINA");
                CMD.Parameters.Add(Parametros_SQL.nombre_error, SqlDbType.VarChar).Value = "";
                CMD.Parameters.Add(Parametros_SQL.ide, SqlDbType.Int).Value = Datos.Cate_clie_ide;
                CMD.Parameters.Add(Parametros_SQL.veces, SqlDbType.Int).Value = Datos.Veces;
                CMD.Parameters.Add(Parametros_SQL.usuario, SqlDbType.VarChar).Value = Datos.Usuario;
                return Categoria_ClienteDA.Acceder(CMD);
            }

            public static ENResultOperation Listar(string Texto_Buscar)
            {
                SqlCommand CMD = new SqlCommand("SELECT * FROM CATEGORIA_CLIENTE WHERE CATE_CLIE_ESTADO = 'Activo' AND CATE_CLIE_NOMBRE LIKE '" +
                                 Texto_Buscar + "%'");
                return Categoria_ClienteDA.Procesar_SQL(CMD);
                /*
                SqlCommand CMD = new SqlCommand("PA_CATEGORIA_CLIENTE_LISTAR");
                CMD.Parameters.Add(Parametros_SQL.nombre_error, SqlDbType.VarChar).Value = Texto_Buscar;

                return Categoria_ClienteDA.Acceder(CMD);
                */
            }

            public static ENResultOperation Listar_Filtro(string Texto_Buscar)
            {
                SqlCommand CMD = new SqlCommand("PA_CATEGORIA_CLIENTE_LISTAR_FILTRO");
                CMD.Parameters.Add(Parametros_SQL.nombre_error, SqlDbType.VarChar).Value = Texto_Buscar;

                return Categoria_ClienteDA.Acceder(CMD);
            }


        }
   
}
