using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaBE;
using CapaDA;

namespace CapaBC
{
    class Recojo_Apoyo_CabeceraBC
    {
    }

    public class ClsRecojo_Apoyo_CabeceraBC
    {
        public static ENResultOperation Crear(ClsRecojo_Apoyo_CabeceraBE Datos)
        {
            return ClsRecojo_Apoyo_CabeceraDA.Crear(Datos);
        }
        public static ENResultOperation Actualizar(ClsRecojo_Apoyo_CabeceraBE Datos)
        {
            return ClsRecojo_Apoyo_CabeceraDA.Actualizar(Datos);
        }

        public static ENResultOperation Eliminar(ClsRecojo_Apoyo_CabeceraBE Datos)
        {
            return ClsRecojo_Apoyo_CabeceraDA.Eliminar(Datos);
        }

        public static ENResultOperation Listar(Int32 Reco_Ide)
        {

            return ClsRecojo_Apoyo_CabeceraDA.Listar(Reco_Ide);
        }

        public static ENResultOperation Listar_Filtro(Int32 Reco_Ide, Int32 Reco_Ide_Detalle)
        {

            return ClsRecojo_Apoyo_CabeceraDA.Listar_Filtro(Reco_Ide, Reco_Ide_Detalle);
        }

        public static ENResultOperation Ultimo_Item(Int32 Reco_Ide)
        {

            return ClsRecojo_Apoyo_CabeceraDA.Ultimo_Item(Reco_Ide);
        }

        public static ENResultOperation Obtener_Registro(Int32 Reco_Ide, Int32 Reco_Ide_Detalle)
        {

            return ClsRecojo_Recargo_CargaDA.Obtener_Registro(Reco_Ide, Reco_Ide_Detalle);
        }
    }
}
