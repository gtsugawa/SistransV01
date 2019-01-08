using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaBE
{
    class Actividad_ProveedorBE
    {
    }
    public class ClsActividad_ProveedorBE
    {
        int acti_prov_ide;
        string acti_prov_nombre;
        decimal acti_prov_monto_detraccion;
        string acti_prov_estado;
        DateTime acti_prov_fechainac;
        DateTime creacion;
        int veces;
        string nombre_error;
        string texto_buscar;
        string usuario;

        public ClsActividad_ProveedorBE()
        {
        }
        public ClsActividad_ProveedorBE(int acti_prov_ide, string acti_prov_nombre, decimal acti_prov_monto_detraccion, string acti_prov_estado, DateTime acti_prov_fechainac, DateTime creacion, int veces, string nombre_error, string texto_buscar, string usuario)
        {
            this.acti_prov_ide = acti_prov_ide;
            this.acti_prov_nombre = acti_prov_nombre;
            this.acti_prov_monto_detraccion = acti_prov_monto_detraccion;
            this.acti_prov_estado = acti_prov_estado;
            this.acti_prov_fechainac = acti_prov_fechainac;
            this.creacion = creacion;
            this.veces = veces;
            this.nombre_error = nombre_error;
            this.texto_buscar = texto_buscar;
            this.usuario = usuario;
        }

        public int Acti_prov_ide
        {
            get
            {
                return acti_prov_ide;
            }

            set
            {
                acti_prov_ide = value;
            }
        }

        public string Acti_prov_nombre
        {
            get
            {
                return acti_prov_nombre;
            }

            set
            {
                acti_prov_nombre = value;
            }
        }

        public decimal Acti_prov_monto_detraccion
        {
            get
            {
                return acti_prov_monto_detraccion;
            }

            set
            {
                acti_prov_monto_detraccion = value;
            }
        }

        public string Acti_prov_estado
        {
            get
            {
                return acti_prov_estado;
            }

            set
            {
                acti_prov_estado = value;
            }
        }

        public DateTime Acti_prov_fechainac
        {
            get
            {
                return acti_prov_fechainac;
            }

            set
            {
                acti_prov_fechainac = value;
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
