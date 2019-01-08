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

namespace CapaPresentacion.Clientes
{
    public partial class frmCliente : Form
    {
        private Int32 nVeces = 0;
        private Int32 nVeces_Contacto = 0;
        private Int32 nVeces_Punto_Partida = 0;
        private Int32 nVeces_Lugar_Entrega = 0;
        string Operacion = null;  // Operaciones : N = Nuevo / M = Modificar E = Eliminar
        string Operacion_Contacto = null;
        string Operacion_Punto_Partida = null;
        string Operacion_Lugar_Entrega = null;
        private SqlConnection Con = null;
        private SqlCommand Cmd;
        private SqlDataReader dr = null;
        string strcon = ConfigurationManager.ConnectionStrings["conex1"].ConnectionString;
        public frmCliente()
        {
            InitializeComponent();
        }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            FormatoDgv_Lugar_Entrega();
            FormatoDgv_Contacto();
            FormatoDgv_Punto_Partida();
            FormatoDgv();
            Mostrar("00");
            Mostrar_Dgv();
            Cargar_ComboBox();
            Llenar_CboMLocalidad();
            Llenar_CboMActividad();
            Llenar_CboMCategoria();
            Llenar_CboMTipoCliente();
            Llenar_CboMTipoDoc();
            Habilitar_Campos_Mantenimimiento(false);
            //**** Contacto *****//
            Llenar_CboCLocalidad();
            Llenar_CboCTipoDoc();
            Llenar_CboCCargo();
            LLenar_CboCSexo();
            Llenar_CboCEstadoCivil();
            Habilitar_Campos_Contacto(false);
            //******* PUNTO DE PARTIDA *************//
            Llenar_CboPLocalidad();
            //******* LUGAR DE ENTREGA *************//
            Llenar_CboLLocalidad();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
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
            dgv.ColumnCount = 23;
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
            dgv.Columns[11].Name = "TIPO_CLIE";
            dgv.Columns[12].Name = "ACTI_CLIE";
            dgv.Columns[13].Name = "CATE_CLIE";
            dgv.Columns[14].Name = "CORREO";
            dgv.Columns[15].Name = "PATERNO";
            dgv.Columns[16].Name = "MATERNO";
            dgv.Columns[17].Name = "NOMBRE";
            dgv.Columns[18].Name = "ESTADO";
            dgv.Columns[19].Name = "FECHAINAC";
            dgv.Columns[20].Name = "CREACION";
            dgv.Columns[21].Name = "VECES";
            dgv.Columns[22].Name = "DOCU_IDEN_IDE";

            dgv.Columns[0].Width = 60;
            dgv.Columns[0].HeaderText = "ID";
            dgv.Columns[0].DataPropertyName = "CLIE_IDE";

            dgv.Columns[1].Width = 120;
            dgv.Columns[1].HeaderText = "Codigo";
            dgv.Columns[1].DataPropertyName = "CLIE_CODIGO";

            dgv.Columns[2].Width = 320;
            dgv.Columns[2].HeaderText = "Razon Social";
            dgv.Columns[2].DataPropertyName = "CLIE_RAZON_SOCIAL";

            dgv.Columns[3].Width = 65;
            dgv.Columns[3].HeaderText = "Empresa";
            dgv.Columns[3].DataPropertyName = "CLIE_EMPRESA";
            dgv.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


            dgv.Columns[4].Width = 120;
            dgv.Columns[4].HeaderText = "RUC";
            dgv.Columns[4].DataPropertyName = "CLIE_RUC";

            dgv.Columns[5].Width = 20;
            dgv.Columns[5].HeaderText = "F.Constitucion";
            dgv.Columns[5].DataPropertyName = "CLIE_FECHA_CONSTITUCION";
            dgv.Columns[5].Visible = false;

            dgv.Columns[6].Width = 269;
            dgv.Columns[6].HeaderText = "Direccion";
            dgv.Columns[6].DataPropertyName = "CLIE_DIRECCION";
            // Columnas que no Deben Verse

            dgv.Columns[7].DataPropertyName = "LOCA_IDE";
            dgv.Columns[7].Visible = false;
            dgv.Columns[8].DataPropertyName = "CLIE_TELEFONO1";
            dgv.Columns[8].Visible = false;
            dgv.Columns[9].DataPropertyName = "CLIE_TELEFONO2";
            dgv.Columns[9].Visible = false;
            dgv.Columns[10].DataPropertyName = "CLIE_FAX";
            dgv.Columns[10].Visible = false;
            dgv.Columns[11].DataPropertyName = "TIPO_CLIE_IDE";
            dgv.Columns[11].Visible = false;
            dgv.Columns[12].DataPropertyName = "ACTI_CLIE_IDE";
            dgv.Columns[12].Visible = false;
            dgv.Columns[13].DataPropertyName = "CATE_CLIE_IDE";
            dgv.Columns[13].Visible = false;


            dgv.Columns[14].DataPropertyName = "CLIE_CORREO";
            dgv.Columns[14].Visible = false;
            dgv.Columns[15].DataPropertyName = "CLIE_PATERNO";
            dgv.Columns[15].Visible = false;
            dgv.Columns[16].DataPropertyName = "CLIE_MATERNO";
            dgv.Columns[16].Visible = false;
            dgv.Columns[17].DataPropertyName = "CLIE_NOMBRE";
            dgv.Columns[17].Visible = false;
            dgv.Columns[18].DataPropertyName = "CLIE_ESTADO";
            dgv.Columns[18].Visible = false;
            dgv.Columns[19].DataPropertyName = "CLIE_FECHAINAC";
            dgv.Columns[19].Visible = false;
            dgv.Columns[20].DataPropertyName = "CREACION";
            dgv.Columns[20].Visible = false;
            dgv.Columns[21].DataPropertyName ="VECES";
            dgv.Columns[21].Visible = false;
            dgv.Columns[22].DataPropertyName = "DOCU_IDEN_IDE";
            dgv.Columns[22].Visible = false;
        }

        private void Mostrar(string filtro)
        {
            ENResultOperation R = ClsClientesBC.Listar(filtro);
            if (R.Proceder)
            {
                dgvListado.DataSource = (DataTable)R.Valor;
            }
            else
            {
                MessageBox.Show("Error al Obtener Valores : " + R.Sms);
            }
        }

        private void Mostrar_Dgv()
        {

            if (this.dgvListado.CurrentRow != null)
            {
                txtMIde.Text = this.dgvListado.CurrentRow.Cells["IDE"].Value.ToString();
                txtMCodigo.Text = this.dgvListado.CurrentRow.Cells["CODIGO"].Value.ToString();
                txtMRuc.Text = this.dgvListado.CurrentRow.Cells["RUC"].Value.ToString();
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
                txtMActi_Ide.Text = this.dgvListado.CurrentRow.Cells["ACTI_CLIE"].Value.ToString();
                cboMActividad.SelectedValue = this.dgvListado.CurrentRow.Cells["ACTI_CLIE"].Value.ToString();
                txtMCate_Ide.Text = this.dgvListado.CurrentRow.Cells["CATE_CLIE"].Value.ToString();
                cboMCategoria.SelectedValue = this.dgvListado.CurrentRow.Cells["CATE_CLIE"].Value.ToString();
                txtMTipo_Ide.Text = this.dgvListado.CurrentRow.Cells["TIPO_CLIE"].Value.ToString();
                cboMTipoCliente.SelectedValue = this.dgvListado.CurrentRow.Cells["TIPO_CLIE"].Value.ToString();
                dtpMFechaConstitucion.Text = this.dgvListado.CurrentRow.Cells["FECHA_CONSTITUCION"].Value.ToString();
                cboMTipoDoc.SelectedValue = this.dgvListado.CurrentRow.Cells["DOCU_IDEN_IDE"].Value.ToString();
                nVeces = Convert.ToInt32(this.dgvListado.CurrentRow.Cells["VECES"].Value.ToString());
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
            cboMLocalidad.ValueMember   = "LOCA_IDE";
            cboMLocalidad.AutoCompleteMode = AutoCompleteMode.Suggest;
            cboMLocalidad.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void Llenar_CboMActividad()
        {
            ENResultOperation R = ClsActividad_ClienteBC.Listar("");
            if (R.Proceder) cboMActividad.DataSource = (DataTable)R.Valor;
            cboMActividad.DisplayMember = "ACTI_CLIE_NOMBRE";
            cboMActividad.ValueMember = "ACTI_CLIE_IDE";
            cboMActividad.AutoCompleteMode = AutoCompleteMode.Suggest;
            cboMActividad.AutoCompleteSource = AutoCompleteSource.ListItems;
            
        }
        private void Llenar_CboMCategoria()
        {
            ENResultOperation R = ClsCategoria_ClienteBC.Listar("");
            if (R.Proceder) cboMCategoria.DataSource = (DataTable)R.Valor;
            cboMCategoria.DisplayMember = "CATE_CLIE_NOMBRE";
            cboMCategoria.ValueMember = "CATE_CLIE_IDE";
            cboMCategoria.AutoCompleteMode = AutoCompleteMode.Suggest;
            cboMCategoria.AutoCompleteSource = AutoCompleteSource.ListItems;

        }
        private void Llenar_CboMTipoCliente()
        {
            ENResultOperation R = ClsTipo_ClienteBC.Listar("");
            if (R.Proceder) cboMTipoCliente.DataSource = (DataTable)R.Valor;
            cboMTipoCliente.DisplayMember = "TIPO_CLIE_NOMBRE";
            cboMTipoCliente.ValueMember = "TIPO_CLIE_IDE";
            cboMTipoCliente.AutoCompleteMode = AutoCompleteMode.Suggest;
            cboMTipoCliente.AutoCompleteSource = AutoCompleteSource.ListItems;

        }

        private void  Inicializa_Campos_Mantenimiento()
        {
            txtMIde.Text = "0";
            txtMCodigo.Text = String.Empty;
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
            cboMTipoDoc.SelectedIndex = 1;
            txtMLoca_Ide.Text = String.Empty;
            cboMLocalidad.SelectedIndex = 0;
            txtMActi_Ide.Text = String.Empty;
            cboMActividad.SelectedIndex = 0;
            txtMCate_Ide.Text = String.Empty;
            cboMCategoria.SelectedIndex = 0;
            txtMTipo_Ide.Text = String.Empty;
            cboMTipoCliente.SelectedIndex = 0;
            dtpMFechaConstitucion.Text = String.Empty;
            txtMPaterno.Enabled = false;
            txtMMaterno.Enabled = false;
            txtMNombre.Enabled = false;
            nVeces = 0;
        }

        private void Valida_Empresa()
        {
            if (cboMEmpresa.Text == "Si")
            {
                txtMPaterno.Text = String.Empty;
                txtMMaterno.Text = String.Empty;
                txtMNombre.Text = String.Empty;
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

        private void txtMRazon_Social_Enter(object sender, EventArgs e)
        {
            if (cboMEmpresa.Text == "No")
            {
                txtMRazon_Social.Text = txtMPaterno.Text + ' ' + txtMMaterno.Text + ' ' + txtMNombre.Text;
            }
        }

 
        private void cboMEmpresa_SelectedValueChanged(object sender, EventArgs e)
        {
            Valida_Empresa();
        }
        private void Habilitar_Campos_Mantenimimiento(Boolean Flag)
        {
            txtMIde.Enabled = Flag;
            txtMCodigo.Enabled = Flag;
            txtMRuc.Enabled = Flag;
            txtMRazon_Social.Enabled = Flag;
            txtMPaterno.Enabled = Flag;
            txtMMaterno.Enabled = Flag;
            txtMNombre.Enabled = Flag;
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
            cboMTipoCliente.Enabled = Flag;
            cboMTipoDoc.Enabled = Flag;
            dtpMFechaConstitucion.Enabled = Flag;
            Valida_Empresa();
            txtMCodigo.Focus();
        }
        private void Habilitar_Botones_Mantenimiento(Boolean Flag)
        {
            btnMNuevo.Enabled = Flag;
            btnMModifica.Enabled = Flag;
            btnMElimina.Enabled = Flag;
            btnMGraba.Enabled = !Flag;
            btnMCancela.Enabled = !Flag;

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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Buscar_Cliente();
        }

        private void Buscar_Cliente()
        {
            string estado = "";
            string cadena = "";
            switch (cboBuscar.Text)
            {
                case "Codigo":
                    cadena = " Clie_Codigo like @filtro ORDER BY Clie_Codigo";
                    break;
                case "Razon Social":
                    cadena = " Clie_Razon_Social like @filtro ORDER BY Clie_Razon_Social ";
                    break;
                case "RUC":
                    cadena = " Clie_RUC like @filtro ORDER BY Clie_RUC";
                    break;
                case "Direccion":
                    cadena = " Clie_Direccion like @filtro ORDER BY Clie_Direccion";
                    break;
            }
            string Consulta = "Select * from Cliente where " + cadena;
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
                Buscar_Cliente();
            }
        }

        private void cboBuscar_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtBuscar.Text = "";
            txtBuscar.Focus();
        }

        private Boolean Verifica_Campos_Cliente()
        {
            if (string.IsNullOrEmpty(txtMCodigo.Text))
            {
                MessageBox.Show("Codigo del Cliente No Ingresado...");
                txtMCodigo.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtMRuc.Text))
            {
                MessageBox.Show("RUC del Cliente No Ingresado...");
                txtMRuc.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtMRazon_Social.Text))
            {
                MessageBox.Show("Razon Social del Cliente No Ingresado...");
                txtMRazon_Social.Focus();
                return false;
            }
            return true;
        }

        private void btnMGraba_Click(object sender, EventArgs e)
        {
            if (Verifica_Campos_Cliente()) Procesar_Operacion();
        }

        private void dgvListado_CurrentCellChanged(object sender, EventArgs e)
        {
            Mostrar_Dgv();
            Mostrar_DgvContacto();
            Mostrar_DgvPuntoPartida();
            Mostrar_DgvLugarEntrega();
        }

        private void btnMNuevo_Click(object sender, EventArgs e)
        {
            Operacion = "N";
            Habilitar_Botones_Mantenimiento(false);
            Habilitar_Campos_Mantenimimiento(true);
            Inicializa_Campos_Mantenimiento();
        }

        private void btnMModifica_Click(object sender, EventArgs e)
        {
            Operacion = "M";
            Habilitar_Botones_Mantenimiento(false);
            Habilitar_Campos_Mantenimimiento(true);
        }

        private void btnMElimina_Click(object sender, EventArgs e)
        {
            Operacion = "E";
            Habilitar_Botones_Mantenimiento(false);
            btnMGraba.Text = "Eliminar";
        }

        private void btnMCancela_Click(object sender, EventArgs e)
        {
            Habilitar_Botones_Mantenimiento(true);
        }

        private void btnMRetornar_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }

        private void Procesar_Operacion()
        {
            ClsClientesBE TipoBE = new ClsClientesBE();
            TipoBE.Clie_ide = Convert.ToInt32(txtMIde.Text);
            TipoBE.Clie_codigo = txtMCodigo.Text;
            TipoBE.Clie_razon_social = txtMRazon_Social.Text;
            TipoBE.Clie_empresa = cboMEmpresa.Text;
            TipoBE.Clie_relacionada = "No";
            TipoBE.Clie_ruc = txtMRuc.Text;
            TipoBE.Docu_iden_ide = Convert.ToInt32(cboMTipoDoc.SelectedValue.ToString());
            TipoBE.Clie_fecha_constitucion = Convert.ToDateTime(dtpMFechaConstitucion.Text);
            TipoBE.Clie_direccion = txtMDireccion.Text;
            TipoBE.Loca_ide = Convert.ToInt32(cboMLocalidad.SelectedValue.ToString());
            TipoBE.Clie_telefono1 = txtMTelefono1.Text;
            TipoBE.Clie_telefono2 = txtMTelefono2.Text;
            TipoBE.Clie_fax = txtMFax.Text;
            TipoBE.Tipo_clie_ide = Convert.ToInt32(cboMTipoCliente.SelectedValue.ToString());
            TipoBE.Acti_clie_ide = Convert.ToInt32(cboMActividad.SelectedValue.ToString());
            TipoBE.Cate_clie_ide = Convert.ToInt32(cboMCategoria.SelectedValue.ToString());
            TipoBE.Clie_correo = txtMCorreo.Text;
            TipoBE.Clie_paterno = txtMPaterno.Text;
            TipoBE.Clie_materno = txtMMaterno.Text;
            TipoBE.Clie_nombre = txtMNombre.Text;
            TipoBE.Clie_estado = cboMEstado.Text;
            TipoBE.Clie_fechainac = Convert.ToDateTime("01-01-1900");
            TipoBE.Veces    = nVeces;
            TipoBE.Usuario  = "ADMIN";
            TipoBE.Creacion = Convert.ToDateTime(DateTime.Today);

            switch (Operacion)
            {
                case "N":
                    {
                        ENResultOperation R = ClsClientesBC.Crear(TipoBE);
                        break;
                    }
                case "M":
                    {
                        ENResultOperation R = ClsClientesBC.Actualizar(TipoBE);
                        break;
                    }
                case "E":
                    {
                        ENResultOperation R = ClsClientesBC.Eliminar(TipoBE);
                        break;
                    }
            }

            Mostrar("");
            Mostrar_Dgv();
            Habilitar_Botones_Mantenimiento(true);
            Habilitar_Campos_Mantenimimiento(false);
            btnMGraba.Text = "Grabar";
        }

        private void cboMLocalidad_Validated(object sender, EventArgs e)
        {
            txtMLoca_Ide.Text = cboMLocalidad.SelectedValue.ToString();
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

        private void cboMTipoCliente_SelectedValueChanged(object sender, EventArgs e)
        {
            txtMTipo_Ide.Text = cboMTipoCliente.SelectedValue.ToString();
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
            //dgv.Columns.Clear();
            dgv.ColumnCount = 22;
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
            dgv.Columns[21].Name = "LRC";

            dgv.Columns[0].Width = 60;
            dgv.Columns[0].HeaderText = "ID";
            dgv.Columns[0].DataPropertyName = "CLIE_IDE";
            dgv.Columns[0].Visible = false;

            dgv.Columns[1].Width = 50;
            dgv.Columns[1].HeaderText = "IDE";
            dgv.Columns[1].DataPropertyName = "CLIE_CONT_IDE";
            dgv.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            //dgv.Columns[1].Visible = false;

            dgv.Columns[2].Width = 40;
            dgv.Columns[2].HeaderText = "Tit";
            dgv.Columns[2].DataPropertyName = "CLIE_CONT_TITULO";


            dgv.Columns[3].Width = 180;
            dgv.Columns[3].HeaderText = "Paterno";
            dgv.Columns[3].DataPropertyName = "CLIE_CONT_PATERNO";

            dgv.Columns[4].Width = 180;
            dgv.Columns[4].HeaderText = "Materno";
            dgv.Columns[4].DataPropertyName = "CLIE_CONT_MATERNO";

            dgv.Columns[5].Width = 180;
            dgv.Columns[5].HeaderText = "Nombres";
            dgv.Columns[5].DataPropertyName = "CLIE_CONT_NOMBRE";

            dgv.Columns[6].Width = 90;
            dgv.Columns[6].HeaderText = "Cargo";
            dgv.Columns[6].DataPropertyName = "CARG_IDE";
            dgv.Columns[6].Visible = false;

            dgv.Columns[7].Width = 340;
            dgv.Columns[7].HeaderText = "Direccion";
            dgv.Columns[7].DataPropertyName = "CLIE_CONT_DIRECCION";
            
            dgv.Columns[8].HeaderText = "Localidad";
            dgv.Columns[8].DataPropertyName = "LOCA_IDE";
            dgv.Columns[8].Visible = false;

            dgv.Columns[9].Width = 90;
            dgv.Columns[9].HeaderText = "Telefono Casa";
            dgv.Columns[9].DataPropertyName = "CLIE_CONT_TELEFONO_CASA";
            dgv.Columns[9].Visible = false;

            dgv.Columns[10].Width = 90;
            dgv.Columns[10].HeaderText = "Celular";
            dgv.Columns[10].DataPropertyName = "CLIE_CONT_TELEFONO_CELULAR";
            dgv.Columns[10].Visible = false;

            dgv.Columns[11].Width = 90;
            dgv.Columns[11].HeaderText = "Fax";
            dgv.Columns[11].DataPropertyName = "CLIE_CONT_FAX";
            dgv.Columns[11].Visible = false;

            dgv.Columns[12].Width = 90;
            dgv.Columns[12].HeaderText = "Tipo Doc";
            dgv.Columns[12].DataPropertyName = "DOCU_IDEN_IDE";
            dgv.Columns[12].Visible = false;

            dgv.Columns[13].Width = 90;
            dgv.Columns[13].HeaderText = "Documento";
            dgv.Columns[13].DataPropertyName = "CLIE_CONT_DOCUMENTO";
            dgv.Columns[13].Visible = false;

            dgv.Columns[14].Width = 90;
            dgv.Columns[14].HeaderText = "F.Nacimiento";
            dgv.Columns[14].DataPropertyName = "CLIE_CONT_FECHA_NACIMIENTO";
            dgv.Columns[14].Visible = false;

            dgv.Columns[15].Width = 90;
            dgv.Columns[15].HeaderText = "Sexo";
            dgv.Columns[15].DataPropertyName = "CLIE_CONT_SEXO";
            dgv.Columns[15].Visible = false;

            dgv.Columns[16].Width = 90;
            dgv.Columns[16].HeaderText = "Estado Civil";
            dgv.Columns[16].DataPropertyName = "CLIE_CONT_ESTADO_CIVIL";
            dgv.Columns[16].Visible = false;

            dgv.Columns[17].Width = 90;
            dgv.Columns[17].HeaderText = "Correo";
            dgv.Columns[17].DataPropertyName = "CLIE_CONT_CORREO";
            dgv.Columns[17].Visible = false;

            dgv.Columns[18].Width = 90;
            dgv.Columns[18].HeaderText = "Nota";
            dgv.Columns[18].DataPropertyName = "CLIE_CONT_NOTA";
            dgv.Columns[18].Visible = false;
            // Columnas que no Deben Verse

            dgv.Columns[19].DataPropertyName = "CREACION";
            dgv.Columns[19].Visible = false;

            dgv.Columns[20].DataPropertyName = "VECES";
            dgv.Columns[20].Visible = false;

            dgv.Columns[21].DataPropertyName = "LRC_IDE";
            dgv.Columns[21].Visible = false;
        }

        private void Mostrar_DgvContacto()
        {
            DataTable TEMP = new DataTable();
            ENResultOperation R = ClsCliente_ContactoBC.Listar_Filtro(Convert.ToInt32(txtMIde.Text));
            if (R.Proceder)
            {
                dgvContacto.DataSource = (DataTable)R.Valor;
                TEMP = (DataTable)R.Valor;
            }
            else
            {
                MessageBox.Show("Error al Obtener Valores : " + R.Sms);
            }
        }
        private void Mostrar_Contacto()
        {
            Inicializa_Campos_Contacto();
            if (dgvContacto.CurrentRow != null)
            {
                txtCRazonSocial.Text = txtMRazon_Social.Text;
                txtCIdCliente.Text = txtMIde.Text;
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

        private void btnCGrabar_Click(object sender, EventArgs e)
        {
            Procesar_Operacion_Contacto();
        }

        private void btnCCancelar_Click(object sender, EventArgs e)
        {
            Habilitar_Botones_Contacto(true);
            Habilitar_Campos_Contacto(false);
            Mostrar_Contacto();
        }

        private void btnCRetornar_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }

        private void dgvContacto_CurrentCellChanged(object sender, EventArgs e)
        {
            Mostrar_Contacto();
        }

        private void Procesar_Operacion_Contacto()
        {
            ClsCliente_ContactoBE TipoBE = new ClsCliente_ContactoBE();
            TipoBE.Clie_ide = Convert.ToInt32(txtMIde.Text);
            TipoBE.Clie_cont_ide = Convert.ToInt32(txtCId.Text);
            TipoBE.Clie_cont_titulo = Convert.ToString(txtCTitulo.Text);
            TipoBE.Clie_cont_paterno = Convert.ToString(txtCPaterno.Text);
            TipoBE.Clie_cont_materno = Convert.ToString(txtCMaterno.Text);
            TipoBE.Clie_cont_nombre = Convert.ToString(txtCNombre.Text);
            TipoBE.Carg_ide = Convert.ToInt32(cboCCargo.SelectedValue.ToString());
            TipoBE.Clie_cont_direccion = Convert.ToString(txtCDireccion.Text);
            TipoBE.Loca_ide = Convert.ToInt32(cboCLocalidad.SelectedValue.ToString());
            TipoBE.Clie_cont_telefono_casa = Convert.ToString(txtCTelefonoCasa.Text);
            TipoBE.Clie_cont_telefono_celular = Convert.ToString(txtCTelefonoCelular.Text);
            TipoBE.Clie_cont_fax = Convert.ToString(txtCFax.Text);
            TipoBE.Docu_iden_ide = Convert.ToInt32(cboCTipoDoc.SelectedValue.ToString());
            TipoBE.Clie_cont_documento = Convert.ToString(txtCNumero.Text);
            TipoBE.Clie_cont_fecha_nacimiento = Convert.ToString(txtCFecNac.Text);
            TipoBE.Clie_cont_sexo = Convert.ToString(cboCSexo.Text);
            TipoBE.Clie_cont_estado_civil = Convert.ToString(cboCEstadoCivil.Text);
            TipoBE.Clie_cont_correo = Convert.ToString(txtCCorreo.Text);
            TipoBE.Clie_cont_nota = Convert.ToString(txtCNota.Text);
            TipoBE.Lrc_ide = Convert.ToInt32(txtMIde.Text);
            TipoBE.Veces = nVeces_Contacto;
            TipoBE.Usuario = "ADMIN";
            TipoBE.Creacion = Convert.ToDateTime(DateTime.Today);

            switch (Operacion_Contacto)
            {
                case "N":
                    {
                        ENResultOperation R = ClsCliente_ContactoBC.Crear(TipoBE);
                        break;
                    }
                case "M":
                    {
                        ENResultOperation R = ClsCliente_ContactoBC.Actualizar(TipoBE);
                        break;
                    }
                case "E":
                    {
                        ENResultOperation R = ClsCliente_ContactoBC.Eliminar(TipoBE);
                        break;
                    }
            }

            Mostrar_Contacto();
            Mostrar_DgvContacto();
            Habilitar_Botones_Contacto(true);
            Habilitar_Campos_Contacto(false);
            btnCGrabar.Text = "Grabar";
        }

        private void Inicializa_Campos_Contacto()
        {
            txtCRazonSocial.Text = string.Empty;
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
            cboCTipoDoc.SelectedIndex = 0;
            cboCLocalidad.SelectedIndex = 0;
            cboCSexo.Text = string.Empty;
            cboCEstadoCivil.Text = string.Empty;
            cboCCargo.SelectedIndex = 0;
        }

        private void Habilitar_Campos_Contacto(Boolean Flag)
        {
            txtCRazonSocial.Enabled = false;
            txtCIdCliente.Enabled = false;
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
            btnCGrabar.Enabled = !Flag;
            btnCCancelar.Enabled = !Flag;
            btnCRetornar.Enabled = Flag;
        }

        private void cboCLocalidad_SelectedValueChanged(object sender, EventArgs e)
        {
            txtCLocaIde.Text = cboCLocalidad.SelectedValue.ToString();
        }

        // ************************ PUNTO PARTIDA *************************************

        void FormatoDgv_Punto_Partida()
        {
            //------------------------------------------------------------------//      
            var dgv = dgvPuntoPartida;

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
            DataGridViewCellStyle style = this.dgvPuntoPartida.ColumnHeadersDefaultCellStyle;
            style.BackColor = Color.Honeydew;
            style.ForeColor = Color.Gray;
            //dgv.Columns.Clear();
            dgv.ColumnCount = 8;
            // Setear Cabecera de Columna 

            dgv.Columns[0].Name = "IDE";
            dgv.Columns[1].Name = "PART_IDE";
            dgv.Columns[2].Name = "PART_DIRECCION";
            dgv.Columns[3].Name = "LOCA_IDE";
            dgv.Columns[4].Name = "LOCA_NOMBRE";
            dgv.Columns[5].Name = "CREACION";
            dgv.Columns[6].Name = "VECES";
            dgv.Columns[7].Name = "LRC_IDE";

            dgv.Columns[0].Width = 60;
            dgv.Columns[0].HeaderText = "ID";
            dgv.Columns[0].DataPropertyName = "PROV_IDE";
            dgv.Columns[0].Visible = false;

            dgv.Columns[1].Width = 50;
            dgv.Columns[1].HeaderText = "IDE";
            dgv.Columns[1].DataPropertyName = "PROV_PART_IDE";
            dgv.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgv.Columns[2].Width = 340;
            dgv.Columns[2].HeaderText = "Direccion";
            dgv.Columns[2].DataPropertyName = "PROV_PART_DIRECCION";


            dgv.Columns[3].Width = 90;
            dgv.Columns[3].HeaderText = "Cod";
            dgv.Columns[3].DataPropertyName = "LOCA_IDE";

            dgv.Columns[4].Width = 200;
            dgv.Columns[4].HeaderText = "Localidad";
            dgv.Columns[4].DataPropertyName = "LOCA_NOMBRE";

            // Columnas que no Deben Verse

            dgv.Columns[5].DataPropertyName = "CREACION";
            dgv.Columns[5].Visible = false;

            dgv.Columns[6].DataPropertyName = "VECES";
            dgv.Columns[6].Visible = false;

            dgv.Columns[7].DataPropertyName = "LRC_IDE";
            dgv.Columns[7].Visible = false;
        }

        private void Mostrar_DgvPuntoPartida()
        {
            DataTable TEMP = new DataTable();
            ENResultOperation R = ClsCliente_Punto_PartidaBC.Listar(Convert.ToInt32(txtMIde.Text));
            if (R.Proceder)
            {
                dgvPuntoPartida.DataSource = (DataTable)R.Valor;
                TEMP = (DataTable)R.Valor;
            }
            else
            {
                MessageBox.Show("Error al Obtener Valores : " + R.Sms);
            }
            Habilitar_Campos_Punto_Partida(false);
        }

        private void Llenar_CboPLocalidad()
        {
            ENResultOperation R = ClsLocalidadBC.Listar("");
            if (R.Proceder) cboPLocalidad.DataSource = (DataTable)R.Valor;
            cboPLocalidad.DisplayMember = "LOCA_NOMBRE";
            cboPLocalidad.ValueMember = "LOCA_IDE";
            cboPLocalidad.AutoCompleteMode = AutoCompleteMode.Suggest;
            cboPLocalidad.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void Mostrar_Punto_Partida()
        {
            Inicializa_Campos_Punto_Partida();
            if (dgvPuntoPartida.CurrentRow != null)
            {
                txtPRazonSocial.Text = txtMRazon_Social.Text;
                txtPIdCliente.Text = Convert.ToString(this.dgvPuntoPartida.CurrentRow.Cells["IDE"].Value); //txtMIde.Text;

                txtPIde.Text = Convert.ToString(this.dgvPuntoPartida.CurrentRow.Cells["PART_IDE"].Value);

                txtPDireccion.Text = Convert.ToString(this.dgvPuntoPartida.CurrentRow.Cells["PART_DIRECCION"].Value);
                txtPLocaIde.Text = Convert.ToString(this.dgvPuntoPartida.CurrentRow.Cells["LOCA_IDE"].Value);
                cboPLocalidad.SelectedValue = Convert.ToInt32(this.dgvPuntoPartida.CurrentRow.Cells["LOCA_IDE"].Value);
                nVeces_Punto_Partida = Convert.ToInt32(this.dgvPuntoPartida.CurrentRow.Cells["VECES"].Value);
            }
        }

        private void btnPNuevo_Click(object sender, EventArgs e)
        {
            Operacion_Punto_Partida = "N";
            Habilitar_Botones_Punto_Partida(false);
            Inicializa_Campos_Punto_Partida();
            Habilitar_Campos_Punto_Partida(true);
        }

        private void btnPModifica_Click(object sender, EventArgs e)
        {
            Operacion_Punto_Partida = "M";
            Habilitar_Botones_Punto_Partida(false);
            Habilitar_Campos_Punto_Partida(true);
        }

        private void btnPElimina_Click(object sender, EventArgs e)
        {
            Operacion_Punto_Partida = "E";
            Habilitar_Botones_Punto_Partida(false);
            Habilitar_Campos_Punto_Partida(true);
            btnPGrabar.Text = "Eliminar";
        }

        private void btnPGrabar_Click(object sender, EventArgs e)
        {
            Procesar_Operacion_Punto_Partida();
        }

        private void btnPCancelar_Click(object sender, EventArgs e)
        {
            Habilitar_Botones_Punto_Partida(true);
            Habilitar_Campos_Punto_Partida(false);
            Mostrar_Punto_Partida();
        }

        private void btnPRetornar_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }

        private void Procesar_Operacion_Punto_Partida()
        {
            ClsCliente_Punto_PartidaBE TipoBE = new ClsCliente_Punto_PartidaBE();
            TipoBE.Prov_ide = Convert.ToInt32(txtMIde.Text);
            TipoBE.Prov_part_ide = Convert.ToInt32(txtPIde.Text);
            TipoBE.Prov_part_direccion = Convert.ToString(txtPDireccion.Text);
            TipoBE.Loca_ide = Convert.ToInt32(cboPLocalidad.SelectedValue.ToString());
            TipoBE.Lrc_ide = Convert.ToInt32(txtPIde.Text);
            TipoBE.Veces = nVeces_Punto_Partida;
            TipoBE.Usuario = "ADMIN";
            TipoBE.Creacion = Convert.ToDateTime(DateTime.Today);

            switch (Operacion_Punto_Partida)
            {
                case "N":
                    {
                        ENResultOperation R = ClsCliente_Punto_PartidaBC.Crear(TipoBE);
                        break;
                    }
                case "M":
                    {
                        ENResultOperation R = ClsCliente_Punto_PartidaBC.Actualizar(TipoBE);
                        break;
                    }
                case "E":
                    {
                        ENResultOperation R = ClsCliente_Punto_PartidaBC.Eliminar(TipoBE);
                        break;
                    }
            }

            Mostrar_Punto_Partida();
            Mostrar_DgvPuntoPartida();
            Habilitar_Botones_Punto_Partida(true);
            Habilitar_Campos_Punto_Partida(false);
            btnPGrabar.Text = "Grabar";
        }

        private void Inicializa_Campos_Punto_Partida()
        {
            txtPRazonSocial.Text = string.Empty;
            txtPIde.Text = "0";

            txtPDireccion.Text = string.Empty;
            txtPLocaIde.Text = string.Empty;
            cboPLocalidad.SelectedIndex = 0;
        }

        private void Habilitar_Campos_Punto_Partida(Boolean Flag)
        {
            txtPRazonSocial.Enabled = false;
            txtPIdCliente.Enabled = false;
            txtPIde.Enabled = false;
            txtPLocaIde.Enabled = false;

            txtPDireccion.Enabled = Flag;
            cboPLocalidad.Enabled = Flag;
        }
        private void Habilitar_Botones_Punto_Partida(Boolean Flag)
        {
            btnPNuevo.Enabled = Flag;
            btnPModifica.Enabled = Flag;
            btnPElimina.Enabled = Flag;
            btnPGrabar.Enabled = !Flag;
            btnPCancelar.Enabled = !Flag;
            btnPRetornar.Enabled = Flag;
        }

        private void dgvPuntoPartida_CurrentCellChanged(object sender, EventArgs e)
        {
            Mostrar_Punto_Partida();
        }

        private void cboPLocalidad_SelectedValueChanged(object sender, EventArgs e)
        {
            txtPLocaIde.Text = cboPLocalidad.SelectedValue.ToString();
        }

        //****************** LUGAR DE ENTREGA O PUNTO DE LLEGADA ***********************//

        void FormatoDgv_Lugar_Entrega()
        {
            //------------------------------------------------------------------//      
            var dgv = dgvLugarEntrega;

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
            DataGridViewCellStyle style = this.dgvLugarEntrega.ColumnHeadersDefaultCellStyle;
            style.BackColor = Color.Honeydew;
            style.ForeColor = Color.Gray;
            //dgv.Columns.Clear();
            dgv.ColumnCount = 7;
            // Setear Cabecera de Columna 

            dgv.Columns[0].Name = "IDE";
            dgv.Columns[1].Name = "CLIE_IDE";
            dgv.Columns[2].Name = "LUGAR_DIRECCION";
            dgv.Columns[3].Name = "LOCA_IDE";
            dgv.Columns[4].Name = "LOCA_NOMBRE";
            dgv.Columns[5].Name = "CREACION";
            dgv.Columns[6].Name = "VECES";

            dgv.Columns[0].Width = 60;
            dgv.Columns[0].HeaderText = "ID";
            dgv.Columns[0].DataPropertyName = "CLIE_IDE";
            dgv.Columns[0].Visible = false;

            dgv.Columns[1].Width = 50;
            dgv.Columns[1].HeaderText = "IDE";
            dgv.Columns[1].DataPropertyName = "CLIE_LUGAR_IDE";
            dgv.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgv.Columns[2].Width = 340;
            dgv.Columns[2].HeaderText = "Direccion";
            dgv.Columns[2].DataPropertyName = "CLIE_LUGAR_DIRECCION";


            dgv.Columns[3].Width = 90;
            dgv.Columns[3].HeaderText = "Cod";
            dgv.Columns[3].DataPropertyName = "LOCA_IDE";

            dgv.Columns[4].Width = 200;
            dgv.Columns[4].HeaderText = "Localidad";
            dgv.Columns[4].DataPropertyName = "LOCA_NOMBRE";

            // Columnas que no Deben Verse

            dgv.Columns[5].DataPropertyName = "CREACION";
            dgv.Columns[5].Visible = false;

            dgv.Columns[6].DataPropertyName = "VECES";
            dgv.Columns[6].Visible = false;
               
        }

        private void Mostrar_DgvLugarEntrega()
        {
            DataTable TEMP = new DataTable();
            ENResultOperation R = ClsCliente_Lugar_EntregaBC.Listar(Convert.ToInt32(txtMIde.Text));
            if (R.Proceder)
            {
                dgvLugarEntrega.DataSource = (DataTable)R.Valor;
                TEMP = (DataTable)R.Valor;
            }
            else
            {
                MessageBox.Show("Error al Obtener Valores : " + R.Sms);
            }
            Habilitar_Campos_Lugar_Entrega(false);
        }

        private void Llenar_CboLLocalidad()
        {
            ENResultOperation R = ClsLocalidadBC.Listar("");
            if (R.Proceder) cboLLocalidad.DataSource = (DataTable)R.Valor;
            cboLLocalidad.DisplayMember = "LOCA_NOMBRE";
            cboLLocalidad.ValueMember = "LOCA_IDE";
            cboLLocalidad.AutoCompleteMode = AutoCompleteMode.Suggest;
            cboLLocalidad.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void Mostrar_Lugar_Entrega()
        {
            Inicializa_Campos_Lugar_Entrega();
            if (dgvLugarEntrega.CurrentRow != null)
            {
                txtLRazonSocial.Text = txtMRazon_Social.Text;
                txtLIdClie.Text = Convert.ToString(this.dgvLugarEntrega.CurrentRow.Cells["IDE"].Value); //txtMIde.Text;

                txtLIde.Text = Convert.ToString(this.dgvLugarEntrega.CurrentRow.Cells["CLIE_IDE"].Value);

                txtLDireccion.Text = Convert.ToString(this.dgvLugarEntrega.CurrentRow.Cells["LUGAR_DIRECCION"].Value);
                txtLLocaIde.Text = Convert.ToString(this.dgvLugarEntrega.CurrentRow.Cells["LOCA_IDE"].Value);
                cboLLocalidad.SelectedValue = Convert.ToInt32(this.dgvLugarEntrega.CurrentRow.Cells["LOCA_IDE"].Value);
                nVeces_Lugar_Entrega = Convert.ToInt32(this.dgvLugarEntrega.CurrentRow.Cells["VECES"].Value);
            }
        }

        private void btnLNuevo_Click(object sender, EventArgs e)
        {
            Operacion_Lugar_Entrega = "N";
            Habilitar_Botones_Lugar_Entrega(false);
            Inicializa_Campos_Lugar_Entrega();
            Habilitar_Campos_Lugar_Entrega(true);
        }

        private void btnLModifica_Click(object sender, EventArgs e)
        {
            Operacion_Lugar_Entrega = "M";
            Habilitar_Botones_Lugar_Entrega(false);
            Habilitar_Campos_Lugar_Entrega(true);
        }

        private void btnLElimina_Click(object sender, EventArgs e)
        {
            Operacion_Lugar_Entrega = "E";
            Habilitar_Botones_Lugar_Entrega(false);
            btnLGrabar.Text = "Eliminar";
        }

        private void btnLGrabar_Click(object sender, EventArgs e)
        {
            Procesar_Operacion_Lugar_Entrega();
        }

        private void btnLCancelar_Click(object sender, EventArgs e)
        {
            Habilitar_Botones_Lugar_Entrega(true);
            Habilitar_Campos_Lugar_Entrega(false);
            Mostrar_Lugar_Entrega();
        }

        private void btnLRetornar_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }

        private void Procesar_Operacion_Lugar_Entrega()
        {
            ClsCliente_Lugar_EntregaBE TipoBE = new ClsCliente_Lugar_EntregaBE();
            TipoBE.Clie_ide = Convert.ToInt32(txtMIde.Text);
            TipoBE.Clie_lugar_ide = Convert.ToInt32(txtLIde.Text);
            TipoBE.Clie_lugar_direccion = Convert.ToString(txtLDireccion.Text);
            TipoBE.Loca_ide = Convert.ToInt32(cboLLocalidad.SelectedValue.ToString());
            TipoBE.Veces = nVeces_Lugar_Entrega;
            TipoBE.Usuario = "ADMIN";
            TipoBE.Creacion = Convert.ToDateTime(DateTime.Today);

            switch (Operacion_Lugar_Entrega)
            {
                case "N":
                    {
                        ENResultOperation R = ClsCliente_Lugar_EntregaBC.Crear(TipoBE);
                        break;
                    }
                case "M":
                    {
                        ENResultOperation R = ClsCliente_Lugar_EntregaBC.Actualizar(TipoBE);
                        break;
                    }
                case "E":
                    {
                        ENResultOperation R = ClsCliente_Lugar_EntregaBC.Eliminar(TipoBE);
                        break;
                    }
            }

            Mostrar_Lugar_Entrega();
            Mostrar_DgvLugarEntrega();
            Habilitar_Botones_Lugar_Entrega(true);
            Habilitar_Campos_Lugar_Entrega(false);
            btnLGrabar.Text = "Grabar";
        }

        private void Inicializa_Campos_Lugar_Entrega()
        {
            txtLRazonSocial.Text = string.Empty;
            txtLIde.Text = "0";

            txtLDireccion.Text = string.Empty;
            txtLLocaIde.Text = string.Empty;
            cboLLocalidad.SelectedIndex = 0;
        }

        private void Habilitar_Campos_Lugar_Entrega(Boolean Flag)
        {
            txtLRazonSocial.Enabled = false;
            txtLIdClie.Enabled = false;
            txtLIde.Enabled = false;

            txtLDireccion.Enabled = Flag;
            txtLLocaIde.Enabled = false;
            cboLLocalidad.Enabled = Flag;

            txtLRazonSocial.Focus();

        }
        private void Habilitar_Botones_Lugar_Entrega(Boolean Flag)
        {
            btnLNuevo.Enabled = Flag;
            btnLModifica.Enabled = Flag;
            btnLElimina.Enabled = Flag;
            btnLGrabar.Enabled = !Flag;
            btnLCancelar.Enabled = !Flag;
            btnLRetornar.Enabled = Flag;
        }

         private void dgvLugarEntrega_CurrentCellChanged(object sender, EventArgs e)
        {
            Mostrar_Lugar_Entrega();
        }

         private void cboLLocalidad_Validated(object sender, EventArgs e)
         {
             txtLLocaIde.Text = cboLLocalidad.SelectedValue.ToString();
         }

 


    }
}
