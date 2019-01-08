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
    public partial class frmAlmacen : Form
    {
        string Operacion = null;  // Operaciones : N = Nuevo / M = Modificar E = Eliminar
        string Mens_Error = "";
        Boolean Flg_Retorno = true;
        public frmAlmacen()
        {
            InitializeComponent();
        }

        private void frmAlmacen_Load(object sender, EventArgs e)
        {
            FormatoDgv();
            Mostrar_dgv("");
            llenar_CboEstado();
            Estado_Botones(true);
            Habilita_Campos(false);
            llenar_cboLocalidad("");
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
            dgv.ColumnCount = 9;
            // Setear Cabecera de Columna 

            dgv.Columns[0].Name = "IDE";
            dgv.Columns[1].Name = "CODIGO";
            dgv.Columns[2].Name = "NOMBRE";
            dgv.Columns[3].Name = "DIRECCION";
            dgv.Columns[4].Name = "LOCALIDAD";
            dgv.Columns[5].Name = "ESTADO";
            dgv.Columns[6].Name = "INACTIVA";
            dgv.Columns[7].Name = "CREACION";
            dgv.Columns[8].Name = "VECES";


            dgv.Columns[0].Width = 45;
            dgv.Columns[0].HeaderText = "ID";
            dgv.Columns[0].DataPropertyName = "ALMA_IDE";

            dgv.Columns[1].Width = 90;
            dgv.Columns[1].HeaderText = "Codigo";
            dgv.Columns[1].DataPropertyName = "ALMA_CODIGO";

            dgv.Columns[2].Width = 260;
            dgv.Columns[2].HeaderText = "Descripción";
            dgv.Columns[2].DataPropertyName = "ALMA_NOMBRE";

            dgv.Columns[3].Width = 200;
            dgv.Columns[3].HeaderText = "Direccion";
            dgv.Columns[3].DataPropertyName = "ALMA_DIRECCION";

            dgv.Columns[4].Width = 60;
            dgv.Columns[4].HeaderText = "Localidad";
            dgv.Columns[4].DataPropertyName = "LOCA_IDE";

            dgv.Columns[5].Width = 85;
            dgv.Columns[5].HeaderText = "Estado";
            dgv.Columns[5].DataPropertyName = "ALMA_ESTADO";

            // Columnas que no Deben Verse

            dgv.Columns[6].DataPropertyName = "ALMA_FECHAINAC";
            dgv.Columns[6].Visible = false;

            dgv.Columns[7].DataPropertyName = "CREACION";
            dgv.Columns[7].Visible = false;

            dgv.Columns[8].DataPropertyName = "VECES";
            dgv.Columns[8].Visible = false;

        }

        private void llenar_CboEstado()
        {
            cboEstado.Items.Clear();
            cboEstado.Items.Add("Activo");
            cboEstado.Items.Add("Inactivo");
            cboEstado.SelectedIndex = 0;
        }

        private void llenar_cboLocalidad(string filtro)
        {
            
            ENResultOperation R = ClsLocalidadBC.ListarTodos(filtro);
            if (R.Proceder)
            {
                cboLocaIde.DataSource = (DataTable)R.Valor;
                cboLocaIde.DisplayMember = "LOCA_NOMBRE";
                cboLocaIde.ValueMember   = "LOCA_IDE";
                cboLocaIde.AutoCompleteMode = AutoCompleteMode.Suggest;
                cboLocaIde.AutoCompleteSource = AutoCompleteSource.ListItems;
            }
            else
            {
                MessageBox.Show("Error al Obtener Valores : " + R.Sms);
            }
        }
        private void Mostrar_dgv(string filtro)
        {
            DataTable TEMP = new DataTable();
            ENResultOperation R = ClsAlmacenBC.Listar(filtro);
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
            txtIde.Text       = "0";
            txtCodigo.Text    = "";
            txtNombre.Text    = "";
            txtDireccion.Text = "";
            txtLocalidad.Text = "";
            txtVeces.Text = "0";
            cboLocaIde.SelectedIndex = cboLocaIde.FindStringExact("LIMA");
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
                txtCodigo.Text = Convert.ToString(this.dgvListado.CurrentRow.Cells["CODIGO"].Value);
                txtNombre.Text = Convert.ToString(this.dgvListado.CurrentRow.Cells["NOMBRE"].Value);
                txtDireccion.Text = Convert.ToString(this.dgvListado.CurrentRow.Cells["DIRECCION"].Value);
                cboLocaIde.SelectedValue = Convert.ToInt32(this.dgvListado.CurrentRow.Cells["LOCALIDAD"].Value);
                txtLocalidad.Text = Convert.ToString(this.dgvListado.CurrentRow.Cells["LOCALIDAD"].Value);
                cboEstado.Text = Convert.ToString(this.dgvListado.CurrentRow.Cells["ESTADO"].Value);
                txtVeces.Text = Convert.ToString(this.dgvListado.CurrentRow.Cells["VECES"].Value);
            }
        }

        private void Habilita_Campos(bool Flag)
        {
            txtIde.ReadOnly = true;
            txtCodigo.Enabled = Flag;
            txtNombre.Enabled = Flag;
            txtDireccion.Enabled = Flag;
            cboLocaIde.Enabled = Flag;
            txtLocalidad.Enabled = Flag;
            cboEstado.Enabled = Flag;

        }

        private void dgvListado_CurrentCellChanged(object sender, EventArgs e)
        {
            Mostrar_Datos();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Estado_Botones(false);
            Inicializa_campos();
            Operacion = "N";
            Habilita_Campos(true);
            txtCodigo.Focus();
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
            btnGraba.Text = "Elimina";
            Operacion = "E";
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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private Boolean Verifica_Campos(string campo)
        {
            if (String.IsNullOrWhiteSpace(campo)) return false;
            return true;
        }

        private void Procesar_Operacion()
        {
            ClsAlmacenBE TipoBE = new ClsAlmacenBE();
            TipoBE.Alma_ide = Convert.ToInt32(txtIde.Text);
            TipoBE.Alma_codigo = txtCodigo.Text;
            TipoBE.Alma_nombre = txtNombre.Text;
            TipoBE.Alma_venta = "No";
            TipoBE.Alma_direccion = txtDireccion.Text;
            TipoBE.Loca_ide = Convert.ToInt32(txtLocalidad.Text);
            TipoBE.Alma_estado = cboEstado.Text;
            TipoBE.Alma_fechainac = Convert.ToDateTime("01-01-1900");
            TipoBE.Veces = Convert.ToInt32(txtVeces.Text);
            TipoBE.Usuario = "ADMIN";
            TipoBE.Creacion = Convert.ToDateTime(DateTime.Today);

            TipoBE.Nombre_error = "";

            Mens_Error = "";
            Flg_Retorno = true;

            switch (Operacion)
            {
                case "N":
                    {
                        ENResultOperation R = ClsAlmacenBC.Crear(TipoBE);
                        if (!R.Proceder) MessageBox.Show("Error al Insertar Almacen : " + R.Sms);
                        break;
                    }
                case "M":
                    {
                        ENResultOperation R = ClsAlmacenBC.Actualizar(TipoBE);
                        if (!R.Proceder) MessageBox.Show("Error al Modificar Almacen : " + R.Sms);
                        break;
                    }
                case "E":
                    {
                        ENResultOperation R = ClsAlmacenBC.Eliminar(TipoBE);
                        if (!R.Proceder) MessageBox.Show("Error al Eliminar Almacen : " + R.Sms);
                        break;
                    }
            }
            if (!Flg_Retorno)
            {
                MessageBox.Show("Error al Ejecutar Operacion : " + Mens_Error);
            }

            Estado_Botones(true);
            Habilita_Campos(false);
            Mostrar_dgv("");
            Mostrar_Datos();
        }

        private void cboLocaIde_Validated(object sender, EventArgs e)
        {
                if (this.cboLocaIde.SelectedItem != null)
                {
                    string value = this.cboLocaIde.SelectedValue.ToString();
                    txtLocalidad.Text = value;
                                        
                }
        }
    }
}
