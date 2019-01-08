using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaBE;
using CapaDA;

namespace CapaBC
{
    class Categoria_ProveedorBC
    {
    }
    public class ClsCategoria_ProveedorBC
    {
        public static ENResultOperation Crear(ClsCategoria_ProveedorBE Datos)
        {
            return ClsCategoria_ProveedorDA.Crear(Datos);
        }
        public static ENResultOperation Actualizar(ClsCategoria_ProveedorBE Datos)
        {
            return ClsCategoria_ProveedorDA.Actualizar(Datos);
        }

        public static ENResultOperation Eliminar(ClsCategoria_ProveedorBE Datos)
        {
            return ClsCategoria_ProveedorDA.Eliminar(Datos);
        }

        public static ENResultOperation Listar(string Texto_Buscar)
        {

            return ClsCategoria_ProveedorDA.Listar(Texto_Buscar);
        }

        public static ENResultOperation Listar_Filtro(string Texto_Buscar)
        {

            return ClsCategoria_ProveedorDA.Listar_Filtro(Texto_Buscar);
        }
    }
}
