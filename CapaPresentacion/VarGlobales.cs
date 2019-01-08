using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace CapaPresentacion
{
    public static class VarGlobales
    {
        private static string _NombreEmpresa = string.Empty;
        private static string _CodigoUsuario = string.Empty;
        private static string _NombreUsuario = string.Empty;
        private static string _Transportista = string.Empty;
        private static decimal _PorcentajeIgv = 0;
        private static decimal _PorcentajeIsc = 0;
        public static string NombreEmpresa
        {
            get
            {
                return _NombreEmpresa;
            }
            set
            {
                _NombreEmpresa = value;
            }
        }

        public static string CodigoUsuario
        {
            get
            {
                return _CodigoUsuario;
            }
            set
            {
                _CodigoUsuario = value;
            }
        }
        public static string NombreUsuario
        {
            get
            {
                return _NombreUsuario;
            }
            set
            {
                _NombreUsuario = value;
            }
        }

        public static string Transportista
        {
            get
            {
                return _Transportista;
            }
            set
            {
                _Transportista = value;
            }

        }
        public static decimal PorcentajeIgv
        {
            get
            {
                return _PorcentajeIgv;
            }
            set
            {
                _PorcentajeIgv = value;
            }

        }
        public static decimal PorcentajeIsc
        {
            get
            {
                return _PorcentajeIsc;
            }
            set
            {
                _PorcentajeIsc = value;
            }

        }

    }
}
