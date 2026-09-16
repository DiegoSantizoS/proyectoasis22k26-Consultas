using System.ComponentModel;
using CapaControlador_Consultas;
using System.Diagnostics.Eventing.Reader;

namespace CapaVista_Consultas.Controles
{
    public partial class UcAgregarCondicion : Componentes.ClsControlUsuarioConsultas
    {
        private readonly ClsControladorConsultas _Controlador =
            new ClsControladorConsultas();
        private readonly clsArregloValores _ArregloValores = new clsArregloValores();


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

            _ArregloValores.ConsultasMetAgregarCondicion(
                ConsultasCboOperadorCampo.Text,
               ConsultasCboOperador.Text,
               ConsultasTxtValor.Text
               );

            var Lista = _ArregloValores.ConsultasMetObtenerCondiciones();

            foreach (string[] Condicion in Lista)
            {
                Console.WriteLine(
                    "Campo: " + Condicion[0] +
                    " | Operador: " + Condicion[1] +
                    " | Valor: " + Condicion[2]
                );
            }

            ConsultasCboOperadorCampo.SelectedIndex = -1;
            ConsultasCboOperador.SelectedIndex = -1;
            ConsultasTxtValor.Clear();
        }

        private void ConsultasCboOperadorCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }
    }
}

