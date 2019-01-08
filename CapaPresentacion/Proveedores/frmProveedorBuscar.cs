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

namespace CapaPresentacion.Proveedores
{
    public partial class frmProveedorBuscar : Form
    {
        public string ProveedorID { get; set; }
        public string ProveedorRazon { get; set; }
        public string ProveedorRuc { get; set; }
        public Int32 ProveedorVeces { get; set; }

        private SqlConnection Con = null;
        private SqlCommand Cmd;
        private SqlDataReader dr = null;
        string strcon = ConfigurationManager.ConnectionStrings["conex1"].ConnectionString;
        public frmProveedorBuscar()
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
            dgv.ColumnCount = 5;
            // Setear Cabecera de Columna 

            dgv.Columns[0].Name = "PROV_IDE";
            dgv.Columns[1].Name = "PROV_RAZON_SOCIAL";
            dgv.Columns[2].Name = "PROV_RUC";
            dgv.Columns[3].Name = "PROV_DIRECCION";
            dgv.Columns[4].Name = "VECES";

            dgv.Columns[0].Width = 45;
            dgv.Columns[0].HeaderText = "ID";
            dgv.Columns[0].DataPropertyName = "PROV_IDE";

            dgv.Columns[1].Width = 340;
            dgv.Columns[1].HeaderText = "Razon Social";
            dgv.Columns[1].DataPropertyName = "PROV_RAZON_SOCIAL";

            dgv.Columns[2].Width = 120;
            dgv.Columns[2].HeaderText = "  RUC ";
            dgv.Columns[2].DataPropertyName = "PROV_RUC";

            dgv.Columns[3].Width = 457;
            dgv.Columns[3].HeaderText = "Direccion";
            dgv.Columns[3].DataPropertyName = "PROV_DIRECCION";

        }
        public void CargarProveedores()
        {
            DataTable TEMP = new DataTable();
            string filtro = ProveedorRazon;
            ENResultOperation R = ClsProveedorBC.Listar(filtro);

            if (R.Proceder) dgvListado.DataSource = (DataTable)R.Valor;
        }

        public void Cargar_ComboBox()
        {
            cboFiltro.Items.Clear();
            cboFiltro.Items.Add("Razon Social");
            cboFiltro.Items.Add("RUC");
            cboFiltro.Items.Add("Direccion");
            cboFiltro.SelectedIndex = 0;
        }

        public void LimpiarTxtBuscar()
        {
            txtBuscar.Text = "";
        }

        private void frmProveedorBuscar_Load(object sender, EventArgs e)
        {
            FormatoDgv();
            Cargar_ComboBox();
            cboFiltro.Text = "Razon Social";
            rbtActivo.Checked = true;
            CargarProveedores();
            txtBuscar.Focus();
        }

        public void BuscarProveedor()
        {
            string estado = "%Activo%";
            string cadena = "";
            if (rbtActivo.Checked) estado = "%Activo%";
            if (rbtInactivo.Checked) estado = "%Inactivo%";
            if (rbtTodos.Checked) estado = "%";
            switch (cboFiltro.Text)
            {
                case "RUC":
                    cadena = " and Prov_RUC like @filtro ORDER BY Prov_RUC";
                    break;
                case "Razon Social":
                    cadena = " and Prov_Razon_Social like @filtro ORDER BY Prov_Razon_Social ";
                    break;
                case "Direccion":
                    cadena = " and Prov_Direccion like @filtro ORDER BY Prov_Direccion";
                    break;
            }
            string Consulta = "Select * from Proveedor where Prov_estado like @Estado " + cadena;
            string cadenastr = "";
            if (string.IsNullOrEmpty(txtBuscar.Text.Trim()))
            {
                cadenastr = "%";
            }
            else
            {
                cadenastr = "%" + txtBuscar.Text.Trim() + "%";
            }
            //Consulta = "Select * from Proveedor where Prov_estado Like '%Activo%' and Prov_Razon_Social Like '%ONU%' Order By Prov_Razon_Social";
            Con = new SqlConnection(strcon);
            Cmd = new SqlCommand(Consulta, Con);
            Cmd.Parameters.AddWithValue("@Estado", estado);
            Cmd.Parameters.AddWithValue("@filtro", cadenastr);
            Con.Open();
            dr = Cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dgvListado.DataSource = dt;
            dgvListado.Focus();
            dr.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Aceptar_Grifo();
        }

        private void Aceptar_Grifo()
        {
            if (string.IsNullOrEmpty(ProveedorID))
            {
                //ProveedorID = dgvListado.Rows[0].Cells[0].Value.ToString();
                ProveedorID = Convert.ToString(this.dgvListado.CurrentRow.Cells["PROV_IDE"].Value);
                ProveedorRazon = Convert.ToString(this.dgvListado.CurrentRow.Cells["PROV_RAZON_SOCIAL"].Value);
                ProveedorRuc = Convert.ToString(this.dgvListado.CurrentRow.Cells["PROV_RUC"].Value);
                ProveedorVeces = Convert.ToInt32(this.dgvListado.CurrentRow.Cells["VECES"].Value);
            }
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
           this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BuscarProveedor();
        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                BuscarProveedor();
            }
        }

        private void rbtActivo_CheckedChanged(object sender, EventArgs e)
        {
            LimpiarTxtBuscar();
        }

        private void rbtInactivo_CheckedChanged(object sender, EventArgs e)
        {
            LimpiarTxtBuscar();
        }

        private void rbtTodos_CheckedChanged(object sender, EventArgs e)
        {
            LimpiarTxtBuscar();
        }

        private void dgvListado_CurrentCellChanged(object sender, EventArgs e)
        {

            if (dgvListado.CurrentRow != null)
            {
                ProveedorID = Convert.ToString(this.dgvListado.CurrentRow.Cells["PROV_IDE"].Value);
                ProveedorRazon = Convert.ToString(this.dgvListado.CurrentRow.Cells["PROV_RAZON_SOCIAL"].Value);
                ProveedorRuc = Convert.ToString(this.dgvListado.CurrentRow.Cells["PROV_RUC"].Value);
            }
        }

        private void dgvListado_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                Aceptar_Grifo();
            }
        }

        private void dgvListado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                Aceptar_Grifo();
            }
        }

    }
}
