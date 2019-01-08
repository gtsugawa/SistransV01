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
    class ProveedorDA
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

    public class ClsProveedorDA
    {
        public struct Parametros_SQL
        {
            public const string nombre_error = "@NOMBRE_ERROR";//@NOMBRE_ERROR VARCHAR(100) OUTPUT
            public const string empresa = "@EMPRESA"; // CHAR(2)
            public const string codigo = "@CODIGO"; // VARCHAR(12)
            public const string detraccion = "@DETRACCION"; // VARCHAR(2)
            public const string relacionada = "@RELACIONADA"; // VARCHAR(2)
            public const string tipo_documento = "@TIPO_DOCUMENTO"; // VARCHAR(2)
            public const string razon_social = "@RAZON_SOCIAL"; // VARCHAR(60)
            public const string paterno = "@PATERNO"; // VARCHAR(20)
            public const string materno = "@MATERNO"; // VARCHAR(20)
            public const string nombre = "@NOMBRE"; //VARCHAR(20)
            public const string ruc = "@RUC"; // VARCHAR(15)
            public const string telefono1 = "@TELEFONO1"; // VARCHAR(15)
            public const string telefono2 = "@TELEFONO2"; // VARCHAR(15)
            public const string fax = "@FAX"; // VARCHAR(15)
            public const string fecha = "@FECHA"; // datetime
            public const string tipo = "@TIPO"; // INT
            public const string actividad = "@ACTIVIDAD"; // INT
            public const string categoria = "@CATEGORIA"; // INT
            public const string direccion = "@DIRECCION"; // VARCHAR(60)
            public const string localidad = "@LOCALIDAD"; // INT
            public const string correo = "@CORREO"; // VARCHAR(60)
            public const string gasto = "@GASTO"; // VARCHAR(60)
            public const string estado = "@ESTADO"; // varchar(8)
            public const string inactiva = "@INACTIVA"; // datetime,
            public const string veces = "@VECES"; // integer
            public const string usuario = "@USUARIO"; // CHAR(15)
            public const string ide = "@IDE"; // INT OUTPUT
        }

        public static ENResultOperation Crear(ClsProveedorBE Datos)
        {
            SqlCommand CMD = new SqlCommand("PA_PROVEEDOR_INSERTA");
            CMD.Parameters.Add(Parametros_SQL.nombre_error, SqlDbType.VarChar).Value = "";
            CMD.Parameters.Add(Parametros_SQL.empresa, SqlDbType.Char).Value = Datos.Prov_empresa;
            CMD.Parameters.Add(Parametros_SQL.detraccion, SqlDbType.Char).Value = Datos.Prov_detraccion;
            CMD.Parameters.Add(Parametros_SQL.codigo, SqlDbType.VarChar).Value = Datos.Prov_codigo;
            CMD.Parameters.Add(Parametros_SQL.relacionada, SqlDbType.Char).Value = Datos.Prov_relacionada;
            CMD.Parameters.Add(Parametros_SQL.tipo_documento, SqlDbType.Int).Value = Datos.Docu_iden_ide;
            CMD.Parameters.Add(Parametros_SQL.razon_social, SqlDbType.VarChar).Value = Datos.Prov_razon_social;
            CMD.Parameters.Add(Parametros_SQL.paterno, SqlDbType.VarChar).Value = Datos.Prov_paterno;
            CMD.Parameters.Add(Parametros_SQL.materno, SqlDbType.VarChar).Value = Datos.Prov_materno;
            CMD.Parameters.Add(Parametros_SQL.nombre, SqlDbType.VarChar).Value = Datos.Prov_nombre;
            CMD.Parameters.Add(Parametros_SQL.ruc, SqlDbType.VarChar).Value = Datos.Prov_ruc;
            CMD.Parameters.Add(Parametros_SQL.telefono1, SqlDbType.VarChar).Value = Datos.Prov_telefono1;
            CMD.Parameters.Add(Parametros_SQL.telefono2, SqlDbType.VarChar).Value = Datos.Prov_telefono2;
            CMD.Parameters.Add(Parametros_SQL.fax, SqlDbType.VarChar).Value = Datos.Prov_fax;
            CMD.Parameters.Add(Parametros_SQL.fecha, SqlDbType.DateTime).Value = Datos.Prov_fecha_constitucion;
            CMD.Parameters.Add(Parametros_SQL.tipo, SqlDbType.Int).Value = Datos.Tipo_prov_ide;
            CMD.Parameters.Add(Parametros_SQL.actividad, SqlDbType.Int).Value = Datos.Acti_prov_ide;
            CMD.Parameters.Add(Parametros_SQL.categoria, SqlDbType.Int).Value = Datos.Cate_prov_ide;
            CMD.Parameters.Add(Parametros_SQL.direccion, SqlDbType.VarChar).Value = Datos.Prov_direccion;
            CMD.Parameters.Add(Parametros_SQL.localidad, SqlDbType.Int).Value = Datos.Loca_ide;
            CMD.Parameters.Add(Parametros_SQL.correo, SqlDbType.VarChar).Value = Datos.Prov_correo;
            CMD.Parameters.Add(Parametros_SQL.gasto, SqlDbType.Int).Value = Datos.Pla_cta_ide;
            CMD.Parameters.Add(Parametros_SQL.estado, SqlDbType.VarChar).Value = Datos.Prov_estado;
            CMD.Parameters.Add(Parametros_SQL.inactiva, SqlDbType.DateTime).Value = Datos.Prov_fechainac;
            CMD.Parameters.Add(Parametros_SQL.veces, SqlDbType.Int).Value = Datos.Veces;
            CMD.Parameters.Add(Parametros_SQL.usuario, SqlDbType.VarChar).Value = "User01";
            CMD.Parameters.Add(Parametros_SQL.ide, SqlDbType.Int).Value = Datos.Prov_ide;

            CMD.Parameters.Add("@RETURN", SqlDbType.Int);
            CMD.Parameters["@RETURN"].Value = DBNull.Value;
            CMD.Parameters["@RETURN"].Direction = ParameterDirection.ReturnValue;

            return ProveedorDA.Acceder(CMD);
        }

        public static ENResultOperation Actualizar(ClsProveedorBE Datos)
        {
            SqlCommand CMD = new SqlCommand("PA_PROVEEDOR_MODIFICA");
            CMD.Parameters.Add(Parametros_SQL.nombre_error, SqlDbType.VarChar).Value = DBNull.Value;
            CMD.Parameters.Add(Parametros_SQL.empresa, SqlDbType.Char).Value = Datos.Prov_empresa;
            CMD.Parameters.Add(Parametros_SQL.detraccion, SqlDbType.Char).Value = Datos.Prov_empresa;
            CMD.Parameters.Add(Parametros_SQL.codigo, SqlDbType.VarChar).Value = Datos.Prov_codigo;
            CMD.Parameters.Add(Parametros_SQL.relacionada, SqlDbType.Char).Value = Datos.Prov_relacionada;
            CMD.Parameters.Add(Parametros_SQL.tipo_documento, SqlDbType.Int).Value = Datos.Docu_iden_ide;
            CMD.Parameters.Add(Parametros_SQL.razon_social, SqlDbType.VarChar).Value = Datos.Prov_razon_social;
            CMD.Parameters.Add(Parametros_SQL.paterno, SqlDbType.VarChar).Value = Datos.Prov_paterno;
            CMD.Parameters.Add(Parametros_SQL.materno, SqlDbType.VarChar).Value = Datos.Prov_paterno;
            CMD.Parameters.Add(Parametros_SQL.nombre, SqlDbType.VarChar).Value = Datos.Prov_nombre;
            CMD.Parameters.Add(Parametros_SQL.ruc, SqlDbType.VarChar).Value = Datos.Prov_ruc;
            CMD.Parameters.Add(Parametros_SQL.telefono1, SqlDbType.VarChar).Value = Datos.Prov_telefono1;
            CMD.Parameters.Add(Parametros_SQL.telefono2, SqlDbType.VarChar).Value = Datos.Prov_telefono2;
            CMD.Parameters.Add(Parametros_SQL.fax, SqlDbType.VarChar).Value = Datos.Prov_fax;
            CMD.Parameters.Add(Parametros_SQL.fecha, SqlDbType.DateTime).Value = Datos.Prov_fecha_constitucion;
            CMD.Parameters.Add(Parametros_SQL.tipo, SqlDbType.Int).Value = Datos.Tipo_prov_ide;
            CMD.Parameters.Add(Parametros_SQL.actividad, SqlDbType.Int).Value = Datos.Acti_prov_ide;
            CMD.Parameters.Add(Parametros_SQL.categoria, SqlDbType.Int).Value = Datos.Cate_prov_ide;
            CMD.Parameters.Add(Parametros_SQL.direccion, SqlDbType.VarChar).Value = Datos.Prov_direccion;
            CMD.Parameters.Add(Parametros_SQL.localidad, SqlDbType.Int).Value = Datos.Loca_ide;
            CMD.Parameters.Add(Parametros_SQL.correo, SqlDbType.VarChar).Value = Datos.Prov_correo;
            CMD.Parameters.Add(Parametros_SQL.gasto, SqlDbType.Int).Value = Datos.Pla_cta_ide;
            CMD.Parameters.Add(Parametros_SQL.estado, SqlDbType.VarChar).Value = Datos.Prov_estado;
            CMD.Parameters.Add(Parametros_SQL.inactiva, SqlDbType.DateTime).Value = Datos.Prov_fechainac;
            CMD.Parameters.Add(Parametros_SQL.veces, SqlDbType.Int).Value = Datos.Veces;
            CMD.Parameters.Add(Parametros_SQL.usuario, SqlDbType.VarChar).Value = "User01";
            CMD.Parameters.Add(Parametros_SQL.ide, SqlDbType.Int).Value = Datos.Prov_ide;

            CMD.Parameters.Add("@RETURN", SqlDbType.Int);
            CMD.Parameters["@RETURN"].Value = DBNull.Value;
            CMD.Parameters["@RETURN"].Direction = ParameterDirection.ReturnValue;

            return ProveedorDA.Acceder(CMD);

        }

        public static ENResultOperation Eliminar(ClsProveedorBE Datos)
        {
            SqlCommand CMD = new SqlCommand("PA_PROVEEDOR_ELIMINA");
            CMD.Parameters.Add(Parametros_SQL.nombre_error, SqlDbType.VarChar).Value = DBNull.Value;
            CMD.Parameters.Add(Parametros_SQL.ide, SqlDbType.Int).Value = Datos.Prov_ide;
            CMD.Parameters.Add(Parametros_SQL.veces, SqlDbType.Int).Value = Datos.Veces;
            CMD.Parameters.Add(Parametros_SQL.usuario, SqlDbType.VarChar).Value = "User01";

            CMD.Parameters.Add("@RETURN", SqlDbType.Int);
            CMD.Parameters["@RETURN"].Value = DBNull.Value;
            CMD.Parameters["@RETURN"].Direction = ParameterDirection.ReturnValue;
            return ProveedorDA.Acceder(CMD);
        }
        public static ENResultOperation Obtener_Registro(Int32 Prove_Ide)
        {
            SqlCommand CMD = new SqlCommand("SELECT * FROM PROVEEDOR WHERE PROV_IDE =@IDE");

            CMD.Parameters.AddWithValue("@IDE", Prove_Ide);
            return ProveedorDA.Procesar_SQL(CMD);
        }
        public static ENResultOperation Obtener_Ruc(string NroRuc)
        {
            SqlCommand CMD = new SqlCommand("SELECT * FROM PROVEEDOR WHERE PROV_RUC =@RUC");

            CMD.Parameters.AddWithValue("@RUC",NroRuc );
            return ProveedorDA.Procesar_SQL(CMD);
        }
        public static ENResultOperation Listar(string Texto_Buscar)
        {
            SqlCommand CMD = new SqlCommand("SELECT * FROM PROVEEDOR WHERE PROV_RAZON_SOCIAL + PROV_CODIGO LIKE '%" +
                                  Texto_Buscar + "%'");
            return ProveedorDA.Procesar_SQL(CMD);

            /*
            SqlCommand CMD = new SqlCommand("PA_PROVEEDOR_LISTAR");
            CMD.Parameters.Add(Parametros_SQL.nombre_error, SqlDbType.VarChar).Value = Texto_Buscar;

            CMD.Parameters.Add("@RETURN", SqlDbType.Int);
            CMD.Parameters["@RETURN"].Value = DBNull.Value;
            CMD.Parameters["@RETURN"].Direction = ParameterDirection.ReturnValue;
            return ProveedorDA.Acceder(CMD);
            */
        }

        public static ENResultOperation Listar_Filtro(string Texto_Buscar)
        {
            SqlCommand CMD = new SqlCommand("PA_PROVEEDOR_LISTAR_FILTRO");
            CMD.Parameters.Add(Parametros_SQL.razon_social, SqlDbType.VarChar).Value = Texto_Buscar;

            CMD.Parameters.Add("@RETURN", SqlDbType.Int);
            CMD.Parameters["@RETURN"].Value = DBNull.Value;
            CMD.Parameters["@RETURN"].Direction = ParameterDirection.ReturnValue;
            return ProveedorDA.Acceder(CMD);
        }

    }
}
