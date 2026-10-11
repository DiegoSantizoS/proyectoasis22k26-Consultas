using System.Windows.Forms;

namespace CapaVista_Compras.Componentes
{
    public class ClsPanelCompras : Panel
    {
        
        public ClsPanelCompras()
        {
            BackColor = ClsTemaCompras.FondoGeneral;
            ForeColor = ClsTemaCompras.PrincipalNavegador;
            DoubleBuffered = true;
            ResizeRedraw = true;
        }
        
    }
}
