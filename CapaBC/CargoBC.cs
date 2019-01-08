using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaBE;
using CapaDA;

namespace CapaBC
{
    class CargoBC
    {
    }
    public class ClsCargoBC
    {
        public static ENResultOperation Crear(ClsCargoBE Datos)
        {
            return ClsCargoDA.Crear(Datos);
        }
        public static ENResultOperation Actualizar(ClsCargoBE Datos)
        {
            return ClsCargoDA.Actualizar(Datos);
        }

        public static ENResultOperation Eliminar(ClsCargoBE Datos)
        {
            return ClsCargoDA.Eliminar(Datos);
        }

        public static ENResultOperation Listar(string Texto_Buscar)
        {

            return ClsCargoDA.Listar(Texto_Buscar);
        }

        public static ENResultOperation Listar_Filtro(string Texto_Buscar)
        {

            return ClsCargoDA.Listar_Filtro(Texto_Buscar);
        }
    }
}
