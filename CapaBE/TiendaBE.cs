using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaBE
{
    class TiendaBE
    {
    }
    public class ClsTiendaBE
    {
        int tienda_ide;
        string tienda_nombre;
        string tienda_codigo;
        string tienda_estado;
        DateTime tienda_fechainac;
        DateTime creacion;
        int veces;
        string nombre_error;
        string texto_buscar;
        string usuario;


        public ClsTiendaBE()
        {
        }

        public ClsTiendaBE(int tienda_ide,string tienda_nombre,string tienda_codigo,string tienda_estado,DateTime tienda_fechainac,DateTime creacion,int veces,string nombre_error,string texto_buscar,string usuario)
        {
            this.tienda_ide = tienda_ide;
            this.tienda_nombre = tienda_nombre;
            this.tienda_codigo = tienda_codigo;
            this.tienda_estado = tienda_estado;
            this.tienda_fechainac = tienda_fechainac;
            this.creacion = creacion;
            this.veces = veces;
            this.nombre_error = nombre_error;
            this.texto_buscar = texto_buscar;
            this.usuario = usuario;
        }
	    public int Tienda_ide
       {
         get { return tienda_ide; }
         set { tienda_ide = value; }
       }

        public string Tienda_nombre
        {
            get { return tienda_nombre; }
            set { tienda_nombre = value; }
        }

        public string Tienda_codigo { get; set; }
        public string Tienda_estado { get; set; }
        public DateTime Tienda_fechainac { get; set; }
        public DateTime Creacion { get; set; }
        public int Veces { get; set; }
        public string Nombre_error { get; set; }
        public string Texto_buscar { get; set; }
        public string Usuario { get; set; }
    }
}
