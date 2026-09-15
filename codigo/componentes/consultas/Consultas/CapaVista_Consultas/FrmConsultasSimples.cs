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

        //Variable dinámica de la tabla = empleado es eliminable
        public string TablaActual { get; set; }
        

        public FrmConsultasSimples()
        {
            InitializeComponent();

        }

        public FrmConsultasSimples(string Tabla)
        {
            InitializeComponent();
          
            ConsultasUcTablaSimple.ConsultasProcActualizarTabla(Tabla);
            ConsultasUcAgregarFiltro.ConsultasProcActualizarTabla(Tabla);
            ClsTablaSeleccionada.ConsultasMetGuardarTabla (Tabla);
        }

        private void ConsultasBtnComplejas_Click_1(object sender, EventArgs e)
        {
            FrmConsultasComplejas FormularioConsultasComplejas = new FrmConsultasComplejas();

            FormularioConsultasComplejas.FormClosed += (s, args) =>
            {
                Application.Exit();
            };

            this.Hide();
            FormularioConsultasComplejas.Show();

        }
    }
}