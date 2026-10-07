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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.consultas1 = new CapaVista_Consultas.Consultas();
            ((System.ComponentModel.ISupportInitialize)(this.consultas1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(256, 22);
            this.textBox1.TabIndex = 0;
            // 
            // consultas1
            // 
            this.consultas1.CampoRetorno = "nombrePaciente";
            this.consultas1.ControlRetorno = this.textBox1;
            this.consultas1.Location = new System.Drawing.Point(12, 40);
            this.consultas1.Name = "consultas1";
            this.consultas1.Size = new System.Drawing.Size(256, 83);
            this.consultas1.TabIndex = 1;
            this.consultas1.Tabla = "tblpaciente";
            this.consultas1.Text = "consultas1";
            this.consultas1.UseVisualStyleBackColor = true;
            // 
            // FrmEjecucion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 139);
            this.Controls.Add(this.consultas1);
            this.Controls.Add(this.textBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmEjecucion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "4001 - Ejecución";
            ((System.ComponentModel.ISupportInitialize)(this.consultas1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private CapaVista_Consultas.Consultas consultas1;
    }
}