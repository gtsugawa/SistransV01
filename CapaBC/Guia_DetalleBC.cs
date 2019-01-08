using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaBE;
using CapaDA;

namespace CapaBC
{
    class Guia_DetalleBC
    {
    }

    public class ClsGuia_DetalleBC
    {
        public static ENResultOperation Crear(ClsGuia_DetalleBE Datos)
        {
            return ClsGuia_DetalleDA.Crear(Datos);
        }
        public static ENResultOperation Actualizar(ClsGuia_DetalleBE Datos)
        {
            return ClsGuia_DetalleDA.Actualizar(Datos);
        }

        public static ENResultOperation Eliminar(ClsGuia_DetalleBE Datos)
        {
            return ClsGuia_DetalleDA.Eliminar(Datos);
        }

        public static ENResultOperation Listar(string Texto_Buscar)
        {

            return ClsGuia_DetalleDA.Listar(Texto_Buscar);
        }

        public static ENResultOperation Listar_Filtro(string Texto_Buscar)
        {

            return ClsGuia_DetalleDA.Listar_Filtro(Texto_Buscar);
        }
    }
}
