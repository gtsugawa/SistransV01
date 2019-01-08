using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaBE
{
    class Consumo_LubricanteBE
    {
    }
    public class ClsConsumo_LubricanteBE
    {
        int	cons_ide;
        int	comp_ide;
        DateTime	cons_fecha;
        string	cons_numero;
        int	tran_ide;
        int	tran_vehi_ide;
        int mant_grupo_ide;
        int mant_actividades_ide;
        decimal cons_cantidad;
        string	cons_unidad;
        decimal	cons_importe;
        string	cons_solicitado;
        string	cons_autorizado;
        string	cons_realizado;
        string	cons_observacion;
        string	cons_estado;

        public ClsConsumo_LubricanteBE()
        {
        }

        public int Cons_ide { get; set; }
        public int Comp_ide { get; set; }
        public DateTime Cons_fecha { get; set; }
        public string Cons_numero { get; set; }
        public int Tran_ide { get; set; }
        public int Tran_vehi_ide { get; set; }
        public int Mant_grupo_ide { get; set; }
        public int Mant_actividades_ide { get; set; }
        public decimal Cons_cantidad { get; set; }
        public string Cons_unidad { get; set; }
        public decimal Cons_importe { get; set; }
        public string Cons_solicitado { get; set; }
        public string Cons_autorizado { get; set; }
        public string Cons_realizado { get; set; }
        public string Cons_observacion { get; set; }
        public string Cons_estado { get; set; }
    }
}
