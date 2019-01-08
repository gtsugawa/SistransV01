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
    public partial class frmCompra_Productos : Form
    {
        private string Operacion;
        private string Operacion_Detalle;
        private string sCondicion;
        private DateTime fecha1;
        private DateTime fecha2;
        private int dComp_Ide;
        private int iComp_Ide;
        private int iComp_Detalle_Ide;
        private int nProve_Ide;
        private decimal nCantidad;
        private decimal nUnitario;
        private decimal nTotal;
        private decimal nValBruto;
        private decimal nValNeto;
        private decimal nValIgv;
        private decimal nValTot;
        public frmCompra_Productos()
        {
            InitializeComponent();
        }

        private void frmCompra_Productos_Load(object sender, EventArgs e)
        {
            ToolTip toolTip1 = new ToolTip();
            toolTip1.SetToolTip(this.txtProveedor, "(F3) Ayuda para Seleccionar Proveedor");

            FormatoDgv();
            Inicializa_Fechas();
            Cargar_IncluyeIgv();
            Cargar_TipoDocumento();
            Cargar_TipoMoneda();
            Cargar_UnidadCompra();
            Cargar_TipoProducto();
            Cargar_BuscarPor();
            Mostrar("");
            PanelMantenimiento.Visible = false;
            PanelDetalle.Visible = false;
            Habilitar_Botones_Generales(true);
            Habilitar_Botones_Cabecera(false);
            Habilitar_Botones_Detalle(false);
            Habilitar_Botones_Detalle_Linea(false);
            Habilitar_Campos_Cabecera(false);
            FormatoDgv_Documento();
            btnNuevo.Focus();
        }

        #region Cabecera
        private void Inicializa_Fechas()
        {
            fecha1 = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            fecha2 = fecha1.AddMonths(1).AddTicks(-1);
            dtpFecIni.Text = fecha1.ToShortDateString();
            dtpFecFin.Text = fecha2.ToShortDateString();
        }
        private void Cargar_BuscarPor()
        {
            cboBuscarPor.Items.Clear();
            cboBuscarPor.Items.Add("Proveedor");
            cboBuscarPor.Items.Add("Nro.Documento");
            cboBuscarPor.SelectedIndex = 0;
        }
        private void Cargar_TipoDocumento()
        {
            ENResultOperation R =  ClsTipo_DocumentoBC.Listar("");
            if (R.Proceder) cboTipoDocumento.DataSource = (DataTable)R.Valor;
            cboTipoDocumento.DisplayMember = "TIPO_DOC_NOMBRE";
            cboTipoDocumento.ValueMember = "TIPO_DOC_IDE";
            cboTipoDocumento.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private void Cargar_TipoProducto()
        {
            cboTipoProducto.Items.Clear();
            cboTipoProducto.Items.Add("Filtros de Aceite       ");
            cboTipoProducto.Items.Add("Filtros de Gasolina     ");
            cboTipoProducto.Items.Add("Filtros de Aire         ");
            cboTipoProducto.Items.Add("Baterias                ");
            cboTipoProducto.Items.Add("Implementos de Seguridad");
            cboTipoProducto.Items.Add("Vestimenta              ");
            cboTipoProducto.Items.Add("Productos Electricos    ");
            cboTipoProducto.SelectedIndex = 0;
        }
        private void Cargar_TipoMoneda()
        {
            cboTipoMoneda.Items.Clear();
            cboTipoMoneda.Items.Add("Soles");
            cboTipoMoneda.Items.Add("Dolares");
            cboTipoMoneda.Items.Add("Euros");
            cboTipoMoneda.SelectedIndex = 0;
        }
        private void Cargar_IncluyeIgv()
        {
            cboIncluye_Igv.Items.Clear();
            cboIncluye_Igv.Items.Add("Si");
            cboIncluye_Igv.Items.Add("No");
            cboIncluye_Igv.SelectedIndex = 0;
        }
        private void Cargar_UnidadCompra()
        {
            cboDetUnidad_Compra.Items.Clear();
            cboDetUnidad_Compra.Items.Add("Unidad");
            cboDetUnidad_Compra.Items.Add("Caja");
            cboDetUnidad_Compra.Items.Add("Kilos");
            cboDetUnidad_Compra.Items.Add("Galones");
            cboDetUnidad_Compra.Items.Add("Litros");
            cboDetUnidad_Compra.Items.Add("Docena");
            cboDetUnidad_Compra.SelectedIndex = 0;
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
            DataGridViewCellStyle style = this.dgvDocumento.ColumnHeadersDefaultCellStyle;
            style.BackColor = Color.Honeydew;
            style.ForeColor = Color.Gray;
            //dgv.Columns.Clear();
            dgv.ColumnCount = 27;
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
            dgv.Columns[2].Width = 200;
            dgv.Columns[2].HeaderText = "Proveedor";

            dgv.Columns[3].Name = "RUC";
            dgv.Columns[3].DataPropertyName = "RUC";
            dgv.Columns[3].Visible = false;

            dgv.Columns[4].Name = "TIPO_DOC_IDE";
            dgv.Columns[4].DataPropertyName = "TIPO_DOC_IDE";
            dgv.Columns[4].Visible = false;

            dgv.Columns[5].Name = "TIPO_DOC";
            dgv.Columns[5].DataPropertyName = "TIPO_DOC";
            dgv.Columns[5].Width = 80;
            dgv.Columns[5].HeaderText = "Tipo Doc";

            dgv.Columns[6].Name = "COMP_SERIE";
            dgv.Columns[6].DataPropertyName = "COMP_SERIE";
            dgv.Columns[6].Width = 40;
            dgv.Columns[6].HeaderText = "Serie";

            dgv.Columns[7].Name = "COMP_NUMERO";
            dgv.Columns[7].DataPropertyName = "COMP_NUMERO";
            dgv.Columns[7].Width = 80;
            dgv.Columns[7].HeaderText = "Numero";

            dgv.Columns[8].Name = "COMP_FECHA_EMISION";
            dgv.Columns[8].DataPropertyName = "COMP_FECHA_EMISION";
            dgv.Columns[8].Width = 80;
            dgv.Columns[8].HeaderText = "Fecha Emision";
            dgv.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgv.Columns[9].Name = "COMP_FECHA_VENCIMIENTO";
            dgv.Columns[9].DataPropertyName = "COMP_FECHA_VENCIMIENTO";
            dgv.Columns[9].Width = 70;
            dgv.Columns[9].HeaderText = "Vencimiento";
            dgv.Columns[9].Visible = false;

            dgv.Columns[10].Name = "COMP_FORMA_PAGO";
            dgv.Columns[10].DataPropertyName = "COMP_FORMA_PAGO";
            dgv.Columns[10].Width = 90;
            dgv.Columns[10].HeaderText = "Forma Pago";
            dgv.Columns[10].Visible = false;

            dgv.Columns[11].Name = "COMP_MONEDA";
            dgv.Columns[11].DataPropertyName = "COMP_MONEDA";
            dgv.Columns[11].Width = 80;
            dgv.Columns[11].HeaderText = "Moneda";
            dgv.Columns[11].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgv.Columns[12].Name = "COMP_TCAMBIO";
            dgv.Columns[12].DataPropertyName = "COMP_TCAMBIO";
            dgv.Columns[12].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgv.Columns[12].Width = 80;
            dgv.Columns[12].HeaderText = "T.Cambio";
            dgv.Columns[12].Visible = false;

            dgv.Columns[13].Name = "COMP_TIPO_COMPRA";
            dgv.Columns[13].DataPropertyName = "COMP_TIPO_COMPRA";
            dgv.Columns[13].Width = 120;
            dgv.Columns[13].HeaderText = "Tipo de Compra";
            dgv.Columns[13].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            dgv.Columns[14].Name = "COMP_IGV_INCLUIDO";
            dgv.Columns[14].DataPropertyName = "COMP_IGV_INCLUIDO";
            dgv.Columns[14].Visible = false;

            dgv.Columns[15].Name = "COMP_IGV_PORCENTAJE";
            dgv.Columns[15].DataPropertyName = "COMP_IGV_PORCENTAJE";
            dgv.Columns[15].Visible = false;

            dgv.Columns[16].Name = "COMP_DESCUENTO_PORCENTAJE";
            dgv.Columns[16].DataPropertyName = "COMP_DESCUENTO_PORCENTAJE";
            dgv.Columns[16].Visible = false;

            dgv.Columns[17].Name = "COMP_VALOR_BRUTO";
            dgv.Columns[17].DataPropertyName = "COMP_VALOR_BRUTO";
            dgv.Columns[17].Visible = false;

            dgv.Columns[18].Name = "COMP_DESCUENTO";
            dgv.Columns[18].DataPropertyName = "COMP_DESCUENTO";
            dgv.Columns[18].Visible = false;

            dgv.Columns[19].Name = "COMP_VALOR_NETO";
            dgv.Columns[19].DataPropertyName = "COMP_VALOR_NETO";
            dgv.Columns[19].Visible = false;

            dgv.Columns[20].Name = "COMP_IGV";
            dgv.Columns[20].DataPropertyName = "COMP_IGV";
            dgv.Columns[20].Visible = false;

            dgv.Columns[21].Name = "COMP_VALOR_TOTAL";
            dgv.Columns[21].DataPropertyName = "COMP_VALOR_TOTAL";
            dgv.Columns[21].Width = 90;
            dgv.Columns[21].HeaderText = "Total";
            dgv.Columns[21].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgv.Columns[22].Name = "USUARIO_CREA";
            dgv.Columns[22].DataPropertyName = "USUARIO_CREA";
            dgv.Columns[22].Visible = false;

            dgv.Columns[23].Name = "FECHA_CREA";
            dgv.Columns[23].DataPropertyName = "FECHA_CREA";
            dgv.Columns[23].Visible = false;

            dgv.Columns[24].Name = "USUARIO_MODIICA";
            dgv.Columns[24].DataPropertyName = "USUARIO_MODIFICA";
            dgv.Columns[24].Visible = false;

            dgv.Columns[25].Name = "FECHA_MODIFICA";
            dgv.Columns[25].DataPropertyName = "FECHA_MODIFICA";
            dgv.Columns[25].Visible = false;

            dgv.Columns[26].Name = "ESTADO";
            dgv.Columns[26].DataPropertyName = "ESTADO";
            dgv.Columns[26].Visible = false;

        }

        private void Mostrar(string filtro)
        {
            ENResultOperation R = ClsCompra_ProductosBC.Listar_por_Fechas(dtpFecIni.Value, dtpFecFin.Value);
            if (R.Proceder)
            {
                dgvListado.DataSource = (DataTable)R.Valor;
            }
            else
            {
                MessageBox.Show("Error al Obtener Valores : " + R.Sms);
            }
            btnNuevo.Focus();
        }

        private void Mostrar_Dgv()
        {

            if (this.dgvListado.CurrentRow != null)
            {
                iComp_Ide = Convert.ToInt32(this.dgvListado.CurrentRow.Cells["IDE"].Value.ToString());
            }
        }
        private void dgvListado_CurrentCellChanged(object sender, EventArgs e)
        {
            Mostrar_Dgv();
        }


        private void Inicializa_Campos_Cabecera()
        {
            txtComp_Ide.Text = string.Empty;
            txtProve_Ide.Text = string.Empty;
            txtProveedor.Text = string.Empty;
            txtSerie.Text = string.Empty;
            txtNumero.Text = string.Empty;
            txtTipo_Cambio.Text = string.Empty;
            txtForma_Pago.Text = string.Empty;
            txtPorcentaje_Igv.Text = Convert.ToString(VarGlobales.PorcentajeIgv);
            txtValor_Bruto.Text = string.Empty;
            txtDscto_Porcentaje.Text = string.Empty;
            txtDescuento.Text =   string.Empty;
            txtValor_Bruto.Text =  string.Empty;
            txtIgv.Text = string.Empty;
            txtValNeto.Text = string.Empty;
            txtTotalDoc.Text = string.Empty;
            dtpFecha_Emision.Text = DateTime.Now.ToShortDateString();
            dtpFecha_Vencimiento.Text = dtpFecha_Emision.Text;
            cboTipoProducto.SelectedIndex = 0;
            cboTipoDocumento.SelectedIndex = 0;
            cboTipoMoneda.SelectedIndex = 0;
            cboIncluye_Igv.SelectedIndex = 0;
            Mostrar_Detalle(0);
        }
        private void Habilitar_Campos_Cabecera(Boolean Flag)
        {
            txtComp_Ide.ReadOnly = !Flag;
            txtProve_Ide.ReadOnly = !Flag;
            txtProveedor.ReadOnly = !Flag;
            txtSerie.ReadOnly = !Flag;
            txtNumero.ReadOnly = !Flag;
            txtTipo_Cambio.ReadOnly = !Flag;
            txtForma_Pago.ReadOnly = !Flag;
            txtPorcentaje_Igv.ReadOnly = !Flag;
            txtValor_Bruto.ReadOnly = !Flag;
            txtDscto_Porcentaje.ReadOnly = !Flag;
            txtDescuento.ReadOnly = !Flag;
            txtValor_Bruto.ReadOnly = !Flag;
            txtIgv.ReadOnly = !Flag;
            txtValNeto.ReadOnly = !Flag;
            txtTotalDoc.ReadOnly = !Flag;
            dtpFecha_Emision.Enabled = Flag;
            dtpFecha_Vencimiento.Enabled = Flag;
            cboTipoProducto.Enabled = Flag;
            cboTipoDocumento.Enabled = Flag;
            cboTipoMoneda.Enabled = Flag;
            cboIncluye_Igv.Enabled = Flag;
            dgvDocumento.Enabled = !Flag;
        }
        private void Habilitar_Botones_Generales(Boolean Flag)
        {
            btnNuevo.Enabled = Flag;
            btnModificar.Enabled = Flag;
            btnEliminar.Enabled = Flag;
            btnImprimir.Enabled = Flag;
            btnSalir.Enabled = Flag;
        }

        private void Habilitar_Botones_Cabecera(Boolean Flag)
        {
            btnContinuar.Enabled = Flag;
            btnGrabar.Enabled = Flag;
            btnCancelar.Enabled = Flag;
            btnGrabar.Text = "Grabar";
        }


        private void Buscar_Proveedor()
        {
            ENResultOperation R = ClsProveedorBC.Listar(txtProveedor.Text);
            if (R.Proceder)
            {
                DataTable dt = (DataTable)R.Valor;
                if (dt.Rows.Count == 1)
                {
                    DataRow ROW = dt.Rows[0];
                    txtProveedor.Text = ROW["PROV_RAZON_SOCIAL"].ToString();
                    nProve_Ide = Convert.ToInt32(ROW["PROV_IDE"]);
                    txtProve_Ide.Text = nProve_Ide.ToString();
                }
                else
                {
                    Proveedores.frmProveedorBuscar frmBuscarProv = new Proveedores.frmProveedorBuscar();
                    frmBuscarProv.ProveedorRazon = txtProveedor.Text;
                    frmBuscarProv.ShowDialog();
                    txtProveedor.Text = "";
                    txtProveedor.Text = frmBuscarProv.ProveedorRazon;
                    nProve_Ide = Convert.ToInt32(frmBuscarProv.ProveedorID);
                    txtProve_Ide.Text = nProve_Ide.ToString();
                }
            }
        }
        private Boolean txtProve_Validar()
        {
            ENResultOperation R = ClsProveedorBC.Listar(txtProveedor.Text);
            if (R.Proceder)
            {
                DataTable dt = (DataTable)R.Valor;
                if (dt.Rows.Count == 1)
                {
                    DataRow ROW = dt.Rows[0];
                    txtProveedor.Text = ROW["PROV_RAZON_SOCIAL"].ToString();
                    nProve_Ide = Convert.ToInt32(ROW["PROV_IDE"]);
                    txtProve_Ide.Text = nProve_Ide.ToString();
                    return true;
                }
                else
                {
                    MessageBox.Show("Proveedor No Registrado", "Mensaje de Busqueda");
                    txtProveedor.Focus();
                    return false;
                }
            }
            return false;
        }

        private void txtProveedor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3)
            {
                Buscar_Proveedor();
            }
        }

        private void Cargar_Registro(int nComp_Ide)
        {
            ENResultOperation R = ClsCompra_ProductosBC.Buscar_Comprobante(nComp_Ide);
            DataTable dtg = (DataTable)R.Valor;
            if (dtg.Rows.Count != 0)
            {
                DataRow ROWG = dtg.Rows[0];
                txtComp_Ide.Text = ROWG["COMP_IDE"].ToString();
                txtProve_Ide.Text = ROWG["PROV_IDE"].ToString();
                txtProveedor.Text = ROWG["PROVEEDOR_NOMBRE"].ToString();
                txtSerie.Text = ROWG["COMP_SERIE"].ToString();
                txtNumero.Text = ROWG["COMP_NUMERO"].ToString();
                txtTipo_Cambio.Text = ROWG["COMP_TCAMBIO"].ToString();
                txtForma_Pago.Text = ROWG["COMP_FORMA_PAGO"].ToString();
                txtPorcentaje_Igv.Text = ROWG["COMP_IGV_PORCENTAJE"].ToString();
                txtValor_Bruto.Text = ROWG["COMP_VALOR_BRUTO"].ToString();
                txtDscto_Porcentaje.Text = ROWG["COMP_DESCUENTO_PORCENTAJE"].ToString();
                txtDescuento.Text = ROWG["COMP_DESCUENTO"].ToString();
                txtValor_Bruto.Text = ROWG["COMP_VALOR_BRUTO"].ToString();
                txtIgv.Text = ROWG["COMP_IGV"].ToString();
                txtValNeto.Text = ROWG["COMP_VALOR_NETO"].ToString();
                txtTotalDoc.Text = ROWG["COMP_VALOR_TOTAL"].ToString();
                dtpFecha_Emision.Text = ROWG["COMP_FECHA_EMISION"].ToString();
                dtpFecha_Vencimiento.Text = ROWG["COMP_FECHA_VENCIMIENTO"].ToString();
                cboTipoProducto.Text = ROWG["COMP_TIPO_COMPRA"].ToString();
                cboTipoDocumento.SelectedValue = ROWG["TIPO_DOC_IDE"].ToString();
                cboTipoMoneda.Text = ROWG["COMP_MONEDA"].ToString();
                cboIncluye_Igv.Text = ROWG["COMP_IGV_INCLUIDO"].ToString();
            }
            else
            {
                Habilitar_Botones_Cabecera(true);
            }

        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Operacion = "N";
            PanelMantenimiento.Visible = true;
            Habilitar_Botones_Generales(false);
            Habilitar_Botones_Cabecera(true);
            Habilitar_Botones_Detalle(false);
            Habilitar_Botones_Detalle_Linea(false);
            Habilitar_Campos_Cabecera(true);
            Inicializa_Campos_Cabecera();
            btnContinuar.Enabled = false;
            txtProveedor.Focus();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvListado.CurrentCell != null)
            {
                Operacion = "M";
                PanelMantenimiento.Visible = true;
                Habilitar_Botones_Generales(false);
                Habilitar_Botones_Cabecera(true);
                Habilitar_Botones_Detalle(false);
                Habilitar_Botones_Detalle_Linea(false);
                Habilitar_Campos_Cabecera(true);
                Cargar_Registro(iComp_Ide);
                Mostrar_Detalle(iComp_Ide);
                btnContinuar.Focus();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvListado.CurrentCell != null)
            {
                Operacion = "E";
                PanelMantenimiento.Visible = true;
                Habilitar_Botones_Generales(false);
                Habilitar_Botones_Cabecera(true);
                Habilitar_Botones_Detalle(false);
                Habilitar_Botones_Detalle_Linea(false);
                dgvDocumento.Enabled = false;
                Cargar_Registro(iComp_Ide);
                Mostrar_Detalle(iComp_Ide);
                btnContinuar.Enabled = false;
                btnGrabar.Text = "Eliminar";
                btnDetGrabar.Focus();
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            Reportes.rptCompra_Productos frmproductos = new Reportes.rptCompra_Productos();
            frmproductos.Empresa = "TERAH S.A.C"; //VarGlobales.NombreEmpresa;
            frmproductos.Titulo = "REPORTE DE COMPRAS DE PRODUCTOS";
            frmproductos.fecha1 = dtpFecIni.Value;
            frmproductos.fecha2 = dtpFecFin.Value;
            frmproductos.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            PanelMantenimiento.Visible = false;
            Habilitar_Botones_Generales(true);
            Habilitar_Botones_Cabecera(false);
            Habilitar_Botones_Detalle(false);
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (Verifica_Campos())
            {
                if (Procesar_Operacion())
                {
                    Habilitar_Botones_Cabecera(false);
                    Habilitar_Campos_Detalle(true);
                    Habilitar_Campos_Cabecera(false);
                    Habilitar_Botones_Detalle(true);
                }
                if (Operacion == "E")
                {
                    PanelMantenimiento.Visible = false;
                    Habilitar_Botones_Cabecera(false);
                    Habilitar_Botones_Generales(true);
                }
                Mostrar("");
            }
        }
        private void btnContinuar_Click(object sender, EventArgs e)
        {
            dComp_Ide = iComp_Ide;
            Habilitar_Botones_Cabecera(false);
            Habilitar_Campos_Detalle(true);
            Habilitar_Campos_Cabecera(false);
            Habilitar_Botones_Detalle(true);
        }

        private Boolean Verifica_Campos()
        {
            if (string.IsNullOrEmpty(txtProve_Ide.Text))
            {
                MessageBox.Show("No se Ha seleccionado un Proveedor", "Lubricantes");
                return false;
            }
            return true;
        }
        private Boolean Procesar_Operacion()
        {
            ClsCompra_ProductosBE TipoBE = new ClsCompra_ProductosBE();
            dComp_Ide = iComp_Ide;
            TipoBE.Comp_ide = iComp_Ide;
            TipoBE.Prov_ide = Convert.ToInt32(txtProve_Ide.Text);
            TipoBE.Tipo_doc_ide = Convert.ToInt32(cboTipoDocumento.SelectedValue);
            TipoBE.Comp_serie = txtSerie.Text;
            TipoBE.Comp_numero = txtNumero.Text;
            TipoBE.Comp_fecha_emision = Convert.ToDateTime(dtpFecha_Emision.Text);
            TipoBE.Comp_fecha_vencimiento = Convert.ToDateTime(dtpFecha_Vencimiento.Text);
            TipoBE.Comp_forma_pago = txtForma_Pago.Text;
            TipoBE.Comp_moneda = cboTipoMoneda.Text;
            if (string.IsNullOrEmpty(txtTipo_Cambio.Text)) txtTipo_Cambio.Text = "0";
            TipoBE.Comp_tcambio = Convert.ToDecimal(txtTipo_Cambio.Text);
            TipoBE.Comp_tipo_compra = cboTipoProducto.Text;
            TipoBE.Comp_igv_incluido = cboIncluye_Igv.Text;
            if (string.IsNullOrEmpty(txtPorcentaje_Igv.Text)) txtPorcentaje_Igv.Text = "0";
            TipoBE.Comp_igv_porcentaje = Convert.ToDecimal(txtPorcentaje_Igv.Text);
            if (string.IsNullOrEmpty(txtDscto_Porcentaje.Text)) txtDscto_Porcentaje.Text = "0";
            TipoBE.Comp_descuento_porcentaje = Convert.ToDecimal(txtDscto_Porcentaje.Text);
            if (string.IsNullOrEmpty(txtValor_Bruto.Text)) txtValor_Bruto.Text = "0";
            TipoBE.Comp_valor_bruto = Convert.ToDecimal(txtValor_Bruto.Text);
            if (string.IsNullOrEmpty(txtDescuento.Text)) txtDescuento.Text = "0";
            TipoBE.Comp_descuento = Convert.ToDecimal(txtDescuento.Text);
            if (string.IsNullOrEmpty(txtValNeto.Text)) txtValNeto.Text = "0";
            TipoBE.Comp_valor_neto = Convert.ToDecimal(txtValNeto.Text);
            if (string.IsNullOrEmpty(txtIgv.Text)) txtIgv.Text = "0";
            TipoBE.Comp_igv = Convert.ToDecimal(txtIgv.Text);
            if (string.IsNullOrEmpty(txtTotalDoc.Text)) txtTotalDoc.Text = "0";
            TipoBE.Comp_valor_total = Convert.ToDecimal(txtTotalDoc.Text);
            TipoBE.Usuario_crea = VarGlobales.CodigoUsuario;
            DateTime FechaUso = new DateTime(2000, 1, 1);
            TipoBE.Fecha_crea = DateTime.Now;
            TipoBE.Usuario_modifica = VarGlobales.CodigoUsuario;
            TipoBE.Fecha_modifica = FechaUso;
            TipoBE.Estado = "";

            switch (Operacion)
            {
                case "N":
                    {
                        ENResultOperation R = ClsCompra_ProductosBC.Crear(TipoBE);
                        if (!R.Proceder) MessageBox.Show("Error al Insertar Compra de Productos " + R.Sms);
                        dComp_Ide = R.Ide;
                        txtComp_Ide.Text = dComp_Ide.ToString();
                        return true;
                    }
                case "M":
                    {
                        ENResultOperation R = ClsCompra_ProductosBC.Actualizar(TipoBE);
                        if (!R.Proceder) MessageBox.Show("Error al Modificar Compra de Productos " + R.Sms);
                        return true;
                    }
                case "E":
                    {
                        ENResultOperation R = ClsCompra_ProductosBC.Eliminar(TipoBE);
                        if (!R.Proceder) MessageBox.Show("Error al Eliminar Compra de Productos " + R.Sms);
                        return true;
                    }
            }
            return false;
        }

        private void Actualiza_Valores_Cabecera()
        {
            ClsCompra_ProductosBE TipoBE = new ClsCompra_ProductosBE();
            TipoBE.Comp_ide = dComp_Ide;
            if (string.IsNullOrEmpty(txtPorcentaje_Igv.Text)) txtPorcentaje_Igv.Text = "0";
            TipoBE.Comp_igv_porcentaje = Convert.ToDecimal(txtPorcentaje_Igv.Text);
            if (string.IsNullOrEmpty(txtDscto_Porcentaje.Text)) txtDscto_Porcentaje.Text = "0";
            TipoBE.Comp_descuento_porcentaje = Convert.ToDecimal(txtDscto_Porcentaje.Text);
            if (string.IsNullOrEmpty(txtValor_Bruto.Text)) txtValor_Bruto.Text = "0";
            TipoBE.Comp_valor_bruto = Convert.ToDecimal(txtValor_Bruto.Text);
            if (string.IsNullOrEmpty(txtDescuento.Text)) txtDescuento.Text = "0";
            TipoBE.Comp_descuento = Convert.ToDecimal(txtDescuento.Text);
            if (string.IsNullOrEmpty(txtValNeto.Text)) txtValNeto.Text = "0";
            TipoBE.Comp_valor_neto = Convert.ToDecimal(txtValNeto.Text);
            if (string.IsNullOrEmpty(txtIgv.Text)) txtIgv.Text = "0";
            TipoBE.Comp_igv = Convert.ToDecimal(txtIgv.Text);
            if (string.IsNullOrEmpty(txtTotalDoc.Text)) txtTotalDoc.Text = "0";
            TipoBE.Comp_valor_total = Convert.ToDecimal(txtTotalDoc.Text);

            ENResultOperation R = ClsCompra_ProductosBC.Actualiza_Valores(TipoBE);
            if (!R.Proceder) MessageBox.Show("Error al Actualizar Valores " + R.Sms);
        }

        private void txtSerie_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtSerie.Text))
            {
                MessageBox.Show("Debe Ingresar el Numero de Serie", "Mensaje de Verificación");
                txtSerie.Focus();
            }
        }
        private void txtProveedor_Validating(object sender, CancelEventArgs e)
        {
        }

        #region Keypress_Cabecera
        private void txtProveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                if (txtProve_Validar()) SendKeys.Send("{TAB}");
            }
        }
        private void cboTipoProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter) SendKeys.Send("{TAB}");
        }

        private void cboTipoDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter) SendKeys.Send("{TAB}");
        }

        private void txtSerie_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter) SendKeys.Send("{TAB}");
        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter) SendKeys.Send("{TAB}");
            ValidarNumeros(e);
        }

        private void dtpFecha_Emision_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter) SendKeys.Send("{TAB}");
        }

        private void cboTipoMoneda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter) SendKeys.Send("{TAB}");
        }

        private void txtTipo_Cambio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter) SendKeys.Send("{TAB}");
            ValidarNumeros(e);
        }

        private void cboIncluye_Igv_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter) SendKeys.Send("{TAB}");
        }

        private void txtForma_Pago_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter) SendKeys.Send("{TAB}");
        }

        private void dtpFecha_Vencimiento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter) SendKeys.Send("{TAB}");
        }

        private void txtPorcentaje_Igv_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter) SendKeys.Send("{TAB}");
            ValidarNumeros(e);
        }

        private void btnGrabar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter) SendKeys.Send("{TAB}");
        }

        private void btnBuscarxFechas_Click(object sender, EventArgs e)
        {
            Buscar_Documentos();
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Buscar_Documentos();
        }
        private void cboBuscarPor_SelectedValueChanged(object sender, EventArgs e)
        {
            switch (cboBuscarPor.Text)
            {
                case "Proveedor": sCondicion = "Proveedor"; break;
                case "Nro.Documento": sCondicion = "Nro.Documento"; break;
            }
            txtBuscar.Text = string.Empty;
            txtBuscar.Focus();
        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter) Buscar_Documentos();
        }

        private void Buscar_Documentos()
        {
            ENResultOperation R = ClsCompra_ProductosBC.Listar_Filtro(txtBuscar.Text,sCondicion,dtpFecIni.Value, dtpFecFin.Value);
            if (R.Proceder)
            {
                dgvListado.DataSource = (DataTable)R.Valor;
            }
            else
            {
                MessageBox.Show("Error al Obtener Valores : " + R.Sms);
            }
        }


        #endregion Keypress_Cabecera

        #endregion Cabecera

        #region Detalle

        void FormatoDgv_Documento()
        {
            //------------------------------------------------------------------//      
            var dgv = dgvDocumento;

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
            DataGridViewCellStyle style = this.dgvDocumento.ColumnHeadersDefaultCellStyle;
            style.BackColor = Color.Honeydew;
            style.ForeColor = Color.Gray;
            //dgv.Columns.Clear();
            dgv.ColumnCount = 12;
            // Setear Cabecera de Columna 
            dgv.Columns[0].Name = "IDE";
            dgv.Columns[0].DataPropertyName = "COMP_IDE";
            dgv.Columns[0].Width = 30;
            dgv.Columns[0].Visible = false;

            dgv.Columns[1].Name = "COMP_DETALLE_IDE";
            dgv.Columns[1].DataPropertyName = "COMP_DETALLE_IDE";
            dgv.Columns[1].Visible = false;

            dgv.Columns[2].Name = "COMP_CODIGO";
            dgv.Columns[2].DataPropertyName = "COMP_CODIGO";
            dgv.Columns[2].Width = 100;
            dgv.Columns[2].HeaderText = "Codigo";

            dgv.Columns[3].Name = "COMP_DESCRIPCION";
            dgv.Columns[3].DataPropertyName = "COMP_DESCRIPCION";
            dgv.Columns[3].Width = 200;
            dgv.Columns[3].HeaderText = "Descripcion";

            dgv.Columns[4].Name = "COMP_UNIDAD_COMPRA";
            dgv.Columns[4].DataPropertyName = "COMP_UNIDAD_COMPRA";
            dgv.Columns[4].Width = 80;
            dgv.Columns[4].HeaderText = "Unidad";
            dgv.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgv.Columns[5].Name = "COMP_UNIDAD_SALIDA";
            dgv.Columns[5].DataPropertyName = "COMP_UNIDAD_SALIDA";
            dgv.Columns[5].Visible = false;

            dgv.Columns[6].Name = "COMP_EQUIVALENCIA";
            dgv.Columns[6].DataPropertyName = "COMP_EQUIVALENCIA";
            dgv.Columns[6].Visible = false;

            dgv.Columns[7].Name = "COMP_VALOR_UNITARIO";
            dgv.Columns[7].DataPropertyName = "COMP_VALOR_UNITARIO";
            dgv.Columns[7].Width = 100;
            dgv.Columns[7].HeaderText = "V.Unitario";
            dgv.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgv.Columns[8].Name = "CANTIDAD_COMPRA";
            dgv.Columns[8].DataPropertyName = "CANTIDAD_COMPRA";
            dgv.Columns[8].Width = 100;
            dgv.Columns[8].HeaderText = "Cantidad";
            dgv.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgv.Columns[9].Name = "TOTAL";
            dgv.Columns[9].DataPropertyName = "TOTAL";
            dgv.Columns[9].Width = 100;
            dgv.Columns[9].HeaderText = "Total";
            dgv.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgv.Columns[10].Name = "CANTIDAD_SALIDA";
            dgv.Columns[10].DataPropertyName = "CANTIDAD_SALIDA";
            dgv.Columns[10].Visible = false;

            dgv.Columns[11].Name = "ESTADO";
            dgv.Columns[11].DataPropertyName = "ESTADO";
            dgv.Columns[11].Visible = false;

        }
        private void Mostrar_Detalle(Int32 nComp_Ide)
        {
            nTotal = 0;
            ENResultOperation D = ClsCompra_Productos_DetalleBC.Listar(nComp_Ide);
            if (D.Proceder)
            {
                dgvDocumento.DataSource = (DataTable)D.Valor;

                for (int row = 0; row <= dgvDocumento.Rows.Count - 1; row++)
                {
                    nCantidad = Convert.ToDecimal(this.dgvDocumento.Rows[row].Cells["CANTIDAD_COMPRA"].Value.ToString());
                    nUnitario = Convert.ToDecimal(this.dgvDocumento.Rows[row].Cells["COMP_VALOR_UNITARIO"].Value.ToString());
                    nTotal += (nCantidad * nUnitario);
                }
                if (cboIncluye_Igv.Text == "Si")
                {
                    Decimal Igv = 1.18M ;
                    nValBruto = nTotal / Igv;
                    nValIgv = nTotal - nValBruto;
                    txtValNeto.Text = nValBruto.ToString("####,###.00");
                    txtValor_Bruto.Text = nValBruto.ToString("####,###.00");
                    txtIgv.Text = nValIgv.ToString("####,###.00");
                    txtTotalDoc.Text = nTotal.ToString("####,###.00");
                }
                else
                {
                    Decimal Igv = 1.18M;
                    nValBruto = nTotal;
                    txtValor_Bruto.Text = nValBruto.ToString("####,###.00");
                    txtValNeto.Text = nValBruto.ToString("####,###.00");
                    nValTot = nValBruto * Igv;
                    nValIgv = nValTot - nValNeto;
                    txtIgv.Text = nValIgv.ToString("####,###.00");
                    txtTotalDoc.Text = nValTot.ToString("####,###.00");
                }
                Actualiza_Valores_Cabecera();
            }
            else
            {
                MessageBox.Show("Error al Obtener Valores : " + D.Sms);
            }
        }

        private void Carga_Detalle()
        {
            ENResultOperation R = ClsCompra_Productos_DetalleBC.Obtener_Registro(dComp_Ide,iComp_Detalle_Ide);
            DataTable dtg = (DataTable)R.Valor;
            if (dtg.Rows.Count == 1)
            {
                DataRow ROWG = dtg.Rows[0];
                txtDetCodigo.Text = ROWG["COMP_CODIGO"].ToString();
                txtDetDescripcion.Text = ROWG["COMP_DESCRIPCION"].ToString();
                txtDetPrecio_Unitario.Text = ROWG["COMP_VALOR_UNITARIO"].ToString();
                txtDetCantidad.Text = ROWG["CANTIDAD_COMPRA"].ToString();
                nTotal = Convert.ToDecimal(txtDetCantidad.Text) * Convert.ToDecimal(txtDetPrecio_Unitario.Text);
                txtDetTotal.Text = nTotal.ToString("###,###.00");
                txtDetTotal.ReadOnly = true;
            }
            else
            {
                MessageBox.Show("Error al Recuperar Item Seleccionado","Mensaje Linea de Items");
            }
        }
        private void Mostrar_Dgv_Detalle()
        {

            if (this.dgvDocumento.CurrentRow != null)
            {
                iComp_Detalle_Ide = Convert.ToInt32(this.dgvDocumento.CurrentRow.Cells["COMP_DETALLE_IDE"].Value.ToString());
            }
        }
        private void dgvDocumento_CurrentCellChanged(object sender, EventArgs e)
        {
            Mostrar_Dgv_Detalle();
        }

        private void Inicializar_Campos_detalle()
        {
            txtDetCodigo.Text = string.Empty;
            txtDetDescripcion.Text = string.Empty;
            txtDetCantidad.Text = string.Empty;
            txtDetPrecio_Unitario.Text = string.Empty;
            txtDetTotal.Text = string.Empty;
            cboDetUnidad_Compra.SelectedIndex = 0;
        }
        private void Habilitar_Campos_Detalle(Boolean Flag)
        {
            txtDetCodigo.ReadOnly = !Flag;
            txtDetDescripcion.ReadOnly = !Flag;
            txtDetCantidad.ReadOnly = !Flag;
            txtDetPrecio_Unitario.ReadOnly = !Flag;
            txtDetTotal.ReadOnly = !Flag;
            cboDetUnidad_Compra.Enabled = Flag;
        }
        private void Habilitar_Botones_Detalle(Boolean Flag)
        {
            btnDetNuevo.Enabled = Flag;
            btnDetModifica.Enabled = Flag;
            btnDetElimina.Enabled = Flag;
            btnDetSalir.Enabled = Flag;
            dgvDocumento.Enabled = Flag;
            btnDetNuevo.Focus();
        }
        private void Habilitar_Botones_Detalle_Linea(Boolean Flag)
        {
            btnDetGrabar.Enabled = Flag;
            btnDetCancelar.Enabled = Flag;
            btnDetGrabar.Text = "Grabar";
        }
        private void btnDetNuevo_Click(object sender, EventArgs e)
        {
            Operacion_Detalle = "N";
            PanelDetalle.Visible = true;
            Habilitar_Botones_Detalle(false);
            Habilitar_Botones_Detalle_Linea(true);
            Inicializar_Campos_detalle();
            Habilitar_Campos_Detalle(true);
            txtDetCodigo.Focus();
        }

        private void btnDetModifica_Click(object sender, EventArgs e)
        {
            Operacion_Detalle = "M";
            PanelDetalle.Visible = true;
            Carga_Detalle();
            Habilitar_Botones_Detalle(false);
            Habilitar_Botones_Detalle_Linea(true);
            Habilitar_Campos_Detalle(true);
            txtDetCodigo.Focus();
        }

        private void btnDetElimina_Click(object sender, EventArgs e)
        {
            Operacion_Detalle = "E";
            PanelDetalle.Visible = true;
            Carga_Detalle();
            Habilitar_Campos_Detalle(true);
            Habilitar_Botones_Detalle(false);
            Habilitar_Botones_Detalle_Linea(true);
            btnDetGrabar.Text = "Eliminar";
            btnDetGrabar.Focus();
        }

        private void btnDetSalir_Click(object sender, EventArgs e)
        {
            PanelMantenimiento.Visible = false;
            Habilitar_Botones_Generales(true);
            Habilitar_Botones_Cabecera(false);
            Mostrar("");
        }

        private void btnDetGrabar_Click(object sender, EventArgs e)
        {
            if (Procesar_Operacion_Detalle())
            {
                PanelDetalle.Visible = false;
                Habilitar_Botones_Detalle(true);
                Habilitar_Botones_Detalle_Linea(false);
                Mostrar_Detalle(dComp_Ide);
            }
        }

        private void btnDetCancelar_Click(object sender, EventArgs e)
        {
            PanelDetalle.Visible = false;
            Habilitar_Botones_Detalle(true);
            Habilitar_Botones_Detalle_Linea(false);
        }

        private Boolean Procesar_Operacion_Detalle()
        {
            ClsCompra_Productos_DetalleBE TipoBE = new ClsCompra_Productos_DetalleBE();
            TipoBE.Comp_ide = dComp_Ide;
            TipoBE.Comp_detalle_ide = iComp_Detalle_Ide;
            TipoBE.Comp_codigo = txtDetCodigo.Text;
            TipoBE.Comp_descripcion = txtDetDescripcion.Text;
            TipoBE.Comp_unidad_compra = cboDetUnidad_Compra.Text;
            TipoBE.Comp_unidad_salida = cboDetUnidad_Compra.Text;
            TipoBE.Comp_equivalencia = 1;
            if (string.IsNullOrEmpty(txtDetPrecio_Unitario.Text)) txtDetPrecio_Unitario.Text = "0";
            TipoBE.Comp_valor_unitario = Convert.ToDecimal(txtDetPrecio_Unitario.Text);
            if (string.IsNullOrEmpty(txtDetCantidad.Text)) txtDetCantidad.Text = "0";
            TipoBE.Cantidad_compra = Convert.ToDecimal(txtDetCantidad.Text);
            TipoBE.Estado = 0;

            switch (Operacion_Detalle)
            {
                case "N":
                    {
                        ENResultOperation R = ClsCompra_Productos_DetalleBC.Crear(TipoBE);
                        if (!R.Proceder) MessageBox.Show("Error al Insertar Compra de Productos " + R.Sms);
                        return true;
                    }
                case "M":
                    {
                        ENResultOperation R = ClsCompra_Productos_DetalleBC.Actualizar(TipoBE);
                        if (!R.Proceder) MessageBox.Show("Error al Modificar Compra de Productos " + R.Sms);
                        return true;
                    }
                case "E":
                    {
                        ENResultOperation R = ClsCompra_Productos_DetalleBC.Eliminar(TipoBE);
                        if (!R.Proceder) MessageBox.Show("Error al Eliminar Compra de Productos " + R.Sms);
                        return true;
                    }
            }
            return false;

        }


        #endregion Detalle


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

        private void txtDetCodigo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3)
            {
             
            }
        }
        private void txtDetCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter) SendKeys.Send("{TAB}");
        }

        private void txtDetDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter) SendKeys.Send("{TAB}");
        }

        private void cboDetUnidad_Compra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter) SendKeys.Send("{TAB}");
        }

        private void txtDetCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter) SendKeys.Send("{TAB}");
            ValidarNumeros(e);
        }

        private void txtDetPrecio_Unitario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter) SendKeys.Send("{TAB}");
            ValidarNumeros(e);
        }

        private void txtDetTotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter) btnDetGrabar.Focus();
            if ((int)e.KeyChar == (int)Keys.Tab)   btnDetGrabar.Focus();
        }

        private void txtDetPrecio_Unitario_Validated(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDetCantidad.Text)) txtDetCantidad.Text = "0";
            if (string.IsNullOrEmpty(txtDetPrecio_Unitario.Text)) txtDetPrecio_Unitario.Text = "0";
            nValTot = Convert.ToDecimal(txtDetCantidad.Text) * Convert.ToDecimal(txtDetPrecio_Unitario.Text);
            txtDetTotal.Text = nValTot.ToString("####,###.00");
        }


    }
}
