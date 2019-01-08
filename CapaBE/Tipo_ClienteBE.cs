using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaBE
{
    class Tipo_ClienteBE
    {
    }
    public class ClsTipo_ClienteBE
    {
        int tipo_clie_ide;
        string tipo_clie_nombre;
        int pla_cta_ide_factura_local;
        int pla_cta_ide_factura_dolar;
        int pla_cta_ide_factura_local_diferida;
        int pla_cta_ide_factura_dolar_diferida;
        int pla_cta_ide_n_debito_local;
        int pla_cta_ide_n_debito_dolar;
        int pla_cta_ide_n_debito_local_diferida;
        int pla_cta_ide_n_debito_dolar_diferida;
        int pla_cta_ide_n_credito_local;
        int pla_cta_ide_n_credito_dolar;
        int pla_cta_ide_n_credito_local_diferida;
        int pla_cta_ide_n_credito_dolar_diferida;
        int pla_cta_ide_boleta_local;
        int pla_cta_ide_boleta_dolar;
        int pla_cta_ide_boleta_local_diferida;
        int pla_cta_ide_boleta_dolar_diferida;
        string tipo_clie_estado;
        DateTime tipo_clie_fechainac;
        DateTime creacion;
        int veces;
        string nombre_error;
        string texto_buscar;
        string usuario;

        public ClsTipo_ClienteBE()
        {
        }

        public ClsTipo_ClienteBE(int tipo_clie_ide, string tipo_clie_nombre, int pla_cta_ide_factura_local, int pla_cta_ide_factura_dolar, int pla_cta_ide_factura_local_diferida, int pla_cta_ide_factura_dolar_diferida, int pla_cta_ide_n_debito_local, int pla_cta_ide_n_debito_dolar, int pla_cta_ide_n_debito_local_diferida, int pla_cta_ide_n_debito_dolar_diferida, int pla_cta_ide_n_credito_local, int pla_cta_ide_n_credito_dolar, int pla_cta_ide_n_credito_local_diferida, int pla_cta_ide_n_credito_dolar_diferida, int pla_cta_ide_boleta_local, int pla_cta_ide_boleta_dolar, int pla_cta_ide_boleta_local_diferida, int pla_cta_ide_boleta_dolar_diferida, string tipo_clie_estado, DateTime tipo_clie_fechainac, DateTime creacion, int veces, string nombre_error, string texto_buscar, string usuario)
        {
            this.tipo_clie_ide = tipo_clie_ide;
            this.tipo_clie_nombre = tipo_clie_nombre;
            this.pla_cta_ide_factura_local = pla_cta_ide_factura_local;
            this.pla_cta_ide_factura_dolar = pla_cta_ide_factura_dolar;
            this.pla_cta_ide_factura_local_diferida = pla_cta_ide_factura_local_diferida;
            this.pla_cta_ide_factura_dolar_diferida = pla_cta_ide_factura_dolar_diferida;
            this.pla_cta_ide_n_debito_local = pla_cta_ide_n_debito_local;
            this.pla_cta_ide_n_debito_dolar = pla_cta_ide_n_debito_dolar;
            this.pla_cta_ide_n_debito_local_diferida = pla_cta_ide_n_debito_local_diferida;
            this.pla_cta_ide_n_debito_dolar_diferida = pla_cta_ide_n_debito_dolar_diferida;
            this.pla_cta_ide_n_credito_local = pla_cta_ide_n_credito_local;
            this.pla_cta_ide_n_credito_dolar = pla_cta_ide_n_credito_dolar;
            this.pla_cta_ide_n_credito_local_diferida = pla_cta_ide_n_credito_local_diferida;
            this.pla_cta_ide_n_credito_dolar_diferida = pla_cta_ide_n_credito_dolar_diferida;
            this.pla_cta_ide_boleta_local = pla_cta_ide_boleta_local;
            this.pla_cta_ide_boleta_dolar = pla_cta_ide_boleta_dolar;
            this.pla_cta_ide_boleta_local_diferida = pla_cta_ide_boleta_local_diferida;
            this.pla_cta_ide_boleta_dolar_diferida = pla_cta_ide_boleta_dolar_diferida;
            this.tipo_clie_estado = tipo_clie_estado;
            this.tipo_clie_fechainac = tipo_clie_fechainac;
            this.creacion = creacion;
            this.veces = veces;
            this.nombre_error = nombre_error;
            this.texto_buscar = texto_buscar;
            this.usuario = usuario;
        }

        public int Tipo_clie_ide
        {
            get
            {
                return tipo_clie_ide;
            }

            set
            {
                tipo_clie_ide = value;
            }
        }

        public string Tipo_clie_nombre
        {
            get
            {
                return tipo_clie_nombre;
            }

            set
            {
                tipo_clie_nombre = value;
            }
        }

        public int Pla_cta_ide_factura_local
        {
            get
            {
                return pla_cta_ide_factura_local;
            }

            set
            {
                pla_cta_ide_factura_local = value;
            }
        }

        public int Pla_cta_ide_factura_dolar
        {
            get
            {
                return pla_cta_ide_factura_dolar;
            }

            set
            {
                pla_cta_ide_factura_dolar = value;
            }
        }

        public int Pla_cta_ide_factura_local_diferida
        {
            get
            {
                return pla_cta_ide_factura_local_diferida;
            }

            set
            {
                pla_cta_ide_factura_local_diferida = value;
            }
        }

        public int Pla_cta_ide_factura_dolar_diferida
        {
            get
            {
                return pla_cta_ide_factura_dolar_diferida;
            }

            set
            {
                pla_cta_ide_factura_dolar_diferida = value;
            }
        }

        public int Pla_cta_ide_n_debito_local
        {
            get
            {
                return pla_cta_ide_n_debito_local;
            }

            set
            {
                pla_cta_ide_n_debito_local = value;
            }
        }

        public int Pla_cta_ide_n_debito_dolar
        {
            get
            {
                return pla_cta_ide_n_debito_dolar;
            }

            set
            {
                pla_cta_ide_n_debito_dolar = value;
            }
        }

        public int Pla_cta_ide_n_debito_local_diferida
        {
            get
            {
                return pla_cta_ide_n_debito_local_diferida;
            }

            set
            {
                pla_cta_ide_n_debito_local_diferida = value;
            }
        }

        public int Pla_cta_ide_n_debito_dolar_diferida
        {
            get
            {
                return pla_cta_ide_n_debito_dolar_diferida;
            }

            set
            {
                pla_cta_ide_n_debito_dolar_diferida = value;
            }
        }

        public int Pla_cta_ide_n_credito_local
        {
            get
            {
                return pla_cta_ide_n_credito_local;
            }

            set
            {
                pla_cta_ide_n_credito_local = value;
            }
        }

        public int Pla_cta_ide_n_credito_dolar
        {
            get
            {
                return pla_cta_ide_n_credito_dolar;
            }

            set
            {
                pla_cta_ide_n_credito_dolar = value;
            }
        }

        public int Pla_cta_ide_n_credito_local_diferida
        {
            get
            {
                return pla_cta_ide_n_credito_local_diferida;
            }

            set
            {
                pla_cta_ide_n_credito_local_diferida = value;
            }
        }

        public int Pla_cta_ide_n_credito_dolar_diferida
        {
            get
            {
                return pla_cta_ide_n_credito_dolar_diferida;
            }

            set
            {
                pla_cta_ide_n_credito_dolar_diferida = value;
            }
        }

        public int Pla_cta_ide_boleta_local
        {
            get
            {
                return pla_cta_ide_boleta_local;
            }

            set
            {
                pla_cta_ide_boleta_local = value;
            }
        }

        public int Pla_cta_ide_boleta_dolar
        {
            get
            {
                return pla_cta_ide_boleta_dolar;
            }

            set
            {
                pla_cta_ide_boleta_dolar = value;
            }
        }

        public int Pla_cta_ide_boleta_local_diferida
        {
            get
            {
                return pla_cta_ide_boleta_local_diferida;
            }

            set
            {
                pla_cta_ide_boleta_local_diferida = value;
            }
        }

        public int Pla_cta_ide_boleta_dolar_diferida
        {
            get
            {
                return pla_cta_ide_boleta_dolar_diferida;
            }

            set
            {
                pla_cta_ide_boleta_dolar_diferida = value;
            }
        }

        public string Tipo_clie_estado
        {
            get
            {
                return tipo_clie_estado;
            }

            set
            {
                tipo_clie_estado = value;
            }
        }

        public DateTime Tipo_clie_fechainac
        {
            get
            {
                return tipo_clie_fechainac;
            }

            set
            {
                tipo_clie_fechainac = value;
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
