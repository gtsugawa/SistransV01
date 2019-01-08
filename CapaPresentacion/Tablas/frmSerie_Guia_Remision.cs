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
    public partial class frmSerie_Guia_Remision : Form
    {
        string Operacion = null;  // Operaciones : N = Nuevo / M = Modificar E = Eliminar
        string Serie_Anterior = null;
        public frmSerie_Guia_Remision()
        {
            InitializeComponent();
        }

        private void frmSerie_Guia_Remision_Load(object sender, EventArgs e)
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
            dgv.ColumnCount = 10;
            // Setear Cabecera de Columna 

            dgv.Columns[0].Name = "SERIE";
            dgv.Columns[1].Name = "CONTADOR";
            dgv.Columns[2].Name = "NUMERO_LINEAS";
            dgv.Columns[3].Name = "NOMBRE_LUGAR";
            dgv.Columns[4].Name = "TERMINAL";
            dgv.Columns[5].Name = "TIENDA";
            dgv.Columns[6].Name = "ESTADO";
            dgv.Columns[7].Name = "INACTIVA";
            dgv.Columns[8].Name = "CREACION";
            dgv.Columns[9].Name = "VECES";

            dgv.Columns[0].Width = 60;
            dgv.Columns[0].HeaderText = "SERIE";
            dgv.Columns[0].DataPropertyName = "SERIE_NUMERO";

            dgv.Columns[1].Width = 80;
            dgv.Columns[1].HeaderText = "Contador";
            dgv.Columns[1].DataPropertyName = "SERIE_CONTADOR";

            dgv.Columns[2].Width = 90;
            dgv.Columns[2].HeaderText = "Nro.Lineas";
            dgv.Columns[2].DataPropertyName = "SERIE_NUMERO_LINEAS";

            dgv.Columns[3].Width = 160;
            dgv.Columns[3].HeaderText = "Lugar";
            dgv.Columns[3].DataPropertyName = "SERIE_NOMBRE_LUGAR";

            dgv.Columns[4].Width = 60;
            dgv.Columns[4].HeaderText = "Terminal";
            dgv.Columns[4].DataPropertyName = "SERIE_TERMINAL_FORMATO";

            dgv.Columns[5].Width = 60;
            dgv.Columns[5].HeaderText = "Tienda";
            dgv.Columns[5].DataPropertyName = "TIENDA_IDE";
            dgv.Columns[5].Visible = false;

            dgv.Columns[6].Width = 70;
            dgv.Columns[6].HeaderText = "Estado";
            dgv.Columns[6].DataPropertyName = "SERIE_ESTADO";


            // Columnas que no Deben Verse

            dgv.Columns[7].DataPropertyName = "SERIE_FECHAINAC";
            dgv.Columns[7].Visible = false;

            dgv.Columns[8].DataPropertyName = "CREACION";
            dgv.Columns[8].Visible = false;

            dgv.Columns[9].DataPropertyName = "VECES";
            dgv.Columns[9].Visible = false;

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
            ENResultOperation R = ClsSerie_Guia_RemisionBC.Listar(filtro);
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
            txtSerie.Text     = "0";
            txtContador.Text  = "0";
            txtNroLineas.Text = "0";
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
                txtSerie.Text = Convert.ToString(this.dgvListado.CurrentRow.Cells["SERIE"].Value);
                txtContador.Text = Convert.ToString(this.dgvListado.CurrentRow.Cells["CONTADOR"].Value);
                txtNroLineas.Text = Convert.ToString(this.dgvListado.CurrentRow.Cells["NUMERO_LINEAS"].Value);
                txtLugar.Text = Convert.ToString(this.dgvListado.CurrentRow.Cells["NOMBRE_LUGAR"].Value);
                txtTerminal.Text = Convert.ToString(this.dgvListado.CurrentRow.Cells["TERMINAL"].Value);
                txtVeces.Text = Convert.ToString(this.dgvListado.CurrentRow.Cells["VECES"].Value);
                cboEstado.Text = Convert.ToString(this.dgvListado.CurrentRow.Cells["ESTADO"].Value);
                cboTienda.SelectedValue = Convert.ToInt32(this.dgvListado.CurrentRow.Cells["TIENDA"].Value);
                Serie_Anterior = Convert.ToString(this.dgvListado.CurrentRow.Cells["SERIE"].Value);
            }
        }

        private void Habilita_Campos(bool Flag)
        {
            txtSerie.Enabled = Flag;
            txtContador.Enabled = Flag;
            txtNroLineas.Enabled = Flag;
            txtLugar.Enabled = Flag;
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
            if (!Verifica_Campos(txtLugar.Text))
            {
                MessageBox.Show("Campo de Lugar no puede estar sin Valor");
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
            ClsSerie_Guia_RemisionBE TipoBE = new ClsSerie_Guia_RemisionBE();
            TipoBE.Serie_numero = Convert.ToString(txtSerie.Text);
            TipoBE.Serie_contador = Convert.ToInt32(txtContador.Text);
            TipoBE.Serie_numero_lineas = Convert.ToInt32(txtNroLineas.Text);
            TipoBE.Serie_nombre_lugar = Convert.ToString(txtLugar.Text);
            TipoBE.Serie_terminal_formato = Convert.ToString(txtTerminal.Text);
            TipoBE.Tienda_ide  = Convert.ToInt32(cboTienda.SelectedValue.ToString());
            TipoBE.Serie_fechainac = Convert.ToDateTime("01-01-1900");
            TipoBE.Serie_estado = cboEstado.Text;
            TipoBE.Veces = Convert.ToInt32(txtVeces.Text);
            TipoBE.Usuario = "ADMIN";
            TipoBE.Creacion = Convert.ToDateTime(DateTime.Today);
            TipoBE.Serie_anterior = Serie_Anterior;

            TipoBE.Nombre_error = "";

            switch (Operacion)
            {
                case "N":
                    {
                        ENResultOperation R = ClsSerie_Guia_RemisionBC.Crear(TipoBE);
                        if (!R.Proceder) MessageBox.Show("Error al Insertar Serie de Guia de Remision : " + R.Sms);
                        break;
                    }
                case "M":
                    {
                        ENResultOperation R = ClsSerie_Guia_RemisionBC.Actualizar(TipoBE);
                        if (!R.Proceder) MessageBox.Show("Error al Modificar Serie de Guia de Remision : " + R.Sms);
                        break;
                    }
                case "E":
                    {
                        ENResultOperation R = ClsSerie_Guia_RemisionBC.Eliminar(TipoBE);
                        if (!R.Proceder) MessageBox.Show("Error al Eliminar Serie de Guia de Remision : " + R.Sms);
                        break;
                    }
            }

            Estado_Botones(true);
            Habilita_Campos(true);
            Mostrar_dgv("");
            Mostrar_Datos();
        }
    }
}
