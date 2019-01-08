using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaBE;
using CapaDA;

namespace CapaBC
{
    class LocalidadBC
    {
    }
    public class ClsLocalidadBC
    {
        public static ENResultOperation Crear(ClsLocalidadBE Datos)
        {
            return ClsLocalidadDA.Crear(Datos);
        }
        public static ENResultOperation Actualizar(ClsLocalidadBE Datos)
        {
            return ClsLocalidadDA.Actualizar(Datos);
        }

        public static ENResultOperation Eliminar(ClsLocalidadBE Datos)
        {
            return ClsLocalidadDA.Eliminar(Datos);
        }

        public static ENResultOperation Listar(string Texto_Buscar)
        {

            return ClsLocalidadDA.Listar(Texto_Buscar);
        }
        public static ENResultOperation ListarBuscar(string Texto_Buscar)
        {

            return ClsLocalidadDA.ListarBuscar(Texto_Buscar);
        }

        public static ENResultOperation ListarTodos(string Texto_Buscar)
        {

            return ClsLocalidadDA.ListarTodos(Texto_Buscar);
        }
        public static ENResultOperation Listar_Filtro(string Texto_Buscar, Int32 Localidad_Ide)
        {

            return ClsLocalidadDA.Listar_Filtro(Texto_Buscar, Localidad_Ide);
        }
    }
}
