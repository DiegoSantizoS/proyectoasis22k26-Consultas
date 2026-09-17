using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using CapaControlador_Consultas;

namespace CapaVista_Consultas.Controles
{
    // Inicio de código de "José Pablo Cano Cóbar" - carné: "0901-23-1727" - Fecha: "15/09/26"
    public partial class UcAgregarFiltro : Componentes.ClsControlUsuarioConsultas
    {
        private readonly ClsControladorFiltroSimple _Controlador =
            new ClsControladorFiltroSimple();

        private string _TablaActual;

        public event EventHandler<ClsArgumentosFiltro> ConsultasEvtBuscarSolicitado;

        public event EventHandler ConsultasEvtRefrescarSolicitado;

        public UcAgregarFiltro()
        {
            InitializeComponent();

            ConsultasBtnBuscar.Click += ConsultasBtnBuscar_Click;
            ConsultasBtnRefrescar.Click += ConsultasBtnRefrescar_Click;

            ConsultasTxtValor.KeyDown += ConsultasTxtValor_KeyDown;

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
                _TablaActual = null;
                return;
            }

            _TablaActual = Tabla;

            ConsultasMetCargarCampos();
        }

        public void ConsultasProcLimpiar()
        {
            ConsultasCboCampo.SelectedIndex = -1;
            ConsultasCboOperador.SelectedIndex = -1;
            ConsultasTxtValor.Clear();
        }

        private void ConsultasMetCargarCampos()
        {
            ConsultasCboCampo.Items.Clear();

            try
            {
                List<string> Campos =
                    _Controlador.ConsultasFuncObtenerCampos(_TablaActual);

                foreach (string Campo in Campos)
                {
                    ConsultasCboCampo.Items.Add(Campo);
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(
                    "No se pudieron cargar los campos de la tabla '" +
                    _TablaActual + "'.\n\nDetalle: " + Ex.Message,
                    "Consultas",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void ConsultasMetCargarOperadores()
        {
            ConsultasCboOperador.Items.Clear();

            List<string> Operadores =
                _Controlador.ConsultasFuncObtenerOperadores();

            foreach (string Operador in Operadores)
            {
                ConsultasCboOperador.Items.Add(Operador);
            }
        }

        private void ConsultasBtnBuscar_Click(object sender, EventArgs e)
        {
            string Campo = ConsultasCboCampo.SelectedItem == null
                ? string.Empty
                : ConsultasCboCampo.SelectedItem.ToString();

            string Operador = ConsultasCboOperador.SelectedItem == null
                ? string.Empty
                : ConsultasCboOperador.SelectedItem.ToString();

            string Valor = ConsultasTxtValor.Text;

            string Mensaje = _Controlador.ConsultasFuncValidarFiltro(
                Campo,
                Operador,
                Valor);

            if (Mensaje != null)
            {
                MessageBox.Show(
                    Mensaje,
                    "Consultas",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                return;
            }

            if (ConsultasEvtBuscarSolicitado != null)
            {
                ConsultasEvtBuscarSolicitado(
                    this,
                    new ClsArgumentosFiltro(Campo, Operador, Valor));
            }
        }

        private void ConsultasBtnRefrescar_Click(object sender, EventArgs e)
        {
            ConsultasProcLimpiar();

            if (ConsultasEvtRefrescarSolicitado != null)
            {
                ConsultasEvtRefrescarSolicitado(this, EventArgs.Empty);
            }
        }

        private void ConsultasTxtValor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                ConsultasBtnBuscar_Click(sender, EventArgs.Empty);
            }
        }

        private void ConsultasTlpPrincipal_Paint(object sender, PaintEventArgs e)
        {

        }
    }

    public class ClsArgumentosFiltro : EventArgs
    {
        public string Campo { get; private set; }
        public string Operador { get; private set; }
        public string Valor { get; private set; }

        public ClsArgumentosFiltro(string Campo, string Operador, string Valor)
        {
            this.Campo = Campo;
            this.Operador = Operador;
            this.Valor = Valor;
        }
    }
    // Fin del código de "José Pablo Cano Cóbar" - Carné: "0901-23-1727" - Fecha: "15/09/26"
}