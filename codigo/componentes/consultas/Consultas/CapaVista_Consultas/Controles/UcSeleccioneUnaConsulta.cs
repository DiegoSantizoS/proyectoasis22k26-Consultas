using System;
using System.Data;
using System.Windows.Forms;
using CapaControlador_Consultas;

namespace CapaVista_Consultas.Controles
{
    public partial class UcSeleccioneUnaConsulta :
        Componentes.ClsControlUsuarioConsultas
    {
        public event Action<string, string> ConsultaSeleccionada;

        public string Tabla { get; set; }
        public string Query { get; set; }

        private readonly ClsConsultaSeleccionada _Consultas =
            new ClsConsultaSeleccionada();

        public UcSeleccioneUnaConsulta()
        {
            InitializeComponent();

            ConsultasProcActualizarConsultas();
        }

        private void ConsultasProcActualizarConsultas()
        {
            try
            {
                ConsultasDgvConsultasReutilizables
                    .Columns.Clear();

                DataTable DtConsultas =
                    _Consultas
                        .ConsultasFuncCargarConsultas();

                ConsultasDgvConsultasReutilizables
                    .DataSource = DtConsultas;

                if (ConsultasDgvConsultasReutilizables
                    .Columns["Query"] != null)
                {
                    ConsultasDgvConsultasReutilizables
                        .Columns["Query"]
                        .Visible = false;
                }

                if (ConsultasDgvConsultasReutilizables
                    .Columns["Tabla"] != null)
                {
                    ConsultasDgvConsultasReutilizables
                        .Columns["Tabla"]
                        .Visible = false;
                }
            }
            catch (InvalidOperationException Ex)
            {
                ConsultasDgvConsultasReutilizables
                    .DataSource = null;

                MessageBox.Show(
                    Ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (Exception Ex)
            {
                ConsultasDgvConsultasReutilizables
                    .DataSource = null;

                MessageBox.Show(
                    "Ocurrió un error inesperado al cargar " +
                    "las consultas.\n\n" +
                    Ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        public void ConsultasProcRefrescarConsultas()
        {
            ConsultasProcActualizarConsultas();
        }

        private void ConsultasBtnIngresar_Click(
            object sender,
            EventArgs e)
        {
            FrmMantenimientoConsultas
                FormularioMantenimientoConsultas =
                    new FrmMantenimientoConsultas();

            FormularioMantenimientoConsultas.Show();
        }

        private void ConsultasBtnEliminar_Click(
            object sender,
            EventArgs e)
        {

        }

        private void ConsultasBtnConsultar_Click(
            object sender,
            EventArgs e)
        {
            if (ConsultasDgvConsultasReutilizables
                .CurrentRow == null)
            {
                MessageBox.Show(
                    "Seleccione una fila para ejecutar la consulta.",
                    "Consulta",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            Query =
                ConsultasDgvConsultasReutilizables
                    .CurrentRow
                    .Cells["Query"]
                    .Value?
                    .ToString();

            Tabla =
                ConsultasDgvConsultasReutilizables
                    .CurrentRow
                    .Cells["Tabla"]
                    .Value?
                    .ToString();

            if (string.IsNullOrWhiteSpace(Query))
            {
                MessageBox.Show(
                    "La consulta seleccionada no contiene " +
                    "una sentencia válida.",
                    "Consulta",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            ConsultaSeleccionada?.Invoke(
                Query,
                Tabla);
        }
    }
}