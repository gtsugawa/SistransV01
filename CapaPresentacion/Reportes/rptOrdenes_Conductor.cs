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
    public partial class rptOrdenes_Conductor : Form
    {
        public DateTime fecha1 { get; set; }
        public DateTime fecha2 { get; set; }
        public DateTime fechatemp { get; set; }
        public string RangoFecha;
        public string Titulo { get; set; }
        public string Empresa { get; set; }
        public Int32 Conductor { get; set; }
        private Int32 nTran_Ide;
        public rptOrdenes_Conductor()
        {
            InitializeComponent();
        }


        private void rptOrdenes_Conductor_Load(object sender, EventArgs e)
        {
            Inicializa_Fechas();
            dtpFecIni.Value = fecha1;
            dtpFecFin.Value = fecha2;
            nTran_Ide = 2564;
            Empresa = "TERAH S.A.C";
            Titulo = "REPORTE DE ORDENES DE RECOJO POR CONDUCTOR";

            // Create the ToolTip and associate with the Form container.
            ToolTip toolTip1 = new ToolTip();

            // Set up the delays for the ToolTip.
            //toolTip1.AutoPopDelay = 5000;
            //toolTip1.InitialDelay = 1000;
            //toolTip1.ReshowDelay = 500;
            // Force the ToolTip text to be displayed whether or not the form is active.
            //toolTip1.ShowAlways = true;

            // Set up the ToolTip text for the Button and Checkbox.
            toolTip1.SetToolTip(this.txtConductor, "(F3) Ayuda para Seleccionar Conductor");
            toolTip1.SetToolTip(this.dtpFecIni, "Fecha Inicial de las Ordenes");
        }
        private void Inicializa_Fechas()
        {
            fechatemp = DateTime.Today;
            fecha1 = new DateTime(fechatemp.Year, fechatemp.Month, 1);
            fecha2 = fecha1.AddMonths(1).AddDays(-1);
        }
        private void txtConductor_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtConductor.Text)) Buscar_Conductor();
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

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtChof_Ide.Text))
            {
                RangoFecha = "Del " + dtpFecIni.Text + " Al " + dtpFecFin.Text;
                this.WindowState = FormWindowState.Maximized;
                // TODO: esta línea de código carga datos en la tabla 'DataSetOrdenes_Conductor.V_RECOJO_CABECERA' Puede moverla o quitarla según sea necesario.
                this.V_RECOJO_CABECERATableAdapter.Fill(this.DataSetOrdenes_Conductor.V_RECOJO_CABECERA, dtpFecIni.Value, dtpFecFin.Value, Conductor);

                ReportParameter[] parameters = new ReportParameter[3];
                parameters[0] = new ReportParameter("ParametroEmpresa", Empresa);
                parameters[1] = new ReportParameter("ParametroTitulo", Titulo);
                parameters[2] = new ReportParameter("RangoDeFechas", RangoFecha);

                //Enviemos la lista de parametros
                //
                reportViewer1.LocalReport.SetParameters(parameters);

                this.reportViewer1.RefreshReport();
            }
            else
            {
                MessageBox.Show("Debe primero Seleccionar un Conductor (F3) Ayuda","Mensaje del Sistema");
            }
        }

        private void txtConductor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3)
            {
                Buscar_Conductor();
            }           
        }

        private void Buscar_Conductor()
        {
            ENResultOperation R = ClsTransportista_ChoferBC.Listar_Filtro(txtConductor.Text, nTran_Ide);
            if (R.Proceder)
            {
                DataTable dt = (DataTable)R.Valor;
                if (dt.Rows.Count == 1)
                {
                    DataRow ROW = dt.Rows[0];
                    txtConductor.Text = ROW["TRAN_CHOF_NOMBRE"].ToString();
                    txtChof_Ide.Text = ROW["TRAN_CHOF_IDE"].ToString();
                    Conductor = Convert.ToInt32(txtChof_Ide.Text);
                }
                else
                {
                    Transportista.frmTransportista_Chofer_Buscar frmChoferes_Buscar = new Transportista.frmTransportista_Chofer_Buscar();
                    frmChoferes_Buscar.Transportista_Ide = 2564;
                    frmChoferes_Buscar.Transportista_Nombre = "TERAH S.A.C";
                    frmChoferes_Buscar.Chofer_Nombre = txtConductor.Text;
                    frmChoferes_Buscar.ShowDialog();
                    txtChof_Ide.Text = frmChoferes_Buscar.Chofer_Ide;
                    Conductor = Convert.ToInt32(frmChoferes_Buscar.Chofer_Ide);
                    txtConductor.Text = frmChoferes_Buscar.Chofer_Nombre;
                }
            }

        }

        private void txtConductor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                if (string.IsNullOrEmpty(txtChof_Ide.Text)) Buscar_Conductor();
                dtpFecIni.Focus();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
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
