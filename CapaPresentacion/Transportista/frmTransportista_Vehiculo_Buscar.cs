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

namespace CapaPresentacion.Transportista
{
    public partial class frmTransportista_Vehiculo_Buscar : Form
    {
        public Int32 Transportista_Ide { get; set; }
        public string Transportista_Nombre { get; set; }
        public string Vehiculo_Placa { get; set; }
        public string Vehiculo_Nombre { get; set; }
        public string Vehiculo_Ide { get; set; }
        public string Tipo_Ide { get; set; }
        public string Tipo_Vehiculo { get; set; }
        public Int32 Vehiculo_Tonelaje { get; set; }
        public Int32 Vehiculo_Volumen { get; set; }
        public string Vehiculo_Rendimiento { get; set; }
        public string Tipo_Combustible { get; set; }
        public frmTransportista_Vehiculo_Buscar()
        {
            InitializeComponent();
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
            dgv.ColumnCount = 22;
            // Setear Cabecera de Columna 

        	dgv.Columns[0].Name = "TRAN_IDE";
	        dgv.Columns[1].Name = "TRAN_VEHI_IDE";
	        dgv.Columns[2].Name = "TRAN_VEHI_PLACA";
	        dgv.Columns[3].Name = "TRAN_VEHI_CONFIGURACION";
	        dgv.Columns[4].Name = "TRAN_VEHI_CERTIFICADO";
	        dgv.Columns[5].Name = "MARCA_VEHI_IDE";
	        dgv.Columns[6].Name = "TIPO_VEHI_IDE";
	        dgv.Columns[7].Name = "TRAN_VEHI_AÑO";
	        dgv.Columns[8].Name = "TRAN_VEHI_TONELAJE";
	        dgv.Columns[9].Name = "TRAN_VEHI_VOLUMEN";
	        dgv.Columns[10].Name = "TRAN_VEHI_TIPO_FRENO";
	        dgv.Columns[11].Name = "COLOR_IDE";
	        dgv.Columns[12].Name = "TRAN_VEHI_ARO";
	        dgv.Columns[13].Name = "TRAN_VEHI_SERIE";
	        dgv.Columns[14].Name = "TRAN_VEHI_NOMBRE";
	        dgv.Columns[15].Name = "TRAN_VEHI_COMBUSTIBLE";
	        dgv.Columns[16].Name = "TRAN_VEHI_RENDIMIENTO";
	        dgv.Columns[17].Name = "CREACION";
            dgv.Columns[18].Name = "VECES";

            dgv.Columns[19].Name = "MARCA_VEHI_NOMBRE";
            dgv.Columns[20].Name = "TIPO_VEHI_NOMBRE";
            dgv.Columns[21].Name = "COLOR_NOMBRE";


            dgv.Columns[0].DataPropertyName = "TRAN_IDE";
            dgv.Columns[0].Visible = false;

            dgv.Columns[1].DataPropertyName = "TRAN_VEHI_IDE";
            dgv.Columns[1].Visible = false;

            dgv.Columns[2].Width = 180;
            dgv.Columns[2].HeaderText = "Placa";
            dgv.Columns[2].DataPropertyName = "TRAN_VEHI_PLACA";

            dgv.Columns[3].Width = 120;
            dgv.Columns[3].HeaderText = "Configuracion";            
            dgv.Columns[3].DataPropertyName = "TRAN_VEHI_CONFIGURACION";

            dgv.Columns[4].DataPropertyName = "TRAN_VEHI_CERTIFICADO";
            dgv.Columns[4].Visible = false;

            dgv.Columns[5].DataPropertyName = "MARCA_VEHI_IDE";
            dgv.Columns[5].Visible = false;

            dgv.Columns[6].DataPropertyName = "TIPO_VEHI_IDE";
            dgv.Columns[6].Visible = false;

            dgv.Columns[7].DataPropertyName = "TRAN_VEHI_AÑO";
            dgv.Columns[7].Visible = false;

            dgv.Columns[8].Width = 90;
            dgv.Columns[8].HeaderText = "Tonelaje";            
            dgv.Columns[8].DataPropertyName = "TRAN_VEHI_TONELAJE";

            dgv.Columns[9].Width = 90;
            dgv.Columns[9].HeaderText = "Volumen"; 
            dgv.Columns[9].DataPropertyName = "TRAN_VEHI_VOLUMEN";

            dgv.Columns[10].DataPropertyName = "TRAN_VEHI_TIPO_FRENO";
            dgv.Columns[10].Visible = false;

            dgv.Columns[11].DataPropertyName = "COLOR_IDE";
            dgv.Columns[11].Visible = false;

            dgv.Columns[12].DataPropertyName = "TRAN_VEHI_ARO";
            dgv.Columns[12].Visible = false;

            dgv.Columns[13].DataPropertyName = "TRAN_VEHI_SERIE";
            dgv.Columns[13].Visible = false;

            dgv.Columns[14].Width = 140;
            dgv.Columns[14].HeaderText = "Nombre";
            dgv.Columns[14].DataPropertyName = "TRAN_VEHI_NOMBRE";
            
            dgv.Columns[15].DataPropertyName = "TRAN_VEHI_COMBUSTIBLE";
            dgv.Columns[15].Visible = false;

            dgv.Columns[16].DataPropertyName = "TRAN_VEHI_RENDIMIENTO";
            dgv.Columns[16].Visible = false;

            dgv.Columns[17].DataPropertyName = "CREACION";
            dgv.Columns[17].Visible = false;

            dgv.Columns[18].DataPropertyName = "VECES";
            dgv.Columns[18].Visible = false;

            dgv.Columns[19].DataPropertyName = "MARCA_VEHI_NOMBRE";
            dgv.Columns[19].Visible = false;
            dgv.Columns[20].DataPropertyName = "TIPO_VEHI_NOMBRE";
            dgv.Columns[20].Visible = false;
            dgv.Columns[21].DataPropertyName = "COLOR_NOMBRE";
            dgv.Columns[21].Visible = false;

        }

        public void Cargar_Vehiculos()
        {
            DataTable TEMP = new DataTable();
            string filtro = txtBuscar.Text;
            ENResultOperation R = ClsTransportista_VehiculoBC.Listar_Filtro(filtro, Transportista_Ide);

            if (R.Proceder) dgvListado.DataSource = (DataTable)R.Valor;
        }

        public void Obtener_Tipo_Vehiculo()
        {
            Int32 pTipo_Vehi_Ide = Convert.ToInt32(this.dgvListado.CurrentRow.Cells["TIPO_VEHI_IDE"].Value);
            ENResultOperation L = ClsTipo_VehiculoBC.Listar_Filtro("", pTipo_Vehi_Ide);
            DataTable dt = (DataTable)L.Valor;
            DataRow ROW = dt.Rows[0];
            Tipo_Vehiculo = ROW["TIPO_VEHI_NOMBRE"].ToString();
            Tipo_Ide      = ROW["TIPO_VEHI_IDE"].ToString();
        }

        private void Aceptar_Vehiculo()
        {
            Vehiculo_Ide      = Convert.ToString(this.dgvListado.CurrentRow.Cells["TRAN_VEHI_IDE"].Value);
            Vehiculo_Placa    = Convert.ToString(this.dgvListado.CurrentRow.Cells["TRAN_VEHI_PLACA"].Value);
            Vehiculo_Tonelaje = Convert.ToInt32(this.dgvListado.CurrentRow.Cells["TRAN_VEHI_TONELAJE"].Value);
            Vehiculo_Volumen  = Convert.ToInt32(this.dgvListado.CurrentRow.Cells["TRAN_VEHI_VOLUMEN"].Value);
            Vehiculo_Nombre = Convert.ToString(this.dgvListado.CurrentRow.Cells["TRAN_VEHI_NOMBRE"].Value);
            Tipo_Combustible = Convert.ToString(this.dgvListado.CurrentRow.Cells["TRAN_VEHI_COMBUSTIBLE"].Value);
            Obtener_Tipo_Vehiculo();
            DialogResult = DialogResult.OK;
            this.Close();

        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Aceptar_Vehiculo();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmTransportista_Vehiculo_Buscar_Load(object sender, EventArgs e)
        {
            FormatoDgv();
            Cargar_Vehiculos();
            txtTransportista_Razon_Social.Text = Transportista_Nombre;
        }

        private void txtTransportista_Razon_Social_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void dgvListado_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                Aceptar_Vehiculo();
            }   
        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                Cargar_Vehiculos();
                this.dgvListado.Focus();
            }   
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Cargar_Vehiculos();
        }

        private void dgvListado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Tab) txtBuscar.Focus();
        }
    }
}
