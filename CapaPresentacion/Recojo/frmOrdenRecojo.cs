                                                                                                                                                                                                                                                                                                                               using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CapaBC;
using CapaBE;
using CapaDA;

namespace CapaPresentacion
{
    public partial class frmOrdenRecojo : Form
    {
        private string campo_busqueda;
        private string condi_busqueda;
        private string sdestinatario;
        private string IPBasedeDatos;
        private Int32 unidad_medida = 1;
        private Int32 sproducto = 1;

        private static frmOrdenRecojo frmInstance = null;
        
        private string Operacion = null;
        private string Detalle_Operacion_Detalle = null;
        private string Operacion_Peaje = null;
        private string Operacion_Gasto = null;
        private string Operacion_Combustible = null;
        private string Operacion_Nota = null;
        private string Operacion_Ayudante = null;
        private string Operacion_Recargo = null;

        private string nProv_Carga_Ide = null;
        private Int32  nReco_Ide = 0;
        private Int32  nReco_Ide_Detalle = 0;
        private Int32  nReco_Ide_Detalle_Peaje = 0;
        private Int32  nReco_Ide_Detalle_Gasto = 0;
        private Int32  nReco_Ide_Detalle_Combustible = 0;
        private Int32  nReco_Ide_Detalle_Nota = 0;
        private Int32  nReco_Ide_Detalle_Ayudante = 0;
        private Int32  nReco_Ide_Detalle_Recargo = 0;
        private Int32  nReco_Ide_Detalle_Apoyo = 0;
        private Int32  ID_Cliente = 0;

        private Int32  nVeces = 0;
        private string cNumero_Orden;
        private string nRendimiento = "";
  
        //private string nProv_Carga_Cont_Ide = null;
        //private string nTran_Ide = null;
        //private string nTran_Chof_Ide = null;
        private string cFiltro = "";
        private string cEstado = "1";
        private string cTipoCombustible;
        private Int32  nTipoCombustible;

        private Int32  nEstado_Digitacion = 0;
        private Int32  nEstado = 0;
        private Int32 nFacturado = 0;
        private Int32 nUnaVez = 0;

        public static  Recojo.frmRecojo_Detalle miform = new Recojo.frmRecojo_Detalle();

        public static frmOrdenRecojo fInstance()
        {
            if (((frmInstance == null) || (frmInstance.IsDisposed == true)))
            {
                frmInstance = new frmOrdenRecojo();
            }

            frmInstance.BringToFront();
            frmInstance.WindowState = FormWindowState.Normal;
            return frmInstance;
        }
        public frmOrdenRecojo()
        {
            InitializeComponent();
            dgvListado.AutoGenerateColumns = false;
            nUnaVez = 0;
        }

        #region OrdenCabecera
        private void Mostrar(string filtro)
        {
            DataTable TEMP = new DataTable();
            ENResultOperation R = ClsRecojo_CabeceraBC.Listar(filtro);
            if (R.Proceder) dgvListado.DataSource = (DataTable)R.Valor;
            //this.OcultarColumnas();
            lblTotal.Text = "Ordenes Visualizadas : " + Convert.ToString(dgvListado.Rows.Count);
            cFiltro = filtro;
            TEMP = (DataTable)R.Valor;
            txtFiltro.Focus();            
        }

        private void Flag_Botones_Cabecera(Boolean Flag1,Boolean Flag2,Boolean Flag3,Boolean Flag4,
                                           Boolean Flag5,Boolean Flag6,Boolean Flag7,Boolean Flag8)
        {
            btnNuevo.Enabled     = Flag1;
            btnModificar.Enabled = Flag2;
            btnEliminar.Enabled  = Flag3;
            btnBuscar.Enabled    = Flag4;
            btnCancelar.Enabled  = Flag5;
            btnGrabar.Enabled    = Flag6;
            btnImprimir.Enabled  = Flag7;
            btnSalir.Enabled     = Flag8;
        }

        //Método para ocultar columnas
        private void OcultarColumnas()
        {
            /*
            this.dataListado.Columns[0].Visible = false;
            this.dataListado.Columns[1].Visible = false;
             */
        }
        private void frmOrdenRecojo_Load(object sender, EventArgs e)
        {
            
            IPBasedeDatos = CapaDA.StrConexion.strcn.Substring(12, 12);
            lblconexion.Text = "";  // IPBasedeDatos;
            this.FormatoDgv();
            this.Mostrar("0");
            llenar_cboReparto();
            Cargar_Lugar();
            llenar_cboTipo();
            Cargar_Serie_Recojo();
            FormatoDgv_Recargo();
            Mes_Actual();
            Flag_Botones_Cabecera(true, true, true, true, false, false, true, true);
            // Detalle de Recojo
            FormatoDgv_RecoDetalle();
            FormatoDgv_Peaje();
            FormatoDgv_Gastos();
            FormatoDgv_Combustible();
            FormatoDgv_Nota();
            FormatoDgv_Ayudante();
            FormatoDgv_PuntoReparto();
            FormatoDgv_Apoyo();
            rbtPorCerrar.Checked = true;
            nEstado = 0;
            cboFiltro.SelectedIndex = 0;
            txtFiltro.Focus();

            miform.Contar += new Recojo.frmRecojo_Detalle.Cuenta(Mostrar_Detalle);
        }

        private void llenar_cboReparto()
        {
            cboRptoDestinatario.Items.Add("No");
            cboRptoDestinatario.Items.Add("Si");
            cboRptoDestinatario.SelectedIndex = 1;
        }

        private void Cargar_Lugar()
        {
            cboLugar.Items.Clear();
            cboLugar.Items.Add("Lima");
            cboLugar.Items.Add("Provincia");
            cboLugar.SelectedIndex = 0;

            /*
            DataTable TEMP = new DataTable();
            string nombre_error = "";
            ENResultOperation R = ClsLocalidadBC.Listar(nombre_error);
            if (R.Proceder)
            { 
                TEMP = (DataTable)R.Valor;
                this.cboLugar.DataSource = TEMP;
                this.cboLugar.DisplayMember = Convert.ToString(TEMP.Columns["Loca_Nombre"]);
                this.cboLugar.ValueMember = Convert.ToString(TEMP.Columns["Loca_Ide"]);
                this.cboLugar.AutoCompleteMode = AutoCompleteMode.Suggest;
                this.cboLugar.AutoCompleteSource = AutoCompleteSource.ListItems;
            }
            */

            
        }

        private void llenar_cboTipo()
        {
            cboTipo.Items.Add("Apoyo");
            cboTipo.Items.Add("Otros");
            cboTipo.Items.Add("Servicios");
            cboTipo.SelectedIndex = 2;
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
            dgv.ColumnCount = 50;
            // Setear Cabecera de Columna 
            dgv.Columns[0].Name = "ESTADO_DIGITACION";
            dgv.Columns[0].Width = 25;
            dgv.Columns[0].HeaderText = "Est";
            dgv.Columns[0].DataPropertyName = "";
            
            dgv.Columns[1].Name = "SERIE";
            dgv.Columns[1].Width = 40;
            dgv.Columns[1].HeaderText = "Serie";
            dgv.Columns[1].DataPropertyName = "Serie_Numero_Recojo";

            dgv.Columns[2].Name = "NUMERO";
            dgv.Columns[2].Width = 60;
            dgv.Columns[2].HeaderText = "Numero";
            dgv.Columns[2].DataPropertyName = "Reco_Numero_Recojo";

            dgv.Columns[3].Name = "FEMISION";
            dgv.Columns[3].Width = 80;
            dgv.Columns[3].HeaderText = "F.Emision";
            dgv.Columns[3].DataPropertyName = "Reco_Fecha_Emision";

            dgv.Columns[4].Name = "RTRASLADO";
            dgv.Columns[4].Width = 80;
            dgv.Columns[4].HeaderText = "F.Traslado";
            dgv.Columns[4].DataPropertyName = "Reco_Fecha_Traslado";

            dgv.Columns[5].Name = "TRANSPORTISTA";
            dgv.Columns[5].Width = 80;
            dgv.Columns[5].HeaderText = "Transportista";
            dgv.Columns[5].DataPropertyName = "Tran_Razon_Social";

            dgv.Columns[6].Name = "CHOFER_NOMBRE";
            dgv.Columns[6].Width = 180;
            dgv.Columns[6].HeaderText = "Conductor";
            dgv.Columns[6].DataPropertyName = "Chofer_Nombre";

            dgv.Columns[7].Name = "VEHICULO";
            dgv.Columns[7].Width = 100;
            dgv.Columns[7].HeaderText = "Vehiculo";
            dgv.Columns[7].DataPropertyName = "Tran_Vehi_Placa";

            dgv.Columns[8].Name = "PESO";
            dgv.Columns[8].Width = 60;
            dgv.Columns[8].HeaderText = "TN";
            dgv.Columns[8].DataPropertyName = "Reco_Tonelaje";

            dgv.Columns[9].Name = "KM";
            dgv.Columns[9].Width = 60;
            dgv.Columns[9].HeaderText = "KM";
            dgv.Columns[9].DataPropertyName = "Kilometraje";

            dgv.Columns[10].Name = "REMITENTE";
            dgv.Columns[10].Width = 140;
            dgv.Columns[10].HeaderText = "Remitente";
            dgv.Columns[10].DataPropertyName = "Clie_Razon_Social";

            dgv.Columns[11].Name = "PEDIDOPOR";
            dgv.Columns[11].Width = 140;
            dgv.Columns[11].HeaderText = "Pedido Por";
            dgv.Columns[11].DataPropertyName = "Contacto_Nombre";

            dgv.Columns[12].Name = "CANTIDAD_DETALLE";
            dgv.Columns[12].Width = 60;
            dgv.Columns[12].HeaderText = "Cantidad";
            dgv.Columns[12].DataPropertyName = "Cantidad_Detalle";

            dgv.Columns[13].Name = "PESO_DETALLE";
            dgv.Columns[13].Width = 60;
            dgv.Columns[13].HeaderText = "Peso";
            dgv.Columns[13].DataPropertyName = "Peso_Detalle";

            dgv.Columns[14].Name = "VOLUMEN_DETALLE";
            dgv.Columns[14].Width = 60;
            dgv.Columns[14].HeaderText = "Volumen";
            dgv.Columns[14].DataPropertyName = "Volumen_Detalle";

            dgv.Columns[15].Name = "LOCA_DETALLE";
            dgv.Columns[15].Width = 100;
            dgv.Columns[15].HeaderText = "Localidad";
            dgv.Columns[15].DataPropertyName = "Loca_Detalle";

            // Columnas que no Deben Verse

            dgv.Columns[16].Name = "RECO_IDE";
            dgv.Columns[16].DataPropertyName = "Reco_Ide";
            dgv.Columns[16].Visible = false;

            dgv.Columns[17].Name = "PROV_CARGA_IDE";
            dgv.Columns[17].DataPropertyName = "Prov_Carga_Ide";
            dgv.Columns[17].Visible = false;

            dgv.Columns[18].Name = "LOCA_IDE";
            dgv.Columns[18].DataPropertyName = "Loca_Ide";
            dgv.Columns[18].Visible = false;

            dgv.Columns[19].Name = "LOCA_CODIGO_POSTAL";
            dgv.Columns[19].DataPropertyName = "Loca_Codigo_Postal";
            dgv.Columns[19].Visible = false;

            dgv.Columns[20].Name = "PROV_CARGA_CONT_IDE";
            dgv.Columns[20].DataPropertyName = "Prov_Carga_Cont_Ide";
            dgv.Columns[20].Visible = false;

            dgv.Columns[21].Name = "TRAN_IDE";
            dgv.Columns[21].DataPropertyName = "Tran_Ide";
            dgv.Columns[21].Visible = false;

            dgv.Columns[22].Name = "TRAN_CHOF_IDE";
            dgv.Columns[22].DataPropertyName = "Tran_Chof_Ide";
            dgv.Columns[22].Visible = false;

            dgv.Columns[23].Name = "TRAN_VEHI_IDE";
            dgv.Columns[23].DataPropertyName = "Tran_Vehi_Ide";
            dgv.Columns[23].Visible = false;

            dgv.Columns[24].Name = "VEHI_CONFIGURACION";
            dgv.Columns[24].DataPropertyName = "Vehi_Configuracion";
            dgv.Columns[24].Visible = false;

            dgv.Columns[25].Name = "VEHI_TONELAJE";
            dgv.Columns[25].DataPropertyName = "Vehi_Tonelaje";
            dgv.Columns[25].Visible = false;

            dgv.Columns[26].Name = "VEHI_VOLUMEN";
            dgv.Columns[26].DataPropertyName = "Vehi_Volumen";
            dgv.Columns[26].Visible = false;

            dgv.Columns[27].Name = "TIPO_VEHI_NOMBRE";
            dgv.Columns[27].DataPropertyName = "Tipo_Vehi_Nombre";
            dgv.Columns[27].Visible = false;

            dgv.Columns[28].Name = "KMINICIAL";
            dgv.Columns[28].DataPropertyName = "Reco_Udometro_inicial";
            dgv.Columns[28].Visible = false;

            dgv.Columns[29].Name = "KMFINAL";
            dgv.Columns[29].DataPropertyName = "Reco_Udometro_Final";
            dgv.Columns[29].Visible = false;

            dgv.Columns[30].Name = "HSALIDA";
            dgv.Columns[30].DataPropertyName = "Reco_Hora_Salida";
            dgv.Columns[30].Visible = false;

            dgv.Columns[31].Name = "FRETORNO";
            dgv.Columns[31].DataPropertyName = "Reco_Fecha_Retorno";
            dgv.Columns[31].Visible = false;

            dgv.Columns[32].Name = "HRETORNO";
            dgv.Columns[32].DataPropertyName = "Reco_Hora_Retorno";
            dgv.Columns[32].Visible = false;

            dgv.Columns[33].Name = "RECO_REPARTO_DESTINATARIO";
            dgv.Columns[33].DataPropertyName = "Reco_reparto_Destinatario";
            dgv.Columns[33].Visible = false;

            dgv.Columns[34].Name = "RECO_TIPO";
            dgv.Columns[34].DataPropertyName = "Reco_Tipo";
            dgv.Columns[34].Visible = false;

            dgv.Columns[35].Name = "TIPO";
            dgv.Columns[35].DataPropertyName = "Tipo_Nombre";
            dgv.Columns[35].Visible = false;

            dgv.Columns[36].Name = "RECO_ESTADO";
            dgv.Columns[36].DataPropertyName = "Reco_Estado";
            dgv.Columns[36].Visible = false;

            dgv.Columns[37].Name = "LUGAR";
            dgv.Columns[37].DataPropertyName = "Reco_Lugar";
            dgv.Columns[37].Visible = false;

            dgv.Columns[38].Name = "PUNTOS_REPARTO";
            dgv.Columns[38].DataPropertyName = "Reco_Punto_Reparto";
            dgv.Columns[38].Visible = false;

            dgv.Columns[39].Name = "PAIS_NOMBRE";
            dgv.Columns[39].DataPropertyName = "Pais_Nombre";
            dgv.Columns[39].Visible = false;

            dgv.Columns[40].Name = "VECES";
            dgv.Columns[40].DataPropertyName = "Veces";
            dgv.Columns[40].Visible = false;

            dgv.Columns[41].Name = "lrc_ide";
            dgv.Columns[41].DataPropertyName = "Lrc_Ide";
            dgv.Columns[41].Visible = false;

            dgv.Columns[42].Name = "LUGAR_NOMBRE";
            dgv.Columns[42].DataPropertyName = "Lugar_Nombre";
            dgv.Columns[42].Visible = false;

            dgv.Columns[43].Name = "TIPO_VEHI_IDE";
            dgv.Columns[43].DataPropertyName = "Tipo_Vehi_Ide";
            dgv.Columns[43].Visible = false;

            dgv.Columns[44].Name = "ESTADO_DIGITADO";
            dgv.Columns[44].DataPropertyName = "RECO_ESTADO_DIGITACION";
            dgv.Columns[44].Visible = false;

            dgv.Columns[45].Name = "FACTURADO";
            dgv.Columns[45].DataPropertyName = "FACTURADO";
            dgv.Columns[45].Visible = false;

            dgv.Columns[46].Name = "LOCA_NOMBRE";
            dgv.Columns[46].DataPropertyName = "LOCA_NOMBRE";
            dgv.Columns[46].Visible = false;

            dgv.Columns[47].Name = "VOLUMEN";
            dgv.Columns[47].DataPropertyName = "VOLUMEN";
            dgv.Columns[47].Visible = false;

            dgv.Columns[48].Name = "CANTIDAD";
            dgv.Columns[48].DataPropertyName = "Reco_Numero_Item";
            dgv.Columns[48].Visible = false;

            dgv.Columns[49].Name = "DIRECCION";
            dgv.Columns[49].DataPropertyName = "Reco_Direccion";
            dgv.Columns[49].Visible = false;

        }

        private void dgvListado_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            procesar_filtro();
        }

        private void procesar_filtro()
        {
            switch (cboFiltro.Text)
            {
                case "Fecha": campo_busqueda = "Fecha_Emision";
                    condi_busqueda = txtFiltro.Text.Trim();
                    break;
                case "Conductor": campo_busqueda = "Chofer_Nombre";
                    condi_busqueda = txtFiltro.Text.Trim();
                    break;
                case "Numero": campo_busqueda = "Numero_Recojo";
                    condi_busqueda = txtFiltro.Text.Trim();
                    break;
                case "Pedido Por": campo_busqueda = "Contacto_Nombre";
                    condi_busqueda = txtFiltro.Text.Trim();
                    break;
                case "Remitente": campo_busqueda = "Clie_Razon_Social";
                    condi_busqueda = txtFiltro.Text.Trim();
                    break;
                case "Transportista": campo_busqueda = "Tran_Razon_Social";
                    condi_busqueda = txtFiltro.Text.Trim();
                    break;
                case "Vehiculo": campo_busqueda = "Tran_Vehi_Placa";
                    condi_busqueda = txtFiltro.Text.Trim();
                    break;
                case "Guia": campo_busqueda = "Tran_Vehi_Placa";
                    condi_busqueda = txtFiltro.Text.Trim();
                    break;
            }
            if  (rbtPorCerrar.Checked)
            {
                nEstado = 0;
            }
            if (rbtCerrado.Checked)
            {
                nEstado = 1;
            }
            if (rbtFacturado.Checked)
            {
                nEstado = 2;
            }
            if (rbtTodos.Checked)
            {
                nEstado = 3;
            }

            if (cboFiltro.Text == "Numero") nEstado = 3;
            
            Ejecutar_filtro(campo_busqueda, condi_busqueda, nEstado);
          
        }

        private void Ejecutar_filtro(string campo_busqueda, string condi_busqueda, Int32 Estado_Digitacion)
        {
            
            DataTable TEMP = new DataTable();
            ENResultOperation R = ClsRecojo_CabeceraBC.Listar_Filtro(campo_busqueda, condi_busqueda, Estado_Digitacion);
            if (R.Proceder) dgvListado.DataSource = (DataTable)R.Valor;
            this.OcultarColumnas();
            TEMP = (DataTable)R.Valor;
            lblTotal.Text = "Ordenes Visualizadas : " + Convert.ToString(dgvListado.Rows.Count);
            for (int row = 0; row <= dgvListado.Rows.Count - 1; row++)
            {
                if (this.dgvListado.Rows[row].Cells["FACTURADO"].Value.ToString() == "1")
                {
                    this.dgvListado.Rows[row].Cells["ESTADO_DIGITACION"].Value = Properties.Resources.bcortar;
                }
                else
                     if (this.dgvListado.Rows[row].Cells["ESTADO_DIGITADO"].Value.ToString() == "0")
                     {
                        this.dgvListado.Rows[row].Cells["ESTADO_DIGITACION"].Value = Properties.Resources.beditar;
                     }
                     else
                    {
                        this.dgvListado.Rows[row].Cells["ESTADO_DIGITACION"].Value = CapaPresentacion.Properties.Resources.disco;
                    }

            }
            if (dgvListado.Rows.Count == 0) 
            {
                if (nUnaVez != 0)
                {
                    MessageBox.Show("No se han encontrado Ordenes para ser visualizar", "Resultado de Busqueda de Ordenes segun criterio seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    nUnaVez = 1;
                }
            }
        }
        private void cboFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFiltro.Text = "";
            txtFiltro.Focus();
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFiltro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                procesar_filtro();
            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {
            
        }

        private void Mes_Actual()
        {
            DateTime Fecha_Hoy  = DateTime.Now;
            Int32 Mes_Actual = Fecha_Hoy.Month;
            cboMes.SelectedIndex = Mes_Actual - 1;
        }
        private void rbtMes_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtMes.Checked )
            {
                
                
                campo_busqueda = "Fecha_Mes";
                condi_busqueda = "";
                
                string nromes = convert_mes(cboMes.Text);
                condi_busqueda = "01/" + nromes + "/" + nroanno.Value.ToString();

                Ejecutar_filtro(campo_busqueda, condi_busqueda, nEstado);
                rbtMes.Checked = false;

            }
        }

        private void rbtPorCerrar_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtPorCerrar.Checked)
            {
                nEstado = 0;
                procesar_filtro();
            }

        }

        private void rbtCerrado_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtCerrado.Checked)
            {
                nEstado = 1;
                procesar_filtro();
            }
        }

        private void rbtFacturado_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtFacturado.Checked)
            {
                nEstado = 2;
                procesar_filtro();
            }
        }

        private void rbtTodos_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtTodos.Checked)
            {
                nEstado = 3;
                procesar_filtro();
            }
        }


        private static string convert_mes(string titmes)
        {
            switch (titmes)
            {
                case "Enero":    return "01"; 
                case "Febrero":  return "02"; 
                case "Marzo":    return "03"; 
                case "Abril":    return "04"; 
                case "Mayo":     return "05"; 
                case "Junio":    return "06"; 
                case "Julio":    return "07"; 
                case "Agosto":    return "08"; 
                case "Setiembre": return "09"; 
                case "Octubre":  return "10"; 
                case "Noviembre": return "11";
                case "Diciembre": return "12";
            }
            return "";
        }

        private void rbtAnno_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtAnno.Checked)
            {


                campo_busqueda = "Fecha_Anno";
                condi_busqueda = "";

                string nromes = convert_mes(cboMes.Text);
                condi_busqueda = "01/" + nromes + "/" + nroanno.Value.ToString();

                Ejecutar_filtro(campo_busqueda, condi_busqueda, nEstado);
                rbtAnno.Checked = false;

            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (btnCancelar.Enabled == true)
            {
                tabControl1.SelectedIndex = 1;
            }
            else
            {
            Mostrar_DgvListado();
            Habilitar_Campos_Cabecera(false);
            }

            if (PanelDetalle.Visible) tabControl1.SelectedIndex = 1;
        }

        private void Mostrar_DgvListado()
        {
            

            if (this.dgvListado.CurrentRow != null)
            {
                nReco_Ide = Convert.ToInt32(this.dgvListado.CurrentRow.Cells["RECO_IDE"].Value);
                cboSerieRecojo.Text = Convert.ToString(this.dgvListado.CurrentRow.Cells["SERIE"].Value);
                txtNumero.Text = Convert.ToString(this.dgvListado.CurrentRow.Cells["NUMERO"].Value);
                dtpFEmision.Text = Convert.ToString(this.dgvListado.CurrentRow.Cells["FEMISION"].Value);
                dtpFTraslado.Text = Convert.ToString(this.dgvListado.CurrentRow.Cells["FEMISION"].Value);

                txtClie_Ide.Text = Convert.ToString(this.dgvListado.CurrentRow.Cells["PROV_CARGA_IDE"].Value);
                txtRemitente.Text = Convert.ToString(this.dgvListado.CurrentRow.Cells["REMITENTE"].Value);
                txtTran_Ide.Text = Convert.ToString(this.dgvListado.CurrentRow.Cells["TRAN_IDE"].Value);
                txtTransportista.Text = Convert.ToString(this.dgvListado.CurrentRow.Cells["TRANSPORTISTA"].Value);
                txtHoraSalida.Text = Convert.ToString(this.dgvListado.CurrentRow.Cells["HSALIDA"].Value);
                dtpFRetorno.Text = Convert.ToString(this.dgvListado.CurrentRow.Cells["FRETORNO"].Value);
                txtHoraRetorno.Text = Convert.ToString(this.dgvListado.CurrentRow.Cells["HRETORNO"].Value);

                txtKmInicial.Text = Convert.ToString(this.dgvListado.CurrentRow.Cells["KMINICIAL"].Value);
                txtKmFinal.Text = Convert.ToString(this.dgvListado.CurrentRow.Cells["KMFINAL"].Value);
                txtPtosReparto.Text = Convert.ToString(this.dgvListado.CurrentRow.Cells["PUNTOS_REPARTO"].Value);
                txtLoca_Ide.Text = Convert.ToString(this.dgvListado.CurrentRow.Cells["LOCA_IDE"].Value);
                txtTipo.Text = Convert.ToString(this.dgvListado.CurrentRow.Cells["TIPO_VEHI_NOMBRE"].Value);

                txtDireccion.Text = Convert.ToString(this.dgvListado.CurrentRow.Cells["DIRECCION"].Value);
                //txtLoca_Ide.Text = Convert.ToString(this.dgvListado.CurrentRow.Cells["LOCA_CODIGO_POSTAL"].Value);
                txtContacto_Ide.Text = Convert.ToString(this.dgvListado.CurrentRow.Cells["PROV_CARGA_CONT_IDE"].Value);
                txtPedidoPor.Text = Convert.ToString(this.dgvListado.CurrentRow.Cells["PEDIDOPOR"].Value);

                txtLocaDistrito.Text = Convert.ToString(this.dgvListado.CurrentRow.Cells["LOCA_NOMBRE"].Value);
                txtLocaPais.Text = Convert.ToString(this.dgvListado.CurrentRow.Cells["PAIS_NOMBRE"].Value);
                txtChof_Ide.Text = Convert.ToString(this.dgvListado.CurrentRow.Cells["TRAN_CHOF_IDE"].Value);
                txtConductor.Text = Convert.ToString(this.dgvListado.CurrentRow.Cells["CHOFER_NOMBRE"].Value);

                txtTnVol.Text = Convert.ToString(this.dgvListado.CurrentRow.Cells["VEHI_TONELAJE"].Value) + "/" +
                                Convert.ToString(this.dgvListado.CurrentRow.Cells["VEHI_VOLUMEN"].Value);

                txtVehi_Ide.Text = Convert.ToString(this.dgvListado.CurrentRow.Cells["TRAN_VEHI_IDE"].Value);
                txtVehiculo.Text = Convert.ToString(this.dgvListado.CurrentRow.Cells["VEHICULO"].Value);

                txtPeso.Text = Convert.ToString(this.dgvListado.CurrentRow.Cells["PESO"].Value);
                txtVolumen.Text = Convert.ToString(this.dgvListado.CurrentRow.Cells["VOLUMEN"].Value);

                if (string.IsNullOrEmpty(txtVolumen.Text))
                {
                    txtVolumen.Text = "0";
                }
                
                cboLugar.Text = Convert.ToString(this.dgvListado.CurrentRow.Cells["LUGAR_NOMBRE"].Value);
                txtTipo_Ide.Text = Convert.ToString(this.dgvListado.CurrentRow.Cells["TIPO_VEHI_IDE"].Value);
                //cboTipo.SelectedIndex = Convert.ToInt32(this.dgvListado.CurrentRow.Cells["RECO_TIPO"].Value.ToString());

                txtLocaPais.Enabled = false;
                //txtLocaDistrito.Enabled = false;
                txtLocaPais.Enabled = false;
                nVeces = Convert.ToInt32(this.dgvListado.CurrentRow.Cells["VECES"].Value.ToString());
                nEstado_Digitacion = Convert.ToInt32(this.dgvListado.CurrentRow.Cells["ESTADO_DIGITADO"].Value);
                cEstado = Convert.ToString(this.dgvListado.CurrentRow.Cells["RECO_ESTADO"].Value);
                nFacturado = Convert.ToInt32(this.dgvListado.CurrentRow.Cells["FACTURADO"].Value.ToString());

                Mostrar_dgv_Detalles(nReco_Ide);
                /*
                Mostrar_Detalle(nReco_Ide);
                Mostrar_Peaje(nReco_Ide);
                Mostrar_Gasto(nReco_Ide);
                Mostrar_Combustible(nReco_Ide);
                Mostrar_Nota(nReco_Ide);
                Mostrar_Ayudante(nReco_Ide);
                Mostrar_PuntoReparto(nReco_Ide);
                Mostrar_Recargo(nReco_Ide);
                Mostrar_Apoyo(nReco_Ide);
               */
            }
        }

        private void Habilitar_Campos_Cabecera(Boolean Flag)
        {
            cboSerieRecojo.Enabled = Flag;
            txtNumero.ReadOnly = !Flag;
            dtpFEmision.Enabled = Flag;
            dtpFTraslado.Enabled = Flag;

            txtClie_Ide.ReadOnly = !Flag;
            txtRemitente.ReadOnly = !Flag;
            txtTran_Ide.ReadOnly = !Flag;
            txtTransportista.ReadOnly = !Flag;
            txtHoraSalida.ReadOnly = !Flag;
            dtpFRetorno.Enabled = Flag;
            txtHoraRetorno.ReadOnly = !Flag;

            txtKmInicial.ReadOnly = !Flag;
            txtKmFinal.ReadOnly = !Flag;
            txtPtosReparto.ReadOnly = !Flag;
            txtLoca_Ide.ReadOnly = !Flag;
            txtTipo.ReadOnly = !Flag;

            txtDireccion.ReadOnly = !Flag;
            txtLoca_Ide.ReadOnly = !Flag;
            txtContacto_Ide.ReadOnly = !Flag;
            txtPedidoPor.ReadOnly = !Flag;

            txtLocaDistrito.ReadOnly = !Flag;
            txtLocaPais.ReadOnly = !Flag;
            txtChof_Ide.ReadOnly = !Flag;
            txtConductor.ReadOnly = !Flag;

            txtTnVol.ReadOnly = !Flag;

            txtVehi_Ide.ReadOnly = !Flag;
            txtVehiculo.ReadOnly = !Flag;

            txtPeso.ReadOnly = !Flag;
            txtVolumen.ReadOnly = !Flag;

            cboLugar.Enabled = Flag;
            txtTipo_Ide.ReadOnly = !Flag;
            cboTipo.Enabled = Flag;

        }

        private void Mostrar_dgv_Detalles(Int32 nroReco_Ide)
        {
            Mostrar_Detalle(nroReco_Ide);
            Mostrar_Peaje(nroReco_Ide);
            Mostrar_Gasto(nroReco_Ide);
            Mostrar_Combustible(nroReco_Ide);
            Mostrar_Nota(nroReco_Ide);
            Mostrar_Ayudante(nroReco_Ide);
            Mostrar_PuntoReparto(nroReco_Ide);
            Mostrar_Recargo(nroReco_Ide);
            Mostrar_Apoyo(nroReco_Ide);
        }
        private void Cargar_Serie_Recojo()
        {
            ENResultOperation R = ClsSerie_Orden_RecojoBC.Listar("");
            if (R.Proceder) cboSerieRecojo.DataSource = (DataTable)R.Valor;
            cboSerieRecojo.DisplayMember = "SERIE_NUMERO";
            cboSerieRecojo.ValueMember   = "SERIE_NUMERO";
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectedIndex = 0;
        }

        private void LimpiaCamposCabecera()
        {
            tabControl1.SelectedIndex = 1;
            cboSerieRecojo.SelectedIndex = 0;
            txtNumero.Text = "0";
            txtClie_Ide.Text = "";
            txtContacto_Ide.Text = "";
            txtNumero.Enabled = false;
            txtHojaRuta.Text = String.Empty;
            txtHojaRuta.Enabled = false;
            txtFactura.Text = String.Empty;
            txtFactura.Enabled = false;

            dtpFEmision.Text = DateTime.Now.ToString();
            dtpFTraslado.Text = DateTime.Now.ToString();
            dtpFRetorno.Text = DateTime.Now.ToString();

            txtHoraSalida.Text = "00:00:00";
            txtHoraRetorno.Text = "00:00:00";

            txtRemitente.Text = String.Empty;
            txtTransportista.Text = String.Empty;
            txtKmInicial.Text = "0";
            txtKmFinal.Text = "0";
            txtPtosReparto.Text = "0";
            txtLoca_Ide.Text = String.Empty;
            txtLoca_Ide.Enabled = false;
            txtTipo.Text = String.Empty;
            txtDireccion.Text = String.Empty;
            txtLoca_Ide.Text = String.Empty;
            txtPedidoPor.Text = String.Empty;
            txtLocaDistrito.Text = String.Empty;
            txtLocaPais.Text = String.Empty;
            txtLocaPais.Enabled = false;
            txtTran_Ide.Text = string.Empty;
            txtChof_Ide.Text = string.Empty;
            txtVehi_Ide.Text = string.Empty;
            txtTipo_Ide.Text = string.Empty;
            txtConductor.Text = String.Empty;
            txtTnVol.Text = "0";
            txtVehiculo.Text = String.Empty;
            txtPeso.Text = "0";
            txtVolumen.Text = "0";
            txtTransportista.Text = "TERAH";
            txtTran_Ide.Text = "2564";
            txtRemitente.Focus();
            cboRptoDestinatario.SelectedIndex = 1;
            cboLugar.SelectedIndex = 0;
            cboTipo.SelectedIndex = 2;

        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Operacion = "N";
            Flag_Botones_Cabecera(false, false, false, false, true, true, false, false);
            LimpiaCamposCabecera();
            nVeces = 0;
            cEstado = "1";
            nEstado_Digitacion = 0;
            Habilitar_Campos_Cabecera(true);
            Mostrar_dgv_Detalles(0);
        }

        private void txtRemitente_Enter(object sender, EventArgs e)
        {
        }

        private void txtRemitente_Leave(object sender, EventArgs e)
        {
        }

        private void txtRemitente_DoubleClick(object sender, EventArgs e)
        {
            Buscar_Cliente();
        }

        private void txtRemitente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3)
            {
                Buscar_Cliente();
            }
        }

        private void txtRemitente_KeyPress(object sender, KeyPressEventArgs e)
        {

            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                if (!string.IsNullOrEmpty(txtRemitente.Text))
                {
                    ENResultOperation R = ClsClientesBC.Listar_Nombre(txtRemitente.Text);
                    if (R.Proceder)
                    {
                        DataTable dt = (DataTable)R.Valor;
                        if (dt.Rows.Count == 1)
                        {
                        DataRow ROW = dt.Rows[0];
                        txtClie_Ide.Text = ROW["CLIE_IDE"].ToString();
                        txtRemitente.Text = ROW["CLIE_RAZON_SOCIAL"].ToString();
                            if (string.IsNullOrEmpty(txtDireccion.Text))
                            {
                                Buscar_Punto_Partida();
                            }
                            else
                            {
                             txtDireccion.Focus();
                            }
                        }
                        else
                        {
                            Buscar_Cliente();
                        }

                    }
                    else
                    {
                        Buscar_Cliente();
                    }
                }
                else
                {
                    Buscar_Cliente();
                }
            }
        }

        private void Buscar_Cliente()
        {
            //Clientes.frmClienteBuscarxNombre frmBuscarCliente = new Clientes.frmClienteBuscarxNombre();
            Clientes.frmClientesBuscar frmBuscarCliente = new Clientes.frmClientesBuscar();
            frmBuscarCliente.Cliente_Razon = txtRemitente.Text;
            frmBuscarCliente.ShowDialog();
            
            //if (!string.IsNullOrEmpty(frmBuscarCliente.cNombre))
            if (!string.IsNullOrEmpty(frmBuscarCliente.Cliente_Razon))
            {
                txtRemitente.Text = frmBuscarCliente.Cliente_Razon; //.cNombre;
                txtClie_Ide.Text  = Convert.ToString(frmBuscarCliente.Clie_Ide); //.nClie_Ide.ToString();
                //Buscar_Punto_Partida();
                txtDireccion.Focus();
            }
            /*
                txtClie_Ide.Text = frmBuscarCliente.Clie_Ide.ToString();
                txtDireccion.Text = frmBuscarCliente.Cliente_Direccion;
                txtLoca_Ide.Text = frmBuscarCliente.Cliente_localidad;
                Obtener_Descripcion_Localidad(txtLoca_Ide.Text);
            }
            */
        }

        private void Buscar_Punto_Partida()
        {
            if (!string.IsNullOrEmpty(txtClie_Ide.Text))
            {
                Clientes.frmCliente_PuntoPartida_Buscar FrmPtoPartida = new Clientes.frmCliente_PuntoPartida_Buscar();
                FrmPtoPartida.Clie_Ide = Convert.ToInt32(txtClie_Ide.Text);
                FrmPtoPartida.Clie_Razon_Social = txtRemitente.Text;
                FrmPtoPartida.ShowDialog();
                if (!string.IsNullOrEmpty(FrmPtoPartida.Direccion_Punto_Partida))
                {
                    txtDireccion.Text = FrmPtoPartida.Direccion_Punto_Partida;
                    txtLoca_Ide.Text = FrmPtoPartida.Loca_Punto_Partida;
                    txtPPartida_Ide.Text = FrmPtoPartida.Punto_Partida_Ide;
                    Obtener_Descripcion_Localidad(txtLoca_Ide.Text);
                    Buscar_Pedido_Por();
                }
            }
        }
        private void txtLocaDistrito_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3)
            {
                Buscar_Localidad();
            }
        }

        private void txtLocaDistrito_KeyPress(object sender, KeyPressEventArgs e)
        {
             if ((int)e.KeyChar == (int)Keys.Enter)
             {
                 txtPedidoPor.Focus();
             }
        }

        private void Buscar_Localidad()
        {
            Tablas.frmBuscarLocalidad frmlocal = new Tablas.frmBuscarLocalidad();
            frmlocal.ShowDialog();
            txtLoca_Ide.Text = frmlocal.Loca_Ide;
            Obtener_Descripcion_Localidad(txtLoca_Ide.Text);
        }

        private void Buscar_Pedido_Por()
        {
            if (!string.IsNullOrEmpty(txtClie_Ide.Text))
            {
                Clientes.frmCliente_Contacto_Buscar frmContacto_Buscar = new Clientes.frmCliente_Contacto_Buscar();
                frmContacto_Buscar.Clie_Ide = Convert.ToInt32(txtClie_Ide.Text);
                frmContacto_Buscar.Clie_Nombre = txtRemitente.Text;
                frmContacto_Buscar.ShowDialog();
                txtPedidoPor.Text = frmContacto_Buscar.Clie_Contacto;
                txtContacto_Ide.Text = frmContacto_Buscar.Contacto_Ide;
                txtTransportista.Focus();
            }
        }

        private void txtPedidoPor_Validated(object sender, EventArgs e)
        {
            txtTransportista.Focus();
        }
        private void Obtener_Descripcion_Localidad(string Localidad_ide)
        {
            if (!String.IsNullOrEmpty(Localidad_ide))
            {
                ENResultOperation R = ClsLocalidadBC.Listar_Filtro("", Convert.ToInt32(Localidad_ide));
                if (R.Proceder)
                {
                    DataTable dt = (DataTable)R.Valor;
                    DataRow ROW = dt.Rows[0];
                    txtLocaDistrito.Text = ROW["LOCA_NOMBRE"].ToString();
                    string Pais_ide = ROW["PAIS_IDE"].ToString();
                    ENResultOperation L = ClsPaisBC.Listar_Filtro("", Convert.ToInt32(Pais_ide));
                    dt.Clear();
                    dt = (DataTable)L.Valor;
                    DataRow row = dt.Rows[0];
                    txtLocaPais.Text = row["PAIS_NOMBRE"].ToString();
                }
            }
                      
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Buscar_Cliente();
        }

        private void txtRemitente_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDireccion_DoubleClick(object sender, EventArgs e)
        {
            Buscar_Punto_Partida();

        }

        private void txtDireccion_Enter(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDireccion.Text))
            {
                Buscar_Punto_Partida();
            }
        }
        private void txtDireccion_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3)
            {
                Buscar_Punto_Partida();
            }

        }
        private void txtDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
               // if (!String.IsNullOrEmpty(txtDireccion.Text) && !String.IsNullOrEmpty(txtPPartida_Ide.Text))
               // {
               //     ENResultOperation R = ClsCliente_Punto_PartidaBC.Encontrar(Convert.ToInt32(txtClie_Ide.Text), Convert.ToInt32(txtPPartida_Ide.Text));
               //     if (R.Proceder)
               //     {
               //         DataTable dt = (DataTable)R.Valor;
               //         DataRow ROW = dt.Rows[0];
               //         txtDireccion.Text = ROW["PROV_PART_DIRECCION"].ToString();
               //         txtLoca_Ide.Text = ROW["LOCA_IDE"].ToString();
               //         Obtener_Descripcion_Localidad(txtLoca_Ide.Text);
               //         txtPedidoPor.Focus();
               //     }
               // }
                txtLocaDistrito.Focus();
            }
        }
        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtPedidoPor_DoubleClick(object sender, EventArgs e)
        {
            Buscar_Pedido_Por();
        }

        private void txtPedidoPor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3)
            {
                Buscar_Pedido_Por();
            }
        }

        private void txtPedidoPor_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtTransportista.Focus();
        }


        private void txtTran_Ide_Buscar()
        {

        }
        private void Buscar_Transportista()
        {
            Transportista.frmTransportista_Buscar frmTransportista_Buscar = new Transportista.frmTransportista_Buscar();
            frmTransportista_Buscar.TransportistaRazon = txtTransportista.Text;
            frmTransportista_Buscar.ShowDialog();
            txtTransportista.Text = frmTransportista_Buscar.TransportistaRazon;
            txtTran_Ide.Text = frmTransportista_Buscar.TransportistaID;
            if (String.IsNullOrEmpty(txtConductor.Text)) 
            {
            Buscar_Conductor();
            btnGrabar.Focus();
            }

        }

        private void Buscar_Conductor()
        {
            Transportista.frmTransportista_Chofer_Buscar frmChoferes_Buscar = new Transportista.frmTransportista_Chofer_Buscar();
            frmChoferes_Buscar.Transportista_Ide = Convert.ToInt32(txtTran_Ide.Text);
            frmChoferes_Buscar.Transportista_Nombre = txtTransportista.Text;
            frmChoferes_Buscar.ShowDialog();
            txtConductor.Text = frmChoferes_Buscar.Chofer_Nombre;
            txtChof_Ide.Text = frmChoferes_Buscar.Chofer_Ide;
            if (String.IsNullOrEmpty(txtVehiculo.Text))
            {
                Buscar_Vehiculo();
            }
        }

        private void Buscar_Vehiculo()
        {
            Transportista.frmTransportista_Vehiculo_Buscar frmVehiculo_Buscar = new Transportista.frmTransportista_Vehiculo_Buscar();
            frmVehiculo_Buscar.Transportista_Ide = Convert.ToInt32(txtTran_Ide.Text);
            frmVehiculo_Buscar.Transportista_Nombre = txtTransportista.Text;
            frmVehiculo_Buscar.ShowDialog();
            txtVehiculo.Text = frmVehiculo_Buscar.Vehiculo_Placa;
            txtTipo.Text = frmVehiculo_Buscar.Tipo_Vehiculo;
            txtTnVol.Text = frmVehiculo_Buscar.Vehiculo_Tonelaje.ToString() + '/' + frmVehiculo_Buscar.Vehiculo_Volumen.ToString();
            txtPeso.Text = frmVehiculo_Buscar.Vehiculo_Tonelaje.ToString();
            txtVolumen.Text = frmVehiculo_Buscar.Vehiculo_Volumen.ToString();
            txtVehi_Ide.Text = frmVehiculo_Buscar.Vehiculo_Ide;
            txtTipo_Ide.Text = frmVehiculo_Buscar.Tipo_Ide;
            cTipoCombustible = frmVehiculo_Buscar.Tipo_Combustible;
            nTipoCombustible = 2;
            if (cTipoCombustible == "Gas") nTipoCombustible = 0;
            if (cTipoCombustible == "Gasolina") nTipoCombustible = 1;
            if (cTipoCombustible == "Petroleo") nTipoCombustible = 0;
            btnGrabar.Focus();
        }

        private void txtTransportista_DoubleClick(object sender, EventArgs e)
        {
            Buscar_Transportista();            
        }

        private void txtConductor_DoubleClick(object sender, EventArgs e)
        {
            Buscar_Conductor();
        }
        private void txtConductor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3) 
            {
                Buscar_Conductor();
            }

            if (e.KeyCode == Keys.Enter)
            {
                if (String.IsNullOrEmpty(txtConductor.Text))
                {
                    Buscar_Conductor();
                }
                else
                {
                    txtVehiculo.Focus();
                }
            }

        }

        private void txtConductor_Enter(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtConductor.Text))
            {
                Buscar_Conductor();
            }
        }

        private void txtVehiculo_Enter(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtVehiculo.Text))
            {
                Buscar_Vehiculo();
            }
        }

        private void txtVehiculo_DoubleClick(object sender, EventArgs e)
        {
            Buscar_Vehiculo();
        }

        private void txtVehiculo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3)
            {
                Buscar_Vehiculo();
            }

            if (e.KeyCode == Keys.Enter)
            {
                if (String.IsNullOrEmpty(txtVehiculo.Text))
                {
                    Buscar_Vehiculo();
                }
                else
                {
                    btnGrabar.Focus();
                }
            }
        }


        private void Procesar_Operacion()
        {
            clsRecojo_CabeceraBE TipoBE = new clsRecojo_CabeceraBE();
            TipoBE.Reco_ide = nReco_Ide;
            TipoBE.Serie_numero_recojo = cboSerieRecojo.Text;
            TipoBE.Reco_numero_recojo =  Convert.ToInt32(txtNumero.Text);
            TipoBE.Reco_fecha_emision  = Convert.ToDateTime(dtpFEmision.Value.ToString("dd/MM/yyyy")); //dateTimePicker1.Value.ToString("MM/dd/yyyy")
            TipoBE.Reco_fecha_traslado = Convert.ToDateTime(dtpFTraslado.Value.ToString("dd/MM/yyyy"));

            //TipoBE.Reco_fecha_emision = DateTime.Parse(dtpFEmision.Text);
            //TipoBE.Reco_fecha_traslado = DateTime.Parse(dtpFTraslado.Text);

            TipoBE.Prov_carga_ide =  Convert.ToInt32(txtClie_Ide.Text);
            TipoBE.Reco_direccion = txtDireccion.Text;
            TipoBE.Loca_ide = Convert.ToInt32(txtLoca_Ide.Text);
            TipoBE.Prov_carga_cont_ide = Convert.ToInt32(txtContacto_Ide.Text);
            TipoBE.Tran_ide = Convert.ToInt32(txtTran_Ide.Text);
            TipoBE.Tran_chof_ide = Convert.ToInt32(txtChof_Ide.Text);
            TipoBE.Tran_vehi_ide = Convert.ToInt32(txtVehi_Ide.Text);
            TipoBE.Reco_tonelaje = Convert.ToInt32(txtPeso.Text);
            TipoBE.Reco_volumen = Convert.ToInt32(txtVolumen.Text);
            TipoBE.Reco_udometro_inicial = Convert.ToInt32(txtKmInicial.Text);
            TipoBE.Reco_udometro_final = Convert.ToInt32(txtKmFinal.Text);
            TipoBE.Reco_hora_salida = txtHoraSalida.Text;
            TipoBE.Reco_fecha_retorno = Convert.ToDateTime(dtpFRetorno.Text);
            TipoBE.Reco_hora_retorno = txtHoraRetorno.Text;
            TipoBE.Reco_reparto_destinatario = Convert.ToByte(cboRptoDestinatario.SelectedIndex);
            TipoBE.Reco_tipo =  Convert.ToInt32(cboTipo.SelectedIndex);
            TipoBE.Reco_estado = cEstado;
            TipoBE.Reco_numero_item = 0;
            TipoBE.Reco_estado_digitacion = nEstado_Digitacion;
            TipoBE.Reco_lugar = Convert.ToInt32(cboLugar.SelectedIndex);
            TipoBE.Reco_punto_reparto = Convert.ToInt32(txtPtosReparto.Text);
            TipoBE.Veces = nVeces;
            TipoBE.Usuario = VarGlobales.NombreUsuario;
            TipoBE.Lrc_ide = 0;

            switch (Operacion)
            {
                case "N": 
                   ENResultOperation R = ClsRecojo_CabeceraBC.Crear(TipoBE);
                   if (R.Proceder)
                   {
                       nReco_Ide = R.Ide;
                       string NroSer = cboSerieRecojo.Text;
                       ClsSerie_Orden_RecojoBE TipSerBE = new ClsSerie_Orden_RecojoBE();
                       ENResultOperation S = ClsSerie_Orden_RecojoBC.Listar_Filtro(NroSer);   
                       if (S.Proceder)
                       {
                           DataTable dt = (DataTable)S.Valor;
                           DataRow ROW = dt.Rows[0];
                           txtNumero.Text = ROW["SERIE_CONTADOR"].ToString();
                           Obtener_Ide_Cabecera();
                       }
                   }  
                    break;
                case "M": ClsRecojo_CabeceraBC.Actualizar(TipoBE);
                    break;
                case "E": ClsRecojo_CabeceraBC.Eliminar(TipoBE);
                    break;
            }

            this.tabControl1.SelectedIndex = 0;
            Flag_Botones_Cabecera(true, true, true, true, false, false, true, true);
            Mostrar(cFiltro);
            Habilitar_Campos_Cabecera(false);
        }

        private Boolean Verifica_Datos_Cabecera()
        {
            if (String.IsNullOrEmpty(txtRemitente.Text)) return false;
            if (String.IsNullOrEmpty(txtDireccion.Text)) return false;
            if (String.IsNullOrEmpty(txtPedidoPor.Text)) return false;
            if (String.IsNullOrEmpty(txtTransportista.Text)) return false;
            if (String.IsNullOrEmpty(txtVehiculo.Text)) return false;
            if (String.IsNullOrEmpty(txtConductor.Text)) return false;
            if (String.IsNullOrEmpty(txtTipo.Text)) return false;
            return true;
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (Verifica_Datos_Cabecera())
            {
                Procesar_Operacion();
                if (Operacion == "N") Nuevo_Detalle();
            }
            else
            {
                MessageBox.Show("Existen Campos Obligatorios que no se Han Ingresado.. !!");
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtClie_Ide.Text))
            {
                switch (cEstado)
                {
                    case "0": MessageBox.Show("No es Posible Actualizar Orden. Ya esta Anulado"); break;
                    case "1": Operacion = "M"; tabControl1.SelectedIndex = 1; Flag_Botones_Cabecera(false, false, false, false, true, true, false, false); txtRemitente.Focus(); Habilitar_Campos_Cabecera(true);
                        break;
                    case "2": MessageBox.Show("No es Posible Actualizar Orden. Ya esta Facturado"); break;
                }
            }
            else
            {
                MessageBox.Show("No Se ha Seleccionado Orden Para Modificar... ");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtClie_Ide.Text))
            {
                Operacion = "E";
                tabControl1.SelectedIndex = 1;
                Flag_Botones_Cabecera(false, false, false, false, true, true, false, false);
            }
            else
            {
                MessageBox.Show("No Se ha Seleccionado Orden Para Eliminar... ");
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Flag_Botones_Cabecera(true, true, true, true, false, false, true, true);
            LimpiaCamposCabecera();
            tabControl1.SelectedIndex = 0;
            Mostrar(cFiltro);
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {

            string mDiaMes = "01/" + cboMes.Text + "/" + nroanno.Value.ToString();
            DateTime fecha1 = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            DateTime fecha2 = fecha1.AddMonths(1).AddTicks(-1);
            Reportes.rptOrdenesRecojo frmrpt = new Reportes.rptOrdenesRecojo();
            frmrpt.fecha1 = fecha1;
            frmrpt.fecha2 = fecha2;
            frmrpt.RangoFecha = "Del : " + fecha1.ToShortDateString() + " Al : " + fecha2.ToShortDateString();
            frmrpt.Empresa = "TERAH S.A.C";
            frmrpt.Titulo = "REPORTE DE ORDENES DE RECOJO " + "Del : " + fecha1.ToShortDateString() + " Al : " + fecha2.ToShortDateString();
            frmrpt.ShowDialog();
        }

        private void txtClie_Ide_DoubleClick(object sender, EventArgs e)
        {
            Buscar_Cliente();
        }

        private void txtPPartida_Ide_DoubleClick(object sender, EventArgs e)
        {
            Buscar_Punto_Partida();
        }

        private void txtContacto_Ide_DoubleClick(object sender, EventArgs e)
        {
            Buscar_Pedido_Por();
        }

        private void txtClie_Ide_Validated(object sender, EventArgs e)
        {
            Validar_TxtClie_Ide();
        }

        private void txtClie_Ide_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                Validar_TxtClie_Ide();
            }
        }

        private void Validar_TxtClie_Ide()
        {
            if (!String.IsNullOrEmpty(txtClie_Ide.Text))
            {
                ENResultOperation R = ClsClientesBC.Consultar_Ide(Convert.ToInt32(txtClie_Ide.Text));
                if (R.Proceder)
                {
                    DataTable dt = (DataTable)R.Valor;
                    DataRow ROW = dt.Rows[0];
                    txtRemitente.Text = ROW["CLIE_RAZON_SOCIAL"].ToString();
                    txtDireccion.Text = ROW["CLIE_DIRECCION"].ToString();
                    txtLoca_Ide.Text = ROW["LOCA_IDE"].ToString();
                    Obtener_Descripcion_Localidad(txtLoca_Ide.Text);
                }
                else
                {
                    MessageBox.Show("Remitente No Encontrado... Reintente");
                    txtClie_Ide.Focus();
                }
            }
        }

        private void Validar_TxtContacto_Ide()
        {
            if (!String.IsNullOrEmpty(txtClie_Ide.Text) && !String.IsNullOrEmpty(txtContacto_Ide.Text))
            {
                ENResultOperation R = ClsCliente_ContactoBC.Consultar_Ide(Convert.ToInt32(txtClie_Ide.Text), Convert.ToInt32(txtContacto_Ide.Text));
                if (R.Proceder)
                {
                    DataTable dt = (DataTable)R.Valor;
                    DataRow ROW = dt.Rows[0];
                    txtPedidoPor.Text = ROW["CLIE_CONT_TITULO"].ToString();
                    txtPedidoPor.Text += ' ' + ROW["CLIE_CONT_PATERNO"].ToString();
                    txtPedidoPor.Text += ' ' + ROW["CLIE_CONT_MATERNO"].ToString();
                    txtPedidoPor.Text += ' ' + ROW["CLIE_CONT_NOMBRE"].ToString();
                }
                else
                {
                    MessageBox.Show("Contacto No Encontrado... Reintente");
                    txtContacto_Ide.Focus();
                }
            }
        }

        private void txtContacto_Ide_Validated(object sender, EventArgs e)
        {
            Validar_TxtContacto_Ide();
        }

        private void txtContacto_Ide_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                Validar_TxtContacto_Ide();
            }
        }

        private void txtTran_Ide_DoubleClick(object sender, EventArgs e)
        {
            Buscar_Transportista();
        }

        private void txtChof_Ide_DoubleClick(object sender, EventArgs e)
        {
            Buscar_Conductor();
        }

        private void txtVehi_Ide_DoubleClick(object sender, EventArgs e)
        {
            Buscar_Vehiculo();
        }

        private void txtTipo_Ide_DoubleClick(object sender, EventArgs e)
        {

        }

        private void txtTipo_Ide_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtTran_Ide_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                Validar_txtTran_Ide();
            }
        }

        private void txtChof_Ide_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                Validar_txtChof_Ide();
            }

        }

        private void txtVehi_Ide_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                //Validar_txtChof_Ide();
            }
        }

        private void txtTransportista_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTran_Ide_Validated(object sender, EventArgs e)
        {
            Validar_txtTran_Ide();
        }

        private void Validar_txtTran_Ide()
        {
            if (!String.IsNullOrEmpty(txtTran_Ide.Text))
            {
                ENResultOperation R = ClsTransportistaBC.Consultar_Ide(Convert.ToInt32(txtTran_Ide.Text));
                if (R.Proceder)
                {
                    DataTable dt = (DataTable)R.Valor;
                    DataRow ROW = dt.Rows[0];
                    txtTransportista.Text = ROW["TRAN_RAZON_SOCIAL"].ToString();
                }
                else
                {
                    MessageBox.Show("Transportista No Encontrado... Reintente");
                    txtTran_Ide.Focus();
                }
            }
        }

        private void Validar_txtChof_Ide()
        {
            if (!String.IsNullOrEmpty(txtChof_Ide.Text))
            {
                ENResultOperation R = ClsTransportista_ChoferBC.Consultar_Ide(Convert.ToInt32(txtTran_Ide.Text), Convert.ToInt32(txtChof_Ide.Text));
                if (R.Proceder)
                {
                    DataTable dt = (DataTable)R.Valor;
                    DataRow ROW = dt.Rows[0];
                    txtConductor.Text  = ROW["TRAN_CHOF_TITULO"].ToString();
                    txtConductor.Text += ' ' + ROW["TRAN_CHOF_PATERNO"].ToString();
                    txtConductor.Text += ' ' + ROW["TRAN_CHOF_MATERNO"].ToString();
                    txtConductor.Text += ' ' + ROW["TRAN_CHOF_NOMBRE"].ToString();
                }
                else
                {
                    MessageBox.Show("Transportista No Encontrado... Reintente");
                    txtChof_Ide.Focus();
                }
            }
        }

        private void cboMes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvListado_CurrentCellChanged(object sender, EventArgs e)
        {
            Mostrar_DgvListado();
        }

        private void dgvListado_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            /*
              if (this.dgvListado.CurrentRow != null)
              {
                  if ((Convert.ToInt32(this.dgvListado.CurrentRow.Cells["ESTADO"].Value)) == 0)
                  {
                      this.dgvListado.DefaultCellStyle.ForeColor = Color.Red;
                  }
              }
             
            if (Convert.ToInt32(this.dgvListado.Rows[e.RowIndex].Cells["ESTADO_DIGITACION"].Value) == 0)
            {
                // aplicar a todas las celdas de esa fila 
                // el estilo que necesitemos 
                foreach (DataGridViewCell celda in
                this.dgvListado.Rows[e.RowIndex].Cells)
                {
                    celda.Style.BackColor = Color.Red;
                    celda.Style.ForeColor = Color.White;
                }
            }
            

            if (Convert.ToInt32(this.dgvListado.Rows[e.RowIndex].Cells["ESTADO_DIGITACION"].Value) == 1)
            {
                // aplicar a todas las celdas de esa fila 
                // el estilo que necesitemos 
                foreach (DataGridViewCell celda in
                this.dgvListado.Rows[e.RowIndex].Cells)
                {
                    celda.Style.BackColor = Color.Azure;
                    celda.Style.ForeColor = Color.White;
                }
            } 
            */
        }

        private void dgvListado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int nFila = e.RowIndex;
            int nColumna = e.ColumnIndex;
            if (nColumna == 0)
            {
                DialogResult dialogResult = MessageBox.Show("Procede a Cerrar Orden Para Su Facturacion ? ", "Cerrar Orden de Recojo", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Operacion = "M";
                    nEstado_Digitacion = 1;
                    ENResultOperation R = ClsRecojo_CabeceraBC.Actualiza_Estado_Digitacion(nReco_Ide, nEstado_Digitacion);
                    procesar_filtro();
                }

            }
            if (nColumna != 0)
            {
                tabControl1.SelectedIndex = 1;
            }

        }


        // PROGRAMACION DEL DETALLE DE LAS ORDENES DE RECOJO //
        void FormatoDgv_RecoDetalle()
        {
            //------------------------------------------------------------------//      
            var dgv = dgvRecoDetalle;

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
            dgv.RowTemplate.Height = 17;
            

            /*---Pintado de color a la cabecera del datagrid ---*/
            DataGridViewCellStyle style = this.dgvListado.ColumnHeadersDefaultCellStyle;
            style.BackColor = Color.Honeydew;
            style.ForeColor = Color.Gray;

            dgv.Columns.Clear();
            dgv.ColumnCount = 35;
            // Setear Cabecera de Columna 
            dgv.Columns[0].Name = "IDE";
            dgv.Columns[0].DataPropertyName = "Reco_Ide";
            dgv.Columns[0].Visible = false;

            dgv.Columns[1].Name = "IDE_DETALLE";
            dgv.Columns[1].DataPropertyName = "Reco_Ide_Detalle";
            dgv.Columns[1].Visible = false;

            dgv.Columns[2].Name = "ITEM";
            dgv.Columns[2].Width = 30;
            dgv.Columns[2].HeaderText = "Item";
            dgv.Columns[2].DataPropertyName = "Reco_Item";

            dgv.Columns[3].Name = "DESTINATARIO";
            dgv.Columns[3].Width = 170;
            dgv.Columns[3].HeaderText = "Destinatario";
            dgv.Columns[3].DataPropertyName = "Reco_Destinatario";

            dgv.Columns[4].Name = "DIRECCION";
            dgv.Columns[4].Width = 170;
            dgv.Columns[4].HeaderText = "Direccion";
            dgv.Columns[4].DataPropertyName = "Reco_Direccion";

            dgv.Columns[5].Name = "LOCA_IDE";
            dgv.Columns[5].DataPropertyName = "Loca_Ide";
            dgv.Columns[5].Visible = false;

            dgv.Columns[6].Name = "LOCA_NOMBRE";
            dgv.Columns[6].Width = 60;
            dgv.Columns[6].HeaderText = "Localidad";
            dgv.Columns[6].DataPropertyName = "Loca_Nombre";

            dgv.Columns[7].Name = "PAIS_NOMBRE";
            dgv.Columns[7].Width = 40;
            dgv.Columns[7].HeaderText = "Pais";
            dgv.Columns[7].DataPropertyName = "Pais_Nombre";


            dgv.Columns[8].Name = "GUIA_PROVEEDOR";
            dgv.Columns[8].Width = 80;
            dgv.Columns[8].HeaderText = "Guia/Remite";
            dgv.Columns[8].DataPropertyName = "Reco_Guia_Proveedor";

            dgv.Columns[9].Name = "PLANILLA";
            dgv.Columns[9].Width = 80;
            dgv.Columns[9].HeaderText = "Pla/Remite";
            dgv.Columns[9].DataPropertyName = "Reco_Planilla";

            dgv.Columns[10].Name = "UNID_MEDI_IDE";
            dgv.Columns[10].DataPropertyName = "Unid_Medi_Ide";
            dgv.Columns[10].Visible = false;

            dgv.Columns[11].Name = "UNID_MEDI_NOMBRE";
            dgv.Columns[11].Width = 30;
            dgv.Columns[11].HeaderText = "UND";
            dgv.Columns[11].DataPropertyName = "Unid_Medi_Nombre";

            dgv.Columns[12].Name = "CANTIDAD";
            dgv.Columns[12].Width = 60;
            dgv.Columns[12].HeaderText = "Cantidad";
            dgv.Columns[12].DataPropertyName = "Reco_Cantidad";
            dgv.Columns[12].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgv.Columns[13].Name = "PESO";
            dgv.Columns[13].Width = 60;
            dgv.Columns[13].HeaderText = "Peso";
            dgv.Columns[13].DataPropertyName = "Reco_Peso";
            dgv.Columns[13].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgv.Columns[14].Name = "VOLUMEN";
            dgv.Columns[14].Width = 60;
            dgv.Columns[14].HeaderText = "Volumen";
            dgv.Columns[14].DataPropertyName = "Reco_Volumen";
            dgv.Columns[14].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgv.Columns[15].Name = "SERIE_NUMERO_GUIA";
            dgv.Columns[15].Width = 30;
            dgv.Columns[15].HeaderText = "Serie";
            dgv.Columns[15].DataPropertyName = "Serie_Guia_Trans";
            dgv.Columns[15].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgv.Columns[16].Name = "GUIA_NUMERO_GUIA";
            dgv.Columns[16].Width = 70;
            dgv.Columns[16].HeaderText = "Guia T";
            dgv.Columns[16].DataPropertyName = "Numero_Guia_Trans";
            dgv.Columns[16].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgv.Columns[17].Name = "DESCRIPCION";
            dgv.Columns[17].Width = 90;
            dgv.Columns[17].HeaderText = "Descripcion";
            dgv.Columns[17].DataPropertyName = "Reco_Descripcion";
            dgv.Columns[17].Visible = true;

            dgv.Columns[18].Name = "KM_FINAL";
            dgv.Columns[18].DataPropertyName = "Reco_Km_Final";
            dgv.Columns[18].Visible = false;
 
            dgv.Columns[19].Name = "PROD_IDE";
            dgv.Columns[19].DataPropertyName = "Tipo_Prod_Ide";
            dgv.Columns[19].Visible = false;

            dgv.Columns[20].Name = "PROD_NOMBRE";
            dgv.Columns[20].DataPropertyName = "Tipo_Prod_Nombre";
            dgv.Columns[20].Visible = false;

            dgv.Columns[21].Name = "FECHA_LLEGADA";
            dgv.Columns[21].DataPropertyName = "Reco_Fecha_Llegada";
            dgv.Columns[21].Visible = false;

            dgv.Columns[22].Name = "HORA_LLEGADA";
            dgv.Columns[22].DataPropertyName = "Reco_Hora_llegada";
            dgv.Columns[22].Visible = false;

            dgv.Columns[23].Name = "FECHA_INICIO_CARGA";
            dgv.Columns[23].DataPropertyName = "Reco_Fecha_Inicio_Carga";
            dgv.Columns[23].Visible = false;

            dgv.Columns[24].Name = "HORA_INICIO_CARGA";
            dgv.Columns[24].DataPropertyName = "Reco_Hora_Inicio_Carga";
            dgv.Columns[24].Visible = false;

            dgv.Columns[25].Name = "FECHA_FIN_CARGA";
            dgv.Columns[25].DataPropertyName = "Reco_Fecha_Fin_Carga";
            dgv.Columns[25].Visible = false;

            dgv.Columns[26].Name = "HORA_FIN_CARGA";
            dgv.Columns[26].DataPropertyName = "Reco_Hora_Fin_Carga";
            dgv.Columns[26].Visible = false;


            dgv.Columns[27].Name = "FECHA_INICIO_DESCARGA";
            dgv.Columns[27].DataPropertyName = "Reco_Fecha_Inicio_Descarga";
            dgv.Columns[27].Visible = false;

            dgv.Columns[28].Name = "HORA_INICIO_DESCARGA";
            dgv.Columns[28].DataPropertyName = "Reco_Hora_Inicio_Descarga";
            dgv.Columns[28].Visible = false;

            dgv.Columns[29].Name = "FECHA_FIN_DESCARGA";
            dgv.Columns[29].DataPropertyName = "Reco_Fecha_Fin_Descarga";
            dgv.Columns[29].Visible = false;

            dgv.Columns[30].Name = "HORA_FIN_DESCARGA";
            dgv.Columns[30].DataPropertyName = "Reco_Hora_Fin_Descarga";
            dgv.Columns[30].Visible = false;

            dgv.Columns[31].Name = "FECHA_RETIRO";
            dgv.Columns[31].DataPropertyName = "Reco_Fecha_Retiro";
            dgv.Columns[31].Visible = false;

            dgv.Columns[32].Name = "HORA_RETIRO";
            dgv.Columns[32].DataPropertyName = "Reco_Hora_Retiro";
            dgv.Columns[32].Visible = false;

            dgv.Columns[33].Name = "ESTADO_RUTA";
            dgv.Columns[33].DataPropertyName = "Reco_Estado_Ruta";
            dgv.Columns[33].Visible = false;

            dgv.Columns[34].Name = "CLIENTE_IDE";
            dgv.Columns[34].DataPropertyName = "Cliente_Ide";
            dgv.Columns[34].Visible = false;

        }
        public  void Mostrar_Detalle(Int32 Recojo_Ide)
        {
            DataTable TEMP = new DataTable();
            ENResultOperation R = ClsRecojo_DetalleBC.Listar(Recojo_Ide);
            if (R.Proceder) dgvRecoDetalle.DataSource = (DataTable)R.Valor;
            TEMP = (DataTable)R.Valor;
            

        }

        private void dgvRecoDetalle_DoubleClick(object sender, EventArgs e)
        {
            btnModificaDetalle.PerformClick();
        }

        private void Mostrar_DgvRecoDetalle()
        {

            if (this.dgvRecoDetalle.CurrentRow != null)
            {
                nReco_Ide = Convert.ToInt32(this.dgvRecoDetalle.CurrentRow.Cells["IDE"].Value);
                lblNumeroOrden.Text = cNumero_Orden;
                nReco_Ide_Detalle = Convert.ToInt32(this.dgvRecoDetalle.CurrentRow.Cells["IDE_DETALLE"].Value);
                unidad_medida = Convert.ToInt32(this.dgvRecoDetalle.CurrentRow.Cells["UNID_MEDI_IDE"].Value);
                sproducto = Convert.ToInt32(this.dgvRecoDetalle.CurrentRow.Cells["PROD_IDE"].Value);
                sdestinatario = this.dgvRecoDetalle.CurrentRow.Cells["DESTINATARIO"].Value.ToString();
            }
        }
        private void btnNuevoDetalle__Click(object sender, EventArgs e)
        {
            Nuevo_Detalle();
        }

        private void btnModificarDetalle_Click(object sender, EventArgs e)
        {
            Modificar_Detalle();
        }

        private void btnEliminarDetalle_Click(object sender, EventArgs e)
        {
            Eliminar_Detalle();
        }

        private void dgvRecoDetalle_CurrentCellChanged(object sender, EventArgs e)
        {
            Mostrar_DgvRecoDetalle();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectedIndex = 0;
        }

        private void btnTerminarDetalle_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectedIndex = 0;
        }

        private void btnGuiaTransportista_Click(object sender, EventArgs e)
        {
            Recojo.frmGuia_Transportista frmGuiaTrans = new Recojo.frmGuia_Transportista();
            frmGuiaTrans.ID_Reco_Ide = nReco_Ide;
            frmGuiaTrans.ShowDialog(); 
        }

        //******************************* PEAJE ********************************//
        void FormatoDgv_Peaje()
        {
            //------------------------------------------------------------------//      
            var dgv = dgvPeaje;

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
            DataGridViewCellStyle style = this.dgvPeaje.ColumnHeadersDefaultCellStyle;
            style.BackColor = Color.Honeydew;
            style.ForeColor = Color.Gray;

            dgv.Columns.Clear();
            dgv.ColumnCount = 8;
            // Setear Cabecera de Columna 
            dgv.Columns[0].Name = "IDE";
            dgv.Columns[0].DataPropertyName = "Reco_Ide";
            dgv.Columns[0].Visible = false;

            dgv.Columns[1].Name = "IDE_DETALLE";
            dgv.Columns[1].DataPropertyName = "Reco_Ide_Detalle";
            dgv.Columns[1].Visible = false;

            dgv.Columns[2].Name = "SERIE";
            dgv.Columns[2].Width = 40;
            dgv.Columns[2].HeaderText = "Serie";
            dgv.Columns[2].DataPropertyName = "Reco_Serie_Peaje";

            dgv.Columns[3].Name = "NUMERO";
            dgv.Columns[3].Width = 90;
            dgv.Columns[3].HeaderText = "Numero";
            dgv.Columns[3].DataPropertyName = "Reco_Numero_Peaje";

            dgv.Columns[4].Name = "MONTO";
            dgv.Columns[4].Width = 90;
            dgv.Columns[4].HeaderText = "Monto";
            dgv.Columns[4].DataPropertyName = "Reco_Monto";
            dgv.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgv.Columns[5].Name = "FECHA";
            dgv.Columns[5].Width = 90;
            dgv.Columns[5].HeaderText = "Fecha";
            dgv.Columns[5].DataPropertyName = "Reco_Fecha";
            dgv.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgv.Columns[6].Name = "VECES";
            dgv.Columns[6].DataPropertyName = "Veces";
            dgv.Columns[6].Visible = false;

            dgv.Columns[7].Name = "CREACION";
            dgv.Columns[7].DataPropertyName = "Creacion";
            dgv.Columns[7].Visible = false;

        }
        private void Mostrar_Peaje(Int32 Recojo_Ide)
        {
            DataTable TEMP = new DataTable();
            ENResultOperation R = ClsRecojo_PeajeBC.Listar(Recojo_Ide);
            if (R.Proceder) dgvPeaje.DataSource = (DataTable)R.Valor;
            TEMP = (DataTable)R.Valor;

        }

        private void Mostrar_DgvPeaje()
        {

            if (this.dgvPeaje.CurrentRow != null)
            {
                nReco_Ide_Detalle_Peaje = Convert.ToInt32(this.dgvPeaje.CurrentRow.Cells["IDE_DETALLE"].Value);
            }
        }

        private void btnNuevoPeaje_Click(object sender, EventArgs e)
        {
            Operacion_Peaje = "N";
            Procesar_Operacion_Peaje();
        }

        private void btnModificarPeaje_Click(object sender, EventArgs e)
        {
            Operacion_Peaje = "M";
            Procesar_Operacion_Peaje();
        }

        private void btnEliminarPeaje_Click(object sender, EventArgs e)
        {
            Operacion_Peaje = "E";
            Procesar_Operacion_Peaje();
        }

        private void Procesar_Operacion_Peaje()
        {
            frmRecojo_Peaje frmpeaje = new frmRecojo_Peaje();
            frmpeaje.Operacion_Peaje = Operacion_Peaje;
            frmpeaje.ID_Reco_Ide = nReco_Ide;
            frmpeaje.ID_Reco_Ide_Detalle = nReco_Ide_Detalle_Peaje;
            frmpeaje.ShowDialog();
            Mostrar_Peaje(nReco_Ide);
        }

 
        private void dgvPeaje_CurrentCellChanged(object sender, EventArgs e)
        {
            Mostrar_DgvPeaje();
        }

        // ************************ GASTOS ****************************//

        void FormatoDgv_Gastos()
        {
            //------------------------------------------------------------------//      
            var dgv = dgvGastos;

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

            dgv.Columns.Clear();
            dgv.ColumnCount = 13;
            // Setear Cabecera de Columna 
            dgv.Columns[0].Name = "IDE";
            dgv.Columns[0].DataPropertyName = "Reco_Ide";
            dgv.Columns[0].Visible = false;

            dgv.Columns[1].Name = "IDE_DETALLE";
            dgv.Columns[1].DataPropertyName = "Reco_Ide_Detalle";
            dgv.Columns[1].Visible = false;

            dgv.Columns[2].Name = "GASTO_IDE";
            dgv.Columns[2].Width = 40;
            dgv.Columns[2].HeaderText = "Gasto";
            dgv.Columns[2].DataPropertyName = "Gto_Ope_Ide";
            dgv.Columns[2].Visible = false;

            dgv.Columns[3].Name = "GASTO_NOMBRE";
            dgv.Columns[3].Width = 140;
            dgv.Columns[3].HeaderText = "Tipo de Gasto";
            dgv.Columns[3].DataPropertyName = "Gto_Ope_Nombre";

            dgv.Columns[4].Name = "TIPO_DOC";
            dgv.Columns[4].Width = 90;
            dgv.Columns[4].HeaderText = "T/D";
            dgv.Columns[4].DataPropertyName = "Tipo_Doc_Ide";
            dgv.Columns[4].Visible = false;

            dgv.Columns[5].Name = "DOC_NOMBRE";
            dgv.Columns[5].Width = 90;
            dgv.Columns[5].HeaderText = "Documento";
            dgv.Columns[5].DataPropertyName = "Tipo_Doc_Nombre";

            dgv.Columns[6].Name = "SERIE";
            dgv.Columns[6].Width = 90;
            dgv.Columns[6].HeaderText = "Serie";
            dgv.Columns[6].DataPropertyName = "Reco_Serie_Documento";

            dgv.Columns[7].Name = "NUMERO";
            dgv.Columns[7].Width = 90;
            dgv.Columns[7].HeaderText = "Numero";
            dgv.Columns[7].DataPropertyName = "Reco_Numero_Documento";

            dgv.Columns[8].Name = "MONTO";
            dgv.Columns[8].Width = 90;
            dgv.Columns[8].HeaderText = "Monto";
            dgv.Columns[8].DataPropertyName = "Reco_Monto";
            dgv.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgv.Columns[9].Name = "OBSERVACION";
            dgv.Columns[9].Width = 140;
            dgv.Columns[9].HeaderText = "Observacion";
            dgv.Columns[9].DataPropertyName = "Reco_Observacion";

            dgv.Columns[10].Name = "FECHA";
            dgv.Columns[10].Width = 90;
            dgv.Columns[10].HeaderText = "Fecha";
            dgv.Columns[10].DataPropertyName = "Reco_Fecha";
            dgv.Columns[10].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgv.Columns[11].Name = "CREACION";
            dgv.Columns[11].DataPropertyName = "Creacion";
            dgv.Columns[11].Visible = false;

            dgv.Columns[12].Name = "VECES";
            dgv.Columns[12].DataPropertyName = "Veces";
            dgv.Columns[12].Visible = false;
        }
        private void Mostrar_Gasto(Int32 Recojo_Ide)
        {
            DataTable TEMP = new DataTable();
            ENResultOperation R = ClsRecojo_GastoBC.Listar(Recojo_Ide);
            if (R.Proceder) dgvGastos.DataSource = (DataTable)R.Valor;
            TEMP = (DataTable)R.Valor;

        }

        private void Mostrar_DgvGastos()
        {

            if (this.dgvGastos.CurrentRow != null)
            {
                nReco_Ide_Detalle_Gasto = Convert.ToInt32(this.dgvGastos.CurrentRow.Cells["IDE_DETALLE"].Value);
            }
        }

        private void Procesar_Operacion_Gastos()
        {
            Recojo.frmRecojo_Gasto frmGasto = new Recojo.frmRecojo_Gasto();
            frmGasto.ID_Reco_Ide = nReco_Ide;
            frmGasto.Operacion_Gasto = Operacion_Gasto;
            frmGasto.ID_Reco_Ide = nReco_Ide;
            frmGasto.ID_Reco_Ide_Detalle = nReco_Ide_Detalle_Gasto;
            frmGasto.ShowDialog();
            Mostrar_Gasto(nReco_Ide);
        }

        private void btnNuevoGastos_Click(object sender, EventArgs e)
        {
            Operacion_Gasto = "N";
            Procesar_Operacion_Gastos();
        }

        private void btnModificarGastos_Click(object sender, EventArgs e)
        {
            Operacion_Gasto = "M";
            Procesar_Operacion_Gastos();
        }

        private void btnEliminarGastos_Click(object sender, EventArgs e)
        {
            Operacion_Gasto = "E";
            Procesar_Operacion_Gastos();
        }


        private void dgvGastos_CurrentCellChanged(object sender, EventArgs e)
        {
            Mostrar_DgvGastos();
        }


        // *********************** COMBUSTIBLE ********************** //

        void FormatoDgv_Combustible()
        {
            //------------------------------------------------------------------//      
            var dgv = dgvCombustible;

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

            dgv.Columns.Clear();
            dgv.ColumnCount = 13;
            // Setear Cabecera de Columna 
            dgv.Columns[0].Name = "IDE";
            dgv.Columns[0].DataPropertyName = "Reco_Ide";
            dgv.Columns[0].Visible = false;

            dgv.Columns[1].Name = "IDE_DETALLE";
            dgv.Columns[1].DataPropertyName = "Reco_Ide_Detalle";
            dgv.Columns[1].Visible = false;

            dgv.Columns[2].Name = "PROV_IDE";
            dgv.Columns[2].Width = 40;
            dgv.Columns[2].HeaderText = "Gasto";
            dgv.Columns[2].DataPropertyName = "Prov_Ide";
            dgv.Columns[2].Visible = false;

            dgv.Columns[3].Name = "PROVEEDOR";
            dgv.Columns[3].Width = 240;
            dgv.Columns[3].HeaderText = "Razon Social Proveedor";
            dgv.Columns[3].DataPropertyName = "Prov_Nombre";

            dgv.Columns[4].Name = "KMINICIAL";
            dgv.Columns[4].Width = 90;
            dgv.Columns[4].HeaderText = "Km. Inicial";
            dgv.Columns[4].DataPropertyName = "Reco_Kilometro_Inicial";
            dgv.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
           
            dgv.Columns[5].Name = "KMFINAL";
            dgv.Columns[5].Width = 90;
            dgv.Columns[5].HeaderText = "Km. Final";
            dgv.Columns[5].DataPropertyName = "Reco_KIlometro_Final";
            dgv.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgv.Columns[6].Name = "RECORRIDO";
            dgv.Columns[6].Width = 90;
            dgv.Columns[6].HeaderText = "Recorrido";
            dgv.Columns[6].DataPropertyName = "Recorrido";
            dgv.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgv.Columns[7].Name = "IMPORTE";
            dgv.Columns[7].Width = 90;
            dgv.Columns[7].HeaderText = "Importe";
            dgv.Columns[7].DataPropertyName = "Reco_Importe";
            dgv.Columns[7].DefaultCellStyle.Format = "N2";
            dgv.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgv.Columns[8].Name = "REDIMIENTO";
            dgv.Columns[8].Width = 90;
            dgv.Columns[8].HeaderText = "Rendimiento";
            dgv.Columns[8].DataPropertyName = "Reco_Rendimiento";
            dgv.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgv.Columns[9].Name = "TOTAL_COMBUSTIBLE";
            dgv.Columns[9].Width = 90;
            dgv.Columns[9].HeaderText = "Factor Consumo";
            dgv.Columns[9].DataPropertyName = "Total_Combustible";
            dgv.Columns[9].DefaultCellStyle.Format = "N2";
            dgv.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgv.Columns[10].Name = "TOTAL";
            dgv.Columns[10].Width = 90;
            dgv.Columns[10].HeaderText = "Total S/";
            dgv.Columns[10].DataPropertyName = "Total";
            dgv.Columns[10].DefaultCellStyle.Format = "N2";
            dgv.Columns[10].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;


            dgv.Columns[11].Name = "CREACION";
            dgv.Columns[11].DataPropertyName = "Creacion";
            dgv.Columns[11].Visible = false;

            dgv.Columns[12].Name = "VECES";
            dgv.Columns[12].DataPropertyName = "Veces";
            dgv.Columns[12].Visible = false;
        }

         private void Mostrar_Combustible(Int32 Recojo_Ide)
         {
             DataTable TEMP = new DataTable();
             ENResultOperation R = ClsRecojo_Combustible_ImporteBC.Listar(Recojo_Ide);
             if (R.Proceder) dgvCombustible.DataSource = (DataTable)R.Valor;
             TEMP = (DataTable)R.Valor;

         }

         private void Procesar_Operacion_Combustible()
         {
             Recojo.frmRecojo_Combustible_Importe frmCombustible = new Recojo.frmRecojo_Combustible_Importe();
             frmCombustible.ID_Reco_Ide = nReco_Ide;
             frmCombustible.Operacion_Combustible = Operacion_Combustible;
             frmCombustible.ID_Reco_Ide_Detalle = nReco_Ide_Detalle_Combustible;
             frmCombustible.Veh_Rendimiento = nRendimiento;
             frmCombustible.cTipoCombustible = cTipoCombustible;
             frmCombustible.nTipoCombustible = nTipoCombustible;
             frmCombustible.dFechaOrden = dtpFEmision.Value;
             frmCombustible.ShowDialog();
             Mostrar_Combustible(nReco_Ide);
         }

         private void btnNuevoCombustible_Click(object sender, EventArgs e)
         {
             Operacion_Combustible = "N";
             ENResultOperation R = ClsTransportista_VehiculoBC.Obtener_Vehiculo(txtVehi_Ide.Text, txtTran_Ide.Text);
             Obtener_Datos_Vehiculo();
             Procesar_Operacion_Combustible();
         }

         private void Obtener_Datos_Vehiculo()
         {
             ENResultOperation R = ClsTransportista_VehiculoBC.Obtener_Vehiculo(txtVehi_Ide.Text, txtTran_Ide.Text);
             if (R.Proceder)
             {
                 DataTable dt = (DataTable)R.Valor;
                 DataRow ROW = dt.Rows[0];
                 nRendimiento = ROW["TRAN_VEHI_RENDIMIENTO"].ToString();
                 cTipoCombustible = ROW["TRAN_VEHI_COMBUSTIBLE"].ToString();
                 nTipoCombustible = 2;
                 if (cTipoCombustible == "Gas") nTipoCombustible = 0;
                 if (cTipoCombustible == "Gasolina") nTipoCombustible = 1;
                 if (cTipoCombustible == "Petroleo") nTipoCombustible = 2;
             }
         }
         private void btnModificarCombustible_Click(object sender, EventArgs e)
         {
             Operacion_Combustible = "M";
             Obtener_Datos_Vehiculo();
             Procesar_Operacion_Combustible();
         }

         private void btnEliminarCombustible_Click(object sender, EventArgs e)
         {
             Operacion_Combustible = "E";
             Obtener_Datos_Vehiculo();
             Procesar_Operacion_Combustible();
         }

           private void dgvCombustible_CurrentCellChanged(object sender, EventArgs e)
         {
             Mostrar_DgvCombustible();
         }

         private void Mostrar_DgvCombustible()
         {

             if (this.dgvCombustible.CurrentRow != null)
             {
                 nReco_Ide_Detalle_Combustible = Convert.ToInt32(this.dgvCombustible.CurrentRow.Cells["IDE_DETALLE"].Value);
             }
         }


        // **************************** NOTA ***************************************//
         void FormatoDgv_Nota()
         {
             //------------------------------------------------------------------//      
             var dgv = dgvNota;

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

             dgv.Columns.Clear();
             dgv.ColumnCount = 5;
             // Setear Cabecera de Columna 
             dgv.Columns[0].Name = "IDE";
             dgv.Columns[0].DataPropertyName = "Reco_Ide";
             dgv.Columns[0].Visible = false;

             dgv.Columns[1].Name = "IDE_DETALLE";
             dgv.Columns[1].DataPropertyName = "Reco_Ide_Detalle";
             dgv.Columns[1].Visible = false;

             dgv.Columns[2].Name = "NOTA";
             dgv.Columns[2].Width = 600;
             dgv.Columns[2].HeaderText = "Nota";
             dgv.Columns[2].DataPropertyName = "Reco_Nota";
             

             dgv.Columns[3].Name = "CREACION";
             dgv.Columns[3].DataPropertyName = "Creacion";
             dgv.Columns[3].Visible = false;

             dgv.Columns[4].Name = "VECES";
             dgv.Columns[4].DataPropertyName = "Veces";
             dgv.Columns[4].Visible = false;
         }

         private void Mostrar_Nota(Int32 Recojo_Ide)
         {
             DataTable TEMP = new DataTable();
             ENResultOperation R = ClsRecojo_NotaBC.Listar(Recojo_Ide);
             if (R.Proceder) dgvNota.DataSource = (DataTable)R.Valor;
             TEMP = (DataTable)R.Valor;

         }

         private void Procesar_Operacion_Nota()
         {
             Recojo.frmRecojo_Nota frmNota = new Recojo.frmRecojo_Nota();
             frmNota.ID_Reco_Ide = nReco_Ide;
             frmNota.Operacion_Nota = Operacion_Nota;
             frmNota.ID_Reco_Ide_Detalle = nReco_Ide_Detalle_Nota;
             frmNota.ShowDialog();
             Mostrar_Nota(nReco_Ide);
         }

         private void btnNuevoNotas_Click(object sender, EventArgs e)
         {
             Operacion_Nota = "N";
             Procesar_Operacion_Nota();
         }

         private void btnModificarNotas_Click(object sender, EventArgs e)
         {
             Operacion_Nota = "M";
             Procesar_Operacion_Nota();
         }

         private void btnEliminarNotas_Click(object sender, EventArgs e)
         {
             Operacion_Nota = "E";
             Procesar_Operacion_Nota();
         }
  
         private void Mostrar_DgvNota()
         {

             if (this.dgvNota.CurrentRow != null)
             {
                 nReco_Ide_Detalle_Nota = Convert.ToInt32(this.dgvNota.CurrentRow.Cells["IDE_DETALLE"].Value);
             }
         }

         private void dgvNota_CurrentCellChanged(object sender, EventArgs e)
         {
             Mostrar_DgvNota();
         }

         #region Ayudantes
         // **************************** AYUDANTE ***************************************//
         void FormatoDgv_Ayudante()
         {
             //------------------------------------------------------------------//      
             var dgv = dgvAyudante;

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

             dgv.Columns.Clear();
             dgv.ColumnCount = 5;
             // Setear Cabecera de Columna 
             dgv.Columns[0].Name = "IDE";
             dgv.Columns[0].DataPropertyName = "Reco_Ide";
             dgv.Columns[0].Visible = false;

             dgv.Columns[1].Name = "IDE_DETALLE";
             dgv.Columns[1].DataPropertyName = "Reco_Ide_Detalle";
             dgv.Columns[1].Visible = false;

             dgv.Columns[2].Name = "ID_Contacto";
             dgv.Columns[2].Width = 40;
             dgv.Columns[2].HeaderText = "ID";
             dgv.Columns[2].DataPropertyName = "Tran_Cont_Ide";

             dgv.Columns[3].Name = "ID_Transportista";
             dgv.Columns[3].Width = 40;
             dgv.Columns[3].HeaderText = "Trans";
             dgv.Columns[3].DataPropertyName = "Tran_Ide";

             dgv.Columns[4].Name = "NOMBRE";
             dgv.Columns[4].Width = 400;
             dgv.Columns[4].HeaderText = "Nombre";
             dgv.Columns[4].DataPropertyName = "Nombre_Completo";

         }

         private void Mostrar_Ayudante(Int32 Recojo_Ide)
         {
             DataTable TEMP = new DataTable();
             ENResultOperation R = ClsRecojo_AyudanteBC.Listar(Recojo_Ide);
             if (R.Proceder) dgvAyudante.DataSource = (DataTable)R.Valor;
             TEMP = (DataTable)R.Valor;
         }

         private void Mostrar_DgvAyudante()
         {

             if (this.dgvAyudante.CurrentRow != null)
             {
                 nReco_Ide_Detalle_Ayudante = Convert.ToInt32(this.dgvAyudante.CurrentRow.Cells["IDE_DETALLE"].Value);
                 txtTran_Cont_Ide.Text = this.dgvAyudante.CurrentRow.Cells["ID_CONTACTO"].Value.ToString();
             }
         }
         private void dgvAyudante_CurrentCellChanged(object sender, EventArgs e)
         {
             Mostrar_DgvAyudante();
         }

         private void Obtener_Veces_Cabecera()
         {
             ENResultOperation R = ClsRecojo_CabeceraBC.Obtener_Registro(nReco_Ide);
             DataTable dt = (DataTable)R.Valor;
             DataRow ROW = dt.Rows[0];
             nVeces = Convert.ToInt32(ROW["VECES"].ToString());
             cNumero_Orden = ROW["RECO_NUMERO_RECOJO"].ToString();
         }

         private void Procesar_Operacion_Ayudante()
         {
             
             ENResultOperation R = ClsRecojo_CabeceraBC.Obtener_Registro(nReco_Ide);
             DataTable dt = (DataTable)R.Valor;
             DataRow ROW = dt.Rows[0];
             nVeces = Convert.ToInt32(ROW["VECES"].ToString());
             //nTran_Ide = Convert.ToInt32(ROW["TRAN_IDE"].ToString());
             Llenar_CboAyudante();
             panelAyudantes.Visible = true;
             if (Operacion_Ayudante != "N")
             {
                 ENResultOperation P = ClsRecojo_AyudanteBC.Listar_Filtro(nReco_Ide, nReco_Ide_Detalle_Ayudante);
                 DataTable dtp = (DataTable)P.Valor;
                 if (dtp.Rows.Count != 0)
                 {
                     DataRow ROWP = dtp.Rows[0];
                     txtTran_Cont_Ide.Text = ROWP["TRAN_CONT_IDE"].ToString();
                     cboAyudante.Text = ROWP["NOMBRE_COMPLETO"].ToString();
                 }
             }
             else
             {
                 cboAyudante.Text = "";
             }
             /*
             Recojo.frmRecojo_Ayudante frmAyudante = new Recojo.frmRecojo_Ayudante();
             frmAyudante.ID_Reco_Ide = nReco_Ide;
             frmAyudante.Operacion_Ayudante = Operacion_Ayudante;
             frmAyudante.ID_Reco_Ide_Detalle = nReco_Ide_Detalle_Ayudante;
             frmAyudante.ShowDialog();
             Mostrar_Ayudante(nReco_Ide);
             */

         }

         private void btnNuevoAyudante_Click(object sender, EventArgs e)
         {
             Operacion_Ayudante = "N";
             btnAyudanteGrabar.Text = "Adicionar";
             cboAyudante.Enabled = true;
             Procesar_Operacion_Ayudante();
         }

         private void btnModificarAyudante_Click(object sender, EventArgs e)
         {
             Operacion_Ayudante = "M";
             btnAyudanteGrabar.Text = "Grabar";
             cboAyudante.Enabled = true;
             Procesar_Operacion_Ayudante();
         }

         private void btnEliminarAyudante_Click(object sender, EventArgs e)
         {
             Operacion_Ayudante = "E";
             btnAyudanteGrabar.Text = "Eliminar";
             cboAyudante.Enabled = false;
             Procesar_Operacion_Ayudante();
         }

         private void Llenar_CboAyudante()
         {
             DataTable TEMP = new DataTable();
             ENResultOperation R = ClsTransportista_ContactoBC.Listar(Convert.ToInt32(txtTran_Ide.Text));
             if (R.Proceder)
             {
                 TEMP = (DataTable)R.Valor;
                 this.cboAyudante.DataSource = TEMP;
                 this.cboAyudante.DisplayMember = "Nombre_Completo";
                 this.cboAyudante.ValueMember = "Tran_Cont_Ide";
                 this.cboAyudante.AutoCompleteMode = AutoCompleteMode.Suggest;
                 this.cboAyudante.AutoCompleteSource = AutoCompleteSource.ListItems;
                 this.cboAyudante.DropDownHeight = 250;
                 this.cboAyudante.DropDownStyle = ComboBoxStyle.DropDownList;
                 //this.cboAyudante.SelectedIndex = Convert.ToInt32(txtTran_Cont_Ide.Text);
             }
         }

         private void btnAyudanteCancelar_Click(object sender, EventArgs e)
         {
             panelAyudantes.Visible = false;
         }

         private void btnAyudanteGrabar_Click(object sender, EventArgs e)
         {
             ClsRecojo_AyudanteBE TipoBE = new ClsRecojo_AyudanteBE();
             TipoBE.Reco_ide = nReco_Ide;
             TipoBE.Reco_ide_detalle = nReco_Ide_Detalle_Ayudante;
             TipoBE.Tran_cont_ide = Convert.ToInt32(txtTran_Cont_Ide.Text);
             TipoBE.Veces = nVeces;
             TipoBE.Usuario = "ADMIN";

             switch (Operacion_Ayudante)
             {
                 case "N":
                     ENResultOperation R = ClsRecojo_AyudanteBC.Crear(TipoBE);
                     if (R.Proceder)
                     {
                         btnAyudanteGrabar.Text = "Adicionar";
                     }
                     break;
                 case "M": ClsRecojo_AyudanteBC.Actualizar(TipoBE);
                     btnAyudanteGrabar.Text = "Grabar";
                     break;
                 case "E": ClsRecojo_AyudanteBC.Eliminar(TipoBE);
                     btnAyudanteGrabar.Text = "Grabar";
                     break;
             }
             Mostrar_Ayudante(nReco_Ide);
             
             if (Operacion_Ayudante == "N")
             {
                 Procesar_Operacion_Ayudante();
             }
             else
             {
                 panelAyudantes.Visible = false;
             }
         }

         private void cboAyudante_SelectedValueChanged(object sender, EventArgs e)
         {
             if (cboAyudante.SelectedValue != null)
             {
                 txtTran_Cont_Ide.Text = cboAyudante.SelectedValue.ToString();
             }
         }


         #endregion Ayudantes
         // **************************** PUNTO DE PARTIDA ***************************************//

         private void txtPPartida_Ide_TextChanged(object sender, EventArgs e)
         {

         }

         private void txtTransportista_KeyDown(object sender, KeyEventArgs e)
         {
             if (e.KeyCode == Keys.F3)
             {
                 Buscar_Transportista();
             }         
         }

         private void txtTransportista_KeyPress(object sender, KeyPressEventArgs e)
         {
             if ((int)e.KeyChar == (int)Keys.Enter)
             {
                 ENResultOperation R = ClsTransportistaBC.Listar_Nombre(txtTransportista.Text);
                 if (R.Proceder)
                 {
                     DataTable dt = (DataTable)R.Valor;
                     if (dt.Rows.Count > 0)
                     {
                         DataRow ROW = dt.Rows[0];
                         txtTransportista.Text = ROW["TRAN_RAZON_SOCIAL"].ToString();
                         txtTran_Ide.Text = ROW["TRAN_IDE"].ToString();
                         txtConductor.Focus();
                     }
                 }
                 else
                 {
                     Buscar_Transportista();
                 }
             }
         }

         private void pictTodos_Click(object sender, EventArgs e)
         {

         }

         // **************************** RECOJO PUNTO REPARTO ***************************************//
         void FormatoDgv_PuntoReparto()
         {
             //------------------------------------------------------------------//      
             var dgv = dgvPuntoReparto;

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
             dgv.RowTemplate.Height = 17;

             /*---Pintado de color a la cabecera del datagrid ---*/
             DataGridViewCellStyle style = this.dgvPuntoReparto.ColumnHeadersDefaultCellStyle;
             style.BackColor = Color.Honeydew;
             style.ForeColor = Color.Gray;

             dgv.Columns.Clear();
             dgv.ColumnCount = 5;
             // Setear Cabecera de Columna 

             dgv.Columns[0].Name = "ITEM";
             dgv.Columns[0].Width = 30;
             dgv.Columns[0].HeaderText = "Itm";
             dgv.Columns[0].DataPropertyName = "Loca_Ide";

             dgv.Columns[1].Name = "DESTINATARIO";
             dgv.Columns[1].Width = 200;
             dgv.Columns[1].HeaderText = "Destinatario";
             dgv.Columns[1].DataPropertyName = "Reco_Destinatario";

             dgv.Columns[2].Name = "DIRECCION";
             dgv.Columns[2].Width = 180;
             dgv.Columns[2].HeaderText = "Direccion";
             dgv.Columns[2].DataPropertyName = "Reco_Direccion";

             dgv.Columns[3].Name = "LOCALIDAD";
             dgv.Columns[3].Width = 100;
             dgv.Columns[3].HeaderText = "Localidad";
             dgv.Columns[3].DataPropertyName = "Loca_Nombre";

             dgv.Columns[4].Name = "PAIS";
             dgv.Columns[4].Width = 100;
             dgv.Columns[4].HeaderText = "Pais";
             dgv.Columns[4].DataPropertyName = "Pais_Nombre";

         }

         private void Mostrar_PuntoReparto(Int32 Recojo_Ide)
         {
             DataTable TEMP = new DataTable();
             ENResultOperation R = ClsRecojo_DetalleBC.Listar_PuntoReparto(Recojo_Ide);
             if (R.Proceder) dgvPuntoReparto.DataSource = (DataTable)R.Valor;
             //TEMP = (DataTable)R.Valor;
             Int32 itm = 0;
             for (int row = 0; row <= dgvPuntoReparto.Rows.Count - 1; row++)
             {
                 itm = itm + 1;
                 this.dgvPuntoReparto.Rows[row].Cells["ITEM"].Value = itm.ToString();
             }
         }

         private void dgvPuntoReparto_CurrentCellChanged(object sender, EventArgs e)
         {

         }

        //*********************   RECOJO - RECARGO ***********************************

         void FormatoDgv_Recargo()
         {
             //------------------------------------------------------------------//      
             var dgv = dgvRecargo;

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
             dgv.RowTemplate.Height = 17;

             /*---Pintado de color a la cabecera del datagrid ---*/
             DataGridViewCellStyle style = this.dgvRecargo.ColumnHeadersDefaultCellStyle;
             style.BackColor = Color.Honeydew;
             style.ForeColor = Color.Gray;

             dgv.Columns.Clear();
             dgv.ColumnCount = 5;
             // Setear Cabecera de Columna 

             dgv.Columns[0].Name = "IDE";
             dgv.Columns[0].DataPropertyName = "Reco_Ide";
             dgv.Columns[0].Visible = false;

             dgv.Columns[1].Name = "IDE_DETALLE";
             dgv.Columns[1].DataPropertyName = "Reco_Ide_Detalle";
             dgv.Columns[1].Visible = false;

             dgv.Columns[2].Name = "MERCA_IDE";
             dgv.Columns[2].DataPropertyName = "Merca_Ide";
             dgv.Columns[2].Visible = false;

             dgv.Columns[3].Name = "MERCA_NOMBRE";
             dgv.Columns[3].Width = 250;
             dgv.Columns[3].HeaderText = "Recargo";
             dgv.Columns[3].DataPropertyName = "Merca_Nombre";

             dgv.Columns[4].Name = "PORCENTAJE";
             dgv.Columns[4].Width = 100;
             dgv.Columns[4].HeaderText = " % ";
             dgv.Columns[4].DataPropertyName = "Reco_Porcentaje";
             dgv.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

         }

         private void Mostrar_Recargo(Int32 Recojo_Ide)
         {
             DataTable TEMP = new DataTable();
             ENResultOperation R = ClsRecojo_Recargo_CargaBC.Listar(Recojo_Ide);
             if (R.Proceder) dgvRecargo.DataSource = (DataTable)R.Valor;
         }
         private void btnRNuevo_Click(object sender, EventArgs e)
         {
             Recojo.frmRecojo_Recargo frmRecargo = new Recojo.frmRecojo_Recargo();
             frmRecargo.ID_Reco_Ide = nReco_Ide;
             frmRecargo.ID_Reco_Ide_Detalle = 0;
             frmRecargo.Operacion_Recargo = "N";
             frmRecargo.ShowDialog();
             Mostrar_Recargo(nReco_Ide);
         }

         private void btnRModificar_Click(object sender, EventArgs e)
         {
             Recojo.frmRecojo_Recargo frmRecargo = new Recojo.frmRecojo_Recargo();
             frmRecargo.ID_Reco_Ide = nReco_Ide;
             frmRecargo.ID_Reco_Ide_Detalle = nReco_Ide_Detalle_Recargo;
             frmRecargo.Operacion_Recargo = "M";
             frmRecargo.ShowDialog();
             Mostrar_Recargo(nReco_Ide);
         }

         private void btnREliminar_Click(object sender, EventArgs e)
         {
             Recojo.frmRecojo_Recargo frmRecargo = new Recojo.frmRecojo_Recargo();
             frmRecargo.ID_Reco_Ide = nReco_Ide;
             frmRecargo.ID_Reco_Ide_Detalle = nReco_Ide_Detalle_Recargo;
             frmRecargo.Operacion_Recargo = "E";
             frmRecargo.ShowDialog();
             Mostrar_Recargo(nReco_Ide);
         }

         private void Mostrar_DgvRecargo()
         {

             if (this.dgvRecargo.CurrentRow != null)
             {
                 nReco_Ide_Detalle_Recargo = Convert.ToInt32(this.dgvRecargo.CurrentRow.Cells["IDE_DETALLE"].Value);
             }
         }

         private void dgvRecargo_CurrentCellChanged(object sender, EventArgs e)
         {
             Mostrar_DgvRecargo();
         }

         // ****************************** RECOJO -  APOYO ***********************//

         void FormatoDgv_Apoyo()
         {
             //------------------------------------------------------------------//      
             var dgv = dgvApoyo;

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
             dgv.DefaultCellStyle.Font = new Font("Tahoma",8);
             /*----------Alterna colores en el grid -------*/
             dgv.RowsDefaultCellStyle.BackColor = Color.LightBlue;
             dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.White;

             /*---Pintado de color a la cabecera del datagrid ---*/
             DataGridViewCellStyle style = this.dgvApoyo.ColumnHeadersDefaultCellStyle;
             style.BackColor = Color.Honeydew;
             style.ForeColor = Color.Gray;

             dgv.Columns.Clear();
             dgv.ColumnCount = 18;
             // Setear Cabecera de Columna 
             dgv.Columns[0].Name = "RECO_IDE";
             dgv.Columns[0].DataPropertyName = "Reco_Ide";
             dgv.Columns[0].Visible = false;

             dgv.Columns[1].Name = "RECO_IDE_DETALLE";
             dgv.Columns[1].DataPropertyName = "Reco_Ide_Detalle";
             dgv.Columns[1].Visible = false;

             dgv.Columns[2].Name = "RECO_NUMERO_APOYO";
             dgv.Columns[2].DataPropertyName = "Reco_Numero_Apoyo";
             dgv.Columns[2].Width = 50;
             dgv.Columns[2].HeaderText = "Apoyo";
             
             dgv.Columns[3].Name = "RECO_FECHA_EMISION";
             dgv.Columns[3].DataPropertyName = "Reco_Fecha_Emision";
             dgv.Columns[3].Width = 90;
             dgv.Columns[3].HeaderText = "F.Emision";

             dgv.Columns[4].Name = "RECO_FECHA_TRASLADO";
             dgv.Columns[4].DataPropertyName = "Reco_Fecha_Traslado";
             dgv.Columns[4].Width = 90;
             dgv.Columns[4].HeaderText = "F.Traslado";

             dgv.Columns[5].Name = "RECO_HORA_SALIDA";
             dgv.Columns[5].DataPropertyName = "Reco_Hora_Salida";
             dgv.Columns[5].Visible = false;

             dgv.Columns[6].Name = "RECO_FECHA_RETORNO";
             dgv.Columns[6].DataPropertyName = "Reco_Fecha_Retorno";
             dgv.Columns[6].Visible = false;

             dgv.Columns[7].Name = "RECO_HORA_RETORNO";
             dgv.Columns[7].DataPropertyName = "Reco_Hora_Retorno";
             dgv.Columns[7].Visible = false;

             dgv.Columns[8].Name = "TRAN_IDE";
             dgv.Columns[8].DataPropertyName = "Tran_Ide";
             dgv.Columns[8].Visible = false;

             dgv.Columns[9].Name = "TRAN_NOMBRE";
             dgv.Columns[9].DataPropertyName = "Tran_Nombre";
             dgv.Columns[9].Width = 100;
             dgv.Columns[9].HeaderText = "Transportista";

             dgv.Columns[10].Name = "TRAN_CHOF_IDE";
             dgv.Columns[10].DataPropertyName = "Tran_Chof_Ide";
             dgv.Columns[10].Visible = false;

             dgv.Columns[11].Name = "CHOF_NOMBRE";
             dgv.Columns[11].DataPropertyName = "Chof_Nombre";
             dgv.Columns[11].Width = 220;
             dgv.Columns[11].HeaderText = "Conductor";

             dgv.Columns[12].Name = "TRAN_VEHI_IDE";
             dgv.Columns[12].DataPropertyName = "Tran_Vehi_Ide";
             dgv.Columns[12].Visible = false;

             dgv.Columns[13].Name = "VEHI_PLACA";
             dgv.Columns[13].DataPropertyName = "Vehi_Placa";
             dgv.Columns[13].Width = 120;
             dgv.Columns[13].HeaderText = "Vehiculo";

             dgv.Columns[14].Name = "RECO_TONELAJE";
             dgv.Columns[14].DataPropertyName = "Reco_Tonelaje";
             dgv.Columns[14].Width =  80;
             dgv.Columns[14].HeaderText = "TN";
             dgv.Columns[14].DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight;

             dgv.Columns[15].Name = "RECO_VOLUMEN";
             dgv.Columns[15].DataPropertyName = "Reco_Volumen";
             dgv.Columns[15].Width = 80;
             dgv.Columns[15].HeaderText = "Volumen";
             dgv.Columns[15].DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight;
            
             dgv.Columns[16].Name = "RECO_UDOMETRO_INICIAL";
             dgv.Columns[16].DataPropertyName = "Reco_Udometro_Inicial";
             dgv.Columns[16].Visible = false;

             dgv.Columns[17].Name = "RECO_UDOMETRO_FINAL";
             dgv.Columns[17].DataPropertyName = "Reco_Udometro_Final";
             dgv.Columns[17].Visible = false;

         }
         private void Mostrar_Apoyo(Int32 Recojo_Ide)
         {
             DataTable TEMP = new DataTable();
             ENResultOperation R = ClsRecojo_Apoyo_CabeceraBC.Listar(Recojo_Ide);
             if (R.Proceder) dgvApoyo.DataSource = (DataTable)R.Valor;
         }

         private void Mostrar_DgvApoyo()
         {

             if (this.dgvApoyo.CurrentRow != null)
             {
                 nReco_Ide_Detalle_Apoyo = Convert.ToInt32(this.dgvApoyo.CurrentRow.Cells["RECO_IDE_DETALLE"].Value);
             }
         }
         private void dgvApoyo_CurrentCellChanged(object sender, EventArgs e)
         {
             Mostrar_DgvApoyo();
         }

         private void btnApNuevo_Click(object sender, EventArgs e)
         {
            if (nFacturado == 0)
            {
                Recojo.frmRecojo_Apoyo frmApoyo = new Recojo.frmRecojo_Apoyo();
                frmApoyo.nReco_Ide = nReco_Ide;
                frmApoyo.nReco_Ide_Detalle = nReco_Ide_Detalle_Apoyo;
                frmApoyo.Operacion_Apoyo = "N";
                frmApoyo.ShowDialog();
            }
            else
            {
                MessageBox.Show("No se Puede Modificar Orden de Recojo por Estar Facturado");
            }
         }

         private void btnApEliminar_Click(object sender, EventArgs e)
         {
             Recojo.frmRecojo_Apoyo frmApoyo = new Recojo.frmRecojo_Apoyo();
             frmApoyo.ShowDialog();
         }

         private void txtVehiculo_TextChanged(object sender, EventArgs e)
         {

         }

         private void txtConductor_TextChanged(object sender, EventArgs e)
         {

         }

         private void tabControl1_Selected(object sender, TabControlEventArgs e)
         {
             txtFiltro.Focus();

         }

         private void cboAyudante_SelectedIndexChanged(object sender, EventArgs e)
         {

         }
         #endregion OrdenCabecera

         #region OrdenDetalle
         private void btnNuevo_Detalle_Click(object sender, EventArgs e)
         {
             if (btnGrabar.Enabled)
             {
                 MessageBox.Show("No puede Ingresar Nuevo Detalle Si No Graba Cabecera", "Mensaje de Alerta");
             }
             else
             {
                 Nuevo_Detalle();
             }
         }

         private Boolean Obtener_Ide_Cabecera()
         {
             if (string.IsNullOrEmpty(txtNumero.Text)) txtNumero.Text = "0";
             if (Convert.ToInt32(txtNumero.Text.ToString()) != 0)
             {
                 cNumero_Orden = "*Error Numero de Orden*";
                 ENResultOperation R = ClsRecojo_CabeceraBC.Buscar_Orden(Convert.ToInt32(txtNumero.Text.ToString()));
                 DataTable dt = (DataTable)R.Valor;
                 if (dt.Rows.Count == 1)
                 {
                     DataRow ROW = dt.Rows[0];
                     nReco_Ide = Convert.ToInt32(ROW["RECO_IDE"].ToString());
                     nVeces = Convert.ToInt32(ROW["VECES"].ToString());
                     cNumero_Orden = ROW["RECO_NUMERO_RECOJO"].ToString();
                     lblNumeroOrden.Text = cNumero_Orden;
                     return true;
                 }
             }
             lblNumeroOrden.Text = cNumero_Orden;
             return false;
         }

         private void Nuevo_Detalle()
         {
             if (!btnGrabar.Enabled)
             {
                 if (Obtener_Ide_Cabecera())
                 {
                     Detalle_Operacion_Detalle = "N";
                     PanelDetalle.Visible = true;
                     Habilitar_Botones_Detalle(false);
                     Habilitar_Campos_Detalle(true);
                     Inicializa_Campos_Detalle();
                     lblNumeroOrden.Text = cNumero_Orden;
                     txtDestinatario_Detalle.Focus();
                 }
             }
         }

         private void btnModificar_Detalle_Click(object sender, EventArgs e)
         {
             Modificar_Detalle();
         }
         private void Modificar_Detalle()
         {
             if (Obtener_Ide_Cabecera())
             {
                 if (this.dgvRecoDetalle.CurrentRow != null)
                 {
                     Cargar_Recojo_Detalle();
                     Detalle_Operacion_Detalle = "M";
                     PanelDetalle.Visible = true;
                     Detalle_Operacion_Detalle = "M";
                     Habilitar_Botones_Detalle(false);
                     Habilitar_Campos_Detalle(true);
                     lblNumeroOrden.Text = cNumero_Orden;
                     txtDestinatario_Detalle.Focus();
                 }
             }
         }

         private void btnEliminar_Detalle_Click(object sender, EventArgs e)
         {
             Eliminar_Detalle();
         }
         private void Eliminar_Detalle()
         {
             if (Obtener_Ide_Cabecera())
             {
                 if (this.dgvRecoDetalle.CurrentRow != null)
                 {
                     Cargar_Recojo_Detalle();
                     Detalle_Operacion_Detalle = "E";
                     PanelDetalle.Visible = true;
                     Habilitar_Botones_Detalle(false);
                     Habilitar_Campos_Detalle(false);
                     lblNumeroOrden.Text = cNumero_Orden;
                     btnGrabar_Detalle.Text = "Eliminar";
                 }
             }
         }

         private void btnGrabar_Detalle_Click(object sender, EventArgs e)
         {
             if (string.IsNullOrEmpty(txtLocaIde_Detalle.Text))
             {
                 MessageBox.Show("Localidad No Ingresada", "Validacion de Datos");
             }
             else
             {
                 Procesar_Operacion_Detalle();
             }

             btnGrabar_Detalle.Text = "Grabar";
             Mostrar_Detalle(nReco_Ide);

             if (Detalle_Operacion_Detalle == "N")
             {
                 Nuevo_Detalle();
             }
             else
             {
                 Habilitar_Botones_Detalle(true);
                 Habilitar_Campos_Detalle(false);
                 Cargar_Recojo_Detalle();
             }
         }
         private void CambiarFlag_Botones(Boolean Flag)
         {
             btnNuevo.Enabled = Flag;
             btnModificar.Enabled = Flag;
             btnEliminar.Enabled =  Flag;
             btnBuscar.Enabled = Flag;
             btnGrabar.Enabled = Flag;
             btnCancelar.Enabled = Flag;
             btnImprimir.Enabled = Flag;
             btnSalir.Enabled = Flag;
         }
         private void btnCancelar_Detalle_Click(object sender, EventArgs e)
         {
             //Habilitar_Botones_Detalle(true);
             //Habilitar_Campos_Detalle(false);
             //Cargar_Recojo_Detalle();
             CambiarFlag_Botones(true);
             btnGrabar.Enabled = false;
             btnCancelar.Enabled = false;
             PanelDetalle.Visible = false;
         }

         private void btnSalir_Detalle_Click(object sender, EventArgs e)
         {
             CambiarFlag_Botones(true);
             btnGrabar.Enabled = false;
             btnCancelar.Enabled = false;
             PanelDetalle.Visible = false;
         }

         private void Habilitar_Botones_Detalle(Boolean Flag)
         {
             btnNuevo_Detalle.Enabled = Flag;
             btnModificar_Detalle.Enabled = Flag;
             btnEliminar_Detalle.Enabled = Flag;
             btnSalir_Detalle.Enabled = Flag;
             btnGrabar_Detalle.Enabled = !Flag;
             btnCancelar_Detalle.Enabled = !Flag;
         }

         private void Cargar_Recojo_Detalle()
         {
             ENResultOperation R = ClsRecojo_DetalleBC.Listar_Filtro(nReco_Ide, nReco_Ide_Detalle);
             DataTable dt = (DataTable)R.Valor;
             txtItem_Detalle.Text = "0";
             if (dt.Rows.Count != 0)
             {
                 DataRow ROW = dt.Rows[0];
                 ID_Cliente = Convert.ToInt32(ROW["CLIENTE_IDE"].ToString());
                 txtItem_Detalle.Text = ROW["RECO_ITEM"].ToString();
                 txtDestinatario_Detalle.Text = ROW["RECO_DESTINATARIO"].ToString();
                 txtDireccion_Detalle.Text = ROW["RECO_DIRECCION"].ToString();
                 txtLocaIde_Detalle.Text = ROW["LOCA_IDE"].ToString();
                 txtLoca_Nombre_Detalle.Text = ROW["LOCA_NOMBRE"].ToString();
                 txtPais_Nombre_Detalle.Text = ROW["PAIS_NOMBRE"].ToString();
                 txtGuia_Remitente_Detalle.Text = ROW["RECO_GUIA_PROVEEDOR"].ToString();
                 txtPlanilla_Remitente_Detalle.Text = ROW["RECO_PLANILLA"].ToString();
                 txtBultos_Detalle.Text = ROW["RECO_CANTIDAD"].ToString();
                 txtPeso_Detalle.Text = ROW["RECO_PESO"].ToString();
                 txtVolumen_Detalle.Text = ROW["RECO_VOLUMEN"].ToString();
                 txtkmFinal_Detalle.Text = ROW["RECO_KM_FINAL"].ToString();
                 txtDescripcion_Detalle.Text = ROW["RECO_DESCRIPCION"].ToString();
                 txtNumero_Apoyo_Detalle.Text = "0";

                 cboTipoProducto_Detalle.Text = ROW["TIPO_PROD_NOMBRE"].ToString();

                 cboUnidad_Medida_Detalle.Text = ROW["UNID_MEDI_NOMBRE"].ToString();


                 dtpFllegada_Detalle.Text = ROW["RECO_FECHA_LLEGADA"].ToString();
                 dtpFInicio_Carga_Detalle.Text = ROW["RECO_FECHA_INICIO_CARGA"].ToString();
                 dtpFFin_Carga_Detalle.Text = ROW["RECO_FECHA_FIN_CARGA"].ToString();
                 dtpFInicio_Descarga_Detalle.Text = ROW["RECO_FECHA_INICIO_DESCARGA"].ToString();
                 dtpFFin_Descarga_Detalle.Text = ROW["RECO_FECHA_FIN_DESCARGA"].ToString();
                 dtpFTermino_Detalle.Text = ROW["RECO_FECHA_RETIRO"].ToString();
                 txtHLlegada_Detalle.Text = ROW["RECO_HORA_LLEGADA"].ToString();
                 txtHInicio_Carga_Detalle.Text = ROW["RECO_HORA_INICIO_CARGA"].ToString();
                 txtHFin_Carga_Detalle.Text = ROW["RECO_HORA_FIN_CARGA"].ToString();
                 txtHInicio_Descarga_Detalle.Text = ROW["RECO_HORA_INICIO_DESCARGA"].ToString();
                 txtHFin_Descarga_Detalle.Text = ROW["RECO_HORA_FIN_DESCARGA"].ToString();
                 txtHTermino_Detalle.Text = ROW["RECO_HORA_RETIRO"].ToString();
             }
             txtItem_Detalle.Focus();
         }

         private void Cargar_Unidad_Medida()
         {
             {
                 DataTable TEMP = new DataTable();
                 string nombre_error = "";
                 ENResultOperation R = ClsUnidad_MedidaBC.Listar(nombre_error);
                 if (R.Proceder)
                 {
                     TEMP = (DataTable)R.Valor;
                     this.cboUnidad_Medida_Detalle.DataSource = TEMP;
                     this.cboUnidad_Medida_Detalle.DisplayMember = Convert.ToString(TEMP.Columns["Unid_Medi_Nombre"]);
                     this.cboUnidad_Medida_Detalle.ValueMember = Convert.ToString(TEMP.Columns["Unid_Medi_Ide"]);
                     this.cboUnidad_Medida_Detalle.DropDownStyle = ComboBoxStyle.DropDownList;
                     this.cboUnidad_Medida_Detalle.SelectedValue = unidad_medida;
                 }
             }
         }
         private void Cargar_Tipo_Producto()
         {
             {
                 DataTable TEMP = new DataTable();
                 string nombre_error = "";
                 ENResultOperation R = ClsTipo_ProductoBC.Listar(nombre_error);
                 if (R.Proceder)
                 {
                     TEMP = (DataTable)R.Valor;
                     this.cboTipoProducto_Detalle.DataSource = TEMP;
                     this.cboTipoProducto_Detalle.DisplayMember = Convert.ToString(TEMP.Columns["Tipo_Prod_Nombre"]);
                     this.cboTipoProducto_Detalle.ValueMember = Convert.ToString(TEMP.Columns["Tipo_Prod_Ide"]);
                     this.cboTipoProducto_Detalle.DropDownStyle = ComboBoxStyle.DropDownList;
                     this.cboTipoProducto_Detalle.AutoCompleteSource = AutoCompleteSource.ListItems;
                     this.cboTipoProducto_Detalle.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                     this.cboTipoProducto_Detalle.SelectedValue = sproducto;
                 }
             }
         }
         private void Procesar_Operacion_Detalle()
         {
             //Obtener_Veces_Cabecera();
             clsRecojo_DetalleBE TipoBE = new clsRecojo_DetalleBE();
             TipoBE.Reco_ide = nReco_Ide;
             TipoBE.Reco_ide_detalle = nReco_Ide_Detalle;
             TipoBE.Reco_item = Convert.ToInt32(txtItem_Detalle.Text);
             TipoBE.Reco_cliente_ide = 0;   // ID_Cliente;
             TipoBE.Reco_destinatario = txtDestinatario_Detalle.Text;
             TipoBE.Reco_direccion = txtDireccion_Detalle.Text;
             if (string.IsNullOrEmpty(txtLocaIde_Detalle.Text)) txtLocaIde_Detalle.Text = "0";
             TipoBE.Loca_ide = Convert.ToInt32(txtLocaIde_Detalle.Text);
             TipoBE.Reco_guia_proveedor = txtGuia_Remitente_Detalle.Text;
             TipoBE.Reco_planilla = txtPlanilla_Remitente_Detalle.Text;
             TipoBE.Reco_descripcion = txtDescripcion_Detalle.Text;
             if (String.IsNullOrEmpty(txtBultos_Detalle.Text)) txtBultos_Detalle.Text = "0";
             TipoBE.Reco_cantidad = Convert.ToDouble(txtBultos_Detalle.Text);
             if (String.IsNullOrEmpty(txtPeso_Detalle.Text)) txtPeso_Detalle.Text = "0";
             TipoBE.Reco_peso = Convert.ToDouble(txtPeso_Detalle.Text);
             if (String.IsNullOrEmpty(txtVolumen_Detalle.Text)) txtVolumen_Detalle.Text = "0";
             TipoBE.Reco_volumen = Convert.ToDouble(txtVolumen_Detalle.Text);
             if (String.IsNullOrEmpty(txtkmFinal_Detalle.Text)) txtkmFinal_Detalle.Text = "0";
             TipoBE.Reco_km_final = Convert.ToDouble(txtkmFinal_Detalle.Text);
             TipoBE.Unid_medi_ide = Convert.ToInt32(cboUnidad_Medida_Detalle.SelectedValue.ToString());
             TipoBE.Tipo_prod_ide = Convert.ToInt32(cboTipoProducto_Detalle.SelectedValue.ToString());
             TipoBE.Reco_fecha_llegada = Convert.ToDateTime(dtpFllegada_Detalle.Text);
             if (txtHLlegada_Detalle.Text.Substring(0,2)=="  ") txtHLlegada_Detalle.Text = "00:00:00";
             TipoBE.Reco_hora_llegada = txtHLlegada_Detalle.Text;
             TipoBE.Reco_fecha_inicio_carga = Convert.ToDateTime(dtpFInicio_Carga_Detalle.Text);
             if (txtHInicio_Carga_Detalle.Text.Substring(0,2)=="  ") txtHInicio_Carga_Detalle.Text = "00:00:00";
             TipoBE.Reco_hora_inicio_carga = txtHInicio_Carga_Detalle.Text;
             TipoBE.Reco_fecha_fin_carga = Convert.ToDateTime(dtpFFin_Carga_Detalle.Text);
             if (txtHFin_Carga_Detalle.Text.Substring(0, 2) == "  ") txtHFin_Carga_Detalle.Text = "00:00:00";
             TipoBE.Reco_hora_fin_carga = txtHFin_Carga_Detalle.Text;
             TipoBE.Reco_fecha_inicio_descarga = Convert.ToDateTime(dtpFInicio_Descarga_Detalle.Text);
             if (txtHInicio_Descarga_Detalle.Text.Substring(0, 2) == "  ") txtHInicio_Descarga_Detalle.Text = "00:00:00";
             TipoBE.Reco_hora_inicio_descarga = txtHInicio_Descarga_Detalle.Text;
             TipoBE.Reco_fecha_fin_descarga = Convert.ToDateTime(dtpFFin_Descarga_Detalle.Text);
             if (txtHFin_Descarga_Detalle.Text.Substring(0, 2) == "  ") txtHFin_Descarga_Detalle.Text = "00:00:00";
             TipoBE.Reco_hora_fin_descarga = txtHFin_Descarga_Detalle.Text;
             TipoBE.Reco_fecha_retiro = Convert.ToDateTime(dtpFTermino_Detalle.Text);
             if (txtHTermino_Detalle.Text.Substring(0, 2) == "  ") txtHTermino_Detalle.Text = "00:00:00";
             TipoBE.Reco_hora_retiro = txtHTermino_Detalle.Text;
             TipoBE.Reco_estado_ruta = true;
             TipoBE.Veces = nVeces;
             TipoBE.Usuario = "ADMIN";
             sproducto = Convert.ToInt32(cboTipoProducto_Detalle.SelectedValue.ToString());
             unidad_medida = Convert.ToInt32(cboUnidad_Medida_Detalle.SelectedValue.ToString());
             sdestinatario = txtDestinatario_Detalle.Text;

             switch (Detalle_Operacion_Detalle)
             {
                 case "N":
                     ENResultOperation N = ClsRecojo_DetalleBC.Crear(TipoBE);
                     if (!N.Proceder) MessageBox.Show("Error : " + N.Sms);
                     break;
                 case "M":
                     ENResultOperation M = ClsRecojo_DetalleBC.Actualizar(TipoBE);
                     if (!M.Proceder) MessageBox.Show("Error : " + M.Sms);
                     break;
                 case "E":
                     ENResultOperation E = ClsRecojo_DetalleBC.Eliminar(TipoBE);
                     if (!E.Proceder) MessageBox.Show("Error : " + E.Sms);
                     break;
             }
             lblNumeroOrden.Text = "";
         }

         private void Habilitar_Campos_Detalle(Boolean Flag)
         {
             
             txtItem_Detalle.ReadOnly = !Flag;
             txtDestinatario_Detalle.ReadOnly = !Flag;
             txtDireccion_Detalle.ReadOnly = !Flag;
             txtLocaIde_Detalle.ReadOnly = !Flag;
             txtLoca_Nombre_Detalle.ReadOnly = !Flag;
             txtPais_Nombre_Detalle.ReadOnly = !Flag;
             txtGuia_Remitente_Detalle.ReadOnly = !Flag;
             txtPlanilla_Remitente_Detalle.ReadOnly = !Flag;
             txtBultos_Detalle.ReadOnly = !Flag;
             txtPeso_Detalle.ReadOnly = !Flag;
             txtVolumen_Detalle.ReadOnly = !Flag;
             txtkmFinal_Detalle.ReadOnly = !Flag;
             txtDescripcion_Detalle.ReadOnly = !Flag;
             txtNumero_Apoyo_Detalle.ReadOnly = true;
             cboTipoProducto_Detalle.Enabled = Flag;
             cboUnidad_Medida_Detalle.Enabled = Flag;
             dtpFllegada_Detalle.Enabled = Flag;
             dtpFInicio_Carga_Detalle.Enabled = Flag;
             dtpFFin_Carga_Detalle.Enabled = Flag;
             dtpFInicio_Descarga_Detalle.Enabled = Flag;
             dtpFFin_Descarga_Detalle.Enabled = Flag;
             dtpFTermino_Detalle.Enabled = Flag;
             txtHLlegada_Detalle.ReadOnly = !Flag;
             txtHInicio_Carga_Detalle.ReadOnly = !Flag;
             txtHFin_Carga_Detalle.ReadOnly = !Flag;
             txtHInicio_Descarga_Detalle.ReadOnly = !Flag;
             txtHFin_Descarga_Detalle.ReadOnly = !Flag;
             txtHTermino_Detalle.ReadOnly = !Flag;
             //lblNumeroOrden.Text = nReco_Ide.ToString();
             
         }
         private void Inicializa_Campos_Detalle()
         {
             txtItem_Detalle.Text = "0";
             txtDestinatario_Detalle.Text = "";
             txtDireccion_Detalle.Text = "";
             txtLocaIde_Detalle.Text = String.Empty;
             txtLoca_Nombre_Detalle.Text = String.Empty;
             txtPais_Nombre_Detalle.Text = String.Empty;
             txtGuia_Remitente_Detalle.Text = String.Empty;
             txtPlanilla_Remitente_Detalle.Text = String.Empty;
             txtBultos_Detalle.Text = String.Empty;
             txtPeso_Detalle.Text = String.Empty;
             txtVolumen_Detalle.Text = String.Empty;
             txtkmFinal_Detalle.Text = String.Empty;
             txtDescripcion_Detalle.Text = String.Empty;
             txtNumero_Apoyo_Detalle.Text = String.Empty;
             //cboTipoProducto.Text = String.Empty;
             //cboUnidad_Medida.Text = String.Empty;
             dtpFllegada_Detalle.Text = dtpFEmision.Text;
             dtpFInicio_Carga_Detalle.Text = dtpFEmision.Text;
             dtpFFin_Carga_Detalle.Text = dtpFEmision.Text;
             dtpFInicio_Descarga_Detalle.Text = dtpFEmision.Text;
             dtpFFin_Descarga_Detalle.Text = dtpFEmision.Text;
             dtpFTermino_Detalle.Text = dtpFEmision.Text;
             txtHLlegada_Detalle.Text = "00:00:00";
             txtHInicio_Carga_Detalle.Text = "00:00:00";
             txtHFin_Carga_Detalle.Text = "00:00:00";
             txtHInicio_Descarga_Detalle.Text = "00:00:00";
             txtHFin_Descarga_Detalle.Text = "00:00:00";
             txtHTermino_Detalle.Text = "00:00:00";
         }


         private void PanelDetalle_Enter(object sender, EventArgs e)
         {
             Cargar_Unidad_Medida();
             Cargar_Tipo_Producto();
             CambiarFlag_Botones(false);
         }

         private void txtDestinatario_Detalle_KeyDown(object sender, KeyEventArgs e)
         {
            if (e.KeyCode == Keys.F3)
            {
                Buscar_Cliente_Detalle();
            }
         }

         private void Buscar_Cliente_Detalle()
         {
             Clientes.frmClientesBuscar frmBuscarCliente = new Clientes.frmClientesBuscar();
             frmBuscarCliente.Cliente_Razon = txtDestinatario_Detalle.Text;
             frmBuscarCliente.ShowDialog();
             if (!string.IsNullOrEmpty(frmBuscarCliente.Cliente_Razon))
             {
                 txtDestinatario_Detalle.Text = frmBuscarCliente.Cliente_Razon;
                 //txtDireccion_Detalle.Text = frmBuscarCliente.Cliente_Direccion;
                 //txtLocaIde_Detalle.Text = frmBuscarCliente.Cliente_localidad;
                 //Obtener_Descripcion_Localidad(txtLocaIde_Detalle.Text);
                 ID_Cliente = frmBuscarCliente.Clie_Ide;
                 txtDireccion_Detalle.Focus();
             }
         }

         private void txtDestinatario_Detalle_KeyPress(object sender, KeyPressEventArgs e)
         {
             if ((int)e.KeyChar == (int)Keys.Enter)
             {
                 if (Existe_Destinatario(txtDestinatario_Detalle.Text))
                 {
                     Buscar_Punto_Llegada();
                     SendKeys.Send("{TAB}");
                 }
                 else
                 {
                     Buscar_Cliente_Detalle();
                 }

             }
         }

         private Boolean Existe_Destinatario(string txtDestinatario)
         {
             ENResultOperation R = ClsClientesBC.Listar_Nombre(txtDestinatario_Detalle.Text);
             if (R.Proceder)
             {
                 DataTable dt = (DataTable)R.Valor;
                 if (dt.Rows.Count == 1)
                 {
                     DataRow ROW = dt.Rows[0];
                     txtDestinatario_Detalle.Text = ROW["CLIE_RAZON_SOCIAL"].ToString();
                     //txtDireccion_Detalle.Text = ROW["CLIE_DIRECCION"].ToString();
                     //txtLocaIde_Detalle.Text = ROW["LOCA_IDE"].ToString();
                     return true;
                 }
                 else
                 {
                     return false;
                 }

             }
             return true;
         }
         private void Buscar_Punto_Llegada()
         {
             if (String.IsNullOrEmpty(txtDireccion_Detalle.Text))
             {
                 Clientes.frmCliente_Lugar_Entrega frmLugarEntrega = new Clientes.frmCliente_Lugar_Entrega();
                 frmLugarEntrega.Clie_Ide = ID_Cliente;
                 frmLugarEntrega.Clie_Nombre = txtDestinatario_Detalle.Text;
                 frmLugarEntrega.ShowDialog();
                 if (!String.IsNullOrEmpty(frmLugarEntrega.Direccion_Lugar_Entrega))
                 {
                     txtDireccion_Detalle.Text = frmLugarEntrega.Direccion_Lugar_Entrega;
                     txtLocaIde_Detalle.Text = frmLugarEntrega.Loca_Ide;
                     Obtener_Descripcion_Localidad(txtLocaIde_Detalle.Text);
                     cboTipoProducto_Detalle.Focus();
                 }
             }
         }

         private void txtDireccion_Detalle_Enter(object sender, EventArgs e)
         {
             if (string.IsNullOrWhiteSpace(txtDireccion_Detalle.Text))
             {
                 Buscar_Punto_Llegada();
             }

         }

         private void txtDireccion_Detalle_KeyDown(object sender, KeyEventArgs e)
         {
             if (e.KeyCode == Keys.F3)
             {
                 Buscar_Punto_Llegada();
             }
         }

         private void txtDireccion_Detalle_KeyPress(object sender, KeyPressEventArgs e)
         {
             if ((int)e.KeyChar == (int)Keys.Enter) SendKeys.Send("{TAB}");
         }

         private void txtLocaIde_Detalle_TextChanged(object sender, EventArgs e)
         {
             Obtener_Descripcion_Localidad(txtLocaIde_Detalle.Text);
         }
         private void txtLocaIde_Detalle_KeyPress(object sender, KeyPressEventArgs e)
         {
             if ((int)e.KeyChar == (int)Keys.Enter) SendKeys.Send("{TAB}");
         }
         private void txtLoca_Nombre_Detalle_KeyPress(object sender, KeyPressEventArgs e)
         {
             if ((int)e.KeyChar == (int)Keys.Enter) SendKeys.Send("{TAB}");
         }
         private void cboTipoProducto_Detalle_KeyPress(object sender, KeyPressEventArgs e)
         {
             if ((int)e.KeyChar == (int)Keys.Enter) SendKeys.Send("{TAB}");
         }

         private void txtGuia_Remitente_Detalle_KeyPress(object sender, KeyPressEventArgs e)
         {
             if ((int)e.KeyChar == (int)Keys.Enter) SendKeys.Send("{TAB}");
         }

         private void txtPlanilla_Remitente_Detalle_KeyPress(object sender, KeyPressEventArgs e)
         {
             if ((int)e.KeyChar == (int)Keys.Enter) SendKeys.Send("{TAB}");
         }

         private void cboUnidad_Medida_Detalle_KeyPress(object sender, KeyPressEventArgs e)
         {
             if ((int)e.KeyChar == (int)Keys.Enter) SendKeys.Send("{TAB}");
         }

         private void txtBultos_Detalle_KeyPress(object sender, KeyPressEventArgs e)
         {
             if ((int)e.KeyChar == (int)Keys.Enter) SendKeys.Send("{TAB}");
         }

         private void txtPeso_Detalle_KeyPress(object sender, KeyPressEventArgs e)
         {
             if ((int)e.KeyChar == (int)Keys.Enter) SendKeys.Send("{TAB}");
         }

         private void txtVolumen_Detalle_KeyPress(object sender, KeyPressEventArgs e)
         {
             if ((int)e.KeyChar == (int)Keys.Enter) SendKeys.Send("{TAB}");
         }

         private void txtkmFinal_Detalle_KeyPress(object sender, KeyPressEventArgs e)
         {
             if ((int)e.KeyChar == (int)Keys.Enter) SendKeys.Send("{TAB}");
         }

         private void dtpFllegada_Detalle_KeyPress(object sender, KeyPressEventArgs e)
         {
             if ((int)e.KeyChar == (int)Keys.Enter) SendKeys.Send("{TAB}");
         }

         private void txtHLlegada_Detalle_KeyPress(object sender, KeyPressEventArgs e)
         {
             if ((int)e.KeyChar == (int)Keys.Enter) SendKeys.Send("{TAB}");
         }

         private void dtpFInicio_Carga_Detalle_KeyPress(object sender, KeyPressEventArgs e)
         {
             if ((int)e.KeyChar == (int)Keys.Enter) SendKeys.Send("{TAB}");
         }

         private void txtHInicio_Carga_Detalle_KeyPress(object sender, KeyPressEventArgs e)
         {
             if ((int)e.KeyChar == (int)Keys.Enter) SendKeys.Send("{TAB}");
         }

         private void dtpFFin_Carga_Detalle_KeyPress(object sender, KeyPressEventArgs e)
         {
             if ((int)e.KeyChar == (int)Keys.Enter) SendKeys.Send("{TAB}");
         }

         private void txtHFin_Carga_Detalle_KeyPress(object sender, KeyPressEventArgs e)
         {
             if ((int)e.KeyChar == (int)Keys.Enter) SendKeys.Send("{TAB}");
         }

         private void dtpFInicio_Descarga_Detalle_KeyPress(object sender, KeyPressEventArgs e)
         {
             if ((int)e.KeyChar == (int)Keys.Enter) SendKeys.Send("{TAB}");
         }

         private void txtHInicio_Descarga_Detalle_KeyPress(object sender, KeyPressEventArgs e)
         {
             if ((int)e.KeyChar == (int)Keys.Enter) SendKeys.Send("{TAB}");
         }

         private void dtpFFin_Descarga_Detalle_KeyPress(object sender, KeyPressEventArgs e)
         {
             if ((int)e.KeyChar == (int)Keys.Enter) SendKeys.Send("{TAB}");
         }

         private void txtHFin_Descarga_Detalle_KeyPress(object sender, KeyPressEventArgs e)
         {
             if ((int)e.KeyChar == (int)Keys.Enter) SendKeys.Send("{TAB}");
         }

         private void dtpFTermino_Detalle_KeyPress(object sender, KeyPressEventArgs e)
         {
             if ((int)e.KeyChar == (int)Keys.Enter) SendKeys.Send("{TAB}");
         }

         private void txtHTermino_Detalle_KeyPress(object sender, KeyPressEventArgs e)
         {
             if ((int)e.KeyChar == (int)Keys.Enter) SendKeys.Send("{TAB}");
         }

         private void txtNumero_Apoyo_Detalle_KeyPress(object sender, KeyPressEventArgs e)
         {
             if ((int)e.KeyChar == (int)Keys.Enter) SendKeys.Send("{TAB}");
         }

         private void btnGrabar_Detalle_KeyPress(object sender, KeyPressEventArgs e)
         {
             if ((int)e.KeyChar == (int)Keys.Enter) SendKeys.Send("{TAB}");
         }

         private void txtDescripcion_Detalle_KeyPress(object sender, KeyPressEventArgs e)
         {
             if ((int)e.KeyChar == (int)Keys.Enter) SendKeys.Send("{TAB}");
         }

         #endregion OrdenDetalle

         private void txtVehi_Ide_TextChanged(object sender, EventArgs e)
         {

         }

         private void frmOrdenRecojo_KeyDown(object sender, KeyEventArgs e)
         {

         }




    }
}
