using System.ComponentModel;
using CapaControlador_Consultas;

namespace CapaVista_Consultas.Controles
{
    public partial class UcAgregarCondicion : Componentes.ClsControlUsuarioConsultas
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
    }
    }

