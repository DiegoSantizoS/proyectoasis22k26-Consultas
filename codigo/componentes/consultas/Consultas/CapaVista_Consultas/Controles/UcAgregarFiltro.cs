using CapaControlador_Consultas;
using System.ComponentModel;

namespace CapaVista_Consultas.Controles
{
    public partial class UcAgregarFiltro : Componentes.ClsControlUsuarioConsultas
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