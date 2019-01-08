using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaBE
{
    class Combustible_CompraBE
    {
    }
    public class ClsCombustible_CompraBE
    {
        int	comp_ide;
        int	prov_ide;
        DateTime comp_fecha;
        string	comp_numero;
        string	comp_tipo_combustible;
        decimal	comp_cantidad;
        decimal	comp_importe;
        int	comp_kilometraje;
        int	tran_ide;
        int	tran_vehi_ide;
        int	tran_chof_ide;
        string	comp_lugar;
        int comp_orden;
        DateTime creacion;
        DateTime fecha_posterior;
        string	usuario;
        int estado;
        int kms_posterior;
        string ordenes;
        string comb_inicio;
        string comb_final;
        string tonelaje;
        string nombre_error;
        string texto_buscar;

        public ClsCombustible_CompraBE()
        {
        }
        public ClsCombustible_CompraBE(int comp_ide, int prov_ide, DateTime comp_fecha, string comp_numero, string comp_tipo_combustible, decimal comp_cantidad, decimal comp_importe, int comp_kilometraje, int tran_ide, int tran_vehi_ide, int tran_chof_ide, string comp_lugar,int comp_orden, DateTime creacion, string usuario, int estado, string nombre_error, string texto_buscar)
        {
            this.comp_ide = comp_ide;
            this.prov_ide = prov_ide;
            this.comp_fecha = comp_fecha;
            this.comp_numero = comp_numero;
            this.comp_tipo_combustible = comp_tipo_combustible;
            this.comp_cantidad = comp_cantidad;
            this.comp_importe = comp_importe;
            this.comp_kilometraje = comp_kilometraje;
            this.tran_ide = tran_ide;
            this.tran_vehi_ide = tran_vehi_ide;
            this.tran_chof_ide = tran_chof_ide;
            this.comp_lugar = comp_lugar;
            this.comp_orden = comp_orden;
            this.creacion = creacion;
            this.usuario = usuario;
            this.estado = estado;
            this.nombre_error = nombre_error;
            this.texto_buscar = texto_buscar;
            
        }

        public int Comp_ide { get; set; }
        public int Prov_ide { get; set; }
        public DateTime Comp_fecha { get; set; }
        public string Comp_numero { get; set; }
        public string Comp_tipo_combustible { get; set; }
        public decimal Comp_cantidad { get; set; }
        public decimal Comp_importe { get; set; }
        public int Comp_kilometraje { get; set; }
        public int Tran_ide { get; set; }
        public int Tran_vehi_ide { get; set; }
        public int Tran_chof_ide { get; set; }
        public string Comp_lugar { get; set; }
        public int Comp_orden { get; set; }
        public DateTime Creacion { get; set; }
        public DateTime Fecha_posterior { get; set; }
        public string Usuario { get; set; }
        public int Estado { get; set; }
        public int Kms_posterior { get; set; }
        public string Ordenes { get; set; }
        public string Comb_inicio { get; set; }
        public string Comb_final { get; set; }
        public string Tonelaje { get; set; }
        public string Nombre_error { get; set; }
        public string Texto_buscar { get; set; }
        
    }
        
}
