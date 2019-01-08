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
        
    public partial class frmVendedor : Form
    {
        string Operacion = null;  // Operaciones : N = Nuevo / M = Modificar E = Eliminar
        public frmVendedor()
        {
            InitializeComponent();
        }

        private void Vendedor_Load(object sender, EventArgs e)
        {
            FormatoDgv();
            Mostrar_dgv("");
            llenar_CboEstado();
            Estado_Botones(true);
            Habilita_Campos(false);
            Llenar_cboLocalidad();
            Llenar_cboTipoDoc();
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
            dgv.RowsDefaultCellStyle.BackColor = Color.LightBlue;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
            /*---Pintado de color a la cabecera del datagrid ---*/
            DataGridViewCellStyle style = this.dgvListado.ColumnHeadersDefaultCellStyle;
            style.BackColor = Color.Honeydew;
            style.ForeColor = Color.Gray;


            //dgv.Columns.Clear();
            dgv.ColumnCount = 20;
            // Setear Cabecera de Columna 

            dgv.Columns[0].Name = "IDE";
            dgv.Columns[1].Name = "CODIGO";
            dgv.Columns[2].Name = "RAZON_SOCIAL";
            dgv.Columns[3].Name = "EMPRESA";
            dgv.Columns[4].Name = "FECHA_NACIMIENTO";
            dgv.Columns[5].Name = "DIRECCION";
            dgv.Columns[6].Name = "LOCA_IDE";
            dgv.Columns[7].Name = "TELEFONO1";
            dgv.Columns[8].Name = "TELEFONO2";
            dgv.Columns[9].Name = "FAX";
            dgv.Columns[10].Name = "DOCU_IDEN";
            dgv.Columns[11].Name = "DOCUMENTO";
            dgv.Columns[12].Name = "CORREO";
            dgv.Columns[13].Name = "PATERNO";
            dgv.Columns[14].Name = "MATERNO";
            dgv.Columns[15].Name = "NOMBRE";
            dgv.Columns[16].Name = "ESTADO";
            dgv.Columns[17].Name = "FECHAINAC";
            dgv.Columns[18].Name = "CREACION";
            dgv.Columns[19].Name = "VECES";
           

            dgv.Columns[0].Width = 45;
            dgv.Columns[0].HeaderText = "ID";
            dgv.Columns[0].DataPropertyName = "VEND_IDE";

            dgv.Columns[1].Width = 100;
            dgv.Columns[1].HeaderText = "Codigo";
            dgv.Columns[1].DataPropertyName = "VEND_CODIGO";

            dgv.Columns[2].Width = 200;
            dgv.Columns[2].HeaderText = "Razon Social";
            dgv.Columns[2].DataPropertyName = "Vend_Razon_Social";

            dgv.Columns[3].Width = 70;
            dgv.Columns[3].HeaderText = "Empresa";
            dgv.Columns[3].DataPropertyName = "Vend_empresa";

            dgv.Columns[4].Width = 140;
            dgv.Columns[4].HeaderText = "Fecha Nacimiento";
            dgv.Columns[4].DataPropertyName = "Vend_Fecha_Nacimiento";
            dgv.Columns[4].Visible = false;

            dgv.Columns[5].Width = 243;
            dgv.Columns[5].HeaderText = "Direccion";
            dgv.Columns[5].DataPropertyName = "Vend_Direccion";
            dgv.Columns[5].Visible = true;

            dgv.Columns[6].Width = 40;
            dgv.Columns[6].HeaderText = "Localidad";
            dgv.Columns[6].DataPropertyName = "Loca_Ide";
            dgv.Columns[6].Visible = false;

            dgv.Columns[7].Width = 140;
            dgv.Columns[7].HeaderText = "Telefono 1";
            dgv.Columns[7].DataPropertyName = "Vend_telefono1";
            dgv.Columns[7].Visible = false;

            // Columnas que no Deben Verse
            dgv.Columns[8].DataPropertyName = "Vend_Telefono2";
            dgv.Columns[8].Visible = false;
            dgv.Columns[9].DataPropertyName = "Vend_fax";
            dgv.Columns[9].Visible = false;
            dgv.Columns[10].DataPropertyName = "Docu_Iden_Ide";
            dgv.Columns[10].Visible = false;
            dgv.Columns[11].DataPropertyName = "Vend_documento";
            dgv.Columns[11].Visible = false;
            dgv.Columns[12].DataPropertyName = "Vend_correo";
            dgv.Columns[12].Visible = false;
            dgv.Columns[13].DataPropertyName = "Vend_paterno";
            dgv.Columns[13].Visible = false;
            dgv.Columns[14].DataPropertyName = "Vend_materno";
            dgv.Columns[14].Visible = false;
            dgv.Columns[15].DataPropertyName = "Vend_nombre";
            dgv.Columns[15].Visible = false;
            dgv.Columns[16].DataPropertyName = "Vend_estado";
            dgv.Columns[16].Visible = false;

            dgv.Columns[17].DataPropertyName = "Vend_FECHAINAC";
            dgv.Columns[17].Visible = false;
            dgv.Columns[18].DataPropertyName = "CREACION";
            dgv.Columns[18].Visible = false;
            dgv.Columns[19].DataPropertyName = "VECES";
            dgv.Columns[19].Visible = false;
        }

        private void llenar_CboEstado()
        {
            cboEstado.Items.Clear();
            cboEstado.Items.Add("Activo");
            cboEstado.Items.Add("Inactivo");
            cboEstado.SelectedIndex = 0;
        }

        private void Llenar_cboLocalidad()
        {
            ENResultOperation R = ClsLocalidadBC.Listar("");
            cboLocalidad.DataSource = (DataTable)R.Valor;
            cboLocalidad.DisplayMember = "LOCA_NOMBRE";
            cboLocalidad.ValueMember = "LOCA_IDE";
            cboLocalidad.AutoCompleteMode = AutoCompleteMode.Suggest;
            cboLocalidad.AutoCompleteSource = AutoCompleteSource.ListItems;
            
        }
        private void Llenar_cboTipoDoc()
        {
            ENResultOperation R = ClsTipo_Documento_IdentidadBC.Listar("");
            cboTipoDoc.DataSource = (DataTable)R.Valor;
            cboTipoDoc.DisplayMember = "DOCU_IDEN_NOMBRE";
            cboTipoDoc.ValueMember = "DOCU_IDEN_IDE";
            cboTipoDoc.AutoCompleteMode = AutoCompleteMode.Suggest;
            cboTipoDoc.AutoCompleteSource = AutoCompleteSource.ListItems;

        }
        private void Mostrar_dgv(string filtro)
        {
            DataTable TEMP = new DataTable();
            ENResultOperation R = ClsVendedorBC.Listar(filtro);
            if (R.Proceder)
            {
                dgvListado.DataSource = (DataTable)R.Valor;
                TEMP = (DataTable)R.Valor;
            }
            else
            {
                MessageBox.Show("Error al Obtener Valores : " + R.Sms);
            }
            Habilita_Campos(false);

        }

        private void Habilita_Campos(Boolean Flag)
        {
            txtIde.Enabled = Flag;
            txtCodigo.Enabled = Flag;
            txtRazonSocial.Enabled = Flag;
            txtCorreo.Enabled = Flag;
            txtDireccion.Enabled = Flag;
            txtDocumento.Enabled = Flag;
            dtpFechaNacimiento.Enabled = Flag;
            txtLocalidad.Enabled = Flag;
            txtVeces.Enabled = Flag;
            cboEmpresa.Enabled = Flag;
            cboEstado.Enabled = Flag;
            cboLocalidad.Enabled = Flag;
            cboTipoDoc.Enabled = Flag;
            cboEstado.Enabled = Flag;
            txtMaterno.Enabled = Flag;
            txtPaterno.Enabled = Flag;
            txtNombre.Enabled = Flag;
        }
        private void Inicializa_campos()
        {
            txtIde.Text = "0";
            txtCodigo.Text = "";
            txtRazonSocial.Text = "";
            txtCorreo.Text = "";
            txtDireccion.Text = "";
            txtDocumento.Text = "";
            dtpFechaNacimiento.Text = DateTime.Now.ToString();
            txtLocalidad.Text = "";
            txtMaterno.Text = "";
            txtPaterno.Text = "";
            txtNombre.Text = "";
            txtVeces.Text = "0";
            cboEmpresa.Text = "No";
            cboEstado.Text = "Activo";
            cboLocalidad.SelectedIndex = cboLocalidad.FindStringExact("LIMA");
            cboTipoDoc.SelectedIndex = 0;
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
                cboEmpresa.Text = Convert.ToString(this.dgvListado.CurrentRow.Cells["EMPRESA"].Value);
                txtCodigo.Text = Convert.ToString(this.dgvListado.CurrentRow.Cells["CODIGO"].Value);
                txtRazonSocial.Text = Convert.ToString(this.dgvListado.CurrentRow.Cells["RAZON_SOCIAL"].Value);
                txtCorreo.Text = Convert.ToString(this.dgvListado.CurrentRow.Cells["CORREO"].Value);
                txtDireccion.Text = Convert.ToString(this.dgvListado.CurrentRow.Cells["DIRECCION"].Value);
                txtDocumento.Text = Convert.ToString(this.dgvListado.CurrentRow.Cells["DOCUMENTO"].Value);
                dtpFechaNacimiento.Text = Convert.ToString(this.dgvListado.CurrentRow.Cells["FECHA_NACIMIENTO"].Value.ToString());
                cboLocalidad.SelectedValue = Convert.ToInt32(this.dgvListado.CurrentRow.Cells["LOCA_IDE"].Value);
                txtMaterno.Text = Convert.ToString(this.dgvListado.CurrentRow.Cells["MATERNO"].Value);
                txtPaterno.Text = Convert.ToString(this.dgvListado.CurrentRow.Cells["PATERNO"].Value);
                txtNombre.Text = Convert.ToString(this.dgvListado.CurrentRow.Cells["NOMBRE"].Value);
                txtTelefono1.Text = Convert.ToString(this.dgvListado.CurrentRow.Cells["TELEFONO1"].Value);
                txtTelefono2.Text = Convert.ToString(this.dgvListado.CurrentRow.Cells["TELEFONO2"].Value);
                txtFax.Text = Convert.ToString(this.dgvListado.CurrentRow.Cells["FAX"].Value);
                cboTipoDoc.SelectedValue = Convert.ToInt32(this.dgvListado.CurrentRow.Cells["DOCU_IDEN"].Value);
                cboEstado.Text = Convert.ToString(this.dgvListado.CurrentRow.Cells["ESTADO"].Value);
                txtVeces.Text = Convert.ToString(this.dgvListado.CurrentRow.Cells["VECES"].Value);
                txtLocalidad.Text = Convert.ToString(this.dgvListado.CurrentRow.Cells["LOCA_IDE"].Value);
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
            txtCodigo.Focus();
        }

        private void btnModifica_Click(object sender, EventArgs e)
        {
            Estado_Botones(false);
            Operacion = "M";
            Habilita_Campos(true);
            txtCodigo.Focus();

        }

        private void btnElimina_Click(object sender, EventArgs e)
        {
            Estado_Botones(false);
            btnGraba.Text = "Eliminar";
            Operacion = "E";
        }

        private void btnCancela_Click(object sender, EventArgs e)
        {
            Estado_Botones(true);
            Habilita_Campos(false);
        }

        private void btnGraba_Click(object sender, EventArgs e)
        {

            if (!Verifica_Campos(txtCodigo.Text))
            {
                MessageBox.Show("Campo de Codigo no puede estar sin Valor");
                return;
            }
            if (!Verifica_Campos(txtRazonSocial.Text))
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
            ClsVendedorBE TipoBE = new ClsVendedorBE();
            TipoBE.Vend_ide = Convert.ToInt32(txtIde.Text);
            TipoBE.Vend_codigo = txtCodigo.Text;
            TipoBE.Vend_paterno = txtPaterno.Text;
            TipoBE.Vend_materno = txtMaterno.Text;
            TipoBE.Vend_nombre = txtNombre.Text;
            TipoBE.Vend_razon_social = txtRazonSocial.Text;
            TipoBE.Vend_correo = txtCorreo.Text;
            TipoBE.Vend_direccion = txtDireccion.Text;
            TipoBE.Vend_documento = txtDocumento.Text;
            TipoBE.Vend_empresa = cboEmpresa.Text;
            TipoBE.Vend_estado = cboEstado.Text;
            TipoBE.Vend_fax = txtFax.Text;
            TipoBE.Vend_telefono1 = txtTelefono1.Text;
            TipoBE.Vend_telefono2 = txtTelefono2.Text;
            TipoBE.Vend_fax = txtFax.Text;
            TipoBE.Vend_fecha_nacimiento = Convert.ToDateTime(dtpFechaNacimiento.Text);
            TipoBE.Loca_ide = Convert.ToInt32(cboLocalidad.SelectedValue.ToString());
            TipoBE.Docu_iden_ide = Convert.ToInt32(cboTipoDoc.SelectedValue.ToString());

            TipoBE.Vend_estado = cboEstado.Text;
            TipoBE.Vend_fechainac = Convert.ToDateTime("01-01-1900");
            TipoBE.Veces = Convert.ToInt32(txtVeces.Text);
            TipoBE.Usuario = "ADMIN";
            TipoBE.Creacion = Convert.ToDateTime(DateTime.Today);
            TipoBE.Nombre_error = "";
            
            switch (Operacion)
            {
                case "N":
                    {
                        ENResultOperation R = ClsVendedorBC.Crear(TipoBE);
                        if (!R.Proceder) MessageBox.Show("Error al Insertar Vendedor : " + R.Sms);
                        break;
                    }
                case "M":
                    {
                        ENResultOperation R = ClsVendedorBC.Actualizar(TipoBE);
                        if (!R.Proceder) MessageBox.Show("Error al Modificar Vendedor : " + R.Sms);
                        break;
                    }
                case "E":
                    {
                        ENResultOperation R = ClsVendedorBC.Eliminar(TipoBE);
                        if (!R.Proceder) MessageBox.Show("Error al Eliminar Vendedor : " + R.Sms);
                        break;
                    }
            }
            Estado_Botones(true);
            Habilita_Campos(false);
            Mostrar_dgv("");
            Mostrar_Datos();
            btnGraba.Text = "Grabar";
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

        private void txtRazonSocial_Enter(object sender, EventArgs e)
        {
            txtRazonSocial.Text = txtPaterno.Text + ' ' + txtMaterno.Text + ' ' + txtNombre.Text;
        }

        private void cboLocalidad_SelectedValueChanged(object sender, EventArgs e)
        {
            txtLocalidad.Text = cboLocalidad.SelectedValue.ToString();
        }

        private void cboLocalidad_Validated(object sender, EventArgs e)
        {
            txtLocalidad.Text = cboLocalidad.SelectedValue.ToString();
        }

        private void cboEmpresa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboEmpresa.Text=="Si")
            {
                txtPaterno.Text = string.Empty;
                txtMaterno.Text = string.Empty;
                txtNombre.Text = string.Empty;
            }
        }


  }
}
