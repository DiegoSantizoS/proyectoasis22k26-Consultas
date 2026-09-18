using CapaVista_Consultas;
using CapaVista_Consultas.Componentes;
using System;
using System.Windows.Forms;

namespace Ejecucion_Consultas
{
    public partial class FrmEjecucion :
        ClsBaseTerminus
    {
        public FrmEjecucion()
        {
            InitializeComponent();
        }

        private void ConsultasBtnConsultar_Click(
            object sender,
            EventArgs e)
        {
            using (FrmConsultasSimples FormularioConsultas =
                new FrmConsultasSimples(
                    "tblConsulta",
                    "Pk_Consulta"))
            {
                FormularioConsultas.ShowDialog();

                if (FormularioConsultas.SeleccionRealizada)
                {
                    ConsultasTxtID.Text =
                        FormularioConsultas.IdSeleccionado;
                }
            }
        }
    }
}