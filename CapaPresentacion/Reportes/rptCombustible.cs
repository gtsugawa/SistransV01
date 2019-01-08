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
    public partial class rptCombustible : Form
    {
        public DateTime fecha1 { get; set; }
        public DateTime fecha2 { get; set; }
        public string RangoFecha { get; set; }
        public string Titulo { get; set; }
        public string Empresa { get; set; }
        public rptCombustible()
        {
            InitializeComponent();
        }

        private void Inicializa_Fechas()
        {
            DateTime fecha1 = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            DateTime fecha2 = fecha1.AddMonths(1).AddTicks(-1);
        }
 
        private void rptCombustible_Load(object sender, EventArgs e)
        {
            //Inicializa_Fechas();
            // TODO: esta línea de código carga datos en la tabla 'DataSetCombustible.V_COMBUSTIBLE_COMPRA' Puede moverla o quitarla según sea necesario.
            this.v_COMBUSTIBLE_COMPRA1TableAdapter.Fill(this.DataSetCombustible.V_COMBUSTIBLE_COMPRA1,fecha1,fecha2);


            ReportParameter[] parameters = new ReportParameter[3];
            parameters[0] = new ReportParameter("ParametroTitulo",  Titulo);
            parameters[1] = new ReportParameter("ParametroEmpresa", Empresa);
            parameters[2] = new ReportParameter("RangoDeFechas", RangoFecha);

            //Enviemos la lista de parametros
            //
            reportViewer1.LocalReport.SetParameters(parameters);
            
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {

        }


  
    }
}
