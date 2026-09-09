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
    public partial class Agrupar_Ordenar : UserControl
    {
        // Mishel loeiza 9959-23-3457
        private ClsControladorConsultas _controlador = new ClsControladorConsultas();

        public Agrupar_Ordenar()
        {
            InitializeComponent();
            CargarDatosIniciales();
        }

       
        private void CargarDatosIniciales()
        {
            string tabla = "Empleados"; //la tabla es solo de prueba 

            _controlador.PoblarComboCampos(tabla, ConsultasCboCampo);

            ConsultasCboOperador.Items.Clear();
            ConsultasCboOperador.Items.AddRange(new object[]
            {
                "=", ">", "<", ">=", "<=", "Contiene", "Comienza con", "Termina con"
            });

            ConsultasRdoAsc.Checked = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        // botón Filtrar 
        private void button1_Click(object sender, EventArgs e)
        {
            string tabla = "Empleados";
            string campo = ConsultasCboCampo.SelectedItem?.ToString();
            string operador = ConsultasCboOperador.SelectedItem?.ToString();
            string valor = ConsultasTxtValor.Text;
            string ordenamiento = ConsultasRdoDesc.Checked ? "DESC" : "ASC";

            string error = _controlador.ValidarFiltro(campo);
            if (error != null)
            {
                MessageBox.Show(error);
                return;
            }

            var resultado = _controlador.Filtrar(tabla, campo, operador, valor, ordenamiento);
            MessageBox.Show($"Filtro ejecutado. Registros encontrados: {resultado.Rows.Count}");
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}