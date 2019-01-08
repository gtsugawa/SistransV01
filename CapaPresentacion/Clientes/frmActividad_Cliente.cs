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

namespace CapaPresentacion
{
    public partial class frmActividad_Cliente : Form
    {
        string Operacion = null;  // Operaciones : N = Nuevo / M = Modificar E = Eliminar
        public frmActividad_Cliente()
        {
            InitializeComponent();
        }

        void FormatoDgv()
        {
            
            var dgv = dgvListado;

            dgv.MultiSelect = false;
            dgv.ReadOnly = true;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            //---------Centrar titulo de cabecera --------------/
            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //-- No se hace visible la primera columna del datagrid /
            dgv.RowHeadersVisible = false;
            //---No premite cambiar el tamaño a la columna/
            dgv.AllowUserToResizeColumns = false;
            dgv.AllowUserToResizeRows = false;
            //---------------Tipo de fuente y tamaño-----/
            dgv.DefaultCellStyle.Font = new Font("Tahoma", 10);
            //----------Alterna colores en el grid -------/
            dgv.RowsDefaultCellStyle.BackColor = Color.LightBlue;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
            //---Pintado de color a la cabecera del datagrid ---/
            DataGridViewCellStyle style = this.dgvListado.ColumnHeadersDefaultCellStyle;
            style.BackColor = Color.Honeydew;
            style.ForeColor = Color.Gray;


            //dgv.Columns.Clear();
            dgv.ColumnCount = 7;
            // Setear Cabecera de Columna 

            dgv.Columns[0].Name = "IDE";
            dgv.Columns[1].Name = "CODIGO";
            dgv.Columns[2].Name = "NOMBRE";
            dgv.Columns[3].Name = "ESTADO";
            dgv.Columns[4].Name = "FECHAINAC";
            dgv.Columns[5].Name = "CREACION";
            dgv.Columns[6].Name = "VECES";


            dgv.Columns[0].Width = 40;
            dgv.Columns[0].HeaderText = "ID";
            dgv.Columns[0].DataPropertyName = "ACTI_CLIE_IDE";

            dgv.Columns[1].Width = 80;
            dgv.Columns[1].HeaderText = "Codigo";
            dgv.Columns[1].DataPropertyName = "ACTI_CLIE_CODIGO";


            dgv.Columns[2].Width = 340;
            dgv.Columns[2].HeaderText = "Descripción ";
            dgv.Columns[2].DataPropertyName = "ACTI_CLIE_NOMBRE";

            dgv.Columns[3].Width = 80;
            dgv.Columns[3].HeaderText = "Estado";
            dgv.Columns[3].DataPropertyName = "ACTI_CLIE_ESTADO";


            // Columnas que no Deben Verse

            dgv.Columns[4].DataPropertyName = "ACTI_CLIE_FECHAINAC";
            dgv.Columns[4].Visible = false;
            dgv.Columns[5].DataPropertyName = "CREACION";
            dgv.Columns[5].Visible = false;
            dgv.Columns[6].DataPropertyName = "VECES";
            dgv.Columns[6].Visible = false;
        }

        private void llenar_CboEstado()
        {
            cboEstado.Items.Add("<Seleccionar>");
            cboEstado.Items.Add("Activo");
            cboEstado.Items.Add("Inactivo");
            cboEstado.SelectedIndex = 0;
        }
        private void Mostrar_dgv(string filtro)
        {
            DataTable TEMP = new DataTable();
            ENResultOperation R = ClsActividad_ClienteBC.Listar(filtro);
            if (R.Proceder) dgvListado.DataSource = (DataTable)R.Valor;
            TEMP = (DataTable)R.Valor;

        }

        private void Inicializa_campos()
        {
            txtIde.Text = "0";
            txtCodigo.Text = string.Empty;
            txtNombre.Text = string.Empty;
            cboEstado.SelectedIndex = 1;  // Activo
            txtVeces.Text = "0";
        }

        private void Estado_Botones(bool flag)
        {
            btnNuevo.Enabled = flag;
            btnModifica.Enabled = flag;
            btnElimina.Enabled = flag;
            btnCancela.Enabled = !flag;
            btnGraba.Enabled = !flag;
            btnSalir.Enabled = flag;
        }

        private void frmActividad_Cliente_Load(object sender, EventArgs e)
        {
            FormatoDgv();
            Mostrar_dgv("");
            llenar_CboEstado();
            Estado_Botones(true);
            Deshabilitar_Campos(true);
        }
         private void Mostrar_Datos()
        {
            if (dgvListado.CurrentRow != null)
            {
                txtIde.Text = Convert.ToString(this.dgvListado.CurrentRow.Cells["IDE"].Value);
                txtCodigo.Text = Convert.ToString(this.dgvListado.CurrentRow.Cells["CODIGO"].Value);
                txtNombre.Text = Convert.ToString(this.dgvListado.CurrentRow.Cells["NOMBRE"].Value);
                cboEstado.Text = Convert.ToString(this.dgvListado.CurrentRow.Cells["ESTADO"].Value);
                txtVeces.Text = Convert.ToString(this.dgvListado.CurrentRow.Cells["VECES"].Value);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Estado_Botones(false);
            Inicializa_campos();
            Operacion = "N";
            Deshabilitar_Campos(false);
            txtCodigo.Focus();
        }

        private void btnModifica_Click(object sender, EventArgs e)
        {
            Estado_Botones(false);
            Operacion = "M";
            Deshabilitar_Campos(false);
            txtNombre.Focus();

        }

        private void btnElimina_Click(object sender, EventArgs e)
        {
            Estado_Botones(false);
            Operacion = "E";
            Deshabilitar_Campos(false);
            btnGraba.Text = "Eliminar";
            /*
            if (MessageBox.Show("Seguro de Eliminar Tipo?", "Eliminacion de Tipo de Cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2, MessageBoxOptions.DefaultDesktopOnly) == DialogResult.Yes)
            {
                Procesar_Operacion();
            }
            */
        }

        private void btnCancela_Click(object sender, EventArgs e)
        {
            Estado_Botones(true);
            Deshabilitar_Campos(true);
            Mostrar_Datos();
        }

        private void btnGraba_Click(object sender, EventArgs e)
        {
            if (Valida_Campos())
            {
                Procesar_Operacion();
            }
        }

        private Boolean Valida_Campos()
        {
            if (string.IsNullOrEmpty(txtCodigo.Text))
            {
                MessageBox.Show("Codigo de Actividad No Ingresado");
                return false;
            }
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("Nombre de la La Actividad No Ingresado");
                return false;
            }
            return true;
        }

        private void Procesar_Operacion()
        {
            ClsActividad_ClienteBE TipoBE = new ClsActividad_ClienteBE();
            TipoBE.Acti_clie_ide = Convert.ToInt32(txtIde.Text);
            TipoBE.Acti_clie_codigo = txtCodigo.Text;
            TipoBE.Acti_clie_nombre = txtNombre.Text;
            TipoBE.Acti_clie_estado = cboEstado.Text;
            TipoBE.Acti_clie_fechainac = Convert.ToDateTime("01-01-1900");
            TipoBE.Veces = Convert.ToInt32(txtVeces.Text);
            TipoBE.Usuario = "ADMIN";
            TipoBE.Creacion = Convert.ToDateTime(DateTime.Today);

            TipoBE.Nombre_error = "";

            switch (Operacion)
            {
                case "N": ClsActividad_ClienteBC.Crear(TipoBE);
                    break;
                case "M": ClsActividad_ClienteBC.Actualizar(TipoBE);
                    break;
                case "E": ClsActividad_ClienteBC.Eliminar(TipoBE);
                    break;
            }

            Estado_Botones(true);
            Deshabilitar_Campos(true);
            Mostrar_dgv("");
            Mostrar_Datos();
            btnGraba.Text = "Grabar";
        }

        private void Deshabilitar_Campos(bool Flag)
        {
            txtIde.ReadOnly = true;
            txtNombre.ReadOnly = Flag;
            cboEstado.Enabled = !Flag;
        }

        private void dgvListado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           // Mostrar_Datos();
        }

        private void dgvListado_CurrentCellChanged(object sender, EventArgs e)
        {
            Mostrar_Datos();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtIde_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cboEstado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtVeces_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

   
    }
}
