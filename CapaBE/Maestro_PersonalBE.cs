using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaBE
{
    class Maestro_PersonalBE
    {
    }
    public class ClsMaestro_PersonalBE
    {
        int	    pers_ide;
        int userid;
        string	pers_codigo;
        string	pers_apellido_paterno;
        string	pers_apellido_materno;
        string	pers_nombres;
        int	    carg_ide;
        int	    docu_iden_ide;
        string	pers_documento;
        string	pers_direccion;
        int	    loca_ide;
        string	pers_telefono_casa;
        string	pers_telefono_celular;
        DateTime pers_fecha_nacimiento;
        DateTime pers_fecha_ingreso;
        DateTime pers_fecha_cese;
        string pers_sexo;
        string	pers_estado_civil;
        string	pers_correo;
        string	pers_nota;
        int	    pers_estado;
        DateTime creacion;
        DateTime modificado;
        string usuario;
        public ClsMaestro_PersonalBE()
        {
        }

        public int Pers_ide { get; set; }
        public int Userid { get; set; }
        public string Pers_codigo { get; set; }
        public string Pers_apellido_paterno { get; set; }
        public string Pers_apellido_materno { get; set; }
        public string Pers_nombres { get; set; }
        public int Carg_ide { get; set; }
        public int Docu_iden_ide { get; set; }
        public string Pers_documento { get; set; }
        public string Pers_direccion { get; set; }
        public int Loca_ide { get; set; }
        public string Pers_telefono_casa { get; set; }
        public string Pers_telefono_celular { get; set; }
        public DateTime Pers_fecha_nacimiento { get; set; }
        public DateTime Pers_fecha_ingreso { get; set; }
        public DateTime Pers_fecha_cese { get; set; }
        public string Pers_sexo { get; set; }
        public string Pers_estado_civil { get; set; }
        public string Pers_correo { get; set; }
        public string Pers_nota { get; set; }
        public int Pers_estado { get; set; }
        public DateTime Creacion { get; set; }
        public DateTime Modificado { get; set; }
        public string Usuario { get; set; }
    }
}
