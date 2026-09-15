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
    }
    }

