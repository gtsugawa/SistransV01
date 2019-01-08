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
    public partial class frmMantenimiento_Programado : Form
    {
        private string campo_busqueda;
        private string condi_busqueda;
        private string Operacion;

        private Int32 iTran_Ide;
        private Int32 iTran_Vehi_Ide;
        private Int32 iMant_Prog_Ide;
        private Int32 nActividad_Ide;
        private Int32 nGrupo_Ide;
        private Int32 nKilometros;
        public frmMantenimiento_Programado()
        {
            InitializeComponent();
        }

        private void frmMantenimiento_Programado_Load(object sender, EventArgs e)
        {
            FormatoDgv();
            Inicializa_Fechas();
            Mostrar("");
            Habilitar_Botones(true);
            Habilitar_Campos(false);
            PanelProgramacion.Visible = false;
        }
        private void Inicializa_Fechas()
        {
            DateTime fecha1;
            DateTime fecha2;
            DateTime fechatemp;
            fechatemp = DateTime.Today;
            fecha1 = new DateTime(fechatemp.Year, fechatemp.Month, 1);
            fecha2 = fecha1.AddMonths(1).AddDays(-1);
            dtpFecIni.Text = fecha1.ToShortDateString();
            dtpFecFin.Text = fecha2.ToShortDateString();

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
            dgv.ColumnCount = 18;
            // Setear Cabecera de Columna 
            dgv.Columns[0].Name = "MANT_PROG_IDE";
            dgv.Columns[1].Name = "TRAN_IDE";
            dgv.Columns[2].Name = "TRAN_VEHI_IDE";
            dgv.Columns[3].Name = "TRAN_VEHI_PLACA";
            dgv.Columns[4].Name = "MANT_GRUPO_IDE";
            dgv.Columns[5].Name = "GRUPO_NOMBRE";
            dgv.Columns[6].Name = "MANT_ACTIVIDAD_IDE";
            dgv.Columns[7].Name = "ACTIVIDAD_NOMBRE";
            dgv.Columns[8].Name = "MANT_PROG_DIAS";
            dgv.Columns[9].Name = "MANT_PROG_KILOMETROS";
            dgv.Columns[10].Name = "MANT_PROG_ULTIMA_FECHA";
            dgv.Columns[11].Name = "MANT_PROG_ULTIMO_KILOMETRAJE";
            dgv.Columns[12].Name = "MANT_PROG_PROXIMA_FECHA";
            dgv.Columns[13].Name = "MANT_PROG_PROXIMO_KILOMETRAJE";
            dgv.Columns[14].Name = "MANT_PROG_DETALLE";
            dgv.Columns[15].Name = "MANT_PROG_USUARIO";
            dgv.Columns[16].Name = "MANT_PROG_FECHA";
            dgv.Columns[17].Name = "MANT_PROG_ESTADO";

            dgv.Columns[0].Width = 40;
            dgv.Columns[0].HeaderText = "ID";
            dgv.Columns[0].DataPropertyName = "MANT_PROG_IDE";
            dgv.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgv.Columns[1].DataPropertyName = "TRAN_IDE";
            dgv.Columns[1].Visible = false;

            dgv.Columns[2].DataPropertyName = "TRAN_VEHI_IDE";
            dgv.Columns[2].Visible = false;

            dgv.Columns[3].Width = 80;
            dgv.Columns[3].HeaderText = "Placa";
            dgv.Columns[3].DataPropertyName = "TRAN_VEHI_PLACA";
            dgv.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgv.Columns[4].Width = 70;
            dgv.Columns[4].HeaderText = "GRUPO";
            dgv.Columns[4].DataPropertyName = "MANT_GRUPO_IDE";
            dgv.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgv.Columns[5].Width = 70;
            dgv.Columns[5].HeaderText = "NOMBRE GRUPO";
            dgv.Columns[5].DataPropertyName = "GRUPO_NOMBRE";
            dgv.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;


            dgv.Columns[6].Width = 180;
            dgv.Columns[6].HeaderText = "ACTIVIDAD";
            dgv.Columns[6].DataPropertyName = "MANT_ACTIVIDAD_IDE";

            dgv.Columns[7].Width = 180;
            dgv.Columns[7].HeaderText = "ACTIVIDAD NOMBRE";
            dgv.Columns[7].DataPropertyName = "ACTIVIDAD_NOMBRE";


            dgv.Columns[8].Width = 180;
            dgv.Columns[8].HeaderText = "C/DIAS";
            dgv.Columns[8].DataPropertyName = "MANT_PROG_DIAS";

            dgv.Columns[9].Width = 180;
            dgv.Columns[9].HeaderText = "C/KMS";
            dgv.Columns[9].DataPropertyName = "MANT_PROG_KILOMETRAJE";

            dgv.Columns[10].Width = 180;
            dgv.Columns[10].HeaderText = "Ultima Fecha";
            dgv.Columns[10].DataPropertyName = "MANT_PROG_ULTIMA_FECHA";

            dgv.Columns[11].Width = 180;
            dgv.Columns[11].HeaderText = "Ultimo Kilometraje";
            dgv.Columns[11].DataPropertyName = "MANT_PROG_ULTIMO_KILOMETRAJE";

            dgv.Columns[12].Width = 90;
            dgv.Columns[12].HeaderText = "Proxima Fecha";
            dgv.Columns[12].DataPropertyName = "MANT_PROG_PROXIMA_FECHA";
            dgv.Columns[12].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgv.Columns[13].Width = 90;
            dgv.Columns[13].HeaderText = "Proximo Kilometraje";
            dgv.Columns[13].DataPropertyName = "MANT_PROG_PROXIMO_KILOMETRAJE";
            dgv.Columns[13].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgv.Columns[14].Width = 180;
            dgv.Columns[14].HeaderText = "DETALLE  ";
            dgv.Columns[14].DataPropertyName = "MANT_PROG_DETALLE";

            dgv.Columns[15].DataPropertyName = "MANT_PROG_USUARIO";
            dgv.Columns[15].Visible = false;

            dgv.Columns[16].DataPropertyName = "MANT_PROG_FECHA";
            dgv.Columns[16].Visible = false;

            dgv.Columns[17].DataPropertyName = "MANT_PROG_ESTADO";
            dgv.Columns[17].Visible = false;

        }

        private void Mostrar(string filtro)
        {
            ENResultOperation R = ClsMantenimiento_ProgramadoBC.Listar_por_Fechas(dtpFecIni.Value, dtpFecFin.Value);
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
                iMant_Prog_Ide = Convert.ToInt32(this.dgvListado.CurrentRow.Cells["MANT_PROG_IDE"].Value.ToString());
            }
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Operacion = "N";
            PanelProgramacion.Visible = true;
            Inicializa_Campos();
            Cargar_Grupos();
            Cargar_Actividades();
            Habilitar_Botones(false);
            Habilitar_Campos(true);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Operacion = "M";
            PanelProgramacion.Visible = true;
            Habilitar_Botones(false);
            Habilitar_Campos(true);
            Cargar_Registro(iMant_Prog_Ide);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Operacion = "E";
            PanelProgramacion.Visible = true;
            Habilitar_Botones(false);
            Habilitar_Campos(false);
            Cargar_Registro(iMant_Prog_Ide);
            btnGrabar.Text = "Eliminar";
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {

        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (Verifica_Campos()) Procesar_Operacion();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            PanelProgramacion.Visible = false;
            Habilitar_Botones(true);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private Boolean Verifica_Campos()
        {
            if (iTran_Vehi_Ide == 0)
            {
                MessageBox.Show("No se Ha Obtenido Registro del Vehiculo", "Mantenimiento Correctivo");
                return false;
            }
            return true;
        }
        private void Cargar_Registro(int nMant_Ide)
        {
            ENResultOperation R = ClsMantenimiento_ProgramadoBC.Buscar_Registro(iMant_Prog_Ide);
            DataTable dtg = (DataTable)R.Valor;
            if (dtg.Rows.Count != 0)
            {
                DataRow ROWG = dtg.Rows[0];
                txtPlaca.Text = ROWG["TRAN_VEHI_PLACA"].ToString();
                iTran_Ide = Convert.ToInt32(ROWG["TRAN_IDE"].ToString());
                iTran_Vehi_Ide = Convert.ToInt32(ROWG["TRAN_VEHI_IDE"].ToString());
                txtFrecKms.Text = ROWG["MANT_PROG_KILOMETROS"].ToString();
                txtFrecDias.Text = ROWG["MANT_PROG_DIAS"].ToString();
                txtUltKm.Text = ROWG["MANT_PROG_ULTIMO_KILOMETRAJE"].ToString();
                dtpUltFecha.Text = ROWG["MANT_PROG_ULTIMA_FECHA"].ToString();
                txtDetalle.Text = ROWG["MANT_PROG_DETALLE"].ToString();
                txtProxKm.Text = ROWG["MANT_PROG_PROXIMO_KILOMETRAJE"].ToString();
                dtpProxFecha.Text = ROWG["MANT_PROG_ULTIMA_FECHA"].ToString();
                cboGrupos.SelectedValue = Convert.ToInt32(ROWG["MANT_GRUPO_IDE"].ToString());
                cboActividades.SelectedValue = Convert.ToInt32(ROWG["MANT_ACTIVIDAD_IDE"].ToString());

                nGrupo_Ide = Convert.ToInt32(ROWG["MANT_GRUPO_IDE"].ToString());
                cboGrupos.SelectedValue = nGrupo_Ide;

                Cargar_Grupos();
                Cargar_Actividades();

                nActividad_Ide = Convert.ToInt32(ROWG["MANT_ACTIVIDAD_IDE"].ToString());
                cboActividades.SelectedValue = nActividad_Ide;

            }
            else
            {
                Habilitar_Botones(true);
            }

        }

        private void Inicializa_Campos()
        {
            iTran_Ide = 2564;
            txtIde.Text = "";
            txtPlaca.Text = "";
            txtFrecKms.Text = "";
            txtFrecDias.Text = "";
            txtUltKm.Text = "";
            txtProxKm.Text = "";
            cboGrupos.Text = "";
            cboActividades.Text = "";
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
            txtPlaca.ReadOnly = !Flag;
            txtFrecKms.ReadOnly = !Flag;
            txtFrecDias.ReadOnly = !Flag;
            txtUltKm.ReadOnly = !Flag;
            txtProxKm.ReadOnly = !Flag;
            cboGrupos.Enabled = Flag;
            cboActividades.Enabled = Flag;
            txtPlaca.Focus();
        }

        private void Cargar_Grupos()
        {
            ENResultOperation R = ClsMantenimiento_GruposBC.Listar("");
            if (R.Proceder) cboGrupos.DataSource = (DataTable)R.Valor;
            cboGrupos.DisplayMember = "MANT_GRUPO_NOMBRE";
            cboGrupos.ValueMember = "MANT_GRUPO_IDE";
            cboGrupos.DropDownStyle = ComboBoxStyle.DropDownList;
            nGrupo_Ide = 0;
            if (cboGrupos.Items.Count != 0) nGrupo_Ide = Convert.ToInt32(cboGrupos.SelectedValue.ToString());
        }

        private void Cargar_Actividades()
        {
            ENResultOperation R = ClsMantenimiento_Grupo_ActividadesBC.Obtener_Actividades_Grupo(nGrupo_Ide);
            if (R.Proceder) cboActividades.DataSource = (DataTable)R.Valor;
            cboActividades.DisplayMember = "MANT_ACTIVIDAD_NOMBRE";
            cboActividades.ValueMember = "MANT_ACTIVIDAD_IDE";
            cboActividades.DropDownStyle = ComboBoxStyle.DropDownList;
            nActividad_Ide = 0;
            if (cboActividades.Items.Count != 0)
            {
                nActividad_Ide = Convert.ToInt32(cboActividades.SelectedValue.ToString());
                Cargar_Registro_Actividades(nActividad_Ide);
            }
        }

        private void Procesar_Operacion()
        {
            ClsMantenimiento_ProgramadoBE TipoBE = new ClsMantenimiento_ProgramadoBE();
            TipoBE.Mant_prog_ide = iMant_Prog_Ide;
            TipoBE.Tran_ide = iTran_Ide;
            TipoBE.Tran_vehi_ide = iTran_Vehi_Ide;
            TipoBE.Tran_vehi_placa = txtPlaca.Text;
            if (string.IsNullOrEmpty(txtFrecKms.Text)) txtFrecKms.Text = "0";
            TipoBE.Mant_prog_kilometros = Convert.ToInt32(txtFrecKms.Text);
            if (string.IsNullOrEmpty(txtFrecDias.Text)) txtFrecDias.Text = "0";
            TipoBE.Mant_prog_dias = Convert.ToInt32(txtFrecDias.Text);
            if (string.IsNullOrEmpty(txtUltKm.Text)) txtUltKm.Text = "0";
            TipoBE.Mant_prog_ultimo_kilometraje = Convert.ToInt32(txtUltKm.Text);
            TipoBE.Mant_prog_ultima_fecha = Convert.ToDateTime(dtpUltFecha.Text);
            TipoBE.Mant_prog_detalle = txtDetalle.Text;
            if (string.IsNullOrEmpty(txtProxKm.Text)) txtProxKm.Text = "0";
            TipoBE.Mant_prog_proximo_kilometraje = Convert.ToInt32(txtProxKm.Text);
            TipoBE.Mant_prog_proxima_fecha = Convert.ToDateTime(dtpProxFecha.Text);
            TipoBE.Mant_prog_usuario = "JUAN";
            TipoBE.Mant_grupo_ide = Convert.ToInt32(cboGrupos.SelectedValue.ToString());
            TipoBE.Mant_actividad_ide = Convert.ToInt32(cboActividades.SelectedValue.ToString());

            switch (Operacion)
            {
                case "N":
                    {
                        ENResultOperation R = ClsMantenimiento_ProgramadoBC.Crear(TipoBE);
                        if (!R.Proceder) MessageBox.Show("Error al Insertar " + R.Sms);
                        break;
                    }
                case "M":
                    {
                        ENResultOperation R = ClsMantenimiento_ProgramadoBC.Actualizar(TipoBE);
                        if (!R.Proceder) MessageBox.Show("Error al Modificar " + R.Sms);
                        break;
                    }
                case "E":
                    {
                        ENResultOperation R = ClsMantenimiento_ProgramadoBC.Eliminar(TipoBE);
                        if (!R.Proceder) MessageBox.Show("Error al Eliminar " + R.Sms);
                        break;
                    }
            }
            PanelProgramacion.Visible = false;
            Habilitar_Botones(true);
            Habilitar_Campos(false);
            Mostrar("");
        }

        private void frmMantenimiento_Programado_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }

        private void txtPlaca_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3) Buscar_Placa();
            if (e.KeyCode == Keys.Escape) btnCancelar.PerformClick();
        }

        private void txtPlaca_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                Buscar_Placa();
                SendKeys.Send("{TAB}");
            }
        }

        private void Buscar_Placa()
        {
            ENResultOperation R = ClsTransportista_VehiculoBC.Listar_Filtro(txtPlaca.Text, iTran_Ide);
            if (R.Proceder)
            {
                DataTable dt = (DataTable)R.Valor;
                if (dt.Rows.Count == 1)
                {
                    DataRow ROW = dt.Rows[0];
                    txtPlaca.Text = ROW["TRAN_VEHI_PLACA"].ToString();
                    iTran_Ide = Convert.ToInt32(ROW["TRAN_IDE"]);
                    iTran_Vehi_Ide = Convert.ToInt32(ROW["TRAN_VEHI_IDE"]);
                    lblNombre.Text = ROW["TRAN_VEHI_NOMBRE"].ToString();
                }
                else
                {
                    Transportista.frmTransportista_Vehiculo_Buscar frmBuscarVeh = new Transportista.frmTransportista_Vehiculo_Buscar();
                    frmBuscarVeh.Transportista_Ide = iTran_Ide;
                    frmBuscarVeh.Vehiculo_Placa = txtPlaca.Text;
                    frmBuscarVeh.ShowDialog();
                    txtPlaca.Text = frmBuscarVeh.Vehiculo_Placa;
                    iTran_Vehi_Ide = Convert.ToInt32(frmBuscarVeh.Vehiculo_Ide);
                    lblNombre.Text = frmBuscarVeh.Vehiculo_Nombre;
                }
            }
        }

        private void cboGrupos_SelectionChangeCommitted(object sender, EventArgs e)
        {
            nGrupo_Ide = Convert.ToInt32(cboGrupos.SelectedValue.ToString());
            Cargar_Actividades();
        }

        private void cboActividades_SelectionChangeCommitted(object sender, EventArgs e)
        {
            nActividad_Ide = Convert.ToInt32(cboActividades.SelectedValue.ToString());
            Cargar_Registro_Actividades(nActividad_Ide);
        }

        private void Cargar_Registro_Actividades(int nMant_Ide)
        {
            if (string.IsNullOrEmpty(txtFrecKms.Text) && string.IsNullOrEmpty(txtFrecDias.Text))
            {
                ENResultOperation R = ClsMantenimiento_Grupo_ActividadesBC.Buscar_Registro(nMant_Ide);
                DataTable dtg = (DataTable)R.Valor;
                if (dtg.Rows.Count != 0)
                {
                    DataRow ROWG = dtg.Rows[0];
                    txtFrecKms.Text = ROWG["MANT_ACTIVIDAD_KILOMETROS"].ToString();
                    txtFrecDias.Text = ROWG["MANT_ACTIVIDAD_DIAS"].ToString();
                }
            }
        }

        private void cboGrupos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter) SendKeys.Send("{TAB}");
        }

        private void cboActividades_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter) SendKeys.Send("{TAB}");
        }

        private void txtPlaca_Validated(object sender, EventArgs e)
        {

        }

        private void txtFrecKms_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter) SendKeys.Send("{TAB}");
        }

        private void txtFrecDias_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter) SendKeys.Send("{TAB}");
        }

        private void dtpUltFecha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter) SendKeys.Send("{TAB}");
        }

        private void txtUltKm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter) SendKeys.Send("{TAB}");
        }

        private void dtpProxFecha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter) SendKeys.Send("{TAB}");
        }

        private void txtProxKm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter) SendKeys.Send("{TAB}");
        }

        private void dtpUltFecha_Validated(object sender, EventArgs e)
        {
            dtpProxFecha.Value = dtpProxFecha.Value.AddDays(Convert.ToInt32(txtFrecDias.Text.ToString()));
        }

        private void txtUltKm_Validated(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUltKm.Text)) txtUltKm.Text = "0";
            if (string.IsNullOrEmpty(txtFrecKms.Text)) txtFrecKms.Text = "0";
            nKilometros = (Convert.ToInt32(txtUltKm.Text.ToString()) + Convert.ToInt32(txtFrecKms.Text.ToString()));

            txtProxKm.Text = nKilometros.ToString();
        }

        private void txtDetalle_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter) SendKeys.Send("{TAB}");

        }

        private void dgvListado_CurrentCellChanged(object sender, EventArgs e)
        {
            Mostrar_Dgv();
        }
    }
}
