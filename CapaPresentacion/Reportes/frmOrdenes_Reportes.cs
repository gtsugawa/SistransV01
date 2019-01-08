using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Reportes
{
    public partial class frmOrdenes_Reportes : Form
    {
        public frmOrdenes_Reportes()
        {
            InitializeComponent();
        }

        private void btnOrdConductor_Click(object sender, EventArgs e)
        {
            rptOrdenes_Conductor rptConductor = new rptOrdenes_Conductor();
            rptConductor.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOrdenesConductores_Click(object sender, EventArgs e)
        {
            rptOrdenes_Total_Conductor rptConductor = new rptOrdenes_Total_Conductor();
            rptConductor.ShowDialog();
        }

        private void btnOrdenesDigitacion_Click(object sender, EventArgs e)
        {
            rptOrdenes_Estado rptEstados = new rptOrdenes_Estado();
            rptEstados.ShowDialog();
        }

        private void btnOrdenesCliente_Click(object sender, EventArgs e)
        {
            rptOrdenes_Cliente rptClientes = new rptOrdenes_Cliente();
            rptClientes.ShowDialog();
        }

        private void btnOrdenesVehiculo_Click(object sender, EventArgs e)
        {
            rptOrdenes_Vehiculo rptVehiculo = new rptOrdenes_Vehiculo();
            rptVehiculo.ShowDialog();
        }
    }
}
