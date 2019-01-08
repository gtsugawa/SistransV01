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
using Microsoft.Reporting.WinForms;


namespace CapaPresentacion.Reportes
{
    public partial class rptOrdenes_Vehiculo : Form
    {
        public DateTime fecha1 { get; set; }
        public DateTime fecha2 { get; set; }
        public DateTime fechatemp { get; set; }
        public string RangoFecha { get; set; }
        public string Titulo { get; set; }
        public string Empresa { get; set; }
        public Int32 Vehiculo { get; set; }
        public Int32 nTran_Ide;
        private Int32 nVehi_Ide;
        public rptOrdenes_Vehiculo()
        {
            InitializeComponent();
        }
        private void rptOrdenes_Vehiculo_Load(object sender, EventArgs e)
        {
            Inicializa_Fechas();
            dtpFecIni.Value = fecha1;
            dtpFecFin.Value = fecha2;
            nTran_Ide = 2564;
            Empresa = "TERAH S.A.C";
            Titulo = "REPORTE DE ORDENES DE RECOJO POR VEHICULO";

            ToolTip toolTip1 = new ToolTip();
            toolTip1.SetToolTip(this.txtVehiculo, "(F3) Ayuda para Seleccionar Vehiculo");
            txtVehiculo.Focus();
        }
        private void Inicializa_Fechas()
        {
            fechatemp = DateTime.Today;
            fecha1 = new DateTime(fechatemp.Year, fechatemp.Month, 1);
            fecha2 = fecha1.AddMonths(1).AddDays(-1);
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtVehi_Ide.Text))
            {
                RangoFecha = "Del " + dtpFecIni.Text + " Al " + dtpFecFin.Text;
                this.WindowState = FormWindowState.Maximized;
                nVehi_Ide = Convert.ToInt32(txtVehi_Ide.Text);
                // TODO: esta línea de código carga datos en la tabla 'DataSetOrdenes_Vehiculo.V_RECOJO_CABECERA' Puede moverla o quitarla según sea necesario.
                this.V_RECOJO_CABECERATableAdapter.Fill(this.DataSetOrdenes_Vehiculo.V_RECOJO_CABECERA, nVehi_Ide, dtpFecIni.Value, dtpFecFin.Value);

                ReportParameter[] parameters = new ReportParameter[3];
                parameters[0] = new ReportParameter("ParametroEmpresa", Empresa);
                parameters[1] = new ReportParameter("ParametroTitulo", Titulo);
                parameters[2] = new ReportParameter("RangoDeFechas", RangoFecha);

                //Enviemos la lista de parametros
                //
                reportViewer1.LocalReport.SetParameters(parameters);
                this.reportViewer1.RefreshReport();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtpFecIni_ValueChanged(object sender, EventArgs e)
        {
            if (dtpFecIni.Value > dtpFecFin.Value)
            {
                MessageBox.Show("Fecha Inicial No Puede Ser Mayor a Fecha Final");
                dtpFecIni.Value = dtpFecFin.Value;
            }
        }

        private void dtpFecFin_ValueChanged(object sender, EventArgs e)
        {
            if (dtpFecFin.Value < dtpFecIni.Value)
            {
                MessageBox.Show("Fecha Final No Puede Ser Menor a Fecha Inicial");
                dtpFecFin.Value = dtpFecIni.Value;
            }
        }

        private void txtVehiculo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3)
            {
                Buscar_Vehiculo();
            }           
        }

        private void txtVehiculo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                if (string.IsNullOrEmpty(txtVehiculo.Text))
                {
                    Buscar_Vehiculo();
                    dtpFecIni.Focus();
                }
                if (Validar_Vehiculo()) dtpFecIni.Focus();
            }
        }

        private void Buscar_Vehiculo()
        {
            Transportista.frmTransportista_Vehiculo_Buscar frmVehiculo_Buscar = new Transportista.frmTransportista_Vehiculo_Buscar();
            frmVehiculo_Buscar.Transportista_Ide = nTran_Ide;
            frmVehiculo_Buscar.Transportista_Nombre = Empresa;
            frmVehiculo_Buscar.ShowDialog();
            txtVehiculo.Text = frmVehiculo_Buscar.Vehiculo_Placa;
            txtVehi_Ide.Text = frmVehiculo_Buscar.Vehiculo_Ide;
        }

        private void dtpFecIni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter) SendKeys.Send("{TAB}");
        }

        private void dtpFecFin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter) SendKeys.Send("{TAB}");
        }

        private void txtVehiculo_Validated(object sender, EventArgs e)
        {
            if (Validar_Vehiculo()) dtpFecIni.Focus();
        }

        private Boolean Validar_Vehiculo()
        {
            ENResultOperation R = ClsTransportista_VehiculoBC.Listar_Filtro(txtVehiculo.Text, nTran_Ide);
            if (R.Proceder)
            {
                DataTable dt = (DataTable)R.Valor;
                if (dt.Rows.Count == 1)
                {
                    DataRow ROW = dt.Rows[0];
                    txtVehiculo.Text = ROW["TRAN_VEHI_PLACA"].ToString();
                    txtNombre.Text = ROW["TRAN_VEHI_NOMBRE"].ToString();
                    txtVehi_Ide.Text = ROW["TRAN_VEHI_IDE"].ToString();
                    return true;
                }
            }
            return false;
        }
    }
}
