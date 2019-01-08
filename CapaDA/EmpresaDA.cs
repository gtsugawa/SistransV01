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
    class EmpresaDA
    {
        private static SqlConnection CN = new SqlConnection(StrConexion.strcn1);

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
    public class ClsEmpresaDA
    {
        public struct Parametros_SQL
        {
            public const string nombre_error = "@NOMBRE_ERROR";
            public const string ide = "@IDE";   // Int
            public const string empresa = "@EMPRESA";   // varchar(50),
            public const string servidor = "@SERVIDOR";   //  varchar(50),
            public const string proveedor = "@PROVEEDOR";   //  varchar(50),
            public const string usuario = "@USUARIO";   //  varchar(50),
            public const string clave = "@CLAVE";   //  varchar(150),
            public const string nombre_bd = "@NOMBRE_BD";   //  varchar(50),
            public const string tiempo = "@TIEMPO";   //  INT,
            public const string dolar = "@DOLAR";   //  CHAR(2),
            public const string codigo_registro = "@CODIGO_REGISTRO";   //  VARCHAR(12),
            public const string veces = "@VECES";   //  integer
            public const string ide_anterior = "@IDE_ANTERIOR";   // Int
        }

        public static ENResultOperation Crear(ClsEmpresaBE Datos)
        {
            SqlCommand CMD = new SqlCommand("PA_EMPRESA_INSERTA");
            CMD.Parameters.Add(Parametros_SQL.nombre_error, SqlDbType.VarChar).Value = DBNull.Value;
            CMD.Parameters.Add(Parametros_SQL.empresa, SqlDbType.VarChar).Value = Datos.Empr_ide;
            CMD.Parameters.Add(Parametros_SQL.servidor, SqlDbType.VarChar).Value = Datos.Empr_nombre_empresa;
            CMD.Parameters.Add(Parametros_SQL.proveedor, SqlDbType.VarChar).Value = Datos.Empr_proveedor;
            CMD.Parameters.Add(Parametros_SQL.usuario, SqlDbType.VarChar).Value = Datos.Empr_usuario;
            CMD.Parameters.Add(Parametros_SQL.clave, SqlDbType.VarChar).Value = Datos.Empr_clave;
            CMD.Parameters.Add(Parametros_SQL.nombre_bd, SqlDbType.VarChar).Value = Datos.Empr_nombre_bd;
            CMD.Parameters.Add(Parametros_SQL.tiempo, SqlDbType.Int).Value = Datos.Empr_tiempo;
            CMD.Parameters.Add(Parametros_SQL.dolar, SqlDbType.VarChar).Value = Datos.Empr_contabilidad_dolar;
            CMD.Parameters.Add(Parametros_SQL.codigo_registro, SqlDbType.VarChar).Value = Datos.Empr_codigo_registro;
            CMD.Parameters.Add(Parametros_SQL.veces, SqlDbType.Int).Value = Datos.Veces;
            return EmpresaDA.Acceder(CMD);
        }

        public static ENResultOperation Actualizar(ClsEmpresaBE Datos)
        {
            SqlCommand CMD = new SqlCommand("PA_EMPRESA_MODIFICA");
            CMD.Parameters.Add(Parametros_SQL.nombre_error, SqlDbType.VarChar).Value = "";
            CMD.Parameters.Add(Parametros_SQL.empresa, SqlDbType.VarChar).Value = Datos.Empr_ide;
            CMD.Parameters.Add(Parametros_SQL.servidor, SqlDbType.VarChar).Value = Datos.Empr_nombre_empresa;
            CMD.Parameters.Add(Parametros_SQL.proveedor, SqlDbType.VarChar).Value = Datos.Empr_proveedor;
            CMD.Parameters.Add(Parametros_SQL.usuario, SqlDbType.VarChar).Value = Datos.Empr_usuario;
            CMD.Parameters.Add(Parametros_SQL.clave, SqlDbType.VarChar).Value = Datos.Empr_clave;
            CMD.Parameters.Add(Parametros_SQL.nombre_bd, SqlDbType.VarChar).Value = Datos.Empr_nombre_bd;
            CMD.Parameters.Add(Parametros_SQL.tiempo, SqlDbType.Int).Value = Datos.Empr_tiempo;
            CMD.Parameters.Add(Parametros_SQL.dolar, SqlDbType.VarChar).Value = Datos.Empr_contabilidad_dolar;
            CMD.Parameters.Add(Parametros_SQL.codigo_registro, SqlDbType.VarChar).Value = Datos.Empr_codigo_registro;
            CMD.Parameters.Add(Parametros_SQL.veces, SqlDbType.Int).Value = Datos.Veces;
            CMD.Parameters.Add(Parametros_SQL.ide_anterior, SqlDbType.VarChar).Value = Datos.Empr_ide_anterior;
            return EmpresaDA.Acceder(CMD);
        }

        public static ENResultOperation Eliminar(ClsEmpresaBE Datos)
        {
            SqlCommand CMD = new SqlCommand("PA_EMPRESA_ELIMINA");
            CMD.Parameters.Add(Parametros_SQL.nombre_error, SqlDbType.VarChar).Value = "";
            CMD.Parameters.Add(Parametros_SQL.ide, SqlDbType.VarChar).Value = Datos.Empr_ide;
            CMD.Parameters.Add(Parametros_SQL.veces, SqlDbType.Int).Value = Datos.Veces;
            return EmpresaDA.Acceder(CMD);
        }

        public static ENResultOperation Listar(string Texto_Buscar)
        {

            SqlCommand CMD = new SqlCommand("SELECT * FROM EMPRESA ORDER BY EMPR_IDE ");
            return EmpresaDA.Procesar_SQL(CMD);
         }

        public static ENResultOperation Listar_Filtro(Int32 Empresa)
        {
            SqlCommand CMD = new SqlCommand("SELECT * FROM EMPRESA WHRE EMPRE_IDE = @IDE");
            CMD.Parameters.AddWithValue("@IDE", Empresa);
            return EmpresaDA.Procesar_SQL(CMD);
        }
    }
}
