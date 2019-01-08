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
    public partial class rptMant_Correctivo : Form
    {
        public DateTime fecha1 { get; set; }
        public DateTime fecha2 { get; set; }
        public DateTime fechatemp { get; set; }
        public string RangoFecha { get; set; }
        public string Titulo { get; set; }
        public string Empresa { get; set; }
        public rptMant_Correctivo()
        {
            InitializeComponent();
        }
        private void Inicializa_Fechas()
        {

            fechatemp = DateTime.Today;
            fecha1 = new DateTime(fechatemp.Year, fechatemp.Month, 1);
            fecha2 = new DateTime(fechatemp.Year, fechatemp.Month + 1, 1).AddDays(-1);
        }
        private void rptMant_Correctivo_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSetMant_Correctivo.V_MANTENIMIENTO_CORRECTIVO' Puede moverla o quitarla según sea necesario.
            this.V_MANTENIMIENTO_CORRECTIVOTableAdapter.Fill(this.DataSetMant_Correctivo.V_MANTENIMIENTO_CORRECTIVO,fecha1,fecha2);


            ReportParameter[] parameters = new ReportParameter[3];
            parameters[0] = new ReportParameter("ParametroTitulo", Titulo);
            parameters[1] = new ReportParameter("ParametroEmpresa", Empresa);
            parameters[2] = new ReportParameter("RangoDeFechas", RangoFecha);

            //Enviemos la lista de parametros
            //
            reportViewer1.LocalReport.SetParameters(parameters);


            this.reportViewer1.RefreshReport();
        }
    }
}
