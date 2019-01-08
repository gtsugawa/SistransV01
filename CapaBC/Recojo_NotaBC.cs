using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaBE;
using CapaDA;

namespace CapaBC
{
    class Recojo_NotaBC
    {
    }

    public class ClsRecojo_NotaBC
    {
        public static ENResultOperation Crear(ClsRecojo_NotaBE Datos)
        {
            return ClsRecojo_NotaDA.Crear(Datos);
        }
        public static ENResultOperation Actualizar(ClsRecojo_NotaBE Datos)
        {
            return ClsRecojo_NotaDA.Actualizar(Datos);
        }

        public static ENResultOperation Eliminar(ClsRecojo_NotaBE Datos)
        {
            return ClsRecojo_NotaDA.Eliminar(Datos);
        }

        public static ENResultOperation Listar(Int32 Reco_Ide)
        {

            return ClsRecojo_NotaDA.Listar(Reco_Ide);
        }

        public static ENResultOperation Listar_Filtro(Int32 Reco_Ide, Int32 Reco_Ide_Detalle)
        {

            return ClsRecojo_NotaDA.Listar_Filtro(Reco_Ide, Reco_Ide_Detalle);
        }

        public static ENResultOperation Obtener_Registro(Int32 Reco_Ide, Int32 Reco_Ide_Detalle)
        {

            return ClsRecojo_NotaDA.Obtener_Registro(Reco_Ide, Reco_Ide_Detalle);
        }
    }
}
