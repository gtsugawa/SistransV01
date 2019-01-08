using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaBE;
using CapaDA;

namespace CapaBC
{
    class Mantenimiento_GruposBC
    {
    }
    public class ClsMantenimiento_GruposBC
    {
        public static ENResultOperation Crear(ClsMantenimiento_GruposBE Datos)
        {
            return ClsMantenimiento_GruposDA.Crear(Datos);
        }
        public static ENResultOperation Actualizar(ClsMantenimiento_GruposBE Datos)
        {
            return ClsMantenimiento_GruposDA.Actualizar(Datos);
        }

        public static ENResultOperation Eliminar(ClsMantenimiento_GruposBE Datos)
        {
            return ClsMantenimiento_GruposDA.Eliminar(Datos);
        }

        public static ENResultOperation Listar(string Texto_Buscar)
        {

            return ClsMantenimiento_GruposDA.Listar(Texto_Buscar);
        }

        public static ENResultOperation Listar_Filtro(string Texto_Buscar, string Condic_Buscar, DateTime FecIni, DateTime FecFin)
        {

            return ClsMantenimiento_GruposDA.Listar_Filtro(Texto_Buscar, Condic_Buscar, FecIni, FecFin);
        }
        public static ENResultOperation Listar_por_Fechas(DateTime FecIni, DateTime FecFin)
        {

            return ClsMantenimiento_GruposDA.Listar_por_Fechas(FecIni, FecFin);
        }
        public static ENResultOperation Buscar_Registro(Int32 Reco_Ide)
        {

            return ClsMantenimiento_GruposDA.Buscar_Registro(Reco_Ide);
        }

        public static ENResultOperation Obtener_Registro(Int32 Reco_Ide)
        {

            return ClsMantenimiento_GruposDA.Obtener_Registro(Reco_Ide);
        }
    }
}
