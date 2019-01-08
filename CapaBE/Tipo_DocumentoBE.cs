using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaBE
{
    class Tipo_DocumentoBE
    {
    }
    public class ClsTipo_DocumentoBE
    {
        int tipo_doc_ide;
        string tipo_doc_codigo;
        string tipo_doc_nombre;
        string tipo_doc_abreviado;
        string tipo_doc_tipo;
        Boolean tipo_doc_chequea_duplicidad;
        string tipo_doc_codigo1;
        string tipo_doc_codigo_sunat;
        string tipo_doc_estado;
        DateTime tipo_doc_fechainac;
        DateTime creacion;
        int veces;
        string nombre_error;
        string texto_buscar;
        string usuario;
        public ClsTipo_DocumentoBE()
        {
        }

        public ClsTipo_DocumentoBE(int tipo_doc_ide, string tipo_doc_codigo, string tipo_doc_nombre, string tipo_doc_abreviado, string tipo_doc_tipo, bool tipo_doc_chequea_duplicidad, string tipo_doc_codigo1, string tipo_doc_codigo_sunat, string tipo_doc_estado, DateTime tipo_doc_fechainac, DateTime creacion, int veces, string nombre_error, string texto_buscar, string usuario)
        {
            this.tipo_doc_ide = tipo_doc_ide;
            this.tipo_doc_codigo = tipo_doc_codigo;
            this.tipo_doc_nombre = tipo_doc_nombre;
            this.tipo_doc_abreviado = tipo_doc_abreviado;
            this.tipo_doc_tipo = tipo_doc_tipo;
            this.tipo_doc_chequea_duplicidad = tipo_doc_chequea_duplicidad;
            this.tipo_doc_codigo1 = tipo_doc_codigo1;
            this.tipo_doc_codigo_sunat = tipo_doc_codigo_sunat;
            this.tipo_doc_estado = tipo_doc_estado;
            this.tipo_doc_fechainac = tipo_doc_fechainac;
            this.creacion = creacion;
            this.veces = veces;
            this.nombre_error = nombre_error;
            this.texto_buscar = texto_buscar;
            this.usuario = usuario;
        }

        public int Tipo_doc_ide
        {
            get
            {
                return tipo_doc_ide;
            }

            set
            {
                tipo_doc_ide = value;
            }
        }

        public string Tipo_doc_codigo
        {
            get
            {
                return tipo_doc_codigo;
            }

            set
            {
                tipo_doc_codigo = value;
            }
        }

        public string Tipo_doc_nombre
        {
            get
            {
                return tipo_doc_nombre;
            }

            set
            {
                tipo_doc_nombre = value;
            }
        }

        public string Tipo_doc_abreviado
        {
            get
            {
                return tipo_doc_abreviado;
            }

            set
            {
                tipo_doc_abreviado = value;
            }
        }

        public string Tipo_doc_tipo
        {
            get
            {
                return tipo_doc_tipo;
            }

            set
            {
                tipo_doc_tipo = value;
            }
        }

        public bool Tipo_doc_chequea_duplicidad
        {
            get
            {
                return tipo_doc_chequea_duplicidad;
            }

            set
            {
                tipo_doc_chequea_duplicidad = value;
            }
        }

        public string Tipo_doc_codigo1
        {
            get
            {
                return tipo_doc_codigo1;
            }

            set
            {
                tipo_doc_codigo1 = value;
            }
        }

        public string Tipo_doc_codigo_sunat
        {
            get
            {
                return tipo_doc_codigo_sunat;
            }

            set
            {
                tipo_doc_codigo_sunat = value;
            }
        }

        public string Tipo_doc_estado
        {
            get
            {
                return tipo_doc_estado;
            }

            set
            {
                tipo_doc_estado = value;
            }
        }

        public DateTime Tipo_doc_fechainac
        {
            get
            {
                return tipo_doc_fechainac;
            }

            set
            {
                tipo_doc_fechainac = value;
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
