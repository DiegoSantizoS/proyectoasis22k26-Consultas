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

        private void ConsultasDgvConsultasFiltros_CellContentClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {

        }

        private void ConsultasBtnAND_Click(object sender, EventArgs e)
        {
            ConsultasDgvConsultasFiltros.Rows.Add("AND", "", "", "");
        }

        private void ConsultasBtnOR_Click(object sender, EventArgs e)
        {
            ConsultasDgvConsultasFiltros.Rows.Add("OR", "", "", "");
        }

        private void ConsultasBtnEliminar_Click(object sender, EventArgs e)
        {
            if (ConsultasDgvConsultasFiltros.Rows.Count > 0)
            {
                ConsultasDgvConsultasFiltros.Rows.RemoveAt(ConsultasDgvConsultasFiltros.Rows.Count - 1);
            }
        }

        public void ConsultasProcAgregarFila(string[] Datos)
        {
            ConsultasDgvConsultasFiltros.Rows.Add(Datos);
        }

        private void ConsultasFlpBotones_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {

        }
    }
}
