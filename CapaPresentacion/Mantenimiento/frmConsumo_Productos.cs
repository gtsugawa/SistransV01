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
    public partial class frmConsumo_Productos : Form
    {
        private string  Operacion;
        private decimal CantStk = 0;
        public frmConsumo_Productos()
        {
            InitializeComponent();
            dgvDetalle.EditingControlShowing += new DataGridViewEditingControlShowingEventHandler(dgvDetalle_EditingControlShowing);
        }

        private void frmConsumo_Productos_Load(object sender, EventArgs e)
        {
            FormatoDetalle();
            FormatoDgv();
            Mostrar("");
            Inicializa_Fechas();

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
            DataGridViewCellStyle style = dgv.ColumnHeadersDefaultCellStyle;
            style.BackColor = Color.Honeydew;
            style.ForeColor = Color.Gray;
            //dgv.Columns.Clear();
            dgv.ColumnCount = 9;
            // Setear Cabecera de Columna 
            dgv.Columns[0].Name = "IDE";
            dgv.Columns[0].DataPropertyName = "CONS_IDE";
            dgv.Columns[0].Width = 30;
            dgv.Columns[0].HeaderText = "Id";
            dgv.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgv.Columns[1].Name = "CONS_FECHA";
            dgv.Columns[1].DataPropertyName = "CONS_FECHA";
            dgv.Columns[1].Width = 100;
            dgv.Columns[1].HeaderText = "Fecha";

            dgv.Columns[2].Name = "COMP_IDE";
            dgv.Columns[2].DataPropertyName = "COMP_IDE";
            dgv.Columns[2].Visible = false;

            dgv.Columns[3].Name = "COMP_DETALLE_IDE";
            dgv.Columns[3].DataPropertyName = "COMP_DETALLE_IDE";
            dgv.Columns[3].Visible = false;

            dgv.Columns[4].Name = "COMP_CODIGO";
            dgv.Columns[4].DataPropertyName = "COMP_CODIGO";
            dgv.Columns[4].Width = 80;
            dgv.Columns[4].HeaderText = "Codigo";

            dgv.Columns[5].Name = "COMP_DESCRIPCION";
            dgv.Columns[5].DataPropertyName = "COMP_DESCRIPCION";
            dgv.Columns[5].Width = 200;
            dgv.Columns[5].HeaderText = "Descripcion";

            dgv.Columns[6].Name = "COMP_UNIDAD_SALIDAD";
            dgv.Columns[6].DataPropertyName = "COMP_UNIDAD_SALIDA";
            dgv.Columns[6].Width = 80;
            dgv.Columns[6].HeaderText = "Unidad";

            dgv.Columns[7].Name = "COMP_EQUIVALENCIA";
            dgv.Columns[7].DataPropertyName = "COMP_EQUIVALENCIA";
            dgv.Columns[7].Visible = false;

            dgv.Columns[8].Name = "CONS_CANTIDAD";
            dgv.Columns[8].DataPropertyName = "CONS_CANTIDAD";
            dgv.Columns[8].Width = 70;
            dgv.Columns[8].HeaderText = "Cantidad";

        }
        private void Mostrar(string filtro)
        {
            ENResultOperation R = ClsProductos_ConsumoBC.Listar_por_Fechas(dtpFecIni.Value, dtpFecFin.Value);
            if (R.Proceder)
            {
                dgvListado.DataSource = (DataTable)R.Valor;
            }
            else
            {
                MessageBox.Show("Error al Obtener Valores : " + R.Sms);
            }
        }

        void FormatoDetalle()
        {
            //------------------------------------------------------------------//      
            var dgv = dgvDetalle;

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
            DataGridViewCellStyle style = dgv.ColumnHeadersDefaultCellStyle;
            style.BackColor = Color.Honeydew;
            style.ForeColor = Color.Gray;
            //dgv.Columns.Clear();
            dgv.ColumnCount = 12;
            // Setear Cabecera de Columna 
            dgv.Columns[0].Name = "IDE";
            dgv.Columns[0].DataPropertyName = "COMP_IDE";
            dgv.Columns[0].Visible = false;

            dgv.Columns[1].Name = "COMP_DETALLE_IDE";
            dgv.Columns[1].DataPropertyName = "COMP_DETALLE_IDE";
            dgv.Columns[1].Width = 100;
            dgv.Columns[1].HeaderText = "Fecha";
            dgv.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgv.Columns[2].Name = "COMP_CODIGO";
            dgv.Columns[2].DataPropertyName = "COMP_CODIGO";
            dgv.Columns[2].Width = 100;
            dgv.Columns[2].HeaderText = "Codigo";

            dgv.Columns[3].Name = "COMP_DESCRIPCION";
            dgv.Columns[3].DataPropertyName = "COMP_DESCRIPCION";
            dgv.Columns[3].Width = 200;
            dgv.Columns[3].HeaderText = "Descripcion";

            dgv.Columns[4].Name = "COMP_UNIDAD_COMPRA";
            dgv.Columns[4].DataPropertyName = "COMP_UNIDAD_COMPRA";
            dgv.Columns[4].Width = 80;
            dgv.Columns[4].HeaderText = "Unidad";

            dgv.Columns[5].Name = "COMP_UNIDAD_SALIDA";
            dgv.Columns[5].DataPropertyName = "COMP_UNIDAD_SALIDA";
            dgv.Columns[5].Visible = false;

            dgv.Columns[6].Name = "COMP_EQUIVALENCIA";
            dgv.Columns[6].DataPropertyName = "COMP_EQUIVALENCIA";
            dgv.Columns[6].Visible = false;

            dgv.Columns[7].Name = "CANTIDAD_COMPRA";
            dgv.Columns[7].DataPropertyName = "CANTIDAD_COMPRA";
            dgv.Columns[7].Width = 80;
            dgv.Columns[7].HeaderText = "Cantidad";

            dgv.Columns[8].Name = "COMP_VALOR_UNITARIO";
            dgv.Columns[8].DataPropertyName = "COMP_VALOR_UNITARIO";
            dgv.Columns[8].Width = 80;
            dgv.Columns[8].HeaderText = "Unitario";

            dgv.Columns[9].Name = "TOTAL";
            dgv.Columns[9].DataPropertyName = "TOTAL";
            dgv.Columns[9].Width = 80;
            dgv.Columns[9].HeaderText = "Total";

            dgv.Columns[10].Name = "CANTIDAD_SALIDA";
            dgv.Columns[10].DataPropertyName = "CANTIDAD_SALIDA";
            dgv.Columns[10].Width = 70;
            dgv.Columns[10].HeaderText = "Consumo";

            dgv.Columns[11].Name = "ESTADO";
            dgv.Columns[11].DataPropertyName = "ESTADO";
            dgv.Columns[11].Visible = false;

        }

        private void Mostrar_Detalle()
        {
            ENResultOperation R = ClsCompra_Productos_DetalleBC.Listar_Pendientes();
            if (R.Proceder)
            {
                dgvDetalle.DataSource = (DataTable)R.Valor;
            }
            else
            {
                MessageBox.Show("Error al Obtener Valores : " + R.Sms);
            }
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            Mostrar_Detalle();
            dgvDetalle.Focus();

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscarxFechas_Click(object sender, EventArgs e)
        {

        }

        private void dgvDetalle_CurrentCellChanged(object sender, EventArgs e)
        {
            if (this.dgvDetalle.CurrentRow != null)
            {
                txtComp_Detalle_Ide.Text = this.dgvDetalle.CurrentRow.Cells["COMP_DETALLE_IDE"].Value.ToString();
                txtCodigo.Text = this.dgvDetalle.CurrentRow.Cells["COMP_CODIGO"].Value.ToString();
                txtDescripcion.Text = this.dgvDetalle.CurrentRow.Cells["COMP_DESCRIPCION"].Value.ToString();
                txtUnidad.Text = this.dgvDetalle.CurrentRow.Cells["COMP_UNIDAD_COMPRA"].Value.ToString();
                if (dgvDetalle.CurrentRow.Cells["CANTIDAD_SALIDA"].Value != DBNull.Value)
                {
                    CantStk = Convert.ToDecimal(dgvDetalle.CurrentRow.Cells["CANTIDAD_COMPRA"].Value) - Convert.ToDecimal(dgvDetalle.CurrentRow.Cells["CANTIDAD_SALIDA"].Value);
                }
                else
                {
                    CantStk = Convert.ToDecimal(dgvDetalle.CurrentRow.Cells["CANTIDAD_COMPRA"].Value);
                }
                txtDisponible.Text = CantStk.ToString();
                txtCantidad_Consumo.Text = "";
            }
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }

        private void ValidarNumeros(KeyPressEventArgs e)
        {

            if (e.KeyChar >= 48 && e.KeyChar <= 57)
            {
                e.Handled = false;
            }
            else if (e.KeyChar == 8 || e.KeyChar == 46)
            {
                e.Handled = false;
            }
            else if (e.KeyChar == 13)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtCantidad_Consumo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter) SendKeys.Send("{TAB}");
            ValidarNumeros(e);
        }

        private void dtpFecConsumo_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void dgvDetalle_KeyPress(object sender, KeyPressEventArgs e)
        {
             if (e.KeyChar == (char)Keys.A) 
             {
                 e.Handled = true;
                 return;
             }
        }

        private void txtCantidad_Consumo_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtCantidad_Consumo.Text)) txtCantidad_Consumo.Text = "0";
            if (Convert.ToDecimal(txtCantidad_Consumo.Text)>CantStk)
            {
                MessageBox.Show("Cantidad No Puede ser mayor al Disponible ","Validacion");
                txtCantidad_Consumo.Focus();
            }
        }

        private void dgvDetalle_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
        }


    }
}
