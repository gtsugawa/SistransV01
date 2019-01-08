using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaBE;
using CapaDA;

namespace CapaBC
{
    class Transportista_VehiculoBC
    {
    }
    public class ClsTransportista_VehiculoBC
    {
        public static ENResultOperation Crear(ClsTransportista_VehiculoBE Datos)
        {
            return ClsTransportista_VehiculoDA.Crear(Datos);
        }
        public static ENResultOperation Actualizar(ClsTransportista_VehiculoBE Datos)
        {
            return ClsTransportista_VehiculoDA.Actualizar(Datos);
        }

        public static ENResultOperation Eliminar(ClsTransportista_VehiculoBE Datos)
        {
            return ClsTransportista_VehiculoDA.Eliminar(Datos);
        }

        public static ENResultOperation Listar(string Texto_Buscar)
        {

            return ClsTransportista_VehiculoDA.Listar(Texto_Buscar);
        }

        public static ENResultOperation Listar_Filtro(string Texto_Buscar, Int32 Transportista_Ide)
        {

            return ClsTransportista_VehiculoDA.Listar_Filtro(Texto_Buscar, Transportista_Ide);
        }

        public static ENResultOperation Obtener_Vehiculo(string Vehiculo_Ide, string Transportista_Ide)
        {

            return ClsTransportista_VehiculoDA.Obtener_Vehiculo(Vehiculo_Ide, Transportista_Ide);
        }
    }    
}
