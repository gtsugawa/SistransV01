using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaBE
{
    class Categoria_ClienteBE
    {
    }
    public class ClsCategoria_ClienteBE
    {
        int cate_clie_ide;
        string cate_clie_nombre;
        string cate_clie_estado;
        DateTime cate_clie_fechainac;
        DateTime creacion;
        int veces;
        string nombre_error;
        string texto_buscar;
        string usuario;
       
        public ClsCategoria_ClienteBE()
        {
        }
        public ClsCategoria_ClienteBE(int cate_clie_ide, string cate_clie_nombre, string cate_clie_estado, DateTime cate_clie_fechainac, DateTime creacion, int veces,string nombre_error,string texto_buscar,string usuario)
        {
            this.cate_clie_ide = cate_clie_ide;
            this.cate_clie_nombre = cate_clie_nombre;
            this.cate_clie_estado = cate_clie_estado;
            this.cate_clie_fechainac = cate_clie_fechainac;
            this.creacion = creacion;
            this.veces = veces;
            this.nombre_error = nombre_error;
            this.texto_buscar = texto_buscar;
            this.usuario = usuario;
        }

        public int Cate_clie_ide
        {
            get
            {
                return cate_clie_ide;
            }

            set
            {
                cate_clie_ide = value;
            }
        }

        public string Cate_clie_nombre
        {
            get
            {
                return cate_clie_nombre;
            }

            set
            {
                cate_clie_nombre = value;
            }
        }

        public string Cate_clie_estado
        {
            get
            {
                return cate_clie_estado;
            }

            set
            {
                cate_clie_estado = value;
            }
        }

        public DateTime Cate_clie_fechainac
        {
            get
            {
                return cate_clie_fechainac;
            }

            set
            {
                cate_clie_fechainac = value;
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
            get { return nombre_error; }
            set { nombre_error = value; }
        }

        public string Texto_buscar
        {
            get { return texto_buscar; }
            set { texto_buscar = value; }
        }

        public string Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }
    }
}
