using System;
using System.Data;
using System.Windows.Forms;
using CapaControlador_Consultas;

namespace CapaVista_Consultas.Controles
{
    public partial class UcSeleccioneUnaConsulta : Componentes.ClsControlUsuarioConsultas
    {
        public event Action<string, string> ConsultaSeleccionada;
        public string TablaActual { get; set; }
        public string Tabla { get; set; }
        public string Query { get; set; }
        private readonly ClsConsultaSeleccionada Consultas = new ClsConsultaSeleccionada();
        public DataTable DtConsulta { get; set; }
        public DataTable DtConsultaSeleccionada = new DataTable();
        public UcSeleccioneUnaConsulta()    
        {
            InitializeComponent();
            ConsultasProcActualizarConsultas();
        }

        public UcSeleccioneUnaConsulta(string Tabla)
        {
            InitializeComponent();

            TablaActual = Tabla;
            ConsultasProcActualizarConsultas();
        }
        private void ConsultasProcActualizarConsultas()
        {
            ConsultasDgvConsultasReutilizables.Columns.Clear();
            DataTable DtConsultas = Consultas.ConsultasFuncCargarConsultas();
            ConsultasDgvConsultasReutilizables.DataSource = DtConsultas;
            ConsultasDgvConsultasReutilizables.Columns["Query"].Visible = false;
            ConsultasDgvConsultasReutilizables.Columns["Tabla"].Visible = false;
        }
        private void ConsultasBtnIngresar_Click(object sender, EventArgs e)
        {
            FrmMantenimientoConsultas FormularioMantenimientoConsultas = new FrmMantenimientoConsultas();
            FormularioMantenimientoConsultas.Show();
        }

       

        private void ConsultasBtnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void ConsultasBtnConsultar_Click(object sender, EventArgs e)
        {
            if (ConsultasDgvConsultasReutilizables.CurrentRow != null)
            {
                Query = ConsultasDgvConsultasReutilizables.CurrentRow.Cells["Query"].Value?.ToString();
                Tabla = ConsultasDgvConsultasReutilizables.CurrentRow.Cells["Tabla"].Value?.ToString();

                // Enviar Query y Tabla al formulario que contiene este UserControl
                ConsultaSeleccionada?.Invoke(Query, Tabla);
            }
            else
            {
                MessageBox.Show("Seleccione una fila para ejecutar la consulta");
            }
        }
    }
}
