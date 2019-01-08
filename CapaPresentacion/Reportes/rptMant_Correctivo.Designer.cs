namespace CapaPresentacion.Reportes
{
    partial class rptMant_Correctivo
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
            this.V_MANTENIMIENTO_CORRECTIVOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetMant_Correctivo = new CapaPresentacion.Reportes.DataSetMant_Correctivo();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.V_MANTENIMIENTO_CORRECTIVOTableAdapter = new CapaPresentacion.Reportes.DataSetMant_CorrectivoTableAdapters.V_MANTENIMIENTO_CORRECTIVOTableAdapter();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            ((System.ComponentModel.ISupportInitialize)(this.V_MANTENIMIENTO_CORRECTIVOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetMant_Correctivo)).BeginInit();
            this.SuspendLayout();
            // 
            // V_MANTENIMIENTO_CORRECTIVOBindingSource
            // 
            this.V_MANTENIMIENTO_CORRECTIVOBindingSource.DataMember = "V_MANTENIMIENTO_CORRECTIVO";
            this.V_MANTENIMIENTO_CORRECTIVOBindingSource.DataSource = this.DataSetMant_Correctivo;
            // 
            // DataSetMant_Correctivo
            // 
            this.DataSetMant_Correctivo.DataSetName = "DataSetMant_Correctivo";
            this.DataSetMant_Correctivo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "DataSetMant_Correctivo";
            reportDataSource1.Value = this.V_MANTENIMIENTO_CORRECTIVOBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CapaPresentacion.Reportes.rptMant_Correctivo.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(2, 27);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(858, 480);
            this.reportViewer1.TabIndex = 0;
            // 
            // V_MANTENIMIENTO_CORRECTIVOTableAdapter
            // 
            this.V_MANTENIMIENTO_CORRECTIVOTableAdapter.ClearBeforeFill = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(859, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // rptMant_Correctivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 509);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "rptMant_Correctivo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "rptMant_Correctivo";
            this.Load += new System.EventHandler(this.rptMant_Correctivo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.V_MANTENIMIENTO_CORRECTIVOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetMant_Correctivo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource V_MANTENIMIENTO_CORRECTIVOBindingSource;
        private DataSetMant_Correctivo DataSetMant_Correctivo;
        private DataSetMant_CorrectivoTableAdapters.V_MANTENIMIENTO_CORRECTIVOTableAdapter V_MANTENIMIENTO_CORRECTIVOTableAdapter;
        private System.Windows.Forms.ToolStrip toolStrip1;
    }
}