using System;

namespace CapaVista_Consultas.Controles
{
    public partial class UcFiltrosAplicados : Componentes.ClsControlUsuarioConsultas
    {
        public UcFiltrosAplicados()
        {
            InitializeComponent();
        }

        private void ConsultasBtnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
