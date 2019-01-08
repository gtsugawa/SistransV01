using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaBE;
using CapaDA;

namespace CapaBC
{
    class Compra_ProductosBC
    {
    }
    public class ClsCompra_ProductosBC
    {
        public static ENResultOperation Crear(ClsCompra_ProductosBE Datos)
        {
            return ClsCompra_ProductosDA.Crear(Datos);
        }
        public static ENResultOperation Actualizar(ClsCompra_ProductosBE Datos)
        {
            return ClsCompra_ProductosDA.Actualizar(Datos);
        }

        public static ENResultOperation Eliminar(ClsCompra_ProductosBE Datos)
        {
            return ClsCompra_ProductosDA.Eliminar(Datos);
        }

        public static ENResultOperation Actualiza_Valores(ClsCompra_ProductosBE Datos)
        {
            return ClsCompra_ProductosDA.Actualiza_Valores(Datos);
        }
        public static ENResultOperation Listar(Int32 nComp_Ide)
        {

            return ClsCompra_ProductosDA.Listar(nComp_Ide);
        }
        public static ENResultOperation Buscar_Comprobante(Int32 nComp_Ide)
        {

            return ClsCompra_ProductosDA.Buscar_Comprobante(nComp_Ide);
        }

        public static ENResultOperation Listar_Filtro(string Texto_Buscar, string Condic_Buscar, DateTime FecIni, DateTime FecFin)
        {

            return ClsCompra_ProductosDA.Listar_Filtro(Texto_Buscar, Condic_Buscar, FecIni, FecFin);
        }
        public static ENResultOperation Listar_por_Fechas(DateTime Fecha_Inicio, DateTime Fecha_Fin)
        {

            return ClsCompra_ProductosDA.Listar_por_Fechas(Fecha_Inicio, Fecha_Fin);
        }
    }
}
