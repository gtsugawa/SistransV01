using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaBE
{
    class VendedorBE
    {
    }

    public class ClsVendedorBE
    {
        int vend_ide;
        string vend_codigo;
        string vend_razon_social;
        string vend_empresa;
        DateTime vend_fecha_nacimiento;
        string vend_direccion;
        int loca_ide;
        string vend_telefono1;
        string vend_telefono2;
        string vend_fax;
        int docu_iden_ide;
        string vend_documento;
        string vend_correo;
        string vend_paterno;
        string vend_materno;
        string vend_nombre;
        string vend_estado;
        DateTime vend_fechainac;
        DateTime creacion;
        int veces;
        string nombre_error;
        string texto_buscar;
        string usuario;

        public ClsVendedorBE()
        {
        }
        public ClsVendedorBE(int vend_ide, string vend_codigo, string vend_razon_social, string vend_empresa, DateTime vend_fecha_nacimiento, string vend_direccion, int loca_ide, string vend_telefono1, string vend_telefono2, string vend_fax, int docu_iden_ide, string vend_documento, string vend_correo, string vend_paterno, string vend_materno, string vend_nombre, string vend_estado, DateTime vend_fechainac, DateTime creacion, int veces, string nombre_error, string texto_buscar, string usuario)
        {
            this.vend_ide = vend_ide;
            this.vend_codigo = vend_codigo;
            this.vend_razon_social = vend_razon_social;
            this.vend_empresa = vend_empresa;
            this.vend_fecha_nacimiento = vend_fecha_nacimiento;
            this.vend_direccion = vend_direccion;
            this.loca_ide = loca_ide;
            this.vend_telefono1 = vend_telefono1;
            this.vend_telefono2 = vend_telefono2;
            this.vend_fax = vend_fax;
            this.docu_iden_ide = docu_iden_ide;
            this.vend_documento = vend_documento;
            this.vend_correo = vend_correo;
            this.vend_paterno = vend_paterno;
            this.vend_materno = vend_materno;
            this.vend_nombre = vend_nombre;
            this.vend_estado = vend_estado;
            this.vend_fechainac = vend_fechainac;
            this.creacion = creacion;
            this.veces = veces;
            this.nombre_error = nombre_error;
            this.texto_buscar = texto_buscar;
            this.usuario = usuario;
        }

        public int Vend_ide
        {
            get
            {
                return vend_ide;
            }

            set
            {
                vend_ide = value;
            }
        }

        public string Vend_codigo
        {
            get
            {
                return vend_codigo;
            }

            set
            {
                vend_codigo = value;
            }
        }

        public string Vend_razon_social
        {
            get
            {
                return vend_razon_social;
            }

            set
            {
                vend_razon_social = value;
            }
        }

        public string Vend_empresa
        {
            get
            {
                return vend_empresa;
            }

            set
            {
                vend_empresa = value;
            }
        }

        public DateTime Vend_fecha_nacimiento
        {
            get
            {
                return vend_fecha_nacimiento;
            }

            set
            {
                vend_fecha_nacimiento = value;
            }
        }

        public string Vend_direccion
        {
            get
            {
                return vend_direccion;
            }

            set
            {
                vend_direccion = value;
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

        public string Vend_telefono1
        {
            get
            {
                return vend_telefono1;
            }

            set
            {
                vend_telefono1 = value;
            }
        }

        public string Vend_telefono2
        {
            get
            {
                return vend_telefono2;
            }

            set
            {
                vend_telefono2 = value;
            }
        }

        public string Vend_fax
        {
            get
            {
                return vend_fax;
            }

            set
            {
                vend_fax = value;
            }
        }

        public int Docu_iden_ide
        {
            get
            {
                return docu_iden_ide;
            }

            set
            {
                docu_iden_ide = value;
            }
        }

        public string Vend_documento
        {
            get
            {
                return vend_documento;
            }

            set
            {
                vend_documento = value;
            }
        }

        public string Vend_correo
        {
            get
            {
                return vend_correo;
            }

            set
            {
                vend_correo = value;
            }
        }

        public string Vend_paterno
        {
            get
            {
                return vend_paterno;
            }

            set
            {
                vend_paterno = value;
            }
        }

        public string Vend_materno
        {
            get
            {
                return vend_materno;
            }

            set
            {
                vend_materno = value;
            }
        }

        public string Vend_nombre
        {
            get
            {
                return vend_nombre;
            }

            set
            {
                vend_nombre = value;
            }
        }

        public string Vend_estado
        {
            get
            {
                return vend_estado;
            }

            set
            {
                vend_estado = value;
            }
        }

        public DateTime Vend_fechainac
        {
            get
            {
                return vend_fechainac;
            }

            set
            {
                vend_fechainac = value;
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
