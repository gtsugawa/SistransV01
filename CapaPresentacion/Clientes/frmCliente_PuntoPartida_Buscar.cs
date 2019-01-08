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
    public partial class frmCliente_PuntoPartida_Buscar : Form
    {
        public Int32  Clie_Ide { get; set; }
        public string Clie_Razon_Social { get; set; }
        public string Direccion_Punto_Partida { get; set; }
        public string Punto_Partida_Ide { get; set; }
        public string Loca_Punto_Partida { get; set; }
        public frmCliente_PuntoPartida_Buscar()
        {
            InitializeComponent();
        }

        private void frmCliente_PuntoPartida_Load(object sender, EventArgs e)
        {
            FormatoDgv();
            Cargar_Punto_Partida_Cliente();
            txtRazon_Social.Text = Clie_Razon_Social;
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
            dgv.ColumnCount = 8;
            // Setear Cabecera de Columna 

            dgv.Columns[0].Name = "IDE";
            dgv.Columns[1].Name = "PART_IDE";
            dgv.Columns[2].Name = "PART_DIRECCION";
            dgv.Columns[3].Name = "LOCA";
            dgv.Columns[4].Name = "NOMBRE";
            dgv.Columns[5].Name = "CREACION";
            dgv.Columns[6].Name = "VECES";
            dgv.Columns[7].Name = "LRC";

            dgv.Columns[0].Width = 60;
            dgv.Columns[0].HeaderText = "ID";
            dgv.Columns[0].DataPropertyName = "PROV_IDE";
            dgv.Columns[0].Visible = false;

            dgv.Columns[1].Width = 120;
            dgv.Columns[1].HeaderText = "Codigo";
            dgv.Columns[1].DataPropertyName = "PROV_PART_IDE";

            dgv.Columns[2].Width = 320;
            dgv.Columns[2].HeaderText = "Direccion";
            dgv.Columns[2].DataPropertyName = "PROV_PART_DIRECCION";

            dgv.Columns[3].Width = 90;
            dgv.Columns[3].HeaderText = "Localidad";
            dgv.Columns[3].DataPropertyName = "LOCA_IDE";
            // Columnas que no Deben Verse
            dgv.Columns[4].Width = 90;
            dgv.Columns[4].HeaderText = "Nombre";
            dgv.Columns[4].DataPropertyName = "LOCA_NOMBRE";

            dgv.Columns[5].DataPropertyName = "CREACION";
            dgv.Columns[5].Visible = false;
            dgv.Columns[6].DataPropertyName = "VECES";
            dgv.Columns[6].Visible = false;
            dgv.Columns[7].DataPropertyName = "LRC_IDE";
            dgv.Columns[7].Visible = false;
        }

        public void Cargar_Punto_Partida_Cliente()
        {
            DataTable TEMP = new DataTable();
            ENResultOperation R = ClsCliente_Punto_PartidaBC.Listar(Clie_Ide);
            if (R.Proceder)
            {
                DataTable dt = (DataTable)R.Valor;
                if (dt.Rows.Count > 1) dgvListado.DataSource = (DataTable)R.Valor;
            }

        }

        private void dgvListado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Aceptar_Punto_Partida();
        }

        private void Aceptar_Punto_Partida()
        {
            if (dgvListado.CurrentRow != null)
            {
                Direccion_Punto_Partida = Convert.ToString(this.dgvListado.CurrentRow.Cells["PART_DIRECCION"].Value);
                Loca_Punto_Partida = Convert.ToString(this.dgvListado.CurrentRow.Cells["LOCA"].Value);
                Punto_Partida_Ide = Convert.ToString(this.dgvListado.CurrentRow.Cells["PART_IDE"].Value);
                this.Close();
            }
            else
            {
                Punto_Partida_Ide = "0";
            }
        }

        private void dgvListado_KeyPress(object sender, KeyPressEventArgs e)
        {

            if ((int)e.KeyChar == (int)Keys.Enter)
            {
               
            }
        }

        private void dgvListado_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                Aceptar_Punto_Partida();
            }   
        }

        private void frmCliente_PuntoPartida_Buscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Escape)
            {
                this.Close();
            }
        }

  
    }
}
