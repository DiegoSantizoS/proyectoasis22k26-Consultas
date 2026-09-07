using System;
using System.Data;
using System.Windows.Forms;
using CapaControlador_Consultas;

namespace CapaVista_Consultas
{
    public partial class TablaSimple : UserControl
    {
        //Insertar nombre de la tabla a consultar
        string tabla = "empleado"; // Reemplaza con el nombre real de la tabla
        clsTablas tablas = new clsTablas();
        public TablaSimple()
        {
            InitializeComponent();
            actuaizarDgvTablas(tabla);
        }

        private void actuaizarDgvTablas(string tablaSeleccionada)
        {
            ConsultasDgvSimples.DataSource = null;
            DataTable dtTablas = tablas.LlenarTabla(tablaSeleccionada);
            ConsultasDgvSimples.DataSource = dtTablas;
        }
    }
}