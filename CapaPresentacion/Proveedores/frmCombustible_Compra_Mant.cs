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

namespace CapaPresentacion.Proveedores
{
    public partial class frmCombustible_Mant : Form
    {
        public int nComp_Ide = 0;

        string Operacion = null;  // Operaciones : N = Nuevo / M = Modificar E = Eliminar
        Int32 nProve_Ide;
        Int32 nTran_Ide;
        Int32 nTran_Vehi_Ide;
        Int32 nTran_Chof_Ide;
        public frmCombustible_Mant()
        {
            InitializeComponent();
        }

        private void frmCombustible_Compra_Mant_Load(object sender, EventArgs e)
        {
            
            Cargar_Registro(nComp_Ide);
            if (nComp_Ide != 0)
            {
                Operacion = "M";
            }
            else
            {
                Operacion = "N";
            }
            Carga_Tipo_Combustible();
            Habilitar_Campos(false);
            Habilitar_Botones(true);
            btnNuevo.Focus();
        }

        private void Carga_Tipo_Combustible()
        {
            cboTipoCombustible.Items.Clear();
            cboTipoCombustible.Items.Add("Petroleo");
            cboTipoCombustible.Items.Add("Gas");
            cboTipoCombustible.Items.Add("Gasolina");
            cboTipoCombustible.SelectedIndex = 0;
        }

        private void Cargar_Registro(int nComp_Ide)
        {
            ENResultOperation R = ClsCombustible_CompraBC.Buscar_Comprobante(nComp_Ide);
            DataTable dtg = (DataTable)R.Valor;
            if (dtg.Rows.Count != 0)
            {
                DataRow ROWG = dtg.Rows[0];
                txtProve.Text  = ROWG["RAZON_SOCIAL"].ToString();
                txtProve_Ide.Text = ROWG["PROV_IDE"].ToString();
                dtpFecha.Text = ROWG["COMP_FECHA"].ToString();
                txtNumero.Text = ROWG["COMP_NUMERO"].ToString();
                txtTran_Ide.Text = ROWG["TRAN_IDE"].ToString();
                txtTransportista.Text = ROWG["TRANSPORTISTA"].ToString();
                txtPlaca.Text = ROWG["PLACA"].ToString();
                txtKilometraje.Text = ROWG["COMP_KILOMETRAJE"].ToString();
                txtChofer.Text = ROWG["CHOFER"].ToString();
                txtCantidad.Text = ROWG["COMP_CANTIDAD"].ToString();
                txtImporte.Text = ROWG["COMP_IMPORTE"].ToString();
                cboTipoCombustible.Text = ROWG["COMP_TIPO_COMBUSTIBLE"].ToString();
                txtVehi_Ide.Text = ROWG["TRAN_VEHI_IDE"].ToString();
                txtChof_ide.Text = ROWG["TRAN_CHOF_IDE"].ToString();
                nTran_Ide = Convert.ToInt32(txtTran_Ide.Text);
                nProve_Ide = Convert.ToInt32(txtProve_Ide.Text);
                nTran_Vehi_Ide = Convert.ToInt32(ROWG["TRAN_VEHI_IDE"]);
                nTran_Chof_Ide = Convert.ToInt32(ROWG["TRAN_CHOF_IDE"]);
            }
            else
            {
                Habilitar_Botones(true);
            }
            
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            Habilitar_Campos(false);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Habilitar_Botones(false);
            Habilitar_Campos(true);
            Operacion = "M";
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Inicializa_Campos();
            Habilitar_Botones(false);
            Habilitar_Campos(true);
            Operacion = "N";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Habilitar_Botones(false);
            btnGrabar.Text = "Eliminar";
            Habilitar_Campos(false);
            Operacion = "E";
        }

        private void Inicializa_Campos()
        {
            txtProve.Text = "";
            dtpFecha.Text = DateTime.Now.ToString();
            txtNumero.Text = "";
            txtTransportista.Text = "";
            txtPlaca.Text = "";
            txtChofer.Text = "";
            txtCantidad.Text = "0";
            txtImporte.Text = "0";
            txtKilometraje.Text = "0";
            cboTipoCombustible.SelectedIndex = 0;
        }
        private void Habilitar_Campos(Boolean Flag)
        {
            txtProve.ReadOnly = !Flag;
            dtpFecha.Enabled  = Flag;
            txtNumero.ReadOnly = !Flag;
            txtTransportista.ReadOnly = !Flag;
            txtPlaca.ReadOnly = !Flag;
            txtChofer.ReadOnly = !Flag;
            txtCantidad.ReadOnly = !Flag;
            txtImporte.ReadOnly = !Flag;
            txtKilometraje.ReadOnly = !Flag;
            cboTipoCombustible.Enabled = Flag;
        }

        private void Habilitar_Botones(Boolean Flag)
        {
            btnNuevo.Enabled = Flag;
            btnModificar.Enabled = Flag;
            btnEliminar.Enabled = Flag;
            btnGrabar.Enabled = !Flag;
            btnCancelar.Enabled = !Flag;
            btnSalir.Enabled = Flag;
            this.KeyPreview = Flag;
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            Procesar_Operacion();
            btnGrabar.Text = "Grabar";
            Habilitar_Campos(false);
            Habilitar_Botones(true);
            Cargar_Registro(nComp_Ide);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Habilitar_Botones(true);
            Habilitar_Campos(false);
            Cargar_Registro(nComp_Ide);
        }

        private Boolean Verifica_Campos()
        {
            if (string.IsNullOrEmpty(txtProve.Text))
            {
                MessageBox.Show("No se Ha seleccionado un Proveedor de Combustible", "Grifo");
                return false;
            }
            if (string.IsNullOrEmpty(txtTransportista.Text))
            {
                MessageBox.Show("No se Ha seleccionado un Chofer ", "Grifo");
                return false;
            }
            return true;
        }
        private void Procesar_Operacion()
        {
            ClsCombustible_CompraBE TipoBE = new ClsCombustible_CompraBE();
            TipoBE.Comp_ide = nComp_Ide;
            TipoBE.Comp_fecha = Convert.ToDateTime(dtpFecha.Text);
            TipoBE.Prov_ide = nProve_Ide;
            TipoBE.Comp_numero = txtNumero.Text;
            TipoBE.Comp_tipo_combustible = cboTipoCombustible.Text;
            TipoBE.Comp_cantidad = Convert.ToDecimal(txtCantidad.Text);
            TipoBE.Comp_importe = Convert.ToDecimal(txtImporte.Text);
            TipoBE.Comp_kilometraje = Convert.ToInt32(txtKilometraje.Text);
            TipoBE.Tran_ide = nTran_Ide;
            TipoBE.Tran_vehi_ide = nTran_Vehi_Ide;
            TipoBE.Tran_chof_ide = nTran_Chof_Ide;
            TipoBE.Comp_lugar = "";
            TipoBE.Estado = 0;
            TipoBE.Usuario = "ADMIN";
            TipoBE.Creacion = Convert.ToDateTime(DateTime.Today);

            TipoBE.Nombre_error = "";

            switch (Operacion)
            {
                case "N":
                    {
                        ENResultOperation R = ClsCombustible_CompraBC.Crear(TipoBE);
                        if (!R.Proceder) MessageBox.Show("Error al Insertar Compra de Combustible " + R.Sms);
                        break;
                    }
                case "M":
                    {
                        ENResultOperation R = ClsCombustible_CompraBC.Actualizar(TipoBE);
                        if (!R.Proceder) MessageBox.Show("Error al Modificar Compra de Combustible " + R.Sms);
                        break;
                    }
                case "E":
                    {
                        ENResultOperation R = ClsCombustible_CompraBC.Eliminar(TipoBE);
                        if (!R.Proceder) MessageBox.Show("Error al Eliminar Compra de Combustible " + R.Sms);
                        break;
                    }
            }

        }

        private void txtProve_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter || (int)e.KeyChar == (int)Keys.F3) 
            {
              Buscar_Proveedor();
              SendKeys.Send("{TAB}");
            }
        }

        private void txtProve_DoubleClick(object sender, EventArgs e)
        {
            Buscar_Proveedor();
        }

        private void Buscar_Proveedor()
        {
            ENResultOperation R = ClsProveedorBC.Listar(txtProve.Text);
            if (R.Proceder)
            {
                DataTable dt = (DataTable)R.Valor;
                if (dt.Rows.Count == 1)
                {
                    DataRow ROW = dt.Rows[0];
                    txtProve.Text = ROW["PROV_RAZON_SOCIAL"].ToString();
                    nProve_Ide = Convert.ToInt32(ROW["PROV_IDE"]);
                    txtProve_Ide.Text = nProve_Ide.ToString();
                }
                else
                {
                    frmProveedorBuscar frmBuscarProv = new frmProveedorBuscar();
                    frmBuscarProv.ProveedorRazon = txtProve.Text;
                    frmBuscarProv.ShowDialog();
                    txtProve.Text = frmBuscarProv.ProveedorRazon;
                }

            }
        }

        private void txtTransportista_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter || (int)e.KeyChar == (int)Keys.F3)
            {
                Buscar_Transportista();
            }
        }
        private void txtTransportista_DoubleClick(object sender, EventArgs e)
        {
            Buscar_Transportista();
        }

        public void Buscar_Transportista()
        {
            ENResultOperation R = ClsTransportistaBC.Listar(txtTransportista.Text);
            if (R.Proceder)
            {
                DataTable dt = (DataTable)R.Valor;
                if (dt.Rows.Count == 1)
                {
                    DataRow ROW = dt.Rows[0];
                    txtTransportista.Text = ROW["TRAN_RAZON_SOCIAL"].ToString();
                    nTran_Ide = Convert.ToInt32(ROW["TRAN_IDE"]);
                    txtTran_Ide.Text = nTran_Ide.ToString();
                }
                else
                {
                    Transportista.frmTransportista_Buscar frmBuscarTran = new Transportista.frmTransportista_Buscar();
                    frmBuscarTran.TransportistaRazon = txtTransportista.Text;
                    frmBuscarTran.ShowDialog();
                    txtTransportista.Text = frmBuscarTran.TransportistaRazon;
                    nTran_Ide = Convert.ToInt32(frmBuscarTran.TransportistaID);
                    txtTran_Ide.Text = nTran_Ide.ToString();
                }

                txtPlaca.Focus();
            }
        }
        private void txtChofer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.F3) Buscar_Chofer();
            if ((int)e.KeyChar == (int)Keys.Enter) SendKeys.Send("{TAB}");
        }
        private void txtChofer_DoubleClick(object sender, EventArgs e)
        {
            Buscar_Chofer();
        }

        private void Buscar_Chofer()
        {
            ENResultOperation R = ClsTransportista_ChoferBC.Listar_Filtro(txtChofer.Text, nTran_Ide);
            if (R.Proceder)
            {
                DataTable dt = (DataTable)R.Valor;
                if (dt.Rows.Count == 1)
                {
                    DataRow ROW = dt.Rows[0];
                    txtChofer.Text = ROW["TRAN_CHOF_NOMBRE"].ToString();
                    nTran_Chof_Ide = Convert.ToInt32(ROW["TRAN_CHOF_IDE"]);
                }
                else
                {
                    Transportista.frmTransportista_Chofer_Buscar frmBuscarChof = new Transportista.frmTransportista_Chofer_Buscar();
                    frmBuscarChof.Transportista_Ide = nTran_Ide;
                    frmBuscarChof.Transportista_Nombre = txtChofer.Text;
                    frmBuscarChof.ShowDialog();
                    txtChofer.Text = frmBuscarChof.Transportista_Nombre;
                    nTran_Chof_Ide = Convert.ToInt32(frmBuscarChof.Chofer_Ide);
                }
            }
        }

        private void txtProve_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPlaca_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter || (int)e.KeyChar == (int)Keys.F3)
            {
                Buscar_Placa();
            }
            if ((int)e.KeyChar == (int)Keys.Enter) SendKeys.Send("{TAB}");
        }
        private void txtPlaca_DoubleClick(object sender, EventArgs e)
        {
            Buscar_Placa();
        }

        private void Buscar_Placa()
        {
            ENResultOperation R = ClsTransportista_VehiculoBC.Listar_Filtro(txtPlaca.Text, nTran_Ide);
            if (R.Proceder)
            {
                DataTable dt = (DataTable)R.Valor;
                if (dt.Rows.Count == 1)
                {
                    DataRow ROW = dt.Rows[0];
                    txtPlaca.Text = ROW["TRAN_VEHI_PLACA"].ToString();
                    nTran_Ide = Convert.ToInt32(ROW["TRAN_IDE"]);
                    txtTran_Ide.Text = nTran_Ide.ToString();
                    nTran_Vehi_Ide = Convert.ToInt32(ROW["TRAN_VEHI_IDE"]);
                }
                else
                {
                    Transportista.frmTransportista_Vehiculo_Buscar frmBuscarVeh = new Transportista.frmTransportista_Vehiculo_Buscar();
                    frmBuscarVeh.Transportista_Ide = nTran_Ide;
                    frmBuscarVeh.Vehiculo_Placa = txtPlaca.Text;
                    frmBuscarVeh.ShowDialog();
                    txtPlaca.Text = frmBuscarVeh.Vehiculo_Placa;
                    nTran_Vehi_Ide = Convert.ToInt32(frmBuscarVeh.Vehiculo_Ide);
                }
            }
        }

        private void txtKilometraje_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter) SendKeys.Send("{TAB}");
            TextBox textbox = (TextBox)sender; // Convierto el sender a TextBox
            solo_numeros(ref textbox, e); // Llamamos a nuestro método
            
        }

        private void cboTipoCombustible_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter) SendKeys.Send("{TAB}");
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter) SendKeys.Send("{TAB}");
            
        }

        private void txtImporte_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter) SendKeys.Send("{TAB}");
            
        }

        private void dtpFecha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter) SendKeys.Send("{TAB}");
        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter) SendKeys.Send("{TAB}");
        }

        public List<int> valores_permitidos = new List<int>() { 8, 13, 37, 38, 39, 40, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 46 };
        public void solo_numeros(ref TextBox textbox, KeyPressEventArgs e)
        {
            char signo_decimal = (char)46; //Si pulsan el punto .

            if (char.IsNumber(e.KeyChar) | valores_permitidos.Contains(e.KeyChar) |
                e.KeyChar == (char)Keys.Escape | e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false; // No hacemos nada y dejamos que el sistema controle la pulsación de tecla
                return;
            }
            else if (e.KeyChar == signo_decimal)
            {
                //Si no hay caracteres, o si ya hay un punto, no dejaremos poner el punto(.)
                if (textbox.Text.Length == 0 | textbox.Text.LastIndexOf(signo_decimal) >= 0)
                {
                    e.Handled = true; // Interceptamos la pulsación para que no permitirla.
                }
                else //Si hay caracteres continuamos las comprobaciones
                {
                    //Cambiamos la pulsación al separador decimal definido por el sistema 
                    e.KeyChar = Convert.ToChar(System.Globalization.NumberFormatInfo.CurrentInfo.CurrencyDecimalSeparator);
                    e.Handled = false; // No hacemos nada y dejamos que el sistema controle la pulsación de tecla
                }
                return;
            }
            else if (e.KeyChar == (char)13) // Si es un enter
            {
                e.Handled = true; //Interceptamos la pulsación para que no la permita.
                SendKeys.Send("{TAB}"); //Pulsamos la tecla Tabulador por código
            }
            else //Para el resto de las teclas
            {
                e.Handled = true; // Interceptamos la pulsación para que no tenga lugar
            }
        }

        private void frmCombustible_Mant_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
                Habilitar_Campos(false);
            }
        }


    }
}
