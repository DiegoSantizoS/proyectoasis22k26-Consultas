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
using CapaControlador_Consultas;
using System.Diagnostics.Eventing.Reader;

namespace CapaVista_Consultas.UserControls
{
    public partial class UcAgregarCondicion : ClsControlUsuarioConsultas
    {
        private readonly ClsControladorConsultas _Controlador =
            new ClsControladorConsultas();


        private string _TablaActual = ClsTablaSeleccionada.ConsultasFuncObtenerTabla();
        public UcAgregarCondicion()
        {
            InitializeComponent();
            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                ConsultasMetCargarOperadores();

                ConsultasMetCargarCampos();
            }
        }

        private void ConsultasMetCargarCampos()
        {
            ConsultasCboOperadorCampo.Items.Clear();

            _Controlador.ConsultasMetPoblarComboCampos(
                _TablaActual,
                ConsultasCboOperadorCampo);
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
                "LIKE"
            });
        }

        private bool ConsultasMetValidarCampo()
        {
            if (ConsultasCboOperadorCampo.SelectedItem == null ||
                string.IsNullOrWhiteSpace(ConsultasCboOperadorCampo.Text))
            {
                MessageBox.Show(
                        "Error: Debe seleccionar un campo.",
                      "Error",
                     MessageBoxButtons.OK,
                      MessageBoxIcon.Error);
                ConsultasCboOperadorCampo.Focus();
                return false;
            }
            else
            {
                if (ConsultasCboOperador.SelectedItem == null ||
                 string.IsNullOrWhiteSpace(ConsultasCboOperador.Text))
                {
                    MessageBox.Show(
                       "Error: Debe seleccionar un operador.",
                        "Error",
                     MessageBoxButtons.OK,
                      MessageBoxIcon.Error);
                    ConsultasCboOperador.Focus();
                    return false;
                }
                else
                {
                    if (string.IsNullOrWhiteSpace(ConsultasTxtValor.Text))
                    {
                        MessageBox.Show(
                         "Error: Debe Ingresar un valor.",
                         "Error",
                         MessageBoxButtons.OK,
                         MessageBoxIcon.Error);
                        ConsultasTxtValor.Focus();
                        return false;
                    }
                }
            }



            return true;
        }

        private void ConsultasBtnIngresar_Click(object sender, EventArgs e)
        {
            if (!ConsultasMetValidarCampo())
                return;

        }
    }
}

