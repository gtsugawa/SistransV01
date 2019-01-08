using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaBE
{
    class Transportista_ContactoBE
    {
    }
    public class ClsTransportista_ContactoBE
    {
        int tran_ide;
        int tran_cont_ide;
        string tran_cont_titulo;
        string tran_cont_paterno;
        string tran_cont_materno;
        string tran_cont_nombre;
        int carg_ide;
        string tran_cont_direccion;
        int loca_ide;
        string tran_cont_telefono_casa;
        string tran_cont_telefono_celular;
        string tran_cont_fax;
        int docu_iden_ide;
        string tran_cont_documento;
        string tran_cont_fecha_nacimiento;
        string tran_cont_sexo;
        string tran_cont_estado_civil;
        string tran_cont_correo;
        string tran_cont_nota;
        DateTime creacion;
        int veces;
        string nombre_error;
        string texto_buscar;
        string usuario;

        public ClsTransportista_ContactoBE()
        {
        }
        public ClsTransportista_ContactoBE(int tran_ide, int tran_cont_ide, string tran_cont_titulo, string tran_cont_paterno, string tran_cont_materno, string tran_cont_nombre, int carg_ide, string tran_cont_direccion, int loca_ide, string tran_cont_telefono_casa, string tran_cont_telefono_celular, string tran_cont_fax, int docu_iden_ide, string tran_cont_documento, string tran_cont_fecha_nacimiento, string tran_cont_sexo, string tran_cont_estado_civil, string tran_cont_correo, string tran_cont_nota, DateTime creacion, int veces, string nombre_error, string texto_buscar, string usuario)
        {
            this.tran_ide = tran_ide;
            this.tran_cont_ide = tran_cont_ide;
            this.tran_cont_titulo = tran_cont_titulo;
            this.tran_cont_paterno = tran_cont_paterno;
            this.tran_cont_materno = tran_cont_materno;
            this.tran_cont_nombre = tran_cont_nombre;
            this.carg_ide = carg_ide;
            this.tran_cont_direccion = tran_cont_direccion;
            this.loca_ide = loca_ide;
            this.tran_cont_telefono_casa = tran_cont_telefono_casa;
            this.tran_cont_telefono_celular = tran_cont_telefono_celular;
            this.tran_cont_fax = tran_cont_fax;
            this.docu_iden_ide = docu_iden_ide;
            this.tran_cont_documento = tran_cont_documento;
            this.tran_cont_fecha_nacimiento = tran_cont_fecha_nacimiento;
            this.tran_cont_sexo = tran_cont_sexo;
            this.tran_cont_estado_civil = tran_cont_estado_civil;
            this.tran_cont_correo = tran_cont_correo;
            this.tran_cont_nota = tran_cont_nota;
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

        public int Tran_cont_ide
        {
            get
            {
                return tran_cont_ide;
            }

            set
            {
                tran_cont_ide = value;
            }
        }

        public string Tran_cont_titulo
        {
            get
            {
                return tran_cont_titulo;
            }

            set
            {
                tran_cont_titulo = value;
            }
        }

        public string Tran_cont_paterno
        {
            get
            {
                return tran_cont_paterno;
            }

            set
            {
                tran_cont_paterno = value;
            }
        }

        public string Tran_cont_materno
        {
            get
            {
                return tran_cont_materno;
            }

            set
            {
                tran_cont_materno = value;
            }
        }

        public string Tran_cont_nombre
        {
            get
            {
                return tran_cont_nombre;
            }

            set
            {
                tran_cont_nombre = value;
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

        public string Tran_cont_direccion
        {
            get
            {
                return tran_cont_direccion;
            }

            set
            {
                tran_cont_direccion = value;
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

        public string Tran_cont_telefono_casa
        {
            get
            {
                return tran_cont_telefono_casa;
            }

            set
            {
                tran_cont_telefono_casa = value;
            }
        }

        public string Tran_cont_telefono_celular
        {
            get
            {
                return tran_cont_telefono_celular;
            }

            set
            {
                tran_cont_telefono_celular = value;
            }
        }

        public string Tran_cont_fax
        {
            get
            {
                return tran_cont_fax;
            }

            set
            {
                tran_cont_fax = value;
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

        public string Tran_cont_documento
        {
            get
            {
                return tran_cont_documento;
            }

            set
            {
                tran_cont_documento = value;
            }
        }

        public string Tran_cont_fecha_nacimiento
        {
            get
            {
                return tran_cont_fecha_nacimiento;
            }

            set
            {
                tran_cont_fecha_nacimiento = value;
            }
        }

        public string Tran_cont_sexo
        {
            get
            {
                return tran_cont_sexo;
            }

            set
            {
                tran_cont_sexo = value;
            }
        }

        public string Tran_cont_estado_civil
        {
            get
            {
                return tran_cont_estado_civil;
            }

            set
            {
                tran_cont_estado_civil = value;
            }
        }

        public string Tran_cont_correo
        {
            get
            {
                return tran_cont_correo;
            }

            set
            {
                tran_cont_correo = value;
            }
        }

        public string Tran_cont_nota
        {
            get
            {
                return tran_cont_nota;
            }

            set
            {
                tran_cont_nota = value;
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
