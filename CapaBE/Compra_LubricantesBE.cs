using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaBE
{
    class Compra_LubricantesBE
    {
    }
    public class ClsCompra_LubricantesBE
    {
        int comp_ide;
        int prov_ide;
        DateTime comp_fecha;
        string comp_numero;
        string comp_codigo;
        string comp_descripcion;
        string comp_marca;
        string comp_unidad;
        int comp_cantidad;
        decimal comp_importe;
        string comp_moneda;
        decimal comp_tcambio;
        string unidad_salida;
        int unidad_equivalencia;
        decimal unidad_costo;
        decimal cantidad_salida;
        DateTime fecha_inicio_uso;
        int estado;

        public ClsCompra_LubricantesBE()
        {
        }

        public int Comp_ide {get; set;}
        public int Prov_ide { get; set; }
        public DateTime Comp_fecha { get; set; }
        public string Comp_numero { get; set; }
        public string Comp_codigo { get; set; }
        public string Comp_descripcion { get; set; }
        public string Comp_marca { get; set; }
        public string Comp_unidad { get; set; }
        public int Comp_cantidad { get; set; }
        public decimal Comp_importe { get; set; }
        public string Comp_moneda { get; set; }
        public decimal Comp_tcambio { get; set; }
        public string Unidad_salida { get; set; }
        public int Unidad_equivalencia { get; set; }
        public decimal Unidad_costo { get; set; }
        public decimal Cantidad_salida { get; set; }
        public DateTime Fecha_inicio_uso { get; set; }
        public int Estado { get; set; }
    }
}
