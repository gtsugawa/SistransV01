using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaBE;
using CapaDA;

namespace CapaBC
{
    class Consumo_LubricanteBC
    {
    }

    public class ClsConsumo_LubricanteBC
    {
        public static ENResultOperation Crear(ClsConsumo_LubricanteBE Datos)
        {
            return ClsConsumo_LubricanteDA.Crear(Datos);
        }
        public static ENResultOperation Actualizar(ClsConsumo_LubricanteBE Datos)
        {
            return ClsConsumo_LubricanteDA.Actualizar(Datos);
        }

        public static ENResultOperation Eliminar(ClsConsumo_LubricanteBE Datos)
        {
            return ClsConsumo_LubricanteDA.Eliminar(Datos);
        }

        public static ENResultOperation Listar(string Texto_Buscar)
        {

            return ClsConsumo_LubricanteDA.Listar(Texto_Buscar);
        }
        public static ENResultOperation Buscar_Registro(Int32 nCons_Ide)
        {

            return ClsConsumo_LubricanteDA.Buscar_Registro(nCons_Ide);
        }

        public static ENResultOperation Listar_Filtro(string Texto_Buscar, string Condic_Buscar, DateTime FecIni, DateTime FecFin)
        {

            return ClsConsumo_LubricanteDA.Listar_Filtro(Texto_Buscar, Condic_Buscar, FecIni, FecFin);
        }
        public static ENResultOperation Listar_por_Fechas(DateTime Fecha_Inicio, DateTime Fecha_Fin)
        {

            return ClsConsumo_LubricanteDA.Listar_por_Fechas(Fecha_Inicio, Fecha_Fin);
        }
        public static ENResultOperation Reprocesar_Consumo(DateTime Fecha_Inicio, DateTime Fecha_Fin)
        {

            return ClsConsumo_LubricanteDA.Reprocesar_Consumo(Fecha_Inicio, Fecha_Fin);
        }
    }
}
