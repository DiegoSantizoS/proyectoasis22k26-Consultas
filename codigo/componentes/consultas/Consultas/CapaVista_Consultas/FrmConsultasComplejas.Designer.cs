namespace CapaVista_Consultas
{
    partial class FrmConsultasComplejas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultasComplejas));
            this.ConsultasTlpPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.ConsultasBtnRefrescar = new CapaVista_Consultas.ClsBotonConsultas();
            this.ConsultasBtnSalir = new CapaVista_Consultas.ClsBotonConsultas();
            this.clsGrupoConsultas1 = new CapaVista_Consultas.Components.ClsGrupoConsultas();
            this.clsListaDesplegableConsultas1 = new CapaVista_Consultas.Components.ClsListaDesplegableConsultas();
            this.clsGrupoConsultas2 = new CapaVista_Consultas.Components.ClsGrupoConsultas();
            this.ucConsultasReutilizables1 = new CapaVista_Consultas.UcConsultasReutilizables();
            this.ConsultasUcTabla = new CapaVista_Consultas.UserControls.UcTablaSimple();
            this.ConsultasTlpPrincipal.SuspendLayout();
            this.clsGrupoConsultas1.SuspendLayout();
            this.clsGrupoConsultas2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ConsultasTlpPrincipal
            // 
            this.ConsultasTlpPrincipal.ColumnCount = 3;
            this.ConsultasTlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 400F));
            this.ConsultasTlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ConsultasTlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.ConsultasTlpPrincipal.Controls.Add(this.ConsultasBtnRefrescar, 2, 1);
            this.ConsultasTlpPrincipal.Controls.Add(this.ConsultasBtnSalir, 2, 0);
            this.ConsultasTlpPrincipal.Controls.Add(this.clsGrupoConsultas1, 0, 0);
            this.ConsultasTlpPrincipal.Controls.Add(this.clsGrupoConsultas2, 0, 2);
            this.ConsultasTlpPrincipal.Controls.Add(this.ConsultasUcTabla, 1, 0);
            this.ConsultasTlpPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConsultasTlpPrincipal.Location = new System.Drawing.Point(0, 0);
            this.ConsultasTlpPrincipal.Margin = new System.Windows.Forms.Padding(0);
            this.ConsultasTlpPrincipal.MinimumSize = new System.Drawing.Size(1230, 700);
            this.ConsultasTlpPrincipal.Name = "ConsultasTlpPrincipal";
            this.ConsultasTlpPrincipal.RowCount = 4;
            this.ConsultasTlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.ConsultasTlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.ConsultasTlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 400F));
            this.ConsultasTlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ConsultasTlpPrincipal.Size = new System.Drawing.Size(1332, 703);
            this.ConsultasTlpPrincipal.TabIndex = 15;
            // 
            // ConsultasBtnRefrescar
            // 
            this.ConsultasBtnRefrescar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ConsultasBtnRefrescar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(231)))), ((int)(((byte)(218)))));
            this.ConsultasBtnRefrescar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ConsultasBtnRefrescar.BackgroundImage")));
            this.ConsultasBtnRefrescar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ConsultasBtnRefrescar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ConsultasBtnRefrescar.FlatAppearance.BorderSize = 0;
            this.ConsultasBtnRefrescar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConsultasBtnRefrescar.Location = new System.Drawing.Point(1248, 96);
            this.ConsultasBtnRefrescar.Margin = new System.Windows.Forms.Padding(6);
            this.ConsultasBtnRefrescar.MaximumSize = new System.Drawing.Size(80, 80);
            this.ConsultasBtnRefrescar.MinimumSize = new System.Drawing.Size(80, 80);
            this.ConsultasBtnRefrescar.Name = "ConsultasBtnRefrescar";
            this.ConsultasBtnRefrescar.Size = new System.Drawing.Size(80, 80);
            this.ConsultasBtnRefrescar.TabIndex = 19;
            this.ConsultasBtnRefrescar.UseVisualStyleBackColor = false;
            // 
            // ConsultasBtnSalir
            // 
            this.ConsultasBtnSalir.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ConsultasBtnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(231)))), ((int)(((byte)(218)))));
            this.ConsultasBtnSalir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ConsultasBtnSalir.BackgroundImage")));
            this.ConsultasBtnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ConsultasBtnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ConsultasBtnSalir.FlatAppearance.BorderSize = 0;
            this.ConsultasBtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConsultasBtnSalir.Location = new System.Drawing.Point(1248, 6);
            this.ConsultasBtnSalir.Margin = new System.Windows.Forms.Padding(6);
            this.ConsultasBtnSalir.MaximumSize = new System.Drawing.Size(80, 80);
            this.ConsultasBtnSalir.MinimumSize = new System.Drawing.Size(80, 80);
            this.ConsultasBtnSalir.Name = "ConsultasBtnSalir";
            this.ConsultasBtnSalir.Size = new System.Drawing.Size(80, 80);
            this.ConsultasBtnSalir.TabIndex = 17;
            this.ConsultasBtnSalir.UseVisualStyleBackColor = false;
            this.ConsultasBtnSalir.Click += new System.EventHandler(this.ConsultasBtnSalir_Click_1);
            // 
            // clsGrupoConsultas1
            // 
            this.clsGrupoConsultas1.BackColor = System.Drawing.Color.Transparent;
            this.clsGrupoConsultas1.Controls.Add(this.clsListaDesplegableConsultas1);
            this.clsGrupoConsultas1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clsGrupoConsultas1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clsGrupoConsultas1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.clsGrupoConsultas1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(74)))), ((int)(((byte)(99)))));
            this.clsGrupoConsultas1.Location = new System.Drawing.Point(3, 3);
            this.clsGrupoConsultas1.Name = "clsGrupoConsultas1";
            this.ConsultasTlpPrincipal.SetRowSpan(this.clsGrupoConsultas1, 2);
            this.clsGrupoConsultas1.Size = new System.Drawing.Size(394, 174);
            this.clsGrupoConsultas1.TabIndex = 20;
            this.clsGrupoConsultas1.TabStop = false;
            this.clsGrupoConsultas1.Text = "clsGrupoConsultas1";
            // 
            // clsListaDesplegableConsultas1
            // 
            this.clsListaDesplegableConsultas1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.clsListaDesplegableConsultas1.BackColor = System.Drawing.Color.White;
            this.clsListaDesplegableConsultas1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.clsListaDesplegableConsultas1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clsListaDesplegableConsultas1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.clsListaDesplegableConsultas1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(74)))), ((int)(((byte)(99)))));
            this.clsListaDesplegableConsultas1.FormattingEnabled = true;
            this.clsListaDesplegableConsultas1.Location = new System.Drawing.Point(20, 80);
            this.clsListaDesplegableConsultas1.Name = "clsListaDesplegableConsultas1";
            this.clsListaDesplegableConsultas1.Size = new System.Drawing.Size(342, 31);
            this.clsListaDesplegableConsultas1.TabIndex = 0;
            // 
            // clsGrupoConsultas2
            // 
            this.clsGrupoConsultas2.BackColor = System.Drawing.Color.Transparent;
            this.clsGrupoConsultas2.Controls.Add(this.ucConsultasReutilizables1);
            this.clsGrupoConsultas2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clsGrupoConsultas2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clsGrupoConsultas2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.clsGrupoConsultas2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(74)))), ((int)(((byte)(99)))));
            this.clsGrupoConsultas2.Location = new System.Drawing.Point(3, 183);
            this.clsGrupoConsultas2.Name = "clsGrupoConsultas2";
            this.clsGrupoConsultas2.Size = new System.Drawing.Size(394, 394);
            this.clsGrupoConsultas2.TabIndex = 21;
            this.clsGrupoConsultas2.TabStop = false;
            this.clsGrupoConsultas2.Text = "clsGrupoConsultas2";
            // 
            // ucConsultasReutilizables1
            // 
            this.ucConsultasReutilizables1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(231)))), ((int)(((byte)(218)))));
            this.ucConsultasReutilizables1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucConsultasReutilizables1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ucConsultasReutilizables1.Location = new System.Drawing.Point(3, 24);
            this.ucConsultasReutilizables1.Margin = new System.Windows.Forms.Padding(0);
            this.ucConsultasReutilizables1.Name = "ucConsultasReutilizables1";
            this.ucConsultasReutilizables1.Size = new System.Drawing.Size(388, 367);
            this.ucConsultasReutilizables1.TabIndex = 0;
            // 
            // ConsultasUcTabla
            // 
            this.ConsultasUcTabla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(231)))), ((int)(((byte)(218)))));
            this.ConsultasUcTabla.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConsultasUcTabla.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ConsultasUcTabla.Location = new System.Drawing.Point(403, 4);
            this.ConsultasUcTabla.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ConsultasUcTabla.Name = "ConsultasUcTabla";
            this.ConsultasTlpPrincipal.SetRowSpan(this.ConsultasUcTabla, 4);
            this.ConsultasUcTabla.Size = new System.Drawing.Size(836, 695);
            this.ConsultasUcTabla.TabIndex = 22;
            // 
            // FrmConsultasComplejas
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(231)))), ((int)(((byte)(218)))));
            this.ClientSize = new System.Drawing.Size(1332, 703);
            this.Controls.Add(this.ConsultasTlpPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(1350, 750);
            this.Name = "FrmConsultasComplejas";
            this.Text = "4002 – Consultas Complejas";
            this.ConsultasTlpPrincipal.ResumeLayout(false);
            this.clsGrupoConsultas1.ResumeLayout(false);
            this.clsGrupoConsultas2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel ConsultasTlpPrincipal;
        private ClsBotonConsultas ConsultasBtnSalir;
        private ClsBotonConsultas ConsultasBtnRefrescar;
        private Components.ClsGrupoConsultas clsGrupoConsultas1;
        private Components.ClsGrupoConsultas clsGrupoConsultas2;
        private UcConsultasReutilizables ucConsultasReutilizables1;
        private UserControls.UcTablaSimple ConsultasUcTabla;
        private Components.ClsListaDesplegableConsultas clsListaDesplegableConsultas1;
    }
}