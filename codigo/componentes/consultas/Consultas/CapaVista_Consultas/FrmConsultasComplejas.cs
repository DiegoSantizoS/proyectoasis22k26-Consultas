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
    public partial class FrmConsultasComplejas : ClsBaseTerminus
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
