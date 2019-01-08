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
    public partial class rptOrdenes_Cliente : Form
    {
        public DateTime fecha1 { get; set; }
        public DateTime fecha2 { get; set; }
        public DateTime fechatemp { get; set; }
        public string RangoFecha { get; set; }
        public string Titulo { get; set; }
        public string Empresa { get; set; }
        public Int32 Conductor { get; set; }
        private Int32 nClie_Ide;
        private Int32 nTran_Ide;
        public rptOrdenes_Cliente()
        {
            InitializeComponent();
        }

        private void Inicializa_Fechas()
        {
            fechatemp = DateTime.Today;
            fecha1 = new DateTime(fechatemp.Year, fechatemp.Month, 1);
            fecha2 = fecha1.AddMonths(1).AddDays(-1);
        }
        private void rptOrdenes_Cliente_Load(object sender, EventArgs e)
        {
            Inicializa_Fechas();
            dtpFecIni.Value = fecha1;
            dtpFecFin.Value = fecha2;
            nTran_Ide = 2564;
            Empresa = "TERAH S.A.C";
            Titulo = "REPORTE DE ORDENES POR REMITENTE";

            // Create the ToolTip and associate with the Form container.
            ToolTip toolTip1 = new ToolTip();

            // Set up the delays for the ToolTip.
            //toolTip1.AutoPopDelay = 5000;
            //toolTip1.InitialDelay = 1000;
            //toolTip1.ReshowDelay = 500;
            // Force the ToolTip text to be displayed whether or not the form is active.
            //toolTip1.ShowAlways = true;

            // Set up the ToolTip text for the Button and Checkbox.
            toolTip1.SetToolTip(this.txtRemitente, "(F3) Ayuda para Seleccionar Cliente");
            toolTip1.SetToolTip(this.dtpFecIni, "Fecha Inicial de las Ordenes");
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtClie_Ide.Text))
            {
                RangoFecha = "Del " + dtpFecIni.Text + " Al " + dtpFecFin.Text;
                this.WindowState = FormWindowState.Maximized;
                nClie_Ide = Convert.ToInt32(txtClie_Ide.Text);
                // TODO: esta línea de código carga datos en la tabla 'DataSetOrdenes_Cliente.V_RECOJO_CABECERA' Puede moverla o quitarla según sea necesario.
                this.V_RECOJO_CABECERATableAdapter.Fill(this.DataSetOrdenes_Cliente.V_RECOJO_CABECERA, dtpFecIni.Value, dtpFecFin.Value, nClie_Ide);

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

        private void Buscar_Cliente()
        {
            Clientes.frmClientesBuscar frmBuscarCliente = new Clientes.frmClientesBuscar();
            frmBuscarCliente.Cliente_Razon = txtRemitente.Text;
            frmBuscarCliente.ShowDialog();

            if (!string.IsNullOrEmpty(frmBuscarCliente.Cliente_Razon))
            {
                txtRemitente.Text = frmBuscarCliente.Cliente_Razon; 
                txtClie_Ide.Text = Convert.ToString(frmBuscarCliente.Clie_Ide);
                dtpFecIni.Focus();
            }
        }
        private void txtCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3)
            {
                Buscar_Cliente();
            }           
        }

        private void txtCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                if (string.IsNullOrEmpty(txtClie_Ide.Text)) Buscar_Cliente();
                dtpFecIni.Focus();
            }
        }

        private void dtpFecIni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter) dtpFecFin.Focus();
        }

        private void dtpFecFin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter) btnImprimir.Focus();
        }
    }
}
