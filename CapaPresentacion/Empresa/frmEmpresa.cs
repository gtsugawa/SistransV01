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



namespace CapaPresentacion.Empresa
{
    public partial class frmEmpresa : Form
    {
        private string Nombre_BD;
        
        public frmEmpresa()
        {
            InitializeComponent();
        }

        private void frmEmpresa_Load(object sender, EventArgs e)
        {
            FormatoDgv();
            Mostrar_dgv("");
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

            dgv.DefaultCellStyle.Font = new Font("Tahoma", 8);

            dgv.RowsDefaultCellStyle.BackColor = Color.White; //.LightBlue;
            //dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.White;

            DataGridViewCellStyle style = this.dgvListado.ColumnHeadersDefaultCellStyle;
            style.BackColor = Color.Honeydew;
            style.ForeColor = Color.Gray;
            dgv.Columns.Clear();
            dgv.ColumnCount = 13;
            // Setear Cabecera de Columna 

            dgv.Columns[0].Name = "EMPR_IDE";
            dgv.Columns[1].Name = "EMPR_NOMBRE_EMPRESA";
            dgv.Columns[2].Name = "EMPR_SERVIDOR";
            dgv.Columns[3].Name = "EMPR_PROVEEDOR";
            dgv.Columns[4].Name = "EMPR_USUARIO";
            dgv.Columns[5].Name = "EMPR_CLAVE";
            dgv.Columns[6].Name = "EMPR_NOMBRE_BD";
            dgv.Columns[7].Name = "EMPR_TIEMPO";
            dgv.Columns[8].Name = "EMPR_CONTABILIDAD_DOLAR";
            dgv.Columns[9].Name = "EMPR_CODIGO_REGISTRO";
            dgv.Columns[10].Name = "EMPR_EXONERADO_IMPUESTO";
            dgv.Columns[11].Name = "EMPR_NUEVO_PC";
            dgv.Columns[12].Name = "VECES";

            dgv.Columns[0].Width = 50;
            dgv.Columns[0].HeaderText = "ID";
            dgv.Columns[0].DataPropertyName = "EMPR_IDE";
 
            dgv.Columns[1].Width = 450;
            dgv.Columns[1].HeaderText = "Empresa";
            dgv.Columns[1].DataPropertyName = "EMPR_NOMBRE_EMPRESA";

            dgv.Columns[2].DataPropertyName = "EMPR_SERVIDOR";
            dgv.Columns[2].Visible = false;
            dgv.Columns[3].DataPropertyName = "EMPR_PROVEEDOR";
            dgv.Columns[3].Visible = false;
            dgv.Columns[4].DataPropertyName = "EMPR_USUARIO";
            dgv.Columns[4].Visible = false;
            dgv.Columns[5].DataPropertyName = "EMPR_CLAVE";
            dgv.Columns[5].Visible = false;
            dgv.Columns[6].DataPropertyName = "EMPR_NOMBRE_BD";
            dgv.Columns[6].Visible = false;
            dgv.Columns[7].DataPropertyName = "EMPR_TIEMPO";
            dgv.Columns[7].Visible = false;
            dgv.Columns[8].DataPropertyName = "EMPR_CONTABILIDAD_DOLAR";
            dgv.Columns[8].Visible = false;
            dgv.Columns[9].DataPropertyName = "EMPR_CODIGO_REGISTRO";
            dgv.Columns[9].Visible = false;
            dgv.Columns[10].DataPropertyName = "EMPR_EXONERADO_IMPUESTO";
            dgv.Columns[10].Visible = false;
            dgv.Columns[11].DataPropertyName = "EMPR_NUEVO_PC";
            dgv.Columns[11].Visible = false;

            dgv.Columns[12].DataPropertyName = "VECES";
            dgv.Columns[12].Visible = false;

        }

        private void Mostrar_dgv(string filtro)
        {
            ENResultOperation R = ClsEmpresaBC.Listar(filtro);
            if (R.Proceder)
            {
                dgvListado.DataSource = (DataTable)R.Valor;
            }
            else
            {
                MessageBox.Show("Error al Leer Base de datos Empresas : " + R.Sms);
            }
        }

        private void Aceptar_Empresa()
        {
            if (this.dgvListado.CurrentRow.Cells["EMPR_IDE"].Value.ToString() == "1")
            {
                frmAcceso frmlogin = new frmAcceso();
                frmlogin.Nombre_Empresa = this.dgvListado.CurrentRow.Cells["EMPR_NOMBRE_EMPRESA"].Value.ToString();
                frmlogin.pcodEmpre = this.dgvListado.CurrentRow.Cells["EMPR_IDE"].Value.ToString();
                frmlogin.Show();
                this.Hide();
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Aceptar_Empresa();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dgvListado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Aceptar_Empresa();
        }

        private void btnReconectar_Click(object sender, EventArgs e)
        {
            Mostrar_dgv("");
        }

        private void dgvListado_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                Aceptar_Empresa();
            }
        }
    }
}
