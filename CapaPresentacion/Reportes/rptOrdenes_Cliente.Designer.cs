namespace CapaPresentacion.Reportes
{
    partial class rptOrdenes_Cliente
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
            this.V_RECOJO_CABECERABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetOrdenes_Cliente = new CapaPresentacion.Reportes.DataSetOrdenes_Cliente();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.V_RECOJO_CABECERATableAdapter = new CapaPresentacion.Reportes.DataSetOrdenes_ClienteTableAdapters.V_RECOJO_CABECERATableAdapter();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.dtpFecFin = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpFecIni = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRemitente = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.txtClie_Ide = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.V_RECOJO_CABECERABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetOrdenes_Cliente)).BeginInit();
            this.SuspendLayout();
            // 
            // V_RECOJO_CABECERABindingSource
            // 
            this.V_RECOJO_CABECERABindingSource.DataMember = "V_RECOJO_CABECERA";
            this.V_RECOJO_CABECERABindingSource.DataSource = this.DataSetOrdenes_Cliente;
            // 
            // DataSetOrdenes_Cliente
            // 
            this.DataSetOrdenes_Cliente.DataSetName = "DataSetOrdenes_Cliente";
            this.DataSetOrdenes_Cliente.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(840, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetOrdenes_Cliente";
            reportDataSource1.Value = this.V_RECOJO_CABECERABindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CapaPresentacion.Reportes.rptOrdenes_Cliente.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 25);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(840, 491);
            this.reportViewer1.TabIndex = 5;
            // 
            // V_RECOJO_CABECERATableAdapter
            // 
            this.V_RECOJO_CABECERATableAdapter.ClearBeforeFill = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Image = global::CapaPresentacion.Properties.Resources.bsalir;
            this.btnSalir.Location = new System.Drawing.Point(796, 0);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(37, 21);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Image = global::CapaPresentacion.Properties.Resources.WZPRINT;
            this.btnImprimir.Location = new System.Drawing.Point(754, -1);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(37, 23);
            this.btnImprimir.TabIndex = 3;
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // dtpFecFin
            // 
            this.dtpFecFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecFin.Location = new System.Drawing.Point(652, 0);
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
            this.label3.Location = new System.Drawing.Point(629, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Al";
            // 
            // dtpFecIni
            // 
            this.dtpFecIni.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecIni.Location = new System.Drawing.Point(524, 0);
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
            this.label2.Location = new System.Drawing.Point(493, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Del ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Remitente ";
            // 
            // txtRemitente
            // 
            this.txtRemitente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRemitente.Location = new System.Drawing.Point(121, 1);
            this.txtRemitente.Name = "txtRemitente";
            this.txtRemitente.Size = new System.Drawing.Size(368, 20);
            this.txtRemitente.TabIndex = 0;
            this.txtRemitente.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCliente_KeyDown);
            this.txtRemitente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCliente_KeyPress);
            // 
            // txtClie_Ide
            // 
            this.txtClie_Ide.Location = new System.Drawing.Point(63, 1);
            this.txtClie_Ide.Name = "txtClie_Ide";
            this.txtClie_Ide.ReadOnly = true;
            this.txtClie_Ide.Size = new System.Drawing.Size(57, 20);
            this.txtClie_Ide.TabIndex = 20;
            // 
            // rptOrdenes_Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 516);
            this.Controls.Add(this.txtClie_Ide);
            this.Controls.Add(this.txtRemitente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.dtpFecFin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpFecIni);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "rptOrdenes_Cliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ordenes Por Cliente";
            this.Load += new System.EventHandler(this.rptOrdenes_Cliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.V_RECOJO_CABECERABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetOrdenes_Cliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource V_RECOJO_CABECERABindingSource;
        private DataSetOrdenes_Cliente DataSetOrdenes_Cliente;
        private DataSetOrdenes_ClienteTableAdapters.V_RECOJO_CABECERATableAdapter V_RECOJO_CABECERATableAdapter;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.DateTimePicker dtpFecFin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpFecIni;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRemitente;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox txtClie_Ide;
    }
}