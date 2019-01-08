using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaBE;
using CapaDA;

namespace CapaBC
{
    class Serie_Orden_RecojoBC
    {
    }
    public class ClsSerie_Orden_RecojoBC
    {
        public static ENResultOperation Crear(ClsSerie_Orden_RecojoBE Datos)
        {
            return ClsSerie_Orden_RecojoDA.Crear(Datos);
        }
        public static ENResultOperation Actualizar(ClsSerie_Orden_RecojoBE Datos)
        {
            return ClsSerie_Orden_RecojoDA.Actualizar(Datos);
        }

        public static ENResultOperation Eliminar(ClsSerie_Orden_RecojoBE Datos)
        {
            return ClsSerie_Orden_RecojoDA.Eliminar(Datos);
        }

        public static ENResultOperation Listar(string Texto_Buscar)
        {

            return ClsSerie_Orden_RecojoDA.Listar(Texto_Buscar);
        }

        public static ENResultOperation Listar_Filtro(string NroSer)
        {

            return ClsSerie_Orden_RecojoDA.Listar_Filtro(NroSer);
        }
    }
}
