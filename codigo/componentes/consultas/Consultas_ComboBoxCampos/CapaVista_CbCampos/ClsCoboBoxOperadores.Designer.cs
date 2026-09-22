namespace CapaVista_CbCampos
{
    partial class ClsCoboBoxOperadores
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
            this.ConsultasCboOperador = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // ConsultasCboOperador
            // 
            this.ConsultasCboOperador.FormattingEnabled = true;
            this.ConsultasCboOperador.Location = new System.Drawing.Point(3, 3);
            this.ConsultasCboOperador.Name = "ConsultasCboOperador";
            this.ConsultasCboOperador.Size = new System.Drawing.Size(169, 24);
            this.ConsultasCboOperador.TabIndex = 1;
            this.ConsultasCboOperador.SelectedIndexChanged += new System.EventHandler(this.ConsultasCboOperador_SelectedIndexChanged);
            // 
            // ClsCoboBoxOperadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ConsultasCboOperador);
            this.Name = "ClsCoboBoxOperadores";
            this.Size = new System.Drawing.Size(173, 27);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox ConsultasCboOperador;
    }
}
