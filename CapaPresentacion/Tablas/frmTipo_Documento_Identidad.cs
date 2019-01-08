using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaBC;
using CapaBE;

namespace CapaPresentacion.Tablas
{
    public partial class frmTipo_Documento_Identidad : Form
    {
        string Operacion = null;  // Operaciones : N = Nuevo / M = Modificar E = Eliminar
        string Mens_Error = "";
        Boolean Flg_Retorno = true;
        public frmTipo_Documento_Identidad()
        {
            InitializeComponent();
        }

        private void frmTipo_Documento_Identidad_Load(object sender, EventArgs e)
        {
            FormatoDgv();
            Mostrar_dgv("");
            Cargar_ComboBox();
            Estado_Botones(true);
            Habilita_Campos(false);
        }

        private void Mostrar_dgv(string filtro)
        {
            ENResultOperation R = ClsTipo_Documento_IdentidadBC.Listar(filtro);
            if (R.Proceder)
            {
                dgvListado.DataSource = (DataTable)R.Valor;
            }
            else
            {
                MessageBox.Show("Error al Obtener Valores : " + R.Sms);
            }
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
            dgv.ColumnCount = 8;
            // Setear Cabecera de Columna 

            dgv.Columns[0].Name = "IDE";
            dgv.Columns[1].Name = "NOMBRE";
            dgv.Columns[2].Name = "CODIGO_SUNAT";
            dgv.Columns[3].Name = "ESTADO";
            dgv.Columns[4].Name = "INACTIVA";
            dgv.Columns[5].Name = "CREACION";
            dgv.Columns[6].Name = "VECES";
            dgv.Columns[7].Name = "USUARIO";

            dgv.Columns[0].Width = 60;
            dgv.Columns[0].HeaderText = "ID";
            dgv.Columns[0].DataPropertyName = "DOCU_IDEN_IDE";

            dgv.Columns[1].Width = 260;
            dgv.Columns[1].HeaderText = "Descripcion";
            dgv.Columns[1].DataPropertyName = "DOCU_IDEN_NOMBRE";

            dgv.Columns[2].Width = 100;
            dgv.Columns[2].HeaderText = "Codigo Sunat";
            dgv.Columns[2].DataPropertyName = "DOCU_IDEN_CODIGO_SUNAT";

            dgv.Columns[3].Width = 100;
            dgv.Columns[3].HeaderText = "Estado";
            dgv.Columns[3].DataPropertyName = "DOCU_IDEN_ESTADO";

            // Columnas que no Deben Verse

            dgv.Columns[4].DataPropertyName = "DOCU_IDEN_FECHAINAC";
            dgv.Columns[4].Visible = false;

            dgv.Columns[5].DataPropertyName = "CREACION";
            dgv.Columns[5].Visible = false;

            dgv.Columns[6].DataPropertyName = "VECES";
            dgv.Columns[6].Visible = false;

            dgv.Columns[7].DataPropertyName = "USUARIO";
            dgv.Columns[7].Visible = false;
        }

        private void Cargar_ComboBox()
        {
            cboEstado.Items.Clear();
            cboEstado.Items.Add("Activo");
            cboEstado.Items.Add("Inactivo");
            cboEstado.SelectedIndex = 0;
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

        private void Inicializa_campos()
        {
            txtIde.Text = "0";
            txtNombre.Text = "";
            txtCodigo_Sunat.Text = "";
            txtVeces.Text = "0";
            cboEstado.Text = "Activo";
        }

        private void Habilita_Campos(bool Flag)
        {
            txtIde.ReadOnly = true;
            txtNombre.Enabled = Flag;
            cboEstado.Enabled = Flag;
        }

        private void Llenar_Campos()
        {
            if (dgvListado.CurrentRow != null)
            {
                txtIde.Text = Convert.ToString(this.dgvListado.CurrentRow.Cells["IDE"].Value);
                txtNombre.Text = Convert.ToString(this.dgvListado.CurrentRow.Cells["NOMBRE"].Value);
                txtVeces.Text = Convert.ToString(this.dgvListado.CurrentRow.Cells["VECES"].Value);
                txtCodigo_Sunat.Text = Convert.ToString(this.dgvListado.CurrentRow.Cells["CODIGO_SUNAT"].Value);
                txtFechaInac.Text = Convert.ToString(this.dgvListado.CurrentRow.Cells["INACTIVA"].Value);
                cboEstado.Text = Convert.ToString(this.dgvListado.CurrentRow.Cells["ESTADO"].Value);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Operacion = "N";
            Estado_Botones(false);
            Inicializa_campos();
            Habilita_Campos(true);
            txtNombre.Focus();
        }

        private void btnModifica_Click(object sender, EventArgs e)
        {
            Operacion = "M";
            Estado_Botones(false);
            Habilita_Campos(true);
            txtNombre.Focus();
        }

        private void btnElimina_Click(object sender, EventArgs e)
        {
            Operacion = "E";
            Estado_Botones(false);
            btnGraba.Text = "Eliminar";
        }

        private void btnCancela_Click(object sender, EventArgs e)
        {
            Estado_Botones(true);
            Habilita_Campos(false);
            Llenar_Campos();
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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvListado_CursorChanged(object sender, EventArgs e)
        {
            Llenar_Campos();
        }

        private Boolean Verifica_Campos(string campo)
        {
            if (String.IsNullOrWhiteSpace(campo)) return false;
            return true;
        }

        private void Procesar_Operacion()
        {
            ClsTipo_Documento_IdentidadBE TipoBE = new ClsTipo_Documento_IdentidadBE();
            TipoBE.Docu_iden_ide = Convert.ToInt32(txtIde.Text);
            TipoBE.Docu_iden_nombre = txtNombre.Text;
            TipoBE.Docu_iden_codigo_sunat = txtCodigo_Sunat.Text;
            TipoBE.Docu_iden_estado = cboEstado.Text;
            TipoBE.Docu_iden_fechainac = Convert.ToDateTime("01-01-1900");
            TipoBE.Veces = Convert.ToInt32(txtVeces.Text);
            TipoBE.Usuario = "ADMIN";
            TipoBE.Creacion = Convert.ToDateTime(DateTime.Today);
            TipoBE.Nombre_error = "";

            switch (Operacion)
            {
                case "N":
                    {
                        ENResultOperation R = ClsTipo_Documento_IdentidadBC.Crear(TipoBE);
                        if (!R.Proceder) MessageBox.Show("Error al Insertar Documento de Indentidad : " + R.Sms);
                        break;
                    }
                case "M":
                    {
                        ENResultOperation R = ClsTipo_Documento_IdentidadBC.Actualizar(TipoBE);
                        if (!R.Proceder) MessageBox.Show("Error al Insertar Documento de Indentidad : " + R.Sms);
                        break;
                    }
                case "E":
                    {
                        ENResultOperation R = ClsTipo_Documento_IdentidadBC.Eliminar(TipoBE);
                        if (!R.Proceder) MessageBox.Show("Error al Insertar Documento de Indentidad : " + R.Sms);
                        break;
                    }
            }
            Estado_Botones(true);
            Habilita_Campos(false);
            Mostrar_dgv("");
            Llenar_Campos();
            btnGraba.Text = "Grabar";
        }

        private void dgvListado_CurrentCellChanged(object sender, EventArgs e)
        {
            Llenar_Campos();
        }
    }
}
