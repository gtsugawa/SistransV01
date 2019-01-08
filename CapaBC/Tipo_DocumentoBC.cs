using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaBE;
using CapaDA;

namespace CapaBC
{
    class Tipo_DocumentoBC
    {
    }

    public class ClsTipo_DocumentoBC
    {
        public static ENResultOperation Crear(ClsTipo_DocumentoBE Datos)
        {
            return ClsTipo_DocumentoDA.Crear(Datos);
        }
        public static ENResultOperation Actualizar(ClsTipo_DocumentoBE Datos)
        {
            return ClsTipo_DocumentoDA.Actualizar(Datos);
        }

        public static ENResultOperation Eliminar(ClsTipo_DocumentoBE Datos)
        {
            return ClsTipo_DocumentoDA.Eliminar(Datos);
        }

        public static ENResultOperation Listar(string Texto_Buscar)
        {

            return ClsTipo_DocumentoDA.Listar(Texto_Buscar);
        }

        public static ENResultOperation Listar_Filtro(string Texto_Buscar)
        {

            return ClsTipo_DocumentoDA.Listar_Filtro(Texto_Buscar);
        }

        public static ENResultOperation Obtener_Registro(Int32 Gto_Ope_Ide)
        {

            return ClsTipo_DocumentoDA.Obtener_Registro(Gto_Ope_Ide);
        }
    }
}
