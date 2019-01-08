using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaBE;
using CapaDA;


namespace CapaBC
{
    class Categoria_ClienteBC
    {
    }
        public class ClsCategoria_ClienteBC
        {
            public static ENResultOperation Crear(ClsCategoria_ClienteBE Datos)
            {
                return ClsCategoria_ClienteDA.Crear(Datos);
            }
            public static ENResultOperation Actualizar(ClsCategoria_ClienteBE Datos)
            {
                return ClsCategoria_ClienteDA.Actualizar(Datos);
            }

            public static ENResultOperation Eliminar(ClsCategoria_ClienteBE Datos)
            {
                return ClsCategoria_ClienteDA.Eliminar(Datos);
            }

            public static ENResultOperation Listar(string Texto_Buscar)
            {

                return ClsCategoria_ClienteDA.Listar(Texto_Buscar);
            }

            public static ENResultOperation Listar_Filtro(string Texto_Buscar)
            {

                return ClsCategoria_ClienteDA.Listar_Filtro(Texto_Buscar);
            }
        }
    
}
