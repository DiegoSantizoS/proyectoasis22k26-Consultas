using System;
using System.Windows.Forms;
using CapaControlador_Consultas;

namespace CapaVista_Consultas
{
using System.Threading.Tasks;
    public partial class FrmConsultasSimples : Componentes.ClsBaseTerminus
    {
        public FrmConsultasSimples()
        {
            InitializeComponent();
        }

        public FrmConsultasSimples(string Tabla)
        {
            InitializeComponent();
            // guarda tabla de la variable global pedro inicio
            TablaActual = tabla;
            ConsultasUcTablaSimple.ConsultasProcActualizarTabla(tabla);
          
            ConsultasUcTablaSimple.ConsultasProcActualizarTabla(Tabla);
            ConsultasUcAgregarFiltro.ConsultasProcActualizarTabla(Tabla);
            ClsTablaSeleccionada.ConsultasMetGuardarTabla (Tabla);
        }

        private void ConsultasBtnComplejas_Click_1(object sender, EventArgs e)
        {
            // pasa la 'TablaActual' al formulario de consultas complejas
            FrmConsultasComplejas FormularioConsultasComplejas = new FrmConsultasComplejas(TablaActual);
            FrmConsultasComplejas FormularioConsultasComplejas = new FrmConsultasComplejas();

            FormularioConsultasComplejas.FormClosed += (s, args) =>
            {
                Application.Exit();
            };

            this.Hide();
            FormularioConsultasComplejas.Show();

        }
        //fin
    }
}