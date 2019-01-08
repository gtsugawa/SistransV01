using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaBE;
using CapaDA;

namespace CapaBC
{
    class Plan_CuentaBC
    {
    }
    public class ClsPlan_CuentaBC
    {
        public static ENResultOperation Crear(ClsPlan_CuentaBE Datos)
        {
            return ClsPlan_CuentaDA.Crear(Datos);
        }
        public static ENResultOperation Actualizar(ClsPlan_CuentaBE Datos)
        {
            return ClsPlan_CuentaDA.Actualizar(Datos);
        }

        public static ENResultOperation Eliminar(ClsPlan_CuentaBE Datos)
        {
            return ClsPlan_CuentaDA.Eliminar(Datos);
        }

        public static ENResultOperation Listar(string Texto_Buscar)
        {

            return ClsPlan_CuentaDA.Listar(Texto_Buscar);
        }

        public static ENResultOperation Listar_Filtro(string Texto_Buscar)
        {

            return ClsPlan_CuentaDA.Listar_Filtro(Texto_Buscar);
        }
    }
}
