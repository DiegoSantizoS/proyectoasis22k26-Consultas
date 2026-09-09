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
    public partial class ConsultaCompleja_500_001 : Form
    {
        public ConsultaCompleja_500_001()
        {
            InitializeComponent();
            // Estandarización EST-10 del Componente Consultas
            ClsEstandarizacionConsultas.ConsultasMetAplicarFormatoVentana(
                this, "4002", "ConsultasComplejas");
            ClsEstandarizacionConsultas.ConsultasMetAplicarFormatoBoton(ConsultasBtnInicio);
            ClsEstandarizacionConsultas.ConsultasMetAplicarFormatoCuadricula(ConsultasDgvFiltros);

            ConsultasMetCargarFiltrosDemo();
        }

        /// <summary>
        /// TEMPORAL - Carga filas de ejemplo para el prototipo.
        /// Eliminar cuando el constructor de consultas alimente la cuadrícula.
        /// </summary>
        private void ConsultasMetCargarFiltrosDemo()
        {
            ConsultasDgvFiltros.Rows.Clear();
            ConsultasDgvFiltros.Rows.Add("1", "Comparación", "=", "departamento", "Ventas");
            ConsultasDgvFiltros.Rows.Add("2", "Lógica", "AND", "estado", "1");
            ConsultasDgvFiltros.Rows.Add("3", "Comparación", ">=", "salario", "5000");
            ConsultasDgvFiltros.Rows.Add("4", "Lógica", "OR", "puesto", "Vendedor");
        }

        private void ConsultasBtnInicio_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
