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

namespace CapaPresentacion.Proveedores
{
    public partial class frmCategoria_Proveedor : Form
    {
        string Operacion = null;  // Operaciones : N = Nuevo / M = Modificar E = Eliminar
        public frmCategoria_Proveedor()
        {
            InitializeComponent();
        }

 
        private void frmCategoria_Proveedor_Load(object sender, EventArgs e)
        {
            FormatoDgv();
            Mostrar_dgv("");
            llenar_CboEstado();
            Estado_Botones(true);
            Deshabilitar_Campos(true);
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


            //dgv.Columns.Clear();
            dgv.ColumnCount = 6;
            // Setear Cabecera de Columna 

            dgv.Columns[0].Name = "IDE";
            dgv.Columns[1].Name = "NOMBRE";
            dgv.Columns[2].Name = "ESTADO";
            dgv.Columns[3].Name = "FECHAINAC";
            dgv.Columns[4].Name = "CREACION";
            dgv.Columns[5].Name = "VECES";


            dgv.Columns[0].Width = 40;
            dgv.Columns[0].HeaderText = "ID";
            dgv.Columns[0].DataPropertyName = "CATE_PROV_IDE";

            dgv.Columns[1].Width = 340;
            dgv.Columns[1].HeaderText = "Descripción ";
            dgv.Columns[1].DataPropertyName = "CATE_PROV_NOMBRE";

            //dgv.Columns[2].DefaultCellStyle.Format = "0.00";
            //dgv.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;


            dgv.Columns[2].Width = 80;
            dgv.Columns[2].HeaderText = "Estado";
            dgv.Columns[2].DataPropertyName = "CATE_PROV_ESTADO";

            // Columnas que no Deben Verse

            dgv.Columns[3].DataPropertyName = "CATE_PROV_FECHAINAC";
            dgv.Columns[3].Visible = false;
            dgv.Columns[4].DataPropertyName = "CREACION";
            dgv.Columns[4].Visible = false;
            dgv.Columns[5].DataPropertyName = "VECES";
            dgv.Columns[5].Visible = false;
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
            ENResultOperation R = ClsCategoria_ProveedorBC.Listar(filtro);
            if (R.Proceder)
            {
                dgvListado.DataSource = (DataTable)R.Valor;
            }
            else
            {
                MessageBox.Show("Error al Obtener Valores : " + R.Sms);
            }

        }

        private void Inicializa_campos()
        {
            txtIde.Text = "0";
            txtNombre.Text = "";
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
                txtNombre.Text = Convert.ToString(this.dgvListado.CurrentRow.Cells["NOMBRE"].Value);
                cboEstado.Text = Convert.ToString(this.dgvListado.CurrentRow.Cells["ESTADO"].Value);
                txtVeces.Text = Convert.ToString(this.dgvListado.CurrentRow.Cells["VECES"].Value);
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
            btnGraba.Focus();
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
            ClsCategoria_ProveedorBE TipoBE = new ClsCategoria_ProveedorBE();
            TipoBE.Cate_prov_ide = Convert.ToInt32(txtIde.Text);
            TipoBE.Cate_prov_nombre = txtNombre.Text;
            TipoBE.Cate_prov_estado = cboEstado.Text;
            TipoBE.Cate_prov_fechainac = Convert.ToDateTime("01-01-1900");
            TipoBE.Veces = Convert.ToInt32(txtVeces.Text);
            TipoBE.Usuario = "ADMIN";
            TipoBE.Creacion = Convert.ToDateTime(DateTime.Today);

            TipoBE.Nombre_error = "";

            switch (Operacion)
            {
                case "N":
                    {
                        ENResultOperation R = ClsCategoria_ProveedorBC.Crear(TipoBE);
                        if (!R.Proceder) MessageBox.Show("Error al Insertar Categoria Proveedor : " + R.Sms);
                        break;
                    }
                case "M":
                    {
                        ENResultOperation R = ClsCategoria_ProveedorBC.Actualizar(TipoBE);
                        if (!R.Proceder) MessageBox.Show("Error al Modificar Categoria Proveedor : " + R.Sms);
                        break;
                    }
                case "E":
                    {
                        ENResultOperation R = ClsCategoria_ProveedorBC.Eliminar(TipoBE);
                        if (!R.Proceder) MessageBox.Show("Error al Eliminar Categoria Proveedor : " + R.Sms);
                        break;
                    }
            }

            Estado_Botones(true);
            Deshabilitar_Campos(true);
            Mostrar_dgv("");
            Mostrar_Datos();
            btnGraba.Text = "Grabar";
        }

        private void Deshabilitar_Campos(bool Flag)
        {
            txtIde.ReadOnly = true;
            txtNombre.ReadOnly = Flag;
            cboEstado.Enabled = !Flag;
        }

        private void dgvListado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Mostrar_Datos();
        }

        private void dgvListado_CurrentCellChanged(object sender, EventArgs e)
        {
            Mostrar_Datos();
        }
 
    }
}
