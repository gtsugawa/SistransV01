using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDA;
using CapaBE;


namespace CapaBC
{
    class Transportista_Condicion_ComercialBC
    {
    }
    public class ClsTransportista_Condicion_ComercialBC
    {
        public static ENResultOperation Crear(ClsTransportista_Condicion_ComercialBE Datos)
        {
            return ClsTransportista_Condicion_ComercialDA.Crear(Datos);
        }
        public static ENResultOperation Actualizar(ClsTransportista_Condicion_ComercialBE Datos)
        {
            return ClsTransportista_Condicion_ComercialDA.Actualizar(Datos);
        }

        public static ENResultOperation Eliminar(ClsTransportista_Condicion_ComercialBE Datos)
        {
            return ClsTransportista_Condicion_ComercialDA.Eliminar(Datos);
        }

        public static ENResultOperation Listar(string Texto_Buscar)
        {

            return ClsTransportista_Condicion_ComercialDA.Listar(Texto_Buscar);
        }

        public static ENResultOperation Listar_Filtro(string Texto_Buscar)
        {

            return ClsTransportista_Condicion_ComercialDA.Listar_Filtro(Texto_Buscar);
        }
    }    
}
