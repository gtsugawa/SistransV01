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
    public partial class rptOrdenes_Estado : Form
    {
        public DateTime fecha1 { get; set; }
        public DateTime fecha2 { get; set; }
        public DateTime fechatemp { get; set; }
        public string RangoFecha { get; set; }
        public string Titulo { get; set; }
        public string Empresa { get; set; }
        public Int32 Conductor { get; set; }
        private Int32 nTran_Ide;
        private Int32 nEstado;
        public rptOrdenes_Estado()
        {
            InitializeComponent();
        }

        private void Inicializa_Fechas()
        {
            fechatemp = DateTime.Today;
            fecha1 = new DateTime(fechatemp.Year, fechatemp.Month, 1);
            fecha2 = fecha1.AddMonths(1).AddDays(-1);
        }
        private void Cargar_Estados()
        {
            cboEstados.Items.Clear();
            cboEstados.Items.Add("EN PROCESO DIGITACION");
            cboEstados.Items.Add("CERRADO PARA FACTURAR");
            cboEstados.SelectedIndex = 0;
        }
        private void rptOrdenes_Estado_Load(object sender, EventArgs e)
        {
            Cargar_Estados();
            Inicializa_Fechas();
            dtpFecIni.Value = fecha1;
            dtpFecFin.Value = fecha2;
            nTran_Ide = 2564;
            nEstado = 0;
            Empresa = "TERAH S.A.C";
            
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            nEstado = Convert.ToInt32(cboEstados.SelectedIndex.ToString());
            if (nEstado == 0)
            {
                Titulo = "REPORTE DE ORDENES EN PROCESO";
            }
            else
            {
                Titulo = "REPORTE DE ORDENES CERRADAS";
            }
            RangoFecha = "Del " + dtpFecIni.Text + " Al " + dtpFecFin.Text;
            this.WindowState = FormWindowState.Maximized;
            // TODO: esta línea de código carga datos en la tabla 'DataSetOrdenes_Estados.V_RECOJO_CABECERA' Puede moverla o quitarla según sea necesario.
            this.V_RECOJO_CABECERATableAdapter.Fill(this.DataSetOrdenes_Estados.V_RECOJO_CABECERA,dtpFecIni.Value,dtpFecFin.Value,nEstado);
            
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
