﻿namespace CapaPresentacion.Proveedores
{
    partial class frmCategoria_Proveedor
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
            this.txtIde = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtVeces = new System.Windows.Forms.TextBox();
            this.cboEstado = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGraba = new System.Windows.Forms.Button();
            this.btnCancela = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnElimina = new System.Windows.Forms.Button();
            this.btnModifica = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvListado
            // 
            this.dgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListado.Location = new System.Drawing.Point(2, 0);
            this.dgvListado.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.dgvListado.MultiSelect = false;
            this.dgvListado.Name = "dgvListado";
            this.dgvListado.Size = new System.Drawing.Size(476, 359);
            this.dgvListado.TabIndex = 41;
            this.dgvListado.CurrentCellChanged += new System.EventHandler(this.dgvListado_CurrentCellChanged);
            // 
            // txtIde
            // 
            this.txtIde.Location = new System.Drawing.Point(68, 3);
            this.txtIde.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtIde.Name = "txtIde";
            this.txtIde.Size = new System.Drawing.Size(88, 23);
            this.txtIde.TabIndex = 8;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(68, 35);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtNombre.MaxLength = 20;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(389, 23);
            this.txtNombre.TabIndex = 6;
            // 
            // txtVeces
            // 
            this.txtVeces.Location = new System.Drawing.Point(137, 47);
            this.txtVeces.Name = "txtVeces";
            this.txtVeces.ReadOnly = true;
            this.txtVeces.Size = new System.Drawing.Size(127, 23);
            this.txtVeces.TabIndex = 25;
            this.txtVeces.Visible = false;
            // 
            // cboEstado
            // 
            this.cboEstado.FormattingEnabled = true;
            this.cboEstado.Location = new System.Drawing.Point(281, 3);
            this.cboEstado.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(177, 24);
            this.cboEstado.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(201, 10);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Estado";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtIde);
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Controls.Add(this.txtVeces);
            this.panel1.Controls.Add(this.cboEstado);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.panel1.Location = new System.Drawing.Point(2, 362);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(474, 73);
            this.panel1.TabIndex = 42;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 40);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nombre";
            // 
            // btnGraba
            // 
            this.btnGraba.Image = global::CapaPresentacion.Properties.Resources.bgrabar;
            this.btnGraba.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGraba.Location = new System.Drawing.Point(251, 439);
            this.btnGraba.Name = "btnGraba";
            this.btnGraba.Size = new System.Drawing.Size(73, 40);
            this.btnGraba.TabIndex = 48;
            this.btnGraba.Text = "&Grabar";
            this.btnGraba.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGraba.UseVisualStyleBackColor = true;
            this.btnGraba.Click += new System.EventHandler(this.btnGraba_Click);
            // 
            // btnCancela
            // 
            this.btnCancela.Image = global::CapaPresentacion.Properties.Resources.bcancelar;
            this.btnCancela.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancela.Location = new System.Drawing.Point(325, 439);
            this.btnCancela.Name = "btnCancela";
            this.btnCancela.Size = new System.Drawing.Size(73, 40);
            this.btnCancela.TabIndex = 47;
            this.btnCancela.Text = "&Cancelar";
            this.btnCancela.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancela.UseVisualStyleBackColor = true;
            this.btnCancela.Click += new System.EventHandler(this.btnCancela_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Image = global::CapaPresentacion.Properties.Resources.bsalir;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSalir.Location = new System.Drawing.Point(399, 439);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(73, 40);
            this.btnSalir.TabIndex = 46;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnElimina
            // 
            this.btnElimina.Image = global::CapaPresentacion.Properties.Resources.bborrar;
            this.btnElimina.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnElimina.Location = new System.Drawing.Point(177, 439);
            this.btnElimina.Name = "btnElimina";
            this.btnElimina.Size = new System.Drawing.Size(73, 40);
            this.btnElimina.TabIndex = 45;
            this.btnElimina.Text = "&Elimina";
            this.btnElimina.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnElimina.UseVisualStyleBackColor = true;
            this.btnElimina.Click += new System.EventHandler(this.btnElimina_Click);
            // 
            // btnModifica
            // 
            this.btnModifica.Image = global::CapaPresentacion.Properties.Resources.beditar;
            this.btnModifica.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnModifica.Location = new System.Drawing.Point(103, 439);
            this.btnModifica.Name = "btnModifica";
            this.btnModifica.Size = new System.Drawing.Size(73, 40);
            this.btnModifica.TabIndex = 44;
            this.btnModifica.Text = "&Modifica";
            this.btnModifica.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnModifica.UseVisualStyleBackColor = true;
            this.btnModifica.Click += new System.EventHandler(this.btnModifica_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Image = global::CapaPresentacion.Properties.Resources.bnuevo;
            this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNuevo.Location = new System.Drawing.Point(29, 439);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(73, 40);
            this.btnNuevo.TabIndex = 43;
            this.btnNuevo.Text = "&Nuevo";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // frmCategoria_Proveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 480);
            this.Controls.Add(this.dgvListado);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnGraba);
            this.Controls.Add(this.btnCancela);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnElimina);
            this.Controls.Add(this.btnModifica);
            this.Controls.Add(this.btnNuevo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCategoria_Proveedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Categoria Proveedor";
            this.Load += new System.EventHandler(this.frmCategoria_Proveedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListado;
        private System.Windows.Forms.TextBox txtIde;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtVeces;
        private System.Windows.Forms.ComboBox cboEstado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGraba;
        private System.Windows.Forms.Button btnCancela;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnElimina;
        private System.Windows.Forms.Button btnModifica;
        private System.Windows.Forms.Button btnNuevo;
    }
}