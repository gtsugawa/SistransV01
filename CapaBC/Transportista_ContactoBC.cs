using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaBE;
using CapaDA;

namespace CapaBC
{
    class Transportista_ContactoBC
    {
    }

    public class ClsTransportista_ContactoBC
    {
        public static ENResultOperation Crear(ClsTransportista_ContactoBE Datos)
        {
            return ClsTransportista_ContactoDA.Crear(Datos);
        }
        public static ENResultOperation Actualizar(ClsTransportista_ContactoBE Datos)
        {
            return ClsTransportista_ContactoDA.Actualizar(Datos);
        }

        public static ENResultOperation Eliminar(ClsTransportista_ContactoBE Datos)
        {
            return ClsTransportista_ContactoDA.Eliminar(Datos);
        }

        public static ENResultOperation Listar(Int32 Tran_Ide)
        {

            return ClsTransportista_ContactoDA.Listar(Tran_Ide);
        }

        public static ENResultOperation Listar_Filtro(string Texto_Buscar, Int32 Transportista_Ide)
        {

            return ClsTransportista_ContactoDA.Listar_Filtro(Texto_Buscar,Transportista_Ide);
        }
        public static ENResultOperation Buscar_Por_Documento(string Nrodoc, Int32 Transportista_Ide)
        {

            return ClsTransportista_ContactoDA.Buscar_Por_Documento(Nrodoc, Transportista_Ide);
        }
    }    
}
