using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaBE
{
    class Transportista_ChoferBE
    {
    }
    public class ClsTransportista_ChoferBE
    {
        int tran_ide;
        int tran_chof_ide;
        string tran_chof_titulo;
        string tran_chof_paterno;
        string tran_chof_materno;
        string tran_chof_nombre;
        string tran_chof_licencia;
        string tran_chof_direccion;
        int loca_ide;
        string tran_chof_telefono_casa;
        string tran_chof_telefono_celular;
        string tran_chof_fax;
        int docu_iden_ide;
        string tran_chof_documento;
        string tran_chof_fecha_nacimiento;
        DateTime tran_chof_fecha_ingreso;
        string tran_chof_sexo;
        string tran_chof_estado_civil;
        string tran_chof_correo;
        string tran_chof_nota;
        string tran_chof_vehiculo;
        string tran_chof_placa;
        string tran_chof_certificado;
        string tran_chof_nombre1;
        DateTime creacion;
        int veces;
        string nombre_error;
        string texto_buscar;
        string usuario;

        public ClsTransportista_ChoferBE()
        {

        }
        public ClsTransportista_ChoferBE(int tran_ide, int tran_chof_ide, string tran_chof_titulo, string tran_chof_paterno, string tran_chof_materno, string tran_chof_nombre, string tran_chof_licencia, string tran_chof_direccion, int loca_ide, string tran_chof_telefono_casa, string tran_chof_telefono_celular, string tran_chof_fax, int docu_iden_ide, string tran_chof_documento, string tran_chof_fecha_nacimiento, DateTime tran_chof_fecha_ingreso, string tran_chof_sexo, string tran_chof_estado_civil, string tran_chof_correo, string tran_chof_nota, DateTime creacion, int veces, string nombre_error, string texto_buscar, string usuario, string tran_chof_vehiculo,string tran_chof_placa,string tran_chof_certificado,string tran_chof_nombre1)
        {
            this.tran_ide = tran_ide;
            this.tran_chof_ide = tran_chof_ide;
            this.tran_chof_titulo = tran_chof_titulo;
            this.tran_chof_paterno = tran_chof_paterno;
            this.tran_chof_materno = tran_chof_materno;
            this.tran_chof_nombre = tran_chof_nombre;
            this.tran_chof_licencia = tran_chof_licencia;
            this.tran_chof_direccion = tran_chof_direccion;
            this.loca_ide = loca_ide;
            this.tran_chof_telefono_casa = tran_chof_telefono_casa;
            this.tran_chof_telefono_celular = tran_chof_telefono_celular;
            this.tran_chof_fax = tran_chof_fax;
            this.docu_iden_ide = docu_iden_ide;
            this.tran_chof_documento = tran_chof_documento;
            this.tran_chof_fecha_nacimiento = tran_chof_fecha_nacimiento;
            this.tran_chof_fecha_ingreso = tran_chof_fecha_ingreso;
            this.tran_chof_sexo = tran_chof_sexo;
            this.tran_chof_estado_civil = tran_chof_estado_civil; 
            this.tran_chof_correo = tran_chof_correo;
            this.tran_chof_nota = tran_chof_nota;
            this.creacion = creacion;
            this.veces = veces;
            this.nombre_error = nombre_error;
            this.texto_buscar = texto_buscar;
            this.usuario = usuario;
            this.tran_chof_vehiculo = tran_chof_vehiculo; 
            this.tran_chof_placa = tran_chof_placa;
            this.tran_chof_certificado = tran_chof_certificado;
            this.tran_chof_nombre1 = tran_chof_nombre1;
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

        public int Tran_chof_ide
        {
            get
            {
                return tran_chof_ide;
            }

            set
            {
                tran_chof_ide = value;
            }
        }

        public string Tran_chof_titulo
        {
            get
            {
                return tran_chof_titulo;
            }

            set
            {
                tran_chof_titulo = value;
            }
        }

        public string Tran_chof_paterno
        {
            get
            {
                return tran_chof_paterno;
            }

            set
            {
                tran_chof_paterno = value;
            }
        }

        public string Tran_chof_materno
        {
            get
            {
                return tran_chof_materno;
            }

            set
            {
                tran_chof_materno = value;
            }
        }

        public string Tran_chof_nombre
        {
            get
            {
                return tran_chof_nombre;
            }

            set
            {
                tran_chof_nombre = value;
            }
        }

        public string Tran_chof_licencia
        {
            get
            {
                return tran_chof_licencia;
            }

            set
            {
                tran_chof_licencia = value;
            }
        }

        public string Tran_chof_direccion
        {
            get
            {
                return tran_chof_direccion;
            }

            set
            {
                tran_chof_direccion = value;
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

        public string Tran_chof_telefono_casa
        {
            get
            {
                return tran_chof_telefono_casa;
            }

            set
            {
                tran_chof_telefono_casa = value;
            }
        }

        public string Tran_chof_telefono_celular
        {
            get
            {
                return tran_chof_telefono_celular;
            }

            set
            {
                tran_chof_telefono_celular = value;
            }
        }

        public string Tran_chof_fax
        {
            get
            {
                return tran_chof_fax;
            }

            set
            {
                tran_chof_fax = value;
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

        public string Tran_chof_documento
        {
            get
            {
                return tran_chof_documento;
            }

            set
            {
                tran_chof_documento = value;
            }
        }

        public string Tran_chof_fecha_nacimiento
        {
            get
            {
                return tran_chof_fecha_nacimiento;
            }

            set
            {
                tran_chof_fecha_nacimiento = value;
            }
        }

        public DateTime Tran_chof_fecha_ingreso
        {
            get
            {
                return tran_chof_fecha_ingreso;
            }

            set
            {
                tran_chof_fecha_ingreso = value;
            }
        }

        public string Tran_chof_sexo
        {
            get
            {
                return tran_chof_sexo;
            }

            set
            {
                tran_chof_sexo = value;
            }
        }

        public string Tran_chof_estado_civil
        {
            get
            {
                return tran_chof_estado_civil;
            }

            set
            {
                tran_chof_estado_civil = value;
            }
        }

        public string Tran_chof_correo
        {
            get
            {
                return tran_chof_correo;
            }

            set
            {
                tran_chof_correo = value;
            }
        }

        public string Tran_chof_nota
        {
            get
            {
                return tran_chof_nota;
            }

            set
            {
                tran_chof_nota = value;
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
        public string Tran_chof_vehiculo
        {
            get
            {
                return tran_chof_vehiculo;
            }

            set
            {
                tran_chof_vehiculo = value;
            }
        }

        public string Tran_chof_placa { get; set; }
        public string Tran_chof_certificado { get; set; }
        public string Tran_chof_nombre1 { get; set; }
    }
}
