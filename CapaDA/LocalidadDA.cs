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
    class LocalidadDA
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
                 if (Convert.ToInt32(ValRetorno) != 0 )
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

        public class ClsLocalidadDA
        {
            public struct Parametros_SQL
            {
                public const string nombre_error = "@NOMBRE_ERROR"; 
                public const string ide = "@IDE"; 
                public const string codigo = "@CODIGO";
                public const string nombre = "@NOMBRE";
                public const string codigo_postal = "@CODIGO_POSTAL"; 
                public const string abreviado = "@ABREVIADO"; 
                public const string pais = "@PAIS"; 
                public const string zona_geografica = "@ZONA_GEOGRAFICA";
                public const string estado = "@ESTADO"; 
                public const string inactiva = "@INACTIVA"; 
                public const string veces = "@VECES"; 
                public const string usuario = "@USUARIO"; 
            }

            public static ENResultOperation Crear(ClsLocalidadBE Datos)
            {
                SqlCommand CMD = new SqlCommand("PA_LOCALIDAD_INSERTA");
                CMD.Parameters.Add(Parametros_SQL.nombre_error, SqlDbType.VarChar).Value = "";
                CMD.Parameters.Add(Parametros_SQL.ide, SqlDbType.Int).Value = Datos.Loca_ide;
                CMD.Parameters.Add(Parametros_SQL.codigo, SqlDbType.VarChar).Value = Datos.Loca_codigo;
                CMD.Parameters.Add(Parametros_SQL.nombre, SqlDbType.VarChar).Value = Datos.Loca_nombre;
                CMD.Parameters.Add(Parametros_SQL.codigo_postal, SqlDbType.VarChar).Value = Datos.Loca_codigo_postal;
                CMD.Parameters.Add(Parametros_SQL.abreviado, SqlDbType.VarChar).Value = Datos.Loca_abreviado;
                CMD.Parameters.Add(Parametros_SQL.pais, SqlDbType.Int).Value = Datos.Pais_ide;
                CMD.Parameters.Add(Parametros_SQL.zona_geografica, SqlDbType.Int).Value = Datos.Zona_geo_ide;
                CMD.Parameters.Add(Parametros_SQL.estado, SqlDbType.VarChar).Value = Datos.Loca_estado;
                CMD.Parameters.Add(Parametros_SQL.inactiva, SqlDbType.DateTime).Value = Datos.Loca_fechainac;
                CMD.Parameters.Add(Parametros_SQL.veces, SqlDbType.Int).Value = Datos.Veces;
                CMD.Parameters.Add(Parametros_SQL.usuario, SqlDbType.VarChar).Value = Datos.Usuario;

                CMD.Parameters.Add("@RETURN", SqlDbType.Int);
                CMD.Parameters["@RETURN"].Value = DBNull.Value;
                CMD.Parameters["@RETURN"].Direction = ParameterDirection.ReturnValue;

                return LocalidadDA.Acceder(CMD);
                
            }

            public static ENResultOperation Actualizar(ClsLocalidadBE Datos)
            {
                SqlCommand CMD = new SqlCommand("PA_LOCALIDAD_MODIFICA");
                CMD.Parameters.Add(Parametros_SQL.nombre_error, SqlDbType.VarChar).Value = "";
                CMD.Parameters.Add(Parametros_SQL.ide, SqlDbType.Int).Value = Datos.Loca_ide;
                CMD.Parameters.Add(Parametros_SQL.codigo, SqlDbType.VarChar).Value = Datos.Loca_codigo;
                CMD.Parameters.Add(Parametros_SQL.nombre, SqlDbType.VarChar).Value = Datos.Loca_nombre;
                CMD.Parameters.Add(Parametros_SQL.codigo_postal, SqlDbType.VarChar).Value = Datos.Loca_codigo_postal;
                CMD.Parameters.Add(Parametros_SQL.abreviado, SqlDbType.VarChar).Value = Datos.Loca_abreviado;
                CMD.Parameters.Add(Parametros_SQL.pais, SqlDbType.Int).Value = Datos.Pais_ide;
                CMD.Parameters.Add(Parametros_SQL.zona_geografica, SqlDbType.Int).Value = Datos.Zona_geo_ide;
                CMD.Parameters.Add(Parametros_SQL.estado, SqlDbType.VarChar).Value = Datos.Loca_estado;
                CMD.Parameters.Add(Parametros_SQL.inactiva, SqlDbType.DateTime).Value = Datos.Loca_fechainac;
                CMD.Parameters.Add(Parametros_SQL.veces, SqlDbType.Int).Value = Datos.Veces;
                CMD.Parameters.Add(Parametros_SQL.usuario, SqlDbType.VarChar).Value = Datos.Usuario;

                CMD.Parameters.Add("@RETURN", SqlDbType.Int);
                CMD.Parameters["@RETURN"].Value = DBNull.Value;
                CMD.Parameters["@RETURN"].Direction = ParameterDirection.ReturnValue;

                return LocalidadDA.Acceder(CMD);

            }

            public static ENResultOperation Eliminar(ClsLocalidadBE Datos)
            {
                SqlCommand CMD = new SqlCommand("PA_LOCALIDAD_ELIMINA");
                CMD.Parameters.Add(Parametros_SQL.nombre_error, SqlDbType.VarChar).Value = DBNull.Value;
                CMD.Parameters.Add(Parametros_SQL.ide, SqlDbType.Int).Value = Datos.Loca_ide;
                CMD.Parameters.Add(Parametros_SQL.veces, SqlDbType.Int).Value = Datos.Veces;
                CMD.Parameters.Add(Parametros_SQL.usuario, SqlDbType.VarChar).Value = Datos.Usuario;

                CMD.Parameters.Add("@RETURN", SqlDbType.Int);
                CMD.Parameters["@RETURN"].Value = DBNull.Value;
                CMD.Parameters["@RETURN"].Direction = ParameterDirection.ReturnValue;
                
                
                return LocalidadDA.Acceder(CMD);
            }

            public static ENResultOperation Listar(string Texto_Buscar)
            {
                SqlCommand CMD = new SqlCommand("SELECT * FROM  LOCALIDAD WHERE LOCA_ESTADO = 'Activo' AND LOCA_NOMBRE LIKE '" +
                 Texto_Buscar + "%'");
                return LocalidadDA.Procesar_SQL(CMD);
             }
            public static ENResultOperation ListarBuscar(string Texto_Buscar)
            {
                SqlCommand CMD = new SqlCommand("SELECT LOCA_IDE,LOCA_CODIGO,LOCA_NOMBRE,PROVINCIA,DEPARTAMENTO,PAIS_NOMBRE FROM  V_LOCALIDAD WHERE LOCA_ESTADO = 'Activo' AND LOCA_NOMBRE LIKE '" +
                 Texto_Buscar + "%' ORDER BY LOCA_NOMBRE");
                return LocalidadDA.Procesar_SQL(CMD);
            }

            public static ENResultOperation ListarTodos(string Texto_Buscar)
            {
                SqlCommand CMD = new SqlCommand("SELECT * FROM  LOCALIDAD WHERE LOCA_NOMBRE LIKE '" +
                 Texto_Buscar + "%'");
                return ProcesarSQLDA.Procesar_SQL(CMD);
            }
            public static ENResultOperation Listar_Filtro(string Texto_Buscar, Int32 Localidad_Ide)
            {
                SqlCommand CMD = new SqlCommand("SELECT * FROM LOCALIDAD WHERE LOCA_IDE = @IDE");
                
                CMD.Parameters.AddWithValue("@IDE", Localidad_Ide);
                return ProcesarSQLDA.Procesar_SQL(CMD);

                /*
                SqlCommand CMD = new SqlCommand("PA_LOCALIDAD_LISTAR_FILTRO");
                CMD.Parameters.Add(Parametros_SQL.nombre_error,SqlDbType.VarChar).Value = Texto_Buscar;
                CMD.Parameters.Add(Parametros_SQL.ide, SqlDbType.Int).Value = Localidad_Ide;

                CMD.Parameters.Add("@RETURN", SqlDbType.Int);
                CMD.Parameters["@RETURN"].Value = DBNull.Value;
                CMD.Parameters["@RETURN"].Direction = ParameterDirection.ReturnValue;

                return LocalidadDA.Acceder(CMD);
                */
            }

        }
}
