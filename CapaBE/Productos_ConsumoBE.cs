using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaBE
{
    class Productos_ConsumoBE
    {
    }
    public class ClsProductos_ConsumoBE
    {
        int cons_ide;
        DateTime cons_fecha;
        int tran_ide;
        int tran_vehi_ide;
        int comp_ide;
        int comp_detalle_ide;
        decimal cons_cantidad;
        int estado;
        
        public ClsProductos_ConsumoBE()
        {
        }

        public int Cons_ide { get; set; }
        public DateTime Cons_fecha { get; set; }
        public int Tran_ide { get; set; }
        public int Tran_vehi_ide { get; set; }
        public int Comp_ide { get; set; }
        public int Comp_detalle_ide { get; set; }
        public decimal Cons_cantidad { get; set; }
        public int Estado { get; set; }

    }
}
