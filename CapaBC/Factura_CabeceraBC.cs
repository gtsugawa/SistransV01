using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaBE;
using CapaDA;

namespace CapaBC
{
    class Factura_CabeceraBC
    {
    }
    public class ClsFactura_CabeceraBC
    {
        public static ENResultOperation Crear(ClsFactura_CabeceraBE Datos)
        {
            return ClsFactura_CabeceraDA.Crear(Datos);
        }
        public static ENResultOperation Actualizar(ClsFactura_CabeceraBE Datos)
        {
            return ClsFactura_CabeceraDA.Actualizar(Datos);
        }

        public static ENResultOperation Eliminar(ClsFactura_CabeceraBE Datos)
        {
            return ClsFactura_CabeceraDA.Eliminar(Datos);
        }

        public static ENResultOperation Listar(string Texto_Buscar)
        {

            return ClsFactura_CabeceraDA.Listar(Texto_Buscar);
        }

        public static ENResultOperation Listar_Filtro(string Texto_Buscar)
        {

            return ClsFactura_CabeceraDA.Listar_Filtro(Texto_Buscar);
        }
    }
}
