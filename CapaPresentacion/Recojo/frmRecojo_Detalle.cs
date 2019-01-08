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

namespace CapaPresentacion.Recojo
{
    public partial class frmRecojo_Detalle : Form
    {
        public string Detalle_Operacion = "";
        public string Operacion_Recargo;
        public string Destinatario = "";
        public Int32 Unidad;
        public Int32 Producto;
        public Int32 ID_Reco_Ide = 0;
        public Int32 ID_Reco_Ide_Detalle = 0;
        public Int32 ID_Cliente = 0;
        public Int32 ID_Veces = 0;
        // delegado
        public delegate void Cuenta(Int32 nReco);
        // Evento
        public event Cuenta Contar;
        public frmRecojo_Detalle()
        {
            InitializeComponent();
        }

        private void btnCancelarDetalle_Click(object sender, EventArgs e)
        {
            Operacion_Recargo = "M";
            Habilitar_Botones(true);
            Habilitar_Campos(false);
            Cargar_Recojo_Detalle();
        }

        private void Habilitar_Botones(Boolean Flag)
        {
            btnNuevo.Enabled = Flag;
            btnModificar.Enabled = Flag;
            btnEliminar.Enabled = Flag;
            btnSalir.Enabled = Flag;
            btnGrabarDetalle.Enabled = !Flag;
            btnCancelarDetalle.Enabled = !Flag;
        }

        private void Obtener_Registro_Cabecera()
        {
            ENResultOperation R = ClsRecojo_CabeceraBC.Obtener_Registro(ID_Reco_Ide);
            DataTable dt = (DataTable)R.Valor;
            DataRow ROW = dt.Rows[0];
            ID_Veces = Convert.ToInt32(ROW["VECES"].ToString());
        }
        private void Cargar_Recojo_Detalle()
        {
            Cargar_Tipo_Producto();
            Cargar_Unidad_Medida();
            ENResultOperation R = ClsRecojo_DetalleBC.Listar_Filtro(ID_Reco_Ide, ID_Reco_Ide_Detalle);
            DataTable dt = (DataTable)R.Valor;
            txtItem.Text = "0";
            if (dt.Rows.Count != 0)
            {
                DataRow ROW = dt.Rows[0];
                ID_Cliente = Convert.ToInt32(ROW["CLIENTE_IDE"].ToString());
                txtItem.Text = ROW["RECO_ITEM"].ToString();
                txtDestinatario.Text = ROW["RECO_DESTINATARIO"].ToString();
                txtDireccion.Text = ROW["RECO_DIRECCION"].ToString();
                txtLoca_Ide.Text = ROW["LOCA_IDE"].ToString();
                txtLoca_Nombre.Text = ROW["LOCA_NOMBRE"].ToString();
                txtPais_Nombre.Text = ROW["PAIS_NOMBRE"].ToString();
                txtGuia_Remitente.Text = ROW["RECO_GUIA_PROVEEDOR"].ToString();
                txtPlanilla_Remitente.Text = ROW["RECO_PLANILLA"].ToString();
                txtBultos.Text = ROW["RECO_CANTIDAD"].ToString();
                txtPeso.Text = ROW["RECO_PESO"].ToString();
                txtVolumen.Text = ROW["RECO_VOLUMEN"].ToString();
                txtkmFinal.Text = ROW["RECO_KM_FINAL"].ToString();
                txtDescripcion.Text = ROW["RECO_DESCRIPCION"].ToString();
                txtNumero_Apoyo.Text = "0";

                cboTipoProducto.Text = ROW["TIPO_PROD_NOMBRE"].ToString();

                cboUnidad_Medida.Text = ROW["UNID_MEDI_NOMBRE"].ToString();


                dtpFllegada.Text = ROW["RECO_FECHA_LLEGADA"].ToString();
                dtpFInicio_Carga.Text = ROW["RECO_FECHA_INICIO_CARGA"].ToString();
                dtpFFin_Carga.Text = ROW["RECO_FECHA_FIN_CARGA"].ToString();
                dtpFInicio_Descarga.Text = ROW["RECO_FECHA_INICIO_DESCARGA"].ToString();
                dtpFFin_Descarga.Text = ROW["RECO_FECHA_FIN_DESCARGA"].ToString();
                dtpFTermino.Text = ROW["RECO_FECHA_RETIRO"].ToString();
                txtHLlegada.Text = ROW["RECO_HORA_LLEGADA"].ToString();
                txtHInicio_Carga.Text = ROW["RECO_HORA_INICIO_CARGA"].ToString();
                txtHFin_Carga.Text = ROW["RECO_HORA_FIN_CARGA"].ToString();
                txtHInicio_Descarga.Text = ROW["RECO_HORA_INICIO_DESCARGA"].ToString();
                txtHFin_Descarga.Text = ROW["RECO_HORA_FIN_DESCARGA"].ToString();
                txtHTermino.Text = ROW["RECO_HORA_RETIRO"].ToString();
            }
            txtItem.Focus();
        }

        private void frmRecojo_Detalle_Load(object sender, EventArgs e)
        {
            Cargar_Recojo_Detalle();
            Habilitar_Botones(false);
            if (Detalle_Operacion=="N")
            {
                Inicializa_Campos();
                txtDestinatario.Focus();
            }
            if (Detalle_Operacion == "E") btnGrabarDetalle.Text = "Eliminar";

            frmOrdenRecojo.miform.Contar += new frmRecojo_Detalle.Cuenta(Mostrar_Detalle);
        }

        private void Mostrar_Detalle(Int32 nReco)
        {
            Mostrar_Detalle(ID_Reco_Ide);
        }
        private void Habilitar_Campos(Boolean Flag)
        {
            txtItem.ReadOnly = !Flag;
            txtDestinatario.ReadOnly = !Flag;
            txtDestinatario.ReadOnly = !Flag;
            txtLoca_Ide.ReadOnly = !Flag;
            txtLoca_Nombre.ReadOnly = !Flag;
            txtPais_Nombre.ReadOnly = !Flag;
            txtGuia_Remitente.ReadOnly = !Flag;
            txtPlanilla_Remitente.ReadOnly = !Flag;
            txtBultos.ReadOnly = !Flag;
            txtPeso.ReadOnly = !Flag;
            txtVolumen.ReadOnly = !Flag;
            txtkmFinal.ReadOnly = !Flag;
            txtDescripcion.ReadOnly = !Flag;
            txtNumero_Apoyo.ReadOnly = !Flag;
            cboTipoProducto.Enabled = Flag;
            cboUnidad_Medida.Enabled = Flag;
            dtpFllegada.Enabled = Flag;
            dtpFInicio_Carga.Enabled = Flag;
            dtpFFin_Carga.Enabled = Flag;
            dtpFInicio_Descarga.Enabled = Flag;
            dtpFFin_Descarga.Enabled = Flag;
            dtpFTermino.Enabled = Flag;
            txtHLlegada.ReadOnly = !Flag;
            txtHInicio_Carga.ReadOnly = !Flag;
            txtHFin_Carga.ReadOnly = !Flag;
            txtHInicio_Descarga.ReadOnly = !Flag;
            txtHFin_Descarga.ReadOnly = !Flag;
            txtHTermino.ReadOnly = !Flag;

        }
        private void Inicializa_Campos()
        {
            txtItem.Text = "0";
            txtDestinatario.Text = Destinatario;
            txtDestinatario.Text = "";
            txtLoca_Ide.Text = String.Empty;
            txtLoca_Nombre.Text = String.Empty;
            txtPais_Nombre.Text = String.Empty;
            txtGuia_Remitente.Text = String.Empty;
            txtPlanilla_Remitente.Text = String.Empty;
            txtBultos.Text = String.Empty;
            txtPeso.Text = String.Empty;
            txtVolumen.Text = String.Empty;
            txtkmFinal.Text = String.Empty;
            txtDescripcion.Text = String.Empty;
            txtNumero_Apoyo.Text = String.Empty;
            //cboTipoProducto.Text = String.Empty;
            //cboUnidad_Medida.Text = String.Empty;
            dtpFllegada.Text = String.Empty;
            dtpFInicio_Carga.Text = String.Empty;
            dtpFFin_Carga.Text = String.Empty;
            dtpFInicio_Descarga.Text = String.Empty;
            dtpFFin_Descarga.Text = String.Empty;
            dtpFTermino.Text = String.Empty;
            txtHLlegada.Text = String.Empty;
            txtHInicio_Carga.Text = String.Empty;
            txtHFin_Carga.Text = String.Empty;
            txtHInicio_Descarga.Text = String.Empty;
            txtHFin_Descarga.Text = String.Empty;
            txtHTermino.Text = String.Empty;
        }

        private void Cargar_Tipo_Producto()
        {
            {
                DataTable TEMP = new DataTable();
                string nombre_error = "";
                ENResultOperation R = ClsTipo_ProductoBC.Listar(nombre_error);
                if (R.Proceder)
                {
                    TEMP = (DataTable)R.Valor;
                    this.cboTipoProducto.DataSource = TEMP;
                    this.cboTipoProducto.DisplayMember = Convert.ToString(TEMP.Columns["Tipo_Prod_Nombre"]);
                    this.cboTipoProducto.ValueMember = Convert.ToString(TEMP.Columns["Tipo_Prod_Ide"]);
                    this.cboTipoProducto.DropDownStyle = ComboBoxStyle.DropDownList;
                    this.cboTipoProducto.AutoCompleteSource = AutoCompleteSource.ListItems;
                    this.cboTipoProducto.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                    this.cboTipoProducto.SelectedValue = Producto;
                }
            }
        }

        private void Cargar_Unidad_Medida()
        {
            {
                DataTable TEMP = new DataTable();
                string nombre_error = "";
                ENResultOperation R = ClsUnidad_MedidaBC.Listar(nombre_error);
                if (R.Proceder)
                {
                    TEMP = (DataTable)R.Valor;
                    this.cboUnidad_Medida.DataSource = TEMP;
                    this.cboUnidad_Medida.DisplayMember = Convert.ToString(TEMP.Columns["Unid_Medi_Nombre"]);
                    this.cboUnidad_Medida.ValueMember = Convert.ToString(TEMP.Columns["Unid_Medi_Ide"]);
                    this.cboUnidad_Medida.DropDownStyle = ComboBoxStyle.DropDownList;
                    this.cboUnidad_Medida.SelectedValue = Unidad;
                    
                    
                    //this.cboUnidad_Medida.AutoCompleteMode = AutoCompleteMode.Suggest;
                    //this.cboUnidad_Medida.AutoCompleteSource = AutoCompleteSource.ListItems;
                }
            }
        }
        private void Procesar_Operacion()
        {
            Obtener_Registro_Cabecera();
            clsRecojo_DetalleBE TipoBE = new clsRecojo_DetalleBE();
            TipoBE.Reco_ide = ID_Reco_Ide;
            TipoBE.Reco_ide_detalle = ID_Reco_Ide_Detalle;
            TipoBE.Reco_item = Convert.ToInt32(txtItem.Text);
            TipoBE.Reco_cliente_ide = 0;   // ID_Cliente;
            TipoBE.Reco_destinatario = txtDestinatario.Text;
            TipoBE.Reco_direccion = txtDireccion.Text;
            if (string.IsNullOrEmpty(txtLoca_Ide.Text)) txtLoca_Ide.Text = "0";
            TipoBE.Loca_ide = Convert.ToInt32(txtLoca_Ide.Text);
            TipoBE.Reco_guia_proveedor = txtGuia_Remitente.Text;
            TipoBE.Reco_planilla = txtPlanilla_Remitente.Text;
            TipoBE.Reco_descripcion = txtDescripcion.Text;
            if (String.IsNullOrEmpty(txtBultos.Text)) txtBultos.Text = "0";
            TipoBE.Reco_cantidad = Convert.ToDouble(txtBultos.Text);
            if (String.IsNullOrEmpty(txtPeso.Text)) txtPeso.Text = "0";
            TipoBE.Reco_peso = Convert.ToDouble(txtPeso.Text);
            if (String.IsNullOrEmpty(txtVolumen.Text)) txtVolumen.Text = "0";
            TipoBE.Reco_volumen = Convert.ToDouble(txtVolumen.Text);
            if (String.IsNullOrEmpty(txtkmFinal.Text)) txtkmFinal.Text = "0";
            TipoBE.Reco_km_final = Convert.ToDouble(txtkmFinal.Text);
            TipoBE.Unid_medi_ide = Convert.ToInt32(cboUnidad_Medida.SelectedValue.ToString());
            TipoBE.Tipo_prod_ide = Convert.ToInt32(cboTipoProducto.SelectedValue.ToString());
            TipoBE.Reco_fecha_llegada = Convert.ToDateTime(dtpFllegada.Text);
            TipoBE.Reco_hora_llegada  = txtHLlegada.Text;
            TipoBE.Reco_fecha_inicio_carga = Convert.ToDateTime(dtpFInicio_Carga.Text);
            TipoBE.Reco_hora_inicio_carga = txtHInicio_Carga.Text;
            TipoBE.Reco_fecha_fin_carga = Convert.ToDateTime(dtpFFin_Carga.Text);
            TipoBE.Reco_hora_fin_carga = txtHFin_Carga.Text;
            TipoBE.Reco_fecha_inicio_descarga = Convert.ToDateTime(dtpFInicio_Descarga.Text);
            TipoBE.Reco_hora_inicio_descarga = txtHInicio_Descarga.Text;
            TipoBE.Reco_fecha_fin_descarga = Convert.ToDateTime(dtpFFin_Descarga.Text);
            TipoBE.Reco_hora_fin_descarga = txtHFin_Descarga.Text;
            TipoBE.Reco_fecha_retiro = Convert.ToDateTime(dtpFTermino.Text);
            TipoBE.Reco_hora_retiro = txtHTermino.Text;
            TipoBE.Reco_estado_ruta = true;
            TipoBE.Veces = ID_Veces;
            TipoBE.Usuario = "ADMIN";
            Producto = Convert.ToInt32(cboTipoProducto.SelectedValue.ToString());
            Unidad = Convert.ToInt32(cboUnidad_Medida.SelectedValue.ToString());
            Destinatario = txtDestinatario.Text;

            switch (Detalle_Operacion)
            {
                case "N":
                    ENResultOperation N = ClsRecojo_DetalleBC.Crear(TipoBE);
                    if (!N.Proceder) MessageBox.Show("Error : " + N.Sms);
                    break;
                case "M": 
                    ENResultOperation M = ClsRecojo_DetalleBC.Actualizar(TipoBE);
                    if (!M.Proceder) MessageBox.Show("Error : " + M.Sms);
                    break;
                case "E": 
                    ENResultOperation E = ClsRecojo_DetalleBC.Eliminar(TipoBE);
                    if (!E.Proceder) MessageBox.Show("Error : " + E.Sms);
                    break;
            }
            
        }
        private void dtpFllegada_ValueChanged(object sender, EventArgs e)
        {
            dtpFInicio_Carga.Text = dtpFllegada.Text;
            dtpFFin_Carga.Text = dtpFllegada.Text;
            dtpFInicio_Descarga.Text = dtpFllegada.Text;
            dtpFFin_Descarga.Text = dtpFllegada.Text;
            dtpFTermino.Text = dtpFllegada.Text;
        }

        private void btnGrabarDetalle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtLoca_Ide.Text))
            {
                MessageBox.Show("Localidad No Ingresada", "Validacion de Datos");
            }
            else
            {
                Procesar_Operacion();
                if (Detalle_Operacion == "N")
                {
                    Operacion_Recargo = "N";
                }
                else
                {
                    Operacion_Recargo = "M";
                }
               this.Close();
            }
            btnGrabarDetalle.Text = "Grabar";
        }

        private void txtDestinatario_DoubleClick(object sender, EventArgs e)
        {
            Buscar_Cliente();
        }

        private void Buscar_Cliente()
        {
            Clientes.frmClientesBuscar frmBuscarCliente = new Clientes.frmClientesBuscar();
            frmBuscarCliente.Cliente_Razon = txtDestinatario.Text;
            frmBuscarCliente.ShowDialog();
            if (!string.IsNullOrEmpty(frmBuscarCliente.Cliente_Razon))
            {
                txtDestinatario.Text = frmBuscarCliente.Cliente_Razon;
                txtDireccion.Text = frmBuscarCliente.Cliente_Direccion;
                txtLoca_Ide.Text = frmBuscarCliente.Cliente_localidad;
                Obtener_Descripcion_Localidad(txtLoca_Ide.Text);
                ID_Cliente = frmBuscarCliente.Clie_Ide;
                txtDireccion.Focus();
            }
        }

        private void Obtener_Descripcion_Localidad(string Localidad_ide)
        {
            if (!String.IsNullOrEmpty(Localidad_ide))
            {
                ENResultOperation R = ClsLocalidadBC.Listar_Filtro("", Convert.ToInt32(Localidad_ide));
                if (R.Proceder)
                {
                    DataTable dt = (DataTable)R.Valor;
                    DataRow ROW = dt.Rows[0];
                    txtLoca_Nombre.Text = ROW["LOCA_NOMBRE"].ToString();
                    string Pais_ide = ROW["PAIS_IDE"].ToString();
                    ENResultOperation L = ClsPaisBC.Listar_Filtro("", Convert.ToInt32(Pais_ide));
                    dt.Clear();
                    dt = (DataTable)L.Valor;
                    DataRow row = dt.Rows[0];
                    txtPais_Nombre.Text = row["PAIS_NOMBRE"].ToString();
                }
            }

        }

        private void txtDireccion_DoubleClick(object sender, EventArgs e)
        {
            Buscar_Punto_Llegada();
        }

        private void Buscar_Punto_Llegada()
        {
            Clientes.frmCliente_Lugar_Entrega frmLugarEntrega = new Clientes.frmCliente_Lugar_Entrega();
            frmLugarEntrega.Clie_Ide = ID_Cliente;
            frmLugarEntrega.Clie_Nombre = txtDestinatario.Text;
            frmLugarEntrega.ShowDialog();
            if (!String.IsNullOrEmpty(frmLugarEntrega.Direccion_Lugar_Entrega))
            {
                txtDireccion.Text = frmLugarEntrega.Direccion_Lugar_Entrega;
                txtLoca_Ide.Text = frmLugarEntrega.Loca_Ide;
                Obtener_Descripcion_Localidad(txtLoca_Ide.Text);
                cboTipoProducto.Focus();
            }
        }
        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDestinatario_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtLoca_Ide_TextChanged(object sender, EventArgs e)
        {
            Obtener_Descripcion_Localidad(txtLoca_Ide.Text);
        }

        private void txtLoca_Ide_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3) 
            {
                Busca_Localidad();
            }
        }
        private void txtLoca_Ide_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                cboTipoProducto.Focus();
            }
        }

        private void Busca_Localidad()
        {
            Tablas.frmBuscarLocalidad frmBuscarLoca = new Tablas.frmBuscarLocalidad();
            frmBuscarLoca.ShowDialog();
            if (!String.IsNullOrEmpty(frmBuscarLoca.Loca_Ide.ToString()))
            {
                txtLoca_Ide.Text = frmBuscarLoca.Loca_Ide.ToString();
            }
        }
        private void txtLoca_Ide_DoubleClick(object sender, EventArgs e)
        {
            Busca_Localidad();
        }

        private void txtDestinatario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3)
            {
                Buscar_Cliente();
            }
      
        }

        private void txtDestinatario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                if (!string.IsNullOrEmpty(txtDestinatario.Text))
                {
                    ENResultOperation R = ClsClientesBC.Listar_Nombre(txtDestinatario.Text);
                    if (R.Proceder)
                    {
                        DataTable dt = (DataTable)R.Valor;
                        if (dt.Rows.Count == 1)
                        {
                            DataRow ROW = dt.Rows[0];
                            txtDestinatario.Text = ROW["CLIE_RAZON_SOCIAL"].ToString();
                            txtDireccion.Text = ROW["CLIE_DIRECCION"].ToString();
                            txtLoca_Ide.Text = ROW["LOCA_IDE"].ToString();
                        }

                    }
                }
                txtDireccion.Focus();
            }
        }

        private void txtDestinatario_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDestinatario.Text))
            {

            }
        }

        private void txtDireccion_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3)
            {
                Buscar_Punto_Llegada();
            }
        }

        private void txtDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {

            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                txtLoca_Ide.Focus();
            }
        }

        private void txtGuia_Remitente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                txtPlanilla_Remitente.Focus();
            }
        }

        private void txtPlanilla_Remitente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                cboUnidad_Medida.Focus();
            }
        }

        private void cboTipoProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                txtGuia_Remitente.Focus();
            }
        }

        private void cboUnidad_Medida_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                txtBultos.Focus();
            }
        }

        private void txtBultos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                txtPeso.Focus();
            }
        }

        private void txtPeso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                txtVolumen.Focus();
            }
        }

        private void txtVolumen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                txtkmFinal.Focus();
            }
        }

        private void txtkmFinal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                txtDescripcion.Focus();
            }
        }

        private void txtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                dtpFllegada.Focus();
            }
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtpFllegada_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                dtpFInicio_Carga.Focus();
            }
        }

        private void dtpFInicio_Carga_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                dtpFFin_Carga.Focus();
            }

        }

        private void dtpFFin_Carga_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                dtpFInicio_Descarga.Focus();
            }

        }

        private void dtpFInicio_Descarga_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                dtpFFin_Descarga.Focus();
            }

        }

        private void dtpFFin_Descarga_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                dtpFTermino.Focus();
            }

        }

        private void dtpFTermino_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                txtNumero_Apoyo.Focus();
            }

        }

        private void txtNumero_Apoyo_KeyPress(object sender, KeyPressEventArgs e)
        {
             if ((int)e.KeyChar == (int)Keys.Enter)
            {
                btnGrabarDetalle.Focus();
            }
        }

        private void cboUnidad_Medida_Enter(object sender, EventArgs e)
        {
           
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Detalle_Operacion = "N";
            Habilitar_Botones(false);
            Habilitar_Campos(true);
            Inicializa_Campos();
            txtDestinatario.Focus();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Detalle_Operacion = "M";
            Habilitar_Botones(false);
            Habilitar_Campos(true);
            txtDestinatario.Focus();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Detalle_Operacion = "E";
            Habilitar_Botones(false);
            Habilitar_Campos(false);
            btnGrabarDetalle.Text = "Eliminar";
        }

        private void frmRecojo_Detalle_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }



    }
}
