using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaBE;
using CapaDA;

namespace CapaBC
{
    class Factura_Carga_Detalle_RecojoBC
    {
    }

    public class ClsFactura_Carga_Detalle_RecojoBC
    {
        public static ENResultOperation Crear(ClsFactura_Carga_Detalle_RecojoBE Datos)
        {
            return ClsFactura_Carga_Detalle_RecojoDA.Crear(Datos);
        }
        public static ENResultOperation Actualizar(ClsFactura_Carga_Detalle_RecojoBE Datos)
        {
            return ClsFactura_Carga_Detalle_RecojoDA.Actualizar(Datos);
        }

        public static ENResultOperation Eliminar(ClsFactura_Carga_Detalle_RecojoBE Datos)
        {
            return ClsFactura_Carga_Detalle_RecojoDA.Eliminar(Datos);
        }

        public static ENResultOperation Listar(int Texto_Buscar)
        {

            return ClsFactura_Carga_Detalle_RecojoDA.Listar(Texto_Buscar);
        }

        public static ENResultOperation Listar_Filtro(string Texto_Buscar)
        {

            return ClsFactura_Carga_Detalle_RecojoDA.Listar_Filtro(Texto_Buscar);
        }
    }
}
