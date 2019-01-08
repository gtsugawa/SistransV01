using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDA;
using CapaBE;


namespace CapaBC
{
    class Tipo_ClienteBC
    {
    }
    public class ClsTipo_ClienteBC
    {
        public static ENResultOperation Crear(ClsTipo_ClienteBE Datos)
        {
            return ClsTipo_ClienteDA.Crear(Datos);
        }
        public static ENResultOperation Actualizar(ClsTipo_ClienteBE Datos)
        {
            return ClsTipo_ClienteDA.Actualizar(Datos);
        }

        public static ENResultOperation Eliminar(ClsTipo_ClienteBE Datos)
        {
            return ClsTipo_ClienteDA.Eliminar(Datos);
        }

        public static ENResultOperation Listar(string Texto_Buscar)
        {

            return ClsTipo_ClienteDA.Listar(Texto_Buscar);
        }

        public static ENResultOperation Listar_Filtro(string Texto_Buscar)
        {

            return ClsTipo_ClienteDA.Listar_Filtro(Texto_Buscar);
        }
    }
}
