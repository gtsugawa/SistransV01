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
    public partial class frmUnidad_Medida : Form
    {
        string Operacion = null;  // Operaciones : N = Nuevo / M = Modificar E = Eliminar
        string Mens_Error = "";
        Boolean Flg_Retorno = true;
        public frmUnidad_Medida()
        {
            InitializeComponent();
        }


        private void frmUnidad_Medida_Load(object sender, EventArgs e)
        {
            FormatoDgv();
            Mostrar_dgv("");
            Cargar_ComboBox();
            Estado_Botones(true);
            Habilita_Campos(false);
        }

        private void Mostrar_dgv(string filtro)
        {
            ENResultOperation R = ClsUnidad_MedidaBC.Listar(filtro);
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
            dgv.ColumnCount = 12;
            // Setear Cabecera de Columna 

            dgv.Columns[0].Name = "IDE";
            dgv.Columns[1].Name = "NOMBRE";
            dgv.Columns[2].Name = "CODIGO1";
            dgv.Columns[3].Name = "ABREVIADO";
            dgv.Columns[4].Name = "SUNAT";
            dgv.Columns[5].Name = "FACTOR";
            dgv.Columns[6].Name = "CANTIDAD";
            dgv.Columns[7].Name = "ESTADO";
            dgv.Columns[8].Name = "INACTIVA";
            dgv.Columns[9].Name = "CREACION";
            dgv.Columns[10].Name = "VECES";
            dgv.Columns[11].Name = "CODIGO";

            dgv.Columns[0].Width = 45;
            dgv.Columns[0].HeaderText = "ID";
            dgv.Columns[0].DataPropertyName = "UNID_MEDI_IDE";

            dgv.Columns[1].Width = 160;
            dgv.Columns[1].HeaderText = "Descripcion";
            dgv.Columns[1].DataPropertyName = "UNID_MEDI_NOMBRE";

            dgv.Columns[2].Width = 90;
            dgv.Columns[2].HeaderText = "Codigo";
            dgv.Columns[2].DataPropertyName = "UNID_MEDI_CODIGO";

            dgv.Columns[3].Width = 90;
            dgv.Columns[3].HeaderText = "Abreviado";
            dgv.Columns[3].DataPropertyName = "UNID_MEDI_ABREVIADO";

            dgv.Columns[4].Width = 90;
            dgv.Columns[4].HeaderText = "Nombre Sunat";
            dgv.Columns[4].DataPropertyName = "UNID_MEDI_CODIGO_SUNAT";

            dgv.Columns[5].DataPropertyName = "UNID_MEDI_FACTOR";
            dgv.Columns[5].Visible = false;

            dgv.Columns[6].DataPropertyName = "UNID_MEDI_CANTIDAD";
            dgv.Columns[6].Visible = false;

            dgv.Columns[7].Width = 65;
            dgv.Columns[7].HeaderText = "Estado";
            dgv.Columns[7].DataPropertyName = "UNID_MEDI_ESTADO";

            // Columnas que no Deben Verse

            dgv.Columns[8].DataPropertyName = "UNID_MEDI_FECHAINAC";
            dgv.Columns[8].HeaderText = "F.Inactivo";
            dgv.Columns[8].Visible = false;

            dgv.Columns[9].DataPropertyName = "CREACION";
            dgv.Columns[9].HeaderText = "F.Creacion";
            dgv.Columns[9].Visible = false;

            dgv.Columns[10].DataPropertyName = "VECES";
            dgv.Columns[10].HeaderText = "Veces";
            dgv.Columns[10].Visible = false;

            dgv.Columns[11].DataPropertyName = "CODIGO";
            dgv.Columns[11].HeaderText = "Codigo";
            dgv.Columns[11].Visible = false;
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
            txtCodSunat.Text = "";
            txtAbreviado.Text = "";
            txtVeces.Text = "0";
            cboEstado.Text = "Activo";
            txtCodigo1.Text = "";
            txtCodigo.Text = "";
        }

        private void Habilita_Campos(bool Flag)
        {
            txtIde.ReadOnly = true;
            txtNombre.Enabled = Flag;
            txtCodSunat.Enabled = Flag;
            txtAbreviado.Enabled = Flag;
            cboEstado.Enabled = Flag;
        }

        private void Llenar_Campos()
        {
            if (dgvListado.CurrentRow != null)
            {
                txtIde.Text = Convert.ToString(this.dgvListado.CurrentRow.Cells["IDE"].Value);
                txtNombre.Text = Convert.ToString(this.dgvListado.CurrentRow.Cells["NOMBRE"].Value);
                txtCodigo1.Text = Convert.ToString(this.dgvListado.CurrentRow.Cells["CODIGO1"].Value);
                txtCodSunat.Text = Convert.ToString(this.dgvListado.CurrentRow.Cells["SUNAT"].Value);
                txtAbreviado.Text = Convert.ToString(this.dgvListado.CurrentRow.Cells["ABREVIADO"].Value);
                txtVeces.Text = Convert.ToString(this.dgvListado.CurrentRow.Cells["VECES"].Value);
                cboEstado.Text = Convert.ToString(this.dgvListado.CurrentRow.Cells["ESTADO"].Value);
                txtCodigo.Text = Convert.ToString(this.dgvListado.CurrentRow.Cells["CODIGO"].Value);
            }
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Operacion = "N";
            Estado_Botones(false);
            Inicializa_campos();
            Habilita_Campos(true);
            txtCodigo1.Focus();
        }

        private void btnModifica_Click(object sender, EventArgs e)
        {
            Operacion = "M";
            Estado_Botones(false);
            Habilita_Campos(true);
            txtCodigo1.Focus();
        }

        private void btnElimina_Click(object sender, EventArgs e)
        {
            Operacion = "E";
            Estado_Botones(false);
            btnGraba.Text = "Elimina";
            btnGraba.Focus();
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

        private void dgvListado_CurrentCellChanged(object sender, EventArgs e)
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
            ClsUnidad_MedidaBE TipoBE = new ClsUnidad_MedidaBE();
            TipoBE.Unid_medi_ide = Convert.ToInt32(txtIde.Text);
            TipoBE.Unid_medi_nombre = txtNombre.Text;
            TipoBE.Unid_medi_codigo = txtCodigo1.Text;
            TipoBE.Unid_medi_factor = 0;
            TipoBE.Unid_medi_cantidad = 0;
            TipoBE.Unid_medi_codigo_sunat = txtCodSunat.Text;
            TipoBE.Unid_medi_abreviado = txtAbreviado.Text;
            TipoBE.Unid_medi_estado = cboEstado.Text;
            TipoBE.Unid_medi_fechainac = Convert.ToDateTime("01-01-1900");
            TipoBE.Veces = Convert.ToInt32(txtVeces.Text);
            TipoBE.Usuario = "ADMIN";
            TipoBE.Creacion = Convert.ToDateTime(DateTime.Today);
            TipoBE.Codigo = txtCodigo.Text;

            TipoBE.Nombre_error = "";

            switch (Operacion)
            {
                case "N":
                    {
                        ENResultOperation R = ClsUnidad_MedidaBC.Crear(TipoBE);
                        if (!R.Proceder) MessageBox.Show("Error al Insertar Unidad de Medida : " + R.Sms);
                        break;
                    }
                case "M":
                    {
                        ENResultOperation R = ClsUnidad_MedidaBC.Actualizar(TipoBE);
                        if (!R.Proceder) MessageBox.Show("Error al Modificar Unidad de Medida : " + R.Sms);
                        break;
                    }
                case "E":
                    {
                        ENResultOperation R = ClsUnidad_MedidaBC.Eliminar(TipoBE);
                        if (!R.Proceder) MessageBox.Show("Error al Modificar Unidad de Medida : " + R.Sms);
                        break;
                    }
            }

            Estado_Botones(true);
            Habilita_Campos(false);
            Mostrar_dgv("");
            Llenar_Campos();
        }
    }
}
