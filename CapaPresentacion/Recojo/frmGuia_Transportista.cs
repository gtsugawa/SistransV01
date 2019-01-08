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
    public partial class frmGuia_Transportista : Form
    {
        public Int32 ID_Reco_Ide = 0;
        public Int32 ID_Veces = 0;
        public String Operacion; 
        public frmGuia_Transportista()
        {
            InitializeComponent();
        }

        private void frmGuia_Transportista_Load(object sender, EventArgs e)
        {
            ENResultOperation R = ClsGuia_CabeceraBC.Obtener_Registro(ID_Reco_Ide);
            DataTable dt = (DataTable)R.Valor;
            Operacion = "N";
            if (dt.Rows.Count != 0)
            {
                DataRow ROW = dt.Rows[0];
                txtSerieGuia.Text = ROW["SERIE_NUMERO_GUIA"].ToString();
                txtNumeroGuia.Text = ROW["GUIA_NUMERO_GUIA"].ToString();
                dtpFEmision.Text = ROW["GUIA_FECHA_EMISION"].ToString();
                dtpFTraslado.Text = ROW["GUIA_FECHA_TRASLADO"].ToString();
                ID_Veces = Convert.ToInt32(ROW["VECES"].ToString());
                Operacion = "M";
            }
            txtSerieGuia.Focus();
        }

        private void btnGrabarDetalle_Click(object sender, EventArgs e)
        {
            Procesar_Operacion();
        }

        private void btnCancelarDetalle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Procesar_Operacion()
        {
            ClsGuia_CabeceraBE TipoBE = new ClsGuia_CabeceraBE();
            TipoBE.Reco_ide = ID_Reco_Ide;
            TipoBE.Serie_numero_guia = txtSerieGuia.Text;
            TipoBE.Guia_numero_guia = Convert.ToInt32(txtNumeroGuia.Text);
            TipoBE.Guia_fecha_emision = Convert.ToDateTime(dtpFEmision.Text);
            TipoBE.Guia_fecha_traslado = Convert.ToDateTime(dtpFTraslado.Text);
            TipoBE.Veces = ID_Veces;
            TipoBE.Usuario = "ADMIN";


            switch (Operacion)
            {
                case "N":
                    ENResultOperation R = ClsGuia_CabeceraBC.Crear(TipoBE);
                    break;
                case "M": ClsGuia_CabeceraBC.Actualizar(TipoBE);
                    break;
                case "E": ClsGuia_CabeceraBC.Eliminar(TipoBE);
                    break;
            }
            this.Close();
        }

        private void txtSerieGuia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                txtNumeroGuia.Focus();
            }
        }

        private void txtNumeroGuia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                dtpFEmision.Focus();
            }
        }

        private void dtpFTraslado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                btnGrabarDetalle.Focus();
            }
        }

        private void dtpFEmision_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                dtpFTraslado.Focus();
            }
        }

        private void frmGuia_Transportista_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }

    }
}
