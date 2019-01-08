namespace CapaPresentacion.Reportes
{
    partial class frmOrdenes_Reportes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOrdenes_Reportes));
            this.btnOrdConductor = new System.Windows.Forms.Button();
            this.btnOrdenesConductores = new System.Windows.Forms.Button();
            this.btnOrdenesDigitacion = new System.Windows.Forms.Button();
            this.btnOrdenesCliente = new System.Windows.Forms.Button();
            this.btnOrdenesVehiculo = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOrdConductor
            // 
            this.btnOrdConductor.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnOrdConductor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrdConductor.ForeColor = System.Drawing.Color.Navy;
            this.btnOrdConductor.Location = new System.Drawing.Point(17, 26);
            this.btnOrdConductor.Name = "btnOrdConductor";
            this.btnOrdConductor.Size = new System.Drawing.Size(128, 67);
            this.btnOrdConductor.TabIndex = 0;
            this.btnOrdConductor.Text = "Ordenes Por Conductor";
            this.btnOrdConductor.UseVisualStyleBackColor = false;
            this.btnOrdConductor.Click += new System.EventHandler(this.btnOrdConductor_Click);
            // 
            // btnOrdenesConductores
            // 
            this.btnOrdenesConductores.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnOrdenesConductores.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOrdenesConductores.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrdenesConductores.ForeColor = System.Drawing.Color.Navy;
            this.btnOrdenesConductores.Location = new System.Drawing.Point(217, 26);
            this.btnOrdenesConductores.Name = "btnOrdenesConductores";
            this.btnOrdenesConductores.Size = new System.Drawing.Size(128, 67);
            this.btnOrdenesConductores.TabIndex = 1;
            this.btnOrdenesConductores.Text = "Ordenes de Todos Los Conductores";
            this.btnOrdenesConductores.UseVisualStyleBackColor = false;
            this.btnOrdenesConductores.Click += new System.EventHandler(this.btnOrdenesConductores_Click);
            // 
            // btnOrdenesDigitacion
            // 
            this.btnOrdenesDigitacion.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnOrdenesDigitacion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOrdenesDigitacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrdenesDigitacion.ForeColor = System.Drawing.Color.Navy;
            this.btnOrdenesDigitacion.Location = new System.Drawing.Point(417, 26);
            this.btnOrdenesDigitacion.Name = "btnOrdenesDigitacion";
            this.btnOrdenesDigitacion.Size = new System.Drawing.Size(128, 67);
            this.btnOrdenesDigitacion.TabIndex = 2;
            this.btnOrdenesDigitacion.Text = "Ordenes por Estados de Digitación";
            this.btnOrdenesDigitacion.UseVisualStyleBackColor = false;
            this.btnOrdenesDigitacion.Click += new System.EventHandler(this.btnOrdenesDigitacion_Click);
            // 
            // btnOrdenesCliente
            // 
            this.btnOrdenesCliente.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnOrdenesCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOrdenesCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrdenesCliente.ForeColor = System.Drawing.Color.Navy;
            this.btnOrdenesCliente.Location = new System.Drawing.Point(17, 180);
            this.btnOrdenesCliente.Name = "btnOrdenesCliente";
            this.btnOrdenesCliente.Size = new System.Drawing.Size(128, 67);
            this.btnOrdenesCliente.TabIndex = 3;
            this.btnOrdenesCliente.Text = "Ordenes por Remitente (Cliente)";
            this.btnOrdenesCliente.UseVisualStyleBackColor = false;
            this.btnOrdenesCliente.Click += new System.EventHandler(this.btnOrdenesCliente_Click);
            // 
            // btnOrdenesVehiculo
            // 
            this.btnOrdenesVehiculo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnOrdenesVehiculo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOrdenesVehiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrdenesVehiculo.ForeColor = System.Drawing.Color.Navy;
            this.btnOrdenesVehiculo.Location = new System.Drawing.Point(217, 180);
            this.btnOrdenesVehiculo.Name = "btnOrdenesVehiculo";
            this.btnOrdenesVehiculo.Size = new System.Drawing.Size(128, 67);
            this.btnOrdenesVehiculo.TabIndex = 4;
            this.btnOrdenesVehiculo.Text = "Ordenes por Vehiculo";
            this.btnOrdenesVehiculo.UseVisualStyleBackColor = false;
            this.btnOrdenesVehiculo.Click += new System.EventHandler(this.btnOrdenesVehiculo_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnSalir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSalir.FlatAppearance.BorderSize = 2;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.Location = new System.Drawing.Point(417, 180);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(128, 67);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmOrdenes_Reportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(564, 313);
            this.ControlBox = false;
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnOrdenesVehiculo);
            this.Controls.Add(this.btnOrdenesCliente);
            this.Controls.Add(this.btnOrdenesDigitacion);
            this.Controls.Add(this.btnOrdenesConductores);
            this.Controls.Add(this.btnOrdConductor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmOrdenes_Reportes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reportes de Ordenes de Recojo";
            this.TopMost = true;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOrdConductor;
        private System.Windows.Forms.Button btnOrdenesConductores;
        private System.Windows.Forms.Button btnOrdenesDigitacion;
        private System.Windows.Forms.Button btnOrdenesCliente;
        private System.Windows.Forms.Button btnOrdenesVehiculo;
        private System.Windows.Forms.Button btnSalir;
    }
}