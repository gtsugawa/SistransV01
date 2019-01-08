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
    public partial class frmArticulo : Form
    {
        string Operacion = null;  // Operaciones : N = Nuevo / M = Modificar E = Eliminar
        string Mens_Error = "";
        Boolean Flg_Retorno = true;
        public frmArticulo()
        {
            InitializeComponent();
        }

        private void frmArticulo_Load(object sender, EventArgs e)
        {
            FormatoDgv1();
            Mostrar_dgv1("");
            Cargar_ComboBox1();
        }

        private void Mostrar_dgv1(string filtro)
        {
            ENResultOperation R = ClsArticuloBC.Listar(filtro);
            if (R.Proceder)
            {
                dgv1Listado.DataSource = (DataTable)R.Valor;
            }
            else
            {
                MessageBox.Show("Error al Obtener Valores : " + R.Sms);
            }
        }

        void FormatoDgv1()
        {

            var dgv1 = dgv1Listado;

            dgv1.MultiSelect = false;
            dgv1.ReadOnly = true;
            dgv1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv1.AllowUserToAddRows = false;
            dgv1.AllowUserToDeleteRows = false;
            //---------Centrar titulo de cabecera --------------/
            dgv1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //-- No se hace visible la primera columna del datagrid /
            dgv1.RowHeadersVisible = false;
            //---No premite cambiar el tamaño a la columna/
            dgv1.AllowUserToResizeColumns = false;
            dgv1.AllowUserToResizeRows = false;
            //---------------Tipo de fuente y tamaño-----/
            dgv1.DefaultCellStyle.Font = new Font("Tahoma", 10);
            //----------Alterna colores en el grid -------/
            dgv1.RowsDefaultCellStyle.BackColor = Color.LightBlue;
            dgv1.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
            //---Pintado de color a la cabecera del datagrid ---/
            DataGridViewCellStyle style = this.dgv1Listado.ColumnHeadersDefaultCellStyle;
            style.BackColor = Color.Honeydew;
            style.ForeColor = Color.Gray;


            dgv1.Columns.Clear();
            dgv1.ColumnCount = 7;
            // Setear Cabecera de Columna 

            dgv1.Columns[0].Name = "IDE";
            dgv1.Columns[1].Name = "TIPO";
            dgv1.Columns[2].Name = "CODIGO";
            dgv1.Columns[3].Name = "NOMBRE";
            dgv1.Columns[4].Name = "MODELO";
            dgv1.Columns[5].Name = "ESTADO";
            dgv1.Columns[6].Name = "INACTIVA";


            dgv1.Columns[0].Width = 40;
            dgv1.Columns[0].HeaderText = "ID";
            dgv1.Columns[0].DataPropertyName = "ARTI_IDE";

            dgv1.Columns[1].Width = 90;
            dgv1.Columns[1].HeaderText = "Tipo  ";
            dgv1.Columns[1].DataPropertyName = "ARTI_TIPO";

            dgv1.Columns[2].Width = 100;
            dgv1.Columns[2].HeaderText = "Codigo";
            dgv1.Columns[2].DataPropertyName = "ARTI_CODIGO";

            dgv1.Columns[3].Width = 400;
            dgv1.Columns[3].HeaderText = "Nombre";
            dgv1.Columns[3].DataPropertyName = "ARTI_NOMBRE";

            dgv1.Columns[4].DataPropertyName = "ARTI_MODELO";
            dgv1.Columns[4].Visible = false;

            dgv1.Columns[5].Width = 90;
            dgv1.Columns[5].HeaderText = "Estado";
            dgv1.Columns[5].DataPropertyName = "ARTI_ESTADO";
            dgv1.Columns[5].Visible = false;
            
            dgv1.Columns[6].DataPropertyName = "ARTI_FECHAINAC";
            dgv1.Columns[6].Visible = false;
        }

        private void Cargar_ComboBox1()
        {
            cbo1Estado.Items.Clear();
            cbo1Estado.Items.Add("Activo");
            cbo1Estado.Items.Add("Inactivo");
            cbo1Estado.SelectedIndex = 0;

            cbo1Tipo.Items.Clear();
            cbo1Tipo.Items.Add("Concepto");
            cbo1Tipo.Items.Add("Mercaderia");
            cbo1Tipo.Items.Add("Suministro");
            cbo1Estado.SelectedIndex = 0;

        }

        private void Estado_Botones1(bool flag)
        {
            btn1Nuevo.Enabled = flag;
            btn1Modifica.Enabled = flag;
            btn1Elimina.Enabled = flag;
            btn1Cancela.Enabled = !flag;
            btn1Graba.Enabled = !flag;
            btn1Salir.Enabled = flag;
        }

        private void Inicializa_campos1()
        {
            txt1Ide.Text = "0";
            txt1Nombre.Text = "";
            txt1Codigo.Text = "";
            txt1Modelo.Text = "";
            cbo1Tipo.Text   = "Concepto";
            cbo1Estado.Text = "Activo";
        }

        private void Deshabilitar_Campos1(bool Flag)
        {
            txt1Ide.ReadOnly = true;
            txt1Nombre.ReadOnly = Flag;
            txt1Codigo.ReadOnly = Flag;
            txt1Modelo.ReadOnly = Flag;
            cbo1Tipo.Enabled = !Flag;
            cbo1Estado.Enabled = !Flag;
        }

        private void btn1Nuevo_Click(object sender, EventArgs e)
        {
            Operacion = "N";
            Estado_Botones1(false);
            Inicializa_campos1();
            Deshabilitar_Campos1(false);
            txt1Codigo.Focus();
        }

        private void btn1Modifica_Click(object sender, EventArgs e)
        {
            Operacion = "M";
            Estado_Botones1(false);
            Deshabilitar_Campos1(false);
            txt1Nombre.Focus();
        }

        private void btn1Elimina_Click(object sender, EventArgs e)
        {
            Operacion = "E";
            Estado_Botones1(false);
            btn1Graba.Enabled = false;
            if (MessageBox.Show("Seguro de Eliminar Articulo", "Eliminacion de Articulo", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2, MessageBoxOptions.DefaultDesktopOnly) == DialogResult.Yes)
            {
                Procesar_Operacion1();
            }
        }

        private void btn1Cancela_Click(object sender, EventArgs e)
        {
            Estado_Botones1(true);
            Deshabilitar_Campos1(true);
            Llenar_Campos1();
        }

        private void btn1Graba_Click(object sender, EventArgs e)
        {
            if (!Verifica_Campos(txt1Nombre.Text))
            {
                MessageBox.Show("Campo de Nombre no puede estar sin Valor");
                return;
            }
            Procesar_Operacion1();
        }

        private void btn1Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgv1Listado_CurrentCellChanged(object sender, EventArgs e)
        {
            Llenar_Campos1();
        }

        private Boolean Verifica_Campos(string campo)
        {
            if (String.IsNullOrWhiteSpace(campo)) return false;
            return true;
        }
        private void Llenar_Campos1()
        {
            if (dgv1Listado.CurrentRow != null)
            {
                txt1Ide.Text = Convert.ToString(this.dgv1Listado.CurrentRow.Cells["IDE"].Value);
                txt1Nombre.Text = Convert.ToString(this.dgv1Listado.CurrentRow.Cells["NOMBRE"].Value);
                txt1Codigo.Text = Convert.ToString(this.dgv1Listado.CurrentRow.Cells["CODIGO"].Value);
                txt1Modelo.Text = Convert.ToString(this.dgv1Listado.CurrentRow.Cells["MODELO"].Value);
                cbo1Estado.Text = Convert.ToString(this.dgv1Listado.CurrentRow.Cells["ESTADO"].Value);
                cbo1Tipo.Text = Convert.ToString(this.dgv1Listado.CurrentRow.Cells["TIPO"].Value);
            }
        }

        private void Procesar_Operacion1()
        {
            ClsArticuloBE TipoBE = new ClsArticuloBE();
            TipoBE.Arti_ide = Convert.ToInt32(txt1Ide.Text);
            TipoBE.Arti_nombre = txt1Nombre.Text;
            TipoBE.Arti_codigo = txt1Codigo.Text;
            TipoBE.Arti_modelo = txt1Modelo.Text;
            TipoBE.Arti_estado = cbo1Estado.Text;
            TipoBE.Arti_tipo   = cbo1Tipo.Text;
            TipoBE.Arti_fechainac = Convert.ToDateTime("01-01-1900");
            TipoBE.Usuario = "ADMIN";
            TipoBE.Nombre_error = "";

            Mens_Error = "";
            Flg_Retorno = true;

            switch (Operacion)
            {
                case "N":
                    {
                        ENResultOperation R = ClsArticuloBC.Crear(TipoBE);
                        Flg_Retorno = R.Proceder;
                        Mens_Error = R.Sms;
                        break;
                    }
                case "M":
                    {
                        ENResultOperation R = ClsArticuloBC.Actualizar(TipoBE);
                        Flg_Retorno = R.Proceder;
                        Mens_Error = R.Sms;
                        break;
                    }
                case "E":
                    {
                        ENResultOperation R = ClsArticuloBC.Eliminar(TipoBE);
                        Flg_Retorno = R.Proceder;
                        Mens_Error = R.Sms;
                        break;
                    }
            }
            if (!Flg_Retorno)
            {
                MessageBox.Show("Error al Ejecutar Operacion : " + Mens_Error);
            }

            Estado_Botones1(true);
            Deshabilitar_Campos1(true);
            Mostrar_dgv1("");
            Llenar_Campos1();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Buscar_Articulo_Listar_Filtro(txt1Buscar.Text);
        }

        private void Buscar_Articulo_Listar_Filtro(string filtro)
        {
            ENResultOperation R = ClsArticuloBC.Listar_Filtro(filtro);
            if (R.Proceder)
            {
                dgv1Listado.DataSource = (DataTable)R.Valor;
            }
            else
            {
                MessageBox.Show("Error al Obtener Valores : " + R.Sms);
            }
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                Buscar_Articulo_Listar_Filtro(txt1Buscar.Text); 
            }
        }
    }
}
