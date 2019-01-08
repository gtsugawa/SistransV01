using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaBE
{
    class Cliente_Punto_PartidaBE
    {
    }
    public class ClsCliente_Punto_PartidaBE
    {
        int prov_ide;
        int prov_part_ide;
        string prov_part_direccion;
        int loca_ide;
        DateTime creacion;
        int veces;
        int lrc_ide;
        string nombre_error;
        string texto_buscar;
        string usuario;
        public ClsCliente_Punto_PartidaBE()
        {

        }
        public ClsCliente_Punto_PartidaBE(int prov_ide, int prov_part_ide, string prov_part_direccion, int loca_ide, DateTime creacion, int veces, int lrc_ide, string nombre_error, string texto_buscar, string usuario)
        {
            this.prov_ide = prov_ide;
            this.prov_part_ide = prov_part_ide;
            this.prov_part_direccion = prov_part_direccion;
            this.loca_ide = loca_ide;
            this.creacion = creacion;
            this.veces = veces;
            this.lrc_ide = lrc_ide;
            this.nombre_error = nombre_error;
            this.texto_buscar = texto_buscar;
            this.usuario = usuario;
        }

        public int Prov_ide
        {
            get
            {
                return prov_ide;
            }

            set
            {
                prov_ide = value;
            }
        }

        public int Prov_part_ide
        {
            get
            {
                return prov_part_ide;
            }

            set
            {
                prov_part_ide = value;
            }
        }

        public string Prov_part_direccion
        {
            get
            {
                return prov_part_direccion;
            }

            set
            {
                prov_part_direccion = value;
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

        public int Lrc_ide
        {
            get
            {
                return lrc_ide;
            }

            set
            {
                lrc_ide = value;
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
