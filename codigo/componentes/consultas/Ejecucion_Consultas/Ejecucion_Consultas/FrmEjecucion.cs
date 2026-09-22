using CapaVista_Consultas;
using CapaVista_Consultas.Componentes;
using System;

namespace Ejecucion_Consultas
{
    public partial class FrmEjecucion :
        ClsBaseTerminus
    {
        public FrmEjecucion()
        {
            InitializeComponent();
        }

        private void ConsultasMetBtnConsultarClick(
            object sender,
            EventArgs e)
        {
<<<<<<< HEAD
            using (FrmConsultasSimples FormularioConsultasSimples =
                new FrmConsultasSimples(
                    "tblConsulta",
                    "Pk_Consulta"))
=======
            string[] TablasDePrueba = new string[] { "tblProveedor", "vwComprasPorProveedor" };

            using (FrmConsultasSimples FormularioConsultasSimples =
                new FrmConsultasSimples(
                    TablasDePrueba,
                    "Pk_Proveedor"))
>>>>>>> 858b8ecdd61146fd72666170e3685eb1487ce977
            {
                FormularioConsultasSimples.ShowDialog();

                if (FormularioConsultasSimples.SeleccionRealizada)
                {
                    ConsultasTxtId.Text =
                        FormularioConsultasSimples.IdSeleccionado;
                }
            }
        }
    }
}