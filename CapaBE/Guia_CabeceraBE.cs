using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaBE
{
    class Guia_CabeceraBE
    {
    }
    public class ClsGuia_CabeceraBE
    {
        int guia_ide;
        int reco_ide;
        string serie_numero_guia;
        int guia_numero_guia;
        DateTime guia_fecha_emision;
        DateTime guia_fecha_traslado;
        string guia_estado;
        int guia_numero_item;
        int guia_estado_digitacion;
        int veces;
        string nombre_error;
        string texto_buscar;
        string usuario;
        public ClsGuia_CabeceraBE()
        {
        }
        public ClsGuia_CabeceraBE(int guia_ide, int reco_ide, string serie_numero_guia, int guia_numero_guia, DateTime guia_fecha_emision, DateTime guia_fecha_traslado, string guia_estado, int guia_numero_item, int guia_estado_digitacion, int veces, string nombre_error, string texto_buscar, string usuario)
        {
            this.guia_ide = guia_ide;
            this.reco_ide = reco_ide;
            this.serie_numero_guia = serie_numero_guia;
            this.guia_numero_guia = guia_numero_guia;
            this.guia_fecha_emision = guia_fecha_emision;
            this.guia_fecha_traslado = guia_fecha_traslado;
            this.guia_estado = guia_estado;
            this.guia_numero_item = guia_numero_item;
            this.guia_estado_digitacion = guia_estado_digitacion;
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

        public int Reco_ide
        {
            get
            {
                return reco_ide;
            }

            set
            {
                reco_ide = value;
            }
        }

        public string Serie_numero_guia
        {
            get
            {
                return serie_numero_guia;
            }

            set
            {
                serie_numero_guia = value;
            }
        }

        public int Guia_numero_guia
        {
            get
            {
                return guia_numero_guia;
            }

            set
            {
                guia_numero_guia = value;
            }
        }

        public DateTime Guia_fecha_emision
        {
            get
            {
                return guia_fecha_emision;
            }

            set
            {
                guia_fecha_emision = value;
            }
        }

        public DateTime Guia_fecha_traslado
        {
            get
            {
                return guia_fecha_traslado;
            }

            set
            {
                guia_fecha_traslado = value;
            }
        }

        public string Guia_estado
        {
            get
            {
                return guia_estado;
            }

            set
            {
                guia_estado = value;
            }
        }

        public int Guia_numero_item
        {
            get
            {
                return guia_numero_item;
            }

            set
            {
                guia_numero_item = value;
            }
        }

        public int Guia_estado_digitacion
        {
            get
            {
                return guia_estado_digitacion;
            }

            set
            {
                guia_estado_digitacion = value;
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
