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

namespace CapaPresentacion.Tablas
{
    public partial class frmConcepto_Factura : Form
    {
        string Operacion = null;  // Operaciones : N = Nuevo / M = Modificar E = Eliminar
        string Mens_Error = "";
        Boolean Flg_Retorno = true;
        public frmConcepto_Factura()
        {
            InitializeComponent();
        }

        private void frmConcepto_Factura_Load(object sender, EventArgs e)
        {
            FormatoDgv();
            Mostrar_dgv("");
            Cargar_ComboBox();
            Habilita_Campos(false);
        }

        private void Mostrar_dgv(string filtro)
        {
            ENResultOperation R = ClsConcepto_FacturaBC.ListarTodos(filtro);
            if (R.Proceder)
            {
                dgvListado.DataSource = (DataTable)R.Valor;
            }
            else
            {
                MessageBox.Show("Error al Obtener Valores : " + R.Sms);
            }
        }

        void FormatoDgv()
        {

            var dgv = dgvListado;

            dgv.MultiSelect = false;
            dgv.ReadOnly = true;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            //---------Centrar titulo de cabecera --------------/
            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //-- No se hace visible la primera columna del datagrid /
            dgv.RowHeadersVisible = false;
            //---No premite cambiar el tamaño a la columna/
            dgv.AllowUserToResizeColumns = false;
            dgv.AllowUserToResizeRows = false;
            //---------------Tipo de fuente y tamaño-----/
            dgv.DefaultCellStyle.Font = new Font("Tahoma", 10);
            //----------Alterna colores en el grid -------/
            dgv.RowsDefaultCellStyle.BackColor = Color.LightBlue;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
            //---Pintado de color a la cabecera del datagrid ---/
            DataGridViewCellStyle style = this.dgvListado.ColumnHeadersDefaultCellStyle;
            style.BackColor = Color.Honeydew;
            style.ForeColor = Color.Gray;


            dgv.Columns.Clear();
            dgv.ColumnCount = 15;
            // Setear Cabecera de Columna 

            dgv.Columns[0].Name = "IDE";
            dgv.Columns[1].Name = "CODIGO";
            dgv.Columns[2].Name = "NOMBRE";
            dgv.Columns[3].Name = "IMPUESTO";
            dgv.Columns[4].Name = "RECARGO";
            dgv.Columns[5].Name = "CTA_IDE";
            dgv.Columns[6].Name = "CTA_IDE_DES";
            dgv.Columns[7].Name = "CTA_IDE_DEV";
            dgv.Columns[8].Name = "LINEA_NEGOCIO";
            dgv.Columns[9].Name = "COSTO_PROD";
            dgv.Columns[10].Name = "ACTI_PROD";
            dgv.Columns[11].Name = "ESTADO";
            dgv.Columns[12].Name = "INACTIVA";
            dgv.Columns[13].Name = "CREACION";
            dgv.Columns[14].Name = "VECES";


            dgv.Columns[0].Width = 40;
            dgv.Columns[0].HeaderText = "ID";
            dgv.Columns[0].DataPropertyName = "MERCA_IDE";

            dgv.Columns[1].Width = 90;
            dgv.Columns[1].HeaderText = "Codigo  ";
            dgv.Columns[1].DataPropertyName = "MERCA_CODIGO";

            dgv.Columns[2].Width = 310;
            dgv.Columns[2].HeaderText = "Nombre";
            dgv.Columns[2].DataPropertyName = "MERCA_NOMBRE";

            dgv.Columns[3].Width = 70;
            dgv.Columns[3].HeaderText = "Impuesto";
            dgv.Columns[3].DataPropertyName = "MERCA_IMPUESTO";

            dgv.Columns[4].Width = 70;
            dgv.Columns[4].HeaderText = "Recargo";
            dgv.Columns[4].DataPropertyName = "MERCA_RECARGO";

            dgv.Columns[11].Width = 70;
            dgv.Columns[11].HeaderText = "Estado";
            dgv.Columns[11].DataPropertyName = "MERCA_ESTADO";

            dgv.Columns[5].DataPropertyName = "PLA_CTA_IDE";
            dgv.Columns[5].Visible = false;

            dgv.Columns[6].DataPropertyName = "PLA_CTA_IDE_DES";
            dgv.Columns[6].Visible = false;

            dgv.Columns[7].DataPropertyName = "PLA_CTA_IDE_DEV";
            dgv.Columns[7].Visible = false;

            dgv.Columns[8].DataPropertyName = "LINEA_NEGO_IDE";
            dgv.Columns[8].Visible = false;

            dgv.Columns[9].DataPropertyName = "COST_PROD_IDE";
            dgv.Columns[9].Visible = false;

            dgv.Columns[10].DataPropertyName = "ACTI_PROD_IDE";
            dgv.Columns[10].Visible = false;

            dgv.Columns[12].DataPropertyName = "MERCA_FECHAINAC";
            dgv.Columns[12].Visible = false;

            dgv.Columns[13].DataPropertyName = "CREACION";
            dgv.Columns[13].Visible = false;

            dgv.Columns[14].DataPropertyName = "VECES";
            dgv.Columns[14].Visible = false;
        }

        private void Cargar_ComboBox()
        {
            cboEstado.Items.Clear();
            cboEstado.Items.Add("Activo");
            cboEstado.Items.Add("Inactivo");
            cboEstado.SelectedIndex = 0;

            cboImpuesto.Items.Clear();
            cboImpuesto.Items.Add("Activo");
            cboImpuesto.Items.Add("Inactivo");
            cboImpuesto.SelectedIndex = 0;

            rbtRecargoSi.Checked = false;
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

        private void Inicializa_campos()
        {
            txtIde.Text = "0";
            txtNombre.Text = "";
            txtCodigo.Text = "";
            txtVeces.Text = "0";
            cboEstado.Text = "Activo";
            cboImpuesto.Text = "Afecto";
            rbtRecargoSi.Checked = false;
            rbtRecargoNo.Checked = true;
        }

        private void Habilita_Campos(bool Flag)
        {
            txtIde.ReadOnly = true;
            txtNombre.Enabled = Flag;
            txtCodigo.Enabled = Flag;
            cboImpuesto.Enabled = Flag;
            cboEstado.Enabled = Flag;
            rbtRecargoSi.Enabled = Flag;
            rbtRecargoNo.Enabled = Flag;
        }


        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Operacion = "N";
            Estado_Botones(false);
            Inicializa_campos();
            Habilita_Campos(true);
            txtCodigo.Focus();
        }

        private void btnModifica_Click(object sender, EventArgs e)
        {
            Operacion = "M";
            Estado_Botones(false);
            Habilita_Campos(true);
            txtNombre.Focus();
        }

        private void btnElimina_Click(object sender, EventArgs e)
        {
            Operacion = "E";
            Estado_Botones(false);
            btnGraba.Text = "Eliminar";
        }

        private void btnCancela_Click(object sender, EventArgs e)
        {
            Estado_Botones(true);
            Habilita_Campos(false);
            Llenar_Campos();
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

        private Boolean Verifica_Campos(string campo)
        {
            if (String.IsNullOrWhiteSpace(campo)) return false;
            return true;
        }
        private void Llenar_Campos()
        {
            if (dgvListado.CurrentRow != null)
            {
                txtIde.Text = Convert.ToString(this.dgvListado.CurrentRow.Cells["IDE"].Value);
                txtNombre.Text = Convert.ToString(this.dgvListado.CurrentRow.Cells["NOMBRE"].Value);
                txtCodigo.Text = Convert.ToString(this.dgvListado.CurrentRow.Cells["CODIGO"].Value);
                cboEstado.Text = Convert.ToString(this.dgvListado.CurrentRow.Cells["ESTADO"].Value);
                cboImpuesto.Text = Convert.ToString(this.dgvListado.CurrentRow.Cells["IMPUESTO"].Value);
                txtVeces.Text = Convert.ToString(this.dgvListado.CurrentRow.Cells["VECES"].Value);
                if (Convert.ToBoolean(this.dgvListado.CurrentRow.Cells["RECARGO"].Value))
                {
                    rbtRecargoSi.Checked = Convert.ToBoolean(this.dgvListado.CurrentRow.Cells["RECARGO"].Value);
                    rbtRecargoNo.Checked = false;
                }
                else
                {
                    rbtRecargoSi.Checked = false;
                    rbtRecargoNo.Checked = true;

                }
                
            }
        }

        private void Procesar_Operacion()
        {
            ClsConcepto_FacturaBE TipoBE = new ClsConcepto_FacturaBE();
            TipoBE.Merca_ide = Convert.ToInt32(txtIde.Text);
            TipoBE.Merca_nombre = txtNombre.Text;
            TipoBE.Merca_nombre2 = "";
            TipoBE.Merca_nombre_ingles = "";
            TipoBE.Merca_codigo = txtCodigo.Text;
            TipoBE.Merca_estado = cboEstado.Text;
            TipoBE.Pla_cta_ide = 0;

            TipoBE.Pla_cta_ide  = 0;
            TipoBE.Pla_cta_ide_des = 0;
            TipoBE.Pla_cta_ide_dev = 0;
            TipoBE.Linea_nego_ide = 0;
            TipoBE.Cost_prod_ide = 0;
            TipoBE.Acti_prod_ide = 0;

            TipoBE.Pla_cta_ide_relacionada = 0;
            TipoBE.Pla_cta_ide_des_relacionada = 0;
            TipoBE.Pla_cta_ide_dev_relacionada = 0;

            TipoBE.Merca_impuesto = cboImpuesto.Text;
            TipoBE.Veces = Convert.ToInt32(txtVeces.Text);
            if (rbtRecargoSi.Checked)
            {
                TipoBE.Merca_recargo = true;
            }
            else
            {
                TipoBE.Merca_recargo = false;
            }
            
            TipoBE.Merca_fechainac = Convert.ToDateTime("01-01-1900");
            TipoBE.Usuario = "ADMIN";
            TipoBE.Nombre_error = "";

            Mens_Error = "";
            Flg_Retorno = true;

            switch (Operacion)
            {
                case "N":
                    {
                        ENResultOperation R = ClsConcepto_FacturaBC.Crear(TipoBE);
                        if (!R.Proceder) MessageBox.Show("Error al Insertar Concepto Factura : " + R.Sms);
                        break;
                    }
                case "M":
                    {
                        ENResultOperation R = ClsConcepto_FacturaBC.Actualizar(TipoBE);
                        if (!R.Proceder) MessageBox.Show("Error al Modificar Concepto Factura : " + R.Sms);
                        break;
                    }
                case "E":
                    {
                        ENResultOperation R = ClsConcepto_FacturaBC.Eliminar(TipoBE);
                        if (!R.Proceder) MessageBox.Show("Error al Eliminar Concepto Factura : " + R.Sms);
                        break;
                    }
            }
            Estado_Botones(true);
            Habilita_Campos(false);
            Mostrar_dgv("");
            Llenar_Campos();
            btnGraba.Text = "Grabar";
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Buscar_Concepto_Factura(txtBuscar.Text);
        }

        private void Buscar_Concepto_Factura(string filtro)
        {
            ENResultOperation R = ClsConcepto_FacturaBC.ListarTodos(filtro);
            if (R.Proceder)
            {
                dgvListado.DataSource = (DataTable)R.Valor;
            }
            else
            {
                MessageBox.Show("Error al Obtener Valores : " + R.Sms);
            }
        }

        private void txt1Buscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                Buscar_Concepto_Factura(txtBuscar.Text);
            }

        }

        private void dgvListado_CurrentCellChanged(object sender, EventArgs e)
        {
            Llenar_Campos();
        }
    }
}
