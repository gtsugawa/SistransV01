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
    public partial class frmRecojo_Gasto : Form
    {
        public Int32 ID_Reco_Ide = 0;
        public Int32 ID_Reco_Ide_Detalle = 0;
        public Int32 ID_Veces = 0;
        public string Operacion_Gasto = "";
        private Int32 nGasto_Ide = 0;
        private string cGasto_nombre = "";
        public frmRecojo_Gasto()
        {
            InitializeComponent();
        }

        private void frmRecojo_Gasto_Load(object sender, EventArgs e)
        {
            ENResultOperation R = ClsRecojo_CabeceraBC.Obtener_Registro(ID_Reco_Ide);
            DataTable dt = (DataTable)R.Valor;
            DataRow ROW = dt.Rows[0];
            ID_Veces = Convert.ToInt32(ROW["VECES"].ToString());

            Llenar_CboTipoGasto();
            Llenar_CboTipoDocumento();

            if (Operacion_Gasto == "N")
            {
                txtIde_Detalle.Text     = "0";
                cboTipoGasto.SelectedIndex = 0;
                cboTipoDocumento.SelectedIndex = 0;
                txtSerie.Text = string.Empty;
                txtNumero.Text = "0";
                txtMonto.Text = "0";
                dtpFecha.Text = DateTime.Now.ToString();
            }
            else
            {
                ENResultOperation G = ClsRecojo_GastoBC.Obtener_Registro(ID_Reco_Ide, ID_Reco_Ide_Detalle);
                DataTable dtg = (DataTable)G.Valor;
                if (dtg.Rows.Count != 0)
                {
                    DataRow ROWG = dtg.Rows[0];
                    txtIde_Detalle.Text = ROWG["RECO_IDE_DETALLE"].ToString();
                    cboTipoGasto.Text = ROWG["GTO_OPE_NOMBRE"].ToString();
                    cboTipoDocumento.Text = ROWG["TIPO_DOC_NOMBRE"].ToString();
                    txtSerie.Text = ROWG["RECO_SERIE_DOCUMENTO"].ToString();
                    txtNumero.Text = ROWG["RECO_NUMERO_DOCUMENTO"].ToString();
                    txtMonto.Text = ROWG["RECO_MONTO"].ToString();
                    txtObservacion.Text = ROWG["RECO_OBSERVACION"].ToString();
                    dtpFecha.Text = ROWG["RECO_FECHA"].ToString();

                    if (Operacion_Gasto == "E") btnGrabar.Text = "Elimina";
                }
             }
        }

        private void Llenar_CboTipoGasto()
        {
            DataTable DTG = new DataTable();
            ENResultOperation G = ClsGasto_OperacionBC.Listar("");
            if (G.Proceder)
            {
                DTG = (DataTable)G.Valor;
                this.cboTipoGasto.DataSource = DTG;
                this.cboTipoGasto.DisplayMember = Convert.ToString(DTG.Columns["Gto_Ope_Nombre"]);
                this.cboTipoGasto.ValueMember = Convert.ToString(DTG.Columns["Gto_Ope_Ide"]);
                this.cboTipoGasto.AutoCompleteMode = AutoCompleteMode.Suggest;
                this.cboTipoGasto.AutoCompleteSource = AutoCompleteSource.ListItems;
                this.cboTipoGasto.DropDownHeight = 250;
                this.cboTipoGasto.DropDownStyle = ComboBoxStyle.DropDownList;
            }
        }

        private void Llenar_CboTipoDocumento()
        {
            DataTable DTD = new DataTable();
            ENResultOperation D = ClsTipo_DocumentoBC.Listar("");
            if (D.Proceder)
            {
                DTD = (DataTable)D.Valor;
                this.cboTipoDocumento.DataSource = DTD;
                this.cboTipoDocumento.DisplayMember = Convert.ToString(DTD.Columns["Tipo_Doc_Nombre"]);
                this.cboTipoDocumento.ValueMember = Convert.ToString(DTD.Columns["Tipo_Doc_Ide"]);
                this.cboTipoDocumento.AutoCompleteMode = AutoCompleteMode.Suggest;
                this.cboTipoDocumento.AutoCompleteSource = AutoCompleteSource.ListItems;
                this.cboTipoDocumento.DropDownHeight = 250;
                this.cboTipoDocumento.DropDownStyle = ComboBoxStyle.DropDownList;

            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            Procesar_Operacion();
        }

        private void Procesar_Operacion()
        {
            ClsRecojo_GastoBE TipoBE = new ClsRecojo_GastoBE();
            TipoBE.Reco_ide = ID_Reco_Ide;
            TipoBE.Reco_ide_detalle = ID_Reco_Ide_Detalle;
            TipoBE.Gto_ope_ide = Convert.ToInt32(cboTipoGasto.SelectedValue.ToString());
            TipoBE.Tipo_doc_ide = Convert.ToInt32(cboTipoDocumento.SelectedValue.ToString());
            TipoBE.Reco_serie_documento = txtSerie.Text;
            TipoBE.Reco_numero_documento = txtNumero.Text;
            TipoBE.Reco_monto = Convert.ToDouble(txtMonto.Text);
            TipoBE.Reco_fecha = Convert.ToDateTime(dtpFecha.Text);
            TipoBE.Reco_observacion = txtObservacion.Text;
            TipoBE.Veces = ID_Veces;
            TipoBE.Usuario = "ADMIN";


            switch (Operacion_Gasto)
            {
                case "N":
                    ENResultOperation R = ClsRecojo_GastoBC.Crear(TipoBE);
                    break;
                case "M": ClsRecojo_GastoBC.Actualizar(TipoBE);
                    break;
                case "E": ClsRecojo_GastoBC.Eliminar(TipoBE);
                    break;
            }
            this.Close();
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboTipoGasto_Validated(object sender, EventArgs e)
        {
            nGasto_Ide    = Convert.ToInt32(cboTipoGasto.SelectedValue.ToString());
            cGasto_nombre = cboTipoGasto.SelectedValue.ToString();
        }

        private void frmRecojo_Gasto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }

  
  
    }
}
