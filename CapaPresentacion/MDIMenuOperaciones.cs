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

namespace CapaPresentacion
{
    public partial class MDIMenuOperaciones : Form
    {
        private int childFormNumber = 0;
        public string MNombre_Empresa = null;
        public string MUsuario = null;
        public string IPBasedeDatos;

        public MDIMenuOperaciones()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void fileMenu_Click(object sender, EventArgs e)
        {

        }

        private void ordenDeRecojoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOrdenRecojo frmOrden = new frmOrdenRecojo();
            frmOrden.MdiParent = this;
            frmOrden.Show();
        }

        private void zToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tablas.frmZona_Geografica frmgeo = new Tablas.frmZona_Geografica();
            frmgeo.MdiParent = this;
            frmgeo.Show();
        }

        private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Clientes.frmCliente frmCli = new Clientes.frmCliente();
            frmCli.MdiParent = this;
            frmCli.Show();
        }

        private void salirDelMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Empresa.frmAcceso frmlogin = new Empresa.frmAcceso();
            frmlogin.Nombre_Empresa = MNombre_Empresa;
            frmlogin.Show();
            this.Close();
            //Application.Exit();   
        }

        private void actividadesDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmActividad_Cliente frmAcCli = new frmActividad_Cliente();
            frmAcCli.MdiParent = this;
            frmAcCli.Show();
        }

        private void tiposDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clientes.frmTipo_Cliente frmTpCli = new Clientes.frmTipo_Cliente();
            frmTpCli.MdiParent = this;
            frmTpCli.Show();
        }

        private void categoriaDeClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clientes.frmCategoria_Cliente frmctcli = new Clientes.frmCategoria_Cliente();
            frmctcli.MdiParent = this;
            frmctcli.Show();
        }

        private void proveedoresToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Proveedores.frmProveedor frmprove = new Proveedores.frmProveedor();
            frmprove.MdiParent = this;
            frmprove.Show();
        }

        private void actividadesDeProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Proveedores.frmActividad_Proveedor frmacpro = new Proveedores.frmActividad_Proveedor();
            frmacpro.MdiParent = this;
            frmacpro.Show();
        }

        private void tiposDeProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Proveedores.frmTipo_Proveedor frmtppro = new Proveedores.frmTipo_Proveedor();
            frmtppro.MdiParent = this;
            frmtppro.Show();
        }

        private void categoriaDeProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Proveedores.frmCategoria_Proveedor frmctpro = new Proveedores.frmCategoria_Proveedor();
            frmctpro.MdiParent = this;
            frmctpro.Show();
        }

        private void transportistasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Transportista.frmTransportista frmtrans = new Transportista.frmTransportista();
            frmtrans.MdiParent = this;
            frmtrans.Show();
        }

        private void vendedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tablas.frmVendedor frmvend = new Tablas.frmVendedor();
            frmvend.MdiParent = this;
            frmvend.Show();
        }

        private void localidadesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Tablas.frmLocalidad frmlocal = new Tablas.frmLocalidad();
            frmlocal.MdiParent = this;
            frmlocal.Show();
        }

        private void paisesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tablas.frmPais frmpais = new Tablas.frmPais();
            frmpais.MdiParent = this;
            frmpais.Show();
        }

        private void marcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tablas.frmMarca_Vehiculo frmmarca = new Tablas.frmMarca_Vehiculo();
            frmmarca.MdiParent = this;
            frmmarca.Show();
        }

        private void tiposDeVehiculosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tablas.frmTipo_Vehiculo frmTpProd = new Tablas.frmTipo_Vehiculo();
            frmTpProd.MdiParent = this;
            frmTpProd.Show();
        }

        private void coloresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tablas.frmColor frmcolor = new Tablas.frmColor();
            frmcolor.MdiParent = this;
            frmcolor.Show();
        }

        private void tiposDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tablas.frmTipo_Producto frmtpproducto = new Tablas.frmTipo_Producto();
            frmtpproducto.MdiParent = this;
            frmtpproducto.Show();
        }

        private void conceptosDeFacturacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tablas.frmConcepto_Factura frmconfac = new Tablas.frmConcepto_Factura();
            frmconfac.MdiParent = this;
            frmconfac.Show();
        }

        private void gastosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tablas.frmGasto_Operacion frmgasto = new Tablas.frmGasto_Operacion();
            frmgasto.MdiParent = this;
            frmgasto.Show();
        }

        private void almacenesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tablas.frmAlmacen frmalma = new Tablas.frmAlmacen();
            frmalma.MdiParent = this;
            frmalma.Show();
        }

        private void unidadesDeMedidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tablas.frmUnidad_Medida frmundmed = new Tablas.frmUnidad_Medida();
            frmundmed.MdiParent = this;
            frmundmed.Show();
        }

        private void cargosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tablas.frmCargo frmcargo = new Tablas.frmCargo();
            frmcargo.MdiParent = this;
            frmcargo.Show();
        }

        private void tiposDeDocumentosDeIdentidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tablas.frmTipo_Documento_Identidad frmtipdocinden = new Tablas.frmTipo_Documento_Identidad();
            frmtipdocinden.MdiParent = this;
            frmtipdocinden.Show();
        }

        private void serieGuiasDeRemisionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tablas.frmSerie_Guia_Remision frmsergui = new Tablas.frmSerie_Guia_Remision();
            frmsergui.MdiParent = this;
            frmsergui.Show();
        }

        private void serieDeOrdenesDeRecojoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSerie_Orden_Recojo frmserord = new frmSerie_Orden_Recojo();
            frmserord.MdiParent = this;
            frmserord.Show();
        }

        private void serieDeFacturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tablas.frmSerie_Facturacion frmserfac = new Tablas.frmSerie_Facturacion();
            frmserfac.MdiParent = this;
            frmserfac.Show();
        }

        private void precioDeCombustibleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CapaPresentacion.Tablas.frmCombustible_Importe frmcombus = new CapaPresentacion.Tablas.frmCombustible_Importe();
            frmcombus.MdiParent = this;
            frmcombus.Show();
        }

  
        private void facturacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CapaPresentacion.Clientes.frmFactura frmfactura = new CapaPresentacion.Clientes.frmFactura();
            frmfactura.MdiParent = this;
            frmfactura.Show();
        }

        private void MDIMenuOperaciones_Load(object sender, EventArgs e)
        {
            IPBasedeDatos = CapaDA.StrConexion.strcn.Substring(12, 12);
            this.toolStripEmpresa.Text = MNombre_Empresa + "  IP: " + IPBasedeDatos;
            this.toolStripUsuario.Text = MUsuario;
            this.toolStripFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
            this.toolStripHora.Text = DateTime.Now.ToString("hh:mm:ss");
        }

        private void toolStripHora_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.toolStripHora.Text = DateTime.Now.ToString("hh:mm:ss");
        }

        private void combustibleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CapaPresentacion.Proveedores.frmCombustible_Compra frmCombustible_Compra = new Proveedores.frmCombustible_Compra();
            frmCombustible_Compra.MdiParent = this;
            frmCombustible_Compra.Show();

        }

        private void mantenimientoCorrectivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CapaPresentacion.Mantenimiento.Mantenimiemto_Correctivo frmCorrectivo = new Mantenimiento.Mantenimiemto_Correctivo();
            frmCorrectivo.MdiParent = this;
            frmCorrectivo.Show();
        }

        private void mantenimientoPreventivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CapaPresentacion.Mantenimiento.Mantenimiemto_Preventivo frmCorrectivo = new Mantenimiento.Mantenimiemto_Preventivo();
            frmCorrectivo.MdiParent = this;
            frmCorrectivo.Show();
        }

        private void actividadesPorGrupoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CapaPresentacion.Mantenimiento.frmMantenimiento_Grupo_Actividades frmGrupoActividad = new Mantenimiento.frmMantenimiento_Grupo_Actividades();
            frmGrupoActividad.MdiParent = this;
            frmGrupoActividad.Show();
        }

        private void GrupoMantenimientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CapaPresentacion.Mantenimiento.frmMantenimiento_Grupos frmGrupos = new Mantenimiento.frmMantenimiento_Grupos();
            frmGrupos.MdiParent = this;
            frmGrupos.Show();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            CapaPresentacion.Mantenimiento.frmMantenimiento_Programado frmProgramado = new Mantenimiento.frmMantenimiento_Programado();
            frmProgramado.MdiParent = this;
            frmProgramado.Show();
        }

        private void trabajadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CapaPresentacion.Transportista.frmTrabajador frmPersonal = new Transportista.frmTrabajador();
            frmPersonal.MdiParent = this;
            frmPersonal.Show();
        }

        private void comprasAProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mantenimiento.frmCompra_Lubricantes frmLubri = new Mantenimiento.frmCompra_Lubricantes();
            frmLubri.MdiParent = this;
            frmLubri.Show();
        }

        private void consumoDeLubricantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mantenimiento.frmConsumo_Lubricante frmConsumo = new Mantenimiento.frmConsumo_Lubricante();
            frmConsumo.MdiParent = this;
            frmConsumo.Show();
        }

        private void OrdenesDeRecojoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reportes.frmOrdenes_Reportes frmReportes = new Reportes.frmOrdenes_Reportes();
            frmReportes.MdiParent = this;
            frmReportes.Show();
        }

        private void productosParaMantenimientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mantenimiento.frmCompra_Productos frmProductos = new Mantenimiento.frmCompra_Productos();
            frmProductos.MdiParent = this;
            frmProductos.Show();
        }
    }
}
