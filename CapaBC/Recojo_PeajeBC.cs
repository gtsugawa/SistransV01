using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaBE;
using CapaDA;

namespace CapaBC
{
    class Recojo_PeajeBC
    {
    }
    public class ClsRecojo_PeajeBC
    {
        public static ENResultOperation Crear(ClsRecojo_PeajeBE Datos)
        {
            return ClsRecojo_PeajeDA.Crear(Datos);
        }
        public static ENResultOperation Actualizar(ClsRecojo_PeajeBE Datos)
        {
            return ClsRecojo_PeajeDA.Actualizar(Datos);
        }

        public static ENResultOperation Eliminar(ClsRecojo_PeajeBE Datos)
        {
            return ClsRecojo_PeajeDA.Eliminar(Datos);
        }

        public static ENResultOperation Listar(Int32 Reco_Ide)
        {

            return ClsRecojo_PeajeDA.Listar(Reco_Ide);
        }

        public static ENResultOperation Listar_Filtro(Int32 Reco_Ide, Int32 Reco_Ide_Detalle)
        {

            return ClsRecojo_PeajeDA.Listar_Filtro(Reco_Ide, Reco_Ide_Detalle);
        }

        public static ENResultOperation Ultimo_Item(Int32 Reco_Ide)
        {

            return ClsRecojo_PeajeDA.Ultimo_Item(Reco_Ide);
        }

        public static ENResultOperation Obtener_Registro(Int32 Reco_Ide, Int32 Reco_Ide_Detalle)
        {

            return ClsRecojo_PeajeDA.Obtener_Registro(Reco_Ide, Reco_Ide_Detalle);
        }
    }
}
