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
    class VendedorDA
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

    public class ClsVendedorDA
    {
        public struct Parametros_SQL
        {
            public const string nombre_error = "@NOMBRE_ERROR";
            public const string ide = "@IDE";
            public const string codigo = "@CODIGO";
            public const string razon_social = "@RAZON_SOCIAL"; // VARCHAR(60),
            public const string empresa = "@EMPRESA"; // CHAR(2),
            public const string paterno = "@PATERNO"; //VARCHAR(20),
            public const string materno = "@MATERNO"; // VARCHAR(20),
            public const string nombre = "@NOMBRE";   // VARCHAR(20),
            public const string telefono1 = "@TELEFONO1"; // VARCHAR(15),
            public const string telefono2 = "@TELEFONO2";  // VARCHAR(15),
            public const string fax = "@FAX"; // VARCHAR(15),
            public const string fecha = "@FECHA";// datetime,
            public const string tipo_documento = "@TIPO_DOCUMENTO"; //INT,
            public const string documento = "@DOCUMENTO"; // VARCHAR(15),
            public const string direccion = "@DIRECCION"; // VARCHAR(60),
            public const string localidad = "@LOCALIDAD"; //  INT,
            public const string correo = "@CORREO";  // VARCHAR(60),
            public const string estado = "@ESTADO";
            public const string inactiva = "@INACTIVA";
            public const string veces = "@VECES";
            public const string usuario = "@USUARIO";
        }

        public static ENResultOperation Crear(ClsVendedorBE Datos)
        {
            SqlCommand CMD = new SqlCommand("PA_VENDEDOR_INSERTA");
            CMD.Parameters.Add(Parametros_SQL.nombre_error, SqlDbType.VarChar).Value = "";
            CMD.Parameters.Add(Parametros_SQL.codigo, SqlDbType.Int).Value = Datos.Vend_codigo;
            CMD.Parameters.Add(Parametros_SQL.razon_social, SqlDbType.VarChar).Value = Datos.Vend_razon_social;
            CMD.Parameters.Add(Parametros_SQL.empresa,SqlDbType.VarChar).Value = Datos.Vend_empresa;
            CMD.Parameters.Add(Parametros_SQL.paterno,SqlDbType.VarChar).Value = Datos.Vend_paterno;
            CMD.Parameters.Add(Parametros_SQL.materno,SqlDbType.VarChar).Value = Datos.Vend_materno;
            CMD.Parameters.Add(Parametros_SQL.nombre,SqlDbType.VarChar).Value = Datos.Vend_nombre;
            CMD.Parameters.Add(Parametros_SQL.direccion, SqlDbType.VarChar).Value = Datos.Vend_direccion;
            CMD.Parameters.Add(Parametros_SQL.telefono1, SqlDbType.VarChar).Value = Datos.Vend_telefono1;
            CMD.Parameters.Add(Parametros_SQL.telefono2,SqlDbType.VarChar).Value = Datos.Vend_telefono2;
            CMD.Parameters.Add(Parametros_SQL.fax,SqlDbType.VarChar).Value = Datos.Vend_fax;
            CMD.Parameters.Add(Parametros_SQL.fecha,SqlDbType.DateTime).Value = Datos.Vend_fecha_nacimiento;
            CMD.Parameters.Add(Parametros_SQL.tipo_documento,SqlDbType.Int).Value = Datos.Docu_iden_ide;
            CMD.Parameters.Add(Parametros_SQL.documento,SqlDbType.VarChar).Value = Datos.Vend_documento;
            CMD.Parameters.Add(Parametros_SQL.localidad,SqlDbType.Int).Value = Datos.Loca_ide;
            CMD.Parameters.Add(Parametros_SQL.correo,SqlDbType.VarChar).Value = Datos.Vend_correo;
            CMD.Parameters.Add(Parametros_SQL.estado, SqlDbType.VarChar).Value = Datos.Vend_estado;
            CMD.Parameters.Add(Parametros_SQL.inactiva, SqlDbType.DateTime).Value = Datos.Vend_fechainac;
            CMD.Parameters.Add(Parametros_SQL.veces, SqlDbType.Int).Value = Datos.Veces;
            CMD.Parameters.Add(Parametros_SQL.usuario, SqlDbType.VarChar).Value = Datos.Usuario;
            CMD.Parameters.Add(Parametros_SQL.ide, SqlDbType.VarChar).Value = Datos.Vend_ide;

            CMD.Parameters.Add("@RETURN", SqlDbType.Int);
            CMD.Parameters["@RETURN"].Value = DBNull.Value;
            CMD.Parameters["@RETURN"].Direction = ParameterDirection.ReturnValue;

            return VendedorDA.Acceder(CMD);

        }

        public static ENResultOperation Actualizar(ClsVendedorBE Datos)
        {
            SqlCommand CMD = new SqlCommand("PA_VENDEDOR_MODIFICA");
            CMD.Parameters.Add(Parametros_SQL.nombre_error, SqlDbType.VarChar).Value = "";
            CMD.Parameters.Add(Parametros_SQL.codigo, SqlDbType.Int).Value = Datos.Vend_codigo;
            CMD.Parameters.Add(Parametros_SQL.razon_social, SqlDbType.VarChar).Value = Datos.Vend_razon_social;
            CMD.Parameters.Add(Parametros_SQL.empresa,SqlDbType.VarChar).Value = Datos.Vend_empresa;
            CMD.Parameters.Add(Parametros_SQL.paterno,SqlDbType.VarChar).Value = Datos.Vend_paterno;
            CMD.Parameters.Add(Parametros_SQL.materno,SqlDbType.VarChar).Value = Datos.Vend_materno;
            CMD.Parameters.Add(Parametros_SQL.nombre,SqlDbType.VarChar).Value = Datos.Vend_nombre;
            CMD.Parameters.Add(Parametros_SQL.direccion, SqlDbType.VarChar).Value = Datos.Vend_direccion;
            CMD.Parameters.Add(Parametros_SQL.telefono1,SqlDbType.VarChar).Value = Datos.Vend_telefono1;
            CMD.Parameters.Add(Parametros_SQL.telefono2,SqlDbType.VarChar).Value = Datos.Vend_telefono2;
            CMD.Parameters.Add(Parametros_SQL.fax,SqlDbType.VarChar).Value = Datos.Vend_fax;
            CMD.Parameters.Add(Parametros_SQL.fecha,SqlDbType.DateTime).Value = Datos.Vend_fecha_nacimiento;
            CMD.Parameters.Add(Parametros_SQL.tipo_documento,SqlDbType.Int).Value = Datos.Docu_iden_ide;
            CMD.Parameters.Add(Parametros_SQL.documento,SqlDbType.VarChar).Value = Datos.Vend_documento;
            CMD.Parameters.Add(Parametros_SQL.localidad,SqlDbType.Int).Value = Datos.Loca_ide;
            CMD.Parameters.Add(Parametros_SQL.correo,SqlDbType.VarChar).Value = Datos.Vend_correo;
            CMD.Parameters.Add(Parametros_SQL.estado, SqlDbType.VarChar).Value = Datos.Vend_estado;
            CMD.Parameters.Add(Parametros_SQL.inactiva, SqlDbType.DateTime).Value = Datos.Vend_fechainac;
            CMD.Parameters.Add(Parametros_SQL.veces, SqlDbType.Int).Value = Datos.Veces;
            CMD.Parameters.Add(Parametros_SQL.usuario, SqlDbType.VarChar).Value = Datos.Usuario;
            CMD.Parameters.Add(Parametros_SQL.ide, SqlDbType.VarChar).Value = Datos.Vend_ide;   

            CMD.Parameters.Add("@RETURN", SqlDbType.Int);
            CMD.Parameters["@RETURN"].Value = DBNull.Value;
            CMD.Parameters["@RETURN"].Direction = ParameterDirection.ReturnValue;

            return VendedorDA.Acceder(CMD);

        }

        public static ENResultOperation Eliminar(ClsVendedorBE Datos)
        {
            SqlCommand CMD = new SqlCommand("PA_VENDEDOR_ELIMINA");
            CMD.Parameters.Add(Parametros_SQL.nombre_error, SqlDbType.VarChar).Value = DBNull.Value;
            CMD.Parameters.Add(Parametros_SQL.ide, SqlDbType.Int).Value = Datos.Vend_ide;
            CMD.Parameters.Add(Parametros_SQL.veces, SqlDbType.Int).Value = Datos.Veces;
            CMD.Parameters.Add(Parametros_SQL.usuario, SqlDbType.VarChar).Value = Datos.Usuario;

            CMD.Parameters.Add("@RETURN", SqlDbType.Int);
            CMD.Parameters["@RETURN"].Value = DBNull.Value;
            CMD.Parameters["@RETURN"].Direction = ParameterDirection.ReturnValue;


            return VendedorDA.Acceder(CMD);
        }

        public static ENResultOperation Listar(string Texto_Buscar)
        {
            SqlCommand CMD = new SqlCommand("SELECT * FROM VENDEDOR WHERE VEND_ESTADO = 'Activo' AND VEND_RAZON_SOCIAL LIKE '" +
                  Texto_Buscar + "%'");
            return VendedorDA.Procesar_SQL(CMD);
         
        }

        public static ENResultOperation Listar_Filtro(string Texto_Buscar)
        {
            SqlCommand CMD = new SqlCommand("PA_VENDEDOR_LISTAR_FILTRO");
            CMD.Parameters.Add(Parametros_SQL.nombre_error, SqlDbType.VarChar).Value = Texto_Buscar;

            CMD.Parameters.Add("@RETURN", SqlDbType.Int);
            CMD.Parameters["@RETURN"].Value = DBNull.Value;
            CMD.Parameters["@RETURN"].Direction = ParameterDirection.ReturnValue;

            return VendedorDA.Acceder(CMD);
        }
    }
}
