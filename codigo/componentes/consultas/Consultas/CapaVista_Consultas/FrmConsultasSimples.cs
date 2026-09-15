using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaControlador_Consultas;

namespace CapaVista_Consultas
{
    public partial class FrmConsultasSimples : ClsBaseTerminus
    {
        ClsControladorConsultaSimple _Controlador = new ClsControladorConsultaSimple();

        public string TablaActual { get; set; } = "tblConsulta";

        public FrmConsultasSimples()
        {
            InitializeComponent();
        }

        public FrmConsultasSimples(string tabla)
        {
            InitializeComponent();
            // guarda tabla de la variable global pedro inicio
            TablaActual = tabla;
            ConsultasUcTablaSimple.ConsultasProcActualizarTabla(tabla);
        }

        private void ConsultasBtnComplejas_Click_1(object sender, EventArgs e)
        {
            // pasa la 'TablaActual' al formulario de consultas complejas
            FrmConsultasComplejas FormularioConsultasComplejas = new FrmConsultasComplejas(TablaActual);
            this.Hide();
            FormularioConsultasComplejas.Show();
        }
        //fin
    }
}