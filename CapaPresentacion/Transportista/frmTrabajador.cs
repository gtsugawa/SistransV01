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

namespace CapaPresentacion.Transportista
{
    public partial class frmTrabajador : Form
    {
        private Int32 iUserid;
        private Int32 iPers_Ide;
        private Int32 iTran_Ide;
        private string Operacion;
        public frmTrabajador()
        {
            InitializeComponent();
        }
        private void frmTrabajador_Load(object sender, EventArgs e)
        {
            iTran_Ide = 2564;
            lblTitulo.Text = "Personal Terah S.A.C";
            txtLocalidad.Visible = false;
            FormatoDgv();
            Mostrar("");
            Cargar_Localidad();
            Cargar_Tipo_Documento();
            Cargar_Cargos();
            Cargar_Estado();
            Cargar_Estado_Civil();
            Cargar_Sexo();
            PanelPersonal.Visible = false;
            txtBuscarPaterno.Text = string.Empty;
            txtBuscarMaterno.Text = string.Empty;
            txtBuscarPaterno.Focus();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

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
            dgv.DefaultCellStyle.Font = new Font("Tahoma", 8);
            /*----------Alterna colores en el grid -------*/
            dgv.RowsDefaultCellStyle.BackColor = Color.LightBlue;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
            /*---Pintado de color a la cabecera del datagrid ---*/
            DataGridViewCellStyle style = this.dgvListado.ColumnHeadersDefaultCellStyle;
            style.BackColor = Color.Honeydew;
            style.ForeColor = Color.Gray;
            //dgv.Columns.Clear();
            dgv.ColumnCount = 27;
            //dgv.EnableHeadersVisualStyles = false;
            // Setear Cabecera de Columna 
            dgv.Columns[0].Name = "PERS_IDE";
            dgv.Columns[0].DataPropertyName = "PERS_IDE";
            dgv.Columns[0].Visible = false;

            dgv.Columns[1].Name = "USERID";
            dgv.Columns[1].DataPropertyName = "USERID";
            dgv.Columns[1].Visible = false;
            
            dgv.Columns[2].Name = "PERS_CODIGO";
            dgv.Columns[2].DataPropertyName = "PERS_CODIGO";
            dgv.Columns[2].Width = 70;
            dgv.Columns[2].HeaderText = "Codigo";
            dgv.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgv.Columns[3].Name = "PERS_APELLIDO_PATERNO";
            dgv.Columns[3].DataPropertyName = "PERS_APELLIDO_PATERNO";
            dgv.Columns[3].Width = 150;
            dgv.Columns[3].HeaderText = "Apellido Paterno";

            dgv.Columns[4].Name = "PERS_APELLIDO_MATERNO";
            dgv.Columns[4].DataPropertyName = "PERS_APELLIDO_MATERNO";
            dgv.Columns[4].Width = 170;
            dgv.Columns[4].HeaderText = "Apellido Materno";

            dgv.Columns[5].Name = "PERS_NOMBRES";
            dgv.Columns[5].DataPropertyName = "PERS_NOMBRES";
            dgv.Columns[5].Width = 170;
            dgv.Columns[5].HeaderText = "Nombres";

            dgv.Columns[6].Name = "CARG_IDE";
            dgv.Columns[6].DataPropertyName = "CARG_IDE";
            dgv.Columns[6].Visible = false;

            dgv.Columns[7].Name = "CARG_NOMBRE";
            dgv.Columns[7].DataPropertyName = "CARG_NOMBRE";
            dgv.Columns[7].Width = 120;
            dgv.Columns[7].HeaderText = "Cargo";

            dgv.Columns[8].Name = "DOCU_IDEN_IDE";
            dgv.Columns[8].DataPropertyName = "DOCU_IDEN_IDE";
            dgv.Columns[8].Visible = false;

            dgv.Columns[9].Name = "DOCU_NOMBRE";
            dgv.Columns[9].DataPropertyName = "DOCU_NOMBRE";
            dgv.Columns[9].Visible = false;

            dgv.Columns[10].Name = "PERS_DOCUMENTO";
            dgv.Columns[10].DataPropertyName = "PERS_DOCUMENTO";
            dgv.Columns[10].Visible = false;

            dgv.Columns[11].Name = "PERS_DIRECCION";
            dgv.Columns[11].DataPropertyName = "PERS_DIRECCION";
            dgv.Columns[11].Visible = false;

            dgv.Columns[12].Name = "LOCA_IDE";
            dgv.Columns[12].DataPropertyName = "LOCA_IDE";
            dgv.Columns[12].Visible = false;

            dgv.Columns[13].Name = "LOCA_NOMBRE";
            dgv.Columns[13].DataPropertyName = "LOCA_NOMBRE";
            dgv.Columns[13].Visible = false;

            dgv.Columns[14].Name = "PERS_TELEFONO_CASA";
            dgv.Columns[14].DataPropertyName = "PERS_TELEFONO_CASA";
            dgv.Columns[14].Visible = false;

            dgv.Columns[15].Name = "PERS_TELEFONO_CELULAR";
            dgv.Columns[15].DataPropertyName = "PERS_TELEFONO_CELULAR";
            dgv.Columns[15].Visible = false;

            dgv.Columns[16].Name = "PERS_FECHA_NACIMIENTO";
            dgv.Columns[16].DataPropertyName = "PERS_FECHA_NACIMIENTO";
            dgv.Columns[16].Visible = false;

            dgv.Columns[17].Name = "PERS_FECHA_INGRESO";
            dgv.Columns[17].DataPropertyName = "PERS_FECHA_INGRESO";
            dgv.Columns[17].Width = 90;
            dgv.Columns[17].HeaderText = "F.Ingreso";
            dgv.Columns[17].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgv.Columns[17].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgv.Columns[18].Name = "PERS_SEXO";
            dgv.Columns[18].DataPropertyName = "PERS_SEXO";
            dgv.Columns[18].Visible = false;

            dgv.Columns[19].Name = "PERS_ESTADO_CIVIL";
            dgv.Columns[19].DataPropertyName = "PERS_ESTADO_CIVIL";
            dgv.Columns[19].Visible = false;

            dgv.Columns[20].Name = "PERS_CORREO";
            dgv.Columns[20].DataPropertyName = "PERS_CORREO";
            dgv.Columns[20].Visible = false;

            dgv.Columns[21].Name = "PERS_NOTA";
            dgv.Columns[21].DataPropertyName = "PERS_NOTA";
            dgv.Columns[21].Visible = false;

            dgv.Columns[22].Name = "PERS_ESTADO";
            dgv.Columns[22].DataPropertyName = "PERS_ESTADO";
            dgv.Columns[22].Visible = false;

            dgv.Columns[23].Name = "CREACION";
            dgv.Columns[23].DataPropertyName = "CREACION";
            dgv.Columns[23].Visible = false;

            dgv.Columns[24].Name = "MODIFICADO";
            dgv.Columns[24].DataPropertyName = "MODIFICADO";
            dgv.Columns[24].Visible = false;

            dgv.Columns[25].Name = "USUARIO";
            dgv.Columns[25].DataPropertyName = "USUARIO";
            dgv.Columns[25].Visible = false;

            dgv.Columns[26].Name = "PERS_FECHA_CESE";
            dgv.Columns[26].DataPropertyName = "PERS_FECHA_CESE";
            dgv.Columns[26].Visible = false;
        }

        private void Mostrar(string filtro)
        {
            ENResultOperation R = ClsMaestro_PersonalBC.Listar(filtro);
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
                iPers_Ide = Convert.ToInt32(this.dgvListado.CurrentRow.Cells["PERS_IDE"].Value.ToString());
            }
        }

        private void dgvListado_CurrentCellChanged(object sender, EventArgs e)
        {
            Mostrar_Dgv();
        }

        private void Cargar_Estado()
        {
            cboEstado.Items.Clear();
            cboEstado.Items.Add("Activo");
            cboEstado.Items.Add("InActivo");
            cboEstado.SelectedIndex = 0;
        }
        private void Cargar_Estado_Civil()
        {
            cboEstado_Civil.Items.Clear();
            cboEstado_Civil.Items.Add("Soltero");
            cboEstado_Civil.Items.Add("Casado");
            cboEstado_Civil.Items.Add("Viudo");
            cboEstado_Civil.Items.Add("Divorciado");
            cboEstado_Civil.SelectedIndex = 0;
        }
        private void Cargar_Sexo()
        {
            cboSexo.Items.Clear();
            cboSexo.Items.Add("Masculino");
            cboSexo.Items.Add("Femenino");
            cboSexo.SelectedIndex = 0;
        }

        private void Cargar_Tipo_Documento()
        {
            ENResultOperation R = ClsTipo_Documento_IdentidadBC.Listar("");
            if (R.Proceder) cboDocumento.DataSource = (DataTable)R.Valor;
            cboDocumento.DisplayMember = "DOCU_IDEN_NOMBRE";
            cboDocumento.ValueMember = "DOCU_IDEN_IDE";
            cboDocumento.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private void Cargar_Localidad()
        {
            ENResultOperation L = ClsLocalidadBC.Listar("");
            if (L.Proceder) cboLocalidad.DataSource = (DataTable)L.Valor;
            cboLocalidad.DisplayMember = "LOCA_NOMBRE";
            cboLocalidad.ValueMember = "LOCA_IDE";
            cboLocalidad.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private void Cargar_Cargos()
        {
            ENResultOperation C = ClsCargoBC.Listar("");
            if (C.Proceder) cboCargos.DataSource = (DataTable)C.Valor;
            cboCargos.DisplayMember = "CARG_NOMBRE";
            cboCargos.ValueMember = "CARG_IDE";
            cboCargos.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void Inicializa_Campos()
        {
            iUserid = 0;
            txtCodigo.Text = "";
            txtDocumento.Text = "";
            txtPaterno.Text = "";
            txtMaterno.Text = "";
            txtNombres.Text = "";
            txtDireccion.Text = "";
            txtLocalidad.Text = "";
            txtNota.Text = "";
            txtTelfCasa.Text = "";
            txtCelular.Text = "";
            txtCorreo.Text = "";
            dtpFecNac.Text = "01-01-2010";
            dtpFecIng.Value = DateTime.Now;
            dtpFecCese.Text = "01-01-2000";
            cboDocumento.SelectedIndex = 0;
            cboEstado_Civil.SelectedIndex = 0;
            cboSexo.SelectedIndex = 0;
            cboEstado.SelectedIndex = 0;
            cboCargos.Text = "";
        }
        private void Habilitar_Botones(Boolean Flag)
        {
            btnNuevo.Enabled = Flag;
            btnModificar.Enabled = Flag;
            btnEliminar.Enabled = Flag;
            btnImprimir.Enabled = Flag;
            btnGrabar.Enabled = !Flag;
            btnCancelar.Enabled = !Flag;
            btnSalir.Enabled = Flag;
            btnGrabar.Text = "Grabar";
        }
        private void Habilitar_Campos(Boolean Flag)
        {
            txtCodigo.ReadOnly = !Flag;
            txtDocumento.ReadOnly = !Flag;
            txtPaterno.ReadOnly = !Flag;
            txtMaterno.ReadOnly = !Flag;
            txtNombres.ReadOnly = !Flag;
            txtDireccion.ReadOnly = !Flag;
            txtLocalidad.ReadOnly = !Flag;
            txtNota.ReadOnly = !Flag;
            txtTelfCasa.ReadOnly = !Flag;
            txtCelular.ReadOnly = !Flag;
            txtCorreo.ReadOnly = !Flag;
            cboDocumento.Enabled = Flag;
            cboEstado_Civil.Enabled = Flag;
            cboSexo.Enabled = Flag;
            cboEstado.Enabled = Flag;
            dtpFecCese.Visible = Flag;
            txtFecCese.Visible = !Flag;
        }

        private void Cargar_Registro(int nMant_Ide)
        {
            ENResultOperation R = ClsMaestro_PersonalBC.Obtener_Registro(iPers_Ide);
            DataTable dtg = (DataTable)R.Valor;
            if (dtg.Rows.Count != 0)
            {
                DataRow ROWG = dtg.Rows[0];
                iUserid = Convert.ToInt32(ROWG["USERID"].ToString());
                txtCodigo.Text = ROWG["PERS_CODIGO"].ToString();
                txtDocumento.Text = ROWG["PERS_DOCUMENTO"].ToString();
                txtPaterno.Text = ROWG["PERS_APELLIDO_PATERNO"].ToString();
                txtMaterno.Text = ROWG["PERS_APELLIDO_MATERNO"].ToString();
                txtNombres.Text = ROWG["PERS_NOMBRES"].ToString();
                txtDireccion.Text = ROWG["PERS_DIRECCION"].ToString();
                txtNota.Text = ROWG["PERS_NOTA"].ToString();
                txtTelfCasa.Text = ROWG["PERS_TELEFONO_CASA"].ToString();
                txtCelular.Text = ROWG["PERS_TELEFONO_CELULAR"].ToString();
                txtCorreo.Text = ROWG["PERS_CORREO"].ToString();
                dtpFecNac.Value = Convert.ToDateTime(ROWG["PERS_FECHA_NACIMIENTO"].ToString());
                dtpFecIng.Value = Convert.ToDateTime(ROWG["PERS_FECHA_INGRESO"].ToString());
                dtpFecCese.Value = Convert.ToDateTime(ROWG["PERS_FECHA_CESE"].ToString());
                cboLocalidad.SelectedValue = Convert.ToInt32(ROWG["LOCA_IDE"].ToString());
                txtLocalidad.Text = cboLocalidad.Text;
                cboDocumento.SelectedValue = ROWG["DOCU_IDEN_IDE"].ToString();
                cboEstado_Civil.Text = ROWG["PERS_ESTADO_CIVIL"].ToString();
                cboSexo.Text = ROWG["PERS_SEXO"].ToString();
                cboEstado.SelectedIndex = Convert.ToInt32(ROWG["PERS_ESTADO"].ToString());
                cboCargos.SelectedValue = Convert.ToInt32(ROWG["CARG_IDE"].ToString());
                txtCargo.Text = ROWG["CARG_IDE"].ToString();
                if (dtpFecCese.Text == "01-01-2000")
                {
                    txtFecCese.Text = string.Empty;
                }
                else
                {
                    txtFecCese.Text = dtpFecCese.Text;
                }
                txtDocumento.Focus();
            }
            else
            {
                Habilitar_Botones(true);
            }

        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            PanelPersonal.Visible = true;
            Operacion = "N";
            Inicializa_Campos();
            Habilitar_Botones(false);
            Habilitar_Campos(true);
            txtDocumento.Focus();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (iPers_Ide != 0)
            {
                PanelPersonal.Visible = true;
                Operacion = "M";
                Habilitar_Botones(false);
                Habilitar_Campos(true);
                Cargar_Registro(iPers_Ide);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (iPers_Ide != 0)
            {
                PanelPersonal.Visible = true;
                Operacion = "E";
                Habilitar_Botones(false);
                Cargar_Registro(iPers_Ide);
                btnGrabar.Text = "Eliminar";
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            Reportes.rptMaestro_Personal frmPers = new Reportes.rptMaestro_Personal();
            //frmPers.RangoFecha = "Del : " + dtpFecIni.Value.ToShortDateString() + " Al : " + dtpFecFin.Value.ToShortDateString();
            frmPers.Empresa = "TERAH S.A.C";
            frmPers.Titulo = "RELACION DEL PERSONAL";
            frmPers.Show();

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (Verifica_Campos()) Procesar_Operacion();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            PanelPersonal.Visible = false;
            Habilitar_Botones(true);
        }

        private Boolean Verifica_Campos()
        {
            if (string.IsNullOrEmpty(txtCodigo.Text))
            {
                MessageBox.Show("No se Ha Ingresado Codigo del Personal", "Mantenimiento de Personal");
                return false;
            }
            if (Existe_Personal_Documento(txtDocumento.Text) && Operacion == "N")
            {
                MessageBox.Show("Personal ya existe con el Numero de Documento", "Alerta Personal");
                return false;
            }
            return true;
        }

        private void Procesar_Operacion()
        {
            ClsMaestro_PersonalBE TipoBE = new ClsMaestro_PersonalBE();
            TipoBE.Userid = iUserid;
            TipoBE.Pers_codigo = txtCodigo.Text;
            TipoBE.Pers_ide = iPers_Ide;
            TipoBE.Pers_apellido_paterno = txtPaterno.Text;
            TipoBE.Pers_apellido_materno = txtMaterno.Text;
            TipoBE.Pers_nombres = txtNombres.Text;
            TipoBE.Pers_documento = txtDocumento.Text;
            TipoBE.Pers_direccion = txtDireccion.Text;
            TipoBE.Loca_ide = Convert.ToInt32(cboLocalidad.SelectedValue.ToString());
            TipoBE.Carg_ide = Convert.ToInt32(cboCargos.SelectedValue.ToString());
            TipoBE.Pers_fecha_ingreso = dtpFecIng.Value;
            TipoBE.Pers_fecha_nacimiento = dtpFecNac.Value;
            TipoBE.Pers_fecha_cese = dtpFecCese.Value;
            TipoBE.Pers_nota = txtNota.Text;
            TipoBE.Pers_telefono_casa = txtTelfCasa.Text;
            TipoBE.Pers_telefono_celular = txtCelular.Text;
            TipoBE.Pers_correo = txtCorreo.Text;
            TipoBE.Docu_iden_ide = Convert.ToInt32(cboDocumento.SelectedValue.ToString());
            TipoBE.Pers_estado_civil = cboEstado_Civil.Text;
            TipoBE.Pers_sexo = cboSexo.Text;
            TipoBE.Pers_estado = Convert.ToInt32(cboEstado.SelectedIndex.ToString());
            TipoBE.Usuario = VarGlobales.NombreUsuario;

            switch (Operacion)
            {
                case "N":
                    {
                        ENResultOperation R = ClsMaestro_PersonalBC.Crear(TipoBE);
                        if (!R.Proceder) MessageBox.Show("Error al Insertar " + R.Sms);
                        break;
                    }
                case "M":
                    {
                        ENResultOperation R = ClsMaestro_PersonalBC.Actualizar(TipoBE);
                        if (!R.Proceder) MessageBox.Show("Error al Modificar " + R.Sms);
                        break;
                    }
                case "E":
                    {
                        ENResultOperation R = ClsMaestro_PersonalBC.Eliminar(TipoBE);
                        if (!R.Proceder) MessageBox.Show("Error al Eliminar " + R.Sms);
                        break;
                    }
            }
            Operacion = "M";
            PanelPersonal.Visible = false;
            Habilitar_Botones(true);
            Habilitar_Campos(false);
            Mostrar("");
        }
        private Boolean Existe_Personal_Documento(string Documento)
        {
            ENResultOperation R = ClsMaestro_PersonalBC.Existe_Personal_Documento(Documento);
            DataTable dtg = (DataTable)R.Valor;
            if (dtg.Rows.Count != 0)
            {
                return true;
            }
            return false;
        }

        private void Buscar_Trabajador(string cNroDoc)
        {
            ENResultOperation R = ClsTransportista_ContactoBC.Buscar_Por_Documento(cNroDoc,iTran_Ide);
            DataTable dtg = (DataTable)R.Valor;
            if (dtg.Rows.Count != 0)
            {
                DataRow ROWG = dtg.Rows[0];
                txtPaterno.Text = ROWG["TRAN_CONT_PATERNO"].ToString();
                txtMaterno.Text = ROWG["TRAN_CONT_MATERNO"].ToString();
                txtNombres.Text = ROWG["TRAN_CONT_NOMBRE"].ToString();
                txtTelfCasa.Text = ROWG["TRAN_CONT_TELEFONO_CASA"].ToString();
                txtCelular.Text =  ROWG["TRAN_CONT_TELEFONO_CELULAR"].ToString();
                txtDireccion.Text = ROWG["TRAN_CONT_DIRECCION"].ToString();
                txtCorreo.Text = ROWG["TRAN_CONT_CORREO"].ToString();
                txtNota.Text = ROWG["TRAN_CONT_NOTA"].ToString();
                cboSexo.Text = ROWG["TRAN_CONT_SEXO"].ToString();
                cboEstado_Civil.Text = ROWG["TRAN_CONT_ESTADO_CIVIL"].ToString();
                cboLocalidad.SelectedValue = Convert.ToInt32(ROWG["LOCA_IDE"].ToString());
                txtLocalidad.Text = ROWG["LOCA_IDE"].ToString();
                cboCargos.SelectedValue = Convert.ToInt32(ROWG["CARG_IDE"].ToString());
                txtCargo.Text = ROWG["CARG_IDE"].ToString();
            }
        }

        private void cboDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter) SendKeys.Send("{TAB}");
        }

        private void txtDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter) SendKeys.Send("{TAB}");
        }

        private void cboEstado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter) SendKeys.Send("{TAB}");
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter) SendKeys.Send("{TAB}");
        }
        private void txtDocumento_KeyDown(object sender, KeyEventArgs e)
        {
              if (e.KeyData == Keys.Enter)
              {
                  if (Existe_Personal_Documento(txtDocumento.Text))
                  {
                      MessageBox.Show("Personal ya existe con el Numero de Documento","Alerta Personal");
                      txtDocumento.Focus();
                  }
                  else
                  {
                      Buscar_Trabajador(txtDocumento.Text);
                      if (string.IsNullOrEmpty(txtCodigo.Text)) txtCodigo.Text = txtDocumento.Text;
                  }
              }
                  
        }

        private void txtPaterno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter) SendKeys.Send("{TAB}");
        }

        private void txtMaterno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter) SendKeys.Send("{TAB}");
        }

        private void txtNombres_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter) SendKeys.Send("{TAB}");
        }

        private void txtDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter) SendKeys.Send("{TAB}");
        }

        private void cboLocalidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter) SendKeys.Send("{TAB}");
        }

        private void dtpFecNac_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter) SendKeys.Send("{TAB}");
        }

        private void dtpFecIng_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter) SendKeys.Send("{TAB}");
        }

        private void cboSexo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter) SendKeys.Send("{TAB}");
        }

        private void cboEstado_Civil_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter) SendKeys.Send("{TAB}");
        }

        private void txtTelfCasa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter) SendKeys.Send("{TAB}");
        }

        private void txtCelular_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter) SendKeys.Send("{TAB}");
        }

        private void txtCorreo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter) SendKeys.Send("{TAB}");
        }

        private void txtNota_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (string.IsNullOrEmpty(txtNota.Text))
            {
                if ((int)e.KeyChar == (int)Keys.Enter) SendKeys.Send("{TAB}");
            }
        }

        private void btnGrabar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter) SendKeys.Send("{TAB}");
        }

        private void cboCargos_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txtCargo.Text = cboCargos.SelectedValue.ToString();
        }

        private void cboLocalidad_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
            txtLocalidad.Text = cboLocalidad.SelectedValue.ToString();
        }

        private void txtBuscarPaterno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.F3)
            {
                Buscar_Trabajador_Filtro();
            }
            if ((int)e.KeyChar == (int)Keys.Enter) SendKeys.Send("{TAB}");
        }

        private void txtBuscarMaterno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                Buscar_Trabajador_Filtro();
            }
            if ((int)e.KeyChar == (int)Keys.Enter) SendKeys.Send("{TAB}");
        }

        private void Buscar_Trabajador_Filtro()
        {
            ENResultOperation R = ClsMaestro_PersonalBC.Buscar_Filtro(txtBuscarPaterno.Text,txtBuscarMaterno.Text);
            if (R.Proceder)
            {
                dgvListado.DataSource = (DataTable)R.Valor;
            }
            else
            {
                MessageBox.Show("Error al Obtener Valores : " + R.Sms);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Buscar_Trabajador_Filtro();
        }

    }
}
