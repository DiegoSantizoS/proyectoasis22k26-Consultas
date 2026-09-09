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

namespace CapaVista_Consultas
{
    public partial class TablaCompleja : UserControl
    {
        private int _PaginaActual = 1;
        private int _RegistrosPorPagina = 10;
        private int _TotalRegistros = 0;
        private int _TotalPaginas = 0;
        private string _TablaSeleccionada = "";
        private int _inicioRangoPagina = 1;

        private int _cantidadBotonesPagina = 5; 
        clsTablas tablas = new clsTablas();
        public TablaCompleja()
        {
            InitializeComponent();
            ConsultasProcPopularCboTablas();

        }

        public void ConsultasProcPopularCboTablas()
        {
            ConsultasCboTablas.Items.Clear();

            DataTable daTablas = tablas.ConsultasFuncObtenerTablas();

            foreach (DataRow row in daTablas.Rows)
            {
                ConsultasCboTablas.Items.Add(row[0].ToString());
            }

            ConsultasCboTablas.SelectedIndex = -1;
            ConsultasCboTablas.SelectedItem = null;
            ConsultasCboTablas.Text = "";
        }
        private void ConsultasProcActuaizarDgvTablas(string tablaSeleccionada)
        {
            ConsultasDgvComplejas.DataSource = null;
            DataTable dtTablas = tablas.ConsutlasFuncLlenarTabla(tablaSeleccionada, _PaginaActual, _RegistrosPorPagina);
            ConsultasDgvComplejas.DataSource = dtTablas;
        }
        private void ConsultasCboTablas_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (ConsultasCboTablas.SelectedItem == null)
            {

                return;
            }

            _TablaSeleccionada = ConsultasCboTablas.SelectedItem.ToString();
            _PaginaActual = 1;
            _inicioRangoPagina = 1;

            ConsultasProcCalcularTotalPaginas();
            _TotalPaginas = (int)Math.Ceiling((double)_TotalRegistros / _RegistrosPorPagina );

            ConsultasProcCrearBotonesPaginas();
            ConsultasProcActuaizarDgvTablas(_TablaSeleccionada);

        }
        private void ConsultasProcCalcularTotalPaginas()
        {
            _TotalRegistros = tablas.ConsultasFuncContarRegistros(_TablaSeleccionada);

            _TotalPaginas = (int)Math.Ceiling(
                (double)_TotalRegistros / _RegistrosPorPagina
            );
        }
        private void ConsultasProcCrearBotonesPaginas()
        {
            ConsultasFlpPaginas.Controls.Clear();

            int finRango = _inicioRangoPagina + _cantidadBotonesPagina - 1;

            if (finRango > _TotalPaginas)
                finRango = _TotalPaginas;


            for (int i = _inicioRangoPagina; i <= finRango; i++)
            {
                Button btn = new Button();

                btn.Text = i.ToString();
                btn.Tag = i;

                btn.Width = 35;
                btn.Height = 30;

                btn.Click += BtnPagina_Click;

                ConsultasFlpPaginas.Controls.Add(btn);
            }

            ConsultasProcActualizarBotonesPagina();
        }
        private void BtnPagina_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            _PaginaActual = Convert.ToInt32(btn.Tag);

            ConsultasProcCrearBotonesPaginas();

            ConsultasProcActuaizarDgvTablas(_TablaSeleccionada);
        }
        private void ConsultasProcActualizarBotonesPagina()
        {
            foreach (Button btn in ConsultasFlpPaginas.Controls)
            {
                int pagina = Convert.ToInt32(btn.Tag);

                if (pagina == _PaginaActual)
                {
                    btn.BackColor = Color.FromArgb(197, 155, 39);
                    btn.ForeColor = Color.White;
                }
                else
                {
                    btn.BackColor = Color.White;
                    btn.ForeColor = Color.Black;
                }
            }
        }


        private void ConsultasBtnAnterior_Click(object sender, EventArgs e)
        {
            if (_PaginaActual > 1)
            {
                _PaginaActual--;

                if (_PaginaActual < _inicioRangoPagina)
                {
                    _inicioRangoPagina--;
                }

                ConsultasProcCrearBotonesPaginas();

                ConsultasProcActuaizarDgvTablas(_TablaSeleccionada);
            }
        }

        private void ConsultasBtnSiguiente_Click(object sender, EventArgs e)
        {
            if (_PaginaActual < _TotalPaginas)
            {
                _PaginaActual++;

                if (_PaginaActual >= _inicioRangoPagina + _cantidadBotonesPagina)
                {
                    _inicioRangoPagina++;
                }

                ConsultasProcCrearBotonesPaginas();

                ConsultasProcActuaizarDgvTablas(_TablaSeleccionada);
            }
        }
    }
}
