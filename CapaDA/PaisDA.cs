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
    class PaisDA
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


    }

    public class ClsPaisDA
    {
        public struct Parametros_SQL
        {
            public const string nombre_error = "@NOMBRE_ERROR";
            public const string ide = "@IDE";
            public const string codigo = "@CODIGO";
            public const string nombre = "@NOMBRE";
            public const string estado = "@ESTADO";
            public const string inactiva = "@INACTIVA";
            public const string veces = "@VECES";
            public const string usuario = "@USUARIO";
        }

        public static ENResultOperation Crear(ClsPaisBE Datos)
        {
            SqlCommand CMD = new SqlCommand("PA_PAIS_INSERTA");
            CMD.Parameters.Add(Parametros_SQL.nombre_error, SqlDbType.VarChar).Value = "";
            CMD.Parameters.Add(Parametros_SQL.codigo, SqlDbType.VarChar).Value = Datos.Pais_ide;
            CMD.Parameters.Add(Parametros_SQL.nombre, SqlDbType.VarChar).Value = Datos.Pais_nombre;
            CMD.Parameters.Add(Parametros_SQL.estado, SqlDbType.VarChar).Value = Datos.Pais_estado;
            CMD.Parameters.Add(Parametros_SQL.inactiva, SqlDbType.DateTime).Value = Datos.Pais_fechainac;
            CMD.Parameters.Add(Parametros_SQL.veces, SqlDbType.Int).Value = Datos.Veces;
            CMD.Parameters.Add(Parametros_SQL.usuario, SqlDbType.VarChar).Value = Datos.Usuario;

            CMD.Parameters.Add("@RETURN", SqlDbType.Int);
            CMD.Parameters["@RETURN"].Value = DBNull.Value;
            CMD.Parameters["@RETURN"].Direction = ParameterDirection.ReturnValue;

            return PaisDA.Acceder(CMD);

        }

        public static ENResultOperation Actualizar(ClsPaisBE Datos)
        {
            SqlCommand CMD = new SqlCommand("PA_PAIS_MODIFICA");
            CMD.Parameters.Add(Parametros_SQL.nombre_error, SqlDbType.VarChar).Value = "";
            CMD.Parameters.Add(Parametros_SQL.ide, SqlDbType.Int).Value = Datos.Pais_ide;
            CMD.Parameters.Add(Parametros_SQL.nombre, SqlDbType.VarChar).Value = Datos.Pais_nombre;
            CMD.Parameters.Add(Parametros_SQL.estado, SqlDbType.VarChar).Value = Datos.Pais_estado;
            CMD.Parameters.Add(Parametros_SQL.inactiva, SqlDbType.DateTime).Value = Datos.Pais_fechainac;
            CMD.Parameters.Add(Parametros_SQL.veces, SqlDbType.Int).Value = Datos.Veces;
            CMD.Parameters.Add(Parametros_SQL.usuario, SqlDbType.VarChar).Value = Datos.Usuario;

            CMD.Parameters.Add("@RETURN", SqlDbType.Int);
            CMD.Parameters["@RETURN"].Value = DBNull.Value;
            CMD.Parameters["@RETURN"].Direction = ParameterDirection.ReturnValue;

            return PaisDA.Acceder(CMD);

        }

        public static ENResultOperation Eliminar(ClsPaisBE Datos)
        {
            SqlCommand CMD = new SqlCommand("PA_PAIS_ELIMINA");
            CMD.Parameters.Add(Parametros_SQL.nombre_error, SqlDbType.VarChar).Value = DBNull.Value;
            CMD.Parameters.Add(Parametros_SQL.ide, SqlDbType.Int).Value = Datos.Pais_ide;
            CMD.Parameters.Add(Parametros_SQL.veces, SqlDbType.Int).Value = Datos.Veces;
            CMD.Parameters.Add(Parametros_SQL.usuario, SqlDbType.VarChar).Value = Datos.Usuario;

            CMD.Parameters.Add("@RETURN", SqlDbType.Int);
            CMD.Parameters["@RETURN"].Value = DBNull.Value;
            CMD.Parameters["@RETURN"].Direction = ParameterDirection.ReturnValue;


            return PaisDA.Acceder(CMD);
        }

        public static ENResultOperation Listar(string Texto_Buscar)
        {
            SqlCommand CMD = new SqlCommand("SELECT * FROM PAIS WHERE PAIS_ESTADO = 'Activo' AND PAIS_NOMBRE LIKE '" +
                   Texto_Buscar + "%'");
            return ProcesarSQLDA.Procesar_SQL(CMD);
        }

        public static ENResultOperation ListarTodos(string Texto_Buscar)
        {
            SqlCommand CMD = new SqlCommand("SELECT * FROM PAIS WHERE PAIS_NOMBRE LIKE '" +
                   Texto_Buscar + "%'");
            return ProcesarSQLDA.Procesar_SQL(CMD);
        }
        public static ENResultOperation Listar_Filtro(string Texto_Buscar, Int32 Pais_Ide)
        {
            SqlCommand CMD = new SqlCommand("SELECT * FROM PAIS WHERE PAIS_IDE = @IDE AND PAIS_NOMBRE LIKE (@FILTRO + '%') ORDER BY PAIS_NOMBRE");
            CMD.Parameters.AddWithValue("@IDE",Pais_Ide);
            CMD.Parameters.AddWithValue("@FILTRO", Texto_Buscar);
            return ProcesarSQLDA.Procesar_SQL(CMD);
            /*
            SqlCommand CMD = new SqlCommand("PA_PAIS_LISTAR_FILTRO");
            CMD.Parameters.Add(Parametros_SQL.nombre_error, SqlDbType.VarChar).Value = Texto_Buscar;
            CMD.Parameters.Add(Parametros_SQL.ide, SqlDbType.Int).Value = Pais_Ide;

            CMD.Parameters.Add("@RETURN", SqlDbType.Int);
            CMD.Parameters["@RETURN"].Value = DBNull.Value;
            CMD.Parameters["@RETURN"].Direction = ParameterDirection.ReturnValue;

            return PaisDA.Acceder(CMD);
            */
        }
    }
}
