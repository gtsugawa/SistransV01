using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaBE
{
    class Transportista_Condicion_ComercialBE
    {
    }

    public class ClsTransportista_Condicion_ComercialBE
    {
        int tran_ide;
        int tran_cond_ide;
        string tran_cond_condicion;
        DateTime creacion;
        int veces;
        string nombre_error;
        string texto_buscar;
        string usuario;

        public ClsTransportista_Condicion_ComercialBE()
        {
        }
        public ClsTransportista_Condicion_ComercialBE(int tran_ide, int tran_cond_ide, string tran_cond_condicion, DateTime creacion, int veces, string nombre_error, string texto_buscar, string usuario)
        {
            this.tran_ide = tran_ide;
            this.tran_cond_ide = tran_cond_ide;
            this.tran_cond_condicion = tran_cond_condicion;
            this.creacion = creacion;
            this.veces = veces;
            this.nombre_error = nombre_error;
            this.texto_buscar = texto_buscar;
            this.usuario = usuario;
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

        public int Tran_cond_ide
        {
            get
            {
                return tran_cond_ide;
            }

            set
            {
                tran_cond_ide = value;
            }
        }

        public string Tran_cond_condicion
        {
            get
            {
                return tran_cond_condicion;
            }

            set
            {
                tran_cond_condicion = value;
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
