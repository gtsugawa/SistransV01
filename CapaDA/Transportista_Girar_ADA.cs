﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaBE;

namespace CapaDA
{
    class Transportista_Girar_ADA
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

    public class ClsTransportista_Girar_ADA
    {
        public struct Parametros_SQL
        {

            public const string nombre_error = "@NOMBRE_ERROR";//@NOMBRE_ERROR VARCHAR(100) OUTPUT
            public const string ide = "@IDE"; // INT OUTPUT
            public const string ide_detalle = "@IDE_DETALLE"; // INT OUTPUT CHAR(2)
            public const string nota = "@NOTA";  // varchar(60),
            public const string veces = "@VECES"; // integer
            public const string usuario = "@USUARIO"; // CHAR(15)

        }

        public static ENResultOperation Crear(ClsTransportista_Girar_ABE Datos)
        {
            SqlCommand CMD = new SqlCommand("PA_TRANSPORTISTA_INSERTA_GIRAR_A");
            CMD.Parameters.Add(Parametros_SQL.nombre_error, SqlDbType.VarChar).Value = "";
            CMD.Parameters.Add(Parametros_SQL.ide, SqlDbType.Int).Value = Datos.Tran_ide;
            CMD.Parameters.Add(Parametros_SQL.ide_detalle, SqlDbType.Int).Value = Datos.Tran_gira_ide;
            CMD.Parameters.Add(Parametros_SQL.nota, SqlDbType.VarChar).Value = Datos.Tran_gira_girar_a;
            CMD.Parameters.Add(Parametros_SQL.veces, SqlDbType.Int).Value = Datos.Veces;
            CMD.Parameters.Add(Parametros_SQL.usuario, SqlDbType.VarChar).Value = "User01";

            CMD.Parameters.Add("@RETURN", SqlDbType.Int);
            CMD.Parameters["@RETURN"].Value = DBNull.Value;
            CMD.Parameters["@RETURN"].Direction = ParameterDirection.ReturnValue;
            return Transportista_Girar_ADA.Acceder(CMD);
        }

        public static ENResultOperation Actualizar(ClsTransportista_Girar_ABE Datos)
        {
            SqlCommand CMD = new SqlCommand("PA_TRANSPORTISTA_MODIFICA_GIRAR_A");
            CMD.Parameters.Add(Parametros_SQL.nombre_error, SqlDbType.VarChar).Value = "";
            CMD.Parameters.Add(Parametros_SQL.ide, SqlDbType.Int).Value = Datos.Tran_ide;
            CMD.Parameters.Add(Parametros_SQL.ide_detalle, SqlDbType.Int).Value = Datos.Tran_gira_ide;
            CMD.Parameters.Add(Parametros_SQL.nota, SqlDbType.VarChar).Value = Datos.Tran_gira_girar_a;
            CMD.Parameters.Add(Parametros_SQL.veces, SqlDbType.Int).Value = Datos.Veces;
            CMD.Parameters.Add(Parametros_SQL.usuario, SqlDbType.VarChar).Value = "User01";

            CMD.Parameters.Add("@RETURN", SqlDbType.Int);
            CMD.Parameters["@RETURN"].Value = DBNull.Value;
            CMD.Parameters["@RETURN"].Direction = ParameterDirection.ReturnValue;
            return Transportista_Girar_ADA.Acceder(CMD);

        }

        public static ENResultOperation Eliminar(ClsTransportista_Girar_ABE Datos)
        {
            SqlCommand CMD = new SqlCommand("PA_TRANSPORTISTA_ELIMINA_GIRAR_A");
            CMD.Parameters.Add(Parametros_SQL.nombre_error, SqlDbType.VarChar).Value = DBNull.Value;
            CMD.Parameters.Add(Parametros_SQL.ide, SqlDbType.Int).Value = Datos.Tran_ide;
            CMD.Parameters.Add(Parametros_SQL.veces, SqlDbType.Int).Value = Datos.Veces;
            CMD.Parameters.Add(Parametros_SQL.usuario, SqlDbType.VarChar).Value = "User01";

            CMD.Parameters.Add("@RETURN", SqlDbType.Int);
            CMD.Parameters["@RETURN"].Value = DBNull.Value;
            CMD.Parameters["@RETURN"].Direction = ParameterDirection.ReturnValue;
            return Transportista_Girar_ADA.Acceder(CMD);
        }

        public static ENResultOperation Listar(string Texto_Buscar)
        {
            SqlCommand CMD = new SqlCommand("PA_TRANSPORTISTA_LISTAR_GIRAR_A");
            CMD.Parameters.Add(Parametros_SQL.nombre_error, SqlDbType.VarChar).Value = Texto_Buscar;

            CMD.Parameters.Add("@RETURN", SqlDbType.Int);
            CMD.Parameters["@RETURN"].Value = DBNull.Value;
            CMD.Parameters["@RETURN"].Direction = ParameterDirection.ReturnValue;
            return Transportista_Girar_ADA.Acceder(CMD);
        }

        public static ENResultOperation Listar_Filtro(string Texto_Buscar)
        {
            SqlCommand CMD = new SqlCommand("PA_TRANSPORTISTA_LISTAR_FILTRO_GIRAR_A");
            CMD.Parameters.Add(Parametros_SQL.nota, SqlDbType.VarChar).Value = Texto_Buscar;

            CMD.Parameters.Add("@RETURN", SqlDbType.Int);
            CMD.Parameters["@RETURN"].Value = DBNull.Value;
            CMD.Parameters["@RETURN"].Direction = ParameterDirection.ReturnValue;
            return Transportista_Girar_ADA.Acceder(CMD);
        }

    }

}
