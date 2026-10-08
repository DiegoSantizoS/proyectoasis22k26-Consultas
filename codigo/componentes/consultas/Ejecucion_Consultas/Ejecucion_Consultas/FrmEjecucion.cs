using CapaVista_Consultas;
using System.Windows.Forms;

namespace Ejecucion_Consultas
{
    public partial class FrmEjecucion : Form
    {
        public FrmEjecucion()
        {
            InitializeComponent();
            ConsultasUsrCampoRetornado.ConsultasMetLimpiarError();
            ConsultasUsrPkRetornado.ConsultasMetLimpiarError();
        }

        private void consultas1_Click(object sender, System.EventArgs e)
        {
            string Pk = consultas1.LlavePrimaria();
            ConsultasUsrPkRetornado.Text = Pk;

            ConsultasUsrPkRetornado.ConsultasMetMostrarError("Esta es la llave primaria del registro");
            ConsultasUsrCampoRetornado.ConsultasMetMostrarError("Este es el campo deseado del registro");
        }
    }
}
