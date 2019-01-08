using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDA;
using CapaBE;

namespace CapaBC
{
    class Tipo_ProveedorBC
    {
    }
    public class ClsTipo_ProveedorBC
    {
        public static ENResultOperation Crear(ClsTipo_ProveedorBE Datos)
        {
            return ClsTipo_ProveedorDA.Crear(Datos);
        }
        public static ENResultOperation Actualizar(ClsTipo_ProveedorBE Datos)
        {
            return ClsTipo_ProveedorDA.Actualizar(Datos);
        }

        public static ENResultOperation Eliminar(ClsTipo_ProveedorBE Datos)
        {
            return ClsTipo_ProveedorDA.Eliminar(Datos);
        }

        public static ENResultOperation Listar(string Texto_Buscar)
        {

            return ClsTipo_ProveedorDA.Listar(Texto_Buscar);
        }

        public static ENResultOperation Listar_Filtro(string Texto_Buscar)
        {

            return ClsTipo_ProveedorDA.Listar_Filtro(Texto_Buscar);
        }
    }
}
