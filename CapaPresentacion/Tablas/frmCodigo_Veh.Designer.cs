namespace CapaPresentacion.Tablas
{
    partial class frmCodigo_Veh
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
            this.lblRutaImagen = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnSaveToBDD = new System.Windows.Forms.Button();
            this.btnLoadFromBDDtoImg = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // lblRutaImagen
            // 
            this.lblRutaImagen.AutoSize = true;
            this.lblRutaImagen.Location = new System.Drawing.Point(29, 100);
            this.lblRutaImagen.Name = "lblRutaImagen";
            this.lblRutaImagen.Size = new System.Drawing.Size(55, 13);
            this.lblRutaImagen.TabIndex = 2;
            this.lblRutaImagen.Text = "Ubicacion";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(255, 38);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar Imagen";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(111, 39);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 4;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(111, 69);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 5;
            // 
            // btnSaveToBDD
            // 
            this.btnSaveToBDD.Location = new System.Drawing.Point(80, 151);
            this.btnSaveToBDD.Name = "btnSaveToBDD";
            this.btnSaveToBDD.Size = new System.Drawing.Size(103, 23);
            this.btnSaveToBDD.TabIndex = 6;
            this.btnSaveToBDD.Text = "Guardar en BD";
            this.btnSaveToBDD.UseVisualStyleBackColor = true;
            this.btnSaveToBDD.Click += new System.EventHandler(this.btnSaveToBDD_Click);
            // 
            // btnLoadFromBDDtoImg
            // 
            this.btnLoadFromBDDtoImg.Location = new System.Drawing.Point(212, 151);
            this.btnLoadFromBDDtoImg.Name = "btnLoadFromBDDtoImg";
            this.btnLoadFromBDDtoImg.Size = new System.Drawing.Size(118, 23);
            this.btnLoadFromBDDtoImg.TabIndex = 7;
            this.btnLoadFromBDDtoImg.Text = "Abrir Imagen en BD";
            this.btnLoadFromBDDtoImg.UseVisualStyleBackColor = true;
            this.btnLoadFromBDDtoImg.Click += new System.EventHandler(this.btnLoadFromBDDtoImg_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(53, 217);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(255, 158);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // frmCodigo_Veh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 481);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnLoadFromBDDtoImg);
            this.Controls.Add(this.btnSaveToBDD);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblRutaImagen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmCodigo_Veh";
            this.Text = "Guardar y Abrir Imagen en BD Sql Server";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblRutaImagen;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnSaveToBDD;
        private System.Windows.Forms.Button btnLoadFromBDDtoImg;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}