using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaBE
{
    class Tipo_ProductoBE
    {
    }
    public class ClsTipo_ProductoBE
    {
        int tipo_prod_ide;
        string tipo_prod_nombre;
        string tipo_prod_estado;
        DateTime tipo_prod_fechainac;
        DateTime creacion;
        int veces;
        string nombre_error;
        string texto_buscar;
        string usuario;
        public ClsTipo_ProductoBE()
        {
        }
        public ClsTipo_ProductoBE(int tipo_prod_ide, string tipo_prod_nombre, string tipo_prod_estado, DateTime tipo_prod_fechainac, DateTime creacion, int veces, string nombre_error, string texto_buscar, string usuario)
        {
            this.tipo_prod_ide = tipo_prod_ide;
            this.tipo_prod_nombre = tipo_prod_nombre;
            this.tipo_prod_estado = tipo_prod_estado;
            this.tipo_prod_fechainac = tipo_prod_fechainac;
            this.creacion = creacion;
            this.veces = veces;
            this.nombre_error = nombre_error;
            this.texto_buscar = texto_buscar;
            this.usuario = usuario;
        }

        public int Tipo_prod_ide
        {
            get
            {
                return tipo_prod_ide;
            }

            set
            {
                tipo_prod_ide = value;
            }
        }

        public string Tipo_prod_nombre
        {
            get
            {
                return tipo_prod_nombre;
            }

            set
            {
                tipo_prod_nombre = value;
            }
        }

        public string Tipo_prod_estado
        {
            get
            {
                return tipo_prod_estado;
            }

            set
            {
                tipo_prod_estado = value;
            }
        }

        public DateTime Tipo_prod_fechainac
        {
            get
            {
                return tipo_prod_fechainac;
            }

            set
            {
                tipo_prod_fechainac = value;
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
