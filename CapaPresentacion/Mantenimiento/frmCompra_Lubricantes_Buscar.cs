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
    public partial class frmCompra_Lubricantes_Buscar : Form
    {
        private DateTime fecha1;
        private DateTime fecha2;
        public  DateTime FechaCompra;
        public Int32 iComp_Ide;
        public  string   sDescripcion;
        public frmCompra_Lubricantes_Buscar()
        {
            InitializeComponent();
        }

        private void frmCompra_Lubricantes_Buscar_Load(object sender, EventArgs e)
        {
            FormatoDgv();
            Inicializa_Fechas();
            Mostrar("");
        }

        private void Inicializa_Fechas()
        {
            DateTime fecha1 = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            DateTime fecha2 = fecha1.AddMonths(1).AddTicks(-1);
            dtpFecIni.Text = fecha1.ToShortDateString();
            dtpFecFin.Text = fecha2.ToShortDateString();
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
            dgv.ColumnCount = 20;
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

            dgv.Columns[4].Name = "FECHA";
            dgv.Columns[4].DataPropertyName = "COMP_FECHA";
            dgv.Columns[4].Width = 80;
            dgv.Columns[4].HeaderText = "Fecha";

            dgv.Columns[5].Name = "NUMERO";
            dgv.Columns[5].DataPropertyName = "COMP_NUMERO";
            dgv.Columns[5].Width = 100;
            dgv.Columns[5].HeaderText = "N° Factura";

            dgv.Columns[6].Name = "CODIGO";
            dgv.Columns[6].DataPropertyName = "COMP_CODIGO";
            dgv.Columns[6].Width = 100;
            dgv.Columns[6].HeaderText = "Codigo";
            dgv.Columns[6].Visible = false;

            dgv.Columns[7].Name = "DESCRIPCION";
            dgv.Columns[7].DataPropertyName = "COMP_DESCRIPCION";
            dgv.Columns[7].Width = 150;
            dgv.Columns[7].HeaderText = "Descripcion";

            dgv.Columns[8].Name = "MARCA";
            dgv.Columns[8].DataPropertyName = "COMP_MARCA";
            dgv.Columns[8].Width = 100;
            dgv.Columns[8].HeaderText = "Marca";
            dgv.Columns[8].Visible = false;

            dgv.Columns[9].Name = "UNIDAD";
            dgv.Columns[9].DataPropertyName = "COMP_UNIDAD";
            dgv.Columns[9].Width = 70;
            dgv.Columns[9].HeaderText = "Unidad";

            dgv.Columns[10].Name = "CANTIDAD";
            dgv.Columns[10].DataPropertyName = "COMP_CANTIDAD";
            dgv.Columns[10].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgv.Columns[10].Width = 70;
            dgv.Columns[10].HeaderText = "Cantidad";

            dgv.Columns[11].Name = "IMPORTE";
            dgv.Columns[11].DataPropertyName = "COMP_IMPORTE";
            dgv.Columns[11].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgv.Columns[11].Width = 90;
            dgv.Columns[11].HeaderText = "Importe";

            dgv.Columns[12].Name = "MONEDA";
            dgv.Columns[12].DataPropertyName = "COMP_MONEDA";
            dgv.Columns[12].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgv.Columns[12].Width = 80;
            dgv.Columns[12].HeaderText = "Moneda";

            dgv.Columns[13].Name = "TCAMBIO";
            dgv.Columns[13].DataPropertyName = "COMP_TCAMBIO";
            dgv.Columns[13].Visible = false;

            dgv.Columns[14].Name = "UNIDAD_SALIDA";
            dgv.Columns[14].DataPropertyName = "UNIDAD_SALIDA";
            dgv.Columns[14].Visible = false;

            dgv.Columns[15].Name = "UNIDAD_EQUIVALENCIA";
            dgv.Columns[15].DataPropertyName = "UNIDAD_EQUIVALENCIA";
            dgv.Columns[15].Visible = false;

            dgv.Columns[16].Name = "UNIDAD_COSTO";
            dgv.Columns[16].DataPropertyName = "UNIDAD_COSTO";
            dgv.Columns[16].Visible = false;

            dgv.Columns[17].Name = "CANTIDAD_SALIDA";
            dgv.Columns[17].DataPropertyName = "CANTIDAD_SALIDA";
            dgv.Columns[17].Visible = false;

            dgv.Columns[18].Name = "FECHA_INICIO_USO";
            dgv.Columns[18].DataPropertyName = "FECHA_INICIO_USO";
            dgv.Columns[18].Visible = false;

            dgv.Columns[19].Name = "ESTADO";
            dgv.Columns[19].DataPropertyName = "ESTADO";
            dgv.Columns[19].Visible = false;

        }

        private void Mostrar(string filtro)
        {
            ENResultOperation R = ClsCompra_LubricantesBC.Listar_por_Fechas(dtpFecIni.Value, dtpFecFin.Value);
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Mostrar("");
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Aceptar()
        {
            if (this.dgvListado.CurrentRow != null)
            {
                iComp_Ide = Convert.ToInt32(this.dgvListado.CurrentRow.Cells["IDE"].Value.ToString());
                sDescripcion = this.dgvListado.CurrentRow.Cells["DESCRIPCION"].Value.ToString();
                FechaCompra = Convert.ToDateTime(this.dgvListado.CurrentRow.Cells["FECHA"].Value.ToString());
                this.Close();
            }
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Aceptar();
        }

        private void dgvListado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)  Aceptar();
        }

        private void dgvListado_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                Aceptar();
            }

        }
    }
}
