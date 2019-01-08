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

namespace CapaPresentacion.Tablas
{
    public partial class frmBuscarLocalidad : Form
    {
        public string Loca_Ide { get; set; }
        public string Loca_Nombre { get; set; }
        public frmBuscarLocalidad()
        {
            InitializeComponent();
        }

        private void frmBuscarLocalidad_Load(object sender, EventArgs e)
        {
            FormatoDgv();
            Cargar_Localidades("");
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
            //dgv.Columns.Clear();
            dgv.ColumnCount = 6;
            // Setear Cabecera de Columna 

            dgv.Columns[0].Name = "IDE";
            dgv.Columns[1].Name = "CODIGO";
            dgv.Columns[2].Name = "NOMBRE";
            dgv.Columns[3].Name = "PROVINCIA";
            dgv.Columns[4].Name = "DEPARTAMENTO";
            dgv.Columns[5].Name = "PAIS";

            dgv.Columns[0].Width = 60;
            dgv.Columns[0].HeaderText = "ID";
            dgv.Columns[0].DataPropertyName = "LOCA_IDE";
            dgv.Columns[0].Visible = false;

            dgv.Columns[1].Width = 120;
            dgv.Columns[1].HeaderText = "Codigo";
            dgv.Columns[1].DataPropertyName = "LOCA_CODIGO";

            dgv.Columns[2].Width = 320;
            dgv.Columns[2].HeaderText = "Localidad";
            dgv.Columns[2].DataPropertyName = "LOCA_NOMBRE";

            dgv.Columns[3].Width = 90;
            dgv.Columns[3].HeaderText = "Provincia";
            dgv.Columns[3].DataPropertyName = "PROVINCIA";
            dgv.Columns[3].Visible = false;

            dgv.Columns[4].Width = 90;
            dgv.Columns[4].HeaderText = "Departamento";
            dgv.Columns[4].DataPropertyName = "DEPARTAMENTO";

            dgv.Columns[5].Width = 120;
            dgv.Columns[5].HeaderText = "Pais";
            dgv.Columns[5].DataPropertyName = "PAIS_NOMBRE";
        }

        public void Cargar_Localidades(string textoBuscar)
        {
            DataTable TEMP = new DataTable();
            ENResultOperation R = ClsLocalidadBC.ListarBuscar(textoBuscar);
            if (R.Proceder) dgvListado.DataSource = (DataTable)R.Valor; dgvListado.Focus();
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Loca_Ide = "";
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Acepta_Localidad();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Cargar_Localidades(txtBuscar.Text);
        }

        public void Acepta_Localidad()
        {
            if (!String.IsNullOrEmpty(Convert.ToString(this.dgvListado.CurrentRow.Cells["NOMBRE"].Value)))
            {
                Loca_Ide = Convert.ToString(this.dgvListado.CurrentRow.Cells["IDE"].Value);
                Loca_Nombre = this.dgvListado.CurrentRow.Cells["NOMBRE"].ToString();
            }
            this.Close();
        }

        private void dgvListado_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                Acepta_Localidad();
            }
        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                Cargar_Localidades(txtBuscar.Text);
           }
        }

        private void dgvListado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                Cargar_Localidades(txtBuscar.Text);
            }
            if ((int)e.KeyChar == (int)Keys.Tab) txtBuscar.Focus();

        }
    }
}
