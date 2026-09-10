namespace CapaVista_Consultas
{
    partial class FiltrosAplicados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FiltrosAplicados));
            this.ConsultasTlpPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.ConsultasDgvConsultasFiltros = new System.Windows.Forms.DataGridView();
            this.Columna1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.ConsultasBtnConsultar = new System.Windows.Forms.Button();
            this.ConsultasBtnGuardar = new System.Windows.Forms.Button();
            this.ConsultasBtnEliminar = new System.Windows.Forms.Button();
            this.ConsultasTlpPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ConsultasDgvConsultasFiltros)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ConsultasTlpPrincipal
            // 
            this.ConsultasTlpPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(231)))), ((int)(((byte)(218)))));
            this.ConsultasTlpPrincipal.ColumnCount = 2;
            this.ConsultasTlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ConsultasTlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.ConsultasTlpPrincipal.Controls.Add(this.ConsultasDgvConsultasFiltros, 0, 0);
            this.ConsultasTlpPrincipal.Controls.Add(this.flowLayoutPanel1, 1, 0);
            this.ConsultasTlpPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConsultasTlpPrincipal.Location = new System.Drawing.Point(0, 0);
            this.ConsultasTlpPrincipal.Name = "ConsultasTlpPrincipal";
            this.ConsultasTlpPrincipal.RowCount = 1;
            this.ConsultasTlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ConsultasTlpPrincipal.Size = new System.Drawing.Size(597, 296);
            this.ConsultasTlpPrincipal.TabIndex = 1;
            // 
            // ConsultasDgvConsultasFiltros
            // 
            this.ConsultasDgvConsultasFiltros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ConsultasDgvConsultasFiltros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Columna1,
            this.Column1,
            this.Column2});
            this.ConsultasDgvConsultasFiltros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConsultasDgvConsultasFiltros.Location = new System.Drawing.Point(3, 3);
            this.ConsultasDgvConsultasFiltros.Name = "ConsultasDgvConsultasFiltros";
            this.ConsultasDgvConsultasFiltros.RowHeadersWidth = 51;
            this.ConsultasDgvConsultasFiltros.RowTemplate.Height = 24;
            this.ConsultasDgvConsultasFiltros.Size = new System.Drawing.Size(531, 290);
            this.ConsultasDgvConsultasFiltros.TabIndex = 0;
            // 
            // Columna1
            // 
            this.Columna1.HeaderText = "No.";
            this.Columna1.MinimumWidth = 6;
            this.Columna1.Name = "Columna1";
            this.Columna1.Width = 125;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Tipo";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Filtro";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.ConsultasBtnConsultar);
            this.flowLayoutPanel1.Controls.Add(this.ConsultasBtnGuardar);
            this.flowLayoutPanel1.Controls.Add(this.ConsultasBtnEliminar);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(540, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(54, 290);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // ConsultasBtnConsultar
            // 
            this.ConsultasBtnConsultar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ConsultasBtnConsultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(231)))), ((int)(((byte)(218)))));
            this.ConsultasBtnConsultar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ConsultasBtnConsultar.BackgroundImage")));
            this.ConsultasBtnConsultar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ConsultasBtnConsultar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ConsultasBtnConsultar.FlatAppearance.BorderSize = 0;
            this.ConsultasBtnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConsultasBtnConsultar.Location = new System.Drawing.Point(0, 0);
            this.ConsultasBtnConsultar.Margin = new System.Windows.Forms.Padding(0);
            this.ConsultasBtnConsultar.MaximumSize = new System.Drawing.Size(50, 50);
            this.ConsultasBtnConsultar.MinimumSize = new System.Drawing.Size(50, 50);
            this.ConsultasBtnConsultar.Name = "ConsultasBtnConsultar";
            this.ConsultasBtnConsultar.Size = new System.Drawing.Size(50, 50);
            this.ConsultasBtnConsultar.TabIndex = 0;
            this.ConsultasBtnConsultar.UseVisualStyleBackColor = false;
            // 
            // ConsultasBtnGuardar
            // 
            this.ConsultasBtnGuardar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ConsultasBtnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(231)))), ((int)(((byte)(218)))));
            this.ConsultasBtnGuardar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ConsultasBtnGuardar.BackgroundImage")));
            this.ConsultasBtnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ConsultasBtnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ConsultasBtnGuardar.FlatAppearance.BorderSize = 0;
            this.ConsultasBtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConsultasBtnGuardar.Location = new System.Drawing.Point(0, 50);
            this.ConsultasBtnGuardar.Margin = new System.Windows.Forms.Padding(0);
            this.ConsultasBtnGuardar.MaximumSize = new System.Drawing.Size(50, 50);
            this.ConsultasBtnGuardar.MinimumSize = new System.Drawing.Size(50, 50);
            this.ConsultasBtnGuardar.Name = "ConsultasBtnGuardar";
            this.ConsultasBtnGuardar.Size = new System.Drawing.Size(50, 50);
            this.ConsultasBtnGuardar.TabIndex = 1;
            this.ConsultasBtnGuardar.UseVisualStyleBackColor = false;
            // 
            // ConsultasBtnEliminar
            // 
            this.ConsultasBtnEliminar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ConsultasBtnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(231)))), ((int)(((byte)(218)))));
            this.ConsultasBtnEliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ConsultasBtnEliminar.BackgroundImage")));
            this.ConsultasBtnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ConsultasBtnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ConsultasBtnEliminar.FlatAppearance.BorderSize = 0;
            this.ConsultasBtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConsultasBtnEliminar.Location = new System.Drawing.Point(0, 100);
            this.ConsultasBtnEliminar.Margin = new System.Windows.Forms.Padding(0);
            this.ConsultasBtnEliminar.MaximumSize = new System.Drawing.Size(50, 50);
            this.ConsultasBtnEliminar.MinimumSize = new System.Drawing.Size(50, 50);
            this.ConsultasBtnEliminar.Name = "ConsultasBtnEliminar";
            this.ConsultasBtnEliminar.Size = new System.Drawing.Size(50, 50);
            this.ConsultasBtnEliminar.TabIndex = 2;
            this.ConsultasBtnEliminar.UseVisualStyleBackColor = false;
            // 
            // FiltrosAplicados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ConsultasTlpPrincipal);
            this.Name = "FiltrosAplicados";
            this.Size = new System.Drawing.Size(597, 296);
            this.ConsultasTlpPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ConsultasDgvConsultasFiltros)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel ConsultasTlpPrincipal;
        private System.Windows.Forms.DataGridView ConsultasDgvConsultasFiltros;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button ConsultasBtnConsultar;
        private System.Windows.Forms.Button ConsultasBtnGuardar;
        private System.Windows.Forms.Button ConsultasBtnEliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Columna1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}
