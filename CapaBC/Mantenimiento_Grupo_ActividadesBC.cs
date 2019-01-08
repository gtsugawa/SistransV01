using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaBE;
using CapaDA;

namespace CapaBC
{
    class Mantenimiento_Grupo_ActividadesBC
    {
    }
    public class ClsMantenimiento_Grupo_ActividadesBC
    {
        public static ENResultOperation Crear(ClsMantenimiento_Grupo_ActividadesBE Datos)
        {
            return ClsMantenimiento_Grupo_ActividadesDA.Crear(Datos);
        }
        public static ENResultOperation Actualizar(ClsMantenimiento_Grupo_ActividadesBE Datos)
        {
            return ClsMantenimiento_Grupo_ActividadesDA.Actualizar(Datos);
        }

        public static ENResultOperation Eliminar(ClsMantenimiento_Grupo_ActividadesBE Datos)
        {
            return ClsMantenimiento_Grupo_ActividadesDA.Eliminar(Datos);
        }

        public static ENResultOperation Listar(string Texto_Buscar)
        {

            return ClsMantenimiento_Grupo_ActividadesDA.Listar(Texto_Buscar);
        }

        public static ENResultOperation Listar_Filtro(string Texto_Buscar, string Condic_Buscar, DateTime FecIni, DateTime FecFin)
        {

            return ClsMantenimiento_Grupo_ActividadesDA.Listar_Filtro(Texto_Buscar, Condic_Buscar, FecIni, FecFin);
        }
        public static ENResultOperation Listar_por_Fechas(DateTime FecIni, DateTime FecFin)
        {

            return ClsMantenimiento_Grupo_ActividadesDA.Listar_por_Fechas(FecIni, FecFin);
        }
        public static ENResultOperation Buscar_Registro(Int32 Reco_Ide)
        {

            return ClsMantenimiento_Grupo_ActividadesDA.Buscar_Registro(Reco_Ide);
        }

        public static ENResultOperation Obtener_Registro(Int32 Reco_Ide)
        {

            return ClsMantenimiento_Grupo_ActividadesDA.Obtener_Registro(Reco_Ide);
        }

        public static ENResultOperation Obtener_Codigo(Int32 Ide,string Codigo)
        {

            return ClsMantenimiento_Grupo_ActividadesDA.Obtener_Codigo(Ide,Codigo);
        }
        public static ENResultOperation Obtener_Actividades_Grupo(Int32 Ide)
        {

            return ClsMantenimiento_Grupo_ActividadesDA.Obtener_Actividades_Grupo(Ide);
        }

    }
}
