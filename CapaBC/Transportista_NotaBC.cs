using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaBE;
using CapaDA;

namespace CapaBC
{
    class Transportista_NotaBC
    {
    }
    public class ClsTransportista_NotaBC
    {
        public static ENResultOperation Crear(ClsTransportista_NotaBE Datos)
        {
            return ClsTransportista_NotaDA.Crear(Datos);
        }
        public static ENResultOperation Actualizar(ClsTransportista_NotaBE Datos)
        {
            return ClsTransportista_NotaDA.Actualizar(Datos);
        }

        public static ENResultOperation Eliminar(ClsTransportista_NotaBE Datos)
        {
            return ClsTransportista_NotaDA.Eliminar(Datos);
        }

        public static ENResultOperation Listar(string Texto_Buscar)
        {

            return ClsTransportista_NotaDA.Listar(Texto_Buscar);
        }

        public static ENResultOperation Listar_Filtro(string Texto_Buscar, Int32 Transportista_Ide)
        {

            return ClsTransportista_NotaDA.Listar_Filtro(Texto_Buscar, Transportista_Ide);
        }
    }    
}
