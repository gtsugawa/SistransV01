using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaBE
{
    class AlmacenBE
    {
    }
    public class ClsAlmacenBE
    {
        int alma_ide;
        string alma_codigo;
        string alma_nombre;
        string alma_venta;
        string alma_direccion;
        int loca_ide;
        string alma_estado;
        DateTime alma_fechainac;
        DateTime creacion;
        int veces;
        string nombre_error;
        string texto_buscar;
        string usuario;
        public ClsAlmacenBE()
        {
        }
        public ClsAlmacenBE(int alma_ide, string alma_codigo, string alma_nombre,string alma_venta, string alma_direccion, int loca_ide, string alma_estado, DateTime alma_fechainac, DateTime creacion, int veces, string nombre_error, string texto_buscar, string usuario)
        {
            this.alma_ide = alma_ide;
            this.alma_codigo = alma_codigo;
            this.alma_nombre = alma_nombre;
            this.alma_venta = alma_venta;
            this.alma_direccion = alma_direccion;
            this.loca_ide = loca_ide;
            this.alma_estado = alma_estado;
            this.alma_fechainac = alma_fechainac;
            this.creacion = creacion;
            this.veces = veces;
            this.nombre_error = nombre_error;
            this.texto_buscar = texto_buscar;
            this.usuario = usuario;
        }

        public int Alma_ide
        {
            get
            {
                return alma_ide;
            }

            set
            {
                alma_ide = value;
            }
        }

        public string Alma_codigo
        {
            get
            {
                return alma_codigo;
            }

            set
            {
                alma_codigo = value;
            }
        }

        public string Alma_nombre
        {
            get
            {
                return alma_nombre;
            }

            set
            {
                alma_nombre = value;
            }
        }

        public string Alma_venta
        {
            get
            {
                return alma_venta;
            }

            set
            {
                alma_venta = value;
            }
        }
        public string Alma_direccion
        {
            get
            {
                return alma_direccion;
            }

            set
            {
                alma_direccion = value;
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

        public string Alma_estado
        {
            get
            {
                return alma_estado;
            }

            set
            {
                alma_estado = value;
            }
        }

        public DateTime Alma_fechainac
        {
            get
            {
                return alma_fechainac;
            }

            set
            {
                alma_fechainac = value;
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
