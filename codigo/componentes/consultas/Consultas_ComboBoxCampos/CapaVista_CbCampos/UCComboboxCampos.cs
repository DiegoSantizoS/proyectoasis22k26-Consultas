using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaControlador_CbCampos;

namespace CapaVista_CbCampos
{
    public partial class UCComboboxCampos : UserControl
    {
        ClsObtenerDatos _Controlador = new ClsObtenerDatos();
        private string _campoSeleccionado;
        private DataTable _dtTabla;



        public UCComboboxCampos()
        {
            InitializeComponent();
        }

        public void llenarCombo(string _tabla)

        {
          
            var dtTabla = _Controlador.enviarDatos(_tabla);

            ConsultasCboCampo.Items.Clear();

            foreach (DataColumn columna in dtTabla.Columns)
            {
                ConsultasCboCampo.Items.Add(columna.ColumnName);
            }

            ConsultasCboCampo.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            ConsultasCboCampo.AutoCompleteSource = AutoCompleteSource.ListItems;


          
        }

        private void ConsultasCboCampo_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (ConsultasCboCampo.SelectedIndex == -1)
                return;

            _campoSeleccionado =
                ConsultasCboCampo.SelectedItem.ToString();
        }

        public Type ObtenerTipoCampo()
        {
            string campo = ObtenerCampoSeleccionado();

            if (campo == null || _dtTabla == null)
                return null;

            return _dtTabla.Columns[campo].DataType;
        }


        public string ObtenerCampoSeleccionado()
        {
            return _campoSeleccionado;
        }

       


    }
}
