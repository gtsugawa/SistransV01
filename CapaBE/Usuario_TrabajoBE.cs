using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaBE
{
    class Usuario_TrabajoBE
    {
    }
    public class ClsUsuario_TrabajoBE
    {
        String nombre_terminal;
        String usuario_terminal;
        int empr_ide;
        String usuario;
        String clave;
        Boolean estado;
        public ClsUsuario_TrabajoBE()
        {
        }
        public ClsUsuario_TrabajoBE(string nombre_terminal, string usuario_terminal, int empr_ide, string usuario, string clave, bool estado)
        {
            this.nombre_terminal = nombre_terminal;
            this.usuario_terminal = usuario_terminal;
            this.empr_ide = empr_ide;
            this.usuario = usuario;
            this.clave = clave;
            this.estado = estado;
        }

        public string Nombre_terminal
        {
            get
            {
                return nombre_terminal;
            }

            set
            {
                nombre_terminal = value;
            }
        }

        public string Usuario_terminal
        {
            get
            {
                return usuario_terminal;
            }

            set
            {
                usuario_terminal = value;
            }
        }

        public int Empr_ide
        {
            get
            {
                return empr_ide;
            }

            set
            {
                empr_ide = value;
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

        public bool Estado
        {
            get
            {
                return estado;
            }

            set
            {
                estado = value;
            }
        }
    }
}
