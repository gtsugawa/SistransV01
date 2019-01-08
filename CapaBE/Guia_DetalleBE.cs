using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaBE
{
    class Guia_DetalleBE
    {
    }
    public class ClsGuia_DetalleBE
    {
        int guia_ide;
        int guia_ide_detalle;
        int reco_ide_detalle;
        int veces;
        string nombre_error;
        string texto_buscar;
        string usuario;

        public ClsGuia_DetalleBE()
        {
        }
        public ClsGuia_DetalleBE(int guia_ide, int guia_ide_detalle, int reco_ide_detalle, int veces, string nombre_error, string texto_buscar, string usuario)
        {
            this.guia_ide = guia_ide;
            this.guia_ide_detalle = guia_ide_detalle;
            this.reco_ide_detalle = reco_ide_detalle;
            this.veces = veces;
            this.nombre_error = nombre_error;
            this.texto_buscar = texto_buscar;
            this.usuario = usuario;
        }

        public int Guia_ide
        {
            get
            {
                return guia_ide;
            }

            set
            {
                guia_ide = value;
            }
        }

        public int Guia_ide_detalle
        {
            get
            {
                return guia_ide_detalle;
            }

            set
            {
                guia_ide_detalle = value;
            }
        }

        public int Reco_ide_detalle
        {
            get
            {
                return reco_ide_detalle;
            }

            set
            {
                reco_ide_detalle = value;
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
