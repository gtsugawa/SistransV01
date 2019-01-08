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
    public partial class frmCompra_Lubricantes : Form
    {
        private string Operacion;
        private string NomEmpresa;
        private DateTime fecha1;
        private DateTime fecha2;
        private int iComp_Ide;
        private int nProve_Ide;
        private decimal nCosto_Unitario;
        private decimal nTipo_Cambio;
        private decimal nCosto_Soles;
        public frmCompra_Lubricantes()
        {
            InitializeComponent();
        }
        private void frmCompra_Lubricantes_Load(object sender, EventArgs e)
        {
            ToolTip toolTip1 = new ToolTip();
            toolTip1.SetToolTip(this.txtProve, "(F3) Ayuda para Seleccionar Proveedor");

            FormatoDgv();
            Cargar_Moneda();
            Cargar_UnidadCompra();
            Cargar_UnidadSalida();
            Cargar_Busquedas();
            Inicializa_Fechas();
            Mostrar("");
            PanelMantenimiento.Visible = false;
        }
        private void Inicializa_Fechas()
        {
            DateTime fecha1 = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            DateTime fecha2 = fecha1.AddMonths(1).AddTicks(-1);

            dtpFecIni.Text = fecha1.ToShortDateString();
            dtpFecFin.Text = fecha2.ToShortDateString();
        }

        private void Cargar_UnidadCompra()
        {
            cboUnidadCompra.Items.Clear();
            cboUnidadCompra.Items.Add("Cilindro");
            cboUnidadCompra.Items.Add("Galones");
            cboUnidadCompra.Items.Add("Litros");
            cboUnidadCompra.SelectedIndex = 0;
        }
        private void Cargar_UnidadSalida()
        {
            cboUnidadSalida.Items.Clear();
            cboUnidadSalida.Items.Add("Cilindro");
            cboUnidadSalida.Items.Add("Galones");
            cboUnidadSalida.Items.Add("Litros");
            cboUnidadSalida.SelectedIndex = 1;
        }
        private void Cargar_Moneda()
        {
            cboMoneda.Items.Clear();
            cboMoneda.Items.Add("Soles");
            cboMoneda.Items.Add("Dolares");
            cboMoneda.Items.Add("Euros");
            cboMoneda.SelectedIndex = 1;
        }
        private void Cargar_Busquedas()
        {
            cboBuscarPor.Items.Clear();
            cboBuscarPor.Items.Add("Razon Social Proveedor");
            cboBuscarPor.SelectedIndex = 0;
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
            dgv.ColumnCount = 20;
            // Setear Cabecera de Columna 
            dgv.Columns[0].Name = "IDE";
            dgv.Columns[0].DataPropertyName = "COMP_IDE";
            dgv.Columns[0].Width = 30;
            dgv.Columns[0].HeaderText = "Id";
            dgv.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgv.Columns[1].Name = "PROV_IDE";
            dgv.Columns[1].DataPropertyName = "PROV_IDE";
            dgv.Columns[1].Visible = false;

            dgv.Columns[2].Name = "PROVEEDOR_NOMBRE";
            dgv.Columns[2].DataPropertyName = "PROVEEDOR_NOMBRE";
            dgv.Columns[2].Width = 280;
            dgv.Columns[2].HeaderText = "Proveedor";

            dgv.Columns[3].Name = "RUC";
            dgv.Columns[3].DataPropertyName = "RUC";
            dgv.Columns[3].Visible = false;

            dgv.Columns[4].Name = "FECHA";
            dgv.Columns[4].DataPropertyName = "COMP_FECHA";
            dgv.Columns[4].Width = 80;
            dgv.Columns[4].HeaderText = "Fecha";

            dgv.Columns[5].Name = "NUMERO";
            dgv.Columns[5].DataPropertyName = "COMP_NUMERO";
            dgv.Columns[5].Width = 100;
            dgv.Columns[5].HeaderText = "N° Factura";

            dgv.Columns[6].Name = "CODIGO";
            dgv.Columns[6].DataPropertyName = "COMP_CODIGO";
            dgv.Columns[6].Width = 100;
            dgv.Columns[6].HeaderText = "Codigo";
            dgv.Columns[6].Visible = false;

            dgv.Columns[7].Name = "DESCRIPCION";
            dgv.Columns[7].DataPropertyName = "COMP_DESCRIPCION";
            dgv.Columns[7].Width = 250;
            dgv.Columns[7].HeaderText = "Descripcion";

            dgv.Columns[8].Name = "MARCA";
            dgv.Columns[8].DataPropertyName = "COMP_MARCA";
            dgv.Columns[8].Width = 100;
            dgv.Columns[8].HeaderText = "Marca";
            dgv.Columns[8].Visible = false;

            dgv.Columns[9].Name = "UNIDAD";
            dgv.Columns[9].DataPropertyName = "COMP_UNIDAD";
            dgv.Columns[9].Width = 70;
            dgv.Columns[9].HeaderText = "Unidad";

            dgv.Columns[10].Name = "CANTIDAD";
            dgv.Columns[10].DataPropertyName = "COMP_CANTIDAD";
            dgv.Columns[10].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgv.Columns[10].Width = 90;
            dgv.Columns[10].HeaderText = "Cantidad";

            dgv.Columns[11].Name = "IMPORTE";
            dgv.Columns[11].DataPropertyName = "COMP_IMPORTE";
            dgv.Columns[11].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgv.Columns[11].Width = 100;
            dgv.Columns[11].HeaderText = "Importe Total";

            dgv.Columns[12].Name = "MONEDA";
            dgv.Columns[12].DataPropertyName = "COMP_MONEDA";
            dgv.Columns[12].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgv.Columns[12].Width = 80;
            dgv.Columns[12].HeaderText = "Moneda";

            dgv.Columns[13].Name = "TCAMBIO";
            dgv.Columns[13].DataPropertyName = "COMP_TCAMBIO";
            dgv.Columns[13].Visible = false;

            dgv.Columns[14].Name = "UNIDAD_SALIDA";
            dgv.Columns[14].DataPropertyName = "UNIDAD_SALIDA";
            dgv.Columns[14].Visible = false;

            dgv.Columns[15].Name = "UNIDAD_EQUIVALENCIA";
            dgv.Columns[15].DataPropertyName = "UNIDAD_EQUIVALENCIA";
            dgv.Columns[15].Visible = false;

            dgv.Columns[16].Name = "UNIDAD_COSTO";
            dgv.Columns[16].DataPropertyName = "UNIDAD_COSTO";
            dgv.Columns[16].Visible = false;

            dgv.Columns[17].Name = "CANTIDAD_SALIDA";
            dgv.Columns[17].DataPropertyName = "CANTIDAD_SALIDA";
            dgv.Columns[17].Visible = false;

            dgv.Columns[18].Name = "FECHA_INICIO_USO";
            dgv.Columns[18].DataPropertyName = "FECHA_INICIO_USO";
            dgv.Columns[18].Visible = false;

            dgv.Columns[19].Name = "ESTADO";
            dgv.Columns[19].DataPropertyName = "ESTADO";
            dgv.Columns[19].Visible = false;

        }

        private void Mostrar(string filtro)
        {
            ENResultOperation R = ClsCompra_LubricantesBC.Listar_por_Fechas(dtpFecIni.Value, dtpFecFin.Value);
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
                iComp_Ide = Convert.ToInt32(this.dgvListado.CurrentRow.Cells["IDE"].Value.ToString());
            }
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            PanelMantenimiento.Visible = true;
            Operacion = "N";
            Inicializa_Campos();
            Habilitar_Botones(false);
            Habilitar_Campos(true);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            PanelMantenimiento.Visible = true;
            Operacion = "M";
            Mantenimiento_Registros();
            Habilitar_Botones(false);
            Habilitar_Campos(true);
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
            Reportes.rptCompra_Lubricantes frmLubri = new Reportes.rptCompra_Lubricantes();
            frmLubri.fecha1 = dtpFecIni.Value;
            frmLubri.fecha2 = dtpFecFin.Value;
            frmLubri.RangoFecha = "Del : " + dtpFecIni.Value.ToShortDateString() + " Al : " + dtpFecFin.Value.ToShortDateString();
            NomEmpresa = VarGlobales.NombreEmpresa;
            if (string.IsNullOrEmpty(NomEmpresa)) NomEmpresa = "TERAH S.A.C";
            frmLubri.Empresa = NomEmpresa;
            frmLubri.Titulo = "REPORTE DE COMPRA DE LUBRICANTES";
            frmLubri.ShowDialog();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (Verifica_Campos())
            {
                PanelMantenimiento.Visible = false;
                Procesar_Operacion();
                Habilitar_Campos(false);
                Habilitar_Botones(true);
                Cargar_Registro(iComp_Ide);
                dgvListado.Focus();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            PanelMantenimiento.Visible = false;
            Habilitar_Botones(true);
            Habilitar_Campos(false);
            Cargar_Registro(iComp_Ide);
        }
        private void dgvListado_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Mantenimiento_Registros();
            }
        }
        private void dgvListado_CurrentCellChanged(object sender, EventArgs e)
        {
            Mostrar_Dgv();
        }

        private void dgvListado_DoubleClick(object sender, EventArgs e)
        {
            Mantenimiento_Registros();
        }
        private void Mantenimiento_Registros()
        {
            Cargar_Registro(iComp_Ide);
        }

        private void Cargar_Registro(int nComp_Ide)
        {
            ENResultOperation R = ClsCompra_LubricantesBC.Buscar_Comprobante(nComp_Ide);
            DataTable dtg = (DataTable)R.Valor;
            if (dtg.Rows.Count != 0)
            {
                DataRow ROWG = dtg.Rows[0];
                txtComp_Ide.Text = ROWG["COMP_IDE"].ToString();
                txtProve.Text = ROWG["PROVEEDOR_NOMBRE"].ToString();
                txtProve_Ide.Text = ROWG["PROV_IDE"].ToString();
                dtpFecha.Text = ROWG["COMP_FECHA"].ToString();
                txtNumero.Text = ROWG["COMP_NUMERO"].ToString();
                txtCodigo.Text = ROWG["COMP_CODIGO"].ToString();
                txtDescripcion.Text = ROWG["COMP_DESCRIPCION"].ToString();
                txtMarca.Text = ROWG["COMP_MARCA"].ToString();
                txtCantidad.Text = ROWG["COMP_CANTIDAD"].ToString();
                txtImporte.Text = ROWG["COMP_IMPORTE"].ToString();
                txtTCambio.Text = ROWG["COMP_TCAMBIO"].ToString();
                txtCantidad_Usada.Text = ROWG["CANTIDAD_SALIDA"].ToString();
                txtEquivalencia.Text = ROWG["UNIDAD_EQUIVALENCIA"].ToString();
                txtCostoUnidad.Text = ROWG["UNIDAD_COSTO"].ToString();
                cboMoneda.Text = ROWG["COMP_MONEDA"].ToString();
                cboUnidadCompra.Text = ROWG["COMP_UNIDAD"].ToString();
                cboUnidadSalida.Text = ROWG["UNIDAD_SALIDA"].ToString();
                Calcular_Costo();
            }
            else
            {
                Habilitar_Botones(true);
            }

        }
        private void Inicializa_Campos()
        {
            txtProve_Ide.Text = "";
            txtProve.Text = string.Empty;
            dtpFecha.Text = DateTime.Now.ToString();
            txtNumero.Text = string.Empty;
            txtCodigo.Text = string.Empty;
            txtDescripcion.Text = string.Empty;
            txtMarca.Text = string.Empty;
            txtCantidad.Text = string.Empty;
            txtImporte.Text = string.Empty;
            txtTCambio.Text = string.Empty;
            txtCantidad_Usada.Text = string.Empty;
            txtEquivalencia.Text = string.Empty;
            txtCostoUnidad.Text = string.Empty;
            cboMoneda.SelectedIndex = 1;
            cboUnidadCompra.SelectedIndex = 0;
            cboUnidadSalida.SelectedIndex = 1;
        }
        private void Habilitar_Campos(Boolean Flag)
        {
            txtProve.ReadOnly = !Flag;
            dtpFecha.Enabled = Flag;
            txtNumero.ReadOnly = !Flag;
            txtCodigo.ReadOnly = !Flag;
            txtDescripcion.ReadOnly = !Flag;
            txtMarca.ReadOnly = !Flag;
            txtCantidad.ReadOnly = !Flag;
            txtImporte.ReadOnly = !Flag;
            txtTCambio.ReadOnly = !Flag;
            txtCantidad_Usada.ReadOnly = !Flag;
            txtEquivalencia.ReadOnly = !Flag;
            txtCostoUnidad.ReadOnly = !Flag;
            cboMoneda.Enabled = Flag;
            cboUnidadCompra.Enabled = Flag;
            cboUnidadSalida.Enabled = Flag;
            txtProve.Focus();
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
            if (string.IsNullOrEmpty(txtProve_Ide.Text))
            {
                MessageBox.Show("No se Ha seleccionado un Proveedor de Lubricante", "Lubricantes");
                return false;
            }
            if (string.IsNullOrEmpty(txtNumero.Text))
            {
                MessageBox.Show("No se Ha Ingresado Numero de Factura", "Lubricantes");
                return false;
            }
            if (string.IsNullOrEmpty(txtNumero.Text))
            {
                MessageBox.Show("No se Ha Ingresado Descripcion del Producto ", "Lubricantes");
                return false;
            }
            if (string.IsNullOrEmpty(txtCantidad.Text))
            {
                MessageBox.Show("No se Ha seleccionado Cantidad de Lubricante ", "Lubricantes");
                return false;
            }
            if (string.IsNullOrEmpty(txtImporte.Text))
            {
                MessageBox.Show("No se Ha Ingresado Monto Total de Lubricante ", "Lubricantes");
                return false;
            }
            if (string.IsNullOrEmpty(txtEquivalencia.Text))
            {
                MessageBox.Show("No se Ha Ingresado Equivalencia Entre Unidades de Compra y Salida", "Lubricantes");
                return false;
            }
            if (cboMoneda.Text == "Dolares" && string.IsNullOrEmpty(txtTCambio.Text))
            {
                MessageBox.Show("No se Ha Ingresado Tipo de Cambio para Valorizar en Soles", "Lubricantes");
                return false;
            }
            return true;
        }

        private void Procesar_Operacion()
        {
            ClsCompra_LubricantesBE TipoBE = new ClsCompra_LubricantesBE();
            TipoBE.Comp_ide = iComp_Ide;
            TipoBE.Comp_fecha = Convert.ToDateTime(dtpFecha.Text);
            TipoBE.Prov_ide = Convert.ToInt32(txtProve_Ide.Text);
            TipoBE.Comp_numero = txtNumero.Text;
            TipoBE.Comp_codigo = txtCodigo.Text;
            TipoBE.Comp_descripcion = txtDescripcion.Text;
            TipoBE.Comp_marca = txtMarca.Text;
            TipoBE.Comp_cantidad = Convert.ToInt32(txtCantidad.Text);
            TipoBE.Comp_importe = Convert.ToDecimal(txtImporte.Text);
            TipoBE.Comp_moneda = cboMoneda.Text;
            TipoBE.Comp_tcambio = Convert.ToDecimal(txtTCambio.Text);
            TipoBE.Comp_unidad = cboUnidadCompra.Text;
            if (string.IsNullOrEmpty(txtCantidad_Usada.Text)) txtCantidad_Usada.Text = "0";
            TipoBE.Cantidad_salida = Convert.ToDecimal(txtCantidad_Usada.Text);
            TipoBE.Unidad_salida = cboUnidadSalida.Text;
            TipoBE.Unidad_equivalencia = Convert.ToInt32(txtEquivalencia.Text);
            TipoBE.Unidad_costo = Convert.ToDecimal(txtCostoUnidad.Text);
            DateTime FechaUso = new DateTime(2000,1,1);
            TipoBE.Fecha_inicio_uso = FechaUso;
            TipoBE.Estado = 0;

            switch (Operacion)
            {
                case "N":
                    {
                        ENResultOperation R = ClsCompra_LubricantesBC.Crear(TipoBE);
                        if (!R.Proceder) MessageBox.Show("Error al Insertar Compra de Lubricantes " + R.Sms);
                        break;
                    }
                case "M":
                    {
                        ENResultOperation R = ClsCompra_LubricantesBC.Actualizar(TipoBE);
                        if (!R.Proceder) MessageBox.Show("Error al Modificar Compra de Lubricantes " + R.Sms);
                        break;
                    }
                case "E":
                    {
                        ENResultOperation R = ClsCompra_LubricantesBC.Eliminar(TipoBE);
                        if (!R.Proceder) MessageBox.Show("Error al Eliminar Compra de Lubricantes " + R.Sms);
                        break;
                    }
            }
            Mostrar("");
        }

        private void txtProve_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3)
            {
                Buscar_Proveedor();
            }

        }

        private void txtProve_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                if (txtProve_Validar())
                {
                    SendKeys.Send("{TAB}");
                }
            }
            if ((int)e.KeyChar == (int)Keys.Escape)
            {
                btnCancelar.PerformClick();
            }

        }
        private void Buscar_Proveedor()
        {
            ENResultOperation R = ClsProveedorBC.Listar(txtProve.Text);
            if (R.Proceder)
            {
                DataTable dt = (DataTable)R.Valor;
                if (dt.Rows.Count == 1)
                {
                    DataRow ROW = dt.Rows[0];
                    txtProve.Text = ROW["PROV_RAZON_SOCIAL"].ToString();
                    nProve_Ide = Convert.ToInt32(ROW["PROV_IDE"]);
                    txtProve_Ide.Text = nProve_Ide.ToString();
                }
                else
                {
                    Proveedores.frmProveedorBuscar frmBuscarProv = new Proveedores.frmProveedorBuscar();
                    frmBuscarProv.ProveedorRazon = txtProve.Text;
                    frmBuscarProv.ShowDialog();
                    txtProve.Text = "";
                    txtProve.Text = frmBuscarProv.ProveedorRazon;
                    nProve_Ide = Convert.ToInt32(frmBuscarProv.ProveedorID);
                    txtProve_Ide.Text = nProve_Ide.ToString();
                }

            }
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ENResultOperation R = ClsCompra_LubricantesBC.Listar_Filtro("RAZON_SOCIAL",txtBuscar.Text,dtpFecIni.Value, dtpFecFin.Value);
            if (R.Proceder)
            {
                dgvListado.DataSource = (DataTable)R.Valor;
            }
            else
            {
                MessageBox.Show("Error al Obtener Valores : " + R.Sms);
            }
        }
        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter) btnBuscar.PerformClick();
        }


        private Boolean txtProve_Validar()
        {
            ENResultOperation R = ClsProveedorBC.Listar(txtProve.Text);
            if (R.Proceder)
            {
                DataTable dt = (DataTable)R.Valor;
                if (dt.Rows.Count == 1)
                {
                    DataRow ROW = dt.Rows[0];
                    txtProve.Text = ROW["PROV_RAZON_SOCIAL"].ToString();
                    nProve_Ide = Convert.ToInt32(ROW["PROV_IDE"]);
                    txtProve_Ide.Text = nProve_Ide.ToString();
                    return true;
                }
                else
                {
                    MessageBox.Show("Proveedor de Lubricantes No Registrado", "Mensaje de Busqueda");
                    txtProve.Focus();
                    return false;
                }
            }
            return false;
        }

        private void dtpFecha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter) SendKeys.Send("{TAB}");
        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter) SendKeys.Send("{TAB}");
        }
        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter) SendKeys.Send("{TAB}");
        }

        private void txtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter) SendKeys.Send("{TAB}");
        }

        private void txtMarca_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter) SendKeys.Send("{TAB}");
        }


        private void cboMoneda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter) SendKeys.Send("{TAB}");
        }

        private void txtTCambio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter) SendKeys.Send("{TAB}");
            ValidarNumeros(e);
        }

        private void cboUnidadCompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter) SendKeys.Send("{TAB}");
        }
        private void cboUnidadCompra_Validated(object sender, EventArgs e)
        {
            if ((cboUnidadCompra.Text == "Cilindro") && (cboUnidadSalida.Text == "Galones"))
            {
                txtEquivalencia.Text = "55";
            }
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter) SendKeys.Send("{TAB}");
            ValidarNumeros(e);
        }

        private void txtImporte_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter) SendKeys.Send("{TAB}");
            ValidarNumeros(e);
        }

        private void cboUnidadSalida_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter) SendKeys.Send("{TAB}");
        }

        private void txtEquivalencia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter) SendKeys.Send("{TAB}");
            ValidarNumeros(e);
        }

        private void txtCostoUnidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter) SendKeys.Send("{TAB}");
        }

        private void txtImporte_Validated(object sender, EventArgs e)
        {
            Calcular_Costo();
        }

        private void Calcular_Costo()
        {
            if (!string.IsNullOrEmpty(txtCantidad.Text) && !string.IsNullOrEmpty(txtImporte.Text))
            {
                nCosto_Unitario = (Convert.ToDecimal(txtImporte.Text) / Convert.ToInt32(txtCantidad.Text));
                txtCostoUnidad.Text = (nCosto_Unitario / Convert.ToInt32(txtEquivalencia.Text)).ToString("####,###.00");
                bool parsed = decimal.TryParse(txtTCambio.Text, out nTipo_Cambio);
                if (parsed)
                {
                    nCosto_Soles = Convert.ToDecimal(txtCostoUnidad.Text) * nTipo_Cambio;
                    txtCostoSoles.Text = nCosto_Soles.ToString("####,###.00");
                }
            }
        }
        private void txtEquivalencia_Validated(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtEquivalencia.Text))
            {
                if (!string.IsNullOrEmpty(txtCantidad.Text) && !string.IsNullOrEmpty(txtImporte.Text))
                {
                    nCosto_Unitario = (Convert.ToDecimal(txtImporte.Text) / Convert.ToInt32(txtCantidad.Text));
                    txtCostoUnidad.Text = (nCosto_Unitario / Convert.ToInt32(txtEquivalencia.Text)).ToString("####,###.00");
                }
            }
        }

        private void ValidarNumeros(KeyPressEventArgs e)
        {

            if (e.KeyChar >= 48 && e.KeyChar <= 57)
            {
                e.Handled = false;
            }
            else if (e.KeyChar == 8 || e.KeyChar == 46 )
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

    }
}
