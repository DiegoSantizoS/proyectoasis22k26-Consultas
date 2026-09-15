using System;

namespace CapaVista_Consultas
{
    public partial class FrmConsultasComplejas : Componentes.ClsBaseTerminus
    {
        public string TablaActual { get; set; } 
        public FrmConsultasComplejas()
        {
            InitializeComponent();
            ConsultasUcTabla.ConsultasMetAjustarAlturaFilas(30);
        }
        public FrmConsultasComplejas(string Tabla)
        {
            InitializeComponent();
           
            TablaActual = Tabla;


        }

        private void ConsultasBtnSalir_Click_1(object sender, EventArgs e)
        {
            FrmConsultasSimples FormularioConsultasSimples = new FrmConsultasSimples();

            FormularioConsultasSimples.FormClosed += (s, args) =>
            {
                this.Hide();
            };

            this.Hide();
            FormularioConsultasSimples.Show();
        }
    }
}
