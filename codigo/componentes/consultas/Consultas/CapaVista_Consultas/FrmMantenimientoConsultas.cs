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
    public partial class FrmMantenimientoConsultas : ClsBaseTerminus
    {

        private readonly ClsControladorConsultas _Controlador =
         new ClsControladorConsultas();
        public string TablaActual { get; set; } 


        private string _TablaActual;
        public FrmMantenimientoConsultas()
        {
            InitializeComponent();

        }

        

    }
}
