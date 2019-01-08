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
    public partial class frmRecojo_Recargo : Form
    {

        public Int32 ID_Reco_Ide = 0;
        public Int32 ID_Reco_Ide_Detalle = 0;
        public Int32 ID_Veces = 0;
        public string Operacion_Recargo = "";
        public frmRecojo_Recargo()
        {
            InitializeComponent();
        }

        private void frmRecojo_Recargo_Load(object sender, EventArgs e)
        {
            ENResultOperation A = ClsArticuloBC.Listar("");
            if (A.Proceder) cboRecargo.DataSource = (DataTable)A.Valor;
            cboRecargo.DisplayMember = "ARTI_NOMBRE";
            cboRecargo.ValueMember = "ARTI_IDE";
            cboRecargo.AutoCompleteMode = AutoCompleteMode.Suggest;
            cboRecargo.AutoCompleteSource = AutoCompleteSource.ListItems;

            ENResultOperation R = ClsRecojo_CabeceraBC.Obtener_Registro(ID_Reco_Ide);
            DataTable dt = (DataTable)R.Valor;
            DataRow ROW = dt.Rows[0];
            ID_Veces = Convert.ToInt32(ROW["VECES"].ToString());


            if (Operacion_Recargo == "N")
            {
                cboRecargo.SelectedIndex = 0;
                txtPorcentaje.Text = "0";
            }
            else
            {
                ENResultOperation N = ClsRecojo_Recargo_CargaBC.Obtener_Registro(ID_Reco_Ide, ID_Reco_Ide_Detalle);
                DataTable dtn = (DataTable)N.Valor;
                if (dtn.Rows.Count != 0)
                {
                    DataRow ROWN = dtn.Rows[0];
                    cboRecargo.SelectedValue = Convert.ToInt32(ROWN["MERCA_IDE"].ToString());
                    txtPorcentaje.Text = ROWN["RECO_PORCENTAJE"].ToString();
                    if (Operacion_Recargo == "E") btnGrabar.Text = "Elimina";
                }
            }
        }

        private void Procesar_Operacion()
        {
            ClsRecojo_Recargo_CargaBE TipoBE = new ClsRecojo_Recargo_CargaBE();
            TipoBE.Reco_ide = ID_Reco_Ide;
            TipoBE.Reco_ide_detalle = ID_Reco_Ide_Detalle;
            TipoBE.Merca_ide = Convert.ToInt32(cboRecargo.SelectedValue.ToString());
            TipoBE.Reco_porcentaje = Convert.ToDouble(txtPorcentaje.Text);
            TipoBE.Veces = ID_Veces;
            TipoBE.Usuario = "ADMIN";


            switch (Operacion_Recargo)
            {
                case "N":
                    ENResultOperation R = ClsRecojo_Recargo_CargaBC.Crear(TipoBE);
                    break;
                case "M": ClsRecojo_Recargo_CargaBC.Actualizar(TipoBE);
                    break;
                case "E": ClsRecojo_Recargo_CargaBC.Eliminar(TipoBE);
                    break;
            }
            btnGrabar.Text = "Grabar";
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
    }
}
