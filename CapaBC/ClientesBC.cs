using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaBE;
using CapaDA;

namespace CapaBC
{
    class ClientesBC
    {
    }
    public class ClsClientesBC
    {
        public static ENResultOperation Crear(ClsClientesBE Datos)
        {
            return clsClientesDA.Crear(Datos);
        }
        public static ENResultOperation Actualizar(ClsClientesBE Datos)
        {
            return clsClientesDA.Actualizar(Datos);
        }

        public static ENResultOperation Eliminar(ClsClientesBE Datos)
        {
            return clsClientesDA.Eliminar(Datos);
        }

        public static ENResultOperation Listar(string Texto_Buscar)
        {

            return clsClientesDA.Listar(Texto_Buscar);
        }

        public static ENResultOperation Listar_Filtro(string Texto_Buscar, Int32 Clie_Ide)
        {

            return clsClientesDA.Listar_Filtro(Texto_Buscar, Clie_Ide);
        }

        public static ENResultOperation Consultar_Ide(Int32 Clie_Ide)
        {

            return clsClientesDA.Consultar_Ide(Clie_Ide);
        }

        public static ENResultOperation Listar_Nombre(string cNombre)
        {

            return clsClientesDA.Listar_Nombre(cNombre);
        }


    }
}
