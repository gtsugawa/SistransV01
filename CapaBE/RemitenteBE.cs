using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaBE
{
    class RemitenteBE
    {
    }

    public class clsRemitenteBE
    {
        int prov_ide;
        string prov_codigo;
        string prov_razon_social;
        string prov_empresa;
        string prov_ruc;
        DateTime prov_fecha_constitucion;
        int acti_clie_ide;
        int tipo_clie_ide;
        int cate_clie_ide;
        string prov_direccion;
        int loca_ide;
        string prov_telefono1;
        string prov_telefono2;
        string prov_fax;
        string prov_correo;
        string prov_paterno;
        string prov_materno;
        string prov_nombre;
        string prov_estado;
        DateTime prov_fechainac;
        DateTime creacion;
        int veces;
        int lrc_ide;
        int tiene_cliente;

        public clsRemitenteBE()
        {

        }

        public clsRemitenteBE(int prov_ide, string prov_codigo, string prov_razon_social, string prov_empresa, string prov_ruc, DateTime prov_fecha_constitucion, int acti_clie_ide, int tipo_clie_ide, int cate_clie_ide, string prov_direccion, int loca_ide, string prov_telefono1, string prov_telefono2, string prov_fax, string prov_correo, string prov_paterno, string prov_materno, string prov_nombre, string prov_estado, DateTime prov_fechainac, DateTime creacion, int veces, int lrc_ide, int tiene_cliente)
        {
            this.prov_ide = prov_ide;
            this.prov_codigo = prov_codigo;
            this.prov_razon_social = prov_razon_social;
            this.prov_empresa = prov_empresa;
            this.prov_ruc = prov_ruc;
            this.prov_fecha_constitucion = prov_fecha_constitucion;
            this.acti_clie_ide = acti_clie_ide;
            this.tipo_clie_ide = tipo_clie_ide;
            this.cate_clie_ide = cate_clie_ide;
            this.prov_direccion = prov_direccion;
            this.loca_ide = loca_ide;
            this.prov_telefono1 = prov_telefono1;
            this.prov_telefono2 = prov_telefono2;
            this.prov_fax = prov_fax;
            this.prov_correo = prov_correo;
            this.prov_paterno = prov_paterno;
            this.prov_materno = prov_materno;
            this.prov_nombre = prov_nombre;
            this.prov_estado = prov_estado;
            this.prov_fechainac = prov_fechainac;
            this.creacion = creacion;
            this.veces = veces;
            this.lrc_ide = lrc_ide;
            this.tiene_cliente = tiene_cliente;
        }

        public int Prov_ide
        {
            get
            {
                return prov_ide;
            }

            set
            {
                prov_ide = value;
            }
        }

        public string Prov_codigo
        {
            get
            {
                return prov_codigo;
            }

            set
            {
                prov_codigo = value;
            }
        }

        public string Prov_razon_social
        {
            get
            {
                return prov_razon_social;
            }

            set
            {
                prov_razon_social = value;
            }
        }

        public string Prov_empresa
        {
            get
            {
                return prov_empresa;
            }

            set
            {
                prov_empresa = value;
            }
        }

        public string Prov_ruc
        {
            get
            {
                return prov_ruc;
            }

            set
            {
                prov_ruc = value;
            }
        }

        public DateTime Prov_fecha_constitucion
        {
            get
            {
                return prov_fecha_constitucion;
            }

            set
            {
                prov_fecha_constitucion = value;
            }
        }

        public int Acti_clie_ide
        {
            get
            {
                return acti_clie_ide;
            }

            set
            {
                acti_clie_ide = value;
            }
        }

        public int Tipo_clie_ide
        {
            get
            {
                return tipo_clie_ide;
            }

            set
            {
                tipo_clie_ide = value;
            }
        }

        public int Cate_clie_ide
        {
            get
            {
                return cate_clie_ide;
            }

            set
            {
                cate_clie_ide = value;
            }
        }

        public string Prov_direccion
        {
            get
            {
                return prov_direccion;
            }

            set
            {
                prov_direccion = value;
            }
        }

        public int Loca_ide
        {
            get
            {
                return loca_ide;
            }

            set
            {
                loca_ide = value;
            }
        }

        public string Prov_telefono1
        {
            get
            {
                return prov_telefono1;
            }

            set
            {
                prov_telefono1 = value;
            }
        }

        public string Prov_telefono2
        {
            get
            {
                return prov_telefono2;
            }

            set
            {
                prov_telefono2 = value;
            }
        }

        public string Prov_fax
        {
            get
            {
                return prov_fax;
            }

            set
            {
                prov_fax = value;
            }
        }

        public string Prov_correo
        {
            get
            {
                return prov_correo;
            }

            set
            {
                prov_correo = value;
            }
        }

        public string Prov_paterno
        {
            get
            {
                return prov_paterno;
            }

            set
            {
                prov_paterno = value;
            }
        }

        public string Prov_materno
        {
            get
            {
                return prov_materno;
            }

            set
            {
                prov_materno = value;
            }
        }

        public string Prov_nombre
        {
            get
            {
                return prov_nombre;
            }

            set
            {
                prov_nombre = value;
            }
        }

        public string Prov_estado
        {
            get
            {
                return prov_estado;
            }

            set
            {
                prov_estado = value;
            }
        }

        public DateTime Prov_fechainac
        {
            get
            {
                return prov_fechainac;
            }

            set
            {
                prov_fechainac = value;
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

        public int Lrc_ide
        {
            get
            {
                return lrc_ide;
            }

            set
            {
                lrc_ide = value;
            }
        }

        public int Tiene_cliente
        {
            get
            {
                return tiene_cliente;
            }

            set
            {
                tiene_cliente = value;
            }
        }
    }

    public class clsRemitente_NotaBE
    {
        int prov_ide;
        int prov_nota_ide;
        string prov_nota_nota;
        DateTime creacion;
        int veces;

        public clsRemitente_NotaBE()
        {

        }


        public clsRemitente_NotaBE(int prov_ide, int prov_nota_ide, string prov_nota_nota, DateTime creacion, int veces)
        {
            this.prov_ide = prov_ide;
            this.prov_nota_ide = prov_nota_ide;
            this.prov_nota_nota = prov_nota_nota;
            this.creacion = creacion;
            this.veces = veces;
        }
        public int Prov_ide
        {
            get
            {
                return prov_ide;
            }

            set
            {
                prov_ide = value;
            }
        }

        public int Prov_nota_ide
        {
            get
            {
                return prov_nota_ide;
            }

            set
            {
                prov_nota_ide = value;
            }
        }

        public string Prov_nota_nota
        {
            get
            {
                return prov_nota_nota;
            }

            set
            {
                prov_nota_nota = value;
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

    public class clsProveedorBE
    {
        int prov_ide;
        string prov_codigo;
        string prov_razon_social;
        string prov_empresa;
        string prov_detraccion;
        string prov_ruc;
        DateTime prov_fecha_constitucion;
        string prov_direccion;
        int loca_ide;
        string prov_telefono1;
        string prov_telefono2;
        string prov_fax;
        int tipo_prov_ide;
        int acti_prov_ide;
        int cate_prov_ide;
        string prov_correo;
        string prov_paterno;
        string prov_materno;
        string prov_nombre;
        string prov_estado;
        DateTime prov_fechainac;
        DateTime creacion;
        int veces;

        public clsProveedorBE()
        {
 
        }

        public clsProveedorBE(int prov_ide, string prov_codigo, string prov_razon_social, string prov_empresa, string prov_detraccion, string prov_ruc, DateTime prov_fecha_constitucion, string prov_direccion, int loca_ide, string prov_telefono1, string prov_telefono2, string prov_fax, int tipo_prov_ide, int acti_prov_ide, int cate_prov_ide, string prov_correo, string prov_paterno, string prov_materno, string prov_nombre, string prov_estado, DateTime prov_fechainac, DateTime creacion, int veces)
        {
            this.prov_ide = prov_ide;
            this.prov_codigo = prov_codigo;
            this.prov_razon_social = prov_razon_social;
            this.prov_empresa = prov_empresa;
            this.prov_detraccion = prov_detraccion;
            this.prov_ruc = prov_ruc;
            this.prov_fecha_constitucion = prov_fecha_constitucion;
            this.prov_direccion = prov_direccion;
            this.loca_ide = loca_ide;
            this.prov_telefono1 = prov_telefono1;
            this.prov_telefono2 = prov_telefono2;
            this.prov_fax = prov_fax;
            this.tipo_prov_ide = tipo_prov_ide;
            this.acti_prov_ide = acti_prov_ide;
            this.cate_prov_ide = cate_prov_ide;
            this.prov_correo = prov_correo;
            this.prov_paterno = prov_paterno;
            this.prov_materno = prov_materno;
            this.prov_nombre = prov_nombre;
            this.prov_estado = prov_estado;
            this.prov_fechainac = prov_fechainac;
            this.creacion = creacion;
            this.veces = veces;
        }

        public int Prov_ide
        {
            get
            {
                return prov_ide;
            }

            set
            {
                prov_ide = value;
            }
        }

        public string Prov_codigo
        {
            get
            {
                return prov_codigo;
            }

            set
            {
                prov_codigo = value;
            }
        }

        public string Prov_razon_social
        {
            get
            {
                return prov_razon_social;
            }

            set
            {
                prov_razon_social = value;
            }
        }

        public string Prov_empresa
        {
            get
            {
                return prov_empresa;
            }

            set
            {
                prov_empresa = value;
            }
        }

        public string Prov_detraccion
        {
            get
            {
                return prov_detraccion;
            }

            set
            {
                prov_detraccion = value;
            }
        }

        public string Prov_ruc
        {
            get
            {
                return prov_ruc;
            }

            set
            {
                prov_ruc = value;
            }
        }

        public DateTime Prov_fecha_constitucion
        {
            get
            {
                return prov_fecha_constitucion;
            }

            set
            {
                prov_fecha_constitucion = value;
            }
        }

        public string Prov_direccion
        {
            get
            {
                return prov_direccion;
            }

            set
            {
                prov_direccion = value;
            }
        }

        public int Loca_ide
        {
            get
            {
                return loca_ide;
            }

            set
            {
                loca_ide = value;
            }
        }

        public string Prov_telefono1
        {
            get
            {
                return prov_telefono1;
            }

            set
            {
                prov_telefono1 = value;
            }
        }

        public string Prov_telefono2
        {
            get
            {
                return prov_telefono2;
            }

            set
            {
                prov_telefono2 = value;
            }
        }

        public string Prov_fax
        {
            get
            {
                return prov_fax;
            }

            set
            {
                prov_fax = value;
            }
        }

        public int Tipo_prov_ide
        {
            get
            {
                return tipo_prov_ide;
            }

            set
            {
                tipo_prov_ide = value;
            }
        }

        public int Acti_prov_ide
        {
            get
            {
                return acti_prov_ide;
            }

            set
            {
                acti_prov_ide = value;
            }
        }

        public int Cate_prov_ide
        {
            get
            {
                return cate_prov_ide;
            }

            set
            {
                cate_prov_ide = value;
            }
        }

        public string Prov_correo
        {
            get
            {
                return prov_correo;
            }

            set
            {
                prov_correo = value;
            }
        }

        public string Prov_paterno
        {
            get
            {
                return prov_paterno;
            }

            set
            {
                prov_paterno = value;
            }
        }

        public string Prov_materno
        {
            get
            {
                return prov_materno;
            }

            set
            {
                prov_materno = value;
            }
        }

        public string Prov_nombre
        {
            get
            {
                return prov_nombre;
            }

            set
            {
                prov_nombre = value;
            }
        }

        public string Prov_estado
        {
            get
            {
                return prov_estado;
            }

            set
            {
                prov_estado = value;
            }
        }

        public DateTime Prov_fechainac
        {
            get
            {
                return prov_fechainac;
            }

            set
            {
                prov_fechainac = value;
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

    public class clsProveedor_Condicion_ComercialBE
    {
        int prov_ide;
        int prov_cond_ide;
        string prov_cond_condicion;
        DateTime creacion;
        int veces;

        public clsProveedor_Condicion_ComercialBE()
        {
 
        }

        public clsProveedor_Condicion_ComercialBE(int prov_ide, int prov_cond_ide, string prov_cond_condicion, DateTime creacion, int veces)
        {
            this.prov_ide = prov_ide;
            this.prov_cond_ide = prov_cond_ide;
            this.prov_cond_condicion = prov_cond_condicion;
            this.creacion = creacion;
            this.veces = veces;
        }

        public int Prov_ide
        {
            get
            {
                return prov_ide;
            }

            set
            {
                prov_ide = value;
            }
        }

        public int Prov_cond_ide
        {
            get
            {
                return prov_cond_ide;
            }

            set
            {
                prov_cond_ide = value;
            }
        }

        public string Prov_cond_condicion
        {
            get
            {
                return prov_cond_condicion;
            }

            set
            {
                prov_cond_condicion = value;
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

    public class clsProveedor_ContactoBE
    {
        int prov_ide;
        int prov_cont_ide;
        string prov_cont_titulo;
        string prov_cont_paterno;
        string prov_cont_materno;
        string prov_cont_nombre;
        int carg_ide;
        string prov_cont_direccion;
        int loca_ide;
        string prov_cont_telefono_casa;
        string prov_cont_telefono_celular;
        string prov_cont_fax;
        int docu_iden_ide;
        string prov_cont_documento;
        string prov_cont_fecha_nacimiento;
        string prov_cont_sexo;
        string prov_cont_estado_civil;
        string prov_cont_correo;
        string prov_cont_nota;
        DateTime creacion;
        int veces;

        public clsProveedor_ContactoBE()
        {
 
        }

        public clsProveedor_ContactoBE(int prov_ide, int prov_cont_ide, string prov_cont_titulo, string prov_cont_paterno, string prov_cont_materno, string prov_cont_nombre, int carg_ide, string prov_cont_direccion, int loca_ide, string prov_cont_telefono_casa, string prov_cont_telefono_celular, string prov_cont_fax, int docu_iden_ide, string prov_cont_documento, string prov_cont_fecha_nacimiento, string prov_cont_sexo, string prov_cont_estado_civil, string prov_cont_correo, string prov_cont_nota, DateTime creacion, int veces)
        {
            this.prov_ide = prov_ide;
            this.prov_cont_ide = prov_cont_ide;
            this.prov_cont_titulo = prov_cont_titulo;
            this.prov_cont_paterno = prov_cont_paterno;
            this.prov_cont_materno = prov_cont_materno;
            this.prov_cont_nombre = prov_cont_nombre;
            this.carg_ide = carg_ide;
            this.prov_cont_direccion = prov_cont_direccion;
            this.loca_ide = loca_ide;
            this.prov_cont_telefono_casa = prov_cont_telefono_casa;
            this.prov_cont_telefono_celular = prov_cont_telefono_celular;
            this.prov_cont_fax = prov_cont_fax;
            this.docu_iden_ide = docu_iden_ide;
            this.prov_cont_documento = prov_cont_documento;
            this.prov_cont_fecha_nacimiento = prov_cont_fecha_nacimiento;
            this.prov_cont_sexo = prov_cont_sexo;
            this.prov_cont_estado_civil = prov_cont_estado_civil;
            this.prov_cont_correo = prov_cont_correo;
            this.prov_cont_nota = prov_cont_nota;
            this.creacion = creacion;
            this.veces = veces;
        }

        public int Prov_ide
        {
            get
            {
                return prov_ide;
            }

            set
            {
                prov_ide = value;
            }
        }

        public int Prov_cont_ide
        {
            get
            {
                return prov_cont_ide;
            }

            set
            {
                prov_cont_ide = value;
            }
        }

        public string Prov_cont_titulo
        {
            get
            {
                return prov_cont_titulo;
            }

            set
            {
                prov_cont_titulo = value;
            }
        }

        public string Prov_cont_paterno
        {
            get
            {
                return prov_cont_paterno;
            }

            set
            {
                prov_cont_paterno = value;
            }
        }

        public string Prov_cont_materno
        {
            get
            {
                return prov_cont_materno;
            }

            set
            {
                prov_cont_materno = value;
            }
        }

        public string Prov_cont_nombre
        {
            get
            {
                return prov_cont_nombre;
            }

            set
            {
                prov_cont_nombre = value;
            }
        }

        public int Carg_ide
        {
            get
            {
                return carg_ide;
            }

            set
            {
                carg_ide = value;
            }
        }

        public string Prov_cont_direccion
        {
            get
            {
                return prov_cont_direccion;
            }

            set
            {
                prov_cont_direccion = value;
            }
        }

        public int Loca_ide
        {
            get
            {
                return loca_ide;
            }

            set
            {
                loca_ide = value;
            }
        }

        public string Prov_cont_telefono_casa
        {
            get
            {
                return prov_cont_telefono_casa;
            }

            set
            {
                prov_cont_telefono_casa = value;
            }
        }

        public string Prov_cont_telefono_celular
        {
            get
            {
                return prov_cont_telefono_celular;
            }

            set
            {
                prov_cont_telefono_celular = value;
            }
        }

        public string Prov_cont_fax
        {
            get
            {
                return prov_cont_fax;
            }

            set
            {
                prov_cont_fax = value;
            }
        }

        public int Docu_iden_ide
        {
            get
            {
                return docu_iden_ide;
            }

            set
            {
                docu_iden_ide = value;
            }
        }

        public string Prov_cont_documento
        {
            get
            {
                return prov_cont_documento;
            }

            set
            {
                prov_cont_documento = value;
            }
        }

        public string Prov_cont_fecha_nacimiento
        {
            get
            {
                return prov_cont_fecha_nacimiento;
            }

            set
            {
                prov_cont_fecha_nacimiento = value;
            }
        }

        public string Prov_cont_sexo
        {
            get
            {
                return prov_cont_sexo;
            }

            set
            {
                prov_cont_sexo = value;
            }
        }

        public string Prov_cont_estado_civil
        {
            get
            {
                return prov_cont_estado_civil;
            }

            set
            {
                prov_cont_estado_civil = value;
            }
        }

        public string Prov_cont_correo
        {
            get
            {
                return prov_cont_correo;
            }

            set
            {
                prov_cont_correo = value;
            }
        }

        public string Prov_cont_nota
        {
            get
            {
                return prov_cont_nota;
            }

            set
            {
                prov_cont_nota = value;
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

    public class clsProveedor_Girar_ABE
    {
        int prov_ide;
        int prov_gira_ide;
        string prov_gira_girar_a;
        DateTime creacion;
        int veces;

        public clsProveedor_Girar_ABE()
        {
 
        }

        public clsProveedor_Girar_ABE(int prov_ide, int prov_gira_ide, string prov_gira_girar_a, DateTime creacion, int veces)
        {
            this.prov_ide = prov_ide;
            this.prov_gira_ide = prov_gira_ide;
            this.prov_gira_girar_a = prov_gira_girar_a;
            this.creacion = creacion;
            this.veces = veces;
        }

        public int Prov_ide
        {
            get
            {
                return prov_ide;
            }

            set
            {
                prov_ide = value;
            }
        }

        public int Prov_gira_ide
        {
            get
            {
                return prov_gira_ide;
            }

            set
            {
                prov_gira_ide = value;
            }
        }

        public string Prov_gira_girar_a
        {
            get
            {
                return prov_gira_girar_a;
            }

            set
            {
                prov_gira_girar_a = value;
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

    public class clsProveedor_GrupoBE
    {
        int prov_ide;
        int prov_gru_ide;
        int prov_gru_ide_proveedor;
        DateTime creacion;
        int veces;

        public clsProveedor_GrupoBE()
        {
 
        }

        public clsProveedor_GrupoBE(int prov_ide, int prov_gru_ide, int prov_gru_ide_proveedor, DateTime creacion, int veces)
        {
            this.prov_ide = prov_ide;
            this.prov_gru_ide = prov_gru_ide;
            this.prov_gru_ide_proveedor = prov_gru_ide_proveedor;
            this.creacion = creacion;
            this.veces = veces;
        }

        public int Prov_ide
        {
            get
            {
                return prov_ide;
            }

            set
            {
                prov_ide = value;
            }
        }

        public int Prov_gru_ide
        {
            get
            {
                return prov_gru_ide;
            }

            set
            {
                prov_gru_ide = value;
            }
        }

        public int Prov_gru_ide_proveedor
        {
            get
            {
                return prov_gru_ide_proveedor;
            }

            set
            {
                prov_gru_ide_proveedor = value;
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

    public class clsProveedor_NotaBE
    {
        int prov_ide;
        int prov_nota_ide;
        string prov_nota_nota;
        DateTime creacion;
        int veces;

        public clsProveedor_NotaBE()
        {
   
        }

        public clsProveedor_NotaBE(int prov_ide, int prov_nota_ide, string prov_nota_nota, DateTime creacion, int veces)
        {
            this.prov_ide = prov_ide;
            this.prov_nota_ide = prov_nota_ide;
            this.prov_nota_nota = prov_nota_nota;
            this.creacion = creacion;
            this.veces = veces;
        }

        public int Prov_ide
        {
            get
            {
                return prov_ide;
            }

            set
            {
                prov_ide = value;
            }
        }

        public int Prov_nota_ide
        {
            get
            {
                return prov_nota_ide;
            }

            set
            {
                prov_nota_ide = value;
            }
        }

        public string Prov_nota_nota
        {
            get
            {
                return prov_nota_nota;
            }

            set
            {
                prov_nota_nota = value;
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

    public class clsActividad_ProveedorBE
    {
        int acti_prov_ide;
        string acti_prov_nombre;
        double acti_prov_monto_detraccion;
        string acti_prov_estado;
        DateTime acti_prov_fechainac;
        DateTime creacion;
        int veces;

        public clsActividad_ProveedorBE()
        {
 
        }

        public clsActividad_ProveedorBE(int acti_prov_ide, string acti_prov_nombre, double acti_prov_monto_detraccion, string acti_prov_estado, DateTime acti_prov_fechainac, DateTime creacion, int veces)
        {
            this.acti_prov_ide = acti_prov_ide;
            this.acti_prov_nombre = acti_prov_nombre;
            this.acti_prov_monto_detraccion = acti_prov_monto_detraccion;
            this.acti_prov_estado = acti_prov_estado;
            this.acti_prov_fechainac = acti_prov_fechainac;
            this.creacion = creacion;
            this.veces = veces;
        }

        public int Acti_prov_ide
        {
            get
            {
                return acti_prov_ide;
            }

            set
            {
                acti_prov_ide = value;
            }
        }

        public string Acti_prov_nombre
        {
            get
            {
                return acti_prov_nombre;
            }

            set
            {
                acti_prov_nombre = value;
            }
        }

        public double Acti_prov_monto_detraccion
        {
            get
            {
                return acti_prov_monto_detraccion;
            }

            set
            {
                acti_prov_monto_detraccion = value;
            }
        }

        public string Acti_prov_estado
        {
            get
            {
                return acti_prov_estado;
            }

            set
            {
                acti_prov_estado = value;
            }
        }

        public DateTime Acti_prov_fechainac
        {
            get
            {
                return acti_prov_fechainac;
            }

            set
            {
                acti_prov_fechainac = value;
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

    public class clsCategoria_ProveedorBE
    {
        int cate_prov_ide;
        string cate_prov_nombre;
        string cate_prov_estado;
        DateTime cate_prov_fechainac;
        DateTime creacion;
        int veces;

        public clsCategoria_ProveedorBE()
        {
 
        }

        public clsCategoria_ProveedorBE(int cate_prov_ide, string cate_prov_nombre, string cate_prov_estado, DateTime cate_prov_fechainac, DateTime creacion, int veces)
        {
            this.cate_prov_ide = cate_prov_ide;
            this.cate_prov_nombre = cate_prov_nombre;
            this.cate_prov_estado = cate_prov_estado;
            this.cate_prov_fechainac = cate_prov_fechainac;
            this.creacion = creacion;
            this.veces = veces;
        }

        public int Cate_prov_ide
        {
            get
            {
                return cate_prov_ide;
            }

            set
            {
                cate_prov_ide = value;
            }
        }

        public string Cate_prov_nombre
        {
            get
            {
                return cate_prov_nombre;
            }

            set
            {
                cate_prov_nombre = value;
            }
        }

        public string Cate_prov_estado
        {
            get
            {
                return cate_prov_estado;
            }

            set
            {
                cate_prov_estado = value;
            }
        }

        public DateTime Cate_prov_fechainac
        {
            get
            {
                return cate_prov_fechainac;
            }

            set
            {
                cate_prov_fechainac = value;
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

    public class clsTipo_ProveedorBE
    {
        int tipo_prov_ide;
        string tipo_prov_nombre;
        string tipo_prov_estado;
        DateTime tipo_prov_fechainac;
        DateTime creacion;
        int veces;

        public clsTipo_ProveedorBE()
        {
        }

        public clsTipo_ProveedorBE(int tipo_prov_ide, string tipo_prov_nombre, string tipo_prov_estado, DateTime tipo_prov_fechainac, DateTime creacion, int veces)
        {
            this.tipo_prov_ide = tipo_prov_ide;
            this.tipo_prov_nombre = tipo_prov_nombre;
            this.tipo_prov_estado = tipo_prov_estado;
            this.tipo_prov_fechainac = tipo_prov_fechainac;
            this.creacion = creacion;
            this.veces = veces;
        }

        public int Tipo_prov_ide
        {
            get
            {
                return tipo_prov_ide;
            }

            set
            {
                tipo_prov_ide = value;
            }
        }

        public string Tipo_prov_nombre
        {
            get
            {
                return tipo_prov_nombre;
            }

            set
            {
                tipo_prov_nombre = value;
            }
        }

        public string Tipo_prov_estado
        {
            get
            {
                return tipo_prov_estado;
            }

            set
            {
                tipo_prov_estado = value;
            }
        }

        public DateTime Tipo_prov_fechainac
        {
            get
            {
                return tipo_prov_fechainac;
            }

            set
            {
                tipo_prov_fechainac = value;
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
