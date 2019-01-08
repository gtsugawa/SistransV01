using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaBE;
using CapaDA;

namespace CapaBC
{
    class UsuarioBC
    {
    }
    public class ClsUsuarioBC
    {
        public static ENResultOperation Crear(ClsUsuarioBE Datos)
        {
            return ClsUsuarioDA.Crear(Datos);
        }
        public static ENResultOperation Actualizar(ClsUsuarioBE Datos)
        {
            return ClsUsuarioDA.Actualizar(Datos);
        }

        public static ENResultOperation Eliminar(ClsUsuarioBE Datos)
        {
            return ClsUsuarioDA.Eliminar(Datos);
        }

        public static ENResultOperation Listar(string Texto_Buscar)
        {

            return ClsUsuarioDA.Listar(Texto_Buscar);
        }
        public static ENResultOperation ListarTodos(string Texto_Buscar)
        {

            return ClsUsuarioDA.Listar(Texto_Buscar);
        }

        public static ENResultOperation Listar_Filtro(string Texto_Buscar)
        {

            return ClsUsuarioDA.Listar_Filtro(Texto_Buscar);
        }
    }
}
