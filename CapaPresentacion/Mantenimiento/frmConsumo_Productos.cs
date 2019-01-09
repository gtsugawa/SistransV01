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
        private int nCons_Ide;
        private int nComp_Ide;
        private int nTran_Ide = 2564;
        private int nTran_Vehi_Ide;
        public frmConsumo_Productos()
        {
            InitializeComponent();
            dgvDetalle.EditingControlShowing += new DataGridViewEditingControlShowingEventHandler(dgvDetalle_EditingControlShowing);
        }

        private void frmConsumo_Productos_Load(object sender, EventArgs e)
        {
            FormatoDetalle();
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
            DataGridViewCellStyle style = dgv.ColumnHeadersDefaultCellStyle;
            style.BackColor = Color.Honeydew;
            style.ForeColor = Color.Gray;
            //dgv.Columns.Clear();
            dgv.ColumnCount = 13;
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

            dgv.Columns[2].Name = "TRAN_IDE";
            dgv.Columns[2].DataPropertyName = "TRAN_IDE";
            dgv.Columns[2].Visible = false;

            dgv.Columns[3].Name = "TRAN_VEHI_IDE";
            dgv.Columns[3].DataPropertyName = "TRAN_VEHI_IDE";
            dgv.Columns[3].Visible = false;

            dgv.Columns[4].Name = "PLACA";
            dgv.Columns[4].DataPropertyName = "PLACA";
            dgv.Columns[4].Width = 80;
            dgv.Columns[4].HeaderText = "Placa";

            dgv.Columns[5].Name = "NOMBRE";
            dgv.Columns[5].DataPropertyName = "NOMBRE";
            dgv.Columns[5].Width = 80;
            dgv.Columns[5].HeaderText = "Nombre";

            dgv.Columns[6].Name = "COMP_IDE";
            dgv.Columns[6].DataPropertyName = "COMP_IDE";
            dgv.Columns[6].Visible = false;

            dgv.Columns[7].Name = "COMP_DETALLE_IDE";
            dgv.Columns[7].DataPropertyName = "COMP_DETALLE_IDE";
            dgv.Columns[7].Visible = false;

            dgv.Columns[8].Name = "COMP_CODIGO";
            dgv.Columns[8].DataPropertyName = "COMP_CODIGO";
            dgv.Columns[8].Width = 80;
            dgv.Columns[8].HeaderText = "Codigo";

            dgv.Columns[9].Name = "COMP_DESCRIPCION";
            dgv.Columns[9].DataPropertyName = "COMP_DESCRIPCION";
            dgv.Columns[9].Width = 200;
            dgv.Columns[9].HeaderText = "Descripcion";

            dgv.Columns[10].Name = "COMP_UNIDAD_SALIDA";
            dgv.Columns[10].DataPropertyName = "COMP_UNIDAD_SALIDA";
            dgv.Columns[10].Width = 80;
            dgv.Columns[10].HeaderText = "Unidad";

            dgv.Columns[11].Name = "COMP_EQUIVALENCIA";
            dgv.Columns[11].DataPropertyName = "COMP_EQUIVALENCIA";
            dgv.Columns[11].Visible = false;

            dgv.Columns[12].Name = "CONS_CANTIDAD";
            dgv.Columns[12].DataPropertyName = "CONS_CANTIDAD";
            dgv.Columns[12].Width = 70;
            dgv.Columns[12].HeaderText = "Cantidad";

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

        private void Habilitar_Botones(Boolean Flag)
        {
            btnNuevo.Enabled = Flag;
            btnModificar.Enabled = Flag;
            btnEliminar.Enabled = Flag;
            btnGrabar.Enabled = !Flag;
            btnCancelar.Enabled = !Flag;
            btnImprimir.Enabled = Flag;
            btnSalir.Enabled = Flag;
            btnGrabar.Text = "Grabar";
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            panel3.Visible = true;
            Mostrar_Detalle();
            dgvDetalle.Focus();
            Operacion = "N";
            Habilitar_Botones(false);
            Habilitar_Campos(true);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (this.dgvListado.CurrentRow != null)
            {
                Operacion = "M";
                Habilitar_Botones(false);
                panel3.Visible = true;
                Mostrar_Consumo();
                Habilitar_Campos(true);
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (this.dgvListado.CurrentRow != null)
            {
                Operacion = "E";
                Habilitar_Botones(false);
                panel3.Visible = true;
                Mostrar_Consumo();
                Habilitar_Botones(false);
                Habilitar_Campos(false);
                btnGrabar.Text = "Eliminar";
            }

        }
        private void Habilitar_Campos(Boolean Flag)
        {
            dtpFecConsumo.Enabled = Flag;
            txtCodigo.ReadOnly = !Flag;
            txtDescripcion.ReadOnly = !Flag;
            txtPlaca.ReadOnly = !Flag;
            txtUnidad.ReadOnly = !Flag;
            txtComp_Detalle_Ide.ReadOnly = !Flag;
            txtCantidad_Consumo.ReadOnly = !Flag;
            txtDisponible.ReadOnly = !Flag;
        }
        private void Mostrar_Consumo()
        {
            nCons_Ide = Convert.ToInt32(dgvListado.CurrentRow.Cells["IDE"].Value.ToString());
            nTran_Ide = Convert.ToInt32(dgvListado.CurrentRow.Cells["TRAN_IDE"].Value.ToString());
            nTran_Vehi_Ide = Convert.ToInt32(dgvListado.CurrentRow.Cells["TRAN_VEHI_IDE"].Value.ToString());
            nComp_Ide = Convert.ToInt32(dgvListado.CurrentRow.Cells["COMP_IDE"].Value.ToString());
            dtpFecConsumo.Text = dgvListado.CurrentRow.Cells["CONS_FECHA"].Value.ToString();
            txtCodigo.Text = dgvListado.CurrentRow.Cells["COMP_CODIGO"].Value.ToString();
            txtDescripcion.Text = dgvListado.CurrentRow.Cells["COMP_DESCRIPCION"].Value.ToString();
            txtPlaca.Text = dgvListado.CurrentRow.Cells["PLACA"].Value.ToString();
            lblNombre.Text = dgvListado.CurrentRow.Cells["NOMBRE"].Value.ToString();
            txtUnidad.Text = dgvListado.CurrentRow.Cells["COMP_UNIDAD_SALIDA"].Value.ToString();
            txtComp_Detalle_Ide.Text = dgvListado.CurrentRow.Cells["COMP_DETALLE_IDE"].Value.ToString();
            txtCantidad_Consumo.Text = dgvListado.CurrentRow.Cells["CONS_CANTIDAD"].Value.ToString();
            txtDisponible.Text = dgvListado.CurrentRow.Cells["CONS_CANTIDAD"].Value.ToString();
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
                if (this.dgvListado.CurrentRow != null)
                {
                    nCons_Ide = Convert.ToInt32(dgvListado.CurrentRow.Cells["IDE"].Value.ToString());
                }
                else
                {
                    nCons_Ide = 0;
                }
                nComp_Ide = Convert.ToInt32(dgvDetalle.CurrentRow.Cells["IDE"].Value.ToString());
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
            if (Verifica_Campos())
            {
                Procesar_Operacion();
                panel2.Visible = false;
                panel3.Visible = false;
                Habilitar_Botones(true);
                dgvListado.Focus();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel3.Visible = false;
            Habilitar_Botones(true);
        }
        private Boolean Verifica_Campos()
        {
            return true;
        }

        private void Procesar_Operacion()
        {
            ClsProductos_ConsumoBE TipoBE = new ClsProductos_ConsumoBE();
            TipoBE.Cons_ide = nCons_Ide;
            TipoBE.Cons_fecha = Convert.ToDateTime(dtpFecConsumo.Text);
            TipoBE.Comp_ide = nComp_Ide;
            TipoBE.Comp_detalle_ide = Convert.ToInt32(txtComp_Detalle_Ide.Text);
            TipoBE.Tran_ide = nTran_Ide;
            TipoBE.Tran_vehi_ide = nTran_Vehi_Ide;
            TipoBE.Comp_detalle_ide = Convert.ToInt32(txtComp_Detalle_Ide.Text);
            if (string.IsNullOrEmpty(txtCantidad_Consumo.Text)) txtCantidad_Consumo.Text = "0";
            TipoBE.Cons_cantidad = Convert.ToDecimal(txtCantidad_Consumo.Text);
            TipoBE.Estado = 0;
            switch (Operacion)
            {
                case "N":
                    {
                        ENResultOperation R = ClsProductos_ConsumoBC.Crear(TipoBE);
                        if (!R.Proceder) MessageBox.Show("Error al Insertar Consumo de Productos " + R.Sms);
                        break;
                    }
                case "M":
                    {
                        ENResultOperation R = ClsProductos_ConsumoBC.Actualizar(TipoBE);
                        if (!R.Proceder) MessageBox.Show("Error al Modificar Consumo de Productos " + R.Sms);
                        break;
                    }
                case "E":
                    {
                        ENResultOperation R = ClsProductos_ConsumoBC.Eliminar(TipoBE);
                        if (!R.Proceder) MessageBox.Show("Error al Eliminar Consumo de Productos " + R.Sms);
                        break;
                    }
            }
            Mostrar("");
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
            if (Operacion == "N")
            {
                if (string.IsNullOrEmpty(txtCantidad_Consumo.Text)) txtCantidad_Consumo.Text = "0";
                if (Convert.ToDecimal(txtCantidad_Consumo.Text) > CantStk)
                {
                    MessageBox.Show("Cantidad No Puede ser mayor al Disponible ", "Validacion");
                    txtCantidad_Consumo.Focus();
                }
            }
        }

        private void dgvDetalle_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
        }

        private void txtPlaca_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                if (Buscar_Vehiculo())
                {
                    txtCantidad_Consumo.Focus();
                }
                else
                {
                    MessageBox.Show("Placa de Vehiculo No Encontrada", "Validación de Placa");
                    txtPlaca.Focus();
                }
            }
        }

        private void txtPlaca_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3)
            {
                Transportista.frmTransportista_Vehiculo_Buscar frmBuscarV = new Transportista.frmTransportista_Vehiculo_Buscar();
                frmBuscarV.Transportista_Ide = 2564;
                frmBuscarV.ShowDialog();
                nTran_Vehi_Ide = Convert.ToInt32(frmBuscarV.Vehiculo_Ide);
                txtPlaca.Text = frmBuscarV.Vehiculo_Placa;
                lblNombre.Text = frmBuscarV.Vehiculo_Nombre;
            }
        }

        private Boolean Buscar_Vehiculo()
        {
            ENResultOperation R = ClsTransportista_VehiculoBC.Listar_Filtro(txtPlaca.Text, nTran_Ide);
            DataTable dtg = (DataTable)R.Valor;
            if (dtg.Rows.Count == 1)
            {
                DataRow ROWG = dtg.Rows[0];
                nTran_Vehi_Ide = Convert.ToInt32(ROWG["TRAN_VEHI_IDE"].ToString());
                txtPlaca.Text = ROWG["TRAN_VEHI_PLACA"].ToString();
                lblNombre.Text = ROWG["TRAN_VEHI_NOMBRE"].ToString();
                return true;
            }
            return false;
        }
    }
}
