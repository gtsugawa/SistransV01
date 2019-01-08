using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaBE
{
    class Correo_ParametroBE
    {
    }

    public class ClsCorreo_ParametroBE
    {
        int empre_ide;
        string empre_correo_from;
        string empre_correo_to;
        string empre_smtp;
        string empre_usuario;
        string empre_clave;

        public ClsCorreo_ParametroBE()
        {
        }

        public int Empre_ide {get; set;}
        public string Empre_correo_from {get; set;}
        public string Empre_correo_to {get; set;}
        public string Empre_smtp {get; set;}
        public string Empre_usuario {get; set;}
        public string Empre_clave {get; set;}
    
    }
}
