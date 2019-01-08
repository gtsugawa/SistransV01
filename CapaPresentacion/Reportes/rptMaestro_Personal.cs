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
    public partial class rptMaestro_Personal : Form
    {
        public string Titulo { get; set; }
        public string Empresa { get; set; }

        public rptMaestro_Personal()
        {
            InitializeComponent();
        }

        private void rptMaestro_Personal_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSetMaestro_Personal.V_MAESTRO_PERSONAL' Puede moverla o quitarla según sea necesario.
            this.V_MAESTRO_PERSONALTableAdapter.Fill(this.DataSetMaestro_Personal.V_MAESTRO_PERSONAL);

            ReportParameter[] parameters = new ReportParameter[2];
            parameters[0] = new ReportParameter("ParametroTitulo", Titulo);
            parameters[1] = new ReportParameter("ParametroEmpresa", Empresa);

            //Enviemos la lista de parametros
            //
            reportViewer1.LocalReport.SetParameters(parameters);

            this.reportViewer1.RefreshReport();
        }
    }
}
