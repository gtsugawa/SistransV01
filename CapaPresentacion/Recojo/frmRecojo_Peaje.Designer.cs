namespace CapaPresentacion
{
    partial class frmRecojo_Peaje
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIde_Detalle = new System.Windows.Forms.TextBox();
            this.txtSerie = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.txtMonto = new System.Windows.Forms.MaskedTextBox();
            this.btnCancelarPeaje = new System.Windows.Forms.Button();
            this.btnGrabarPeaje = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 3);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Serie ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(112, 3);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Numero";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(287, 3);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Monto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(196, 3);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Fecha";
            // 
            // txtIde_Detalle
            // 
            this.txtIde_Detalle.Enabled = false;
            this.txtIde_Detalle.Location = new System.Drawing.Point(8, 20);
            this.txtIde_Detalle.Margin = new System.Windows.Forms.Padding(2);
            this.txtIde_Detalle.Name = "txtIde_Detalle";
            this.txtIde_Detalle.Size = new System.Drawing.Size(41, 20);
            this.txtIde_Detalle.TabIndex = 0;
            // 
            // txtSerie
            // 
            this.txtSerie.Location = new System.Drawing.Point(53, 20);
            this.txtSerie.Margin = new System.Windows.Forms.Padding(2);
            this.txtSerie.MaxLength = 4;
            this.txtSerie.Name = "txtSerie";
            this.txtSerie.Size = new System.Drawing.Size(52, 20);
            this.txtSerie.TabIndex = 0;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(110, 20);
            this.txtNumero.Margin = new System.Windows.Forms.Padding(2);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(67, 20);
            this.txtNumero.TabIndex = 1;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(182, 20);
            this.dtpFecha.Margin = new System.Windows.Forms.Padding(2);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(78, 20);
            this.dtpFecha.TabIndex = 2;
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(265, 20);
            this.txtMonto.Margin = new System.Windows.Forms.Padding(2);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(78, 20);
            this.txtMonto.TabIndex = 3;
            // 
            // btnCancelarPeaje
            // 
            this.btnCancelarPeaje.Image = global::CapaPresentacion.Properties.Resources.bcancelar;
            this.btnCancelarPeaje.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelarPeaje.Location = new System.Drawing.Point(415, 17);
            this.btnCancelarPeaje.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelarPeaje.Name = "btnCancelarPeaje";
            this.btnCancelarPeaje.Size = new System.Drawing.Size(71, 22);
            this.btnCancelarPeaje.TabIndex = 5;
            this.btnCancelarPeaje.Text = "Cancelar";
            this.btnCancelarPeaje.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelarPeaje.UseVisualStyleBackColor = true;
            this.btnCancelarPeaje.Click += new System.EventHandler(this.btnCancelarPeaje_Click);
            // 
            // btnGrabarPeaje
            // 
            this.btnGrabarPeaje.Image = global::CapaPresentacion.Properties.Resources.bgrabar;
            this.btnGrabarPeaje.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGrabarPeaje.Location = new System.Drawing.Point(346, 17);
            this.btnGrabarPeaje.Margin = new System.Windows.Forms.Padding(2);
            this.btnGrabarPeaje.Name = "btnGrabarPeaje";
            this.btnGrabarPeaje.Size = new System.Drawing.Size(66, 22);
            this.btnGrabarPeaje.TabIndex = 4;
            this.btnGrabarPeaje.Text = "Grabar";
            this.btnGrabarPeaje.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGrabarPeaje.UseVisualStyleBackColor = true;
            this.btnGrabarPeaje.Click += new System.EventHandler(this.btnGrabarPeaje_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtIde_Detalle);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnCancelarPeaje);
            this.panel1.Controls.Add(this.txtSerie);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnGrabarPeaje);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtNumero);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtMonto);
            this.panel1.Controls.Add(this.dtpFecha);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(491, 48);
            this.panel1.TabIndex = 18;
            // 
            // frmRecojo_Peaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 56);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRecojo_Peaje";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Orden de Recojo - Peaje";
            this.Load += new System.EventHandler(this.frmRecojo_Peaje_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmRecojo_Peaje_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIde_Detalle;
        private System.Windows.Forms.TextBox txtSerie;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.MaskedTextBox txtMonto;
        private System.Windows.Forms.Button btnCancelarPeaje;
        private System.Windows.Forms.Button btnGrabarPeaje;
        private System.Windows.Forms.Panel panel1;
    }
}