using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaBE
{
    class Transportista_NotaBE
    {
    }

    public class ClsTransportista_NotaBE
    {
        int tran_ide;
        int tran_nota_ide;
        string tran_nota_nota;
        DateTime creacion;
        int veces;
        string nombre_error;
        string texto_buscar;
        string usuario;

        public ClsTransportista_NotaBE()
        {
        }
        public ClsTransportista_NotaBE(int tran_ide, int tran_nota_ide, string tran_nota_nota, DateTime creacion, int veces, string nombre_error, string texto_buscar, string usuario)
        {
            this.tran_ide = tran_ide;
            this.tran_nota_ide = tran_nota_ide;
            this.tran_nota_nota = tran_nota_nota;
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

        public int Tran_nota_ide
        {
            get
            {
                return tran_nota_ide;
            }

            set
            {
                tran_nota_ide = value;
            }
        }

        public string Tran_nota_nota
        {
            get
            {
                return tran_nota_nota;
            }

            set
            {
                tran_nota_nota = value;
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
