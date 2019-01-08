using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaBE
{
    class Marca_VehiculoBE
    {
    }
    public class ClsMarca_VehiculoBE
    {
        int marca_vehi_ide;
        string marca_vehi_nombre;
        string marca_vehi_estado;
        DateTime marca_vehi_fechainac;
        DateTime creacion;
        int veces;
        string nombre_error;
        string texto_buscar;
        string usuario;

        public ClsMarca_VehiculoBE()
        {

        }
        public ClsMarca_VehiculoBE(int marca_vehi_ide, string marca_vehi_nombre, string marca_vehi_estado, DateTime marca_vehi_fechainac, DateTime creacion, int veces, string nombre_error, string texto_buscar, string usuario)
        {
            this.marca_vehi_ide = marca_vehi_ide;
            this.marca_vehi_nombre = marca_vehi_nombre;
            this.marca_vehi_estado = marca_vehi_estado;
            this.marca_vehi_fechainac = marca_vehi_fechainac;
            this.creacion = creacion;
            this.veces = veces;
            this.nombre_error = nombre_error;
            this.texto_buscar = texto_buscar;
            this.usuario = usuario;
        }

        public int Marca_vehi_ide
        {
            get
            {
                return marca_vehi_ide;
            }

            set
            {
                marca_vehi_ide = value;
            }
        }

        public string Marca_vehi_nombre
        {
            get
            {
                return marca_vehi_nombre;
            }

            set
            {
                marca_vehi_nombre = value;
            }
        }

        public string Marca_vehi_estado
        {
            get
            {
                return marca_vehi_estado;
            }

            set
            {
                marca_vehi_estado = value;
            }
        }

        public DateTime Marca_vehi_fechainac
        {
            get
            {
                return marca_vehi_fechainac;
            }

            set
            {
                marca_vehi_fechainac = value;
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
