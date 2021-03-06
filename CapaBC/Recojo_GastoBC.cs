﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaBE;
using CapaDA;

namespace CapaBC
{
    class Recojo_GastoBC
    {
    }

    public class ClsRecojo_GastoBC
    {
        public static ENResultOperation Crear(ClsRecojo_GastoBE Datos)
        {
            return ClsRecojo_GastoDA.Crear(Datos);
        }
        public static ENResultOperation Actualizar(ClsRecojo_GastoBE Datos)
        {
            return ClsRecojo_GastoDA.Actualizar(Datos);
        }

        public static ENResultOperation Eliminar(ClsRecojo_GastoBE Datos)
        {
            return ClsRecojo_GastoDA.Eliminar(Datos);
        }

        public static ENResultOperation Listar(Int32 Reco_Ide)
        {

            return ClsRecojo_GastoDA.Listar(Reco_Ide);
        }

        public static ENResultOperation Listar_Filtro(Int32 Reco_Ide, Int32 Reco_Ide_Detalle)
        {

            return ClsRecojo_GastoDA.Listar_Filtro(Reco_Ide, Reco_Ide_Detalle);
        }

        public static ENResultOperation Ultimo_Item(Int32 Reco_Ide)
        {

            return ClsRecojo_GastoDA.Ultimo_Item(Reco_Ide);
        }

        public static ENResultOperation Obtener_Registro(Int32 Reco_Ide, Int32 Reco_Ide_Detalle)
        {

            return ClsRecojo_GastoDA.Obtener_Registro(Reco_Ide, Reco_Ide_Detalle);
        }
    }
}
