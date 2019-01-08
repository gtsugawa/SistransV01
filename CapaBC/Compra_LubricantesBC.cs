using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaBE;
using CapaDA;

namespace CapaBC
{
    class Compra_LubricantesBC
    {
    }
    public class ClsCompra_LubricantesBC
    {
        public static ENResultOperation Crear(ClsCompra_LubricantesBE Datos)
        {
            return ClsCompra_LubricantesDA.Crear(Datos);
        }
        public static ENResultOperation Actualizar(ClsCompra_LubricantesBE Datos)
        {
            return ClsCompra_LubricantesDA.Actualizar(Datos);
        }

        public static ENResultOperation Eliminar(ClsCompra_LubricantesBE Datos)
        {
            return ClsCompra_LubricantesDA.Eliminar(Datos);
        }

        public static ENResultOperation Listar(string Texto_Buscar)
        {

            return ClsCompra_LubricantesDA.Listar(Texto_Buscar);
        }
        public static ENResultOperation Buscar_Comprobante(Int32 nComp_Ide)
        {

            return ClsCompra_LubricantesDA.Buscar_Comprobante(nComp_Ide);
        }

        public static ENResultOperation Listar_Filtro(string Texto_Buscar, string Condic_Buscar, DateTime FecIni, DateTime FecFin)
        {

            return ClsCompra_LubricantesDA.Listar_Filtro(Texto_Buscar, Condic_Buscar, FecIni, FecFin);
        }
        public static ENResultOperation Listar_por_Fechas(DateTime Fecha_Inicio, DateTime Fecha_Fin)
        {

            return ClsCompra_LubricantesDA.Listar_por_Fechas(Fecha_Inicio, Fecha_Fin);
        }
    }
}
