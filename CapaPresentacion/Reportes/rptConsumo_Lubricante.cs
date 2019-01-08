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
    public partial class rptConsumo_Lubricante : Form
    {
        public DateTime fecha1 { get; set; }
        public DateTime fecha2 { get; set; }
        public string RangoFecha { get; set; }
        public string Titulo { get; set; }
        public string Empresa { get; set; }
        public rptConsumo_Lubricante()
        {
            InitializeComponent();
        }

        private void rptConsumo_Lubricante_Load(object sender, EventArgs e)
        {
            //Inicializa_Fechas();
            dtpFecIni.Value = fecha1;
            dtpFecFin.Value = fecha2;
            btnImprimir.PerformClick();
        }

        private void Inicializa_Fechas()
        {
            DateTime fecha1 = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            DateTime fecha2 = fecha1.AddMonths(1).AddTicks(-1);
        }
        private void btnImprimir_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            // TODO: esta línea de código carga datos en la tabla 'DataSetConsumo_Lubricantes.V_CONSUMO_LUBRICANTE' Puede moverla o quitarla según sea necesario.
            this.V_CONSUMO_LUBRICANTETableAdapter.Fill(this.DataSetConsumo_Lubricantes.V_CONSUMO_LUBRICANTE, dtpFecIni.Value, dtpFecFin.Value);
            
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
