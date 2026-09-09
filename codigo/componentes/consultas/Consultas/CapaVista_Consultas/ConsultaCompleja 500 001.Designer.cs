namespace CapaVista_Consultas
{
    partial class ConsultaCompleja_500_001
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaCompleja_500_001));
            this.tablaCompleja1 = new CapaVista_Consultas.TablaCompleja();
            this.condicionesLogica1 = new CapaVista_Consultas.CondicionesLogica();
            this.consultasReutilizables1 = new CapaVista_Consultas.ConsultasReutilizables();
            this.condicionesComparacion1 = new CapaVista_Consultas.CondicionesComparacion();
            this.agrupar_Ordenar1 = new CapaVista_Consultas.Agrupar_Ordenar();
            this.botonesConsulta1 = new CapaVista_Consultas.BotonesConsulta();
            this.ConsultasBtnInicio = new System.Windows.Forms.Button();
            this.ConsultasGbxFiltros = new System.Windows.Forms.GroupBox();
            this.ConsultasDgvFiltros = new System.Windows.Forms.DataGridView();
            this.ColNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColOperador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCampo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConsultasGbxFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ConsultasDgvFiltros)).BeginInit();
            this.SuspendLayout();
            // 
            // tablaCompleja1
            // 
            this.tablaCompleja1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.tablaCompleja1.Location = new System.Drawing.Point(12, 8);
            this.tablaCompleja1.Name = "tablaCompleja1";
            this.tablaCompleja1.Size = new System.Drawing.Size(794, 196);
            this.tablaCompleja1.TabIndex = 4;
            // 
            // condicionesLogica1
            // 
            this.condicionesLogica1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.condicionesLogica1.Location = new System.Drawing.Point(12, 214);
            this.condicionesLogica1.Margin = new System.Windows.Forms.Padding(2);
            this.condicionesLogica1.Name = "condicionesLogica1";
            this.condicionesLogica1.Size = new System.Drawing.Size(459, 320);
            this.condicionesLogica1.TabIndex = 3;
            // 
            // consultasReutilizables1
            // 
            this.consultasReutilizables1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.consultasReutilizables1.Location = new System.Drawing.Point(818, 8);
            this.consultasReutilizables1.Name = "consultasReutilizables1";
            this.consultasReutilizables1.Size = new System.Drawing.Size(424, 150);
            this.consultasReutilizables1.TabIndex = 2;
            // 
            // condicionesComparacion1
            // 
            this.condicionesComparacion1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.condicionesComparacion1.Location = new System.Drawing.Point(479, 214);
            this.condicionesComparacion1.Margin = new System.Windows.Forms.Padding(2);
            this.condicionesComparacion1.Name = "condicionesComparacion1";
            this.condicionesComparacion1.Size = new System.Drawing.Size(391, 320);
            this.condicionesComparacion1.TabIndex = 1;
            // 
            // agrupar_Ordenar1
            // 
            this.agrupar_Ordenar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.agrupar_Ordenar1.Location = new System.Drawing.Point(12, 540);
            this.agrupar_Ordenar1.Name = "agrupar_Ordenar1";
            this.agrupar_Ordenar1.Size = new System.Drawing.Size(860, 62);
            this.agrupar_Ordenar1.TabIndex = 0;
            // 
            // botonesConsulta1
            // 
            this.botonesConsulta1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(231)))), ((int)(((byte)(218)))));
            this.botonesConsulta1.Location = new System.Drawing.Point(0, 606);
            this.botonesConsulta1.Name = "botonesConsulta1";
            this.botonesConsulta1.Size = new System.Drawing.Size(1254, 58);
            this.botonesConsulta1.TabIndex = 5;
            // 
            // ConsultasBtnInicio
            // 
            this.ConsultasBtnInicio.Location = new System.Drawing.Point(1132, 166);
            this.ConsultasBtnInicio.Name = "ConsultasBtnInicio";
            this.ConsultasBtnInicio.Size = new System.Drawing.Size(110, 42);
            this.ConsultasBtnInicio.TabIndex = 0;
            this.ConsultasBtnInicio.Text = "Inicio";
            this.ConsultasBtnInicio.UseVisualStyleBackColor = true;
            this.ConsultasBtnInicio.Click += new System.EventHandler(this.ConsultasBtnInicio_Click);
            // 
            // ConsultasGbxFiltros
            // 
            this.ConsultasGbxFiltros.Controls.Add(this.ConsultasDgvFiltros);
            this.ConsultasGbxFiltros.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConsultasGbxFiltros.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(74)))), ((int)(((byte)(99)))));
            this.ConsultasGbxFiltros.Location = new System.Drawing.Point(878, 286);
            this.ConsultasGbxFiltros.Name = "ConsultasGbxFiltros";
            this.ConsultasGbxFiltros.Size = new System.Drawing.Size(364, 312);
            this.ConsultasGbxFiltros.TabIndex = 6;
            this.ConsultasGbxFiltros.TabStop = false;
            this.ConsultasGbxFiltros.Text = "Filtros aplicados";
            // 
            // ConsultasDgvFiltros
            // 
            this.ConsultasDgvFiltros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ConsultasDgvFiltros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColNumero,
            this.ColTipo,
            this.ColOperador,
            this.ColCampo,
            this.ColValor});
            this.ConsultasDgvFiltros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConsultasDgvFiltros.Location = new System.Drawing.Point(3, 24);
            this.ConsultasDgvFiltros.Name = "ConsultasDgvFiltros";
            this.ConsultasDgvFiltros.RowHeadersWidth = 51;
            this.ConsultasDgvFiltros.RowTemplate.Height = 24;
            this.ConsultasDgvFiltros.Size = new System.Drawing.Size(358, 285);
            this.ConsultasDgvFiltros.TabIndex = 0;
            // 
            // ColNumero
            // 
            this.ColNumero.FillWeight = 10F;
            this.ColNumero.HeaderText = "No. ";
            this.ColNumero.MinimumWidth = 35;
            this.ColNumero.Name = "ColNumero";
            this.ColNumero.Width = 125;
            // 
            // ColTipo
            // 
            this.ColTipo.FillWeight = 24F;
            this.ColTipo.HeaderText = "Tipo";
            this.ColTipo.MinimumWidth = 70;
            this.ColTipo.Name = "ColTipo";
            this.ColTipo.Width = 125;
            // 
            // ColOperador
            // 
            this.ColOperador.FillWeight = 20F;
            this.ColOperador.HeaderText = "Operador";
            this.ColOperador.MinimumWidth = 60;
            this.ColOperador.Name = "ColOperador";
            this.ColOperador.Width = 125;
            // 
            // ColCampo
            // 
            this.ColCampo.FillWeight = 24F;
            this.ColCampo.HeaderText = "Campo";
            this.ColCampo.MinimumWidth = 70;
            this.ColCampo.Name = "ColCampo";
            this.ColCampo.Width = 125;
            // 
            // ColValor
            // 
            this.ColValor.FillWeight = 22F;
            this.ColValor.HeaderText = "Valor";
            this.ColValor.MinimumWidth = 65;
            this.ColValor.Name = "ColValor";
            this.ColValor.Width = 125;
            // 
            // ConsultaCompleja_500_001
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(231)))), ((int)(((byte)(218)))));
            this.ClientSize = new System.Drawing.Size(1242, 662);
            this.Controls.Add(this.ConsultasGbxFiltros);
            this.Controls.Add(this.ConsultasBtnInicio);
            this.Controls.Add(this.botonesConsulta1);
            this.Controls.Add(this.tablaCompleja1);
            this.Controls.Add(this.condicionesLogica1);
            this.Controls.Add(this.consultasReutilizables1);
            this.Controls.Add(this.condicionesComparacion1);
            this.Controls.Add(this.agrupar_Ordenar1);
            this.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1254, 672);
            this.Name = "ConsultaCompleja_500_001";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "4002 – ConsultasComplejas";
            this.ConsultasGbxFiltros.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ConsultasDgvFiltros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Agrupar_Ordenar agrupar_Ordenar1;
        private CondicionesComparacion condicionesComparacion1;
        private ConsultasReutilizables consultasReutilizables1;
        private CondicionesLogica condicionesLogica1;
        private TablaCompleja tablaCompleja1;
        private BotonesConsulta botonesConsulta1;
        private System.Windows.Forms.Button ConsultasBtnInicio;
        private System.Windows.Forms.GroupBox ConsultasGbxFiltros;
        private System.Windows.Forms.DataGridView ConsultasDgvFiltros;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNumero;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColOperador;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCampo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColValor;
    }
}