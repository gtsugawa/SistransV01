using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaBE;
using CapaDA;

namespace CapaBC
{
    class ArticuloBC
    {
    }

    public class ClsArticuloBC
    {
        public static ENResultOperation Crear(ClsArticuloBE Datos)
        {
            return ClsArticuloDA.Crear(Datos);
        }
        public static ENResultOperation Actualizar(ClsArticuloBE Datos)
        {
            return ClsArticuloDA.Actualizar(Datos);
        }

        public static ENResultOperation Eliminar(ClsArticuloBE Datos)
        {
            return ClsArticuloDA.Eliminar(Datos);
        }

        public static ENResultOperation Listar(string Texto_Buscar)
        {

            return ClsArticuloDA.Listar(Texto_Buscar);
        }

        public static ENResultOperation Listar_Filtro(string Texto_Buscar)
        {

            return ClsArticuloDA.Listar_Filtro(Texto_Buscar);
        }
    }
}
