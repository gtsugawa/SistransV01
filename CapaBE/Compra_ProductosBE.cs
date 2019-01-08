using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaBE
{
    class Compra_ProductosBE
    {
    }
    public class ClsCompra_ProductosBE
    {
        int comp_ide;
        int prov_ide;
        int tipo_doc_ide;
        string comp_serie;
        string comp_numero;
        DateTime comp_fecha_emision;
        DateTime comp_fecha_vencimiento;
        string comp_forma_pago;
        string comp_moneda;
        decimal comp_tcambio;
        string comp_tipo_compra;
        string comp_igv_incluido;
        decimal comp_igv_porcentaje;
        decimal comp_descuento_porcentaje;
        decimal comp_valor_bruto;
        decimal comp_descuento;
        decimal comp_valor_neto;
        decimal comp_igv;
        decimal comp_valor_total;
        string usuario_crea;
        DateTime fecha_crea;
        string usuario_modifica;
        DateTime fecha_modifica;
        string estado;

        public ClsCompra_ProductosBE()
        {

        }

        public int Comp_ide {get; set;}
        public int Prov_ide { get; set; }
        public int Tipo_doc_ide { get; set; }
        public string Comp_serie { get; set; }
        public string Comp_numero { get; set; }
        public DateTime Comp_fecha_emision { get; set; }
        public DateTime Comp_fecha_vencimiento { get; set; }
        public string Comp_forma_pago { get; set; }
        public string Comp_moneda { get; set; }
        public decimal Comp_tcambio { get; set; }
        public string Comp_tipo_compra { get; set; }
        public string Comp_igv_incluido { get; set; }
        public decimal Comp_igv_porcentaje { get; set; }
        public decimal Comp_descuento_porcentaje { get; set; }
        public decimal Comp_valor_bruto { get; set; }
        public decimal Comp_descuento { get; set; }
        public decimal Comp_valor_neto { get; set; }
        public decimal Comp_igv { get; set; }
        public decimal Comp_valor_total { get; set; }
        public string Usuario_crea { get; set; }
        public DateTime Fecha_crea { get; set; }
        public string Usuario_modifica { get; set; }
        public DateTime Fecha_modifica { get; set; }
        public string Estado { get; set; }
    }
}
