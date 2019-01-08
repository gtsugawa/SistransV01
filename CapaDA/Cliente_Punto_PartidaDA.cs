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
    class Cliente_Punto_PartidaDA
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

    public class ClsCliente_Punto_PartidaDA
    {
        public struct Parametros_SQL
        {
            public const string nombre_error = "@NOMBRE_ERROR";
            public const string ide = "@IDE";
            public const string ide_detalle = "@IDE_DETALLE"; // INT OUTPUT,
            public const string direccion = "@DIRECCION"; // varchar(60),
            public const string localidad = "@LOCALIDAD"; // INT,
            public const string veces = "@VECES";
            public const string usuario = "@USUARIO";
        }

        public static ENResultOperation Crear(ClsCliente_Punto_PartidaBE Datos)
        {
            SqlCommand CMD = new SqlCommand("PA_CLIENTE_INSERTA_PUNTO_PARTIDA");
            CMD.Parameters.Add(Parametros_SQL.nombre_error, SqlDbType.VarChar).Value = "";
            CMD.Parameters.Add(Parametros_SQL.ide, SqlDbType.Int).Value = Datos.Prov_ide;
            CMD.Parameters.Add(Parametros_SQL.ide_detalle, SqlDbType.Int).Value = Datos.Prov_part_ide;
            CMD.Parameters.Add(Parametros_SQL.direccion, SqlDbType.VarChar).Value = Datos.Prov_part_direccion;
            CMD.Parameters.Add(Parametros_SQL.localidad, SqlDbType.Int).Value = Datos.Loca_ide;
            CMD.Parameters.Add(Parametros_SQL.veces, SqlDbType.Int).Value = Datos.Veces;
            CMD.Parameters.Add(Parametros_SQL.usuario, SqlDbType.VarChar).Value = Datos.Usuario;

            CMD.Parameters.Add("@RETURN", SqlDbType.Int);
            CMD.Parameters["@RETURN"].Value = DBNull.Value;
            CMD.Parameters["@RETURN"].Direction = ParameterDirection.ReturnValue;

            return Cliente_Punto_PartidaDA.Acceder(CMD);

        }

        public static ENResultOperation Actualizar(ClsCliente_Punto_PartidaBE Datos)
        {
            SqlCommand CMD = new SqlCommand("PA_CLIENTE_MODIFICA_PUNTO_PARTIDA");
            CMD.Parameters.Add(Parametros_SQL.nombre_error, SqlDbType.VarChar).Value = "";
            CMD.Parameters.Add(Parametros_SQL.ide, SqlDbType.Int).Value = Datos.Prov_ide;
            CMD.Parameters.Add(Parametros_SQL.ide_detalle, SqlDbType.Int).Value = Datos.Prov_part_ide;
            CMD.Parameters.Add(Parametros_SQL.direccion, SqlDbType.VarChar).Value = Datos.Prov_part_direccion;
            CMD.Parameters.Add(Parametros_SQL.localidad, SqlDbType.Int).Value = Datos.Loca_ide;
            CMD.Parameters.Add(Parametros_SQL.veces, SqlDbType.Int).Value = Datos.Veces;
            CMD.Parameters.Add(Parametros_SQL.usuario, SqlDbType.VarChar).Value = Datos.Usuario;

            CMD.Parameters.Add("@RETURN", SqlDbType.Int);
            CMD.Parameters["@RETURN"].Value = DBNull.Value;
            CMD.Parameters["@RETURN"].Direction = ParameterDirection.ReturnValue;

            return Cliente_Punto_PartidaDA.Acceder(CMD);

        }

        public static ENResultOperation Eliminar(ClsCliente_Punto_PartidaBE Datos)
        {
            SqlCommand CMD = new SqlCommand("PA_CLIENTE_ELIMINA_PUNTO_PARTIDA");
            CMD.Parameters.Add(Parametros_SQL.nombre_error, SqlDbType.VarChar).Value = "";
            CMD.Parameters.Add(Parametros_SQL.ide, SqlDbType.Int).Value = Datos.Prov_part_ide;
            CMD.Parameters.Add(Parametros_SQL.veces, SqlDbType.Int).Value = Datos.Veces;
            CMD.Parameters.Add(Parametros_SQL.usuario, SqlDbType.VarChar).Value = Datos.Usuario;

            CMD.Parameters.Add("@RETURN", SqlDbType.Int);
            CMD.Parameters["@RETURN"].Value = DBNull.Value;
            CMD.Parameters["@RETURN"].Direction = ParameterDirection.ReturnValue;


            return Cliente_Punto_PartidaDA.Acceder(CMD);
        }

        public static ENResultOperation Listar(Int32 Clie_Ide)
        {
            string CmdSql = "SELECT PROV_IDE,PROV_PART_IDE,PROV_PART_DIRECCION,LOCA_IDE,(SELECT LOCA_NOMBRE FROM LOCALIDAD WHERE LOCA_IDE = CLIENTE_PUNTO_PARTIDA.LOCA_IDE) AS LOCA_NOMBRE," +
                     "CREACION,VECES,LRC_IDE FROM CLIENTE_PUNTO_PARTIDA WHERE PROV_IDE = " + Clie_Ide.ToString();

            SqlCommand CMD = new SqlCommand(CmdSql);
            return Cliente_Punto_PartidaDA.Procesar_SQL(CMD);
        }

        public static ENResultOperation Encontrar(Int32 Clie_Ide, Int32 Part_Ide)
        {
            string CmdSql = "SELECT PROV_IDE,PROV_PART_IDE,PROV_PART_DIRECCION,LOCA_IDE,(SELECT LOCA_NOMBRE FROM LOCALIDAD WHERE LOCA_IDE = CLIENTE_PUNTO_PARTIDA.LOCA_IDE) AS LOCA_NOMBRE," +
                     "CREACION,VECES,LRC_IDE FROM CLIENTE_PUNTO_PARTIDA WHERE PROV_IDE = @IDE AND PROV_PART_IDE = @PART_IDE "; // +Clie_Ide.ToString();

            SqlCommand CMD = new SqlCommand(CmdSql);
            CMD.Parameters.AddWithValue("@IDE", Clie_Ide.ToString());
            CMD.Parameters.AddWithValue("@PART_IDE", Part_Ide.ToString());
            return Cliente_Punto_PartidaDA.Procesar_SQL(CMD);
        }

        public static ENResultOperation Listar_Filtro(string Texto_Buscar)
        {
            SqlCommand CMD = new SqlCommand("PA_CLIENTE_LISTAR_FILTRO_PUNTO_PARTIDA");
            CMD.Parameters.Add(Parametros_SQL.nombre_error, SqlDbType.VarChar).Value = Texto_Buscar;

            CMD.Parameters.Add("@RETURN", SqlDbType.Int);
            CMD.Parameters["@RETURN"].Value = DBNull.Value;
            CMD.Parameters["@RETURN"].Direction = ParameterDirection.ReturnValue;

            return Cliente_Punto_PartidaDA.Acceder(CMD);
        }
    }
}
