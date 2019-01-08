using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaBE;
using CapaDA;

namespace CapaBC
{
    class Marca_VehiculoBC
    {
    }
    public class ClsMarca_VehiculoBC
    {
        public static ENResultOperation Crear(ClsMarca_VehiculoBE Datos)
        {
            return ClsMarca_VehiculoDA.Crear(Datos);
        }
        public static ENResultOperation Actualizar(ClsMarca_VehiculoBE Datos)
        {
            return ClsMarca_VehiculoDA.Actualizar(Datos);
        }

        public static ENResultOperation Eliminar(ClsMarca_VehiculoBE Datos)
        {
            return ClsMarca_VehiculoDA.Eliminar(Datos);
        }

        public static ENResultOperation Listar(string Texto_Buscar)
        {

            return ClsMarca_VehiculoDA.Listar(Texto_Buscar);
        }
        public static ENResultOperation ListarTodos(string Texto_Buscar)
        {

            return ClsMarca_VehiculoDA.ListarTodos(Texto_Buscar);
        }
        public static ENResultOperation Listar_Filtro(string Texto_Buscar)
        {

            return ClsMarca_VehiculoDA.Listar_Filtro(Texto_Buscar);
        }
    }
}
