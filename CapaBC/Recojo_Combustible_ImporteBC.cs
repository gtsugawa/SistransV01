using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaBE;
using CapaDA;

namespace CapaBC
{
    class Recojo_Combustible_ImporteBC
    {
    }

    public class ClsRecojo_Combustible_ImporteBC
    {
        public static ENResultOperation Crear(ClsRecojo_Combustible_ImporteBE Datos)
        {
            return ClsRecojo_Combustible_ImporteDA.Crear(Datos);
        }
        public static ENResultOperation Actualizar(ClsRecojo_Combustible_ImporteBE Datos)
        {
            return ClsRecojo_Combustible_ImporteDA.Actualizar(Datos);
        }

        public static ENResultOperation Eliminar(ClsRecojo_Combustible_ImporteBE Datos)
        {
            return ClsRecojo_Combustible_ImporteDA.Eliminar(Datos);
        }

        public static ENResultOperation Listar(Int32 Reco_Ide)
        {

            return ClsRecojo_Combustible_ImporteDA.Listar(Reco_Ide);
        }

        public static ENResultOperation Listar_Filtro(Int32 Reco_Ide, Int32 Reco_Ide_Detalle)
        {

            return ClsRecojo_Combustible_ImporteDA.Listar_Filtro(Reco_Ide, Reco_Ide_Detalle);
        }
        public static ENResultOperation Obtener_Registro(Int32 Reco_Ide, Int32 Reco_Ide_Detalle)
        {

            return ClsRecojo_Combustible_ImporteDA.Obtener_Registro(Reco_Ide, Reco_Ide_Detalle);
        }
    }
}
