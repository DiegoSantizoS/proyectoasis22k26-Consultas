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
    public partial class TablaCompleja : UserControl
    {
        clsTablas tablas = new clsTablas();
        public TablaCompleja()
        {
            InitializeComponent();
            PopularCboTablas();

        }
        public void PopularCboTablas()
        {
            ConsultasCboTablas.Items.Clear();

            DataTable daTablas = tablas.ObtenerTablas();

            foreach (DataRow row in daTablas.Rows)
            {
                ConsultasCboTablas.Items.Add(row[0].ToString());
            }

            ConsultasCboTablas.SelectedIndex = -1;
            ConsultasCboTablas.SelectedItem = null;
            ConsultasCboTablas.Text = "";
        }
        private void actuaizarDgvTablas(string tablaSeleccionada)
        {
            ConsultasDgvComplejas.DataSource = null;
            DataTable dtTablas = tablas.LlenarTabla(tablaSeleccionada);
            ConsultasDgvComplejas.DataSource = dtTablas;
        }
        private void ConsultasCboTablas_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (ConsultasCboTablas.SelectedItem == null)
            {

                return;
            }

            string tablaSeleccionada = ConsultasCboTablas.SelectedItem.ToString();
            actuaizarDgvTablas(tablaSeleccionada);

        }
    }
}
