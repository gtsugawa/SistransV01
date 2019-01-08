using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaBE;
using CapaDA;

namespace CapaBC
{
    class Gasto_OperacionBC
    {
    }
    public class ClsGasto_OperacionBC
    {
        public static ENResultOperation Crear(ClsGasto_OperacionBE Datos)
        {
            return ClsGasto_OperacionDA.Crear(Datos);
        }
        public static ENResultOperation Actualizar(ClsGasto_OperacionBE Datos)
        {
            return ClsGasto_OperacionDA.Actualizar(Datos);
        }

        public static ENResultOperation Eliminar(ClsGasto_OperacionBE Datos)
        {
            return ClsGasto_OperacionDA.Eliminar(Datos);
        }

        public static ENResultOperation Listar(string Texto_Buscar)
        {

            return ClsGasto_OperacionDA.Listar(Texto_Buscar);
        }

        public static ENResultOperation Listar_Filtro(string Texto_Buscar)
        {

            return ClsGasto_OperacionDA.Listar_Filtro(Texto_Buscar);
        }

        public static ENResultOperation Obtener_Registro(Int32 Gto_Ope_Ide)
        {

            return ClsGasto_OperacionDA.Obtener_Registro(Gto_Ope_Ide);
        }
    }
}
