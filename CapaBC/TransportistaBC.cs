using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDA;
using CapaBE;

namespace CapaBC
{
    class TransportistaBC
    {
    }
    public class ClsTransportistaBC
    {
        public static ENResultOperation Crear(ClsTransportistaBE Datos)
        {
            return ClsTransportistaDA.Crear(Datos);
        }
        public static ENResultOperation Actualizar(ClsTransportistaBE Datos)
        {
            return ClsTransportistaDA.Actualizar(Datos);
        }

        public static ENResultOperation Eliminar(ClsTransportistaBE Datos)
        {
            return ClsTransportistaDA.Eliminar(Datos);
        }

        public static ENResultOperation Listar(string Texto_Buscar)
        {

            return ClsTransportistaDA.Listar(Texto_Buscar);
        }

        public static ENResultOperation Listar_Filtro(string Texto_Buscar)
        {

            return ClsTransportistaDA.Listar_Filtro(Texto_Buscar);
        }

        public static ENResultOperation Consultar_Ide(Int32 Tran_Ide)
        {

            return ClsTransportistaDA.Consultar_Ide(Tran_Ide);
        }

        public static ENResultOperation Listar_Nombre(string Tran_Nombre)
        {

            return ClsTransportistaDA.Listar_Nombre(Tran_Nombre);
        }
    }
}
