using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaBE
{
    class Categoria_ProveedorBE
    {
    }
    public class ClsCategoria_ProveedorBE
    {
        int cate_prov_ide;
        string cate_prov_nombre;
        string cate_prov_estado;
        DateTime cate_prov_fechainac;
        DateTime creacion;
        int veces;
        string nombre_error;
        string texto_buscar;
        string usuario;
        public ClsCategoria_ProveedorBE()
        {
        }
        public ClsCategoria_ProveedorBE(int cate_prov_ide, string cate_prov_nombre, string cate_prov_estado, DateTime cate_prov_fechainac, DateTime creacion, int veces, string nombre_error, string texto_buscar, string usuario)
        {
            this.cate_prov_ide = cate_prov_ide;
            this.cate_prov_nombre = cate_prov_nombre;
            this.cate_prov_estado = cate_prov_estado;
            this.cate_prov_fechainac = cate_prov_fechainac;
            this.creacion = creacion;
            this.veces = veces;
            this.nombre_error = nombre_error;
            this.texto_buscar = texto_buscar;
            this.usuario = usuario;
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

        public string Cate_prov_nombre
        {
            get
            {
                return cate_prov_nombre;
            }

            set
            {
                cate_prov_nombre = value;
            }
        }

        public string Cate_prov_estado
        {
            get
            {
                return cate_prov_estado;
            }

            set
            {
                cate_prov_estado = value;
            }
        }

        public DateTime Cate_prov_fechainac
        {
            get
            {
                return cate_prov_fechainac;
            }

            set
            {
                cate_prov_fechainac = value;
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
