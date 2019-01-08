using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaBE
{
    class RecojoBE
    {
    }

    public class ClsRecojo_Apoyo_AyudanteBE
    {
        int eco_ide_detalle;
        int reco_ide_detalle_detalle;
        int tran_cont_ide;

        public ClsRecojo_Apoyo_AyudanteBE()
        {
    
        }
        public ClsRecojo_Apoyo_AyudanteBE(int eco_ide_detalle, int reco_ide_detalle_detalle, int tran_cont_ide)
        {
            this.eco_ide_detalle = eco_ide_detalle;
            this.reco_ide_detalle_detalle = reco_ide_detalle_detalle;
            this.tran_cont_ide = tran_cont_ide;
        }

        public int Eco_ide_detalle
        {
            get
            {
                return eco_ide_detalle;
            }

            set
            {
                eco_ide_detalle = value;
            }
        }

        public int Reco_ide_detalle_detalle
        {
            get
            {
                return reco_ide_detalle_detalle;
            }

            set
            {
                reco_ide_detalle_detalle = value;
            }
        }

        public int Tran_cont_ide
        {
            get
            {
                return tran_cont_ide;
            }

            set
            {
                tran_cont_ide = value;
            }
        }
    }

    public class ClsRecojo_Apoyo_CabeceraBE
    {
        int reco_ide;
        int reco_ide_detalle;
        int reco_numero_apoyo;
        DateTime reco_fecha_emision;
        int tran_ide;
        int tran_chof_ide;
        int tran_vehi_ide;
        int reco_tonelaje;
        int reco_volumen;
        int reco_udometro_inicial;
        int reco_udometro_final;
        DateTime reco_fecha_traslado;
        string reco_hora_salida;
        DateTime reco_fecha_retorno;
        string reco_hora_retorno;
        int veces;
        string usuario;

        public ClsRecojo_Apoyo_CabeceraBE()
        {
           
        }

        public ClsRecojo_Apoyo_CabeceraBE(int reco_ide,int reco_ide_detalle, int reco_numero_apoyo, DateTime reco_fecha_emision, int tran_ide, int tran_chof_ide, int tran_vehi_ide, int reco_tonelaje, int reco_volumen, int reco_udometro_inicial, int reco_udometro_final, DateTime reco_fecha_traslado, string reco_hora_salida, DateTime reco_fecha_retorno, string reco_hora_retorno, int veces, string usuario)
        {
            this.reco_ide = reco_ide;
            this.reco_ide_detalle = reco_ide_detalle;
            this.reco_numero_apoyo = reco_numero_apoyo;
            this.reco_fecha_emision = reco_fecha_emision;
            this.tran_ide = tran_ide;
            this.tran_chof_ide = tran_chof_ide;
            this.tran_vehi_ide = tran_vehi_ide;
            this.reco_tonelaje = reco_tonelaje;
            this.reco_volumen = reco_volumen;
            this.reco_udometro_inicial = reco_udometro_inicial;
            this.reco_udometro_final = reco_udometro_final;
            this.reco_fecha_traslado = reco_fecha_traslado;
            this.reco_hora_salida = reco_hora_salida;
            this.reco_fecha_retorno = reco_fecha_retorno;
            this.reco_hora_retorno = reco_hora_retorno;
            this.veces = veces;
            this.usuario = usuario;
        }

        public int Reco_ide
        {
            get
            {
                return reco_ide;
            }

            set
            {
                reco_ide = value;
            }
        }
        public int Reco_ide_detalle
        {
            get
            {
                return reco_ide_detalle;
            }

            set
            {
                reco_ide_detalle = value;
            }
        }
        public int Reco_numero_apoyo
        {
            get
            {
                return reco_numero_apoyo;
            }

            set
            {
                reco_numero_apoyo = value;
            }
        }

        public DateTime Reco_fecha_emision
        {
            get
            {
                return reco_fecha_emision;
            }

            set
            {
                reco_fecha_emision = value;
            }
        }

        public int Tran_ide
        {
            get
            {
                return tran_ide;
            }

            set
            {
                tran_ide = value;
            }
        }

        public int Tran_chof_ide
        {
            get
            {
                return tran_chof_ide;
            }

            set
            {
                tran_chof_ide = value;
            }
        }

        public int Tran_vehi_ide
        {
            get
            {
                return tran_vehi_ide;
            }

            set
            {
                tran_vehi_ide = value;
            }
        }

        public int Reco_tonelaje
        {
            get
            {
                return reco_tonelaje;
            }

            set
            {
                reco_tonelaje = value;
            }
        }

        public int Reco_volumen
        {
            get
            {
                return reco_volumen;
            }

            set
            {
                reco_volumen = value;
            }
        }

        public int Reco_udometro_inicial
        {
            get
            {
                return reco_udometro_inicial;
            }

            set
            {
                reco_udometro_inicial = value;
            }
        }

        public int Reco_udometro_final
        {
            get
            {
                return reco_udometro_final;
            }

            set
            {
                reco_udometro_final = value;
            }
        }

        public DateTime Reco_fecha_traslado
        {
            get
            {
                return reco_fecha_traslado;
            }

            set
            {
                reco_fecha_traslado = value;
            }
        }

        public string Reco_hora_salida
        {
            get
            {
                return reco_hora_salida;
            }

            set
            {
                reco_hora_salida = value;
            }
        }

        public DateTime Reco_fecha_retorno
        {
            get
            {
                return reco_fecha_retorno;
            }

            set
            {
                reco_fecha_retorno = value;
            }
        }

        public string Reco_hora_retorno
        {
            get
            {
                return reco_hora_retorno;
            }

            set
            {
                reco_hora_retorno = value;
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
   
    public class ClsRecojo_Apoyo_DetalleBE
    {
        int reco_ide_detalle;
        int reco_ide_detalle_detalle;
        int reco_ide_detalle_apoyo;

        public ClsRecojo_Apoyo_DetalleBE()
        {
     
        }

        public ClsRecojo_Apoyo_DetalleBE(int reco_ide_detalle, int reco_ide_detalle_detalle, int reco_ide_detalle_apoyo)
        {
            this.reco_ide_detalle = reco_ide_detalle;
            this.reco_ide_detalle_detalle = reco_ide_detalle_detalle;
            this.reco_ide_detalle_apoyo = reco_ide_detalle_apoyo;
        }

        public int Reco_ide_detalle
        {
            get
            {
                return reco_ide_detalle;
            }

            set
            {
                reco_ide_detalle = value;
            }
        }

        public int Reco_ide_detalle_detalle
        {
            get
            {
                return reco_ide_detalle_detalle;
            }

            set
            {
                reco_ide_detalle_detalle = value;
            }
        }

        public int Reco_ide_detalle_apoyo
        {
            get
            {
                return reco_ide_detalle_apoyo;
            }

            set
            {
                reco_ide_detalle_apoyo = value;
            }
        }
    }

    public class ClsRecojo_Apoyo_NotaBE
    {
        int reco_ide_detalle;
        int reco_ide_detalle_detalle;
        string reco_nota;
        DateTime creacion;
        int veces;

        public ClsRecojo_Apoyo_NotaBE()
        {
 
        }
        public ClsRecojo_Apoyo_NotaBE(int reco_ide_detalle, int reco_ide_detalle_detalle, string reco_nota, DateTime creacion, int veces)
        {
            this.reco_ide_detalle = reco_ide_detalle;
            this.reco_ide_detalle_detalle = reco_ide_detalle_detalle;
            this.reco_nota = reco_nota;
            this.creacion = creacion;
            this.veces = veces;
        }

        public int Reco_ide_detalle
        {
            get
            {
                return reco_ide_detalle;
            }

            set
            {
                reco_ide_detalle = value;
            }
        }

        public int Reco_ide_detalle_detalle
        {
            get
            {
                return reco_ide_detalle_detalle;
            }

            set
            {
                reco_ide_detalle_detalle = value;
            }
        }

        public string Reco_nota
        {
            get
            {
                return reco_nota;
            }

            set
            {
                reco_nota = value;
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
    
    public class ClsRecojo_AyudanteBE
    {
        int reco_ide;
        int reco_ide_detalle;
        int tran_cont_ide;
        int veces;
        string usuario;

        public ClsRecojo_AyudanteBE()
        {
   
        }

        public ClsRecojo_AyudanteBE(int reco_ide, int reco_ide_detalle, int tran_cont_ide, int veces, string usuario)
        {
            this.reco_ide = reco_ide;
            this.reco_ide_detalle = reco_ide_detalle;
            this.tran_cont_ide = tran_cont_ide;
            this.veces = veces;
            this.usuario = usuario;
        }

        public int Reco_ide
        {
            get
            {
                return reco_ide;
            }

            set
            {
                reco_ide = value;
            }
        }

        public int Reco_ide_detalle
        {
            get
            {
                return reco_ide_detalle;
            }

            set
            {
                reco_ide_detalle = value;
            }
        }

        public int Tran_cont_ide
        {
            get
            {
                return tran_cont_ide;
            }

            set
            {
                tran_cont_ide = value;
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

    public class clsRecojo_Ayudante_RepartoBE
    {
        int reco_ide_detalle;
        int reco_ide_detalle_reparto;

        public clsRecojo_Ayudante_RepartoBE()
        {
    
        }

        public clsRecojo_Ayudante_RepartoBE(int reco_ide_detalle, int reco_ide_detalle_reparto)
        {
            this.reco_ide_detalle = reco_ide_detalle;
            this.reco_ide_detalle_reparto = reco_ide_detalle_reparto;
        }

        public int Reco_ide_detalle
        {
            get
            {
                return reco_ide_detalle;
            }

            set
            {
                reco_ide_detalle = value;
            }
        }

        public int Reco_ide_detalle_reparto
        {
            get
            {
                return reco_ide_detalle_reparto;
            }

            set
            {
                reco_ide_detalle_reparto = value;
            }
        }
    }

    public class clsRecojo_CabeceraBE
    {
        int reco_ide;
        string serie_numero_recojo;
        int reco_numero_recojo;
        DateTime reco_fecha_emision;
        DateTime reco_fecha_traslado;
        int prov_carga_ide;
        string reco_direccion;
        int loca_ide;
        int prov_carga_cont_ide;
        int tran_ide;
        int tran_chof_ide;
        int tran_vehi_ide;
        int reco_tonelaje;
        int reco_volumen;
        int reco_udometro_inicial;
        int reco_udometro_final;
        string reco_hora_salida;
        DateTime reco_fecha_retorno;
        string reco_hora_retorno;
        byte reco_reparto_destinatario;
        int reco_tipo;
        string reco_estado;
        int reco_numero_item;
        int reco_estado_digitacion;
        int reco_lugar;
        int reco_punto_reparto;
        int veces;
        int lrc_ide;
        int contacto;
        string usuario;
        public clsRecojo_CabeceraBE()
        {

        }
        public clsRecojo_CabeceraBE(int reco_ide, string serie_numero_recojo, int reco_numero_recojo, DateTime reco_fecha_emision, DateTime reco_fecha_traslado, int prov_carga_ide, string reco_direccion, int loca_ide, int prov_carga_cont_ide, int tran_ide, int tran_chof_ide, int tran_vehi_ide, int reco_tonelaje, int reco_volumen, int reco_udometro_inicial, int reco_udometro_final, string reco_hora_salida, DateTime reco_fecha_retorno, string reco_hora_retorno, byte reco_reparto_destinatario, int reco_tipo, string reco_estado, int reco_numero_item, int reco_estado_digitacion, int reco_lugar, int reco_punto_reparto, int veces, int lrc_ide, int contacto, string usuario)
        {
            this.reco_ide = reco_ide;
            this.serie_numero_recojo = serie_numero_recojo;
            this.reco_numero_recojo = reco_numero_recojo;
            this.reco_fecha_emision = reco_fecha_emision;
            this.reco_fecha_traslado = reco_fecha_traslado;
            this.prov_carga_ide = prov_carga_ide;
            this.reco_direccion = reco_direccion;
            this.loca_ide = loca_ide;
            this.prov_carga_cont_ide = prov_carga_cont_ide;
            this.tran_ide = tran_ide;
            this.tran_chof_ide = tran_chof_ide;
            this.tran_vehi_ide = tran_vehi_ide;
            this.reco_tonelaje = reco_tonelaje;
            this.reco_volumen = reco_volumen;
            this.reco_udometro_inicial = reco_udometro_inicial;
            this.reco_udometro_final = reco_udometro_final;
            this.reco_hora_salida = reco_hora_salida;
            this.reco_fecha_retorno = reco_fecha_retorno;
            this.reco_hora_retorno = reco_hora_retorno;
            this.reco_reparto_destinatario = reco_reparto_destinatario;
            this.reco_tipo = reco_tipo;
            this.reco_estado = reco_estado;
            this.reco_numero_item = reco_numero_item;
            this.reco_estado_digitacion = reco_estado_digitacion;
            this.reco_lugar = reco_lugar;
            this.reco_punto_reparto = reco_punto_reparto;
            this.veces = veces;
            this.lrc_ide = lrc_ide;
            this.contacto = contacto;
            this.usuario = usuario;
        }

        public int Reco_ide
        {
            get
            {
                return reco_ide;
            }

            set
            {
                reco_ide = value;
            }
        }

        public string Serie_numero_recojo
        {
            get
            {
                return serie_numero_recojo;
            }

            set
            {
                serie_numero_recojo = value;
            }
        }

        public int Reco_numero_recojo
        {
            get
            {
                return reco_numero_recojo;
            }

            set
            {
                reco_numero_recojo = value;
            }
        }

        public DateTime Reco_fecha_emision
        {
            get
            {
                return reco_fecha_emision;
            }

            set
            {
                reco_fecha_emision = value;
            }
        }

        public DateTime Reco_fecha_traslado
        {
            get
            {
                return reco_fecha_traslado;
            }

            set
            {
                reco_fecha_traslado = value;
            }
        }

        public int Prov_carga_ide
        {
            get
            {
                return prov_carga_ide;
            }

            set
            {
                prov_carga_ide = value;
            }
        }

        public string Reco_direccion
        {
            get
            {
                return reco_direccion;
            }

            set
            {
                reco_direccion = value;
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

        public int Prov_carga_cont_ide
        {
            get
            {
                return prov_carga_cont_ide;
            }

            set
            {
                prov_carga_cont_ide = value;
            }
        }

        public int Tran_ide
        {
            get
            {
                return tran_ide;
            }

            set
            {
                tran_ide = value;
            }
        }

        public int Tran_chof_ide
        {
            get
            {
                return tran_chof_ide;
            }

            set
            {
                tran_chof_ide = value;
            }
        }

        public int Tran_vehi_ide
        {
            get
            {
                return tran_vehi_ide;
            }

            set
            {
                tran_vehi_ide = value;
            }
        }

        public int Reco_tonelaje
        {
            get
            {
                return reco_tonelaje;
            }

            set
            {
                reco_tonelaje = value;
            }
        }

        public int Reco_volumen
        {
            get
            {
                return reco_volumen;
            }

            set
            {
                reco_volumen = value;
            }
        }

        public int Reco_udometro_inicial
        {
            get
            {
                return reco_udometro_inicial;
            }

            set
            {
                reco_udometro_inicial = value;
            }
        }

        public int Reco_udometro_final
        {
            get
            {
                return reco_udometro_final;
            }

            set
            {
                reco_udometro_final = value;
            }
        }

        public string Reco_hora_salida
        {
            get
            {
                return reco_hora_salida;
            }

            set
            {
                reco_hora_salida = value;
            }
        }

        public DateTime Reco_fecha_retorno
        {
            get
            {
                return reco_fecha_retorno;
            }

            set
            {
                reco_fecha_retorno = value;
            }
        }

        public string Reco_hora_retorno
        {
            get
            {
                return reco_hora_retorno;
            }

            set
            {
                reco_hora_retorno = value;
            }
        }

        public byte Reco_reparto_destinatario
        {
            get
            {
                return reco_reparto_destinatario;
            }

            set
            {
                reco_reparto_destinatario = value;
            }
        }

        public int Reco_tipo
        {
            get
            {
                return reco_tipo;
            }

            set
            {
                reco_tipo = value;
            }
        }

        public string Reco_estado
        {
            get
            {
                return reco_estado;
            }

            set
            {
                reco_estado = value;
            }
        }

        public int Reco_numero_item
        {
            get
            {
                return reco_numero_item;
            }

            set
            {
                reco_numero_item = value;
            }
        }

        public int Reco_estado_digitacion
        {
            get
            {
                return reco_estado_digitacion;
            }

            set
            {
                reco_estado_digitacion = value;
            }
        }

        public int Reco_lugar
        {
            get
            {
                return reco_lugar;
            }

            set
            {
                reco_lugar = value;
            }
        }

        public int Reco_punto_reparto
        {
            get
            {
                return reco_punto_reparto;
            }

            set
            {
                reco_punto_reparto = value;
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

        public int Contacto
        {
            get { return contacto; }
            set { contacto = value; }
        }

        public string Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }
    }

    public class ClsRecojo_Combustible_ImporteBE
    {
        int reco_ide;
        int reco_ide_detalle;
        int prov_ide;
        int reco_kilometro_inicial;
        int reco_kilometro_final;
        double reco_importe;
        double reco_rendimiento;
        DateTime creacion;
        int veces;
        string usuario;

        public ClsRecojo_Combustible_ImporteBE()
        {
  
        }

        public ClsRecojo_Combustible_ImporteBE(int reco_ide, int reco_ide_detalle, int prov_ide, int reco_kilometro_inicial, int reco_kilometro_final, double reco_importe, double reco_rendimiento, DateTime creacion, int veces, string usuario)
        {
            this.reco_ide = reco_ide;
            this.reco_ide_detalle = reco_ide_detalle;
            this.prov_ide = prov_ide;
            this.reco_kilometro_inicial = reco_kilometro_inicial;
            this.reco_kilometro_final = reco_kilometro_final;
            this.reco_importe = reco_importe;
            this.reco_rendimiento = reco_rendimiento;
            this.creacion = creacion;
            this.veces = veces;
            this.usuario = usuario;
        }

        public int Reco_ide
        {
            get
            {
                return reco_ide;
            }

            set
            {
                reco_ide = value;
            }
        }

        public int Reco_ide_detalle
        {
            get
            {
                return reco_ide_detalle;
            }

            set
            {
                reco_ide_detalle = value;
            }
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

        public int Reco_kilometro_inicial
        {
            get
            {
                return reco_kilometro_inicial;
            }

            set
            {
                reco_kilometro_inicial = value;
            }
        }

        public int Reco_kilometro_final
        {
            get
            {
                return reco_kilometro_final;
            }

            set
            {
                reco_kilometro_final = value;
            }
        }

        public double Reco_importe
        {
            get
            {
                return reco_importe;
            }

            set
            {
                reco_importe = value;
            }
        }

        public double Reco_rendimiento
        {
            get
            {
                return reco_rendimiento;
            }

            set
            {
                reco_rendimiento = value;
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

    public class clsRecojo_DetalleBE
    {
        int reco_ide;
        int reco_ide_detalle;
        int reco_item;
        string reco_destinatario;
        string reco_direccion;
        int loca_ide;
        string reco_guia_proveedor;
        string reco_planilla;
        string reco_descripcion;
        double reco_cantidad;
        double reco_peso;
        double reco_volumen;
        double reco_km_final;
        int unid_medi_ide;
        int tipo_prod_ide;
        DateTime reco_fecha_llegada;
        string reco_hora_llegada;
        DateTime reco_fecha_inicio_carga;
        string reco_hora_inicio_carga;
        DateTime reco_fecha_fin_carga;
        string reco_hora_fin_carga;
        DateTime reco_fecha_inicio_descarga;
        string reco_hora_inicio_descarga;
        DateTime reco_fecha_fin_descarga;
        string reco_hora_fin_descarga;
        DateTime reco_fecha_retiro;
        string reco_hora_retiro;
        Boolean reco_estado_ruta;
        int reco_cliente_ide;
        int veces;
        string usuario;


        public clsRecojo_DetalleBE()
        {
 
        }

        public clsRecojo_DetalleBE(int reco_ide, int reco_ide_detalle, int reco_item, string reco_destinatario, string reco_direccion, int loca_ide, string reco_guia_proveedor, string reco_planilla, string reco_descripcion, double reco_cantidad, double reco_peso, double reco_volumen, double reco_km_final, int unid_medi_ide, int tipo_prod_ide, DateTime reco_fecha_llegada, string reco_hora_llegada, DateTime reco_fecha_inicio_carga, string reco_hora_inicio_carga, DateTime reco_fecha_fin_carga, string reco_hora_fin_carga, DateTime reco_fecha_inicio_descarga, string reco_hora_inicio_descarga, DateTime reco_fecha_fin_descarga, string reco_hora_fin_descarga, DateTime reco_fecha_retiro, string reco_hora_retiro, bool reco_estado_ruta, int reco_cliente_ide, int veces, string usuario)
        {
            this.reco_ide = reco_ide;
            this.reco_ide_detalle = reco_ide_detalle;
            this.reco_item = reco_item;
            this.reco_destinatario = reco_destinatario;
            this.reco_direccion = reco_direccion;
            this.loca_ide = loca_ide;
            this.reco_guia_proveedor = reco_guia_proveedor;
            this.reco_planilla = reco_planilla;
            this.reco_descripcion = reco_descripcion;
            this.reco_cantidad = reco_cantidad;
            this.reco_peso = reco_peso;
            this.reco_volumen = reco_volumen;
            this.reco_km_final = reco_km_final;
            this.unid_medi_ide = unid_medi_ide;
            this.tipo_prod_ide = tipo_prod_ide;
            this.reco_fecha_llegada = reco_fecha_llegada;
            this.reco_hora_llegada = reco_hora_llegada;
            this.reco_fecha_inicio_carga = reco_fecha_inicio_carga;
            this.reco_hora_inicio_carga = reco_hora_inicio_carga;
            this.reco_fecha_fin_carga = reco_fecha_fin_carga;
            this.reco_hora_fin_carga = reco_hora_fin_carga;
            this.reco_fecha_inicio_descarga = reco_fecha_inicio_descarga;
            this.reco_hora_inicio_descarga = reco_hora_inicio_descarga;
            this.reco_fecha_fin_descarga = reco_fecha_fin_descarga;
            this.reco_hora_fin_descarga = reco_hora_fin_descarga;
            this.reco_fecha_retiro = reco_fecha_retiro;
            this.reco_hora_retiro = reco_hora_retiro;
            this.reco_estado_ruta = reco_estado_ruta;
            this.reco_cliente_ide = reco_cliente_ide;
            this.veces = veces;
            this.usuario = usuario;
        }

        public int Reco_ide
        {
            get
            {
                return reco_ide;
            }

            set
            {
                reco_ide = value;
            }
        }

        public int Reco_ide_detalle
        {
            get
            {
                return reco_ide_detalle;
            }

            set
            {
                reco_ide_detalle = value;
            }
        }

        public int Reco_item
        {
            get
            {
                return reco_item;
            }

            set
            {
                reco_item = value;
            }
        }

        public string Reco_destinatario
        {
            get
            {
                return reco_destinatario;
            }

            set
            {
                reco_destinatario = value;
            }
        }

        public string Reco_direccion
        {
            get
            {
                return reco_direccion;
            }

            set
            {
                reco_direccion = value;
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

        public string Reco_guia_proveedor
        {
            get
            {
                return reco_guia_proveedor;
            }

            set
            {
                reco_guia_proveedor = value;
            }
        }

        public string Reco_planilla
        {
            get
            {
                return reco_planilla;
            }

            set
            {
                reco_planilla = value;
            }
        }

        public string Reco_descripcion
        {
            get
            {
                return reco_descripcion;
            }

            set
            {
                reco_descripcion = value;
            }
        }

        public double Reco_cantidad
        {
            get
            {
                return reco_cantidad;
            }

            set
            {
                reco_cantidad = value;
            }
        }

        public double Reco_peso
        {
            get
            {
                return reco_peso;
            }

            set
            {
                reco_peso = value;
            }
        }

        public double Reco_volumen
        {
            get
            {
                return reco_volumen;
            }

            set
            {
                reco_volumen = value;
            }
        }

        public double Reco_km_final
        {
            get
            {
                return reco_km_final;
            }

            set
            {
                reco_km_final = value;
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

        public DateTime Reco_fecha_llegada
        {
            get
            {
                return reco_fecha_llegada;
            }

            set
            {
                reco_fecha_llegada = value;
            }
        }

        public string Reco_hora_llegada
        {
            get
            {
                return reco_hora_llegada;
            }

            set
            {
                reco_hora_llegada = value;
            }
        }

        public DateTime Reco_fecha_inicio_carga
        {
            get
            {
                return reco_fecha_inicio_carga;
            }

            set
            {
                reco_fecha_inicio_carga = value;
            }
        }

        public string Reco_hora_inicio_carga
        {
            get
            {
                return reco_hora_inicio_carga;
            }

            set
            {
                reco_hora_inicio_carga = value;
            }
        }

        public DateTime Reco_fecha_fin_carga
        {
            get
            {
                return reco_fecha_fin_carga;
            }

            set
            {
                reco_fecha_fin_carga = value;
            }
        }

        public string Reco_hora_fin_carga
        {
            get
            {
                return reco_hora_fin_carga;
            }

            set
            {
                reco_hora_fin_carga = value;
            }
        }

        public DateTime Reco_fecha_inicio_descarga
        {
            get
            {
                return reco_fecha_inicio_descarga;
            }

            set
            {
                reco_fecha_inicio_descarga = value;
            }
        }

        public string Reco_hora_inicio_descarga
        {
            get
            {
                return reco_hora_inicio_descarga;
            }

            set
            {
                reco_hora_inicio_descarga = value;
            }
        }

        public DateTime Reco_fecha_fin_descarga
        {
            get
            {
                return reco_fecha_fin_descarga;
            }

            set
            {
                reco_fecha_fin_descarga = value;
            }
        }

        public string Reco_hora_fin_descarga
        {
            get
            {
                return reco_hora_fin_descarga;
            }

            set
            {
                reco_hora_fin_descarga = value;
            }
        }

        public DateTime Reco_fecha_retiro
        {
            get
            {
                return reco_fecha_retiro;
            }

            set
            {
                reco_fecha_retiro = value;
            }
        }

        public string Reco_hora_retiro
        {
            get
            {
                return reco_hora_retiro;
            }

            set
            {
                reco_hora_retiro = value;
            }
        }

        public bool Reco_estado_ruta
        {
            get
            {
                return reco_estado_ruta;
            }

            set
            {
                reco_estado_ruta = value;
            }
        }

        public int Reco_cliente_ide
        {
            get
            {
                return reco_cliente_ide;
            }

            set
            {
                reco_cliente_ide = value;
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

    public class clsRecojo_Detalle_DestinatarioBE
    {
        int reco_ide_detalle;
        int clie_ide;

        public clsRecojo_Detalle_DestinatarioBE()
        {
        }

        public clsRecojo_Detalle_DestinatarioBE(int reco_ide_detalle, int clie_ide)
        {
            this.reco_ide_detalle = reco_ide_detalle;
            this.clie_ide = clie_ide;
        }

        public int Reco_ide_detalle
        {
            get
            {
                return reco_ide_detalle;
            }

            set
            {
                reco_ide_detalle = value;
            }
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
    }

    public class ClsRecojo_GastoBE
    {
        int reco_ide;
        int reco_ide_detalle;
        int gto_ope_ide;
        int tipo_doc_ide;
        string reco_serie_documento;
        string reco_numero_documento;
        double reco_monto;
        string reco_observacion;
        DateTime reco_fecha;
        DateTime creacion;
        int veces;
        string usuario;

        public ClsRecojo_GastoBE()
        {

        }

        public ClsRecojo_GastoBE(int reco_ide, int reco_ide_detalle, int gto_ope_ide, int tipo_doc_ide, string reco_serie_documento, string reco_numero_documento, double reco_monto, string reco_observacion, DateTime reco_fecha, DateTime creacion, int veces, string usuario)
        {
            this.reco_ide = reco_ide;
            this.reco_ide_detalle = reco_ide_detalle;
            this.gto_ope_ide = gto_ope_ide;
            this.tipo_doc_ide = tipo_doc_ide;
            this.reco_serie_documento = reco_serie_documento;
            this.reco_numero_documento = reco_numero_documento;
            this.reco_monto = reco_monto;
            this.reco_observacion = reco_observacion;
            this.reco_fecha = reco_fecha;
            this.creacion = creacion;
            this.veces = veces;
        }

        public int Reco_ide
        {
            get
            {
                return reco_ide;
            }

            set
            {
                reco_ide = value;
            }
        }

        public int Reco_ide_detalle
        {
            get
            {
                return reco_ide_detalle;
            }

            set
            {
                reco_ide_detalle = value;
            }
        }

        public int Gto_ope_ide
        {
            get
            {
                return gto_ope_ide;
            }

            set
            {
                gto_ope_ide = value;
            }
        }

        public int Tipo_doc_ide
        {
            get
            {
                return tipo_doc_ide;
            }

            set
            {
                tipo_doc_ide = value;
            }
        }

        public string Reco_serie_documento
        {
            get
            {
                return reco_serie_documento;
            }

            set
            {
                reco_serie_documento = value;
            }
        }

        public string Reco_numero_documento
        {
            get
            {
                return reco_numero_documento;
            }

            set
            {
                reco_numero_documento = value;
            }
        }

        public double Reco_monto
        {
            get
            {
                return reco_monto;
            }

            set
            {
                reco_monto = value;
            }
        }

        public string Reco_observacion
        {
            get
            {
                return reco_observacion;
            }

            set
            {
                reco_observacion = value;
            }
        }

        public DateTime Reco_fecha
        {
            get
            {
                return reco_fecha;
            }

            set
            {
                reco_fecha = value;
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

    public class ClsRecojo_NotaBE
    {
        int reco_ide;
        int reco_ide_detalle;
        string reco_nota;
        DateTime creacion;
        int veces;
        string usuario;

        public ClsRecojo_NotaBE()
        {
            
        }

        public ClsRecojo_NotaBE(int reco_ide, int reco_ide_detalle, string reco_nota, DateTime creacion, int veces,string usuario)
        {
            this.reco_ide = reco_ide;
            this.reco_ide_detalle = reco_ide_detalle;
            this.reco_nota = reco_nota;
            this.creacion = creacion;
            this.veces = veces;
            this.usuario = usuario;
        }

        public int Reco_ide
        {
            get
            {
                return reco_ide;
            }

            set
            {
                reco_ide = value;
            }
        }

        public int Reco_ide_detalle
        {
            get
            {
                return reco_ide_detalle;
            }

            set
            {
                reco_ide_detalle = value;
            }
        }

        public string Reco_nota
        {
            get
            {
                return reco_nota;
            }

            set
            {
                reco_nota = value;
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

    public class ClsRecojo_PeajeBE
    {
        int reco_ide;
        int reco_ide_detalle;
        string reco_serie_peaje;
        int reco_numero_peaje;
        double reco_monto;
        DateTime reco_fecha;
        int veces;
        DateTime creacion;
        string usuario;

        public ClsRecojo_PeajeBE()
        {
 
        }

        public ClsRecojo_PeajeBE(int reco_ide, int reco_ide_detalle, string reco_serie_peaje, int reco_numero_peaje, double reco_monto, DateTime reco_fecha, int veces, DateTime creacion, string usuario)
        {
            this.reco_ide = reco_ide;
            this.reco_ide_detalle = reco_ide_detalle;
            this.reco_serie_peaje = reco_serie_peaje;
            this.reco_numero_peaje = reco_numero_peaje;
            this.reco_monto = reco_monto;
            this.reco_fecha = reco_fecha;
            this.veces = veces;
            this.creacion = creacion;
            this.usuario = usuario;
        }

        public int Reco_ide
        {
            get
            {
                return reco_ide;
            }

            set
            {
                reco_ide = value;
            }
        }

        public int Reco_ide_detalle
        {
            get
            {
                return reco_ide_detalle;
            }

            set
            {
                reco_ide_detalle = value;
            }
        }

        public string Reco_serie_peaje
        {
            get
            {
                return reco_serie_peaje;
            }

            set
            {
                reco_serie_peaje = value;
            }
        }

        public int Reco_numero_peaje
        {
            get
            {
                return reco_numero_peaje;
            }

            set
            {
                reco_numero_peaje = value;
            }
        }

        public double Reco_monto
        {
            get
            {
                return reco_monto;
            }

            set
            {
                reco_monto = value;
            }
        }

        public DateTime Reco_fecha
        {
            get
            {
                return reco_fecha;
            }

            set
            {
                reco_fecha = value;
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

    public class ClsRecojo_Recargo_CargaBE
    {
        int reco_ide;
        int reco_ide_detalle;
        int merca_ide;
        double reco_porcentaje;
        int veces;
        string usuario;

        public ClsRecojo_Recargo_CargaBE()
        {
 
        }

        public ClsRecojo_Recargo_CargaBE(int reco_ide, int reco_ide_detalle, int merca_ide, double reco_porcentaje, int veces, string usuario)
        {
            this.reco_ide = reco_ide;
            this.reco_ide_detalle = reco_ide_detalle;
            this.merca_ide = merca_ide;
            this.reco_porcentaje = reco_porcentaje;
            this.veces = veces;
            this.usuario = usuario;
        }

        public int Reco_ide
        {
            get
            {
                return reco_ide;
            }

            set
            {
                reco_ide = value;
            }
        }

        public int Reco_ide_detalle
        {
            get
            {
                return reco_ide_detalle;
            }

            set
            {
                reco_ide_detalle = value;
            }
        }

        public int Merca_ide
        {
            get
            {
                return merca_ide;
            }

            set
            {
                merca_ide = value;
            }
        }

        public double Reco_porcentaje
        {
            get
            {
                return reco_porcentaje;
            }

            set
            {
                reco_porcentaje = value;
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

    public class clsRecojo_Reparto
    {
        int reco_ide;
        int reco_ide_detalle;
        string reco_destinatario;
        int clie_ide;
        string reco_direccion;
        int loca_ide;

        public clsRecojo_Reparto()
        {
        }

        public clsRecojo_Reparto(int reco_ide, int reco_ide_detalle, string reco_destinatario, int clie_ide, string reco_direccion, int loca_ide)
        {
            this.reco_ide = reco_ide;
            this.reco_ide_detalle = reco_ide_detalle;
            this.reco_destinatario = reco_destinatario;
            this.clie_ide = clie_ide;
            this.reco_direccion = reco_direccion;
            this.loca_ide = loca_ide;
        }

        public int Reco_ide
        {
            get
            {
                return reco_ide;
            }

            set
            {
                reco_ide = value;
            }
        }

        public int Reco_ide_detalle
        {
            get
            {
                return reco_ide_detalle;
            }

            set
            {
                reco_ide_detalle = value;
            }
        }

        public string Reco_destinatario
        {
            get
            {
                return reco_destinatario;
            }

            set
            {
                reco_destinatario = value;
            }
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

        public string Reco_direccion
        {
            get
            {
                return reco_direccion;
            }

            set
            {
                reco_direccion = value;
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
    }
}
