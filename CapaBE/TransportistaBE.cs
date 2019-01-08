using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaBE
{
    class TransportistaBE
    {
    }

    public class ClsTransportistaBE
    {
        int tran_ide;
        string tran_codigo;
        string tran_razon_social;
        string tran_empresa;
        string tran_ruc;
        DateTime tran_fecha_constitucion;
        string tran_direccion;
        int loca_ide;
        string tran_telefono1;
        string tran_telefono2;
        string tran_fax;
        string tran_correo;
        string tran_paterno;
        string tran_materno;
        string tran_nombre;
        string tran_estado;
        DateTime tran_fechainac;
        DateTime creacion;
        int veces;
        string nombre_error;
        string texto_buscar;
        string usuario;

        public ClsTransportistaBE()
        {
        }
        public ClsTransportistaBE(int tran_ide, string tran_codigo, string tran_razon_social, string tran_empresa, string tran_ruc, DateTime tran_fecha_constitucion, string tran_direccion, int loca_ide, string tran_telefono1, string tran_telefono2, string tran_fax, string tran_correo, string tran_paterno, string tran_materno, string tran_nombre, string tran_estado, DateTime tran_fechainac, DateTime creacion, int veces, string nombre_error, string texto_buscar, string usuario)
        {
            this.tran_ide = tran_ide;
            this.tran_codigo = tran_codigo;
            this.tran_razon_social = tran_razon_social;
            this.tran_empresa = tran_empresa;
            this.tran_ruc = tran_ruc;
            this.tran_fecha_constitucion = tran_fecha_constitucion;
            this.tran_direccion = tran_direccion;
            this.loca_ide = loca_ide;
            this.tran_telefono1 = tran_telefono1;
            this.tran_telefono2 = tran_telefono2;
            this.tran_fax = tran_fax;
            this.tran_correo = tran_correo;
            this.tran_paterno = tran_paterno;
            this.tran_materno = tran_materno;
            this.tran_nombre = tran_nombre;
            this.tran_estado = tran_estado;
            this.tran_fechainac = tran_fechainac;
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

        public string Tran_codigo
        {
            get
            {
                return tran_codigo;
            }

            set
            {
                tran_codigo = value;
            }
        }

        public string Tran_razon_social
        {
            get
            {
                return tran_razon_social;
            }

            set
            {
                tran_razon_social = value;
            }
        }

        public string Tran_empresa
        {
            get
            {
                return tran_empresa;
            }

            set
            {
                tran_empresa = value;
            }
        }

        public string Tran_ruc
        {
            get
            {
                return tran_ruc;
            }

            set
            {
                tran_ruc = value;
            }
        }

        public DateTime Tran_fecha_constitucion
        {
            get
            {
                return tran_fecha_constitucion;
            }

            set
            {
                tran_fecha_constitucion = value;
            }
        }

        public string Tran_direccion
        {
            get
            {
                return tran_direccion;
            }

            set
            {
                tran_direccion = value;
            }
        }

        public int Loca_ide
        {
            get
            {
                return loca_ide;
            }

            set
            {
                loca_ide = value;
            }
        }

        public string Tran_telefono1
        {
            get
            {
                return tran_telefono1;
            }

            set
            {
                tran_telefono1 = value;
            }
        }

        public string Tran_telefono2
        {
            get
            {
                return tran_telefono2;
            }

            set
            {
                tran_telefono2 = value;
            }
        }

        public string Tran_fax
        {
            get
            {
                return tran_fax;
            }

            set
            {
                tran_fax = value;
            }
        }

        public string Tran_correo
        {
            get
            {
                return tran_correo;
            }

            set
            {
                tran_correo = value;
            }
        }

        public string Tran_paterno
        {
            get
            {
                return tran_paterno;
            }

            set
            {
                tran_paterno = value;
            }
        }

        public string Tran_materno
        {
            get
            {
                return tran_materno;
            }

            set
            {
                tran_materno = value;
            }
        }

        public string Tran_nombre
        {
            get
            {
                return tran_nombre;
            }

            set
            {
                tran_nombre = value;
            }
        }

        public string Tran_estado
        {
            get
            {
                return tran_estado;
            }

            set
            {
                tran_estado = value;
            }
        }

        public DateTime Tran_fechainac
        {
            get
            {
                return tran_fechainac;
            }

            set
            {
                tran_fechainac = value;
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
