
namespace CapaVista_Consultas
{
    partial class FrmConsultas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer _Componentes = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="LiberarRecursos">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool LiberarRecursos)
        {
            if (LiberarRecursos && (_Componentes != null))
            {
                _Componentes.Dispose();
            }
            base.Dispose(LiberarRecursos);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultas));
            this.ConsultasPnlTarjeta = new CapaVista_Consultas.Componentes.ClsPanelConsultas();
            this.SuspendLayout();
            // 
            // ConsultasPnlTarjeta
            // 
            this.ConsultasPnlTarjeta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConsultasPnlTarjeta.Location = new System.Drawing.Point(0, 0);
            this.ConsultasPnlTarjeta.Margin = new System.Windows.Forms.Padding(0);
            this.ConsultasPnlTarjeta.Name = "ConsultasPnlTarjeta";
            this.ConsultasPnlTarjeta.Size = new System.Drawing.Size(1232, 703);
            this.ConsultasPnlTarjeta.TabIndex = 0;
            // 
            // FrmConsultas
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(231)))), ((int)(((byte)(218)))));
            this.ClientSize = new System.Drawing.Size(1232, 703);
            this.Controls.Add(this.ConsultasPnlTarjeta);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1250, 750);
            this.MinimumSize = new System.Drawing.Size(850, 500);
            this.Name = "FrmConsultas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "4000 - Consultas";
            this.ResumeLayout(false);

        }

        #endregion

        private CapaVista_Consultas.Componentes.ClsPanelConsultas ConsultasPnlTarjeta;
    }
}