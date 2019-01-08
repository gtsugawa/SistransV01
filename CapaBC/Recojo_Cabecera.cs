using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaBE;
using CapaDA;

namespace CapaBC
{
    class Recojo_Cabecera
    {
    }
    public class ClsRecojo_CabeceraBC
    {
        public static ENResultOperation Crear(clsRecojo_CabeceraBE Datos)
        {
            return clsRecojo_CabeceraDA.Crear(Datos);
        }
        public static ENResultOperation Actualizar(clsRecojo_CabeceraBE Datos)
        {
            return clsRecojo_CabeceraDA.Actualizar(Datos);
        }

        public static ENResultOperation Eliminar(clsRecojo_CabeceraBE Datos)
        {
            return clsRecojo_CabeceraDA.Eliminar(Datos);
        }
        public static ENResultOperation Actualiza_Estado_Digitacion(Int32 Reco_Ide, Int32 Estado)
        {
            return clsRecojo_CabeceraDA.Actualiza_Estado_Digitacion(Reco_Ide,Estado);
        }

        public static ENResultOperation Listar(string Texto_Buscar)
        {

            return clsRecojo_CabeceraDA.Listar(Texto_Buscar);
        }

        public static ENResultOperation Listar_Filtro(string Campo_Buscar,string Condicion, Int32 Estado_Digitacion )
        {

            return clsRecojo_CabeceraDA.Listar_Filtro(Campo_Buscar,Condicion, Estado_Digitacion);
        }


        public static ENResultOperation Obtener_Registro(Int32 Reco_Ide)
        {

            return clsRecojo_CabeceraDA.Obtener_Registro(Reco_Ide);
        }
        public static ENResultOperation Buscar_Orden(Int32 Orden)
        {

            return clsRecojo_CabeceraDA.Buscar_Orden(Orden);
        }
    }
}
