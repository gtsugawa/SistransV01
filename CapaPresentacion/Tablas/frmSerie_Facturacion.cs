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

namespace CapaPresentacion.Tablas
{
    public partial class frmSerie_Facturacion : Form
    {
        string Operacion = null;  // Operaciones : N = Nuevo / M = Modificar E = Eliminar
  
        public frmSerie_Facturacion()
        {
            InitializeComponent();
        }

        private void frmSerie_Facturacion_Load(object sender, EventArgs e)
        {
            FormatoDgv();
            Mostrar_dgv("");
            llenar_CboEstado();
            Llenar_cboTienda();            
            Estado_Botones(true);
            Habilita_Campos(false);
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
            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgv.RowHeadersVisible = false;

            dgv.AllowUserToResizeColumns = false;
            dgv.AllowUserToResizeRows = false;

            dgv.DefaultCellStyle.Font = new Font("Tahoma", 10);

            dgv.RowsDefaultCellStyle.BackColor = Color.LightBlue;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.White;

            DataGridViewCellStyle style = this.dgvListado.ColumnHeadersDefaultCellStyle;
            style.BackColor = Color.Honeydew;
            style.ForeColor = Color.Gray;


            //dgv.Columns.Clear();
            dgv.ColumnCount = 18;
            // Setear Cabecera de Columna 

            dgv.Columns[0].Name = "SERIE";
            dgv.Columns[1].Name = "CONTADOR";
            dgv.Columns[2].Name = "NUMERO_LINEAS";

            dgv.Columns[3].Name = "DEBITO_CONTADOR"; 
            dgv.Columns[4].Name = "DEBITO_LINEAS";
            dgv.Columns[5].Name = "CREDITO_CONTADOR";
            dgv.Columns[6].Name = "CREDITO_LINEAS";
            dgv.Columns[7].Name = "BOLETA_CONTADOR";
            dgv.Columns[8].Name = "BOLETA_LINEAS";
            dgv.Columns[9].Name = "ATRIBUCION_CONTADOR";
            dgv.Columns[10].Name = "ATRIBUCION_LINEAS";

            dgv.Columns[11].Name = "NOMBRE_LUGAR";
            dgv.Columns[12].Name = "TERMINAL";
            dgv.Columns[13].Name = "TIENDA";
            dgv.Columns[14].Name = "ESTADO";
            dgv.Columns[15].Name = "INACTIVA";
            dgv.Columns[16].Name = "CREACION";
            dgv.Columns[17].Name = "VECES";

            dgv.Columns[0].Width = 40;
            dgv.Columns[0].HeaderText = "SERIE";
            dgv.Columns[0].DataPropertyName = "SERIE_NUMERO";

            dgv.Columns[1].Width = 70;
            dgv.Columns[1].HeaderText = "Factura Contador";
            dgv.Columns[1].DataPropertyName = "SERIE_FACTURA_CONTADOR";

            dgv.Columns[2].Width = 90;
            dgv.Columns[2].HeaderText = "Factura Nro.Lineas";
            dgv.Columns[2].DataPropertyName = "SERIE_FACTURA_NUMERO_LINEAS";

            dgv.Columns[3].Width = 90;
            dgv.Columns[3].HeaderText = "N/Debito Contador";
            dgv.Columns[3].DataPropertyName = "SERIE_N_DEBITO_CONTADOR";

            dgv.Columns[4].Width = 90;
            dgv.Columns[4].HeaderText = "N/Debito Lineas";
            dgv.Columns[4].DataPropertyName = "SERIE_N_DEBITO_NUMERO_LINEAS";

            dgv.Columns[5].Width = 90;
            dgv.Columns[5].HeaderText = "N/Credito Contador";
            dgv.Columns[5].DataPropertyName = "SERIE_N_CREDITO_CONTADOR";

            dgv.Columns[6].Width = 90;
            dgv.Columns[6].HeaderText = "N/Credito Lineas";
            dgv.Columns[6].DataPropertyName = "SERIE_N_CREDITO_NUMERO_LINEAS";

            dgv.Columns[7].Width = 90;
            dgv.Columns[7].HeaderText = "Boleta Contador";
            dgv.Columns[7].DataPropertyName = "SERIE_BOLETA_CONTADOR";

            dgv.Columns[8].Width = 90;
            dgv.Columns[8].HeaderText = "Boleta Lineas";
            dgv.Columns[8].DataPropertyName = "SERIE_BOLETA_NUMERO_LINEAS";

            dgv.Columns[9].Width = 90;
            dgv.Columns[9].HeaderText = "Atribucion Contador";
            dgv.Columns[9].DataPropertyName = "SERIE_DOC_ATRIBUCION_CONTADOR";

            dgv.Columns[10].Width = 90;
            dgv.Columns[10].HeaderText = "Atribucion Lineas";
            dgv.Columns[10].DataPropertyName = "SERIE_DOC_ATRIBUCION_NUMERO_LINEAS";

            dgv.Columns[11].Width = 160;
            dgv.Columns[11].HeaderText = "Lugar";
            dgv.Columns[11].DataPropertyName = "SERIE_NOMBRE_LUGAR";

            dgv.Columns[12].Width = 60;
            dgv.Columns[12].HeaderText = "Terminal";
            dgv.Columns[12].DataPropertyName = "SERIE_TERMINAL_FORMATO";

            dgv.Columns[13].Width = 60;
            dgv.Columns[13].HeaderText = "Tienda";
            dgv.Columns[13].DataPropertyName = "TIENDA_IDE";
            dgv.Columns[13].Visible = false;

            dgv.Columns[14].Width = 70;
            dgv.Columns[14].HeaderText = "Estado";
            dgv.Columns[14].DataPropertyName = "SERIE_ESTADO";


            // Columnas que no Deben Verse

            dgv.Columns[15].DataPropertyName = "SERIE_FECHAINAC";
            dgv.Columns[15].Visible = false;

            dgv.Columns[16].DataPropertyName = "CREACION";
            dgv.Columns[16].Visible = false;

            dgv.Columns[17].DataPropertyName = "VECES";
            dgv.Columns[17].Visible = false;

        }

        private void llenar_CboEstado()
        {
            cboEstado.Items.Clear();
            cboEstado.Items.Add("Activo");
            cboEstado.Items.Add("Inactivo");
            cboEstado.SelectedIndex = 0;
        }
        private void Llenar_cboTienda()
        {
            ENResultOperation R = ClsTiendaBC.Listar("");
            cboTienda.DataSource = (DataTable)R.Valor;
            cboTienda.DisplayMember = "TIENDA_NOMBRE";
            cboTienda.ValueMember = "TIENDA_IDE";
            cboTienda.AutoCompleteMode = AutoCompleteMode.Suggest;
            cboTienda.AutoCompleteSource = AutoCompleteSource.ListItems;
        }


        private void Mostrar_dgv(string filtro)
        {
            DataTable TEMP = new DataTable();
            ENResultOperation R = ClsSerie_FacturacionBC.Listar(filtro);
            if (R.Proceder)
            {
                dgvListado.DataSource = (DataTable)R.Valor;
                TEMP = (DataTable)R.Valor;
            }
            else
            {
                MessageBox.Show("Error al Obtener Valores : " + R.Sms);
            }

        }

        private void Inicializa_campos()
        {
            txtSerie.Text = "0";
            txtFCContador.Text = "0";
            txtFCLineas.Text = "0";
            txtNDContador.Text = "0";
            txtNDLineas.Text = "0";
            txtNCContador.Text = "0";
            txtNCLineas.Text = "0";
            txtBLContador.Text = "0";
            txtBLLineas.Text = "0";
            txtATContador.Text = "0";
            txtATLineas.Text = "0";
            txtLugar.Text = "";
            txtTerminal.Text = "";
            cboTienda.SelectedIndex = 0;
            txtVeces.Text = "0";
            cboEstado.SelectedIndex = 0;  // Activo
        }

        private void Estado_Botones(bool flag)
        {
            btnNuevo.Enabled = flag;
            btnModifica.Enabled = flag;
            btnElimina.Enabled = flag;
            btnCancela.Enabled = !flag;
            btnGraba.Enabled = !flag;
            btnSalir.Enabled = flag;
        }

        private void Mostrar_Datos()
        {
            if (dgvListado.CurrentRow != null)
            {
                txtSerie.Text      = Convert.ToString(this.dgvListado.CurrentRow.Cells["SERIE"].Value);
                txtFCContador.Text = Convert.ToString(this.dgvListado.CurrentRow.Cells["CONTADOR"].Value);
                txtFCLineas.Text   = Convert.ToString(this.dgvListado.CurrentRow.Cells["NUMERO_LINEAS"].Value);

                txtNDContador.Text = Convert.ToString(this.dgvListado.CurrentRow.Cells["DEBITO_CONTADOR"].Value);
                txtNDLineas.Text = Convert.ToString(this.dgvListado.CurrentRow.Cells["DEBITO_LINEAS"].Value);

                txtNCContador.Text = Convert.ToString(this.dgvListado.CurrentRow.Cells["CREDITO_CONTADOR"].Value);
                txtNCLineas.Text = Convert.ToString(this.dgvListado.CurrentRow.Cells["CREDITO_LINEAS"].Value);

                txtBLContador.Text = Convert.ToString(this.dgvListado.CurrentRow.Cells["BOLETA_CONTADOR"].Value);
                txtBLLineas.Text = Convert.ToString(this.dgvListado.CurrentRow.Cells["BOLETA_LINEAS"].Value);

                txtATContador.Text = Convert.ToString(this.dgvListado.CurrentRow.Cells["ATRIBUCION_CONTADOR"].Value);
                txtATLineas.Text = Convert.ToString(this.dgvListado.CurrentRow.Cells["ATRIBUCION_LINEAS"].Value);

                txtLugar.Text = Convert.ToString(this.dgvListado.CurrentRow.Cells["NOMBRE_LUGAR"].Value);
                txtTerminal.Text = Convert.ToString(this.dgvListado.CurrentRow.Cells["TERMINAL"].Value);
                txtVeces.Text = Convert.ToString(this.dgvListado.CurrentRow.Cells["VECES"].Value);
                cboEstado.Text = Convert.ToString(this.dgvListado.CurrentRow.Cells["ESTADO"].Value);
                cboTienda.SelectedValue = Convert.ToInt32(this.dgvListado.CurrentRow.Cells["TIENDA"].Value);
  
            }
        }

        private void Habilita_Campos(bool Flag)
        {
            txtSerie.Enabled = Flag;
            txtFCContador.Enabled = Flag;
            txtFCLineas.Enabled = Flag;
            txtNDContador.Enabled = Flag;
            txtNDLineas.Enabled = Flag;
            txtNCContador.Enabled = Flag;
            txtNCLineas.Enabled = Flag;
            txtBLContador.Enabled = Flag;
            txtBLLineas.Enabled = Flag;
            txtATContador.Enabled = Flag;
            txtATLineas.Enabled = Flag;
            txtLugar.Enabled = Flag;
            txtTerminal.Enabled = Flag;
            txtVeces.Enabled = Flag;
            txtTerminal.Enabled = Flag;
            txtVeces.Enabled = Flag;
            cboEstado.Enabled = Flag;
            cboTienda.Enabled = Flag;
        }


        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Estado_Botones(false);
            Inicializa_campos();
            Operacion = "N";
            Habilita_Campos(true);
            txtSerie.Focus();
        }

        private void btnModifica_Click(object sender, EventArgs e)
        {
            Estado_Botones(false);
            Operacion = "M";
            Habilita_Campos(true);
            txtSerie.Focus();
        }

        private void btnElimina_Click(object sender, EventArgs e)
        {
            Estado_Botones(false);
            btnGraba.Text = "Eliminar";
            Operacion = "E";
        }

        private void btnCancela_Click(object sender, EventArgs e)
        {
            Estado_Botones(true);
            Habilita_Campos(false);
            Mostrar_Datos();
        }

        private void btnGraba_Click(object sender, EventArgs e)
        {
            if (!Verifica_Campos(txtSerie.Text))
            {
                MessageBox.Show("Campo de Serie no puede estar sin Valor");
                return;
            }
            Procesar_Operacion();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvListado_CurrentCellChanged(object sender, EventArgs e)
        {
            Mostrar_Datos();
        }
        private Boolean Verifica_Campos(string campo)
        {
            if (String.IsNullOrWhiteSpace(campo)) return false;
            return true;
        }

        private void Procesar_Operacion()
        {
            ClsSerie_FacturacionBE TipoBE = new ClsSerie_FacturacionBE();
            TipoBE.Serie_numero = Convert.ToString(txtSerie.Text.Trim());
            TipoBE.Serie_factura_contador = Convert.ToInt32(txtFCContador.Text);
            TipoBE.Serie_factura_numero_lineas = Convert.ToInt32(txtFCLineas.Text);
            TipoBE.Serie_n_debito_contador = Convert.ToInt32(txtNDContador.Text);
            TipoBE.Serie_n_debito_numero_lineas = Convert.ToInt32(txtNDLineas.Text);
            TipoBE.Serie_n_credito_contador = Convert.ToInt32(txtNCContador.Text);
            TipoBE.Serie_n_credito_numero_lineas = Convert.ToInt32(txtNCLineas.Text);
            TipoBE.Serie_boleta_contador = Convert.ToInt32(txtBLContador.Text);
            TipoBE.Serie_boleta_numero_lineas = Convert.ToInt32(txtBLLineas.Text);
            TipoBE.Serie_doc_atribucion_contador = Convert.ToInt32(txtATContador.Text);
            TipoBE.Serie_doc_atribucion_numero_lineas = Convert.ToInt32(txtATLineas.Text);
            TipoBE.Serie_nombre_lugar = Convert.ToString(txtLugar.Text);
            TipoBE.Serie_terminal_formato = Convert.ToString(txtTerminal.Text);
            TipoBE.Tienda_ide = Convert.ToInt32(cboTienda.SelectedValue.ToString());
            TipoBE.Serie_fechainac = Convert.ToDateTime("01-01-1900");
            TipoBE.Serie_estado = cboEstado.Text;
            TipoBE.Veces = Convert.ToInt32(txtVeces.Text);
            TipoBE.Usuario = "ADMIN";
            TipoBE.Creacion = Convert.ToDateTime(DateTime.Today);
            TipoBE.Serie_numero_anterior = Convert.ToString(txtSerie.Text);

            TipoBE.Nombre_error = "";

            switch (Operacion)
            {
                case "N":
                    {
                        ENResultOperation R = ClsSerie_FacturacionBC.Crear(TipoBE);
                        if (!R.Proceder) MessageBox.Show("Error al Insertar Serie de Factura : " + R.Sms);
                        break;
                    }
                case "M":
                    {
                        ENResultOperation R = ClsSerie_FacturacionBC.Actualizar(TipoBE);
                        if (!R.Proceder) MessageBox.Show("Error al Modificar Serie de Factura : " + R.Sms);
                        break;
                    }
                case "E":
                    {
                        ENResultOperation R = ClsSerie_FacturacionBC.Eliminar(TipoBE);
                        if (!R.Proceder) MessageBox.Show("Error al Eliminar Factura Serie de Factura : " + R.Sms);
                        break;
                    }
            }

            Estado_Botones(true);
            Habilita_Campos(false);
            Mostrar_dgv("");
            Mostrar_Datos();
            btnGraba.Text = "Grabar";
        }
    }
}
