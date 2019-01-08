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
using System.Net;
using System.Net.Mail;

namespace CapaPresentacion.Proveedores
{
    public partial class frmCombustible_Compra : Form
    {
        private string campo_busqueda;
        private string condi_busqueda;
        private string tonelaje;
        public int iComp_Ide;
        string Operacion = null;  // Operaciones : N = Nuevo / M = Modificar E = Eliminar
        private Int32 nProve_Ide;
        private Int32 nTran_Ide;
        private Int32 nTran_Vehi_Ide;
        private Int32 nTran_Chof_Ide;
        private Int32 nTipo_Combustible;
        private Int32 nRecorrido;
        private Decimal nEficiencia;
        private Decimal nPrecio_Combustible;

        string From = "ptorres@terahsac.com"; //de quien procede, puede ser un alias
        string To = "iperez@terahsac.com,mhernandez@terahsac.com,logistica.sb@terahsac.com,corpursac@gmail.com";  //a quien vamos a enviar el mail
        //string To = "corpursac@gmail.com";  //a quien vamos a enviar el mail
        string Mensaje;  //mensaje
        string Asunto; //asunto
        List<string> Archivo = new List<string>(); //lista de archivos a enviar
        string DE = "ptorres@terahsac.com"; //nuestro usuario de smtp
        string PASS = "terah2019"; //nuestro password de smtp

        System.Net.Mail.MailMessage Email;

        public string error = "";

        public frmCombustible_Compra()
        {
            InitializeComponent();
        }
        
        private void frmCombustible_Compra_Load(object sender, EventArgs e)
        {
            FormatoDgv();
            Inicializa_Fechas();
            Mostrar("");
            Carga_Tipo_Combustible();
            PanelMantenimiento.Visible = false;
            Habilitar_Botones(true);
            Cargar_Busquedas();
            txtBuscar.Focus();
            txtOrden.ReadOnly = true;
            Parametros_Correo();
            ToolTip toolTip1 = new ToolTip();
            toolTip1.ShowAlways = true;
            toolTip1.SetToolTip(btnActualizar, "Reprocesa todas las compras para Actualizar Kms Finales y Ordenes ");  
        }

        private void Parametros_Correo()
        {
            ENResultOperation R =  ClsCorreo_ParametroBC.Listar("");
            DataTable dtg = (DataTable)R.Valor;
            if (dtg.Rows.Count != 0)
            {
                DataRow ROWG = dtg.Rows[0];
                From = ROWG["EMPRE_CORREO_FROM"].ToString();
                To   = ROWG["EMPRE_CORREO_TO"].ToString();
                DE = ROWG["EMPRE_USUARIO"].ToString();
                PASS = ROWG["EMPRE_CLAVE"].ToString();
            }
            else
            {
                From = "ptorres@terahsac.com";
                To = "corpursac@gmail.com,ventas@corpursac.com";
                DE = "ptorres@terahsac.com";
                PASS = "terah2019";
            }
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
            // Setear Cabecera de Columna 

            dgv.Columns[0].Name = "IDE";
            dgv.Columns[1].Name = "PROV_IDE";
            dgv.Columns[2].Name = "RAZON_SOCIAL";
            dgv.Columns[3].Name = "FECHA";
            dgv.Columns[4].Name = "NUMERO";
            dgv.Columns[5].Name = "TIPO_COMBUSTIBLE";
            dgv.Columns[6].Name = "CANTIDAD";
            dgv.Columns[7].Name = "IMPORTE";
            dgv.Columns[8].Name = "KILOMETRAJE";
            dgv.Columns[9].Name = "TRAN_IDE";
            dgv.Columns[10].Name = "TRANSPORTISTA";
            dgv.Columns[11].Name = "TRAN_VEHI_IDE";
            dgv.Columns[12].Name = "PLACA";
            dgv.Columns[13].Name = "NOMBRE";
            dgv.Columns[14].Name = "TRAN_CHOF_IDE";
            dgv.Columns[15].Name = "CHOFER";
            dgv.Columns[16].Name = "COMP_LUGAR";
            dgv.Columns[17].Name = "CREACION";
            dgv.Columns[18].Name = "USUARIO";
            dgv.Columns[19].Name = "ESTADO";
            dgv.Columns[20].Name = "COMP_ORDEN";
            dgv.Columns[21].Name = "FECHA_POSTERIOR";
            dgv.Columns[22].Name = "KMS_POSTERIOR";
            dgv.Columns[23].Name = "ORDENES";
            dgv.Columns[24].Name = "COMB_INICIO";
            dgv.Columns[25].Name = "COMB_FINAL";
            dgv.Columns[26].Name = "TONELAJE";


            dgv.Columns[0].Width = 30;
            dgv.Columns[0].HeaderText = "ID";
            dgv.Columns[0].DataPropertyName = "COMP_IDE";

            dgv.Columns[1].DataPropertyName = "PROV_IDE";
            dgv.Columns[1].Visible = false;

            dgv.Columns[2].Width = 200;
            dgv.Columns[2].HeaderText = "Razon Social";
            dgv.Columns[2].DataPropertyName = "RAZON_SOCIAL";

            dgv.Columns[3].Width = 70;
            dgv.Columns[3].HeaderText = "Fecha";
            dgv.Columns[3].DataPropertyName = "COMP_FECHA";

            dgv.Columns[4].Width = 90;
            dgv.Columns[4].HeaderText = "Factura";
            dgv.Columns[4].DataPropertyName = "COMP_NUMERO";
            dgv.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            dgv.Columns[5].Width = 80;
            dgv.Columns[5].HeaderText = "Combustible";
            dgv.Columns[5].DataPropertyName = "COMP_TIPO_COMBUSTIBLE";
            dgv.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgv.Columns[6].Width = 60;
            dgv.Columns[6].HeaderText = "Cantidad";
            dgv.Columns[6].DataPropertyName = "COMP_CANTIDAD";
            dgv.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgv.Columns[7].Width = 80;
            dgv.Columns[7].HeaderText = " Importe";
            dgv.Columns[7].DataPropertyName = "COMP_IMPORTE";
            dgv.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgv.Columns[8].Width = 80;
            dgv.Columns[8].HeaderText = "Kilometraje";
            dgv.Columns[8].DataPropertyName = "COMP_KILOMETRAJE";
            dgv.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgv.Columns[9].DataPropertyName = "TRAN_IDE";
            dgv.Columns[9].Visible = false;

            dgv.Columns[10].DataPropertyName = "TRANSPORTISTA";
            dgv.Columns[10].Visible = false;

            dgv.Columns[11].DataPropertyName = "TRAN_VEHI_IDE";
            dgv.Columns[11].Visible = false;

            dgv.Columns[12].Width = 70;
            dgv.Columns[12].HeaderText = "Placa";
            dgv.Columns[12].DataPropertyName = "PLACA";
            dgv.Columns[12].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            dgv.Columns[13].Width = 120;
            dgv.Columns[13].HeaderText = "Nombre";
            dgv.Columns[13].DataPropertyName = "NOMBRE";
            dgv.Columns[13].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            dgv.Columns[14].DataPropertyName = "TRAN_CHOF_IDE";
            dgv.Columns[14].Visible = false;

            dgv.Columns[15].DataPropertyName = "CHOFER";
            dgv.Columns[15].Width = 170;
            dgv.Columns[15].HeaderText = "Chofer";
            dgv.Columns[15].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            dgv.Columns[16].DataPropertyName = "COMP_LUGAR";
            dgv.Columns[16].Visible = false;

            dgv.Columns[17].DataPropertyName = "CREACION";
            dgv.Columns[17].Visible = false;

            dgv.Columns[18].DataPropertyName = "USUARIO";
            dgv.Columns[18].Visible = false;

            dgv.Columns[19].DataPropertyName = "ESTADO";
            dgv.Columns[19].Visible = false;

            dgv.Columns[20].DataPropertyName = "COMP_ORDEN";
            dgv.Columns[20].Visible = false;

            dgv.Columns[21].DataPropertyName = "FECHA_POSTERIOR";
            dgv.Columns[21].Width = 70;
            dgv.Columns[21].HeaderText = "Fecha Posterior";
            dgv.Columns[21].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgv.Columns[22].DataPropertyName = "KMS_POSTERIOR";
            dgv.Columns[22].Width = 80;
            dgv.Columns[22].HeaderText = "Kms Posterior";
            dgv.Columns[22].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgv.Columns[23].DataPropertyName = "ORDENES";
            dgv.Columns[23].Width = 380;
            dgv.Columns[23].HeaderText = "Ordenes de Recojo";
            dgv.Columns[23].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            dgv.Columns[24].DataPropertyName = "COMB_INICIO";
            dgv.Columns[24].Width = 80;
            dgv.Columns[24].HeaderText = "Marcador Inicio";
            dgv.Columns[24].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgv.Columns[24].Visible = false;

            dgv.Columns[25].DataPropertyName = "COMB_FINAL";
            dgv.Columns[25].Width = 80;
            dgv.Columns[25].HeaderText = "Marcador Final";
            dgv.Columns[25].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgv.Columns[25].Visible = false;

            dgv.Columns[26].DataPropertyName = "TONELAJE";
            dgv.Columns[26].Width = 80;
            dgv.Columns[26].HeaderText = "Tonelaje";
            dgv.Columns[26].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgv.Columns[26].Visible = false;

        }

        private void Cargar_Busquedas()
        {
          cboBuscarPor.Items.Clear();
          cboBuscarPor.Items.Add("Fecha");
          cboBuscarPor.Items.Add("Razon Social Proveedor");
          cboBuscarPor.Items.Add("Placa");
          cboBuscarPor.SelectedIndex = 0;
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

        private void Mostrar(string filtro)
        {
            ENResultOperation R = ClsCombustible_CompraBC.Listar_por_Fechas(dtpFecIni.Value, dtpFecFin.Value); 
            //ENResultOperation R = ClsCombustible_CompraBC.Listar(filtro);
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

        private void dgvListado_DoubleClick(object sender, EventArgs e)
        {
            Mantenimiento_Registros();
        }
        private void dgvListado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.F4)
            {
                if (this.dgvListado.CurrentRow != null)
                {
                    iComp_Ide = Convert.ToInt32(this.dgvListado.CurrentRow.Cells["IDE"].Value.ToString());
                    btnModificar.PerformClick();
                }
            }
        }

        private void dgvListado_CurrentCellChanged(object sender, EventArgs e)
        {
            Mostrar_Dgv();
        }

        private void Carga_Tipo_Combustible()
        {
            cboTipoCombustible.Items.Clear();
            cboTipoCombustible.Items.Add("Gas");
            cboTipoCombustible.Items.Add("Gasolina");
            cboTipoCombustible.Items.Add("Petroleo");
            cboTipoCombustible.SelectedIndex = 0;
        }
  
        private void Mantenimiento_Registros()
        {
            Cargar_Registro(iComp_Ide);
        }

        private void dgvListado_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
               // Mantenimiento_Registros();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            PanelMantenimiento.Visible = false;
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            PanelMantenimiento.Visible = true;
            Operacion = "E";
            btnGrabar.Text = "Eliminar";
            Mantenimiento_Registros();
            Habilitar_Botones(false);
            
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            PanelMantenimiento.Visible = true;
            Operacion = "M";
            Mantenimiento_Registros();
            Habilitar_Botones(false);
            Habilitar_Campos(true);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            PanelMantenimiento.Visible = true;
            Operacion = "N";
            Inicializa_Campos();
            Habilitar_Botones(false);
            Habilitar_Campos(true);
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

        private void Cargar_Registro(int nComp_Ide)
        {
            ENResultOperation R = ClsCombustible_CompraBC.Buscar_Comprobante(nComp_Ide);
            DataTable dtg = (DataTable)R.Valor;
            if (dtg.Rows.Count != 0)
            {
                DataRow ROWG = dtg.Rows[0];
                txtProve.Text = ROWG["RAZON_SOCIAL"].ToString();
                txtProve_Ide.Text = ROWG["PROV_IDE"].ToString();
                dtpFecha.Text = ROWG["COMP_FECHA"].ToString();
                txtNumero.Text = ROWG["COMP_NUMERO"].ToString();
                txtTran_Ide.Text = ROWG["TRAN_IDE"].ToString();
                txtTransportista.Text = ROWG["TRANSPORTISTA"].ToString();
                txtPlaca.Text = ROWG["PLACA"].ToString();
                txtKilometraje.Text = ROWG["COMP_KILOMETRAJE"].ToString();
                txtChofer.Text = ROWG["CHOFER"].ToString();
                txtCantidad.Text = ROWG["COMP_CANTIDAD"].ToString();
                txtImporte.Text = ROWG["COMP_IMPORTE"].ToString();
                cboTipoCombustible.Text = ROWG["COMP_TIPO_COMBUSTIBLE"].ToString();
                txtVehi_Ide.Text = ROWG["TRAN_VEHI_IDE"].ToString();
                txtChof_Ide.Text = ROWG["TRAN_CHOF_IDE"].ToString();
                txtOrden.Text = ROWG["ORDENES"].ToString();
                txtKmFinal.Text = ROWG["KMS_POSTERIOR"].ToString();
                txtComb_Inicio.Text = ROWG["COMB_INICIO"].ToString();
                txtComb_Final.Text = ROWG["COMB_FINAL"].ToString();
                txtDeposito.Text = ROWG["COMp_LUGAR"].ToString();
                tonelaje = ROWG["TONELAJE"].ToString();
                if (!string.IsNullOrEmpty(ROWG["KMS_POSTERIOR"].ToString()))
                {
                nRecorrido = Convert.ToInt32(ROWG["KMS_POSTERIOR"].ToString()) - Convert.ToInt32(ROWG["COMP_KILOMETRAJE"].ToString());
                nEficiencia = nRecorrido / Convert.ToDecimal(txtCantidad.Text.ToString());
                txtEficiencia.Text = nEficiencia.ToString("##,###.000");
                }
                else
                {
                    nRecorrido = 0;
                }
                txtRecorrido.Text = nRecorrido.ToString();
                nTran_Ide = Convert.ToInt32(txtTran_Ide.Text);
                nProve_Ide = Convert.ToInt32(txtProve_Ide.Text);
                nTran_Vehi_Ide = Convert.ToInt32(ROWG["TRAN_VEHI_IDE"]);
                nTran_Chof_Ide = Convert.ToInt32(ROWG["TRAN_CHOF_IDE"]);
                Mostrar_Unitario();

                Obtener_Datos_Vehiculo(nTran_Ide.ToString(), nTran_Vehi_Ide.ToString());

                //ENResultOperation S = ClsRecojo_CabeceraBC.Buscar_Orden(Convert.ToInt32(txtOrden.Text));
                //if (txtOrden.Text == "0") txtOrden.Text = "";
                ///if (S.Proceder)
               // {
                //    DataTable dt = (DataTable)S.Valor;
                //    if (dt.Rows.Count == 1)
                 //   {
                 //       DataRow ROW = dt.Rows[0];
                  //      //txtFecha_Orden.Text = Convert.ToDateTime(ROW["RECO_FECHA_EMISION"]).ToString("dd/MM/yyyy");
                 //   }
                //}
            }
            else
            {
                Habilitar_Botones(true);
            }

        }
        private void Inicializa_Campos()
        {
            txtProve_Ide.Text = "";
            txtProve.Text = "";
            dtpFecha.Text = DateTime.Now.ToString();
            txtNumero.Text = "";
            txtTransportista.Text = "TERAH";
            nTran_Ide = 2564;
            txtTran_Ide.Text = "2564";
            txtPlaca.Text = "";
            txtVehi_Ide.Text = "";
            txtChofer.Text = "";
            txtChof_Ide.Text = "";
            txtCantidad.Text = "";
            txtImporte.Text = "";
            txtKilometraje.Text = "";
            txtOrden.Text = "";
            cboTipoCombustible.SelectedIndex = 0;
            txtDeposito.Text = "";
            txtComb_Inicio.Text = "";
            txtComb_Final.Text = "";
        }
        private void Habilitar_Campos(Boolean Flag)
        {
            txtProve.ReadOnly = !Flag;
            dtpFecha.Enabled = Flag;
            txtNumero.ReadOnly = !Flag;
            txtTransportista.ReadOnly = !Flag;
            txtPlaca.ReadOnly = !Flag;
            txtChofer.ReadOnly = !Flag;
            txtCantidad.ReadOnly = !Flag;
            txtImporte.ReadOnly = !Flag;
            txtKilometraje.ReadOnly = !Flag;
            txtDeposito.ReadOnly = !Flag;
            txtComb_Inicio.ReadOnly = !Flag;
            txtComb_Final.ReadOnly = !Flag;
            cboTipoCombustible.Enabled = Flag;
            btnGrabar.Text = "Grabar";
            if (string.IsNullOrEmpty(txtOrden.Text))
            {
                lblKmFinal.Visible = false;
                txtKmFinal.Visible = false;
                lblRecorrido.Visible = false;
                txtRecorrido.Visible = false;
                txtOrden.Visible = false;
                lblorden.Visible = false;
                lblEficiencia.Visible = false;
                txtEficiencia.Visible = false;
                txtRendimiento.Visible = false;
            }
            else
            {
                lblKmFinal.Visible = true;
                txtKmFinal.Visible = true;
                lblRecorrido.Visible = true;
                txtRecorrido.Visible = true;
                txtOrden.Visible = true;
                lblorden.Visible = true;
                lblEficiencia.Visible = true;
                txtEficiencia.Visible = true;
                txtRendimiento.Visible = true;


                txtKmFinal.ReadOnly = true;
                txtRecorrido.ReadOnly = true;
                txtOrden.ReadOnly    = true;
                txtEficiencia.ReadOnly = true;
                txtRendimiento.ReadOnly = true;

            }


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
                MessageBox.Show("No se Ha seleccionado un Proveedor de Combustible", "Grifo");
                return false;
            }
            if (string.IsNullOrEmpty(txtNumero.Text))
            {
                MessageBox.Show("No se Ha Ingresado Numero de Factura", "Grifo");
                return false;
            }
            if (string.IsNullOrEmpty(txtTran_Ide.Text))
            {
                MessageBox.Show("No se Ha seleccionado un Transportista ", "Grifo");
                return false;
            }
            if (string.IsNullOrEmpty(txtTransportista.Text))
            {
                MessageBox.Show("No se Ha seleccionado Transportista ", "Grifo");
                return false;
            }
            if (string.IsNullOrEmpty(txtVehi_Ide.Text))
            {
                MessageBox.Show("No se Ha seleccionado Placa de Vehiculo", "Grifo");
                return false;
            }
            if (string.IsNullOrEmpty(txtChof_Ide.Text))
            {
                MessageBox.Show("No se Ha seleccionado Chofer - Id", "Grifo");
                return false;
            }
            if (string.IsNullOrEmpty(txtChofer.Text))
            {
                MessageBox.Show("No se Ha seleccionado Chofer - Nombre", "Grifo");
                return false;
            }
            if (string.IsNullOrEmpty(txtPlaca.Text))
            {
                MessageBox.Show("No se Ha seleccionado Placa de Vehiculo", "Grifo");
                return false;
            }
            if (string.IsNullOrEmpty(txtCantidad.Text))
            {
                MessageBox.Show("No se Ha seleccionado Cantidad de Combustible ", "Grifo");
                return false;
            }
            if (string.IsNullOrEmpty(txtImporte.Text))
            {
                MessageBox.Show("No se Ha Ingresado Monto Total de Combustible ", "Grifo");
                return false;
            }
            return true;
        }

        private void Procesar_Operacion()
        {
            ClsCombustible_CompraBE TipoBE = new ClsCombustible_CompraBE();
            TipoBE.Comp_ide = iComp_Ide;
            TipoBE.Comp_fecha = Convert.ToDateTime(dtpFecha.Text);
            TipoBE.Prov_ide = nProve_Ide;
            TipoBE.Comp_numero = txtNumero.Text;
            TipoBE.Comp_tipo_combustible = cboTipoCombustible.Text;
            TipoBE.Comp_cantidad = Convert.ToDecimal(txtCantidad.Text);
            TipoBE.Comp_importe = Convert.ToDecimal(txtImporte.Text);
            TipoBE.Comp_kilometraje = Convert.ToInt32(txtKilometraje.Text);
            TipoBE.Tran_ide = nTran_Ide;
            TipoBE.Tran_vehi_ide = nTran_Vehi_Ide;
            TipoBE.Tran_chof_ide = nTran_Chof_Ide;
            TipoBE.Comp_lugar = txtDeposito.Text;
            TipoBE.Estado = 0;
            TipoBE.Usuario = CapaPresentacion.VarGlobales.NombreUsuario;
            TipoBE.Comp_orden = 0;
            TipoBE.Creacion = Convert.ToDateTime(DateTime.Today);
            DateTime FechaPosterior = new DateTime(2000, 1, 1);
            TipoBE.Fecha_posterior = FechaPosterior;
            TipoBE.Kms_posterior = 0;
            TipoBE.Tonelaje = tonelaje;
            TipoBE.Comb_inicio = txtComb_Inicio.Text;
            TipoBE.Comb_final = txtComb_Final.Text;

            TipoBE.Nombre_error = "";

            switch (Operacion)
            {
                case "N":
                    {
                        ENResultOperation R = ClsCombustible_CompraBC.Crear(TipoBE);
                        if (!R.Proceder) MessageBox.Show("Error al Insertar Compra de Combustible " + R.Sms);
                        break;
                    }
                case "M":
                    {
                        ENResultOperation R = ClsCombustible_CompraBC.Actualizar(TipoBE);
                        if (!R.Proceder) MessageBox.Show("Error al Modificar Compra de Combustible " + R.Sms);
                        break;
                    }
                case "E":
                    {
                        ENResultOperation R = ClsCombustible_CompraBC.Eliminar(TipoBE);
                        if (!R.Proceder) MessageBox.Show("Error al Eliminar Compra de Combustible " + R.Sms);
                        break;
                    }
            }
            if (!Buscar_Precio_Combustible()) Graba_Precio_Combustible();
            Asunto  = "Abastecimiento de Combustible Placa : " + txtPlaca.Text + " del " + dtpFecha.Text;
            Mensaje = "";
            switch (Operacion)
            {
                case "N": Mensaje = "Ingreso      Del  Abastecimiento de Combustible <br>"; break;
                case "M": Mensaje = "Modificacion Del  Abastecimiento de Combustible <br>"; break;
                case "E": Mensaje = "Eliminación  Del  Abastecimiento de Combustible <br>"; break;
            }
            Mensaje += " Proveedor    : " + txtProve.Text +
                  "<br> Fecha        : " + dtpFecha.Text +
                  "<br> Factura      : " + txtNumero.Text +
                  "<br> Placa        : " + txtPlaca.Text + "  " + lblNombre.Text +
                  "<br> Combustible  : " + cboTipoCombustible.Text + 
                  "<br> Kilometraje  : " + Convert.ToInt32(txtKilometraje.Text).ToString("####,###") +
                  "<br> Chofer       : " + txtChofer.Text +
                  "<br> Cantidad     : " + Convert.ToDecimal(txtCantidad.Text).ToString("######,###.000") +
                  "<br> Importe      : " + Convert.ToDecimal(txtImporte.Text).ToString("###,###.00") +
                  "<br> Depositado a : " + txtDeposito.Text;
            enviaMail(From, To, Mensaje, Asunto);
            Mostrar("");
        }

        private Boolean Buscar_Precio_Combustible()
        {
            if (cboTipoCombustible.Text == "Gas") nTipo_Combustible = 0;
            if (cboTipoCombustible.Text == "Gasolina") nTipo_Combustible = 1;
            if (cboTipoCombustible.Text == "Petroleo") nTipo_Combustible = 2;
            ENResultOperation P = ClsCombustible_ImporteBC.Obtener_Registro(nProve_Ide,Convert.ToDateTime(dtpFecha.Text),nTipo_Combustible);
            if (P.Proceder)
            {
                DataTable dtp = (DataTable)P.Valor;
                if (dtp.Rows.Count == 1)
                {
                    //DataRow PROW = dtp.Rows[0];
                    //txtImporte.Text = PROW["GRIFO_IMPORTE"].ToString();
                    return true;
                }
            }
            return false;
        }
        private void Graba_Precio_Combustible()
        {
            nPrecio_Combustible = (Convert.ToDecimal(txtImporte.Text) / Convert.ToDecimal(txtCantidad.Text));
            ClsCombustible_ImporteBE TipoBE = new ClsCombustible_ImporteBE();
            TipoBE.Grifo_fecha = Convert.ToDateTime(dtpFecha.Text);
            TipoBE.Grifo_tipo_combustible = nTipo_Combustible;
            TipoBE.Prov_ide = nProve_Ide;
            TipoBE.Grifo_importe = nPrecio_Combustible;
            TipoBE.Usuario = "JUAN";
            TipoBE.Veces = 0;

            ENResultOperation R = ClsCombustible_ImporteBC.Crear(TipoBE);
            if (!R.Proceder) MessageBox.Show("Error al Insertar Precio de Combustible " + R.Sms);
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
                    frmProveedorBuscar frmBuscarProv = new frmProveedorBuscar();
                    frmBuscarProv.ProveedorRazon = txtProve.Text;
                    frmBuscarProv.ShowDialog();
                    txtProve.Text = "";
                    txtProve.Text = frmBuscarProv.ProveedorRazon;
                    nProve_Ide = Convert.ToInt32(frmBuscarProv.ProveedorID);
                    txtProve_Ide.Text = nProve_Ide.ToString();
                }

            }
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
                    MessageBox.Show("Proveedor de Combustible No Registrado", "Mensaje de Busqueda");
                    txtProve.Focus();
                    return false;
                }
            }
            return false;
        }

        public void Buscar_Transportista()
        {
            ENResultOperation R = ClsTransportistaBC.Listar(txtTransportista.Text);
            if (R.Proceder)
            {
                DataTable dt = (DataTable)R.Valor;
                if (dt.Rows.Count == 1)
                {
                    DataRow ROW = dt.Rows[0];
                    txtTransportista.Text = ROW["TRAN_RAZON_SOCIAL"].ToString();
                    nTran_Ide = Convert.ToInt32(ROW["TRAN_IDE"]);
                    txtTran_Ide.Text = nTran_Ide.ToString();
                }
                else
                {
                    Transportista.frmTransportista_Buscar frmBuscarTran = new Transportista.frmTransportista_Buscar();
                    frmBuscarTran.TransportistaRazon = txtTransportista.Text;
                    frmBuscarTran.ShowDialog();
                    txtTransportista.Text = "";
                    txtTransportista.Text = frmBuscarTran.TransportistaRazon;
                    nTran_Ide = Convert.ToInt32(frmBuscarTran.TransportistaID);
                    txtTran_Ide.Text = nTran_Ide.ToString();
                }

                txtPlaca.Focus();
            }
        }
        private void Buscar_Chofer()
        {
            ENResultOperation R = ClsTransportista_ChoferBC.Listar_Filtro(txtChofer.Text, nTran_Ide);
            if (R.Proceder)
            {
                DataTable dt = (DataTable)R.Valor;
                if (dt.Rows.Count == 1)
                {
                    DataRow ROW = dt.Rows[0];
                    txtChofer.Text = ROW["TRAN_CHOF_NOMBRE"].ToString();
                    txtChof_Ide.Text = ROW["TRAN_CHOF_IDE"].ToString();
                    nTran_Chof_Ide = Convert.ToInt32(ROW["TRAN_CHOF_IDE"]);
                }
                else
                {
                    Transportista.frmTransportista_Chofer_Buscar frmBuscarChof = new Transportista.frmTransportista_Chofer_Buscar();
                    frmBuscarChof.Transportista_Ide = nTran_Ide;
                    frmBuscarChof.Transportista_Nombre = txtChofer.Text;
                    frmBuscarChof.ShowDialog();
                    txtChofer.Text = frmBuscarChof.Transportista_Nombre;
                    txtChof_Ide.Text = frmBuscarChof.Chofer_Ide;
                    nTran_Chof_Ide = Convert.ToInt32(frmBuscarChof.Chofer_Ide);
                }
            }
        }

        private void Obtener_Datos_Vehiculo(string Transportista, string Vehiculo)
        {
            ENResultOperation R = ClsTransportista_VehiculoBC.Obtener_Vehiculo(Vehiculo, Transportista);
            if (R.Proceder)
            {
                DataTable dt = (DataTable)R.Valor;
                if (dt.Rows.Count == 1)
                {
                    DataRow ROW = dt.Rows[0];
                    lblNombre.Text = ROW["TRAN_VEHI_NOMBRE"].ToString();
                    txtRendimiento.Text = ROW["TRAN_VEHI_RENDIMIENTO"].ToString();
                }
            }

        }
        private void Buscar_Placa()
        {
            ENResultOperation R = ClsTransportista_VehiculoBC.Listar_Filtro(txtPlaca.Text, nTran_Ide);
            if (R.Proceder)
            {
                DataTable dt = (DataTable)R.Valor;
                if (dt.Rows.Count == 1)
                {
                    DataRow ROW = dt.Rows[0];
                    txtPlaca.Text = ROW["TRAN_VEHI_PLACA"].ToString();
                    nTran_Ide = Convert.ToInt32(ROW["TRAN_IDE"]);
                    txtTran_Ide.Text = nTran_Ide.ToString();
                    txtVehi_Ide.Text = ROW["TRAN_VEHI_IDE"].ToString();
                    nTran_Vehi_Ide = Convert.ToInt32(ROW["TRAN_VEHI_IDE"]);
                    lblNombre.Text = ROW["TRAN_VEHI_NOMBRE"].ToString();
                    tonelaje = ROW["TRAN_VEHI_TONELAJE"].ToString();
                    nTipo_Combustible = 2;
                    if (ROW["TRAN_VEHI_COMBUSTIBLE"].ToString() == "Gas") nTipo_Combustible = 0;
                    if (ROW["TRAN_VEHI_COMBUSTIBLE"].ToString() == "Gasolina") nTipo_Combustible = 1;
                    if (ROW["TRAN_VEHI_COMBUSTIBLE"].ToString() == "Petroleo") nTipo_Combustible = 2;
                    cboTipoCombustible.SelectedIndex = nTipo_Combustible;
                }
                else
                {
                    Transportista.frmTransportista_Vehiculo_Buscar frmBuscarVeh = new Transportista.frmTransportista_Vehiculo_Buscar();
                    frmBuscarVeh.Transportista_Ide = nTran_Ide;
                    frmBuscarVeh.Vehiculo_Placa = txtPlaca.Text;
                    frmBuscarVeh.Transportista_Nombre = txtTransportista.Text;
                    frmBuscarVeh.ShowDialog();
                    txtPlaca.Text = frmBuscarVeh.Vehiculo_Placa;
                    nTran_Vehi_Ide = Convert.ToInt32(frmBuscarVeh.Vehiculo_Ide);
                    txtVehi_Ide.Text = nTran_Ide.ToString();
                    lblNombre.Text = frmBuscarVeh.Vehiculo_Nombre;
                    nTipo_Combustible = 2;
                    if (frmBuscarVeh.Tipo_Combustible == "Gas") nTipo_Combustible = 0;
                    if (frmBuscarVeh.Tipo_Combustible == "Gasolina") nTipo_Combustible = 1;
                    if (frmBuscarVeh.Tipo_Combustible == "Petroleo") nTipo_Combustible = 2;
                    cboTipoCombustible.SelectedIndex = nTipo_Combustible;
                }
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
        }
        private void txtProve_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3) Buscar_Proveedor();
        }

        private void txtProve_DoubleClick(object sender, EventArgs e)
        {
            Buscar_Proveedor();
        }

        private void dtpFecha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter) SendKeys.Send("{TAB}");
        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter) SendKeys.Send("{TAB}");
        }

        private void txtTransportista_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTransportista_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter || (int)e.KeyChar == (int)Keys.F3)
            {
                Buscar_Transportista();
            }
        }
        private void txtTransportista_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3) Buscar_Transportista();
        }

        private void txtKilometraje_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter) SendKeys.Send("{TAB}");
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Enter))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtPlaca_Validated(object sender, EventArgs e)
        {

        }
        private void txtPlaca_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter || (int)e.KeyChar == (int)Keys.F3)
            {
                Buscar_Placa();
            }
            if ((int)e.KeyChar == (int)Keys.Enter) SendKeys.Send("{TAB}");
        }
        private void txtPlaca_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3) Buscar_Placa();
        }

        private void txtPlaca_DoubleClick(object sender, EventArgs e)
        {
            Buscar_Placa();
        }

        private void txtChofer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter || (int)e.KeyChar == (int)Keys.F3) Buscar_Chofer();
            if ((int)e.KeyChar == (int)Keys.Enter) SendKeys.Send("{TAB}");
        }
        private void txtChofer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3) Buscar_Chofer();
        }
        private void txtChofer_DoubleClick(object sender, EventArgs e)
        {
            Buscar_Chofer();
        }

        private void cboTipoCombustible_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter) SendKeys.Send("{TAB}");
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter) SendKeys.Send("{TAB}");
        }

        private void txtImporte_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter) SendKeys.Send("{TAB}");
        }

        private void btnMGrabar_Click(object sender, EventArgs e)
        {

        }

        private void btnMCancelar_Click(object sender, EventArgs e)
        {

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
                case "Fecha": campo_busqueda = "Fecha";
                    condi_busqueda =  txtBuscar.Text.Trim();
                    break;
                case "Razon Social Proveedor": campo_busqueda = "Razon_Social";
                    condi_busqueda = txtBuscar.Text.Trim();
                    break;
                case "Placa": campo_busqueda = "Placa";
                    condi_busqueda = txtBuscar.Text.Trim();
                    break;
            }
            Ejecutar_filtro(campo_busqueda, condi_busqueda, dtpFecIni.Value, dtpFecFin.Value);
        }

        private void Ejecutar_filtro(string campo_busqueda, string condi_busqueda, DateTime FecIni, DateTime FecFin)
        {

            DataTable TEMP = new DataTable();
            ENResultOperation R = ClsCombustible_CompraBC.Listar_Filtro(campo_busqueda, condi_busqueda,FecIni, FecFin);
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
            ENResultOperation R = ClsCombustible_CompraBC.Listar_por_Fechas(dtpFecIni.Value,dtpFecFin.Value);
            if (R.Proceder) dgvListado.DataSource = (DataTable)R.Valor;
            TEMP = (DataTable)R.Valor;
        }

        private void cboBuscarPor_Validated(object sender, EventArgs e)
        {
            txtBuscar.Text = "";
        }

        private void cboBuscarPor_SelectedValueChanged(object sender, EventArgs e)
        {
            txtBuscar.Text = "";
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            Reportes.rptCombustible frmrpt = new Reportes.rptCombustible();
            frmrpt.fecha1 = dtpFecIni.Value;
            frmrpt.fecha2 = dtpFecFin.Value;
            frmrpt.RangoFecha = "Del : " + dtpFecIni.Value.ToShortDateString() + " Al : " + dtpFecFin.Value.ToShortDateString();
            frmrpt.Empresa = "TERAH S.A.C";
            frmrpt.Titulo = "REPORTE DE COMPRA DE COMBUSTIBLE";
            frmrpt.Show();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
        
        private void Buscar_Orden(string Orden)
        {
            ENResultOperation R = ClsRecojo_CabeceraBC.Buscar_Orden(Convert.ToInt32(txtOrden.Text));
            if (R.Proceder)
            {
                DataTable dt = (DataTable)R.Valor;
                if (dt.Rows.Count == 1)
                {
                    DataRow ROW = dt.Rows[0];
                    //txtFecha_Orden.Text = Convert.ToDateTime(ROW["RECO_FECHA_EMISION"]).ToString("dd/MM/yyyy");
                }
                else
                {
                    MessageBox.Show("Numero de Orden no esta Registrada en el Sistema", "Mensaje");
                    //txtFecha_Orden.Text = "";
                    //txtOrden.Text = "";
                }
            }
        }
        
        private void txtOrden_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!string.IsNullOrEmpty(txtOrden.Text) && txtOrden.Text != "0")
                {
                   //Buscar_Orden(txtOrden.Text);
                }
                else
                {
                    //txtFecha_Orden.Text = "";
                }
            }
        }

        private void txtOrden_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter) SendKeys.Send("{TAB}");
        }

        private void txtImporte_Validated(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCantidad.Text))
            {
                Mostrar_Unitario();
            }
        }
        
        private void Mostrar_Unitario()
        {
            if (!string.IsNullOrEmpty(txtImporte.Text))
            {
                txtUnitario.Text = (Convert.ToDecimal(txtImporte.Text) / Convert.ToDecimal(txtCantidad.Text)).ToString("###,###.000");
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ENResultOperation R = ClsCombustible_CompraBC.Reprocesar_Consumo(dtpFecIni.Value, dtpFecFin.Value);
            if (!R.Proceder)
            {
                MessageBox.Show("No se Actualizo Correctamente : " + R.Sms,"Mensaje de Alerta");
            }
            else
            {
                Mostrar("");
            }
        }

        public bool enviaMail(string From, string To, string Message, string Subject, List<string> Archivo = null)
        {
            //una validación básica
            if (To.Trim().Equals("") || Message.Trim().Equals("") || Subject.Trim().Equals(""))
            {
                error = "El mail, el asunto y el mensaje son obligatorios";
                return false;
            }

            //aqui comenzamos el proceso
            //comienza-------------------------------------------------------------------------
            try
            {
                //creamos un objeto tipo MailMessage
                //este objeto recibe el sujeto o persona que envia el mail,
                //la direccion de procedencia, el asunto y el mensaje
                Email = new System.Net.Mail.MailMessage(From, To, Subject, Message);

                //si viene archivo a adjuntar
                //realizamos un recorrido por todos los adjuntos enviados en la lista
                //la lista se llena con direcciones fisicas, por ejemplo: c:/pato.txt
                if (Archivo != null)
                {
                    //agregado de archivo
                    foreach (string archivo in Archivo)
                    {
                        //comprobamos si existe el archivo y lo agregamos a los adjuntos
                        if (System.IO.File.Exists(@archivo))
                            Email.Attachments.Add(new Attachment(@archivo));

                    }
                }

                Email.IsBodyHtml = true; //definimos si el contenido sera html
                Email.From = new MailAddress(From); //definimos la direccion de procedencia

                //aqui creamos un objeto tipo SmtpClient el cual recibe el servidor que utilizaremos como smtp
                //en este caso me colgare de gmail
                System.Net.Mail.SmtpClient smtpMail = new System.Net.Mail.SmtpClient("smtp.gmail.com");

                smtpMail.EnableSsl = false;//le definimos si es conexión ssl
                smtpMail.UseDefaultCredentials = false; //le decimos que no utilice la credencial por defecto
                //smtpMail.Host = "smtp.gmail.com"; //agregamos el servidor smtp
                smtpMail.Host = "mail.terahsac.com"; //agregamos el servidor smtp
                smtpMail.Port = 587; //le asignamos el puerto, en este caso gmail utiliza el 465
                smtpMail.Credentials = new System.Net.NetworkCredential(DE, PASS); //agregamos nuestro usuario y pass de gmail

                //enviamos el mail
                smtpMail.Send(Email);

                //eliminamos el objeto
                smtpMail.Dispose();

                //MessageBox.Show("Enviado Correo Correctamente", "Mensaje de Envio");

                //regresamos true
                return true;
            }
            catch (Exception ex)
            {
                //si ocurre un error regresamos false y el error
                //MessageBox.Show("Error al Enviar Correo : " + ex.Message, "Mensaje de Envio");
                return false;
            }

        }

    }
}
