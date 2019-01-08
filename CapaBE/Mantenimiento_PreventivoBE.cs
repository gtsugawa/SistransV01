using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaBE
{
    class Mantenimiento_PreventivoBE
    {
    }

    public class ClsMantenimiento_PreventivoBE
    {
        int mant_ide;
        int tran_ide;
        int tran_vehi_ide;
        int mant_kilometraje;
        DateTime mant_fecha;
        string mant_solicitado;
        string mant_requerimiento;
        string mant_responsable;
        string mant_detalle;
        string mant_servicio;
        decimal mant_costo_igv;
        string mant_ruc;
        string mant_proveedor;
        DateTime mant_fecha_factura;
        string mant_numero_factura;
        string mant_modo_pago;
        string mant_transferido;
        string mant_contacto;
        string mant_estado;
        string mant_observaciones;
        int mant_grupo_ide;
        int mant_actividad_ide;
        DateTime mant_fecha_crea;
        string mant_usuario_crea;
        DateTime mant_fecha_act;
        string mant_usuario_act;
        public ClsMantenimiento_PreventivoBE()
        {

        }

        public int Mant_ide { get; set; }
        public int Tran_ide { get; set; }
        public int Tran_vehi_ide { get; set; }
        public int Mant_kilometraje { get; set; }
        public DateTime Mant_fecha { get; set; }
        public string Mant_solicitado { get; set; }
        public string Mant_requerimiento { get; set; }
        public string Mant_responsable { get; set; }
        public string Mant_detalle { get; set; }
        public string Mant_servicio { get; set; }
        public decimal Mant_costo_igv { get; set; }
        public string Mant_ruc { get; set; }
        public string Mant_proveedor { get; set; }
        public DateTime Mant_fecha_factura { get; set; }
        public string Mant_numero_factura { get; set; }
        public string Mant_modo_pago { get; set; }
        public string Mant_transferido { get; set; }
        public string Mant_contacto { get; set; }
        public string Mant_estado { get; set; }
        public string Mant_observaciones { get; set; }
        public int Mant_grupo_ide { get; set; }
        public int Mant_actividad_ide { get; set; }
        public DateTime Mant_fecha_crea { get; set; }
        public string Mant_usuario_crea { get; set; }
        public DateTime Mant_fecha_act { get; set; }
        public string Mant_usuario_act { get; set; }
    }
}