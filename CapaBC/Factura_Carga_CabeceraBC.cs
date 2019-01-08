using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaBE;
using CapaDA;

namespace CapaBC
{
    class Factura_Carga_CabeceraBC
    {
    }

    public class ClsFactura_Carga_CabeceraBC
    {
        public static ENResultOperation Crear(ClsFactura_Carga_CabeceraBE Datos)
        {
            return ClsFactura_Carga_CabeceraDA.Crear(Datos);
        }
        public static ENResultOperation Actualizar(ClsFactura_Carga_CabeceraBE Datos)
        {
            return ClsFactura_Carga_CabeceraDA.Actualizar(Datos);
        }

        public static ENResultOperation Eliminar(ClsFactura_Carga_CabeceraBE Datos)
        {
            return ClsFactura_Carga_CabeceraDA.Eliminar(Datos);
        }

        public static ENResultOperation Listar(string Texto_Buscar)
        {

            return ClsFactura_Carga_CabeceraDA.Listar(Texto_Buscar);
        }
        public static ENResultOperation Buscar_Id(Int32 Fact_Ide)
        {

            return ClsFactura_Carga_CabeceraDA.Buscar_Id(Fact_Ide);
        }

        public static ENResultOperation Listar_Filtro(string Texto_Buscar, string Condicion_Buscar)
        {

            return ClsFactura_Carga_CabeceraDA.Listar_Filtro(Texto_Buscar, Condicion_Buscar);
        }
    }
}
