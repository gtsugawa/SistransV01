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
    public partial class rptOrdenes_Total_Conductor : Form
    {
        public DateTime fecha1 { get; set; }
        public DateTime fecha2 { get; set; }
        public DateTime fechatemp { get; set; }
        public string RangoFecha { get; set; }
        public string Titulo { get; set; }
        public string Empresa { get; set; }
        public Int32 Conductor { get; set; }
        public rptOrdenes_Total_Conductor()
        {
            InitializeComponent();
        }

        private void Inicializa_Fechas()
        {
            fechatemp = DateTime.Today;
            fecha1 = new DateTime(fechatemp.Year, fechatemp.Month, 1);
            fecha2 = fecha1.AddMonths(1).AddDays(-1);
        }
        private void rptOrdenes_Total_Conductor_Load(object sender, EventArgs e)
        {
            Inicializa_Fechas();
            dtpFecIni.Value = fecha1;
            dtpFecFin.Value = fecha2;
            Empresa = "TERAH S.A.C";
            Titulo = "REPORTE DE ORDENES DE RECOJO POR CONDUCTOR";
        }


        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            RangoFecha = "Del " + dtpFecIni.Text + " Al " + dtpFecFin.Text;
            this.WindowState = FormWindowState.Maximized;
            // TODO: esta línea de código carga datos en la tabla 'DataSetOrdenes_Total_Conductor.V_RECOJO_CABECERA' Puede moverla o quitarla según sea necesario.
            this.V_RECOJO_CABECERATableAdapter.Fill(this.DataSetOrdenes_Total_Conductor.V_RECOJO_CABECERA, dtpFecIni.Value, dtpFecFin.Value);

            ReportParameter[] parameters = new ReportParameter[3];
            parameters[0] = new ReportParameter("ParametroEmpresa", Empresa);
            parameters[1] = new ReportParameter("ParametroTitulo", Titulo);
            parameters[2] = new ReportParameter("RangoDeFechas", RangoFecha);

            //Enviemos la lista de parametros
            //
            reportViewer1.LocalReport.SetParameters(parameters);

            this.reportViewer1.RefreshReport();
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
    }
}
