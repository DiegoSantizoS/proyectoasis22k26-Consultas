using System;

namespace CapaVista_Consultas.Controles
{
    public partial class UcSeleccioneUnaConsulta : Componentes.ClsControlUsuarioConsultas
    {
        public string TablaActual { get; set; } 
        public UcSeleccioneUnaConsulta()
        {
            InitializeComponent();
        }

        public UcSeleccioneUnaConsulta(string Tabla)
        {
            InitializeComponent();

            TablaActual = Tabla;
        }
        private void ConsultasBtnIngresar_Click(object sender, EventArgs e)
        {
            FrmMantenimientoConsultas FormularioMantenimientoConsultas = new FrmMantenimientoConsultas();
            FormularioMantenimientoConsultas.Show();
        }

       

        private void ConsultasBtnEliminar_Click(object sender, EventArgs e)
        {

        }
    }
}
