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
    public partial class CondicionesComparacion : UserControl
    {
        private clsConstructorconsultas constructor;
        public CondicionesComparacion()
        {
            InitializeComponent();
            constructor = new clsConstructorconsultas("PELICULA");
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          

            

          
            if (Cbo_Comparacion.SelectedItem != null)
            {
                if (Cbo_Campo.SelectedItem == null)
                {
                    MessageBox.Show("Seleccione un campo");
                    return;
                }

                if (Cbo_Comparacion.SelectedItem == null)
                {
                    MessageBox.Show("Seleccione un operador");
                    return;
                }

                if (string.IsNullOrWhiteSpace(Txtvalor.Text))
                {
                    MessageBox.Show("Ingrese un valor");
                    return;
                }

                string campo =
                    Cbo_Campo.SelectedItem.ToString();

                string operador =
                    Cbo_Comparacion.SelectedItem.ToString();

                string valor =
                    Txtvalor.Text;


                clsCondicionComparacion condicion =
                    new clsCondicionComparacion(
                        campo,
                        operador,
                        valor
                    );

                constructor.AgregarCondicion(
                    condicion.GenerarCondicion(),null
                    
                );

                MessageBox.Show(
                    "Condición agregada:\n\n" +
                    condicion.GenerarCondicion()
                );
                
                MessageBox.Show(
                    constructor.ObtenerConsultaActual(),
                    "Consulta SQL actual",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );


            }
        }
    }
}
