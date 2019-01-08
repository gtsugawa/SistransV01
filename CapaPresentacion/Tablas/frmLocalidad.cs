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
    public partial class frmLocalidad : Form
    {
        string Operacion = null;  // Operaciones : N = Nuevo / M = Modificar E = Eliminar
        public frmLocalidad()
        {
            InitializeComponent();
        }

        private void frmLocalidad_Load(object sender, EventArgs e)
        {
            FormatoDgv();
            Mostrar_dgv("");
            llenar_CboEstado();
            Estado_Botones(true);
            Habilita_Campos(true);
            Llenar_cboZonaGeo();
            Llenar_cboPais();
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
            dgv.ColumnCount = 11;
            // Setear Cabecera de Columna 

            dgv.Columns[0].Name = "IDE";
            dgv.Columns[1].Name = "CODIGO";
            dgv.Columns[2].Name = "NOMBRE";
            dgv.Columns[3].Name = "CODIGO_POSTAL";
            dgv.Columns[4].Name = "ABREVIADO";
            dgv.Columns[5].Name = "ZONA_GEOGRAFICA";
            dgv.Columns[6].Name = "PAIS";
            dgv.Columns[7].Name = "ESTADO";
            dgv.Columns[10].Name = "VECES";
           

            dgv.Columns[0].Width = 45;
            dgv.Columns[0].HeaderText = "ID";
            dgv.Columns[0].DataPropertyName = "LOCA_IDE";

            dgv.Columns[1].Width = 60;
            dgv.Columns[1].HeaderText = "Codigo";
            dgv.Columns[1].DataPropertyName = "LOCA_CODIGO";

            dgv.Columns[2].Width = 240;
            dgv.Columns[2].HeaderText = "Descripción ";
            dgv.Columns[2].DataPropertyName = "LOCA_NOMBRE";

            dgv.Columns[3].Width = 90;
            dgv.Columns[3].HeaderText = "Codigo Postal";
            dgv.Columns[3].DataPropertyName = "LOCA_CODIGO_POSTAL";

            dgv.Columns[4].Width = 140;
            dgv.Columns[4].HeaderText = "Abreviado";
            dgv.Columns[4].DataPropertyName = "LOCA_ABREVIADO";

            dgv.Columns[5].Width = 140;
            dgv.Columns[5].HeaderText = "Zona Geografica";
            dgv.Columns[5].DataPropertyName = "ZONA_GEO_IDE";

            dgv.Columns[6].Width = 140;
            dgv.Columns[6].HeaderText = "Pais";
            dgv.Columns[6].DataPropertyName = "PAIS_IDE";

            dgv.Columns[7].Width = 90;
            dgv.Columns[7].HeaderText = "Estado";
            dgv.Columns[7].DataPropertyName = "LOCA_ESTADO";


            // Columnas que no Deben Verse

            dgv.Columns[8].DataPropertyName = "LOCA_FECHAINAC";
            dgv.Columns[8].Visible = false;
            dgv.Columns[9].DataPropertyName = "CREACION";
            dgv.Columns[9].Visible = false;
            dgv.Columns[10].DataPropertyName = "VECES";
            dgv.Columns[10].Visible = false;
        }

        private void llenar_CboEstado()
        {
            cboEstado.Items.Clear();
            cboEstado.Items.Add("Activo");
            cboEstado.Items.Add("Inactivo");
            cboEstado.SelectedIndex = 0;
        }

        private void Llenar_cboZonaGeo()
        {
            ENResultOperation R = ClsZona_GeograficaBC.ListarTodos("");
            cboZonaGeo.DataSource = (DataTable)R.Valor;
            cboZonaGeo.DisplayMember = "ZONA_GEO_NOMBRE";
            cboZonaGeo.ValueMember = "ZONA_GEO_IDE";
            cboZonaGeo.AutoCompleteMode = AutoCompleteMode.Suggest;
            cboZonaGeo.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void Llenar_cboPais()
        {
            ENResultOperation R = ClsPaisBC.Listar("");
            cboPais.DataSource = (DataTable)R.Valor;
            cboPais.DisplayMember = "PAIS_NOMBRE";
            cboPais.ValueMember = "PAIS_IDE";
            cboPais.AutoCompleteMode = AutoCompleteMode.Suggest;
            cboPais.AutoCompleteSource = AutoCompleteSource.ListItems;
        }
        private void Mostrar_dgv(string filtro)
        {
            DataTable TEMP = new DataTable();
            ENResultOperation R = ClsLocalidadBC.ListarTodos(filtro);
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
            txtIde.Text = "0";
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtAbreviado.Text = "";
            txtCodPostal.Text = "";
            txtVeces.Text = "0";
            cboZonaGeo.SelectedIndex = 0;
            cboEstado.SelectedIndex = 0;  // Activo
            cboPais.SelectedIndex = 0;
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
                txtCodigo.Text = Convert.ToString(this.dgvListado.CurrentRow.Cells["CODIGO"].Value);
                txtNombre.Text = Convert.ToString(this.dgvListado.CurrentRow.Cells["NOMBRE"].Value);
                txtCodPostal.Text = Convert.ToString(this.dgvListado.CurrentRow.Cells["CODIGO_POSTAL"].Value);
                txtAbreviado.Text = Convert.ToString(this.dgvListado.CurrentRow.Cells["ABREVIADO"].Value);
                cboEstado.Text = Convert.ToString(this.dgvListado.CurrentRow.Cells["ESTADO"].Value);
                txtVeces.Text = Convert.ToString(this.dgvListado.CurrentRow.Cells["VECES"].Value);
                cboPais.SelectedValue    = Convert.ToInt32(this.dgvListado.CurrentRow.Cells["PAIS"].Value);
                cboZonaGeo.SelectedValue = Convert.ToInt32(this.dgvListado.CurrentRow.Cells["ZONA_GEOGRAFICA"].Value);
                Habilita_Campos(false);
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
            Habilita_Campos(true);
            txtCodigo.Focus();
        }

        private void btnModifica_Click(object sender, EventArgs e)
        {
            Estado_Botones(false);
            Operacion = "M";
            Habilita_Campos(true);
            txtCodigo.Focus();

        }

        private void btnElimina_Click(object sender, EventArgs e)
        {
            Estado_Botones(false);
            btnGraba.Text = "Eliminar";
            Operacion = "E";
        }

        private void btnCancela_Click(object sender, EventArgs e)
        {
            Estado_Botones(true);
            Habilita_Campos(false);
            Mostrar_Datos();
        }

        private void btnGraba_Click(object sender, EventArgs e)
        {

            if (!Verifica_Campos(txtCodigo.Text))
            {
                MessageBox.Show("Campo de Codigo no puede estar sin Valor");
                return;
            }
            if (!Verifica_Campos(txtNombre.Text))
            {
                MessageBox.Show("Campo de Nombre no puede estar sin Valor");
                return;
            }
            if (!Verifica_Campos(txtCodPostal.Text))
            {
                MessageBox.Show("Campo de Codigo Postal no puede estar sin Valor");
                return;
            }
            if (!Verifica_Campos(txtAbreviado.Text))
            {
                MessageBox.Show("Campo de Abreviado Postal no puede estar sin Valor");
                return;
            }
            if (!Verifica_Campos(cboZonaGeo.Text))
            {
                MessageBox.Show("Campo de Zona Geografica no puede estar sin Valor");
                return;
            }
            if (!Verifica_Campos(cboPais.Text))
            {
                MessageBox.Show("Campo de Pais no puede estar sin Valor");
                return;
            }
            Procesar_Operacion();
        }

        private Boolean Verifica_Campos(string campo)
        {
            if (String.IsNullOrWhiteSpace(campo)) return false;
            if (txtCodigo.Text.Length != 2 && txtCodigo.Text.Length != 4 && txtCodigo.Text.Length != 6 )
            {
                 MessageBox.Show("El Codigo debe Tener 2 , 4 o 6 Caracteres");
                 return false;
            }
            return true;
        }
        

        private void Procesar_Operacion()
        {
            ClsLocalidadBE TipoBE = new ClsLocalidadBE();
            TipoBE.Loca_ide = Convert.ToInt32(txtIde.Text);
            TipoBE.Loca_codigo = txtCodigo.Text;
            TipoBE.Loca_nombre = txtNombre.Text;
            TipoBE.Loca_codigo_postal = txtCodPostal.Text;
            TipoBE.Loca_abreviado = txtAbreviado.Text;
            TipoBE.Zona_geo_ide = Convert.ToInt32(cboZonaGeo.SelectedValue.ToString());
            TipoBE.Pais_ide = Convert.ToInt32(cboPais.SelectedValue.ToString());
            TipoBE.Loca_estado = cboEstado.Text;
            TipoBE.Loca_fechainac = Convert.ToDateTime("01-01-1900");
            TipoBE.Veces = Convert.ToInt32(txtVeces.Text);
            TipoBE.Usuario = "ADMIN";
            TipoBE.Creacion = Convert.ToDateTime(DateTime.Today);

            TipoBE.Nombre_error = "";
            
            switch (Operacion)
            {
                case "N":
                    {
                        ENResultOperation R = ClsLocalidadBC.Crear(TipoBE);
                        if (!R.Proceder) MessageBox.Show("Error al Insertar Localidad : " + R.Sms);
                        break;
                    }
                case "M":
                    {
                        ENResultOperation R = ClsLocalidadBC.Actualizar(TipoBE);
                        if (!R.Proceder) MessageBox.Show("Error al Modificar Localidad : " + R.Sms);
                        break;
                    }
                case "E":
                    {
                        ENResultOperation R = ClsLocalidadBC.Eliminar(TipoBE);
                        if (!R.Proceder) MessageBox.Show("Error al Eliminar Localidad : " + R.Sms);
                        break;
                    }
            }
            Estado_Botones(true);
            Habilita_Campos(false);
            Mostrar_dgv("");
            Mostrar_Datos();
            btnGraba.Text = "Grabar";
        }

        private void Habilita_Campos(bool Flag)
        {
            txtIde.Enabled = false;
            cboEstado.Enabled = Flag;
            txtCodigo.Enabled = Flag;
            txtNombre.Enabled = Flag;
            txtAbreviado.Enabled = Flag;
            txtCodigo.Enabled = Flag;
            cboZonaGeo.Enabled = Flag;
            txtCodPostal.Enabled = Flag;
        }

  
        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            //MessageBox.Show("Valor del Texto : " + txtNombre.Text);
        }


        private void dgvListado_CurrentCellChanged(object sender, EventArgs e)
        {
            Mostrar_Datos();
        }

        private void txtVeces_TextChanged(object sender, EventArgs e)
        {

        }

  
    }
}
