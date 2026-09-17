using System;
using System.Data;
using System.Windows.Forms;
using CapaControlador_Consultas;
using CapaVista_Consultas.Controles;

namespace CapaVista_Consultas
{
    // Inicio de código de "José Pablo Cano Cóbar" - carné: "0901-23-1727" - Fecha: "15/09/26"
    public partial class FrmConsultasSimples : Componentes.ClsBaseTerminus
    {
        private readonly ClsControladorFiltroSimple _Controlador =
            new ClsControladorFiltroSimple();

        private string _TablaActual;
        private string _CampoFiltro;
        private string _OperadorFiltro;
        private string _ValorFiltro;
        private const int _RegistrosPorPagina = 15;

        public FrmConsultasSimples()
        {
            InitializeComponent();

            ConsultasMetSuscribirEventos();
        }

        public FrmConsultasSimples(string Tabla)
        {
            InitializeComponent();

            ConsultasMetSuscribirEventos();

            _TablaActual = Tabla;

            ClsTablaSeleccionada.ConsultasMetGuardarTabla(Tabla);

            ConsultasUcTablaSimple.ConsultasProcActualizarTabla(Tabla);
            ConsultasUcAgregarFiltro.ConsultasProcActualizarTabla(Tabla);
        }

        public FrmConsultasSimples(string[] Tablas)
        {
            InitializeComponent();

            ConsultasMetSuscribirEventos();

            _TablaActual = Tablas[0];
            ;

            ClsTablaSeleccionada.ConsultasMetGuardarTabla(Tablas[0]);

            ConsultasUcTablaSimple.ConsultasProcActualizarTabla(Tablas[0]);
            ConsultasUcAgregarFiltro.ConsultasProcActualizarTabla(Tablas[0]);
        }

        private void ConsultasMetSuscribirEventos()
        {
            ConsultasUcAgregarFiltro.ConsultasEvtBuscarSolicitado +=
                ConsultasUcAgregarFiltro_BuscarSolicitado;

            ConsultasUcAgregarFiltro.ConsultasEvtRefrescarSolicitado +=
                ConsultasUcAgregarFiltro_RefrescarSolicitado;
        }

        private void ConsultasUcAgregarFiltro_BuscarSolicitado(
            object sender,
            ClsArgumentosFiltro e)
        {
            _CampoFiltro = e.Campo;
            _OperadorFiltro = e.Operador;
            _ValorFiltro = e.Valor;

            ConsultasMetAplicarFiltro();
        }

        private void ConsultasUcAgregarFiltro_RefrescarSolicitado(
            object sender,
            EventArgs e)
        {
            _CampoFiltro = null;
            _OperadorFiltro = null;
            _ValorFiltro = null;

            ConsultasUcTablaSimple.ConsultasProcActualizarTabla(_TablaActual);
        }

        private void ConsultasMetAplicarFiltro()
        {
            try
            {
                Cursor = Cursors.WaitCursor;

                DataTable DtResultado = _Controlador.ConsultasFuncBuscar(
                    _TablaActual,
                    _CampoFiltro,
                    _OperadorFiltro,
                    _ValorFiltro,
                    1,
                    _RegistrosPorPagina);

                int TotalRegistros = _Controlador.ConsultasFuncContar(
                    _TablaActual,
                    _CampoFiltro,
                    _OperadorFiltro,
                    _ValorFiltro);

                ConsultasUcTablaSimple.ConsultasProcMostrarResultado(
                    DtResultado,
                    TotalRegistros);

                if (TotalRegistros == 0)
                {
                    MessageBox.Show(
                        "Ningún registro cumple con el filtro indicado.",
                        "Consultas",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(
                    "No se pudo ejecutar la consulta.\n\nDetalle: " + Ex.Message,
                    "Consultas",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void ConsultasBtnComplejas_Click_1(object sender, EventArgs e)
        {
            FrmConsultasComplejas FormularioConsultasComplejas =
                new FrmConsultasComplejas(_TablaActual);

            FormularioConsultasComplejas.FormClosed += (Remitente, Argumentos) =>
            {
                this.Show();
                this.BringToFront();
            };

            this.Hide();
            FormularioConsultasComplejas.Show();
        }

        private void ConsultasBtnSalir_Click(object sender, EventArgs e)
        {
            DialogResult Respuesta = MessageBox.Show(
                "¿Desea salir del componente de Consultas?",
                "Consultas",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (Respuesta == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
    // Fin del código de "José Pablo Cano Cóbar" - Carné: "0901-23-1727" - Fecha: "15/09/26"
}
