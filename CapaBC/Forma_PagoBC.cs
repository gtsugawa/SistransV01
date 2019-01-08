using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaBE;
using CapaDA;

namespace CapaBC
{
    class Forma_PagoBC
    {
    }
    public class ClsForma_PagoBC
    {
        public static ENResultOperation Crear(ClsForma_PagoBE Datos)
        {
            return ClsForma_PagoDA.Crear(Datos);
        }
        public static ENResultOperation Actualizar(ClsForma_PagoBE Datos)
        {
            return ClsForma_PagoDA.Actualizar(Datos);
        }

        public static ENResultOperation Eliminar(ClsForma_PagoBE Datos)
        {
            return ClsForma_PagoDA.Eliminar(Datos);
        }

        public static ENResultOperation Listar(string Texto_Buscar)
        {

            return ClsForma_PagoDA.Listar(Texto_Buscar);
        }

        public static ENResultOperation Listar_Filtro(string Texto_Buscar)
        {

            return ClsForma_PagoDA.Listar_Filtro(Texto_Buscar);
        }
    }
}
