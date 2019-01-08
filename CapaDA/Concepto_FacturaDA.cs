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
    class Concepto_FacturaDA
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
    public class ClsConcepto_FacturaDA
    {
        public struct Parametros_SQL
        {
            public const string nombre_error = "@NOMBRE_ERROR";
            public const string codigo = "@CODIGO"; // INT OUTPUT,
            public const string ide = "@IDE"; // INT OUTPUT,
            public const string nombre = "@NOMBRE"; // VARCHAR(20),
            public const string impuesto = "@IMPUESTO"; // VARCHAR(10),
            public const string recargo = "@RECARGO"; // INT,
            public const string estado = "@ESTADO"; // varchar(8),
            public const string inactiva = "@INACTIVA"; // datetime,
            public const string ide_pla_cta = "@IDE_PLA_CTA"; // integer,
            public const string ide_pla_cta_des = "@IDE_PLA_CTA_DES"; // integer,
            public const string ide_pla_cta_dev = "@IDE_PLA_CTA_DEV"; // integer,
            public const string ide_linea_negocio = "@IDE_LINEA_NEGOCIO"; // integer,
            public const string ide_costo_produccion = "@IDE_COSTO_PRODUCCION"; // integer,
            public const string ide_actividad_produccion = "@IDE_ACTIVIDAD_PRODUCCION"; // integer,
            public const string veces = "@VECES"; // integer,
            public const string usuario = "@USUARIO"; // CHAR(15)
            public const string nombre2 = "@NOMBRE2"; // VARCHAR(80),
            public const string nombre_ingles = "@NOMBRE_INGLES"; //  VARCHAR(80),
            public const string ide_pla_cta_relacionada = "@IDE_PLA_CTA_RELACIONADA"; //  integer,
            public const string ide_pla_cta_des_relacionada = "@IDE_PLA_CTA_DES_RELACIONADA"; //  integer,
            public const string ide_pla_cta_dev_relacionada = "@IDE_PLA_CTA_DEV_RELACIONADA"; //  integer,
        }

        public static ENResultOperation Crear(ClsConcepto_FacturaBE Datos)
        {
            SqlCommand CMD = new SqlCommand("PA_CONCEPTO_FACTURA_INSERTA");
            CMD.Parameters.Add(Parametros_SQL.nombre_error, SqlDbType.VarChar).Value = "";
            CMD.Parameters.Add(Parametros_SQL.ide, SqlDbType.Int).Value = Datos.Merca_ide;
            CMD.Parameters.Add(Parametros_SQL.codigo, SqlDbType.Int).Value = Datos.Merca_codigo;
            CMD.Parameters.Add(Parametros_SQL.nombre, SqlDbType.VarChar).Value = Datos.Merca_nombre;
            CMD.Parameters.Add(Parametros_SQL.nombre2, SqlDbType.VarChar).Value = Datos.Merca_nombre2;
            CMD.Parameters.Add(Parametros_SQL.nombre_ingles, SqlDbType.VarChar).Value = Datos.Merca_nombre_ingles;
            CMD.Parameters.Add(Parametros_SQL.impuesto, SqlDbType.VarChar).Value = Datos.Merca_impuesto;
            CMD.Parameters.Add(Parametros_SQL.recargo, SqlDbType.Int).Value = Datos.Merca_recargo;
            CMD.Parameters.Add(Parametros_SQL.estado, SqlDbType.VarChar).Value = Datos.Merca_estado;
            CMD.Parameters.Add(Parametros_SQL.inactiva, SqlDbType.DateTime).Value = Datos.Merca_fechainac;
            CMD.Parameters.Add(Parametros_SQL.ide_pla_cta, SqlDbType.Int).Value = Datos.Pla_cta_ide;
            CMD.Parameters.Add(Parametros_SQL.ide_pla_cta_des, SqlDbType.Int).Value = Datos.Pla_cta_ide_des;
            CMD.Parameters.Add(Parametros_SQL.ide_pla_cta_dev, SqlDbType.Int).Value = Datos.Pla_cta_ide_dev;
            CMD.Parameters.Add(Parametros_SQL.ide_pla_cta_relacionada, SqlDbType.Int).Value = Datos.Pla_cta_ide_relacionada;
            CMD.Parameters.Add(Parametros_SQL.ide_pla_cta_des_relacionada, SqlDbType.Int).Value = Datos.Pla_cta_ide_des_relacionada;
            CMD.Parameters.Add(Parametros_SQL.ide_pla_cta_dev_relacionada, SqlDbType.Int).Value = Datos.Pla_cta_ide_dev_relacionada;
            CMD.Parameters.Add(Parametros_SQL.ide_linea_negocio, SqlDbType.Int).Value = Datos.Linea_nego_ide;
            CMD.Parameters.Add(Parametros_SQL.ide_costo_produccion, SqlDbType.Int).Value = Datos.Cost_prod_ide;
            CMD.Parameters.Add(Parametros_SQL.ide_actividad_produccion, SqlDbType.Int).Value = Datos.Acti_prod_ide;
            CMD.Parameters.Add(Parametros_SQL.veces, SqlDbType.Int).Value = Datos.Veces;
            CMD.Parameters.Add(Parametros_SQL.usuario, SqlDbType.VarChar).Value = Datos.Usuario;

            CMD.Parameters.Add("@RETURN", SqlDbType.Int);
            CMD.Parameters["@RETURN"].Value = DBNull.Value;
            CMD.Parameters["@RETURN"].Direction = ParameterDirection.ReturnValue;            
            return Concepto_FacturaDA.Acceder(CMD);
        }

        public static ENResultOperation Actualizar(ClsConcepto_FacturaBE Datos)
        {
            SqlCommand CMD = new SqlCommand("PA_CONCEPTO_FACTURA_MODIFICA");
            CMD.Parameters.Add(Parametros_SQL.nombre_error, SqlDbType.VarChar).Value = "";
            CMD.Parameters.Add(Parametros_SQL.ide, SqlDbType.Int).Value = Datos.Merca_ide;
            CMD.Parameters.Add(Parametros_SQL.codigo, SqlDbType.Int).Value = Datos.Merca_codigo;
            CMD.Parameters.Add(Parametros_SQL.nombre, SqlDbType.VarChar).Value = Datos.Merca_nombre;
            CMD.Parameters.Add(Parametros_SQL.nombre2, SqlDbType.VarChar).Value = Datos.Merca_nombre2;
            CMD.Parameters.Add(Parametros_SQL.nombre_ingles, SqlDbType.VarChar).Value = Datos.Merca_nombre_ingles;
            CMD.Parameters.Add(Parametros_SQL.impuesto, SqlDbType.VarChar).Value = Datos.Merca_impuesto;
            CMD.Parameters.Add(Parametros_SQL.recargo, SqlDbType.Int).Value = Datos.Merca_recargo;
            CMD.Parameters.Add(Parametros_SQL.estado, SqlDbType.VarChar).Value = Datos.Merca_estado;
            CMD.Parameters.Add(Parametros_SQL.inactiva, SqlDbType.DateTime).Value = Datos.Merca_fechainac;
            CMD.Parameters.Add(Parametros_SQL.ide_pla_cta, SqlDbType.Int).Value = Datos.Pla_cta_ide;
            CMD.Parameters.Add(Parametros_SQL.ide_pla_cta_des, SqlDbType.Int).Value = Datos.Pla_cta_ide_des;
            CMD.Parameters.Add(Parametros_SQL.ide_pla_cta_dev, SqlDbType.Int).Value = Datos.Pla_cta_ide_dev;
            CMD.Parameters.Add(Parametros_SQL.ide_pla_cta_relacionada, SqlDbType.Int).Value = Datos.Pla_cta_ide_relacionada;
            CMD.Parameters.Add(Parametros_SQL.ide_pla_cta_des_relacionada, SqlDbType.Int).Value = Datos.Pla_cta_ide_des_relacionada;
            CMD.Parameters.Add(Parametros_SQL.ide_pla_cta_dev_relacionada, SqlDbType.Int).Value = Datos.Pla_cta_ide_dev_relacionada;
            CMD.Parameters.Add(Parametros_SQL.ide_linea_negocio, SqlDbType.Int).Value = Datos.Linea_nego_ide;
            CMD.Parameters.Add(Parametros_SQL.ide_costo_produccion, SqlDbType.Int).Value = Datos.Cost_prod_ide;
            CMD.Parameters.Add(Parametros_SQL.ide_actividad_produccion, SqlDbType.Int).Value = Datos.Acti_prod_ide;
            CMD.Parameters.Add(Parametros_SQL.veces, SqlDbType.Int).Value = Datos.Veces;
            CMD.Parameters.Add(Parametros_SQL.usuario, SqlDbType.VarChar).Value = Datos.Usuario;
            CMD.Parameters.Add("@RETURN", SqlDbType.Int);
            CMD.Parameters["@RETURN"].Value = DBNull.Value;
            CMD.Parameters["@RETURN"].Direction = ParameterDirection.ReturnValue;
            return Concepto_FacturaDA.Acceder(CMD);
        }

        public static ENResultOperation Eliminar(ClsConcepto_FacturaBE Datos)
        {
            SqlCommand CMD = new SqlCommand("PA_CONCEPTO_FACTURA_ELIMINA");
            CMD.Parameters.Add(Parametros_SQL.nombre_error, SqlDbType.VarChar).Value = "";
            CMD.Parameters.Add(Parametros_SQL.ide, SqlDbType.Int).Value = Datos.Merca_ide;
            CMD.Parameters.Add(Parametros_SQL.veces, SqlDbType.Int).Value = Datos.Veces;
            CMD.Parameters.Add(Parametros_SQL.usuario, SqlDbType.VarChar).Value = Datos.Usuario;
            CMD.Parameters.Add("@RETURN", SqlDbType.Int);
            CMD.Parameters["@RETURN"].Value = DBNull.Value;
            CMD.Parameters["@RETURN"].Direction = ParameterDirection.ReturnValue;
            return Concepto_FacturaDA.Acceder(CMD);
        }

        public static ENResultOperation Listar(string Texto_Buscar)
        {
            SqlCommand CMD = new SqlCommand("SELECT * FROM CONCEPTO_FACTURA WHERE MERCA_ESTADO = 'Activo' AND MERCA_NOMBRE LIKE '%" +
                   Texto_Buscar + "%'");
            return ProcesarSQLDA.Procesar_SQL(CMD);
        }
        public static ENResultOperation ListarTodos(string Texto_Buscar)
        {
            SqlCommand CMD = new SqlCommand("SELECT * FROM CONCEPTO_FACTURA WHERE MERCA_NOMBRE LIKE '%" +
                   Texto_Buscar + "%'");
            return ProcesarSQLDA.Procesar_SQL(CMD);
        }
        public static ENResultOperation Listar_Filtro(string Texto_Buscar)
        {
            SqlCommand CMD = new SqlCommand("PA_CONCEPTO_FACTURA_LISTAR_FILTRO");
            CMD.Parameters.Add(Parametros_SQL.nombre_error, SqlDbType.VarChar).Value = DBNull.Value;
            CMD.Parameters.Add(Parametros_SQL.nombre, SqlDbType.VarChar).Value = Texto_Buscar;

            CMD.Parameters.Add("@RETURN", SqlDbType.Int);
            CMD.Parameters["@RETURN"].Value = DBNull.Value;
            CMD.Parameters["@RETURN"].Direction = ParameterDirection.ReturnValue;
            return Concepto_FacturaDA.Acceder(CMD);
        }


    }
}
