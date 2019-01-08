using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaBE
{
    class Mantenimiento_Grupo_ActividadesBE
    {
    }
    public class ClsMantenimiento_Grupo_ActividadesBE
    {
        int mant_actividad_ide;
        int mant_grupo_ide;
        string mant_grupo_codigo;
        string mant_actividad_codigo;
        string mant_actividad_nombre;
        int mant_actividad_kilometros;
        int mant_actividad_dias;
        int mant_actividad_estado;
        public ClsMantenimiento_Grupo_ActividadesBE()
        {
        }
        public int Mant_actividad_ide { get; set; }
        public int Mant_grupo_ide { get; set; }
        public string Mant_grupo_codigo { get; set; }
        public string Mant_actividad_codigo { get; set; }
        public string Mant_actividad_nombre { get; set; }
        public int Mant_actividad_kilometros { get; set; }
        public int Mant_actividad_dias { get; set; }
        public int Mant_actividad_estado { get; set; }
    }
}
