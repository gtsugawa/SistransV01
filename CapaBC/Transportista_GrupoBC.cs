using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaBE;
using CapaDA;

namespace CapaBC
{
    class Transportista_GrupoBC
    {
    }
    public class ClsTransportista_GrupoBC
    {
        public static ENResultOperation Crear(ClsTransportista_GrupoBE Datos)
        {
            return ClsTransportista_GrupoDA.Crear(Datos);
        }
        public static ENResultOperation Actualizar(ClsTransportista_GrupoBE Datos)
        {
            return ClsTransportista_GrupoDA.Actualizar(Datos);
        }

        public static ENResultOperation Eliminar(ClsTransportista_GrupoBE Datos)
        {
            return ClsTransportista_GrupoDA.Eliminar(Datos);
        }

        public static ENResultOperation Listar(string Texto_Buscar)
        {

            return ClsTransportista_GrupoDA.Listar(Texto_Buscar);
        }

        public static ENResultOperation Listar_Filtro(string Texto_Buscar)
        {

            return ClsTransportista_GrupoDA.Listar_Filtro(Texto_Buscar);
        }
    }    
}
