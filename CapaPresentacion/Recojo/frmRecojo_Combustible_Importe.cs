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

namespace CapaPresentacion.Recojo
{
    public partial class frmRecojo_Combustible_Importe : Form
    {

        public Int32  ID_Reco_Ide = 0;
        public Int32  ID_Reco_Ide_Detalle = 0;
        public Int32  ID_Veces = 0;
        public Int32  ID_Vehi_Ide = 0;
        public Int32  ID_Tran_Ide = 0;
        private Int32 nRecorrido = 0;
        private Int32 nKmInicial = 0;
        private Int32 nKmFinal = 0;
        private Decimal nRendimiento;
        private Decimal nFactor;
        private Decimal nImporte;
        private Decimal nTotal;

        public  string cTipoCombustible;
        public  Int32  nTipoCombustible;
        public DateTime dFechaOrden;

        public string Operacion_Combustible = "";
        public string Veh_Rendimiento = "";
        
        public frmRecojo_Combustible_Importe()
        {
            InitializeComponent();
        }

        private void frmRecojo_Combustible_Importe_Load(object sender, EventArgs e)
        {
            ToolTip toolTip1 = new ToolTip();

            // Set up the delays for the ToolTip.
            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 1000;
            toolTip1.ReshowDelay = 500;
            // Force the ToolTip text to be displayed whether or not the form is active.
            toolTip1.ShowAlways = true;

            // Set up the ToolTip text for the Button and Checkbox.
            toolTip1.SetToolTip(this.txtRuc, "F3 - Para Selecionar Proveedor");

            ENResultOperation R = ClsRecojo_CabeceraBC.Obtener_Registro(ID_Reco_Ide);
            DataTable dt = (DataTable)R.Valor;
            DataRow ROW = dt.Rows[0];
            ID_Veces = Convert.ToInt32(ROW["VECES"].ToString());
            lblTipoCombustible.Text = cTipoCombustible;

            if (Operacion_Combustible == "N")
            {
                txtIde_Detalle.Text = "0";
                txtProv_Ide.Text = "";
                txtProv_Nombre.Text = "";
                txtKmInicial.Text = "0";
                txtKmFinal.Text = "0";
                txtImporte.Text = "0";
                txtTotal.Text = "0";
                txtRendimiento.Text = Veh_Rendimiento;
                nRendimiento = Convert.ToDecimal(Veh_Rendimiento);
            }
            else
            {
                ENResultOperation C = ClsRecojo_Combustible_ImporteBC.Obtener_Registro(ID_Reco_Ide, ID_Reco_Ide_Detalle);
                DataTable dtc = (DataTable)C.Valor;
                if (dtc.Rows.Count != 0)
                {
                    DataRow ROWC = dtc.Rows[0];
                    txtIde_Detalle.Text = ROWC["RECO_IDE_DETALLE"].ToString();
                    txtProv_Ide.Text = ROWC["PROV_IDE"].ToString();
                    txtProv_Nombre.Text = ROWC["PROV_NOMBRE"].ToString();
                    
                    nKmInicial = Convert.ToInt32(ROWC["RECO_KILOMETRO_INICIAL"].ToString());
                    txtKmInicial.Text = nKmInicial.ToString();

                    nKmFinal = Convert.ToInt32(ROWC["RECO_KILOMETRO_FINAL"].ToString());
                    txtKmFinal.Text = nKmFinal.ToString();

                    nImporte = Convert.ToDecimal(ROWC["RECO_IMPORTE"].ToString());
                    txtImporte.Text = nImporte.ToString();

                    nRendimiento = Convert.ToDecimal(ROWC["RECO_RENDIMIENTO"].ToString());
                    txtRendimiento.Text = nRendimiento.ToString();

                    nRecorrido = nKmFinal - nKmInicial;
                    txtRecorrido.Text = nRecorrido.ToString("### ###,###");

                    if (nRendimiento > 0)
                    {
                        nFactor = nRecorrido / nRendimiento;
                    }
                    else
                    {
                        nFactor = 0;
                    }
                    txtFactor.Text = nFactor.ToString("###,###.000");
                    nTotal = nImporte * nFactor;
                    txtTotal.Text = nTotal.ToString("###,###.00");

                    if (Operacion_Combustible == "E")
                    {
                        txtIde_Detalle.Enabled = false;
                        txtProv_Ide.Enabled = false;
                        txtProv_Nombre.Enabled = false;
                        txtKmInicial.Enabled = false;
                        txtKmFinal.Enabled = false;
                        txtImporte.Enabled = false;
                        txtRendimiento.Enabled = false;
                        btnGrabar.Text = "Elimina";
                    }
                    if (Obtener_Proveedor()) txtKmInicial.Focus() ;

                }
            }
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            Procesar_Operacion();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Procesar_Operacion()
        {
            ClsRecojo_Combustible_ImporteBE TipoBE = new ClsRecojo_Combustible_ImporteBE();
            TipoBE.Reco_ide = ID_Reco_Ide;
            TipoBE.Reco_ide_detalle = ID_Reco_Ide_Detalle;
            TipoBE.Prov_ide = Convert.ToInt32(txtProv_Ide.Text);
            TipoBE.Reco_kilometro_inicial = Convert.ToInt32(txtKmInicial.Text);
            TipoBE.Reco_kilometro_final = Convert.ToInt32(txtKmFinal.Text);
            TipoBE.Reco_importe = Convert.ToDouble(txtImporte.Text);
            TipoBE.Reco_rendimiento = Convert.ToDouble(txtRendimiento.Text);
            TipoBE.Veces = ID_Veces;
            TipoBE.Usuario = "ADMIN";


            switch (Operacion_Combustible)
            {
                case "N":
                    ENResultOperation R = ClsRecojo_Combustible_ImporteBC.Crear(TipoBE);
                    break;
                case "M": ClsRecojo_Combustible_ImporteBC.Actualizar(TipoBE);
                    break;
                case "E": ClsRecojo_Combustible_ImporteBC.Eliminar(TipoBE);
                    break;
            }
            this.Close();
        }

        private void txtRuc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3)
            {
                Buscar_Proveedor();
            }
        }

        private void txtRuc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                if (Obtener_Proveedor_Ruc())
                {
                    Obtener_Importe_Combustible();
                    txtKmInicial.Focus();
                }
                else
                {
                    txtRuc.Focus();
                }
            }
        }

        private void txtRuc_DoubleClick(object sender, EventArgs e)
        {
            Buscar_Proveedor();
        }

        private void txtRuc_Validated(object sender, EventArgs e)
        {
        }

        private void txtProv_Ide_DoubleClick(object sender, EventArgs e)
        {
            Buscar_Proveedor();
        }

        private void txtProv_Ide_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3)
            {
                Buscar_Proveedor();
            }
        }

        private Boolean Obtener_Proveedor()
        {
            ENResultOperation R = ClsProveedorBC.Obtener_Registro(Convert.ToInt32(txtProv_Ide.Text));
            if (R.Proceder)
            {
                DataTable dt = (DataTable)R.Valor;
                if (dt.Rows.Count == 1)
                {
                    DataRow ROW = dt.Rows[0];
                    txtRuc.Text = ROW["PROV_RUC"].ToString();
                    txtProv_Nombre.Text = ROW["PROV_RAZON_SOCIAL"].ToString();
                    return true;
                }
            }
            return false;
        }

        private Boolean Obtener_Proveedor_Ruc()
        {
            ENResultOperation S = ClsProveedorBC.Obtener_Ruc(txtRuc.Text);
            if (S.Proceder)
            {
                DataTable dtr = (DataTable)S.Valor;
                if (dtr.Rows.Count == 1)
                {
                    DataRow RROW = dtr.Rows[0];
                    txtProv_Ide.Text = RROW["PROV_IDE"].ToString();
                    txtRuc.Text = RROW["PROV_RUC"].ToString();
                    txtProv_Nombre.Text = RROW["PROV_RAZON_SOCIAL"].ToString();
                    txtRuc.Focus();
                    return true;
                }
                else
                {
                    MessageBox.Show("No es Valido el RUC Ingresado","Proveedores");
                }
            }
            txtRuc.Focus();
            return false;
        }
        private void Buscar_Proveedor()
        {
            Proveedores.frmProveedorBuscar frmProveedor = new Proveedores.frmProveedorBuscar();
            frmProveedor.ShowDialog();

            if (!string.IsNullOrEmpty(frmProveedor.ProveedorID))
            {
                txtProv_Nombre.Text = frmProveedor.ProveedorRazon;
                txtProv_Ide.Text = frmProveedor.ProveedorID;
                txtRuc.Text = frmProveedor.ProveedorRuc;
                if (Obtener_Proveedor()) txtKmInicial.Focus();
            }
            txtRuc.Focus();
        }
        private void txtProv_Ide_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter) txtKmInicial.Focus();
        }

        private void txtKmInicial_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter) SendKeys.Send("{TAB}");
        }

        private void txtKmFinal_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void txtKmFinal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter) txtImporte.Focus();

        }

        private void txtRecorrido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter) SendKeys.Send("{TAB}");
        }

        private void txtImporte_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter) btnGrabar.Focus();
        }

        private void txtTotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter) SendKeys.Send("{TAB}");
        }

        private void txtRendimiento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter) SendKeys.Send("{TAB}");
        }

        private void txtKmInicial_Validated(object sender, EventArgs e)
        {
            nRecorrido = Convert.ToInt32(txtKmFinal.Text) - Convert.ToInt32(txtKmInicial.Text);
            if (nRendimiento > 0)
            {
                nFactor = nRecorrido / nRendimiento;
            }
            else
            {
                nFactor = 0;
            }
            txtRecorrido.Text = nRecorrido.ToString("### ###,###");
            txtFactor.Text = nFactor.ToString("###,###.000");
            nTotal = nImporte * nFactor;
            txtTotal.Text = nTotal.ToString("###,###.00");
        }

        private void txtKmFinal_Validated(object sender, EventArgs e)
        {
            nRecorrido = Convert.ToInt32(txtKmFinal.Text) - Convert.ToInt32(txtKmInicial.Text);
            if (nRendimiento > 0)
            {
                nFactor = nRecorrido / nRendimiento;
            }
            else
            {
                nFactor = 0;
            }
            txtRecorrido.Text = nRecorrido.ToString("### ###,###");
            nTotal = nFactor * nImporte;
            txtTotal.Text = nTotal.ToString("#####,###.00");
            txtFactor.Text = nFactor.ToString("###,###.000");
        }

        private void txtProv_Ide_Validated(object sender, EventArgs e)
        {

        }
        private void Obtener_Importe_Combustible()
        {
            ENResultOperation D = ClsCombustible_ImporteBC.Obtener_Registro(Convert.ToInt32(txtProv_Ide.Text),dFechaOrden,nTipoCombustible);
            if (D.Proceder)
            {
                DataTable dts = (DataTable)D.Valor;
                if (dts.Rows.Count == 1)
                {
                    DataRow DROW = dts.Rows[0];
                    nImporte = Convert.ToDecimal(DROW["GRIFO_IMPORTE"].ToString());
                    txtImporte.Text = nImporte.ToString("###,###.00");
                }
                else
                {
                    MessageBox.Show("No Hay Precio / Fecha del Combustible para Este Proveedor", "Proveedores de Combustible");
                }
            }
            else
            {
                MessageBox.Show("Se se ha encontrado Importe para este Proveedor", "Precio de Combustible");
            }
        }

        private void txtImporte_Validated(object sender, EventArgs e)
        {
            nRecorrido = Convert.ToInt32(txtKmFinal.Text) - Convert.ToInt32(txtKmInicial.Text);
            if (nRendimiento > 0)
            {
                nFactor = nRecorrido / nRendimiento;
            }
            else
            {
                nFactor = 0;
            }
            nImporte = Convert.ToDecimal(txtImporte.Text);
            nTotal = nFactor * nImporte;
            txtFactor.Text = nFactor.ToString("###,###.000");
            txtTotal.Text = nTotal.ToString("###,###.00");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmRecojo_Combustible_Importe_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }



  
    }
}
