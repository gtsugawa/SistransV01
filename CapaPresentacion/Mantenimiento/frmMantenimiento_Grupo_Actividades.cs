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


namespace CapaPresentacion.Mantenimiento
{
    public partial class frmMantenimiento_Grupo_Actividades : Form
    {
        private int iMant_Ide;
        private Int32 nGrupo_Ide;
        private string Operacion;
        private string cCodigo_Grupo;
        public frmMantenimiento_Grupo_Actividades()
        {
            InitializeComponent();
        }
        private void frmMantenimiento_Grupo_Actividades_Load(object sender, EventArgs e)
        {
            FormatoDgv();
            Cargar_Estado();
            Cargar_Grupos();
            Mostrar(nGrupo_Ide);
            PanelGrupos.Visible = false;
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
            dgv.ColumnCount = 9;
            // Setear Cabecera de Columna 
            dgv.Columns[0].Name = "MANT_ACTIVIDAD_IDE";
            dgv.Columns[1].Name = "MANT_GRUPO_IDE";
            dgv.Columns[2].Name = "MANT_GRUPO_CODIGO";
            dgv.Columns[3].Name = "GRUPO_NOMBRE";
            dgv.Columns[4].Name = "MANT_ACTIVIDAD_CODIGO";
            dgv.Columns[5].Name = "MANT_ACTIVIDAD_NOMBRE";
            dgv.Columns[6].Name = "MANT_ACTIVIDAD_KILOMETROS";
            dgv.Columns[7].Name = "MANT_ACTIVIDAD_DIAS";
            dgv.Columns[8].Name = "MANT_ACTIVIDAD_ESTADO";

            dgv.Columns[0].Width = 40;
            dgv.Columns[0].HeaderText = "ID";
            dgv.Columns[0].DataPropertyName = "MANT_ACTIVIDAD_IDE";
            dgv.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgv.Columns[1].DataPropertyName = "MANT_GRUPO_IDE";
            dgv.Columns[1].Visible = false;

            dgv.Columns[2].DataPropertyName = "MANT_GRUPO_CODIGO";
            dgv.Columns[2].Visible = false;

            dgv.Columns[3].Width = 100;
            dgv.Columns[3].HeaderText = "Grupo";
            dgv.Columns[3].DataPropertyName = "GRUPO_NOMBRE";
            dgv.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            dgv.Columns[4].Width =  60;
            dgv.Columns[4].HeaderText = "Codigo";
            dgv.Columns[4].DataPropertyName = "MANT_ACTIVIDAD_CODIGO";
            dgv.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgv.Columns[5].Width = 350;
            dgv.Columns[5].HeaderText = "Descripcion del Grupo";
            dgv.Columns[5].DataPropertyName = "MANT_ACTIVIDAD_NOMBRE";
            dgv.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            dgv.Columns[6].Width = 100;
            dgv.Columns[6].HeaderText = "Kilometraje";
            dgv.Columns[6].DataPropertyName = "MANT_ACTIVIDAD_KILOMETROS";
            dgv.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgv.Columns[7].Width = 100;
            dgv.Columns[7].HeaderText = "Dias";
            dgv.Columns[7].DataPropertyName = "MANT_ACTIVIDAD_DIAS";
            dgv.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgv.Columns[8].Width = 90;
            dgv.Columns[8].HeaderText = "Estado";
            dgv.Columns[8].DataPropertyName = "MANT_ACTIVIDAD_ESTADO";
            dgv.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

        }
        private void Mostrar(Int32 filtro)
        {
            ENResultOperation R = ClsMantenimiento_Grupo_ActividadesBC.Obtener_Actividades_Grupo(filtro);
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
            iMant_Ide = 0;
            if (this.dgvListado.CurrentRow != null)
            {
                iMant_Ide = Convert.ToInt32(this.dgvListado.CurrentRow.Cells["MANT_ACTIVIDAD_IDE"].Value.ToString());
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
        private void Cargar_Grupos()
        {
            ENResultOperation R = ClsMantenimiento_GruposBC.Listar("");
            if (R.Proceder) cboGrupos.DataSource = (DataTable)R.Valor;
            cboGrupos.DisplayMember = "MANT_GRUPO_NOMBRE";
            cboGrupos.ValueMember = "MANT_GRUPO_IDE";
            cboGrupos.DropDownStyle = ComboBoxStyle.DropDownList;

            if (R.Proceder) cboFiltrarGrupo.DataSource = (DataTable)R.Valor;
            cboFiltrarGrupo.DisplayMember = "MANT_GRUPO_NOMBRE";
            cboFiltrarGrupo.ValueMember = "MANT_GRUPO_IDE";
            cboFiltrarGrupo.DropDownStyle = ComboBoxStyle.DropDownList;
            
            Cargar_Registro_Grupo(Convert.ToInt32(cboGrupos.SelectedValue.ToString()));

        }
        private void Inicializa_Campos()
        {
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtKilometros.Text = "";
            txtDias.Text = "";
            //cboGrupos.SelectedIndex = 0;
            cboEstado.SelectedIndex = 0;
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
            txtNombre.ReadOnly = !Flag;
            txtKilometros.ReadOnly = !Flag;
            txtDias.ReadOnly = !Flag;
            cboEstado.Enabled = Flag;
            txtCodigo.Focus();
        }

        private void Cargar_Registro(int nMant_Ide)
        {
            ENResultOperation R = ClsMantenimiento_Grupo_ActividadesBC.Buscar_Registro(nMant_Ide);
            DataTable dtg = (DataTable)R.Valor;
            if (dtg.Rows.Count != 0)
            {
                DataRow ROWG = dtg.Rows[0];
                txtCodigo.Text = ROWG["MANT_ACTIVIDAD_CODIGO"].ToString();
                txtNombre.Text = ROWG["MANT_ACTIVIDAD_NOMBRE"].ToString();
                txtKilometros.Text = ROWG["MANT_ACTIVIDAD_KILOMETROS"].ToString();
                txtDias.Text = ROWG["MANT_ACTIVIDAD_DIAS"].ToString();
                cboEstado.SelectedValue = Convert.ToInt32(ROWG["MANT_ACTIVIDAD_ESTADO"].ToString());
                txtGrupo.Text = ROWG["MANT_GRUPO_IDE"].ToString();
                nGrupo_Ide = Convert.ToInt32(txtGrupo.Text);
                cboGrupos.SelectedValue = nGrupo_Ide;
            }
            else
            {
                Habilitar_Botones(true);
            }

        }
        private void Cargar_Registro_Grupo(int nMant_Grupo_Ide)
        {
            ENResultOperation R = ClsMantenimiento_GruposBC.Buscar_Registro(nMant_Grupo_Ide);
            DataTable dtg = (DataTable)R.Valor;
            cCodigo_Grupo = "";
            nGrupo_Ide = 0;
            if (dtg.Rows.Count != 0)
            {
                DataRow ROWG = dtg.Rows[0];
                nGrupo_Ide = Convert.ToInt32(ROWG["MANT_GRUPO_IDE"].ToString());
                cCodigo_Grupo = ROWG["MANT_GRUPO_CODIGO"].ToString();
            }
            txtGrupo.Text = cCodigo_Grupo;
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            PanelGrupos.Visible = true;
            Operacion = "N";
            Inicializa_Campos();
            cboGrupos.Enabled = false;
            Habilitar_Botones(false);
            Habilitar_Campos(true);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            PanelGrupos.Visible = true;
            if (iMant_Ide != 0)
            {
                PanelGrupos.Visible = true;
                Operacion = "M";
                Habilitar_Botones(false);
                Habilitar_Campos(true);
                cboGrupos.Enabled = false;
                Cargar_Registro(iMant_Ide);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            PanelGrupos.Visible = true;
            if (iMant_Ide != 0)
            {
                PanelGrupos.Visible = true;
                Operacion = "E";
                Habilitar_Botones(false);
                cboGrupos.Enabled = false;
                //Habilitar_Campos(false);
                Cargar_Registro(iMant_Ide);
                btnGrabar.Text = "Eliminar";
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {

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
            PanelGrupos.Visible = false;
            Habilitar_Botones(true);
        }

        private Boolean Verifica_Campos()
        {
            if (string.IsNullOrEmpty(txtCodigo.Text))
            {
                MessageBox.Show("No se Ha Ingresado Codigo de la Actividad dentro del Grupo", "Mantenimiento de Grupo-Actividades");
                return false;
            }
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("No se Ha Ingresado Descripcion de la Actividad dentro del Grupo", "Mantenimiento de Grupo-Actividades");
                return false;
            }

            if (string.IsNullOrEmpty(txtKilometros.Text))
            {
                MessageBox.Show("No se Ha Ingresado Frecuencia en Kilometros se Realiza la Actividad ", "Mantenimiento de Grupo-Actividades");
                return false;
            }
            if (string.IsNullOrEmpty(txtDias.Text))
            {
                MessageBox.Show("No se Ha Ingresado Frecuencia en Dias se Realiza la Actividad", "Mantenimiento de Grupo-Actividades");
                return false;
            }
            if (string.IsNullOrEmpty(txtKilometros.Text))
            {
                MessageBox.Show("No se Ha Ingresado Codigo de la Actividad dentro del Grupo", "Mantenimiento de Grupo-Actividades");
                return false;
            }

            return true;
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private Boolean Grupo_Actividad_Existe_Codigo()
        {
            ENResultOperation R = ClsMantenimiento_Grupo_ActividadesBC.Obtener_Codigo(nGrupo_Ide, txtCodigo.Text);
            DataTable dtg = (DataTable)R.Valor;
            if (dtg.Rows.Count != 0) return true;
            return false;
        }

        private void Procesar_Operacion()
        {
            ClsMantenimiento_Grupo_ActividadesBE TipoBE = new ClsMantenimiento_Grupo_ActividadesBE();
            TipoBE.Mant_actividad_ide = iMant_Ide;
            TipoBE.Mant_grupo_ide = Convert.ToInt32(cboGrupos.SelectedValue.ToString());
            TipoBE.Mant_grupo_codigo = cboGrupos.SelectedText.ToString();
            TipoBE.Mant_actividad_codigo = txtCodigo.Text;
            TipoBE.Mant_actividad_nombre = txtNombre.Text;
            TipoBE.Mant_actividad_kilometros = Convert.ToInt32(txtKilometros.Text);
            TipoBE.Mant_actividad_dias = Convert.ToInt32(txtDias.Text);
            TipoBE.Mant_actividad_estado = Convert.ToInt32(cboEstado.SelectedIndex);

            switch (Operacion)
            {
                case "N":
                    {
                        ENResultOperation R = ClsMantenimiento_Grupo_ActividadesBC.Crear(TipoBE);
                        if (!R.Proceder) MessageBox.Show("Error al Insertar " + R.Sms);
                        break;
                    }
                case "M":
                    {
                        ENResultOperation R = ClsMantenimiento_Grupo_ActividadesBC.Actualizar(TipoBE);
                        if (!R.Proceder) MessageBox.Show("Error al Modificar " + R.Sms);
                        break;
                    }
                case "E":
                    {
                        ENResultOperation R = ClsMantenimiento_Grupo_ActividadesBC.Eliminar(TipoBE);
                        if (!R.Proceder) MessageBox.Show("Error al Eliminar " + R.Sms);
                        break;
                    }
            }
            Operacion = "M";
            PanelGrupos.Visible = false;
            Habilitar_Botones(true);
            Habilitar_Campos(false);
            Mostrar(nGrupo_Ide);
        }

        private void frmMantenimiento_Grupo_Actividades_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }

        }

        private void txtKilometros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter) SendKeys.Send("{TAB}");
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Enter))
            {
                e.Handled = true;
                return;
            }
        }

        private void txtDias_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter) SendKeys.Send("{TAB}");
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Enter))
            {
                e.Handled = true;
                return;
            }
        }
        private void cboGrupos_Validated(object sender, EventArgs e)
        {
            Cargar_Registro_Grupo(Convert.ToInt32(cboGrupos.SelectedValue.ToString()));
            txtGrupo.Text = cCodigo_Grupo;
        }

        private void cboGrupos_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Cargar_Registro_Grupo(Convert.ToInt32(cboGrupos.SelectedValue.ToString()));
            txtGrupo.Text = cCodigo_Grupo;
        }

        private void txtCodigo_Validated(object sender, EventArgs e)
        {
            if (Grupo_Actividad_Existe_Codigo() && Operacion=="N")
            {
                MessageBox.Show("Codigo de Actividad " + txtCodigo.Text + " Ya Existe","Codigo de Actividad");
                txtCodigo.Text = "";
                txtCodigo.Focus();
            }
        }

        private void cboFiltrarGrupo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            nGrupo_Ide = Convert.ToInt32(cboFiltrarGrupo.SelectedValue.ToString());
            Mostrar(nGrupo_Ide);
        }

        private void cboFiltrarGrupo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

  
    }
}
