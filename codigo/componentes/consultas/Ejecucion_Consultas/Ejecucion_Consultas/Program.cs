using System;
using System.Windows.Forms;
using CapaVista_Consultas;

namespace Ejecucion_Consultas
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
<<<<<<< HEAD
            string[] Tablas =
            {
                "vwDetalleCompras",
                "vwComprasPorProveedor",
                "vwComprasPorProducto",
                "tblConsulta"
            };
=======
            
>>>>>>> 858b8ecdd61146fd72666170e3685eb1487ce977
            Application.Run(new FrmEjecucion());
            
        }
    }
}