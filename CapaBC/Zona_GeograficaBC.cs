using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaBE;
using CapaDA;

namespace CapaBC
{
    class Zona_GeograficaBC
    {
    }
    public class ClsZona_GeograficaBC
    {
        public static ENResultOperation Crear(ClsZona_GeograficaBE Datos)
        {
            return ClsZona_GeograficaDA.Crear(Datos);
        }
        public static ENResultOperation Actualizar(ClsZona_GeograficaBE Datos)
        {
            return ClsZona_GeograficaDA.Actualizar(Datos);
        }

        public static ENResultOperation Eliminar(ClsZona_GeograficaBE Datos)
        {
            return ClsZona_GeograficaDA.Eliminar(Datos);
        }

        public static ENResultOperation Listar(string Texto_Buscar)
        {

            return ClsZona_GeograficaDA.Listar(Texto_Buscar);
        }

        public static ENResultOperation ListarTodos(string Texto_Buscar)
        {

            return ClsZona_GeograficaDA.ListarTodos(Texto_Buscar);
        }

        public static ENResultOperation Listar_Filtro(string Texto_Buscar)
        {

            return ClsZona_GeograficaDA.Listar_Filtro(Texto_Buscar);
        }
    }
}
