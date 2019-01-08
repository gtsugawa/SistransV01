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

namespace CapaPresentacion
{
    public partial class frmRecojo_Peaje : Form
    {
        public Int32  ID_Reco_Ide     = 0;
        public Int32  ID_Reco_Ide_Detalle = 0;
        public Int32  ID_Veces        = 0;
        public string Operacion_Peaje = "";
        public frmRecojo_Peaje()
        {
            InitializeComponent();
        }

        private void frmRecojo_Peaje_Load(object sender, EventArgs e)
        {
            ENResultOperation R = ClsRecojo_CabeceraBC.Obtener_Registro(ID_Reco_Ide);
            DataTable dt = (DataTable)R.Valor;
            DataRow ROW = dt.Rows[0];
            ID_Veces = Convert.ToInt32(ROW["VECES"].ToString());

            if (Operacion_Peaje == "N")
            {
                txtIde_Detalle.Text = "0";
                txtSerie.Text = string.Empty;
                txtNumero.Text = "0";
                txtMonto.Text = "0";
                dtpFecha.Text = DateTime.Now.ToString();
            }
            else
            {
                ENResultOperation P = ClsRecojo_PeajeBC.Obtener_Registro(ID_Reco_Ide, ID_Reco_Ide_Detalle);
                DataTable dtp = (DataTable)P.Valor;
                if (dtp.Rows.Count != 0)
                {
                    DataRow ROWP = dtp.Rows[0];
                    txtIde_Detalle.Text = ROWP["RECO_IDE_DETALLE"].ToString();
                    txtSerie.Text = ROWP["RECO_SERIE_PEAJE"].ToString();
                    txtNumero.Text = ROWP["RECO_NUMERO_PEAJE"].ToString();
                    txtMonto.Text = ROWP["RECO_MONTO"].ToString();
                    dtpFecha.Text = ROWP["RECO_FECHA"].ToString();
                    if (Operacion_Peaje == "E") btnGrabarPeaje.Text = "Elimina";
                }
            }
            txtSerie.Focus();
        }

         private void btnGrabarPeaje_Click(object sender, EventArgs e)
        {
            Procesar_Operacion();
        }

        private void btnCancelarPeaje_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Procesar_Operacion()
        {
            ClsRecojo_PeajeBE TipoBE = new ClsRecojo_PeajeBE();
            TipoBE.Reco_ide = ID_Reco_Ide;
            TipoBE.Reco_ide_detalle = ID_Reco_Ide_Detalle;
            TipoBE.Reco_serie_peaje = txtSerie.Text;
            TipoBE.Reco_numero_peaje = Convert.ToInt32(txtNumero.Text);
            TipoBE.Reco_monto = Convert.ToDouble(txtMonto.Text);
            TipoBE.Reco_fecha = Convert.ToDateTime(dtpFecha.Text);
            TipoBE.Veces = ID_Veces;
            TipoBE.Usuario = "ADMIN";


            switch (Operacion_Peaje)
            {
                case "N": 
                    ENResultOperation R = ClsRecojo_PeajeBC.Crear(TipoBE);
                    break;
                case "M": ClsRecojo_PeajeBC.Actualizar(TipoBE);
                    break;
                case "E": ClsRecojo_PeajeBC.Eliminar(TipoBE);
                    break;
            }
            this.Close();
        }

        private void frmRecojo_Peaje_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }

    }
}
