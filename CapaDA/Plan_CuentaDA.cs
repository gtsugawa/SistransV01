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
    class Plan_CuentaDA
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

    public class ClsPlan_CuentaDA
    {
        public struct Parametros_SQL
        {
            public const string nombre_error = "@NOMBRE_ERROR";
            public const string ide = "@IDE INT";
            public const string codigo = "@CODIGO";
            public const string nombre = "@NOMBRE";
            public const string grupo = "@GRUPO";
            public const string tipo_banco = "@TIPO_BANCO";
            public const string banco = "@BANCO";
            public const string auxiliar = "@AUXILIAR";
            public const string documento = "@DOCUMENTO";
            public const string actividad = "@ACTIVIDAD";
            public const string entidad = "@ENTIDAD";
            public const string cuenta = "@CUENTA";
            public const string tipo = "@TIPO";
            public const string contrapartida = "@CONTRAPARTIDA";
            public const string cierre = "@CIERRE";
            public const string contrapartida_c_c = "@CONTRAPARTIDA_C_C";
            public const string estado = "@ESTADO";
            public const string inactiva = "@INACTIVA";
            public const string veces = "@VECES";
            public const string usuario = "@USUARIO";
            public const string cta_sunat = "@CTA_SUNAT";
        }

        public static ENResultOperation Crear(ClsPlan_CuentaBE Datos)
        {
            SqlCommand CMD = new SqlCommand("PA_PLAN_CUENTA_INSERTA_SUNAT");

            CMD.Parameters.Add(Parametros_SQL.nombre_error, SqlDbType.VarChar).Value = DBNull.Value;
            CMD.Parameters.Add(Parametros_SQL.ide, SqlDbType.Int).Value = Datos.Pla_cta_ide;
            CMD.Parameters.Add(Parametros_SQL.codigo, SqlDbType.VarChar).Value = Datos.Pla_cta_codigo;
            CMD.Parameters.Add(Parametros_SQL.nombre, SqlDbType.VarChar).Value = Datos.Pla_cta_nombre;
            CMD.Parameters.Add(Parametros_SQL.grupo, SqlDbType.VarChar).Value = Datos.Pla_cta_grupo;
            CMD.Parameters.Add(Parametros_SQL.tipo_banco, SqlDbType.VarChar).Value = Datos.Pla_cta_tipo_banco;
            CMD.Parameters.Add(Parametros_SQL.banco, SqlDbType.VarChar).Value = Datos.Pla_cta_banco;
            CMD.Parameters.Add(Parametros_SQL.auxiliar, SqlDbType.VarChar).Value = Datos.Pla_cta_auxiliar;
            CMD.Parameters.Add(Parametros_SQL.documento, SqlDbType.VarChar).Value = Datos.Pla_cta_documento;
            CMD.Parameters.Add(Parametros_SQL.actividad, SqlDbType.Int).Value = Datos.Pla_cta_actividad;
            CMD.Parameters.Add(Parametros_SQL.entidad, SqlDbType.Int).Value = 0;
            CMD.Parameters.Add(Parametros_SQL.cuenta, SqlDbType.VarChar).Value = "";
            CMD.Parameters.Add(Parametros_SQL.tipo, SqlDbType.VarChar).Value = Datos.Pla_cta_tipo;
            CMD.Parameters.Add(Parametros_SQL.contrapartida, SqlDbType.VarChar).Value = Datos.Pla_cta_cta_contrapartida;
            CMD.Parameters.Add(Parametros_SQL.cierre, SqlDbType.VarChar).Value = Datos.Pla_cta_cta_cierre;
            CMD.Parameters.Add(Parametros_SQL.contrapartida_c_c, SqlDbType.VarChar).Value = Datos.Pla_cta_contrapartida;
            CMD.Parameters.Add(Parametros_SQL.estado, SqlDbType.VarChar).Value = Datos.Pla_cta_estado;
            CMD.Parameters.Add(Parametros_SQL.inactiva, SqlDbType.VarChar).Value = Datos.Pla_cta_fechainac;
            CMD.Parameters.Add(Parametros_SQL.veces, SqlDbType.VarChar).Value = Datos.Veces;
            CMD.Parameters.Add(Parametros_SQL.usuario, SqlDbType.VarChar).Value = Datos.Usuario;
            CMD.Parameters.Add(Parametros_SQL.cta_sunat, SqlDbType.VarChar).Value = Datos.Pla_cta_sunat;

            CMD.Parameters.Add("@RETURN", SqlDbType.Int);
            CMD.Parameters["@RETURN"].Value = DBNull.Value;
            CMD.Parameters["@RETURN"].Direction = ParameterDirection.ReturnValue;

            return Plan_CuentaDA.Acceder(CMD);

        }

        public static ENResultOperation Actualizar(ClsPlan_CuentaBE Datos)
        {
            SqlCommand CMD = new SqlCommand("PA_PLAN_CUENTA_MODIFICA_SUNAT");
            CMD.Parameters.Add(Parametros_SQL.nombre_error, SqlDbType.VarChar).Value = DBNull.Value;
            CMD.Parameters.Add(Parametros_SQL.ide, SqlDbType.Int).Value = Datos.Pla_cta_ide;
            CMD.Parameters.Add(Parametros_SQL.codigo, SqlDbType.VarChar).Value = Datos.Pla_cta_codigo;
            CMD.Parameters.Add(Parametros_SQL.nombre, SqlDbType.VarChar).Value = Datos.Pla_cta_nombre;
            CMD.Parameters.Add(Parametros_SQL.grupo, SqlDbType.VarChar).Value = Datos.Pla_cta_grupo;
            CMD.Parameters.Add(Parametros_SQL.tipo_banco, SqlDbType.VarChar).Value = Datos.Pla_cta_tipo_banco;
            CMD.Parameters.Add(Parametros_SQL.banco, SqlDbType.VarChar).Value = Datos.Pla_cta_banco;
            CMD.Parameters.Add(Parametros_SQL.auxiliar, SqlDbType.VarChar).Value = Datos.Pla_cta_auxiliar;
            CMD.Parameters.Add(Parametros_SQL.documento, SqlDbType.VarChar).Value = Datos.Pla_cta_documento;
            CMD.Parameters.Add(Parametros_SQL.actividad, SqlDbType.Int).Value = Datos.Pla_cta_actividad;
            CMD.Parameters.Add(Parametros_SQL.entidad, SqlDbType.Int).Value = 0;
            CMD.Parameters.Add(Parametros_SQL.cuenta, SqlDbType.VarChar).Value = "";
            CMD.Parameters.Add(Parametros_SQL.tipo, SqlDbType.VarChar).Value = Datos.Pla_cta_tipo;
            CMD.Parameters.Add(Parametros_SQL.contrapartida, SqlDbType.VarChar).Value = Datos.Pla_cta_cta_contrapartida;
            CMD.Parameters.Add(Parametros_SQL.cierre, SqlDbType.VarChar).Value = Datos.Pla_cta_cta_cierre;
            CMD.Parameters.Add(Parametros_SQL.contrapartida_c_c, SqlDbType.VarChar).Value = Datos.Pla_cta_contrapartida;
            CMD.Parameters.Add(Parametros_SQL.estado, SqlDbType.VarChar).Value = Datos.Pla_cta_estado;
            CMD.Parameters.Add(Parametros_SQL.inactiva, SqlDbType.VarChar).Value = Datos.Pla_cta_fechainac;
            CMD.Parameters.Add(Parametros_SQL.veces, SqlDbType.VarChar).Value = Datos.Veces;
            CMD.Parameters.Add(Parametros_SQL.usuario, SqlDbType.VarChar).Value = Datos.Usuario;
            CMD.Parameters.Add(Parametros_SQL.cta_sunat, SqlDbType.VarChar).Value = Datos.Pla_cta_sunat;

            CMD.Parameters.Add("@RETURN", SqlDbType.Int);
            CMD.Parameters["@RETURN"].Value = DBNull.Value;
            CMD.Parameters["@RETURN"].Direction = ParameterDirection.ReturnValue;

            return Plan_CuentaDA.Acceder(CMD);

        }

        public static ENResultOperation Eliminar(ClsPlan_CuentaBE Datos)
        {
            SqlCommand CMD = new SqlCommand("PA_PLAN_CUENTA_ELIMINA");
            CMD.Parameters.Add(Parametros_SQL.nombre_error, SqlDbType.VarChar).Value = DBNull.Value;
            CMD.Parameters.Add(Parametros_SQL.ide, SqlDbType.Int).Value = Datos.Pla_cta_ide;
            CMD.Parameters.Add(Parametros_SQL.veces, SqlDbType.Int).Value = Datos.Veces;
            CMD.Parameters.Add(Parametros_SQL.usuario, SqlDbType.VarChar).Value = Datos.Usuario;

            CMD.Parameters.Add("@RETURN", SqlDbType.Int);
            CMD.Parameters["@RETURN"].Value = DBNull.Value;
            CMD.Parameters["@RETURN"].Direction = ParameterDirection.ReturnValue;


            return Plan_CuentaDA.Acceder(CMD);
        }

        public static ENResultOperation Listar(string Texto_Buscar)
        {
            SqlCommand CMD = new SqlCommand("SELECT PLA_CTA_IDE,(PLA_CTA_CODIGO + ' ' + PLA_CTA_NOMBRE) AS PLA_NOMBRE  FROM  PLAN_CUENTA WHERE PLA_CTA_ESTADO = 'Activo' AND PLA_CTA_CODIGO LIKE '" +
             Texto_Buscar + "%'");
            return Plan_CuentaDA.Procesar_SQL(CMD);
            /*
            SqlCommand CMD = new SqlCommand("PA_LOCALIDAD_LISTAR");
            CMD.Parameters.Add(Parametros_SQL.nombre_error, SqlDbType.VarChar).Value = Texto_Buscar;

            CMD.Parameters.Add("@RETURN", SqlDbType.Int);
            CMD.Parameters["@RETURN"].Value = DBNull.Value;
            CMD.Parameters["@RETURN"].Direction = ParameterDirection.ReturnValue;

            return LocalidadDA.Acceder(CMD);
            */
        }

        public static ENResultOperation Listar_Filtro(string Texto_Buscar)
        {
            SqlCommand CMD = new SqlCommand("PA_PLAN_CUENTA_LISTAR_FILTRO");
            CMD.Parameters.Add(Parametros_SQL.nombre_error, SqlDbType.VarChar).Value = Texto_Buscar;

            CMD.Parameters.Add("@RETURN", SqlDbType.Int);
            CMD.Parameters["@RETURN"].Value = DBNull.Value;
            CMD.Parameters["@RETURN"].Direction = ParameterDirection.ReturnValue;

            return Plan_CuentaDA.Acceder(CMD);
        }

    }
}
