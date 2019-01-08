using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaBE;
using CapaDA;

namespace CapaBC
{
    class Correo_ParametroBC
    {
    }
    public class ClsCorreo_ParametroBC
    {
        public static ENResultOperation Crear(ClsCorreo_ParametroBE Datos)
        {
            return ClsCorreo_ParametroDA.Crear(Datos);
        }
        public static ENResultOperation Actualizar(ClsCorreo_ParametroBE Datos)
        {
            return ClsCorreo_ParametroDA.Actualizar(Datos);
        }

        public static ENResultOperation Eliminar(ClsCorreo_ParametroBE Datos)
        {
            return ClsCorreo_ParametroDA.Eliminar(Datos);
        }

        public static ENResultOperation Listar(string Texto_Buscar)
        {

            return ClsCorreo_ParametroDA.Listar(Texto_Buscar);
        }

        public static ENResultOperation Listar_Filtro(string Texto_Buscar)
        {

            return ClsCorreo_ParametroDA.Listar_Filtro(Texto_Buscar);
        }
    }
}
