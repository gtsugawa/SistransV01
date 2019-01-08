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
    class Transportista_ChoferDA
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

    }

    public class ClsTransportista_ChoferDA
    {
        public struct Parametros_SQL
        {

            public const string nombre_error = "@NOMBRE_ERROR";//@NOMBRE_ERROR VARCHAR(100) OUTPUT
            public const string ide = "@IDE"; // INT OUTPUT
            public const string ide_detalle = "@IDE_DETALLE"; // INT OUTPUT CHAR(2)
            public const string titulo = "@TITULO"; // VARCHAR(12)
            public const string paterno = "@PATERNO"; // VARCHAR(20)
            public const string materno = "@MATERNO"; // VARCHAR(20)
            public const string nombre = "@CHOFER"; //VARCHAR(20)
            public const string sexo = "@SEXO"; // VARCHAR(15)
            public const string estadocivil =  "@ESTADOCIVIL"; // varchar(12),
            public const string fecha = "@FECHA"; // char(5),
            public const string fecha_ingreso = "@FECHA_ingreso"; // datetime,
            public const string licencia = "@LICENCIA"; // VARCHAR(15),
            public const string tipo_documento = "@TIPO_DOCUMENTO"; // INT,
            public const string documento = "@DOCUMENTO"; // varchar(12),
            public const string direccion = "@DIRECCION"; // varchar(60),
            public const string localidad = "@LOCALIDAD"; // INT,
            public const string telefonocasa = "@TELEFONOCASA"; //varchar(15),
            public const string telefonocelular = "@TELEFONOCELULAR"; // varchar(15),
            public const string fax = "@FAX"; // varchar(15),
            public const string correo = "@CORREO"; // varchar(60),
            public const string nota = "@NOTA";  // varchar(60),
            public const string vehiculo = "@VEHICULO";  // varchar(60),
            public const string placa = "@PLACA";  // varchar(60),
            public const string certificado = "@CERTIFICADO";  // varchar(60),
            public const string nombre1 = "@NOMBRE";  // varchar(60),

            public const string veces = "@VECES"; // integer
            public const string usuario = "@USUARIO"; // CHAR(15)
            
        }

        public static ENResultOperation Crear(ClsTransportista_ChoferBE Datos)
        {
            SqlCommand CMD = new SqlCommand("PA_TRANSPORTISTA_INSERTA_CHOFER");
            CMD.Parameters.Add(Parametros_SQL.nombre_error, SqlDbType.VarChar).Value = "";
            CMD.Parameters.Add(Parametros_SQL.ide, SqlDbType.Int).Value = Datos.Tran_ide;
            CMD.Parameters.Add(Parametros_SQL.ide_detalle, SqlDbType.Int).Value = Datos.Tran_chof_ide;
            CMD.Parameters.Add(Parametros_SQL.nombre, SqlDbType.VarChar).Value = Datos.Tran_chof_nombre;
            CMD.Parameters.Add(Parametros_SQL.licencia, SqlDbType.VarChar).Value = Datos.Tran_chof_licencia;
            CMD.Parameters.Add(Parametros_SQL.vehiculo, SqlDbType.VarChar).Value = Datos.Tran_chof_vehiculo;
            CMD.Parameters.Add(Parametros_SQL.placa, SqlDbType.VarChar).Value = Datos.Tran_chof_placa;
            CMD.Parameters.Add(Parametros_SQL.certificado, SqlDbType.VarChar).Value = Datos.Tran_chof_certificado;

            CMD.Parameters.Add(Parametros_SQL.veces, SqlDbType.Int).Value = Datos.Veces;
            CMD.Parameters.Add(Parametros_SQL.usuario, SqlDbType.VarChar).Value = "User01";

            CMD.Parameters.Add("@RETURN", SqlDbType.Int);
            CMD.Parameters["@RETURN"].Value = DBNull.Value;
            CMD.Parameters["@RETURN"].Direction = ParameterDirection.ReturnValue;
            return Transportista_ChoferDA.Acceder(CMD);
        }

        public static ENResultOperation Actualizar(ClsTransportista_ChoferBE Datos)
        {
            SqlCommand CMD = new SqlCommand("PA_TRANSPORTISTA_MODIFICA_CHOFER");
            CMD.Parameters.Add(Parametros_SQL.nombre_error, SqlDbType.VarChar).Value = "";
            CMD.Parameters.Add(Parametros_SQL.ide, SqlDbType.Int).Value = Datos.Tran_ide;
            CMD.Parameters.Add(Parametros_SQL.ide_detalle, SqlDbType.Int).Value = Datos.Tran_chof_ide;
            CMD.Parameters.Add(Parametros_SQL.nombre, SqlDbType.VarChar).Value = Datos.Tran_chof_nombre;
            CMD.Parameters.Add(Parametros_SQL.licencia, SqlDbType.VarChar).Value = Datos.Tran_chof_licencia;
            CMD.Parameters.Add(Parametros_SQL.vehiculo, SqlDbType.VarChar).Value = Datos.Tran_chof_vehiculo;
            CMD.Parameters.Add(Parametros_SQL.placa, SqlDbType.VarChar).Value = Datos.Tran_chof_placa;
            CMD.Parameters.Add(Parametros_SQL.certificado, SqlDbType.VarChar).Value = Datos.Tran_chof_certificado;

            CMD.Parameters.Add(Parametros_SQL.veces, SqlDbType.Int).Value = Datos.Veces;
            CMD.Parameters.Add(Parametros_SQL.usuario, SqlDbType.VarChar).Value = "User01";
 
            CMD.Parameters.Add("@RETURN", SqlDbType.Int);
            CMD.Parameters["@RETURN"].Value = DBNull.Value;
            CMD.Parameters["@RETURN"].Direction = ParameterDirection.ReturnValue;
            return Transportista_ChoferDA.Acceder(CMD);

        }

        public static ENResultOperation Eliminar(ClsTransportista_ChoferBE Datos)
        {
            SqlCommand CMD = new SqlCommand("PA_TRANSPORTISTA_ELIMINA_CHOFER");
            CMD.Parameters.Add(Parametros_SQL.nombre_error, SqlDbType.VarChar).Value = DBNull.Value;
            CMD.Parameters.Add(Parametros_SQL.ide, SqlDbType.Int).Value = Datos.Tran_chof_ide;
            CMD.Parameters.Add(Parametros_SQL.veces, SqlDbType.Int).Value = Datos.Veces;
            CMD.Parameters.Add(Parametros_SQL.usuario, SqlDbType.VarChar).Value = "User01";

            CMD.Parameters.Add("@RETURN", SqlDbType.Int);
            CMD.Parameters["@RETURN"].Value = DBNull.Value;
            CMD.Parameters["@RETURN"].Direction = ParameterDirection.ReturnValue;
            return Transportista_ChoferDA.Acceder(CMD);
        }

        public static ENResultOperation Listar(string Texto_Buscar)
        {
            SqlCommand CMD = new SqlCommand("PA_TRANSPORTISTA_LISTAR_CHOFER");
            CMD.Parameters.Add(Parametros_SQL.nombre_error, SqlDbType.VarChar).Value = Texto_Buscar;

            CMD.Parameters.Add("@RETURN", SqlDbType.Int);
            CMD.Parameters["@RETURN"].Value = DBNull.Value;
            CMD.Parameters["@RETURN"].Direction = ParameterDirection.ReturnValue;
            return Transportista_ChoferDA.Acceder(CMD);
        }

        public static ENResultOperation Listar_Filtro(string Texto_Buscar, Int32 Transportista_Ide)
        {
            SqlCommand CMD = new SqlCommand("SELECT * FROM  TRANSPORTISTA_CHOFER WHERE TRAN_IDE = " +
                              Transportista_Ide.ToString() + " AND TRAN_CHOF_NOMBRE LIKE '" +Texto_Buscar + "%' ORDER BY TRAN_CHOF_NOMBRE");
            return ProcesarSQLDA.Procesar_SQL(CMD);

            /*
            SqlCommand CMD = new SqlCommand("PA_TRANSPORTISTA_LISTAR_FILTRO_CHOFER");
            CMD.Parameters.Add(Parametros_SQL.nombre_error, SqlDbType.VarChar).Value = DBNull.Value;
            CMD.Parameters.Add(Parametros_SQL.ide, SqlDbType.VarChar).Value = Transportista_Ide;

            CMD.Parameters.Add("@RETURN", SqlDbType.Int);
            CMD.Parameters["@RETURN"].Value = DBNull.Value;
            CMD.Parameters["@RETURN"].Direction = ParameterDirection.ReturnValue;
            return Transportista_ChoferDA.Acceder(CMD);
            */
        }

        public static ENResultOperation Consultar_Ide(Int32 Transportista_Ide, Int32 Chofer_Ide)
        {
            SqlCommand CMD = new SqlCommand("PA_TRANSPORTISTA_CHOFER_CONSULTAR_IDE");
            CMD.Parameters.Add(Parametros_SQL.nombre_error, SqlDbType.VarChar).Value = DBNull.Value;
            CMD.Parameters.Add(Parametros_SQL.ide, SqlDbType.VarChar).Value = Transportista_Ide;
            CMD.Parameters.Add(Parametros_SQL.ide_detalle, SqlDbType.Int).Value = Chofer_Ide;

            CMD.Parameters.Add("@RETURN", SqlDbType.Int);
            CMD.Parameters["@RETURN"].Value = DBNull.Value;
            CMD.Parameters["@RETURN"].Direction = ParameterDirection.ReturnValue;
            return Transportista_ChoferDA.Acceder(CMD);
        }
    }
}
