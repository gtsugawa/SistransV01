namespace CapaPresentacion.Tablas
{
    partial class frmCombustible_Importe
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
            this.txtVeces = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.txtImporte = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboTipoCombustible = new System.Windows.Forms.ComboBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.txtIde = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvListado = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.txtProvIde = new System.Windows.Forms.TextBox();
            this.txtProveedor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboMeses = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cboaños = new System.Windows.Forms.ComboBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnBuscartxt = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnModifica = new System.Windows.Forms.Button();
            this.btnCancela = new System.Windows.Forms.Button();
            this.btnElimina = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnGraba = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).BeginInit();
            this.SuspendLayout();
            // 
            // txtVeces
            // 
            this.txtVeces.Location = new System.Drawing.Point(600, 5);
            this.txtVeces.Name = "txtVeces";
            this.txtVeces.Size = new System.Drawing.Size(65, 23);
            this.txtVeces.TabIndex = 37;
            this.txtVeces.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(271, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 28;
            this.label3.Text = "Fecha";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtImporte);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cboTipoCombustible);
            this.panel1.Controls.Add(this.dtpFecha);
            this.panel1.Controls.Add(this.txtVeces);
            this.panel1.Controls.Add(this.txtIde);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 437);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(678, 62);
            this.panel1.TabIndex = 72;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(477, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 17);
            this.label5.TabIndex = 43;
            this.label5.Text = "Importe";
            // 
            // txtImporte
            // 
            this.txtImporte.Location = new System.Drawing.Point(541, 33);
            this.txtImporte.MaxLength = 16;
            this.txtImporte.Name = "txtImporte";
            this.txtImporte.Size = new System.Drawing.Size(121, 23);
            this.txtImporte.TabIndex = 3;
            this.txtImporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 17);
            this.label4.TabIndex = 41;
            this.label4.Text = "Tipo Combustible";
            // 
            // cboTipoCombustible
            // 
            this.cboTipoCombustible.FormattingEnabled = true;
            this.cboTipoCombustible.Location = new System.Drawing.Point(134, 31);
            this.cboTipoCombustible.Name = "cboTipoCombustible";
            this.cboTipoCombustible.Size = new System.Drawing.Size(121, 24);
            this.cboTipoCombustible.TabIndex = 1;
            this.cboTipoCombustible.SelectedIndexChanged += new System.EventHandler(this.cboTipoCombustible_SelectedIndexChanged);
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(334, 31);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(116, 23);
            this.dtpFecha.TabIndex = 2;
            // 
            // txtIde
            // 
            this.txtIde.Location = new System.Drawing.Point(76, 4);
            this.txtIde.Name = "txtIde";
            this.txtIde.Size = new System.Drawing.Size(80, 23);
            this.txtIde.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 17);
            this.label1.TabIndex = 26;
            this.label1.Text = "ID";
            // 
            // dgvListado
            // 
            this.dgvListado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListado.Location = new System.Drawing.Point(0, 60);
            this.dgvListado.Name = "dgvListado";
            this.dgvListado.Size = new System.Drawing.Size(678, 374);
            this.dgvListado.TabIndex = 71;
            this.dgvListado.CurrentCellChanged += new System.EventHandler(this.dgvListado_CurrentCellChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 17);
            this.label6.TabIndex = 73;
            this.label6.Text = "Proveedor ";
            // 
            // txtProvIde
            // 
            this.txtProvIde.Enabled = false;
            this.txtProvIde.Location = new System.Drawing.Point(87, 3);
            this.txtProvIde.Name = "txtProvIde";
            this.txtProvIde.Size = new System.Drawing.Size(71, 23);
            this.txtProvIde.TabIndex = 74;
            this.txtProvIde.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProvIde_KeyPress);
            // 
            // txtProveedor
            // 
            this.txtProveedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtProveedor.Location = new System.Drawing.Point(162, 3);
            this.txtProveedor.Name = "txtProveedor";
            this.txtProveedor.Size = new System.Drawing.Size(509, 23);
            this.txtProveedor.TabIndex = 0;
            this.txtProveedor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtProveedor_KeyDown);
            this.txtProveedor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProveedor_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 76;
            this.label2.Text = "Mes ";
            // 
            // cboMeses
            // 
            this.cboMeses.FormattingEnabled = true;
            this.cboMeses.Location = new System.Drawing.Point(87, 31);
            this.cboMeses.Name = "cboMeses";
            this.cboMeses.Size = new System.Drawing.Size(157, 24);
            this.cboMeses.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(254, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 17);
            this.label7.TabIndex = 78;
            this.label7.Text = "Año ";
            // 
            // cboaños
            // 
            this.cboaños.FormattingEnabled = true;
            this.cboaños.Location = new System.Drawing.Point(299, 30);
            this.cboaños.Name = "cboaños";
            this.cboaños.Size = new System.Drawing.Size(106, 24);
            this.cboaños.TabIndex = 2;
            this.cboaños.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboaños_KeyPress);
            this.cboaños.Validated += new System.EventHandler(this.cboaños_Validated);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Image = global::CapaPresentacion.Properties.Resources.bnuevo1;
            this.btnLimpiar.Location = new System.Drawing.Point(416, 30);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(76, 27);
            this.btnLimpiar.TabIndex = 3;
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnBuscartxt
            // 
            this.btnBuscartxt.Image = global::CapaPresentacion.Properties.Resources.Buscar_p;
            this.btnBuscartxt.Location = new System.Drawing.Point(505, 29);
            this.btnBuscartxt.Name = "btnBuscartxt";
            this.btnBuscartxt.Size = new System.Drawing.Size(76, 27);
            this.btnBuscartxt.TabIndex = 4;
            this.btnBuscartxt.UseVisualStyleBackColor = true;
            this.btnBuscartxt.Click += new System.EventHandler(this.btnBuscartxt_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNuevo.Image = global::CapaPresentacion.Properties.Resources.bnuevo;
            this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNuevo.Location = new System.Drawing.Point(209, 502);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(72, 42);
            this.btnNuevo.TabIndex = 0;
            this.btnNuevo.Text = "&Nuevo";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnModifica
            // 
            this.btnModifica.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModifica.Image = global::CapaPresentacion.Properties.Resources.beditar;
            this.btnModifica.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnModifica.Location = new System.Drawing.Point(288, 502);
            this.btnModifica.Name = "btnModifica";
            this.btnModifica.Size = new System.Drawing.Size(72, 42);
            this.btnModifica.TabIndex = 1;
            this.btnModifica.Text = "&Modifica";
            this.btnModifica.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnModifica.UseVisualStyleBackColor = true;
            this.btnModifica.Click += new System.EventHandler(this.btnModifica_Click);
            // 
            // btnCancela
            // 
            this.btnCancela.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancela.Image = global::CapaPresentacion.Properties.Resources.bcancelar;
            this.btnCancela.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancela.Location = new System.Drawing.Point(523, 502);
            this.btnCancela.Name = "btnCancela";
            this.btnCancela.Size = new System.Drawing.Size(72, 42);
            this.btnCancela.TabIndex = 4;
            this.btnCancela.Text = "&Cancelar";
            this.btnCancela.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancela.UseVisualStyleBackColor = true;
            this.btnCancela.Click += new System.EventHandler(this.btnCancela_Click);
            // 
            // btnElimina
            // 
            this.btnElimina.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnElimina.Image = global::CapaPresentacion.Properties.Resources.bborrar;
            this.btnElimina.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnElimina.Location = new System.Drawing.Point(367, 502);
            this.btnElimina.Name = "btnElimina";
            this.btnElimina.Size = new System.Drawing.Size(72, 42);
            this.btnElimina.TabIndex = 2;
            this.btnElimina.Text = "&Elimina";
            this.btnElimina.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnElimina.UseVisualStyleBackColor = true;
            this.btnElimina.Click += new System.EventHandler(this.btnElimina_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.Image = global::CapaPresentacion.Properties.Resources.bsalir;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSalir.Location = new System.Drawing.Point(604, 502);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(72, 42);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnGraba
            // 
            this.btnGraba.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGraba.Image = global::CapaPresentacion.Properties.Resources.bgrabar;
            this.btnGraba.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGraba.Location = new System.Drawing.Point(445, 502);
            this.btnGraba.Name = "btnGraba";
            this.btnGraba.Size = new System.Drawing.Size(72, 42);
            this.btnGraba.TabIndex = 3;
            this.btnGraba.Text = "&Grabar";
            this.btnGraba.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGraba.UseVisualStyleBackColor = true;
            this.btnGraba.Click += new System.EventHandler(this.btnGraba_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Image = global::CapaPresentacion.Properties.Resources.bsalir;
            this.button1.Location = new System.Drawing.Point(594, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 27);
            this.button1.TabIndex = 5;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmCombustible_Importe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 545);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.cboaños);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cboMeses);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtProveedor);
            this.Controls.Add(this.btnBuscartxt);
            this.Controls.Add(this.txtProvIde);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnModifica);
            this.Controls.Add(this.btnCancela);
            this.Controls.Add(this.btnElimina);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnGraba);
            this.Controls.Add(this.dgvListado);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCombustible_Importe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Combustible Importe";
            this.Load += new System.EventHandler(this.frmCombustible_Importe_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnModifica;
        private System.Windows.Forms.Button btnCancela;
        private System.Windows.Forms.Button btnElimina;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox txtVeces;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtIde;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGraba;
        private System.Windows.Forms.DataGridView dgvListado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtImporte;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboTipoCombustible;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtProvIde;
        private System.Windows.Forms.Button btnBuscartxt;
        private System.Windows.Forms.TextBox txtProveedor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboMeses;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboaños;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button button1;
    }
}