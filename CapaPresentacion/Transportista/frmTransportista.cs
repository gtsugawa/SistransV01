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


namespace CapaPresentacion.Transportista
{
    public partial class frmTransportista : Form
    {
        string Operacion = null;  // Operaciones : N = Nuevo / M = Modificar E = Eliminar
        string Operacion_Chofer = null;
        string Operacion_Vehiculo = null;
        string Operacion_Contacto = null;
        string Operacion_Notas = null;
        Int32 nVecesChofer = 0;
        Int32 nVecesVehiculo = 0;
        Int32 nVecesContacto = 0;
        Int32 nVecesNotas = 0;
        private SqlConnection Con = null;
        private SqlCommand Cmd;
        private SqlDataReader dr = null;
        string strcon = ConfigurationManager.ConnectionStrings["conex1"].ConnectionString;
        public frmTransportista()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmTransportista_Load(object sender, EventArgs e)
        {
            FormatoDgv();
            FormatoDgv_Chofer();
            FormatoDgv_Vehiculo();
            FormatoDgv_Contacto();
            FormatoDgv_Notas();
            Mostrar_dgv("TERAH");
            Cargar_ComboBox();
            Habilitar_Campos_Mantenimiento(false);
            Cargar_Localidad();
  
            //******* LLenar ComboBox Transportista-Vehiculo ****//
            Llenar_CboVColor();
            Llenar_CboVMarca();
            Llenar_CboVCombustible();
            Llenar_CboVTipo();
            //******* LLenar ComboBox Transportista-Contacto ****//
            Llenar_cboCoCargo();
            Llenar_cboCoEstadoCivil();
            Llenar_cboCoLocalidad();
            Llenar_cboCoSexo();
            Llenar_cboCoTipoDoc();
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
            dgv.ColumnCount = 19;
            // Setear Cabecera de Columna 

            dgv.Columns[0].Name = "IDE";
            dgv.Columns[1].Name = "CODIGO";
            dgv.Columns[2].Name = "RAZON_SOCIAL";
            dgv.Columns[3].Name = "EMPRESA";
            dgv.Columns[4].Name = "RUC";
            dgv.Columns[5].Name = "FECHA_CONSTITUCION";
            dgv.Columns[6].Name = "DIRECCION";
            dgv.Columns[7].Name = "LOCA_IDE";
            dgv.Columns[8].Name = "TELEFONO1";
            dgv.Columns[9].Name = "TELEFONO2";
            dgv.Columns[10].Name = "FAX";
            dgv.Columns[11].Name = "CORREO";
            dgv.Columns[12].Name = "PATERNO";
            dgv.Columns[13].Name = "MATERNO";
            dgv.Columns[14].Name = "NOMBRE";
            dgv.Columns[15].Name = "ESTADO";
            dgv.Columns[16].Name = "FECHAINAC";
            dgv.Columns[17].Name = "CREACION";
            dgv.Columns[18].Name = "VECES";

            dgv.Columns[0].Width = 60;
            dgv.Columns[0].HeaderText = "ID";
            dgv.Columns[0].DataPropertyName = "TRAN_IDE";

            dgv.Columns[1].Width = 120;
            dgv.Columns[1].HeaderText = "Codigo";
            dgv.Columns[1].DataPropertyName = "TRAN_CODIGO";

            dgv.Columns[2].Width = 320;
            dgv.Columns[2].HeaderText = "Razon Social";
            dgv.Columns[2].DataPropertyName = "TRAN_RAZON_SOCIAL";

            dgv.Columns[3].Width = 65;
            dgv.Columns[3].HeaderText = "Empresa";
            dgv.Columns[3].DataPropertyName = "TRAN_EMPRESA";
            dgv.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            

            dgv.Columns[4].Width = 120;
            dgv.Columns[4].HeaderText = "RUC";
            dgv.Columns[4].DataPropertyName = "TRAN_RUC";

            dgv.Columns[5].Width = 20;
            dgv.Columns[5].HeaderText = "F.Constitucion";
            dgv.Columns[5].DataPropertyName = "TRAN_FECHA_CONSTITUCION";
            dgv.Columns[5].Visible = false;

            dgv.Columns[6].Width = 269;
            dgv.Columns[6].HeaderText = "Direccion";
            dgv.Columns[6].DataPropertyName = "TRAN_DIRECCION";
            // Columnas que no Deben Verse

            dgv.Columns[7].DataPropertyName = "LOCA_IDE";
            dgv.Columns[7].Visible = false;
            dgv.Columns[8].DataPropertyName = "TRAN_TELEFONO1";
            dgv.Columns[8].Visible = false;
            dgv.Columns[9].DataPropertyName = "TRAN_TELEFONO2";
            dgv.Columns[9].Visible = false;
            dgv.Columns[10].DataPropertyName = "TRAN_FAX";
            dgv.Columns[10].Visible = false;
            dgv.Columns[11].DataPropertyName = "TRAN_CORREO";
            dgv.Columns[11].Visible = false;
            dgv.Columns[12].DataPropertyName = "TRAN_PATERNO";
            dgv.Columns[12].Visible = false;
            dgv.Columns[13].DataPropertyName = "TRAN_MATERNO";
            dgv.Columns[13].Visible = false;
            dgv.Columns[14].DataPropertyName = "TRAN_NOMBRE";
            dgv.Columns[14].Visible = false;
            dgv.Columns[15].DataPropertyName = "TRAN_ESTADO";
            dgv.Columns[15].Visible = false;
            dgv.Columns[16].DataPropertyName = "TRAN_FECHAINAC";
            dgv.Columns[16].Visible = false;
            dgv.Columns[17].DataPropertyName = "CREACION";
            dgv.Columns[17].Visible = false;
            dgv.Columns[18].DataPropertyName = "VECES";
            dgv.Columns[18].Visible = false;
        }

        private void Mostrar_dgv(string filtro)
        {
           // DataTable TEMP = new DataTable();
            ENResultOperation R = ClsTransportistaBC.Listar(filtro);
            if (R.Proceder)
            {
                dgvListado.DataSource = (DataTable)R.Valor;
              //  TEMP = (DataTable)R.Valor;
            }
            else
            {
                MessageBox.Show("Error al Obtener Valores : " + R.Sms);
            }
        }

        private void Cargar_Localidad()
        {
            //DataTable TEMP = new DataTable();
            ENResultOperation R = ClsLocalidadBC.Listar("");
            if (R.Proceder)
            {
                cboMLocalidad.DataSource    = (DataTable)R.Valor;
                cboMLocalidad.DisplayMember = "Loca_Nombre";
                cboMLocalidad.ValueMember   = "Loca_Ide";
                cboMLocalidad.AutoCompleteMode = AutoCompleteMode.Suggest;
                cboMLocalidad.AutoCompleteSource = AutoCompleteSource.ListItems;
               // TEMP = (DataTable)R.Valor;
            }
            else
            {
                MessageBox.Show("Error al Obtener Valores : " + R.Sms);
            }

        }

        private void Cargar_ComboBox()
        {
            cboBuscarPor.Items.Clear();
            cboBuscarPor.Items.Add("Razon Social");
            cboBuscarPor.Items.Add("RUC");
            cboBuscarPor.Items.Add("Codigo");
            cboBuscarPor.Items.Add("Direccion");
            cboBuscarPor.SelectedIndex = 0;

            cboMEmpresa.Items.Clear();
            cboMEmpresa.Items.Add("Si");
            cboMEmpresa.Items.Add("No");
            cboMEmpresa.SelectedIndex = 0;
            
            cboMEstado.Items.Clear();
            cboMEstado.Items.Add("Activo");
            cboMEstado.Items.Add("Inactivo");
            cboMEstado.SelectedIndex = 0;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Buscar_Transportista();
        }

        private void Buscar_Transportista()
        {
            string estado = "";
            string cadena = "";
            switch (cboBuscarPor.Text)
            {
                case "Codigo":
                    cadena = " Tran_Codigo like @filtro ORDER BY Tran_Codigo";
                    break;
                case "Razon Social":
                    cadena = " Tran_Razon_Social like @filtro ORDER BY Tran_Razon_Social ";
                    break;
                case "RUC":
                    cadena = " Tran_RUC like @filtro ORDER BY Tran_RUC";
                    break;
                case "Direccion":
                    cadena = " Tran_Direccion like @filtro ORDER BY Tran_Direccion";
                    break;
            }
            string Consulta = "Select * from Transportista where " + cadena;
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

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                Buscar_Transportista();
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dgvListado_CurrentCellChanged(object sender, EventArgs e)
        {
            Mostrar_filas();
            Mostrar_Datos_Choferes();
            Mostrar_Vehiculo();
            Mostrar_Contacto();
            Mostrar_Notas();
        }

        private void Mostrar_filas()
        {
            if (dgvListado.CurrentRow != null)
            {
                txtMID.Text = Convert.ToString(this.dgvListado.CurrentRow.Cells["IDE"].Value);
                txtMCodigo.Text = Convert.ToString(this.dgvListado.CurrentRow.Cells["CODIGO"].Value);
                txtMNombre.Text = Convert.ToString(this.dgvListado.CurrentRow.Cells["NOMBRE"].Value);
                cboMEstado.Text = Convert.ToString(this.dgvListado.CurrentRow.Cells["ESTADO"].Value);
                txtMRazonSocial.Text = Convert.ToString(this.dgvListado.CurrentRow.Cells["RAZON_SOCIAL"].Value);
                txtMRuc.Text = Convert.ToString(this.dgvListado.CurrentRow.Cells["RUC"].Value);
                txtMPaterno.Text = Convert.ToString(this.dgvListado.CurrentRow.Cells["PATERNO"].Value);
                txtMMaterno.Text = Convert.ToString(this.dgvListado.CurrentRow.Cells["MATERNO"].Value);
                txtMNombre.Text = Convert.ToString(this.dgvListado.CurrentRow.Cells["NOMBRE"].Value);
                txtMLocaIde.Text = Convert.ToString(this.dgvListado.CurrentRow.Cells["LOCA_IDE"].Value);
                txtMDireccion.Text = Convert.ToString(this.dgvListado.CurrentRow.Cells["DIRECCION"].Value);
                txtMTelefono1.Text = Convert.ToString(this.dgvListado.CurrentRow.Cells["TELEFONO1"].Value);
                txtMTelefono2.Text = Convert.ToString(this.dgvListado.CurrentRow.Cells["TELEFONO2"].Value);
                txtMFax.Text = Convert.ToString(this.dgvListado.CurrentRow.Cells["FAX"].Value);
                txtMFechaConstitucion.Text = Convert.ToString(this.dgvListado.CurrentRow.Cells["FECHA_CONSTITUCION"].Value);
                dpkMFechaConstitucion.Text = Convert.ToString(this.dgvListado.CurrentRow.Cells["FECHA_CONSTITUCION"].Value);
                txtMveces.Text = Convert.ToString(this.dgvListado.CurrentRow.Cells["VECES"].Value);
                txtMCorreo.Text = Convert.ToString(this.dgvListado.CurrentRow.Cells["CORREO"].Value);
                cboMEmpresa.Text = Convert.ToString(this.dgvListado.CurrentRow.Cells["EMPRESA"].Value);
                cboMEstado.Text = Convert.ToString(this.dgvListado.CurrentRow.Cells["ESTADO"].Value);
                cboMLocalidad.SelectedValue = Convert.ToInt32(txtMLocaIde.Text);
                //
                txtCTranIde.Text = Convert.ToString(this.dgvListado.CurrentRow.Cells["IDE"].Value);
                txtMTransportista.Text = Convert.ToString(this.dgvListado.CurrentRow.Cells["RAZON_SOCIAL"].Value);

            }
        }

        private void dgvListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgvListado_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }

        private void btnMRetornar_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }

        private void btnMNuevo_Click(object sender, EventArgs e)
        {
            Operacion = "N";
            txtMTransportista.Text = "";
            txtMID.ReadOnly = true;
            txtMID.Text      =  "0";
            txtMCodigo.Text  =  "";
            txtMNombre.Text  =  "";
            cboMEstado.Text  =  "Activo";
            txtMRazonSocial.Text = "";
            txtMRuc.Text     =  "";
            txtMPaterno.Text =  "";
            txtMMaterno.Text =  "";
            txtMNombre.Text  =  "";
            txtMLocaIde.Text =  "";
            txtMDireccion.Text = "";
            txtMTelefono1.Text = "";
            txtMTelefono2.Text = "";
            txtMFax.Text     =  "";
            txtMFechaConstitucion.Text = "";
            dpkMFechaConstitucion.Text = "";
            txtMLocalidad.Text = "";
            txtMveces.Text   = "0";
            txtMCorreo.Text  = "";
            cboMEmpresa.Text = "Si";
            cboMLocalidad.Text = "Lima";
            Cambiar_Estado_Botones_Mantenimiento(false);
            Habilitar_Campos_Mantenimiento(true);
        }  

        private void btnMCancela_Click(object sender, EventArgs e)
        {
            Mostrar_filas();
            Cambiar_Estado_Botones_Mantenimiento(true);
            Habilitar_Campos_Mantenimiento(false);
        }

        private  void Cambiar_Estado_Botones_Mantenimiento(bool flag)
        {
            btnMNuevo.Enabled    = flag;
            btnMModifica.Enabled = flag;
            btnMElimina.Enabled  = flag;
            btnMCancela.Enabled  = !flag;
            btnMGraba.Enabled    = !flag;
            btnMRetornar.Enabled = flag;
        }

        private void  Habilitar_Campos_Mantenimiento(bool flag)
        {
            txtMID.ReadOnly      = !flag;
            txtMCodigo.ReadOnly  = !flag;
            txtMNombre.ReadOnly  = !flag;
            cboMEstado.Enabled   = flag;
            txtMRazonSocial.ReadOnly = !flag;
            txtMRuc.ReadOnly     = !flag;
            if (cboMEmpresa.Text == "Si")
            {
                txtMPaterno.ReadOnly = true;
                txtMMaterno.ReadOnly = true;
                txtMNombre.ReadOnly =  true;
            }
            txtMLocaIde.ReadOnly = !flag;
            txtMDireccion.ReadOnly = !flag;
            txtMTelefono1.ReadOnly = !flag;
            txtMTelefono2.ReadOnly = !flag;
            txtMFax.ReadOnly     = !flag;
            txtMFechaConstitucion.ReadOnly = !flag;
            txtMLocalidad.ReadOnly = !flag;
            txtMveces.ReadOnly  = !flag;
            txtMCorreo.ReadOnly = !flag;
            cboMEmpresa.Enabled = flag;
            cboMLocalidad.Enabled = flag;
            dpkMFechaConstitucion.Enabled = flag;
        }

        private void btnMModifica_Click(object sender, EventArgs e)
        {
            Operacion = "M"; 
            Cambiar_Estado_Botones_Mantenimiento(false);
            Habilitar_Campos_Mantenimiento(true);
        }

        private void btnMElimina_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro de Eliminar Cliente?", "Eliminacion de Cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2, MessageBoxOptions.DefaultDesktopOnly) == DialogResult.Yes)
            {
                Operacion = "E";
                Procesar_Operacion();
            }
        }

        private void btnMGraba_Click(object sender, EventArgs e)
        {
            Procesar_Operacion();
        }

        private void Procesar_Operacion()
        {
            ClsTransportistaBE TipoBE = new ClsTransportistaBE();
            TipoBE.Tran_ide = Convert.ToInt32(txtMID.Text);
            TipoBE.Tran_empresa  =  cboMEmpresa.Text;
            TipoBE.Tran_codigo = txtMCodigo.Text;
            TipoBE.Tran_razon_social = txtMRazonSocial.Text;
            TipoBE.Tran_paterno = txtMPaterno.Text;
            TipoBE.Tran_materno = txtMMaterno.Text;
            TipoBE.Tran_nombre = txtMNombre.Text;
            TipoBE.Tran_ruc = txtMRuc.Text;
            TipoBE.Tran_telefono1 = txtMTelefono1.Text;
            TipoBE.Tran_telefono2 = txtMTelefono2.Text;
            TipoBE.Tran_fax = txtMFax.Text;
            TipoBE.Tran_fecha_constitucion = Convert.ToDateTime(dpkMFechaConstitucion.Text);
            TipoBE.Tran_direccion = txtMDireccion.Text;
            TipoBE.Loca_ide = Convert.ToInt32(txtMLocaIde.Text);
            TipoBE.Tran_correo = txtMCorreo.Text;
            TipoBE.Tran_estado = cboMEstado.Text;
            TipoBE.Tran_fechainac = Convert.ToDateTime("01-01-1900");
            TipoBE.Veces        = Convert.ToInt32(txtMveces.Text);
            TipoBE.Usuario      = "ADMIN";
            TipoBE.Creacion = Convert.ToDateTime(DateTime.Today);
            

            switch (Operacion)
            {
                case "N": ClsTransportistaBC.Crear(TipoBE);
                    break;
                case "M": ClsTransportistaBC.Actualizar(TipoBE);
                    break;
                case "E": ClsTransportistaBC.Eliminar(TipoBE);
                    break;
            }

            Cambiar_Estado_Botones_Mantenimiento(true);
            Habilitar_Campos_Mantenimiento(false);
            Mostrar_dgv("");
        }

        private void cboMLocalidad_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txtMLocaIde.Text = cboMLocalidad.SelectedValue.ToString();

        }

        private void txtMCodigo_Leave(object sender, EventArgs e)
        {
            if (cboMEmpresa.Text=="Si")
            {
                txtMRazonSocial.Focus();
            }
        }

        private void cboMEmpresa_TextChanged(object sender, EventArgs e)
        {
            if (cboMEmpresa.Text=="Si")
            {
                txtMPaterno.ReadOnly = true;
                txtMMaterno.ReadOnly = true;
                txtMNombre.ReadOnly = true;
            }
            else
            {
                txtMPaterno.ReadOnly = false;
                txtMMaterno.ReadOnly = false;
                txtMNombre.ReadOnly  = false;
            }
        }

        private void TabChoferes_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
           if (tabControl1.SelectedIndex == 2)
           {
              Mostrar_Datos_Choferes();
           }
        }

        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
           
        }

        //********************* TRANSPORTISTA - CHOFER ***************************//
        void FormatoDgv_Chofer()
        {
            //------------------------------------------------------------------//      
            var dgvC = dgvListado_Chofer;

            dgvC.MultiSelect = false;
            dgvC.ReadOnly = true;
            dgvC.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvC.AllowUserToAddRows = false;
            dgvC.AllowUserToDeleteRows = false;
            /*---------Centrar titulo de cabecera --------------*/
            dgvC.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            /*-- No se hace visible la primera columna del datagrid */
            dgvC.RowHeadersVisible = false;
            /*---No premite cambiar el tamaño a la columna*/
            dgvC.AllowUserToResizeColumns = false;
            dgvC.AllowUserToResizeRows = false;
            /*---------------Tipo de fuente y tamaño-----*/
            dgvC.DefaultCellStyle.Font = new Font("Tahoma", 10);
            /*----------Alterna colores en el grid -------*/
            dgvC.RowsDefaultCellStyle.BackColor = Color.LightBlue;
            dgvC.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
            /*---Pintado de color a la cabecera del datagrid ---*/
            DataGridViewCellStyle style = this.dgvListado_Chofer.ColumnHeadersDefaultCellStyle;
            style.BackColor = Color.Honeydew;
            style.ForeColor = Color.Gray;


            dgvC.Columns.Clear();
            dgvC.ColumnCount = 26;
            // Setear Cabecera de Columna 
            dgvC.Columns[0].Name = "TRAN_IDE";
            dgvC.Columns[1].Name = "CHOFER_IDE";
            dgvC.Columns[2].Name = "TITULO";
            dgvC.Columns[3].Name = "PATERNO";
            dgvC.Columns[4].Name = "MATERNO";
            dgvC.Columns[5].Name = "NOMBRE";
            dgvC.Columns[6].Name = "LICENCIA";
            dgvC.Columns[7].Name = "DIRECCION";
            dgvC.Columns[8].Name = "LOCA_IDE";
            dgvC.Columns[9].Name = "TELEFONO_CASA";
            dgvC.Columns[10].Name = "TELEFONO_CELULAR";
            dgvC.Columns[11].Name = "FAX";
            dgvC.Columns[12].Name = "DOCU_IDEN_IDE";
            dgvC.Columns[13].Name = "DOCUMENTO";
            dgvC.Columns[14].Name = "FECHA_NACIMIENTO";
            dgvC.Columns[15].Name = "FECHA_INGRESO";
            dgvC.Columns[16].Name = "SEXO";
            dgvC.Columns[17].Name = "ESTADO_CIVIL";
            dgvC.Columns[18].Name = "CORREO";
            dgvC.Columns[19].Name = "NOTA";
            dgvC.Columns[20].Name = "CREACION";
            dgvC.Columns[21].Name = "VECES";
            dgvC.Columns[22].Name = "NOMBRE1";
            dgvC.Columns[23].Name = "VEHICULO";
            dgvC.Columns[24].Name = "PLACA";
            dgvC.Columns[25].Name = "CERTIFICADO";

            dgvC.Columns[0].Width = 50;
            dgvC.Columns[0].HeaderText = "ID";
            dgvC.Columns[0].DataPropertyName = "TRAN_IDE";
            dgvC.Columns[0].Visible = false;

            dgvC.Columns[1].Width = 60;
            dgvC.Columns[1].HeaderText = "Codigo";
            dgvC.Columns[1].DataPropertyName = "TRAN_CHOF_IDE";
            dgvC.Columns[1].Visible = false;

            dgvC.Columns[2].Width = 30;
            dgvC.Columns[2].HeaderText = "Tit";
            dgvC.Columns[2].DataPropertyName = "TRAN_CHOF_TITULO";
            dgvC.Columns[2].Visible = false;

            dgvC.Columns[3].Width = 160;
            dgvC.Columns[3].HeaderText = "ApellidoPaterno";
            dgvC.Columns[3].DataPropertyName = "TRAN_CHOF_PATERNO";
            dgvC.Columns[3].Visible = false;
            
            dgvC.Columns[4].Width = 160;
            dgvC.Columns[4].HeaderText = "Materno";
            dgvC.Columns[4].DataPropertyName = "TRAN_CHOF_MATERNO";
            dgvC.Columns[4].Visible = false;

            dgvC.Columns[5].Width = 340;
            dgvC.Columns[5].HeaderText = "Apelidos y Nombres";
            dgvC.Columns[5].DataPropertyName = "TRAN_CHOF_NOMBRE";

            dgvC.Columns[6].Width = 90;
            dgvC.Columns[6].HeaderText = "Licencia";
            dgvC.Columns[6].DataPropertyName = "TRAN_CHOF_LICENCIA";

            dgvC.Columns[7].Width = 340;
            dgvC.Columns[7].HeaderText = "Direccion";
            dgvC.Columns[7].DataPropertyName = "TRAN_CHOF_DIRECCION";
            dgvC.Columns[7].Visible = false;

            // Columnas que no Deben Verse

            dgvC.Columns[8].DataPropertyName = "LOCA_IDE";
            dgvC.Columns[8].Visible = false;
            dgvC.Columns[9].DataPropertyName = "TRAN_CHOF_TELEFONO_CASA";
            dgvC.Columns[9].Visible = false;
            dgvC.Columns[10].DataPropertyName = "TRAN_CHOF_TELEFONO_CELULAR";
            dgvC.Columns[10].Visible = false;
            dgvC.Columns[11].DataPropertyName = "TRAN_CHOF_FAX";
            dgvC.Columns[11].Visible = false;

            dgvC.Columns[12].Width = 60;
            dgvC.Columns[12].HeaderText = "Doc";
            dgvC.Columns[12].DataPropertyName = "DOCU_IDEN_IDE";
            dgvC.Columns[12].Visible = false;

            dgvC.Columns[13].Width = 100;
            dgvC.Columns[13].HeaderText = "Doc.Identidad";
            dgvC.Columns[13].DataPropertyName = "TRAN_CHOF_DOCUMENTO";
            dgvC.Columns[13].Visible = false;

            dgvC.Columns[14].DataPropertyName = "TRAN_CHOF_FECHA_NACIMIENTO";
            dgvC.Columns[14].Visible = false;
            dgvC.Columns[15].DataPropertyName = "TRAN_CHOF_FECHA_INGRESO";
            dgvC.Columns[15].Visible = false;
            dgvC.Columns[16].DataPropertyName = "TRAN_CHOF_SEXO";
            dgvC.Columns[16].Visible = false;
            dgvC.Columns[17].DataPropertyName = "TRAN_CHOF_ESTADO_CIVIL";
            dgvC.Columns[17].Visible = false;
            dgvC.Columns[18].DataPropertyName = "TRAN_CHOF_CORREO";
            dgvC.Columns[18].Visible = false;
            dgvC.Columns[19].DataPropertyName = "TRAN_CHOF_NOTA";
            dgvC.Columns[19].Visible = false;
            dgvC.Columns[20].DataPropertyName = "CREACION";
            dgvC.Columns[20].Visible = false;
            dgvC.Columns[21].DataPropertyName = "VECES";
            dgvC.Columns[21].Visible = false;
            dgvC.Columns[22].DataPropertyName = "TRAN_CHOF_NOMBRE1";
            dgvC.Columns[22].Visible = false;

            dgvC.Columns[23].Width = 180;
            dgvC.Columns[23].HeaderText = "Vehiculo";
            dgvC.Columns[23].DataPropertyName = "TRAN_CHOF_VEHICULO";

            dgvC.Columns[24].Width = 180;
            dgvC.Columns[24].HeaderText = "Placa";
            dgvC.Columns[24].DataPropertyName = "TRAN_CHOF_PLACA";

            dgvC.Columns[25].Width = 180;
            dgvC.Columns[25].HeaderText = "Certificado";
            dgvC.Columns[25].DataPropertyName = "TRAN_CHOF_CERTIFICADO";
            
        }

        private void Mostrar_Datos_Choferes()
        {
            if (dgvListado.CurrentRow != null)
            {
                txtCTransportista.Enabled = false;
                txtCTranIde.Enabled = false;
                txtCTransportista.Text = Convert.ToString(this.dgvListado.CurrentRow.Cells["RAZON_SOCIAL"].Value);
                txtCTranIde.Text = Convert.ToString(this.dgvListado.CurrentRow.Cells["IDE"].Value);
                ENResultOperation R = ClsTransportista_ChoferBC.Listar_Filtro("",Convert.ToInt32(txtCTranIde.Text));
                if (R.Proceder)
                {
                    dgvListado_Chofer.DataSource = (DataTable)R.Valor;
                }
                else
                {
                    MessageBox.Show("Error al Obtener Valores : " + R.Sms);
                }
                Habilitar_Campos_Chofer(false);
            }

        }

        private void Llenar_Campos_Choferes()
        {
            if (dgvListado_Chofer.CurrentRow != null)
            {
                txtCIde.Text = Convert.ToString(this.dgvListado_Chofer.CurrentRow.Cells["CHOFER_IDE"].Value);
                txtCNombreCompleto.Text = Convert.ToString(this.dgvListado_Chofer.CurrentRow.Cells["NOMBRE"].Value);
                txtCLicencia.Text = Convert.ToString(this.dgvListado_Chofer.CurrentRow.Cells["LICENCIA"].Value);
                txtCPlaca.Text = Convert.ToString(this.dgvListado_Chofer.CurrentRow.Cells["PLACA"].Value);
                txtCVehiculo.Text = Convert.ToString(this.dgvListado_Chofer.CurrentRow.Cells["VEHICULO"].Value);
                txtCCertificado.Text = Convert.ToString(this.dgvListado_Chofer.CurrentRow.Cells["CERTIFICADO"].Value);
                nVecesChofer = Convert.ToInt32(this.dgvListado_Chofer.CurrentRow.Cells["VECES"].Value);
                if (string.IsNullOrEmpty(txtCCertificado.Text)) txtCCertificado.Text = "";

            }
        }

        private void Habilitar_Botones_Chofer(Boolean Flag)
        {
            btnCNuevo.Enabled = Flag;
            btnCModifica.Enabled = Flag;
            btnCElimina.Enabled = Flag;
            btnCGrabar.Enabled = !Flag;
            btnCCancelar.Enabled = !Flag;
            btnCRetornar.Enabled = Flag;
        }

        private void Habilitar_Campos_Chofer(Boolean Flag)
        {
             txtCIde.Enabled = false;
             txtCNombreCompleto.Enabled = Flag;
             txtCLicencia.Enabled = Flag;
             txtCPlaca.Enabled = Flag;
             txtCVehiculo.Enabled = Flag;
             txtCCertificado.Enabled = Flag;
        }

        private void Inicializa_Campos_Chofer()
        {
             txtCIde.Text = "0";
             txtCNombreCompleto.Text = string.Empty;
             txtCPlaca.Text = string.Empty;
             txtCLicencia.Text = string.Empty;
             txtCVehiculo.Text = string.Empty;
             txtCCertificado.Text = string.Empty;
             nVecesChofer = 0;
        }
        private void Procesar_Operacion_Chofer()
        {
            ClsTransportista_ChoferBE TipoBE = new ClsTransportista_ChoferBE();
            TipoBE.Tran_ide = Convert.ToInt32(txtMID.Text);
            TipoBE.Tran_chof_ide = Convert.ToInt32(txtCIde.Text);
            TipoBE.Tran_chof_nombre = txtCNombreCompleto.Text;
            TipoBE.Tran_chof_licencia = txtCLicencia.Text;
            TipoBE.Tran_chof_vehiculo = txtCVehiculo.Text;
            TipoBE.Tran_chof_certificado = txtCCertificado.Text;
            TipoBE.Tran_chof_placa = txtCPlaca.Text;
            TipoBE.Veces = nVecesChofer;
            TipoBE.Usuario = "ADMIN";
            TipoBE.Creacion = Convert.ToDateTime(DateTime.Today);


            switch (Operacion_Chofer)
            {
                case "N": ClsTransportista_ChoferBC.Crear(TipoBE);
                    break;
                case "M": ClsTransportista_ChoferBC.Actualizar(TipoBE);
                    break;
                case "E": ClsTransportista_ChoferBC.Eliminar(TipoBE);
                    break;
            }

            Habilitar_Botones_Chofer(true);
            Habilitar_Campos_Chofer(false);
            Mostrar_Datos_Choferes();
            btnCGrabar.Text = "Grabar";

        }

        private void dgvListado_Chofer_CurrentCellChanged(object sender, EventArgs e)
        {
            Llenar_Campos_Choferes();
        }

        private void btnCNuevo_Click(object sender, EventArgs e)
        {
            Operacion_Chofer = "N";
            Inicializa_Campos_Chofer();
            Habilitar_Botones_Chofer(false);
            Habilitar_Campos_Chofer(true);
        }

        private void btnCModifica_Click(object sender, EventArgs e)
        {
            Operacion_Chofer = "M";
            Habilitar_Botones_Chofer(false);
            Habilitar_Campos_Chofer(true);
        }

        private void btnCElimina_Click(object sender, EventArgs e)
        {
            Operacion_Chofer = "E";
            Habilitar_Botones_Chofer(false);
            Habilitar_Campos_Chofer(true);
            btnCGrabar.Text = "Eliminar";
        }

        private void btnCGrabar_Click(object sender, EventArgs e)
        {
            Procesar_Operacion_Chofer();
        }

        private void btnCCancelar_Click(object sender, EventArgs e)
        {
            Habilitar_Botones_Chofer(true);
            Habilitar_Campos_Chofer(false);
            btnCGrabar.Text = "Grabar";
        }

        private void btnCRetornar_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }


        //*********************** TRANSPORTISTA - VEHICULO ********************************//

        void FormatoDgv_Vehiculo()
        {
            //------------------------------------------------------------------//      
            var dgv = dgvVehiculo;

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
            DataGridViewCellStyle style = this.dgvVehiculo.ColumnHeadersDefaultCellStyle;
            style.BackColor = Color.Honeydew;
            style.ForeColor = Color.Gray;


            dgv.Columns.Clear();
            dgv.ColumnCount = 22;
            // Setear Cabecera de Columna 

            dgv.Columns[0].Name = "TRAN_IDE";
            dgv.Columns[1].Name = "VEHI_IDE";
            dgv.Columns[2].Name = "VEHI_PLACA";
            dgv.Columns[3].Name = "VEHI_CONFIGURACION";
            dgv.Columns[4].Name = "VEHI_CERTIFICADO";
            dgv.Columns[5].Name = "MARCA_VEHI_IDE";
            dgv.Columns[6].Name = "MARCA_VEHI_NOMBRE";
            dgv.Columns[7].Name = "TIPO_VEHI_IDE";
            dgv.Columns[8].Name = "TIPO_VEHI_NOMBRE";
            dgv.Columns[9].Name = "VEHI_AÑO";
            dgv.Columns[10].Name = "VEHI_TONELAJE";
            dgv.Columns[11].Name = "VEHI_VOLUMEN";
            dgv.Columns[12].Name = "VEHI_TIPO_FRENO";
            dgv.Columns[13].Name = "COLOR_IDE";
            dgv.Columns[14].Name = "COLOR_NOMBRE";
            dgv.Columns[15].Name = "VEHI_ARO";
            dgv.Columns[16].Name = "VEHI_SERIE";
            dgv.Columns[17].Name = "VEHI_NOMBRE";
            dgv.Columns[18].Name = "VEHI_COMBUSTIBLE";
            dgv.Columns[19].Name = "VEHI_RENDIMIENTO";
            dgv.Columns[20].Name = "CREACION";
            dgv.Columns[21].Name = "VECES";


            dgv.Columns[0].Width = 50;
            dgv.Columns[0].HeaderText = "ID";
            dgv.Columns[0].DataPropertyName = "TRAN_IDE";
            dgv.Columns[0].Visible = false;

            dgv.Columns[1].Width = 50;
            dgv.Columns[1].HeaderText = "ID";
            dgv.Columns[1].DataPropertyName = "TRAN_VEHI_IDE";

            dgv.Columns[2].Width = 180;
            dgv.Columns[2].HeaderText = "Placa";
            dgv.Columns[2].DataPropertyName = "TRAN_VEHI_PLACA";

            dgv.Columns[3].Width = 100;
            dgv.Columns[3].HeaderText = "Configuracion";
            dgv.Columns[3].DataPropertyName = "TRAN_VEHI_CONFIGURACION";
            dgv.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgv.Columns[4].Width = 160;
            dgv.Columns[4].HeaderText = "Certificado";
            dgv.Columns[4].DataPropertyName = "TRAN_VEHI_CERTIFICADO";

            dgv.Columns[5].Width = 160;
            dgv.Columns[5].HeaderText = "Marca ID";
            dgv.Columns[5].DataPropertyName = "MARCA_VEHI_IDE";
            dgv.Columns[5].Visible = false;

            dgv.Columns[6].Width = 160;
            dgv.Columns[6].HeaderText = "Marca";
            dgv.Columns[6].DataPropertyName = "MARCA_VEHI_NOMBRE";

            dgv.Columns[7].Width = 160;
            dgv.Columns[7].HeaderText = "Tipo ID";
            dgv.Columns[7].DataPropertyName = "TIPO_VEHI_IDE";
            dgv.Columns[7].Visible = false;

            dgv.Columns[8].Width = 160;
            dgv.Columns[8].HeaderText = "Tipo";
            dgv.Columns[8].DataPropertyName = "TIPO_VEHI_NOMBRE";

            dgv.Columns[9].Width = 70;
            dgv.Columns[9].HeaderText = "Año";
            dgv.Columns[9].DataPropertyName = "TRAN_VEHI_AÑO";
            dgv.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgv.Columns[10].Width = 70;
            dgv.Columns[10].HeaderText = "Tonelaje";
            dgv.Columns[10].DataPropertyName = "TRAN_VEHI_TONELAJE";
            dgv.Columns[10].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgv.Columns[11].Width = 70;
            dgv.Columns[11].HeaderText = "Volumen";
            dgv.Columns[11].DataPropertyName = "TRAN_VEHI_VOLUMEN";
            dgv.Columns[11].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgv.Columns[12].DataPropertyName = "TRAN_VEHI_TIPO_FRENO";
            dgv.Columns[12].Visible = false;

            dgv.Columns[13].DataPropertyName = "COLOR_IDE";
            dgv.Columns[13].Visible = false;

            dgv.Columns[14].Width = 100;
            dgv.Columns[14].HeaderText = "Color";
            dgv.Columns[14].DataPropertyName = "COLOR_NOMBRE";

            dgv.Columns[15].DataPropertyName = "TRAN_VEHI_ARO";
            dgv.Columns[15].Visible = false;
            dgv.Columns[16].DataPropertyName = "TRAN_VEHI_SERIE";
            dgv.Columns[16].Visible = false;

            dgv.Columns[17].Width = 140;
            dgv.Columns[17].HeaderText = "Nombre";
            dgv.Columns[17].DataPropertyName = "TRAN_VEHI_NOMBRE";
            
            dgv.Columns[18].DataPropertyName = "TRAN_VEHI_COMBUSTIBLE";
            dgv.Columns[18].Visible = false;
            dgv.Columns[19].DataPropertyName = "TRAN_VEHI_RENDIMIENTO";
            dgv.Columns[19].Visible = false;
            dgv.Columns[20].DataPropertyName = "CREACION";
            dgv.Columns[20].Visible = false;
            dgv.Columns[21].DataPropertyName = "VECES";
            dgv.Columns[21].Visible = false;
        }

        private void Mostrar_Vehiculo()
        {
            if (dgvListado.CurrentRow != null)
            {
                txtVTransportista.Text = Convert.ToString(this.dgvListado.CurrentRow.Cells["RAZON_SOCIAL"].Value);
                txtVTranIde.Text = Convert.ToString(this.dgvListado.CurrentRow.Cells["IDE"].Value);
                ENResultOperation R = ClsTransportista_VehiculoBC.Listar_Filtro("", Convert.ToInt32(txtVTranIde.Text));
                if (R.Proceder)
                {
                    dgvVehiculo.DataSource = (DataTable)R.Valor;
                }
                else
                {
                    MessageBox.Show("Error al Obtener Valores : " + R.Sms);
                }
                Habilitar_Botones_Vehiculo(true);
                Habilitar_Campos_Vehiculo(false);
            }

        }

        private void Llenar_CboVMarca()
        {
            ENResultOperation R = ClsMarca_VehiculoBC.Listar("");
            if (R.Proceder)
            {
                cboVMarca.DataSource    = (DataTable)R.Valor;
                cboVMarca.DisplayMember = "MARCA_VEHI_NOMBRE";
                cboVMarca.ValueMember = "MARCA_VEHI_IDE";
                cboVMarca.AutoCompleteMode = AutoCompleteMode.Suggest;
                cboVMarca.AutoCompleteSource = AutoCompleteSource.ListItems;
            }

        }

        private void Llenar_CboVColor()
        {
            ENResultOperation R = ClsColorBC.Listar("");
            if (R.Proceder)
            {
                cboVColor.DataSource = (DataTable)R.Valor;
                cboVColor.DisplayMember = "COLOR_NOMBRE";
                cboVColor.ValueMember = "COLOR_IDE";
                cboVColor.AutoCompleteMode = AutoCompleteMode.Suggest;
                cboVColor.AutoCompleteSource = AutoCompleteSource.ListItems;
            }

        }
        private void Llenar_CboVTipo()
        {
            ENResultOperation R = ClsTipo_VehiculoBC.Listar("");
            if (R.Proceder)
            {
                cboVTipo.DataSource = (DataTable)R.Valor;
                cboVTipo.DisplayMember = "TIPO_VEHI_NOMBRE";
                cboVTipo.ValueMember = "TIPO_VEHI_IDE";
                cboVTipo.AutoCompleteMode = AutoCompleteMode.Suggest;
                cboVTipo.AutoCompleteSource = AutoCompleteSource.ListItems;
            }

        }

        private void Llenar_CboVCombustible()
        {
            cboVCombustible.Items.Add("Gasolina");
            cboVCombustible.Items.Add("Petroleo");
            cboVCombustible.Items.Add("Gas");
            cboVCombustible.SelectedIndex = 1;

        }

        private void Mostrar_Datos_Vehiculo()
        {
            if (dgvVehiculo.CurrentRow != null)
            {
                txtVIde.Text = Convert.ToString(this.dgvVehiculo.CurrentRow.Cells["VEHI_IDE"].Value);
                txtVPLaca.Text = Convert.ToString(this.dgvVehiculo.CurrentRow.Cells["VEHI_PLACA"].Value);
                txtVConfiguracion.Text = Convert.ToString(this.dgvVehiculo.CurrentRow.Cells["VEHI_CONFIGURACION"].Value);
                txtVCertificado.Text = Convert.ToString(this.dgvVehiculo.CurrentRow.Cells["VEHI_CERTIFICADO"].Value);
                txtVMarca_Ide.Text = Convert.ToString(this.dgvVehiculo.CurrentRow.Cells["MARCA_VEHI_IDE"].Value);
                TxtVAño.Text = Convert.ToString(this.dgvVehiculo.CurrentRow.Cells["VEHI_AÑO"].Value);
                txtVSerie.Text = Convert.ToString(this.dgvVehiculo.CurrentRow.Cells["VEHI_SERIE"].Value);
                txtVNombre.Text = Convert.ToString(this.dgvVehiculo.CurrentRow.Cells["VEHI_NOMBRE"].Value);
                txtVTipo_Freno.Text = Convert.ToString(this.dgvVehiculo.CurrentRow.Cells["VEHI_TIPO_FRENO"].Value);
                txtVTonelaje.Text = Convert.ToString(this.dgvVehiculo.CurrentRow.Cells["VEHI_TONELAJE"].Value);
                txtVVolumen.Text = Convert.ToString(this.dgvVehiculo.CurrentRow.Cells["VEHI_VOLUMEN"].Value);
                txtVAro.Text = Convert.ToString(this.dgvVehiculo.CurrentRow.Cells["VEHI_ARO"].Value);
                txtVRendimiento.Text = Convert.ToString(this.dgvVehiculo.CurrentRow.Cells["VEHI_RENDIMIENTO"].Value);
                cboVMarca.SelectedValue = Convert.ToInt32(this.dgvVehiculo.CurrentRow.Cells["MARCA_VEHI_IDE"].Value);
                cboVColor.SelectedValue = Convert.ToInt32(this.dgvVehiculo.CurrentRow.Cells["COLOR_IDE"].Value);
                cboVCombustible.Text = Convert.ToString(this.dgvVehiculo.CurrentRow.Cells["VEHI_COMBUSTIBLE"].Value);
                cboVTipo.SelectedValue = Convert.ToInt32(this.dgvVehiculo.CurrentRow.Cells["TIPO_VEHI_IDE"].Value);
                nVecesVehiculo = Convert.ToInt32(this.dgvVehiculo.CurrentRow.Cells["VECES"].Value);
            }
        }
        private void dgvVehiculo_CurrentCellChanged(object sender, EventArgs e)
        {
            Mostrar_Datos_Vehiculo();
        }

        private void Habilitar_Botones_Vehiculo(Boolean Flag)
        {
            btnVNuevo.Enabled = Flag;
            btnVModifica.Enabled = Flag;
            btnVElimina.Enabled = Flag;
            btnVGrabar.Enabled = !Flag;
            btnVCancelar.Enabled = !Flag;
            btnVRetornar.Enabled = Flag;
        }

        private void Habilitar_Campos_Vehiculo(Boolean Flag)
        {
                txtVIde.Enabled = false;
                txtVPLaca.Enabled = Flag;
                txtVConfiguracion.Enabled = Flag;
                txtVCertificado.Enabled = Flag;
                txtVMarca_Ide.Enabled = Flag;
                TxtVAño.Enabled = Flag;
                txtVSerie.Enabled = Flag;
                txtVNombre.Enabled = Flag;
                txtVTipo_Freno.Enabled = Flag;
                txtVTonelaje.Enabled = Flag;
                txtVVolumen.Enabled = Flag;
                txtVAro.Enabled = Flag;
                txtVRendimiento.Enabled = Flag;
                cboVMarca.Enabled = Flag;
                cboVColor.Enabled = Flag;
                cboVCombustible.Enabled = Flag;
                cboVTipo.Enabled = Flag;
        }

        private void Inicializa_Campos_Vehiculo()
        {
            txtVIde.Text = "0";
            txtVPLaca.Text = string.Empty;
            txtVConfiguracion.Text = string.Empty;
            txtVCertificado.Text = string.Empty;
            txtVMarca_Ide.Text = string.Empty;
            TxtVAño.Text = "0";
            txtVSerie.Text = string.Empty;
            txtVNombre.Text = string.Empty;
            txtVTipo_Freno.Text = string.Empty;
            txtVTonelaje.Text = "0";
            txtVVolumen.Text = "0";
            txtVAro.Text = string.Empty;
            txtVRendimiento.Text = "0";
            cboVMarca.SelectedIndex = 0;
            cboVColor.SelectedIndex = 0;
            cboVCombustible.SelectedIndex = 1;
            nVecesVehiculo = 0;
            txtVPLaca.Focus();
        }
        private void Procesar_Operacion_Vehiculo()
        {
            ClsTransportista_VehiculoBE TipoBE = new ClsTransportista_VehiculoBE();
            TipoBE.Tran_ide = Convert.ToInt32(txtMID.Text);
            TipoBE.Tran_vehi_ide = Convert.ToInt32(txtVIde.Text);
            TipoBE.Tran_vehi_placa = txtVPLaca.Text;
            TipoBE.Tran_vehi_configuracion = txtVConfiguracion.Text;
            TipoBE.Tran_vehi_certificado = txtVCertificado.Text;
            TipoBE.Marca_vehi_ide = Convert.ToInt32(cboVMarca.SelectedValue.ToString());
            TipoBE.Tipo_vehi_ide = Convert.ToInt32(cboVTipo.SelectedValue.ToString());
            
            TipoBE.Tran_vehi_año = Convert.ToInt32(TxtVAño.Text);
            TipoBE.Tran_vehi_tonelaje = Convert.ToInt32(txtVTonelaje.Text);
            TipoBE.Tran_vehi_volumen  = Convert.ToInt32(txtVVolumen.Text);
            TipoBE.Tran_vehi_tipo_freno = txtVTipo_Freno.Text;
            TipoBE.Color_ide = Convert.ToInt32(cboVColor.SelectedValue.ToString());
            TipoBE.Tran_vehi_aro = txtVAro.Text;
            TipoBE.Tran_vehi_serie = txtVSerie.Text;
            TipoBE.Tran_vehi_nombre = txtVNombre.Text;
            TipoBE.Tran_vehi_combustible = cboVCombustible.Text;
            TipoBE.Tran_vehi_rendimiento = Convert.ToDecimal(txtVRendimiento.Text);

            TipoBE.Veces = nVecesVehiculo;
            TipoBE.Usuario = "ADMIN";
            TipoBE.Creacion = Convert.ToDateTime(DateTime.Today);


            switch (Operacion_Vehiculo)
            {
                case "N": ClsTransportista_VehiculoBC.Crear(TipoBE);
                    break;
                case "M": ClsTransportista_VehiculoBC.Actualizar(TipoBE);
                    break;
                case "E": ClsTransportista_VehiculoBC.Eliminar(TipoBE);
                    break;
            }

            Habilitar_Botones_Vehiculo(true);
            Habilitar_Campos_Vehiculo(false);
            Mostrar_Vehiculo();
            btnVGrabar.Text = "Grabar";

        }
        private void btnVNuevo_Click(object sender, EventArgs e)
        {
            Operacion_Vehiculo = "N";
            Habilitar_Botones_Vehiculo(false);
            Inicializa_Campos_Vehiculo();
            Habilitar_Campos_Vehiculo(true);
        }

        private void btnVModifica_Click(object sender, EventArgs e)
        {
            Operacion_Vehiculo = "M";
            Habilitar_Botones_Vehiculo(false);
            Habilitar_Campos_Vehiculo(true);
        }

        private void btnVElimina_Click(object sender, EventArgs e)
        {
            Operacion_Vehiculo = "E";
            Habilitar_Botones_Vehiculo(false);
            Habilitar_Campos_Vehiculo(true);
            btnVGrabar.Text = "Eliminar";
        }

        private void btnVGrabar_Click(object sender, EventArgs e)
        {
            Procesar_Operacion_Vehiculo();
        }

        private void btnVCancelar_Click(object sender, EventArgs e)
        {
            Habilitar_Botones_Vehiculo(true);
            Habilitar_Campos_Vehiculo(false);
            btnVGrabar.Text = "Grabar";
        }

        private void btnVRetornar_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }

        //************************ TRANSPORTISTA - CONTACTO ******************//

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
            dgv.ColumnCount = 24;
            // Setear Cabecera de Columna 

            dgv.Columns[0].Name = "IDE";
            dgv.Columns[1].Name = "CONT_IDE";
            dgv.Columns[2].Name = "CONT_TITULO";
            dgv.Columns[3].Name = "CONT_PATERNO";
            dgv.Columns[4].Name = "CONT_MATERNO";
            dgv.Columns[5].Name = "CONT_NOMBRE";
            dgv.Columns[6].Name = "CARG_IDE";
            dgv.Columns[7].Name = "CARG_NOMBRE";
            dgv.Columns[8].Name = "CONT_DIRECCION";
            dgv.Columns[9].Name = "LOCA_IDE";
            dgv.Columns[10].Name = "LOCA_NOMBRE";
            dgv.Columns[11].Name = "CONT_TELEFONO_CASA";
            dgv.Columns[12].Name = "CONT_TELEFONO_CELULAR";
            dgv.Columns[13].Name = "CONT_FAX";
            dgv.Columns[14].Name = "DOCU_IDEN_IDE";
            dgv.Columns[15].Name = "DOCU_IDEN_NOMBRE";
            dgv.Columns[16].Name = "CONT_DOCUMENTO";
            dgv.Columns[17].Name = "CONT_FECHA_NACIMIENTO";
            dgv.Columns[18].Name = "CONT_SEXO";
            dgv.Columns[19].Name = "CONT_ESTADO_CIVIL";
            dgv.Columns[20].Name = "CONT_CORREO";
            dgv.Columns[21].Name = "CONT_NOTA";
            dgv.Columns[22].Name = "CREACION";
            dgv.Columns[23].Name = "VECES";

            dgv.Columns[0].Width = 50;
            dgv.Columns[0].HeaderText = "ID";
            dgv.Columns[0].DataPropertyName = "TRAN_IDE";
            dgv.Columns[0].Visible = false;

            dgv.Columns[1].Width = 50;
            dgv.Columns[1].HeaderText = "ID";
            dgv.Columns[1].DataPropertyName = "TRAN_CONT_IDE";

            dgv.Columns[2].Width = 50;
            dgv.Columns[2].HeaderText = "Tit";
            dgv.Columns[2].DataPropertyName = "TRAN_CONT_TITULO";

            dgv.Columns[3].Width = 180;
            dgv.Columns[3].HeaderText = "Paterno";
            dgv.Columns[3].DataPropertyName = "TRAN_CONT_PATERNO";

            dgv.Columns[4].Width = 180;
            dgv.Columns[4].HeaderText = "Materno";
            dgv.Columns[4].DataPropertyName = "TRAN_CONT_MATERNO";

            dgv.Columns[5].Width = 180;
            dgv.Columns[5].HeaderText = "Nombre";
            dgv.Columns[5].DataPropertyName = "TRAN_CONT_NOMBRE";
              
            dgv.Columns[6].Width = 160;
            dgv.Columns[6].HeaderText = "Cargo ID";
            dgv.Columns[6].DataPropertyName = "CARG_IDE";
            dgv.Columns[6].Visible = false;

            dgv.Columns[7].Width = 160;
            dgv.Columns[7].HeaderText = "Cargo";
            dgv.Columns[7].DataPropertyName = "CARG_NOMBRE";

            dgv.Columns[8].Width = 160;
            dgv.Columns[8].HeaderText = "Direccion";
            dgv.Columns[8].DataPropertyName = "TRAN_CONT_DIRECCION";
            dgv.Columns[8].Visible = false;

            dgv.Columns[9].Width = 160;
            dgv.Columns[9].HeaderText = "Localidad ID";
            dgv.Columns[9].DataPropertyName = "LOCA_IDE";
            dgv.Columns[9].Visible = false;

            dgv.Columns[10].Width = 160;
            dgv.Columns[10].HeaderText = "Localidad";
            dgv.Columns[10].DataPropertyName = "LOCA_NOMBRE";

            dgv.Columns[11].Width = 70;
            dgv.Columns[11].HeaderText = "Telefono Casa";
            dgv.Columns[11].DataPropertyName = "TRAN_CONT_TELEFONO_CASA";
            dgv.Columns[11].Visible = false;

            dgv.Columns[12].Width = 70;
            dgv.Columns[12].HeaderText = "Celular";
            dgv.Columns[12].DataPropertyName = "TRAN_CONT_TELEFONO_CELULAR";
            dgv.Columns[12].Visible = false;

            dgv.Columns[13].Width = 70;
            dgv.Columns[13].HeaderText = "Fax";
            dgv.Columns[13].DataPropertyName = "TRAN_CONT_FAX";
            dgv.Columns[13].Visible = false;

            dgv.Columns[14].DataPropertyName = "DOCU_IDEN_IDE";
            dgv.Columns[14].Visible = false;

            dgv.Columns[15].DataPropertyName = "DOCU_IDEN_NOMBRE";
            dgv.Columns[15].Visible = false;

            dgv.Columns[16].DataPropertyName = "TRAN_CONT_DOCUMENTO";
            dgv.Columns[16].Visible = false;

            dgv.Columns[17].DataPropertyName = "TRAN_CONT_FECHA_NACIMIENTO";
            dgv.Columns[17].Visible = false;

            dgv.Columns[18].DataPropertyName = "TRAN_CONT_SEXO";
            dgv.Columns[18].Visible = false;
            dgv.Columns[19].DataPropertyName = "TRAN_CONT_ESTADO_CIVIL";
            dgv.Columns[19].Visible = false;

            dgv.Columns[20].DataPropertyName = "TRAN_CONT_CORREO";
            dgv.Columns[20].Visible = false;

            dgv.Columns[21].DataPropertyName = "TRAN_CONT_NOTA";
            dgv.Columns[21].Visible = false;
 
            dgv.Columns[22].DataPropertyName = "CREACION";
            dgv.Columns[22].Visible = false;
            dgv.Columns[23].DataPropertyName = "VECES";
            dgv.Columns[23].Visible = false;
        }

        private void Mostrar_Contacto()
        {
            if (dgvListado.CurrentRow != null)
            {
                txtCoTransportista.Enabled = false;
                txtCoTranIde.Enabled = false;

                txtCoTransportista.Text = Convert.ToString(this.dgvListado.CurrentRow.Cells["RAZON_SOCIAL"].Value);
                txtCoTranIde.Text = Convert.ToString(this.dgvListado.CurrentRow.Cells["IDE"].Value);
                ENResultOperation R = ClsTransportista_ContactoBC.Listar_Filtro("", Convert.ToInt32(txtCoTranIde.Text));
                if (R.Proceder)
                {
                    dgvContacto.DataSource = (DataTable)R.Valor;
                }
                else
                {
                    MessageBox.Show("Error al Obtener Valores : " + R.Sms);
                }
            }
            Habilitar_Botones_Contacto(true);
            Habilitar_Campos_Contacto(false);
        }

        private void Llenar_Campos_Contacto()
        {
            if (dgvContacto.CurrentRow != null)
            {
                txtCoIde.Text = Convert.ToString(this.dgvContacto.CurrentRow.Cells["CONT_IDE"].Value);
                txtCoTitulo.Text = Convert.ToString(this.dgvContacto.CurrentRow.Cells["CONT_TITULO"].Value);
                txtCoPaterno.Text = Convert.ToString(this.dgvContacto.CurrentRow.Cells["CONT_PATERNO"].Value);
                txtCoMaterno.Text = Convert.ToString(this.dgvContacto.CurrentRow.Cells["CONT_MATERNO"].Value);
                txtCoNombre.Text = Convert.ToString(this.dgvContacto.CurrentRow.Cells["CONT_NOMBRE"].Value);
                cboCoCargo.SelectedValue = Convert.ToInt32(this.dgvContacto.CurrentRow.Cells["CARG_IDE"].Value);
                //txtCoIde.Text = Convert.ToString(this.dgvContacto.CurrentRow.Cells["CARG_NOMBRE"].Value);
                txtCoDireccion.Text = Convert.ToString(this.dgvContacto.CurrentRow.Cells["CONT_DIRECCION"].Value);
                cboCoLocalidad.SelectedValue = Convert.ToInt32(this.dgvContacto.CurrentRow.Cells["LOCA_IDE"].Value);
                txtCoLoca_Ide.Text = Convert.ToString(this.dgvContacto.CurrentRow.Cells["LOCA_IDE"].Value);
                txtCoTelefonoCasa.Text = Convert.ToString(this.dgvContacto.CurrentRow.Cells["CONT_TELEFONO_CASA"].Value);
                txtCoCelular.Text = Convert.ToString(this.dgvContacto.CurrentRow.Cells["CONT_TELEFONO_CELULAR"].Value);
                txtCoFax.Text = Convert.ToString(this.dgvContacto.CurrentRow.Cells["CONT_FAX"].Value);
                cboCoTipoDoc.SelectedValue = Convert.ToInt32(this.dgvContacto.CurrentRow.Cells["DOCU_IDEN_IDE"].Value);
                //txtCoIde.Text = Convert.ToString(this.dgvContacto.CurrentRow.Cells["DOCU_IDEN_NOMBRE"].Value);
                txtCoNumero.Text = Convert.ToString(this.dgvContacto.CurrentRow.Cells["CONT_DOCUMENTO"].Value);
                txtCoFecNac.Text = Convert.ToString(this.dgvContacto.CurrentRow.Cells["CONT_FECHA_NACIMIENTO"].Value);
                cboCoSexo.Text = Convert.ToString(this.dgvContacto.CurrentRow.Cells["CONT_SEXO"].Value);
                cboCoEstadoCivil.Text = Convert.ToString(this.dgvContacto.CurrentRow.Cells["CONT_ESTADO_CIVIL"].Value);
                txtCoCorreo.Text = Convert.ToString(this.dgvContacto.CurrentRow.Cells["CONT_CORREO"].Value);
                txtCoNota.Text = Convert.ToString(this.dgvContacto.CurrentRow.Cells["CONT_NOTA"].Value);
                nVecesContacto = Convert.ToInt32(this.dgvContacto.CurrentRow.Cells["VECES"].Value);
            }
        }

        private void Llenar_cboCoCargo()
        {
                ENResultOperation R = ClsCargoBC.Listar("");
                if (R.Proceder)
                {
                    cboCoCargo.DataSource = (DataTable)R.Valor;
                    cboCoCargo.DisplayMember = "CARG_NOMBRE";
                    cboCoCargo.ValueMember = "CARG_IDE";
                    cboCoCargo.AutoCompleteMode = AutoCompleteMode.Suggest;
                    cboCoCargo.AutoCompleteSource = AutoCompleteSource.ListItems;
                }
        }

        private void Llenar_cboCoLocalidad()
        {
            ENResultOperation R = ClsLocalidadBC.Listar("");
            if (R.Proceder)
            {
                cboCoLocalidad.DataSource = (DataTable)R.Valor;
                cboCoLocalidad.DisplayMember = "LOCA_NOMBRE";
                cboCoLocalidad.ValueMember = "LOCA_IDE";
                cboCoLocalidad.AutoCompleteMode = AutoCompleteMode.Suggest;
                cboCoLocalidad.AutoCompleteSource = AutoCompleteSource.ListItems;
            }
        }
        private void Llenar_cboCoTipoDoc()
        {
            ENResultOperation R = ClsTipo_Documento_IdentidadBC.Listar("");
            if (R.Proceder)
            {
                cboCoTipoDoc.DataSource = (DataTable)R.Valor;
                cboCoTipoDoc.DisplayMember = "DOCU_IDEN_NOMBRE";
                cboCoTipoDoc.ValueMember = "DOCU_IDEN_IDE";
                cboCoTipoDoc.AutoCompleteMode = AutoCompleteMode.Suggest;
                cboCoTipoDoc.AutoCompleteSource = AutoCompleteSource.ListItems;
            }
        }

        private void Llenar_cboCoSexo()
        {
            cboCoSexo.Items.Clear();
            cboCoSexo.Items.Add("Masculino");
            cboCoSexo.Items.Add("Femenino");
            cboCoSexo.SelectedIndex = 0;
        }

        private void Llenar_cboCoEstadoCivil()
        {
            cboCoEstadoCivil.Items.Clear();
            cboCoEstadoCivil.Items.Add("Soltero");
            cboCoEstadoCivil.Items.Add("Casado");
            cboCoEstadoCivil.Items.Add("Viudo");
            cboCoEstadoCivil.Items.Add("Divorciado");
            cboCoEstadoCivil.SelectedIndex = 0;
        }
        private void dgvContacto_CurrentCellChanged(object sender, EventArgs e)
        {
            Llenar_Campos_Contacto();
        }



        private void btnCoRetornar_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }

        private void Habilitar_Botones_Contacto(Boolean Flag)
        {
            btnCoNuevo.Enabled = Flag;
            btnCoModifica.Enabled = Flag;
            btnCoElimina.Enabled = Flag;
            btnCoGrabar.Enabled = !Flag;
            btnCoCancelar.Enabled = !Flag;
            btnCoRetornar.Enabled = Flag;
        }

        private void Habilitar_Campos_Contacto(Boolean Flag)
        {
            txtCoIde.Enabled = false;
            txtCoTitulo.Enabled = Flag;
            txtCoPaterno.Enabled = Flag;
            txtCoMaterno.Enabled = Flag;
            txtCoNombre.Enabled = Flag;
            cboCoCargo.Enabled = Flag;
            txtCoDireccion.Enabled = Flag;
            cboCoLocalidad.Enabled = Flag;
            txtCoLoca_Ide.Enabled = Flag;
            txtCoTelefonoCasa.Enabled = Flag;
            txtCoCelular.Enabled = Flag;
            txtCoFax.Enabled = Flag;
            cboCoTipoDoc.Enabled = Flag;
            txtCoNumero.Enabled = Flag;
            txtCoFecNac.Enabled = Flag;
            cboCoSexo.Enabled = Flag;
            cboCoEstadoCivil.Enabled = Flag;
            txtCoCorreo.Enabled = Flag;
            txtCoNota.Enabled = Flag;
            txtCoNumero.Focus();
        }

        private void Inicializa_Campos_Contacto()
        {
            txtCoIde.Text = "0";
            txtCoTitulo.Text = string.Empty;
            txtCoPaterno.Text = string.Empty;
            txtCoMaterno.Text = string.Empty;
            txtCoNombre.Text = string.Empty;
            cboCoCargo.SelectedIndex = 0;
            txtCoDireccion.Text = string.Empty;
            cboCoLocalidad.SelectedIndex = 0;
            txtCoLoca_Ide.Text = cboCoLocalidad.SelectedValue.ToString();
            txtCoTelefonoCasa.Text = string.Empty;
            txtCoCelular.Text = string.Empty;
            txtCoFax.Text = string.Empty;
            cboCoTipoDoc.SelectedIndex = 0;
            txtCoNumero.Text = string.Empty;
            txtCoFecNac.Text = string.Empty;
            cboCoSexo.Text = "Masculino";
            cboCoEstadoCivil.Text = "Soltero";
            txtCoCorreo.Text = string.Empty;
            txtCoNota.Text = string.Empty;
            nVecesContacto = 0;
        }
        private void Procesar_Operacion_Contacto()
        {
            ClsTransportista_ContactoBE TipoBE = new ClsTransportista_ContactoBE();
            TipoBE.Tran_ide = Convert.ToInt32(txtMID.Text);
            TipoBE.Tran_cont_ide = Convert.ToInt32(txtCoIde.Text);
            TipoBE.Tran_cont_titulo = txtCoTitulo.Text;
            TipoBE.Tran_cont_paterno = txtCoPaterno.Text;
            TipoBE.Tran_cont_materno = txtCoMaterno.Text;
            TipoBE.Tran_cont_nombre = txtCoNombre.Text;
            TipoBE.Carg_ide = Convert.ToInt32(cboCoCargo.SelectedValue.ToString());
            TipoBE.Tran_cont_direccion = txtCoDireccion.Text;
            TipoBE.Loca_ide = Convert.ToInt32(cboCoLocalidad.SelectedValue.ToString());
            TipoBE.Tran_cont_telefono_casa = txtCoTelefonoCasa.Text;
            TipoBE.Tran_cont_telefono_celular = txtCoCelular.Text;
            TipoBE.Tran_cont_fax = txtCoFax.Text;
            TipoBE.Docu_iden_ide = Convert.ToInt32(cboCoTipoDoc.SelectedValue.ToString());
            TipoBE.Tran_cont_documento = txtCoNumero.Text;
            TipoBE.Tran_cont_fecha_nacimiento = txtCoFecNac.Text;
            TipoBE.Tran_cont_sexo = cboCoSexo.Text;
            TipoBE.Tran_cont_estado_civil = cboCoEstadoCivil.Text;
            TipoBE.Tran_cont_correo = txtCoCorreo.Text;
            TipoBE.Tran_cont_nota = txtCoNota.Text;
            TipoBE.Veces = nVecesContacto;
            TipoBE.Usuario = "ADMIN";
            TipoBE.Creacion = Convert.ToDateTime(DateTime.Today);


            switch (Operacion_Contacto)
            {
                case "N": ClsTransportista_ContactoBC.Crear(TipoBE);
                    break;
                case "M": ClsTransportista_ContactoBC.Actualizar(TipoBE);
                    break;
                case "E": ClsTransportista_ContactoBC.Eliminar(TipoBE);
                    break;
            }

            Habilitar_Botones_Contacto(true);
            Habilitar_Campos_Contacto(false);
            Mostrar_Contacto();
            btnCoGrabar.Text = "Grabar";

        }

        private void btnCoNuevo_Click(object sender, EventArgs e)
        {
            Operacion_Contacto = "N";
            Habilitar_Botones_Contacto(false);
            Inicializa_Campos_Contacto();
            Habilitar_Campos_Contacto(true);
        }

        private void btnCoModifica_Click(object sender, EventArgs e)
        {
            Operacion_Contacto = "M";
            Habilitar_Botones_Contacto(false);
            Habilitar_Campos_Contacto(true);
        }

        private void btnCoElimina_Click(object sender, EventArgs e)
        {
            Operacion_Contacto = "E";
            Habilitar_Botones_Contacto(false);
            btnCoGrabar.Text = "Eliminar";
        }

        private void btnCoGrabar_Click(object sender, EventArgs e)
        {
            Procesar_Operacion_Contacto();
        }

        private void btnCoCancelar_Click(object sender, EventArgs e)
        {
            Habilitar_Botones_Contacto(true);
            Habilitar_Campos_Contacto(false);
            btnCoGrabar.Text = "Grabar";
        }

        private void cboCoLocalidad_SelectedValueChanged(object sender, EventArgs e)
        {
            txtCoLoca_Ide.Text = cboCoLocalidad.SelectedValue.ToString();
        }

        //******************** TRANSPORTISTA -  NOTA ********************************/

        void FormatoDgv_Notas()
        {
            //------------------------------------------------------------------//      
            var dgv = dgvNotas;

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
            DataGridViewCellStyle style = this.dgvNotas.ColumnHeadersDefaultCellStyle;
            style.BackColor = Color.Honeydew;
            style.ForeColor = Color.Gray;


            dgv.Columns.Clear();
            dgv.ColumnCount = 5;
            // Setear Cabecera de Columna 

            dgv.Columns[0].Name = "IDE";
            dgv.Columns[1].Name = "NOTA_IDE";
            dgv.Columns[2].Name = "NOTA_NOTA";
            dgv.Columns[3].Name = "CREACION";
            dgv.Columns[4].Name = "VECES";

            dgv.Columns[0].Width = 50;
            dgv.Columns[0].HeaderText = "ID";
            dgv.Columns[0].DataPropertyName = "TRAN_IDE";
            dgv.Columns[0].Visible = false;

            dgv.Columns[1].Width = 50;
            dgv.Columns[1].HeaderText = "ID";
            dgv.Columns[1].DataPropertyName = "TRAN_NOTA_IDE";

            dgv.Columns[2].Width = 500;
            dgv.Columns[2].HeaderText = "Nota";
            dgv.Columns[2].DataPropertyName = "TRAN_NOTA_NOTA";


            dgv.Columns[3].DataPropertyName = "CREACION";
            dgv.Columns[3].Visible = false;
            dgv.Columns[4].DataPropertyName = "VECES";
            dgv.Columns[4].Visible = false;
        }

        private void Mostrar_Notas()
        {
            if (dgvListado.CurrentRow != null)
            {
                txtNTransportista.Enabled = false;
                txtNTranIde.Enabled = false;

                txtNTransportista.Text = Convert.ToString(this.dgvListado.CurrentRow.Cells["RAZON_SOCIAL"].Value);
                txtNTranIde.Text = Convert.ToString(this.dgvListado.CurrentRow.Cells["IDE"].Value);
                ENResultOperation R = ClsTransportista_NotaBC.Listar_Filtro("", Convert.ToInt32(txtNTranIde.Text));
                if (R.Proceder)
                {
                    dgvNotas.DataSource = (DataTable)R.Valor;
                }
                else
                {
                    MessageBox.Show("Error al Obtener Valores : " + R.Sms);
                }
            }
            Habilitar_Botones_Notas(true);
            Habilitar_Campos_Notas(false);
        }

        private void Llenar_Campos_Notas()
        {
            if (dgvNotas.CurrentRow != null)
            {
                txtNIde.Text = Convert.ToString(this.dgvNotas.CurrentRow.Cells["NOTA_IDE"].Value);
                txtNNota.Text = Convert.ToString(this.dgvNotas.CurrentRow.Cells["NOTA_NOTA"].Value);
                nVecesNotas  = Convert.ToInt32(this.dgvNotas.CurrentRow.Cells["VECES"].Value);
            }
        }

        private void dgvNotas_CurrentCellChanged(object sender, EventArgs e)
        {
            Llenar_Campos_Notas();
        }

        private void Habilitar_Botones_Notas(Boolean Flag)
        {
            btnNNuevo.Enabled = Flag;
            btnNModifica.Enabled = Flag;
            btnNElimina.Enabled = Flag;
            btnNGrabar.Enabled = !Flag;
            btnNCancelar.Enabled = !Flag;
            btnNRetornar.Enabled = Flag;
        }

        private void Habilitar_Campos_Notas(Boolean Flag)
        {
            txtNIde.Enabled = false;
            txtNNota.Enabled = Flag;
        }

        private void Inicializa_Campos_Notas()
        {
            txtNIde.Text  = "0";
            txtNNota.Text = string.Empty;
            nVecesNotas   = 0;
        }
        private void Procesar_Operacion_Notas()
        {
            ClsTransportista_NotaBE TipoBE = new ClsTransportista_NotaBE();
            TipoBE.Tran_ide = Convert.ToInt32(txtMID.Text);
            TipoBE.Tran_nota_ide = Convert.ToInt32(txtNIde.Text);
            TipoBE.Tran_nota_nota = txtNNota.Text;
            TipoBE.Veces = nVecesNotas;
            TipoBE.Usuario = "ADMIN";
            TipoBE.Creacion = Convert.ToDateTime(DateTime.Today);


            switch (Operacion_Notas)
            {
                case "N": ClsTransportista_NotaBC.Crear(TipoBE);
                    break;
                case "M": ClsTransportista_NotaBC.Actualizar(TipoBE);
                    break;
                case "E": ClsTransportista_NotaBC.Eliminar(TipoBE);
                    break;
            }

            Habilitar_Botones_Notas(true);
            Habilitar_Campos_Notas(false);
            Mostrar_Notas();
            btnNGrabar.Text = "Grabar";

        }
        private void btnNNuevo_Click(object sender, EventArgs e)
        {
            Operacion_Notas = "N";
            Habilitar_Botones_Notas(false);
            Inicializa_Campos_Notas();
            Habilitar_Campos_Notas(true);
        }

        private void btnNModifica_Click(object sender, EventArgs e)
        {
            Operacion_Notas = "M";
            Habilitar_Botones_Notas(false);
            Habilitar_Campos_Notas(true);
        }

        private void btnNElimina_Click(object sender, EventArgs e)
        {
            Operacion_Notas = "E";
            Habilitar_Botones_Notas(false);
            btnNGrabar.Text = "Eliminar";
        }

        private void btnNGrabar_Click(object sender, EventArgs e)
        {
            Procesar_Operacion_Notas();
        }

        private void btnNCancelar_Click(object sender, EventArgs e)
        {
            Habilitar_Botones_Notas(true);
            Habilitar_Campos_Notas(false);
            btnNGrabar.Text = "Grabar";
        }

        private void btnNRetornar_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }

        
    }
}
