using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaBE;
using CapaDA;


namespace CapaBC
{
    class Recojo_Recargo_CargaBC
    {
    }

    public class ClsRecojo_Recargo_CargaBC
    {
        public static ENResultOperation Crear(ClsRecojo_Recargo_CargaBE Datos)
        {
            return ClsRecojo_Recargo_CargaDA.Crear(Datos);
        }
        public static ENResultOperation Actualizar(ClsRecojo_Recargo_CargaBE Datos)
        {
            return ClsRecojo_Recargo_CargaDA.Actualizar(Datos);
        }

        public static ENResultOperation Eliminar(ClsRecojo_Recargo_CargaBE Datos)
        {
            return ClsRecojo_Recargo_CargaDA.Eliminar(Datos);
        }

        public static ENResultOperation Listar(Int32 Reco_Ide)
        {

            return ClsRecojo_Recargo_CargaDA.Listar(Reco_Ide);
        }

        public static ENResultOperation Listar_Filtro(Int32 Reco_Ide, Int32 Reco_Ide_Detalle)
        {

            return ClsRecojo_Recargo_CargaDA.Listar_Filtro(Reco_Ide, Reco_Ide_Detalle);
        }

        public static ENResultOperation Ultimo_Item(Int32 Reco_Ide)
        {

            return ClsRecojo_Recargo_CargaDA.Ultimo_Item(Reco_Ide);
        }

        public static ENResultOperation Obtener_Registro(Int32 Reco_Ide, Int32 Reco_Ide_Detalle)
        {

            return ClsRecojo_Recargo_CargaDA.Obtener_Registro(Reco_Ide, Reco_Ide_Detalle);
        }
    }
}
