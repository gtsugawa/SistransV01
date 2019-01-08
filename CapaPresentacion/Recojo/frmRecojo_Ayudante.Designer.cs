namespace CapaPresentacion.Recojo
{
    partial class frmRecojo_Ayudante
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
            this.btnGrabar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtIde_Detalle = new System.Windows.Forms.TextBox();
            this.txtTran_Cont_Ide = new System.Windows.Forms.TextBox();
            this.cboAyudante = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 4);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 28);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre ";
            // 
            // btnGrabar
            // 
            this.btnGrabar.Image = global::CapaPresentacion.Properties.Resources.bgrabar;
            this.btnGrabar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGrabar.Location = new System.Drawing.Point(317, 50);
            this.btnGrabar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(67, 22);
            this.btnGrabar.TabIndex = 3;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = global::CapaPresentacion.Properties.Resources.bcancelar;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(387, 50);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(74, 22);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtIde_Detalle
            // 
            this.txtIde_Detalle.Enabled = false;
            this.txtIde_Detalle.Location = new System.Drawing.Point(52, 3);
            this.txtIde_Detalle.Margin = new System.Windows.Forms.Padding(2);
            this.txtIde_Detalle.Name = "txtIde_Detalle";
            this.txtIde_Detalle.Size = new System.Drawing.Size(42, 20);
            this.txtIde_Detalle.TabIndex = 0;
            // 
            // txtTran_Cont_Ide
            // 
            this.txtTran_Cont_Ide.Location = new System.Drawing.Point(52, 26);
            this.txtTran_Cont_Ide.Margin = new System.Windows.Forms.Padding(2);
            this.txtTran_Cont_Ide.Name = "txtTran_Cont_Ide";
            this.txtTran_Cont_Ide.Size = new System.Drawing.Size(42, 20);
            this.txtTran_Cont_Ide.TabIndex = 1;
            // 
            // cboAyudante
            // 
            this.cboAyudante.FormattingEnabled = true;
            this.cboAyudante.Location = new System.Drawing.Point(98, 26);
            this.cboAyudante.Margin = new System.Windows.Forms.Padding(2);
            this.cboAyudante.Name = "cboAyudante";
            this.cboAyudante.Size = new System.Drawing.Size(362, 21);
            this.cboAyudante.TabIndex = 2;
            this.cboAyudante.SelectedValueChanged += new System.EventHandler(this.cboAyudante_SelectedValueChanged);
            // 
            // frmRecojo_Ayudante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 77);
            this.Controls.Add(this.cboAyudante);
            this.Controls.Add(this.txtTran_Cont_Ide);
            this.Controls.Add(this.txtIde_Detalle);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRecojo_Ayudante";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Oden de Recojo Ayudantes";
            this.Load += new System.EventHandler(this.frmRecojo_Ayudante_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmRecojo_Ayudante_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtIde_Detalle;
        private System.Windows.Forms.TextBox txtTran_Cont_Ide;
        private System.Windows.Forms.ComboBox cboAyudante;
    }
}