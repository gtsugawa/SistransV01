using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaBE
{
    class Factura_Carga_Detalle_RecojoBE
    {
    }
    public class ClsFactura_Carga_Detalle_RecojoBE
    {
        int fact_ide;
        int fact_ide_detalle;
        int reco_ide;
        string fact_nota;
        double fact_valor_bruto;
        double fact_valor_neto;
        string fact_tipo_impuesto;
        double fact_precio_neto;
        double fact_cantidad;
        double fact_valor_total;
        double fact_valor_venta;
        double fact_impuesto;
        double fact_costo_local;
        double fact_costo_dolar;
        double fact_unitario_local;
        double fact_unitario_dolar;
        double fact_valor_venta_local;
        double fact_valor_venta_dolar;
        double fact_impuesto_local;
        double fact_impuesto_dolar;
        string usuario;
        int veces;
        public ClsFactura_Carga_Detalle_RecojoBE()
        {

        }

        public ClsFactura_Carga_Detalle_RecojoBE(int fact_ide, int fact_ide_detalle, int reco_ide, string fact_nota, double fact_valor_bruto, double fact_valor_neto, string fact_tipo_impuesto, double fact_precio_neto, double fact_cantidad, double fact_valor_total, double fact_valor_venta, double fact_impuesto, double fact_costo_local, double fact_costo_dolar, double fact_unitario_local, double fact_unitario_dolar, double fact_valor_venta_local, double fact_valor_venta_dolar, double fact_impuesto_local, double fact_impuesto_dolar,string usuario,int veces)
        {
            this.fact_ide = fact_ide;
            this.fact_ide_detalle = fact_ide_detalle;
            this.reco_ide = reco_ide;
            this.fact_nota = fact_nota;
            this.fact_valor_bruto = fact_valor_bruto;
            this.fact_valor_neto = fact_valor_neto;
            this.fact_tipo_impuesto = fact_tipo_impuesto;
            this.fact_precio_neto = fact_precio_neto;
            this.fact_cantidad = fact_cantidad;
            this.fact_valor_total = fact_valor_total;
            this.fact_valor_venta = fact_valor_venta;
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

        public int Reco_ide
        {
            get
            {
                return reco_ide;
            }

            set
            {
                reco_ide = value;
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
