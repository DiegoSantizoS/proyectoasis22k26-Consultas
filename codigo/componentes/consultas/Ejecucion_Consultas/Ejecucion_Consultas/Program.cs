using System;
using System.Windows.Forms;

namespace Ejecucion_Consultas
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new CapaVista_Consultas.FrmConsultasSimples(new string[] { "tbl_rrhh_empleados", "tbl_rrhh_asistencias", "tbl_rrhh_nominas" }));

        }
    }
}