using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaBE;
using CapaBC;
using System.Configuration;
using System.Data.SqlClient;

namespace CapaPresentacion
{
    public partial class frmClientes : Form
    {
        
        private Char Operacion = ' ';
        private int veces = 0;
        private SqlConnection Con = null;
        private SqlCommand Cmd;
        private SqlDataReader dr = null;
        private Boolean IsPrimeraCarga = true;
        string strcon = ConfigurationManager.ConnectionStrings["conex1"].ConnectionString;

        private static frmClientes frmInstance = null;

        public static frmClientes fInstance()
        {
            if (((frmInstance == null) || (frmInstance.IsDisposed == true)))
            {
                frmInstance = new frmClientes();
            }

            frmInstance.BringToFront();
            frmInstance.WindowState = FormWindowState.Normal;
            return frmInstance;
        }

        public frmClientes()
        {
            InitializeComponent();
          
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            inicializa_Botones();
            posicionar_Ultimo_registro();
            carga_Tabla_Localidad();
            carga_Tabla_Actividad();
            carga_Tabla_Categoria();
            carga_Tabla_TipoCliente();

            carga_Localidad(txtLoca_Ide.Text);
            carga_Actividad(txtActi_Ide.Text);
            carga_Categoria(txtCate_Ide.Text);
            carga_TipoCliente(txtTipo_Ide.Text);
            ReadOnly_Campos(true);
            IsPrimeraCarga = false;
        }
        private void ReadOnly_Campos(bool opcion)
        {
            txtID.ReadOnly = opcion;
            txtCodigo.ReadOnly = opcion;
            txtRazon_Social.ReadOnly = opcion;
            txtPaterno.ReadOnly = opcion;
            txtMaterno.ReadOnly = opcion;
            txtNombre.ReadOnly = opcion;
            txtFax.ReadOnly = opcion;
            txtCorreo.ReadOnly = opcion;
            txtDireccion.ReadOnly = opcion;
            txtEstado.ReadOnly = true;
            
            txtEmpresa.ReadOnly = opcion;
            txtTelefono1.ReadOnly = opcion;
            txtTelefono2.ReadOnly = opcion;
            txtTipo_Ide.ReadOnly = opcion;
            dpkFechaConstitucion.Enabled = !opcion;
            txtRuc.ReadOnly = opcion;
            cboEmpresa.Enabled = !opcion;
            cboLocalidad.Enabled = !opcion;
            cboActividad.Enabled = !opcion;
            cboCategoria.Enabled = !opcion;
            cboTipoCliente.Enabled = !opcion;
            cboEstado.Enabled = !opcion;

        }
        private void inicializa_Botones()
        {
            btnNuevo.Enabled = true;
            btnGrabar.Enabled = false;
            btnCancelar.Enabled = false;
            btnEditar.Enabled = true;
            btnInactivar.Enabled = true;
            btnImprimir.Enabled = true;
            btnSalir.Enabled = true;
            btnBuscar.Enabled = true;
            cboLocalidad.Enabled = false;
            cboActividad.Enabled = false;
            cboCategoria.Enabled = false;
            cboTipoCliente.Enabled = false;
          
        }
        private void desactivar_Botones_edicion()
        {
            btnNuevo.Enabled = false;
            btnGrabar.Enabled = true;
            btnCancelar.Enabled = true;
            btnEditar.Enabled = false;
            btnInactivar.Enabled = false;
            btnImprimir.Enabled = false;
            btnSalir.Enabled = false;
            btnBuscar.Enabled = false;
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Clientes.frmClientesBuscar frmClieBuscar = new Clientes.frmClientesBuscar();
            DialogResult res = frmClieBuscar.ShowDialog();
            if (frmClieBuscar.ClienteID != null)
            { 
            txtCodigo.Text =  frmClieBuscar.ClienteID.ToString();
            LeerCliente(txtCodigo.Text.Trim());
            //carga_Tabla_Localidad();
            //carga_Tabla_Actividad();
            //carga_Tabla_Categoria();
            //carga_Tabla_TipoCliente();
            carga_Localidad(txtLoca_Ide.Text);
            carga_Actividad(txtActi_Ide.Text);
            carga_Categoria(txtCate_Ide.Text);
            carga_TipoCliente(txtTipo_Ide.Text);
            ReadOnly_Campos(true); 
            }
            frmClieBuscar.Dispose();
        }
       
        private void LeerCliente(string codigo)
        {
            Limpiar_Campos();
            Con = new SqlConnection(strcon);
            string Consulta = "Select * from Cliente where Clie_Codigo = @codigo";
            Cmd = new SqlCommand(Consulta, Con);
            Cmd.Parameters.AddWithValue("@codigo", codigo);
            Con.Open();
            dr = Cmd.ExecuteReader();
            while (dr.Read())
            {
                txtCodigo.Text = dr["Clie_Codigo"].ToString();
                txtRazon_Social.Text = dr["Clie_Razon_Social"].ToString();
                txtID.Text = dr["Clie_Ide"].ToString();
                txtPaterno.Text = dr["Clie_Paterno"].ToString();
                txtMaterno.Text = dr["Clie_Materno"].ToString();
                txtNombre.Text = dr["Clie_Nombre"].ToString();
                txtFax.Text = dr["Clie_Fax"].ToString();
                txtCorreo.Text = dr["Clie_Correo"].ToString();
                txtDireccion.Text = dr["Clie_Direccion"].ToString();
                txtEstado.Text = dr["Clie_Estado"].ToString();
                cboEstado.Text = dr["Clie_Estado"].ToString();
                txtEmpresa.Text = dr["Clie_Empresa"].ToString();
                txtCate_Ide.Text = dr["Cate_Clie_Ide"].ToString();
                txtActi_Ide.Text = dr["Acti_Clie_Ide"].ToString();
                txtLoca_Ide.Text = dr["Loca_Ide"].ToString();
                txtTelefono1.Text = dr["Clie_Telefono1"].ToString();
                txtTelefono2.Text = dr["Clie_Telefono2"].ToString();
                txtTipo_Ide.Text = dr["Tipo_Clie_Ide"].ToString();
                dpkFechaConstitucion.Text = dr["clie_fecha_Constitucion"].ToString();
                txtRuc.Text = dr["clie_Ruc"].ToString();
            }
            dr.Close();
        }

        private void Limpiar_Campos()
        {
            txtID.Text = "0";
            txtEstado.Text = "Activo";
            txtCodigo.Text = "";
            txtRazon_Social.Text = "";
            txtPaterno.Text = "";
            txtMaterno.Text = "";
            txtNombre.Text = "";
            txtFax.Text = "";
            txtCorreo.Text = "";
            txtDireccion.Text = "";
            txtEstado.Text = "";
            txtEmpresa.Text = "Si";
            txtCate_Ide.Text = "0";
            txtActi_Ide.Text = "0";
            txtLoca_Ide.Text = "0";
            txtTelefono1.Text = "";
            txtTelefono2.Text = "";
            txtTipo_Ide.Text = "0";
            dpkFechaConstitucion.Text = "";
            txtRuc.Text = "";
            cboEstado.Text = "Activo";
            cboLocalidad.Text = "";
            cboActividad.Text = "";
            cboCategoria.Text = "";
            cboTipoCliente.Text = "";
            cboEmpresa.Text = "Si";
            cboLocalidad.Enabled = true;
            cboActividad.Enabled = true;
            cboCategoria.Enabled = true;
            cboTipoCliente.Enabled = true;
            cboEstado.Enabled = true;
            
        }

        private void posicionar_Ultimo_registro()
        {
            try
            {
                Con = new SqlConnection(strcon);

                string cadena = "Select TOP 1 * from Cliente ORDER BY Clie_Ide DESC";
                Cmd = new SqlCommand(cadena, Con);
                Con.Open();
                dr = Cmd.ExecuteReader();


                int drfilas = 0;

                while (dr.Read())
                {
                    drfilas = drfilas + 1;

                    txtCodigo.Text = dr["Clie_Codigo"].ToString();
                    txtRazon_Social.Text = dr["Clie_Razon_Social"].ToString();
                    txtID.Text = dr["Clie_Ide"].ToString();
                    txtPaterno.Text = dr["Clie_Paterno"].ToString();
                    txtMaterno.Text = dr["Clie_Materno"].ToString();
                    txtNombre.Text = dr["Clie_Nombre"].ToString();
                    txtFax.Text = dr["Clie_Fax"].ToString();
                    txtCorreo.Text = dr["Clie_Correo"].ToString();
                    txtDireccion.Text = dr["Clie_Direccion"].ToString();
                    txtEstado.Text = dr["Clie_Estado"].ToString();
                    cboEstado.Text = dr["Clie_Estado"].ToString();
                    txtEmpresa.Text = dr["Clie_Empresa"].ToString();
                    txtCate_Ide.Text = dr["Cate_Clie_Ide"].ToString();
                    txtActi_Ide.Text = dr["Acti_Clie_Ide"].ToString();
                    txtLoca_Ide.Text = dr["Loca_Ide"].ToString();
                    txtTelefono1.Text = dr["Clie_Telefono1"].ToString();
                    txtTelefono2.Text = dr["Clie_Telefono2"].ToString();
                    txtTipo_Ide.Text = dr["Tipo_Clie_Ide"].ToString();
                    dpkFechaConstitucion.Text = dr["clie_fecha_Constitucion"].ToString();
                    txtRuc.Text = dr["clie_Ruc"].ToString();

                }
                if (drfilas != 1)
                {
                    Limpiar_Campos();
                }

            }
            catch (Exception ex)
            {
                //MessageBox.Show("Error de Conexion a BD " + ex);
            }
            finally
            {
                dr.Close();
                Con.Close();

            }
        }
        private void carga_Tabla_Localidad()
        {
            try
            {
                Con = new SqlConnection(strcon);
                if (cboActividad.Items.Count > 0) cboActividad.Items.RemoveAt(0);
                string cadena = "Select loca_Ide,loca_Nombre from Localidad where Loca_Estado = 'Activo' Order By Loca_Nombre";
                Cmd = new SqlCommand(cadena, Con);
                Con.Open();
                dr = Cmd.ExecuteReader();
                while (dr.Read())
                {
                    cboLocalidad.Items.Add(dr["loca_Nombre"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tabla de Localidad - Error " + ex);
            }
            finally
            {
                dr.Close();
                Con.Close();
            }
        }
        private void carga_Localidad(string localidad)
        {
            try
            {
                Con = new SqlConnection(strcon);

                string cadena = "Select loca_Nombre from Localidad where loca_Ide = " + localidad;
                Cmd = new SqlCommand(cadena, Con);
                Con.Open();
                dr = Cmd.ExecuteReader();
                while (dr.Read())
                {
                    cboLocalidad.Text = dr["loca_Nombre"].ToString();
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Tabla de Localidad - Error " + ex);
            }
            finally
            {
                dr.Close();
                Con.Close();
            }
        }

        private void carga_Localidad_Ide(string localidad)
        {
            try
            {
                Con = new SqlConnection(strcon);

                string cadena = "Select loca_Ide from Localidad where loca_Nombre = '" + localidad + "'";
                Cmd = new SqlCommand(cadena, Con);
                Con.Open();
                dr = Cmd.ExecuteReader();
                while (dr.Read())
                {

                     txtLoca_Ide.Text = dr["loca_Ide"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tabla de Localidad - Error " + ex);
            }
            finally
            {
                dr.Close();
                Con.Close();
            }
        }
        private void carga_Actividad(string actividad)
        {
            try
            {
                Con = new SqlConnection(strcon);

                string cadena = "Select Acti_Clie_Nombre from Actividad_Cliente where Acti_Clie_Ide = " + actividad;
                Cmd = new SqlCommand(cadena, Con);
                Con.Open();
                dr = Cmd.ExecuteReader();
                while (dr.Read())
                {

                    cboActividad.Text = dr["Acti_Clie_Nombre"].ToString();
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Tabla de Actividades Cliente - Error " + ex);
            }
            finally
            {
                dr.Close();
                Con.Close();
            }
        }
        private void carga_Tabla_Actividad()
        {
            try
            {
                Con = new SqlConnection(strcon);
                if (cboActividad.Items.Count > 0) cboActividad.Items.RemoveAt(0);
                string cadena = "Select Acti_Clie_Nombre from Actividad_Cliente where Acti_Clie_Estado = 'Activo' ";
                Cmd = new SqlCommand(cadena, Con);
                Con.Open();
                dr = Cmd.ExecuteReader();
                while (dr.Read())
                {
                    cboActividad.Items.Add(dr["Acti_Clie_Nombre"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tabla de Actividades Cliente - Error " + ex);
            }
            finally
            {
                dr.Close();
                Con.Close();
            }
        }

        private void carga_Tabla_Actividad_Ide(string Actividad)
        {
            try
            {
                Con = new SqlConnection(strcon);

                string cadena = "Select Acti_Clie_Ide from Actividad_Cliente where Acti_Clie_Nombre = '" + Actividad + "'";
                Cmd = new SqlCommand(cadena, Con);
                Con.Open();
                dr = Cmd.ExecuteReader();
                while (dr.Read())
                {
                    txtActi_Ide.Text = dr["Acti_Clie_Ide"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tabla de Actividades Cliente - Error " + ex);
            }
            finally
            {
                dr.Close();
                Con.Close();
            }
        }
        private void carga_Tabla_Categoria()
        {
            try
            {
                Con = new SqlConnection(strcon);
                if (cboCategoria.Items.Count > 0 ) cboCategoria.Items.RemoveAt(0);
                string cadena = "Select Cate_Clie_Nombre from Categoria_Cliente where Cate_Clie_Estado = 'Activo' ";
                Cmd = new SqlCommand(cadena, Con);
                Con.Open();
                dr = Cmd.ExecuteReader();
                while (dr.Read())
                {
                    cboCategoria.Items.Add(dr["Cate_Clie_Nombre"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tabla de Categoria Cliente - Error " + ex);
            }
            finally
            {
                dr.Close();
                Con.Close();
            }
        }

        private void carga_Categoria(string Categoria)
        {
            try
            {
                Con = new SqlConnection(strcon);
                string cadena = "Select Cate_Clie_Nombre from Categoria_Cliente where Cate_Clie_Ide = " + Categoria;
                Cmd = new SqlCommand(cadena, Con);
                Con.Open();
                dr = Cmd.ExecuteReader();
                while (dr.Read())
                {
                    cboCategoria.Text = dr["Cate_Clie_Nombre"].ToString();
                }
            }
            catch (Exception ex)
            {
               // MessageBox.Show("Tabla de Categoria Cliente - Error " + ex);
            }
            finally
            {
                dr.Close();
                Con.Close();
            }
        }

        private void carga_Categoria_Ide(string Categoria)
        {
            try
            {
                Con = new SqlConnection(strcon);

                string cadena = "Select Cate_Clie_Ide from Categoria_Cliente where Cate_Clie_Nombre = '" + Categoria + "'";
                Cmd = new SqlCommand(cadena, Con);
                Con.Open();
                dr = Cmd.ExecuteReader();
                while (dr.Read())
                {

                    txtCate_Ide.Text = dr["Cate_Clie_Ide"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tabla de Categoria Cliente - Error " + ex);
            }
            finally
            {
                dr.Close();
                Con.Close();
            }
        }

      
        private void carga_TipoCliente(string TipoCliente)
        {
            try
            {
                Con = new SqlConnection(strcon);

                string cadena = "Select Tipo_Clie_Nombre from Tipo_Cliente where Tipo_Clie_Ide = " + TipoCliente;
                Cmd = new SqlCommand(cadena, Con);
                Con.Open();
                dr = Cmd.ExecuteReader();
                while (dr.Read())
                {
                    //cboTipoCliente.Items.Add(dr["Tipo_Clie_Nombre"]);
                    cboTipoCliente.Text = dr["Tipo_Clie_Nombre"].ToString();
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Tabla de Tipo Cliente - Error " + ex);
            }
            finally
            {
                dr.Close();
                Con.Close();
            }
        }
        private void carga_Tabla_TipoCliente()
        {
            try
            {
                Con = new SqlConnection(strcon);
                if (cboTipoCliente.Items.Count > 0 ) cboTipoCliente.Items.RemoveAt(0);
                string cadena = "Select Tipo_Clie_Nombre from Tipo_Cliente where Tipo_Clie_Estado = 'Activo'";
                Cmd = new SqlCommand(cadena, Con);
                Con.Open();
                dr = Cmd.ExecuteReader();
                while (dr.Read())
                {
                    cboTipoCliente.Items.Add(dr["Tipo_Clie_Nombre"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tabla de Tipo Cliente - Error " + ex);
            }
            finally
            {
                dr.Close();
                Con.Close();
            }
        }

        private void carga_TipoCliente_Ide(string TipoCliente)
        {
            try
            {
                Con = new SqlConnection(strcon);

                string cadena = "Select Tipo_Clie_Ide from Tipo_Cliente where Tipo_Clie_Nombre = '" + TipoCliente + "'";
                Cmd = new SqlCommand(cadena, Con);
                Con.Open();
                dr = Cmd.ExecuteReader();
                while (dr.Read())
                {
                    txtTipo_Ide.Text = dr["Tipo_Clie_Ide"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tabla de Tipo Cliente - Error " + ex);
            }
            finally
            {
                dr.Close();
                Con.Close();
            }
        }

        private void carga_veces(int ClienteID)
        {
            try
            {
                Con = new SqlConnection(strcon);

                string cadena = "Select veces from Cliente where Clie_Ide = " + ClienteID;
                Cmd = new SqlCommand(cadena, Con);
                Con.Open();
                dr = Cmd.ExecuteReader();
                while (dr.Read())
                {
                    veces = Convert.ToInt32(dr["Veces"].ToString());
                }
            }
            catch 
            {
                veces = 0;
            }
            finally
            {
                dr.Close();
                Con.Close();
            }
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            Operacion = 'M';
            desactivar_Botones_edicion();
            ReadOnly_Campos(false);
            txtCodigo.Focus();
           
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Operacion = 'N';
            Limpiar_Campos();
            desactivar_Botones_edicion();
            ReadOnly_Campos(false);
            cboEmpresa.Focus();
           
            Valida_Empresa();
        }

        private void btnInactivar_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Seguro de Eliminar Cliente?", "Eliminacion de Cliente", MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation,MessageBoxDefaultButton.Button2,MessageBoxOptions.DefaultDesktopOnly) == DialogResult.Yes)
            {
                Operacion = 'I';
                
                ClsClientesBE ClientesBE = new ClsClientesBE();
                ClientesBE.Clie_ide = Convert.ToInt32(txtID.Text);
                ClientesBE.Clie_empresa = cboEmpresa.Text;
                ClientesBE.Clie_codigo = txtCodigo.Text;
                ClientesBE.Clie_razon_social = txtRazon_Social.Text;
                ClientesBE.Clie_empresa = txtEmpresa.Text;
                ClientesBE.Clie_ruc = txtRuc.Text;
                ClientesBE.Clie_fecha_constitucion = Convert.ToDateTime(dpkFechaConstitucion.Text);
                ClientesBE.Clie_direccion = txtDireccion.Text;
                ClientesBE.Loca_ide = Convert.ToInt32(txtLoca_Ide.Text);
                ClientesBE.Clie_telefono1 = txtTelefono1.Text;
                ClientesBE.Clie_telefono2 = txtTelefono2.Text;
                ClientesBE.Clie_fax = txtFax.Text;
                ClientesBE.Tipo_clie_ide = Convert.ToInt32(txtTipo_Ide.Text);
                ClientesBE.Acti_clie_ide = Convert.ToInt32(txtActi_Ide.Text);
                ClientesBE.Cate_clie_ide = Convert.ToInt32(txtCate_Ide.Text);
                ClientesBE.Clie_correo = txtCorreo.Text;
                ClientesBE.Clie_paterno = txtPaterno.Text;
                ClientesBE.Clie_materno = txtMaterno.Text;
                ClientesBE.Clie_nombre = txtNombre.Text;
                ClientesBE.Clie_estado = cboEstado.Text;
                ClientesBE.Clie_fechainac = Convert.ToDateTime("01-01-1900");
                ClientesBE.Creacion = Convert.ToDateTime(DateTime.Today);

                ClientesBE.Nombre_error = "";
                ClientesBE.Texto_buscar = "";
                carga_veces(Convert.ToInt32(txtID.Text));
                ClientesBE.Veces = veces;
                ClsClientesBC.Eliminar(ClientesBE);
                inicializa_Botones();
                posicionar_Ultimo_registro();
                ReadOnly_Campos(true);
            }
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (Validar_Campos())
            {
            ClsClientesBE ClientesBE = new ClsClientesBE();
            ClientesBE.Clie_ide = Convert.ToInt32(txtID.Text);
            ClientesBE.Clie_empresa = cboEmpresa.Text;
            ClientesBE.Clie_codigo = txtCodigo.Text;
            ClientesBE.Clie_razon_social = txtRazon_Social.Text;
            ClientesBE.Clie_empresa = txtEmpresa.Text;
            ClientesBE.Clie_ruc = txtRuc.Text;
            ClientesBE.Clie_fecha_constitucion = Convert.ToDateTime(dpkFechaConstitucion.Text);
            ClientesBE.Clie_direccion = txtDireccion.Text;
            ClientesBE.Loca_ide = Convert.ToInt32(txtLoca_Ide.Text);
            ClientesBE.Clie_telefono1 = txtTelefono1.Text;
            ClientesBE.Clie_telefono2 = txtTelefono2.Text;
            ClientesBE.Clie_fax = txtFax.Text;
            ClientesBE.Tipo_clie_ide = Convert.ToInt32(txtTipo_Ide.Text);
            ClientesBE.Acti_clie_ide = Convert.ToInt32(txtActi_Ide.Text);
            ClientesBE.Cate_clie_ide = Convert.ToInt32(txtCate_Ide.Text);
            ClientesBE.Clie_correo = txtCorreo.Text;
            ClientesBE.Clie_paterno = txtPaterno.Text;
            ClientesBE.Clie_materno = txtMaterno.Text;
            ClientesBE.Clie_nombre = txtNombre.Text;
            ClientesBE.Clie_estado = cboEstado.Text;
            ClientesBE.Clie_fechainac = Convert.ToDateTime("01-01-1900");
            ClientesBE.Creacion = Convert.ToDateTime(DateTime.Today);

            ClientesBE.Nombre_error = "";
            ClientesBE.Texto_buscar = "";
            carga_veces(Convert.ToInt32(txtID.Text));
            ClientesBE.Veces = veces;
            switch (Operacion)
            {
                case 'N': ClsClientesBC.Crear(ClientesBE);
                    break;
                case 'M': ClsClientesBC.Actualizar(ClientesBE);
                    break;
                case 'I': ClsClientesBC.Eliminar(ClientesBE);
                    break;
            }
            inicializa_Botones();
            posicionar_Ultimo_registro();
            ReadOnly_Campos(true);
            }
            else
            {
                MessageBox.Show("Algún Campos Marcado con (*) que son Obligatorios estan en Vacio... Completar Datos");
            }

        }

   
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            inicializa_Botones();
            posicionar_Ultimo_registro();
            carga_Localidad(txtLoca_Ide.Text);
            carga_Actividad(txtActi_Ide.Text);
            carga_Categoria(txtCate_Ide.Text);
            carga_TipoCliente(txtTipo_Ide.Text);
            ReadOnly_Campos(true);
        }

        private void cboLocalidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!IsPrimeraCarga)   carga_Localidad_Ide(cboLocalidad.Text);
        }

        private void cboActividad_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!IsPrimeraCarga) carga_Tabla_Actividad_Ide(cboActividad.Text);
        }

        private void cboCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!IsPrimeraCarga) carga_Categoria_Ide(cboCategoria.Text);
        }

        private void cboTipoCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!IsPrimeraCarga) carga_TipoCliente_Ide(cboTipoCliente.Text);
        }

        private void cboLocalidad_SelectionChangeCommitted(object sender, EventArgs e)
        {
            carga_Localidad_Ide(cboLocalidad.Text);
        }

        private void cboEmpresa_SelectedValueChanged(object sender, EventArgs e)
        {
            Valida_Empresa();
        }

        private void Valida_Empresa()
        {
            string empresa = cboEmpresa.Text;
            if (empresa == "Si" )
            {
                txtPaterno.Enabled = false;
                txtMaterno.Enabled = false;
                txtNombre.Enabled = false;
            }
            else
            {
                txtPaterno.Enabled = true;
                txtMaterno.Enabled = true;
                txtNombre.Enabled = true;
            }
        }

        private bool Validar_Campos()
        {
            string value = this.txtActi_Ide.Text.Trim();
            if (string.IsNullOrEmpty(value))
            {
                
                return false;
            }
            value = this.txtLoca_Ide.Text.Trim();
            if (string.IsNullOrEmpty(value))
            {
                return false;
            }

            value = this.txtCate_Ide.Text.Trim();
            if (string.IsNullOrEmpty(value))
            {
                return false;
            }

            value = this.txtTipo_Ide.Text.Trim();
            if (string.IsNullOrEmpty(value))
            {
                return false;
            }

            value = this.txtCodigo.Text.Trim();
            if (string.IsNullOrEmpty(value))
            {
                return false;
            }

            value = this.txtRazon_Social.Text.Trim();
            if (string.IsNullOrEmpty(value))
            {
                return false;
            }

            value = this.txtRuc.Text.Trim();
            if (string.IsNullOrEmpty(value))
            {
                return false;
            }

            value = this.txtDireccion.Text.Trim();
            if (string.IsNullOrEmpty(value))
            {
                return false;
            }

            return true;

        }

        private void cboEmpresa_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        
    }
}
