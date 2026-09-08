using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using CapaControlador_Consultas;

namespace CapaVista_Consultas
{
    public partial class TablaSimple : UserControl
    {
        clsTablas tablas = new clsTablas();

        public TablaSimple()
        {
            InitializeComponent();

            //this.Load += TablaSimple_Load;
        }

        /*private string _nombreTabla;
        [Category("Consultas")]
        [Description("Nombre de la tabla que se mostrará.")]
        [TypeConverter(typeof(TablaConverter))]
        public string NombreTabla
        {
            get { return _nombreTabla; }
            set { _nombreTabla = value; }
        }


        [Category("Consultas")]
        [Description("Indica si la tabla se carga automáticamente al iniciar.")]
        public bool CargarAutomaticamente { get; set; } = true;

        private void TablaSimple_Load(object sender, EventArgs e)
        {
            if (CargarAutomaticamente && !string.IsNullOrWhiteSpace(_nombreTabla))
            {
                ActualizarTabla();
            }
        }*/
        public void ConsultasProcActualizarTabla(string tablaSeleccionada)
        {
            ConsultasDgvSimples.DataSource = null;
            DataTable dtTablas = tablas.LlenarTabla(tablaSeleccionada);
            ConsultasDgvSimples.DataSource = dtTablas;
        }
    }
}