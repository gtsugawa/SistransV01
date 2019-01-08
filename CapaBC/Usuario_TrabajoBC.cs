using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaBE;
using CapaDA;

namespace CapaBC
{
    class Usuario_TrabajoBC
    {
    }
    public class ClsUsuario_TrabajoBC
    {
        public static ENResultOperation Crear(ClsUsuario_TrabajoBE Datos)
        {
            return ClsUsuario_TrabajoDA.Crear(Datos);
        }
        public static ENResultOperation Actualizar(ClsUsuario_TrabajoBE Datos)
        {
            return ClsUsuario_TrabajoDA.Actualizar(Datos);
        }

        public static ENResultOperation Eliminar(ClsUsuario_TrabajoBE Datos)
        {
            return ClsUsuario_TrabajoDA.Eliminar(Datos);
        }

        public static ENResultOperation Listar(string Texto_Buscar)
        {

            return ClsUsuario_TrabajoDA.Listar(Texto_Buscar);
        }
        public static ENResultOperation ListarTodos(string Texto_Buscar)
        {

            return ClsUsuario_TrabajoDA.Listar(Texto_Buscar);
        }

        public static ENResultOperation Listar_Filtro(string Texto_Buscar)
        {

            return ClsUsuario_TrabajoDA.Listar_Filtro(Texto_Buscar);
        }
    }
}
