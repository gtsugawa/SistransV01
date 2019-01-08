using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaBE
{
    class ArticuloBE
    {
    }
    public class ClsArticuloBE
    {
        int arti_ide;
        string arti_tipo;
        string arti_nombre;
        string arti_modelo;
        string arti_codigo;
        string arti_estado;
        DateTime arti_fechainac;
        string nombre_error;
        string texto_buscar;
        string usuario;
        public ClsArticuloBE()
        {
        }
        public ClsArticuloBE(int arti_ide, string arti_tipo, string arti_nombre, string arti_modelo, string arti_codigo, string arti_estado, DateTime arti_fechainac, string nombre_error, string texto_buscar, string usuario)
        {
            this.arti_ide = arti_ide;
            this.arti_tipo = arti_tipo;
            this.arti_nombre = arti_nombre;
            this.arti_modelo = arti_modelo;
            this.arti_codigo = arti_codigo;
            this.arti_estado = arti_estado;
            this.arti_fechainac = arti_fechainac;
            this.nombre_error = nombre_error;
            this.texto_buscar = texto_buscar;
            this.usuario = usuario;
        }

        public int Arti_ide
        {
            get
            {
                return arti_ide;
            }

            set
            {
                arti_ide = value;
            }
        }

        public string Arti_tipo
        {
            get
            {
                return arti_tipo;
            }

            set
            {
                arti_tipo = value;
            }
        }

        public string Arti_nombre
        {
            get
            {
                return arti_nombre;
            }

            set
            {
                arti_nombre = value;
            }
        }

        public string Arti_modelo
        {
            get
            {
                return arti_modelo;
            }

            set
            {
                arti_modelo = value;
            }
        }

        public string Arti_codigo
        {
            get
            {
                return arti_codigo;
            }

            set
            {
                arti_codigo = value;
            }
        }

        public string Arti_estado
        {
            get
            {
                return arti_estado;
            }

            set
            {
                arti_estado = value;
            }
        }

        public DateTime Arti_fechainac
        {
            get
            {
                return arti_fechainac;
            }

            set
            {
                arti_fechainac = value;
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
