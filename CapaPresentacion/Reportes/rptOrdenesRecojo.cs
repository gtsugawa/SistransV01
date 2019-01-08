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
    public partial class rptOrdenesRecojo : Form
    {
        public DateTime fecha1 { get; set; }
        public DateTime fecha2 { get; set; }
        public string RangoFecha { get; set; }
        public string Titulo { get; set; }
        public string Empresa { get; set; }
        public rptOrdenesRecojo()
        {
            InitializeComponent();
        }

        private void rptOrdenesRecojo_Load(object sender, EventArgs e)
        {
            dtpFecIni.Value = fecha1;
            dtpFecFin.Value = fecha2;
        }

        private void dtpFecIni_ValueChanged(object sender, EventArgs e)
        {
            if (dtpFecIni.Value <= dtpFecFin.Value)
            {
                btnImprimir.PerformClick();
            }
            else
            {
                MessageBox.Show("Fecha Inicial No Puede Ser Mayor a Fecha Final");
                dtpFecIni.Value = dtpFecFin.Value;
            }
        }

        private void dtpFecFin_ValueChanged(object sender, EventArgs e)
        {
            if (dtpFecFin.Value >= dtpFecIni.Value)
            {
                btnImprimir.PerformClick();
            }
            else
            {
                MessageBox.Show("Fecha Final No Puede Ser Menor a Fecha Inicial");
                dtpFecFin.Value = dtpFecIni.Value;
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            Titulo = "REPORTE DE ORDENES DE RECOJO " + "Del : " + dtpFecIni.Value.ToShortDateString() + " Al : " + dtpFecFin.Value.ToShortDateString();
            // TODO: esta línea de código carga datos en la tabla 'DataSetOrdenesRecojo.V_RECOJO_CABECERA' Puede moverla o quitarla según sea necesario.
            this.V_RECOJO_CABECERATableAdapter.Fill(this.DataSetOrdenesRecojo.V_RECOJO_CABECERA, dtpFecIni.Value, dtpFecFin.Value);

            ReportParameter[] parameters = new ReportParameter[2];
            parameters[0] = new ReportParameter("ParametroTitulo", Titulo);
            parameters[1] = new ReportParameter("ParametroEmpresa", Empresa);
            //parameters[2] = new ReportParameter("RangoDeFechas", RangoFecha);

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
