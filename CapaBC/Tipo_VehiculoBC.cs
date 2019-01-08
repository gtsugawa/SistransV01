using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDA;
using CapaBE;

namespace CapaBC
{
    class Tipo_VehiculoBC
    {
    }
    public class ClsTipo_VehiculoBC
    {
        public static ENResultOperation Crear(ClsTipo_VehiculoBE Datos)
        {
            return ClsTipo_VehiculoDA.Crear(Datos);
        }
        public static ENResultOperation Actualizar(ClsTipo_VehiculoBE Datos)
        {
            return ClsTipo_VehiculoDA.Actualizar(Datos);
        }

        public static ENResultOperation Eliminar(ClsTipo_VehiculoBE Datos)
        {
            return ClsTipo_VehiculoDA.Eliminar(Datos);
        }

        public static ENResultOperation Listar(string Texto_Buscar)
        {

            return ClsTipo_VehiculoDA.Listar(Texto_Buscar);
        }
        public static ENResultOperation ListarTodos(string Texto_Buscar)
        {

            return ClsTipo_VehiculoDA.ListarTodos(Texto_Buscar);
        }
        public static ENResultOperation Listar_Filtro(string Texto_Buscar, Int32 Tipo_Ide)
        {

            return ClsTipo_VehiculoDA.Listar_Filtro(Texto_Buscar, Tipo_Ide);
        }
    }
}
