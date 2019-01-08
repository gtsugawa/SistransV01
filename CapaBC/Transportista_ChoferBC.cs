using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDA;
using CapaBE;

namespace CapaBC
{
    class Transportista_ChoferBC
    {
    }
    public class ClsTransportista_ChoferBC
    {
        public static ENResultOperation Crear(ClsTransportista_ChoferBE Datos)
        {
            return ClsTransportista_ChoferDA.Crear(Datos);
        }
        public static ENResultOperation Actualizar(ClsTransportista_ChoferBE Datos)
        {
            return ClsTransportista_ChoferDA.Actualizar(Datos);
        }

        public static ENResultOperation Eliminar(ClsTransportista_ChoferBE Datos)
        {
            return ClsTransportista_ChoferDA.Eliminar(Datos);
        }

        public static ENResultOperation Listar(string Texto_Buscar)
        {

            return ClsTransportista_ChoferDA.Listar(Texto_Buscar);
        }

        public static ENResultOperation Listar_Filtro(string Texto_Buscar, Int32 Transportista_Ide)
        {

            return ClsTransportista_ChoferDA.Listar_Filtro(Texto_Buscar, Transportista_Ide);
        }

        public static ENResultOperation Consultar_Ide(Int32 Transportista_Ide, Int32 Chofer_Ide)
        {

            return ClsTransportista_ChoferDA.Consultar_Ide(Transportista_Ide, Chofer_Ide);
        }
    }    
}
