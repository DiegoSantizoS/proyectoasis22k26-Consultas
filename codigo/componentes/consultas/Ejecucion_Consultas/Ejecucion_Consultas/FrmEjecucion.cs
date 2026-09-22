using CapaVista_Consultas;
using CapaVista_Consultas.Componentes;
using System;

namespace Ejecucion_Consultas
{
    public partial class FrmEjecucion :
        ClsBaseTerminus
    {
        public FrmEjecucion()
        {
            InitializeComponent();
        }

        private void ConsultasMetBtnConsultarClick(object Sender, EventArgs Evento)
        {
            using (FrmConsultasSimples Formulario = new FrmConsultasSimples("tblConsulta","Pk_Consulta"))
            {
                Formulario.ShowDialog();

                if (Formulario.SeleccionRealizada)
                {
                    ConsultasTxtId.Text = Formulario.IdSeleccionado;
                }
            }
        }

    }
}