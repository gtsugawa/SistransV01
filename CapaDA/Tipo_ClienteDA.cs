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
    public class Tipo_ClienteDA
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
         public class ClsTipo_ClienteDA
         {
             public struct Parametros_SQL
             {
                 public const string nombre_error = "@NOMBRE_ERROR";
                 public const string codigo = "@CODIGO"; // INT OUTPUT,
                 public const string ide = "@IDE"; // INT OUTPUT,
                 public const string nombre = "@NOMBRE"; // VARCHAR(20),
                 public const string cuenta_factura_local = "@CUENTA_FACTURA_LOCAL"; //_LOCAL INT,
                 public const string cuenta_n_debito_local = "@CUENTA_N_DEBITO_LOCAL"; // INT,
                 public const string cuenta_n_credito_local = "@CUENTA_N_CREDITO_LOCAL"; // INT,
                 public const string cuenta_boleta_local = "@CUENTA_BOLETA_LOCAL"; // INT,
                 public const string cuenta_factura_dolar = "@CUENTA_FACTURA_DOLAR"; // INT,
                 public const string cuenta_n_debito_dolar = "@CUENTA_N_DEBITO_DOLAR";  // INT,
                 public const string cuenta_n_credito_dolar = "@CUENTA_N_CREDITO_DOLAR";  // INT,
                 public const string cuenta_boleta_dolar = "@CUENTA_BOLETA_DOLAR"; // INT,
                 public const string cuenta_factura_local_diferida = "@CUENTA_FACTURA_LOCAL_DIFERIDA"; // INT,
                 public const string cuenta_n_debito_local_diferida = "@CUENTA_N_DEBITO_LOCAL_DIFERIDA"; // INT,
                 public const string cuenta_n_credito_local_diferida = "@CUENTA_N_CREDITO_LOCAL_DIFERIDA"; // INT,
                 public const string cuenta_boleta_local_diferida = "@CUENTA_BOLETA_LOCAL_DIFERIDA"; // INT,
                 public const string cuenta_factura_dolar_diferida = "@CUENTA_FACTURA_DOLAR_DIFERIDA"; // INT,
                 public const string cuenta_n_debito_dolar_diferida = "@CUENTA_N_DEBITO_DOLAR_DIFERIDA";  // INT,
                 public const string cuenta_n_credito_dolar_diferida = "@CUENTA_N_CREDITO_DOLAR_DIFERIDA"; // INT,
                 public const string cuenta_boleta_dolar_diferida = "@CUENTA_BOLETA_DOLAR_DIFERIDA"; // INT,
                 public const string estado = "@ESTADO"; // varchar(8),
                 public const string inactiva = "@INACTIVA"; // datetime,
                 public const string veces = "@VECES"; // integer,
                 public const string usuario = "@USUARIO"; // CHAR(15)

             }

             public static ENResultOperation Crear(ClsTipo_ClienteBE Datos)
             {
                SqlCommand CMD = new SqlCommand("PA_TIPO_CLIENTE_INSERTA");
                CMD.Parameters.Add(Parametros_SQL.nombre_error, SqlDbType.VarChar).Value = "";
                CMD.Parameters.Add(Parametros_SQL.codigo, SqlDbType.Int).Value = Datos.Tipo_clie_ide;
                CMD.Parameters.Add(Parametros_SQL.nombre, SqlDbType.VarChar).Value = Datos.Tipo_clie_nombre;
                CMD.Parameters.Add(Parametros_SQL.cuenta_factura_local, SqlDbType.Int).Value = Datos.Pla_cta_ide_factura_local;
                CMD.Parameters.Add(Parametros_SQL.cuenta_n_debito_local, SqlDbType.Int).Value = Datos.Pla_cta_ide_n_debito_local;
                CMD.Parameters.Add(Parametros_SQL.cuenta_n_credito_local, SqlDbType.Int).Value = Datos.Pla_cta_ide_n_credito_local;
                CMD.Parameters.Add(Parametros_SQL.cuenta_boleta_local, SqlDbType.Int).Value = Datos.Pla_cta_ide_boleta_local;
                CMD.Parameters.Add(Parametros_SQL.cuenta_factura_dolar, SqlDbType.Int).Value = Datos.Pla_cta_ide_factura_dolar;
                CMD.Parameters.Add(Parametros_SQL.cuenta_n_debito_dolar, SqlDbType.Int).Value = Datos.Pla_cta_ide_n_debito_dolar;
                CMD.Parameters.Add(Parametros_SQL.cuenta_n_credito_dolar, SqlDbType.Int).Value = Datos.Pla_cta_ide_n_credito_dolar;
                CMD.Parameters.Add(Parametros_SQL.cuenta_boleta_dolar, SqlDbType.Int).Value = Datos.Pla_cta_ide_boleta_dolar;
                CMD.Parameters.Add(Parametros_SQL.cuenta_factura_local_diferida, SqlDbType.Int).Value = Datos.Pla_cta_ide_factura_local_diferida;
                CMD.Parameters.Add(Parametros_SQL.cuenta_n_debito_local_diferida, SqlDbType.Int).Value = Datos.Pla_cta_ide_n_debito_local_diferida;
                CMD.Parameters.Add(Parametros_SQL.cuenta_n_credito_local_diferida, SqlDbType.Int).Value = Datos.Pla_cta_ide_n_credito_local_diferida;
                CMD.Parameters.Add(Parametros_SQL.cuenta_boleta_local_diferida, SqlDbType.Int).Value = Datos.Pla_cta_ide_boleta_local_diferida;
                CMD.Parameters.Add(Parametros_SQL.cuenta_factura_dolar_diferida, SqlDbType.Int).Value = Datos.Pla_cta_ide_factura_dolar_diferida;
                CMD.Parameters.Add(Parametros_SQL.cuenta_n_debito_dolar_diferida, SqlDbType.Int).Value = Datos.Pla_cta_ide_n_debito_dolar_diferida;
                CMD.Parameters.Add(Parametros_SQL.cuenta_n_credito_dolar_diferida, SqlDbType.Int).Value = Datos.Pla_cta_ide_n_credito_dolar_diferida;
                CMD.Parameters.Add(Parametros_SQL.cuenta_boleta_dolar_diferida, SqlDbType.Int).Value = Datos.Pla_cta_ide_boleta_dolar_diferida;
                CMD.Parameters.Add(Parametros_SQL.estado, SqlDbType.VarChar).Value = Datos.Tipo_clie_estado;
                CMD.Parameters.Add(Parametros_SQL.inactiva, SqlDbType.DateTime).Value = Datos.Tipo_clie_fechainac;
                CMD.Parameters.Add(Parametros_SQL.veces, SqlDbType.Int).Value = Datos.Veces;
                CMD.Parameters.Add(Parametros_SQL.usuario, SqlDbType.VarChar).Value = Datos.Usuario;
                return Tipo_ClienteDA.Acceder(CMD);
             }

             public static ENResultOperation Actualizar(ClsTipo_ClienteBE Datos)
             {
                 SqlCommand CMD = new SqlCommand("PA_TIPO_CLIENTE_MODIFICA");
                 CMD.Parameters.Add(Parametros_SQL.nombre_error, SqlDbType.VarChar).Value = "";
                 CMD.Parameters.Add(Parametros_SQL.ide, SqlDbType.Int).Value = Datos.Tipo_clie_ide;
                 CMD.Parameters.Add(Parametros_SQL.nombre, SqlDbType.VarChar).Value = Datos.Tipo_clie_nombre;
                 CMD.Parameters.Add(Parametros_SQL.cuenta_factura_local, SqlDbType.Int).Value = Datos.Pla_cta_ide_factura_local;
                 CMD.Parameters.Add(Parametros_SQL.cuenta_n_debito_local, SqlDbType.Int).Value = Datos.Pla_cta_ide_n_debito_local;
                 CMD.Parameters.Add(Parametros_SQL.cuenta_n_credito_local, SqlDbType.Int).Value = Datos.Pla_cta_ide_n_credito_local;
                 CMD.Parameters.Add(Parametros_SQL.cuenta_boleta_local, SqlDbType.Int).Value = Datos.Pla_cta_ide_boleta_local;
                 CMD.Parameters.Add(Parametros_SQL.cuenta_factura_dolar, SqlDbType.Int).Value = Datos.Pla_cta_ide_factura_dolar;
                 CMD.Parameters.Add(Parametros_SQL.cuenta_n_debito_dolar, SqlDbType.Int).Value = Datos.Pla_cta_ide_n_debito_dolar;
                 CMD.Parameters.Add(Parametros_SQL.cuenta_n_credito_dolar, SqlDbType.Int).Value = Datos.Pla_cta_ide_n_credito_dolar;
                 CMD.Parameters.Add(Parametros_SQL.cuenta_boleta_dolar, SqlDbType.Int).Value = Datos.Pla_cta_ide_boleta_dolar;
                 CMD.Parameters.Add(Parametros_SQL.cuenta_factura_local_diferida, SqlDbType.Int).Value = Datos.Pla_cta_ide_factura_local_diferida;
                 CMD.Parameters.Add(Parametros_SQL.cuenta_n_debito_local_diferida, SqlDbType.Int).Value = Datos.Pla_cta_ide_n_debito_local_diferida;
                 CMD.Parameters.Add(Parametros_SQL.cuenta_n_credito_local_diferida, SqlDbType.Int).Value = Datos.Pla_cta_ide_n_credito_local_diferida;
                 CMD.Parameters.Add(Parametros_SQL.cuenta_boleta_local_diferida, SqlDbType.Int).Value = Datos.Pla_cta_ide_boleta_local_diferida;
                 CMD.Parameters.Add(Parametros_SQL.cuenta_factura_dolar_diferida, SqlDbType.Int).Value = Datos.Pla_cta_ide_factura_dolar_diferida;
                 CMD.Parameters.Add(Parametros_SQL.cuenta_n_debito_dolar_diferida, SqlDbType.Int).Value = Datos.Pla_cta_ide_n_debito_dolar_diferida;
                 CMD.Parameters.Add(Parametros_SQL.cuenta_n_credito_dolar_diferida, SqlDbType.Int).Value = Datos.Pla_cta_ide_n_credito_dolar_diferida;
                 CMD.Parameters.Add(Parametros_SQL.cuenta_boleta_dolar_diferida, SqlDbType.Int).Value = Datos.Pla_cta_ide_boleta_dolar_diferida;
                 CMD.Parameters.Add(Parametros_SQL.estado, SqlDbType.VarChar).Value = Datos.Tipo_clie_estado;
                 CMD.Parameters.Add(Parametros_SQL.inactiva, SqlDbType.DateTime).Value = Datos.Tipo_clie_fechainac;
                 CMD.Parameters.Add(Parametros_SQL.veces, SqlDbType.Int).Value = Datos.Veces;
                 CMD.Parameters.Add(Parametros_SQL.usuario, SqlDbType.VarChar).Value = Datos.Usuario;
                 return Tipo_ClienteDA.Acceder(CMD);
             }

             public static ENResultOperation Eliminar(ClsTipo_ClienteBE Datos)
             {
                 SqlCommand CMD = new SqlCommand("PA_TIPO_CLIENTE_ELIMINA");
                 CMD.Parameters.Add(Parametros_SQL.nombre_error, SqlDbType.VarChar).Value = "";
                 CMD.Parameters.Add(Parametros_SQL.ide, SqlDbType.Int).Value = Datos.Tipo_clie_ide;
                 CMD.Parameters.Add(Parametros_SQL.veces, SqlDbType.Int).Value = Datos.Veces;
                 CMD.Parameters.Add(Parametros_SQL.usuario, SqlDbType.VarChar).Value = Datos.Usuario;
                 return Tipo_ClienteDA.Acceder(CMD);
             }

             public static ENResultOperation Listar(string Texto_Buscar)
             {
                 SqlCommand CMD = new SqlCommand("SELECT * FROM TIPO_CLIENTE WHERE TIPO_CLIE_ESTADO = 'Activo' AND TIPO_CLIE_NOMBRE LIKE '" +
                                  Texto_Buscar + "%'");
                 return Tipo_ClienteDA.Procesar_SQL(CMD);
                 /*
                 SqlCommand CMD = new SqlCommand("PA_TIPO_CLIENTE_LISTAR");
                 CMD.Parameters.Add(Parametros_SQL.nombre_error, SqlDbType.VarChar).Value = Texto_Buscar;

                 return Tipo_ClienteDA.Acceder(CMD);
                 */
             }

             public static ENResultOperation Listar_Filtro(string Texto_Buscar)
             {
                 SqlCommand CMD = new SqlCommand("PA_TIPO_CLIENTE_LISTAR_FILTRO");
                 CMD.Parameters.Add(Parametros_SQL.nombre_error, SqlDbType.VarChar).Value = Texto_Buscar;

                 return Tipo_ClienteDA.Acceder(CMD);
             }

             
         }

       
    
}
