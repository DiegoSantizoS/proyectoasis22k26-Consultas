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
    public partial class BotonesConsulta : UserControl
    {
        public BotonesConsulta()
        {
            InitializeComponent();
            // Estandarización EST-10 del Componente Consultas
            this.BackColor = ClsEstandarizacionConsultas.Fondo;
            pnl_Botones.BackColor = ClsEstandarizacionConsultas.Fondo;

            ClsEstandarizacionConsultas.ConsultasMetAplicarFormatoBoton(btn_Generar);
            ClsEstandarizacionConsultas.ConsultasMetAplicarFormatoBoton(btn_EjecutarConsulta);
            ClsEstandarizacionConsultas.ConsultasMetAplicarFormatoBoton(btn_Limpiar);
        }

        private void BotonesConsulta_Load(object sender, EventArgs e)
        {

        }
    }
}
