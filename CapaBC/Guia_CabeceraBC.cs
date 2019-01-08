using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaBE;
using CapaDA;

namespace CapaBC
{
    class Guia_CabeceraBC
    {
    }
    public class ClsGuia_CabeceraBC
    {
        public static ENResultOperation Crear(ClsGuia_CabeceraBE Datos)
        {
            return ClsGuia_CabeceraDA.Crear(Datos);
        }
        public static ENResultOperation Actualizar(ClsGuia_CabeceraBE Datos)
        {
            return ClsGuia_CabeceraDA.Actualizar(Datos);
        }

        public static ENResultOperation Eliminar(ClsGuia_CabeceraBE Datos)
        {
            return ClsGuia_CabeceraDA.Eliminar(Datos);
        }

        public static ENResultOperation Listar(string Texto_Buscar)
        {

            return ClsGuia_CabeceraDA.Listar(Texto_Buscar);
        }

        public static ENResultOperation Listar_Filtro(string Texto_Buscar)
        {

            return ClsGuia_CabeceraDA.Listar_Filtro(Texto_Buscar);
        }

        public static ENResultOperation Obtener_Registro(Int32 Reco_Ide)
        {

            return ClsGuia_CabeceraDA.Obtener_Registro(Reco_Ide);
        }
    }
}
