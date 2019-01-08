using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaBE;
using CapaDA;

namespace CapaBC
{
    class Cliente_Punto_PartidaBC
    {
    }

    public class ClsCliente_Punto_PartidaBC
    {
        public static ENResultOperation Crear(ClsCliente_Punto_PartidaBE Datos)
        {
            return ClsCliente_Punto_PartidaDA.Crear(Datos);
        }
        public static ENResultOperation Actualizar(ClsCliente_Punto_PartidaBE Datos)
        {
            return ClsCliente_Punto_PartidaDA.Actualizar(Datos);
        }

        public static ENResultOperation Eliminar(ClsCliente_Punto_PartidaBE Datos)
        {
            return ClsCliente_Punto_PartidaDA.Eliminar(Datos);
        }

        public static ENResultOperation Listar(Int32 Clie_Ide)
        {

            return ClsCliente_Punto_PartidaDA.Listar(Clie_Ide);
        }
        public static ENResultOperation Encontrar(Int32 Clie_Ide, Int32 Part_Ide)
        {

            return ClsCliente_Punto_PartidaDA.Encontrar(Clie_Ide, Part_Ide);
        }

        public static ENResultOperation Listar_Filtro(string Texto_Buscar)
        {

            return ClsCliente_Punto_PartidaDA.Listar_Filtro(Texto_Buscar);
        }
    }
}
