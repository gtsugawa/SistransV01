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
    class Transportista_ContactoDA
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

    public class ClsTransportista_ContactoDA
    {
        public struct Parametros_SQL
        {

            public const string nombre_error = "@NOMBRE_ERROR";//@NOMBRE_ERROR VARCHAR(100) OUTPUT
            public const string ide = "@IDE"; // INT OUTPUT
            public const string ide_detalle = "@IDE_DETALLE"; // INT OUTPUT CHAR(2)
            public const string titulo = "@TITULO"; // VARCHAR(12)
            public const string paterno = "@PATERNO"; // VARCHAR(20)
            public const string materno = "@MATERNO"; // VARCHAR(20)
            public const string nombre = "@NOMBRE"; //VARCHAR(20)
            public const string sexo = "@SEXO"; // VARCHAR(15)
            public const string estadocivil = "@ESTADOCIVIL"; // varchar(12),
            public const string fecha = "@FECHA"; // char(5),
            public const string cargo = "@CARGO"; // 
            public const string tipo_documento = "@TIPO_DOCUMENTO"; // INT,
            public const string documento = "@DOCUMENTO"; // varchar(12),
            public const string direccion = "@DIRECCION"; // varchar(60),
            public const string localidad = "@LOCALIDAD"; // INT,
            public const string telefonocasa = "@TELEFONOCASA"; //varchar(15),
            public const string telefonocelular = "@TELEFONOCELULAR"; // varchar(15),
            public const string fax = "@FAX"; // varchar(15),
            public const string correo = "@CORREO"; // varchar(60),
            public const string nota = "@NOTA";  // varchar(60),
            public const string veces = "@VECES"; // integer
            public const string usuario = "@USUARIO"; // CHAR(15)

        }

        public static ENResultOperation Crear(ClsTransportista_ContactoBE Datos)
        {
            SqlCommand CMD = new SqlCommand("PA_TRANSPORTISTA_INSERTA_CONTACTO");
            CMD.Parameters.Add(Parametros_SQL.nombre_error, SqlDbType.VarChar).Value = "";
            CMD.Parameters.Add(Parametros_SQL.ide, SqlDbType.Int).Value = Datos.Tran_ide;
            CMD.Parameters.Add(Parametros_SQL.ide_detalle, SqlDbType.Int).Value = Datos.Tran_cont_ide;
            CMD.Parameters.Add(Parametros_SQL.titulo, SqlDbType.VarChar).Value = Datos.Tran_cont_titulo;
            CMD.Parameters.Add(Parametros_SQL.paterno, SqlDbType.VarChar).Value = Datos.Tran_cont_paterno;
            CMD.Parameters.Add(Parametros_SQL.materno, SqlDbType.VarChar).Value = Datos.Tran_cont_materno;
            CMD.Parameters.Add(Parametros_SQL.nombre, SqlDbType.VarChar).Value = Datos.Tran_cont_nombre;
            CMD.Parameters.Add(Parametros_SQL.sexo, SqlDbType.VarChar).Value = Datos.Tran_cont_sexo;
            CMD.Parameters.Add(Parametros_SQL.estadocivil, SqlDbType.VarChar).Value = Datos.Tran_cont_estado_civil;
            CMD.Parameters.Add(Parametros_SQL.fecha, SqlDbType.VarChar).Value = Datos.Tran_cont_fecha_nacimiento;
            CMD.Parameters.Add(Parametros_SQL.cargo, SqlDbType.Int).Value = Datos.Carg_ide;
            CMD.Parameters.Add(Parametros_SQL.tipo_documento, SqlDbType.Int).Value = Datos.Docu_iden_ide;
            CMD.Parameters.Add(Parametros_SQL.documento, SqlDbType.VarChar).Value = Datos.Tran_cont_documento;
            CMD.Parameters.Add(Parametros_SQL.direccion, SqlDbType.VarChar).Value = Datos.Tran_cont_direccion;
            CMD.Parameters.Add(Parametros_SQL.localidad, SqlDbType.Int).Value = Datos.Loca_ide;
            CMD.Parameters.Add(Parametros_SQL.telefonocasa, SqlDbType.VarChar).Value = Datos.Tran_cont_telefono_casa;
            CMD.Parameters.Add(Parametros_SQL.telefonocelular, SqlDbType.VarChar).Value = Datos.Tran_cont_telefono_celular;
            CMD.Parameters.Add(Parametros_SQL.fax, SqlDbType.VarChar).Value = Datos.Tran_cont_fax;
            CMD.Parameters.Add(Parametros_SQL.correo, SqlDbType.VarChar).Value = Datos.Tran_cont_correo;
            CMD.Parameters.Add(Parametros_SQL.nota, SqlDbType.VarChar).Value = Datos.Tran_cont_nota;
            CMD.Parameters.Add(Parametros_SQL.veces, SqlDbType.Int).Value = Datos.Veces;
            CMD.Parameters.Add(Parametros_SQL.usuario, SqlDbType.VarChar).Value = "User01";

            CMD.Parameters.Add("@RETURN", SqlDbType.Int);
            CMD.Parameters["@RETURN"].Value = DBNull.Value;
            CMD.Parameters["@RETURN"].Direction = ParameterDirection.ReturnValue;
            return Transportista_ContactoDA.Acceder(CMD);
        }

        public static ENResultOperation Actualizar(ClsTransportista_ContactoBE Datos)
        {
            SqlCommand CMD = new SqlCommand("PA_TRANSPORTISTA_MODIFICA_CONTACTO");
            CMD.Parameters.Add(Parametros_SQL.nombre_error, SqlDbType.VarChar).Value = "";
            CMD.Parameters.Add(Parametros_SQL.ide, SqlDbType.Int).Value = Datos.Tran_ide;
            CMD.Parameters.Add(Parametros_SQL.ide_detalle, SqlDbType.Int).Value = Datos.Tran_cont_ide;
            CMD.Parameters.Add(Parametros_SQL.titulo, SqlDbType.VarChar).Value = Datos.Tran_cont_titulo;
            CMD.Parameters.Add(Parametros_SQL.paterno, SqlDbType.VarChar).Value = Datos.Tran_cont_paterno;
            CMD.Parameters.Add(Parametros_SQL.materno, SqlDbType.VarChar).Value = Datos.Tran_cont_materno;
            CMD.Parameters.Add(Parametros_SQL.nombre, SqlDbType.VarChar).Value = Datos.Tran_cont_nombre;
            CMD.Parameters.Add(Parametros_SQL.sexo, SqlDbType.VarChar).Value = Datos.Tran_cont_sexo;
            CMD.Parameters.Add(Parametros_SQL.estadocivil, SqlDbType.VarChar).Value = Datos.Tran_cont_estado_civil;
            CMD.Parameters.Add(Parametros_SQL.fecha, SqlDbType.VarChar).Value = Datos.Tran_cont_fecha_nacimiento;
            CMD.Parameters.Add(Parametros_SQL.cargo, SqlDbType.Int).Value = Datos.Carg_ide;
            CMD.Parameters.Add(Parametros_SQL.tipo_documento, SqlDbType.Int).Value = Datos.Docu_iden_ide;
            CMD.Parameters.Add(Parametros_SQL.documento, SqlDbType.VarChar).Value = Datos.Tran_cont_documento;
            CMD.Parameters.Add(Parametros_SQL.direccion, SqlDbType.VarChar).Value = Datos.Tran_cont_direccion;
            CMD.Parameters.Add(Parametros_SQL.localidad, SqlDbType.Int).Value = Datos.Loca_ide;
            CMD.Parameters.Add(Parametros_SQL.telefonocasa, SqlDbType.VarChar).Value = Datos.Tran_cont_telefono_casa;
            CMD.Parameters.Add(Parametros_SQL.telefonocelular, SqlDbType.VarChar).Value = Datos.Tran_cont_telefono_celular;
            CMD.Parameters.Add(Parametros_SQL.fax, SqlDbType.VarChar).Value = Datos.Tran_cont_fax;
            CMD.Parameters.Add(Parametros_SQL.correo, SqlDbType.VarChar).Value = Datos.Tran_cont_correo;
            CMD.Parameters.Add(Parametros_SQL.nota, SqlDbType.VarChar).Value = Datos.Tran_cont_nota;
            CMD.Parameters.Add(Parametros_SQL.veces, SqlDbType.Int).Value = Datos.Veces;
            CMD.Parameters.Add(Parametros_SQL.usuario, SqlDbType.VarChar).Value = "User01";

            CMD.Parameters.Add("@RETURN", SqlDbType.Int);
            CMD.Parameters["@RETURN"].Value = DBNull.Value;
            CMD.Parameters["@RETURN"].Direction = ParameterDirection.ReturnValue;
            return Transportista_ContactoDA.Acceder(CMD);

        }

        public static ENResultOperation Eliminar(ClsTransportista_ContactoBE Datos)
        {
            SqlCommand CMD = new SqlCommand("PA_TRANSPORTISTA_ELIMINA_CONTACTO");
            CMD.Parameters.Add(Parametros_SQL.nombre_error, SqlDbType.VarChar).Value = DBNull.Value;
            CMD.Parameters.Add(Parametros_SQL.ide, SqlDbType.Int).Value = Datos.Tran_cont_ide;
            CMD.Parameters.Add(Parametros_SQL.veces, SqlDbType.Int).Value = Datos.Veces;
            CMD.Parameters.Add(Parametros_SQL.usuario, SqlDbType.VarChar).Value = "User01";

            CMD.Parameters.Add("@RETURN", SqlDbType.Int);
            CMD.Parameters["@RETURN"].Value = DBNull.Value;
            CMD.Parameters["@RETURN"].Direction = ParameterDirection.ReturnValue;
            return Transportista_ContactoDA.Acceder(CMD);
        }

        public static ENResultOperation Listar(Int32 Tran_Ide)
        {
            SqlCommand CMD = new SqlCommand("SELECT * FROM  VW_TRANSPORTISTA_CONTACTO WHERE TRAN_IDE = @IDE ORDER BY TRAN_CONT_PATERNO");
            CMD.Parameters.AddWithValue("@IDE", Tran_Ide);
            return ProcesarSQLDA.Procesar_SQL(CMD);

            /*
            SqlCommand CMD = new SqlCommand("PA_TRANSPORTISTA_CONTACTO_LISTAR");
            CMD.Parameters.Add(Parametros_SQL.nombre_error, SqlDbType.VarChar).Value = DBNull.Value;
            CMD.Parameters.Add(Parametros_SQL.ide, SqlDbType.Int).Value = Tran_Ide;

            CMD.Parameters.Add("@RETURN", SqlDbType.Int);
            CMD.Parameters["@RETURN"].Value = DBNull.Value;
            CMD.Parameters["@RETURN"].Direction = ParameterDirection.ReturnValue;
            return Transportista_ContactoDA.Acceder(CMD);
            */
        }

        public static ENResultOperation Listar_Filtro(string Texto_Buscar, Int32 Transportista_Ide)
        {
            SqlCommand CMD = new SqlCommand("SELECT * FROM  VW_TRANSPORTISTA_CONTACTO WHERE TRAN_IDE = " +
                      Transportista_Ide.ToString() + " AND TRAN_CONT_PATERNO LIKE '" + Texto_Buscar + "%' ORDER BY TRAN_CONT_PATERNO");
            return ProcesarSQLDA.Procesar_SQL(CMD);
        }
        public static ENResultOperation Buscar_Por_Documento(string NroDoc, Int32 Transportista_Ide)
        {
            SqlCommand CMD = new SqlCommand("SELECT * FROM  VW_TRANSPORTISTA_CONTACTO WHERE TRAN_IDE = @IDE AND TRAN_CONT_DOCUMENTO = @NRODOC");

            CMD.Parameters.AddWithValue("@NRODOC", NroDoc);
            CMD.Parameters.AddWithValue("@IDE", Transportista_Ide);
            return ProcesarSQLDA.Procesar_SQL(CMD);
        }

    }
}
