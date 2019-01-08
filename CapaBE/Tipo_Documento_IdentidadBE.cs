using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaBE
{
    class Tipo_Documento_IdentidadBE
    {
    }

    public class ClsTipo_Documento_IdentidadBE
    {
        int docu_iden_ide;
        string docu_iden_nombre;
        string docu_iden_codigo_sunat;
        string docu_iden_estado;
        DateTime docu_iden_fechainac;
        DateTime creacion;
        int veces;
        string nombre_error;
        string texto_buscar;
        string usuario;
        public ClsTipo_Documento_IdentidadBE()
        {
        }

        public ClsTipo_Documento_IdentidadBE(int docu_iden_ide, string docu_iden_nombre, string docu_iden_codigo_sunat,string docu_iden_estado, DateTime docu_iden_fechainac, DateTime creacion, int veces, string nombre_error, string texto_buscar, string usuario)
        {
            this.docu_iden_ide = docu_iden_ide;
            this.docu_iden_nombre = docu_iden_nombre;
            this.docu_iden_codigo_sunat = docu_iden_codigo_sunat;
            this.docu_iden_estado = docu_iden_estado;
            this.docu_iden_fechainac = docu_iden_fechainac;
            this.creacion = creacion;
            this.veces = veces;
            this.nombre_error = nombre_error;
            this.texto_buscar = texto_buscar;
            this.usuario = usuario;
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

        public string Docu_iden_nombre
        {
            get
            {
                return docu_iden_nombre;
            }

            set
            {
                docu_iden_nombre = value;
            }
        }
        public string Docu_iden_codigo_sunat
        {
            get
            {
                return docu_iden_codigo_sunat;
            }

            set
            {
                docu_iden_codigo_sunat = value;
            }
        }

        public string Docu_iden_estado
        {
            get
            {
                return docu_iden_estado;
            }

            set
            {
                docu_iden_estado = value;
            }
        }

        public DateTime Docu_iden_fechainac
        {
            get
            {
                return docu_iden_fechainac;
            }

            set
            {
                docu_iden_fechainac = value;
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
