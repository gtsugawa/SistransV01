using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaBE
{
    class Serie_FacturacionBE
    {
    }
    public class ClsSerie_FacturacionBE
    {
        string serie_numero;
        int serie_factura_contador;
        int serie_factura_numero_lineas;
        int serie_n_debito_contador;
        int serie_n_debito_numero_lineas;
        int serie_n_credito_contador;
        int serie_n_credito_numero_lineas;
        int serie_boleta_contador;
        int serie_boleta_numero_lineas;
        int serie_doc_atribucion_contador;
        int serie_doc_atribucion_numero_lineas;
        string serie_nombre_lugar;
        string serie_terminal_formato;
        int tienda_ide;
        string serie_estado;
        DateTime serie_fechainac;
        DateTime creacion;
        int veces;
        string serie_numero_anterior;
        string nombre_error;
        string texto_buscar;
        string usuario;
        public ClsSerie_FacturacionBE()
        {
        }
        public ClsSerie_FacturacionBE(string serie_numero, int serie_factura_contador, int serie_factura_numero_lineas, int serie_n_debito_contador, int serie_n_debito_numero_lineas, int serie_n_credito_contador, int serie_n_credito_numero_lineas, int serie_boleta_contador, int serie_boleta_numero_lineas, int serie_doc_atribucion_contador, int serie_doc_atribucion_numero_lineas, string serie_nombre_lugar, string serie_terminal_formato, int tienda_ide, string serie_estado, DateTime serie_fechainac, DateTime creacion, int veces, string serie_numero_anterior, string nombre_error, string texto_buscar, string usuario)
        {
            this.serie_numero = serie_numero;
            this.serie_factura_contador = serie_factura_contador;
            this.serie_factura_numero_lineas = serie_factura_numero_lineas;
            this.serie_n_debito_contador = serie_n_debito_contador;
            this.serie_n_debito_numero_lineas = serie_n_debito_numero_lineas;
            this.serie_n_credito_contador = serie_n_credito_contador;
            this.serie_n_credito_numero_lineas = serie_n_credito_numero_lineas;
            this.serie_boleta_contador = serie_boleta_contador;
            this.serie_boleta_numero_lineas = serie_boleta_numero_lineas;
            this.serie_doc_atribucion_contador = serie_doc_atribucion_contador;
            this.serie_doc_atribucion_numero_lineas = serie_doc_atribucion_numero_lineas;
            this.serie_nombre_lugar = serie_nombre_lugar;
            this.serie_terminal_formato = serie_terminal_formato;
            this.tienda_ide = tienda_ide;
            this.serie_estado = serie_estado;
            this.serie_fechainac = serie_fechainac;
            this.creacion = creacion;
            this.veces = veces;
            this.serie_numero_anterior = serie_numero_anterior;
            this.nombre_error = nombre_error;
            this.texto_buscar = texto_buscar;
            this.usuario = usuario;
        }

        public string Serie_numero
        {
            get
            {
                return serie_numero;
            }

            set
            {
                serie_numero = value;
            }
        }
        public string Serie_numero_anterior
        {
            get
            {
                return serie_numero_anterior;
            }

            set
            {
                serie_numero_anterior = value;
            }
        }
        public int Serie_factura_contador
        {
            get
            {
                return serie_factura_contador;
            }

            set
            {
                serie_factura_contador = value;
            }
        }

        public int Serie_factura_numero_lineas
        {
            get
            {
                return serie_factura_numero_lineas;
            }

            set
            {
                serie_factura_numero_lineas = value;
            }
        }

        public int Serie_n_debito_contador
        {
            get
            {
                return serie_n_debito_contador;
            }

            set
            {
                serie_n_debito_contador = value;
            }
        }

        public int Serie_n_debito_numero_lineas
        {
            get
            {
                return serie_n_debito_numero_lineas;
            }

            set
            {
                serie_n_debito_numero_lineas = value;
            }
        }

        public int Serie_n_credito_contador
        {
            get
            {
                return serie_n_credito_contador;
            }

            set
            {
                serie_n_credito_contador = value;
            }
        }

        public int Serie_n_credito_numero_lineas
        {
            get
            {
                return serie_n_credito_numero_lineas;
            }

            set
            {
                serie_n_credito_numero_lineas = value;
            }
        }

        public int Serie_boleta_contador
        {
            get
            {
                return serie_boleta_contador;
            }

            set
            {
                serie_boleta_contador = value;
            }
        }

        public int Serie_boleta_numero_lineas
        {
            get
            {
                return serie_boleta_numero_lineas;
            }

            set
            {
                serie_boleta_numero_lineas = value;
            }
        }

        public int Serie_doc_atribucion_contador
        {
            get
            {
                return serie_doc_atribucion_contador;
            }

            set
            {
                serie_doc_atribucion_contador = value;
            }
        }

        public int Serie_doc_atribucion_numero_lineas
        {
            get
            {
                return serie_doc_atribucion_numero_lineas;
            }

            set
            {
                serie_doc_atribucion_numero_lineas = value;
            }
        }

        public string Serie_nombre_lugar
        {
            get
            {
                return serie_nombre_lugar;
            }

            set
            {
                serie_nombre_lugar = value;
            }
        }

        public string Serie_terminal_formato
        {
            get
            {
                return serie_terminal_formato;
            }

            set
            {
                serie_terminal_formato = value;
            }
        }

        public int Tienda_ide
        {
            get
            {
                return tienda_ide;
            }

            set
            {
                tienda_ide = value;
            }
        }

        public string Serie_estado
        {
            get
            {
                return serie_estado;
            }

            set
            {
                serie_estado = value;
            }
        }

        public DateTime Serie_fechainac
        {
            get
            {
                return serie_fechainac;
            }

            set
            {
                serie_fechainac = value;
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
