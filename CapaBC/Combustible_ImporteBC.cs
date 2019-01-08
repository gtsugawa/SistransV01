using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaBE;
using CapaDA;

namespace CapaBC
{
    class Combustible_ImporteBC
    {
    }
    public class ClsCombustible_ImporteBC
    {
        public static ENResultOperation Crear(ClsCombustible_ImporteBE Datos)
        {
            return ClsCombustible_ImporteDA.Crear(Datos);
        }
        public static ENResultOperation Actualizar(ClsCombustible_ImporteBE Datos)
        {
            return ClsCombustible_ImporteDA.Actualizar(Datos);
        }

        public static ENResultOperation Eliminar(ClsCombustible_ImporteBE Datos)
        {
            return ClsCombustible_ImporteDA.Eliminar(Datos);
        }

        public static ENResultOperation Listar(string Texto_Buscar)
        {

            return ClsCombustible_ImporteDA.Listar(Texto_Buscar);
        }

        public static ENResultOperation Listar_Filtro(string Texto_Buscar, DateTime Fecha_Buscar)
        {

            return ClsCombustible_ImporteDA.Listar_Filtro(Texto_Buscar, Fecha_Buscar);
        }

        public static ENResultOperation Obtener_Registro(Int32 Prov_Ide, DateTime Fecha_Buscar, Int32 TipoCombustible)
        {

            return ClsCombustible_ImporteDA.Obtener_Registro(Prov_Ide, Fecha_Buscar, TipoCombustible);
        }
    }
}
