namespace CapaPresentacion.Tablas
{
    partial class frmSerie_Facturacion
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
            this.btnCancela = new System.Windows.Forms.Button();
            this.btnElimina = new System.Windows.Forms.Button();
            this.btnModifica = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnGraba = new System.Windows.Forms.Button();
            this.dgvListado = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtATLineas = new System.Windows.Forms.TextBox();
            this.txtATContador = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtBLLineas = new System.Windows.Forms.TextBox();
            this.txtBLContador = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtNCLineas = new System.Windows.Forms.TextBox();
            this.txtNCContador = new System.Windows.Forms.TextBox();
            this.txtSerie = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtNDLineas = new System.Windows.Forms.TextBox();
            this.txtNDContador = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtFCLineas = new System.Windows.Forms.TextBox();
            this.txtFCContador = new System.Windows.Forms.TextBox();
            this.txtTiendaID = new System.Windows.Forms.TextBox();
            this.cboTienda = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTerminal = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtVeces = new System.Windows.Forms.TextBox();
            this.txtLugar = new System.Windows.Forms.TextBox();
            this.cboEstado = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancela
            // 
            this.btnCancela.Image = global::CapaPresentacion.Properties.Resources.bcancelar;
            this.btnCancela.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancela.Location = new System.Drawing.Point(550, 483);
            this.btnCancela.Name = "btnCancela";
            this.btnCancela.Size = new System.Drawing.Size(72, 42);
            this.btnCancela.TabIndex = 3;
            this.btnCancela.Text = "&Cancelar";
            this.btnCancela.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancela.UseVisualStyleBackColor = true;
            this.btnCancela.Click += new System.EventHandler(this.btnCancela_Click);
            // 
            // btnElimina
            // 
            this.btnElimina.Image = global::CapaPresentacion.Properties.Resources.bborrar;
            this.btnElimina.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnElimina.Location = new System.Drawing.Point(392, 483);
            this.btnElimina.Name = "btnElimina";
            this.btnElimina.Size = new System.Drawing.Size(72, 42);
            this.btnElimina.TabIndex = 2;
            this.btnElimina.Text = "&Elimina";
            this.btnElimina.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnElimina.UseVisualStyleBackColor = true;
            this.btnElimina.Click += new System.EventHandler(this.btnElimina_Click);
            // 
            // btnModifica
            // 
            this.btnModifica.Image = global::CapaPresentacion.Properties.Resources.beditar;
            this.btnModifica.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnModifica.Location = new System.Drawing.Point(313, 483);
            this.btnModifica.Name = "btnModifica";
            this.btnModifica.Size = new System.Drawing.Size(72, 42);
            this.btnModifica.TabIndex = 1;
            this.btnModifica.Text = "&Modifica";
            this.btnModifica.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnModifica.UseVisualStyleBackColor = true;
            this.btnModifica.Click += new System.EventHandler(this.btnModifica_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Image = global::CapaPresentacion.Properties.Resources.bnuevo;
            this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNuevo.Location = new System.Drawing.Point(234, 483);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(72, 42);
            this.btnNuevo.TabIndex = 0;
            this.btnNuevo.Text = "&Nuevo";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Image = global::CapaPresentacion.Properties.Resources.bsalir;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSalir.Location = new System.Drawing.Point(629, 483);
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
            this.btnGraba.Image = global::CapaPresentacion.Properties.Resources.bgrabar;
            this.btnGraba.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGraba.Location = new System.Drawing.Point(469, 483);
            this.btnGraba.Name = "btnGraba";
            this.btnGraba.Size = new System.Drawing.Size(72, 42);
            this.btnGraba.TabIndex = 4;
            this.btnGraba.Text = "&Grabar";
            this.btnGraba.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGraba.UseVisualStyleBackColor = true;
            this.btnGraba.Click += new System.EventHandler(this.btnGraba_Click);
            // 
            // dgvListado
            // 
            this.dgvListado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListado.Location = new System.Drawing.Point(1, 1);
            this.dgvListado.Margin = new System.Windows.Forms.Padding(4);
            this.dgvListado.MultiSelect = false;
            this.dgvListado.Name = "dgvListado";
            this.dgvListado.Size = new System.Drawing.Size(703, 268);
            this.dgvListado.TabIndex = 77;
            this.dgvListado.CurrentCellChanged += new System.EventHandler(this.dgvListado_CurrentCellChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.groupBox5);
            this.panel2.Controls.Add(this.groupBox4);
            this.panel2.Controls.Add(this.groupBox3);
            this.panel2.Controls.Add(this.txtSerie);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.txtTiendaID);
            this.panel2.Controls.Add(this.cboTienda);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txtTerminal);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.txtVeces);
            this.panel2.Controls.Add(this.txtLugar);
            this.panel2.Controls.Add(this.cboEstado);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label13);
            this.panel2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.panel2.Location = new System.Drawing.Point(1, 270);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(705, 207);
            this.panel2.TabIndex = 78;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtATLineas);
            this.groupBox5.Controls.Add(this.txtATContador);
            this.groupBox5.Location = new System.Drawing.Point(584, 39);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(109, 77);
            this.groupBox5.TabIndex = 43;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "  Atribucion";
            // 
            // txtATLineas
            // 
            this.txtATLineas.Location = new System.Drawing.Point(10, 49);
            this.txtATLineas.Name = "txtATLineas";
            this.txtATLineas.Size = new System.Drawing.Size(89, 23);
            this.txtATLineas.TabIndex = 1;
            // 
            // txtATContador
            // 
            this.txtATContador.Location = new System.Drawing.Point(11, 20);
            this.txtATContador.Name = "txtATContador";
            this.txtATContador.Size = new System.Drawing.Size(89, 23);
            this.txtATContador.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtBLLineas);
            this.groupBox4.Controls.Add(this.txtBLContador);
            this.groupBox4.Location = new System.Drawing.Point(458, 39);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(120, 77);
            this.groupBox4.TabIndex = 42;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "     Boleta";
            // 
            // txtBLLineas
            // 
            this.txtBLLineas.Location = new System.Drawing.Point(9, 49);
            this.txtBLLineas.Name = "txtBLLineas";
            this.txtBLLineas.Size = new System.Drawing.Size(89, 23);
            this.txtBLLineas.TabIndex = 1;
            // 
            // txtBLContador
            // 
            this.txtBLContador.Location = new System.Drawing.Point(8, 20);
            this.txtBLContador.Name = "txtBLContador";
            this.txtBLContador.Size = new System.Drawing.Size(89, 23);
            this.txtBLContador.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtNCLineas);
            this.groupBox3.Controls.Add(this.txtNCContador);
            this.groupBox3.Location = new System.Drawing.Point(328, 39);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(122, 78);
            this.groupBox3.TabIndex = 41;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "  Nota Credito";
            // 
            // txtNCLineas
            // 
            this.txtNCLineas.Location = new System.Drawing.Point(12, 49);
            this.txtNCLineas.Name = "txtNCLineas";
            this.txtNCLineas.Size = new System.Drawing.Size(89, 23);
            this.txtNCLineas.TabIndex = 1;
            // 
            // txtNCContador
            // 
            this.txtNCContador.Location = new System.Drawing.Point(12, 20);
            this.txtNCContador.Name = "txtNCContador";
            this.txtNCContador.Size = new System.Drawing.Size(89, 23);
            this.txtNCContador.TabIndex = 0;
            // 
            // txtSerie
            // 
            this.txtSerie.Location = new System.Drawing.Point(97, 7);
            this.txtSerie.Name = "txtSerie";
            this.txtSerie.Size = new System.Drawing.Size(90, 23);
            this.txtSerie.TabIndex = 0;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 90);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(70, 17);
            this.label14.TabIndex = 39;
            this.label14.Text = "N° Lineas";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 65);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 17);
            this.label10.TabIndex = 38;
            this.label10.Text = "Contador";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 9);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 17);
            this.label9.TabIndex = 37;
            this.label9.Text = "Serie";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtNDLineas);
            this.groupBox2.Controls.Add(this.txtNDContador);
            this.groupBox2.Location = new System.Drawing.Point(209, 39);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(110, 78);
            this.groupBox2.TabIndex = 36;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "   Nota Debito";
            // 
            // txtNDLineas
            // 
            this.txtNDLineas.Location = new System.Drawing.Point(12, 49);
            this.txtNDLineas.Margin = new System.Windows.Forms.Padding(4);
            this.txtNDLineas.Name = "txtNDLineas";
            this.txtNDLineas.Size = new System.Drawing.Size(89, 23);
            this.txtNDLineas.TabIndex = 1;
            // 
            // txtNDContador
            // 
            this.txtNDContador.Location = new System.Drawing.Point(12, 20);
            this.txtNDContador.Margin = new System.Windows.Forms.Padding(4);
            this.txtNDContador.Name = "txtNDContador";
            this.txtNDContador.Size = new System.Drawing.Size(89, 23);
            this.txtNDContador.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtFCLineas);
            this.groupBox1.Controls.Add(this.txtFCContador);
            this.groupBox1.Location = new System.Drawing.Point(86, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(112, 78);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "     Factura";
            // 
            // txtFCLineas
            // 
            this.txtFCLineas.Location = new System.Drawing.Point(10, 49);
            this.txtFCLineas.Margin = new System.Windows.Forms.Padding(4);
            this.txtFCLineas.Name = "txtFCLineas";
            this.txtFCLineas.Size = new System.Drawing.Size(89, 23);
            this.txtFCLineas.TabIndex = 1;
            // 
            // txtFCContador
            // 
            this.txtFCContador.Location = new System.Drawing.Point(10, 20);
            this.txtFCContador.Margin = new System.Windows.Forms.Padding(4);
            this.txtFCContador.Name = "txtFCContador";
            this.txtFCContador.Size = new System.Drawing.Size(89, 23);
            this.txtFCContador.TabIndex = 0;
            // 
            // txtTiendaID
            // 
            this.txtTiendaID.Location = new System.Drawing.Point(245, 176);
            this.txtTiendaID.Margin = new System.Windows.Forms.Padding(4);
            this.txtTiendaID.Name = "txtTiendaID";
            this.txtTiendaID.Size = new System.Drawing.Size(54, 23);
            this.txtTiendaID.TabIndex = 30;
            // 
            // cboTienda
            // 
            this.cboTienda.FormattingEnabled = true;
            this.cboTienda.Location = new System.Drawing.Point(97, 176);
            this.cboTienda.Margin = new System.Windows.Forms.Padding(4);
            this.cboTienda.Name = "cboTienda";
            this.cboTienda.Size = new System.Drawing.Size(139, 24);
            this.cboTienda.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 181);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 17);
            this.label7.TabIndex = 28;
            this.label7.Text = "Tienda";
            // 
            // txtTerminal
            // 
            this.txtTerminal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTerminal.Location = new System.Drawing.Point(97, 150);
            this.txtTerminal.Margin = new System.Windows.Forms.Padding(4);
            this.txtTerminal.MaxLength = 40;
            this.txtTerminal.Name = "txtTerminal";
            this.txtTerminal.Size = new System.Drawing.Size(415, 23);
            this.txtTerminal.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 154);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 17);
            this.label11.TabIndex = 16;
            this.label11.Text = "Terminal";
            // 
            // txtVeces
            // 
            this.txtVeces.Location = new System.Drawing.Point(455, 175);
            this.txtVeces.Margin = new System.Windows.Forms.Padding(4);
            this.txtVeces.Name = "txtVeces";
            this.txtVeces.Size = new System.Drawing.Size(45, 23);
            this.txtVeces.TabIndex = 15;
            this.txtVeces.Visible = false;
            // 
            // txtLugar
            // 
            this.txtLugar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtLugar.Location = new System.Drawing.Point(97, 125);
            this.txtLugar.Margin = new System.Windows.Forms.Padding(4);
            this.txtLugar.MaxLength = 40;
            this.txtLugar.Name = "txtLugar";
            this.txtLugar.Size = new System.Drawing.Size(415, 23);
            this.txtLugar.TabIndex = 2;
            // 
            // cboEstado
            // 
            this.cboEstado.FormattingEnabled = true;
            this.cboEstado.Location = new System.Drawing.Point(566, 4);
            this.cboEstado.Margin = new System.Windows.Forms.Padding(4);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(115, 24);
            this.cboEstado.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 129);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(45, 17);
            this.label12.TabIndex = 4;
            this.label12.Text = "Lugar";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(499, 6);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 17);
            this.label13.TabIndex = 3;
            this.label13.Text = "Estado";
            // 
            // frmSerie_Facturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 529);
            this.Controls.Add(this.btnCancela);
            this.Controls.Add(this.btnElimina);
            this.Controls.Add(this.btnModifica);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnGraba);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgvListado);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSerie_Facturacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Serie Facturacion";
            this.Load += new System.EventHandler(this.frmSerie_Facturacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancela;
        private System.Windows.Forms.Button btnElimina;
        private System.Windows.Forms.Button btnModifica;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnGraba;
        private System.Windows.Forms.DataGridView dgvListado;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtATLineas;
        private System.Windows.Forms.TextBox txtATContador;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtBLLineas;
        private System.Windows.Forms.TextBox txtBLContador;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtNCLineas;
        private System.Windows.Forms.TextBox txtNCContador;
        private System.Windows.Forms.TextBox txtSerie;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtNDLineas;
        private System.Windows.Forms.TextBox txtNDContador;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtFCLineas;
        private System.Windows.Forms.TextBox txtFCContador;
        private System.Windows.Forms.TextBox txtTiendaID;
        private System.Windows.Forms.ComboBox cboTienda;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTerminal;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtVeces;
        private System.Windows.Forms.TextBox txtLugar;
        private System.Windows.Forms.ComboBox cboEstado;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
    }
}