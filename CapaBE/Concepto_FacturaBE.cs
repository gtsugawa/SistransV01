using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaBE
{
    class Concepto_FacturaBE
    {
    }
    public class ClsConcepto_FacturaBE
    {
        int merca_ide;
        string merca_codigo;
        string merca_nombre;
        string merca_impuesto;
        bool merca_recargo;
       
        int pla_cta_ide;
        int pla_cta_ide_des;
        int pla_cta_ide_dev;
        int linea_nego_ide;
        int cost_prod_ide;
        int acti_prod_ide;
        string merca_estado;
        DateTime merca_fechainac;
        DateTime creacion;
        int veces;
        string nombre_error;
        string texto_buscar;
        string usuario;
        string merca_nombre_ingles;
        string merca_nombre2;
        int pla_cta_ide_relacionada;
        int pla_cta_ide_des_relacionada;
        int pla_cta_ide_dev_relacionada;
        public ClsConcepto_FacturaBE()
        {
        }
        public ClsConcepto_FacturaBE(int merca_ide, string merca_codigo, string merca_nombre, string merca_impuesto, bool merca_recargo, int pla_cta_ide, int pla_cta_ide_des, int pla_cta_ide_dev, int linea_nego_ide, int cost_prod_ide, int acti_prod_ide, string merca_estado, DateTime merca_fechainac, DateTime creacion, int veces, string nombre_error, string texto_buscar, string usuario,string merca_nombre_ingles,string merca_nombre2,int pla_cta_ide_relacionada,int pla_cta_ide_des_relacionada,int pla_cta_ide_dev_relacionada)
        {
            this.merca_ide = merca_ide;
            this.merca_codigo = merca_codigo;
            this.merca_nombre = merca_nombre;
            this.merca_nombre2 = merca_nombre2;
            this.merca_nombre_ingles = merca_nombre_ingles;
            this.merca_impuesto = merca_impuesto;
            this.merca_recargo = merca_recargo;
            this.pla_cta_ide = pla_cta_ide;
            this.pla_cta_ide_des = pla_cta_ide_des;
            this.pla_cta_ide_dev = pla_cta_ide_dev;
            this.pla_cta_ide_relacionada = pla_cta_ide_relacionada;
            this.pla_cta_ide_des_relacionada = pla_cta_ide_des_relacionada;
            this.pla_cta_ide_dev_relacionada = pla_cta_ide_dev_relacionada;
            this.linea_nego_ide = linea_nego_ide;
            this.cost_prod_ide = cost_prod_ide;
            this.acti_prod_ide = acti_prod_ide;
            this.merca_estado = merca_estado;
            this.merca_fechainac = merca_fechainac;
            this.creacion = creacion;
            this.veces = veces;
            this.nombre_error = nombre_error;
            this.texto_buscar = texto_buscar;
            this.usuario = usuario;
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

        public string Merca_codigo
        {
            get
            {
                return merca_codigo;
            }

            set
            {
                merca_codigo = value;
            }
        }

        public string Merca_nombre
        {
            get
            {
                return merca_nombre;
            }

            set
            {
                merca_nombre = value;
            }
        }

        public string Merca_impuesto
        {
            get
            {
                return merca_impuesto;
            }

            set
            {
                merca_impuesto = value;
            }
        }

        public bool Merca_recargo
        {
            get
            {
                return merca_recargo;
            }

            set
            {
                merca_recargo = value;
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

        public int Pla_cta_ide_des
        {
            get
            {
                return pla_cta_ide_des;
            }

            set
            {
                pla_cta_ide_des = value;
            }
        }

        public int Pla_cta_ide_dev
        {
            get
            {
                return pla_cta_ide_dev;
            }

            set
            {
                pla_cta_ide_dev = value;
            }
        }

        public int Linea_nego_ide
        {
            get
            {
                return linea_nego_ide;
            }

            set
            {
                linea_nego_ide = value;
            }
        }

        public int Cost_prod_ide
        {
            get
            {
                return cost_prod_ide;
            }

            set
            {
                cost_prod_ide = value;
            }
        }

        public int Acti_prod_ide
        {
            get
            {
                return acti_prod_ide;
            }

            set
            {
                acti_prod_ide = value;
            }
        }

        public string Merca_estado
        {
            get
            {
                return merca_estado;
            }

            set
            {
                merca_estado = value;
            }
        }

        public DateTime Merca_fechainac
        {
            get
            {
                return merca_fechainac;
            }

            set
            {
                merca_fechainac = value;
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

        public string Merca_nombre_ingles
        {
            get
            {
                return merca_nombre_ingles;
            }

            set
            {
                merca_nombre_ingles = value;
            }
        }

        public string Merca_nombre2
        {
            get
            {
                return merca_nombre2;
            }

            set
            {
                merca_nombre2 = value;
            }
        }

        public int Pla_cta_ide_relacionada
        {
            get
            {
                return pla_cta_ide_relacionada;
            }

            set
            {
                pla_cta_ide_relacionada = value;
            }
        }

        public int Pla_cta_ide_des_relacionada
        {
            get
            {
                return pla_cta_ide_des_relacionada;
            }

            set
            {
                pla_cta_ide_des_relacionada = value;
            }
        }

        public int Pla_cta_ide_dev_relacionada
        {
            get
            {
                return pla_cta_ide_dev_relacionada;
            }

            set
            {
                pla_cta_ide_dev_relacionada = value;
            }
        }
    }
}
