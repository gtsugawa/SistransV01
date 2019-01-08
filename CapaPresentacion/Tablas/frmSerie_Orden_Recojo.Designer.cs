namespace CapaPresentacion
{
    partial class frmSerie_Orden_Recojo
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtTiendaIde = new System.Windows.Forms.TextBox();
            this.cboTienda = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTerminal = new System.Windows.Forms.TextBox();
            this.txtNroLineas = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtContador = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtVeces = new System.Windows.Forms.TextBox();
            this.txtSerie = new System.Windows.Forms.TextBox();
            this.txtLugar = new System.Windows.Forms.TextBox();
            this.cboEstado = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvListado = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancela
            // 
            this.btnCancela.Image = global::CapaPresentacion.Properties.Resources.bcancelar;
            this.btnCancela.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancela.Location = new System.Drawing.Point(355, 480);
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
            this.btnElimina.Image = global::CapaPresentacion.Properties.Resources.bborrar;
            this.btnElimina.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnElimina.Location = new System.Drawing.Point(197, 480);
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
            this.btnModifica.Location = new System.Drawing.Point(118, 480);
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
            this.btnNuevo.Location = new System.Drawing.Point(39, 480);
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
            this.btnSalir.Location = new System.Drawing.Point(434, 480);
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
            this.btnGraba.Location = new System.Drawing.Point(277, 480);
            this.btnGraba.Name = "btnGraba";
            this.btnGraba.Size = new System.Drawing.Size(72, 42);
            this.btnGraba.TabIndex = 3;
            this.btnGraba.Text = "&Grabar";
            this.btnGraba.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGraba.UseVisualStyleBackColor = true;
            this.btnGraba.Click += new System.EventHandler(this.btnGraba_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtTiendaIde);
            this.panel1.Controls.Add(this.cboTienda);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtTerminal);
            this.panel1.Controls.Add(this.txtNroLineas);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtContador);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtVeces);
            this.panel1.Controls.Add(this.txtSerie);
            this.panel1.Controls.Add(this.txtLugar);
            this.panel1.Controls.Add(this.cboEstado);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.panel1.Location = new System.Drawing.Point(1, 340);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(511, 135);
            this.panel1.TabIndex = 78;
            // 
            // txtTiendaIde
            // 
            this.txtTiendaIde.Location = new System.Drawing.Point(228, 104);
            this.txtTiendaIde.Margin = new System.Windows.Forms.Padding(4);
            this.txtTiendaIde.Name = "txtTiendaIde";
            this.txtTiendaIde.Size = new System.Drawing.Size(54, 23);
            this.txtTiendaIde.TabIndex = 7;
            // 
            // cboTienda
            // 
            this.cboTienda.FormattingEnabled = true;
            this.cboTienda.Location = new System.Drawing.Point(86, 104);
            this.cboTienda.Margin = new System.Windows.Forms.Padding(4);
            this.cboTienda.Name = "cboTienda";
            this.cboTienda.Size = new System.Drawing.Size(139, 24);
            this.cboTienda.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 109);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 17);
            this.label6.TabIndex = 28;
            this.label6.Text = "Tienda";
            // 
            // txtTerminal
            // 
            this.txtTerminal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTerminal.Location = new System.Drawing.Point(86, 78);
            this.txtTerminal.Margin = new System.Windows.Forms.Padding(4);
            this.txtTerminal.MaxLength = 40;
            this.txtTerminal.Name = "txtTerminal";
            this.txtTerminal.Size = new System.Drawing.Size(415, 23);
            this.txtTerminal.TabIndex = 5;
            // 
            // txtNroLineas
            // 
            this.txtNroLineas.Location = new System.Drawing.Point(86, 28);
            this.txtNroLineas.Margin = new System.Windows.Forms.Padding(4);
            this.txtNroLineas.Name = "txtNroLineas";
            this.txtNroLineas.Size = new System.Drawing.Size(89, 23);
            this.txtNroLineas.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 31);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 17);
            this.label4.TabIndex = 25;
            this.label4.Text = "Nro.Lineas";
            // 
            // txtContador
            // 
            this.txtContador.Location = new System.Drawing.Point(247, 3);
            this.txtContador.Margin = new System.Windows.Forms.Padding(4);
            this.txtContador.Name = "txtContador";
            this.txtContador.Size = new System.Drawing.Size(73, 23);
            this.txtContador.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(180, 7);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 17);
            this.label8.TabIndex = 23;
            this.label8.Text = "Contador ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 82);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "Terminal";
            // 
            // txtVeces
            // 
            this.txtVeces.Location = new System.Drawing.Point(455, 103);
            this.txtVeces.Margin = new System.Windows.Forms.Padding(4);
            this.txtVeces.Name = "txtVeces";
            this.txtVeces.Size = new System.Drawing.Size(45, 23);
            this.txtVeces.TabIndex = 15;
            this.txtVeces.Visible = false;
            // 
            // txtSerie
            // 
            this.txtSerie.Location = new System.Drawing.Point(86, 3);
            this.txtSerie.Margin = new System.Windows.Forms.Padding(4);
            this.txtSerie.Name = "txtSerie";
            this.txtSerie.Size = new System.Drawing.Size(89, 23);
            this.txtSerie.TabIndex = 0;
            // 
            // txtLugar
            // 
            this.txtLugar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtLugar.Location = new System.Drawing.Point(86, 53);
            this.txtLugar.Margin = new System.Windows.Forms.Padding(4);
            this.txtLugar.MaxLength = 40;
            this.txtLugar.Name = "txtLugar";
            this.txtLugar.Size = new System.Drawing.Size(415, 23);
            this.txtLugar.TabIndex = 4;
            // 
            // cboEstado
            // 
            this.cboEstado.FormattingEnabled = true;
            this.cboEstado.Location = new System.Drawing.Point(387, 3);
            this.cboEstado.Margin = new System.Windows.Forms.Padding(4);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(115, 24);
            this.cboEstado.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 57);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Lugar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(326, 7);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Estado";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Serie Nro";
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
            this.dgvListado.Size = new System.Drawing.Size(511, 338);
            this.dgvListado.TabIndex = 77;
            this.dgvListado.CurrentCellChanged += new System.EventHandler(this.dgvListado_CurrentCellChanged);
            // 
            // frmSerie_Orden_Recojo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 524);
            this.Controls.Add(this.btnCancela);
            this.Controls.Add(this.btnElimina);
            this.Controls.Add(this.btnModifica);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnGraba);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvListado);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSerie_Orden_Recojo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Serie Orden Recojo";
            this.Load += new System.EventHandler(this.frmSerie_Orden_Recojo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancela;
        private System.Windows.Forms.Button btnElimina;
        private System.Windows.Forms.Button btnModifica;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnGraba;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtTiendaIde;
        private System.Windows.Forms.ComboBox cboTienda;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTerminal;
        private System.Windows.Forms.TextBox txtNroLineas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtContador;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtVeces;
        private System.Windows.Forms.TextBox txtSerie;
        private System.Windows.Forms.TextBox txtLugar;
        private System.Windows.Forms.ComboBox cboEstado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvListado;
    }
}