using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaBE
{
    class Tipo_VehiculoBE
    {
    }
    public class ClsTipo_VehiculoBE
    {
        int tipo_vehi_ide;
        string tipo_vehi_nombre;
        string tipo_vehi_estado;
        DateTime tipo_vehi_fechainac;
        DateTime creacion;
        int veces;
        string nombre_error;
        string texto_buscar;
        string usuario;

        public ClsTipo_VehiculoBE()
        {
        }
        public ClsTipo_VehiculoBE(int tipo_vehi_ide, string tipo_vehi_nombre, string tipo_vehi_estado, DateTime tipo_vehi_fechainac, DateTime creacion, int veces, string nombre_error, string texto_buscar, string usuario)
        {
            this.tipo_vehi_ide = tipo_vehi_ide;
            this.tipo_vehi_nombre = tipo_vehi_nombre;
            this.tipo_vehi_estado = tipo_vehi_estado;
            this.tipo_vehi_fechainac = tipo_vehi_fechainac;
            this.creacion = creacion;
            this.veces = veces;
            this.nombre_error = nombre_error;
            this.texto_buscar = texto_buscar;
            this.usuario = usuario;
        }

        public int Tipo_vehi_ide
        {
            get
            {
                return tipo_vehi_ide;
            }

            set
            {
                tipo_vehi_ide = value;
            }
        }

        public string Tipo_vehi_nombre
        {
            get
            {
                return tipo_vehi_nombre;
            }

            set
            {
                tipo_vehi_nombre = value;
            }
        }

        public string Tipo_vehi_estado
        {
            get
            {
                return tipo_vehi_estado;
            }

            set
            {
                tipo_vehi_estado = value;
            }
        }

        public DateTime Tipo_vehi_fechainac
        {
            get
            {
                return tipo_vehi_fechainac;
            }

            set
            {
                tipo_vehi_fechainac = value;
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
