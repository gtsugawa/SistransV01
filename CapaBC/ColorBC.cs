using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaBE;
using CapaDA;

namespace CapaBC
{
    class ColorBC
    {
    }
    public class ClsColorBC
    {
        public static ENResultOperation Crear(ClsColorBE Datos)
        {
            return ClsColorDA.Crear(Datos);
        }
        public static ENResultOperation Actualizar(ClsColorBE Datos)
        {
            return ClsColorDA.Actualizar(Datos);
        }

        public static ENResultOperation Eliminar(ClsColorBE Datos)
        {
            return ClsColorDA.Eliminar(Datos);
        }

        public static ENResultOperation Listar(string Texto_Buscar)
        {

            return ClsColorDA.Listar(Texto_Buscar);
        }

        public static ENResultOperation ListarTodos(string Texto_Buscar)
        {

            return ClsColorDA.ListarTodos(Texto_Buscar);
        }
        public static ENResultOperation Listar_Filtro(string Texto_Buscar)
        {

            return ClsColorDA.Listar_Filtro(Texto_Buscar);
        }
    }
}
