using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaBE;
using CapaDA;


namespace CapaBC
{
    class ProveedorBC
    {
    }

    public class ClsProveedorBC
    {
        public static ENResultOperation Crear(ClsProveedorBE Datos)
        {
            return ClsProveedorDA.Crear(Datos);
        }
        public static ENResultOperation Actualizar(ClsProveedorBE Datos)
        {
            return ClsProveedorDA.Actualizar(Datos);
        }

        public static ENResultOperation Eliminar(ClsProveedorBE Datos)
        {
            return ClsProveedorDA.Eliminar(Datos);
        }
        public static ENResultOperation Obtener_Registro(Int32 Prov_Ide)
        {

            return ClsProveedorDA.Obtener_Registro(Prov_Ide);
        }
        public static ENResultOperation Obtener_Ruc(string NroRuc)
        {

            return ClsProveedorDA.Obtener_Ruc(NroRuc);
        }
        public static ENResultOperation Listar(string Texto_Buscar)
        {

            return ClsProveedorDA.Listar(Texto_Buscar);
        }

        public static ENResultOperation Listar_Filtro(string Texto_Buscar)
        {

            return ClsProveedorDA.Listar_Filtro(Texto_Buscar);
        }
    }
}
