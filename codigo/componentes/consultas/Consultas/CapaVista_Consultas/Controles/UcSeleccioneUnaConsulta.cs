using CapaControlador_Consultas;
using CapaVista_Consultas.Components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVista_Consultas
{
    public partial class UcSeleccioneUnaConsulta : ClsControlUsuarioConsultas
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
