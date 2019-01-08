using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaBE
{
    class Mantenimiento_ProgramadoBE
    {
    }

    public class ClsMantenimiento_ProgramadoBE
    {
       	int mant_prog_ide;
    	int tran_ide;
	    int tran_vehi_ide;
	    string tran_vehi_placa;
	    int mant_grupo_ide;
	    int mant_actividad_ide;
	    int mant_prog_dias;
	    int mant_prog_kilometros;
	    DateTime mant_prog_ultima_fecha;
	    int mant_prog_ultimo_kilometraje;
	    DateTime mant_prog_proxima_fecha;
	    int mant_prog_proximo_kilometraje;
	    string mant_prog_detalle;
	    string mant_prog_usuario;
	    DateTime mant_prog_fecha;
	    int mant_prog_estado;

        public ClsMantenimiento_ProgramadoBE()
        {

        }

        public int Mant_prog_ide {get; set;}
        public int Tran_ide { get; set; }
        public int Tran_vehi_ide { get; set; }
        public string Tran_vehi_placa { get; set; }
        public int Mant_grupo_ide { get; set; }
        public int Mant_actividad_ide { get; set; }
        public int Mant_prog_dias { get; set; }
        public int Mant_prog_kilometros { get; set; }
        public DateTime Mant_prog_ultima_fecha { get; set; }
        public int Mant_prog_ultimo_kilometraje { get; set; }
        public DateTime Mant_prog_proxima_fecha { get; set; }
        public int Mant_prog_proximo_kilometraje { get; set; }
        public string Mant_prog_detalle { get; set; }
        public string Mant_prog_usuario { get; set; }
        public DateTime Mant_prog_fecha { get; set; }
        public int Mant_prog_estado { get; set; }
    }
}
