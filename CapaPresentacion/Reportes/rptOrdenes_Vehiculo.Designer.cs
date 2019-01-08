namespace CapaPresentacion.Reportes
{
    partial class rptOrdenes_Vehiculo
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.V_RECOJO_CABECERABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetOrdenes_Vehiculo = new CapaPresentacion.Reportes.DataSetOrdenes_Vehiculo();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.V_RECOJO_CABECERATableAdapter = new CapaPresentacion.Reportes.DataSetOrdenes_VehiculoTableAdapters.V_RECOJO_CABECERATableAdapter();
            this.txtVehi_Ide = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.dtpFecFin = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpFecIni = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtVehiculo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.txtNombre = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.V_RECOJO_CABECERABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetOrdenes_Vehiculo)).BeginInit();
            this.SuspendLayout();
            // 
            // V_RECOJO_CABECERABindingSource
            // 
            this.V_RECOJO_CABECERABindingSource.DataMember = "V_RECOJO_CABECERA";
            this.V_RECOJO_CABECERABindingSource.DataSource = this.DataSetOrdenes_Vehiculo;
            // 
            // DataSetOrdenes_Vehiculo
            // 
            this.DataSetOrdenes_Vehiculo.DataSetName = "DataSetOrdenes_Vehiculo";
            this.DataSetOrdenes_Vehiculo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(882, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource3.Name = "DataSetOrdenes_Vehiculo";
            reportDataSource3.Value = this.V_RECOJO_CABECERABindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CapaPresentacion.Reportes.rptOrdenes_Vehiculo.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 25);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(882, 485);
            this.reportViewer1.TabIndex = 5;
            // 
            // V_RECOJO_CABECERATableAdapter
            // 
            this.V_RECOJO_CABECERATableAdapter.ClearBeforeFill = true;
            // 
            // txtVehi_Ide
            // 
            this.txtVehi_Ide.Location = new System.Drawing.Point(63, 2);
            this.txtVehi_Ide.Name = "txtVehi_Ide";
            this.txtVehi_Ide.ReadOnly = true;
            this.txtVehi_Ide.Size = new System.Drawing.Size(39, 20);
            this.txtVehi_Ide.TabIndex = 19;
            // 
            // btnSalir
            // 
            this.btnSalir.Image = global::CapaPresentacion.Properties.Resources.bsalir;
            this.btnSalir.Location = new System.Drawing.Point(838, 2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(37, 21);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Image = global::CapaPresentacion.Properties.Resources.WZPRINT;
            this.btnImprimir.Location = new System.Drawing.Point(796, 1);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(37, 23);
            this.btnImprimir.TabIndex = 3;
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // dtpFecFin
            // 
            this.dtpFecFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecFin.Location = new System.Drawing.Point(694, 2);
            this.dtpFecFin.Name = "dtpFecFin";
            this.dtpFecFin.Size = new System.Drawing.Size(99, 20);
            this.dtpFecFin.TabIndex = 2;
            this.dtpFecFin.ValueChanged += new System.EventHandler(this.dtpFecFin_ValueChanged);
            this.dtpFecFin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dtpFecFin_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(671, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Al";
            // 
            // dtpFecIni
            // 
            this.dtpFecIni.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecIni.Location = new System.Drawing.Point(566, 2);
            this.dtpFecIni.Name = "dtpFecIni";
            this.dtpFecIni.Size = new System.Drawing.Size(99, 20);
            this.dtpFecIni.TabIndex = 1;
            this.dtpFecIni.ValueChanged += new System.EventHandler(this.dtpFecIni_ValueChanged);
            this.dtpFecIni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dtpFecIni_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(535, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Del ";
            // 
            // txtVehiculo
            // 
            this.txtVehiculo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtVehiculo.Location = new System.Drawing.Point(106, 2);
            this.txtVehiculo.Name = "txtVehiculo";
            this.txtVehiculo.Size = new System.Drawing.Size(222, 20);
            this.txtVehiculo.TabIndex = 0;
            this.txtVehiculo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtVehiculo_KeyDown);
            this.txtVehiculo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVehiculo_KeyPress);
            this.txtVehiculo.Validated += new System.EventHandler(this.txtVehiculo_Validated);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(5, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Vehiculo";
            // 
            // txtNombre
            // 
            this.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombre.Enabled = false;
            this.txtNombre.Location = new System.Drawing.Point(329, 2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ReadOnly = true;
            this.txtNombre.Size = new System.Drawing.Size(204, 20);
            this.txtNombre.TabIndex = 20;
            // 
            // rptOrdenes_Vehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 510);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtVehi_Ide);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.dtpFecFin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpFecIni);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtVehiculo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "rptOrdenes_Vehiculo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "rptOrdenes_Vehiculo";
            this.Load += new System.EventHandler(this.rptOrdenes_Vehiculo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.V_RECOJO_CABECERABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetOrdenes_Vehiculo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource V_RECOJO_CABECERABindingSource;
        private DataSetOrdenes_Vehiculo DataSetOrdenes_Vehiculo;
        private DataSetOrdenes_VehiculoTableAdapters.V_RECOJO_CABECERATableAdapter V_RECOJO_CABECERATableAdapter;
        private System.Windows.Forms.TextBox txtVehi_Ide;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.DateTimePicker dtpFecFin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpFecIni;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtVehiculo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox txtNombre;
    }
}