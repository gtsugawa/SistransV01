using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaBE;
using CapaDA;

namespace CapaBC
{
    class Combustible_CompraBC
    {
    }
    public class ClsCombustible_CompraBC
    {
        public static ENResultOperation Crear(ClsCombustible_CompraBE Datos)
        {
            return ClsCombustible_CompraDA.Crear(Datos);
        }
        public static ENResultOperation Actualizar(ClsCombustible_CompraBE Datos)
        {
            return ClsCombustible_CompraDA.Actualizar(Datos);
        }

        public static ENResultOperation Eliminar(ClsCombustible_CompraBE Datos)
        {
            return ClsCombustible_CompraDA.Eliminar(Datos);
        }

        public static ENResultOperation Listar(string Texto_Buscar)
        {

            return ClsCombustible_CompraDA.Listar(Texto_Buscar);
        }
        public static ENResultOperation Buscar_Comprobante(Int32 nComp_Ide)
        {

            return ClsCombustible_CompraDA.Buscar_Comprobante(nComp_Ide);
        }

        public static ENResultOperation Listar_Filtro(string Texto_Buscar, string Condic_Buscar,DateTime FecIni, DateTime FecFin)
        {

            return ClsCombustible_CompraDA.Listar_Filtro(Texto_Buscar, Condic_Buscar, FecIni,FecFin);
        }
        public static ENResultOperation Listar_por_Fechas(DateTime Fecha_Inicio, DateTime Fecha_Fin)
        {

            return ClsCombustible_CompraDA.Listar_por_Fechas(Fecha_Inicio,Fecha_Fin);
        }
        public static ENResultOperation Reprocesar_Consumo(DateTime Fecha_Inicio, DateTime Fecha_Fin)
        {

            return ClsCombustible_CompraDA.Reprocesar_Consumo(Fecha_Inicio, Fecha_Fin);
        }
    }
}
