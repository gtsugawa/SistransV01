using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaBE
{
    class Factura_Carga_CabeceraBE
    {
    }

    public class ClsFactura_Carga_CabeceraBE
    {
        int fact_ide;
        string serie_factura_numero;
        int fact_factura_numero;
        string fact_moneda;
        DateTime fact_fecha_emision;
        DateTime fact_fecha_vencimiento;
        string fact_tipo_facturacion;
        string fact_tipo_precio;
        int clie_ide;
        int vend_ide;
        string fact_direccion;
        int loca_ide;
        int for_pag_ide;
        int conc_ide;
        string fact_tipo_documento;
        string serie_documento_numero;
        int fact_documento_numero;
        string fact_documento_numero_no_facturacion;
        DateTime fact_fecha_documento;
        Byte fact_documento_no_existe;
        string fact_estado;
        int fact_estado_digitacion;
        DateTime fact_fechainac;
        double fact_valor_total_afecto;
        double fact_valor_total_inafecto;
        double fact_impuesto;
        double fact_redondeo;
        double fact_porcentaje_impuesto;
        int fact_numero_item;
        string fact_monto_letras;
        int pla_cta_ide;
        int tipo_doc_ide;
        double fact_venta_local;
        double fact_venta_dolar;
        double fact_venta_inafecto_local;
        double fact_venta_inafecto_dolar;
        double fact_impuesto_local;
        double fact_impuesto_dolar;
        double fact_redondeo_local;
        double fact_redondeo_dolar;
        double fact_tipo_cambio;
        string fact_concepto;
        string fact_precio_incluye_impuesto;
        int fact_numero_asiento;
        int veces;
        int fact_automatico;
        string usuario;

        public ClsFactura_Carga_CabeceraBE()
        {
        }

        public ClsFactura_Carga_CabeceraBE(int fact_ide, string serie_factura_numero, int fact_factura_numero, string fact_moneda, DateTime fact_fecha_emision, DateTime fact_fecha_vencimiento, string fact_tipo_facturacion, string fact_tipo_precio, int clie_ide, int vend_ide, string fact_direccion, int loca_ide, int for_pag_ide, int conc_ide, string fact_tipo_documento, string serie_documento_numero, int fact_documento_numero, string fact_documento_numero_no_facturacion, DateTime fact_fecha_documento, byte fact_documento_no_existe, string fact_estado, int fact_estado_digitacion, DateTime fact_fechainac, double fact_valor_total_afecto, double fact_valor_total_inafecto, double fact_impuesto, double fact_redondeo, double fact_porcentaje_impuesto, int fact_numero_item, string fact_monto_letras, int pla_cta_ide, int tipo_doc_ide, double fact_venta_local, double fact_venta_dolar, double fact_venta_inafecto_local, double fact_venta_inafecto_dolar, double fact_impuesto_local, double fact_impuesto_dolar, double fact_redondeo_local, double fact_redondeo_dolar, double fact_tipo_cambio, string fact_concepto, string fact_precio_incluye_impuesto, int fact_numero_asiento, int veces, int fact_automatico, string usuario)
        {
            this.fact_ide = fact_ide;
            this.serie_factura_numero = serie_factura_numero;
            this.fact_factura_numero = fact_factura_numero;
            this.fact_moneda = fact_moneda;
            this.fact_fecha_emision = fact_fecha_emision;
            this.fact_fecha_vencimiento = fact_fecha_vencimiento;
            this.fact_tipo_facturacion = fact_tipo_facturacion;
            this.fact_tipo_precio = fact_tipo_precio;
            this.clie_ide = clie_ide;
            this.vend_ide = vend_ide;
            this.fact_direccion = fact_direccion;
            this.loca_ide = loca_ide;
            this.for_pag_ide = for_pag_ide;
            this.conc_ide = conc_ide;
            this.fact_tipo_documento = fact_tipo_documento;
            this.serie_documento_numero = serie_documento_numero;
            this.fact_documento_numero = fact_documento_numero;
            this.fact_documento_numero_no_facturacion = fact_documento_numero_no_facturacion;
            this.fact_fecha_documento = fact_fecha_documento;
            this.fact_documento_no_existe = fact_documento_no_existe;
            this.fact_estado = fact_estado;
            this.fact_estado_digitacion = fact_estado_digitacion;
            this.fact_fechainac = fact_fechainac;
            this.fact_valor_total_afecto = fact_valor_total_afecto;
            this.fact_valor_total_inafecto = fact_valor_total_inafecto;
            this.fact_impuesto = fact_impuesto;
            this.fact_redondeo = fact_redondeo;
            this.fact_porcentaje_impuesto = fact_porcentaje_impuesto;
            this.fact_numero_item = fact_numero_item;
            this.fact_monto_letras = fact_monto_letras;
            this.pla_cta_ide = pla_cta_ide;
            this.tipo_doc_ide = tipo_doc_ide;
            this.fact_venta_local = fact_venta_local;
            this.fact_venta_dolar = fact_venta_dolar;
            this.fact_venta_inafecto_local = fact_venta_inafecto_local;
            this.fact_venta_inafecto_dolar = fact_venta_inafecto_dolar;
            this.fact_impuesto_local = fact_impuesto_local;
            this.fact_impuesto_dolar = fact_impuesto_dolar;
            this.fact_redondeo_local = fact_redondeo_local;
            this.fact_redondeo_dolar = fact_redondeo_dolar;
            this.fact_tipo_cambio = fact_tipo_cambio;
            this.fact_concepto = fact_concepto;
            this.fact_precio_incluye_impuesto = fact_precio_incluye_impuesto;
            this.fact_numero_asiento = fact_numero_asiento;
            this.veces = veces;
            this.fact_automatico = fact_automatico;
            this.usuario = usuario;
        }

        public int Fact_ide
        {
            get
            {
                return fact_ide;
            }

            set
            {
                fact_ide = value;
            }
        }

        public string Serie_factura_numero
        {
            get
            {
                return serie_factura_numero;
            }

            set
            {
                serie_factura_numero = value;
            }
        }

        public int Fact_factura_numero
        {
            get
            {
                return fact_factura_numero;
            }

            set
            {
                fact_factura_numero = value;
            }
        }

        public string Fact_moneda
        {
            get
            {
                return fact_moneda;
            }

            set
            {
                fact_moneda = value;
            }
        }

        public DateTime Fact_fecha_emision
        {
            get
            {
                return fact_fecha_emision;
            }

            set
            {
                fact_fecha_emision = value;
            }
        }

        public DateTime Fact_fecha_vencimiento
        {
            get
            {
                return fact_fecha_vencimiento;
            }

            set
            {
                fact_fecha_vencimiento = value;
            }
        }

        public string Fact_tipo_facturacion
        {
            get
            {
                return fact_tipo_facturacion;
            }

            set
            {
                fact_tipo_facturacion = value;
            }
        }

        public string Fact_tipo_precio
        {
            get
            {
                return fact_tipo_precio;
            }

            set
            {
                fact_tipo_precio = value;
            }
        }

        public int Clie_ide
        {
            get
            {
                return clie_ide;
            }

            set
            {
                clie_ide = value;
            }
        }

        public int Vend_ide
        {
            get
            {
                return vend_ide;
            }

            set
            {
                vend_ide = value;
            }
        }

        public string Fact_direccion
        {
            get
            {
                return fact_direccion;
            }

            set
            {
                fact_direccion = value;
            }
        }

        public int Loca_ide
        {
            get
            {
                return loca_ide;
            }

            set
            {
                loca_ide = value;
            }
        }

        public int For_pag_ide
        {
            get
            {
                return for_pag_ide;
            }

            set
            {
                for_pag_ide = value;
            }
        }

        public int Conc_ide
        {
            get
            {
                return conc_ide;
            }

            set
            {
                conc_ide = value;
            }
        }

        public string Fact_tipo_documento
        {
            get
            {
                return fact_tipo_documento;
            }

            set
            {
                fact_tipo_documento = value;
            }
        }

        public string Serie_documento_numero
        {
            get
            {
                return serie_documento_numero;
            }

            set
            {
                serie_documento_numero = value;
            }
        }

        public int Fact_documento_numero
        {
            get
            {
                return fact_documento_numero;
            }

            set
            {
                fact_documento_numero = value;
            }
        }

        public string Fact_documento_numero_no_facturacion
        {
            get
            {
                return fact_documento_numero_no_facturacion;
            }

            set
            {
                fact_documento_numero_no_facturacion = value;
            }
        }

        public DateTime Fact_fecha_documento
        {
            get
            {
                return fact_fecha_documento;
            }

            set
            {
                fact_fecha_documento = value;
            }
        }

        public byte Fact_documento_no_existe
        {
            get
            {
                return fact_documento_no_existe;
            }

            set
            {
                fact_documento_no_existe = value;
            }
        }

        public string Fact_estado
        {
            get
            {
                return fact_estado;
            }

            set
            {
                fact_estado = value;
            }
        }

        public int Fact_estado_digitacion
        {
            get
            {
                return fact_estado_digitacion;
            }

            set
            {
                fact_estado_digitacion = value;
            }
        }

        public DateTime Fact_fechainac
        {
            get
            {
                return fact_fechainac;
            }

            set
            {
                fact_fechainac = value;
            }
        }

        public double Fact_valor_total_afecto
        {
            get
            {
                return fact_valor_total_afecto;
            }

            set
            {
                fact_valor_total_afecto = value;
            }
        }

        public double Fact_valor_total_inafecto
        {
            get
            {
                return fact_valor_total_inafecto;
            }

            set
            {
                fact_valor_total_inafecto = value;
            }
        }

        public double Fact_impuesto
        {
            get
            {
                return fact_impuesto;
            }

            set
            {
                fact_impuesto = value;
            }
        }

        public double Fact_redondeo
        {
            get
            {
                return fact_redondeo;
            }

            set
            {
                fact_redondeo = value;
            }
        }

        public double Fact_porcentaje_impuesto
        {
            get
            {
                return fact_porcentaje_impuesto;
            }

            set
            {
                fact_porcentaje_impuesto = value;
            }
        }

        public int Fact_numero_item
        {
            get
            {
                return fact_numero_item;
            }

            set
            {
                fact_numero_item = value;
            }
        }

        public string Fact_monto_letras
        {
            get
            {
                return fact_monto_letras;
            }

            set
            {
                fact_monto_letras = value;
            }
        }

        public int Pla_cta_ide
        {
            get
            {
                return pla_cta_ide;
            }

            set
            {
                pla_cta_ide = value;
            }
        }

        public int Tipo_doc_ide
        {
            get
            {
                return tipo_doc_ide;
            }

            set
            {
                tipo_doc_ide = value;
            }
        }

        public double Fact_venta_local
        {
            get
            {
                return fact_venta_local;
            }

            set
            {
                fact_venta_local = value;
            }
        }

        public double Fact_venta_dolar
        {
            get
            {
                return fact_venta_dolar;
            }

            set
            {
                fact_venta_dolar = value;
            }
        }

        public double Fact_venta_inafecto_local
        {
            get
            {
                return fact_venta_inafecto_local;
            }

            set
            {
                fact_venta_inafecto_local = value;
            }
        }

        public double Fact_venta_inafecto_dolar
        {
            get
            {
                return fact_venta_inafecto_dolar;
            }

            set
            {
                fact_venta_inafecto_dolar = value;
            }
        }

        public double Fact_impuesto_local
        {
            get
            {
                return fact_impuesto_local;
            }

            set
            {
                fact_impuesto_local = value;
            }
        }

        public double Fact_impuesto_dolar
        {
            get
            {
                return fact_impuesto_dolar;
            }

            set
            {
                fact_impuesto_dolar = value;
            }
        }

        public double Fact_redondeo_local
        {
            get
            {
                return fact_redondeo_local;
            }

            set
            {
                fact_redondeo_local = value;
            }
        }

        public double Fact_redondeo_dolar
        {
            get
            {
                return fact_redondeo_dolar;
            }

            set
            {
                fact_redondeo_dolar = value;
            }
        }

        public double Fact_tipo_cambio
        {
            get
            {
                return fact_tipo_cambio;
            }

            set
            {
                fact_tipo_cambio = value;
            }
        }

        public string Fact_concepto
        {
            get
            {
                return fact_concepto;
            }

            set
            {
                fact_concepto = value;
            }
        }

        public string Fact_precio_incluye_impuesto
        {
            get
            {
                return fact_precio_incluye_impuesto;
            }

            set
            {
                fact_precio_incluye_impuesto = value;
            }
        }

        public int Fact_numero_asiento
        {
            get
            {
                return fact_numero_asiento;
            }

            set
            {
                fact_numero_asiento = value;
            }
        }

        public int Veces
        {
            get
            {
                return veces;
            }

            set
            {
                veces = value;
            }
        }

        public int Fact_automatico
        {
            get
            {
                return fact_automatico;
            }

            set
            {
                fact_automatico = value;
            }
        }

        public string Usuario
        {
            get
            {
                return usuario;
            }

            set
            {
                usuario = value;
            }
        }

    }
}
