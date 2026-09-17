using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaControlador_Consultas;

namespace CapaVista_Consultas.Controles
{
    public partial class UcTabla : Componentes.ClsControlUsuarioConsultas
    {


        private readonly ClsTablas Tablas = new ClsTablas();
        private readonly ClsConsultaSeleccionada seleccionada = new ClsConsultaSeleccionada();
        private int _PaginaActual = 1;
        private string _QuerySeleccionada = "";
        private bool _EsConsultaPersonalizada = false;
        public int RegistrosPorPagina = 15;
        private int _TotalRegistros = 0;
        private int _TotalPaginas = 0;
        private string _TablaSeleccionada = "";
        private int _InicioRangoPagina = 1;
        private int _CantidadBotonesPagina = 5;

        public UcTabla()
        {
            InitializeComponent();

            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                ConsultasDgvSimples.AutoGenerateColumns = true;
                ConsultasProcActualizarTabla("tblConsulta");
            }
        }

        public void ConsultasMetAjustarAlturaFilas(int RegistrosPorPagina)
        {
            this.RegistrosPorPagina = RegistrosPorPagina;
        }

        public UcTabla(string tabla)
        {
            InitializeComponent();

            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                ConsultasDgvSimples.AutoGenerateColumns = true;
                ConsultasProcActualizarTabla(tabla);
            }
        }
       

        public void ConsultasProcActualizarTabla(string tablaSeleccionada)
        {
            if (_TablaSeleccionada != tablaSeleccionada)
            {
                _PaginaActual = 1;
                _InicioRangoPagina = 1;
            }

            _TablaSeleccionada = tablaSeleccionada;

            ConsultasProcCalcularTotalPaginas();

            DataTable DtTablas = Tablas.ConsultasFuncLlenarTabla(
                _TablaSeleccionada,
                _PaginaActual,
                RegistrosPorPagina);

            ConsultasDgvSimples.DataSource = DtTablas;


            ConsultasProcCrearBotonesPaginas();
            ConsultasProcCambiarLbl();

        }
        public void ConsultasProcCargarConsultaDesdeQuery(String Consulta, String tabla)
        {
            if (_TablaSeleccionada != tabla)
            {
                _PaginaActual = 1;
                _InicioRangoPagina = 1;
            }

            _TablaSeleccionada = tabla;
            ConsultasProcCalcularTotalPaginas();

            DataTable dtTablas = seleccionada.ConsultasFuncCargarConsulta(
                Consulta,
                _PaginaActual,
                RegistrosPorPagina);

            ConsultasDgvSimples.DataSource = dtTablas;
        }
        /*
        Inicio de código de "José Pablo Cano Cóbar" - carné: "0901-23-1727" - Fecha: "15/09/26"
        */
        public void ConsultasProcMostrarResultado(
            System.Data.DataTable Datos,
            int TotalRegistros)
        {
            _PaginaActual = 1;
            _InicioRangoPagina = 1;
            _TotalRegistros = TotalRegistros;

            _TotalPaginas = (int)System.Math.Ceiling(
                (double)_TotalRegistros / RegistrosPorPagina);

            ConsultasDgvSimples.DataSource = Datos;

            ConsultasProcCrearBotonesPaginas();

            ConsultasProcCambiarLblResultado();
        }

        public void ConsultasProcMostrarResultado(System.Data.DataTable Datos)
        {
            ConsultasProcMostrarResultado(
                Datos,
                Datos == null ? 0 : Datos.Rows.Count);
        }

        private void ConsultasProcCambiarLblResultado()
        {
            if (_TotalRegistros == 0)
            {
                ConsultasLblPaginacion.Text = "Sin registros que coincidan";
                return;
            }

            int Desde = ((_PaginaActual - 1) * RegistrosPorPagina) + 1;
            int Hasta = _PaginaActual * RegistrosPorPagina;

            if (Hasta > _TotalRegistros)
            {
                Hasta = _TotalRegistros;
            }

            ConsultasLblPaginacion.Text =
                "Mostrando " + Desde + "-" + Hasta +
                " de " + _TotalRegistros + " registros";
        }

        private void ConsultasProcCalcularTotalPaginas()
        {
            _TotalRegistros = Tablas.ConsultasFuncContarRegistros(_TablaSeleccionada);

            _TotalPaginas = (int)Math.Ceiling(
                (double)_TotalRegistros / RegistrosPorPagina
            );
        }
        private void ConsultasProcCrearBotonesPaginas()
        {
            ConsultasFlpPaginas.Controls.Clear();

            int FinRango = _InicioRangoPagina + _CantidadBotonesPagina - 1;

            if (FinRango > _TotalPaginas)
                FinRango = _TotalPaginas;

            for (int NumeroPagina = _InicioRangoPagina; NumeroPagina <= FinRango; NumeroPagina++)
            {
                Componentes.ClsBotonPaginacionConsultas BotonPagina =
                    new Componentes.ClsBotonPaginacionConsultas();

                BotonPagina.Name = $"ConsultasBtnPagina{NumeroPagina}";
                BotonPagina.Text = NumeroPagina.ToString();
                BotonPagina.Tag = NumeroPagina;
                BotonPagina.EsActivo = NumeroPagina == _PaginaActual;

                BotonPagina.Click += BtnPagina_Click;

                ConsultasFlpPaginas.Controls.Add(BotonPagina);
            }
        }
        private void BtnPagina_Click(object sender, EventArgs e)
        {
            Componentes.ClsBotonPaginacionConsultas BotonPagina =
                (Componentes.ClsBotonPaginacionConsultas)sender;

            _PaginaActual = Convert.ToInt32(BotonPagina.Tag);

            if (_EsConsultaPersonalizada)
            {
                ConsultasProcCargarConsultaDesdeQuery(
                    _QuerySeleccionada,
                    _TablaSeleccionada);
            }
            else
            {
                ConsultasProcActualizarTabla(
                    _TablaSeleccionada);
            }
        }

        private void ConsultasBtnAnterior1_Click(object sender, EventArgs e)
        {
            if (_PaginaActual > 1)
            {
                _PaginaActual--;

                if (_PaginaActual < _InicioRangoPagina)
                {
                    _InicioRangoPagina--;
                }

                if (_EsConsultaPersonalizada)
                {
                    ConsultasProcCargarConsultaDesdeQuery(
                        _QuerySeleccionada,
                        _TablaSeleccionada);
                }
                else
                {
                    ConsultasProcActualizarTabla(
                        _TablaSeleccionada);
                }
            }
        }

        private void ConsultasBtnSiguiente_Click_1(object sender, EventArgs e)
        {
            if (_PaginaActual < _TotalPaginas)
            {
                _PaginaActual++;

                if (_PaginaActual >=
                    _InicioRangoPagina + _CantidadBotonesPagina)
                {
                    _InicioRangoPagina++;
                }

                if (_EsConsultaPersonalizada)
                {
                    ConsultasProcCargarConsultaDesdeQuery(
                        _QuerySeleccionada,
                        _TablaSeleccionada);
                }
                else
                {
                    ConsultasProcActualizarTabla(
                        _TablaSeleccionada);
                }
            }
        }
        private void ConsultasProcCambiarLbl()
        {
            ConsultasLblPaginacion.Text = "Mostrando " +
                (((_PaginaActual - 1) * RegistrosPorPagina) + 1) +
                "-" +
                (_PaginaActual * RegistrosPorPagina) +
                " de " +
                Tablas.ConsultasFuncContarRegistros(_TablaSeleccionada) +
                " registros";
        }
        public void ConsultasProcCambiarRegistrosPorPagina(int cantidad)
        {
            RegistrosPorPagina = cantidad;

            // Reiniciar paginación
            _PaginaActual = 1;
            _InicioRangoPagina = 1;

            // Actualizar tabla con la nueva cantidad
            ConsultasProcActualizarTabla(_TablaSeleccionada);
        }

        public void ConsultasProcCambiarRegistrosPorPagina(int cantidad, string tabla)
        {
            RegistrosPorPagina = cantidad;

            _PaginaActual = 1;
            _InicioRangoPagina = 1;

            ConsultasProcActualizarTabla(tabla);
        }
    }

}
