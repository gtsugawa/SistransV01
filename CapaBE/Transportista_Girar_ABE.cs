using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaBE
{
    class Transportista_Girar_ABE
    {
    }
    public class ClsTransportista_Girar_ABE
    {
        int tran_ide;
        int tran_gira_ide;
        string tran_gira_girar_a;
        DateTime creacion;
        int veces;
        string nombre_error;
        string texto_buscar;
        string usuario;

        public ClsTransportista_Girar_ABE()
        {
        }
        public ClsTransportista_Girar_ABE(int tran_ide, int tran_gira_ide, string tran_gira_girar_a, DateTime creacion, int veces, string nombre_error, string texto_buscar, string usuario)
        {
            this.tran_ide = tran_ide;
            this.tran_gira_ide = tran_gira_ide;
            this.tran_gira_girar_a = tran_gira_girar_a;
            this.creacion = creacion;
            this.veces = veces;
            this.nombre_error = nombre_error;
            this.texto_buscar = texto_buscar;
            this.usuario = usuario;
        }

        public int Tran_ide
        {
            get
            {
                return tran_ide;
            }

            set
            {
                tran_ide = value;
            }
        }

        public int Tran_gira_ide
        {
            get
            {
                return tran_gira_ide;
            }

            set
            {
                tran_gira_ide = value;
            }
        }

        public string Tran_gira_girar_a
        {
            get
            {
                return tran_gira_girar_a;
            }

            set
            {
                tran_gira_girar_a = value;
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
