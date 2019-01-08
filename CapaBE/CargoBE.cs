using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaBE
{
    class CargoBE
    {
    }
    public class ClsCargoBE
    {
        int carg_ide;
        string carg_nombre;
        string carg_codigo_sunat;
        string carg_nombre_sunat;
        string carg_estado;
        DateTime carg_fechainac;
        DateTime creacion;
        int veces;
        string nombre_error;
        string texto_buscar;
        string usuario;
        public ClsCargoBE()
        {
        }
        public ClsCargoBE(int carg_ide, string carg_nombre, string carg_codigo_sunat, string carg_nombre_sunat, string carg_estado, DateTime carg_fechainac, DateTime creacion, int veces, string nombre_error, string texto_buscar, string usuario)
        {
            this.carg_ide = carg_ide;
            this.carg_nombre = carg_nombre;
            this.carg_codigo_sunat = carg_codigo_sunat;
            this.carg_nombre_sunat = carg_nombre_sunat;
            this.carg_estado = carg_estado;
            this.carg_fechainac = carg_fechainac;
            this.creacion = creacion;
            this.veces = veces;
            this.nombre_error = nombre_error;
            this.texto_buscar = texto_buscar;
            this.usuario = usuario;
        }

        public int Carg_ide
        {
            get
            {
                return carg_ide;
            }

            set
            {
                carg_ide = value;
            }
        }

        public string Carg_nombre
        {
            get
            {
                return carg_nombre;
            }

            set
            {
                carg_nombre = value;
            }
        }

        public string Carg_codigo_sunat
        {
            get
            {
                return carg_codigo_sunat;
            }

            set
            {
                carg_codigo_sunat = value;
            }
        }

        public string Carg_nombre_sunat
        {
            get
            {
                return carg_nombre_sunat;
            }

            set
            {
                carg_nombre_sunat = value;
            }
        }

        public string Carg_estado
        {
            get
            {
                return carg_estado;
            }

            set
            {
                carg_estado = value;
            }
        }

        public DateTime Carg_fechainac
        {
            get
            {
                return carg_fechainac;
            }

            set
            {
                carg_fechainac = value;
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
