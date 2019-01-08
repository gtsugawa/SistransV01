using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaBE;
using CapaDA;

namespace CapaBC
{
    class Serie_Guia_RemisionBC
    {
    }
    public class ClsSerie_Guia_RemisionBC
    {
        public static ENResultOperation Crear(ClsSerie_Guia_RemisionBE Datos)
        {
            return ClsSerie_Guia_RemisionDA.Crear(Datos);
        }
        public static ENResultOperation Actualizar(ClsSerie_Guia_RemisionBE Datos)
        {
            return ClsSerie_Guia_RemisionDA.Actualizar(Datos);
        }

        public static ENResultOperation Eliminar(ClsSerie_Guia_RemisionBE Datos)
        {
            return ClsSerie_Guia_RemisionDA.Eliminar(Datos);
        }

        public static ENResultOperation Listar(string Texto_Buscar)
        {

            return ClsSerie_Guia_RemisionDA.Listar(Texto_Buscar);
        }

        public static ENResultOperation Listar_Filtro(string Texto_Buscar)
        {

            return ClsSerie_Guia_RemisionDA.Listar_Filtro(Texto_Buscar);
        }
    }
}
