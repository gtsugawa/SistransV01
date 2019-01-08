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
    class Transportista_VehiculoDA
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

    public class ClsTransportista_VehiculoDA
    {
        public struct Parametros_SQL
        {

            public const string nombre_error = "@NOMBRE_ERROR";//@NOMBRE_ERROR VARCHAR(100) OUTPUT
            public const string ide = "@IDE"; // INT OUTPUT
            public const string ide_detalle = "@IDE_DETALLE"; // INT OUTPUT CHAR(2)
            public const string placa = "@PLACA";  // varchar(15),
            public const string configuracion = "@CONFIGURACION";  // varchar(15),
            public const string certificado = "@CERTIFICADO";  // varchar(15),
            public const string combustible = "@COMBUSTIBLE";  // varchar(10),
            public const string freno = "@FRENO";  // varchar(15),
            public const string aro = "@ARO";  // VARchar(10),
            public const string serie = "@SERIE";  // VARCHAR(20),
            public const string nombre = "@NOMBRE";  // VARCHAR(20),
            public const string marca = "@MARCA";  // INT,
            public const string tipo = "@TIPO";  // INT,
            public const string color = "@COLOR";  // INT,
            public const string ano = "@ANO";  // INT,
            public const string kilometro = "@KILOMETRO";  // INT,
            public const string volumen = "@VOLUMEN";  // INT,
            public const string rendimiento = "@RENDIMIENTO";  // DECIMAL(18,3),
            public const string veces = "@VECES";  // integer,
            public const string usuario = "@USUARIO";  // CHAR(15)

        }

        public static ENResultOperation Crear(ClsTransportista_VehiculoBE Datos)
        {
            SqlCommand CMD = new SqlCommand("PA_TRANSPORTISTA_INSERTA_VEHICULO");
            CMD.Parameters.Add(Parametros_SQL.nombre_error, SqlDbType.VarChar).Value = "";
            CMD.Parameters.Add(Parametros_SQL.ide, SqlDbType.Int).Value = Datos.Tran_ide;
            CMD.Parameters.Add(Parametros_SQL.ide_detalle, SqlDbType.Int).Value = Datos.Tran_vehi_ide;

            CMD.Parameters.Add(Parametros_SQL.placa, SqlDbType.VarChar).Value = Datos.Tran_vehi_placa;
            CMD.Parameters.Add(Parametros_SQL.configuracion, SqlDbType.VarChar).Value = Datos.Tran_vehi_configuracion;
            CMD.Parameters.Add(Parametros_SQL.certificado, SqlDbType.VarChar).Value = Datos.Tran_vehi_certificado;
            CMD.Parameters.Add(Parametros_SQL.combustible, SqlDbType.VarChar).Value = Datos.Tran_vehi_combustible;
            CMD.Parameters.Add(Parametros_SQL.freno, SqlDbType.VarChar).Value = Datos.Tran_vehi_tipo_freno;
            CMD.Parameters.Add(Parametros_SQL.aro, SqlDbType.VarChar).Value = Datos.Tran_vehi_aro;
            CMD.Parameters.Add(Parametros_SQL.serie, SqlDbType.VarChar).Value = Datos.Tran_vehi_serie;
            CMD.Parameters.Add(Parametros_SQL.nombre, SqlDbType.VarChar).Value = Datos.Tran_vehi_nombre;
            CMD.Parameters.Add(Parametros_SQL.marca, SqlDbType.Int).Value = Datos.Marca_vehi_ide;
            CMD.Parameters.Add(Parametros_SQL.tipo, SqlDbType.Int).Value = Datos.Tipo_vehi_ide;
            CMD.Parameters.Add(Parametros_SQL.color, SqlDbType.Int).Value = Datos.Color_ide;
            CMD.Parameters.Add(Parametros_SQL.ano, SqlDbType.Int).Value = Datos.Tran_vehi_año;
            CMD.Parameters.Add(Parametros_SQL.kilometro, SqlDbType.Int).Value = Datos.Tran_vehi_tonelaje;
            CMD.Parameters.Add(Parametros_SQL.volumen, SqlDbType.Int).Value = Datos.Tran_vehi_volumen;
            CMD.Parameters.Add(Parametros_SQL.rendimiento, SqlDbType.Decimal).Value = Datos.Tran_vehi_rendimiento;

            CMD.Parameters.Add(Parametros_SQL.veces, SqlDbType.Int).Value = Datos.Veces;
            CMD.Parameters.Add(Parametros_SQL.usuario, SqlDbType.VarChar).Value = "User01";

            CMD.Parameters.Add("@RETURN", SqlDbType.Int);
            CMD.Parameters["@RETURN"].Value = DBNull.Value;
            CMD.Parameters["@RETURN"].Direction = ParameterDirection.ReturnValue;
            return Transportista_VehiculoDA.Acceder(CMD);
        }

        public static ENResultOperation Actualizar(ClsTransportista_VehiculoBE Datos)
        {
            SqlCommand CMD = new SqlCommand("PA_TRANSPORTISTA_MODIFICA_VEHICULO");
            CMD.Parameters.Add(Parametros_SQL.nombre_error, SqlDbType.VarChar).Value = "";
            CMD.Parameters.Add(Parametros_SQL.ide, SqlDbType.Int).Value = Datos.Tran_ide;
            CMD.Parameters.Add(Parametros_SQL.ide_detalle, SqlDbType.Int).Value = Datos.Tran_vehi_ide;
            CMD.Parameters.Add(Parametros_SQL.placa, SqlDbType.VarChar).Value = Datos.Tran_vehi_placa;
            CMD.Parameters.Add(Parametros_SQL.configuracion, SqlDbType.VarChar).Value = Datos.Tran_vehi_configuracion;
            CMD.Parameters.Add(Parametros_SQL.certificado, SqlDbType.VarChar).Value = Datos.Tran_vehi_certificado;
            CMD.Parameters.Add(Parametros_SQL.combustible, SqlDbType.VarChar).Value = Datos.Tran_vehi_combustible;
            CMD.Parameters.Add(Parametros_SQL.freno, SqlDbType.VarChar).Value = Datos.Tran_vehi_tipo_freno;
            CMD.Parameters.Add(Parametros_SQL.aro, SqlDbType.VarChar).Value = Datos.Tran_vehi_aro;
            CMD.Parameters.Add(Parametros_SQL.serie, SqlDbType.VarChar).Value = Datos.Tran_vehi_serie;
            CMD.Parameters.Add(Parametros_SQL.nombre, SqlDbType.VarChar).Value = Datos.Tran_vehi_nombre;
            CMD.Parameters.Add(Parametros_SQL.marca, SqlDbType.Int).Value = Datos.Marca_vehi_ide;
            CMD.Parameters.Add(Parametros_SQL.tipo, SqlDbType.Int).Value = Datos.Tipo_vehi_ide;
            CMD.Parameters.Add(Parametros_SQL.color, SqlDbType.Int).Value = Datos.Color_ide;
            CMD.Parameters.Add(Parametros_SQL.ano, SqlDbType.Int).Value = Datos.Tran_vehi_año;
            CMD.Parameters.Add(Parametros_SQL.kilometro, SqlDbType.Int).Value = Datos.Tran_vehi_tonelaje;
            CMD.Parameters.Add(Parametros_SQL.volumen, SqlDbType.Int).Value = Datos.Tran_vehi_volumen;
            CMD.Parameters.Add(Parametros_SQL.rendimiento, SqlDbType.Decimal).Value = Datos.Tran_vehi_rendimiento;
            CMD.Parameters.Add(Parametros_SQL.veces, SqlDbType.Int).Value = Datos.Veces;
            CMD.Parameters.Add(Parametros_SQL.usuario, SqlDbType.VarChar).Value = "User01";

            CMD.Parameters.Add("@RETURN", SqlDbType.Int);
            CMD.Parameters["@RETURN"].Value = DBNull.Value;
            CMD.Parameters["@RETURN"].Direction = ParameterDirection.ReturnValue;
            return Transportista_VehiculoDA.Acceder(CMD);

        }

        public static ENResultOperation Eliminar(ClsTransportista_VehiculoBE Datos)
        {
            SqlCommand CMD = new SqlCommand("PA_TRANSPORTISTA_ELIMINA_VEHICULO");
            CMD.Parameters.Add(Parametros_SQL.nombre_error, SqlDbType.VarChar).Value = DBNull.Value;
            CMD.Parameters.Add(Parametros_SQL.ide, SqlDbType.Int).Value = Datos.Tran_vehi_ide;
            CMD.Parameters.Add(Parametros_SQL.veces, SqlDbType.Int).Value = Datos.Veces;
            CMD.Parameters.Add(Parametros_SQL.usuario, SqlDbType.VarChar).Value = "User01";

            CMD.Parameters.Add("@RETURN", SqlDbType.Int);
            CMD.Parameters["@RETURN"].Value = DBNull.Value;
            CMD.Parameters["@RETURN"].Direction = ParameterDirection.ReturnValue;
            return Transportista_VehiculoDA.Acceder(CMD);
        }

        public static ENResultOperation Listar(string Texto_Buscar)
        {

            SqlCommand CMD = new SqlCommand("SELECT * FROM TRANSPORTISTA_VEHICULO WHERE TRAN_VEHI_PLACA LIKE '" +
                             Texto_Buscar + "%'");
            return ProcesarSQLDA.Procesar_SQL(CMD);

        }

        public static ENResultOperation Listar_Filtro(string Texto_Buscar, Int32 Transportista_Ide)
        {
            SqlCommand CMD = new SqlCommand("SELECT * FROM  V_TRANSPORTISTA_VEHICULO WHERE TRAN_IDE = @TRAN_IDE AND " +
                              "TRAN_VEHI_PLACA LIKE '%' + @BUSCAR ORDER BY TRAN_VEHI_PLACA");

            CMD.Parameters.AddWithValue("@BUSCAR", Texto_Buscar);
            CMD.Parameters.AddWithValue("@TRAN_IDE", Transportista_Ide);
            return ProcesarSQLDA.Procesar_SQL(CMD);

  
        }

        public static ENResultOperation Obtener_Vehiculo(string Vehiculo_Ide, string Transportista_Ide)
        {
            SqlCommand CMD = new SqlCommand("SELECT * FROM  V_TRANSPORTISTA_VEHICULO WHERE TRAN_IDE = @TRAN_IDE AND TRAN_VEHI_IDE = @VEHI_IDE" );

            CMD.Parameters.AddWithValue("@VEHI_IDE", Convert.ToInt32(Vehiculo_Ide));
            CMD.Parameters.AddWithValue("@TRAN_IDE", Convert.ToInt32(Transportista_Ide));
            return ProcesarSQLDA.Procesar_SQL(CMD);
        }
    }
}
