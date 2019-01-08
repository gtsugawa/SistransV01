using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaBE;
using CapaDA;

namespace CapaBC
{
    class Concepto_FacturaBC
    {
    }
    public class ClsConcepto_FacturaBC
    {
        public static ENResultOperation Crear(ClsConcepto_FacturaBE Datos)
        {
            return ClsConcepto_FacturaDA.Crear(Datos);
        }
        public static ENResultOperation Actualizar(ClsConcepto_FacturaBE Datos)
        {
            return ClsConcepto_FacturaDA.Actualizar(Datos);
        }

        public static ENResultOperation Eliminar(ClsConcepto_FacturaBE Datos)
        {
            return ClsConcepto_FacturaDA.Eliminar(Datos);
        }

        public static ENResultOperation Listar(string Texto_Buscar)
        {

            return ClsConcepto_FacturaDA.Listar(Texto_Buscar);
        }

        public static ENResultOperation ListarTodos(string Texto_Buscar)
        {

            return ClsConcepto_FacturaDA.ListarTodos(Texto_Buscar);
        }
        public static ENResultOperation Listar_Filtro(string Texto_Buscar)
        {

            return ClsConcepto_FacturaDA.Listar_Filtro(Texto_Buscar);
        }
    }
}
