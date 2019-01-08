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
    public partial class frmRecojo_Ayudante : Form
    {
        public Int32  ID_Reco_Ide = 0;
        public Int32  ID_Reco_Ide_Detalle = 0;
        public Int32  ID_Veces = 0;
        public Int32  ID_Tran_Ide = 0;
        public string Operacion_Ayudante = "";
        public frmRecojo_Ayudante()
        {
            InitializeComponent();
        }

        private void frmRecojo_Ayudante_Load(object sender, EventArgs e)
        {
            ENResultOperation R = ClsRecojo_CabeceraBC.Obtener_Registro(ID_Reco_Ide);
            DataTable dt = (DataTable)R.Valor;
            DataRow ROW = dt.Rows[0];
            ID_Veces    = Convert.ToInt32(ROW["VECES"].ToString());
            ID_Tran_Ide = Convert.ToInt32(ROW["TRAN_IDE"].ToString());

            Llenar_CboAyudante();

            if (Operacion_Ayudante == "N")
            {
                txtIde_Detalle.Text   = "0";
                txtTran_Cont_Ide.Text = "0";
                cboAyudante.SelectedIndex = 0;
              
            }
            else
            {
                ENResultOperation P = ClsRecojo_AyudanteBC.Listar_Filtro(ID_Reco_Ide, ID_Reco_Ide_Detalle);
                DataTable dtp = (DataTable)P.Valor;
                if (dtp.Rows.Count != 0)
                {
                    DataRow ROWP = dtp.Rows[0];
                    txtIde_Detalle.Text = ROWP["TRAN_IDE"].ToString();
                    txtTran_Cont_Ide.Text = ROWP["TRAN_CONT_IDE"].ToString();
                    cboAyudante.Text = ROWP["NOMBRE_COMPLETO"].ToString();
                    if (Operacion_Ayudante == "E") btnGrabar.Text = "Elimina";
                }
            }

            //txtTran_Cont_Ide.Text = 
        }

        private void Llenar_CboAyudante()
        {
            DataTable TEMP = new DataTable();
            ENResultOperation R = ClsTransportista_ContactoBC.Listar(ID_Tran_Ide);
            if (R.Proceder)
            { 
                TEMP = (DataTable)R.Valor;
                this.cboAyudante.DataSource = TEMP;
                this.cboAyudante.DisplayMember = "Nombre_Completo";
                this.cboAyudante.ValueMember   = "Tran_Cont_Ide";
                this.cboAyudante.AutoCompleteMode = AutoCompleteMode.Suggest;
                this.cboAyudante.AutoCompleteSource = AutoCompleteSource.ListItems;
                this.cboAyudante.DropDownHeight = 250;
                this.cboAyudante.DropDownStyle = ComboBoxStyle.DropDownList;
                //this.cboAyudante.SelectedIndex = Convert.ToInt32(txtTran_Cont_Ide.Text);
            }
        }

        private void Procesar_Operacion()
        {
            ClsRecojo_AyudanteBE TipoBE = new ClsRecojo_AyudanteBE();
            TipoBE.Reco_ide = ID_Reco_Ide;
            TipoBE.Reco_ide_detalle = ID_Reco_Ide_Detalle;
            TipoBE.Tran_cont_ide = Convert.ToInt32(txtTran_Cont_Ide.Text);
            TipoBE.Veces = ID_Veces;
            TipoBE.Usuario = "ADMIN";


            switch (Operacion_Ayudante)
            {
                case "N":
                    ENResultOperation R = ClsRecojo_AyudanteBC.Crear(TipoBE);
                    break;
                case "M":
                    ClsRecojo_AyudanteBC.Actualizar(TipoBE);
                    break;
                case "E":
                    ClsRecojo_AyudanteBC.Eliminar(TipoBE);
                    break;
            }
            this.Close();
        }
        private void btnGrabar_Click(object sender, EventArgs e)
        {
            Procesar_Operacion();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboAyudante_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cboAyudante.SelectedValue != null)
            {
                txtTran_Cont_Ide.Text = cboAyudante.SelectedValue.ToString();
            }
        }

        private void frmRecojo_Ayudante_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }
    }
}
