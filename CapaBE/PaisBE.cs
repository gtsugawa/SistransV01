using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaBE
{
    class PaisBE
    {
    }
     public class ClsPaisBE
     {
        int pais_ide;
        string pais_nombre;
        string pais_estado;
        DateTime pais_fechainac;
        DateTime creacion;
        int veces;
        string nombre_error;
        string texto_buscar;
        string usuario;
    
        public ClsPaisBE()
        {
        }
        public ClsPaisBE(int pais_ide, string pais_nombre, string pais_estado, DateTime pais_fechainac, DateTime creacion, int veces, string nombre_error, string texto_buscar, string usuario)
        {
            this.pais_ide = pais_ide;
            this.pais_nombre = pais_nombre;
            this.pais_estado = pais_estado;
            this.pais_fechainac = pais_fechainac;
            this.creacion = creacion;
            this.veces = veces;
            this.nombre_error = nombre_error;
            this.texto_buscar = texto_buscar;
            this.usuario = usuario;
        }

        public int Pais_ide
        {
            get
            {
                return pais_ide;
            }

            set
            {
                pais_ide = value;
            }
        }

        public string Pais_nombre
        {
            get
            {
                return pais_nombre;
            }

            set
            {
                pais_nombre = value;
            }
        }

        public string Pais_estado
        {
            get
            {
                return pais_estado;
            }

            set
            {
                pais_estado = value;
            }
        }

        public DateTime Pais_fechainac
        {
            get
            {
                return pais_fechainac;
            }

            set
            {
                pais_fechainac = value;
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
