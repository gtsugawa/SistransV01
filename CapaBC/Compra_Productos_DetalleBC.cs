using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaBE;
using CapaDA;

namespace CapaBC
{
    class Compra_Productos_DetalleBC
    {
    }
    public class ClsCompra_Productos_DetalleBC
    {
        public static ENResultOperation Crear(ClsCompra_Productos_DetalleBE Datos)
        {
            return ClsCompra_Productos_DetalleDA.Crear(Datos);
        }
        public static ENResultOperation Actualizar(ClsCompra_Productos_DetalleBE Datos)
        {
            return ClsCompra_Productos_DetalleDA.Actualizar(Datos);
        }

        public static ENResultOperation Eliminar(ClsCompra_Productos_DetalleBE Datos)
        {
            return ClsCompra_Productos_DetalleDA.Eliminar(Datos);
        }

        public static ENResultOperation Obtener_Registro(Int32 nComp_Ide, Int32 nComp_Detalle_ide)
        {

            return ClsCompra_Productos_DetalleDA.Obtener_Registro(nComp_Ide,nComp_Detalle_ide);
        }
        public static ENResultOperation Listar(Int32 nComp_Ide)
        {

            return ClsCompra_Productos_DetalleDA.Listar(nComp_Ide);
        }
        public static ENResultOperation Listar_Pendientes()
        {

            return ClsCompra_Productos_DetalleDA.Listar_Pendientes();
        }
        public static ENResultOperation Buscar_Comprobante(Int32 nComp_Ide)
        {

            return ClsCompra_Productos_DetalleDA.Buscar_Comprobante(nComp_Ide);
        }

        public static ENResultOperation Listar_Filtro(string Texto_Buscar, string Condic_Buscar, DateTime FecIni, DateTime FecFin)
        {

            return ClsCompra_Productos_DetalleDA.Listar_Filtro(Texto_Buscar, Condic_Buscar, FecIni, FecFin);
        }
        public static ENResultOperation Listar_por_Fechas(DateTime Fecha_Inicio, DateTime Fecha_Fin)
        {

            return ClsCompra_Productos_DetalleDA.Listar_por_Fechas(Fecha_Inicio, Fecha_Fin);
        }
    }
}
