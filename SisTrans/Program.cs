using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaPresentacion;

namespace SisTrans
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
           if (PrimeraInstancia)
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                //Application.Run(new CapaPresentacion.Mantenimiento.frmCompra_Productos());
                //Application.Run(new CapaPresentacion.Reportes.rptOrdenes_Vehiculo());
                //Application.Run(new CapaPresentacion.Mantenimiento.frmCompra_Lubricantes_Buscar());
                //Application.Run(new CapaPresentacion.Mantenimiento.frmConsumo_Lubricante());
                //Application.Run(new CapaPresentacion.Proveedores.frmProveedorBuscar());
                //Application.Run(new CapaPresentacion.Mantenimiento.frmCompra_Lubricantes());
                //Application.Run(new CapaPresentacion.Reportes.rptOrdenes_Cliente());
                //Application.Run(new CapaPresentacion.Reportes.rptOrdenes_Conductor());
                //Application.Run(new CapaPresentacion.Reportes.rptOrdenes_Total_Conductor());
                //Application.Run(new CapaPresentacion.frmOrdenRecojo());
                //Application.Run(new CapaPresentacion.Mantenimiento.Mantenimiemto_Correctivo());
                //Application.Run(new CapaPresentacion.Mantenimiento.Mantenimiemto_Preventivo());
               // Application.Run(new CapaPresentacion.Mantenimiento.frmMantenimiento_Programado());
                //Application.Run(new CapaPresentacion.Mantenimiento.frmMantenimiento_Grupo_Actividades());
               // Application.Run(new CapaPresentacion.Transportista.frmTrabajador());
                //Application.Run(new CapaPresentacion.Proveedores.frmCombustible_Compra());
                //Application.Run(new CapaPresentacion.Tablas.frmCodigo_Veh());
               //Application.Run(new MDIMenuOperaciones());
               Application.Run(new CapaPresentacion.Empresa.frmEmpresa());
                
            }
            else
            {
                MessageBox.Show("Ya se esta ejecutando la Sesion");
                Application.Exit();
            }
        }

        private static bool PrimeraInstancia
        {
            get
            {
                // Verificar si ya existe una Aplicacion
                System.Threading.Mutex exmut;
                string nombre_exmut = "ApWinForms";
                bool nueva;
                exmut = new System.Threading.Mutex(true, nombre_exmut, out nueva);
                return nueva;

            }

        }
    }
}
