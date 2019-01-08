using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaBE;
using CapaDA;

namespace CapaBC
{
    class Transportista_Girar_ABC
    {
    }
    public class ClsTransportista_Girar_ABC
    {
        public static ENResultOperation Crear(ClsTransportista_Girar_ABE Datos)
        {
            return ClsTransportista_Girar_ADA.Crear(Datos);
        }
        public static ENResultOperation Actualizar(ClsTransportista_Girar_ABE Datos)
        {
            return ClsTransportista_Girar_ADA.Actualizar(Datos);
        }

        public static ENResultOperation Eliminar(ClsTransportista_Girar_ABE Datos)
        {
            return ClsTransportista_Girar_ADA.Eliminar(Datos);
        }

        public static ENResultOperation Listar(string Texto_Buscar)
        {

            return ClsTransportista_Girar_ADA.Listar(Texto_Buscar);
        }

        public static ENResultOperation Listar_Filtro(string Texto_Buscar)
        {

            return ClsTransportista_Girar_ADA.Listar_Filtro(Texto_Buscar);
        }
    }    
}
