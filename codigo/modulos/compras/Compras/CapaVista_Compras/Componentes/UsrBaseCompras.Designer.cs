namespace CapaVista_Compras.Componentes
{
    partial class UsrBaseCompras
    {
        private System.ComponentModel.IContainer _Componentes = null;

        protected override void Dispose(bool LiberarRecursos)
        {
            if (LiberarRecursos && (_Componentes != null))
            {
                _Componentes.Dispose();
            }

            base.Dispose(LiberarRecursos);
        }

        #region Código generado por el Diseñador de componentes

        private void InitializeComponent()
        {
            this.SuspendLayout();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = ClsTemaCompras.FondoGeneral;
            this.DoubleBuffered = true;
            this.ForeColor = ClsTemaCompras.PrincipalNavegador;
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MaximumSize = new System.Drawing.Size(1150, 750);
            this.Name = "UsrBaseCompras";
            this.Size = new System.Drawing.Size(1150, 750);
            this.ResumeLayout(false);

        }

        #endregion
    }
}
