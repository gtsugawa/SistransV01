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

namespace CapaPresentacion.Mantenimiento
{
    public partial class frmConsumo_Lubricante : Form
    {
        private string NomEmpresa;
        private string Operacion;
        private DateTime fecha1;
        private DateTime fecha2;
        private Int32 iCons_Ide;
        private Int32 iComp_Ide;
        private Int32 nGrupo_Ide;
        private Int32 nActividad_Ide;
        private Int32 nTran_Ide;
        private Int32 nTran_Vehi_Ide;

        public frmConsumo_Lubricante()
        {
            InitializeComponent();
        }

        private void frmConsumo_Lubricante_Load(object sender, EventArgs e)
        {
            ToolTip toolTip1 = new ToolTip();
            toolTip1.SetToolTip(this.txtComp_Ide, "[F3] Para Consultar Compras de Lubricantes");
            toolTip1.SetToolTip(this.txtPlaca, "[F3] Para Consultar Vehiculos");
            FormatoDgv();
            Inicializa_Fechas();
            Mostrar("");
            PanelMantenimiento.Visible = false;
            nTran_Ide  = 2564;
            nGrupo_Ide = 12;
            nActividad_Ide = 9;
            txtCons_Ide.ReadOnly = true;
            txtGrupo.ReadOnly = true;
            txtActividad.ReadOnly = true;
            txtTotal.ReadOnly = true;
            txtGrupo.Text = "SISTEMA DE LUBRICACION";
            txtActividad.Text = "CAMBIO DE ACEITE";
        }
        private void Inicializa_Fechas()
        {
            DateTime fecha1 = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            DateTime fecha2 = fecha1.AddMonths(1).AddTicks(-1);
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
            dgv.ColumnCount = 23;
            // Setear Cabecera de Columna 
            dgv.Columns[0].Name = "IDE";
            dgv.Columns[0].DataPropertyName = "CONS_IDE";
            dgv.Columns[0].Width = 30;
            dgv.Columns[0].HeaderText = "Id";
            dgv.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgv.Columns[1].Name = "COMP_IDE";
            dgv.Columns[1].DataPropertyName = "COMP_IDE";
            dgv.Columns[1].Visible = false;

            dgv.Columns[2].Name = "CONS_FECHA";
            dgv.Columns[2].DataPropertyName = "CONS_FECHA";
            dgv.Columns[2].Width = 80;
            dgv.Columns[2].HeaderText = "Fecha";
            dgv.Columns[2].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgv.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgv.Columns[3].Name = "CONS_NUMERO";
            dgv.Columns[3].DataPropertyName = "CONS_NUMERO";
            dgv.Columns[3].Visible = false;

            dgv.Columns[4].Name = "DESCRIPCION";
            dgv.Columns[4].DataPropertyName = "DESCRIPCION";
            dgv.Columns[4].Visible = false;

            dgv.Columns[5].Name = "TRAN_IDE";
            dgv.Columns[5].DataPropertyName = "TRAN_IDE";
            dgv.Columns[5].Visible = false;

            dgv.Columns[6].Name = "TRAN_VEHI_IDE";
            dgv.Columns[6].DataPropertyName = "TRAN_VEHI_IDE";
            dgv.Columns[6].Visible = false;

            dgv.Columns[7].Name = "PLACA";
            dgv.Columns[7].DataPropertyName = "PLACA";
            dgv.Columns[7].Width = 100;
            dgv.Columns[7].HeaderText = "Placa";

            dgv.Columns[8].Name = "CONFIGURACION";
            dgv.Columns[8].DataPropertyName = "CONFIGURACION";
            dgv.Columns[8].Width = 100;
            dgv.Columns[8].HeaderText = "Configuracion";

            dgv.Columns[9].Name = "NOMBRE";
            dgv.Columns[9].DataPropertyName = "NOMBRE";
            dgv.Columns[9].Width = 100;
            dgv.Columns[9].HeaderText = "Marca";
            dgv.Columns[9].Visible = false;

            dgv.Columns[10].Name = "MANT_GRUPO_IDE";
            dgv.Columns[10].DataPropertyName = "MANT_GRUPO_IDE";
            dgv.Columns[10].Width = 100;
            dgv.Columns[10].HeaderText = "Grupo";
            dgv.Columns[10].Visible = false;

            dgv.Columns[11].Name = "GRUPO";
            dgv.Columns[11].DataPropertyName = "GRUPO";
            dgv.Columns[11].Width = 100;
            dgv.Columns[11].HeaderText = "Grupo";
            dgv.Columns[11].Visible = false;

            dgv.Columns[12].Name = "MANT_ACTIVIDAD_IDE";
            dgv.Columns[12].DataPropertyName = "MANT_ACTIVIDAD_IDE";
            dgv.Columns[12].Width = 100;
            dgv.Columns[12].HeaderText = "Actividad";
            dgv.Columns[12].Visible = false;

            dgv.Columns[13].Name = "ACTIVIDAD";
            dgv.Columns[13].DataPropertyName = "ACTIVIDAD";
            dgv.Columns[13].Width = 100;
            dgv.Columns[13].HeaderText = "Actividad";
            dgv.Columns[13].Visible = false;

            dgv.Columns[14].Name = "CONS_CANTIDAD";
            dgv.Columns[14].DataPropertyName = "CONS_CANTIDAD";
            dgv.Columns[14].Width = 60;
            dgv.Columns[14].HeaderText = "Cantidad";
            dgv.Columns[14].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgv.Columns[15].Name = "CONS_UNIDAD";
            dgv.Columns[15].DataPropertyName = "CONS_UNIDAD";
            dgv.Columns[15].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.Columns[15].Width = 60;
            dgv.Columns[15].HeaderText = "Unidad";

            dgv.Columns[16].Name = "CONS_IMPORTE";
            dgv.Columns[16].DataPropertyName = "CONS_IMPORTE";
            dgv.Columns[16].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgv.Columns[16].Width = 70;
            dgv.Columns[16].HeaderText = "CstxGalón";

            dgv.Columns[17].Name = "TOTAL";
            dgv.Columns[17].DataPropertyName = "TOTAL";
            dgv.Columns[17].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgv.Columns[17].Width = 80;
            dgv.Columns[17].HeaderText = "Total";

            dgv.Columns[18].Name = "CONS_SOLICITADO";
            dgv.Columns[18].DataPropertyName = "CONS_SOLICITADO";
            dgv.Columns[18].Width = 130;
            dgv.Columns[18].HeaderText = "Solicitado Por";

            dgv.Columns[19].Name = "CONS_AUTORIZADO";
            dgv.Columns[19].DataPropertyName = "CONS_AUTORIZADO";
            dgv.Columns[19].Width = 130;
            dgv.Columns[19].HeaderText = "Autorizado Por";

            dgv.Columns[20].Name = "CONS_REALIZADO";
            dgv.Columns[20].DataPropertyName = "CONS_REALIZADO";
            dgv.Columns[20].Width = 130;
            dgv.Columns[20].HeaderText = "Realizado Por";

            dgv.Columns[21].Name = "CONS_OBSERVACION";
            dgv.Columns[21].DataPropertyName = "CONS_OBSERVACION";
            dgv.Columns[21].Visible = false;

            dgv.Columns[22].Name = "CONS_ESTADO";
            dgv.Columns[22].DataPropertyName = "CONS_ESTADO";
            dgv.Columns[22].Visible = false;

        }
        private void Mostrar(string filtro)
        {
            ENResultOperation R = ClsConsumo_LubricanteBC.Listar_por_Fechas(dtpFecIni.Value, dtpFecFin.Value);
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
                iCons_Ide = Convert.ToInt32(this.dgvListado.CurrentRow.Cells["IDE"].Value.ToString());
            }
        }
        private void dgvListado_CurrentCellChanged(object sender, EventArgs e)
        {
            Mostrar_Dgv();
        }

        private void Mantenimiento_Registros()
        {
            Cargar_Registro(iCons_Ide);
        }
        private void Cargar_Registro(int nCons_Ide)
        {
            ENResultOperation R = ClsConsumo_LubricanteBC.Buscar_Registro(nCons_Ide);
            DataTable dtg = (DataTable)R.Valor;
            if (dtg.Rows.Count != 0)
            {
                DataRow ROWG = dtg.Rows[0];
                txtCons_Ide.Text = ROWG["CONS_IDE"].ToString();
                txtComp_Ide.Text = ROWG["COMP_IDE"].ToString();
                txtComp_Descripcion.Text = ROWG["DESCRIPCION"].ToString();
                dtpFecha.Text = ROWG["CONS_FECHA"].ToString();
                txtPlaca.Text = ROWG["PLACA"].ToString();
                txtNombre.Text = ROWG["NOMBRE"].ToString();
                txtCantidad.Text = ROWG["CONS_CANTIDAD"].ToString();
                txtUnidad.Text = ROWG["CONS_UNIDAD"].ToString();
                txtCosto.Text = ROWG["CONS_IMPORTE"].ToString();
                txtTotal.Text = ROWG["TOTAL"].ToString();
                txtSolicitado.Text = ROWG["CONS_SOLICITADO"].ToString();
                txtAutorizado.Text = ROWG["CONS_AUTORIZADO"].ToString();
                txtRealizado.Text = ROWG["CONS_REALIZADO"].ToString();
                txtObservacion.Text = ROWG["CONS_OBSERVACION"].ToString();
                nTran_Vehi_Ide = Convert.ToInt32(ROWG["TRAN_VEHI_IDE"].ToString());
            }
            else
            {
                Habilitar_Botones(true);
            }

        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            PanelMantenimiento.Visible = true;
            Operacion = "N";
            Inicializa_Campos();
            Habilitar_Botones(false);
            Habilitar_Campos(true);
            txtComp_Ide.Focus();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            PanelMantenimiento.Visible = true;
            Operacion = "M";
            Mantenimiento_Registros();
            Habilitar_Botones(false);
            Habilitar_Campos(true);
            txtComp_Ide.Focus();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            PanelMantenimiento.Visible = true;
            Operacion = "E";
            btnGrabar.Text = "Eliminar";
            Mantenimiento_Registros();
            Habilitar_Botones(false);
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            Reportes.rptConsumo_Lubricante frmLubri = new Reportes.rptConsumo_Lubricante();
            frmLubri.fecha1 = dtpFecIni.Value;
            frmLubri.fecha2 = dtpFecFin.Value;
            frmLubri.RangoFecha = "Del : " + dtpFecIni.Value.ToShortDateString() + " Al : " + dtpFecFin.Value.ToShortDateString();
            NomEmpresa = VarGlobales.NombreEmpresa;
            if (string.IsNullOrEmpty(NomEmpresa)) NomEmpresa = "TERAH S.A.C";
            frmLubri.Empresa = NomEmpresa;
            frmLubri.Titulo = "REPORTE DE CONSUMO DE LUBRICANTES";
            frmLubri.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (Verifica_Campos())
            {
                PanelMantenimiento.Visible = false;
                Procesar_Operacion();
                Habilitar_Campos(false);
                Habilitar_Botones(true);
                Cargar_Registro(iCons_Ide);
                dgvListado.Focus();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            PanelMantenimiento.Visible = false;
            Habilitar_Botones(true);
            Habilitar_Campos(false);
            Cargar_Registro(iCons_Ide);
        }
        private void Inicializa_Campos()
        {
            txtCons_Ide.Text = "";
            txtComp_Ide.Text = string.Empty;
            txtComp_Descripcion.Text = string.Empty;
            DateTime FechaUso = new DateTime(2018, 1, 1);
            dtpFecCompra.Text = FechaUso.ToString();
            dtpFecha.Text = DateTime.Now.ToString();
            txtPlaca.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtCantidad.Text = string.Empty;
            txtUnidad.Text = string.Empty;
            txtCosto.Text = string.Empty;
            txtSolicitado.Text = string.Empty;
            txtAutorizado.Text = string.Empty;
            txtRealizado.Text = string.Empty;
            txtObservacion.Text = string.Empty;
        }
        private void Habilitar_Campos(Boolean Flag)
        {
            txtComp_Ide.ReadOnly = !Flag;
            txtComp_Descripcion.ReadOnly = true;
            dtpFecha.Enabled = Flag;
            txtPlaca.ReadOnly = !Flag;
            txtNombre.ReadOnly = true;
            txtCantidad.ReadOnly = !Flag;
            txtUnidad.ReadOnly = true;
            txtMoneda.ReadOnly = true;
            txtCosto.ReadOnly = true;
            txtSolicitado.ReadOnly = !Flag;
            txtAutorizado.ReadOnly = !Flag;
            txtRealizado.ReadOnly = !Flag;
            txtObservacion.ReadOnly = !Flag;
        }

        private void Habilitar_Botones(Boolean Flag)
        {
            btnNuevo.Enabled = Flag;
            btnModificar.Enabled = Flag;
            btnEliminar.Enabled = Flag;
            btnGrabar.Enabled = !Flag;
            btnCancelar.Enabled = !Flag;
            btnImprimir.Enabled = Flag;
            btnSalir.Enabled = Flag;
            this.KeyPreview = Flag;
        }

        private Boolean Verifica_Campos()
        {
            if (string.IsNullOrEmpty(txtComp_Ide.Text))
            {
                MessageBox.Show("No se Ha seleccionado el Cilindro a Descargar Lubricante", "Lubricantes");
                return false;
            }
            if (string.IsNullOrEmpty(txtPlaca.Text))
            {
                MessageBox.Show("No se Ha Ingresado Vehiculo para el Cambio de Aceite", "Lubricantes");
                return false;
            }
            if (string.IsNullOrEmpty(txtCantidad.Text))
            {
                MessageBox.Show("No se Ha seleccionado Cantidad de Lubricante ", "Lubricantes");
                return false;
            }
            if (string.IsNullOrEmpty(txtCosto.Text))
            {
                MessageBox.Show("No se Ha Ingresado Costo Total de Lubricante ", "Lubricantes");
                return false;
            }
            return true;
        }

        private void Procesar_Operacion()
        {
            ClsConsumo_LubricanteBE TipoBE = new ClsConsumo_LubricanteBE();
            if (string.IsNullOrEmpty(txtCons_Ide.Text)) txtCons_Ide.Text = "0";
            TipoBE.Cons_ide = Convert.ToInt32(txtCons_Ide.Text);
            TipoBE.Comp_ide = Convert.ToInt32(txtComp_Ide.Text);
            TipoBE.Cons_fecha = Convert.ToDateTime(dtpFecha.Text);
            TipoBE.Cons_numero = "";
            TipoBE.Tran_ide = nTran_Ide;
            TipoBE.Tran_vehi_ide = nTran_Vehi_Ide;
            TipoBE.Mant_grupo_ide = nGrupo_Ide;
            TipoBE.Mant_actividades_ide = nActividad_Ide;
            if (string.IsNullOrEmpty(txtCantidad.Text)) txtCantidad.Text = "0";
            TipoBE.Cons_cantidad = Convert.ToDecimal(txtCantidad.Text);
            TipoBE.Cons_unidad = txtUnidad.Text;
            if (string.IsNullOrEmpty(txtCosto.Text)) txtCosto.Text = "0";
            TipoBE.Cons_importe = Convert.ToDecimal(txtCosto.Text);
            TipoBE.Cons_solicitado = txtSolicitado.Text;
            TipoBE.Cons_autorizado = txtAutorizado.Text;
            TipoBE.Cons_realizado = txtRealizado.Text;
            TipoBE.Cons_observacion = txtObservacion.Text;
            TipoBE.Cons_estado = txtEstado.Text;
            switch (Operacion)
            {
                case "N":
                    {
                        ENResultOperation R = ClsConsumo_LubricanteBC.Crear(TipoBE);
                        if (!R.Proceder) MessageBox.Show("Error al Insertar Consumo de Lubricantes " + R.Sms);
                        break;
                    }
                case "M":
                    {
                        ENResultOperation R = ClsConsumo_LubricanteBC.Actualizar(TipoBE);
                        if (!R.Proceder) MessageBox.Show("Error al Modificar Consumo de Lubricantes " + R.Sms);
                        break;
                    }
                case "E":
                    {
                        ENResultOperation R = ClsConsumo_LubricanteBC.Eliminar(TipoBE);
                        if (!R.Proceder) MessageBox.Show("Error al Eliminar Consumo de Lubricantes " + R.Sms);
                        break;
                    }
            }
            Mostrar("");
        }

        private void txtComp_Ide_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3)
            {
                Mantenimiento.frmCompra_Lubricantes_Buscar frmBuscar = new frmCompra_Lubricantes_Buscar();
                frmBuscar.ShowDialog();
                iComp_Ide = frmBuscar.iComp_Ide;
                txtComp_Ide.Text = iComp_Ide.ToString();
                txtComp_Descripcion.Text = frmBuscar.sDescripcion;
                dtpFecCompra.Text = frmBuscar.FechaCompra.ToString();
            }
        }

        private Boolean Buscar_Compra()
        {
            ENResultOperation R = ClsCompra_LubricantesBC.Buscar_Comprobante(Convert.ToInt32(txtComp_Ide.Text));
            DataTable dtg = (DataTable)R.Valor;
            if (dtg.Rows.Count == 1)
            {
                DataRow ROWG = dtg.Rows[0];
                txtComp_Ide.Text = ROWG["COMP_IDE"].ToString();
                txtComp_Descripcion.Text = ROWG["COMP_DESCRIPCION"].ToString();
                dtpFecCompra.Text = ROWG["COMP_FECHA"].ToString();
                txtUnidad.Text = ROWG["UNIDAD_SALIDA"].ToString();
                txtCosto.Text = ROWG["UNIDAD_COSTO"].ToString();
                txtMoneda.Text = ROWG["COMP_MONEDA"].ToString();
                return true;
            }
            else
            {
                return false;
            }
        }

        private Boolean Buscar_Vehiculo()
        {
            ENResultOperation R = ClsTransportista_VehiculoBC.Listar_Filtro(txtPlaca.Text,nTran_Ide);
            DataTable dtg = (DataTable)R.Valor;
            if (dtg.Rows.Count == 1)
            {
                DataRow ROWG = dtg.Rows[0];
                nTran_Vehi_Ide = Convert.ToInt32(ROWG["TRAN_VEHI_IDE"].ToString());
                txtPlaca.Text = ROWG["TRAN_VEHI_PLACA"].ToString();
                txtNombre.Text = ROWG["TRAN_VEHI_NOMBRE"].ToString();
                return true;
            }
            return false;
        }
        private void txtComp_Ide_KeyPress(object sender, KeyPressEventArgs e)
        {
             if ((int)e.KeyChar == (int)Keys.Enter)
             {
                 if (Buscar_Compra()) SendKeys.Send("{TAB}");
             }
             txtComp_Ide.Focus();
        }

        private void dtpFecha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter) SendKeys.Send("{TAB}");
        }
        private void txtPlaca_Enter(object sender, EventArgs e)
        {
            lblVehiculo.Text = "[F3] Para Consulta de Vehiculos ";
        }

        private void txtPlaca_Leave(object sender, EventArgs e)
        {
            lblVehiculo.Text = "";
        }
        private void txtPlaca_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3)
            {
                Transportista.frmTransportista_Vehiculo_Buscar frmBuscarV = new Transportista.frmTransportista_Vehiculo_Buscar();
                frmBuscarV.Transportista_Ide = 2564;
                frmBuscarV.ShowDialog();
                nTran_Vehi_Ide = Convert.ToInt32(frmBuscarV.Vehiculo_Ide);
                txtPlaca.Text = frmBuscarV.Vehiculo_Placa;
                txtNombre.Text = frmBuscarV.Vehiculo_Nombre;
            }
        }
        private void txtPlaca_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                if (Buscar_Vehiculo())
                {
                    SendKeys.Send("{TAB}");
                }
                txtPlaca.Focus();
            }
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter) SendKeys.Send("{TAB}");
            ValidarNumeros(e);
        }

        private void txtCosto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter) SendKeys.Send("{TAB}");
            ValidarNumeros(e);
        }

        private void txtSolicitado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter) SendKeys.Send("{TAB}");
        }

        private void txtAutorizado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter) SendKeys.Send("{TAB}");
        }

        private void txtRealizado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter) SendKeys.Send("{TAB}");
        } 

        private void cboGrupos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter) SendKeys.Send("{TAB}");
        }

        private void cboActividades_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter) SendKeys.Send("{TAB}");
        }

        private void txtObservacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter) SendKeys.Send("{TAB}");
        }

        private void txtEstado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter) SendKeys.Send("{TAB}");
        }

        private void btnGrabar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter) SendKeys.Send("{TAB}");
        }

        private void txtComp_Ide_Enter(object sender, EventArgs e)
        {
            lblMensaje.Text = "[F3] Para Consultar Compras de Lubricantes";
        }

        private void txtComp_Ide_Leave(object sender, EventArgs e)
        {
            lblMensaje.Text = "";
        }

        private void ValidarNumeros(KeyPressEventArgs e)
        {

            if (e.KeyChar >= 48 && e.KeyChar <= 57)
            {
                e.Handled = false;
            }
            else if (e.KeyChar == 8 || e.KeyChar == 46)
            {
                e.Handled = false;
            }
            else if (e.KeyChar == 13)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void btnBuscarxFechas_Click(object sender, EventArgs e)
        {
            Mostrar("");
        }


    }
}
