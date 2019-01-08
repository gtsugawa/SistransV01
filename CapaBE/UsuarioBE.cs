using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaBE
{
    class UsuarioBE
    {
    }
    public class ClsUsuarioBE
    {
        string usuario;
        string nombre;
        string cargo_usuario;
        string clave;
        string modulos;
        public ClsUsuarioBE()
        {
        }
        public ClsUsuarioBE(string usuario, string nombre, string cargo_usuario, string clave, string modulos)
        {
            this.usuario = usuario;
            this.nombre = nombre;
            this.cargo_usuario = cargo_usuario;
            this.clave = clave;
            this.modulos = modulos;
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

        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }

        public string Cargo_usuario
        {
            get
            {
                return cargo_usuario;
            }

            set
            {
                cargo_usuario = value;
            }
        }

        public string Clave
        {
            get
            {
                return clave;
            }

            set
            {
                clave = value;
            }
        }

        public string Modulos
        {
            get
            {
                return modulos;
            }

            set
            {
                modulos = value;
            }
        }
    }
}
