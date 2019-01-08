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
    public partial class frmPais : Form
    {
        string Operacion = null;  // Operaciones : N = Nuevo / M = Modificar E = Eliminar
        string Mens_Error = "";
        Boolean Flg_Retorno = true;
        public frmPais()
        {
            InitializeComponent();
        }

        private void frmPais_Load(object sender, EventArgs e)
        {
            FormatoDgv();
            Mostrar_dgv("");
            llenar_CboEstado();
            Estado_Botones(true);
            Habilita_Campos(false);
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
            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgv.RowHeadersVisible = false;

            dgv.AllowUserToResizeColumns = false;
            dgv.AllowUserToResizeRows = false;

            dgv.DefaultCellStyle.Font = new Font("Tahoma", 10);

            dgv.RowsDefaultCellStyle.BackColor = Color.LightBlue;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.White;

            DataGridViewCellStyle style = this.dgvListado.ColumnHeadersDefaultCellStyle;
            style.BackColor = Color.Honeydew;
            style.ForeColor = Color.Gray;


            //dgv.Columns.Clear();
            dgv.ColumnCount = 6;
            // Setear Cabecera de Columna 

            dgv.Columns[0].Name = "IDE";
            dgv.Columns[1].Name = "NOMBRE";
            dgv.Columns[2].Name = "ESTADO";
            dgv.Columns[3].Name = "FECHAINAC";
            dgv.Columns[4].Name = "CREACION";
            dgv.Columns[5].Name = "VECES";


            dgv.Columns[0].Width = 45;
            dgv.Columns[0].HeaderText = "ID";
            dgv.Columns[0].DataPropertyName = "PAIS_IDE";

            dgv.Columns[1].Width = 340;
            dgv.Columns[1].HeaderText = "Descripción ";
            dgv.Columns[1].DataPropertyName = "PAIS_NOMBRE";

            dgv.Columns[2].Width = 85;
            dgv.Columns[2].HeaderText = "Estado";
            dgv.Columns[2].DataPropertyName = "PAIS_ESTADO";

            // Columnas que no Deben Verse

            dgv.Columns[3].DataPropertyName = "PAIS_FECHAINAC";
            dgv.Columns[3].HeaderText = "F.Inactivo";
            dgv.Columns[3].Visible = false;
            dgv.Columns[4].DataPropertyName = "CREACION";
            dgv.Columns[4].HeaderText = "F.Creacion";
            dgv.Columns[4].Visible = false;
            dgv.Columns[5].DataPropertyName = "VECES";
            dgv.Columns[5].HeaderText = "Veces";
            dgv.Columns[5].Visible = false;

        }

        private void llenar_CboEstado()
        {
            cboEstado.Items.Clear();
            cboEstado.Items.Add("Activo");
            cboEstado.Items.Add("Inactivo");
            cboEstado.SelectedIndex = 0;
        }
        private void Mostrar_dgv(string filtro)
        {
            DataTable TEMP = new DataTable();
            ENResultOperation R = ClsPaisBC.ListarTodos(filtro);
            if (R.Proceder)
            {
                dgvListado.DataSource = (DataTable)R.Valor;
                TEMP = (DataTable)R.Valor;
            }
            else
            {
                MessageBox.Show("Error al Obtener Valores : " + R.Sms);
            }

        }

        private void Inicializa_campos()
        {
            txtIde.Text = "0";
            txtNombre.Text = "";
            txtVeces.Text = "0";
            cboEstado.SelectedIndex = 0;  // Activo
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



        private void Mostrar_Datos()
        {
            if (dgvListado.CurrentRow != null)
            {
                txtIde.Text = Convert.ToString(this.dgvListado.CurrentRow.Cells["IDE"].Value);
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
            Habilita_Campos(true);
            txtNombre.Focus();
        }

        private void btnModifica_Click(object sender, EventArgs e)
        {
            Estado_Botones(false);
            Operacion = "M";
            Habilita_Campos(true);
            txtNombre.Focus();

        }

        private void btnElimina_Click(object sender, EventArgs e)
        {
            Estado_Botones(false);
            Operacion = "E";
            btnGraba.Text = "Eliminar";
        }

        private void btnCancela_Click(object sender, EventArgs e)
        {
            Estado_Botones(true);
            Habilita_Campos(false);
            Mostrar_Datos();
        }

        private void btnGraba_Click(object sender, EventArgs e)
        {

            if (!Verifica_Campos(txtNombre.Text))
            {
                MessageBox.Show("Campo de Nombre no puede estar sin Valor");
                return;
            }
            Procesar_Operacion();
        }

        private Boolean Verifica_Campos(string campo)
        {
            if (String.IsNullOrWhiteSpace(campo)) return false;
            return true;
        }


        private void Procesar_Operacion()
        {
            ClsPaisBE TipoBE = new ClsPaisBE();
            TipoBE.Pais_ide = Convert.ToInt32(txtIde.Text);
            TipoBE.Pais_nombre = txtNombre.Text;
            TipoBE.Pais_estado = cboEstado.Text;
            TipoBE.Pais_fechainac = Convert.ToDateTime("01-01-1900");
            TipoBE.Veces = Convert.ToInt32(txtVeces.Text);
            TipoBE.Usuario = "ADMIN";
            TipoBE.Creacion = Convert.ToDateTime(DateTime.Today);

            TipoBE.Nombre_error = "";

            switch (Operacion)
            {
                case "N":
                    {
                        ENResultOperation R = ClsPaisBC.Crear(TipoBE);
                        if (!R.Proceder) MessageBox.Show("Error al Insertar Pais : " + R.Sms);
                        break;
                    }
                case "M":
                    {
                        ENResultOperation R = ClsPaisBC.Actualizar(TipoBE);
                        if (!R.Proceder) MessageBox.Show("Error al Modificar Pais : " + R.Sms);
                        break;
                    }
                case "E":
                    {
                        ENResultOperation R = ClsPaisBC.Eliminar(TipoBE);
                        if (!R.Proceder) MessageBox.Show("Error al Eliminar Pais : " + R.Sms);
                        break;
                    }
            }
            Estado_Botones(true);
            Habilita_Campos(false);
            Mostrar_dgv("");
            Mostrar_Datos();
            btnGraba.Text = "Grabar";
        }

        private void Habilita_Campos(bool Flag)
        {
            txtIde.ReadOnly = true;
            txtNombre.Enabled = Flag;
            cboEstado.Enabled = Flag;
        }


        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            //MessageBox.Show("Valor del Texto : " + txtNombre.Text);
        }

        private void dgvListado_CurrentCellChanged(object sender, EventArgs e)
        {
            Mostrar_Datos();
        }

        private void txtVeces_TextChanged(object sender, EventArgs e)
        {

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

        private void txtNombre_TextChanged_1(object sender, EventArgs e)
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
