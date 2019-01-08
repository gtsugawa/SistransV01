using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaBE
{
    class ClientesBE
    {
    }

    public class ClsClientesBE
    {
        int clie_ide;
        string clie_codigo;
        string clie_razon_social;
        string clie_empresa;
        string clie_relacionada;
        int docu_iden_ide;
        string clie_ruc;
        DateTime clie_fecha_constitucion;
        string clie_direccion;
        int loca_ide;
        string clie_telefono1;
        string clie_telefono2;
        string clie_fax;
        int tipo_clie_ide;
        int acti_clie_ide;
        int cate_clie_ide;
        string clie_correo;
        string clie_paterno;
        string clie_materno;
        string clie_nombre;
        string clie_estado;
        DateTime clie_fechainac;
        DateTime creacion;
        int veces;
        string nombre_error;
        string texto_buscar;
        string usuario;

        public ClsClientesBE()
        {
           
        }

        public ClsClientesBE(int clie_ide, string clie_codigo, string clie_razon_social, string clie_empresa,string clie_relacionada, int docu_iden_ide,string clie_ruc, DateTime clie_fecha_constitucion, string clie_direccion, int loca_ide, string clie_telefono1, string clie_telefono2, string clie_fax, int tipo_clie_ide, int acti_clie_ide, int cate_clie_ide, string clie_correo, string clie_paterno, string clie_materno, string clie_nombre, string clie_estado, DateTime clie_fechainac, DateTime creacion, int veces, string nombre_error, string texto_buscar,string usuario)
        {
            this.clie_ide = clie_ide;
            this.clie_codigo = clie_codigo;
            this.clie_razon_social = clie_razon_social;
            this.clie_empresa = clie_empresa;
            this.clie_relacionada = clie_relacionada;
            this.docu_iden_ide = docu_iden_ide;
            this.clie_ruc = clie_ruc;
            this.clie_fecha_constitucion = clie_fecha_constitucion;
            this.clie_direccion = clie_direccion;
            this.loca_ide = loca_ide;
            this.clie_telefono1 = clie_telefono1;
            this.clie_telefono2 = clie_telefono2;
            this.clie_fax = clie_fax;
            this.tipo_clie_ide = tipo_clie_ide;
            this.acti_clie_ide = acti_clie_ide;
            this.cate_clie_ide = cate_clie_ide;
            this.clie_correo = clie_correo;
            this.clie_paterno = clie_paterno;
            this.clie_materno = clie_materno;
            this.clie_nombre = clie_nombre;
            this.clie_estado = clie_estado;
            this.clie_fechainac = clie_fechainac;
            this.creacion = creacion;
            this.veces = veces;
            this.nombre_error = nombre_error;
            this.texto_buscar = texto_buscar;
            this.usuario = usuario;
        }

        public int Clie_ide
        {
            get
            {
                return clie_ide;
            }

            set
            {
                clie_ide = value;
            }
        }

        public string Clie_codigo
        {
            get
            {
                return clie_codigo;
            }

            set
            {
                clie_codigo = value;
            }
        }

        public string Clie_razon_social
        {
            get
            {
                return clie_razon_social;
            }

            set
            {
                clie_razon_social = value;
            }
        }

        public string Clie_empresa
        {
            get
            {
                return clie_empresa;
            }

            set
            {
                clie_empresa = value;
            }
        }

        public string Clie_relacionada
        {
            get
            {
                return clie_relacionada;
            }

            set
            {
                clie_relacionada = value;
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

        public string Clie_ruc
        {
            get
            {
                return clie_ruc;
            }

            set
            {
                clie_ruc = value;
            }
        }

        public DateTime Clie_fecha_constitucion
        {
            get
            {
                return clie_fecha_constitucion;
            }

            set
            {
                clie_fecha_constitucion = value;
            }
        }

        public string Clie_direccion
        {
            get
            {
                return clie_direccion;
            }

            set
            {
                clie_direccion = value;
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

        public string Clie_telefono1
        {
            get
            {
                return clie_telefono1;
            }

            set
            {
                clie_telefono1 = value;
            }
        }

        public string Clie_telefono2
        {
            get
            {
                return clie_telefono2;
            }

            set
            {
                clie_telefono2 = value;
            }
        }

        public string Clie_fax
        {
            get
            {
                return clie_fax;
            }

            set
            {
                clie_fax = value;
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

        public string Clie_correo
        {
            get
            {
                return clie_correo;
            }

            set
            {
                clie_correo = value;
            }
        }

        public string Clie_paterno
        {
            get
            {
                return clie_paterno;
            }

            set
            {
                clie_paterno = value;
            }
        }

        public string Clie_materno
        {
            get
            {
                return clie_materno;
            }

            set
            {
                clie_materno = value;
            }
        }

        public string Clie_nombre
        {
            get
            {
                return clie_nombre;
            }

            set
            {
                clie_nombre = value;
            }
        }

        public string Clie_estado
        {
            get
            {
                return clie_estado;
            }

            set
            {
                clie_estado = value;
            }
        }

        public DateTime Clie_fechainac
        {
            get
            {
                return clie_fechainac;
            }

            set
            {
                clie_fechainac = value;
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

        public string Nombre_error
        {
            get
            {
                return nombre_error;
            }

            set
            {
                nombre_error = value;
            }
        }

        public string Texto_buscar
        {
            get
            {
                return texto_buscar;
            }

            set
            {
                texto_buscar = value;
            }
        }

        public string Usuario
        {
            get
            {
                return usuario;
            }

            set
            {
                usuario = value;
            }
        }

    }

    public class clsCliente_ContactoBE
    {
        int clie_ide;
        int clie_cont_ide;
        string clie_cont_titulo;
        string clie_cont_paterno;
        string clie_cont_materno;
        string clie_cont_nombre;
        int carg_ide;
        string clie_cont_direccion;
        int loca_ide;
        string clie_cont_telefono_casa;
        string clie_cont_telefono_celular;
        string clie_cont_fax;
        int docu_iden_ide;
        string clie_cont_documento;
        string clie_cont_fecha_nacimiento;
        string clie_cont_sexo;
        string clie_cont_estado_civil;
        string clie_cont_correo;
        string clie_cont_nota;
        DateTime creacion;
        int veces;
        int lrc_ide;

        public clsCliente_ContactoBE()
        {

        }

        public clsCliente_ContactoBE(int clie_ide, int clie_cont_ide, string clie_cont_titulo, string clie_cont_paterno, string clie_cont_materno, string clie_cont_nombre, int carg_ide, string clie_cont_direccion, int loca_ide, string clie_cont_telefono_casa, string clie_cont_telefono_celular, string clie_cont_fax, int docu_iden_ide, string clie_cont_documento, string clie_cont_fecha_nacimiento, string clie_cont_sexo, string clie_cont_estado_civil, string clie_cont_correo, string clie_cont_nota, DateTime creacion, int veces, int lrc_ide)
        {
            this.clie_ide = clie_ide;
            this.clie_cont_ide = clie_cont_ide;
            this.clie_cont_titulo = clie_cont_titulo;
            this.clie_cont_paterno = clie_cont_paterno;
            this.clie_cont_materno = clie_cont_materno;
            this.clie_cont_nombre = clie_cont_nombre;
            this.carg_ide = carg_ide;
            this.clie_cont_direccion = clie_cont_direccion;
            this.loca_ide = loca_ide;
            this.clie_cont_telefono_casa = clie_cont_telefono_casa;
            this.clie_cont_telefono_celular = clie_cont_telefono_celular;
            this.clie_cont_fax = clie_cont_fax;
            this.docu_iden_ide = docu_iden_ide;
            this.clie_cont_documento = clie_cont_documento;
            this.clie_cont_fecha_nacimiento = clie_cont_fecha_nacimiento;
            this.clie_cont_sexo = clie_cont_sexo;
            this.clie_cont_estado_civil = clie_cont_estado_civil;
            this.clie_cont_correo = clie_cont_correo;
            this.clie_cont_nota = clie_cont_nota;
            this.creacion = creacion;
            this.veces = veces;
            this.lrc_ide = lrc_ide;
        }

        
        public int Clie_ide
        {
            get
            {
                return clie_ide;
            }

            set
            {
                clie_ide = value;
            }
        }

        public int Clie_cont_ide
        {
            get
            {
                return clie_cont_ide;
            }

            set
            {
                clie_cont_ide = value;
            }
        }

        public string Clie_cont_titulo
        {
            get
            {
                return clie_cont_titulo;
            }

            set
            {
                clie_cont_titulo = value;
            }
        }

        public string Clie_cont_paterno
        {
            get
            {
                return clie_cont_paterno;
            }

            set
            {
                clie_cont_paterno = value;
            }
        }

        public string Clie_cont_materno
        {
            get
            {
                return clie_cont_materno;
            }

            set
            {
                clie_cont_materno = value;
            }
        }

        public string Clie_cont_nombre
        {
            get
            {
                return clie_cont_nombre;
            }

            set
            {
                clie_cont_nombre = value;
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

        public string Clie_cont_direccion
        {
            get
            {
                return clie_cont_direccion;
            }

            set
            {
                clie_cont_direccion = value;
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

        public string Clie_cont_telefono_casa
        {
            get
            {
                return clie_cont_telefono_casa;
            }

            set
            {
                clie_cont_telefono_casa = value;
            }
        }

        public string Clie_cont_telefono_celular
        {
            get
            {
                return clie_cont_telefono_celular;
            }

            set
            {
                clie_cont_telefono_celular = value;
            }
        }

        public string Clie_cont_fax
        {
            get
            {
                return clie_cont_fax;
            }

            set
            {
                clie_cont_fax = value;
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

        public string Clie_cont_documento
        {
            get
            {
                return clie_cont_documento;
            }

            set
            {
                clie_cont_documento = value;
            }
        }

        public string Clie_cont_fecha_nacimiento
        {
            get
            {
                return clie_cont_fecha_nacimiento;
            }

            set
            {
                clie_cont_fecha_nacimiento = value;
            }
        }

        public string Clie_cont_sexo
        {
            get
            {
                return clie_cont_sexo;
            }

            set
            {
                clie_cont_sexo = value;
            }
        }

        public string Clie_cont_estado_civil
        {
            get
            {
                return clie_cont_estado_civil;
            }

            set
            {
                clie_cont_estado_civil = value;
            }
        }

        public string Clie_cont_correo
        {
            get
            {
                return clie_cont_correo;
            }

            set
            {
                clie_cont_correo = value;
            }
        }

        public string Clie_cont_nota
        {
            get
            {
                return clie_cont_nota;
            }

            set
            {
                clie_cont_nota = value;
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
    }

    public class ClsCliente_Contacto_Precio_BultoBE
    {
        int prov_cont_ide;
        int prov_cont_ide_detalle;
        int prov_bulto;
        double prov_precio_directo;
        double prov_precio_reparto;
        DateTime creacion;
        int	veces;

        public ClsCliente_Contacto_Precio_BultoBE()
        {
           
        }

        public ClsCliente_Contacto_Precio_BultoBE(int prov_cont_ide, int prov_cont_ide_detalle, int prov_bulto, double prov_precio_directo, double prov_precio_reparto, DateTime creacion, int veces)
        {
            this.prov_cont_ide = prov_cont_ide;
            this.prov_cont_ide_detalle = prov_cont_ide_detalle;
            this.prov_bulto = prov_bulto;
            this.prov_precio_directo = prov_precio_directo;
            this.prov_precio_reparto = prov_precio_reparto;
            this.creacion = creacion;
            this.veces = veces;
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

        public int Prov_cont_ide_detalle
        {
            get
            {
                return prov_cont_ide_detalle;
            }

            set
            {
                prov_cont_ide_detalle = value;
            }
        }

        public int Prov_bulto
        {
            get
            {
                return prov_bulto;
            }

            set
            {
                prov_bulto = value;
            }
        }

        public double Prov_precio_directo
        {
            get
            {
                return prov_precio_directo;
            }

            set
            {
                prov_precio_directo = value;
            }
        }

        public double Prov_precio_reparto
        {
            get
            {
                return prov_precio_reparto;
            }

            set
            {
                prov_precio_reparto = value;
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

    public class clsCliente_Contacto_Precio_KilogramoBE
    {
        int prov_cont_ide;
        int prov_cont_ide_detalle;
        double prov_kilogramo;
        double prov_precio_directo;
        double prov_precio_reparto;
        DateTime creacion;
        int veces;

        public clsCliente_Contacto_Precio_KilogramoBE()
        {
         
        }

        public clsCliente_Contacto_Precio_KilogramoBE(int prov_cont_ide, int prov_cont_ide_detalle, double prov_kilogramo, double prov_precio_directo, double prov_precio_reparto, DateTime creacion, int veces)
        {
            this.prov_cont_ide = prov_cont_ide;
            this.prov_cont_ide_detalle = prov_cont_ide_detalle;
            this.prov_kilogramo = prov_kilogramo;
            this.prov_precio_directo = prov_precio_directo;
            this.prov_precio_reparto = prov_precio_reparto;
            this.creacion = creacion;
            this.veces = veces;
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

        public int Prov_cont_ide_detalle
        {
            get
            {
                return prov_cont_ide_detalle;
            }

            set
            {
                prov_cont_ide_detalle = value;
            }
        }

        public double Prov_kilogramo
        {
            get
            {
                return prov_kilogramo;
            }

            set
            {
                prov_kilogramo = value;
            }
        }

        public double Prov_precio_directo
        {
            get
            {
                return prov_precio_directo;
            }

            set
            {
                prov_precio_directo = value;
            }
        }

        public double Prov_precio_reparto
        {
            get
            {
                return prov_precio_reparto;
            }

            set
            {
                prov_precio_reparto = value;
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

    public class clsCliente_Contacto_Precio_TonelajeBE
    {
        int prov_cont_ide;
        int prov_cont_ide_detalle;
        int prov_tonelaje;
        int prov_puntos;
        double prov_precio_directo;
        double prov_precio_reparto;
        int prov_tipo_recargo;
        int prov_puntos_hasta;
        double prov_porcentaje_exceso_reparto;
        int prov_puntos_2_hasta;
        double prov_porcentaje_exceso_reparto_2;
        int prov_puntos_3_hasta;
        double prov_porcentaje_exceso_reparto_3;
        int prov_puntos_4_hasta;
        double prov_porcentaje_exceso_reparto_4;
        DateTime creacion;
        int veces;
        int lrc_ide;

        public clsCliente_Contacto_Precio_TonelajeBE()
        {
         
        }
        public clsCliente_Contacto_Precio_TonelajeBE(int prov_cont_ide, int prov_cont_ide_detalle, int prov_tonelaje, int prov_puntos, double prov_precio_directo, double prov_precio_reparto, int prov_tipo_recargo, int prov_puntos_hasta, double prov_porcentaje_exceso_reparto, int prov_puntos_2_hasta, double prov_porcentaje_exceso_reparto_2, int prov_puntos_3_hasta, double prov_porcentaje_exceso_reparto_3, int prov_puntos_4_hasta, double prov_porcentaje_exceso_reparto_4, DateTime creacion, int veces, int lrc_ide)
        {
            this.prov_cont_ide = prov_cont_ide;
            this.prov_cont_ide_detalle = prov_cont_ide_detalle;
            this.prov_tonelaje = prov_tonelaje;
            this.prov_puntos = prov_puntos;
            this.prov_precio_directo = prov_precio_directo;
            this.prov_precio_reparto = prov_precio_reparto;
            this.prov_tipo_recargo = prov_tipo_recargo;
            this.prov_puntos_hasta = prov_puntos_hasta;
            this.prov_porcentaje_exceso_reparto = prov_porcentaje_exceso_reparto;
            this.prov_puntos_2_hasta = prov_puntos_2_hasta;
            this.prov_porcentaje_exceso_reparto_2 = prov_porcentaje_exceso_reparto_2;
            this.prov_puntos_3_hasta = prov_puntos_3_hasta;
            this.prov_porcentaje_exceso_reparto_3 = prov_porcentaje_exceso_reparto_3;
            this.prov_puntos_4_hasta = prov_puntos_4_hasta;
            this.prov_porcentaje_exceso_reparto_4 = prov_porcentaje_exceso_reparto_4;
            this.creacion = creacion;
            this.veces = veces;
            this.lrc_ide = lrc_ide;
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

        public int Prov_cont_ide_detalle
        {
            get
            {
                return prov_cont_ide_detalle;
            }

            set
            {
                prov_cont_ide_detalle = value;
            }
        }

        public int Prov_tonelaje
        {
            get
            {
                return prov_tonelaje;
            }

            set
            {
                prov_tonelaje = value;
            }
        }

        public int Prov_puntos
        {
            get
            {
                return prov_puntos;
            }

            set
            {
                prov_puntos = value;
            }
        }

        public double Prov_precio_directo
        {
            get
            {
                return prov_precio_directo;
            }

            set
            {
                prov_precio_directo = value;
            }
        }

        public double Prov_precio_reparto
        {
            get
            {
                return prov_precio_reparto;
            }

            set
            {
                prov_precio_reparto = value;
            }
        }

        public int Prov_tipo_recargo
        {
            get
            {
                return prov_tipo_recargo;
            }

            set
            {
                prov_tipo_recargo = value;
            }
        }

        public int Prov_puntos_hasta
        {
            get
            {
                return prov_puntos_hasta;
            }

            set
            {
                prov_puntos_hasta = value;
            }
        }

        public double Prov_porcentaje_exceso_reparto
        {
            get
            {
                return prov_porcentaje_exceso_reparto;
            }

            set
            {
                prov_porcentaje_exceso_reparto = value;
            }
        }

        public int Prov_puntos_2_hasta
        {
            get
            {
                return prov_puntos_2_hasta;
            }

            set
            {
                prov_puntos_2_hasta = value;
            }
        }

        public double Prov_porcentaje_exceso_reparto_2
        {
            get
            {
                return prov_porcentaje_exceso_reparto_2;
            }

            set
            {
                prov_porcentaje_exceso_reparto_2 = value;
            }
        }

        public int Prov_puntos_3_hasta
        {
            get
            {
                return prov_puntos_3_hasta;
            }

            set
            {
                prov_puntos_3_hasta = value;
            }
        }

        public double Prov_porcentaje_exceso_reparto_3
        {
            get
            {
                return prov_porcentaje_exceso_reparto_3;
            }

            set
            {
                prov_porcentaje_exceso_reparto_3 = value;
            }
        }

        public int Prov_puntos_4_hasta
        {
            get
            {
                return prov_puntos_4_hasta;
            }

            set
            {
                prov_puntos_4_hasta = value;
            }
        }

        public double Prov_porcentaje_exceso_reparto_4
        {
            get
            {
                return prov_porcentaje_exceso_reparto_4;
            }

            set
            {
                prov_porcentaje_exceso_reparto_4 = value;
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
      }

    public class clsCliente_ContactolrcBE
    {
        int clie_ide;
        int clie_cont_ide;
        string clie_cont_titulo;
        string clie_cont_paterno;
        string clie_cont_materno;
        string clie_cont_nombre;
        int carg_ide;
        string clie_cont_direccion;
        int loca_ide;
        string clie_cont_telefono_casa;
        string clie_cont_telefono_celular;
        string clie_cont_fax;
        int docu_iden_ide;
        string clie_cont_documento;
        string clie_cont_fecha_nacimiento;
        string clie_cont_sexo;
        string clie_cont_estado_civil;
        string clie_cont_correo;
        string clie_cont_nota;
        DateTime creacion;
        int veces;
        public clsCliente_ContactolrcBE()
        {
 
        }

        public clsCliente_ContactolrcBE(int clie_ide, int clie_cont_ide, string clie_cont_titulo, string clie_cont_paterno, string clie_cont_materno, string clie_cont_nombre, int carg_ide, string clie_cont_direccion, int loca_ide, string clie_cont_telefono_casa, string clie_cont_telefono_celular, string clie_cont_fax, int docu_iden_ide, string clie_cont_documento, string clie_cont_fecha_nacimiento, string clie_cont_sexo, string clie_cont_estado_civil, string clie_cont_correo, string clie_cont_nota, DateTime creacion, int veces)
        {
            this.clie_ide = clie_ide;
            this.clie_cont_ide = clie_cont_ide;
            this.clie_cont_titulo = clie_cont_titulo;
            this.clie_cont_paterno = clie_cont_paterno;
            this.clie_cont_materno = clie_cont_materno;
            this.clie_cont_nombre = clie_cont_nombre;
            this.carg_ide = carg_ide;
            this.clie_cont_direccion = clie_cont_direccion;
            this.loca_ide = loca_ide;
            this.clie_cont_telefono_casa = clie_cont_telefono_casa;
            this.clie_cont_telefono_celular = clie_cont_telefono_celular;
            this.clie_cont_fax = clie_cont_fax;
            this.docu_iden_ide = docu_iden_ide;
            this.clie_cont_documento = clie_cont_documento;
            this.clie_cont_fecha_nacimiento = clie_cont_fecha_nacimiento;
            this.clie_cont_sexo = clie_cont_sexo;
            this.clie_cont_estado_civil = clie_cont_estado_civil;
            this.clie_cont_correo = clie_cont_correo;
            this.clie_cont_nota = clie_cont_nota;
            this.creacion = creacion;
            this.veces = veces;
        }

        public int Clie_ide
        {
            get
            {
                return clie_ide;
            }

            set
            {
                clie_ide = value;
            }
        }

        public int Clie_cont_ide
        {
            get
            {
                return clie_cont_ide;
            }

            set
            {
                clie_cont_ide = value;
            }
        }

        public string Clie_cont_titulo
        {
            get
            {
                return clie_cont_titulo;
            }

            set
            {
                clie_cont_titulo = value;
            }
        }

        public string Clie_cont_paterno
        {
            get
            {
                return clie_cont_paterno;
            }

            set
            {
                clie_cont_paterno = value;
            }
        }

        public string Clie_cont_materno
        {
            get
            {
                return clie_cont_materno;
            }

            set
            {
                clie_cont_materno = value;
            }
        }

        public string Clie_cont_nombre
        {
            get
            {
                return clie_cont_nombre;
            }

            set
            {
                clie_cont_nombre = value;
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

        public string Clie_cont_direccion
        {
            get
            {
                return clie_cont_direccion;
            }

            set
            {
                clie_cont_direccion = value;
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

        public string Clie_cont_telefono_casa
        {
            get
            {
                return clie_cont_telefono_casa;
            }

            set
            {
                clie_cont_telefono_casa = value;
            }
        }

        public string Clie_cont_telefono_celular
        {
            get
            {
                return clie_cont_telefono_celular;
            }

            set
            {
                clie_cont_telefono_celular = value;
            }
        }

        public string Clie_cont_fax
        {
            get
            {
                return clie_cont_fax;
            }

            set
            {
                clie_cont_fax = value;
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

        public string Clie_cont_documento
        {
            get
            {
                return clie_cont_documento;
            }

            set
            {
                clie_cont_documento = value;
            }
        }

        public string Clie_cont_fecha_nacimiento
        {
            get
            {
                return clie_cont_fecha_nacimiento;
            }

            set
            {
                clie_cont_fecha_nacimiento = value;
            }
        }

        public string Clie_cont_sexo
        {
            get
            {
                return clie_cont_sexo;
            }

            set
            {
                clie_cont_sexo = value;
            }
        }

        public string Clie_cont_estado_civil
        {
            get
            {
                return clie_cont_estado_civil;
            }

            set
            {
                clie_cont_estado_civil = value;
            }
        }

        public string Clie_cont_correo
        {
            get
            {
                return clie_cont_correo;
            }

            set
            {
                clie_cont_correo = value;
            }
        }

        public string Clie_cont_nota
        {
            get
            {
                return clie_cont_nota;
            }

            set
            {
                clie_cont_nota = value;
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

    public class  clsCliente_GrupoBE
    {
        int clie_ide;
        int clie_gru_ide;
        int clie_gru_ide_cliente;
        DateTime creacion;
        int veces;

        public clsCliente_GrupoBE()
        {
            
        }

        public clsCliente_GrupoBE(int clie_ide, int clie_gru_ide, int clie_gru_ide_cliente, DateTime creacion, int veces)
        {
            this.clie_ide = clie_ide;
            this.clie_gru_ide = clie_gru_ide;
            this.clie_gru_ide_cliente = clie_gru_ide_cliente;
            this.creacion = creacion;
            this.veces = veces;
        }

        public int Clie_ide
        {
            get
            {
                return clie_ide;
            }

            set
            {
                clie_ide = value;
            }
        }

        public int Clie_gru_ide
        {
            get
            {
                return clie_gru_ide;
            }

            set
            {
                clie_gru_ide = value;
            }
        }

        public int Clie_gru_ide_cliente
        {
            get
            {
                return clie_gru_ide_cliente;
            }

            set
            {
                clie_gru_ide_cliente = value;
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

    public class clsCliente_Lugar_EntregaBE
    {
        int clie_ide;
        int clie_lugar_ide;
        string clie_lugar_direccion;
        int loca_ide;
        DateTime creacion;
        int veces;

        public clsCliente_Lugar_EntregaBE()
        {
        }
        public clsCliente_Lugar_EntregaBE(int clie_ide, int clie_lugar_ide, string clie_lugar_direccion, int loca_ide, DateTime creacion, int veces)
        {
            this.clie_ide = clie_ide;
            this.clie_lugar_ide = clie_lugar_ide;
            this.clie_lugar_direccion = clie_lugar_direccion;
            this.loca_ide = loca_ide;
            this.creacion = creacion;
            this.veces = veces;
        }

        public int Clie_ide
        {
            get
            {
                return clie_ide;
            }

            set
            {
                clie_ide = value;
            }
        }

        public int Clie_lugar_ide
        {
            get
            {
                return clie_lugar_ide;
            }

            set
            {
                clie_lugar_ide = value;
            }
        }

        public string Clie_lugar_direccion
        {
            get
            {
                return clie_lugar_direccion;
            }

            set
            {
                clie_lugar_direccion = value;
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

    public class clsCliente_NotaBE
    {
        int clie_ide;
        int clie_nota_ide;
        string clie_nota_nota;
        DateTime creacion;
        int veces;

        public clsCliente_NotaBE()
        {
  
        }

        public clsCliente_NotaBE(int clie_ide, int clie_nota_ide, string clie_nota_nota, DateTime creacion, int veces)
        {
            this.clie_ide = clie_ide;
            this.clie_nota_ide = clie_nota_ide;
            this.clie_nota_nota = clie_nota_nota;
            this.creacion = creacion;
            this.veces = veces;
        }

        public int Clie_ide
        {
            get
            {
                return clie_ide;
            }

            set
            {
                clie_ide = value;
            }
        }

        public int Clie_nota_ide
        {
            get
            {
                return clie_nota_ide;
            }

            set
            {
                clie_nota_ide = value;
            }
        }

        public string Clie_nota_nota
        {
            get
            {
                return clie_nota_nota;
            }

            set
            {
                clie_nota_nota = value;
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

    public class clsCliente_Punto_PartidaBE
    {
        int prov_ide;
        int prov_part_ide;
        string prov_part_direccion;
        int loca_ide;
        DateTime creacion;
        int veces;
        int lrc_ide;

        public clsCliente_Punto_PartidaBE()
        {
        }

        public clsCliente_Punto_PartidaBE(int prov_ide, int prov_part_ide, string prov_part_direccion, int loca_ide, DateTime creacion, int veces, int lrc_ide)
        {
            this.prov_ide = prov_ide;
            this.prov_part_ide = prov_part_ide;
            this.prov_part_direccion = prov_part_direccion;
            this.loca_ide = loca_ide;
            this.creacion = creacion;
            this.veces = veces;
            this.lrc_ide = lrc_ide;
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

        public int Prov_part_ide
        {
            get
            {
                return prov_part_ide;
            }

            set
            {
                prov_part_ide = value;
            }
        }

        public string Prov_part_direccion
        {
            get
            {
                return prov_part_direccion;
            }

            set
            {
                prov_part_direccion = value;
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
    }

    public class clsCategoria_ClienteBE
    {
        int cate_clie_ide;
        string cate_clie_nombre;
        string cate_clie_estado;
        DateTime cate_clie_fechainac;
        DateTime creacion;
        int veces;

        public clsCategoria_ClienteBE()
        {
 
        }

        public clsCategoria_ClienteBE(int cate_clie_ide, string cate_clie_nombre, string cate_clie_estado, DateTime cate_clie_fechainac, DateTime creacion, int veces)
        {
            this.cate_clie_ide = cate_clie_ide;
            this.cate_clie_nombre = cate_clie_nombre;
            this.cate_clie_estado = cate_clie_estado;
            this.cate_clie_fechainac = cate_clie_fechainac;
            this.creacion = creacion;
            this.veces = veces;
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

        public string Cate_clie_nombre
        {
            get
            {
                return cate_clie_nombre;
            }

            set
            {
                cate_clie_nombre = value;
            }
        }

        public string Cate_clie_estado
        {
            get
            {
                return cate_clie_estado;
            }

            set
            {
                cate_clie_estado = value;
            }
        }

        public DateTime Cate_clie_fechainac
        {
            get
            {
                return cate_clie_fechainac;
            }

            set
            {
                cate_clie_fechainac = value;
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
