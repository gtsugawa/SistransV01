using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaBE
{
    class Gasto_OperacionBE
    {
    }
    public class ClsGasto_OperacionBE
    {
        int gto_ope_ide;
        string gto_ope_nombre;
        int pla_cta_ide;
        int linea_nego_ide;
        int cost_prod_ide;
        int acti_prod_ide;
        string gto_ope_estado;
        DateTime gto_ope_fechainac;
        DateTime creacion;
        int veces;
        string nombre_error;
        string texto_buscar;
        string usuario;

        public ClsGasto_OperacionBE()
        {
        }
        public ClsGasto_OperacionBE(int gto_ope_ide, string gto_ope_nombre, int pla_cta_ide, int linea_nego_ide, int cost_prod_ide, int acti_prod_ide, string gto_ope_estado, DateTime gto_ope_fechainac, DateTime creacion, int veces, string nombre_error, string texto_buscar, string usuario)
        {
            this.gto_ope_ide = gto_ope_ide;
            this.gto_ope_nombre = gto_ope_nombre;
            this.pla_cta_ide = pla_cta_ide;
            this.linea_nego_ide = linea_nego_ide;
            this.cost_prod_ide = cost_prod_ide;
            this.acti_prod_ide = acti_prod_ide;
            this.gto_ope_estado = gto_ope_estado;
            this.gto_ope_fechainac = gto_ope_fechainac;
            this.creacion = creacion;
            this.veces = veces;
            this.nombre_error = nombre_error;
            this.texto_buscar = texto_buscar;
            this.usuario = usuario;
        }

        public int Gto_ope_ide
        {
            get
            {
                return gto_ope_ide;
            }

            set
            {
                gto_ope_ide = value;
            }
        }

        public string Gto_ope_nombre
        {
            get
            {
                return gto_ope_nombre;
            }

            set
            {
                gto_ope_nombre = value;
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

        public string Gto_ope_estado
        {
            get
            {
                return gto_ope_estado;
            }

            set
            {
                gto_ope_estado = value;
            }
        }

        public DateTime Gto_ope_fechainac
        {
            get
            {
                return gto_ope_fechainac;
            }

            set
            {
                gto_ope_fechainac = value;
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
