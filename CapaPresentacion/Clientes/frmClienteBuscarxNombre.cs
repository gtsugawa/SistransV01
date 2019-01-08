using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaBE;
using CapaBC;


namespace CapaPresentacion.Clientes
{
    public partial class frmClienteBuscarxNombre : Form
    {
        public string cNombre = "";
        public Int32  nClie_Ide = 0;
        public frmClienteBuscarxNombre()
        {
            InitializeComponent();
            dgvListado.AutoGenerateColumns = false;
        }

        private void frmClienteBuscarxNombre_Load(object sender, EventArgs e)
        {
            FormatoDgv();
            CargarClientes();
            Mostrar_Dgv();
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
            dgv.DefaultCellStyle.Font = new Font("Tahoma", 10);
            /*----------Alterna colores en el grid -------*/
            dgv.RowsDefaultCellStyle.BackColor = Color.WhiteSmoke; //.LightBlue;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
            /*---Pintado de color a la cabecera del datagrid ---*/
            DataGridViewCellStyle style = this.dgvListado.ColumnHeadersDefaultCellStyle;
            style.BackColor = Color.Honeydew;
            style.ForeColor = Color.Gray;
            dgv.Columns.Clear();
            dgv.ColumnCount = 4;
            // Setear Cabecera de Columna 

            dgv.Columns[0].Name = "IDE";
            dgv.Columns[1].Name = "CODIGO";
            dgv.Columns[2].Name = "RAZON_SOCIAL";
            dgv.Columns[3].Name = "DIRECCION";

            dgv.Columns[0].Width = 60;
            dgv.Columns[0].HeaderText = "ID";
            dgv.Columns[0].DataPropertyName = "CLIE_IDE";
            dgv.Columns[0].Visible = false;

            dgv.Columns[1].Width = 120;
            dgv.Columns[1].HeaderText = "Codigo";
            dgv.Columns[1].DataPropertyName = "CLIE_CODIGO";
            dgv.Columns[1].Visible = false;

            dgv.Columns[2].Width = 320;
            dgv.Columns[2].HeaderText = "Razon Social";
            dgv.Columns[2].DataPropertyName = "CLIE_RAZON_SOCIAL";

            dgv.Columns[3].Width = 300;
            dgv.Columns[3].HeaderText = "Direccion";
            dgv.Columns[3].DataPropertyName = "CLIE_DIRECCION";

        }

        private void CargarClientes()
        {
            DataTable TEMP = new DataTable();
            string filtro = cNombre.Trim();
            ENResultOperation R = ClsClientesBC.Listar(filtro);
            if (R.Proceder) dgvListado.DataSource = (DataTable)R.Valor;
        }

       private void Mostrar_Dgv()
        {
           if (this.dgvListado.CurrentRow != null)
           {

               cNombre = Convert.ToString(this.dgvListado.CurrentRow.Cells["RAZON_SOCIAL"].Value);
               nClie_Ide = Convert.ToInt32(this.dgvListado.CurrentRow.Cells["IDE"].Value);
           }
        }

        private void dgvListado_CurrentCellChanged(object sender, EventArgs e)
        {
            cNombre   = Convert.ToString(this.dgvListado.CurrentRow.Cells["RAZON_SOCIAL"].Value);
            txtNombre.Text = Convert.ToString(this.dgvListado.CurrentRow.Cells["RAZON_SOCIAL"].Value);
            nClie_Ide = Convert.ToInt32(this.dgvListado.CurrentRow.Cells["IDE"].Value);
        }

        private void dgvListado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                this.Close();
            }
        }

    
    }
}
