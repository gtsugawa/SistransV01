using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaBE
{
    class Zona_GeograficaBE
    {
    }
    public class ClsZona_GeograficaBE
    {
        int zona_geo_ide;
        string zona_geo_nombre;
        string zona_geo_estado;
        DateTime zona_geo_fechainac;
        DateTime creacion;
        int veces;
        string nombre_error;
        string texto_buscar;
        string usuario;
        public ClsZona_GeograficaBE()
        {

        }
        public ClsZona_GeograficaBE(int zona_geo_ide, string zona_geo_nombre, string zona_geo_estado, DateTime zona_geo_fechainac, DateTime creacion, int veces, string nombre_error, string texto_buscar, string usuario)
        {
            this.zona_geo_ide = zona_geo_ide;
            this.zona_geo_nombre = zona_geo_nombre;
            this.zona_geo_estado = zona_geo_estado;
            this.zona_geo_fechainac = zona_geo_fechainac;
            this.creacion = creacion;
            this.veces = veces;
            this.nombre_error = nombre_error;
            this.texto_buscar = texto_buscar;
            this.usuario = usuario;
        }

        public int Zona_geo_ide
        {
            get
            {
                return zona_geo_ide;
            }

            set
            {
                zona_geo_ide = value;
            }
        }

        public string Zona_geo_nombre
        {
            get
            {
                return zona_geo_nombre;
            }

            set
            {
                zona_geo_nombre = value;
            }
        }

        public string Zona_geo_estado
        {
            get
            {
                return zona_geo_estado;
            }

            set
            {
                zona_geo_estado = value;
            }
        }

        public DateTime Zona_geo_fechainac
        {
            get
            {
                return zona_geo_fechainac;
            }

            set
            {
                zona_geo_fechainac = value;
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
