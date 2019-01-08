using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaBE;
using CapaDA;

namespace CapaBC
{
    class Tipo_Documento_IdentidadBC
    {
    }
    public class ClsTipo_Documento_IdentidadBC
    {
        public static ENResultOperation Crear(ClsTipo_Documento_IdentidadBE Datos)
        {
            return ClsTipo_Documento_IdentidadDA.Crear(Datos);
        }
        public static ENResultOperation Actualizar(ClsTipo_Documento_IdentidadBE Datos)
        {
            return ClsTipo_Documento_IdentidadDA.Actualizar(Datos);
        }

        public static ENResultOperation Eliminar(ClsTipo_Documento_IdentidadBE Datos)
        {
            return ClsTipo_Documento_IdentidadDA.Eliminar(Datos);
        }

        public static ENResultOperation Listar(string Texto_Buscar)
        {

            return ClsTipo_Documento_IdentidadDA.Listar(Texto_Buscar);
        }

        public static ENResultOperation Listar_Filtro(string Texto_Buscar)
        {

            return ClsTipo_Documento_IdentidadDA.Listar_Filtro(Texto_Buscar);
        }
    }
}
