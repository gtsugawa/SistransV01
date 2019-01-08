using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaBE;
using CapaDA;

namespace CapaBC
{
    class Proveedor_ContactoBC
    {
    }

    public class ClsProveedor_ContactoBC
    {
        public static ENResultOperation Crear(ClsProveedor_ContactoBE Datos)
        {
            return ClsProveedor_ContactoDA.Crear(Datos);
        }
        public static ENResultOperation Actualizar(ClsProveedor_ContactoBE Datos)
        {
            return ClsProveedor_ContactoDA.Actualizar(Datos);
        }

        public static ENResultOperation Eliminar(ClsProveedor_ContactoBE Datos)
        {
            return ClsProveedor_ContactoDA.Eliminar(Datos);
        }

        public static ENResultOperation Listar(string Texto_Buscar)
        {

            return ClsProveedor_ContactoDA.Listar(Texto_Buscar);
        }

        public static ENResultOperation Listar_Filtro(Int32 Prov_Ide)
        {

            return ClsProveedor_ContactoDA.Listar_Filtro(Prov_Ide);
        }
    }
}
