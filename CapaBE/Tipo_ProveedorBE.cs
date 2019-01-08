using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaBE
{
    class Tipo_ProveedorBE
    {
    }
    public class ClsTipo_ProveedorBE
    {
        int tipo_prov_ide;
        string tipo_prov_nombre;
        string tipo_prov_estado;
        DateTime tipo_prov_fechainac;
        DateTime creacion;
        int veces;
        string nombre_error;
        string texto_buscar;
        string usuario;
        public ClsTipo_ProveedorBE()
        {
        }
        public ClsTipo_ProveedorBE(int tipo_prov_ide, string tipo_prov_nombre, string tipo_prov_estado, DateTime tipo_prov_fechainac, DateTime creacion, int veces, string nombre_error, string texto_buscar, string usuario)
        {
            this.tipo_prov_ide = tipo_prov_ide;
            this.tipo_prov_nombre = tipo_prov_nombre;
            this.tipo_prov_estado = tipo_prov_estado;
            this.tipo_prov_fechainac = tipo_prov_fechainac;
            this.creacion = creacion;
            this.veces = veces;
            this.nombre_error = nombre_error;
            this.texto_buscar = texto_buscar;
            this.usuario = usuario;
        }

        public int Tipo_prov_ide
        {
            get
            {
                return tipo_prov_ide;
            }

            set
            {
                tipo_prov_ide = value;
            }
        }

        public string Tipo_prov_nombre
        {
            get
            {
                return tipo_prov_nombre;
            }

            set
            {
                tipo_prov_nombre = value;
            }
        }

        public string Tipo_prov_estado
        {
            get
            {
                return tipo_prov_estado;
            }

            set
            {
                tipo_prov_estado = value;
            }
        }

        public DateTime Tipo_prov_fechainac
        {
            get
            {
                return tipo_prov_fechainac;
            }

            set
            {
                tipo_prov_fechainac = value;
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
