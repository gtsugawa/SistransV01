using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaBE
{
    class Compra_Productos_DetalleBE
    {
    }
    public class ClsCompra_Productos_DetalleBE
    {
        int comp_ide;
        int comp_detalle_ide;
        string comp_codigo;
        string comp_descripcion;
        string comp_unidad_compra;
        string comp_unidad_salida;
        int comp_equivalencia;
        decimal comp_valor_unitario;
        decimal cantidad_compra;
        decimal cantidad_salida;
        int estado;

        public ClsCompra_Productos_DetalleBE()
        {
        }

        public int Comp_ide { get; set; }
        public int Comp_detalle_ide { get; set; }
        public string Comp_codigo { get; set; }
        public string Comp_descripcion { get; set; }
        public string Comp_unidad_compra { get; set; }
        public string Comp_unidad_salida { get; set; }
        public int Comp_equivalencia { get; set; }
        public decimal Comp_valor_unitario { get; set; }
        public decimal Cantidad_compra { get; set; }
        public decimal Cantidad_salida { get; set; }
        public int Estado { get; set; }

    }
}
