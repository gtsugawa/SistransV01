namespace CapaPresentacion.Mantenimiento
{
    partial class frmConsumo_Productos
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
            this.dgvListado = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBuscarxFechas = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.dtpFecIni = new System.Windows.Forms.DateTimePicker();
            this.dtpFecFin = new System.Windows.Forms.DateTimePicker();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblNombre = new System.Windows.Forms.Label();
            this.dgvDetalle = new System.Windows.Forms.DataGridView();
            this.txtDisponible = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtComp_Detalle_Ide = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.dtpFecConsumo = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCantidad_Consumo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUnidad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvListado
            // 
            this.dgvListado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListado.Location = new System.Drawing.Point(-1, 43);
            this.dgvListado.Name = "dgvListado";
            this.dgvListado.Size = new System.Drawing.Size(890, 471);
            this.dgvListado.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnBuscarxFechas);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.dtpFecIni);
            this.panel1.Controls.Add(this.dtpFecFin);
            this.panel1.Location = new System.Drawing.Point(4, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(322, 39);
            this.panel1.TabIndex = 34;
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
            // btnImprimir
            // 
            this.btnImprimir.Image = global::CapaPresentacion.Properties.Resources.WZPRINT;
            this.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImprimir.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnImprimir.Location = new System.Drawing.Point(730, 5);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(74, 28);
            this.btnImprimir.TabIndex = 40;
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
            this.btnSalir.Location = new System.Drawing.Point(812, 5);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(74, 28);
            this.btnSalir.TabIndex = 38;
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
            this.btnEliminar.Location = new System.Drawing.Point(645, 5);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(74, 28);
            this.btnEliminar.TabIndex = 37;
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
            this.btnModificar.Location = new System.Drawing.Point(560, 5);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(74, 28);
            this.btnModificar.TabIndex = 36;
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
            this.btnNuevo.Location = new System.Drawing.Point(475, 5);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(74, 28);
            this.btnNuevo.TabIndex = 35;
            this.btnNuevo.Text = "&Nuevo";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblNombre);
            this.panel2.Controls.Add(this.dgvDetalle);
            this.panel2.Location = new System.Drawing.Point(-1, 43);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(890, 362);
            this.panel2.TabIndex = 41;
            this.panel2.Visible = false;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(404, 358);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(0, 13);
            this.lblNombre.TabIndex = 14;
            // 
            // dgvDetalle
            // 
            this.dgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalle.Location = new System.Drawing.Point(6, 8);
            this.dgvDetalle.Name = "dgvDetalle";
            this.dgvDetalle.Size = new System.Drawing.Size(876, 350);
            this.dgvDetalle.TabIndex = 0;
            this.dgvDetalle.CurrentCellChanged += new System.EventHandler(this.dgvDetalle_CurrentCellChanged);
            this.dgvDetalle.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvDetalle_EditingControlShowing);
            this.dgvDetalle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dgvDetalle_KeyPress);
            // 
            // txtDisponible
            // 
            this.txtDisponible.Location = new System.Drawing.Point(99, 46);
            this.txtDisponible.Name = "txtDisponible";
            this.txtDisponible.ReadOnly = true;
            this.txtDisponible.Size = new System.Drawing.Size(98, 20);
            this.txtDisponible.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Disponible";
            // 
            // txtComp_Detalle_Ide
            // 
            this.txtComp_Detalle_Ide.Location = new System.Drawing.Point(12, 79);
            this.txtComp_Detalle_Ide.Name = "txtComp_Detalle_Ide";
            this.txtComp_Detalle_Ide.Size = new System.Drawing.Size(59, 20);
            this.txtComp_Detalle_Ide.TabIndex = 3;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = global::CapaPresentacion.Properties.Resources.bcancelar;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(408, 73);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(74, 28);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Image = global::CapaPresentacion.Properties.Resources.bgrabar;
            this.btnGrabar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGrabar.Location = new System.Drawing.Point(301, 73);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(74, 28);
            this.btnGrabar.TabIndex = 7;
            this.btnGrabar.Text = "&Grabar";
            this.btnGrabar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // dtpFecConsumo
            // 
            this.dtpFecConsumo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecConsumo.Location = new System.Drawing.Point(99, 10);
            this.dtpFecConsumo.Name = "dtpFecConsumo";
            this.dtpFecConsumo.Size = new System.Drawing.Size(98, 20);
            this.dtpFecConsumo.TabIndex = 0;
            this.dtpFecConsumo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dtpFecConsumo_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Fecha Consumo";
            // 
            // txtCantidad_Consumo
            // 
            this.txtCantidad_Consumo.Location = new System.Drawing.Point(788, 42);
            this.txtCantidad_Consumo.Name = "txtCantidad_Consumo";
            this.txtCantidad_Consumo.Size = new System.Drawing.Size(75, 20);
            this.txtCantidad_Consumo.TabIndex = 6;
            this.txtCantidad_Consumo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCantidad_Consumo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_Consumo_KeyPress);
            this.txtCantidad_Consumo.Validating += new System.ComponentModel.CancelEventHandler(this.txtCantidad_Consumo_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(726, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Consumo";
            // 
            // txtUnidad
            // 
            this.txtUnidad.Location = new System.Drawing.Point(595, 41);
            this.txtUnidad.Name = "txtUnidad";
            this.txtUnidad.ReadOnly = true;
            this.txtUnidad.Size = new System.Drawing.Size(100, 20);
            this.txtUnidad.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(548, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Unidad";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(468, 10);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.ReadOnly = true;
            this.txtDescripcion.Size = new System.Drawing.Size(364, 20);
            this.txtDescripcion.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(401, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Descripcion";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(274, 12);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 1;
            this.txtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigo_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(229, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Codigo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(229, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Placa";
            // 
            // txtPlaca
            // 
            this.txtPlaca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPlaca.Location = new System.Drawing.Point(274, 41);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(100, 20);
            this.txtPlaca.TabIndex = 4;
            this.txtPlaca.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPlaca_KeyDown);
            this.txtPlaca.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPlaca_KeyPress);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.txtPlaca);
            this.panel3.Controls.Add(this.txtCodigo);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.txtDisponible);
            this.panel3.Controls.Add(this.txtDescripcion);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.txtComp_Detalle_Ide);
            this.panel3.Controls.Add(this.txtUnidad);
            this.panel3.Controls.Add(this.btnCancelar);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.btnGrabar);
            this.panel3.Controls.Add(this.txtCantidad_Consumo);
            this.panel3.Controls.Add(this.dtpFecConsumo);
            this.panel3.Location = new System.Drawing.Point(0, 402);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(890, 112);
            this.panel3.TabIndex = 15;
            this.panel3.Visible = false;
            // 
            // frmConsumo_Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 516);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvListado);
            this.Name = "frmConsumo_Productos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmConsumo_Productos";
            this.Load += new System.EventHandler(this.frmConsumo_Productos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListado;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBuscarxFechas;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dtpFecIni;
        private System.Windows.Forms.DateTimePicker dtpFecFin;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvDetalle;
        private System.Windows.Forms.DateTimePicker dtpFecConsumo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCantidad_Consumo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUnidad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.TextBox txtComp_Detalle_Ide;
        private System.Windows.Forms.TextBox txtDisponible;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel3;
    }
}