namespace CapaVista_Consultas.UserControls
{
    partial class TablaSimple
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ConsultasDgvSimples = new System.Windows.Forms.DataGridView();
            this.ConsultasTlpPaginacion = new System.Windows.Forms.TableLayoutPanel();
            this.ConsultasBtnAnterior = new System.Windows.Forms.Button();
            this.ConsultasBtnSiguiente = new System.Windows.Forms.Button();
            this.ConsultasFlpPaginas = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ConsultasDgvSimples)).BeginInit();
            this.ConsultasTlpPaginacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.ConsultasTlpPaginacion, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.ConsultasDgvSimples, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.01629F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.98371F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(871, 614);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // ConsultasDgvSimples
            // 
            this.ConsultasDgvSimples.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ConsultasDgvSimples.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(231)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(74)))), ((int)(((byte)(99)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(128)))), ((int)(((byte)(120)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ConsultasDgvSimples.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ConsultasDgvSimples.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ConsultasDgvSimples.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConsultasDgvSimples.Location = new System.Drawing.Point(3, 3);
            this.ConsultasDgvSimples.Name = "ConsultasDgvSimples";
            this.ConsultasDgvSimples.RowHeadersWidth = 51;
            this.ConsultasDgvSimples.RowTemplate.Height = 24;
            this.ConsultasDgvSimples.Size = new System.Drawing.Size(865, 516);
            this.ConsultasDgvSimples.TabIndex = 1;
            // 
            // ConsultasTlpPaginacion
            // 
            this.ConsultasTlpPaginacion.ColumnCount = 3;
            this.ConsultasTlpPaginacion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.81741F));
            this.ConsultasTlpPaginacion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.40977F));
            this.ConsultasTlpPaginacion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.87898F));
            this.ConsultasTlpPaginacion.Controls.Add(this.ConsultasBtnAnterior, 0, 0);
            this.ConsultasTlpPaginacion.Controls.Add(this.ConsultasBtnSiguiente, 2, 0);
            this.ConsultasTlpPaginacion.Controls.Add(this.ConsultasFlpPaginas, 1, 0);
            this.ConsultasTlpPaginacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConsultasTlpPaginacion.Location = new System.Drawing.Point(3, 525);
            this.ConsultasTlpPaginacion.Name = "ConsultasTlpPaginacion";
            this.ConsultasTlpPaginacion.RowCount = 1;
            this.ConsultasTlpPaginacion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ConsultasTlpPaginacion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.ConsultasTlpPaginacion.Size = new System.Drawing.Size(865, 86);
            this.ConsultasTlpPaginacion.TabIndex = 3;
            // 
            // ConsultasBtnAnterior
            // 
            this.ConsultasBtnAnterior.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConsultasBtnAnterior.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(87)))), ((int)(((byte)(63)))));
            this.ConsultasBtnAnterior.Location = new System.Drawing.Point(3, 3);
            this.ConsultasBtnAnterior.Name = "ConsultasBtnAnterior";
            this.ConsultasBtnAnterior.Size = new System.Drawing.Size(130, 80);
            this.ConsultasBtnAnterior.TabIndex = 0;
            this.ConsultasBtnAnterior.Text = "Atras";
            this.ConsultasBtnAnterior.UseVisualStyleBackColor = true;
            // 
            // ConsultasBtnSiguiente
            // 
            this.ConsultasBtnSiguiente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConsultasBtnSiguiente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(87)))), ((int)(((byte)(63)))));
            this.ConsultasBtnSiguiente.Location = new System.Drawing.Point(721, 3);
            this.ConsultasBtnSiguiente.Name = "ConsultasBtnSiguiente";
            this.ConsultasBtnSiguiente.Size = new System.Drawing.Size(141, 80);
            this.ConsultasBtnSiguiente.TabIndex = 1;
            this.ConsultasBtnSiguiente.Text = "Adelante";
            this.ConsultasBtnSiguiente.UseVisualStyleBackColor = true;
            // 
            // ConsultasFlpPaginas
            // 
            this.ConsultasFlpPaginas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConsultasFlpPaginas.Location = new System.Drawing.Point(139, 3);
            this.ConsultasFlpPaginas.Name = "ConsultasFlpPaginas";
            this.ConsultasFlpPaginas.Size = new System.Drawing.Size(576, 80);
            this.ConsultasFlpPaginas.TabIndex = 2;
            // 
            // TablaSimple2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(231)))), ((int)(((byte)(218)))));
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "TablaSimple2";
            this.Size = new System.Drawing.Size(871, 614);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ConsultasDgvSimples)).EndInit();
            this.ConsultasTlpPaginacion.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView ConsultasDgvSimples;
        private System.Windows.Forms.TableLayoutPanel ConsultasTlpPaginacion;
        private System.Windows.Forms.Button ConsultasBtnAnterior;
        private System.Windows.Forms.Button ConsultasBtnSiguiente;
        private System.Windows.Forms.FlowLayoutPanel ConsultasFlpPaginas;
    }
}
