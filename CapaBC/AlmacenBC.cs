using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaBE;
using CapaDA;

namespace CapaBC
{
    class AlmacenBC
    {
    }
    public class ClsAlmacenBC
    {
        public static ENResultOperation Crear(ClsAlmacenBE Datos)
        {
            return ClsAlmacenDA.Crear(Datos);
        }
        public static ENResultOperation Actualizar(ClsAlmacenBE Datos)
        {
            return ClsAlmacenDA.Actualizar(Datos);
        }

        public static ENResultOperation Eliminar(ClsAlmacenBE Datos)
        {
            return ClsAlmacenDA.Eliminar(Datos);
        }

        public static ENResultOperation Listar(string Texto_Buscar)
        {

            return ClsAlmacenDA.Listar(Texto_Buscar);
        }
        public static ENResultOperation ListarTodos(string Texto_Buscar)
        {

            return ClsAlmacenDA.Listar(Texto_Buscar);
        }

        public static ENResultOperation Listar_Filtro(string Texto_Buscar)
        {

            return ClsAlmacenDA.Listar_Filtro(Texto_Buscar);
        }
    }
}
