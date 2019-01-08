using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaBE;
using CapaDA;

namespace CapaBC
{
    class Serie_FacturacionBC
    {
    }
    public class ClsSerie_FacturacionBC
    {
        public static ENResultOperation Crear(ClsSerie_FacturacionBE Datos)
        {
            return ClsSerie_FacturacionDA.Crear(Datos);
        }
        public static ENResultOperation Actualizar(ClsSerie_FacturacionBE Datos)
        {
            return ClsSerie_FacturacionDA.Actualizar(Datos);
        }

        public static ENResultOperation Eliminar(ClsSerie_FacturacionBE Datos)
        {
            return ClsSerie_FacturacionDA.Eliminar(Datos);
        }

        public static ENResultOperation Listar(string Texto_Buscar)
        {

            return ClsSerie_FacturacionDA.Listar(Texto_Buscar);
        }

        public static ENResultOperation Listar_Filtro(string Texto_Buscar)
        {

            return ClsSerie_FacturacionDA.Listar_Filtro(Texto_Buscar);
        }
    }
}
