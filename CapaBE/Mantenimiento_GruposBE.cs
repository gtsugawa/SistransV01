using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaBE
{
    class Mantenimiento_GruposBE
    {
    }
    public class ClsMantenimiento_GruposBE
    {
        int mant_grupo_ide;
        string mant_grupo_codigo;
        string mant_grupo_nombre;
        int mant_grupo_estado;
        public ClsMantenimiento_GruposBE()
        {
        }
        public ClsMantenimiento_GruposBE(int mant_grupo_ide, string mant_grupo_codigo, string mant_grupo_nombre, int mant_grupo_estado)
        {
            this.mant_grupo_ide = mant_grupo_ide;
            this.mant_grupo_nombre = mant_grupo_nombre;
            this.mant_grupo_codigo = mant_grupo_codigo;
            this.mant_grupo_estado = mant_grupo_estado;
        }

        public int Mant_grupo_ide { get; set; }
        public string Mant_grupo_codigo { get; set; }
        public string Mant_grupo_nombre { get; set; }
        public int Mant_grupo_estado { get; set; }

    }
}
