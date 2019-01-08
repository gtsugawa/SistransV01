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
using System.Data.SqlClient;


namespace CapaPresentacion.Mantenimiento
{
    public partial class frmMantenimiento_Grupos : Form
    {
        private int iMant_Ide;
        private string Operacion;
        public frmMantenimiento_Grupos()
        {
            InitializeComponent();
        }

        private void frmMantenimiento_Grupos_Load(object sender, EventArgs e)
        {
            FormatoDgv();
            Mostrar("");
            Cargar_Estado();
            PanelGrupos.Visible = false;
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
            dgv.ColumnCount = 4;
            // Setear Cabecera de Columna 
            dgv.Columns[0].Name = "MANT_GRUPO_IDE";
            dgv.Columns[1].Name = "MANT_GRUPO_CODIGO";
            dgv.Columns[2].Name = "MANT_GRUPO_NOMBRE";
            dgv.Columns[3].Name = "MANT_GRUPO_ESTADO";

            dgv.Columns[0].Width = 40;
            dgv.Columns[0].HeaderText = "ID";
            dgv.Columns[0].DataPropertyName = "MANT_GRUPO_IDE";
            dgv.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgv.Columns[1].Width = 100;
            dgv.Columns[1].HeaderText = "Codigo";
            dgv.Columns[1].DataPropertyName = "MANT_GRUPO_CODIGO";

            dgv.Columns[2].Width = 380;
            dgv.Columns[2].HeaderText = "Descripcion del Grupo";
            dgv.Columns[2].DataPropertyName = "MANT_GRUPO_NOMBRE";
            dgv.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            dgv.Columns[3].Width = 90;
            dgv.Columns[3].HeaderText = "Estado";
            dgv.Columns[3].DataPropertyName = "MANT_GRUPO_ESTADO";
            dgv.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

        }
        private void Mostrar(string filtro)
        {
            ENResultOperation R = ClsMantenimiento_GruposBC.Listar(filtro);
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
            iMant_Ide = 0;
            if (this.dgvListado.CurrentRow != null)
            {
                iMant_Ide = Convert.ToInt32(this.dgvListado.CurrentRow.Cells["MANT_GRUPO_IDE"].Value.ToString());
            }
        }
        private void dgvListado_CurrentCellChanged_1(object sender, EventArgs e)
        {
            Mostrar_Dgv();
        }

        private void Cargar_Estado()
        {
            cboEstado.Items.Clear();
            cboEstado.Items.Add("Activo");
            cboEstado.Items.Add("InActivo");
            cboEstado.SelectedIndex = 0;
        }

        private void Inicializa_Campos()
        {
            txtCodigo.Text = "";
            txtNombre.Text = "";
            cboEstado.SelectedIndex = 0;
        }
        private void Habilitar_Botones(Boolean Flag)
        {
            btnNuevo.Enabled = Flag;
            btnModificar.Enabled = Flag;
            btnEliminar.Enabled = Flag;
            btnImprimir.Enabled = Flag;
            btnGrabar.Enabled = !Flag;
            btnCancelar.Enabled = !Flag;
            btnSalir.Enabled = Flag;
            btnGrabar.Text = "Grabar";
        }
        private void Habilitar_Campos(Boolean Flag)
        {
            txtCodigo.ReadOnly = !Flag;
            txtNombre.ReadOnly = !Flag;
            cboEstado.Enabled = Flag;
            txtCodigo.Focus();
        }

        private void Cargar_Registro(int nMant_Ide)
        {
            ENResultOperation R = ClsMantenimiento_GruposBC.Buscar_Registro(nMant_Ide);
            DataTable dtg = (DataTable)R.Valor;
            if (dtg.Rows.Count != 0)
            {
                DataRow ROWG = dtg.Rows[0];
                txtCodigo.Text = ROWG["MANT_GRUPO_CODIGO"].ToString();
                txtNombre.Text = ROWG["MANT_GRUPO_NOMBRE"].ToString();
                cboEstado.SelectedValue = Convert.ToInt32(ROWG["MANT_GRUPO_ESTADO"].ToString());
            }
            else
            {
                Habilitar_Botones(true);
            }

        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            PanelGrupos.Visible = true;
            Operacion = "N";
            Inicializa_Campos();
            Habilitar_Botones(false);
            Habilitar_Campos(true);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (iMant_Ide != 0)
            {
                PanelGrupos.Visible = true;
                Operacion = "M";
                Habilitar_Botones(false);
                Habilitar_Campos(true);
                Cargar_Registro(iMant_Ide);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (iMant_Ide != 0)
            {
                PanelGrupos.Visible = true;
                Operacion = "E";
                Habilitar_Botones(false);
                Habilitar_Campos(false);
                Cargar_Registro(iMant_Ide);
                btnGrabar.Text = "Eliminar";
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {

        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (Verifica_Campos()) Procesar_Operacion();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            PanelGrupos.Visible = false;
            Habilitar_Botones(true);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private Boolean Verifica_Campos()
        {
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("No se Ha Ingresado Descripcion del Grupo", "Mantenimiento de Grupos");
                return false;
            }

            if (string.IsNullOrEmpty(txtCodigo.Text))
            {
                MessageBox.Show("No se Ha Ingresado Codigo del Grupo", "Mantenimiento de Grupos");
                return false;
            }

            return true;
        }
        private void Procesar_Operacion()
        {
            ClsMantenimiento_GruposBE TipoBE = new ClsMantenimiento_GruposBE();
            TipoBE.Mant_grupo_ide = iMant_Ide;
            TipoBE.Mant_grupo_codigo = txtCodigo.Text;
            TipoBE.Mant_grupo_nombre = txtNombre.Text;
            TipoBE.Mant_grupo_estado = Convert.ToInt32(cboEstado.SelectedIndex);

            switch (Operacion)
            {
                case "N":
                    {
                        ENResultOperation R = ClsMantenimiento_GruposBC.Crear(TipoBE);
                        if (!R.Proceder) MessageBox.Show("Error al Insertar " + R.Sms);
                        break;
                    }
                case "M":
                    {
                        ENResultOperation R = ClsMantenimiento_GruposBC.Actualizar(TipoBE);
                        if (!R.Proceder) MessageBox.Show("Error al Modificar " + R.Sms);
                        break;
                    }
                case "E":
                    {
                        ENResultOperation R = ClsMantenimiento_GruposBC.Eliminar(TipoBE);
                        if (!R.Proceder) MessageBox.Show("Error al Eliminar " + R.Sms);
                        break;
                    }
            }
            PanelGrupos.Visible = false;
            Habilitar_Botones(true);
            Habilitar_Campos(false);
            Mostrar("");
        }

        private void dgvListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmMantenimiento_Grupos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }

        }

    }
}
