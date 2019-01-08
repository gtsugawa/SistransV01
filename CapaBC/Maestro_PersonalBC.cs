using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaBE;
using CapaDA;

namespace CapaBC
{
    class Maestro_PersonalBC
    {
    }
    public class ClsMaestro_PersonalBC
    {
        public static ENResultOperation Crear(ClsMaestro_PersonalBE Datos)
        {
            return ClsMaestro_PersonalDA.Crear(Datos);
        }
        public static ENResultOperation Actualizar(ClsMaestro_PersonalBE Datos)
        {
            return ClsMaestro_PersonalDA.Actualizar(Datos);
        }

        public static ENResultOperation Eliminar(ClsMaestro_PersonalBE Datos)
        {
            return ClsMaestro_PersonalDA.Eliminar(Datos);
        }

        public static ENResultOperation Listar(string Texto_Buscar)
        {

            return ClsMaestro_PersonalDA.Listar(Texto_Buscar);
        }
        public static ENResultOperation Listar_Filtro(string Texto_Buscar, Int32 Pers_Ide)
        {

            return ClsMaestro_PersonalDA.Listar_Filtro(Texto_Buscar,Pers_Ide);
        }
        public static ENResultOperation Existe_Personal_Documento(string Documento)
        {

            return ClsMaestro_PersonalDA.Existe_Personal_Documento(Documento);
        }
        public static ENResultOperation Buscar_Filtro(string ApPaterno, string ApMaterno)
        {

            return ClsMaestro_PersonalDA.Buscar_Filtro(ApPaterno, ApMaterno);
        }
        public static ENResultOperation Obtener_Registro(Int32 Pers_Ide)
        {

            return ClsMaestro_PersonalDA.Obtener_Registro(Pers_Ide);
        }
    }
}
