namespace CapaPresentacion.Reportes
{
    partial class rptCompra_Productos
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
            this.V_COMPRA_PRODUCTOS_CABECERA_DETALLEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetCompra_Productos = new CapaPresentacion.Reportes.DataSetCompra_Productos();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.V_COMPRA_PRODUCTOS_CABECERA_DETALLETableAdapter = new CapaPresentacion.Reportes.DataSetCompra_ProductosTableAdapters.V_COMPRA_PRODUCTOS_CABECERA_DETALLETableAdapter();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.dtpFecFin = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFecIni = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.V_COMPRA_PRODUCTOS_CABECERA_DETALLEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetCompra_Productos)).BeginInit();
            this.SuspendLayout();
            // 
            // V_COMPRA_PRODUCTOS_CABECERA_DETALLEBindingSource
            // 
            this.V_COMPRA_PRODUCTOS_CABECERA_DETALLEBindingSource.DataMember = "V_COMPRA_PRODUCTOS_CABECERA_DETALLE";
            this.V_COMPRA_PRODUCTOS_CABECERA_DETALLEBindingSource.DataSource = this.DataSetCompra_Productos;
            // 
            // DataSetCompra_Productos
            // 
            this.DataSetCompra_Productos.DataSetName = "DataSetCompra_Productos";
            this.DataSetCompra_Productos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(740, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetCompra_Productos";
            reportDataSource1.Value = this.V_COMPRA_PRODUCTOS_CABECERA_DETALLEBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CapaPresentacion.Reportes.rptCompra_Productos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 25);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(740, 445);
            this.reportViewer1.TabIndex = 1;
            // 
            // V_COMPRA_PRODUCTOS_CABECERA_DETALLETableAdapter
            // 
            this.V_COMPRA_PRODUCTOS_CABECERA_DETALLETableAdapter.ClearBeforeFill = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Image = global::CapaPresentacion.Properties.Resources.bsalir;
            this.btnSalir.Location = new System.Drawing.Point(370, 1);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(37, 21);
            this.btnSalir.TabIndex = 12;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Image = global::CapaPresentacion.Properties.Resources.WZPRINT;
            this.btnImprimir.Location = new System.Drawing.Point(328, 1);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(37, 23);
            this.btnImprimir.TabIndex = 11;
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // dtpFecFin
            // 
            this.dtpFecFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecFin.Location = new System.Drawing.Point(222, 1);
            this.dtpFecFin.Name = "dtpFecFin";
            this.dtpFecFin.Size = new System.Drawing.Size(97, 20);
            this.dtpFecFin.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(190, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Al ";
            // 
            // dtpFecIni
            // 
            this.dtpFecIni.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecIni.Location = new System.Drawing.Point(71, 1);
            this.dtpFecIni.Name = "dtpFecIni";
            this.dtpFecIni.Size = new System.Drawing.Size(97, 20);
            this.dtpFecIni.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(9, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Desde El ";
            // 
            // rptCompra_Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 470);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.dtpFecFin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpFecIni);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "rptCompra_Productos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Compra de Productos";
            this.Load += new System.EventHandler(this.rptCompra_Productos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.V_COMPRA_PRODUCTOS_CABECERA_DETALLEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetCompra_Productos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource V_COMPRA_PRODUCTOS_CABECERA_DETALLEBindingSource;
        private DataSetCompra_Productos DataSetCompra_Productos;
        private DataSetCompra_ProductosTableAdapters.V_COMPRA_PRODUCTOS_CABECERA_DETALLETableAdapter V_COMPRA_PRODUCTOS_CABECERA_DETALLETableAdapter;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.DateTimePicker dtpFecFin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpFecIni;
        private System.Windows.Forms.Label label1;
    }
}