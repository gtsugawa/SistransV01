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
using System.Data.SqlClient;
using System.Configuration;

namespace CapaPresentacion.Proveedores
{
    public partial class frmProveedor : Form
    {
        private Int32 nVeces = 0;
        private Int32 nVeces_Contacto = 0;
        string Operacion = null;  // Operaciones : N = Nuevo / M = Modificar E = Eliminar
        string Operacion_Contacto = null;  // Operaciones : N = Nuevo / M = Modificar E = Eliminar
        private SqlConnection Con = null;
        private SqlCommand Cmd;
        private SqlDataReader dr = null;
        string strcon = ConfigurationManager.ConnectionStrings["conex1"].ConnectionString;
        public frmProveedor()
        {
            InitializeComponent();
        }

        private void frmProveedor_Load(object sender, EventArgs e)
        {
            FormatoDgv_Contacto();
            FormatoDgv();
            Mostrar("00");
            Llenar_CboMTipoDoc();
            Llenar_CboMLocalidad();
            Llenar_CboMActividad();
            Llenar_CboMCategoria();
            Llenar_CboMTipoProveedor();
            Llenar_CboMPlanCuenta();
            Llenar_CboMHonorario();
            Cargar_ComboBox();
            //****** Contacto ******/
            
            Llenar_CboCTipoDoc();
            Llenar_CboCLocalidad();
            Llenar_CboCCargo();
            Llenar_CboCCargo();
            LLenar_CboCSexo();
            Llenar_CboCEstadoCivil();
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
            dgv.ColumnCount = 27;
            // Setear Cabecera de Columna 

            dgv.Columns[0].Name = "IDE";
            dgv.Columns[1].Name = "CODIGO";
            dgv.Columns[2].Name = "RAZON_SOCIAL";
            dgv.Columns[3].Name = "EMPRESA";
            dgv.Columns[4].Name = "DETRACCION";
            dgv.Columns[5].Name = "RUC";
            dgv.Columns[6].Name = "FECHA_CONSTITUCION";
            dgv.Columns[7].Name = "DIRECCION";
            dgv.Columns[8].Name = "LOCA_IDE";
            dgv.Columns[9].Name = "TELEFONO1";
            dgv.Columns[10].Name = "TELEFONO2";
            dgv.Columns[11].Name = "FAX";
            dgv.Columns[12].Name = "TIPO";
            dgv.Columns[13].Name = "ACTIVIDAD";
            dgv.Columns[14].Name = "CATEGORIA";
            dgv.Columns[15].Name = "CORREO";
            dgv.Columns[16].Name = "PATERNO";
            dgv.Columns[17].Name = "MATERNO";
            dgv.Columns[18].Name = "NOMBRE";
            dgv.Columns[19].Name = "ESTADO";
            dgv.Columns[20].Name = "FECHAINAC";
            dgv.Columns[21].Name = "CREACION";
            dgv.Columns[22].Name = "VECES";
            dgv.Columns[23].Name = "RELACIONADA";
            dgv.Columns[24].Name = "TIPO_DOCUMENTO";
            dgv.Columns[25].Name = "PLAN_CUENTA";
            dgv.Columns[26].Name = "TIPO_HONORARIO";
  
            dgv.Columns[0].Width = 60;
            dgv.Columns[0].HeaderText = "ID";
            dgv.Columns[0].DataPropertyName = "PROV_IDE";

            dgv.Columns[1].Width = 120;
            dgv.Columns[1].HeaderText = "Codigo";
            dgv.Columns[1].DataPropertyName = "PROV_CODIGO";

            dgv.Columns[2].Width = 320;
            dgv.Columns[2].HeaderText = "Razon Social";
            dgv.Columns[2].DataPropertyName = "PROV_RAZON_SOCIAL";

            dgv.Columns[3].Width = 65;
            dgv.Columns[3].HeaderText = "Empresa";
            dgv.Columns[3].DataPropertyName = "PROV_EMPRESA";
            dgv.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgv.Columns[4].Width = 80;
            dgv.Columns[4].HeaderText = "Detraccion";
            dgv.Columns[4].DataPropertyName = "PROV_DETRACCION";
            dgv.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgv.Columns[5].Width = 120;
            dgv.Columns[5].HeaderText = "RUC";
            dgv.Columns[5].DataPropertyName = "PROV_RUC";

            dgv.Columns[6].Width = 20;
            dgv.Columns[6].HeaderText = "F.Constitucion";
            dgv.Columns[6].DataPropertyName = "PROV_FECHA_CONSTITUCION";
            dgv.Columns[6].Visible = false;

            dgv.Columns[7].Width = 269;
            dgv.Columns[7].HeaderText = "Direccion";
            dgv.Columns[7].DataPropertyName = "PROV_DIRECCION";
            // Columnas que no Deben Verse

            dgv.Columns[8].DataPropertyName = "LOCA_IDE";
            dgv.Columns[8].Visible = false;
            dgv.Columns[9].DataPropertyName = "PROV_TELEFONO1";
            dgv.Columns[9].Visible = false;
            dgv.Columns[10].DataPropertyName = "PROV_TELEFONO2";
            dgv.Columns[10].Visible = false;
            dgv.Columns[11].DataPropertyName = "PROV_FAX";
            dgv.Columns[11].Visible = false;
            dgv.Columns[12].DataPropertyName = "TIPO_PROV_IDE";
            dgv.Columns[12].Visible = false;
            dgv.Columns[13].DataPropertyName = "ACTI_PROV_IDE";
            dgv.Columns[13].Visible = false;
            dgv.Columns[14].DataPropertyName = "CATE_PROV_IDE";
            dgv.Columns[14].Visible = false;
            dgv.Columns[15].DataPropertyName = "PROV_CORREO";
            dgv.Columns[15].Visible = false;
            dgv.Columns[16].DataPropertyName = "PROV_PATERNO";
            dgv.Columns[16].Visible = false;
            dgv.Columns[17].DataPropertyName = "PROV_MATERNO";
            dgv.Columns[17].Visible = false;
            dgv.Columns[18].DataPropertyName = "PROV_NOMBRE";
            dgv.Columns[18].Visible = false;
            dgv.Columns[19].DataPropertyName = "PROV_ESTADO";
            dgv.Columns[19].Visible = false;
            dgv.Columns[20].DataPropertyName = "PROV_FECHAINAC";
            dgv.Columns[20].Visible = false;
            dgv.Columns[21].DataPropertyName = "CREACION";
            dgv.Columns[21].Visible = false;
            dgv.Columns[22].DataPropertyName = "VECES";
            dgv.Columns[22].Visible = false;
            dgv.Columns[23].DataPropertyName = "PROV_RELACIONADA";
            dgv.Columns[23].Visible = false;
            dgv.Columns[24].DataPropertyName = "DOCU_IDEN_IDE";
            dgv.Columns[24].Visible = false;
        }

        private void Mostrar(string filtro)
        {
             ENResultOperation R = ClsProveedorBC.Listar(filtro);
            if (R.Proceder)
            {
                dgvListado.DataSource = (DataTable)R.Valor;
            }
            else
            {
                MessageBox.Show("Error al Obtener Valores : " + R.Sms);
            }
            Habilitar_Campos_Mantenimimiento(false);
            Habilitar_Botones_Mantenimiento(true);
        }
        private void Mostrar_Dgv()
        {

            if (this.dgvListado.CurrentRow != null)
            {
                txtMIde.Text = this.dgvListado.CurrentRow.Cells["IDE"].Value.ToString();
                txtMCodigo.Text = this.dgvListado.CurrentRow.Cells["CODIGO"].Value.ToString();
                cboMRelacionada.Text = this.dgvListado.CurrentRow.Cells["RELACIONADA"].Value.ToString();
                cboMTipoDoc.SelectedValue = this.dgvListado.CurrentRow.Cells["TIPO_DOCUMENTO"].Value.ToString();
                txtMRuc.Text = this.dgvListado.CurrentRow.Cells["RUC"].Value.ToString();
                cboMDetraccion.Text = this.dgvListado.CurrentRow.Cells["DETRACCION"].Value.ToString();
                txtMRazon_Social.Text = this.dgvListado.CurrentRow.Cells["RAZON_SOCIAL"].Value.ToString();
                txtMPaterno.Text = this.dgvListado.CurrentRow.Cells["PATERNO"].Value.ToString();
                txtMMaterno.Text = this.dgvListado.CurrentRow.Cells["MATERNO"].Value.ToString();
                txtMNombre.Text = this.dgvListado.CurrentRow.Cells["NOMBRE"].Value.ToString();
                txtMDireccion.Text = this.dgvListado.CurrentRow.Cells["DIRECCION"].Value.ToString();
                txtMTelefono1.Text = this.dgvListado.CurrentRow.Cells["TELEFONO1"].Value.ToString();
                txtMTelefono2.Text = this.dgvListado.CurrentRow.Cells["TELEFONO2"].Value.ToString();
                txtMFax.Text = this.dgvListado.CurrentRow.Cells["FAX"].Value.ToString();
                txtMCorreo.Text = this.dgvListado.CurrentRow.Cells["CORREO"].Value.ToString();
                cboMEmpresa.Text = this.dgvListado.CurrentRow.Cells["EMPRESA"].Value.ToString();
                cboMEstado.Text = this.dgvListado.CurrentRow.Cells["ESTADO"].Value.ToString();
                txtMLoca_Ide.Text = this.dgvListado.CurrentRow.Cells["LOCA_IDE"].Value.ToString();
                cboMLocalidad.SelectedValue = this.dgvListado.CurrentRow.Cells["LOCA_IDE"].Value.ToString();
                txtMActi_Ide.Text = this.dgvListado.CurrentRow.Cells["ACTIVIDAD"].Value.ToString();
                cboMActividad.SelectedValue = this.dgvListado.CurrentRow.Cells["ACTIVIDAD"].Value.ToString();
                txtMCate_Ide.Text = this.dgvListado.CurrentRow.Cells["CATEGORIA"].Value.ToString();
                cboMCategoria.SelectedValue = this.dgvListado.CurrentRow.Cells["CATEGORIA"].Value.ToString();
                txtMTipo_Ide.Text = this.dgvListado.CurrentRow.Cells["TIPO"].Value.ToString();
                cboMTipoProveedor.SelectedValue = this.dgvListado.CurrentRow.Cells["TIPO"].Value.ToString();
                dtpMFechaConstitucion.Text = this.dgvListado.CurrentRow.Cells["FECHA_CONSTITUCION"].Value.ToString();
                nVeces = Convert.ToInt32(this.dgvListado.CurrentRow.Cells["VECES"].Value.ToString());

                Mostrar_Contacto();
                Habilitar_Botones_Contacto(true);
                Habilitar_Campos_Contacto(false);
                
            }
        }

        private void Llenar_CboMTipoDoc()
        {
            ENResultOperation R = ClsTipo_Documento_IdentidadBC.Listar("");
            if (R.Proceder) cboMTipoDoc.DataSource = (DataTable)R.Valor;
            cboMTipoDoc.DisplayMember = "DOCU_IDEN_NOMBRE";
            cboMTipoDoc.ValueMember = "DOCU_IDEN_IDE";
            cboMTipoDoc.AutoCompleteMode = AutoCompleteMode.Suggest;
            cboMTipoDoc.AutoCompleteSource = AutoCompleteSource.ListItems;
            cboMTipoDoc.SelectedIndex = 0;
        }
        private void Llenar_CboMLocalidad()
        {
            ENResultOperation R = ClsLocalidadBC.Listar("");
            if (R.Proceder) cboMLocalidad.DataSource = (DataTable)R.Valor;
            cboMLocalidad.DisplayMember = "LOCA_NOMBRE";
            cboMLocalidad.ValueMember = "LOCA_IDE";
            cboMLocalidad.AutoCompleteMode = AutoCompleteMode.Suggest;
            cboMLocalidad.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void Llenar_CboMActividad()
        {
            ENResultOperation R = ClsActividad_ProveedorBC.Listar("");
            if (R.Proceder) cboMActividad.DataSource = (DataTable)R.Valor;
            cboMActividad.DisplayMember = "ACTI_PROV_NOMBRE";
            cboMActividad.ValueMember = "ACTI_PROV_IDE";
            cboMActividad.AutoCompleteMode = AutoCompleteMode.Suggest;
            cboMActividad.AutoCompleteSource = AutoCompleteSource.ListItems;

        }
        private void Llenar_CboMCategoria()
        {
            ENResultOperation R = ClsCategoria_ProveedorBC.Listar("");
            if (R.Proceder) cboMCategoria.DataSource = (DataTable)R.Valor;
            cboMCategoria.DisplayMember = "CATE_PROV_NOMBRE";
            cboMCategoria.ValueMember = "CATE_PROV_IDE";
            cboMCategoria.AutoCompleteMode = AutoCompleteMode.Suggest;
            cboMCategoria.AutoCompleteSource = AutoCompleteSource.ListItems;

        }

        private void Llenar_CboMTipoProveedor()
        {
            ENResultOperation R = ClsTipo_ProveedorBC.Listar("");
            if (R.Proceder) cboMTipoProveedor.DataSource = (DataTable)R.Valor;
            cboMTipoProveedor.DisplayMember = "TIPO_PROV_NOMBRE";
            cboMTipoProveedor.ValueMember = "TIPO_PROV_IDE";
            cboMTipoProveedor.AutoCompleteMode = AutoCompleteMode.Suggest;
            cboMTipoProveedor.AutoCompleteSource = AutoCompleteSource.ListItems;

        }

        private void Llenar_CboMPlanCuenta()
        {
            ENResultOperation R = ClsPlan_CuentaBC.Listar("");
            if (R.Proceder) cboMPlanCuenta.DataSource = (DataTable)R.Valor;
            cboMPlanCuenta.DisplayMember = "PLA_NOMBRE";
            cboMPlanCuenta.ValueMember = "PLA_CTA_IDE";
            cboMPlanCuenta.AutoCompleteMode = AutoCompleteMode.Suggest;
            cboMPlanCuenta.AutoCompleteSource = AutoCompleteSource.ListItems;
            cboMPlanCuenta.SelectedIndex = 0;
        }
        private void Llenar_CboMHonorario()
        {
            ENResultOperation R = ClsTipo_HonorarioBC.Listar("");
            if (R.Proceder) cboMHonorario.DataSource = (DataTable)R.Valor;
            cboMHonorario.DisplayMember = "TIPO_HONO_NOMBRE";
            cboMHonorario.ValueMember = "TIPO_HONO_IDE";
            cboMHonorario.AutoCompleteMode = AutoCompleteMode.Suggest;
            cboMHonorario.AutoCompleteSource = AutoCompleteSource.ListItems;
            cboMHonorario.SelectedIndex = 0;
        }
        private void Cargar_ComboBox()
        {
            cboBuscar.Items.Clear();
            cboBuscar.Items.Add("Razon Social");
            cboBuscar.Items.Add("RUC");
            cboBuscar.Items.Add("Codigo");
            cboBuscar.Items.Add("Direccion");
            cboBuscar.SelectedIndex = 0;
        }

        private void Buscar_Proveedor()
        {
            string estado = "";
            string cadena = "";
            switch (cboBuscar.Text)
            {
                case "Codigo":
                    cadena = " Prov_Codigo like @filtro ORDER BY Prov_Codigo";
                    break;
                case "Razon Social":
                    cadena = " Prov_Razon_Social like @filtro ORDER BY Prov_Razon_Social ";
                    break;
                case "RUC":
                    cadena = " Prov_RUC like @filtro ORDER BY Prov_RUC";
                    break;
                case "Direccion":
                    cadena = " Prov_Direccion like @filtro ORDER BY Prov_Direccion";
                    break;
            }
            string Consulta = "Select * from Proveedor where " + cadena;
            string cadenastr = "";
            if (string.IsNullOrEmpty(txtBuscar.Text.Trim()))
            {
                cadenastr = "%";
            }
            else
            {
                cadenastr = "%" + txtBuscar.Text.Trim() + "%";
            }
            Con = new SqlConnection(strcon);
            Cmd = new SqlCommand(Consulta, Con);
            Cmd.Parameters.AddWithValue("@Estado", estado);
            Cmd.Parameters.AddWithValue("@filtro", cadenastr);
            Con.Open();
            dr = Cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dgvListado.DataSource = dt;
            dr.Close();
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Buscar_Proveedor();
        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                Buscar_Proveedor();
            }
        }

        private void cboBuscar_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtBuscar.Text = "";
            txtBuscar.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void dgvListado_CurrentCellChanged(object sender, EventArgs e)
        {
            Mostrar_Dgv();
            Mostrar_DgvContacto();
        }


        // ************************  MANTENIMIENTO ****************************//

        private void Inicializa_Campos_Mantenimiento()
        {
            txtMIde.Text = "0";
            txtMCodigo.Text = String.Empty;
            cboMRelacionada.Text = "No";
            cboMTipoDoc.SelectedIndex = 1;
            txtMRuc.Text = String.Empty;
            txtMRazon_Social.Text = String.Empty;
            txtMPaterno.Text = String.Empty;
            txtMMaterno.Text = String.Empty;
            txtMNombre.Text = String.Empty;
            txtMDireccion.Text = String.Empty;
            txtMTelefono1.Text = String.Empty;
            txtMTelefono2.Text = String.Empty;
            txtMFax.Text = String.Empty;
            txtMCorreo.Text = String.Empty;
            cboMEmpresa.Text = "Si";
            cboMEstado.Text = "Activo";

            cboMLocalidad.SelectedIndex = cboMLocalidad.FindStringExact("LIMA");
            txtMLoca_Ide.Text = cboMLocalidad.SelectedValue.ToString();

            cboMActividad.SelectedIndex = 0;
            txtMActi_Ide.Text = cboMActividad.SelectedValue.ToString();

            cboMCategoria.SelectedIndex = 0;
            txtMCate_Ide.Text = cboMCategoria.SelectedValue.ToString();

            cboMTipoProveedor.SelectedIndex = 0;
            txtMTipo_Ide.Text = cboMTipoProveedor.SelectedValue.ToString();

            cboMDetraccion.Text = "No";
            dtpMFechaConstitucion.Text = String.Empty;

            cboMPlanCuenta.SelectedIndex = 0;
            cboMHonorario.SelectedIndex = 0;
        }
        private void Habilitar_Campos_Mantenimimiento(Boolean Flag)
        {
            txtMIde.Enabled = Flag;
            txtMCodigo.Enabled = Flag;
            cboMRelacionada.Enabled = Flag;
            cboMTipoDoc.Enabled = Flag;
            txtMRuc.Enabled = Flag;
            txtMRazon_Social.Enabled = Flag;
            
            txtMDireccion.Enabled = Flag;
            txtMTelefono1.Enabled = Flag;
            txtMTelefono2.Enabled = Flag;
            txtMFax.Enabled = Flag;
            txtMCorreo.Enabled = Flag;
            cboMEmpresa.Enabled = Flag;
            cboMEstado.Enabled = Flag;
            txtMLoca_Ide.Enabled = Flag;
            cboMLocalidad.Enabled = Flag;
            txtMActi_Ide.Enabled = Flag;
            cboMActividad.Enabled = Flag;
            txtMCate_Ide.Enabled = Flag;
            cboMCategoria.Enabled = Flag;
            txtMTipo_Ide.Enabled = Flag;
            cboMTipoProveedor.Enabled = Flag;
            cboMDetraccion.Enabled = Flag;
            dtpMFechaConstitucion.Enabled = Flag;
            cboMPlanCuenta.Enabled = Flag;
            cboMHonorario.Enabled = Flag;
           
            txtMPaterno.Enabled = Flag;
            txtMMaterno.Enabled = Flag;
            txtMNombre.Enabled = Flag;
           
            
        }
        private void Habilitar_Botones_Mantenimiento(Boolean Flag)
        {
            btnMNuevo.Enabled = Flag;
            btnMModifica.Enabled = Flag;
            btnMElimina.Enabled = Flag;
            btnMGraba.Enabled = !Flag;
            btnMCancela.Enabled = !Flag;
            btnMRetornar.Enabled = Flag;

        }
        private void btnMNuevo_Click(object sender, EventArgs e)
        {
            Operacion = "N";
            Habilitar_Botones_Mantenimiento(false);
            Inicializa_Campos_Mantenimiento();
            Habilitar_Campos_Mantenimimiento(true);
            Valida_Empresa();
            txtMCodigo.Focus();
        }

        private void btnMModifica_Click(object sender, EventArgs e)
        {
            Operacion = "M";
            Habilitar_Botones_Mantenimiento(false);
            Habilitar_Campos_Mantenimimiento(true);
            Valida_Empresa();
            txtMRazon_Social.Focus();
        }

        private void btnMElimina_Click(object sender, EventArgs e)
        {
            Operacion = "E";
            Habilitar_Botones_Mantenimiento(false);
            btnMGraba.Text = "Eliminar";
            btnMGraba.Focus();
        }

        private void btnMGraba_Click(object sender, EventArgs e)
        {
            if (Verificar_Campos())
            {
                Procesar_Operacion();
            }
        }

        private void btnMCancela_Click(object sender, EventArgs e)
        {
            Habilitar_Botones_Mantenimiento(true);
        }

        private void Procesar_Operacion()
        {
            ClsProveedorBE TipoBE = new ClsProveedorBE();
            TipoBE.Prov_ide = Convert.ToInt32(txtMIde.Text);
            TipoBE.Prov_codigo = txtMCodigo.Text;
            TipoBE.Prov_relacionada = cboMRelacionada.Text;
            TipoBE.Docu_iden_ide = Convert.ToInt32(cboMTipoDoc.SelectedValue.ToString());
            TipoBE.Prov_razon_social = txtMRazon_Social.Text;
            TipoBE.Prov_empresa = cboMEmpresa.Text;
            TipoBE.Prov_detraccion = cboMDetraccion.Text;
            TipoBE.Prov_ruc = txtMRuc.Text;
            TipoBE.Prov_fecha_constitucion = Convert.ToDateTime(dtpMFechaConstitucion.Text);
            TipoBE.Prov_direccion = txtMDireccion.Text;
            TipoBE.Loca_ide       = Convert.ToInt32(cboMLocalidad.SelectedValue.ToString());
            TipoBE.Prov_telefono1 = txtMTelefono1.Text;
            TipoBE.Prov_telefono2 = txtMTelefono2.Text;
            TipoBE.Prov_fax = txtMFax.Text;
            TipoBE.Tipo_prov_ide = Convert.ToInt32(cboMTipoProveedor.SelectedValue.ToString());
            TipoBE.Acti_prov_ide = Convert.ToInt32(cboMActividad.SelectedValue.ToString());
            TipoBE.Cate_prov_ide = Convert.ToInt32(cboMCategoria.SelectedValue.ToString());
            TipoBE.Prov_correo = txtMCorreo.Text;
            TipoBE.Prov_paterno = txtMPaterno.Text;
            TipoBE.Prov_materno = txtMMaterno.Text;
            TipoBE.Prov_nombre = txtMNombre.Text; ;
            TipoBE.Prov_estado = cboMEstado.Text;
            TipoBE.Prov_fechainac = Convert.ToDateTime("01-01-1900");
            TipoBE.Tipo_hono_ide = Convert.ToInt32(cboMHonorario.SelectedValue.ToString());
            TipoBE.Pla_cta_ide   = Convert.ToInt32(cboMPlanCuenta.SelectedValue.ToString());
            TipoBE.Veces = nVeces;
            TipoBE.Usuario = "ADMIN";
            TipoBE.Creacion = Convert.ToDateTime(DateTime.Today);

            switch (Operacion)
            {
                case "N":
                    {
                        ENResultOperation R = ClsProveedorBC.Crear(TipoBE);
                        if (!R.Proceder) MessageBox.Show("Error al Insertar Proveedor..." + R.Sms);
                        break;
                    }
                case "M":
                    {
                        ENResultOperation R = ClsProveedorBC.Actualizar(TipoBE);
                        if (!R.Proceder) MessageBox.Show("Error al Modificar Proveedor..." + R.Sms);
                        break;
                    }
                case "E":
                    {
                        ENResultOperation R = ClsProveedorBC.Eliminar(TipoBE);
                        if (!R.Proceder) MessageBox.Show("Error al Eliminar Proveedor..." + R.Sms);
                        break;
                    }
            }

            

            Mostrar("");
            Mostrar_Dgv();
            Habilitar_Botones_Mantenimiento(true);
            Habilitar_Campos_Mantenimimiento(false);
            btnMGraba.Text = "Grabar";
        }

        private void btnMRetornar_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }

        private void cboMLocalidad_SelectedValueChanged(object sender, EventArgs e)
        {
            txtMLoca_Ide.Text = cboMLocalidad.SelectedValue.ToString();
        }

        private void cboMActividad_SelectedValueChanged(object sender, EventArgs e)
        {
            txtMActi_Ide.Text = cboMActividad.SelectedValue.ToString();
        }

        private void cboMCategoria_SelectedValueChanged(object sender, EventArgs e)
        {
            txtMCate_Ide.Text = cboMCategoria.SelectedValue.ToString();
        }

        private void cboMTipoProveedor_SelectedValueChanged(object sender, EventArgs e)
        {
            txtMTipo_Ide.Text = cboMTipoProveedor.SelectedValue.ToString();
        }

        private void cboMEmpresa_SelectedValueChanged(object sender, EventArgs e)
        {
            Valida_Empresa();
        }

        private void Valida_Empresa()
        {
            if (cboMEmpresa.Text == "Si")
            {
                txtMPaterno.Text = string.Empty;
                txtMMaterno.Text = string.Empty;
                txtMNombre.Text = string.Empty;
                txtMPaterno.Enabled = false;
                txtMMaterno.Enabled = false;
                txtMNombre.Enabled = false;
            }
            else
            {
                txtMPaterno.Enabled = true;
                txtMMaterno.Enabled = true;
                txtMNombre.Enabled = true;
            }
        }

        private void txtMNombre_Validated(object sender, EventArgs e)
        {
            txtMRazon_Social.Text = txtMPaterno.Text + ' ' + txtMMaterno.Text + ' ' + txtMNombre.Text;
        }

        private void txtMRazon_Social_Enter(object sender, EventArgs e)
        {
            if (cboMEmpresa.Text == "No")
            {
                txtMRazon_Social.Text = txtMPaterno.Text + ' ' + txtMMaterno.Text + ' ' + txtMNombre.Text;
            }
        }
        private Boolean Verificar_Campos()
        {
            if (string.IsNullOrEmpty(txtMCodigo.Text))
            {
                MessageBox.Show("Codigo No Fue Ingresado.. Campo Obligatorio");
                return false;
            }
            if (string.IsNullOrEmpty(txtMRuc.Text))
            {
                MessageBox.Show("RUC No Fue Ingresado.. Campo Obligatorio");
                return false;
            }
            if (string.IsNullOrEmpty(txtMRazon_Social.Text))
            {
                MessageBox.Show("Razon Social del Proveedor No Fue Ingresado.. Campo Obligatorio");
                return false;
            }
            if (string.IsNullOrEmpty(txtMLoca_Ide.Text))
            {
                MessageBox.Show("No Ha Seleccionado Localidad.. Campo Obligatorio");
                return false;
            }
            if (string.IsNullOrEmpty(txtMTipo_Ide.Text))
            {
                MessageBox.Show("No Ha Seleccionado Tipo de Proveedor.. Campo Obligatorio");
                return false;
            }
            if (string.IsNullOrEmpty(txtMActi_Ide.Text))
            {
                MessageBox.Show("No Ha Seleccionado Actividad.. Campo Obligatorio");
                return false;
            }
            if (string.IsNullOrEmpty(txtMCate_Ide.Text))
            {
                MessageBox.Show("No Ha Seleccionado Categoria.. Campo Obligatorio");
                return false;
            }
            return true;
        }


        // ************************ CONTACTO *************************************

        void FormatoDgv_Contacto()
        {
            //------------------------------------------------------------------//      
            var dgv = dgvContacto;

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
            DataGridViewCellStyle style = this.dgvContacto.ColumnHeadersDefaultCellStyle;
            style.BackColor = Color.Honeydew;
            style.ForeColor = Color.Gray;
            dgv.Columns.Clear();
            dgv.ColumnCount = 21;
            // Setear Cabecera de Columna 

            dgv.Columns[0].Name = "IDE";
            dgv.Columns[1].Name = "CONT_IDE";
            dgv.Columns[2].Name = "CONT_TITULO";
            dgv.Columns[3].Name = "CONT_PATERNO";
            dgv.Columns[4].Name = "CONT_MATERNO";
            dgv.Columns[5].Name = "CONT_NOMBRE";
            dgv.Columns[6].Name = "CARG_IDE";
            dgv.Columns[7].Name = "CONT_DIRECCION";
            dgv.Columns[8].Name = "LOCA_IDE";
            dgv.Columns[9].Name = "CONT_TELEFONO_CASA";
            dgv.Columns[10].Name = "CONT_TELEFONO_CELULAR";
            dgv.Columns[11].Name = "CONT_FAX";
            dgv.Columns[12].Name = "DOCU_IDEN_IDE";
            dgv.Columns[13].Name = "CONT_DOCUMENTO";
            dgv.Columns[14].Name = "CONT_FECHA_NACIMIENTO";
            dgv.Columns[15].Name = "CONT_SEXO";
            dgv.Columns[16].Name = "CONT_ESTADO_CIVIL";
            dgv.Columns[17].Name = "CONT_CORREO";
            dgv.Columns[18].Name = "CONT_NOTA";
            dgv.Columns[19].Name = "CREACION";
            dgv.Columns[20].Name = "VECES";
           
            dgv.Columns[0].Width = 60;
            dgv.Columns[0].HeaderText = "ID";
            dgv.Columns[0].DataPropertyName = "PROV_IDE";
            dgv.Columns[0].Visible = false;

            dgv.Columns[1].Width = 50;
            dgv.Columns[1].HeaderText = "IDE";
            dgv.Columns[1].DataPropertyName = "PROV_CONT_IDE";
            dgv.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            //dgv.Columns[1].Visible = false;

            dgv.Columns[2].Width = 40;
            dgv.Columns[2].HeaderText = "Tit";
            dgv.Columns[2].DataPropertyName = "PROV_CONT_TITULO";


            dgv.Columns[3].Width = 180;
            dgv.Columns[3].HeaderText = "Paterno";
            dgv.Columns[3].DataPropertyName = "PROV_CONT_PATERNO";

            dgv.Columns[4].Width = 180;
            dgv.Columns[4].HeaderText = "Materno";
            dgv.Columns[4].DataPropertyName = "PROV_CONT_MATERNO";

            dgv.Columns[5].Width = 180;
            dgv.Columns[5].HeaderText = "Nombres";
            dgv.Columns[5].DataPropertyName = "PROV_CONT_NOMBRE";

            dgv.Columns[6].Width = 90;
            dgv.Columns[6].HeaderText = "Cargo";
            dgv.Columns[6].DataPropertyName = "CARG_IDE";
            dgv.Columns[6].Visible = false;

            dgv.Columns[7].Width = 340;
            dgv.Columns[7].HeaderText = "Direccion";
            dgv.Columns[7].DataPropertyName = "PROV_CONT_DIRECCION";

            dgv.Columns[8].HeaderText = "Localidad";
            dgv.Columns[8].DataPropertyName = "LOCA_IDE";
            dgv.Columns[8].Visible = false;

            dgv.Columns[9].Width = 90;
            dgv.Columns[9].HeaderText = "Telefono Casa";
            dgv.Columns[9].DataPropertyName = "PROV_CONT_TELEFONO_CASA";
            dgv.Columns[9].Visible = false;

            dgv.Columns[10].Width = 90;
            dgv.Columns[10].HeaderText = "Celular";
            dgv.Columns[10].DataPropertyName = "PROV_CONT_TELEFONO_CELULAR";
            dgv.Columns[10].Visible = false;

            dgv.Columns[11].Width = 90;
            dgv.Columns[11].HeaderText = "Fax";
            dgv.Columns[11].DataPropertyName = "PROV_CONT_FAX";
            dgv.Columns[11].Visible = false;

            dgv.Columns[12].Width = 90;
            dgv.Columns[12].HeaderText = "Tipo Doc";
            dgv.Columns[12].DataPropertyName = "DOCU_IDEN_IDE";
            dgv.Columns[12].Visible = false;

            dgv.Columns[13].Width = 90;
            dgv.Columns[13].HeaderText = "Documento";
            dgv.Columns[13].DataPropertyName = "PROV_CONT_DOCUMENTO";
            dgv.Columns[13].Visible = false;

            dgv.Columns[14].Width = 90;
            dgv.Columns[14].HeaderText = "F.Nacimiento";
            dgv.Columns[14].DataPropertyName = "PROV_CONT_FECHA_NACIMIENTO";
            dgv.Columns[14].Visible = false;

            dgv.Columns[15].Width = 90;
            dgv.Columns[15].HeaderText = "Sexo";
            dgv.Columns[15].DataPropertyName = "PROV_CONT_SEXO";
            dgv.Columns[15].Visible = false;

            dgv.Columns[16].Width = 90;
            dgv.Columns[16].HeaderText = "Estado Civil";
            dgv.Columns[16].DataPropertyName = "PROV_CONT_ESTADO_CIVIL";
            dgv.Columns[16].Visible = false;

            dgv.Columns[17].Width = 90;
            dgv.Columns[17].HeaderText = "Correo";
            dgv.Columns[17].DataPropertyName = "PROV_CONT_CORREO";
            dgv.Columns[17].Visible = false;

            dgv.Columns[18].Width = 90;
            dgv.Columns[18].HeaderText = "Nota";
            dgv.Columns[18].DataPropertyName = "PROV_CONT_NOTA";
            dgv.Columns[18].Visible = false;
            // Columnas que no Deben Verse

            dgv.Columns[19].DataPropertyName = "CREACION";
            dgv.Columns[19].Visible = false;

            dgv.Columns[20].DataPropertyName = "VECES";
            dgv.Columns[20].Visible = false;
                 
        }

        private void Mostrar_DgvContacto()
        {
            DataTable TEMP = new DataTable();
            ENResultOperation R = ClsProveedor_ContactoBC.Listar_Filtro(Convert.ToInt32(txtMIde.Text));
            if (R.Proceder)
            {
                dgvContacto.DataSource = (DataTable)R.Valor;
                TEMP = (DataTable)R.Valor;
            }
            else
            {
                MessageBox.Show("Error al Obtener Valores : " + R.Sms);
            }
            txtCRazonSocial.Text = txtMRazon_Social.Text;
            txtCIdProveedor.Text = txtMIde.Text;
        }
        private void Mostrar_Contacto()
        {
            txtCRazonSocial.Text = txtMRazon_Social.Text;
            txtCIdProveedor.Text = txtMIde.Text;
            if (dgvContacto.CurrentRow != null)
            {
                txtCId.Text = Convert.ToString(this.dgvContacto.CurrentRow.Cells["CONT_IDE"].Value);
                txtCNumero.Text = Convert.ToString(this.dgvContacto.CurrentRow.Cells["CONT_DOCUMENTO"].Value);
                txtCTitulo.Text = Convert.ToString(this.dgvContacto.CurrentRow.Cells["CONT_TITULO"].Value);
                txtCNombre.Text = Convert.ToString(this.dgvContacto.CurrentRow.Cells["CONT_NOMBRE"].Value);
                txtCMaterno.Text = Convert.ToString(this.dgvContacto.CurrentRow.Cells["CONT_MATERNO"].Value);
                txtCPaterno.Text = Convert.ToString(this.dgvContacto.CurrentRow.Cells["CONT_PATERNO"].Value);
                txtCDireccion.Text = Convert.ToString(this.dgvContacto.CurrentRow.Cells["CONT_DIRECCION"].Value);
                txtCLocaIde.Text = Convert.ToString(this.dgvContacto.CurrentRow.Cells["LOCA_IDE"].Value);
                txtCTelefonoCasa.Text = Convert.ToString(this.dgvContacto.CurrentRow.Cells["CONT_TELEFONO_CASA"].Value);
                txtCTelefonoCelular.Text = Convert.ToString(this.dgvContacto.CurrentRow.Cells["CONT_TELEFONO_CELULAR"].Value);
                txtCFax.Text = Convert.ToString(this.dgvContacto.CurrentRow.Cells["CONT_FAX"].Value);
                txtCFecNac.Text = Convert.ToString(this.dgvContacto.CurrentRow.Cells["CONT_FECHA_NACIMIENTO"].Value);
                txtCCorreo.Text = Convert.ToString(this.dgvContacto.CurrentRow.Cells["CONT_CORREO"].Value);
                txtCNota.Text = Convert.ToString(this.dgvContacto.CurrentRow.Cells["CONT_NOTA"].Value);
                cboCTipoDoc.SelectedValue = Convert.ToInt32(this.dgvContacto.CurrentRow.Cells["DOCU_IDEN_IDE"].Value);
                cboCLocalidad.SelectedValue = Convert.ToInt32(this.dgvContacto.CurrentRow.Cells["LOCA_IDE"].Value);
                cboCSexo.Text = Convert.ToString(this.dgvContacto.CurrentRow.Cells["CONT_SEXO"].Value);
                cboCEstadoCivil.Text = Convert.ToString(this.dgvContacto.CurrentRow.Cells["CONT_ESTADO_CIVIL"].Value);
                cboCCargo.SelectedValue = Convert.ToInt32(this.dgvContacto.CurrentRow.Cells["CARG_IDE"].Value);
                nVeces_Contacto = Convert.ToInt32(this.dgvContacto.CurrentRow.Cells["VECES"].Value);
            }
            else
            {
                Poner_Campos_Contacto_Blanco();
            }
        }

        private void Llenar_CboCTipoDoc()
        {
            ENResultOperation R = ClsTipo_Documento_IdentidadBC.Listar("");
            if (R.Proceder) cboCTipoDoc.DataSource = (DataTable)R.Valor;
            cboCTipoDoc.DisplayMember = "DOCU_IDEN_NOMBRE";
            cboCTipoDoc.ValueMember = "DOCU_IDEN_IDE";
            cboCTipoDoc.AutoCompleteMode = AutoCompleteMode.Suggest;
            cboCTipoDoc.AutoCompleteSource = AutoCompleteSource.ListItems;
            cboCTipoDoc.SelectedIndex = 0;
        }

        private void Llenar_CboCLocalidad()
        {
            ENResultOperation R = ClsLocalidadBC.Listar("");
            if (R.Proceder) cboCLocalidad.DataSource = (DataTable)R.Valor;
            cboCLocalidad.DisplayMember = "LOCA_NOMBRE";
            cboCLocalidad.ValueMember = "LOCA_IDE";
            cboCLocalidad.AutoCompleteMode = AutoCompleteMode.Suggest;
            cboCLocalidad.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void Llenar_CboCCargo()
        {
            ENResultOperation R = ClsCargoBC.Listar("");
            if (R.Proceder) cboCCargo.DataSource = (DataTable)R.Valor;
            cboCCargo.DisplayMember = "CARG_NOMBRE";
            cboCCargo.ValueMember = "CARG_IDE";
            cboCCargo.AutoCompleteMode = AutoCompleteMode.Suggest;
            cboCCargo.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void LLenar_CboCSexo()
        {
            cboCSexo.Items.Add("Masculino");
            cboCSexo.Items.Add("Femenino");
            cboCSexo.SelectedIndex = 0;
        }

        private void Llenar_CboCEstadoCivil()
        {
            cboCEstadoCivil.Items.Add("Soltero");
            cboCEstadoCivil.Items.Add("Casado");
            cboCEstadoCivil.Items.Add("Viudo");
            cboCEstadoCivil.Items.Add("Divorciado");
            cboCEstadoCivil.SelectedIndex = 0;

        }

        private void btnCNuevo_Click(object sender, EventArgs e)
        {
            Operacion_Contacto = "N";
            Habilitar_Botones_Contacto(false);
            Inicializa_Campos_Contacto();
            Habilitar_Campos_Contacto(true);
        }

        private void btnCModifica_Click(object sender, EventArgs e)
        {
            Operacion_Contacto = "M";
            Habilitar_Botones_Contacto(false);
            Habilitar_Campos_Contacto(true);
        }

        private void btnCElimina_Click(object sender, EventArgs e)
        {
            Operacion_Contacto = "E";
            Habilitar_Botones_Contacto(false);
            Habilitar_Campos_Contacto(true);
            btnMGraba.Text = "Eliminar";
        }

        private void btnCGraba_Click(object sender, EventArgs e)
        {
            Procesar_Operacion_Contacto();
        }

        private void btnCCancela_Click(object sender, EventArgs e)
        {
            Habilitar_Botones_Contacto(true);
            Habilitar_Campos_Contacto(false);
            Mostrar_Contacto();
        }

        private void btnCRetorna_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }

        private void Procesar_Operacion_Contacto()
        {
            ClsProveedor_ContactoBE TipoBE = new ClsProveedor_ContactoBE();
            TipoBE.Prov_ide = Convert.ToInt32(txtMIde.Text);
            TipoBE.Prov_cont_ide = Convert.ToInt32(txtCId.Text);
            TipoBE.Prov_cont_titulo = Convert.ToString(txtCTitulo.Text);
            TipoBE.Prov_cont_paterno = Convert.ToString(txtCPaterno.Text);
            TipoBE.Prov_cont_materno = Convert.ToString(txtCMaterno.Text);
            TipoBE.Prov_cont_nombre = Convert.ToString(txtCNombre.Text);
            TipoBE.Carg_ide = Convert.ToInt32(cboCCargo.SelectedValue.ToString());
            TipoBE.Prov_cont_direccion = Convert.ToString(txtCDireccion.Text);
            TipoBE.Loca_ide = Convert.ToInt32(cboCLocalidad.SelectedValue.ToString());
            TipoBE.Prov_cont_telefono_casa = Convert.ToString(txtCTelefonoCasa.Text);
            TipoBE.Prov_cont_telefono_celular = Convert.ToString(txtCTelefonoCelular.Text);
            TipoBE.Prov_cont_fax = Convert.ToString(txtCFax.Text);
            TipoBE.Docu_iden_ide = Convert.ToInt32(cboCTipoDoc.SelectedValue.ToString());
            TipoBE.Prov_cont_documento = Convert.ToString(txtCNumero.Text);
            TipoBE.Prov_cont_fecha_nacimiento = Convert.ToString(txtCFecNac.Text);
            TipoBE.Prov_cont_sexo = Convert.ToString(cboCSexo.Text);
            TipoBE.Prov_cont_estado_civil = Convert.ToString(cboCEstadoCivil.Text);
            TipoBE.Prov_cont_correo = Convert.ToString(txtCCorreo.Text);
            TipoBE.Prov_cont_nota = Convert.ToString(txtCNota.Text);
            TipoBE.Veces = nVeces_Contacto;
            TipoBE.Usuario = "ADMIN";
            TipoBE.Creacion = Convert.ToDateTime(DateTime.Today);

            switch (Operacion_Contacto)
            {
                case "N":
                    {
                        ENResultOperation R = ClsProveedor_ContactoBC.Crear(TipoBE);
                        break;
                    }
                case "M":
                    {
                        ENResultOperation R = ClsProveedor_ContactoBC.Actualizar(TipoBE);
                        break;
                    }
                case "E":
                    {
                        ENResultOperation R = ClsProveedor_ContactoBC.Eliminar(TipoBE);
                        break;
                    }
            }

            Mostrar_Contacto();
            Mostrar_DgvContacto();
            Habilitar_Botones_Contacto(true);
            Habilitar_Campos_Contacto(false);
            btnCGraba.Text = "Grabar";
        }

        private void Poner_Campos_Contacto_Blanco()
        {
            txtCId.Text = "0";
            txtCNumero.Text = string.Empty;
            txtCTitulo.Text = string.Empty;
            txtCNombre.Text = string.Empty;
            txtCMaterno.Text = string.Empty;
            txtCPaterno.Text = string.Empty;
            txtCDireccion.Text = string.Empty;
            txtCLocaIde.Text = string.Empty;
            txtCTelefonoCasa.Text = string.Empty;
            txtCTelefonoCelular.Text = string.Empty;
            txtCFax.Text = string.Empty;
            txtCFecNac.Text = string.Empty;
            txtCCorreo.Text = string.Empty;
            txtCNota.Text = string.Empty;
            cboCTipoDoc.Text = string.Empty;
            cboCLocalidad.Text = string.Empty;
            cboCSexo.Text = string.Empty;
            cboCEstadoCivil.Text = string.Empty;
            cboCCargo.Text = string.Empty;
        }
        private void Inicializa_Campos_Contacto()
        {
            Poner_Campos_Contacto_Blanco();
            cboCTipoDoc.SelectedIndex = 0;
            cboCLocalidad.SelectedIndex = cboCLocalidad.FindStringExact("LIMA");
            txtCLocaIde.Text = cboCLocalidad.SelectedValue.ToString();
            cboCSexo.SelectedIndex = 0;
            cboCEstadoCivil.SelectedIndex = 0;
            cboCCargo.SelectedIndex = 0;
        }

        private void Habilitar_Campos_Contacto(Boolean Flag)
        {
            txtCRazonSocial.Enabled = false;
            txtCIdProveedor.Enabled = false;
            txtCId.Enabled = false;

            txtCNumero.Enabled = Flag;
            txtCTitulo.Enabled = Flag;
            txtCNombre.Enabled = Flag;
            txtCMaterno.Enabled = Flag;
            txtCPaterno.Enabled = Flag;
            txtCDireccion.Enabled = Flag;
            txtCLocaIde.Enabled = Flag;
            txtCTelefonoCasa.Enabled = Flag;
            txtCTelefonoCelular.Enabled = Flag;
            txtCFax.Enabled = Flag;
            txtCFecNac.Enabled = Flag;
            txtCCorreo.Enabled = Flag;
            txtCNota.Enabled = Flag;
            cboCTipoDoc.Enabled = Flag;
            cboCLocalidad.Enabled = Flag;
            cboCSexo.Enabled = Flag;
            cboCEstadoCivil.Enabled = Flag;
            cboCCargo.Enabled = Flag;
        }
        private void Habilitar_Botones_Contacto(Boolean Flag)
        {
            btnCNuevo.Enabled = Flag;
            btnCModifica.Enabled = Flag;
            btnCElimina.Enabled = Flag;
            btnCGraba.Enabled = !Flag;
            btnCCancela.Enabled = !Flag;
            btnCRetorna.Enabled = Flag;
        }

        private void cboCLocalidad_SelectedValueChanged(object sender, EventArgs e)
        {
            txtCLocaIde.Text = cboCLocalidad.SelectedValue.ToString();
        }

        private void cboCTipoDoc_SelectedValueChanged(object sender, EventArgs e)
        {
           
        }

        private void dgvContacto_CurrentCellChanged(object sender, EventArgs e)
        {
            Mostrar_Contacto();
        }



 
 
 
    }
}
