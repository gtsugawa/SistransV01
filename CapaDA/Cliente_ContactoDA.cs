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
    class Cliente_ContactoDA
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

    public class ClsCliente_ContactoDA
    {
        public struct Parametros_SQL
        {
            public const string nombre_error = "@NOMBRE_ERROR";
            public const string ide = "@IDE";
            public const string ide_detalle = "@IDE_DETALLE"; // INT OUTPUT,
            public const string titulo = "@TITULO"; // varchar(4),
            public const string paterno = "@PATERNO"; // varchar(20),
            public const string materno = "@MATERNO"; // varchar(20),
            public const string nombre = "@NOMBRE";// varchar(20),
            public const string sexo = "@SEXO"; // varchar(10),
            public const string estadocivil = "@ESTADOCIVIL"; // varchar(12),
            public const string fechanac = "@FECHA"; // char(5),
            public const string cargo = "@CARGO"; //INT,
            public const string tipo_documento = "@TIPO_DOCUMENTO"; // INT,
            public const string documento = "@DOCUMENTO"; // varchar(12),
            public const string direccion = "@DIRECCION"; // varchar(60),
            public const string localidad = "@LOCALIDAD"; // INT,
            public const string telefonocasa = "@TELEFONOCASA"; // varchar(15),
            public const string telefonocelular = "@TELEFONOCELULAR"; // varchar(15),
            public const string fax = "@FAX"; // varchar(15),
            public const string correo = "@CORREO"; // varchar(60),
            public const string nota = "@NOTA"; // varchar(60),
            public const string veces = "@VECES";
            public const string usuario = "@USUARIO";
        }

        public static ENResultOperation Crear(ClsCliente_ContactoBE Datos)
        {
            SqlCommand CMD = new SqlCommand("PA_CLIENTE_INSERTA_CONTACTO");
            CMD.Parameters.Add(Parametros_SQL.nombre_error, SqlDbType.VarChar).Value = "";
            CMD.Parameters.Add(Parametros_SQL.ide, SqlDbType.Int).Value = Datos.Clie_ide;
            CMD.Parameters.Add(Parametros_SQL.ide_detalle, SqlDbType.Int).Value = Datos.Clie_cont_ide;
            CMD.Parameters.Add(Parametros_SQL.titulo, SqlDbType.VarChar).Value = Datos.Clie_cont_titulo;
            CMD.Parameters.Add(Parametros_SQL.paterno, SqlDbType.VarChar).Value = Datos.Clie_cont_paterno;
            CMD.Parameters.Add(Parametros_SQL.materno, SqlDbType.VarChar).Value = Datos.Clie_cont_materno;
            CMD.Parameters.Add(Parametros_SQL.nombre, SqlDbType.VarChar).Value = Datos.Clie_cont_nombre;
            CMD.Parameters.Add(Parametros_SQL.sexo, SqlDbType.VarChar).Value = Datos.Clie_cont_sexo;
            CMD.Parameters.Add(Parametros_SQL.estadocivil, SqlDbType.VarChar).Value = Datos.Clie_cont_estado_civil;
            CMD.Parameters.Add(Parametros_SQL.fechanac, SqlDbType.VarChar).Value = Datos.Clie_cont_fecha_nacimiento;
            CMD.Parameters.Add(Parametros_SQL.cargo, SqlDbType.Int).Value = Datos.Carg_ide;
            CMD.Parameters.Add(Parametros_SQL.tipo_documento, SqlDbType.VarChar).Value = Datos.Docu_iden_ide;
            CMD.Parameters.Add(Parametros_SQL.documento, SqlDbType.VarChar).Value = Datos.Clie_cont_documento;
            CMD.Parameters.Add(Parametros_SQL.direccion, SqlDbType.VarChar).Value = Datos.Clie_cont_direccion;
            CMD.Parameters.Add(Parametros_SQL.localidad, SqlDbType.Int).Value = Datos.Loca_ide;
            CMD.Parameters.Add(Parametros_SQL.telefonocasa, SqlDbType.VarChar).Value = Datos.Clie_cont_telefono_casa;
            CMD.Parameters.Add(Parametros_SQL.telefonocelular, SqlDbType.VarChar).Value = Datos.Clie_cont_telefono_celular;
            CMD.Parameters.Add(Parametros_SQL.fax, SqlDbType.VarChar).Value = Datos.Clie_cont_fax;
            CMD.Parameters.Add(Parametros_SQL.correo, SqlDbType.VarChar).Value = Datos.Clie_cont_correo;
            CMD.Parameters.Add(Parametros_SQL.nota, SqlDbType.VarChar).Value = Datos.Clie_cont_nota;
            CMD.Parameters.Add(Parametros_SQL.veces, SqlDbType.Int).Value = Datos.Veces;
            CMD.Parameters.Add(Parametros_SQL.usuario, SqlDbType.VarChar).Value = Datos.Usuario;

            CMD.Parameters.Add("@RETURN", SqlDbType.Int);
            CMD.Parameters["@RETURN"].Value = DBNull.Value;
            CMD.Parameters["@RETURN"].Direction = ParameterDirection.ReturnValue;

            return Cliente_ContactoDA.Acceder(CMD);

        }

        public static ENResultOperation Actualizar(ClsCliente_ContactoBE Datos)
        {
            SqlCommand CMD = new SqlCommand("PA_CLIENTE_MODIFICA_CONTACTO");
            CMD.Parameters.Add(Parametros_SQL.nombre_error, SqlDbType.VarChar).Value = "";
            CMD.Parameters.Add(Parametros_SQL.ide, SqlDbType.Int).Value = Datos.Clie_ide;
            CMD.Parameters.Add(Parametros_SQL.ide_detalle, SqlDbType.Int).Value = Datos.Clie_cont_ide;
            CMD.Parameters.Add(Parametros_SQL.titulo, SqlDbType.VarChar).Value = Datos.Clie_cont_titulo;
            CMD.Parameters.Add(Parametros_SQL.paterno, SqlDbType.VarChar).Value = Datos.Clie_cont_paterno;
            CMD.Parameters.Add(Parametros_SQL.materno, SqlDbType.VarChar).Value = Datos.Clie_cont_materno;
            CMD.Parameters.Add(Parametros_SQL.nombre, SqlDbType.VarChar).Value = Datos.Clie_cont_nombre;
            CMD.Parameters.Add(Parametros_SQL.sexo, SqlDbType.VarChar).Value = Datos.Clie_cont_sexo;
            CMD.Parameters.Add(Parametros_SQL.estadocivil, SqlDbType.VarChar).Value = Datos.Clie_cont_estado_civil;
            CMD.Parameters.Add(Parametros_SQL.fechanac, SqlDbType.VarChar).Value = Datos.Clie_cont_fecha_nacimiento;
            CMD.Parameters.Add(Parametros_SQL.cargo, SqlDbType.Int).Value = Datos.Carg_ide;
            CMD.Parameters.Add(Parametros_SQL.tipo_documento, SqlDbType.VarChar).Value = Datos.Docu_iden_ide;
            CMD.Parameters.Add(Parametros_SQL.documento, SqlDbType.VarChar).Value = Datos.Clie_cont_documento;
            CMD.Parameters.Add(Parametros_SQL.direccion, SqlDbType.VarChar).Value = Datos.Clie_cont_direccion;
            CMD.Parameters.Add(Parametros_SQL.localidad, SqlDbType.Int).Value = Datos.Loca_ide;
            CMD.Parameters.Add(Parametros_SQL.telefonocasa, SqlDbType.VarChar).Value = Datos.Clie_cont_telefono_casa;
            CMD.Parameters.Add(Parametros_SQL.telefonocelular, SqlDbType.VarChar).Value = Datos.Clie_cont_telefono_celular;
            CMD.Parameters.Add(Parametros_SQL.fax, SqlDbType.VarChar).Value = Datos.Clie_cont_fax;
            CMD.Parameters.Add(Parametros_SQL.correo, SqlDbType.VarChar).Value = Datos.Clie_cont_correo;
            CMD.Parameters.Add(Parametros_SQL.nota, SqlDbType.VarChar).Value = Datos.Clie_cont_nota;
            CMD.Parameters.Add(Parametros_SQL.veces, SqlDbType.Int).Value = Datos.Veces;
            CMD.Parameters.Add(Parametros_SQL.usuario, SqlDbType.VarChar).Value = Datos.Usuario;

            CMD.Parameters.Add("@RETURN", SqlDbType.Int);
            CMD.Parameters["@RETURN"].Value = DBNull.Value;
            CMD.Parameters["@RETURN"].Direction = ParameterDirection.ReturnValue;

            return Cliente_ContactoDA.Acceder(CMD);

        }

        public static ENResultOperation Eliminar(ClsCliente_ContactoBE Datos)
        {
            SqlCommand CMD = new SqlCommand("PA_CLIENTE_ELIMINA_CONTACTO");
            CMD.Parameters.Add(Parametros_SQL.nombre_error, SqlDbType.VarChar).Value = "";
            CMD.Parameters.Add(Parametros_SQL.ide, SqlDbType.Int).Value = Datos.Clie_cont_ide;
            CMD.Parameters.Add(Parametros_SQL.veces, SqlDbType.Int).Value = Datos.Veces;
            CMD.Parameters.Add(Parametros_SQL.usuario, SqlDbType.VarChar).Value = Datos.Usuario;

            CMD.Parameters.Add("@RETURN", SqlDbType.Int);
            CMD.Parameters["@RETURN"].Value = DBNull.Value;
            CMD.Parameters["@RETURN"].Direction = ParameterDirection.ReturnValue;


            return Cliente_ContactoDA.Acceder(CMD);
        }

        public static ENResultOperation Listar(string Texto_Buscar)
        {
            SqlCommand CMD = new SqlCommand("PA_CLIENTE_LISTAR_CONTACTO");
            CMD.Parameters.Add(Parametros_SQL.nombre_error, SqlDbType.VarChar).Value = Texto_Buscar;

            CMD.Parameters.Add("@RETURN", SqlDbType.Int);
            CMD.Parameters["@RETURN"].Value = DBNull.Value;
            CMD.Parameters["@RETURN"].Direction = ParameterDirection.ReturnValue;

            return Cliente_ContactoDA.Acceder(CMD);
        }

        public static ENResultOperation Listar_Filtro(Int32 Clie_Ide)
        {

            SqlCommand CMD = new SqlCommand("SELECT * FROM CLIENTE_CONTACTO WHERE Clie_Ide = " +
                                             Clie_Ide.ToString());

            return Cliente_ContactoDA.Procesar_SQL(CMD);

            /*
            SqlCommand CMD = new SqlCommand("PA_CLIENTE_LISTAR_FILTRO_CONTACTO");
            CMD.Parameters.Add(Parametros_SQL.nombre_error, SqlDbType.VarChar).Value = Texto_Buscar;
            CMD.Parameters.Add(Parametros_SQL.ide, SqlDbType.Int).Value = Clie_Ide;

            CMD.Parameters.Add("@RETURN", SqlDbType.Int);
            CMD.Parameters["@RETURN"].Value = DBNull.Value;
            CMD.Parameters["@RETURN"].Direction = ParameterDirection.ReturnValue;

            return Cliente_ContactoDA.Acceder(CMD);
            */
        }

        public static ENResultOperation Consultar_Ide(Int32 Clie_Ide, Int32 Cont_Ide)
        {
            SqlCommand CMD = new SqlCommand("PA_CLIENTE_CONTACTO_CONSULTAR_IDE");
            CMD.Parameters.Add(Parametros_SQL.nombre_error, SqlDbType.VarChar).Value = DBNull.Value;
            CMD.Parameters.Add(Parametros_SQL.ide, SqlDbType.Int).Value = Clie_Ide;
            CMD.Parameters.Add(Parametros_SQL.ide_detalle, SqlDbType.Int).Value = Cont_Ide;

            CMD.Parameters.Add("@RETURN", SqlDbType.Int);
            CMD.Parameters["@RETURN"].Value = DBNull.Value;
            CMD.Parameters["@RETURN"].Direction = ParameterDirection.ReturnValue;

            return Cliente_ContactoDA.Acceder(CMD);
        }

        public static ENResultOperation Obtener_Registro(Int32 Clie_Ide, Int32 Clie_Cont_Ide)
        {
            SqlCommand CMD = new SqlCommand("SELECT * FROM CLIENTE_CONTACTO WHERE Clie_Ide = " +
                             Clie_Ide.ToString() + " AND Clie_Cont_Ide = " + Clie_Cont_Ide.ToString());

            return Cliente_ContactoDA.Procesar_SQL(CMD);
        }
    }
}

