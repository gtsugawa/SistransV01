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

namespace CapaPresentacion.Clientes
{
    public partial class frmClientesBuscar : Form
    {
        public Int32  Clie_Ide { get; set; }
        public string ClienteID { get; set; }
        public string Cliente_Razon { get; set; }
        public string Cliente_Direccion { get; set;}
        public string Cliente_localidad { get; set;}
        private SqlConnection Con = null;
        private SqlCommand Cmd;
        private SqlDataReader dr = null;
        string strcon = ConfigurationManager.ConnectionStrings["conex1"].ConnectionString;

//        string strcon = "Data Source=GUILLERMO-HP\\SQLEXPRESS;Initial Catalog=SIAC_TERAH;Integrated Security=True";
        public frmClientesBuscar()
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
            dgv.AllowUserToResizeColumns = false;
            dgv.AllowUserToResizeRows = false;
            /*---------------Tipo de fuente y tamaño-----*/
            dgv.DefaultCellStyle.Font = new Font("Tahoma", 8);
            /*----------Alterna colores en el grid -------*/
            dgv.RowsDefaultCellStyle.BackColor = Color.WhiteSmoke; //.LightBlue;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
            /*---Pintado de color a la cabecera del datagrid ---*/
            DataGridViewCellStyle style = this.dgvListado.ColumnHeadersDefaultCellStyle;
            style.BackColor = Color.Honeydew;
            style.ForeColor = Color.Gray;
            dgv.Columns.Clear();
            dgv.ColumnCount = 22;
            // Setear Cabecera de Columna 

            dgv.Columns[0].Name = "IDE";
            dgv.Columns[1].Name = "CODIGO";
            dgv.Columns[2].Name = "RAZON_SOCIAL";
            dgv.Columns[3].Name = "EMPRESA";
            dgv.Columns[4].Name = "RUC";
            dgv.Columns[5].Name = "FECHA_CONSTITUCION";
            dgv.Columns[6].Name = "DIRECCION";
            dgv.Columns[7].Name = "LOCA_IDE";
            dgv.Columns[8].Name = "TELEFONO1";
            dgv.Columns[9].Name = "TELEFONO2";
            dgv.Columns[10].Name = "FAX";
            dgv.Columns[11].Name = "TIPO_CLIE";
            dgv.Columns[12].Name = "ACTI_CLIE";
            dgv.Columns[13].Name = "CATE_CLIE";
            dgv.Columns[14].Name = "CORREO";
            dgv.Columns[15].Name = "PATERNO";
            dgv.Columns[16].Name = "MATERNO";
            dgv.Columns[17].Name = "NOMBRE";
            dgv.Columns[18].Name = "ESTADO";
            dgv.Columns[19].Name = "FECHAINAC";
            dgv.Columns[20].Name = "CREACION";
            dgv.Columns[21].Name = "VECES";

            dgv.Columns[0].Width = 60;
            dgv.Columns[0].HeaderText = "ID";
            dgv.Columns[0].DataPropertyName = "CLIE_IDE";
            dgv.Columns[0].Visible = false;

            dgv.Columns[1].Width = 120;
            dgv.Columns[1].HeaderText = "Codigo";
            dgv.Columns[1].DataPropertyName = "CLIE_CODIGO";

            dgv.Columns[2].Width = 320;
            dgv.Columns[2].HeaderText = "Razon Social";
            dgv.Columns[2].DataPropertyName = "CLIE_RAZON_SOCIAL";

            dgv.Columns[3].Width = 65;
            dgv.Columns[3].HeaderText = "Empresa";
            dgv.Columns[3].DataPropertyName = "CLIE_EMPRESA";
            dgv.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.Columns[3].Visible = false;


            dgv.Columns[4].Width = 120;
            dgv.Columns[4].HeaderText = "RUC";
            dgv.Columns[4].DataPropertyName = "CLIE_RUC";
            dgv.Columns[4].Visible = false;

            dgv.Columns[5].Width = 20;
            dgv.Columns[5].HeaderText = "F.Constitucion";
            dgv.Columns[5].DataPropertyName = "CLIE_FECHA_CONSTITUCION";
            dgv.Columns[5].Visible = false;

            dgv.Columns[6].Width = 274;
            dgv.Columns[6].HeaderText = "Direccion";
            dgv.Columns[6].DataPropertyName = "CLIE_DIRECCION";
            
            // Columnas que no Deben Verse

            dgv.Columns[7].DataPropertyName = "LOCA_IDE";
            dgv.Columns[7].Visible = false;
            dgv.Columns[8].DataPropertyName = "CLIE_TELEFONO1";
            dgv.Columns[8].Visible = false;
            dgv.Columns[9].DataPropertyName = "CLIE_TELEFONO2";
            dgv.Columns[9].Visible = false;
            dgv.Columns[10].DataPropertyName = "CLIE_FAX";
            dgv.Columns[10].Visible = false;
            dgv.Columns[11].DataPropertyName = "TIPO_CLIE_IDE";
            dgv.Columns[11].Visible = false;
            dgv.Columns[12].DataPropertyName = "ACTI_CLIE_IDE";
            dgv.Columns[12].Visible = false;
            dgv.Columns[13].DataPropertyName = "CATE_CLIE_IDE";
            dgv.Columns[13].Visible = false;


            dgv.Columns[14].DataPropertyName = "CLIE_CORREO";
            dgv.Columns[14].Visible = false;
            dgv.Columns[15].DataPropertyName = "CLIE_PATERNO";
            dgv.Columns[15].Visible = false;
            dgv.Columns[16].DataPropertyName = "CLIE_MATERNO";
            dgv.Columns[16].Visible = false;
            dgv.Columns[17].DataPropertyName = "CLIE_NOMBRE";
            dgv.Columns[17].Visible = false;
            dgv.Columns[18].DataPropertyName = "CLIE_ESTADO";
            dgv.Columns[18].Visible = false;
            dgv.Columns[19].DataPropertyName = "CLIE_FECHAINAC";
            dgv.Columns[19].Visible = false;
            dgv.Columns[20].DataPropertyName = "CREACION";
            dgv.Columns[20].Visible = false;
            dgv.Columns[21].DataPropertyName = "VECES";
            dgv.Columns[21].Visible = false;
        }

        public void CargarClientes()
        {
            DataTable TEMP = new DataTable();
            string filtro = txtBuscar.Text;
            ENResultOperation R = ClsClientesBC.Listar_Nombre(filtro);
            if (R.Proceder) dgvListado.DataSource = (DataTable)R.Valor;
            
        }

         private void frmClientesBuscar_Load(object sender, EventArgs e)
        {
            FormatoDgv();
            txtBuscar.Text = Cliente_Razon;
            CargarClientes();
            txtBuscar.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ClienteID = "";
            Cliente_Razon = "";
            Close();
        }

         private void btnAceptar_Click(object sender, EventArgs e)
        {
            Aceptar_Cliente();
        }

        private void Aceptar_Cliente()
        {
            if (dgvListado.CurrentRow != null)
            {
                Clie_Ide = Convert.ToInt32(this.dgvListado.CurrentRow.Cells["IDE"].Value);
                ClienteID = Convert.ToString(this.dgvListado.CurrentRow.Cells["CODIGO"].Value);
                Cliente_Razon = Convert.ToString(this.dgvListado.CurrentRow.Cells["RAZON_SOCIAL"].Value);
                Cliente_Direccion = Convert.ToString(this.dgvListado.CurrentRow.Cells["DIRECCION"].Value);
                Cliente_localidad = Convert.ToString(this.dgvListado.CurrentRow.Cells["LOCA_IDE"].Value);
            }
            DialogResult = DialogResult.OK;
            this.Close();
        }
        private void dgvListado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            int index = e.RowIndex;// get the Row Index
            if (index > 0)
            {
                DataGridViewRow selectedRow = dgvListado.Rows[index];
                Clie_Ide = Convert.ToInt32(selectedRow.Cells["IDE"].Value);
                ClienteID = selectedRow.Cells["CODIGO"].Value.ToString();
                Cliente_Razon = selectedRow.Cells["RAZON_SOCIAL"].Value.ToString();
            }
            /* 
            if (dgvListado.CurrentRow != null)
            {
                ClienteID = Convert.ToString(this.dgvListado.CurrentRow.Cells["CODIGO"].Value);
                Cliente_Razon = Convert.ToString(this.dgvListado.CurrentRow.Cells["RAZON_SOCIAL"].Value);
            }
            */
        }
        private void dgvListado_CurrentCellChanged(object sender, EventArgs e)
        {

            if (dgvListado.CurrentRow != null)
            {
                Clie_Ide = Convert.ToInt32(this.dgvListado.CurrentRow.Cells["IDE"].Value);
                ClienteID = Convert.ToString(this.dgvListado.CurrentRow.Cells["CODIGO"].Value);
                Cliente_Razon = Convert.ToString(this.dgvListado.CurrentRow.Cells["RAZON_SOCIAL"].Value);
            }
        }

        
        private void dgvListado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Aceptar_Cliente();
        }

        private void dgvListado_KeyPress(object sender, KeyPressEventArgs e)
        {

            if ((int)e.KeyChar == (int)Keys.Tab) txtBuscar.Focus();
        }

        private void dgvListado_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                Aceptar_Cliente();
            }
            if (e.KeyCode == Keys.F3)
            {
                Aceptar_Cliente();
            }   

        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                CargarClientes();
                this.dgvListado.Focus();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CargarClientes();
        }

        private void txtBuscar_Validated(object sender, EventArgs e)
        {

        }

        private void frmClientesBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Escape) btnSalir.PerformClick();
        }

 
    }
}
