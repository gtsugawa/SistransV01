using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDA;
using CapaBE;


namespace CapaBC
{
    class Actividad_ProveedorBC
    {
    }

    public class ClsActividad_ProveedorBC
    {
        public static ENResultOperation Crear(ClsActividad_ProveedorBE Datos)
        {
            return ClsActividad_ProveedorDA.Crear(Datos);
        }
        public static ENResultOperation Actualizar(ClsActividad_ProveedorBE Datos)
        {
            return ClsActividad_ProveedorDA.Actualizar(Datos);
        }

        public static ENResultOperation Eliminar(ClsActividad_ProveedorBE Datos)
        {
            return ClsActividad_ProveedorDA.Eliminar(Datos);
        }

        public static ENResultOperation Listar(string Texto_Buscar)
        {

            return ClsActividad_ProveedorDA.Listar(Texto_Buscar);
        }

        public static ENResultOperation Listar_Filtro(string Texto_Buscar)
        {

            return ClsActividad_ProveedorDA.Listar_Filtro(Texto_Buscar);
        }
    }
}
