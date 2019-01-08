using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaBE
{
    class Unidad_MedidaBE
    {
    }
    public class ClsUnidad_MedidaBE
    {
        int unid_medi_ide;
        string unid_medi_nombre;
        string unid_medi_codigo;
        string unid_medi_abreviado;
        string unid_medi_codigo_sunat;
        double unid_medi_factor; 
        double unid_medi_cantidad;
        string unid_medi_estado;
        DateTime unid_medi_fechainac;
        DateTime creacion;
        int veces;
        string codigo;
        string nombre_error;
        string texto_buscar;
        string usuario;
        public ClsUnidad_MedidaBE()
        {
        }
        public ClsUnidad_MedidaBE(int unid_medi_ide, string unid_medi_nombre, string unid_medi_codigo, string unid_medi_abreviado, string unid_medi_codigo_sunat, double unid_medi_factor,double unid_medi_cantidad, string unid_medi_estado, DateTime unid_medi_fechainac, DateTime creacion, int veces, string codigo, string nombre_error, string texto_buscar, string usuario)
        {
            this.unid_medi_ide = unid_medi_ide;
            this.unid_medi_nombre = unid_medi_nombre;
            this.unid_medi_codigo = unid_medi_codigo;
            this.unid_medi_abreviado = unid_medi_abreviado;
            this.unid_medi_codigo_sunat = unid_medi_codigo_sunat;
            this.unid_medi_factor = unid_medi_factor;
            this.unid_medi_cantidad = unid_medi_cantidad;
            this.unid_medi_estado = unid_medi_estado;
            this.unid_medi_fechainac = unid_medi_fechainac;
            this.creacion = creacion;
            this.veces = veces;
            this.codigo = codigo;
            this.nombre_error = nombre_error;
            this.texto_buscar = texto_buscar;
            this.usuario = usuario;
        }

        public int Unid_medi_ide
        {
            get
            {
                return unid_medi_ide;
            }

            set
            {
                unid_medi_ide = value;
            }
        }

        public string Unid_medi_nombre
        {
            get
            {
                return unid_medi_nombre;
            }

            set
            {
                unid_medi_nombre = value;
            }
        }

        public string Unid_medi_codigo
        {
            get
            {
                return unid_medi_codigo;
            }

            set
            {
                unid_medi_codigo = value;
            }
        }

        public string Unid_medi_abreviado
        {
            get
            {
                return unid_medi_abreviado;
            }

            set
            {
                unid_medi_abreviado = value;
            }
        }

        public string Unid_medi_codigo_sunat
        {
            get
            {
                return unid_medi_codigo_sunat;
            }

            set
            {
                unid_medi_codigo_sunat = value;
            }
        }

        public double Unid_medi_factor
        {
            get
            {
                return unid_medi_factor;
            }

            set
            {
                unid_medi_factor = value;
            }
        }
        public double Unid_medi_cantidad
        {
            get
            {
                return unid_medi_cantidad;
            }

            set
            {
                unid_medi_cantidad = value;
            }
        }

        public string Unid_medi_estado
        {
            get
            {
                return unid_medi_estado;
            }

            set
            {
                unid_medi_estado = value;
            }
        }

        public DateTime Unid_medi_fechainac
        {
            get
            {
                return unid_medi_fechainac;
            }

            set
            {
                unid_medi_fechainac = value;
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

        public string Codigo
        {
            get
            {
                return codigo;
            }

            set
            {
                codigo = value;
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
