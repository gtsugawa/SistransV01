namespace CapaPresentacion.Reportes
{
    partial class rptOrdenes_Conductor
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
            this.DataSetOrdenes_Conductor = new CapaPresentacion.Reportes.DataSetOrdenes_Conductor();
            this.tableAdapterManager1 = new CapaPresentacion.Reportes.DataSetCombustibleTableAdapters.TableAdapterManager();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.txtConductor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFecIni = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpFecFin = new System.Windows.Forms.DateTimePicker();
            this.V_RECOJO_CABECERATableAdapter = new CapaPresentacion.Reportes.DataSetOrdenes_ConductorTableAdapters.V_RECOJO_CABECERATableAdapter();
            this.txtChof_Ide = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.V_RECOJO_CABECERABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetOrdenes_Conductor)).BeginInit();
            this.SuspendLayout();
            // 
            // V_RECOJO_CABECERABindingSource
            // 
            this.V_RECOJO_CABECERABindingSource.DataMember = "V_RECOJO_CABECERA";
            this.V_RECOJO_CABECERABindingSource.DataSource = this.DataSetOrdenes_Conductor;
            // 
            // DataSetOrdenes_Conductor
            // 
            this.DataSetOrdenes_Conductor.DataSetName = "DataSetOrdenes_Conductor";
            this.DataSetOrdenes_Conductor.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.UpdateOrder = CapaPresentacion.Reportes.DataSetCombustibleTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetOrdenes_Conductor";
            reportDataSource1.Value = this.V_RECOJO_CABECERABindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CapaPresentacion.Reportes.rptOrdenes_Conductor.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 25);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(760, 422);
            this.reportViewer1.TabIndex = 5;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(760, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(9, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Conductor";
            // 
            // txtConductor
            // 
            this.txtConductor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtConductor.Location = new System.Drawing.Point(110, 1);
            this.txtConductor.Name = "txtConductor";
            this.txtConductor.Size = new System.Drawing.Size(289, 20);
            this.txtConductor.TabIndex = 0;
            this.txtConductor.TextChanged += new System.EventHandler(this.txtConductor_TextChanged);
            this.txtConductor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtConductor_KeyDown);
            this.txtConductor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtConductor_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(404, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Del ";
            // 
            // dtpFecIni
            // 
            this.dtpFecIni.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecIni.Location = new System.Drawing.Point(435, 1);
            this.dtpFecIni.Name = "dtpFecIni";
            this.dtpFecIni.Size = new System.Drawing.Size(99, 20);
            this.dtpFecIni.TabIndex = 1;
            this.dtpFecIni.ValueChanged += new System.EventHandler(this.dtpFecIni_ValueChanged);
            this.dtpFecIni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dtpFecIni_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(540, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Al";
            // 
            // dtpFecFin
            // 
            this.dtpFecFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecFin.Location = new System.Drawing.Point(563, 1);
            this.dtpFecFin.Name = "dtpFecFin";
            this.dtpFecFin.Size = new System.Drawing.Size(99, 20);
            this.dtpFecFin.TabIndex = 2;
            this.dtpFecFin.ValueChanged += new System.EventHandler(this.dtpFecFin_ValueChanged);
            this.dtpFecFin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dtpFecFin_KeyPress);
            // 
            // V_RECOJO_CABECERATableAdapter
            // 
            this.V_RECOJO_CABECERATableAdapter.ClearBeforeFill = true;
            // 
            // txtChof_Ide
            // 
            this.txtChof_Ide.Location = new System.Drawing.Point(67, 1);
            this.txtChof_Ide.Name = "txtChof_Ide";
            this.txtChof_Ide.ReadOnly = true;
            this.txtChof_Ide.Size = new System.Drawing.Size(39, 20);
            this.txtChof_Ide.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Image = global::CapaPresentacion.Properties.Resources.bsalir;
            this.button1.Location = new System.Drawing.Point(707, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(37, 21);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Image = global::CapaPresentacion.Properties.Resources.WZPRINT;
            this.btnImprimir.Location = new System.Drawing.Point(665, 0);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(37, 23);
            this.btnImprimir.TabIndex = 3;
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // rptOrdenes_Conductor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(760, 447);
            this.Controls.Add(this.txtChof_Ide);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.dtpFecFin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpFecIni);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtConductor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "rptOrdenes_Conductor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Informe de Ordenes Por Conductor";
            this.Load += new System.EventHandler(this.rptOrdenes_Conductor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.V_RECOJO_CABECERABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetOrdenes_Conductor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSetCombustibleTableAdapters.TableAdapterManager tableAdapterManager1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource V_RECOJO_CABECERABindingSource;
        private DataSetOrdenes_Conductor DataSetOrdenes_Conductor;
        private DataSetOrdenes_ConductorTableAdapters.V_RECOJO_CABECERATableAdapter V_RECOJO_CABECERATableAdapter;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtConductor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpFecIni;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpFecFin;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtChof_Ide;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}