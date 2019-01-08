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
    class Maestro_PersonalDA
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
    public class ClsMaestro_PersonalDA
    {
        public struct Parametros_SQL
        {

            public const string nombre_error = "@NOMBRE_ERROR";//@NOMBRE_ERROR VARCHAR(100) OUTPUT
            public const string ide = "@IDE";
            public const string userid = "@USERID";
            public const string codigo = "@CODIGO";
            public const string apellido_paterno = "@PATERNO";
            public const string apellido_materno = "@MATERNO";
            public const string nombres = "@NOMBRES";
            public const string carg_ide = "@CARG_IDE";
            public const string docu_iden_ide = "@DOCU_IDE";
            public const string documento = "@DOCUMENTO";
            public const string direccion = "@DIRECCION";
            public const string loca_ide = "@LOCA_IDE";
            public const string telefono_casa = "@TELEFONO_CASA";
            public const string telefono_celular = "@TELEFONO_CELULAR";
            public const string fecha_nacimiento = "@FECNAC";
            public const string fecha_ingreso = "@FECING";
            public const string fecha_cese = "@FECCESE";
            public const string sexo = "@SEXO";
            public const string estado_civil = "@ESTADO_CIVIL";
            public const string correo = "@CORREO";
            public const string nota = "@NOTA";
            public const string estado = "@ESTADO";
            public const string creacion = "@CREACION";
            public const string modificado = "@MODIFICADO";
            public const string usuario = "@USUARIO";
        }

        public static ENResultOperation Crear(ClsMaestro_PersonalBE Datos)
        {
            SqlCommand CMD = new SqlCommand("PA_MAESTRO_PERSONAL_INSERTA");
            CMD.Parameters.Add(Parametros_SQL.nombre_error, SqlDbType.VarChar).Value = "";
            CMD.Parameters.Add(Parametros_SQL.ide, SqlDbType.Int).Value = Datos.Pers_ide;
            CMD.Parameters.Add(Parametros_SQL.userid, SqlDbType.Int).Value = Datos.Userid;
            CMD.Parameters.Add(Parametros_SQL.codigo, SqlDbType.VarChar).Value = Datos.Pers_codigo;
            CMD.Parameters.Add(Parametros_SQL.apellido_paterno, SqlDbType.VarChar).Value = Datos.Pers_apellido_paterno;
            CMD.Parameters.Add(Parametros_SQL.apellido_materno, SqlDbType.VarChar).Value = Datos.Pers_apellido_materno;
            CMD.Parameters.Add(Parametros_SQL.nombres, SqlDbType.VarChar).Value = Datos.Pers_nombres;
            CMD.Parameters.Add(Parametros_SQL.carg_ide, SqlDbType.Int).Value = Datos.Carg_ide;
            CMD.Parameters.Add(Parametros_SQL.docu_iden_ide, SqlDbType.Int).Value = Datos.Docu_iden_ide;
            CMD.Parameters.Add(Parametros_SQL.documento, SqlDbType.VarChar).Value = Datos.Pers_documento;
            CMD.Parameters.Add(Parametros_SQL.direccion, SqlDbType.VarChar).Value = Datos.Pers_direccion;
            CMD.Parameters.Add(Parametros_SQL.loca_ide, SqlDbType.Int).Value = Datos.Loca_ide;
            CMD.Parameters.Add(Parametros_SQL.telefono_casa, SqlDbType.VarChar).Value = Datos.Pers_telefono_casa;
            CMD.Parameters.Add(Parametros_SQL.telefono_celular, SqlDbType.VarChar).Value = Datos.Pers_telefono_celular;
            CMD.Parameters.Add(Parametros_SQL.fecha_nacimiento, SqlDbType.DateTime).Value = Datos.Pers_fecha_nacimiento;
            CMD.Parameters.Add(Parametros_SQL.fecha_ingreso, SqlDbType.DateTime).Value = Datos.Pers_fecha_ingreso;
            CMD.Parameters.Add(Parametros_SQL.fecha_cese, SqlDbType.DateTime).Value = Datos.Pers_fecha_cese;
            CMD.Parameters.Add(Parametros_SQL.sexo, SqlDbType.VarChar).Value = Datos.Pers_sexo;
            CMD.Parameters.Add(Parametros_SQL.estado_civil, SqlDbType.VarChar).Value = Datos.Pers_estado_civil;
            CMD.Parameters.Add(Parametros_SQL.correo, SqlDbType.VarChar).Value = Datos.Pers_correo;
            CMD.Parameters.Add(Parametros_SQL.nota, SqlDbType.NVarChar).Value = Datos.Pers_nota;
            CMD.Parameters.Add(Parametros_SQL.estado, SqlDbType.Int).Value = Datos.Pers_estado;
            CMD.Parameters.Add(Parametros_SQL.usuario, SqlDbType.VarChar).Value = Datos.Usuario;

            CMD.Parameters.Add("@RETURN", SqlDbType.Int);
            CMD.Parameters["@RETURN"].Value = DBNull.Value;
            CMD.Parameters["@RETURN"].Direction = ParameterDirection.ReturnValue;
            return Maestro_PersonalDA.Acceder(CMD);
        }

        public static ENResultOperation Actualizar(ClsMaestro_PersonalBE Datos)
        {
            SqlCommand CMD = new SqlCommand("PA_MAESTRO_PERSONAL_MODIFICA");
            CMD.Parameters.Add(Parametros_SQL.nombre_error, SqlDbType.VarChar).Value = "";
            CMD.Parameters.Add(Parametros_SQL.ide, SqlDbType.Int).Value = Datos.Pers_ide;
            CMD.Parameters.Add(Parametros_SQL.userid, SqlDbType.Int).Value = Datos.Userid;
            CMD.Parameters.Add(Parametros_SQL.codigo, SqlDbType.VarChar).Value = Datos.Pers_codigo;
            CMD.Parameters.Add(Parametros_SQL.apellido_paterno, SqlDbType.VarChar).Value = Datos.Pers_apellido_paterno;
            CMD.Parameters.Add(Parametros_SQL.apellido_materno, SqlDbType.VarChar).Value = Datos.Pers_apellido_materno;
            CMD.Parameters.Add(Parametros_SQL.nombres, SqlDbType.VarChar).Value = Datos.Pers_nombres;
            CMD.Parameters.Add(Parametros_SQL.carg_ide, SqlDbType.Int).Value = Datos.Carg_ide;
            CMD.Parameters.Add(Parametros_SQL.docu_iden_ide, SqlDbType.Int).Value = Datos.Docu_iden_ide;
            CMD.Parameters.Add(Parametros_SQL.documento, SqlDbType.VarChar).Value = Datos.Pers_documento;
            CMD.Parameters.Add(Parametros_SQL.direccion, SqlDbType.VarChar).Value = Datos.Pers_direccion;
            CMD.Parameters.Add(Parametros_SQL.loca_ide, SqlDbType.Int).Value = Datos.Loca_ide;
            CMD.Parameters.Add(Parametros_SQL.telefono_casa, SqlDbType.VarChar).Value = Datos.Pers_telefono_casa;
            CMD.Parameters.Add(Parametros_SQL.telefono_celular, SqlDbType.VarChar).Value = Datos.Pers_telefono_celular;
            CMD.Parameters.Add(Parametros_SQL.fecha_nacimiento, SqlDbType.DateTime).Value = Datos.Pers_fecha_nacimiento;
            CMD.Parameters.Add(Parametros_SQL.fecha_ingreso, SqlDbType.DateTime).Value = Datos.Pers_fecha_ingreso;
            CMD.Parameters.Add(Parametros_SQL.fecha_cese, SqlDbType.DateTime).Value = Datos.Pers_fecha_cese;
            CMD.Parameters.Add(Parametros_SQL.sexo, SqlDbType.VarChar).Value = Datos.Pers_sexo;
            CMD.Parameters.Add(Parametros_SQL.estado_civil, SqlDbType.VarChar).Value = Datos.Pers_estado_civil;
            CMD.Parameters.Add(Parametros_SQL.correo, SqlDbType.VarChar).Value = Datos.Pers_correo;
            CMD.Parameters.Add(Parametros_SQL.nota, SqlDbType.NVarChar).Value = Datos.Pers_nota;
            CMD.Parameters.Add(Parametros_SQL.estado, SqlDbType.Int).Value = Datos.Pers_estado;
            CMD.Parameters.Add(Parametros_SQL.usuario, SqlDbType.VarChar).Value = Datos.Usuario;

            CMD.Parameters.Add("@RETURN", SqlDbType.Int);
            CMD.Parameters["@RETURN"].Value = DBNull.Value;
            CMD.Parameters["@RETURN"].Direction = ParameterDirection.ReturnValue;
            return Maestro_PersonalDA.Acceder(CMD);

        }

        public static ENResultOperation Eliminar(ClsMaestro_PersonalBE Datos)
        {
            SqlCommand CMD = new SqlCommand("PA_MAESTRO_PERSONAL_ELIMINA");
            CMD.Parameters.Add(Parametros_SQL.nombre_error, SqlDbType.VarChar).Value = DBNull.Value;
            CMD.Parameters.Add(Parametros_SQL.ide, SqlDbType.Int).Value = Datos.Pers_ide;

            CMD.Parameters.Add("@RETURN", SqlDbType.Int);
            CMD.Parameters["@RETURN"].Value = DBNull.Value;
            CMD.Parameters["@RETURN"].Direction = ParameterDirection.ReturnValue;
            return Maestro_PersonalDA.Acceder(CMD);
        }

        public static ENResultOperation Listar(string Texto_Buscar)
        {
            SqlCommand CMD = new SqlCommand("SELECT * FROM  V_MAESTRO_PERSONAL WHERE PERS_APELLIDO_PATERNO LIKE '%' + @TEXTO + '%' ORDER BY PERS_APELLIDO_PATERNO");
            CMD.Parameters.AddWithValue("@TEXTO", Texto_Buscar);
            return ProcesarSQLDA.Procesar_SQL(CMD);

        }

        public static ENResultOperation Listar_Filtro(string Texto_Buscar, Int32 Pers_Ide)
        {
            SqlCommand CMD = new SqlCommand("SELECT * FROM  V_MAESTRO_PERSONAL WHERE PERS_IDE = @IDE AND PERS_APELLIDO_PATERNO LIKE '%' + @TEXTO + '%' ORDER BY PERS_APELLIDO_PATERNO");

            CMD.Parameters.AddWithValue("@TEXTO", Texto_Buscar);
            CMD.Parameters.AddWithValue("@IDE", Pers_Ide);
            return ProcesarSQLDA.Procesar_SQL(CMD);
        }
        public static ENResultOperation Buscar_Filtro(string ApPaterno,string ApMaterno)
        {
            SqlCommand CMD = new SqlCommand("SELECT * FROM  V_MAESTRO_PERSONAL WHERE PERS_APELLIDO_PATERNO LIKE '%' + @PATERNO + '%' AND PERS_APELLIDO_MATERNO LIKE '%' + @MATERNO + '%' ORDER BY PERS_APELLIDO_PATERNO");

            CMD.Parameters.AddWithValue("@PATERNO", ApPaterno);
            CMD.Parameters.AddWithValue("@MATERNO", ApMaterno);
            return ProcesarSQLDA.Procesar_SQL(CMD);
        }
        public static ENResultOperation Existe_Personal_Documento(string Documento)
        {
            SqlCommand CMD = new SqlCommand("SELECT * FROM  V_MAESTRO_PERSONAL WHERE PERS_DOCUMENTO = @DOCUMENTO");

            CMD.Parameters.AddWithValue("@DOCUMENTO", Documento);
            return ProcesarSQLDA.Procesar_SQL(CMD);
        }
        public static ENResultOperation Obtener_Registro(Int32 Pers_Ide)
        {
            SqlCommand CMD = new SqlCommand("SELECT * FROM  V_MAESTRO_PERSONAL WHERE PERS_IDE = @IDE");
            CMD.Parameters.AddWithValue("@IDE", Pers_Ide);
            return ProcesarSQLDA.Procesar_SQL(CMD);

        }

    }
}
