using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaBE
{
    class EmpresaBE
    {
    }
    public class ClsEmpresaBE
    {
        int empr_ide;
        string empr_nombre_empresa;
        string empr_servidor;
        string empr_proveedor;
        string empr_usuario;
        string empr_clave;
        string empr_nombre_bd;
        int empr_tiempo;
        string empr_contabilidad_dolar;
        string empr_codigo_registro;
        string empr_exonerado_impuesto;
        string empr_nuevo_pc;
        int veces;
        int empr_ide_anterior;
        public ClsEmpresaBE()
        {
        }

        public ClsEmpresaBE(int empr_ide, string empr_nombre_empresa, string empr_servidor, string empr_proveedor, string empr_usuario, string empr_clave, string empr_nombre_bd, int empr_tiempo, string empr_contabilidad_dolar, string empr_codigo_registro, string empr_exonerado_impuesto, string empr_nuevo_pc, int veces, int empr_ide_anterior)
        {
            this.empr_ide = empr_ide;
            this.empr_nombre_empresa = empr_nombre_empresa;
            this.empr_servidor = empr_servidor;
            this.empr_proveedor = empr_proveedor;
            this.empr_usuario = empr_usuario;
            this.empr_clave = empr_clave;
            this.empr_nombre_bd = empr_nombre_bd;
            this.empr_tiempo = empr_tiempo;
            this.empr_contabilidad_dolar = empr_contabilidad_dolar;
            this.empr_codigo_registro = empr_codigo_registro;
            this.empr_exonerado_impuesto = empr_exonerado_impuesto;
            this.empr_nuevo_pc = empr_nuevo_pc;
            this.veces = veces;
            this.empr_ide_anterior = empr_ide_anterior;
        }

        public int Empr_ide
        {
            get
            {
                return empr_ide;
            }

            set
            {
                empr_ide = value;
            }
        }

        public string Empr_nombre_empresa
        {
            get
            {
                return empr_nombre_empresa;
            }

            set
            {
                empr_nombre_empresa = value;
            }
        }

        public string Empr_servidor
        {
            get
            {
                return empr_servidor;
            }

            set
            {
                empr_servidor = value;
            }
        }

        public string Empr_proveedor
        {
            get
            {
                return empr_proveedor;
            }

            set
            {
                empr_proveedor = value;
            }
        }

        public string Empr_usuario
        {
            get
            {
                return empr_usuario;
            }

            set
            {
                empr_usuario = value;
            }
        }

        public string Empr_clave
        {
            get
            {
                return empr_clave;
            }

            set
            {
                empr_clave = value;
            }
        }

        public string Empr_nombre_bd
        {
            get
            {
                return empr_nombre_bd;
            }

            set
            {
                empr_nombre_bd = value;
            }
        }

        public int Empr_tiempo
        {
            get
            {
                return empr_tiempo;
            }

            set
            {
                empr_tiempo = value;
            }
        }

        public string Empr_contabilidad_dolar
        {
            get
            {
                return empr_contabilidad_dolar;
            }

            set
            {
                empr_contabilidad_dolar = value;
            }
        }

        public string Empr_codigo_registro
        {
            get
            {
                return empr_codigo_registro;
            }

            set
            {
                empr_codigo_registro = value;
            }
        }

        public string Empr_exonerado_impuesto
        {
            get
            {
                return empr_exonerado_impuesto;
            }

            set
            {
                empr_exonerado_impuesto = value;
            }
        }

        public string Empr_nuevo_pc
        {
            get
            {
                return empr_nuevo_pc;
            }

            set
            {
                empr_nuevo_pc = value;
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

        public int Empr_ide_anterior
        {
            get
            {
                return empr_ide_anterior;
            }

            set
            {
                empr_ide_anterior = value;
            }
        }
    }
}
