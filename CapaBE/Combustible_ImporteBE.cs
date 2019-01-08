using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaBE
{
    class Combustible_ImporteBE
    {
    }
    public class ClsCombustible_ImporteBE
    {
        int grifo_ide;
        int prov_ide;
        DateTime grifo_fecha;
        int grifo_tipo_combustible;
        Decimal grifo_importe;
        DateTime creacion;
        int veces;
        string nombre_error;
        string texto_buscar;
        string usuario;

        public ClsCombustible_ImporteBE()
        {
        }
        public ClsCombustible_ImporteBE(int grifo_ide, int prov_ide, DateTime grifo_fecha, int grifo_tipo_combustible, decimal grifo_importe, DateTime creacion, int veces, string nombre_error, string texto_buscar, string usuario)
        {
            this.grifo_ide = grifo_ide;
            this.prov_ide = prov_ide;
            this.grifo_fecha = grifo_fecha;
            this.grifo_tipo_combustible = grifo_tipo_combustible;
            this.grifo_importe = grifo_importe;
            this.creacion = creacion;
            this.veces = veces;
            this.nombre_error = nombre_error;
            this.texto_buscar = texto_buscar;
            this.usuario = usuario;
        }

        public int Grifo_ide
        {
            get
            {
                return grifo_ide;
            }

            set
            {
                grifo_ide = value;
            }
        }

        public int Prov_ide
        {
            get
            {
                return prov_ide;
            }

            set
            {
                prov_ide = value;
            }
        }

        public DateTime Grifo_fecha
        {
            get
            {
                return grifo_fecha;
            }

            set
            {
                grifo_fecha = value;
            }
        }

        public int Grifo_tipo_combustible
        {
            get
            {
                return grifo_tipo_combustible;
            }

            set
            {
                grifo_tipo_combustible = value;
            }
        }

        public decimal Grifo_importe
        {
            get
            {
                return grifo_importe;
            }

            set
            {
                grifo_importe = value;
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
