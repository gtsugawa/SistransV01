using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaBE
{
    class Actividad_ClienteBE
    {
    }
    public class ClsActividad_ClienteBE
    {
        int acti_clie_ide;
        string acti_clie_codigo;
        string acti_clie_nombre;
        string acti_clie_estado;
        DateTime acti_clie_fechainac;
        DateTime creacion;
        int veces;
        string nombre_error;
        string texto_buscar;
        string usuario;

        public ClsActividad_ClienteBE()
        {
        }
        public ClsActividad_ClienteBE(int acti_clie_ide, string acti_clie_codigo,string acti_clie_nombre, string acti_clie_estado, DateTime acti_clie_fechainac, DateTime creacion, int veces, string nombre_error, string texto_buscar, string usuario)
        {
            this.acti_clie_ide = acti_clie_ide;
            this.acti_clie_codigo = acti_clie_codigo;
            this.acti_clie_nombre = acti_clie_nombre;
            this.acti_clie_estado = acti_clie_estado;
            this.acti_clie_fechainac = acti_clie_fechainac;
            this.creacion = creacion;
            this.veces = veces;
            this.nombre_error = nombre_error;
            this.texto_buscar = texto_buscar;
            this.usuario = usuario;
        }

        public int Acti_clie_ide
        {
            get
            {
                return acti_clie_ide;
            }

            set
            {
                acti_clie_ide = value;
            }
        }

        public string Acti_clie_codigo
        {
            get
            {
                return acti_clie_codigo;
            }

            set
            {
                acti_clie_codigo = value;
            }
        }

        public string Acti_clie_nombre
        {
            get
            {
                return acti_clie_nombre;
            }

            set
            {
                acti_clie_nombre = value;
            }
        }

        public string Acti_clie_estado
        {
            get
            {
                return acti_clie_estado;
            }

            set
            {
                acti_clie_estado = value;
            }
        }

        public DateTime Acti_clie_fechainac
        {
            get
            {
                return acti_clie_fechainac;
            }

            set
            {
                acti_clie_fechainac = value;
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
