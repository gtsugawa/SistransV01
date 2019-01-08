using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaBE
{
    class Proveedor_ContactoBE
    {
    }
    public class ClsProveedor_ContactoBE
    {
        int prov_ide;
        int prov_cont_ide;
        string prov_cont_titulo;
        string prov_cont_paterno;
        string prov_cont_materno;
        string prov_cont_nombre;
        int carg_ide;
        string prov_cont_direccion;
        int loca_ide;
        string prov_cont_telefono_casa;
        string prov_cont_telefono_celular;
        string prov_cont_fax;
        int docu_iden_ide;
        string prov_cont_documento;
        string prov_cont_fecha_nacimiento;
        string prov_cont_sexo;
        string prov_cont_estado_civil;
        string prov_cont_correo;
        string prov_cont_nota;
        DateTime creacion;
        int veces;
        string nombre_error;
        string texto_buscar;
        string usuario;
        public ClsProveedor_ContactoBE()
        {
        }
        public ClsProveedor_ContactoBE(int prov_ide, int prov_cont_ide, string prov_cont_titulo, string prov_cont_paterno, string prov_cont_materno, string prov_cont_nombre, int carg_ide, string prov_cont_direccion, int loca_ide, string prov_cont_telefono_casa, string prov_cont_telefono_celular, string prov_cont_fax, int docu_iden_ide, string prov_cont_documento, string prov_cont_fecha_nacimiento, string prov_cont_sexo, string prov_cont_estado_civil, string prov_cont_correo, string prov_cont_nota, DateTime creacion, int veces, string nombre_error, string texto_buscar, string usuario)
        {
            this.prov_ide = prov_ide;
            this.prov_cont_ide = prov_cont_ide;
            this.prov_cont_titulo = prov_cont_titulo;
            this.prov_cont_paterno = prov_cont_paterno;
            this.prov_cont_materno = prov_cont_materno;
            this.prov_cont_nombre = prov_cont_nombre;
            this.carg_ide = carg_ide;
            this.prov_cont_direccion = prov_cont_direccion;
            this.loca_ide = loca_ide;
            this.prov_cont_telefono_casa = prov_cont_telefono_casa;
            this.prov_cont_telefono_celular = prov_cont_telefono_celular;
            this.prov_cont_fax = prov_cont_fax;
            this.docu_iden_ide = docu_iden_ide;
            this.prov_cont_documento = prov_cont_documento;
            this.prov_cont_fecha_nacimiento = prov_cont_fecha_nacimiento;
            this.prov_cont_sexo = prov_cont_sexo;
            this.prov_cont_estado_civil = prov_cont_estado_civil;
            this.prov_cont_correo = prov_cont_correo;
            this.prov_cont_nota = prov_cont_nota;
            this.creacion = creacion;
            this.veces = veces;
            this.nombre_error = nombre_error;
            this.texto_buscar = texto_buscar;
            this.usuario = usuario;
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

        public int Prov_cont_ide
        {
            get
            {
                return prov_cont_ide;
            }

            set
            {
                prov_cont_ide = value;
            }
        }

        public string Prov_cont_titulo
        {
            get
            {
                return prov_cont_titulo;
            }

            set
            {
                prov_cont_titulo = value;
            }
        }

        public string Prov_cont_paterno
        {
            get
            {
                return prov_cont_paterno;
            }

            set
            {
                prov_cont_paterno = value;
            }
        }

        public string Prov_cont_materno
        {
            get
            {
                return prov_cont_materno;
            }

            set
            {
                prov_cont_materno = value;
            }
        }

        public string Prov_cont_nombre
        {
            get
            {
                return prov_cont_nombre;
            }

            set
            {
                prov_cont_nombre = value;
            }
        }

        public int Carg_ide
        {
            get
            {
                return carg_ide;
            }

            set
            {
                carg_ide = value;
            }
        }

        public string Prov_cont_direccion
        {
            get
            {
                return prov_cont_direccion;
            }

            set
            {
                prov_cont_direccion = value;
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

        public string Prov_cont_telefono_casa
        {
            get
            {
                return prov_cont_telefono_casa;
            }

            set
            {
                prov_cont_telefono_casa = value;
            }
        }

        public string Prov_cont_telefono_celular
        {
            get
            {
                return prov_cont_telefono_celular;
            }

            set
            {
                prov_cont_telefono_celular = value;
            }
        }

        public string Prov_cont_fax
        {
            get
            {
                return prov_cont_fax;
            }

            set
            {
                prov_cont_fax = value;
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

        public string Prov_cont_documento
        {
            get
            {
                return prov_cont_documento;
            }

            set
            {
                prov_cont_documento = value;
            }
        }

        public string Prov_cont_fecha_nacimiento
        {
            get
            {
                return prov_cont_fecha_nacimiento;
            }

            set
            {
                prov_cont_fecha_nacimiento = value;
            }
        }

        public string Prov_cont_sexo
        {
            get
            {
                return prov_cont_sexo;
            }

            set
            {
                prov_cont_sexo = value;
            }
        }

        public string Prov_cont_estado_civil
        {
            get
            {
                return prov_cont_estado_civil;
            }

            set
            {
                prov_cont_estado_civil = value;
            }
        }

        public string Prov_cont_correo
        {
            get
            {
                return prov_cont_correo;
            }

            set
            {
                prov_cont_correo = value;
            }
        }

        public string Prov_cont_nota
        {
            get
            {
                return prov_cont_nota;
            }

            set
            {
                prov_cont_nota = value;
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
