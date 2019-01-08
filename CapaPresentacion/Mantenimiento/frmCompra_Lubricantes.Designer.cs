namespace CapaPresentacion.Mantenimiento
{
    partial class frmCompra_Lubricantes
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.dgvListado = new System.Windows.Forms.DataGridView();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.cboBuscarPor = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBuscarxFechas = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.dtpFecIni = new System.Windows.Forms.DateTimePicker();
            this.dtpFecFin = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.PanelMantenimiento = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCostoSoles = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txtProve_Ide = new System.Windows.Forms.TextBox();
            this.txtCantidad_Usada = new System.Windows.Forms.TextBox();
            this.txtCostoUnidad = new System.Windows.Forms.TextBox();
            this.txtEquivalencia = new System.Windows.Forms.TextBox();
            this.txtImporte = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtTCambio = new System.Windows.Forms.TextBox();
            this.cboUnidadSalida = new System.Windows.Forms.ComboBox();
            this.cboUnidadCompra = new System.Windows.Forms.ComboBox();
            this.cboMoneda = new System.Windows.Forms.ComboBox();
            this.txtComp_Ide = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtProve = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).BeginInit();
            this.panel1.SuspendLayout();
            this.PanelMantenimiento.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblTitulo.Location = new System.Drawing.Point(7, 7);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(259, 20);
            this.lblTitulo.TabIndex = 29;
            this.lblTitulo.Text = "Control de Compras de Lubricantes";
            // 
            // dgvListado
            // 
            this.dgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListado.Location = new System.Drawing.Point(0, 40);
            this.dgvListado.Name = "dgvListado";
            this.dgvListado.Size = new System.Drawing.Size(816, 413);
            this.dgvListado.TabIndex = 31;
            this.dgvListado.CurrentCellChanged += new System.EventHandler(this.dgvListado_CurrentCellChanged);
            this.dgvListado.DoubleClick += new System.EventHandler(this.dgvListado_DoubleClick);
            this.dgvListado.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvListado_KeyDown);
            // 
            // txtBuscar
            // 
            this.txtBuscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(215, 469);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(246, 23);
            this.txtBuscar.TabIndex = 35;
            this.txtBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscar_KeyPress);
            // 
            // cboBuscarPor
            // 
            this.cboBuscarPor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBuscarPor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboBuscarPor.FormattingEnabled = true;
            this.cboBuscarPor.Location = new System.Drawing.Point(77, 468);
            this.cboBuscarPor.Name = "cboBuscarPor";
            this.cboBuscarPor.Size = new System.Drawing.Size(137, 23);
            this.cboBuscarPor.TabIndex = 34;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnBuscarxFechas);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.dtpFecIni);
            this.panel1.Controls.Add(this.dtpFecFin);
            this.panel1.Location = new System.Drawing.Point(492, 459);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(322, 39);
            this.panel1.TabIndex = 33;
            // 
            // btnBuscarxFechas
            // 
            this.btnBuscarxFechas.Image = global::CapaPresentacion.Properties.Resources.Buscar_p;
            this.btnBuscarxFechas.Location = new System.Drawing.Point(283, 5);
            this.btnBuscarxFechas.Name = "btnBuscarxFechas";
            this.btnBuscarxFechas.Size = new System.Drawing.Size(24, 26);
            this.btnBuscarxFechas.TabIndex = 22;
            this.btnBuscarxFechas.UseVisualStyleBackColor = true;
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
            // dtpFecIni
            // 
            this.dtpFecIni.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecIni.Location = new System.Drawing.Point(46, 9);
            this.dtpFecIni.Name = "dtpFecIni";
            this.dtpFecIni.Size = new System.Drawing.Size(95, 20);
            this.dtpFecIni.TabIndex = 16;
            // 
            // dtpFecFin
            // 
            this.dtpFecFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecFin.Location = new System.Drawing.Point(180, 9);
            this.dtpFecFin.Name = "dtpFecFin";
            this.dtpFecFin.Size = new System.Drawing.Size(95, 20);
            this.dtpFecFin.TabIndex = 17;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(7, 472);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 13);
            this.label12.TabIndex = 32;
            this.label12.Text = "Buscar Por";
            // 
            // PanelMantenimiento
            // 
            this.PanelMantenimiento.BackColor = System.Drawing.SystemColors.ControlLight;
            this.PanelMantenimiento.Controls.Add(this.label11);
            this.PanelMantenimiento.Controls.Add(this.txtCostoSoles);
            this.PanelMantenimiento.Controls.Add(this.txtMarca);
            this.PanelMantenimiento.Controls.Add(this.txtDescripcion);
            this.PanelMantenimiento.Controls.Add(this.label20);
            this.PanelMantenimiento.Controls.Add(this.txtCodigo);
            this.PanelMantenimiento.Controls.Add(this.label19);
            this.PanelMantenimiento.Controls.Add(this.label18);
            this.PanelMantenimiento.Controls.Add(this.txtProve_Ide);
            this.PanelMantenimiento.Controls.Add(this.txtCantidad_Usada);
            this.PanelMantenimiento.Controls.Add(this.txtCostoUnidad);
            this.PanelMantenimiento.Controls.Add(this.txtEquivalencia);
            this.PanelMantenimiento.Controls.Add(this.txtImporte);
            this.PanelMantenimiento.Controls.Add(this.txtCantidad);
            this.PanelMantenimiento.Controls.Add(this.txtTCambio);
            this.PanelMantenimiento.Controls.Add(this.cboUnidadSalida);
            this.PanelMantenimiento.Controls.Add(this.cboUnidadCompra);
            this.PanelMantenimiento.Controls.Add(this.cboMoneda);
            this.PanelMantenimiento.Controls.Add(this.txtComp_Ide);
            this.PanelMantenimiento.Controls.Add(this.label17);
            this.PanelMantenimiento.Controls.Add(this.label16);
            this.PanelMantenimiento.Controls.Add(this.label15);
            this.PanelMantenimiento.Controls.Add(this.label10);
            this.PanelMantenimiento.Controls.Add(this.label9);
            this.PanelMantenimiento.Controls.Add(this.label8);
            this.PanelMantenimiento.Controls.Add(this.label7);
            this.PanelMantenimiento.Controls.Add(this.label6);
            this.PanelMantenimiento.Controls.Add(this.label5);
            this.PanelMantenimiento.Controls.Add(this.label4);
            this.PanelMantenimiento.Controls.Add(this.btnCancelar);
            this.PanelMantenimiento.Controls.Add(this.btnGrabar);
            this.PanelMantenimiento.Controls.Add(this.dtpFecha);
            this.PanelMantenimiento.Controls.Add(this.txtNumero);
            this.PanelMantenimiento.Controls.Add(this.txtProve);
            this.PanelMantenimiento.Controls.Add(this.label3);
            this.PanelMantenimiento.Controls.Add(this.label2);
            this.PanelMantenimiento.Controls.Add(this.label1);
            this.PanelMantenimiento.Location = new System.Drawing.Point(172, 40);
            this.PanelMantenimiento.Name = "PanelMantenimiento";
            this.PanelMantenimiento.Size = new System.Drawing.Size(566, 459);
            this.PanelMantenimiento.TabIndex = 37;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(315, 389);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(108, 13);
            this.label11.TabIndex = 49;
            this.label11.Text = "Costo x Unidad Soles";
            // 
            // txtCostoSoles
            // 
            this.txtCostoSoles.Enabled = false;
            this.txtCostoSoles.Location = new System.Drawing.Point(429, 385);
            this.txtCostoSoles.Name = "txtCostoSoles";
            this.txtCostoSoles.Size = new System.Drawing.Size(113, 20);
            this.txtCostoSoles.TabIndex = 48;
            this.txtCostoSoles.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtMarca
            // 
            this.txtMarca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMarca.Location = new System.Drawing.Point(129, 214);
            this.txtMarca.MaxLength = 20;
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(150, 20);
            this.txtMarca.TabIndex = 5;
            this.txtMarca.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMarca_KeyPress);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescripcion.Location = new System.Drawing.Point(129, 184);
            this.txtDescripcion.MaxLength = 50;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(414, 20);
            this.txtDescripcion.TabIndex = 4;
            this.txtDescripcion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDescripcion_KeyPress);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(28, 220);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(37, 13);
            this.label20.TabIndex = 47;
            this.label20.Text = "Marca";
            // 
            // txtCodigo
            // 
            this.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodigo.Location = new System.Drawing.Point(129, 150);
            this.txtCodigo.MaxLength = 15;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 3;
            this.txtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigo_KeyPress);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(28, 187);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(63, 13);
            this.label19.TabIndex = 45;
            this.label19.Text = "Descripcion";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(28, 153);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(43, 13);
            this.label18.TabIndex = 44;
            this.label18.Text = "Codigo ";
            // 
            // txtProve_Ide
            // 
            this.txtProve_Ide.Location = new System.Drawing.Point(86, 49);
            this.txtProve_Ide.Name = "txtProve_Ide";
            this.txtProve_Ide.Size = new System.Drawing.Size(38, 20);
            this.txtProve_Ide.TabIndex = 43;
            this.txtProve_Ide.Visible = false;
            // 
            // txtCantidad_Usada
            // 
            this.txtCantidad_Usada.Enabled = false;
            this.txtCantidad_Usada.Location = new System.Drawing.Point(129, 390);
            this.txtCantidad_Usada.Name = "txtCantidad_Usada";
            this.txtCantidad_Usada.ReadOnly = true;
            this.txtCantidad_Usada.Size = new System.Drawing.Size(100, 20);
            this.txtCantidad_Usada.TabIndex = 14;
            this.txtCantidad_Usada.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtCostoUnidad
            // 
            this.txtCostoUnidad.Enabled = false;
            this.txtCostoUnidad.Location = new System.Drawing.Point(430, 355);
            this.txtCostoUnidad.Name = "txtCostoUnidad";
            this.txtCostoUnidad.Size = new System.Drawing.Size(113, 20);
            this.txtCostoUnidad.TabIndex = 13;
            this.txtCostoUnidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCostoUnidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCostoUnidad_KeyPress);
            // 
            // txtEquivalencia
            // 
            this.txtEquivalencia.Location = new System.Drawing.Point(430, 320);
            this.txtEquivalencia.Name = "txtEquivalencia";
            this.txtEquivalencia.Size = new System.Drawing.Size(113, 20);
            this.txtEquivalencia.TabIndex = 11;
            this.txtEquivalencia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtEquivalencia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEquivalencia_KeyPress);
            this.txtEquivalencia.Validated += new System.EventHandler(this.txtEquivalencia_Validated);
            // 
            // txtImporte
            // 
            this.txtImporte.Location = new System.Drawing.Point(129, 356);
            this.txtImporte.Name = "txtImporte";
            this.txtImporte.Size = new System.Drawing.Size(100, 20);
            this.txtImporte.TabIndex = 12;
            this.txtImporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtImporte.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtImporte_KeyPress);
            this.txtImporte.Validated += new System.EventHandler(this.txtImporte_Validated);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(129, 322);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 20);
            this.txtCantidad.TabIndex = 10;
            this.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
            // 
            // txtTCambio
            // 
            this.txtTCambio.Location = new System.Drawing.Point(429, 249);
            this.txtTCambio.Name = "txtTCambio";
            this.txtTCambio.Size = new System.Drawing.Size(114, 20);
            this.txtTCambio.TabIndex = 7;
            this.txtTCambio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTCambio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTCambio_KeyPress);
            // 
            // cboUnidadSalida
            // 
            this.cboUnidadSalida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUnidadSalida.FormattingEnabled = true;
            this.cboUnidadSalida.Location = new System.Drawing.Point(430, 286);
            this.cboUnidadSalida.Name = "cboUnidadSalida";
            this.cboUnidadSalida.Size = new System.Drawing.Size(113, 21);
            this.cboUnidadSalida.TabIndex = 9;
            this.cboUnidadSalida.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboUnidadSalida_KeyPress);
            // 
            // cboUnidadCompra
            // 
            this.cboUnidadCompra.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUnidadCompra.FormattingEnabled = true;
            this.cboUnidadCompra.Location = new System.Drawing.Point(129, 287);
            this.cboUnidadCompra.Name = "cboUnidadCompra";
            this.cboUnidadCompra.Size = new System.Drawing.Size(100, 21);
            this.cboUnidadCompra.TabIndex = 8;
            this.cboUnidadCompra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboUnidadCompra_KeyPress);
            this.cboUnidadCompra.Validated += new System.EventHandler(this.cboUnidadCompra_Validated);
            // 
            // cboMoneda
            // 
            this.cboMoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMoneda.FormattingEnabled = true;
            this.cboMoneda.Location = new System.Drawing.Point(129, 249);
            this.cboMoneda.Name = "cboMoneda";
            this.cboMoneda.Size = new System.Drawing.Size(100, 21);
            this.cboMoneda.TabIndex = 6;
            this.cboMoneda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboMoneda_KeyPress);
            // 
            // txtComp_Ide
            // 
            this.txtComp_Ide.Location = new System.Drawing.Point(130, 15);
            this.txtComp_Ide.Name = "txtComp_Ide";
            this.txtComp_Ide.ReadOnly = true;
            this.txtComp_Ide.Size = new System.Drawing.Size(71, 20);
            this.txtComp_Ide.TabIndex = 0;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(28, 19);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(60, 13);
            this.label17.TabIndex = 42;
            this.label17.Text = "ID Registro";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(28, 392);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(83, 13);
            this.label16.TabIndex = 41;
            this.label16.Text = "Cantidad Usada";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(315, 358);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(111, 13);
            this.label15.TabIndex = 40;
            this.label15.Text = "Costo x Unidad Salida";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(315, 324);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 13);
            this.label10.TabIndex = 39;
            this.label10.Text = "Equivalencia";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(315, 290);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 13);
            this.label9.TabIndex = 38;
            this.label9.Text = "Unidad de Salida";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 358);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 37;
            this.label8.Text = "Importe Total";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 324);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 36;
            this.label7.Text = "Cantidad";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 290);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 13);
            this.label6.TabIndex = 35;
            this.label6.Text = "Unidad de Compra";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(315, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "Tipo de Cambio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "Tipo de Moneda";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = global::CapaPresentacion.Properties.Resources.bcancelar;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(427, 419);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(74, 28);
            this.btnCancelar.TabIndex = 16;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Image = global::CapaPresentacion.Properties.Resources.bgrabar;
            this.btnGrabar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGrabar.Location = new System.Drawing.Point(320, 419);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(74, 28);
            this.btnGrabar.TabIndex = 15;
            this.btnGrabar.Text = "&Grabar";
            this.btnGrabar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(129, 83);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(102, 20);
            this.dtpFecha.TabIndex = 1;
            this.dtpFecha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dtpFecha_KeyPress);
            // 
            // txtNumero
            // 
            this.txtNumero.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNumero.Location = new System.Drawing.Point(129, 117);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 20);
            this.txtNumero.TabIndex = 2;
            this.txtNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumero_KeyPress);
            // 
            // txtProve
            // 
            this.txtProve.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtProve.Location = new System.Drawing.Point(129, 49);
            this.txtProve.Name = "txtProve";
            this.txtProve.Size = new System.Drawing.Size(415, 20);
            this.txtProve.TabIndex = 0;
            this.txtProve.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtProve_KeyDown);
            this.txtProve.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProve_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "N° Comprobante ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "Fecha";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Proveedor ";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = global::CapaPresentacion.Properties.Resources.Buscar_p;
            this.btnBuscar.Location = new System.Drawing.Point(461, 467);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(24, 26);
            this.btnBuscar.TabIndex = 36;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Image = global::CapaPresentacion.Properties.Resources.WZPRINT;
            this.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImprimir.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnImprimir.Location = new System.Drawing.Point(658, 4);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(74, 28);
            this.btnImprimir.TabIndex = 30;
            this.btnImprimir.Text = "&Imprimir";
            this.btnImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Image = global::CapaPresentacion.Properties.Resources.bsalir;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSalir.Location = new System.Drawing.Point(740, 4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(74, 28);
            this.btnSalir.TabIndex = 28;
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
            this.btnEliminar.Location = new System.Drawing.Point(573, 4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(74, 28);
            this.btnEliminar.TabIndex = 25;
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
            this.btnModificar.Location = new System.Drawing.Point(488, 4);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(74, 28);
            this.btnModificar.TabIndex = 24;
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
            this.btnNuevo.Location = new System.Drawing.Point(403, 4);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(74, 28);
            this.btnNuevo.TabIndex = 23;
            this.btnNuevo.Text = "&Nuevo";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // frmCompra_Lubricantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(818, 499);
            this.Controls.Add(this.PanelMantenimiento);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.cboBuscarPor);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dgvListado);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnNuevo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmCompra_Lubricantes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Compra de Lubricantes";
            this.Load += new System.EventHandler(this.frmCompra_Lubricantes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.PanelMantenimiento.ResumeLayout(false);
            this.PanelMantenimiento.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.DataGridView dgvListado;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.ComboBox cboBuscarPor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBuscarxFechas;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dtpFecIni;
        private System.Windows.Forms.DateTimePicker dtpFecFin;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel PanelMantenimiento;
        private System.Windows.Forms.TextBox txtCantidad_Usada;
        private System.Windows.Forms.TextBox txtCostoUnidad;
        private System.Windows.Forms.TextBox txtEquivalencia;
        private System.Windows.Forms.TextBox txtImporte;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtTCambio;
        private System.Windows.Forms.ComboBox cboUnidadSalida;
        private System.Windows.Forms.ComboBox cboUnidadCompra;
        private System.Windows.Forms.ComboBox cboMoneda;
        private System.Windows.Forms.TextBox txtComp_Ide;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtProve;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProve_Ide;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtCostoSoles;
    }
}