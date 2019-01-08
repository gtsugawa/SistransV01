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
    public partial class Mantenimiemto_Correctivo : Form
    {
        private string campo_busqueda;
        private string condi_busqueda;
        private Int32 iMant_Ide;
        private Int32 iTran_Ide;
        private Int32 iTran_Vehi_Ide;
        private Int32 nGrupo_Ide;
        private Int32 nActividad_Ide;
        private string Operacion;
        public Mantenimiemto_Correctivo()
        {
            InitializeComponent();
        }

        private void Mantenimiemto_Correctivo_Load(object sender, EventArgs e)
        {
            FormatoDgv();
            Inicializa_Fechas();
            Mostrar("");
            Habilitar_Botones(true);
            Habilitar_Campos(false);
            Cargar_Busquedas();
            Cargar_Grupos();
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
            dgv.ColumnCount = 28;
            // Setear Cabecera de Columna 
            dgv.Columns[0].Name = "MANT_IDE";
            dgv.Columns[1].Name = "TRAN_IDE";
            dgv.Columns[2].Name = "NOMBRE";
            dgv.Columns[3].Name = "TRAN_VEHI_IDE";
            dgv.Columns[4].Name = "PLACA";
            dgv.Columns[5].Name = "MANT_FECHA";
            dgv.Columns[6].Name = "MANT_KILOMETRAJE";
            dgv.Columns[7].Name = "MANT_SOLICITADO";
            dgv.Columns[8].Name = "MANT_REQUERIMIENTO";
            dgv.Columns[9].Name = "MANT_RESPONSABLE";
            dgv.Columns[10].Name = "MANT_DETALLE";
            dgv.Columns[11].Name = "MANT_SERVICIO";
            dgv.Columns[12].Name = "MANT_COSTO_IGV";
            dgv.Columns[13].Name = "MANT_RUC";
            dgv.Columns[14].Name = "MANT_PROVEEDOR";
            dgv.Columns[15].Name = "MANT_FECHA_FACTURA";
            dgv.Columns[16].Name = "MANT_NUMERO_FACTURA";
            dgv.Columns[17].Name = "MANT_MODO_PAGO";
            dgv.Columns[18].Name = "MANT_TRANSFERIDO";
            dgv.Columns[19].Name = "MANT_CONTACTO";
            dgv.Columns[20].Name = "MANT_ESTADO";
            dgv.Columns[21].Name = "MANT_OBSERVACIONES";
            dgv.Columns[22].Name = "MANT_GRUPO_IDE";
            dgv.Columns[23].Name = "MANT_ACTIVIDAD_IDE";
            dgv.Columns[24].Name = "MANT_FECHA_CREA";
            dgv.Columns[25].Name = "MANT_USUARIO_CREA";
            dgv.Columns[26].Name = "MANT_FECHA_ACT";
            dgv.Columns[27].Name = "MANT_USUARIO_ACT";


            dgv.Columns[0].Width = 40;
            dgv.Columns[0].HeaderText = "ID";
            dgv.Columns[0].DataPropertyName = "MANT_IDE";
            dgv.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgv.Columns[1].DataPropertyName = "TRAN_IDE";
            dgv.Columns[1].Visible = false;

            dgv.Columns[2].DataPropertyName = "NOMBRE";
            dgv.Columns[2].Visible = false;

            dgv.Columns[3].DataPropertyName = "TRAN_VEHI_IDE";
            dgv.Columns[3].Visible = false;

            dgv.Columns[4].Width = 100;
            dgv.Columns[4].HeaderText = "Placa";
            dgv.Columns[4].DataPropertyName = "PLACA";

            dgv.Columns[5].Width = 80;
            dgv.Columns[5].HeaderText = "Fecha";
            dgv.Columns[5].DataPropertyName = "MANT_FECHA";
            dgv.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgv.Columns[6].Width = 70;
            dgv.Columns[6].HeaderText = "Kilometraje";
            dgv.Columns[6].DataPropertyName = "MANT_KILOMETRAJE";
            dgv.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgv.Columns[7].Width = 180;
            dgv.Columns[7].HeaderText = "Solicitado Por";
            dgv.Columns[7].DataPropertyName = "MANT_SOLICITADO";

            dgv.Columns[8].Width = 180;
            dgv.Columns[8].HeaderText = "Requerimiento";
            dgv.Columns[8].DataPropertyName = "MANT_REQUERIMIENTO";

            dgv.Columns[9].Width = 180;
            dgv.Columns[9].HeaderText = "Responsable";
            dgv.Columns[9].DataPropertyName = "MANT_RESPONSABLE";

            dgv.Columns[10].Width = 180;
            dgv.Columns[10].HeaderText = "Detalle";
            dgv.Columns[10].DataPropertyName = "MANT_DETALLE";

            dgv.Columns[11].Width = 180;
            dgv.Columns[11].HeaderText = "Servicio";
            dgv.Columns[11].DataPropertyName = "MANT_SERVICIO";

            dgv.Columns[12].Width = 90;
            dgv.Columns[12].HeaderText = "Costo";
            dgv.Columns[12].DataPropertyName = "MANT_COSTO_IGV";
            dgv.Columns[12].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgv.Columns[13].DataPropertyName = "MANT_RUC";
            dgv.Columns[13].Visible = false;

            dgv.Columns[14].Width = 180;
            dgv.Columns[14].HeaderText = "Proveedor";
            dgv.Columns[14].DataPropertyName = "MANT_PROVEEDOR";

            dgv.Columns[15].DataPropertyName = "MANT_FECHA_FACTURA";
            dgv.Columns[15].Width = 80;
            dgv.Columns[15].HeaderText = "Fecha";
            dgv.Columns[15].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            dgv.Columns[16].Width = 90;
            dgv.Columns[16].HeaderText = "Nro.Factura";
            dgv.Columns[16].DataPropertyName = "MANT_NUMERO_FACTURA";

            dgv.Columns[17].Width = 180;
            dgv.Columns[17].HeaderText = "Modo de Pago";
            dgv.Columns[17].DataPropertyName = "MANT_MODO_PAGO";

            dgv.Columns[18].Width = 180;
            dgv.Columns[18].HeaderText = "Se Transfirio a ";
            dgv.Columns[18].DataPropertyName = "MANT_TRANSFERIDO";


            dgv.Columns[19].Width = 180;
            dgv.Columns[19].HeaderText = "Contacto";
            dgv.Columns[19].DataPropertyName = "MANT_CONTACTO";

            dgv.Columns[20].Width = 100;
            dgv.Columns[20].HeaderText = "Estado";
            dgv.Columns[20].DataPropertyName = "MANT_ESTADO";

            dgv.Columns[21].Width = 180;
            dgv.Columns[21].HeaderText = "Observaciones";
            dgv.Columns[21].DataPropertyName = "MANT_OBSERVACIONES";

            dgv.Columns[22].DataPropertyName = "MANT_GRUPO_IDE";
            dgv.Columns[22].Visible = false;

            dgv.Columns[23].DataPropertyName = "MANT_ACTIVIDAD_IDE";
            dgv.Columns[23].Visible = false;

            dgv.Columns[24].DataPropertyName = "MANT_FECHA_CREA";
            dgv.Columns[24].Visible = false;

            dgv.Columns[25].DataPropertyName = "MANT_USUARIO_CREA";
            dgv.Columns[25].Visible = false;

            dgv.Columns[26].DataPropertyName = "MANT_FECHA_ACT";
            dgv.Columns[26].Visible = false;

            dgv.Columns[27].DataPropertyName = "MANT_USUARIO_ACT";
            dgv.Columns[27].Visible = false;
        }
        private void Mostrar(string filtro)
        {
            ENResultOperation R = ClsMantenimiento_CorrectivoBC.Listar_por_Fechas(dtpFecIni.Value,dtpFecFin.Value);
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
                iMant_Ide = Convert.ToInt32(this.dgvListado.CurrentRow.Cells["MANT_IDE"].Value.ToString());
            }
        }

        private void dgvListado_CurrentCellChanged(object sender, EventArgs e)
        {
            Mostrar_Dgv();
        }
        private void Cargar_Busquedas()
        {
            cboBuscarPor.Items.Clear();
            cboBuscarPor.Items.Add("Placa");
            cboBuscarPor.Items.Add("Fecha");
            cboBuscarPor.SelectedIndex = 0;
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Inicializa_Campos()
        {
            txtPlaca.Text = "";
            dtpFechaSolicitud.Text = DateTime.Now.ToString();
            txtKilometraje.Text = "";
            txtSolicitado.Text = "";
            txtRequerimiento.Text = "";
            txtResponsable.Text = "";
            txtDetalle.Text = "";
            txtServicio.Text = "";
            txtEstado.Text = "";
            txtObservaciones.Text = "";
            txtRuc.Text = "";
            txtProveedor.Text = "";
            dtpFechaFactura.Text = DateTime.Now.ToString();
            txtNroFactura.Text = "";
            txtTotalCosto.Text = "";
            txtModoPago.Text = "";
            txtTransferido.Text = "";
            txtContacto.Text = "";
            iTran_Ide = 2564;
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
            txtPlaca.ReadOnly = !Flag;
            dtpFechaSolicitud.Enabled = Flag;
            txtKilometraje.ReadOnly = !Flag;
            txtSolicitado.ReadOnly = !Flag;
            txtRequerimiento.ReadOnly = !Flag;
            txtResponsable.ReadOnly = !Flag;
            txtDetalle.ReadOnly = !Flag;
            txtServicio.ReadOnly = !Flag;
            txtEstado.ReadOnly = !Flag;
            txtObservaciones.ReadOnly = !Flag;
            txtRuc.ReadOnly = !Flag;
            txtProveedor.ReadOnly = !Flag;
            dtpFechaFactura.Enabled = Flag;
            txtNroFactura.ReadOnly = !Flag;
            txtTotalCosto.ReadOnly = !Flag;
            txtModoPago.ReadOnly = !Flag;
            txtTransferido.ReadOnly = !Flag;
            txtContacto.ReadOnly = !Flag;
            txtPlaca.Focus();
        }

        private void Cargar_Registro(int nMant_Ide)
        {
            ENResultOperation R =  ClsMantenimiento_CorrectivoBC.Buscar_Registro(nMant_Ide);
            DataTable dtg = (DataTable)R.Valor;
            if (dtg.Rows.Count != 0)
            {
                DataRow ROWG = dtg.Rows[0];
                txtPlaca.Text = ROWG["PLACA"].ToString();
                dtpFechaSolicitud.Text = ROWG["MANT_FECHA"].ToString();
                txtKilometraje.Text = ROWG["MANT_KILOMETRAJE"].ToString();
                txtSolicitado.Text = ROWG["MANT_SOLICITADO"].ToString();
                txtRequerimiento.Text = ROWG["MANT_REQUERIMIENTO"].ToString();
                txtResponsable.Text = ROWG["MANT_RESPONSABLE"].ToString();
                txtDetalle.Text = ROWG["MANT_REQUERIMIENTO"].ToString();
                txtServicio.Text = ROWG["MANT_SERVICIO"].ToString();
                txtEstado.Text = ROWG["MANT_ESTADO"].ToString();
                txtObservaciones.Text = ROWG["MANT_OBSERVACIONES"].ToString();
                txtRuc.Text = ROWG["MANT_RUC"].ToString();
                txtProveedor.Text = ROWG["MANT_PROVEEDOR"].ToString();
                dtpFechaFactura.Text = ROWG["MANT_FECHA_FACTURA"].ToString();
                txtNroFactura.Text = ROWG["MANT_NUMERO_FACTURA"].ToString();
                txtTotalCosto.Text = ROWG["MANT_COSTO_IGV"].ToString();
                txtModoPago.Text = ROWG["MANT_MODO_PAGO"].ToString();
                txtTransferido.Text = ROWG["MANT_TRANSFERIDO"].ToString();
                txtContacto.Text = ROWG["MANT_CONTACTO"].ToString();
                iTran_Ide = Convert.ToInt32(ROWG["TRAN_IDE"].ToString());
                iTran_Vehi_Ide = Convert.ToInt32(ROWG["TRAN_VEHI_IDE"].ToString());

                nGrupo_Ide = Convert.ToInt32(ROWG["MANT_GRUPO_IDE"].ToString());
                cboGrupos.SelectedValue = nGrupo_Ide;

                Cargar_Actividades();

                nActividad_Ide = Convert.ToInt32(ROWG["MANT_ACTIVIDAD_IDE"].ToString());
                cboActividades.SelectedValue = nActividad_Ide;
            }
            else
            {
                Habilitar_Botones(true);
            }

        }

        private Boolean Verifica_Campos()
        {
            if (iTran_Vehi_Ide==0)
            {
                MessageBox.Show("No se Ha Obtenido Registro del Vehiculo", "Mantenimiento Correctivo");
                return false;
            }
            if (string.IsNullOrEmpty(txtPlaca.Text))
            {
                MessageBox.Show("No se Ha seleccionado Placa del Vehiculo", "Mantenimiento Correctivo");
                return false;
            }
            if (string.IsNullOrEmpty(txtKilometraje.Text))
            {
                MessageBox.Show("No se Ha Ingresado Kilometraje del Vehiculo", "Mantenimiento Correctivo");
                return false;
            }
            if (string.IsNullOrEmpty(txtSolicitado.Text))
            {
                MessageBox.Show("No se Ha seleccionado Campo Solicitado Por", "Mantenimiento Correctivo");
                return false;
            }

            return true;
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            PanelMantenimiento.Visible = true;
            Operacion = "N";
            Inicializa_Campos();
            Habilitar_Botones(false);
            Habilitar_Campos(true);
            Cargar_Actividades();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            PanelMantenimiento.Visible = true;
            Operacion = "M";
            Habilitar_Botones(false);
            Habilitar_Campos(true);
            Cargar_Registro(iMant_Ide);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            PanelMantenimiento.Visible = true;
            Operacion = "E";
            Habilitar_Botones(false);
            Habilitar_Campos(false);
            Cargar_Registro(iMant_Ide);
            btnGrabar.Text = "Eliminar";
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            Reportes.rptMant_Correctivo frmrpt = new Reportes.rptMant_Correctivo();
            frmrpt.fecha1 = dtpFecIni.Value;
            frmrpt.fecha2 = dtpFecFin.Value;
            frmrpt.RangoFecha = "Del : " + dtpFecIni.Value.ToShortDateString() + " Al : " + dtpFecFin.Value.ToShortDateString();
            frmrpt.Empresa = "TERAH S.A.C";
            frmrpt.Titulo = "MANTENIMIENTO CORRECTIVO";
            frmrpt.ShowDialog();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (Verifica_Campos())  Procesar_Operacion();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            PanelMantenimiento.Visible = false;
            Habilitar_Botones(true);
            //Mostrar("");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Procesar_Operacion()
        {
            ClsMantenimiento_CorrectivoBE TipoBE = new ClsMantenimiento_CorrectivoBE();
            TipoBE.Mant_ide = iMant_Ide;
            TipoBE.Tran_ide = iTran_Ide;
            TipoBE.Tran_vehi_ide = iTran_Vehi_Ide;
            if (string.IsNullOrEmpty(txtKilometraje.Text)) txtKilometraje.Text = "0";
            TipoBE.Mant_kilometraje = Convert.ToInt32(txtKilometraje.Text);
            TipoBE.Mant_fecha = Convert.ToDateTime(dtpFechaSolicitud.Text.ToString());
            TipoBE.Mant_solicitado = txtSolicitado.Text;
            TipoBE.Mant_requerimiento = txtRequerimiento.Text;
            TipoBE.Mant_responsable = txtResponsable.Text;
            TipoBE.Mant_detalle = txtDetalle.Text;
            TipoBE.Mant_servicio = txtServicio.Text;
            if (string.IsNullOrEmpty(txtTotalCosto.Text)) txtTotalCosto.Text = "0";
            TipoBE.Mant_costo_igv = Convert.ToDecimal(txtTotalCosto.Text);
            TipoBE.Mant_ruc = txtRuc.Text;
            TipoBE.Mant_proveedor = txtProveedor.Text;
            TipoBE.Mant_fecha_factura = Convert.ToDateTime(dtpFechaFactura.Text.ToString());
            TipoBE.Mant_numero_factura = txtNroFactura.Text;
            TipoBE.Mant_modo_pago = txtModoPago.Text;
            TipoBE.Mant_transferido = txtTransferido.Text;
            TipoBE.Mant_contacto = txtContacto.Text;
            TipoBE.Mant_estado = txtEstado.Text;
            TipoBE.Mant_observaciones = txtObservaciones.Text;
            TipoBE.Mant_grupo_ide = nGrupo_Ide;
            TipoBE.Mant_actividad_ide = nActividad_Ide;
            TipoBE.Mant_usuario_crea = "JUAN";
            TipoBE.Mant_usuario_act = "JUAN";

            switch (Operacion)
            {
                case "N":
                    {
                        ENResultOperation R = ClsMantenimiento_CorrectivoBC.Crear(TipoBE);
                        if (!R.Proceder) MessageBox.Show("Error al Insertar " + R.Sms);
                        break;
                    }
                case "M":
                    {
                        ENResultOperation R = ClsMantenimiento_CorrectivoBC.Actualizar(TipoBE);
                        if (!R.Proceder) MessageBox.Show("Error al Modificar " + R.Sms);
                        break;
                    }
                case "E":
                    {
                        ENResultOperation R = ClsMantenimiento_CorrectivoBC.Eliminar(TipoBE);
                        if (!R.Proceder) MessageBox.Show("Error al Eliminar " + R.Sms);
                        break;
                    }
            }
            PanelMantenimiento.Visible = false;
            Habilitar_Botones(true);
            Habilitar_Campos(false);
            Mostrar("");
        }

        private void txtPlaca_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3) Buscar_Placa();
            if (e.KeyCode == Keys.Escape) btnCancelar.PerformClick();
        }

        private void txtPlaca_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter) SendKeys.Send("{TAB}");

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

        private void dtpFechaSolicitud_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter) SendKeys.Send("{TAB}");
        }

        private void txtKilometraje_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter) SendKeys.Send("{TAB}");
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Enter))
            {
                e.Handled = true;
                return;
            }
        }

        private void txtSolicitado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter) SendKeys.Send("{TAB}");
        }

        private void txtRequerimiento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter) SendKeys.Send("{TAB}");
        }

        private void txtResponsable_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter) SendKeys.Send("{TAB}");
        }

        private void txtDetalle_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter) SendKeys.Send("{TAB}");
        }

        private void txtServicio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter) SendKeys.Send("{TAB}");
        }

        private void txtEstado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter) SendKeys.Send("{TAB}");
        }

        private void txtObservaciones_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter) SendKeys.Send("{TAB}");
        }

        private void txtRuc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter) SendKeys.Send("{TAB}");
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Enter))
            {
                e.Handled = true;
                return;
            }
        }

        private void txtProveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter) SendKeys.Send("{TAB}");
        }

        private void dtpFechaFactura_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter) SendKeys.Send("{TAB}");
        }

        private void txtNroFactura_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter) SendKeys.Send("{TAB}");
        }

        private void txtTotalCosto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter) SendKeys.Send("{TAB}");
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Enter) && (e.KeyChar != 46))
            {
                e.Handled = true;
                return;
            }
        }

        private void txtModoPago_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter) SendKeys.Send("{TAB}");
        }

        private void txtTransferido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter) SendKeys.Send("{TAB}");
        }

        private void txtContacto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter) btnGrabar.Focus();
        }

        private void txtBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Filtrar_Registros();
            }           
        }

        private void Filtrar_Registros()
        {
            switch (cboBuscarPor.Text)
            {
                case "Fecha": campo_busqueda = "FECHA";
                    condi_busqueda = txtBuscar.Text.Trim();
                    break;
                case "Placa": campo_busqueda = "PLACA";
                    condi_busqueda = txtBuscar.Text.Trim();
                    break;
            }
            Ejecutar_filtro(campo_busqueda, condi_busqueda, dtpFecIni.Value, dtpFecFin.Value);
        }

        private void Ejecutar_filtro(string campo_busqueda, string condi_busqueda, DateTime FecIni, DateTime FecFin)
        {

            DataTable TEMP = new DataTable();
            ENResultOperation R = ClsMantenimiento_CorrectivoBC.Listar_Filtro(campo_busqueda, condi_busqueda, FecIni, FecFin);
            if (R.Proceder) dgvListado.DataSource = (DataTable)R.Valor;
            TEMP = (DataTable)R.Valor;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Filtrar_Registros();
        }

        private void btnBuscarxFechas_Click(object sender, EventArgs e)
        {
            txtBuscar.Text = "";
            DataTable TEMP = new DataTable();
            ENResultOperation R = ClsMantenimiento_CorrectivoBC.Listar_por_Fechas(dtpFecIni.Value, dtpFecFin.Value);
            if (R.Proceder) dgvListado.DataSource = (DataTable)R.Valor;
            TEMP = (DataTable)R.Valor;
        }

        private void dtpFecIni_Validated(object sender, EventArgs e)
        {
            DateTime fecha2;
            DateTime fechatemp;
            fechatemp = dtpFecIni.Value;
            fecha2 = fechatemp.AddMonths(1).AddDays(-1);
            dtpFecFin.Text = fecha2.ToShortDateString();
        }

        private void dtpFecFin_Validated(object sender, EventArgs e)
        {
            DateTime fecha1;
            DateTime fechatemp;
            fechatemp = dtpFecFin.Value;
            if (dtpFecFin.Value < dtpFecIni.Value)
            {
                fecha1 = new DateTime(fechatemp.Year, fechatemp.Month, 1);
                dtpFecIni.Text = fecha1.ToShortDateString();
            }
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
            if (cboActividades.Items.Count != 0) nActividad_Ide = Convert.ToInt32(cboActividades.SelectedValue.ToString());
        }

        private void cboGrupos_SelectionChangeCommitted(object sender, EventArgs e)
        {
            nGrupo_Ide = Convert.ToInt32(cboGrupos.SelectedValue.ToString());
            Cargar_Actividades();
        }

        private void cboActividades_SelectionChangeCommitted(object sender, EventArgs e)
        {
            nActividad_Ide = Convert.ToInt32(cboActividades.SelectedValue.ToString());
        }

    }
}
