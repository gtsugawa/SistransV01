using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaBE
{
    class Tipo_HonorarioBE
    {
    }
    public class ClsTipo_HonorarioBE
    {
        int tipo_hono_ide;
        string tipo_hono_codigo;
        int tipo_hono_moneda;
        string tipo_hono_nombre;
        int pla_cta_ide_sub_total;
        int pla_cta_ide_impto1;
        int auxi_ide_impto1;
        int tipo_doc_ide_impto1;
        double tipo_hono_porc_impto1;
        int pla_cta_ide_impto2;
        int auxi_ide_impto2;
        int tipo_doc_ide_impto2;
        double tipo_hono_monto_desde1_impto2;
        double tipo_hono_monto_hasta1_impto2;
        double tipo_hono_porc_impto2;
        double tipo_hono_monto_desde2_impto2;
        double tipo_hono_monto_hasta2_impto2;
        double tipo_hono_porc_impto22;
        int pla_cta_ide_impto3;
        int auxi_ide_impto3;
        int tipo_doc_ide_impto3;
        double tipo_hono_monto_desde1_impto3;
        double tipo_hono_monto_hasta1_impto3;
        double tipo_hono_porc_impto3;
        int pla_cta_ide_impto4;
        int auxi_ide_impto4;
        int tipo_doc_ide_impto4;
        double tipo_hono_monto_desde1_impto4;
        double tipo_hono_monto_hasta1_impto4;
        double tipo_hono_porc_impto4;
        double tipo_hono_tope_impto4;
        int pla_cta_ide_total;
        string tipo_hono_estado;
        DateTime tipo_hono_fechainac;
        double tipo_hono_desde;
        DateTime creacion;
        int veces;
        string nombre_error;
        string texto_buscar;
        string usuario;

        public ClsTipo_HonorarioBE()
        {
        }

        public ClsTipo_HonorarioBE(int tipo_hono_ide, string tipo_hono_codigo, int tipo_hono_moneda, string tipo_hono_nombre, int pla_cta_ide_sub_total, int pla_cta_ide_impto1, int auxi_ide_impto1, int tipo_doc_ide_impto1, double tipo_hono_porc_impto1, int pla_cta_ide_impto2, int auxi_ide_impto2, int tipo_doc_ide_impto2, double tipo_hono_monto_desde1_impto2, double tipo_hono_monto_hasta1_impto2, double tipo_hono_porc_impto2, double tipo_hono_monto_desde2_impto2, double tipo_hono_monto_hasta2_impto2, double tipo_hono_porc_impto22, int pla_cta_ide_impto3, int auxi_ide_impto3, int tipo_doc_ide_impto3, double tipo_hono_monto_desde1_impto3, double tipo_hono_monto_hasta1_impto3, double tipo_hono_porc_impto3, int pla_cta_ide_impto4, int auxi_ide_impto4, int tipo_doc_ide_impto4, double tipo_hono_monto_desde1_impto4, double tipo_hono_monto_hasta1_impto4, double tipo_hono_porc_impto4, double tipo_hono_tope_impto4, int pla_cta_ide_total, string tipo_hono_estado, DateTime tipo_hono_fechainac, double tipo_hono_desde, DateTime creacion, int veces, string nombre_error, string texto_buscar, string usuario)
        {
            this.tipo_hono_ide = tipo_hono_ide;
            this.tipo_hono_codigo = tipo_hono_codigo;
            this.tipo_hono_moneda = tipo_hono_moneda;
            this.tipo_hono_nombre = tipo_hono_nombre;
            this.pla_cta_ide_sub_total = pla_cta_ide_sub_total;
            this.pla_cta_ide_impto1 = pla_cta_ide_impto1;
            this.auxi_ide_impto1 = auxi_ide_impto1;
            this.tipo_doc_ide_impto1 = tipo_doc_ide_impto1;
            this.tipo_hono_porc_impto1 = tipo_hono_porc_impto1;
            this.pla_cta_ide_impto2 = pla_cta_ide_impto2;
            this.auxi_ide_impto2 = auxi_ide_impto2;
            this.tipo_doc_ide_impto2 = tipo_doc_ide_impto2;
            this.tipo_hono_monto_desde1_impto2 = tipo_hono_monto_desde1_impto2;
            this.tipo_hono_monto_hasta1_impto2 = tipo_hono_monto_hasta1_impto2;
            this.tipo_hono_porc_impto2 = tipo_hono_porc_impto2;
            this.tipo_hono_monto_desde2_impto2 = tipo_hono_monto_desde2_impto2;
            this.tipo_hono_monto_hasta2_impto2 = tipo_hono_monto_hasta2_impto2;
            this.tipo_hono_porc_impto22 = tipo_hono_porc_impto22;
            this.pla_cta_ide_impto3 = pla_cta_ide_impto3;
            this.auxi_ide_impto3 = auxi_ide_impto3;
            this.tipo_doc_ide_impto3 = tipo_doc_ide_impto3;
            this.tipo_hono_monto_desde1_impto3 = tipo_hono_monto_desde1_impto3;
            this.tipo_hono_monto_hasta1_impto3 = tipo_hono_monto_hasta1_impto3;
            this.tipo_hono_porc_impto3 = tipo_hono_porc_impto3;
            this.pla_cta_ide_impto4 = pla_cta_ide_impto4;
            this.auxi_ide_impto4 = auxi_ide_impto4;
            this.tipo_doc_ide_impto4 = tipo_doc_ide_impto4;
            this.tipo_hono_monto_desde1_impto4 = tipo_hono_monto_desde1_impto4;
            this.tipo_hono_monto_hasta1_impto4 = tipo_hono_monto_hasta1_impto4;
            this.tipo_hono_porc_impto4 = tipo_hono_porc_impto4;
            this.tipo_hono_tope_impto4 = tipo_hono_tope_impto4;
            this.pla_cta_ide_total = pla_cta_ide_total;
            this.tipo_hono_estado = tipo_hono_estado;
            this.tipo_hono_fechainac = tipo_hono_fechainac;
            this.tipo_hono_desde = tipo_hono_desde;
            this.creacion = creacion;
            this.veces = veces;
            this.nombre_error = nombre_error;
            this.texto_buscar = texto_buscar;
            this.usuario = usuario;
        }

        public int Tipo_hono_ide
        {
            get
            {
                return tipo_hono_ide;
            }

            set
            {
                tipo_hono_ide = value;
            }
        }

        public string Tipo_hono_codigo
        {
            get
            {
                return tipo_hono_codigo;
            }

            set
            {
                tipo_hono_codigo = value;
            }
        }

        public int Tipo_hono_moneda
        {
            get
            {
                return tipo_hono_moneda;
            }

            set
            {
                tipo_hono_moneda = value;
            }
        }

        public string Tipo_hono_nombre
        {
            get
            {
                return tipo_hono_nombre;
            }

            set
            {
                tipo_hono_nombre = value;
            }
        }

        public int Pla_cta_ide_sub_total
        {
            get
            {
                return pla_cta_ide_sub_total;
            }

            set
            {
                pla_cta_ide_sub_total = value;
            }
        }

        public int Pla_cta_ide_impto1
        {
            get
            {
                return pla_cta_ide_impto1;
            }

            set
            {
                pla_cta_ide_impto1 = value;
            }
        }

        public int Auxi_ide_impto1
        {
            get
            {
                return auxi_ide_impto1;
            }

            set
            {
                auxi_ide_impto1 = value;
            }
        }

        public int Tipo_doc_ide_impto1
        {
            get
            {
                return tipo_doc_ide_impto1;
            }

            set
            {
                tipo_doc_ide_impto1 = value;
            }
        }

        public double Tipo_hono_porc_impto1
        {
            get
            {
                return tipo_hono_porc_impto1;
            }

            set
            {
                tipo_hono_porc_impto1 = value;
            }
        }

        public int Pla_cta_ide_impto2
        {
            get
            {
                return pla_cta_ide_impto2;
            }

            set
            {
                pla_cta_ide_impto2 = value;
            }
        }

        public int Auxi_ide_impto2
        {
            get
            {
                return auxi_ide_impto2;
            }

            set
            {
                auxi_ide_impto2 = value;
            }
        }

        public int Tipo_doc_ide_impto2
        {
            get
            {
                return tipo_doc_ide_impto2;
            }

            set
            {
                tipo_doc_ide_impto2 = value;
            }
        }

        public double Tipo_hono_monto_desde1_impto2
        {
            get
            {
                return tipo_hono_monto_desde1_impto2;
            }

            set
            {
                tipo_hono_monto_desde1_impto2 = value;
            }
        }

        public double Tipo_hono_monto_hasta1_impto2
        {
            get
            {
                return tipo_hono_monto_hasta1_impto2;
            }

            set
            {
                tipo_hono_monto_hasta1_impto2 = value;
            }
        }

        public double Tipo_hono_porc_impto2
        {
            get
            {
                return tipo_hono_porc_impto2;
            }

            set
            {
                tipo_hono_porc_impto2 = value;
            }
        }

        public double Tipo_hono_monto_desde2_impto2
        {
            get
            {
                return tipo_hono_monto_desde2_impto2;
            }

            set
            {
                tipo_hono_monto_desde2_impto2 = value;
            }
        }

        public double Tipo_hono_monto_hasta2_impto2
        {
            get
            {
                return tipo_hono_monto_hasta2_impto2;
            }

            set
            {
                tipo_hono_monto_hasta2_impto2 = value;
            }
        }

        public double Tipo_hono_porc_impto22
        {
            get
            {
                return tipo_hono_porc_impto22;
            }

            set
            {
                tipo_hono_porc_impto22 = value;
            }
        }

        public int Pla_cta_ide_impto3
        {
            get
            {
                return pla_cta_ide_impto3;
            }

            set
            {
                pla_cta_ide_impto3 = value;
            }
        }

        public int Auxi_ide_impto3
        {
            get
            {
                return auxi_ide_impto3;
            }

            set
            {
                auxi_ide_impto3 = value;
            }
        }

        public int Tipo_doc_ide_impto3
        {
            get
            {
                return tipo_doc_ide_impto3;
            }

            set
            {
                tipo_doc_ide_impto3 = value;
            }
        }

        public double Tipo_hono_monto_desde1_impto3
        {
            get
            {
                return tipo_hono_monto_desde1_impto3;
            }

            set
            {
                tipo_hono_monto_desde1_impto3 = value;
            }
        }

        public double Tipo_hono_monto_hasta1_impto3
        {
            get
            {
                return tipo_hono_monto_hasta1_impto3;
            }

            set
            {
                tipo_hono_monto_hasta1_impto3 = value;
            }
        }

        public double Tipo_hono_porc_impto3
        {
            get
            {
                return tipo_hono_porc_impto3;
            }

            set
            {
                tipo_hono_porc_impto3 = value;
            }
        }

        public int Pla_cta_ide_impto4
        {
            get
            {
                return pla_cta_ide_impto4;
            }

            set
            {
                pla_cta_ide_impto4 = value;
            }
        }

        public int Auxi_ide_impto4
        {
            get
            {
                return auxi_ide_impto4;
            }

            set
            {
                auxi_ide_impto4 = value;
            }
        }

        public int Tipo_doc_ide_impto4
        {
            get
            {
                return tipo_doc_ide_impto4;
            }

            set
            {
                tipo_doc_ide_impto4 = value;
            }
        }

        public double Tipo_hono_monto_desde1_impto4
        {
            get
            {
                return tipo_hono_monto_desde1_impto4;
            }

            set
            {
                tipo_hono_monto_desde1_impto4 = value;
            }
        }

        public double Tipo_hono_monto_hasta1_impto4
        {
            get
            {
                return tipo_hono_monto_hasta1_impto4;
            }

            set
            {
                tipo_hono_monto_hasta1_impto4 = value;
            }
        }

        public double Tipo_hono_porc_impto4
        {
            get
            {
                return tipo_hono_porc_impto4;
            }

            set
            {
                tipo_hono_porc_impto4 = value;
            }
        }

        public double Tipo_hono_tope_impto4
        {
            get
            {
                return tipo_hono_tope_impto4;
            }

            set
            {
                tipo_hono_tope_impto4 = value;
            }
        }

        public int Pla_cta_ide_total
        {
            get
            {
                return pla_cta_ide_total;
            }

            set
            {
                pla_cta_ide_total = value;
            }
        }

        public string Tipo_hono_estado
        {
            get
            {
                return tipo_hono_estado;
            }

            set
            {
                tipo_hono_estado = value;
            }
        }

        public DateTime Tipo_hono_fechainac
        {
            get
            {
                return tipo_hono_fechainac;
            }

            set
            {
                tipo_hono_fechainac = value;
            }
        }

        public double Tipo_hono_desde
        {
            get
            {
                return tipo_hono_desde;
            }

            set
            {
                tipo_hono_desde = value;
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
}
