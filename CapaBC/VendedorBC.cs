using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaBE;
using CapaDA;

namespace CapaBC
{
    class VendedorBC
    {
    }
    public class ClsVendedorBC
    {
        public static ENResultOperation Crear(ClsVendedorBE Datos)
        {
            return ClsVendedorDA.Crear(Datos);
        }
        public static ENResultOperation Actualizar(ClsVendedorBE Datos)
        {
            return ClsVendedorDA.Actualizar(Datos);
        }

        public static ENResultOperation Eliminar(ClsVendedorBE Datos)
        {
            return ClsVendedorDA.Eliminar(Datos);
        }

        public static ENResultOperation Listar(string Texto_Buscar)
        {

            return ClsVendedorDA.Listar(Texto_Buscar);
        }

        public static ENResultOperation Listar_Filtro(string Texto_Buscar)
        {

            return ClsVendedorDA.Listar_Filtro(Texto_Buscar);
        }
    }

}
