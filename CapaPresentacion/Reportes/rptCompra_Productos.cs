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
    public partial class rptCompra_Productos : Form
    {
        public DateTime fecha1 { get; set; }
        public DateTime fecha2 { get; set; }
        public DateTime fechatemp { get; set; }
        public string RangoFecha { get; set; }
        public string Titulo { get; set; }
        public string Empresa { get; set; }
        public rptCompra_Productos()
        {
            InitializeComponent();
        }
        private void Inicializa_Fechas()
        {

            fechatemp = DateTime.Today;
            fecha1 = new DateTime(fechatemp.Year, fechatemp.Month, 1);
            fecha2 = fecha1.AddMonths(1).AddDays(-1);
        }
        private void rptCompra_Productos_Load(object sender, EventArgs e)
        {
            //Inicializa_Fechas();
            dtpFecIni.Value = fecha1;
            dtpFecFin.Value = fecha2;
            btnImprimir.PerformClick();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            RangoFecha = "Del " + dtpFecIni.Text + " Al " + dtpFecFin.Text;
            // TODO: esta línea de código carga datos en la tabla 'DataSetCompra_Productos.V_COMPRA_PRODUCTOS_CABECERA_DETALLE' Puede moverla o quitarla según sea necesario.
            this.V_COMPRA_PRODUCTOS_CABECERA_DETALLETableAdapter.Fill(this.DataSetCompra_Productos.V_COMPRA_PRODUCTOS_CABECERA_DETALLE,dtpFecIni.Value,dtpFecFin.Value);

            ReportParameter[] parameters = new ReportParameter[3];
            parameters[0] = new ReportParameter("ParametroEmpresa", Empresa);
            parameters[1] = new ReportParameter("ParametroTitulo", Titulo);
            parameters[2] = new ReportParameter("RangoDeFechas", RangoFecha);

            //Enviemos la lista de parametros
            //
            reportViewer1.LocalReport.SetParameters(parameters);

            this.reportViewer1.RefreshReport();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
