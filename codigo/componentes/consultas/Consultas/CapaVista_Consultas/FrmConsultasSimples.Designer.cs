namespace CapaVista_Consultas
{
    partial class ConsultaSimple_400_001
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaSimple_400_001));
            this.button3 = new System.Windows.Forms.Button();
            this.ConsultasBtnRefrescar = new System.Windows.Forms.Button();
            this.agrupar_Ordenar1 = new CapaVista_Consultas.Agrupar_Ordenar();
            this.tablaSimple1 = new CapaVista_Consultas.UserControls.TablaSimple();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(980, 457);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 63);
            this.button3.TabIndex = 5;
            this.button3.Text = "Consulta Compleja";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // ConsultasBtnRefrescar
            // 
            this.ConsultasBtnRefrescar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ConsultasBtnRefrescar.BackgroundImage")));
            this.ConsultasBtnRefrescar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ConsultasBtnRefrescar.FlatAppearance.BorderSize = 0;
            this.ConsultasBtnRefrescar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConsultasBtnRefrescar.Location = new System.Drawing.Point(1006, 46);
            this.ConsultasBtnRefrescar.Margin = new System.Windows.Forms.Padding(0);
            this.ConsultasBtnRefrescar.MaximumSize = new System.Drawing.Size(75, 75);
            this.ConsultasBtnRefrescar.MinimumSize = new System.Drawing.Size(75, 75);
            this.ConsultasBtnRefrescar.Name = "ConsultasBtnRefrescar";
            this.ConsultasBtnRefrescar.Size = new System.Drawing.Size(75, 75);
            this.ConsultasBtnRefrescar.TabIndex = 16;
            this.ConsultasBtnRefrescar.UseVisualStyleBackColor = true;
            // 
            // agrupar_Ordenar1
            // 
            this.agrupar_Ordenar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(231)))), ((int)(((byte)(218)))));
            this.agrupar_Ordenar1.Location = new System.Drawing.Point(12, 35);
            this.agrupar_Ordenar1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.agrupar_Ordenar1.Name = "agrupar_Ordenar1";
            this.agrupar_Ordenar1.Size = new System.Drawing.Size(941, 91);
            this.agrupar_Ordenar1.TabIndex = 17;
            // 
            // tablaSimple1
            // 
            this.tablaSimple1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(231)))), ((int)(((byte)(218)))));
            this.tablaSimple1.Location = new System.Drawing.Point(14, 131);
            this.tablaSimple1.Name = "tablaSimple1";
            this.tablaSimple1.Size = new System.Drawing.Size(1068, 304);
            this.tablaSimple1.TabIndex = 18;
            // 
            // ConsultaSimple_400_001
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(231)))), ((int)(((byte)(218)))));
            this.ClientSize = new System.Drawing.Size(1096, 529);
            this.Controls.Add(this.tablaSimple1);
            this.Controls.Add(this.agrupar_Ordenar1);
            this.Controls.Add(this.ConsultasBtnRefrescar);
            this.Controls.Add(this.button3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "ConsultaSimple_400_001";
            this.Text = "4001 - ConsultaSimple";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button ConsultasBtnRefrescar;
        private Agrupar_Ordenar agrupar_Ordenar1;
        private UserControls.TablaSimple tablaSimple1;
    }
}