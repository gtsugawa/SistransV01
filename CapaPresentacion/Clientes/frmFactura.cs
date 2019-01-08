using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaBE;
using CapaBC;

namespace CapaPresentacion.Clientes
{
    public partial class frmFactura : Form
    {
        private string Operacion;
        private string campo_busqueda;
        private string condi_busqueda;
        private Int32 Id_Cliente = 0;
        private Int32 nId_Fact = 0;
        private Int32 nVeces;
        private Int32 nLoca_Ide = 0;
        private decimal mCantid = 0;
        private decimal mValVta = 0;
        private decimal mSubTot = 0;
        private decimal mImpIgv  = 0;
        public frmFactura()
        {
            InitializeComponent();
            dgvListado.AutoGenerateColumns = false;
        }

        private void frmFactura_Load(object sender, EventArgs e)
        {
            FormatoDetDgv();
            FormatoDgv();
            Mostrar_dgv("0");
            llenar_cboBuscarPor();
            llenar_cboTipFac();
            llenar_cboTipMon();
            llenar_cboLisPre();
            llenar_cboIncluyeIgv();
            llenar_cboEstado();
            llenar_cboReferencia();
            llenar_cboForPag();
            llenar_cboVendedor();
            Flag_Botones_Cabecera(true, true, true, false, false, true);
            HabilitarCamposCabecera(false);
        }

        # region Factura_Cabecera
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
            dgv.DefaultCellStyle.Font = new Font("Tahoma", 9);
            /*----------Alterna colores en el grid -------*/
            dgv.RowsDefaultCellStyle.BackColor = Color.LightBlue;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
            /*---Pintado de color a la cabecera del datagrid ---*/
            DataGridViewCellStyle style = this.dgvListado.ColumnHeadersDefaultCellStyle;
            style.BackColor = Color.Honeydew;
            style.ForeColor = Color.Gray;

            //dgv.Columns.Clear();
            dgv.ColumnCount = 47;
            // Setear Cabecera de Columna 
            dgv.Columns[0].Name = "FACT_IDE";
            dgv.Columns[1].Name = "SERIE_FACTURA_NUMERO";
            dgv.Columns[2].Name = "FACT_FACTURA_NUMERO";
            dgv.Columns[3].Name = "FACT_MONEDA";
            dgv.Columns[4].Name = "FACT_FECHA_EMISION";
            dgv.Columns[5].Name = "FACT_FECHA_VENCIMIENTO";
            dgv.Columns[6].Name = "FACT_TIPO_FACTURACION";
            dgv.Columns[7].Name = "FACT_TIPO_PRECIO";
            dgv.Columns[8].Name = "CLIE_IDE";
            dgv.Columns[9].Name = "VEND_IDE";
            dgv.Columns[10].Name = "FACT_DIRECCION";
            dgv.Columns[11].Name = "LOCA_IDE";
            dgv.Columns[12].Name = "FOR_PAG_IDE";
            dgv.Columns[13].Name = "CONC_IDE";
            dgv.Columns[14].Name = "FACT_TIPO_DOCUMENTO";
            dgv.Columns[15].Name = "SERIE_DOCUMENTO_NUMERO";
            dgv.Columns[16].Name = "FACT_DOCUMENTO_NUMERO";
            dgv.Columns[17].Name = "FACT_DOCUMENTO_NUMERO_NO_FACTURACION";
            dgv.Columns[18].Name = "FACT_FECHA_DOCUMENTO";
            dgv.Columns[19].Name = "FACT_DOCUMENTO_NO_EXISTE";
            dgv.Columns[20].Name = "FACT_ESTADO";
            dgv.Columns[21].Name = "FACT_ESTADO_DIGITACION";
            dgv.Columns[22].Name = "FACT_FECHAINAC";
            dgv.Columns[23].Name = "FACT_VALOR_TOTAL_AFECTO";
            dgv.Columns[24].Name = "FACT_VALOR_TOTAL_INAFECTO";
            dgv.Columns[25].Name = "FACT_IMPUESTO";
            dgv.Columns[26].Name = "FACT_REDONDEO";
            dgv.Columns[27].Name = "FACT_PORCENTAJE_IMPUESTO";
            dgv.Columns[28].Name = "FACT_TOTAL";

            dgv.Columns[29].Name = "FACT_NUMERO_ITEM";
            dgv.Columns[30].Name = "FACT_MONTO_LETRAS";
            dgv.Columns[31].Name = "PLA_CTA_IDE";
            dgv.Columns[32].Name = "TIPO_DOC_IDE";
            dgv.Columns[33].Name = "FACT_VENTA_LOCAL";
            dgv.Columns[34].Name = "FACT_VENTA_DOLAR";
            dgv.Columns[35].Name = "FACT_VENTA_INAFECTO_LOCAL";
            dgv.Columns[36].Name = "FACT_VENTA_INAFECTO_DOLAR";
            dgv.Columns[37].Name = "FACT_IMPUESTO_LOCAL";
            dgv.Columns[38].Name = "FACT_IMPUESTO_DOLAR";
            dgv.Columns[39].Name = "FACT_REDONDEO_LOCAL";
            dgv.Columns[40].Name = "FACT_REDONDEO_DOLAR";
            dgv.Columns[41].Name = "FACT_TIPO_CAMBIO";
            dgv.Columns[42].Name = "FACT_CONCEPTO";
            dgv.Columns[43].Name = "FACT_PRECIO_INCLUYE_IMPUESTO";
            dgv.Columns[44].Name = "FACT_NUMERO_ASIENTO";
            dgv.Columns[45].Name = "VECES";
            dgv.Columns[46].Name = "FACT_AUTOMATICO";

            dgv.Columns[0].Width = 25;
            dgv.Columns[0].HeaderText = "ID";
            dgv.Columns[0].Visible = false;
            dgv.Columns[0].DataPropertyName = "FACT_IDE";

            dgv.Columns[1].Width = 40;
            dgv.Columns[1].HeaderText = "Serie";
            dgv.Columns[1].DataPropertyName = "SERIE_FACTURA_NUMERO";

            dgv.Columns[2].Width = 60;
            dgv.Columns[2].HeaderText = "Numero";
            dgv.Columns[2].DataPropertyName = "FACT_FACTURA_NUMERO";
            dgv.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgv.Columns[3].Width = 25;
            dgv.Columns[3].HeaderText = "ID";
            dgv.Columns[3].DataPropertyName = "FACT_MONEDA";
            dgv.Columns[3].Visible = false;

            dgv.Columns[4].Width = 80;
            dgv.Columns[4].HeaderText = "F.Emision";
            dgv.Columns[4].DataPropertyName = "FACT_FECHA_EMISION";
            dgv.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.Columns[4].DefaultCellStyle.Format = "dd/MM/yyyy";

            dgv.Columns[5].Width = 80;
            dgv.Columns[5].HeaderText = "F.Vencmto";
            dgv.Columns[5].DataPropertyName = "FACT_FECHA_VENCIMIENTO";
            dgv.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.Columns[5].DefaultCellStyle.Format = "dd/MM/yyyy";

            dgv.Columns[6].DataPropertyName = "FACT_TIPO_FACTURACION";
            dgv.Columns[6].Visible = false;

            dgv.Columns[7].DataPropertyName = "FACT_TIPO_PRECIO";
            dgv.Columns[7].Visible = false;

            dgv.Columns[8].Width = 80;
            dgv.Columns[8].HeaderText = "IDE";
            dgv.Columns[8].DataPropertyName = "CLIE_IDE";
            dgv.Columns[8].Visible = false;

            dgv.Columns[9].DataPropertyName = "VEND_IDE";
            dgv.Columns[9].Visible = false;

            dgv.Columns[10].Width = 320;
            dgv.Columns[10].HeaderText = "Razon Social";
            dgv.Columns[10].DataPropertyName = "FACT_DIRECCION";

            dgv.Columns[11].DataPropertyName = "LOCA_IDE";
            dgv.Columns[11].Visible = false;

            dgv.Columns[12].DataPropertyName = "FOR_PAG_IDE";
            dgv.Columns[12].Visible = false;

            dgv.Columns[13].DataPropertyName = "CONC_IDE";
            dgv.Columns[13].Visible = false;

            dgv.Columns[14].DataPropertyName = "FACT_TIPO_DOCUMENTO";
            dgv.Columns[14].Visible = false;

            dgv.Columns[15].DataPropertyName = "SERIE_DOCUMENTO_NUMERO";
            dgv.Columns[15].Visible = false;

            dgv.Columns[16].DataPropertyName = "FACT_DOCUMENTO_NUMERO";
            dgv.Columns[16].Visible = false;

            dgv.Columns[17].DataPropertyName = "FACT_DOCUMENTO_NUMERO_NO_FACTURACION";
            dgv.Columns[17].Visible = false;

            dgv.Columns[18].DataPropertyName = "FACT_FECHA_DOCUMENTO";
            dgv.Columns[18].Visible = false;

            dgv.Columns[19].DataPropertyName = "FACT_DOCUMENTO_NO_EXISTE";
            dgv.Columns[19].Visible = false;

            dgv.Columns[20].DataPropertyName = "FACT_ESTADO";
            dgv.Columns[20].HeaderText = "Estado";
            
            dgv.Columns[21].DataPropertyName = "FACT_ESTADO_DIGITACION";
            dgv.Columns[21].Visible = false;

            dgv.Columns[22].DataPropertyName = "FACT_FECHAINAC";
            dgv.Columns[22].Visible = false;

            dgv.Columns[23].Width = 100;
            dgv.Columns[23].HeaderText = "Valor Afecto";
            dgv.Columns[23].DataPropertyName = "FACT_VALOR_TOTAL_AFECTO";
            dgv.Columns[23].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgv.Columns[23].DefaultCellStyle.Format = "# ###,###.#0";

            dgv.Columns[24].DataPropertyName = "FACT_VALOR_TOTAL_INAFECTO";
            dgv.Columns[24].Visible = false;

            dgv.Columns[25].Width = 100;
            dgv.Columns[25].HeaderText = "Impuesto";
            dgv.Columns[25].DataPropertyName = "FACT_IMPUESTO";
            dgv.Columns[25].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgv.Columns[25].DefaultCellStyle.Format = "# ###,###.#0";

            dgv.Columns[26].Width = 100;
            dgv.Columns[26].HeaderText = "Total Factura";
            dgv.Columns[26].DataPropertyName = "FACT_TOTAL";
            dgv.Columns[26].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgv.Columns[26].DefaultCellStyle.Format = "# ###,###.#0";

            dgv.Columns[27].Width = 80;
            dgv.Columns[27].HeaderText = "% IGV";
            dgv.Columns[27].DataPropertyName = "FACT_PORCENTAJE_IMPUESTO";
            dgv.Columns[27].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgv.Columns[27].DefaultCellStyle.Format = "###.#0";

            dgv.Columns[28].DataPropertyName = "FACT_REDONDEO";
            dgv.Columns[28].Visible = false;

            dgv.Columns[29].DataPropertyName = "FACT_NUMERO_ITEM";
            dgv.Columns[29].Visible = false;

            dgv.Columns[30].DataPropertyName = "FACT_MONTO_LETRAS";
            dgv.Columns[30].Visible = false;

            dgv.Columns[31].DataPropertyName = "PLA_CTA_IDE";
            dgv.Columns[31].Visible = false;

            dgv.Columns[32].DataPropertyName = "TIPO_DOC_IDE";
            dgv.Columns[32].Visible = false;

            dgv.Columns[33].DataPropertyName = "FACT_VENTA_LOCAL";
            dgv.Columns[33].Visible = false;

            dgv.Columns[34].DataPropertyName = "FACT_VENTA_DOLAR";
            dgv.Columns[34].Visible = false;

            dgv.Columns[35].DataPropertyName = "FACT_VENTA_INAFECTO_LOCAL";
            dgv.Columns[35].Visible = false;

            dgv.Columns[36].DataPropertyName = "FACT_VENTA_INAFECTO_DOLAR";
            dgv.Columns[36].Visible = false;

            dgv.Columns[37].DataPropertyName = "FACT_IMPUESTO_LOCAL";
            dgv.Columns[37].Visible = false;

            dgv.Columns[38].DataPropertyName = "FACT_IMPUESTO_DOLAR";
            dgv.Columns[38].Visible = false;

            dgv.Columns[39].DataPropertyName = "FACT_REDONDEO_LOCAL";
            dgv.Columns[39].Visible = false;

            dgv.Columns[40].DataPropertyName = "FACT_REDONDEO_DOLAR";
            dgv.Columns[40].Visible = false;

            dgv.Columns[41].DataPropertyName = "FACT_TIPO_CAMBIO";
            dgv.Columns[41].Visible = false;

            dgv.Columns[42].DataPropertyName = "FACT_CONCEPTO";
            dgv.Columns[42].Visible = false;

            dgv.Columns[43].DataPropertyName = "FACT_PRECIO_INCLUYE_IMPUESTO";
            dgv.Columns[43].Visible = false;

            dgv.Columns[44].DataPropertyName = "FACT_NUMERO_ASIENTO";
            dgv.Columns[44].Visible = false;

            dgv.Columns[45].DataPropertyName = "VECES";
            dgv.Columns[45].Visible = false;

            dgv.Columns[46].DataPropertyName = "FACT_AUTOMATICO";
            dgv.Columns[46].Visible = false;

        }

        private void Mostrar_dgv(string filtro)
        {
            DataTable TEMP = new DataTable();

            ENResultOperation R = ClsFactura_Carga_CabeceraBC.Listar(filtro);
            if (R.Proceder)
            {
                dgvListado.DataSource = (DataTable)R.Valor;
            }
            else
            {
                MessageBox.Show(R.Sms,"Error al Seleccionar Registros : ");
            }
            TEMP = (DataTable)R.Valor;

            for (int row = 0; row <= dgvListado.Rows.Count - 1; row++)
            {
                if (this.dgvListado.Rows[row].Cells[10].Value != null)
                {
                    Id_Cliente = Convert.ToInt32(this.dgvListado.Rows[row].Cells["CLIE_IDE"].Value);
                    ENResultOperation S = ClsClientesBC.Consultar_Ide(Id_Cliente);
                    DataTable dt = (DataTable)S.Valor;
                    DataRow ROW = dt.Rows[0];
                    this.dgvListado.Rows[row].Cells[10].Value = ROW["CLIE_RAZON_SOCIAL"].ToString();
                }
                this.dgvListado.Rows[row].Cells[26].Value = Convert.ToString(Convert.ToDouble(this.dgvListado.Rows[row].Cells[23].Value) + Convert.ToDouble(this.dgvListado.Rows[row].Cells[25].Value));
            }

        }

        private void Mostrar_DgvListado()
        {

            if (this.dgvListado.CurrentRow != null)
            {

                nId_Fact = Convert.ToInt32(this.dgvListado.CurrentRow.Cells["FACT_IDE"].Value);
                nLoca_Ide = Convert.ToInt32(this.dgvListado.CurrentRow.Cells["LOCA_IDE"].Value);
                nVeces = Convert.ToInt32(this.dgvListado.CurrentRow.Cells["VECES"].Value);
                cboTipFac.Text = Convert.ToString(this.dgvListado.CurrentRow.Cells["FACT_TIPO_FACTURACION"].Value);
                cboTipMon.Text = Convert.ToString(this.dgvListado.CurrentRow.Cells["FACT_MONEDA"].Value);
                cboLisPre.Text = Convert.ToString(this.dgvListado.CurrentRow.Cells["FACT_TIPO_PRECIO"].Value);
                cboIncluyeIgv.Text = Convert.ToString(this.dgvListado.CurrentRow.Cells["FACT_PRECIO_INCLUYE_IMPUESTO"].Value);
                cboEstado.Text = Convert.ToString(this.dgvListado.CurrentRow.Cells["FACT_ESTADO"].Value);
                cboForPag.SelectedValue = Convert.ToString(this.dgvListado.CurrentRow.Cells["FOR_PAG_IDE"].Value);
                cboVendedor.SelectedValue = Convert.ToString(this.dgvListado.CurrentRow.Cells["VEND_IDE"].Value);
                cboReferencia.SelectedValue = Convert.ToString(this.dgvListado.CurrentRow.Cells["FACT_TIPO_DOCUMENTO"].Value);

                txtSerie.Text = Convert.ToString(this.dgvListado.CurrentRow.Cells["SERIE_FACTURA_NUMERO"].Value);
                txtNumero.Text = Convert.ToString(this.dgvListado.CurrentRow.Cells["FACT_FACTURA_NUMERO"].Value);
                txtCodCli.Text = Convert.ToString(this.dgvListado.CurrentRow.Cells["CLIE_IDE"].Value);
                txtDirCli.Text = Convert.ToString(this.dgvListado.CurrentRow.Cells["FACT_DIRECCION"].Value);

                dtpFecEmision.Text = Convert.ToString(this.dgvListado.CurrentRow.Cells["FACT_FECHA_EMISION"].Value);
                dtpFecVencto.Text = Convert.ToString(this.dgvListado.CurrentRow.Cells["FACT_FECHA_EMISION"].Value);

                txtSubTot.Text = this.dgvListado.CurrentRow.Cells["FACT_VALOR_TOTAL_AFECTO"].Value.ToString();
                txtPorIgv.Text = Convert.ToString(this.dgvListado.CurrentRow.Cells["FACT_PORCENTAJE_IMPUESTO"].Value);
                txtImpIgv.Text = Convert.ToString(this.dgvListado.CurrentRow.Cells["FACT_IMPUESTO"].Value);

                mSubTot = Convert.ToDecimal(this.dgvListado.CurrentRow.Cells["FACT_VALOR_TOTAL_AFECTO"].Value);
                mImpIgv = Convert.ToDecimal(this.dgvListado.CurrentRow.Cells["FACT_IMPUESTO"].Value);

                txtTotal.Text = Convert.ToString(mSubTot + mImpIgv);

                txtSubTot.Text = String.Format("{0:# ###,###.00}", double.Parse(txtSubTot.Text));
                txtImpIgv.Text = String.Format("{0:# ###,###.00}", double.Parse(txtImpIgv.Text));
                txtTotal.Text  = String.Format("{0:# ###,###.00}", double.Parse(txtTotal.Text));

                txtSerDoc.Text = Convert.ToString(this.dgvListado.CurrentRow.Cells["SERIE_DOCUMENTO_NUMERO"].Value);
                txtNumDoc.Text = Convert.ToString(this.dgvListado.CurrentRow.Cells["FACT_DOCUMENTO_NUMERO"].Value);

                Mostrar_Cliente();
                Mostrar_Detdgv(nId_Fact);

            }
        }

        private void dgvListado_CurrentCellChanged(object sender, EventArgs e)
        {
            Mostrar_DgvListado();
        }

        private void llenar_cboBuscarPor()
        {
            cboBuscarpor.Items.Add("Numero");
            cboBuscarpor.Items.Add("Cliente");
            cboBuscarpor.Items.Add("Fecha");
            cboBuscarpor.Items.Add("Guia Remision");
            cboBuscarpor.SelectedIndex = 0;
        }
        private void llenar_cboTipFac()
        {
            cboTipFac.Items.Add("Factura");
            cboTipFac.Items.Add("B/Venta");
            cboTipFac.SelectedIndex = 0;
        }
        private void llenar_cboTipMon()
        {
            cboTipMon.Items.Add("Soles");
            cboTipMon.Items.Add("Dolares");
            cboTipMon.SelectedIndex = 0;
        }
        private void llenar_cboLisPre()
        {
            cboLisPre.Items.Add("Local");
            cboLisPre.Items.Add("CIF");
            cboLisPre.Items.Add("FOB");
            cboLisPre.SelectedIndex = 0;
        }
        private void llenar_cboIncluyeIgv()
        {
            cboIncluyeIgv.Items.Add("No");
            cboIncluyeIgv.Items.Add("Si");
            cboIncluyeIgv.SelectedIndex = 0;
        }
        private void llenar_cboEstado()
        {
            cboEstado.Items.Add("Activo");
            cboEstado.Items.Add("Cerrado");
            cboEstado.Items.Add("Anulado");
            cboEstado.SelectedIndex = 0;
        }
        private void llenar_cboReferencia()
        {
            cboReferencia.Items.Add("Factura");
            cboReferencia.Items.Add("B/Venta");
            cboReferencia.SelectedIndex = 0;
        }

        private void llenar_cboForPag()
        {
            ENResultOperation R = ClsForma_PagoBC.Listar("");
            if (R.Proceder) cboForPag.DataSource = (DataTable)R.Valor;
            cboForPag.DisplayMember = "FOR_PAG_NOMBRE";
            cboForPag.ValueMember = "FOR_PAG_IDE";
        }

        private void llenar_cboVendedor()
        {
            ENResultOperation R = ClsVendedorBC.Listar("");
            if (R.Proceder) cboVendedor.DataSource = (DataTable)R.Valor;
            cboVendedor.DisplayMember = "VEND_RAZON_SOCIAL";
            cboVendedor.ValueMember = "VEND_IDE";
        }

        private void Mostrar_Cliente()
        {
            if (!String.IsNullOrEmpty(txtCodCli.Text))
            {
                ENResultOperation R = ClsClientesBC.Consultar_Ide(Convert.ToInt32(txtCodCli.Text));
                if (R.Proceder)
                {
                    DataTable dt = (DataTable)R.Valor;
                    DataRow ROW = dt.Rows[0];
                    txtNomCli.Text = ROW["CLIE_RAZON_SOCIAL"].ToString();
                    txtLocaIde.Text = ROW["LOCA_CODIGO"].ToString();
                    txtLocalidad.Text = ROW["LOCA_NOMBRE"].ToString();
                    txtPais.Text = ROW["PAIS_NOMBRE"].ToString();
                    nLoca_Ide = Convert.ToInt32(ROW["LOCA_IDE"]);
                }
                else
                {
                    txtNomCli.Text = "";
                }
            }
        }

        private void txtBuscarpor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Buscar_Factura();
            }
        }

        private void btnBuscarTxt_Click(object sender, EventArgs e)
        {
            Buscar_Factura();
        }

        private void Buscar_Factura()
        {
            switch (cboBuscarpor.Text)
            {
                case "Numero": campo_busqueda = "Numero";
                    condi_busqueda = txtBuscarpor.Text.Trim();
                    break;
                case "Cliente": campo_busqueda = "Cliente";
                    condi_busqueda = txtBuscarpor.Text.Trim();
                    break;
                case "Fecha": campo_busqueda = "Fecha";
                    condi_busqueda = txtBuscarpor.Text.Trim();
                    break;
                case "Guia Remision": campo_busqueda = "Guia_Remision";
                    condi_busqueda = txtBuscarpor.Text.Trim();
                    break;
            }

            Ejecutar_Busqueda(campo_busqueda, condi_busqueda);
        }

        private void Ejecutar_Busqueda(string campo_busqueda, string condi_busqueda)
        {
            DataTable TEMP = new DataTable();
            ENResultOperation R = ClsFactura_Carga_CabeceraBC.Listar_Filtro(campo_busqueda, condi_busqueda);
            if (R.Proceder) dgvListado.DataSource = (DataTable)R.Valor;
            TEMP = (DataTable)R.Valor;
        }
        private void Refrescar_Cabecera(Int32 Fact_Ide)
        {
            DataTable TEMP = new DataTable();
            ENResultOperation R = ClsFactura_Carga_CabeceraBC.Buscar_Id(nId_Fact);
            if (R.Proceder) dgvListado.DataSource = (DataTable)R.Valor;
            TEMP = (DataTable)R.Valor;
            Mostrar_DgvListado();
        }

        private void Flag_Botones_Cabecera(Boolean Flag1, Boolean Flag2, Boolean Flag3, Boolean Flag4,
                                          Boolean Flag5, Boolean Flag6)
        {
            btnNuevoCab.Enabled = Flag1;
            btnModificarCab.Enabled = Flag2;
            btnEliminarCab.Enabled = Flag3;
            btnGrabarCab.Enabled = Flag4; 
            btnCancelarCab.Enabled = Flag5;
            btnSalir.Enabled = Flag6;
        }
        private void LimpiaCamposCabecera()
        {
            cboTipFac.SelectedIndex = 0;
            cboTipMon.SelectedIndex = 0;
            cboLisPre.SelectedIndex = 0;
            cboIncluyeIgv.SelectedIndex = 0;
            cboEstado.SelectedIndex = 0;
            cboForPag.SelectedIndex = 0;
            cboVendedor.SelectedIndex = 0;
            cboReferencia.SelectedIndex = 0; ;

            txtSerie.Text = "001";
            txtNumero.Text = "0";
            txtCodCli.Text = "";
            txtNomCli.Text = "";
            txtDirCli.Text = "";

            txtLocaIde.Text = "";
            txtLocalidad.Text = "";
            txtPais.Text = "";

            dtpFecEmision.Text = DateTime.Now.ToString();
            dtpFecVencto.Text = DateTime.Now.ToString();

            txtSerDoc.Text = "";
            txtNumDoc.Text = "";

            txtSubTot.Text = "0.00";
            txtPorIgv.Text = "0.00";
            txtImpIgv.Text = "0.00";
            txtTotal.Text = "0.00";

        }

        private void HabilitarCamposCabecera(Boolean flag)
        {
            cboTipFac.Enabled = flag;
            cboTipMon.Enabled = flag;
            cboLisPre.Enabled = flag;
            cboIncluyeIgv.Enabled = flag;
            cboEstado.Enabled = flag;

            txtSerie.ReadOnly = !flag;
            txtNumero.ReadOnly = !flag;
            txtCodCli.ReadOnly = !flag;
            txtNomCli.ReadOnly = !flag;
            txtDirCli.ReadOnly = !flag;

            txtLocaIde.ReadOnly = !flag;
            txtLocalidad.ReadOnly = !flag;
            txtPais.ReadOnly = !flag;

            dtpFecEmision.Enabled = flag;
            dtpFecVencto.Enabled = flag;

            txtSubTot.ReadOnly = !flag;
            txtPorIgv.ReadOnly = !flag;
            txtImpIgv.ReadOnly = !flag;
            txtTotal.ReadOnly = !flag;

            cboForPag.Enabled = flag;
            cboVendedor.Enabled = flag;
            cboReferencia.Enabled = flag;
            txtSerDoc.ReadOnly = !flag;
            txtNumDoc.ReadOnly = !flag;
        }

        private void btnNuevoCab_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
            Operacion = "N";
            Flag_Botones_Cabecera(false, false, false, true, true, false);
            LimpiaCamposCabecera();
            HabilitarCamposCabecera(true);
        }

        private void btnModificarCab_Click(object sender, EventArgs e)
        {
            if (nId_Fact != 0)
            {
            tabControl1.SelectedIndex = 1;
            Operacion = "M";
            HabilitarCamposCabecera(true);
            Flag_Botones_Cabecera(false, false, false, true, true, false);
            Refrescar_Cabecera(nId_Fact);
            }

        }
        private void btnEliminarCab_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
            Operacion = "E";
            Flag_Botones_Cabecera(false, false, false, true, true, false);
            btnGrabarCab.Text = "Elimina";
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnGrabarCab_Click(object sender, EventArgs e)
        {
            Procesar_Operacion_Cabecera();
        }

        private void btnCancelarCab_Click(object sender, EventArgs e)
        {
            Flag_Botones_Cabecera(true, true, true, false, false, true);
            HabilitarCamposCabecera(false);
            Mostrar_DgvListado();
        }

        private void Mostrar(string filtro)
        {
            //DataTable TEMP = new DataTable();
            //ENResultOperation R = ClsFactura_Carga_CabeceraBC.Listar(filtro);
            //if (R.Proceder) dgvListado.DataSource = (DataTable)R.Valor;
            //this.OcultarColumnas();
            //cFiltro = filtro;
            //TEMP = (DataTable)R.Valor;
            //txtFiltro.Focus();
        }

        private void Procesar_Operacion_Cabecera()
        {
            ClsFactura_Carga_CabeceraBE TipoBE = new ClsFactura_Carga_CabeceraBE();
            TipoBE.Fact_ide = nId_Fact;
            TipoBE.Serie_factura_numero = txtSerie.Text;
            TipoBE.Fact_factura_numero = Convert.ToInt32(txtNumero.Text);
            TipoBE.Fact_moneda = cboTipMon.Text;
            TipoBE.Fact_fecha_emision = Convert.ToDateTime(dtpFecEmision.Value.ToString("dd/MM/yyyy"));
            TipoBE.Fact_fecha_vencimiento = Convert.ToDateTime(dtpFecVencto.Value.ToString("dd/MM/yyyy"));
            TipoBE.Fact_tipo_facturacion = cboTipFac.Text;
            TipoBE.Fact_tipo_precio = cboLisPre.Text;
            TipoBE.Clie_ide = Convert.ToInt32(txtCodCli.Text);
            TipoBE.Vend_ide = Convert.ToInt32(cboVendedor.SelectedValue);;
            TipoBE.Fact_direccion = txtDirCli.Text;
            TipoBE.Loca_ide = nLoca_Ide;
            TipoBE.For_pag_ide = Convert.ToInt32(cboForPag.SelectedValue);
            TipoBE.Conc_ide = 1;
            TipoBE.Fact_tipo_documento = cboReferencia.Text;
            TipoBE.Serie_documento_numero = txtSerDoc.Text;
            TipoBE.Fact_documento_numero = Convert.ToInt32(txtNumDoc.Text);
            TipoBE.Fact_documento_numero_no_facturacion = "";
            TipoBE.Fact_fecha_documento = DateTime.Today;
            TipoBE.Fact_documento_no_existe = 0;
            TipoBE.Fact_estado = cboEstado.Text;
            TipoBE.Fact_redondeo = 0;
            TipoBE.Fact_precio_incluye_impuesto = cboIncluyeIgv.Text;
            TipoBE.Fact_estado_digitacion = 0;
            TipoBE.Fact_fechainac = DateTime.Today;
            TipoBE.Fact_porcentaje_impuesto = 18.00;
            TipoBE.Veces = nVeces;
            TipoBE.Usuario = "ADMIN";

            switch (Operacion)
            {
                case "N":
                    ENResultOperation R = ClsFactura_Carga_CabeceraBC.Crear(TipoBE);
                    if (R.Proceder)
                    {
                        string NroSer = txtSerie.Text;
                        ClsSerie_FacturacionBE TipSerBE = new ClsSerie_FacturacionBE();
                        ENResultOperation S = ClsSerie_FacturacionBC.Listar_Filtro(NroSer);
                        if (S.Proceder)
                        {
                            DataTable dt = (DataTable)S.Valor;
                            DataRow ROW = dt.Rows[0];
                            txtNumero.Text = ROW["SERIE_FACTURA_CONTADOR"].ToString();

                        }
                    }
                    break;
                case "M":
                    ENResultOperation T = ClsFactura_Carga_CabeceraBC.Actualizar(TipoBE);
                    if (!T.Proceder)
                    {
                        MessageBox.Show("ERROR AL MODIFICAR " + T.Sms);
                    }

                    break;
                case "E":
                    ENResultOperation U = ClsFactura_Carga_CabeceraBC.Eliminar(TipoBE);
                    if (U.Proceder)
                    {
                        MessageBox.Show("Se Elimino Factura ");
                    }
                    else
                    {
                        MessageBox.Show("Error Al Eliminar " + U.Sms);
                    }

                    break;
            }

            this.tabControl1.SelectedIndex = 0;
            Flag_Botones_Cabecera(true, true, true, false, false, true);
            HabilitarCamposCabecera(false);
            btnGrabarCab.Text = "Grabar";
        }

        #endregion Factura_Cabecera

        #region Tab_Documento
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Buscar");
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Guardar");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cancelar");
        }
        private void btnImprimir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Imprimir");
        }

        private void btnTerminar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nuevo");
        }

        private void btnInserta_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Inserta");
        }

        private void btnModifica_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Modifica");
        }

        private void btnElimina_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Elimina");
        }

        private void btnRefresca_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Refresca");
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mostrar");
        }

        private void btnNuevoOR_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nuevo OR");
        }

        #endregion


        #region Factura_Detalle

        void FormatoDetDgv()
        {
            //------------------------------------------------------------------//      
            var dgvD = dgvDetListado;

            dgvD.MultiSelect = false;
            dgvD.ReadOnly = true;
            dgvD.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvD.AllowUserToAddRows = false;
            dgvD.AllowUserToDeleteRows = false;
            /*---------Centrar titulo de cabecera --------------*/
            dgvD.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            /*-- No se hace visible la primera columna del datagrid */
            dgvD.RowHeadersVisible = false;
            /*---No premite cambiar el tamaño a la columna*/
            dgvD.AllowUserToResizeColumns = false;
            dgvD.AllowUserToResizeRows = false;
            /*---------------Tipo de fuente y tamaño-----*/
            dgvD.DefaultCellStyle.Font = new Font("Tahoma", 9);
            /*----------Alterna colores en el grid -------*/
            //dgvD.RowsDefaultCellStyle.BackColor = Color.LightBlue;
            //dgvD.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
            /*---Pintado de color a la cabecera del datagrid ---*/
            DataGridViewCellStyle style = this.dgvDetListado.ColumnHeadersDefaultCellStyle;
            style.BackColor = Color.Blue; //Color.Honeydew;
            style.ForeColor = Color.Gray;

            //dgvD.Columns.Clear();
            dgvD.ColumnCount = 7;
            // Setear Cabecera de Columna 

            
            dgvD.Columns[0].Name = "FACT_IDE";
            dgvD.Columns[1].Name = "FACT_IDE_DETALLE";
            dgvD.Columns[2].Name = "FACT_NOTA";
            dgvD.Columns[3].Name = "FACT_UNIDAD";
            dgvD.Columns[4].Name = "FACT_CANTIDAD";
            dgvD.Columns[5].Name = "FACT_VALOR_VENTA";
            dgvD.Columns[6].Name = "TOTAL_DETALLE";

            dgvD.Columns[0].Visible = false;
            dgvD.Columns[0].DataPropertyName = "FACT_IDE";

            dgvD.Columns[1].DataPropertyName = "FACT_IDE_DETALLE";
            dgvD.Columns[1].Visible = false;

            dgvD.Columns[2].Width = 420;
            dgvD.Columns[2].HeaderText = "NOTA";
            dgvD.Columns[2].DataPropertyName = "FACT_NOTA";

            dgvD.Columns[3].Width = 50;
            dgvD.Columns[3].HeaderText = "U/M";
            dgvD.Columns[3].DataPropertyName = "FACT_UNIDAD";
            dgvD.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvD.Columns[4].Width = 80;
            dgvD.Columns[4].HeaderText = "Cantidad";
            dgvD.Columns[4].DataPropertyName = "FACT_CANTIDAD";
            dgvD.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvD.Columns[4].DefaultCellStyle.Format = "# ###,###.#0";

            dgvD.Columns[5].Width = 100;
            dgvD.Columns[5].HeaderText = "V.Venta";
            dgvD.Columns[5].DataPropertyName = "FACT_VALOR_VENTA";
            dgvD.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvD.Columns[5].DefaultCellStyle.Format = "# ###,###.#0";

            dgvD.Columns[6].Width = 100;
            dgvD.Columns[6].HeaderText = "Sub Total";
            dgvD.Columns[6].DataPropertyName = "SUBTOTAL";
            dgvD.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvD.Columns[6].DefaultCellStyle.Format = "# ###,###.#0";

        }

        private void Mostrar_Detdgv(int filtro)
        {
            DataTable TEMP = new DataTable();

            ENResultOperation R = ClsFactura_Carga_Detalle_RecojoBC.Listar(filtro);
            if (R.Proceder)
            {
                dgvDetListado.DataSource = (DataTable)R.Valor;
            }
            else
            {
                MessageBox.Show(R.Sms, "Error al Seleccionar Registros : ");
            }
            TEMP = (DataTable)R.Valor;

            foreach (DataGridViewRow row in dgvDetListado.Rows)
            {
                if (Convert.ToDecimal(dgvDetListado.Rows[row.Index].Cells["FACT_CANTIDAD"].Value) != 0)
                {
                    row.DefaultCellStyle.BackColor = Color.LightGray;
                    //row.DefaultCellStyle.SelectionBackColor = Color.Honeydew;
                }
                else
                {
                    row.DefaultCellStyle.BackColor = Color.White;
                    //row.DefaultCellStyle.SelectionBackColor = Color.RoyalBlue;
                }
            }

        }

        #endregion

        private void tabControl1_Enter(object sender, EventArgs e)
        {
            txtBuscarpor.Focus();

        }

    }
}
