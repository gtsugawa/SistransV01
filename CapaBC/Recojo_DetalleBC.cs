using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaBE;
using CapaDA;

namespace CapaBC
{
    class Recojo_DetalleBC
    {
    }
    public class ClsRecojo_DetalleBC
    {
        public static ENResultOperation Crear(clsRecojo_DetalleBE Datos)
        {
            return clsRecojo_DetalleDA.Crear(Datos);
        }
        public static ENResultOperation Actualizar(clsRecojo_DetalleBE Datos)
        {
            return clsRecojo_DetalleDA.Actualizar(Datos);
        }

        public static ENResultOperation Eliminar(clsRecojo_DetalleBE Datos)
        {
            return clsRecojo_DetalleDA.Eliminar(Datos);
        }

        public static ENResultOperation Listar(Int32 Reco_Ide)
        {

            return clsRecojo_DetalleDA.Listar(Reco_Ide);
        }

        public static ENResultOperation Listar_Filtro(Int32 Reco_Ide, Int32 Reco_Ide_Detalle)
        {

            return clsRecojo_DetalleDA.Listar_Filtro(Reco_Ide, Reco_Ide_Detalle);
        }

        public static ENResultOperation Listar_PuntoReparto(Int32 Reco_Ide)
        {

            return clsRecojo_DetalleDA.Listar_PuntoReparto(Reco_Ide);
        }
        public static ENResultOperation Ultimo_Item(Int32 Reco_Ide)
        {

            return clsRecojo_DetalleDA.Ultimo_Item(Reco_Ide);
        }
    }
}
