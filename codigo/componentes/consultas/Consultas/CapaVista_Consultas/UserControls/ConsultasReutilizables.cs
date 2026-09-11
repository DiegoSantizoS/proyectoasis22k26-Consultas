using CapaControlador_Consultas;
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
    public partial class ConsultasReutilizables : UserControl
    {
        public ConsultasReutilizables()
        {
            InitializeComponent();
            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                ClsEstandarizacionDataGridView.Estandarizar(ConsultasDgvConsultasReutilizables);
            }
        }
    }
}
