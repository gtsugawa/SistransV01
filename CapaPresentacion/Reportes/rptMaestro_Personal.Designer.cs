namespace CapaPresentacion.Reportes
{
    partial class rptMaestro_Personal
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.V_MAESTRO_PERSONALBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetMaestro_Personal = new CapaPresentacion.Reportes.DataSetMaestro_Personal();
            this.V_MAESTRO_PERSONALTableAdapter = new CapaPresentacion.Reportes.DataSetMaestro_PersonalTableAdapters.V_MAESTRO_PERSONALTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.V_MAESTRO_PERSONALBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetMaestro_Personal)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetMaestro_Personal";
            reportDataSource1.Value = this.V_MAESTRO_PERSONALBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CapaPresentacion.Reportes.rptMaestro_Personal.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(805, 506);
            this.reportViewer1.TabIndex = 0;
            // 
            // V_MAESTRO_PERSONALBindingSource
            // 
            this.V_MAESTRO_PERSONALBindingSource.DataMember = "V_MAESTRO_PERSONAL";
            this.V_MAESTRO_PERSONALBindingSource.DataSource = this.DataSetMaestro_Personal;
            // 
            // DataSetMaestro_Personal
            // 
            this.DataSetMaestro_Personal.DataSetName = "DataSetMaestro_Personal";
            this.DataSetMaestro_Personal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // V_MAESTRO_PERSONALTableAdapter
            // 
            this.V_MAESTRO_PERSONALTableAdapter.ClearBeforeFill = true;
            // 
            // rptMaestro_Personal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 506);
            this.Controls.Add(this.reportViewer1);
            this.Name = "rptMaestro_Personal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "rptMaestro_Personal";
            this.Load += new System.EventHandler(this.rptMaestro_Personal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.V_MAESTRO_PERSONALBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetMaestro_Personal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource V_MAESTRO_PERSONALBindingSource;
        private DataSetMaestro_Personal DataSetMaestro_Personal;
        private DataSetMaestro_PersonalTableAdapters.V_MAESTRO_PERSONALTableAdapter V_MAESTRO_PERSONALTableAdapter;



    }
}