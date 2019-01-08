using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaBE
{
    class Forma_PagoBE
    {
    }
    public class ClsForma_PagoBE
    {
        int for_pag_ide;
        string for_pag_nombre;
        string for_pag_nombre_ingles;
        string for_pag_canje;
        int for_pag_numero_documento;
        int for_pag_vencimiento1;
        string for_pag_lista_precio;
        string for_pag_estado;
        DateTime for_pag_fechainac;
        DateTime creacion;
        int veces;
        string nombre_error;
        string texto_buscar;
        string usuario;

        public ClsForma_PagoBE()
        {
        }

        public ClsForma_PagoBE(int for_pag_ide,string for_pag_nombre,string for_pag_nombre_ingles,string for_pag_canje,int for_pag_numero_documento,int for_pag_vencimiento1,string for_pag_lista_precio,string for_pag_estado,DateTime for_pag_fechainac,DateTime creacion,int veces,string nombre_error,string texto_buscar,string usuario)
        {
            this.for_pag_ide = for_pag_ide;
            this.for_pag_nombre = for_pag_nombre;
            this.for_pag_nombre_ingles = for_pag_nombre_ingles;
            this.for_pag_canje = for_pag_canje;
            this.for_pag_numero_documento = for_pag_numero_documento;
            this.for_pag_vencimiento1 = for_pag_vencimiento1;
            this.for_pag_lista_precio = for_pag_lista_precio;
            this.for_pag_estado = for_pag_estado;
            this.for_pag_fechainac = for_pag_fechainac;
            this.creacion = creacion;
            this.veces = veces;
            this.nombre_error = nombre_error;
            this.texto_buscar = texto_buscar;
            this.usuario = usuario;
        }

        public int For_pag_ide {get; set;}
        public string For_pag_nombre { get; set; }
        public string For_pag_nombre_ingles { get; set; }
        public string For_pag_canje { get; set; }
        public int For_pag_numero_documento { get; set; }
        public int For_pag_vencimiento1 { get; set; }
        public string For_pag_lista_precio { get; set; }
        public string For_pag_estado { get; set; }
        public DateTime For_pag_fechainac { get; set; }
        public DateTime Creacion { get; set; }
        public int Veces { get; set; }
        public string Nombre_error { get; set; }
        public string Texto_buscar { get; set; }
        public string Usuario { get; set; }
    }
}
