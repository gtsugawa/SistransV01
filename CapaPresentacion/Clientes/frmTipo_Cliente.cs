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
    public partial class frmTipo_Cliente : Form
    {

        string Operacion = null;  // Operaciones : N = Nuevo / M = Modificar E = Eliminar
        public frmTipo_Cliente()
        {
            InitializeComponent();
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
            dgv.DefaultCellStyle.Font = new Font("Tahoma", 10);
            /*----------Alterna colores en el grid -------*/
            dgv.RowsDefaultCellStyle.BackColor = Color.LightBlue;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
            /*---Pintado de color a la cabecera del datagrid ---*/
            DataGridViewCellStyle style = this.dgvListado.ColumnHeadersDefaultCellStyle;
            style.BackColor = Color.Honeydew;
            style.ForeColor = Color.Gray;


            //dgv.Columns.Clear();
            dgv.ColumnCount = 22;
            // Setear Cabecera de Columna 
           
            dgv.Columns[0].Name = "IDE";
            dgv.Columns[1].Name = "NOMBRE";
            dgv.Columns[2].Name = "ESTADO";
            dgv.Columns[21].Name = "VECES";

            dgv.Columns[0].Width = 40;
            dgv.Columns[0].HeaderText = "ID";
            dgv.Columns[0].DataPropertyName = "TIPO_CLIE_IDE";

            dgv.Columns[1].Width = 340;
            dgv.Columns[1].HeaderText = "Descripción ";
            dgv.Columns[1].DataPropertyName = "TIPO_CLIE_NOMBRE";

            dgv.Columns[2].Width = 90;
            dgv.Columns[2].HeaderText = "Estado";
            dgv.Columns[2].DataPropertyName = "TIPO_CLIE_ESTADO";

           
            // Columnas que no Deben Verse
            	
            dgv.Columns[3].DataPropertyName = "Pla_Cta_Ide_Factura_Local";
            dgv.Columns[3].Visible = false;
            dgv.Columns[4].DataPropertyName = "Pla_Cta_Ide_Factura_Dolar";
            dgv.Columns[4].Visible = false;
            dgv.Columns[5].DataPropertyName = "Pla_CTa_Ide_Factura_Local_Diferida";
            dgv.Columns[5].Visible = false;
            dgv.Columns[6].DataPropertyName = "PLA_CTA_IDE_FACTURA_DOLAR_DIFERIDA";
            dgv.Columns[6].Visible = false;
            dgv.Columns[7].DataPropertyName = "PLA_CTA_IDE_N_DEBITO_LOCAL";
            dgv.Columns[7].Visible = false;
            dgv.Columns[8].DataPropertyName = "PLA_CTA_IDE_N_DEBITO_DOLAR";
            dgv.Columns[8].Visible = false;
            dgv.Columns[9].DataPropertyName = "PLA_CTA_IDE_N_DEBITO_LOCAL_DIFERIDA";
            dgv.Columns[9].Visible = false;
            dgv.Columns[10].DataPropertyName = "PLA_CTA_IDE_N_DEBITO_DOLAR_DIFERIDA";
            dgv.Columns[10].Visible = false;
            dgv.Columns[11].DataPropertyName = "PLA_CTA_IDE_N_CREDITO_LOCAL";
            dgv.Columns[11].Visible = false;
            dgv.Columns[12].DataPropertyName = "PLA_CTA_IDE_N_CREDITO_DOLAR";
            dgv.Columns[12].Visible = false;
            dgv.Columns[13].DataPropertyName = "PLA_CTA_IDE_N_CREDITO_LOCAL_DIFERIDA";
            dgv.Columns[13].Visible = false;
            dgv.Columns[14].DataPropertyName = "PLA_CTA_IDE_N_CREDITO_DOLAR_DIFERIDA";
            dgv.Columns[14].Visible = false;
            dgv.Columns[15].DataPropertyName = "PLA_CTA_IDE_BOLETA_LOCAL";
            dgv.Columns[15].Visible = false;
            dgv.Columns[16].DataPropertyName = "PLA_CTA_IDE_BOLETA_DOLAR";
            dgv.Columns[16].Visible = false;
            dgv.Columns[17].DataPropertyName = "PLA_CTA_IDE_BOLETA_LOCAL_DIFERIDA";
            dgv.Columns[17].Visible = false;
            dgv.Columns[18].DataPropertyName = "PLA_CTA_IDE_BOLETA_DOLAR_DIFERIDA";
            dgv.Columns[18].Visible = false;
            dgv.Columns[19].DataPropertyName = "TIPO_CLIE_FECHAINAC";
            dgv.Columns[19].Visible = false;
            dgv.Columns[20].DataPropertyName = "CREACION";
            dgv.Columns[20].Visible = false;
            dgv.Columns[21].DataPropertyName = "VECES";
            dgv.Columns[21].Visible = false;
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
            ENResultOperation R = ClsTipo_ClienteBC.Listar(filtro);
            if (R.Proceder) dgvListado.DataSource = (DataTable)R.Valor;
            TEMP = (DataTable)R.Valor;

        }

        private void Inicializa_campos()
        {
            txtIde.Text    = "0";
            txtNombre.Text = "";
            cboEstado.SelectedIndex = 1;  // Activo
        }

        private void Estado_Botones (bool flag)
        {
            btnNuevo.Enabled    = flag;
            btnModifica.Enabled = flag;
            btnElimina.Enabled  = flag;
            btnCancela.Enabled  = !flag;
            btnGraba.Enabled    = !flag;
            btnSalir.Enabled    = flag;
        }
 
        private void frmTipo_Cliente_Load(object sender, EventArgs e)
        {
            FormatoDgv();
            Mostrar_dgv("");
            llenar_CboEstado();
            Estado_Botones(true);
            Deshabilitar_Campos(true);
        }

        private void Mostrar_Datos()
        {
            if (dgvListado.CurrentRow != null)
            {
                txtIde.Text = Convert.ToString(this.dgvListado.CurrentRow.Cells["IDE"].Value);
                txtNombre.Text = Convert.ToString(this.dgvListado.CurrentRow.Cells["NOMBRE"].Value);
                cboEstado.Text = Convert.ToString(this.dgvListado.CurrentRow.Cells["ESTADO"].Value);
                txtVeces.Text  = Convert.ToString(this.dgvListado.CurrentRow.Cells["VECES"].Value);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
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
            btnGraba.Text = "Eliminar";
            Operacion = "E";
            Deshabilitar_Campos(false);
        }

        private void btnCancela_Click(object sender, EventArgs e)
        {
            Estado_Botones(true);
            Deshabilitar_Campos(true);
            Mostrar_Datos();
        }

        private void btnGraba_Click(object sender, EventArgs e)
        {
            Procesar_Operacion();
        }

        private void Procesar_Operacion()
        {
            ClsTipo_ClienteBE TipoBE = new ClsTipo_ClienteBE();
            TipoBE.Tipo_clie_ide = Convert.ToInt32(txtIde.Text);
            TipoBE.Tipo_clie_nombre = txtNombre.Text;
            TipoBE.Tipo_clie_estado = cboEstado.Text;
            TipoBE.Tipo_clie_fechainac = Convert.ToDateTime("01-01-1900");
            TipoBE.Veces = Convert.ToInt32(txtVeces.Text);
            TipoBE.Usuario = "ADMIN";
            TipoBE.Creacion = Convert.ToDateTime(DateTime.Today);

            TipoBE.Nombre_error = "";
            TipoBE.Pla_cta_ide_boleta_dolar = 0;
            TipoBE.Pla_cta_ide_boleta_dolar_diferida = 0;
            TipoBE.Pla_cta_ide_factura_local = 0;
            TipoBE.Pla_cta_ide_factura_dolar = 0;

            TipoBE.Pla_cta_ide_factura_local_diferida = 0;
            TipoBE.Pla_cta_ide_factura_dolar_diferida = 0;
            TipoBE.Pla_cta_ide_n_debito_local = 0;
            TipoBE.Pla_cta_ide_n_debito_dolar = 0;
            TipoBE.Pla_cta_ide_n_debito_local_diferida = 0;
            TipoBE.Pla_cta_ide_n_debito_dolar_diferida = 0;
            TipoBE.Pla_cta_ide_n_credito_local = 0;
            TipoBE.Pla_cta_ide_n_credito_dolar = 0;
            TipoBE.Pla_cta_ide_n_credito_local_diferida = 0;
            TipoBE.Pla_cta_ide_n_credito_dolar_diferida = 0;
            TipoBE.Pla_cta_ide_boleta_local = 0;
            TipoBE.Pla_cta_ide_boleta_dolar = 0;
            TipoBE.Pla_cta_ide_boleta_local_diferida = 0;
            TipoBE.Pla_cta_ide_boleta_dolar_diferida = 0;

            switch (Operacion)
            {
                case "N": ClsTipo_ClienteBC.Crear(TipoBE);
                    break;
                case "M": ClsTipo_ClienteBC.Actualizar(TipoBE);
                    break;
                case "E": ClsTipo_ClienteBC.Eliminar(TipoBE);
                    break;
            }

            Estado_Botones(true);
            Deshabilitar_Campos(true);
            Mostrar_dgv("");
            Mostrar_Datos();
            btnGraba.Text = "Grabar";
        }

        private void Deshabilitar_Campos(bool Flag)
        {
            txtIde.ReadOnly    = true;
            txtNombre.ReadOnly = Flag;
            cboEstado.Enabled  = !Flag;
        }

        private void dgvListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgvListado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Mostrar_Datos();

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            //MessageBox.Show("Valor del Texto : " + txtNombre.Text);
        }

        private void dgvListado_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dgvListado_CurrentCellChanged(object sender, EventArgs e)
        {
            Mostrar_Datos();
        }
    }
}
