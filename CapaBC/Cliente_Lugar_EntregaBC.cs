using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaBE;
using CapaDA;

namespace CapaBC
{
    class Cliente_Lugar_EntregaBC
    {
    }
    public class ClsCliente_Lugar_EntregaBC
    {
        public static ENResultOperation Crear(ClsCliente_Lugar_EntregaBE Datos)
        {
            return ClsCliente_Lugar_EntregaDA.Crear(Datos);
        }
        public static ENResultOperation Actualizar(ClsCliente_Lugar_EntregaBE Datos)
        {
            return ClsCliente_Lugar_EntregaDA.Actualizar(Datos);
        }

        public static ENResultOperation Eliminar(ClsCliente_Lugar_EntregaBE Datos)
        {
            return ClsCliente_Lugar_EntregaDA.Eliminar(Datos);
        }

        public static ENResultOperation Listar(Int32 Clie_Ide)
        {

            return ClsCliente_Lugar_EntregaDA.Listar(Clie_Ide);
        }

        public static ENResultOperation Listar_Filtro(string Texto_Buscar)
        {

            return ClsCliente_Lugar_EntregaDA.Listar_Filtro(Texto_Buscar);
        }
    }
}
