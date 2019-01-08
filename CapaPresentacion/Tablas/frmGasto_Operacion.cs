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
    public partial class frmGasto_Operacion : Form
    {
        string Operacion = null;  // Operaciones : N = Nuevo / M = Modificar E = Eliminar
        string Mens_Error = "";
        Boolean Flg_Retorno = true;
        public frmGasto_Operacion()
        {
            InitializeComponent();
        }

        private void frmGasto_Operacion_Load(object sender, EventArgs e)
        {
            FormatoDgv();
            Mostrar_dgv("");
            llenar_CboEstado();
            Estado_Botones(true);
            Deshabilitar_Campos(true);
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

            dgv.Columns[0].Name = "IDE";
            dgv.Columns[1].Name = "NOMBRE";
            dgv.Columns[2].Name = "PLA_CTA";
            dgv.Columns[3].Name = "LINEA_NEGO";
            dgv.Columns[4].Name = "COST_PROD";
            dgv.Columns[5].Name = "ACTI_PROD";
            dgv.Columns[6].Name = "ESTADO";
            dgv.Columns[7].Name = "INACTIVA";
            dgv.Columns[8].Name = "CREACION";
            dgv.Columns[9].Name = "VECES";


            dgv.Columns[0].Width = 40;
            dgv.Columns[0].HeaderText = "ID";
            dgv.Columns[0].DataPropertyName = "GTO_OPE_IDE";

            dgv.Columns[1].Width = 175;
            dgv.Columns[1].HeaderText = "Descripción";
            dgv.Columns[1].DataPropertyName = "GTO_OPE_NOMBRE";

            dgv.Columns[2].Width = 60;
            dgv.Columns[2].HeaderText = "Plan Cuentas";
            dgv.Columns[2].DataPropertyName = "PLA_CTA_IDE";

            dgv.Columns[3].Width = 60;
            dgv.Columns[3].HeaderText = "Linea Negocio";
            dgv.Columns[3].DataPropertyName = "LINEA_NEGO_IDE";

            dgv.Columns[4].Width = 60;
            dgv.Columns[4].HeaderText = "Costo Prod";
            dgv.Columns[4].DataPropertyName = "COST_PROD_IDE";

            dgv.Columns[5].Width = 60;
            dgv.Columns[5].HeaderText = "Actividad Prod";
            dgv.Columns[5].DataPropertyName = "ACTI_PROD_IDE";

            dgv.Columns[6].Width = 70;
            dgv.Columns[6].HeaderText = "Estado";
            dgv.Columns[6].DataPropertyName = "GTO_OPE_ESTADO";


            // Columnas que no Deben Verse

            dgv.Columns[7].DataPropertyName = "GTO_OPE_FECHAINAC";
            dgv.Columns[7].Visible = false;

            dgv.Columns[8].DataPropertyName = "CREACION";
            dgv.Columns[8].Visible = false;

            dgv.Columns[9].DataPropertyName = "VECES";
            dgv.Columns[9].Visible = false;

        }

        private void llenar_CboEstado()
        {
            cboEstado.Items.Add("<Seleccionar>");
            cboEstado.Items.Add("Activo");
            cboEstado.Items.Add("Inactivo");
            cboEstado.SelectedIndex = 0;
        }

        private void Mostrar_dgv(string filtro)
        {
            DataTable TEMP = new DataTable();
            ENResultOperation R = ClsGasto_OperacionBC.Listar(filtro);
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
            txtIde.Text       = "0";
            txtPlaCta.Text    = "0";
            txtNombre.Text    = "";
            txtLineaNego.Text = "0";
            txtCostProd.Text  = "0";
            txtActiProd.Text  = "0";
            txtVeces.Text = "0";
            cboEstado.SelectedIndex = 1;  // Activo
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
                txtIde.Text = Convert.ToString(this.dgvListado.CurrentRow.Cells["IDE"].Value);
                txtPlaCta.Text = Convert.ToString(this.dgvListado.CurrentRow.Cells["PLA_CTA"].Value);
                txtNombre.Text = Convert.ToString(this.dgvListado.CurrentRow.Cells["NOMBRE"].Value);
                txtLineaNego.Text = Convert.ToString(this.dgvListado.CurrentRow.Cells["LINEA_NEGO"].Value);
                txtCostProd.Text = Convert.ToString(this.dgvListado.CurrentRow.Cells["COST_PROD"].Value);
                txtActiProd.Text = Convert.ToString(this.dgvListado.CurrentRow.Cells["ACTI_PROD"].Value);
                txtVeces.Text = Convert.ToString(this.dgvListado.CurrentRow.Cells["VECES"].Value);
                cboEstado.Text = Convert.ToString(this.dgvListado.CurrentRow.Cells["ESTADO"].Value);
            }
        }

        private void Deshabilitar_Campos(bool Flag)
        {
            txtIde.ReadOnly = true;
            txtPlaCta.ReadOnly = Flag;
            txtNombre.ReadOnly = Flag;
            txtVeces.ReadOnly = Flag;
            cboEstado.Enabled = !Flag;
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Estado_Botones(false);
            Inicializa_campos();
            Operacion = "N";
            Deshabilitar_Campos(false);
            txtNombre.Focus();
        }

        private void btnModifica_Click(object sender, EventArgs e)
        {
            Estado_Botones(false);
            Operacion = "M";
            Deshabilitar_Campos(false);
            txtNombre.Focus();
        }

        private void btnElimina_Click(object sender, EventArgs e)
        {
            Estado_Botones(false);
            btnGraba.Enabled = false;
            Operacion = "E";
            if (MessageBox.Show("Seguro de Eliminar Gasto ", "Eliminacion de Gasto", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2, MessageBoxOptions.DefaultDesktopOnly) == DialogResult.Yes)
            {
                Procesar_Operacion();
            }
        }

        private void btnCancela_Click(object sender, EventArgs e)
        {
            Estado_Botones(true);
            Deshabilitar_Campos(true);
            Mostrar_Datos();
        }

        private void btnGraba_Click(object sender, EventArgs e)
        {
            if (!Verifica_Campos(txtNombre.Text))
            {
                MessageBox.Show("Campo de Nombre no puede estar sin Valor");
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
            ClsGasto_OperacionBE TipoBE = new ClsGasto_OperacionBE();
            TipoBE.Gto_ope_ide = Convert.ToInt32(txtIde.Text);
            TipoBE.Gto_ope_nombre = txtNombre.Text;
            TipoBE.Pla_cta_ide = Convert.ToInt32(txtPlaCta.Text);
            TipoBE.Linea_nego_ide = Convert.ToInt32(txtLineaNego.Text);
            TipoBE.Cost_prod_ide = Convert.ToInt32(txtCostProd.Text);
            TipoBE.Acti_prod_ide = Convert.ToInt32(txtActiProd.Text);
            TipoBE.Gto_ope_fechainac = Convert.ToDateTime("01-01-1900");
            TipoBE.Gto_ope_estado = cboEstado.Text;
            TipoBE.Veces = Convert.ToInt32(txtVeces.Text);
            TipoBE.Usuario = "ADMIN";
            TipoBE.Creacion = Convert.ToDateTime(DateTime.Today);

            TipoBE.Nombre_error = "";

            Mens_Error = "";
            Flg_Retorno = true;

            switch (Operacion)
            {
                case "N":
                    {
                        ENResultOperation R = ClsGasto_OperacionBC.Crear(TipoBE);
                        Flg_Retorno = R.Proceder;
                        Mens_Error = R.Sms;
                        break;
                    }
                case "M":
                    {
                        ENResultOperation R = ClsGasto_OperacionBC.Actualizar(TipoBE);
                        Flg_Retorno = R.Proceder;
                        Mens_Error = R.Sms;
                        break;
                    }
                case "E":
                    {
                        ENResultOperation R = ClsGasto_OperacionBC.Eliminar(TipoBE);
                        Flg_Retorno = R.Proceder;
                        Mens_Error = R.Sms;
                        break;
                    }
            }
            if (!Flg_Retorno)
            {
                MessageBox.Show("Error al Ejecutar Operacion : " + Mens_Error);
            }

            Estado_Botones(true);
            Deshabilitar_Campos(true);
            Mostrar_dgv("");
            Mostrar_Datos();
        }

    }
}
