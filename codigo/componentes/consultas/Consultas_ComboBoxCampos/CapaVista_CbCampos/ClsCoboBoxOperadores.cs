using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVista_CbCampos
{
    public partial class ClsCoboBoxOperadores : UserControl
    {

        private DataTable _dtTabla;
        private string _campoSeleccionado;
        private string _operadorSeleccionado;
        public ClsCoboBoxOperadores()
        {
            InitializeComponent();
        }

        private void ConsultasCboOperador_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ConsultasCboOperador.SelectedIndex == -1)
                return;

            _operadorSeleccionado =
                ConsultasCboOperador.SelectedItem.ToString();

        }

        public void ConfigurarOperadores(DataTable dtTabla, string campoSeleccionado)
        {
            _dtTabla = dtTabla;
            _campoSeleccionado = campoSeleccionado;

            ConsultasCboOperador.Items.Clear();

            List<string> operadores = ObtenerOperadores();

            ConsultasCboOperador.Items.AddRange(operadores.ToArray());
        }


        public List<string> ObtenerOperadores()
        {
            List<string> operadores = new List<string>();

            if (string.IsNullOrEmpty(_campoSeleccionado))
                return operadores;

            DataColumn columna =
                _dtTabla.Columns[_campoSeleccionado];

            Type tipo = columna.DataType;

            if (tipo == typeof(int) ||
                tipo == typeof(long) ||
                tipo == typeof(short) ||
                tipo == typeof(decimal) ||
                tipo == typeof(double) ||
                tipo == typeof(float))
            {
                operadores.AddRange(new[]
                {
            "=",
            ">",
            "<",
            ">=",
            "<="
        });
            }
            else if (tipo == typeof(string))
            {
                operadores.AddRange(new[]
                {
            "=",
            "LIKE",
            "NOT LIKE"
        });
            }
            else if (tipo == typeof(DateTime))
            {
                operadores.AddRange(new[]
                {
            "=",
            ">",
            "<",
            ">=",
            "<="
        });
            }
            else if (tipo == typeof(bool))
            {
                operadores.AddRange(new[]
                {
            "=",
            "<>"
        });
            }

            return operadores;
        }

        public string ObtenerOperadorSeleccionado()
        {
            return _operadorSeleccionado;
        }



    }
}
