using CapaControlador_Consultas;
using CapaControlador_Consultas.Temporales;
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
    public partial class FrmConsultasComplejas : ClsBaseTerminus
    {
        // intancia el controlador de tablas relacionadas para obtener las tablas relacionadas Pedro Gómez
        ClsControladorTablasRelacionadas _ControladorTablas = new ClsControladorTablasRelacionadas();

        public string TablaActual { get; set; }

        public FrmConsultasComplejas()
        {
            InitializeComponent();
            ConsultasUcTabla.ConsultasMetAjustarAlturaFilas(30);
        }

        // recibe la tabla del formualrio simple pedro incio
        public FrmConsultasComplejas(string Tabla)
        {
            InitializeComponent();
            TablaActual = Tabla; 
            ConsultasUcTabla.ConsultasMetAjustarAlturaFilas(30);

            // método que llenará el combo
            ConsultasMetLlenarComboTablas();
        }

        private void ConsultasMetLlenarComboTablas()
        {
            ConsultasCboSeleccionTabla.Items.Clear();

            List<string> ListaTablas = _ControladorTablas.ConsultasFuncObtenerTablasRelacionadas(TablaActual);

            // tablas al ComboBox
            foreach (string TablaRelacionada in ListaTablas)
            {
                ConsultasCboSeleccionTabla.Items.Add(TablaRelacionada);
            }

            if (ConsultasCboSeleccionTabla.Items.Count > 0)
            {
                ConsultasCboSeleccionTabla.SelectedIndex = 0;
            }
        }

        // para no perder la tabla al regresar
        private void ConsultasBtnSalir_Click_1(object sender, EventArgs e)
        {
            FrmConsultasSimples FormularioConsultasSimples = new FrmConsultasSimples(TablaActual);
            this.Hide();
            FormularioConsultasSimples.Show();
        }
        // fin
    }
}