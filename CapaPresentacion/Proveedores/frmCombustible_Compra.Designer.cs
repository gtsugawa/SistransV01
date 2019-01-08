namespace CapaPresentacion.Proveedores
{
    partial class frmCombustible_Compra
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dgvListado = new System.Windows.Forms.DataGridView();
            this.PanelMantenimiento = new System.Windows.Forms.Panel();
            this.txtRendimiento = new System.Windows.Forms.TextBox();
            this.txtEficiencia = new System.Windows.Forms.TextBox();
            this.lblEficiencia = new System.Windows.Forms.Label();
            this.lblRecorrido = new System.Windows.Forms.Label();
            this.lblKmFinal = new System.Windows.Forms.Label();
            this.txtRecorrido = new System.Windows.Forms.TextBox();
            this.txtKmFinal = new System.Windows.Forms.TextBox();
            this.txtUnitario = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtOrden = new System.Windows.Forms.TextBox();
            this.lblorden = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.txtProve_Ide = new System.Windows.Forms.TextBox();
            this.txtVehi_Ide = new System.Windows.Forms.TextBox();
            this.txtChof_Ide = new System.Windows.Forms.TextBox();
            this.txtTran_Ide = new System.Windows.Forms.TextBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.cboTipoCombustible = new System.Windows.Forms.ComboBox();
            this.txtChofer = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtImporte = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtKilometraje = new System.Windows.Forms.TextBox();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.txtTransportista = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtProve = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dtpFecIni = new System.Windows.Forms.DateTimePicker();
            this.dtpFecFin = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBuscarxFechas = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cboBuscarPor = new System.Windows.Forms.ComboBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtComb_Inicio = new System.Windows.Forms.TextBox();
            this.txtComb_Final = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtDeposito = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).BeginInit();
            this.PanelMantenimiento.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvListado
            // 
            this.dgvListado.AllowUserToAddRows = false;
            this.dgvListado.AllowUserToDeleteRows = false;
            this.dgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListado.Location = new System.Drawing.Point(4, 46);
            this.dgvListado.Name = "dgvListado";
            this.dgvListado.ReadOnly = true;
            this.dgvListado.Size = new System.Drawing.Size(841, 406);
            this.dgvListado.TabIndex = 0;
            this.dgvListado.CurrentCellChanged += new System.EventHandler(this.dgvListado_CurrentCellChanged);
            this.dgvListado.DoubleClick += new System.EventHandler(this.dgvListado_DoubleClick);
            this.dgvListado.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvListado_KeyDown);
            this.dgvListado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dgvListado_KeyPress);
            // 
            // PanelMantenimiento
            // 
            this.PanelMantenimiento.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.PanelMantenimiento.BackColor = System.Drawing.Color.Gainsboro;
            this.PanelMantenimiento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelMantenimiento.Controls.Add(this.txtDeposito);
            this.PanelMantenimiento.Controls.Add(this.label18);
            this.PanelMantenimiento.Controls.Add(this.txtComb_Final);
            this.PanelMantenimiento.Controls.Add(this.txtComb_Inicio);
            this.PanelMantenimiento.Controls.Add(this.label16);
            this.PanelMantenimiento.Controls.Add(this.label15);
            this.PanelMantenimiento.Controls.Add(this.txtRendimiento);
            this.PanelMantenimiento.Controls.Add(this.txtEficiencia);
            this.PanelMantenimiento.Controls.Add(this.lblEficiencia);
            this.PanelMantenimiento.Controls.Add(this.lblRecorrido);
            this.PanelMantenimiento.Controls.Add(this.lblKmFinal);
            this.PanelMantenimiento.Controls.Add(this.txtRecorrido);
            this.PanelMantenimiento.Controls.Add(this.txtKmFinal);
            this.PanelMantenimiento.Controls.Add(this.txtUnitario);
            this.PanelMantenimiento.Controls.Add(this.label17);
            this.PanelMantenimiento.Controls.Add(this.lblNombre);
            this.PanelMantenimiento.Controls.Add(this.txtOrden);
            this.PanelMantenimiento.Controls.Add(this.lblorden);
            this.PanelMantenimiento.Controls.Add(this.btnCancelar);
            this.PanelMantenimiento.Controls.Add(this.btnGrabar);
            this.PanelMantenimiento.Controls.Add(this.txtProve_Ide);
            this.PanelMantenimiento.Controls.Add(this.txtVehi_Ide);
            this.PanelMantenimiento.Controls.Add(this.txtChof_Ide);
            this.PanelMantenimiento.Controls.Add(this.txtTran_Ide);
            this.PanelMantenimiento.Controls.Add(this.dtpFecha);
            this.PanelMantenimiento.Controls.Add(this.cboTipoCombustible);
            this.PanelMantenimiento.Controls.Add(this.txtChofer);
            this.PanelMantenimiento.Controls.Add(this.label10);
            this.PanelMantenimiento.Controls.Add(this.txtImporte);
            this.PanelMantenimiento.Controls.Add(this.txtCantidad);
            this.PanelMantenimiento.Controls.Add(this.txtKilometraje);
            this.PanelMantenimiento.Controls.Add(this.txtPlaca);
            this.PanelMantenimiento.Controls.Add(this.txtTransportista);
            this.PanelMantenimiento.Controls.Add(this.txtNumero);
            this.PanelMantenimiento.Controls.Add(this.txtProve);
            this.PanelMantenimiento.Controls.Add(this.label9);
            this.PanelMantenimiento.Controls.Add(this.label8);
            this.PanelMantenimiento.Controls.Add(this.label7);
            this.PanelMantenimiento.Controls.Add(this.label6);
            this.PanelMantenimiento.Controls.Add(this.label5);
            this.PanelMantenimiento.Controls.Add(this.label4);
            this.PanelMantenimiento.Controls.Add(this.label3);
            this.PanelMantenimiento.Controls.Add(this.label2);
            this.PanelMantenimiento.Controls.Add(this.label1);
            this.PanelMantenimiento.Location = new System.Drawing.Point(192, 49);
            this.PanelMantenimiento.Name = "PanelMantenimiento";
            this.PanelMantenimiento.Size = new System.Drawing.Size(452, 447);
            this.PanelMantenimiento.TabIndex = 7;
            // 
            // txtRendimiento
            // 
            this.txtRendimiento.Location = new System.Drawing.Point(381, 133);
            this.txtRendimiento.Name = "txtRendimiento";
            this.txtRendimiento.ReadOnly = true;
            this.txtRendimiento.Size = new System.Drawing.Size(63, 20);
            this.txtRendimiento.TabIndex = 14;
            this.txtRendimiento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtEficiencia
            // 
            this.txtEficiencia.Location = new System.Drawing.Point(381, 156);
            this.txtEficiencia.Name = "txtEficiencia";
            this.txtEficiencia.ReadOnly = true;
            this.txtEficiencia.Size = new System.Drawing.Size(63, 20);
            this.txtEficiencia.TabIndex = 15;
            this.txtEficiencia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblEficiencia
            // 
            this.lblEficiencia.AutoSize = true;
            this.lblEficiencia.Location = new System.Drawing.Point(379, 117);
            this.lblEficiencia.Name = "lblEficiencia";
            this.lblEficiencia.Size = new System.Drawing.Size(66, 13);
            this.lblEficiencia.TabIndex = 59;
            this.lblEficiencia.Text = "Rendimiento";
            // 
            // lblRecorrido
            // 
            this.lblRecorrido.AutoSize = true;
            this.lblRecorrido.Location = new System.Drawing.Point(323, 140);
            this.lblRecorrido.Name = "lblRecorrido";
            this.lblRecorrido.Size = new System.Drawing.Size(53, 13);
            this.lblRecorrido.TabIndex = 58;
            this.lblRecorrido.Text = "Recorrido";
            // 
            // lblKmFinal
            // 
            this.lblKmFinal.AutoSize = true;
            this.lblKmFinal.Location = new System.Drawing.Point(228, 140);
            this.lblKmFinal.Name = "lblKmFinal";
            this.lblKmFinal.Size = new System.Drawing.Size(83, 13);
            this.lblKmFinal.TabIndex = 57;
            this.lblKmFinal.Text = "Kilometraje Final";
            // 
            // txtRecorrido
            // 
            this.txtRecorrido.Location = new System.Drawing.Point(315, 156);
            this.txtRecorrido.Name = "txtRecorrido";
            this.txtRecorrido.ReadOnly = true;
            this.txtRecorrido.Size = new System.Drawing.Size(61, 20);
            this.txtRecorrido.TabIndex = 13;
            this.txtRecorrido.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtKmFinal
            // 
            this.txtKmFinal.Location = new System.Drawing.Point(226, 156);
            this.txtKmFinal.Name = "txtKmFinal";
            this.txtKmFinal.ReadOnly = true;
            this.txtKmFinal.Size = new System.Drawing.Size(84, 20);
            this.txtKmFinal.TabIndex = 12;
            this.txtKmFinal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtUnitario
            // 
            this.txtUnitario.Location = new System.Drawing.Point(107, 272);
            this.txtUnitario.Name = "txtUnitario";
            this.txtUnitario.ReadOnly = true;
            this.txtUnitario.Size = new System.Drawing.Size(100, 20);
            this.txtUnitario.TabIndex = 53;
            this.txtUnitario.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(16, 276);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(43, 13);
            this.label17.TabIndex = 54;
            this.label17.Text = "Unitario";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(231, 122);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(0, 13);
            this.lblNombre.TabIndex = 50;
            // 
            // txtOrden
            // 
            this.txtOrden.Location = new System.Drawing.Point(274, 252);
            this.txtOrden.Multiline = true;
            this.txtOrden.Name = "txtOrden";
            this.txtOrden.Size = new System.Drawing.Size(164, 66);
            this.txtOrden.TabIndex = 16;
            this.txtOrden.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtOrden_KeyDown);
            this.txtOrden.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOrden_KeyPress);
            // 
            // lblorden
            // 
            this.lblorden.AutoSize = true;
            this.lblorden.Location = new System.Drawing.Point(270, 236);
            this.lblorden.Name = "lblorden";
            this.lblorden.Size = new System.Drawing.Size(129, 13);
            this.lblorden.TabIndex = 48;
            this.lblorden.Text = "Ordenes de Recojo (O/R)";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = global::CapaPresentacion.Properties.Resources.bcancelar;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(362, 412);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(74, 28);
            this.btnCancelar.TabIndex = 14;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Image = global::CapaPresentacion.Properties.Resources.bgrabar;
            this.btnGrabar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGrabar.Location = new System.Drawing.Point(276, 412);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(74, 28);
            this.btnGrabar.TabIndex = 13;
            this.btnGrabar.Text = "&Grabar";
            this.btnGrabar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // txtProve_Ide
            // 
            this.txtProve_Ide.Enabled = false;
            this.txtProve_Ide.Location = new System.Drawing.Point(450, 12);
            this.txtProve_Ide.Name = "txtProve_Ide";
            this.txtProve_Ide.Size = new System.Drawing.Size(48, 20);
            this.txtProve_Ide.TabIndex = 45;
            // 
            // txtVehi_Ide
            // 
            this.txtVehi_Ide.Enabled = false;
            this.txtVehi_Ide.Location = new System.Drawing.Point(450, 137);
            this.txtVehi_Ide.Name = "txtVehi_Ide";
            this.txtVehi_Ide.Size = new System.Drawing.Size(51, 20);
            this.txtVehi_Ide.TabIndex = 44;
            // 
            // txtChof_Ide
            // 
            this.txtChof_Ide.Enabled = false;
            this.txtChof_Ide.Location = new System.Drawing.Point(450, 197);
            this.txtChof_Ide.Name = "txtChof_Ide";
            this.txtChof_Ide.Size = new System.Drawing.Size(51, 20);
            this.txtChof_Ide.TabIndex = 43;
            // 
            // txtTran_Ide
            // 
            this.txtTran_Ide.Enabled = false;
            this.txtTran_Ide.Location = new System.Drawing.Point(450, 107);
            this.txtTran_Ide.Name = "txtTran_Ide";
            this.txtTran_Ide.Size = new System.Drawing.Size(51, 20);
            this.txtTran_Ide.TabIndex = 42;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(108, 34);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(102, 20);
            this.dtpFecha.TabIndex = 1;
            this.dtpFecha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dtpFecha_KeyPress);
            // 
            // cboTipoCombustible
            // 
            this.cboTipoCombustible.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoCombustible.FormattingEnabled = true;
            this.cboTipoCombustible.Location = new System.Drawing.Point(108, 213);
            this.cboTipoCombustible.Name = "cboTipoCombustible";
            this.cboTipoCombustible.Size = new System.Drawing.Size(141, 21);
            this.cboTipoCombustible.TabIndex = 7;
            this.cboTipoCombustible.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboTipoCombustible_KeyPress);
            // 
            // txtChofer
            // 
            this.txtChofer.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtChofer.Location = new System.Drawing.Point(107, 184);
            this.txtChofer.Name = "txtChofer";
            this.txtChofer.Size = new System.Drawing.Size(336, 20);
            this.txtChofer.TabIndex = 6;
            this.txtChofer.DoubleClick += new System.EventHandler(this.txtChofer_DoubleClick);
            this.txtChofer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtChofer_KeyDown);
            this.txtChofer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtChofer_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 188);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 41;
            this.label10.Text = "Chofer";
            // 
            // txtImporte
            // 
            this.txtImporte.Location = new System.Drawing.Point(107, 301);
            this.txtImporte.Name = "txtImporte";
            this.txtImporte.Size = new System.Drawing.Size(100, 20);
            this.txtImporte.TabIndex = 9;
            this.txtImporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtImporte.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtImporte_KeyPress);
            this.txtImporte.Validated += new System.EventHandler(this.txtImporte_Validated);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(108, 243);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 20);
            this.txtCantidad.TabIndex = 8;
            this.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
            // 
            // txtKilometraje
            // 
            this.txtKilometraje.Location = new System.Drawing.Point(108, 155);
            this.txtKilometraje.Name = "txtKilometraje";
            this.txtKilometraje.Size = new System.Drawing.Size(100, 20);
            this.txtKilometraje.TabIndex = 5;
            this.txtKilometraje.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtKilometraje.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKilometraje_KeyPress);
            // 
            // txtPlaca
            // 
            this.txtPlaca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPlaca.Location = new System.Drawing.Point(108, 121);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(100, 20);
            this.txtPlaca.TabIndex = 4;
            this.txtPlaca.DoubleClick += new System.EventHandler(this.txtPlaca_DoubleClick);
            this.txtPlaca.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPlaca_KeyDown);
            this.txtPlaca.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPlaca_KeyPress);
            this.txtPlaca.Validated += new System.EventHandler(this.txtPlaca_Validated);
            // 
            // txtTransportista
            // 
            this.txtTransportista.Location = new System.Drawing.Point(108, 92);
            this.txtTransportista.Name = "txtTransportista";
            this.txtTransportista.Size = new System.Drawing.Size(336, 20);
            this.txtTransportista.TabIndex = 3;
            this.txtTransportista.TextChanged += new System.EventHandler(this.txtTransportista_TextChanged);
            this.txtTransportista.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTransportista_KeyDown);
            this.txtTransportista.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTransportista_KeyPress);
            // 
            // txtNumero
            // 
            this.txtNumero.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNumero.Location = new System.Drawing.Point(108, 63);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 20);
            this.txtNumero.TabIndex = 2;
            this.txtNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumero_KeyPress);
            // 
            // txtProve
            // 
            this.txtProve.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtProve.Location = new System.Drawing.Point(108, 5);
            this.txtProve.Name = "txtProve";
            this.txtProve.Size = new System.Drawing.Size(336, 20);
            this.txtProve.TabIndex = 0;
            this.txtProve.DoubleClick += new System.EventHandler(this.txtProve_DoubleClick);
            this.txtProve.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtProve_KeyDown);
            this.txtProve.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProve_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 159);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 32;
            this.label9.Text = "Kilometraje";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 304);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 31;
            this.label8.Text = "Importe ";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 247);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "Cantidad";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Tipo Combustible";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Placa ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Transportista";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "N° Comprobante ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Fecha";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Proveedor ";
            // 
            // btnSalir
            // 
            this.btnSalir.Image = global::CapaPresentacion.Properties.Resources.bsalir;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSalir.Location = new System.Drawing.Point(740, 4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(74, 28);
            this.btnSalir.TabIndex = 13;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Image = global::CapaPresentacion.Properties.Resources.bborrar;
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnEliminar.Location = new System.Drawing.Point(488, 4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(74, 28);
            this.btnEliminar.TabIndex = 10;
            this.btnEliminar.Text = "&Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Image = global::CapaPresentacion.Properties.Resources.beditar;
            this.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnModificar.Location = new System.Drawing.Point(404, 4);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(74, 28);
            this.btnModificar.TabIndex = 9;
            this.btnModificar.Text = "&Modificar";
            this.btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Image = global::CapaPresentacion.Properties.Resources.bnuevo;
            this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnNuevo.Location = new System.Drawing.Point(320, 4);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(74, 28);
            this.btnNuevo.TabIndex = 8;
            this.btnNuevo.Text = "&Nuevo";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label11.Location = new System.Drawing.Point(4, 7);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(268, 20);
            this.label11.TabIndex = 14;
            this.label11.Text = "Control de Compras de Combustible ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(1, 469);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 13);
            this.label12.TabIndex = 15;
            this.label12.Text = "Buscar x";
            // 
            // dtpFecIni
            // 
            this.dtpFecIni.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecIni.Location = new System.Drawing.Point(46, 9);
            this.dtpFecIni.Name = "dtpFecIni";
            this.dtpFecIni.Size = new System.Drawing.Size(95, 20);
            this.dtpFecIni.TabIndex = 0;
            this.dtpFecIni.Validated += new System.EventHandler(this.dtpFecIni_Validated);
            // 
            // dtpFecFin
            // 
            this.dtpFecFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecFin.Location = new System.Drawing.Point(180, 9);
            this.dtpFecFin.Name = "dtpFecFin";
            this.dtpFecFin.Size = new System.Drawing.Size(95, 20);
            this.dtpFecFin.TabIndex = 17;
            this.dtpFecFin.Validated += new System.EventHandler(this.dtpFecFin_Validated);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnBuscarxFechas);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.dtpFecIni);
            this.panel1.Controls.Add(this.dtpFecFin);
            this.panel1.Location = new System.Drawing.Point(522, 456);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(322, 39);
            this.panel1.TabIndex = 18;
            // 
            // btnBuscarxFechas
            // 
            this.btnBuscarxFechas.Image = global::CapaPresentacion.Properties.Resources.Buscar_p;
            this.btnBuscarxFechas.Location = new System.Drawing.Point(283, 5);
            this.btnBuscarxFechas.Name = "btnBuscarxFechas";
            this.btnBuscarxFechas.Size = new System.Drawing.Size(24, 26);
            this.btnBuscarxFechas.TabIndex = 22;
            this.btnBuscarxFechas.UseVisualStyleBackColor = true;
            this.btnBuscarxFechas.Click += new System.EventHandler(this.btnBuscarxFechas_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(144, 13);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(35, 13);
            this.label14.TabIndex = 19;
            this.label14.Text = "Hasta";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(5, 13);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 13);
            this.label13.TabIndex = 18;
            this.label13.Text = "Desde ";
            // 
            // cboBuscarPor
            // 
            this.cboBuscarPor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBuscarPor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboBuscarPor.FormattingEnabled = true;
            this.cboBuscarPor.Location = new System.Drawing.Point(57, 465);
            this.cboBuscarPor.Name = "cboBuscarPor";
            this.cboBuscarPor.Size = new System.Drawing.Size(138, 23);
            this.cboBuscarPor.TabIndex = 19;
            this.cboBuscarPor.SelectedValueChanged += new System.EventHandler(this.cboBuscarPor_SelectedValueChanged);
            this.cboBuscarPor.Validated += new System.EventHandler(this.cboBuscarPor_Validated);
            // 
            // txtBuscar
            // 
            this.txtBuscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(197, 466);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(297, 23);
            this.txtBuscar.TabIndex = 20;
            this.txtBuscar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBuscar_KeyDown);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = global::CapaPresentacion.Properties.Resources.Buscar_p;
            this.btnBuscar.Location = new System.Drawing.Point(496, 464);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(24, 26);
            this.btnBuscar.TabIndex = 0;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Image = global::CapaPresentacion.Properties.Resources.WZPRINT;
            this.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImprimir.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnImprimir.Location = new System.Drawing.Point(572, 4);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(74, 28);
            this.btnImprimir.TabIndex = 22;
            this.btnImprimir.Text = "&Imprimir";
            this.btnImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Image = global::CapaPresentacion.Properties.Resources.refresh;
            this.btnActualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActualizar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnActualizar.Location = new System.Drawing.Point(656, 4);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(74, 28);
            this.btnActualizar.TabIndex = 23;
            this.btnActualizar.Text = "&Actualizar";
            this.btnActualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(14, 335);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(91, 13);
            this.label15.TabIndex = 60;
            this.label15.Text = "Marcador al Inicio";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(14, 361);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(88, 13);
            this.label16.TabIndex = 61;
            this.label16.Text = "Marcador al Final";
            // 
            // txtComb_Inicio
            // 
            this.txtComb_Inicio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtComb_Inicio.Location = new System.Drawing.Point(107, 332);
            this.txtComb_Inicio.Name = "txtComb_Inicio";
            this.txtComb_Inicio.Size = new System.Drawing.Size(329, 20);
            this.txtComb_Inicio.TabIndex = 10;
            // 
            // txtComb_Final
            // 
            this.txtComb_Final.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtComb_Final.Location = new System.Drawing.Point(107, 358);
            this.txtComb_Final.Name = "txtComb_Final";
            this.txtComb_Final.Size = new System.Drawing.Size(329, 20);
            this.txtComb_Final.TabIndex = 11;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(15, 392);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(58, 13);
            this.label18.TabIndex = 66;
            this.label18.Text = "Deposito a";
            // 
            // txtDeposito
            // 
            this.txtDeposito.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDeposito.Location = new System.Drawing.Point(106, 387);
            this.txtDeposito.Name = "txtDeposito";
            this.txtDeposito.Size = new System.Drawing.Size(329, 20);
            this.txtDeposito.TabIndex = 12;
            // 
            // frmCombustible_Compra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(845, 497);
            this.Controls.Add(this.PanelMantenimiento);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.cboBuscarPor);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.dgvListado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCombustible_Compra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Compras de Combustible ";
            this.Load += new System.EventHandler(this.frmCombustible_Compra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).EndInit();
            this.PanelMantenimiento.ResumeLayout(false);
            this.PanelMantenimiento.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListado;
        private System.Windows.Forms.Panel PanelMantenimiento;
        private System.Windows.Forms.TextBox txtVehi_Ide;
        private System.Windows.Forms.TextBox txtChof_Ide;
        private System.Windows.Forms.TextBox txtTran_Ide;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.ComboBox cboTipoCombustible;
        private System.Windows.Forms.TextBox txtChofer;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtImporte;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtKilometraje;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.TextBox txtTransportista;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtProve;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.TextBox txtProve_Ide;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dtpFecIni;
        private System.Windows.Forms.DateTimePicker dtpFecFin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cboBuscarPor;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnBuscarxFechas;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.TextBox txtOrden;
        private System.Windows.Forms.Label lblorden;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtUnitario;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lblRecorrido;
        private System.Windows.Forms.Label lblKmFinal;
        private System.Windows.Forms.TextBox txtRecorrido;
        private System.Windows.Forms.TextBox txtKmFinal;
        private System.Windows.Forms.TextBox txtEficiencia;
        private System.Windows.Forms.Label lblEficiencia;
        private System.Windows.Forms.TextBox txtRendimiento;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox txtDeposito;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtComb_Final;
        private System.Windows.Forms.TextBox txtComb_Inicio;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
    }
}