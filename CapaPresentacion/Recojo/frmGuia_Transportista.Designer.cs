namespace CapaPresentacion.Recojo
{
    partial class frmGuia_Transportista
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
            this.txtSerieGuia = new System.Windows.Forms.TextBox();
            this.txtNumeroGuia = new System.Windows.Forms.TextBox();
            this.dtpFEmision = new System.Windows.Forms.DateTimePicker();
            this.dtpFTraslado = new System.Windows.Forms.DateTimePicker();
            this.btnCancelarDetalle = new System.Windows.Forms.Button();
            this.btnGrabarDetalle = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Serie";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 3);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "N° Guia";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(134, 3);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "F.Emision";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(217, 3);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "F.Traslado";
            // 
            // txtSerieGuia
            // 
            this.txtSerieGuia.Location = new System.Drawing.Point(3, 20);
            this.txtSerieGuia.Margin = new System.Windows.Forms.Padding(2);
            this.txtSerieGuia.Name = "txtSerieGuia";
            this.txtSerieGuia.Size = new System.Drawing.Size(39, 20);
            this.txtSerieGuia.TabIndex = 0;
            this.txtSerieGuia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSerieGuia_KeyPress);
            // 
            // txtNumeroGuia
            // 
            this.txtNumeroGuia.Location = new System.Drawing.Point(46, 20);
            this.txtNumeroGuia.Margin = new System.Windows.Forms.Padding(2);
            this.txtNumeroGuia.Name = "txtNumeroGuia";
            this.txtNumeroGuia.Size = new System.Drawing.Size(73, 20);
            this.txtNumeroGuia.TabIndex = 1;
            this.txtNumeroGuia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeroGuia_KeyPress);
            // 
            // dtpFEmision
            // 
            this.dtpFEmision.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFEmision.Location = new System.Drawing.Point(124, 20);
            this.dtpFEmision.Margin = new System.Windows.Forms.Padding(2);
            this.dtpFEmision.Name = "dtpFEmision";
            this.dtpFEmision.Size = new System.Drawing.Size(82, 20);
            this.dtpFEmision.TabIndex = 2;
            this.dtpFEmision.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dtpFEmision_KeyPress);
            // 
            // dtpFTraslado
            // 
            this.dtpFTraslado.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFTraslado.Location = new System.Drawing.Point(209, 20);
            this.dtpFTraslado.Margin = new System.Windows.Forms.Padding(2);
            this.dtpFTraslado.Name = "dtpFTraslado";
            this.dtpFTraslado.Size = new System.Drawing.Size(80, 20);
            this.dtpFTraslado.TabIndex = 3;
            this.dtpFTraslado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dtpFTraslado_KeyPress);
            // 
            // btnCancelarDetalle
            // 
            this.btnCancelarDetalle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelarDetalle.Image = global::CapaPresentacion.Properties.Resources.bcancelar;
            this.btnCancelarDetalle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelarDetalle.Location = new System.Drawing.Point(208, 7);
            this.btnCancelarDetalle.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelarDetalle.Name = "btnCancelarDetalle";
            this.btnCancelarDetalle.Size = new System.Drawing.Size(73, 22);
            this.btnCancelarDetalle.TabIndex = 1;
            this.btnCancelarDetalle.Text = "Cancelar";
            this.btnCancelarDetalle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelarDetalle.UseVisualStyleBackColor = true;
            this.btnCancelarDetalle.Click += new System.EventHandler(this.btnCancelarDetalle_Click);
            // 
            // btnGrabarDetalle
            // 
            this.btnGrabarDetalle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGrabarDetalle.Image = global::CapaPresentacion.Properties.Resources.bgrabar;
            this.btnGrabarDetalle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGrabarDetalle.Location = new System.Drawing.Point(123, 7);
            this.btnGrabarDetalle.Margin = new System.Windows.Forms.Padding(2);
            this.btnGrabarDetalle.Name = "btnGrabarDetalle";
            this.btnGrabarDetalle.Size = new System.Drawing.Size(73, 22);
            this.btnGrabarDetalle.TabIndex = 0;
            this.btnGrabarDetalle.Text = "Grabar";
            this.btnGrabarDetalle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGrabarDetalle.UseVisualStyleBackColor = true;
            this.btnGrabarDetalle.Click += new System.EventHandler(this.btnGrabarDetalle_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.dtpFTraslado);
            this.panel1.Controls.Add(this.dtpFEmision);
            this.panel1.Controls.Add(this.txtNumeroGuia);
            this.panel1.Controls.Add(this.txtSerieGuia);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(296, 45);
            this.panel1.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnGrabarDetalle);
            this.panel2.Controls.Add(this.btnCancelarDetalle);
            this.panel2.Location = new System.Drawing.Point(6, 52);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(290, 36);
            this.panel2.TabIndex = 11;
            // 
            // frmGuia_Transportista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 95);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmGuia_Transportista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Guia Transportista";
            this.Load += new System.EventHandler(this.frmGuia_Transportista_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmGuia_Transportista_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSerieGuia;
        private System.Windows.Forms.TextBox txtNumeroGuia;
        private System.Windows.Forms.DateTimePicker dtpFEmision;
        private System.Windows.Forms.DateTimePicker dtpFTraslado;
        private System.Windows.Forms.Button btnCancelarDetalle;
        private System.Windows.Forms.Button btnGrabarDetalle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}