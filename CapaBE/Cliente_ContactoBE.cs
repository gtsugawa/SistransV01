using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaBE
{
    class Cliente_ContactoBE
    {
    }
    public class ClsCliente_ContactoBE
    {
        int clie_ide;
        int clie_cont_ide;
        string clie_cont_titulo;
        string clie_cont_paterno;
        string clie_cont_materno;
        string clie_cont_nombre;
        int carg_ide;
        string clie_cont_direccion;
        int loca_ide;
        string clie_cont_telefono_casa;
        string clie_cont_telefono_celular;
        string clie_cont_fax;
        int docu_iden_ide;
        string clie_cont_documento;
        string clie_cont_fecha_nacimiento;
        string clie_cont_sexo;
        string clie_cont_estado_civil;
        string clie_cont_correo;
        string clie_cont_nota;
        DateTime creacion;
        int veces;
        int lrc_ide;
        string nombre_error;
        string texto_buscar;
        string usuario;
        public ClsCliente_ContactoBE()
        {
        }
        public ClsCliente_ContactoBE(int clie_ide, int clie_cont_ide, string clie_cont_titulo, string clie_cont_paterno, string clie_cont_materno, string clie_cont_nombre, int carg_ide, string clie_cont_direccion, int loca_ide, string clie_cont_telefono_casa, string clie_cont_telefono_celular, string clie_cont_fax, int docu_iden_ide, string clie_cont_documento, string clie_cont_fecha_nacimiento, string clie_cont_sexo, string clie_cont_estado_civil, string clie_cont_correo, string clie_cont_nota, DateTime creacion, int veces, int lrc_ide, string nombre_error, string texto_buscar, string usuario)
        {
            this.clie_ide = clie_ide;
            this.clie_cont_ide = clie_cont_ide;
            this.clie_cont_titulo = clie_cont_titulo;
            this.clie_cont_paterno = clie_cont_paterno;
            this.clie_cont_materno = clie_cont_materno;
            this.clie_cont_nombre = clie_cont_nombre;
            this.carg_ide = carg_ide;
            this.clie_cont_direccion = clie_cont_direccion;
            this.loca_ide = loca_ide;
            this.clie_cont_telefono_casa = clie_cont_telefono_casa;
            this.clie_cont_telefono_celular = clie_cont_telefono_celular;
            this.clie_cont_fax = clie_cont_fax;
            this.docu_iden_ide = docu_iden_ide;
            this.clie_cont_documento = clie_cont_documento;
            this.clie_cont_fecha_nacimiento = clie_cont_fecha_nacimiento;
            this.clie_cont_sexo = clie_cont_sexo;
            this.clie_cont_estado_civil = clie_cont_estado_civil;
            this.clie_cont_correo = clie_cont_correo;
            this.clie_cont_nota = clie_cont_nota;
            this.creacion = creacion;
            this.veces = veces;
            this.lrc_ide = lrc_ide;
            this.nombre_error = nombre_error;
            this.texto_buscar = texto_buscar;
            this.usuario = usuario;
        }

        public int Clie_ide
        {
            get
            {
                return clie_ide;
            }

            set
            {
                clie_ide = value;
            }
        }

        public int Clie_cont_ide
        {
            get
            {
                return clie_cont_ide;
            }

            set
            {
                clie_cont_ide = value;
            }
        }

        public string Clie_cont_titulo
        {
            get
            {
                return clie_cont_titulo;
            }

            set
            {
                clie_cont_titulo = value;
            }
        }

        public string Clie_cont_paterno
        {
            get
            {
                return clie_cont_paterno;
            }

            set
            {
                clie_cont_paterno = value;
            }
        }

        public string Clie_cont_materno
        {
            get
            {
                return clie_cont_materno;
            }

            set
            {
                clie_cont_materno = value;
            }
        }

        public string Clie_cont_nombre
        {
            get
            {
                return clie_cont_nombre;
            }

            set
            {
                clie_cont_nombre = value;
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

        public string Clie_cont_direccion
        {
            get
            {
                return clie_cont_direccion;
            }

            set
            {
                clie_cont_direccion = value;
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

        public string Clie_cont_telefono_casa
        {
            get
            {
                return clie_cont_telefono_casa;
            }

            set
            {
                clie_cont_telefono_casa = value;
            }
        }

        public string Clie_cont_telefono_celular
        {
            get
            {
                return clie_cont_telefono_celular;
            }

            set
            {
                clie_cont_telefono_celular = value;
            }
        }

        public string Clie_cont_fax
        {
            get
            {
                return clie_cont_fax;
            }

            set
            {
                clie_cont_fax = value;
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

        public string Clie_cont_documento
        {
            get
            {
                return clie_cont_documento;
            }

            set
            {
                clie_cont_documento = value;
            }
        }

        public string Clie_cont_fecha_nacimiento
        {
            get
            {
                return clie_cont_fecha_nacimiento;
            }

            set
            {
                clie_cont_fecha_nacimiento = value;
            }
        }

        public string Clie_cont_sexo
        {
            get
            {
                return clie_cont_sexo;
            }

            set
            {
                clie_cont_sexo = value;
            }
        }

        public string Clie_cont_estado_civil
        {
            get
            {
                return clie_cont_estado_civil;
            }

            set
            {
                clie_cont_estado_civil = value;
            }
        }

        public string Clie_cont_correo
        {
            get
            {
                return clie_cont_correo;
            }

            set
            {
                clie_cont_correo = value;
            }
        }

        public string Clie_cont_nota
        {
            get
            {
                return clie_cont_nota;
            }

            set
            {
                clie_cont_nota = value;
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

        public int Lrc_ide
        {
            get
            {
                return lrc_ide;
            }

            set
            {
                lrc_ide = value;
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
