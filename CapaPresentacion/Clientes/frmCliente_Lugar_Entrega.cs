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
    public partial class frmCliente_Lugar_Entrega : Form
    {
        public Int32  Clie_Ide { get; set; }
        public string  Loca_Ide { get; set; }
        public string Clie_Nombre { get; set; }
        public string Direccion_Lugar_Entrega { get; set; }
        public frmCliente_Lugar_Entrega()
        {
            InitializeComponent();
        }

        private void frmCliente_Lugar_Entrega_Load(object sender, EventArgs e)
        {
            FormatoDgv();
            txtRazon_Social.Text = Clie_Nombre;
            Cargar_Lugar_Entrega_Cliente(Clie_Ide);
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
            dgv.ColumnCount = 7;
            // Setear Cabecera de Columna 

            dgv.Columns[0].Name = "IDE";
            dgv.Columns[1].Name = "LUGART_IDE";
            dgv.Columns[2].Name = "LUGAR_DIRECCION";
            dgv.Columns[3].Name = "LOCA";
            dgv.Columns[4].Name = "NOMBRE";
            dgv.Columns[5].Name = "CREACION";
            dgv.Columns[6].Name = "VECES";

            dgv.Columns[0].Width = 60;
            dgv.Columns[0].HeaderText = "ID";
            dgv.Columns[0].DataPropertyName = "CLIE_IDE";
            dgv.Columns[0].Visible = false;

            dgv.Columns[1].Width = 120;
            dgv.Columns[1].HeaderText = "Codigo";
            dgv.Columns[1].DataPropertyName = "CLIE_LUGAR_IDE";

            dgv.Columns[2].Width = 320;
            dgv.Columns[2].HeaderText = "Direccion";
            dgv.Columns[2].DataPropertyName = "CLIE_LUGAR_DIRECCION";

            dgv.Columns[3].Width = 90;
            dgv.Columns[3].HeaderText = "Localidad";
            dgv.Columns[3].DataPropertyName = "LOCA_IDE";
            dgv.Columns[3].Visible = false;
            // Columnas que no Deben Verse
            dgv.Columns[4].Width = 90;
            dgv.Columns[4].HeaderText = "Localidad";
            dgv.Columns[4].DataPropertyName = "LOCA_NOMBRE";

            dgv.Columns[5].DataPropertyName = "CREACION";
            dgv.Columns[5].Visible = false;
            dgv.Columns[6].DataPropertyName = "VECES";
            dgv.Columns[6].Visible = false;
        }

        public void Cargar_Lugar_Entrega_Cliente(int ID_Cliente)
        {
            DataTable TEMP = new DataTable();
            ENResultOperation R = ClsCliente_Lugar_EntregaBC.Listar(ID_Cliente);
            if (R.Proceder) dgvListado.DataSource = (DataTable)R.Valor;
        }

        public void Acepta_Lugar_Entrega()
        {
            if (!String.IsNullOrEmpty(Convert.ToString(this.dgvListado.CurrentRow.Cells["LUGAR_DIRECCION"].Value)))
            {
                Direccion_Lugar_Entrega = Convert.ToString(this.dgvListado.CurrentRow.Cells["LUGAR_DIRECCION"].Value);
                Loca_Ide = Convert.ToString(this.dgvListado.CurrentRow.Cells["LOCA"].Value);
            }
            else
            {
                Direccion_Lugar_Entrega = "";
            }
            this.Close();
        }

        private void dgvListado_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                Acepta_Lugar_Entrega();
            }   
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Acepta_Lugar_Entrega();
        }
    }
}
