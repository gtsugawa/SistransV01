using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaBE;
using CapaDA;

namespace CapaBC
{
    class Unidad_MedidaBC
    {
    }
    public class ClsUnidad_MedidaBC
    {
        public static ENResultOperation Crear(ClsUnidad_MedidaBE Datos)
        {
            return ClsUnidad_MedidaDA.Crear(Datos);
        }
        public static ENResultOperation Actualizar(ClsUnidad_MedidaBE Datos)
        {
            return ClsUnidad_MedidaDA.Actualizar(Datos);
        }

        public static ENResultOperation Eliminar(ClsUnidad_MedidaBE Datos)
        {
            return ClsUnidad_MedidaDA.Eliminar(Datos);
        }

        public static ENResultOperation Listar(string Texto_Buscar)
        {

            return ClsUnidad_MedidaDA.Listar(Texto_Buscar);
        }
        public static ENResultOperation ListarTodos(string Texto_Buscar)
        {

            return ClsUnidad_MedidaDA.ListarTodos(Texto_Buscar);
        }

        public static ENResultOperation Listar_Filtro(string Texto_Buscar)
        {

            return ClsUnidad_MedidaDA.Listar_Filtro(Texto_Buscar);
        }
    }
}
