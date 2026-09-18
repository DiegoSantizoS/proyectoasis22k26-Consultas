namespace Ejecucion_Consultas
{
    partial class FrmEjecucion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEjecucion));
            this.ConsultasTxtID = new CapaVista_Consultas.Componentes.ClsCajaTextoConsultas();
            this.ConsultasBtnConsultar = new CapaVista_Consultas.Componentes.ClsBotonConsultas();
            this.ConsultasLbID = new CapaVista_Consultas.Componentes.ClsEtiquetaConsultas();
            this.SuspendLayout();
            // 
            // ConsultasTxtID
            // 
            this.ConsultasTxtID.BackColor = System.Drawing.Color.White;
            this.ConsultasTxtID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ConsultasTxtID.Enabled = false;
            this.ConsultasTxtID.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ConsultasTxtID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(74)))), ((int)(((byte)(99)))));
            this.ConsultasTxtID.Location = new System.Drawing.Point(226, 212);
            this.ConsultasTxtID.Name = "ConsultasTxtID";
            this.ConsultasTxtID.Size = new System.Drawing.Size(200, 30);
            this.ConsultasTxtID.TabIndex = 0;
            // 
            // ConsultasBtnConsultar
            // 
            this.ConsultasBtnConsultar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ConsultasBtnConsultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(231)))), ((int)(((byte)(218)))));
            this.ConsultasBtnConsultar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ConsultasBtnConsultar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ConsultasBtnConsultar.FlatAppearance.BorderSize = 0;
            this.ConsultasBtnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConsultasBtnConsultar.Image = ((System.Drawing.Image)(resources.GetObject("ConsultasBtnConsultar.Image")));
            this.ConsultasBtnConsultar.Location = new System.Drawing.Point(462, 186);
            this.ConsultasBtnConsultar.Margin = new System.Windows.Forms.Padding(0);
            this.ConsultasBtnConsultar.MaximumSize = new System.Drawing.Size(80, 80);
            this.ConsultasBtnConsultar.MinimumSize = new System.Drawing.Size(80, 80);
            this.ConsultasBtnConsultar.Name = "ConsultasBtnConsultar";
            this.ConsultasBtnConsultar.Size = new System.Drawing.Size(80, 80);
            this.ConsultasBtnConsultar.TabIndex = 1;
            this.ConsultasBtnConsultar.UseVisualStyleBackColor = false;
            this.ConsultasBtnConsultar.Click += new System.EventHandler(this.ConsultasBtnConsultar_Click);
            // 
            // ConsultasLbID
            // 
            this.ConsultasLbID.AutoSize = true;
            this.ConsultasLbID.BackColor = System.Drawing.Color.Transparent;
            this.ConsultasLbID.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.ConsultasLbID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(74)))), ((int)(((byte)(99)))));
            this.ConsultasLbID.Location = new System.Drawing.Point(98, 216);
            this.ConsultasLbID.Margin = new System.Windows.Forms.Padding(3);
            this.ConsultasLbID.Name = "ConsultasLbID";
            this.ConsultasLbID.Size = new System.Drawing.Size(122, 19);
            this.ConsultasLbID.TabIndex = 2;
            this.ConsultasLbID.Text = "ID Seleccionado";
            this.ConsultasLbID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FrmEjecucion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ConsultasLbID);
            this.Controls.Add(this.ConsultasBtnConsultar);
            this.Controls.Add(this.ConsultasTxtID);
            this.Name = "FrmEjecucion";
            this.Text = "4004 - EjecucionComplejas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CapaVista_Consultas.Componentes.ClsCajaTextoConsultas ConsultasTxtID;
        private CapaVista_Consultas.Componentes.ClsBotonConsultas ConsultasBtnConsultar;
        private CapaVista_Consultas.Componentes.ClsEtiquetaConsultas ConsultasLbID;
    }
}