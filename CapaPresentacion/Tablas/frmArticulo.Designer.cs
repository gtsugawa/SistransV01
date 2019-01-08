namespace CapaPresentacion.Tablas
{
    partial class frmArticulo
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
            this.cbo1Tipo = new System.Windows.Forms.ComboBox();
            this.txt1Modelo = new System.Windows.Forms.TextBox();
            this.btn1Nuevo = new System.Windows.Forms.Button();
            this.cbo1Estado = new System.Windows.Forms.ComboBox();
            this.btn1Modifica = new System.Windows.Forms.Button();
            this.txt1Nombre = new System.Windows.Forms.TextBox();
            this.txt1Codigo = new System.Windows.Forms.TextBox();
            this.txt1Ide = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn1Cancela = new System.Windows.Forms.Button();
            this.btn1Elimina = new System.Windows.Forms.Button();
            this.btn1Salir = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgv1Listado = new System.Windows.Forms.DataGridView();
            this.btn1Graba = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txt1Buscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab1Articulos = new System.Windows.Forms.TabPage();
            this.tab2Conceptos = new System.Windows.Forms.TabPage();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1Listado)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tab1Articulos.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbo1Tipo
            // 
            this.cbo1Tipo.FormattingEnabled = true;
            this.cbo1Tipo.Location = new System.Drawing.Point(516, 34);
            this.cbo1Tipo.Name = "cbo1Tipo";
            this.cbo1Tipo.Size = new System.Drawing.Size(121, 24);
            this.cbo1Tipo.TabIndex = 3;
            // 
            // txt1Modelo
            // 
            this.txt1Modelo.Location = new System.Drawing.Point(74, 94);
            this.txt1Modelo.MaxLength = 20;
            this.txt1Modelo.Name = "txt1Modelo";
            this.txt1Modelo.Size = new System.Drawing.Size(253, 23);
            this.txt1Modelo.TabIndex = 5;
            // 
            // btn1Nuevo
            // 
            this.btn1Nuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn1Nuevo.Image = global::CapaPresentacion.Properties.Resources.bnuevo;
            this.btn1Nuevo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn1Nuevo.Location = new System.Drawing.Point(182, 461);
            this.btn1Nuevo.Name = "btn1Nuevo";
            this.btn1Nuevo.Size = new System.Drawing.Size(72, 42);
            this.btn1Nuevo.TabIndex = 43;
            this.btn1Nuevo.Text = "&Nuevo";
            this.btn1Nuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn1Nuevo.UseVisualStyleBackColor = true;
            this.btn1Nuevo.Click += new System.EventHandler(this.btn1Nuevo_Click);
            // 
            // cbo1Estado
            // 
            this.cbo1Estado.FormattingEnabled = true;
            this.cbo1Estado.Location = new System.Drawing.Point(516, 4);
            this.cbo1Estado.Name = "cbo1Estado";
            this.cbo1Estado.Size = new System.Drawing.Size(121, 24);
            this.cbo1Estado.TabIndex = 1;
            // 
            // btn1Modifica
            // 
            this.btn1Modifica.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn1Modifica.Image = global::CapaPresentacion.Properties.Resources.beditar;
            this.btn1Modifica.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn1Modifica.Location = new System.Drawing.Point(261, 461);
            this.btn1Modifica.Name = "btn1Modifica";
            this.btn1Modifica.Size = new System.Drawing.Size(72, 42);
            this.btn1Modifica.TabIndex = 44;
            this.btn1Modifica.Text = "&Modifica";
            this.btn1Modifica.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn1Modifica.UseVisualStyleBackColor = true;
            this.btn1Modifica.Click += new System.EventHandler(this.btn1Modifica_Click);
            // 
            // txt1Nombre
            // 
            this.txt1Nombre.Location = new System.Drawing.Point(74, 64);
            this.txt1Nombre.MaxLength = 60;
            this.txt1Nombre.Name = "txt1Nombre";
            this.txt1Nombre.Size = new System.Drawing.Size(491, 23);
            this.txt1Nombre.TabIndex = 4;
            // 
            // txt1Codigo
            // 
            this.txt1Codigo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt1Codigo.Location = new System.Drawing.Point(74, 34);
            this.txt1Codigo.MaxLength = 16;
            this.txt1Codigo.Name = "txt1Codigo";
            this.txt1Codigo.Size = new System.Drawing.Size(100, 16);
            this.txt1Codigo.TabIndex = 2;
            // 
            // txt1Ide
            // 
            this.txt1Ide.Location = new System.Drawing.Point(74, 4);
            this.txt1Ide.Name = "txt1Ide";
            this.txt1Ide.Size = new System.Drawing.Size(100, 23);
            this.txt1Ide.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(439, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 17);
            this.label8.TabIndex = 33;
            this.label8.Text = "Estado";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(439, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 17);
            this.label5.TabIndex = 30;
            this.label5.Text = "Tipo ";
            // 
            // btn1Cancela
            // 
            this.btn1Cancela.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn1Cancela.Image = global::CapaPresentacion.Properties.Resources.bcancelar;
            this.btn1Cancela.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn1Cancela.Location = new System.Drawing.Point(419, 461);
            this.btn1Cancela.Name = "btn1Cancela";
            this.btn1Cancela.Size = new System.Drawing.Size(72, 42);
            this.btn1Cancela.TabIndex = 47;
            this.btn1Cancela.Text = "&Cancelar";
            this.btn1Cancela.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn1Cancela.UseVisualStyleBackColor = true;
            this.btn1Cancela.Click += new System.EventHandler(this.btn1Cancela_Click);
            // 
            // btn1Elimina
            // 
            this.btn1Elimina.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn1Elimina.Image = global::CapaPresentacion.Properties.Resources.bborrar;
            this.btn1Elimina.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn1Elimina.Location = new System.Drawing.Point(340, 461);
            this.btn1Elimina.Name = "btn1Elimina";
            this.btn1Elimina.Size = new System.Drawing.Size(72, 42);
            this.btn1Elimina.TabIndex = 45;
            this.btn1Elimina.Text = "&Elimina";
            this.btn1Elimina.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn1Elimina.UseVisualStyleBackColor = true;
            this.btn1Elimina.Click += new System.EventHandler(this.btn1Elimina_Click);
            // 
            // btn1Salir
            // 
            this.btn1Salir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn1Salir.Image = global::CapaPresentacion.Properties.Resources.bsalir;
            this.btn1Salir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn1Salir.Location = new System.Drawing.Point(577, 461);
            this.btn1Salir.Name = "btn1Salir";
            this.btn1Salir.Size = new System.Drawing.Size(72, 42);
            this.btn1Salir.TabIndex = 46;
            this.btn1Salir.Text = "&Salir";
            this.btn1Salir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn1Salir.UseVisualStyleBackColor = true;
            this.btn1Salir.Click += new System.EventHandler(this.btn1Salir_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 17);
            this.label4.TabIndex = 29;
            this.label4.Text = "Modelo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 28;
            this.label3.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 27;
            this.label2.Text = "Codigo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 17);
            this.label1.TabIndex = 26;
            this.label1.Text = "ID";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cbo1Estado);
            this.panel1.Controls.Add(this.cbo1Tipo);
            this.panel1.Controls.Add(this.txt1Modelo);
            this.panel1.Controls.Add(this.txt1Nombre);
            this.panel1.Controls.Add(this.txt1Codigo);
            this.panel1.Controls.Add(this.txt1Ide);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 329);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(653, 127);
            this.panel1.TabIndex = 50;
            // 
            // dgv1Listado
            // 
            this.dgv1Listado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv1Listado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1Listado.Location = new System.Drawing.Point(1, 36);
            this.dgv1Listado.Name = "dgv1Listado";
            this.dgv1Listado.Size = new System.Drawing.Size(653, 290);
            this.dgv1Listado.TabIndex = 49;
            this.dgv1Listado.CurrentCellChanged += new System.EventHandler(this.dgv1Listado_CurrentCellChanged);
            // 
            // btn1Graba
            // 
            this.btn1Graba.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn1Graba.Image = global::CapaPresentacion.Properties.Resources.bgrabar;
            this.btn1Graba.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn1Graba.Location = new System.Drawing.Point(498, 461);
            this.btn1Graba.Name = "btn1Graba";
            this.btn1Graba.Size = new System.Drawing.Size(72, 42);
            this.btn1Graba.TabIndex = 48;
            this.btn1Graba.Text = "&Grabar";
            this.btn1Graba.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn1Graba.UseVisualStyleBackColor = true;
            this.btn1Graba.Click += new System.EventHandler(this.btn1Graba_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 17);
            this.label6.TabIndex = 51;
            this.label6.Text = "Buscar ";
            // 
            // txt1Buscar
            // 
            this.txt1Buscar.Location = new System.Drawing.Point(74, 7);
            this.txt1Buscar.Name = "txt1Buscar";
            this.txt1Buscar.Size = new System.Drawing.Size(417, 23);
            this.txt1Buscar.TabIndex = 52;
            this.txt1Buscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = global::CapaPresentacion.Properties.Resources.Buscar_p;
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(498, 3);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(82, 28);
            this.btnBuscar.TabIndex = 53;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tab1Articulos);
            this.tabControl1.Controls.Add(this.tab2Conceptos);
            this.tabControl1.Location = new System.Drawing.Point(2, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(663, 539);
            this.tabControl1.TabIndex = 54;
            // 
            // tab1Articulos
            // 
            this.tab1Articulos.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tab1Articulos.Controls.Add(this.txt1Buscar);
            this.tab1Articulos.Controls.Add(this.btn1Nuevo);
            this.tab1Articulos.Controls.Add(this.btnBuscar);
            this.tab1Articulos.Controls.Add(this.btn1Modifica);
            this.tab1Articulos.Controls.Add(this.label6);
            this.tab1Articulos.Controls.Add(this.btn1Cancela);
            this.tab1Articulos.Controls.Add(this.dgv1Listado);
            this.tab1Articulos.Controls.Add(this.btn1Elimina);
            this.tab1Articulos.Controls.Add(this.panel1);
            this.tab1Articulos.Controls.Add(this.btn1Salir);
            this.tab1Articulos.Controls.Add(this.btn1Graba);
            this.tab1Articulos.Location = new System.Drawing.Point(4, 25);
            this.tab1Articulos.Name = "tab1Articulos";
            this.tab1Articulos.Padding = new System.Windows.Forms.Padding(3);
            this.tab1Articulos.Size = new System.Drawing.Size(655, 510);
            this.tab1Articulos.TabIndex = 0;
            this.tab1Articulos.Text = "     Articulos     ";
            // 
            // tab2Conceptos
            // 
            this.tab2Conceptos.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tab2Conceptos.Location = new System.Drawing.Point(4, 25);
            this.tab2Conceptos.Name = "tab2Conceptos";
            this.tab2Conceptos.Padding = new System.Windows.Forms.Padding(3);
            this.tab2Conceptos.Size = new System.Drawing.Size(655, 510);
            this.tab2Conceptos.TabIndex = 1;
            this.tab2Conceptos.Text = "     Conceptos de Facturacion     ";
            // 
            // frmArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 541);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmArticulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Articulo";
            this.Load += new System.EventHandler(this.frmArticulo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1Listado)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tab1Articulos.ResumeLayout(false);
            this.tab1Articulos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbo1Tipo;
        private System.Windows.Forms.TextBox txt1Modelo;
        private System.Windows.Forms.Button btn1Nuevo;
        private System.Windows.Forms.ComboBox cbo1Estado;
        private System.Windows.Forms.Button btn1Modifica;
        private System.Windows.Forms.TextBox txt1Nombre;
        private System.Windows.Forms.TextBox txt1Codigo;
        private System.Windows.Forms.TextBox txt1Ide;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn1Cancela;
        private System.Windows.Forms.Button btn1Elimina;
        private System.Windows.Forms.Button btn1Salir;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgv1Listado;
        private System.Windows.Forms.Button btn1Graba;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt1Buscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tab1Articulos;
        private System.Windows.Forms.TabPage tab2Conceptos;
    }
}