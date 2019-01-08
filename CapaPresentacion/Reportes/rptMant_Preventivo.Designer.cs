namespace CapaPresentacion.Reportes
{
    partial class rptMant_Preventivo
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.V_MANTENIMIENTO_PREVENTIVOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetMant_Preventivo = new CapaPresentacion.Reportes.DataSetMant_Preventivo();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.V_MANTENIMIENTO_PREVENTIVOTableAdapter = new CapaPresentacion.Reportes.DataSetMant_PreventivoTableAdapters.V_MANTENIMIENTO_PREVENTIVOTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.V_MANTENIMIENTO_PREVENTIVOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetMant_Preventivo)).BeginInit();
            this.SuspendLayout();
            // 
            // V_MANTENIMIENTO_PREVENTIVOBindingSource
            // 
            this.V_MANTENIMIENTO_PREVENTIVOBindingSource.DataMember = "V_MANTENIMIENTO_PREVENTIVO";
            this.V_MANTENIMIENTO_PREVENTIVOBindingSource.DataSource = this.DataSetMant_Preventivo;
            // 
            // DataSetMant_Preventivo
            // 
            this.DataSetMant_Preventivo.DataSetName = "DataSetMant_Preventivo";
            this.DataSetMant_Preventivo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetMant_Preventivo";
            reportDataSource1.Value = this.V_MANTENIMIENTO_PREVENTIVOBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CapaPresentacion.Reportes.rptMant_Preventivo.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(837, 518);
            this.reportViewer1.TabIndex = 0;
            // 
            // V_MANTENIMIENTO_PREVENTIVOTableAdapter
            // 
            this.V_MANTENIMIENTO_PREVENTIVOTableAdapter.ClearBeforeFill = true;
            // 
            // rptMant_Preventivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 518);
            this.Controls.Add(this.reportViewer1);
            this.Name = "rptMant_Preventivo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "rptMant_Preventivo";
            this.Load += new System.EventHandler(this.rptMant_Preventivo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.V_MANTENIMIENTO_PREVENTIVOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetMant_Preventivo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource V_MANTENIMIENTO_PREVENTIVOBindingSource;
        private DataSetMant_Preventivo DataSetMant_Preventivo;
        private DataSetMant_PreventivoTableAdapters.V_MANTENIMIENTO_PREVENTIVOTableAdapter V_MANTENIMIENTO_PREVENTIVOTableAdapter;
    }
}