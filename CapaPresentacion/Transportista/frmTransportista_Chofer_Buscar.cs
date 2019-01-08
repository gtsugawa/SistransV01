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
    public partial class frmTransportista_Chofer_Buscar : Form
    {
        public Int32  Transportista_Ide { get; set; }
        public string Transportista_Nombre { get; set; }
        public string Chofer_Ide { get; set; }
        public string Chofer_Nombre { get; set;}
        public frmTransportista_Chofer_Buscar()
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
            dgv.ColumnCount = 26;
            // Setear Cabecera de Columna 

            dgv.Columns[0].Name = "TRAN_IDE";
            dgv.Columns[1].Name = "TRAN_CHOF_IDE";
            dgv.Columns[2].Name = "TRAN_CHOF_TITULO";
            dgv.Columns[3].Name = "TRAN_CHOF_PATERNO";
            dgv.Columns[4].Name = "TRAN_CHOF_MATERNO";
            dgv.Columns[5].Name = "TRAN_CHOF_NOMBRE";
            dgv.Columns[6].Name = "TRAN_CHOF_LICENCIA";
            dgv.Columns[7].Name = "TRAN_CHOF_DIRECCION";
            dgv.Columns[8].Name = "LOCA_IDE";
            dgv.Columns[9].Name = "TRAN_CHOF_TELEFONO_CASA";
            dgv.Columns[10].Name = "TRAN_CHOF_TELEFONO_CELULAR";
            dgv.Columns[11].Name = "TRAN_CHOF_FAX";
            dgv.Columns[12].Name = "DOCU_IDEN_IDE";
            dgv.Columns[13].Name = "TRAN_CHOF_DOCUMENTO";
            dgv.Columns[14].Name = "TRAN_CHOF_FECHA_NACIMIENTO";
            dgv.Columns[15].Name = "TRAN_CHOF_FECHA_INGRESO";
            dgv.Columns[16].Name = "TRAN_CHOF_SEXO";
            dgv.Columns[17].Name = "TRAN_CHOF_ESTADO_CIVIL";
            dgv.Columns[18].Name = "TRAN_CHOF_CORREO";
            dgv.Columns[19].Name = "TRAN_CHOF_NOTA";
            dgv.Columns[20].Name = "CREACION";
            dgv.Columns[21].Name = "VECES";
            dgv.Columns[22].Name = "TRAN_CHOF_NOMBRE1";
            dgv.Columns[23].Name = "TRAN_CHOF_VEHICULO";
            dgv.Columns[24].Name = "PLACA";
            dgv.Columns[25].Name = "CERTIFICADO";

            dgv.Columns[0].DataPropertyName = "TRAN_IDE";
            dgv.Columns[0].Visible = false;

            dgv.Columns[1].DataPropertyName = "TRAN_CHOF_IDE";
            dgv.Columns[1].Visible = false;

            dgv.Columns[2].Width = 45;
            dgv.Columns[2].HeaderText = "Tit";
            dgv.Columns[2].DataPropertyName = "TRAN_CHOF_TITULO";

            dgv.Columns[3].Width = 160;
            dgv.Columns[3].HeaderText = "Paterno";
            dgv.Columns[3].DataPropertyName = "TRAN_CHOF_PATERNO";
            dgv.Columns[3].Visible = false;

            dgv.Columns[4].Width = 160;
            dgv.Columns[4].HeaderText = "Materno";
            dgv.Columns[4].DataPropertyName = "TRAN_CHOF_MATERNO";
            dgv.Columns[4].Visible = false;

            dgv.Columns[5].Width = 400;
            dgv.Columns[5].HeaderText = "Nombres";
            dgv.Columns[5].DataPropertyName = "TRAN_CHOF_NOMBRE";

            dgv.Columns[6].DataPropertyName = "TRAN_CHOF_LICENCIA";
            dgv.Columns[6].Visible = false;

            dgv.Columns[7].DataPropertyName = "TRAN_CHOF_DIRECCION";
            dgv.Columns[7].Visible = false;

            dgv.Columns[8].DataPropertyName = "LOCA_IDE";
            dgv.Columns[8].Visible = false;

            dgv.Columns[9].DataPropertyName = "TRAN_CHOF_TELEFONO_CASA";
            dgv.Columns[9].Visible = false;

            dgv.Columns[10].DataPropertyName = "TRAN_CHOF_TELEFONO_CELULAR";
            dgv.Columns[10].Visible = false;

            dgv.Columns[11].DataPropertyName = "TRAN_CHOF_FAX";
            dgv.Columns[11].Visible = false;

            dgv.Columns[12].DataPropertyName = "DOCU_IDEN_IDE";
            dgv.Columns[12].Visible = false;

            dgv.Columns[13].DataPropertyName = "TRAN_CHOF_DOCUMENTO";
            dgv.Columns[13].Visible = false;

            dgv.Columns[14].DataPropertyName = "TRAN_CHOF_FECHA_NACIMIENTO";
            dgv.Columns[14].Visible = false;

            dgv.Columns[15].DataPropertyName = "TRAN_CHOF_FECHA_INGRESO";
            dgv.Columns[15].Visible = false;

            dgv.Columns[16].DataPropertyName = "TRAN_CHOF_SEXO";
            dgv.Columns[16].Visible = false;

            dgv.Columns[17].DataPropertyName = "TRAN_CHOF_ESTADO_CIVIL";
            dgv.Columns[17].Visible = false;

            dgv.Columns[18].DataPropertyName = "TRAN_CHOF_CORREO";
            dgv.Columns[18].Visible = false;

            dgv.Columns[19].DataPropertyName = "TRAN_CHOF_NOTA";
            dgv.Columns[19].Visible = false;

            dgv.Columns[20].DataPropertyName = "CREACION";
            dgv.Columns[20].Visible = false;

            dgv.Columns[21].DataPropertyName = "VECES";
            dgv.Columns[21].Visible = false;

            dgv.Columns[22].DataPropertyName = "TRAN_CHOF_NOMBRE1";
            dgv.Columns[22].Visible = false;

            dgv.Columns[23].DataPropertyName = "TRAN_CHOF_VEHICULO";
            dgv.Columns[23].Visible = false;

            dgv.Columns[24].DataPropertyName = "TRAN_CHOF_PLACA";
            dgv.Columns[24].Visible = false;

            dgv.Columns[25].DataPropertyName = "TRAN_CHOF_CERTIFICADO";
            dgv.Columns[25].Visible = false;

        }

        private void frmTransportista_Chofer_Buscar_Load(object sender, EventArgs e)
        {
            FormatoDgv();
            Cargar_Choferes();
            txtTransportista_Razon_Social.Text = Transportista_Nombre;
        }

        public void Cargar_Choferes()
        {
            DataTable TEMP = new DataTable();
            string filtro = txtBuscar.Text;
            ENResultOperation R = ClsTransportista_ChoferBC.Listar_Filtro(filtro,Transportista_Ide);
            if (R.Proceder) dgvListado.DataSource = (DataTable)R.Valor;
        }

        private void Aceptar_Chofer()
        {
            Chofer_Nombre = Convert.ToString(this.dgvListado.CurrentRow.Cells["TRAN_CHOF_NOMBRE"].Value);
            Chofer_Ide = Convert.ToString(this.dgvListado.CurrentRow.Cells["TRAN_CHOF_IDE"].Value);
            Transportista_Nombre = Convert.ToString(this.dgvListado.CurrentRow.Cells["TRAN_CHOF_NOMBRE"].Value); 
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Aceptar_Chofer();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTransportista_Razon_Social_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtTransportista_Razon_Social_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void dgvListado_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                Aceptar_Chofer();
            }   

        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                Cargar_Choferes();
                this.dgvListado.Focus();
            }   
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Cargar_Choferes();
        }

        private void dgvListado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Tab) txtBuscar.Focus();
        }


    }
}
