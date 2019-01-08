using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaBE
{
    class FacturaBE
    {
    }

    public class ClsFactura_CabeceraBE
    {
        int fac_Ide;
        string serie_factura_numero;
        int fact_factura_numero;
        string serie_guia_numero;
        int fact_guia_numero;
        string serie_guia_numero2;
        int fact_guia_numero2;
        string fact_moneda;
        DateTime fact_fecha_emision;
        DateTime fact_fecha_vencimiento;
        string fact_tipo_facturacion;
        string fact_tipo_precio;
        string fact_orden_compra;
        int clie_ide;
        int vend_ide;
        string fact_direccion;
        int loca_ide;
        int for_pag_ide;
        int desc_ide;
        int conc_ide;
        double fact_descuento1;
        double fact_descuento2;
        double fact_descuento3;
        string fact_tipo_documento;
        string serie_documento_numero;
        int fact_documento_numero;
        string fact_documento_numero_no_facturacion;
        DateTime fact_fecha_documento;
        Boolean fact_documento_no_existe;
        string fact_diferida;
        int alma_ide;
        string fact_estado;
        int fact_estado_digitacion;
        DateTime fact_fechainac;
        double fact_valor_total_afecto;
        double fact_valor_total_inafecto;
        double fact_descuento_cabecera_afecto;
        double fact_descuento_cabecera_inafecto;
        double fact_impuesto;
        double fact_redondeo;
        double fact_porcentaje_impuesto;
        int fact_numero_item;
        string fact_monto_letras;
        double fact_amortizacion_lrc;
        double fact_amortizacion_c_lrc;
        double fact_diferencia_cambio_lrc;
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
        int fact_lista_precio;
        string fact_precio_incluye_impuesto;
        int fact_numero_asiento;
        int veces;
        int fact_automatico;
        string nombre_error;
        string texto_buscar;
        string usuario;


        public ClsFactura_CabeceraBE()
        {
        }

        public ClsFactura_CabeceraBE(int fac_Ide, string serie_factura_numero, int fact_factura_numero, string serie_guia_numero, int fact_guia_numero, string serie_guia_numero2, int fact_guia_numero2, string fact_moneda, DateTime fact_fecha_emision, DateTime fact_fecha_vencimiento, string fact_tipo_facturacion, string fact_tipo_precio, string fact_orden_compra, int clie_ide, int vend_ide, string fact_direccion, int loca_ide, int for_pag_ide, int desc_ide, int conc_ide, double fact_descuento1, double fact_descuento2, double fact_descuento3, string fact_tipo_documento, string serie_documento_numero, int fact_documento_numero, string fact_documento_numero_no_facturacion, DateTime fact_fecha_documento, bool fact_documento_no_existe, string fact_diferida, int alma_ide, string fact_estado, int fact_estado_digitacion, DateTime fact_fechainac, double fact_valor_total_afecto, double fact_valor_total_inafecto, double fact_descuento_cabecera_afecto, double fact_descuento_cabecera_inafecto, double fact_impuesto, double fact_redondeo, double fact_porcentaje_impuesto, int fact_numero_item, string fact_monto_letras, double fact_amortizacion_lrc, double fact_amortizacion_c_lrc, double fact_diferencia_cambio_lrc, int pla_cta_ide, int tipo_doc_ide, double fact_venta_local, double fact_venta_dolar, double fact_venta_inafecto_local, double fact_venta_inafecto_dolar, double fact_impuesto_local, double fact_impuesto_dolar, double fact_redondeo_local, double fact_redondeo_dolar, double fact_tipo_cambio, string fact_concepto, int fact_lista_precio, string fact_precio_incluye_impuesto, int fact_numero_asiento, int veces, int fact_automatico, string nombre_error, string texto_buscar, string usuario)
        {
            this.fac_Ide = fac_Ide;
            this.serie_factura_numero = serie_factura_numero;
            this.fact_factura_numero = fact_factura_numero;
            this.serie_guia_numero = serie_guia_numero;
            this.fact_guia_numero = fact_guia_numero;
            this.serie_guia_numero2 = serie_guia_numero2;
            this.fact_guia_numero2 = fact_guia_numero2;
            this.fact_moneda = fact_moneda;
            this.fact_fecha_emision = fact_fecha_emision;
            this.fact_fecha_vencimiento = fact_fecha_vencimiento;
            this.fact_tipo_facturacion = fact_tipo_facturacion;
            this.fact_tipo_precio = fact_tipo_precio;
            this.fact_orden_compra = fact_orden_compra;
            this.clie_ide = clie_ide;
            this.vend_ide = vend_ide;
            this.fact_direccion = fact_direccion;
            this.loca_ide = loca_ide;
            this.for_pag_ide = for_pag_ide;
            this.desc_ide = desc_ide;
            this.conc_ide = conc_ide;
            this.fact_descuento1 = fact_descuento1;
            this.fact_descuento2 = fact_descuento2;
            this.fact_descuento3 = fact_descuento3;
            this.fact_tipo_documento = fact_tipo_documento;
            this.serie_documento_numero = serie_documento_numero;
            this.fact_documento_numero = fact_documento_numero;
            this.fact_documento_numero_no_facturacion = fact_documento_numero_no_facturacion;
            this.fact_fecha_documento = fact_fecha_documento;
            this.fact_documento_no_existe = fact_documento_no_existe;
            this.fact_diferida = fact_diferida;
            this.alma_ide = alma_ide;
            this.fact_estado = fact_estado;
            this.fact_estado_digitacion = fact_estado_digitacion;
            this.fact_fechainac = fact_fechainac;
            this.fact_valor_total_afecto = fact_valor_total_afecto;
            this.fact_valor_total_inafecto = fact_valor_total_inafecto;
            this.fact_descuento_cabecera_afecto = fact_descuento_cabecera_afecto;
            this.fact_descuento_cabecera_inafecto = fact_descuento_cabecera_inafecto;
            this.fact_impuesto = fact_impuesto;
            this.fact_redondeo = fact_redondeo;
            this.fact_porcentaje_impuesto = fact_porcentaje_impuesto;
            this.fact_numero_item = fact_numero_item;
            this.fact_monto_letras = fact_monto_letras;
            this.fact_amortizacion_lrc = fact_amortizacion_lrc;
            this.fact_amortizacion_c_lrc = fact_amortizacion_c_lrc;
            this.fact_diferencia_cambio_lrc = fact_diferencia_cambio_lrc;
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
            this.fact_lista_precio = fact_lista_precio;
            this.fact_precio_incluye_impuesto = fact_precio_incluye_impuesto;
            this.fact_numero_asiento = fact_numero_asiento;
            this.veces = veces;
            this.fact_automatico = fact_automatico;
            this.nombre_error = nombre_error;
            this.texto_buscar = texto_buscar;
            this.usuario = usuario;

        }

        public int Fac_Ide
        {
            get
            {
                return fac_Ide;
            }

            set
            {
                fac_Ide = value;
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

        public string Serie_guia_numero
        {
            get
            {
                return serie_guia_numero;
            }

            set
            {
                serie_guia_numero = value;
            }
        }

        public int Fact_guia_numero
        {
            get
            {
                return fact_guia_numero;
            }

            set
            {
                fact_guia_numero = value;
            }
        }

        public string Serie_guia_numero2
        {
            get
            {
                return serie_guia_numero2;
            }

            set
            {
                serie_guia_numero2 = value;
            }
        }

        public int Fact_guia_numero2
        {
            get
            {
                return fact_guia_numero2;
            }

            set
            {
                fact_guia_numero2 = value;
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

        public string Fact_orden_compra
        {
            get
            {
                return fact_orden_compra;
            }

            set
            {
                fact_orden_compra = value;
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

        public int Desc_ide
        {
            get
            {
                return desc_ide;
            }

            set
            {
                desc_ide = value;
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

        public double Fact_descuento1
        {
            get
            {
                return fact_descuento1;
            }

            set
            {
                fact_descuento1 = value;
            }
        }

        public double Fact_descuento2
        {
            get
            {
                return fact_descuento2;
            }

            set
            {
                fact_descuento2 = value;
            }
        }

        public double Fact_descuento3
        {
            get
            {
                return fact_descuento3;
            }

            set
            {
                fact_descuento3 = value;
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

        public bool Fact_documento_no_existe
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

        public string Fact_diferida
        {
            get
            {
                return fact_diferida;
            }

            set
            {
                fact_diferida = value;
            }
        }

        public int Alma_ide
        {
            get
            {
                return alma_ide;
            }

            set
            {
                alma_ide = value;
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

        public double Fact_descuento_cabecera_afecto
        {
            get
            {
                return fact_descuento_cabecera_afecto;
            }

            set
            {
                fact_descuento_cabecera_afecto = value;
            }
        }

        public double Fact_descuento_cabecera_inafecto
        {
            get
            {
                return fact_descuento_cabecera_inafecto;
            }

            set
            {
                fact_descuento_cabecera_inafecto = value;
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

        public double Fact_amortizacion_lrc
        {
            get
            {
                return fact_amortizacion_lrc;
            }

            set
            {
                fact_amortizacion_lrc = value;
            }
        }

        public double Fact_amortizacion_c_lrc
        {
            get
            {
                return fact_amortizacion_c_lrc;
            }

            set
            {
                fact_amortizacion_c_lrc = value;
            }
        }

        public double Fact_diferencia_cambio_lrc
        {
            get
            {
                return fact_diferencia_cambio_lrc;
            }

            set
            {
                fact_diferencia_cambio_lrc = value;
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

        public int Fact_lista_precio
        {
            get
            {
                return fact_lista_precio;
            }

            set
            {
                fact_lista_precio = value;
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

        public string Nombre_error
        {
            get
            {
                return nombre_error;
            }

            set
            {
                nombre_error = value;
            }
        }

        public string Texto_buscar
        {
            get
            {
                return texto_buscar;
            }

            set
            {
                texto_buscar = value;
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

    public class ClsFactura_DetalleBE
    {
        int fact_ide;
        int fact_ide_detalle;
        int fact_ide_detalle_guia;

        public ClsFactura_DetalleBE()
        {
            
        }

        public ClsFactura_DetalleBE(int fact_ide, int fact_ide_detalle, int fact_ide_detalle_guia)
        {
            this.fact_ide = fact_ide;
            this.fact_ide_detalle = fact_ide_detalle;
            this.fact_ide_detalle_guia = fact_ide_detalle_guia;
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

        public int Fact_ide_detalle
        {
            get
            {
                return fact_ide_detalle;
            }

            set
            {
                fact_ide_detalle = value;
            }
        }

        public int Fact_ide_detalle_guia
        {
            get
            {
                return fact_ide_detalle_guia;
            }

            set
            {
                fact_ide_detalle_guia = value;
            }
        }
    }

    public class ClsFactura_Detalle_ProductoBE
    {
        int fact_ide;
        int fact_ide_detalle;
        int merca_ide;
        int unid_medi_ide;
        double fact_valor_bruto;
        double fact_descuento1;
        double fact_descuento2;
        double fact_descuento3;
        double fact_valor_neto;
        string fact_tipo_impuesto;
        double fact_precio_neto;
        double fact_cantidad;
        double fact_valor_total;
        double fact_valor_venta;
        double fact_rentabilidad;
        double fact_participacion;
        double fact_descuento_cabecera;
        double fact_impuesto;
        double fact_costo_local;
        double fact_costo_dolar;
        double fact_unitario_local;
        double fact_unitario_dolar;
        double fact_valor_venta_local;
        double fact_valor_venta_dolar;
        double fact_impuesto_local;
        double fact_impuesto_dolar;
        double fact_numero_serie;
        double fact_cantidad_entregada;
        double fact_compra_local;
        double fact_compra_dolar;

        public ClsFactura_Detalle_ProductoBE()
        {

        }

        public ClsFactura_Detalle_ProductoBE(int fact_ide, int fact_ide_detalle, int merca_ide, int unid_medi_ide, double fact_valor_bruto, double fact_descuento1, double fact_descuento2, double fact_descuento3, double fact_valor_neto, string fact_tipo_impuesto, double fact_precio_neto, double fact_cantidad, double fact_valor_total, double fact_valor_venta, double fact_rentabilidad, double fact_participacion, double fact_descuento_cabecera, double fact_impuesto, double fact_costo_local, double fact_costo_dolar, double fact_unitario_local, double fact_unitario_dolar, double fact_valor_venta_local, double fact_valor_venta_dolar, double fact_impuesto_local, double fact_impuesto_dolar, double fact_numero_serie, double fact_cantidad_entregada, double fact_compra_local, double fact_compra_dolar)
        {
            this.fact_ide = fact_ide;
            this.fact_ide_detalle = fact_ide_detalle;
            this.merca_ide = merca_ide;
            this.unid_medi_ide = unid_medi_ide;
            this.fact_valor_bruto = fact_valor_bruto;
            this.fact_descuento1 = fact_descuento1;
            this.fact_descuento2 = fact_descuento2;
            this.fact_descuento3 = fact_descuento3;
            this.fact_valor_neto = fact_valor_neto;
            this.fact_tipo_impuesto = fact_tipo_impuesto;
            this.fact_precio_neto = fact_precio_neto;
            this.fact_cantidad = fact_cantidad;
            this.fact_valor_total = fact_valor_total;
            this.fact_valor_venta = fact_valor_venta;
            this.fact_rentabilidad = fact_rentabilidad;
            this.fact_participacion = fact_participacion;
            this.fact_descuento_cabecera = fact_descuento_cabecera;
            this.fact_impuesto = fact_impuesto;
            this.fact_costo_local = fact_costo_local;
            this.fact_costo_dolar = fact_costo_dolar;
            this.fact_unitario_local = fact_unitario_local;
            this.fact_unitario_dolar = fact_unitario_dolar;
            this.fact_valor_venta_local = fact_valor_venta_local;
            this.fact_valor_venta_dolar = fact_valor_venta_dolar;
            this.fact_impuesto_local = fact_impuesto_local;
            this.fact_impuesto_dolar = fact_impuesto_dolar;
            this.fact_numero_serie = fact_numero_serie;
            this.fact_cantidad_entregada = fact_cantidad_entregada;
            this.fact_compra_local = fact_compra_local;
            this.fact_compra_dolar = fact_compra_dolar;
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

        public int Fact_ide_detalle
        {
            get
            {
                return fact_ide_detalle;
            }

            set
            {
                fact_ide_detalle = value;
            }
        }

        public int Merca_ide
        {
            get
            {
                return merca_ide;
            }

            set
            {
                merca_ide = value;
            }
        }

        public int Unid_medi_ide
        {
            get
            {
                return unid_medi_ide;
            }

            set
            {
                unid_medi_ide = value;
            }
        }

        public double Fact_valor_bruto
        {
            get
            {
                return fact_valor_bruto;
            }

            set
            {
                fact_valor_bruto = value;
            }
        }

        public double Fact_descuento1
        {
            get
            {
                return fact_descuento1;
            }

            set
            {
                fact_descuento1 = value;
            }
        }

        public double Fact_descuento2
        {
            get
            {
                return fact_descuento2;
            }

            set
            {
                fact_descuento2 = value;
            }
        }

        public double Fact_descuento3
        {
            get
            {
                return fact_descuento3;
            }

            set
            {
                fact_descuento3 = value;
            }
        }

        public double Fact_valor_neto
        {
            get
            {
                return fact_valor_neto;
            }

            set
            {
                fact_valor_neto = value;
            }
        }

        public string Fact_tipo_impuesto
        {
            get
            {
                return fact_tipo_impuesto;
            }

            set
            {
                fact_tipo_impuesto = value;
            }
        }

        public double Fact_precio_neto
        {
            get
            {
                return fact_precio_neto;
            }

            set
            {
                fact_precio_neto = value;
            }
        }

        public double Fact_cantidad
        {
            get
            {
                return fact_cantidad;
            }

            set
            {
                fact_cantidad = value;
            }
        }

        public double Fact_valor_total
        {
            get
            {
                return fact_valor_total;
            }

            set
            {
                fact_valor_total = value;
            }
        }

        public double Fact_valor_venta
        {
            get
            {
                return fact_valor_venta;
            }

            set
            {
                fact_valor_venta = value;
            }
        }

        public double Fact_rentabilidad
        {
            get
            {
                return fact_rentabilidad;
            }

            set
            {
                fact_rentabilidad = value;
            }
        }

        public double Fact_participacion
        {
            get
            {
                return fact_participacion;
            }

            set
            {
                fact_participacion = value;
            }
        }

        public double Fact_descuento_cabecera
        {
            get
            {
                return fact_descuento_cabecera;
            }

            set
            {
                fact_descuento_cabecera = value;
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

        public double Fact_costo_local
        {
            get
            {
                return fact_costo_local;
            }

            set
            {
                fact_costo_local = value;
            }
        }

        public double Fact_costo_dolar
        {
            get
            {
                return fact_costo_dolar;
            }

            set
            {
                fact_costo_dolar = value;
            }
        }

        public double Fact_unitario_local
        {
            get
            {
                return fact_unitario_local;
            }

            set
            {
                fact_unitario_local = value;
            }
        }

        public double Fact_unitario_dolar
        {
            get
            {
                return fact_unitario_dolar;
            }

            set
            {
                fact_unitario_dolar = value;
            }
        }

        public double Fact_valor_venta_local
        {
            get
            {
                return fact_valor_venta_local;
            }

            set
            {
                fact_valor_venta_local = value;
            }
        }

        public double Fact_valor_venta_dolar
        {
            get
            {
                return fact_valor_venta_dolar;
            }

            set
            {
                fact_valor_venta_dolar = value;
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

        public double Fact_numero_serie
        {
            get
            {
                return fact_numero_serie;
            }

            set
            {
                fact_numero_serie = value;
            }
        }

        public double Fact_cantidad_entregada
        {
            get
            {
                return fact_cantidad_entregada;
            }

            set
            {
                fact_cantidad_entregada = value;
            }
        }

        public double Fact_compra_local
        {
            get
            {
                return fact_compra_local;
            }

            set
            {
                fact_compra_local = value;
            }
        }

        public double Fact_compra_dolar
        {
            get
            {
                return fact_compra_dolar;
            }

            set
            {
                fact_compra_dolar = value;
            }
        }
    }

    public class ClsFactura_Detalle_TextoBE
    {
        int fact_ide_detalle;
        string fact_nota;

        public ClsFactura_Detalle_TextoBE()
        {
        }

        public ClsFactura_Detalle_TextoBE(int fact_ide_detalle, string fact_nota)
        {
            this.fact_ide_detalle = fact_ide_detalle;
            this.fact_nota = fact_nota;
        }

        public int Fact_ide_detalle
        {
            get
            {
                return fact_ide_detalle;
            }

            set
            {
                fact_ide_detalle = value;
            }
        }

        public string Fact_nota
        {
            get
            {
                return fact_nota;
            }

            set
            {
                fact_nota = value;
            }
        }
    }

    public class ClsFactura_GuiaBE
    {
        int fact_ide;
        string fact_lugar_entrega;
        int loca_ide;
        int tran_ide;
        string fact_chofer;
        string fact_licencia;
        string fact_vehiculo;
        string fact_placa;
        string fact_remitimos;
        int veces;

        public ClsFactura_GuiaBE()
        {
            
        }

        public ClsFactura_GuiaBE(int fact_ide, string fact_lugar_entrega, int loca_ide, int tran_ide, string fact_chofer, string fact_licencia, string fact_vehiculo, string fact_placa, string fact_remitimos, int veces)
        {
            this.fact_ide = fact_ide;
            this.fact_lugar_entrega = fact_lugar_entrega;
            this.loca_ide = loca_ide;
            this.tran_ide = tran_ide;
            this.fact_chofer = fact_chofer;
            this.fact_licencia = fact_licencia;
            this.fact_vehiculo = fact_vehiculo;
            this.fact_placa = fact_placa;
            this.fact_remitimos = fact_remitimos;
            this.veces = veces;
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

        public string Fact_lugar_entrega
        {
            get
            {
                return fact_lugar_entrega;
            }

            set
            {
                fact_lugar_entrega = value;
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

        public int Tran_ide
        {
            get
            {
                return tran_ide;
            }

            set
            {
                tran_ide = value;
            }
        }

        public string Fact_chofer
        {
            get
            {
                return fact_chofer;
            }

            set
            {
                fact_chofer = value;
            }
        }

        public string Fact_licencia
        {
            get
            {
                return fact_licencia;
            }

            set
            {
                fact_licencia = value;
            }
        }

        public string Fact_vehiculo
        {
            get
            {
                return fact_vehiculo;
            }

            set
            {
                fact_vehiculo = value;
            }
        }

        public string Fact_placa
        {
            get
            {
                return fact_placa;
            }

            set
            {
                fact_placa = value;
            }
        }

        public string Fact_remitimos
        {
            get
            {
                return fact_remitimos;
            }

            set
            {
                fact_remitimos = value;
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
    }

    public class ClsFactura_Mes_PendienteBE
    {
        int fact_ide;
        int fact_ano_contabilizacion;
        int fact_mes_contabilizacion;
        int fact_ano_pendiente;
        int fact_mes_pendiente;

        public ClsFactura_Mes_PendienteBE()
        {
  
        }
        public ClsFactura_Mes_PendienteBE(int fact_ide, int fact_ano_contabilizacion, int fact_mes_contabilizacion, int fact_ano_pendiente, int fact_mes_pendiente)
        {
            this.fact_ide = fact_ide;
            this.fact_ano_contabilizacion = fact_ano_contabilizacion;
            this.fact_mes_contabilizacion = fact_mes_contabilizacion;
            this.fact_ano_pendiente = fact_ano_pendiente;
            this.fact_mes_pendiente = fact_mes_pendiente;
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

        public int Fact_ano_contabilizacion
        {
            get
            {
                return fact_ano_contabilizacion;
            }

            set
            {
                fact_ano_contabilizacion = value;
            }
        }

        public int Fact_mes_contabilizacion
        {
            get
            {
                return fact_mes_contabilizacion;
            }

            set
            {
                fact_mes_contabilizacion = value;
            }
        }

        public int Fact_ano_pendiente
        {
            get
            {
                return fact_ano_pendiente;
            }

            set
            {
                fact_ano_pendiente = value;
            }
        }

        public int Fact_mes_pendiente
        {
            get
            {
                return fact_mes_pendiente;
            }

            set
            {
                fact_mes_pendiente = value;
            }
        }
    }



    public class ClsFactura_Carga_DetalleBE
    {
        int fact_ide;
        int fact_ide_detalle;
        int fact_ide_detalle_guia;

        public ClsFactura_Carga_DetalleBE()
        {

        }

        public ClsFactura_Carga_DetalleBE(int fact_ide, int fact_ide_detalle, int fact_ide_detalle_guia)
        {
            this.fact_ide = fact_ide;
            this.fact_ide_detalle = fact_ide_detalle;
            this.fact_ide_detalle_guia = fact_ide_detalle_guia;
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

        public int Fact_ide_detalle
        {
            get
            {
                return fact_ide_detalle;
            }

            set
            {
                fact_ide_detalle = value;
            }
        }

        public int Fact_ide_detalle_guia
        {
            get
            {
                return fact_ide_detalle_guia;
            }

            set
            {
                fact_ide_detalle_guia = value;
            }
        }
    }

    public class ClsFactura_Carga_Detalle_ProductoBE
    {
        int fact_ide;
        int fact_ide_detalle;
        int merca_ide;
        int unid_medi_ide;
        double fact_valor_bruto;
        double fact_valor_neto;
        string fact_tipo_impuesto;
        double fact_precio_neto;
        double fact_cantidad;
        double fact_valor_total;
        double fact_valor_venta;
        double fact_participacion;
        double fact_impuesto;
        double fact_costo_local;
        double fact_costo_dolar;
        double fact_unitario_local;
        double fact_unitario_dolar;
        double fact_valor_venta_local;
        double fact_valor_venta_dolar;
        double fact_impuesto_local;
        double fact_impuesto_dolar;

        public ClsFactura_Carga_Detalle_ProductoBE()
        {
 
        }

        public ClsFactura_Carga_Detalle_ProductoBE(int fact_ide, int fact_ide_detalle, int merca_ide, int unid_medi_ide, double fact_valor_bruto, double fact_valor_neto, string fact_tipo_impuesto, double fact_precio_neto, double fact_cantidad, double fact_valor_total, double fact_valor_venta, double fact_participacion, double fact_impuesto, double fact_costo_local, double fact_costo_dolar, double fact_unitario_local, double fact_unitario_dolar, double fact_valor_venta_local, double fact_valor_venta_dolar, double fact_impuesto_local, double fact_impuesto_dolar)
        {
            this.fact_ide = fact_ide;
            this.fact_ide_detalle = fact_ide_detalle;
            this.merca_ide = merca_ide;
            this.unid_medi_ide = unid_medi_ide;
            this.fact_valor_bruto = fact_valor_bruto;
            this.fact_valor_neto = fact_valor_neto;
            this.fact_tipo_impuesto = fact_tipo_impuesto;
            this.fact_precio_neto = fact_precio_neto;
            this.fact_cantidad = fact_cantidad;
            this.fact_valor_total = fact_valor_total;
            this.fact_valor_venta = fact_valor_venta;
            this.fact_participacion = fact_participacion;
            this.fact_impuesto = fact_impuesto;
            this.fact_costo_local = fact_costo_local;
            this.fact_costo_dolar = fact_costo_dolar;
            this.fact_unitario_local = fact_unitario_local;
            this.fact_unitario_dolar = fact_unitario_dolar;
            this.fact_valor_venta_local = fact_valor_venta_local;
            this.fact_valor_venta_dolar = fact_valor_venta_dolar;
            this.fact_impuesto_local = fact_impuesto_local;
            this.fact_impuesto_dolar = fact_impuesto_dolar;
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

        public int Fact_ide_detalle
        {
            get
            {
                return fact_ide_detalle;
            }

            set
            {
                fact_ide_detalle = value;
            }
        }

        public int Merca_ide
        {
            get
            {
                return merca_ide;
            }

            set
            {
                merca_ide = value;
            }
        }

        public int Unid_medi_ide
        {
            get
            {
                return unid_medi_ide;
            }

            set
            {
                unid_medi_ide = value;
            }
        }

        public double Fact_valor_bruto
        {
            get
            {
                return fact_valor_bruto;
            }

            set
            {
                fact_valor_bruto = value;
            }
        }

        public double Fact_valor_neto
        {
            get
            {
                return fact_valor_neto;
            }

            set
            {
                fact_valor_neto = value;
            }
        }

        public string Fact_tipo_impuesto
        {
            get
            {
                return fact_tipo_impuesto;
            }

            set
            {
                fact_tipo_impuesto = value;
            }
        }

        public double Fact_precio_neto
        {
            get
            {
                return fact_precio_neto;
            }

            set
            {
                fact_precio_neto = value;
            }
        }

        public double Fact_cantidad
        {
            get
            {
                return fact_cantidad;
            }

            set
            {
                fact_cantidad = value;
            }
        }

        public double Fact_valor_total
        {
            get
            {
                return fact_valor_total;
            }

            set
            {
                fact_valor_total = value;
            }
        }

        public double Fact_valor_venta
        {
            get
            {
                return fact_valor_venta;
            }

            set
            {
                fact_valor_venta = value;
            }
        }

        public double Fact_participacion
        {
            get
            {
                return fact_participacion;
            }

            set
            {
                fact_participacion = value;
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

        public double Fact_costo_local
        {
            get
            {
                return fact_costo_local;
            }

            set
            {
                fact_costo_local = value;
            }
        }

        public double Fact_costo_dolar
        {
            get
            {
                return fact_costo_dolar;
            }

            set
            {
                fact_costo_dolar = value;
            }
        }

        public double Fact_unitario_local
        {
            get
            {
                return fact_unitario_local;
            }

            set
            {
                fact_unitario_local = value;
            }
        }

        public double Fact_unitario_dolar
        {
            get
            {
                return fact_unitario_dolar;
            }

            set
            {
                fact_unitario_dolar = value;
            }
        }

        public double Fact_valor_venta_local
        {
            get
            {
                return fact_valor_venta_local;
            }

            set
            {
                fact_valor_venta_local = value;
            }
        }

        public double Fact_valor_venta_dolar
        {
            get
            {
                return fact_valor_venta_dolar;
            }

            set
            {
                fact_valor_venta_dolar = value;
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
    }

     public class ClsFactura_Carga_Detalle_TextoBE
    {
        int fact_ide;
        int fact_ide_detalle;
        string fact_nota;

        public ClsFactura_Carga_Detalle_TextoBE()
        {
            
        }

        public ClsFactura_Carga_Detalle_TextoBE(int fact_ide, int fact_ide_detalle, string fact_nota)
        {
            this.fact_ide = fact_ide;
            this.fact_ide_detalle = fact_ide_detalle;
            this.fact_nota = fact_nota;
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

        public int Fact_ide_detalle
        {
            get
            {
                return fact_ide_detalle;
            }

            set
            {
                fact_ide_detalle = value;
            }
        }

        public string Fact_nota
        {
            get
            {
                return fact_nota;
            }

            set
            {
                fact_nota = value;
            }
        }
    }

    public class ClsFactura_Carga_Mes_PendienteBE
    {
        int fact_ide;
        int fact_ano_contabilizacion;
        int fact_mes_contabilizacion;
        int fact_ano_pendiente;
        int fact_mes_pendiente;

        public ClsFactura_Carga_Mes_PendienteBE()
        {
          
        }
        public ClsFactura_Carga_Mes_PendienteBE(int fact_ide, int fact_ano_contabilizacion, int fact_mes_contabilizacion, int fact_ano_pendiente, int fact_mes_pendiente)
        {
            this.fact_ide = fact_ide;
            this.fact_ano_contabilizacion = fact_ano_contabilizacion;
            this.fact_mes_contabilizacion = fact_mes_contabilizacion;
            this.fact_ano_pendiente = fact_ano_pendiente;
            this.fact_mes_pendiente = fact_mes_pendiente;
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

        public int Fact_ano_contabilizacion
        {
            get
            {
                return fact_ano_contabilizacion;
            }

            set
            {
                fact_ano_contabilizacion = value;
            }
        }

        public int Fact_mes_contabilizacion
        {
            get
            {
                return fact_mes_contabilizacion;
            }

            set
            {
                fact_mes_contabilizacion = value;
            }
        }

        public int Fact_ano_pendiente
        {
            get
            {
                return fact_ano_pendiente;
            }

            set
            {
                fact_ano_pendiente = value;
            }
        }

        public int Fact_mes_pendiente
        {
            get
            {
                return fact_mes_pendiente;
            }

            set
            {
                fact_mes_pendiente = value;
            }
        }
    }

    public class ClsTipo_CambioBE
    {
        DateTime tipo_camb_fecha;
        double tipo_camb_compra;
        double tipo_camb_venta;
        double tipo_camb_impuesto;
        DateTime creacion;
        int veces;

        public ClsTipo_CambioBE()
        {
  
        }

        public ClsTipo_CambioBE(DateTime tipo_camb_fecha, double tipo_camb_compra, double tipo_camb_venta, double tipo_camb_impuesto, DateTime creacion, int veces)
        {
            this.tipo_camb_fecha = tipo_camb_fecha;
            this.tipo_camb_compra = tipo_camb_compra;
            this.tipo_camb_venta = tipo_camb_venta;
            this.tipo_camb_impuesto = tipo_camb_impuesto;
            this.creacion = creacion;
            this.veces = veces;
        }
        public DateTime Tipo_camb_fecha
        {
            get
            {
                return tipo_camb_fecha;
            }

            set
            {
                tipo_camb_fecha = value;
            }
        }

        public double Tipo_camb_compra
        {
            get
            {
                return tipo_camb_compra;
            }

            set
            {
                tipo_camb_compra = value;
            }
        }

        public double Tipo_camb_venta
        {
            get
            {
                return tipo_camb_venta;
            }

            set
            {
                tipo_camb_venta = value;
            }
        }

        public double Tipo_camb_impuesto
        {
            get
            {
                return tipo_camb_impuesto;
            }

            set
            {
                tipo_camb_impuesto = value;
            }
        }

        public DateTime Creacion
        {
            get
            {
                return creacion;
            }

            set
            {
                creacion = value;
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
    }

}
