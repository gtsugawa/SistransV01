using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaBE
{
    class ColorBE
    {
    }
    public class ClsColorBE
    {
        int color_ide;
        string color_nombre;
        string color_estado;
        DateTime color_fechainac;
        DateTime creacion;
        int veces;
        string nombre_error;
        string texto_buscar;
        string usuario;

        public ClsColorBE()
        {
        }
        public ClsColorBE(int color_ide, string color_nombre, string color_estado, DateTime color_fechainac, DateTime creacion, int veces, string nombre_error, string texto_buscar, string usuario)
        {
            this.color_ide = color_ide;
            this.color_nombre = color_nombre;
            this.color_estado = color_estado;
            this.color_fechainac = color_fechainac;
            this.creacion = creacion;
            this.veces = veces;
            this.nombre_error = nombre_error;
            this.texto_buscar = texto_buscar;
            this.usuario = usuario;
        }

        public int Color_ide
        {
            get
            {
                return color_ide;
            }

            set
            {
                color_ide = value;
            }
        }

        public string Color_nombre
        {
            get
            {
                return color_nombre;
            }

            set
            {
                color_nombre = value;
            }
        }

        public string Color_estado
        {
            get
            {
                return color_estado;
            }

            set
            {
                color_estado = value;
            }
        }

        public DateTime Color_fechainac
        {
            get
            {
                return color_fechainac;
            }

            set
            {
                color_fechainac = value;
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
