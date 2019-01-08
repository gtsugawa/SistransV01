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
    public partial class frmCliente_Contacto_Buscar : Form
    {
        public Int32  Clie_Ide { get; set; }
        public string Clie_Nombre { get; set; }
        public string Contacto_Ide { get; set; }
        public string Clie_Contacto { get; set;}
        public frmCliente_Contacto_Buscar()
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
            dgv.Columns[1].Name = "CONT_IDE";
            dgv.Columns[2].Name = "CONT_TITULO";
            dgv.Columns[3].Name = "CONT_PATERNO";
            dgv.Columns[4].Name = "CONT_MATERNO";
            dgv.Columns[5].Name = "CONT_NOMBRE";
            dgv.Columns[6].Name = "CARG_IDE";
            dgv.Columns[7].Name = "CONT_DIRECCION";
            dgv.Columns[8].Name = "LOCA_IDE";
            dgv.Columns[9].Name = "CONT_TELEFONO_CASA";
            dgv.Columns[10].Name = "CONT_TELEFONO_CELULAR";
            dgv.Columns[11].Name = "CONT_FAX";
            dgv.Columns[12].Name = "DOCU_IDEN_IDE";
            dgv.Columns[13].Name = "CONT_DOCUMENTO";
            dgv.Columns[14].Name = "CONT_FECHA_NACIMIENTO";
            dgv.Columns[15].Name = "CONT_SEXO";
            dgv.Columns[16].Name = "CONT_ESTADO_CIVIL";
            dgv.Columns[17].Name = "CONT_CORREO";
            dgv.Columns[18].Name = "CONT_NOTA";
            dgv.Columns[19].Name = "CREACION";
            dgv.Columns[20].Name = "VECES";
            dgv.Columns[21].Name = "LRC";

            dgv.Columns[0].Width = 60;
            dgv.Columns[0].HeaderText = "ID";
            dgv.Columns[0].DataPropertyName = "CLIE_IDE";
            dgv.Columns[0].Visible = false;

            dgv.Columns[1].Width = 50;
            dgv.Columns[1].HeaderText = "IDE";
            dgv.Columns[1].DataPropertyName = "CLIE_CONT_IDE";
            dgv.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            
            //dgv.Columns[1].Visible = false;

            dgv.Columns[2].Width = 40;
            dgv.Columns[2].HeaderText = "Tit";
            dgv.Columns[2].DataPropertyName = "CLIE_CONT_TITULO";
           

            dgv.Columns[3].Width = 130;
            dgv.Columns[3].HeaderText = "Paterno";
            dgv.Columns[3].DataPropertyName = "CLIE_CONT_PATERNO";

            dgv.Columns[4].Width = 130;
            dgv.Columns[4].HeaderText = "Materno";
            dgv.Columns[4].DataPropertyName = "CLIE_CONT_MATERNO";

            dgv.Columns[5].Width = 130;
            dgv.Columns[5].HeaderText = "Nombres";
            dgv.Columns[5].DataPropertyName = "CLIE_CONT_NOMBRE";

            dgv.Columns[6].Width = 90;
            dgv.Columns[6].HeaderText = "Cargo";
            dgv.Columns[6].DataPropertyName = "CARG_IDE";
            dgv.Columns[6].Visible = false;

            dgv.Columns[7].HeaderText = "Direccion";
            dgv.Columns[7].DataPropertyName = "CLIE_CONT_DIRECCION";
            dgv.Columns[7].Visible = false;

            dgv.Columns[8].HeaderText = "Localidad";
            dgv.Columns[8].DataPropertyName = "LOCA_IDE";
            dgv.Columns[8].Visible = false;

            dgv.Columns[9].Width = 90;
            dgv.Columns[9].HeaderText = "Telefono Casa";
            dgv.Columns[9].DataPropertyName = "CLIE_CONT_TELEFONO_CASA";
            dgv.Columns[9].Visible = false;

            dgv.Columns[10].Width = 90;
            dgv.Columns[10].HeaderText = "Celular";
            dgv.Columns[10].DataPropertyName = "CLIE_CONT_TELEFONO_CELULAR";
            dgv.Columns[10].Visible = false;

            dgv.Columns[11].Width = 90;
            dgv.Columns[11].HeaderText = "Fax";
            dgv.Columns[11].DataPropertyName = "CLIE_CONT_FAX";
            dgv.Columns[11].Visible = false;

            dgv.Columns[12].Width = 90;
            dgv.Columns[12].HeaderText = "Tipo Doc";
            dgv.Columns[12].DataPropertyName = "DOCU_IDEN_IDE";
            dgv.Columns[12].Visible = false;

            dgv.Columns[13].Width = 90;
            dgv.Columns[13].HeaderText = "Documento";
            dgv.Columns[13].DataPropertyName = "CLIE_CONT_DOCUMENTO";
            dgv.Columns[13].Visible = false;

            dgv.Columns[14].Width = 90;
            dgv.Columns[14].HeaderText = "F.Nacimiento";
            dgv.Columns[14].DataPropertyName = "CLIE_CONT_FECHA_NACIMIENTO";
            dgv.Columns[14].Visible = false;

            dgv.Columns[15].Width = 90;
            dgv.Columns[15].HeaderText = "Sexo";
            dgv.Columns[15].DataPropertyName = "CLIE_CONT_SEXO";
            dgv.Columns[15].Visible = false;

            dgv.Columns[16].Width = 90;
            dgv.Columns[16].HeaderText = "Estado Civil";
            dgv.Columns[16].DataPropertyName = "CLIE_CONT_ESTADO_CIVIL";
            dgv.Columns[16].Visible = false;

            dgv.Columns[17].Width = 90;
            dgv.Columns[17].HeaderText = "Correo";
            dgv.Columns[17].DataPropertyName = "CLIE_CONT_CORREO";
            dgv.Columns[17].Visible = false;

            dgv.Columns[18].Width = 90;
            dgv.Columns[18].HeaderText = "Nota";
            dgv.Columns[18].DataPropertyName = "CLIE_CONT_NOTA";
            dgv.Columns[18].Visible = false;
            // Columnas que no Deben Verse

            dgv.Columns[19].DataPropertyName = "CREACION";
            dgv.Columns[19].Visible = false;

            dgv.Columns[20].DataPropertyName = "VECES";
            dgv.Columns[20].Visible = false;

            dgv.Columns[21].DataPropertyName = "LRC_IDE";
            dgv.Columns[21].Visible = false;
        }

        private void frmCliente_Contacto_Buscar_Load(object sender, EventArgs e)
        {
            FormatoDgv();
            txtRazon_Social.Text = Clie_Nombre;
            Cargar_Cliente_Contacto(Clie_Ide);
        }
        public void Cargar_Cliente_Contacto(Int32 Clie_Ide)
        {
            DataTable TEMP = new DataTable();
            ENResultOperation R = ClsCliente_ContactoBC.Listar_Filtro(Clie_Ide);
            if (R.Proceder) dgvListado.DataSource = (DataTable)R.Valor;
          
        }

        private void Aceptar_Contacto()
        {
            String Nombre_Contacto = Convert.ToString(this.dgvListado.CurrentRow.Cells["CONT_TITULO"].Value);
            Nombre_Contacto += ' ' + Convert.ToString(this.dgvListado.CurrentRow.Cells["CONT_PATERNO"].Value);
            Nombre_Contacto += ' ' + Convert.ToString(this.dgvListado.CurrentRow.Cells["CONT_MATERNO"].Value);
            Nombre_Contacto += ' ' + Convert.ToString(this.dgvListado.CurrentRow.Cells["CONT_NOMBRE"].Value);
            Clie_Contacto = Nombre_Contacto;
            Contacto_Ide = Convert.ToString(this.dgvListado.CurrentRow.Cells["CONT_IDE"].Value);
            this.Close();
        }


        private void dgvListado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Aceptar_Contacto();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Aceptar_Contacto();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvListado_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                Aceptar_Contacto();
            }   
        }

        private void frmCliente_Contacto_Buscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Escape) btnSalir.PerformClick();
        }

    }
}
