namespace CapaPresentacion.Mantenimiento
{
    partial class frmMantenimiento_Programado
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
            this.btnImprimir = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.dgvListado = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnBuscarxFechas = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.dtpFecIni = new System.Windows.Forms.DateTimePicker();
            this.dtpFecFin = new System.Windows.Forms.DateTimePicker();
            this.label21 = new System.Windows.Forms.Label();
            this.PanelProgramacion = new System.Windows.Forms.Panel();
            this.txtDetalle = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.dtpProxFecha = new System.Windows.Forms.DateTimePicker();
            this.dtpUltFecha = new System.Windows.Forms.DateTimePicker();
            this.txtProxKm = new System.Windows.Forms.TextBox();
            this.txtUltKm = new System.Windows.Forms.TextBox();
            this.txtFrecDias = new System.Windows.Forms.TextBox();
            this.txtFrecKms = new System.Windows.Forms.TextBox();
            this.cboActividades = new System.Windows.Forms.ComboBox();
            this.cboGrupos = new System.Windows.Forms.ComboBox();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.txtIde = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.PanelProgramacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnImprimir
            // 
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnImprimir.Image = global::CapaPresentacion.Properties.Resources.WZPRINT;
            this.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImprimir.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnImprimir.Location = new System.Drawing.Point(681, 2);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(74, 28);
            this.btnImprimir.TabIndex = 33;
            this.btnImprimir.Text = "&Imprimir";
            this.btnImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label11.Location = new System.Drawing.Point(8, 5);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(205, 20);
            this.label11.TabIndex = 37;
            this.label11.Text = "Mantenimiento Programado";
            // 
            // btnSalir
            // 
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalir.Image = global::CapaPresentacion.Properties.Resources.bsalir;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSalir.Location = new System.Drawing.Point(761, 2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(74, 28);
            this.btnSalir.TabIndex = 36;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Image = global::CapaPresentacion.Properties.Resources.bcancelar;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(530, 402);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(74, 28);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGrabar
            // 
            this.btnGrabar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGrabar.Image = global::CapaPresentacion.Properties.Resources.bgrabar;
            this.btnGrabar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGrabar.Location = new System.Drawing.Point(430, 402);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(74, 28);
            this.btnGrabar.TabIndex = 11;
            this.btnGrabar.Text = "&Grabar";
            this.btnGrabar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminar.Image = global::CapaPresentacion.Properties.Resources.bborrar;
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnEliminar.Location = new System.Drawing.Point(596, 2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(74, 28);
            this.btnEliminar.TabIndex = 32;
            this.btnEliminar.Text = "&Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnModificar.Image = global::CapaPresentacion.Properties.Resources.beditar;
            this.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnModificar.Location = new System.Drawing.Point(511, 2);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(74, 28);
            this.btnModificar.TabIndex = 31;
            this.btnModificar.Text = "&Modificar";
            this.btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNuevo.Image = global::CapaPresentacion.Properties.Resources.bnuevo;
            this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnNuevo.Location = new System.Drawing.Point(426, 2);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(74, 28);
            this.btnNuevo.TabIndex = 30;
            this.btnNuevo.Text = "&Nuevo";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // dgvListado
            // 
            this.dgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListado.Location = new System.Drawing.Point(2, 36);
            this.dgvListado.Name = "dgvListado";
            this.dgvListado.Size = new System.Drawing.Size(841, 414);
            this.dgvListado.TabIndex = 38;
            this.dgvListado.CurrentCellChanged += new System.EventHandler(this.dgvListado_CurrentCellChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(3, 450);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(842, 40);
            this.panel1.TabIndex = 39;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnBuscarxFechas);
            this.panel3.Controls.Add(this.label22);
            this.panel3.Controls.Add(this.dtpFecIni);
            this.panel3.Controls.Add(this.dtpFecFin);
            this.panel3.Controls.Add(this.label21);
            this.panel3.Location = new System.Drawing.Point(519, 1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(322, 39);
            this.panel3.TabIndex = 34;
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
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(144, 13);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(35, 13);
            this.label22.TabIndex = 19;
            this.label22.Text = "Hasta";
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
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(5, 13);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(41, 13);
            this.label21.TabIndex = 18;
            this.label21.Text = "Desde ";
            // 
            // PanelProgramacion
            // 
            this.PanelProgramacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelProgramacion.Controls.Add(this.txtDetalle);
            this.PanelProgramacion.Controls.Add(this.label15);
            this.PanelProgramacion.Controls.Add(this.lblNombre);
            this.PanelProgramacion.Controls.Add(this.dtpProxFecha);
            this.PanelProgramacion.Controls.Add(this.dtpUltFecha);
            this.PanelProgramacion.Controls.Add(this.txtProxKm);
            this.PanelProgramacion.Controls.Add(this.txtUltKm);
            this.PanelProgramacion.Controls.Add(this.txtFrecDias);
            this.PanelProgramacion.Controls.Add(this.btnCancelar);
            this.PanelProgramacion.Controls.Add(this.txtFrecKms);
            this.PanelProgramacion.Controls.Add(this.btnGrabar);
            this.PanelProgramacion.Controls.Add(this.cboActividades);
            this.PanelProgramacion.Controls.Add(this.cboGrupos);
            this.PanelProgramacion.Controls.Add(this.txtPlaca);
            this.PanelProgramacion.Controls.Add(this.txtIde);
            this.PanelProgramacion.Controls.Add(this.label14);
            this.PanelProgramacion.Controls.Add(this.label13);
            this.PanelProgramacion.Controls.Add(this.label12);
            this.PanelProgramacion.Controls.Add(this.label10);
            this.PanelProgramacion.Controls.Add(this.label9);
            this.PanelProgramacion.Controls.Add(this.label8);
            this.PanelProgramacion.Controls.Add(this.label7);
            this.PanelProgramacion.Controls.Add(this.label6);
            this.PanelProgramacion.Controls.Add(this.label5);
            this.PanelProgramacion.Controls.Add(this.label4);
            this.PanelProgramacion.Controls.Add(this.label3);
            this.PanelProgramacion.Controls.Add(this.label2);
            this.PanelProgramacion.Controls.Add(this.label1);
            this.PanelProgramacion.Location = new System.Drawing.Point(182, 37);
            this.PanelProgramacion.Name = "PanelProgramacion";
            this.PanelProgramacion.Size = new System.Drawing.Size(661, 453);
            this.PanelProgramacion.TabIndex = 40;
            // 
            // txtDetalle
            // 
            this.txtDetalle.Location = new System.Drawing.Point(96, 164);
            this.txtDetalle.Multiline = true;
            this.txtDetalle.Name = "txtDetalle";
            this.txtDetalle.Size = new System.Drawing.Size(507, 95);
            this.txtDetalle.TabIndex = 4;
            this.txtDetalle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDetalle_KeyPress);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(22, 167);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(40, 13);
            this.label15.TabIndex = 36;
            this.label15.Text = "Detalle";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(215, 57);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(0, 13);
            this.lblNombre.TabIndex = 13;
            // 
            // dtpProxFecha
            // 
            this.dtpProxFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpProxFecha.Location = new System.Drawing.Point(287, 355);
            this.dtpProxFecha.Name = "dtpProxFecha";
            this.dtpProxFecha.Size = new System.Drawing.Size(97, 20);
            this.dtpProxFecha.TabIndex = 9;
            this.dtpProxFecha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dtpProxFecha_KeyPress);
            // 
            // dtpUltFecha
            // 
            this.dtpUltFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpUltFecha.Location = new System.Drawing.Point(287, 313);
            this.dtpUltFecha.Name = "dtpUltFecha";
            this.dtpUltFecha.Size = new System.Drawing.Size(97, 20);
            this.dtpUltFecha.TabIndex = 7;
            this.dtpUltFecha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dtpUltFecha_KeyPress);
            this.dtpUltFecha.Validated += new System.EventHandler(this.dtpUltFecha_Validated);
            // 
            // txtProxKm
            // 
            this.txtProxKm.Location = new System.Drawing.Point(507, 359);
            this.txtProxKm.Name = "txtProxKm";
            this.txtProxKm.Size = new System.Drawing.Size(98, 20);
            this.txtProxKm.TabIndex = 10;
            this.txtProxKm.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtProxKm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProxKm_KeyPress);
            // 
            // txtUltKm
            // 
            this.txtUltKm.Location = new System.Drawing.Point(507, 316);
            this.txtUltKm.Name = "txtUltKm";
            this.txtUltKm.Size = new System.Drawing.Size(98, 20);
            this.txtUltKm.TabIndex = 8;
            this.txtUltKm.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtUltKm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUltKm_KeyPress);
            this.txtUltKm.Validated += new System.EventHandler(this.txtUltKm_Validated);
            // 
            // txtFrecDias
            // 
            this.txtFrecDias.Location = new System.Drawing.Point(507, 270);
            this.txtFrecDias.Name = "txtFrecDias";
            this.txtFrecDias.Size = new System.Drawing.Size(98, 20);
            this.txtFrecDias.TabIndex = 6;
            this.txtFrecDias.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtFrecDias.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFrecDias_KeyPress);
            // 
            // txtFrecKms
            // 
            this.txtFrecKms.Location = new System.Drawing.Point(287, 274);
            this.txtFrecKms.Name = "txtFrecKms";
            this.txtFrecKms.Size = new System.Drawing.Size(98, 20);
            this.txtFrecKms.TabIndex = 5;
            this.txtFrecKms.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtFrecKms.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFrecKms_KeyPress);
            // 
            // cboActividades
            // 
            this.cboActividades.FormattingEnabled = true;
            this.cboActividades.Location = new System.Drawing.Point(96, 125);
            this.cboActividades.Name = "cboActividades";
            this.cboActividades.Size = new System.Drawing.Size(508, 21);
            this.cboActividades.TabIndex = 3;
            this.cboActividades.SelectionChangeCommitted += new System.EventHandler(this.cboActividades_SelectionChangeCommitted);
            this.cboActividades.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboActividades_KeyPress);
            // 
            // cboGrupos
            // 
            this.cboGrupos.FormattingEnabled = true;
            this.cboGrupos.Location = new System.Drawing.Point(96, 88);
            this.cboGrupos.Name = "cboGrupos";
            this.cboGrupos.Size = new System.Drawing.Size(508, 21);
            this.cboGrupos.TabIndex = 2;
            this.cboGrupos.SelectionChangeCommitted += new System.EventHandler(this.cboGrupos_SelectionChangeCommitted);
            this.cboGrupos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboGrupos_KeyPress);
            // 
            // txtPlaca
            // 
            this.txtPlaca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPlaca.Location = new System.Drawing.Point(96, 54);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(98, 20);
            this.txtPlaca.TabIndex = 1;
            this.txtPlaca.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPlaca_KeyDown);
            this.txtPlaca.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPlaca_KeyPress);
            this.txtPlaca.Validated += new System.EventHandler(this.txtPlaca_Validated);
            // 
            // txtIde
            // 
            this.txtIde.Location = new System.Drawing.Point(96, 20);
            this.txtIde.Name = "txtIde";
            this.txtIde.Size = new System.Drawing.Size(42, 20);
            this.txtIde.TabIndex = 0;
            this.txtIde.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(437, 359);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(58, 13);
            this.label14.TabIndex = 12;
            this.label14.Text = "Kilometraje";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(211, 359);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(37, 13);
            this.label13.TabIndex = 11;
            this.label13.Text = "Fecha";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(21, 355);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(116, 13);
            this.label12.TabIndex = 10;
            this.label12.Text = "Proximo Mantenimiento";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(437, 316);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Kilometraje";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(211, 316);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Fecha";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 316);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Ultimo Mantenimiento";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(447, 277);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Dias";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(211, 277);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Kilometros";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 278);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Frecuencia de la Actividad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Actividad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Grupo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Placa";
            // 
            // frmMantenimiento_Programado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 493);
            this.Controls.Add(this.PanelProgramacion);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvListado);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnNuevo);
            this.Name = "frmMantenimiento_Programado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento Programado";
            this.Load += new System.EventHandler(this.frmMantenimiento_Programado_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmMantenimiento_Programado_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.PanelProgramacion.ResumeLayout(false);
            this.PanelProgramacion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.DataGridView dgvListado;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel PanelProgramacion;
        private System.Windows.Forms.DateTimePicker dtpProxFecha;
        private System.Windows.Forms.DateTimePicker dtpUltFecha;
        private System.Windows.Forms.TextBox txtProxKm;
        private System.Windows.Forms.TextBox txtUltKm;
        private System.Windows.Forms.TextBox txtFrecDias;
        private System.Windows.Forms.TextBox txtFrecKms;
        private System.Windows.Forms.ComboBox cboActividades;
        private System.Windows.Forms.ComboBox cboGrupos;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.TextBox txtIde;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnBuscarxFechas;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.DateTimePicker dtpFecIni;
        private System.Windows.Forms.DateTimePicker dtpFecFin;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtDetalle;
        private System.Windows.Forms.Label label15;
    }
}