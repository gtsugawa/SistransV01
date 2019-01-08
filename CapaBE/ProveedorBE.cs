using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaBE
{
    class ProveedorBE
    {
    }
    public class ClsProveedorBE
    {
        int prov_ide;
        string prov_codigo;
        string prov_razon_social;
        string prov_empresa;
        string prov_detraccion;
        string prov_relacionada;
        int docu_iden_ide;
        string prov_ruc;
        DateTime prov_fecha_constitucion;
        string prov_direccion;
        int loca_ide;
        string prov_telefono1;
        string prov_telefono2;
        string prov_fax;
        int tipo_prov_ide;
        int acti_prov_ide;
        int cate_prov_ide;
        string prov_correo;
        string prov_paterno;
        string prov_materno;
        string prov_nombre;
        string prov_estado;
        DateTime prov_fechainac;
        DateTime creacion;
        int veces;
        int pla_cta_ide;
        int tipo_hono_ide;
        string nombre_error;
        string texto_buscar;
        string usuario;

        public ClsProveedorBE()
        {
        }
        public ClsProveedorBE(int prov_ide, string prov_codigo, string prov_razon_social, string prov_empresa, string prov_detraccion,string prov_relacionada, int docu_iden_ide, string prov_ruc, DateTime prov_fecha_constitucion, string prov_direccion, int loca_ide, string prov_telefono1, string prov_telefono2, string prov_fax, int tipo_prov_ide, int acti_prov_ide, int cate_prov_ide, string prov_correo, string prov_paterno, string prov_materno, string prov_nombre, string prov_estado, DateTime prov_fechainac, DateTime creacion, int veces, string nombre_error, string texto_buscar, string usuario,int pla_cta_ide,int tipo_hono_ide)
        {
            this.prov_ide = prov_ide;
            this.prov_codigo = prov_codigo;
            this.prov_razon_social = prov_razon_social;
            this.prov_empresa = prov_empresa;
            this.prov_detraccion = prov_detraccion;
            this.prov_relacionada = prov_relacionada;
            this.docu_iden_ide = docu_iden_ide;
            this.prov_ruc = prov_ruc;
            this.prov_fecha_constitucion = prov_fecha_constitucion;
            this.prov_direccion = prov_direccion;
            this.loca_ide = loca_ide;
            this.prov_telefono1 = prov_telefono1;
            this.prov_telefono2 = prov_telefono2;
            this.prov_fax = prov_fax;
            this.tipo_prov_ide = tipo_prov_ide;
            this.acti_prov_ide = acti_prov_ide;
            this.cate_prov_ide = cate_prov_ide;
            this.prov_correo = prov_correo;
            this.prov_paterno = prov_paterno;
            this.prov_materno = prov_materno;
            this.prov_nombre = prov_nombre;
            this.prov_estado = prov_estado;
            this.prov_fechainac = prov_fechainac;
            this.creacion = creacion;
            this.veces = veces;
            this.nombre_error = nombre_error;
            this.texto_buscar = texto_buscar;
            this.usuario = usuario;
            this.pla_cta_ide = pla_cta_ide;
            this.tipo_hono_ide = tipo_hono_ide;
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

        public string Prov_codigo
        {
            get
            {
                return prov_codigo;
            }

            set
            {
                prov_codigo = value;
            }
        }

        public string Prov_razon_social
        {
            get
            {
                return prov_razon_social;
            }

            set
            {
                prov_razon_social = value;
            }
        }

        public string Prov_empresa
        {
            get
            {
                return prov_empresa;
            }

            set
            {
                prov_empresa = value;
            }
        }

        public string Prov_detraccion
        {
            get
            {
                return prov_detraccion;
            }

            set
            {
                prov_detraccion = value;
            }
        }
        public string Prov_relacionada
        {
            get
            {
                return prov_relacionada;
            }

            set
            {
                prov_relacionada = value;
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

        public string Prov_ruc
        {
            get
            {
                return prov_ruc;
            }

            set
            {
                prov_ruc = value;
            }
        }

        public DateTime Prov_fecha_constitucion
        {
            get
            {
                return prov_fecha_constitucion;
            }

            set
            {
                prov_fecha_constitucion = value;
            }
        }

        public string Prov_direccion
        {
            get
            {
                return prov_direccion;
            }

            set
            {
                prov_direccion = value;
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

        public string Prov_telefono1
        {
            get
            {
                return prov_telefono1;
            }

            set
            {
                prov_telefono1 = value;
            }
        }

        public string Prov_telefono2
        {
            get
            {
                return prov_telefono2;
            }

            set
            {
                prov_telefono2 = value;
            }
        }

        public string Prov_fax
        {
            get
            {
                return prov_fax;
            }

            set
            {
                prov_fax = value;
            }
        }

        public int Tipo_prov_ide
        {
            get
            {
                return tipo_prov_ide;
            }

            set
            {
                tipo_prov_ide = value;
            }
        }

        public int Acti_prov_ide
        {
            get
            {
                return acti_prov_ide;
            }

            set
            {
                acti_prov_ide = value;
            }
        }

        public int Cate_prov_ide
        {
            get
            {
                return cate_prov_ide;
            }

            set
            {
                cate_prov_ide = value;
            }
        }

        public string Prov_correo
        {
            get
            {
                return prov_correo;
            }

            set
            {
                prov_correo = value;
            }
        }

        public string Prov_paterno
        {
            get
            {
                return prov_paterno;
            }

            set
            {
                prov_paterno = value;
            }
        }

        public string Prov_materno
        {
            get
            {
                return prov_materno;
            }

            set
            {
                prov_materno = value;
            }
        }

        public string Prov_nombre
        {
            get
            {
                return prov_nombre;
            }

            set
            {
                prov_nombre = value;
            }
        }

        public string Prov_estado
        {
            get
            {
                return prov_estado;
            }

            set
            {
                prov_estado = value;
            }
        }

        public DateTime Prov_fechainac
        {
            get
            {
                return prov_fechainac;
            }

            set
            {
                prov_fechainac = value;
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

        public int Pla_cta_ide
        {
            get
            {
                return pla_cta_ide;
            }

            set
            {
                pla_cta_ide = value;
            }
        }

        public int Tipo_hono_ide
        {
            get
            {
                return tipo_hono_ide;
            }

            set
            {
                tipo_hono_ide = value;
            }
        }
    }
}
