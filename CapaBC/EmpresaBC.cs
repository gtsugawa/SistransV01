using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaBE;
using CapaDA;

namespace CapaBC
{
    class EmpresaBC
    {
    }
    public class ClsEmpresaBC
    {
        public static ENResultOperation Crear(ClsEmpresaBE Datos)
        {
            return ClsEmpresaDA.Crear(Datos);
        }
        public static ENResultOperation Actualizar(ClsEmpresaBE Datos)
        {
            return ClsEmpresaDA.Actualizar(Datos);
        }

        public static ENResultOperation Eliminar(ClsEmpresaBE Datos)
        {
            return ClsEmpresaDA.Eliminar(Datos);
        }

        public static ENResultOperation Listar(string Texto_Buscar)
        {

            return ClsEmpresaDA.Listar(Texto_Buscar);
        }

        public static ENResultOperation Listar_Filtro(Int32 Empresa)
        {

            return ClsEmpresaDA.Listar_Filtro(Empresa);
        }
    }
}
