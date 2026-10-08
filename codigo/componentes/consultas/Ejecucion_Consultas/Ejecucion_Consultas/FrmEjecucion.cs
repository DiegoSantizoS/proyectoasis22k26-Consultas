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
            consultas1.ConsultasEvtSeleccion += ConsultasMetSeleccionar;
        }

        private void ConsultasMetSeleccionar(object Sender, ClsSeleccionConsulta Evento)
        {
            string Pk = consultas1.LlavePrimaria();
            ConsultasUsrPkRetornado.Text = Pk;

            ConsultasUsrPkRetornado.ConsultasMetMostrarError("Esta es la llave primaria del registro");
            ConsultasUsrCampoRetornado.ConsultasMetMostrarError("Este es el campo deseado del registro");
        }
    }
}
