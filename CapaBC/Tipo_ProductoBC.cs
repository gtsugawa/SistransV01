using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDA;
using CapaBE;


namespace CapaBC
{
    class Tipo_ProductoBC
    {
    }
    public class ClsTipo_ProductoBC
    {
        public static ENResultOperation Crear(ClsTipo_ProductoBE Datos)
        {
            return ClsTipo_ProductoDA.Crear(Datos);
        }
        public static ENResultOperation Actualizar(ClsTipo_ProductoBE Datos)
        {
            return ClsTipo_ProductoDA.Actualizar(Datos);
        }

        public static ENResultOperation Eliminar(ClsTipo_ProductoBE Datos)
        {
            return ClsTipo_ProductoDA.Eliminar(Datos);
        }

        public static ENResultOperation Listar(string Texto_Buscar)
        {

            return ClsTipo_ProductoDA.Listar(Texto_Buscar);
        }
        public static ENResultOperation ListarTodos(string Texto_Buscar)
        {

            return ClsTipo_ProductoDA.ListarTodos(Texto_Buscar);
        }
        public static ENResultOperation Listar_Filtro(string Texto_Buscar)
        {

            return ClsTipo_ProductoDA.Listar_Filtro(Texto_Buscar);
        }
    }
}
