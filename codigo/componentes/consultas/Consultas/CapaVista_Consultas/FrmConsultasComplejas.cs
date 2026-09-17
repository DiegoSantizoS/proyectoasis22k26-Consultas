using System;
using System.Windows.Forms;

namespace CapaVista_Consultas
{
    public partial class FrmConsultasComplejas : Componentes.ClsBaseTerminus
    {
        public string TablaActual { get; set; }
        // Inicio de código de "Pedro José Gómez Villalobos" - carné: "0901-23-4868" - Fecha: "16/09/26"

        private string[] _ArregloTablas;

        public FrmConsultasComplejas(string[] Tablas)
        {
            InitializeComponent();
            ConsultasUcTabla.ConsultasMetAjustarAlturaFilas(30);

            _ArregloTablas = Tablas;
            TablaActual = Tablas[0]; 

            ConsultasMetLlenarComboTablas();
        }

        private void ConsultasMetLlenarComboTablas()
        {
            ConsultasCboSeleccionTabla.Items.Clear();

            if (_ArregloTablas != null)
            {
                foreach (string Tabla in _ArregloTablas)
                {
                    ConsultasCboSeleccionTabla.Items.Add(Tabla);
                }

                if (ConsultasCboSeleccionTabla.Items.Count > 0)
                {
                    ConsultasCboSeleccionTabla.SelectedIndex = 0;
                }
            }
        }
        // Fin de código de "Pedro José Gómez Villalobos" - carné: "0901-23-4868" - Fecha: "16/09/26"

        public FrmConsultasComplejas()
        {
            InitializeComponent();
            ConsultasUcTabla.ConsultasMetAjustarAlturaFilas(30);
        }
        public string TablaActual { get; set; } 
        public FrmConsultasComplejas(string Tabla)
        {
            InitializeComponent();
            ConsultasUcTabla.ConsultasMetAjustarAlturaFilas(30);
            TablaActual = Tabla;
            ConsultasUcTabla.ConsultasProcCambiarRegistrosPorPagina(30, TablaActual);
            ConsultasUcTabla.ConsultasProcCambiarRegistrosPorPagina(30, TablaActual);
            ConsultasUcConsultasReutilizables.ConsultaSeleccionada += EjecutarConsultaSeleccionada;

        }

        // Inicio de código de "José Pablo Cano Cóbar" - carné: "0901-23-1727" - Fecha: "16/09/26"

        private void EjecutarConsultaSeleccionada(
            string Query,
            string Tabla)
        {
            ConsultasUcTabla.ConsultasProcCargarConsultaDesdeQuery(
                Query,
                Tabla);
        }
        private void ConsultasBtnSalir_Click_1(object sender, EventArgs e)
        {
            DialogResult Respuesta = System.Windows.Forms.MessageBox.Show(
                "¿Desea salir del componente de Consultas?",
                "Consultas",
                System.Windows.Forms.MessageBoxButtons.YesNo,
                System.Windows.Forms.MessageBoxIcon.Question);

            if (Respuesta == DialogResult.Yes)
            {
                System.Windows.Forms.Application.Exit();
            }
        }

        private void ConsultasBtnInicio_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
