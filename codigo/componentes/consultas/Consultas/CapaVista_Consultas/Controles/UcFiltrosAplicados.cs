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


        private void ConsultasMetBtnANDClick(object sender, EventArgs e)
        {
            ConsultasDgvConsultasFiltros.Rows.Add("AND", "", "", "");
        }

        private void ConsultasMetBtnORClick(object sender, EventArgs e)
        {
            ConsultasDgvConsultasFiltros.Rows.Add("OR", "", "", "");
        }
    }
}
