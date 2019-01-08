using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using CapaBE;
using CapaBC;

namespace CapaPresentacion.Tablas
{
    public partial class frmCombustible_Importe : Form
    {

        private DateTime Fecha_Buscar = DateTime.Now;
        string strcon = ConfigurationManager.ConnectionStrings["conex1"].ConnectionString;

        string Operacion = null;  // Operaciones : N = Nuevo / M = Modificar E = Eliminar
        public frmCombustible_Importe()
        {
            InitializeComponent();
        }

        private void frmCombustible_Importe_Load(object sender, EventArgs e)
        {
            FormatoDgv();
            Cargar_ComboBox();
            Llenar_CboTipoCombustible();
            txtProveedor.Focus();
            Habilita_Campos(false);
            Habilitar_Botones(true);
        }

        private void Mostrar_dgv(string filtro, DateTime fechabuscar)
        {
            ENResultOperation R = ClsCombustible_ImporteBC.Listar_Filtro(filtro, fechabuscar);
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
            dgv.ColumnCount = 9;
            // Setear Cabecera de Columna 

            dgv.Columns[0].Name = "IDE";
            dgv.Columns[1].Name = "PROV_IDE";
            dgv.Columns[2].Name = "PROVEEDOR";
            dgv.Columns[3].Name = "FECHA";
            dgv.Columns[4].Name = "TIPO_COMBUSTIBLE";
            dgv.Columns[5].Name = "NOMBRE_COMBUSTIBLE";
            dgv.Columns[6].Name = "IMPORTE";
            dgv.Columns[7].Name = "CREACION";
            dgv.Columns[8].Name = "VECES";


            dgv.Columns[0].Width = 60;
            dgv.Columns[0].HeaderText = "ID";
            dgv.Columns[0].DataPropertyName = "GRIFO_IDE";

            dgv.Columns[1].Width = 90;
            dgv.Columns[1].HeaderText = "ID Prov";
            dgv.Columns[1].DataPropertyName = "PROV_IDE";
            dgv.Columns[1].Visible = false;


            dgv.Columns[2].Width = 300;
            dgv.Columns[2].HeaderText = "Proveedor  ";
            dgv.Columns[2].DataPropertyName = "PROV_RAZON_SOCIAL";

            dgv.Columns[3].Width = 90;
            dgv.Columns[3].HeaderText = "Fecha";
            dgv.Columns[3].DataPropertyName = "GRIFO_FECHA";

            dgv.Columns[4].Width = 70;
            dgv.Columns[4].HeaderText = "T-Combustible";
            dgv.Columns[4].DataPropertyName = "GRIFO_TIPO_COMBUSTIBLE";
            dgv.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgv.Columns[5].Width = 90;
            dgv.Columns[5].HeaderText = "Combustible";
            dgv.Columns[5].DataPropertyName = "NOMBRE_COMBUSTIBLE";
            dgv.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgv.Columns[6].Width = 70;
            dgv.Columns[6].HeaderText = "Importe";
            dgv.Columns[6].DataPropertyName = "GRIFO_IMPORTE";
            dgv.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgv.Columns[7].DataPropertyName = "CREACION";
            dgv.Columns[7].Visible = false;

            dgv.Columns[8].DataPropertyName = "VECES";
            dgv.Columns[8].Visible = false;
        }

        private void Cargar_ComboBox()
        {
            cboMeses.Items.Clear();
            cboMeses.Items.Add("Enero");
            cboMeses.Items.Add("Febrero");
            cboMeses.Items.Add("Marzo");
            cboMeses.Items.Add("Abril");
            cboMeses.Items.Add("Mayo");
            cboMeses.Items.Add("Junio");
            cboMeses.Items.Add("Julio");
            cboMeses.Items.Add("Agosto");
            cboMeses.Items.Add("Setiembre");
            cboMeses.Items.Add("Octubre");
            cboMeses.Items.Add("Noviembre");
            cboMeses.Items.Add("Diciembre");
            cboMeses.SelectedIndex = Convert.ToInt32(DateTime.Now.Month-1);

            cboaños.Items.Clear();
            for (int i = 2010; i < 2060; i++)
            {
                cboaños.Items.Add(Convert.ToString(i));
            }
            cboaños.SelectedIndex = Convert.ToInt32(DateTime.Now.Year - 2010);
                
        }

        private void Llenar_CboTipoCombustible()
        {
            cboTipoCombustible.Items.Clear();
            cboTipoCombustible.Items.Add("Gas");
            cboTipoCombustible.Items.Add("Gasolina");
            cboTipoCombustible.Items.Add("Petroleo");
            cboTipoCombustible.SelectedIndex = 2;
        }
        private void Habilitar_Botones(bool flag)
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
                cboTipoCombustible.SelectedIndex = Convert.ToInt32(this.dgvListado.CurrentRow.Cells["TIPO_COMBUSTIBLE"].Value);
                dtpFecha.Text = Convert.ToString(this.dgvListado.CurrentRow.Cells["FECHA"].Value);
                txtImporte.Text = Convert.ToString(this.dgvListado.CurrentRow.Cells["IMPORTE"].Value);
                txtVeces.Text = Convert.ToString(this.dgvListado.CurrentRow.Cells["VECES"].Value);
            }
        }
        private void Inicializa_campos()
        {
            txtIde.Text = "0";
            txtVeces.Text = "0";
            txtImporte.Text = "0";
            cboTipoCombustible.SelectedIndex = 2;
        }

        private void Habilita_Campos(bool Flag)
        {
            txtIde.ReadOnly = true;
            //txtProveedor.ReadOnly = !Flag;
            //txtProvIde.ReadOnly   = !Flag;
            cboTipoCombustible.Enabled = Flag;
            dtpFecha.Enabled = Flag;
            txtImporte.Enabled = Flag;
        }


        private void dgvListado_CurrentCellChanged(object sender, EventArgs e)
        {
            Mostrar_Datos();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtProveedor.Text))
            {
                Operacion = "N";
                Inicializa_campos();
                Habilitar_Botones(false);
                Habilita_Campos(true);
                cboTipoCombustible.Focus();
            }
        }

        private void btnModifica_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtProveedor.Text))
            {
                Operacion = "M";
                Habilitar_Botones(false);
                Habilita_Campos(true);
                cboTipoCombustible.Focus();
            }
        }

        private void btnElimina_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtProveedor.Text))
            {
                Operacion = "E";
                Habilitar_Botones(false);
                btnGraba.Text = "Eliminar";
                btnGraba.Focus();
            }
        }

        private void btnCancela_Click(object sender, EventArgs e)
        {

            Habilitar_Botones(true);
        }

        private void btnGraba_Click(object sender, EventArgs e)
        {
            Procesar_Operacion();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscartxt_Click(object sender, EventArgs e)
        {

            Buscar_Proveedor(txtProveedor.Text.Trim());
        }

        private void txtProvIde_KeyPress(object sender, KeyPressEventArgs e)
        {
            Buscar_Proveedor(txtProvIde.Text.Trim());
        }

        private void Buscar_Proveedor(string campo)
        {
                Proveedores.frmProveedorBuscar frmProvBuscar = new Proveedores.frmProveedorBuscar();
                frmProvBuscar.ProveedorRazon = txtProveedor.Text;
                DialogResult res = frmProvBuscar.ShowDialog();
                if (frmProvBuscar.ProveedorID != null)
                {

                    txtProvIde.Text = frmProvBuscar.ProveedorID.ToString();
                    txtProveedor.Text = frmProvBuscar.ProveedorRazon.ToString();

                    string nromes = convert_mes(cboMeses.Text);
                    Fecha_Buscar = Convert.ToDateTime("01/" + nromes + "/" + cboaños.Text.ToString());
                    Mostrar_dgv(txtProvIde.Text, Fecha_Buscar);
                }
        }

        private static string convert_mes(string titmes)
        {
            switch (titmes)
            {
                case "Enero": return "01";
                case "Febrero": return "02";
                case "Marzo": return "03"; 
                case "Abril": return "04"; 
                case "Mayo": return "05"; 
                case "Junio": return "06"; 
                case "Julio": return "07"; 
                case "Agosto": return "08"; 
                case "Setiembre": return "09";
                case "Octubre": return "10"; 
                case "Noviembre": return "11"; 
                case "Diciembre": return "12"; 
            }
            return "";
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            
            txtProveedor.Text = "";
            txtProvIde.Text = "0";
            txtProvIde.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtProveedor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3)
            {
                Buscar_Proveedor(txtProveedor.Text.Trim());
            }
        }

        private void txtProveedor_KeyPress(object sender, KeyPressEventArgs e)
        {

            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                Buscar_Proveedor(txtProveedor.Text.Trim());
            }
           
        }

        private void Procesar_Operacion()
        {
            ClsCombustible_ImporteBE TipoBE = new ClsCombustible_ImporteBE();
            TipoBE.Prov_ide = Convert.ToInt32(txtProvIde.Text);
            TipoBE.Grifo_ide = Convert.ToInt32(txtIde.Text);
            TipoBE.Grifo_fecha = Convert.ToDateTime(dtpFecha.Text);
            //TipoBE.Grifo_tipo_combustible = Convert.ToInt32(cboTipoCombustible.SelectedValue.ToString());
            TipoBE.Grifo_importe = Convert.ToDecimal(txtImporte.Text);
            TipoBE.Veces = Convert.ToInt32(txtVeces.Text);
            TipoBE.Usuario = "ADMIN";
            TipoBE.Creacion = Convert.ToDateTime(DateTime.Today);
            switch (cboTipoCombustible.Text)
            {
                case "Gas": TipoBE.Grifo_tipo_combustible = 0; break;
                case "Gasolina": TipoBE.Grifo_tipo_combustible = 1; break;
                case "Petroleo": TipoBE.Grifo_tipo_combustible = 2; break;
            }

            TipoBE.Nombre_error = "";
            switch (Operacion)
            {
                case "N":
                    {
                        ENResultOperation R = ClsCombustible_ImporteBC.Crear(TipoBE);
                        if (!R.Proceder) MessageBox.Show("Error al Insertar Importe del Combustible : " + R.Sms);
                        break;
                    }
                case "M":
                    {
                        ENResultOperation R = ClsCombustible_ImporteBC.Actualizar(TipoBE);
                        if (!R.Proceder) MessageBox.Show("Error al Modificar Importe del Combustible : " + R.Sms);
                        break;
                    }
                case "E":
                    {
                        ENResultOperation R = ClsCombustible_ImporteBC.Eliminar(TipoBE);
                        if (!R.Proceder) MessageBox.Show("Error al Eliminar Importe del Combustible : " + R.Sms);
                        break;
                    }
            }

            Habilitar_Botones(true);
            Habilita_Campos(false);
            Mostrar_dgv(txtProvIde.Text, Fecha_Buscar);
            Mostrar_Datos();
            btnGraba.Text = "Grabar";
        }

        private void cboTipoCombustible_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboaños_Validated(object sender, EventArgs e)
        {
            
        }

        private void cboaños_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                Buscar_Proveedor(txtProveedor.Text.Trim());
            }
        }
 
    }
}
