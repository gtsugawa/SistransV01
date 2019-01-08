using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using CapaBE;
using CapaBC;
using System.Configuration;

namespace CapaPresentacion.Transportista
{
    public partial class frmTransportista_Buscar : Form
    {

        public string TransportistaID { get; set; }
        public string TransportistaRazon { get; set; }

        private SqlConnection Con = null;
        private SqlCommand Cmd;
        private SqlDataReader dr = null;
        string strcon = ConfigurationManager.ConnectionStrings["conex1"].ConnectionString;
        public frmTransportista_Buscar()
        {
            InitializeComponent();
            dgvListado.AutoGenerateColumns = false;
        }

        void FormatoDgv()
        {
            //------------------------------------------------------------------//      
            var dgv = dgvListado;

            dgv.MultiSelect = false;
            dgv.ReadOnly = true;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            /*---------Centrar titulo de cabecera --------------*/
            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            /*-- No se hace visible la primera columna del datagrid */
            dgv.RowHeadersVisible = false;
            /*---No premite cambiar el tamaño a la columna*/
            dgv.AllowUserToResizeColumns = true;
            dgv.AllowUserToResizeRows = false;
            /*---------------Tipo de fuente y tamaño-----*/
            dgv.DefaultCellStyle.Font = new Font("Tahoma", 8);
            /*----------Alterna colores en el grid -------*/
            dgv.RowsDefaultCellStyle.BackColor = Color.LightBlue;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
            /*---Pintado de color a la cabecera del datagrid ---*/
            DataGridViewCellStyle style = this.dgvListado.ColumnHeadersDefaultCellStyle;
            style.BackColor = Color.Honeydew;
            style.ForeColor = Color.Gray;


            dgv.Columns.Clear();
            dgv.ColumnCount = 19;
            // Setear Cabecera de Columna 
            
            dgv.Columns[0].Name = "TRAN_IDE";
            dgv.Columns[1].Name = "TRAN_CODIGO";
            dgv.Columns[2].Name = "TRAN_RAZON_SOCIAL";
            dgv.Columns[3].Name = "TRAN_EMPRESA";

	        dgv.Columns[4].Name = "TRAN_RUC";
	        dgv.Columns[5].Name = "TRAN_FECHA_CONSTITUCION";
	        dgv.Columns[6].Name = "TRAN_DIRECCION";
	        dgv.Columns[7].Name = "LOCA_IDE";
	        dgv.Columns[8].Name = "TRAN_TELEFONO1";
	        dgv.Columns[9].Name = "TRAN_TELEFONO2";
	        dgv.Columns[10].Name = "TRAN_FAX";
	        dgv.Columns[11].Name = "TRAN_CORREO";
	        dgv.Columns[12].Name = "TRAN_PATERNO";
	        dgv.Columns[13].Name = "TRAN_MATERNO";
	        dgv.Columns[14].Name = "TRAN_NOMBRE";
	        dgv.Columns[15].Name = "TRAN_ESTADO";
	        dgv.Columns[16].Name = "TRAN_FECHAINAC";
	        dgv.Columns[17].Name = "CREACION";
            dgv.Columns[18].Name = "VECES";

            dgv.Columns[0].Width = 45;
            dgv.Columns[0].HeaderText = "ID";
            dgv.Columns[0].DataPropertyName = "TRAN_IDE";
            dgv.Columns[0].Visible = false;

            dgv.Columns[1].Width = 120;
            dgv.Columns[1].HeaderText = "Codigo";
            dgv.Columns[1].DataPropertyName = "TRAN_CODIGO";
            
            dgv.Columns[2].Width = 300;
            dgv.Columns[2].HeaderText = "Razon Social ";
            dgv.Columns[2].DataPropertyName = "TRAN_RAZON_SOCIAL";

            dgv.Columns[3].DataPropertyName = "TRAN_EMPRESA";
            dgv.Columns[3].Visible = false;

            dgv.Columns[4].DataPropertyName = "TRAN_RUC";
            dgv.Columns[4].Visible = false;

            dgv.Columns[5].DataPropertyName = "TRAN_FECHA_CONSTITUCION";
            dgv.Columns[5].Visible = false;

            dgv.Columns[6].Width = 300;
            dgv.Columns[6].HeaderText = "Direccion";
            dgv.Columns[6].DataPropertyName = "TRAN_DIRECCION";
      
            dgv.Columns[7].DataPropertyName = "LOCA_IDE";
            dgv.Columns[7].Visible = false;

            dgv.Columns[8].DataPropertyName = "TRAN_TELEFONO1";
            dgv.Columns[8].Visible = false;

            dgv.Columns[9].DataPropertyName = "TRAN_TELEFONO2";
            dgv.Columns[9].Visible = false;

            dgv.Columns[10].DataPropertyName = "TRAN_FAX";
            dgv.Columns[10].Visible = false;

            dgv.Columns[11].DataPropertyName = "TRAN_CORREO";
            dgv.Columns[11].Visible = false;

            dgv.Columns[12].DataPropertyName = "TRAN_PATERNO";
            dgv.Columns[12].Visible = false;

            dgv.Columns[13].DataPropertyName = "TRAN_MATERNO";
            dgv.Columns[13].Visible = false;

            dgv.Columns[14].DataPropertyName = "TRAN_NOMBRE";
            dgv.Columns[14].Visible = false;

            dgv.Columns[15].DataPropertyName = "TRAN_ESTADO";
            dgv.Columns[15].Visible = false;

            dgv.Columns[16].DataPropertyName = "TRAN_FECHAINAC";
            dgv.Columns[16].Visible = false;

            dgv.Columns[17].DataPropertyName = "CREACION";
            dgv.Columns[17].Visible = false;

            dgv.Columns[18].DataPropertyName = "VECES";
            dgv.Columns[18].Visible = false;

        }
        public void Cargar_Transportistas()
        {
            DataTable TEMP = new DataTable();
            string filtro = txtBuscar.Text;
            ENResultOperation R = ClsTransportistaBC.Listar_Nombre(filtro);

            if (R.Proceder) dgvListado.DataSource = (DataTable)R.Valor;
        }

        private void Aceptar_Transportista()
        {
            if (string.IsNullOrEmpty(TransportistaID))
            {
                //ProveedorID = dgvListado.Rows[0].Cells[0].Value.ToString();
                TransportistaID = Convert.ToString(this.dgvListado.CurrentRow.Cells["TRAN_IDE"].Value);
                TransportistaRazon = Convert.ToString(this.dgvListado.CurrentRow.Cells["TRAN_RAZON_SOCIAL"].Value);
            }
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Aceptar_Transportista();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmTransportista_Buscar_Load(object sender, EventArgs e)
        {
            FormatoDgv();
            txtBuscar.Text = TransportistaRazon;
            Cargar_Transportistas();
            dgvListado.Focus();
        }

   

        private void dgvListado_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dgvListado.CurrentRow != null)
            {
                TransportistaID = Convert.ToString(this.dgvListado.CurrentRow.Cells["TRAN_IDE"].Value);
                TransportistaRazon = Convert.ToString(this.dgvListado.CurrentRow.Cells["TRAN_RAZON_SOCIAL"].Value);
            }
        }

        private void dgvListado_DoubleClick(object sender, EventArgs e)
        {
            Aceptar_Transportista();
        }

        private void dgvListado_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                Aceptar_Transportista();
            }   
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                Cargar_Transportistas();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Cargar_Transportistas();
        }
    }
}
