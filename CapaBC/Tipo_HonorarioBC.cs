using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaBE;
using CapaDA;

namespace CapaBC
{
    class Tipo_HonorarioBC
    {
    }
    public class ClsTipo_HonorarioBC
    {
        public static ENResultOperation Crear(ClsTipo_HonorarioBE Datos)
        {
            return ClsTipo_HonorarioDA.Crear(Datos);
        }
        public static ENResultOperation Actualizar(ClsTipo_HonorarioBE Datos)
        {
            return ClsTipo_HonorarioDA.Actualizar(Datos);
        }

        public static ENResultOperation Eliminar(ClsTipo_HonorarioBE Datos)
        {
            return ClsTipo_HonorarioDA.Eliminar(Datos);
        }

        public static ENResultOperation Listar(string Texto_Buscar)
        {

            return ClsTipo_HonorarioDA.Listar(Texto_Buscar);
        }

        public static ENResultOperation Listar_Filtro(string Texto_Buscar)
        {

            return ClsTipo_HonorarioDA.Listar_Filtro(Texto_Buscar);
        }
    }
}
