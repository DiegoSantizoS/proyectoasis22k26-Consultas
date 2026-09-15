using CapaControlador_Consultas;
using CapaVista_Consultas.Components;
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
    public partial class UcAgregarFiltro : ClsControlUsuarioConsultas
    {
        private readonly ClsControladorConsultas _Controlador =
            new ClsControladorConsultas();

        private string _TablaActual;

        public UcAgregarFiltro()
        {
            InitializeComponent();

            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                ConsultasMetCargarOperadores();
            }
        }
      

        public void ConsultasProcActualizarTabla(string Tabla)
        {
            if (string.IsNullOrWhiteSpace(Tabla))
            {
                ConsultasCboCampo.Items.Clear();
                return;
            }

            _TablaActual = Tabla;

            ConsultasMetCargarCampos();
        }

        private void ConsultasMetCargarCampos()
        {
            ConsultasCboCampo.Items.Clear();

            _Controlador.ConsultasMetPoblarComboCampos(
                _TablaActual,
                ConsultasCboCampo);
        }

        private void ConsultasMetCargarOperadores()
        {
            ConsultasCboOperador.Items.Clear();

            ConsultasCboOperador.Items.AddRange(new object[]
            {
                "=",
                ">",
                "<",
                ">=",
                "<=",
                "Contiene",
                "Comienza con",
                "Termina con"
            });
        }
    }
}