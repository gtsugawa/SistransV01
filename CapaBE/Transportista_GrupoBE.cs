using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaBE
{
    class Transportista_GrupoBE
    {
    }

    public class ClsTransportista_GrupoBE
    {
        int tran_ide;
        int tran_gru_ide;
        int tran_gru_ide_transportista;
        DateTime creacion;
        int veces;
        string nombre_error;
        string texto_buscar;
        string usuario;

        public ClsTransportista_GrupoBE()
        {
        }
        public ClsTransportista_GrupoBE(int tran_ide, int tran_gru_ide, int tran_gru_ide_transportista, DateTime creacion, int veces, string nombre_error, string texto_buscar, string usuario)
        {
            this.tran_ide = tran_ide;
            this.tran_gru_ide = tran_gru_ide;
            this.tran_gru_ide_transportista = tran_gru_ide_transportista;
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

        public int Tran_gru_ide
        {
            get
            {
                return tran_gru_ide;
            }

            set
            {
                tran_gru_ide = value;
            }
        }

        public int Tran_gru_ide_transportista
        {
            get
            {
                return tran_gru_ide_transportista;
            }

            set
            {
                tran_gru_ide_transportista = value;
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
