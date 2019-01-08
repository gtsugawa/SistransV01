using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaBC;
using CapaBE;

namespace CapaPresentacion.Recojo
{
    public partial class frmRecojo_Apoyo : Form
    {
        public string Operacion_Apoyo;
        public  Int32 nReco_Ide;
        public  Int32 nReco_Ide_Detalle;
        private Int32 nTran_Ide;
        private Int32 nChof_Ide;
        private Int32 nVehi_Ide;
        private Int32 nVeces;
        public frmRecojo_Apoyo()
        {
            InitializeComponent();
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmRecojo_Apoyo_Load(object sender, EventArgs e)
        {
            ENResultOperation C = ClsRecojo_CabeceraBC.Obtener_Registro(nReco_Ide);
            DataTable dtc = (DataTable)C.Valor;
            if (dtc.Rows.Count != 0)
            {
                DataRow ROW = dtc.Rows[0];
                nVeces = Convert.ToInt32(ROW["VECES"].ToString());

                ENResultOperation R = ClsRecojo_Apoyo_CabeceraBC.Listar_Filtro(nReco_Ide, nReco_Ide_Detalle);
                DataTable dt = (DataTable)R.Valor;
                if (dt.Rows.Count != 0)
                {
                    DataRow ROWN = dt.Rows[0];
                    txtApoyo.Text = ROWN["RECO_NUMERO_APOYO"].ToString();
                    dtpFEmision.Text = ROWN["RECO_FECHA_EMISION"].ToString();
                    dtpFTraslado.Text = ROWN["RECO_FECHA_TRASLADO"].ToString();
                    txtHSalida.Text = ROWN["RECO_HORA_SALIDA"].ToString();
                    dtpFRetorno.Text = ROWN["RECO_FECHA_RETORNO"].ToString();
                    txtHRetorno.Text = ROWN["RECO_HORA_RETORNO"].ToString();
                    txtKmInicial.Text = ROWN["RECO_UDOMETRO_INICIAL"].ToString();
                    txtKmFinal.Text = ROWN["RECO_UDOMETRO_FINAL"].ToString();
                    txtTransportista.Text = ROWN["TRAN_NOMBRE"].ToString();
                    txtConductor.Text = ROWN["CHOF_NOMBRE"].ToString();
                    txtVehiculo.Text = ROWN["VEHI_PLACA"].ToString();
                    txtTipoVehi.Text = ROWN["TIPO_NOMBRE"].ToString();
                    txtTnM3.Text = ROWN["VEHI_TNM3"].ToString();
                    txtPeso.Text = ROWN["RECO_TONELAJE"].ToString();
                    txtVolumen.Text = ROWN["RECO_VOLUMEN"].ToString();
                    nTran_Ide = Convert.ToInt32(ROWN["TRAN_IDE"].ToString());
                    nChof_Ide = Convert.ToInt32(ROWN["TRAN_CHOF_IDE"].ToString());
                    nVehi_Ide = Convert.ToInt32(ROWN["TRAN_VEHI_IDE"].ToString());
                }
            }
        }

        private void Buscar_Transportista()
        {
            Transportista.frmTransportista_Buscar frmTransportista_Buscar = new Transportista.frmTransportista_Buscar();
            frmTransportista_Buscar.TransportistaRazon = txtTransportista.Text;
            frmTransportista_Buscar.ShowDialog();
            txtTransportista.Text = frmTransportista_Buscar.TransportistaRazon;
            nTran_Ide = Convert.ToInt32(frmTransportista_Buscar.TransportistaID);
        }

        private void Buscar_Conductor()
        {
            Transportista.frmTransportista_Chofer_Buscar frmChoferes_Buscar = new Transportista.frmTransportista_Chofer_Buscar();
            frmChoferes_Buscar.Transportista_Ide = nTran_Ide;
            frmChoferes_Buscar.Transportista_Nombre = txtTransportista.Text;
            frmChoferes_Buscar.ShowDialog();
            txtConductor.Text = frmChoferes_Buscar.Chofer_Nombre;
            nChof_Ide = Convert.ToInt32(frmChoferes_Buscar.Chofer_Ide);
            Buscar_Vehiculo();
        }

        private void Buscar_Vehiculo()
        {
            Transportista.frmTransportista_Vehiculo_Buscar frmVehiculo_Buscar = new Transportista.frmTransportista_Vehiculo_Buscar();
            frmVehiculo_Buscar.Transportista_Ide = nTran_Ide;
            frmVehiculo_Buscar.Transportista_Nombre = txtTransportista.Text;
            frmVehiculo_Buscar.ShowDialog();
            txtVehiculo.Text = frmVehiculo_Buscar.Vehiculo_Placa;
            nVehi_Ide = Convert.ToInt32(frmVehiculo_Buscar.Vehiculo_Ide);
        }

        private void txtTransportista_DoubleClick(object sender, EventArgs e)
        {
            Buscar_Transportista();
        }

        private void txtConductor_DoubleClick(object sender, EventArgs e)
        {
            Buscar_Conductor();
        }

        private void txtVehiculo_DoubleClick(object sender, EventArgs e)
        {
            Buscar_Vehiculo();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            Procesar_Operacion();
        }
        private void Procesar_Operacion()
        {
            ClsRecojo_Apoyo_CabeceraBE TipoBE = new ClsRecojo_Apoyo_CabeceraBE();
            TipoBE.Reco_ide = nReco_Ide;
            TipoBE.Reco_ide_detalle = nReco_Ide_Detalle;
            TipoBE.Reco_numero_apoyo = Convert.ToInt32(txtApoyo.Text);
            TipoBE.Reco_fecha_emision = Convert.ToDateTime(dtpFEmision.Text);
            TipoBE.Tran_ide = nTran_Ide;
            TipoBE.Tran_chof_ide = nChof_Ide;
            TipoBE.Tran_vehi_ide = nVehi_Ide;
            TipoBE.Reco_tonelaje = Convert.ToInt32(txtPeso.Text);
            TipoBE.Reco_volumen = Convert.ToInt32(txtVolumen.Text);
            TipoBE.Reco_udometro_inicial = Convert.ToInt32(txtKmInicial.Text);
            TipoBE.Reco_udometro_final = Convert.ToInt32(txtKmFinal.Text);
            TipoBE.Reco_fecha_traslado = Convert.ToDateTime(dtpFTraslado.Text);
            TipoBE.Reco_hora_salida = txtHSalida.Text;
            TipoBE.Reco_fecha_retorno = Convert.ToDateTime(dtpFRetorno.Text);
            TipoBE.Reco_hora_retorno = txtHRetorno.Text;
            TipoBE.Veces = nVeces;
            TipoBE.Usuario = "ADMIN";

            ENResultOperation R = new ENResultOperation();

            switch (Operacion_Apoyo)
            {
                case "N":
                    R = ClsRecojo_Apoyo_CabeceraBC.Crear(TipoBE);
                    if (!R.Proceder)
                    {
                        MessageBox.Show("Error : " + R.Sms);
                    }
                    break;
                case "M":
                    R = ClsRecojo_Apoyo_CabeceraBC.Actualizar(TipoBE);
                    if (!R.Proceder)
                    {
                        MessageBox.Show("Error : " + R.Sms);
                    }
                    break;
                case "E":
                    R = ClsRecojo_Apoyo_CabeceraBC.Eliminar(TipoBE);
                    if (!R.Proceder)
                    {
                        MessageBox.Show("Error : " + R.Sms);
                    }
                    break;
            }
            this.Close();
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
