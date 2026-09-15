namespace CapaVista_Consultas
{
    partial class FrmMantenimientoConsultas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMantenimientoConsultas));
            this.ConsultasTlpPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.ConsultasGbxCondicionesLogicas = new CapaVista_Consultas.Components.ClsGrupoConsultas();
            this.ConsultasUcAgregarCondicion = new CapaVista_Consultas.UserControls.UcAgregarCondicion();
            this.ConsultasUcFiltrosAplicados = new CapaVista_Consultas.UcFiltrosAplicados();
            this.clsGrupoConsultas1 = new CapaVista_Consultas.Components.ClsGrupoConsultas();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ConsultasLblNombre = new CapaVista_Consultas.Components.ClsEtiquetaConsultas();
            this.ConsultasBtnGuardar = new CapaVista_Consultas.ClsBotonConsultas();
            this.ConsultasTxtNombre = new CapaVista_Consultas.ClsCajaTextoConsultas();
            this.ConsultasTlpPrincipal.SuspendLayout();
            this.ConsultasGbxCondicionesLogicas.SuspendLayout();
            this.clsGrupoConsultas1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ConsultasTlpPrincipal
            // 
            this.ConsultasTlpPrincipal.ColumnCount = 2;
            this.ConsultasTlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.ConsultasTlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.ConsultasTlpPrincipal.Controls.Add(this.ConsultasGbxCondicionesLogicas, 0, 0);
            this.ConsultasTlpPrincipal.Controls.Add(this.ConsultasUcFiltrosAplicados, 1, 0);
            this.ConsultasTlpPrincipal.Controls.Add(this.clsGrupoConsultas1, 0, 1);
            this.ConsultasTlpPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConsultasTlpPrincipal.Location = new System.Drawing.Point(0, 0);
            this.ConsultasTlpPrincipal.Margin = new System.Windows.Forms.Padding(2);
            this.ConsultasTlpPrincipal.Name = "ConsultasTlpPrincipal";
            this.ConsultasTlpPrincipal.RowCount = 3;
            this.ConsultasTlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.ConsultasTlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.ConsultasTlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ConsultasTlpPrincipal.Size = new System.Drawing.Size(981, 482);
            this.ConsultasTlpPrincipal.TabIndex = 16;
            // 
            // ConsultasGbxCondicionesLogicas
            // 
            this.ConsultasGbxCondicionesLogicas.BackColor = System.Drawing.Color.Transparent;
            this.ConsultasGbxCondicionesLogicas.Controls.Add(this.ConsultasUcAgregarCondicion);
            this.ConsultasGbxCondicionesLogicas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConsultasGbxCondicionesLogicas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConsultasGbxCondicionesLogicas.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.ConsultasGbxCondicionesLogicas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(74)))), ((int)(((byte)(99)))));
            this.ConsultasGbxCondicionesLogicas.Location = new System.Drawing.Point(3, 3);
            this.ConsultasGbxCondicionesLogicas.Name = "ConsultasGbxCondicionesLogicas";
            this.ConsultasGbxCondicionesLogicas.Size = new System.Drawing.Size(386, 294);
            this.ConsultasGbxCondicionesLogicas.TabIndex = 16;
            this.ConsultasGbxCondicionesLogicas.TabStop = false;
            this.ConsultasGbxCondicionesLogicas.Text = "Agregar Condición";
            // 
            // ConsultasUcAgregarCondicion
            // 
            this.ConsultasUcAgregarCondicion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(231)))), ((int)(((byte)(218)))));
            this.ConsultasUcAgregarCondicion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConsultasUcAgregarCondicion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ConsultasUcAgregarCondicion.Location = new System.Drawing.Point(3, 24);
            this.ConsultasUcAgregarCondicion.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ConsultasUcAgregarCondicion.Name = "ConsultasUcAgregarCondicion";
            this.ConsultasUcAgregarCondicion.Size = new System.Drawing.Size(380, 267);
            this.ConsultasUcAgregarCondicion.TabIndex = 1;
            // 
            // ConsultasUcFiltrosAplicados
            // 
            this.ConsultasUcFiltrosAplicados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(231)))), ((int)(((byte)(218)))));
            this.ConsultasUcFiltrosAplicados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConsultasUcFiltrosAplicados.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ConsultasUcFiltrosAplicados.Location = new System.Drawing.Point(392, 0);
            this.ConsultasUcFiltrosAplicados.Margin = new System.Windows.Forms.Padding(0);
            this.ConsultasUcFiltrosAplicados.Name = "ConsultasUcFiltrosAplicados";
            this.ConsultasTlpPrincipal.SetRowSpan(this.ConsultasUcFiltrosAplicados, 2);
            this.ConsultasUcFiltrosAplicados.Size = new System.Drawing.Size(589, 480);
            this.ConsultasUcFiltrosAplicados.TabIndex = 17;
            // 
            // clsGrupoConsultas1
            // 
            this.clsGrupoConsultas1.BackColor = System.Drawing.Color.Transparent;
            this.clsGrupoConsultas1.Controls.Add(this.tableLayoutPanel1);
            this.clsGrupoConsultas1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clsGrupoConsultas1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clsGrupoConsultas1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.clsGrupoConsultas1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(74)))), ((int)(((byte)(99)))));
            this.clsGrupoConsultas1.Location = new System.Drawing.Point(3, 303);
            this.clsGrupoConsultas1.Name = "clsGrupoConsultas1";
            this.clsGrupoConsultas1.Size = new System.Drawing.Size(386, 174);
            this.clsGrupoConsultas1.TabIndex = 18;
            this.clsGrupoConsultas1.TabStop = false;
            this.clsGrupoConsultas1.Text = "Guardar Consulta";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 137F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.ConsultasLblNombre, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.ConsultasBtnGuardar, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.ConsultasTxtNombre, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 24);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 94F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(380, 147);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // ConsultasLblNombre
            // 
            this.ConsultasLblNombre.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ConsultasLblNombre.AutoSize = true;
            this.ConsultasLblNombre.BackColor = System.Drawing.Color.Transparent;
            this.ConsultasLblNombre.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.ConsultasLblNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(74)))), ((int)(((byte)(99)))));
            this.ConsultasLblNombre.Location = new System.Drawing.Point(68, 17);
            this.ConsultasLblNombre.Margin = new System.Windows.Forms.Padding(3);
            this.ConsultasLblNombre.Name = "ConsultasLblNombre";
            this.ConsultasLblNombre.Size = new System.Drawing.Size(66, 19);
            this.ConsultasLblNombre.TabIndex = 3;
            this.ConsultasLblNombre.Text = "Nombre";
            this.ConsultasLblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.ConsultasBtnGuardar.Location = new System.Drawing.Point(218, 60);
            this.ConsultasBtnGuardar.Margin = new System.Windows.Forms.Padding(0);
            this.ConsultasBtnGuardar.MaximumSize = new System.Drawing.Size(80, 80);
            this.ConsultasBtnGuardar.MinimumSize = new System.Drawing.Size(80, 80);
            this.ConsultasBtnGuardar.Name = "ConsultasBtnGuardar";
            this.ConsultasBtnGuardar.Size = new System.Drawing.Size(80, 80);
            this.ConsultasBtnGuardar.TabIndex = 2;
            this.ConsultasBtnGuardar.UseVisualStyleBackColor = false;
            // 
            // ConsultasTxtNombre
            // 
            this.ConsultasTxtNombre.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ConsultasTxtNombre.BackColor = System.Drawing.Color.White;
            this.ConsultasTxtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ConsultasTxtNombre.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ConsultasTxtNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(74)))), ((int)(((byte)(99)))));
            this.ConsultasTxtNombre.Location = new System.Drawing.Point(140, 11);
            this.ConsultasTxtNombre.Name = "ConsultasTxtNombre";
            this.ConsultasTxtNombre.Size = new System.Drawing.Size(237, 30);
            this.ConsultasTxtNombre.TabIndex = 0;
            // 
            // FrmMantenimientoConsultas
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(231)))), ((int)(((byte)(218)))));
            this.ClientSize = new System.Drawing.Size(981, 482);
            this.Controls.Add(this.ConsultasTlpPrincipal);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMantenimientoConsultas";
            this.Text = "4003 – MantenimientoConsultas";
            this.TopMost = true;
            this.ConsultasTlpPrincipal.ResumeLayout(false);
            this.ConsultasGbxCondicionesLogicas.ResumeLayout(false);
            this.clsGrupoConsultas1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel ConsultasTlpPrincipal;
        private Components.ClsGrupoConsultas ConsultasGbxCondicionesLogicas;
        private UserControls.UcAgregarCondicion ConsultasUcAgregarCondicion;
        private UcFiltrosAplicados ConsultasUcFiltrosAplicados;
        private Components.ClsGrupoConsultas clsGrupoConsultas1;
        private ClsCajaTextoConsultas ConsultasTxtNombre;
        private ClsBotonConsultas ConsultasBtnGuardar;
        private Components.ClsEtiquetaConsultas ConsultasLblNombre;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}