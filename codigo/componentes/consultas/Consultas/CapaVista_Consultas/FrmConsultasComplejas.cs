using System;
using System.Windows.Forms;

namespace CapaVista_Consultas
{
    public partial class FrmConsultasComplejas :
        Componentes.ClsBaseTerminus
    {
        public string TablaActual { get; private set; }

        public string IdSeleccionado { get; private set; }

        public bool SeleccionRealizada { get; private set; }

        public FrmConsultasComplejas()
        {
            InitializeComponent();

            ConsultasMetConfigurarFormulario();
        }

        public FrmConsultasComplejas(
            string Tabla,
            string CampoId)
            : this()
        {
            TablaActual = Tabla;

            ConsultasUcTabla
                .ConsultasMetConfigurarSeleccion(
                    CampoId);

            ConsultasUcTabla
                .ConsultasProcCambiarRegistrosPorPagina(
                    30,
                    TablaActual);
        }

        private void ConsultasMetConfigurarFormulario()
        {
            ConsultasUcTabla
                .ConsultasMetAjustarAlturaFilas(30);

            ConsultasUcConsultasReutilizables
                .ConsultaSeleccionada +=
                    EjecutarConsultaSeleccionada;

            ConsultasUcTabla
                .ConsultasEvtFilaSeleccionada +=
                    ConsultasUcTabla_FilaSeleccionada;
        }

        private void ConsultasUcTabla_FilaSeleccionada(
            object sender,
            EventArgs e)
        {
            IdSeleccionado =
                ConsultasUcTabla.IdSeleccionado;

            SeleccionRealizada =
                ConsultasUcTabla.SeleccionRealizada;

            if (!SeleccionRealizada)
            {
                return;
            }

            DialogResult =
                DialogResult.OK;

            Close();
        }

        // Inicio de código de "José Pablo Cano Cóbar" - carné: "0901-23-1727" - Fecha: "16/09/26"

        private void EjecutarConsultaSeleccionada(
            string Query,
            string Tabla)
        {
            TablaActual = Tabla;

            ConsultasUcTabla
                .ConsultasProcCargarConsultaDesdeQuery(
                    Query,
                    Tabla);
        }

        private void ConsultasMetBtnSeleccionarClick(
            object sender,
            EventArgs e)
        {
            bool ResultadoSeleccion =
                ConsultasUcTabla
                    .ConsultasFuncSeleccionarRegistro();

            if (!ResultadoSeleccion)
            {
                MessageBox.Show(
                    "Seleccione un registro.",
                    "Consultas",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                return;
            }

            IdSeleccionado =
                ConsultasUcTabla.IdSeleccionado;

            SeleccionRealizada =
                ConsultasUcTabla.SeleccionRealizada;

            DialogResult =
                DialogResult.OK;

            Close();
        }

        private void ConsultasMetBtnSalirClick(
            object sender,
            EventArgs e)
        {
            DialogResult Respuesta =
                MessageBox.Show(
                    "¿Desea salir del componente de Consultas?",
                    "Consultas",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

            if (Respuesta == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void ConsultasMetBtnInicioClick(
            object sender,
            EventArgs e)
        {
            Close();
        }

        // Fin de código de "José Pablo Cano Cóbar" - carné: "0901-23-1727" - Fecha: "16/09/26"
    }
}