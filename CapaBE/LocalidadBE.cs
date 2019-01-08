using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaBE
{
    class LocalidadBE
    {
    }
    public class ClsLocalidadBE
    {
        int loca_ide;
        string loca_codigo;
        string loca_nombre;
        string loca_codigo_postal;
        string loca_abreviado;
        int zona_geo_ide;
        int pais_ide;
        string loca_estado;
        DateTime loca_fechainac;
        DateTime creacion;
        int veces;
        string nombre_error;
        string texto_buscar;
        string usuario;

              
        public ClsLocalidadBE()
        {

        }
        public ClsLocalidadBE(int loca_ide,string loca_codigo,string loca_nombre,string loca_codigo_postal,
                              string loca_abreviado,int zona_geo_ide,int pais_ide,string loca_estado,
                              DateTime loca_fechainac,DateTime creacion,int veces,string nombre_error, string texto_buscar,string usuario)
        {
            this.loca_ide = loca_ide;
            this.loca_codigo = loca_codigo;
            this.loca_nombre = loca_nombre;
            this.loca_codigo_postal = loca_codigo_postal;
            this.loca_abreviado = loca_abreviado;
            this.zona_geo_ide = zona_geo_ide;
            this.pais_ide = pais_ide;
            this.loca_estado = loca_estado;
            this.loca_fechainac = loca_fechainac;
            this.creacion = creacion;
            this.veces = veces;
            this.nombre_error = nombre_error;
            this.texto_buscar = texto_buscar;
            this.usuario = usuario;

        }
        public int Loca_ide
        {
            get { return loca_ide; }
            set { loca_ide = value; }
        }
        
        public string Loca_codigo
        {
            get { return loca_codigo; }
            set { loca_codigo = value; }
        }
        
        public string Loca_nombre
        {
            get { return loca_nombre; }
            set { loca_nombre = value; }
        }
        
        public string Loca_codigo_postal
        {
            get { return loca_codigo_postal; }
            set { loca_codigo_postal = value; }
        }
        
        public string Loca_abreviado
        {
            get { return loca_abreviado; }
            set { loca_abreviado = value; }
        }

        public int Zona_geo_ide
        {
            get { return zona_geo_ide; }
            set { zona_geo_ide = value; }
        }

        public int Pais_ide
        {
            get { return pais_ide; }
            set { pais_ide = value; }
        }

        public string Loca_estado
        {
            get { return loca_estado; }
            set { loca_estado = value; }
        }

        public DateTime Loca_fechainac
        {
            get { return loca_fechainac; }
            set { loca_fechainac = value; }
        }

        public DateTime Creacion
        {
            get { return creacion; }
            set { creacion = value; }
        }

        public int Veces
        {
            get { return veces; }
            set { veces = value; }
        }
        public string Texto_buscar
        {
            get { return texto_buscar; }
            set { texto_buscar = value; }
        }
        public string Nombre_error
        {
            get { return nombre_error; }
            set { nombre_error = value; }
        }

        public string Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }
        
    }
}
