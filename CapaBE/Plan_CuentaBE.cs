using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaBE
{
    class Plan_CuentaBE
    {
    }
    public class ClsPlan_CuentaBE
    {
        int pla_cta_ide;
        string pla_cta_codigo;
        string pla_cta_nombre;
        string pla_cta_grupo;
        int pla_cta_tipo_banco;
        string pla_cta_banco;
        string pla_cta_auxiliar;
        string pla_cta_documento;
        int pla_cta_actividad;
        string pla_cta_tipo;
        string pla_cta_cta_contrapartida;
        string pla_cta_cta_cierre;
        string pla_cta_contrapartida;
        string pla_cta_estado;
        DateTime pla_cta_fechainac;
        string pla_cta_sunat;
        DateTime creacion;
        int veces;
        string nombre_error;
        string texto_buscar;
        string usuario;
        public ClsPlan_CuentaBE()
        {
        }
        public ClsPlan_CuentaBE(int pla_cta_ide, string pla_cta_codigo, string pla_cta_nombre, string pla_cta_grupo, int pla_cta_tipo_banco, string pla_cta_banco, string pla_cta_auxiliar, string pla_cta_documento, int pla_cta_actividad, string pla_cta_tipo, string pla_cta_cta_contrapartida, string pla_cta_cta_cierre, string pla_cta_contrapartida, string pla_cta_estado, DateTime pla_cta_fechainac, string pla_cta_sunat, DateTime creacion, int veces, string nombre_error, string texto_buscar, string usuario)
        {
            this.pla_cta_ide = pla_cta_ide;
            this.pla_cta_codigo = pla_cta_codigo;
            this.pla_cta_nombre = pla_cta_nombre;
            this.pla_cta_grupo = pla_cta_grupo;
            this.pla_cta_tipo_banco = pla_cta_tipo_banco;
            this.pla_cta_banco = pla_cta_banco;
            this.pla_cta_auxiliar = pla_cta_auxiliar;
            this.pla_cta_documento = pla_cta_documento;
            this.pla_cta_actividad = pla_cta_actividad;
            this.pla_cta_tipo = pla_cta_tipo;
            this.pla_cta_cta_contrapartida = pla_cta_cta_contrapartida;
            this.pla_cta_cta_cierre = pla_cta_cta_cierre;
            this.pla_cta_contrapartida = pla_cta_contrapartida;
            this.pla_cta_estado = pla_cta_estado;
            this.pla_cta_fechainac = pla_cta_fechainac;
            this.pla_cta_sunat = pla_cta_sunat;
            this.creacion = creacion;
            this.veces = veces;
            this.nombre_error = nombre_error;
            this.texto_buscar = texto_buscar;
            this.usuario = usuario;
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

        public string Pla_cta_codigo
        {
            get
            {
                return pla_cta_codigo;
            }

            set
            {
                pla_cta_codigo = value;
            }
        }

        public string Pla_cta_nombre
        {
            get
            {
                return pla_cta_nombre;
            }

            set
            {
                pla_cta_nombre = value;
            }
        }

        public string Pla_cta_grupo
        {
            get
            {
                return pla_cta_grupo;
            }

            set
            {
                pla_cta_grupo = value;
            }
        }

        public int Pla_cta_tipo_banco
        {
            get
            {
                return pla_cta_tipo_banco;
            }

            set
            {
                pla_cta_tipo_banco = value;
            }
        }

        public string Pla_cta_banco
        {
            get
            {
                return pla_cta_banco;
            }

            set
            {
                pla_cta_banco = value;
            }
        }

        public string Pla_cta_auxiliar
        {
            get
            {
                return pla_cta_auxiliar;
            }

            set
            {
                pla_cta_auxiliar = value;
            }
        }

        public string Pla_cta_documento
        {
            get
            {
                return pla_cta_documento;
            }

            set
            {
                pla_cta_documento = value;
            }
        }

        public int Pla_cta_actividad
        {
            get
            {
                return pla_cta_actividad;
            }

            set
            {
                pla_cta_actividad = value;
            }
        }

        public string Pla_cta_tipo
        {
            get
            {
                return pla_cta_tipo;
            }

            set
            {
                pla_cta_tipo = value;
            }
        }

        public string Pla_cta_cta_contrapartida
        {
            get
            {
                return pla_cta_cta_contrapartida;
            }

            set
            {
                pla_cta_cta_contrapartida = value;
            }
        }

        public string Pla_cta_cta_cierre
        {
            get
            {
                return pla_cta_cta_cierre;
            }

            set
            {
                pla_cta_cta_cierre = value;
            }
        }

        public string Pla_cta_contrapartida
        {
            get
            {
                return pla_cta_contrapartida;
            }

            set
            {
                pla_cta_contrapartida = value;
            }
        }

        public string Pla_cta_estado
        {
            get
            {
                return pla_cta_estado;
            }

            set
            {
                pla_cta_estado = value;
            }
        }

        public DateTime Pla_cta_fechainac
        {
            get
            {
                return pla_cta_fechainac;
            }

            set
            {
                pla_cta_fechainac = value;
            }
        }

        public string Pla_cta_sunat
        {
            get
            {
                return pla_cta_sunat;
            }

            set
            {
                pla_cta_sunat = value;
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
