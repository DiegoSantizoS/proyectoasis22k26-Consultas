namespace CapaVista_Consultas
{
    partial class FrmConsultasSimples
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultasSimples));
            this.ConsultasTlpPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.ConsultasUcTablaSimple = new CapaVista_Consultas.Controles.UcTabla();
            this.ConsultasGbxAgregarFiltro = new CapaVista_Consultas.Componentes.ClsGrupoConsultas();
            this.ConsultasUcAgregarFiltro = new CapaVista_Consultas.Controles.UcAgregarFiltro();
            this.ConsultasBtnComplejas = new CapaVista_Consultas.Componentes.ClsBotonConsultas();
            this.ConsultasTlpPrincipal.SuspendLayout();
            this.ConsultasGbxAgregarFiltro.SuspendLayout();
            this.SuspendLayout();
            // 
            // ConsultasTlpPrincipal
            // 
            this.ConsultasTlpPrincipal.ColumnCount = 2;
            this.ConsultasTlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ConsultasTlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 91F));
            this.ConsultasTlpPrincipal.Controls.Add(this.ConsultasUcTablaSimple, 0, 1);
            this.ConsultasTlpPrincipal.Controls.Add(this.ConsultasGbxAgregarFiltro, 0, 0);
            this.ConsultasTlpPrincipal.Controls.Add(this.ConsultasBtnComplejas, 1, 0);
            this.ConsultasTlpPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConsultasTlpPrincipal.Location = new System.Drawing.Point(0, 0);
            this.ConsultasTlpPrincipal.Margin = new System.Windows.Forms.Padding(0);
            this.ConsultasTlpPrincipal.Name = "ConsultasTlpPrincipal";
            this.ConsultasTlpPrincipal.RowCount = 2;
            this.ConsultasTlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.ConsultasTlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ConsultasTlpPrincipal.Size = new System.Drawing.Size(982, 678);
            this.ConsultasTlpPrincipal.TabIndex = 19;
            // 
            // ConsultasUcTablaSimple
            // 
            this.ConsultasUcTablaSimple.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(231)))), ((int)(((byte)(218)))));
            this.ConsultasTlpPrincipal.SetColumnSpan(this.ConsultasUcTablaSimple, 2);
            this.ConsultasUcTablaSimple.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConsultasUcTablaSimple.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ConsultasUcTablaSimple.Location = new System.Drawing.Point(5, 155);
            this.ConsultasUcTablaSimple.Margin = new System.Windows.Forms.Padding(5);
            this.ConsultasUcTablaSimple.Name = "ConsultasUcTablaSimple";
            this.ConsultasUcTablaSimple.Size = new System.Drawing.Size(972, 518);
            this.ConsultasUcTablaSimple.TabIndex = 18;
            // 
            // ConsultasGbxAgregarFiltro
            // 
            this.ConsultasGbxAgregarFiltro.BackColor = System.Drawing.Color.Transparent;
            this.ConsultasGbxAgregarFiltro.Controls.Add(this.ConsultasUcAgregarFiltro);
            this.ConsultasGbxAgregarFiltro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConsultasGbxAgregarFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConsultasGbxAgregarFiltro.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.ConsultasGbxAgregarFiltro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(74)))), ((int)(((byte)(99)))));
            this.ConsultasGbxAgregarFiltro.Location = new System.Drawing.Point(10, 5);
            this.ConsultasGbxAgregarFiltro.Margin = new System.Windows.Forms.Padding(10, 5, 5, 5);
            this.ConsultasGbxAgregarFiltro.Name = "ConsultasGbxAgregarFiltro";
            this.ConsultasGbxAgregarFiltro.Padding = new System.Windows.Forms.Padding(0);
            this.ConsultasGbxAgregarFiltro.Size = new System.Drawing.Size(876, 140);
            this.ConsultasGbxAgregarFiltro.TabIndex = 19;
            this.ConsultasGbxAgregarFiltro.TabStop = false;
            this.ConsultasGbxAgregarFiltro.Text = "Agregar Filtro";
            // 
            // ConsultasUcAgregarFiltro
            // 
            this.ConsultasUcAgregarFiltro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ConsultasUcAgregarFiltro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(231)))), ((int)(((byte)(218)))));
            this.ConsultasUcAgregarFiltro.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ConsultasUcAgregarFiltro.Location = new System.Drawing.Point(0, 21);
            this.ConsultasUcAgregarFiltro.Margin = new System.Windows.Forms.Padding(5);
            this.ConsultasUcAgregarFiltro.Name = "ConsultasUcAgregarFiltro";
            this.ConsultasUcAgregarFiltro.Size = new System.Drawing.Size(876, 100);
            this.ConsultasUcAgregarFiltro.TabIndex = 0;
            // 
            // ConsultasBtnComplejas
            // 
            this.ConsultasBtnComplejas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ConsultasBtnComplejas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(231)))), ((int)(((byte)(218)))));
            this.ConsultasBtnComplejas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ConsultasBtnComplejas.BackgroundImage")));
            this.ConsultasBtnComplejas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ConsultasBtnComplejas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ConsultasBtnComplejas.FlatAppearance.BorderSize = 0;
            this.ConsultasBtnComplejas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConsultasBtnComplejas.Location = new System.Drawing.Point(896, 35);
            this.ConsultasBtnComplejas.Margin = new System.Windows.Forms.Padding(5);
            this.ConsultasBtnComplejas.MaximumSize = new System.Drawing.Size(80, 80);
            this.ConsultasBtnComplejas.MinimumSize = new System.Drawing.Size(80, 80);
            this.ConsultasBtnComplejas.Name = "ConsultasBtnComplejas";
            this.ConsultasBtnComplejas.Size = new System.Drawing.Size(80, 80);
            this.ConsultasBtnComplejas.TabIndex = 21;
            this.ConsultasBtnComplejas.UseVisualStyleBackColor = false;
            this.ConsultasBtnComplejas.Click += new System.EventHandler(this.ConsultasBtnComplejas_Click_1);
            // 
            // FrmConsultasSimples
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(231)))), ((int)(((byte)(218)))));
            this.ClientSize = new System.Drawing.Size(982, 678);
            this.Controls.Add(this.ConsultasTlpPrincipal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(1000, 725);
            this.Name = "FrmConsultasSimples";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "4001 - ConsultasSimples";
            this.ConsultasTlpPrincipal.ResumeLayout(false);
            this.ConsultasGbxAgregarFiltro.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel ConsultasTlpPrincipal;
        private Componentes.ClsGrupoConsultas ConsultasGbxAgregarFiltro;
        private Controles.UcAgregarFiltro ConsultasUcAgregarFiltro;
        private Componentes.ClsBotonConsultas ConsultasBtnComplejas;
        private Controles.UcTabla ConsultasUcTablaSimple;
    }
}