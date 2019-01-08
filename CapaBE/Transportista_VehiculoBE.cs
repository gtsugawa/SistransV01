using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaBE
{
    class Transportista_VehiculoBE
    {
    }

    public class ClsTransportista_VehiculoBE
    {
        int tran_ide;
        int tran_vehi_ide;
        string tran_vehi_placa;
        string tran_vehi_configuracion;
        string tran_vehi_certificado;
        int marca_vehi_ide;
        int tipo_vehi_ide;
        int tran_vehi_año;
        int tran_vehi_tonelaje;
        int tran_vehi_volumen;
        string tran_vehi_tipo_freno;
        int color_ide;
        string tran_vehi_aro;
        string tran_vehi_serie;
        string tran_vehi_nombre;
        string tran_vehi_combustible;
        decimal tran_vehi_rendimiento;
        DateTime creacion;
        int veces;
        string nombre_error;
        string texto_buscar;
        string usuario;

        public ClsTransportista_VehiculoBE()
        {
        }
        public ClsTransportista_VehiculoBE(int tran_ide, int tran_vehi_ide, string tran_vehi_placa, string tran_vehi_configuracion, string tran_vehi_certificado, int marca_vehi_ide, int tipo_vehi_ide, int tran_vehi_año, int tran_vehi_tonelaje, int tran_vehi_volumen, string tran_vehi_tipo_freno, int color_ide, string tran_vehi_aro, string tran_vehi_serie, string tran_vehi_nombre, string tran_vehi_combustible, decimal tran_vehi_rendimiento, DateTime creacion, int veces, string nombre_error, string texto_buscar, string usuario)
        {
            this.tran_ide = tran_ide;
            this.tran_vehi_ide = tran_vehi_ide;
            this.tran_vehi_placa = tran_vehi_placa;
            this.tran_vehi_configuracion = tran_vehi_configuracion;
            this.tran_vehi_certificado = tran_vehi_certificado;
            this.marca_vehi_ide = marca_vehi_ide;
            this.tipo_vehi_ide = tipo_vehi_ide;
            this.tran_vehi_año = tran_vehi_año;
            this.tran_vehi_tonelaje = tran_vehi_tonelaje;
            this.tran_vehi_volumen = tran_vehi_volumen;
            this.tran_vehi_tipo_freno = tran_vehi_tipo_freno;
            this.color_ide = color_ide;
            this.tran_vehi_aro = tran_vehi_aro;
            this.tran_vehi_serie = tran_vehi_serie;
            this.tran_vehi_nombre = tran_vehi_nombre;
            this.tran_vehi_combustible = tran_vehi_combustible;
            this.tran_vehi_rendimiento = tran_vehi_rendimiento;
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

        public int Tran_vehi_ide
        {
            get
            {
                return tran_vehi_ide;
            }

            set
            {
                tran_vehi_ide = value;
            }
        }

        public string Tran_vehi_placa
        {
            get
            {
                return tran_vehi_placa;
            }

            set
            {
                tran_vehi_placa = value;
            }
        }

        public string Tran_vehi_configuracion
        {
            get
            {
                return tran_vehi_configuracion;
            }

            set
            {
                tran_vehi_configuracion = value;
            }
        }

        public string Tran_vehi_certificado
        {
            get
            {
                return tran_vehi_certificado;
            }

            set
            {
                tran_vehi_certificado = value;
            }
        }

        public int Marca_vehi_ide
        {
            get
            {
                return marca_vehi_ide;
            }

            set
            {
                marca_vehi_ide = value;
            }
        }

        public int Tipo_vehi_ide
        {
            get
            {
                return tipo_vehi_ide;
            }

            set
            {
                tipo_vehi_ide = value;
            }
        }

        public int Tran_vehi_año
        {
            get
            {
                return tran_vehi_año;
            }

            set
            {
                tran_vehi_año = value;
            }
        }

        public int Tran_vehi_tonelaje
        {
            get
            {
                return tran_vehi_tonelaje;
            }

            set
            {
                tran_vehi_tonelaje = value;
            }
        }

        public int Tran_vehi_volumen
        {
            get
            {
                return tran_vehi_volumen;
            }

            set
            {
                tran_vehi_volumen = value;
            }
        }

        public string Tran_vehi_tipo_freno
        {
            get
            {
                return tran_vehi_tipo_freno;
            }

            set
            {
                tran_vehi_tipo_freno = value;
            }
        }

        public int Color_ide
        {
            get
            {
                return color_ide;
            }

            set
            {
                color_ide = value;
            }
        }

        public string Tran_vehi_aro
        {
            get
            {
                return tran_vehi_aro;
            }

            set
            {
                tran_vehi_aro = value;
            }
        }

        public string Tran_vehi_serie
        {
            get
            {
                return tran_vehi_serie;
            }

            set
            {
                tran_vehi_serie = value;
            }
        }

        public string Tran_vehi_nombre
        {
            get
            {
                return tran_vehi_nombre;
            }

            set
            {
                tran_vehi_nombre = value;
            }
        }

        public string Tran_vehi_combustible
        {
            get
            {
                return tran_vehi_combustible;
            }

            set
            {
                tran_vehi_combustible = value;
            }
        }

        public decimal Tran_vehi_rendimiento
        {
            get
            {
                return tran_vehi_rendimiento;
            }

            set
            {
                tran_vehi_rendimiento = value;
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
