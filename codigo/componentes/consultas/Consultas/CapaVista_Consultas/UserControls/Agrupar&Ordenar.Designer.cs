namespace CapaVista_Consultas
{
    partial class Agrupar_Ordenar
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ConsultasRdoDesc = new System.Windows.Forms.RadioButton();
            this.ConsultasRdoAsc = new System.Windows.Forms.RadioButton();
            this.ConsultasCboModo = new System.Windows.Forms.ComboBox();
            this.ConsultasCboCampo = new System.Windows.Forms.ComboBox();
            this.ConsultasCboOperador = new System.Windows.Forms.ComboBox();
            this.ConsultasTxtValor = new System.Windows.Forms.TextBox();
            this.ConsultasBtnFiltrar = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Agrupar - Ordenar";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(223, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Agrupar - Ordenar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(407, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Campo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(564, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 32);
            this.label4.TabIndex = 8;
            this.label4.Text = "Agrupar - Ordenar";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(678, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Valor";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolTip;
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.46809F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.53191F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 157F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 114F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 123F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.tableLayoutPanel1.Controls.Add(this.label5, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.ConsultasCboModo, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.ConsultasCboCampo, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.ConsultasCboOperador, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.ConsultasTxtValor, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.ConsultasBtnFiltrar, 5, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1, 1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.07463F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 64.92538F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(856, 134);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ConsultasRdoDesc);
            this.groupBox1.Controls.Add(this.ConsultasRdoAsc);
            this.groupBox1.Location = new System.Drawing.Point(3, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(214, 74);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ordenamiento";
            // 
            // ConsultasRdoDesc
            // 
            this.ConsultasRdoDesc.AutoSize = true;
            this.ConsultasRdoDesc.Location = new System.Drawing.Point(105, 19);
            this.ConsultasRdoDesc.Name = "ConsultasRdoDesc";
            this.ConsultasRdoDesc.Size = new System.Drawing.Size(65, 20);
            this.ConsultasRdoDesc.TabIndex = 0;
            this.ConsultasRdoDesc.TabStop = true;
            this.ConsultasRdoDesc.Text = "DESC";
            this.ConsultasRdoDesc.UseVisualStyleBackColor = true;
            // 
            // ConsultasRdoAsc
            // 
            this.ConsultasRdoAsc.AutoSize = true;
            this.ConsultasRdoAsc.Location = new System.Drawing.Point(3, 19);
            this.ConsultasRdoAsc.Name = "ConsultasRdoAsc";
            this.ConsultasRdoAsc.Size = new System.Drawing.Size(55, 20);
            this.ConsultasRdoAsc.TabIndex = 2;
            this.ConsultasRdoAsc.TabStop = true;
            this.ConsultasRdoAsc.Text = "ASC";
            this.ConsultasRdoAsc.UseVisualStyleBackColor = true;
            this.ConsultasRdoAsc.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // ConsultasCboModo
            // 
            this.ConsultasCboModo.FormattingEnabled = true;
            this.ConsultasCboModo.Location = new System.Drawing.Point(223, 50);
            this.ConsultasCboModo.Name = "ConsultasCboModo";
            this.ConsultasCboModo.Size = new System.Drawing.Size(121, 24);
            this.ConsultasCboModo.TabIndex = 2;
            // 
            // ConsultasCboCampo
            // 
            this.ConsultasCboCampo.FormattingEnabled = true;
            this.ConsultasCboCampo.Location = new System.Drawing.Point(407, 50);
            this.ConsultasCboCampo.Name = "ConsultasCboCampo";
            this.ConsultasCboCampo.Size = new System.Drawing.Size(121, 24);
            this.ConsultasCboCampo.TabIndex = 3;
            // 
            // ConsultasCboOperador
            // 
            this.ConsultasCboOperador.FormattingEnabled = true;
            this.ConsultasCboOperador.Location = new System.Drawing.Point(564, 50);
            this.ConsultasCboOperador.Name = "ConsultasCboOperador";
            this.ConsultasCboOperador.Size = new System.Drawing.Size(89, 24);
            this.ConsultasCboOperador.TabIndex = 4;
            // 
            // ConsultasTxtValor
            // 
            this.ConsultasTxtValor.Location = new System.Drawing.Point(678, 50);
            this.ConsultasTxtValor.Name = "ConsultasTxtValor";
            this.ConsultasTxtValor.Size = new System.Drawing.Size(98, 22);
            this.ConsultasTxtValor.TabIndex = 5;
            // 
            // ConsultasBtnFiltrar
            // 
            this.ConsultasBtnFiltrar.Location = new System.Drawing.Point(801, 50);
            this.ConsultasBtnFiltrar.Name = "ConsultasBtnFiltrar";
            this.ConsultasBtnFiltrar.Size = new System.Drawing.Size(51, 23);
            this.ConsultasBtnFiltrar.TabIndex = 10;
            this.ConsultasBtnFiltrar.Text = "Filtrar";
            this.ConsultasBtnFiltrar.UseVisualStyleBackColor = true;
            this.ConsultasBtnFiltrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // Agrupar_Ordenar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Agrupar_Ordenar";
            this.Size = new System.Drawing.Size(857, 135);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton ConsultasRdoDesc;
        private System.Windows.Forms.RadioButton ConsultasRdoAsc;
        private System.Windows.Forms.ComboBox ConsultasCboModo;
        private System.Windows.Forms.ComboBox ConsultasCboCampo;
        private System.Windows.Forms.ComboBox ConsultasCboOperador;
        private System.Windows.Forms.TextBox ConsultasTxtValor;
        private System.Windows.Forms.Button ConsultasBtnFiltrar;
    }
}
