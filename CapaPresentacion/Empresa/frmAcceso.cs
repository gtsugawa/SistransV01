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
using CP = CapaPresentacion;


namespace CapaPresentacion.Empresa
{
    public partial class frmAcceso : Form
    {
        public string Nombre_Empresa;
        public string Nombre_Usuario;
        public string Clave_Usuario;
        public string pcodEmpre;
        public string IP_BD;
        public string Modulos;
        public frmAcceso()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {


        }

        private Boolean Verifica_Login(String Usuario)
        {
            ENResultOperation R = ClsUsuarioBC.Listar_Filtro(Usuario);
            if (R.Proceder)
            {
                DataTable dt = new DataTable();
                dt = (DataTable)R.Valor;
                DataRow row = dt.Rows[0];
                Nombre_Usuario = row["NOMBRE"].ToString();
                Clave_Usuario = row["CLAVE_SEC"].ToString();
                Modulos = row["MODULOS"].ToString();
                if (txtContraseña.Text == Clave_Usuario)
                {
                    txtUsuario.Focus();
                    return true;
                }
                else
                {
                    MessageBox.Show("Contraseña del Usuario Incorrecto");
                    return false;
                }
                
            }
            else
            {
                MessageBox.Show("Usuario Incorrecto");
                return false;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            frmEmpresa frmempre = new frmEmpresa();
            frmempre.Show();
            this.Close();
            
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsuario.Text) || string.IsNullOrEmpty(txtContraseña.Text))
            {
                MessageBox.Show("Ingrese Usuario y Contraseña");
            }
            else
            {
                if (Verifica_Login(txtUsuario.Text.Trim()))
                {
                    MDIMenuOperaciones MenuPrin = new MDIMenuOperaciones();
                    MenuPrin.MNombre_Empresa = lblNombre_Empresa.Text + "                          ";
                    MenuPrin.MUsuario = "  " + Nombre_Usuario + "   ";
                    MenuPrin.Show();
                    CP.VarGlobales.NombreEmpresa = lblNombre_Empresa.Text;
                    CP.VarGlobales.CodigoUsuario = txtUsuario.Text;
                    CP.VarGlobales.NombreUsuario = Nombre_Usuario;
                    CP.VarGlobales.PorcentajeIgv = 18;
                    CP.VarGlobales.PorcentajeIgv = 10;
                    this.Close();
                }
            }
            txtUsuario.Focus();
        }

        private void frmAcceso_Load(object sender, EventArgs e)
        {
            lblNombre_Empresa.Text = Nombre_Empresa;
            txtUsuario.Focus();

        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                txtContraseña.Focus();
            }
        }

        private void txtContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                btnAceptar.Focus();
            }
        }
    }
}
