using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaBE;
using CapaDA;

namespace CapaBC
{
    class Productos_ConsumoBC
    {
    }

    public class ClsProductos_ConsumoBC
    {
        public static ENResultOperation Crear(ClsProductos_ConsumoBE Datos)
        {
            return ClsProductos_ConsumoDA.Crear(Datos);
        }
        public static ENResultOperation Actualizar(ClsProductos_ConsumoBE Datos)
        {
            return ClsProductos_ConsumoDA.Actualizar(Datos);
        }

        public static ENResultOperation Eliminar(ClsProductos_ConsumoBE Datos)
        {
            return ClsProductos_ConsumoDA.Eliminar(Datos);
        }

        public static ENResultOperation Listar(string Texto_Buscar)
        {

            return ClsProductos_ConsumoDA.Listar(Texto_Buscar);
        }

        public static ENResultOperation Listar_Filtro(string Texto_Buscar, string Condic_Buscar, DateTime FecIni, DateTime FecFin)
        {

            return ClsProductos_ConsumoDA.Listar_Filtro(Texto_Buscar, Condic_Buscar, FecIni, FecFin);
        }
        public static ENResultOperation Listar_por_Fechas(DateTime Fecha_Inicio, DateTime Fecha_Fin)
        {

            return ClsProductos_ConsumoDA.Listar_por_Fechas(Fecha_Inicio, Fecha_Fin);
        }
    }
}
