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
    class Tipo_ProveedorDA
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
    public class ClsTipo_ProveedorDA

    {
        public struct Parametros_SQL
        {
            public const string nombre_error = "@NOMBRE_ERROR";
            public const string codigo = "@CODIGO"; // INT OUTPUT,
            public const string ide = "@IDE"; // INT OUTPUT,
            public const string nombre = "@NOMBRE"; // VARCHAR(20),
            public const string estado = "@ESTADO"; // varchar(8),
            public const string inactiva = "@INACTIVA"; // datetime,
            public const string veces = "@VECES"; // integer,
            public const string usuario = "@USUARIO"; // CHAR(15)

        }

        public static ENResultOperation Crear(ClsTipo_ProveedorBE Datos)
        {
            SqlCommand CMD = new SqlCommand("PA_TIPO_PROVEEDOR_INSERTA");
            CMD.Parameters.Add(Parametros_SQL.nombre_error, SqlDbType.VarChar).Value = "";
            CMD.Parameters.Add(Parametros_SQL.codigo, SqlDbType.Int).Value = Datos.Tipo_prov_ide;
            CMD.Parameters.Add(Parametros_SQL.nombre, SqlDbType.VarChar).Value = Datos.Tipo_prov_nombre;
            CMD.Parameters.Add(Parametros_SQL.estado, SqlDbType.VarChar).Value = Datos.Tipo_prov_estado;
            CMD.Parameters.Add(Parametros_SQL.inactiva, SqlDbType.DateTime).Value = Datos.Tipo_prov_fechainac;
            CMD.Parameters.Add(Parametros_SQL.veces, SqlDbType.Int).Value = Datos.Veces;
            CMD.Parameters.Add(Parametros_SQL.usuario, SqlDbType.VarChar).Value = Datos.Usuario;

            CMD.Parameters.Add("@RETURN", SqlDbType.Int);
            CMD.Parameters["@RETURN"].Value = DBNull.Value;
            CMD.Parameters["@RETURN"].Direction = ParameterDirection.ReturnValue;
            return Tipo_ProveedorDA.Acceder(CMD);
        }

        public static ENResultOperation Actualizar(ClsTipo_ProveedorBE Datos)
        {
            SqlCommand CMD = new SqlCommand("PA_TIPO_PROVEEDOR_MODIFICA");
            CMD.Parameters.Add(Parametros_SQL.nombre_error, SqlDbType.VarChar).Value = "";
            CMD.Parameters.Add(Parametros_SQL.ide, SqlDbType.Int).Value = Datos.Tipo_prov_ide;
            CMD.Parameters.Add(Parametros_SQL.nombre, SqlDbType.VarChar).Value = Datos.Tipo_prov_nombre;
            CMD.Parameters.Add(Parametros_SQL.estado, SqlDbType.VarChar).Value = Datos.Tipo_prov_estado;
            CMD.Parameters.Add(Parametros_SQL.inactiva, SqlDbType.DateTime).Value = Datos.Tipo_prov_fechainac;
            CMD.Parameters.Add(Parametros_SQL.veces, SqlDbType.Int).Value = Datos.Veces;
            CMD.Parameters.Add(Parametros_SQL.usuario, SqlDbType.VarChar).Value = Datos.Usuario;

            CMD.Parameters.Add("@RETURN", SqlDbType.Int);
            CMD.Parameters["@RETURN"].Value = DBNull.Value;
            CMD.Parameters["@RETURN"].Direction = ParameterDirection.ReturnValue;
            return Tipo_ProveedorDA.Acceder(CMD);
        }

        public static ENResultOperation Eliminar(ClsTipo_ProveedorBE Datos)
        {
            SqlCommand CMD = new SqlCommand("PA_TIPO_PROVEEDOR_ELIMINA");
            CMD.Parameters.Add(Parametros_SQL.nombre_error, SqlDbType.VarChar).Value = "";
            CMD.Parameters.Add(Parametros_SQL.ide, SqlDbType.Int).Value = Datos.Tipo_prov_ide;
            CMD.Parameters.Add(Parametros_SQL.veces, SqlDbType.Int).Value = Datos.Veces;
            CMD.Parameters.Add(Parametros_SQL.usuario, SqlDbType.VarChar).Value = Datos.Usuario;

            CMD.Parameters.Add("@RETURN", SqlDbType.Int);
            CMD.Parameters["@RETURN"].Value = DBNull.Value;
            CMD.Parameters["@RETURN"].Direction = ParameterDirection.ReturnValue;
            return Tipo_ProveedorDA.Acceder(CMD);
        }

        public static ENResultOperation Listar(string Texto_Buscar)
        {
            SqlCommand CMD = new SqlCommand("SELECT * FROM  TIPO_PROVEEDOR WHERE TIPO_PROV_ESTADO = 'Activo' AND TIPO_PROV_NOMBRE LIKE '" +
                                             Texto_Buscar + "%'");
            return Tipo_ProveedorDA.Procesar_SQL(CMD);
            /*
            SqlCommand CMD = new SqlCommand("PA_TIPO_PROVEEDOR_LISTAR");
            CMD.Parameters.Add(Parametros_SQL.nombre_error, SqlDbType.VarChar).Value = Texto_Buscar;

            CMD.Parameters.Add("@RETURN", SqlDbType.Int);
            CMD.Parameters["@RETURN"].Value = DBNull.Value;
            CMD.Parameters["@RETURN"].Direction = ParameterDirection.ReturnValue;
            return Tipo_ProveedorDA.Acceder(CMD);
            */
        }

        public static ENResultOperation Listar_Filtro(string Texto_Buscar)
        {
            SqlCommand CMD = new SqlCommand("PA_TIPO_PROVEEDOR_LISTAR_FILTRO");
            CMD.Parameters.Add(Parametros_SQL.nombre_error, SqlDbType.VarChar).Value = Texto_Buscar;

            CMD.Parameters.Add("@RETURN", SqlDbType.Int);
            CMD.Parameters["@RETURN"].Value = DBNull.Value;
            CMD.Parameters["@RETURN"].Direction = ParameterDirection.ReturnValue;
            return Tipo_ProveedorDA.Acceder(CMD);
        }
    }
}
