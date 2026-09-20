namespace CapaVista_CbCampos
{
    partial class UCComboboxCampos
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
            this.ConsultasCboCampo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // ConsultasCboCampo
            // 
            this.ConsultasCboCampo.FormattingEnabled = true;
            this.ConsultasCboCampo.Location = new System.Drawing.Point(0, 3);
            this.ConsultasCboCampo.Name = "ConsultasCboCampo";
            this.ConsultasCboCampo.Size = new System.Drawing.Size(169, 24);
            this.ConsultasCboCampo.TabIndex = 0;
            this.ConsultasCboCampo.SelectedIndexChanged += new System.EventHandler(this.ConsultasCboCampo_SelectedIndexChanged);
            // 
            // UCComboboxCampos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ConsultasCboCampo);
            this.Name = "UCComboboxCampos";
            this.Size = new System.Drawing.Size(171, 27);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox ConsultasCboCampo;
    }
}
