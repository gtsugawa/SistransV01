namespace CapaPresentacion.Reportes
{
    partial class rptCombustible
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.V_COMBUSTIBLE_COMPRABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetCombustible = new CapaPresentacion.Reportes.DataSetCombustible();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.v_COMBUSTIBLE_COMPRA1TableAdapter = new CapaPresentacion.Reportes.DataSetCombustibleTableAdapters.V_COMBUSTIBLE_COMPRA1TableAdapter();
            this.tableAdapterManager = new CapaPresentacion.Reportes.DataSetCombustibleTableAdapters.TableAdapterManager();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            ((System.ComponentModel.ISupportInitialize)(this.V_COMBUSTIBLE_COMPRABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetCombustible)).BeginInit();
            this.SuspendLayout();
            // 
            // V_COMBUSTIBLE_COMPRABindingSource
            // 
            this.V_COMBUSTIBLE_COMPRABindingSource.DataMember = "V_COMBUSTIBLE_COMPRA1";
            this.V_COMBUSTIBLE_COMPRABindingSource.DataSource = this.DataSetCombustible;
            // 
            // DataSetCombustible
            // 
            this.DataSetCombustible.DataSetName = "DataSetCombustible";
            this.DataSetCombustible.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSetCombustible";
            reportDataSource2.Value = this.V_COMBUSTIBLE_COMPRABindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CapaPresentacion.Reportes.ReportCombustible.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 25);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1029, 403);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // v_COMBUSTIBLE_COMPRA1TableAdapter
            // 
            this.v_COMBUSTIBLE_COMPRA1TableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = CapaPresentacion.Reportes.DataSetCombustibleTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1029, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "fillByToolStrip";
            // 
            // rptCombustible
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 428);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "rptCombustible";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Compra de Combustible";
            this.Load += new System.EventHandler(this.rptCombustible_Load);
            ((System.ComponentModel.ISupportInitialize)(this.V_COMBUSTIBLE_COMPRABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetCombustible)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource V_COMBUSTIBLE_COMPRABindingSource;
        private DataSetCombustible DataSetCombustible;
        private DataSetCombustibleTableAdapters.V_COMBUSTIBLE_COMPRA1TableAdapter v_COMBUSTIBLE_COMPRA1TableAdapter;
        private DataSetCombustibleTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ToolStrip toolStrip1;
    }
}