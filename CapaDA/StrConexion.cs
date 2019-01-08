using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace CapaDA
{
    public class StrConexion
    {
        
        public static string strcn = ConfigurationManager.ConnectionStrings["conex1"].ConnectionString;

        public static string strcn1 = ConfigurationManager.ConnectionStrings["conex2"].ConnectionString;
        
    }
}
