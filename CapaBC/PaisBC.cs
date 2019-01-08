using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaBE;
using CapaDA;

namespace CapaBC
{
    class PaisBC
    {
    }
    public class ClsPaisBC
    {
        public static ENResultOperation Crear(ClsPaisBE Datos)
        {
            return ClsPaisDA.Crear(Datos);
        }
        public static ENResultOperation Actualizar(ClsPaisBE Datos)
        {
            return ClsPaisDA.Actualizar(Datos);
        }

        public static ENResultOperation Eliminar(ClsPaisBE Datos)
        {
            return ClsPaisDA.Eliminar(Datos);
        }

        public static ENResultOperation Listar(string Texto_Buscar)
        {

            return ClsPaisDA.Listar(Texto_Buscar);
        }
        public static ENResultOperation ListarTodos(string Texto_Buscar)
        {

            return ClsPaisDA.ListarTodos(Texto_Buscar);
        }
        public static ENResultOperation Listar_Filtro(string Texto_Buscar, Int32 Pais_Ide)
        {

            return ClsPaisDA.Listar_Filtro(Texto_Buscar, Pais_Ide);
        }
    }
}
