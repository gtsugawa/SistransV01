using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaBE
{
    class TablasGeneralesBE
    {
    }

    public class clsArticuloBE
    {
        int arti_ide;
        string arti_tipo;
        string arti_nombre;
        string arti_modelo;
        string arti_codigo;
        string arti_estado;
        DateTime arti_fechainac;

        public clsArticuloBE()
        {
  
        }

        public clsArticuloBE(int arti_ide, string arti_tipo, string arti_nombre, string arti_modelo, string arti_codigo, string arti_estado, DateTime arti_fechainac)
        {
            this.arti_ide = arti_ide;
            this.arti_tipo = arti_tipo;
            this.arti_nombre = arti_nombre;
            this.arti_modelo = arti_modelo;
            this.arti_codigo = arti_codigo;
            this.arti_estado = arti_estado;
            this.arti_fechainac = arti_fechainac;
        }

        public int Arti_ide
        {
            get
            {
                return arti_ide;
            }

            set
            {
                arti_ide = value;
            }
        }

        public string Arti_tipo
        {
            get
            {
                return arti_tipo;
            }

            set
            {
                arti_tipo = value;
            }
        }

        public string Arti_nombre
        {
            get
            {
                return arti_nombre;
            }

            set
            {
                arti_nombre = value;
            }
        }

        public string Arti_modelo
        {
            get
            {
                return arti_modelo;
            }

            set
            {
                arti_modelo = value;
            }
        }

        public string Arti_codigo
        {
            get
            {
                return arti_codigo;
            }

            set
            {
                arti_codigo = value;
            }
        }

        public string Arti_estado
        {
            get
            {
                return arti_estado;
            }

            set
            {
                arti_estado = value;
            }
        }

        public DateTime Arti_fechainac
        {
            get
            {
                return arti_fechainac;
            }

            set
            {
                arti_fechainac = value;
            }
        }
    }

    public class clsArticulo_Unidad_MedidaBE
    {
        int arti_ide;
        int unid_medi_ide;

        public clsArticulo_Unidad_MedidaBE()
        {
  
        }


        public clsArticulo_Unidad_MedidaBE(int arti_ide, int unid_medi_ide)
        {
            this.arti_ide = arti_ide;
            this.unid_medi_ide = unid_medi_ide;
        }
        public int Arti_ide
        {
            get
            {
                return arti_ide;
            }

            set
            {
                arti_ide = value;
            }
        }

        public int Unid_medi_ide
        {
            get
            {
                return unid_medi_ide;
            }

            set
            {
                unid_medi_ide = value;
            }
        }
    }

    public class clsColorBE
    {
        int color_ide;
        string color_nombre;
        string color_estado;
        DateTime color_fechainac;
        DateTime creacion;
        int veces;

        public clsColorBE()
        {
  
        }

        public clsColorBE(int color_ide, string color_nombre, string color_estado, DateTime color_fechainac, DateTime creacion, int veces)
        {
            this.color_ide = color_ide;
            this.color_nombre = color_nombre;
            this.color_estado = color_estado;
            this.color_fechainac = color_fechainac;
            this.creacion = creacion;
            this.veces = veces;
        }
        public int Color_ide
        {
            get
            {
                return color_ide;
            }

            set
            {
                color_ide = value;
            }
        }

        public string Color_nombre
        {
            get
            {
                return color_nombre;
            }

            set
            {
                color_nombre = value;
            }
        }

        public string Color_estado
        {
            get
            {
                return color_estado;
            }

            set
            {
                color_estado = value;
            }
        }

        public DateTime Color_fechainac
        {
            get
            {
                return color_fechainac;
            }

            set
            {
                color_fechainac = value;
            }
        }

        public DateTime Creacion
        {
            get
            {
                return creacion;
            }

            set
            {
                creacion = value;
            }
        }

        public int Veces
        {
            get
            {
                return veces;
            }

            set
            {
                veces = value;
            }
        }
    }

    public class clsTipo_ProductoBE
    {
        int tipo_prod_ide;
        string tipo_prod_nombre;
        string tipo_prod_estado;
        DateTime tipo_prod_fechainac;
        DateTime creacion;
        int veces;

        public clsTipo_ProductoBE()
        {
     
        }


        public clsTipo_ProductoBE(int tipo_prod_ide, string tipo_prod_nombre, string tipo_prod_estado, DateTime tipo_prod_fechainac, DateTime creacion, int veces)
        {
            this.tipo_prod_ide = tipo_prod_ide;
            this.tipo_prod_nombre = tipo_prod_nombre;
            this.tipo_prod_estado = tipo_prod_estado;
            this.tipo_prod_fechainac = tipo_prod_fechainac;
            this.creacion = creacion;
            this.veces = veces;
        }

        public int Tipo_prod_ide
        {
            get
            {
                return tipo_prod_ide;
            }

            set
            {
                tipo_prod_ide = value;
            }
        }

        public string Tipo_prod_nombre
        {
            get
            {
                return tipo_prod_nombre;
            }

            set
            {
                tipo_prod_nombre = value;
            }
        }

        public string Tipo_prod_estado
        {
            get
            {
                return tipo_prod_estado;
            }

            set
            {
                tipo_prod_estado = value;
            }
        }

        public DateTime Tipo_prod_fechainac
        {
            get
            {
                return tipo_prod_fechainac;
            }

            set
            {
                tipo_prod_fechainac = value;
            }
        }

        public DateTime Creacion
        {
            get
            {
                return creacion;
            }

            set
            {
                creacion = value;
            }
        }

        public int Veces
        {
            get
            {
                return veces;
            }

            set
            {
                veces = value;
            }
        }
    }

    public class clsForma_PagoBE
    {
        int for_pag_ide;
        string for_pag_nombre;
        string for_pag_canje;
        int for_pag_numero_documento;
        int for_pag_vencimiento1;
        string for_pag_lista_precio;
        string for_pag_estado;
        DateTime for_pag_fechainac;
        DateTime creacion;
        int veces;

        public clsForma_PagoBE(int for_pag_ide, string for_pag_nombre, string for_pag_canje, int for_pag_numero_documento, int for_pag_vencimiento1, string for_pag_lista_precio, string for_pag_estado, DateTime for_pag_fechainac, DateTime creacion, int veces)
        {
            this.for_pag_ide = for_pag_ide;
            this.for_pag_nombre = for_pag_nombre;
            this.for_pag_canje = for_pag_canje;
            this.for_pag_numero_documento = for_pag_numero_documento;
            this.for_pag_vencimiento1 = for_pag_vencimiento1;
            this.for_pag_lista_precio = for_pag_lista_precio;
            this.for_pag_estado = for_pag_estado;
            this.for_pag_fechainac = for_pag_fechainac;
            this.creacion = creacion;
            this.veces = veces;
        }

        public clsForma_PagoBE()
        {
  
        }

        public int For_pag_ide
        {
            get
            {
                return for_pag_ide;
            }

            set
            {
                for_pag_ide = value;
            }
        }

        public string For_pag_nombre
        {
            get
            {
                return for_pag_nombre;
            }

            set
            {
                for_pag_nombre = value;
            }
        }

        public string For_pag_canje
        {
            get
            {
                return for_pag_canje;
            }

            set
            {
                for_pag_canje = value;
            }
        }

        public int For_pag_numero_documento
        {
            get
            {
                return for_pag_numero_documento;
            }

            set
            {
                for_pag_numero_documento = value;
            }
        }

        public int For_pag_vencimiento1
        {
            get
            {
                return for_pag_vencimiento1;
            }

            set
            {
                for_pag_vencimiento1 = value;
            }
        }

        public string For_pag_lista_precio
        {
            get
            {
                return for_pag_lista_precio;
            }

            set
            {
                for_pag_lista_precio = value;
            }
        }

        public string For_pag_estado
        {
            get
            {
                return for_pag_estado;
            }

            set
            {
                for_pag_estado = value;
            }
        }

        public DateTime For_pag_fechainac
        {
            get
            {
                return for_pag_fechainac;
            }

            set
            {
                for_pag_fechainac = value;
            }
        }

        public DateTime Creacion
        {
            get
            {
                return creacion;
            }

            set
            {
                creacion = value;
            }
        }

        public int Veces
        {
            get
            {
                return veces;
            }

            set
            {
                veces = value;
            }
        }
    }

}
