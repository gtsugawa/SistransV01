using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDA;
using CapaBE;

namespace CapaBC
{
    class Actividad_ClienteBC
    {
    }

    public class ClsActividad_ClienteBC
    {
        public static ENResultOperation Crear(ClsActividad_ClienteBE Datos)
        {
            return ClsActividad_ClienteDA.Crear(Datos);
        }
        public static ENResultOperation Actualizar(ClsActividad_ClienteBE Datos)
        {
            return ClsActividad_ClienteDA.Actualizar(Datos);
        }

        public static ENResultOperation Eliminar(ClsActividad_ClienteBE Datos)
        {
            return ClsActividad_ClienteDA.Eliminar(Datos);
        }

        public static ENResultOperation Listar(string Texto_Buscar)
        {

            return ClsActividad_ClienteDA.Listar(Texto_Buscar);
        }

        public static ENResultOperation Listar_Filtro(string Texto_Buscar)
        {

            return ClsActividad_ClienteDA.Listar_Filtro(Texto_Buscar);
        }
    }
}
