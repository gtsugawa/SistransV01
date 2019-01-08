using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaBE;
using CapaDA;

namespace CapaBC
{
    class Recojo_AyudanteBC
    {
    }
    public class ClsRecojo_AyudanteBC
    {
        public static ENResultOperation Crear(ClsRecojo_AyudanteBE Datos)
        {
            return ClsRecojo_AyudanteDA.Crear(Datos);
        }
        public static ENResultOperation Actualizar(ClsRecojo_AyudanteBE Datos)
        {
            return ClsRecojo_AyudanteDA.Actualizar(Datos);
        }

        public static ENResultOperation Eliminar(ClsRecojo_AyudanteBE Datos)
        {
            return ClsRecojo_AyudanteDA.Eliminar(Datos);
        }

        public static ENResultOperation Listar(Int32 Reco_Ide)
        {

            return ClsRecojo_AyudanteDA.Listar(Reco_Ide);
        }

        public static ENResultOperation Listar_Filtro(Int32 Reco_Ide, Int32 Reco_Ide_Detalle)
        {

            return ClsRecojo_AyudanteDA.Listar_Filtro(Reco_Ide, Reco_Ide_Detalle);
        }

        public static ENResultOperation Obtener_Registro(Int32 Reco_Ide, Int32 Reco_Ide_Detalle)
        {

            return ClsRecojo_AyudanteDA.Obtener_Registro(Reco_Ide, Reco_Ide_Detalle);
        }
    }
}
