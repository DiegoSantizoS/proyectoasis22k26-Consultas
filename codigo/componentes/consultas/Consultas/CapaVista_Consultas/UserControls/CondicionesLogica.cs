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
    public partial class CondicionesLogica : UserControl
    {
        private clsConstructorconsultas constructor;
        public CondicionesLogica()
        {
            InitializeComponent();
            constructor = new clsConstructorconsultas("PELICULA");
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cbologica.SelectedItem != null)
            {
                if (cbocampo.SelectedItem == null)
                {
                    MessageBox.Show("Seleccione un campo");
                    return;
                }

                if (cbologica.SelectedItem == null)
                {
                    MessageBox.Show("Seleccione un operador");
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtvalor.Text))
                {
                    MessageBox.Show("Ingrese un valor");
                    return;
                }





                string campo = cbocampo.SelectedItem.ToString();
                string valor = txtvalor.Text;
                string operadorLogico = cbologica.SelectedItem.ToString();

                clsCondicionLogica condicion =
                    new clsCondicionLogica(
                        campo,
                        valor,
                        operadorLogico
                    );

                constructor.AgregarCondicion(
                   null,
                 condicion.GenerarOperadorLogico()
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
