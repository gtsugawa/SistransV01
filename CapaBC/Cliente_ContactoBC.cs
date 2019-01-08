using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaBE;
using CapaDA;

namespace CapaBC
{
    class Cliente_ContactoBC
    {
    }
    public class ClsCliente_ContactoBC
    {
        public static ENResultOperation Crear(ClsCliente_ContactoBE Datos)
        {
            return ClsCliente_ContactoDA.Crear(Datos);
        }
        public static ENResultOperation Actualizar(ClsCliente_ContactoBE Datos)
        {
            return ClsCliente_ContactoDA.Actualizar(Datos);
        }

        public static ENResultOperation Eliminar(ClsCliente_ContactoBE Datos)
        {
            return ClsCliente_ContactoDA.Eliminar(Datos);
        }

        public static ENResultOperation Listar(string Texto_Buscar)
        {

            return ClsCliente_ContactoDA.Listar(Texto_Buscar);
        }

        public static ENResultOperation Listar_Filtro(Int32 Clie_Ide)
        {

            return ClsCliente_ContactoDA.Listar_Filtro(Clie_Ide);
        }

        public static ENResultOperation Consultar_Ide(Int32 Clie_Ide, Int32 Cont_Ide)
        {

            return ClsCliente_ContactoDA.Consultar_Ide(Clie_Ide, Cont_Ide);
        }

        public static ENResultOperation Obtener_Registro(Int32 Clie_Ide, Int32 Cont_Ide)
        {

            return ClsCliente_ContactoDA.Obtener_Registro(Clie_Ide, Cont_Ide);
        }
    }
}
