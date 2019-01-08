using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDA;
using CapaBE;

namespace CapaBC
{
    class TiendaBC
    {
    }

    public class ClsTiendaBC
    {
        public static ENResultOperation Crear(ClsTiendaBE Datos)
        {
            return ClsTiendaDA.Crear(Datos);
        }
        public static ENResultOperation Actualizar(ClsTiendaBE Datos)
        {
            return ClsTiendaDA.Actualizar(Datos);
        }

        public static ENResultOperation Eliminar(ClsTiendaBE Datos)
        {
            return ClsTiendaDA.Eliminar(Datos);
        }

        public static ENResultOperation Listar(string Texto_Buscar)
        {

            return ClsTiendaDA.Listar(Texto_Buscar);
        }

        public static ENResultOperation Listar_Filtro(string Texto_Buscar)
        {

            return ClsTiendaDA.Listar_Filtro(Texto_Buscar);
        }
    }
}
