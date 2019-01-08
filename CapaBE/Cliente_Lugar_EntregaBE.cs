using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaBE
{
    class Cliente_Lugar_EntregaBE
    {
    }
    public class ClsCliente_Lugar_EntregaBE
    {
        int clie_ide;
        int clie_lugar_ide;
        string clie_lugar_direccion;
        int loca_ide;
        DateTime creacion;
        int veces;
        string nombre_error;
        string texto_buscar;
        string usuario;
        public ClsCliente_Lugar_EntregaBE()
        {
        }
        public ClsCliente_Lugar_EntregaBE(int clie_ide, int clie_lugar_ide, string clie_lugar_direccion, int loca_ide, DateTime creacion, int veces, string nombre_error, string texto_buscar, string usuario)
        {
            this.clie_ide = clie_ide;
            this.clie_lugar_ide = clie_lugar_ide;
            this.clie_lugar_direccion = clie_lugar_direccion;
            this.loca_ide = loca_ide;
            this.creacion = creacion;
            this.veces = veces;
            this.nombre_error = nombre_error;
            this.texto_buscar = texto_buscar;
            this.usuario = usuario;
        }

        public int Clie_ide
        {
            get
            {
                return clie_ide;
            }

            set
            {
                clie_ide = value;
            }
        }

        public int Clie_lugar_ide
        {
            get
            {
                return clie_lugar_ide;
            }

            set
            {
                clie_lugar_ide = value;
            }
        }

        public string Clie_lugar_direccion
        {
            get
            {
                return clie_lugar_direccion;
            }

            set
            {
                clie_lugar_direccion = value;
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
