using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace CapaVista_Compras.Componentes
{
    public class ClsTableLayoutPanelCompras : TableLayoutPanel
    {
        private int _ActualizacionesVisuales;
        private IntPtr _VentanaOculta;

        [DllImport("user32.dll")]
        private static extern IntPtr SendMessage(IntPtr Ventana, int Mensaje, IntPtr Parametro, IntPtr Datos);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool IsWindowVisible(IntPtr Ventana);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool RedrawWindow(IntPtr Ventana, IntPtr Rectangulo, IntPtr Region, uint Opciones);

        public ClsTableLayoutPanelCompras()
        {
            BackColor = ClsTemaCompras.FondoGeneral;
            ForeColor = ClsTemaCompras.PrincipalNavegador;
            DoubleBuffered = true;
            ResizeRedraw = true;
        }

        internal void ComprasProcOcultarActualizacion()
        {
            if (_ActualizacionesVisuales++ != 0 || !IsHandleCreated || !IsWindowVisible(Handle)) return;
            _VentanaOculta = Handle;
            SendMessage(_VentanaOculta, 0x000B, IntPtr.Zero, IntPtr.Zero);
        }

        internal void ComprasProcRestaurarActualizacion()
        {
            if (--_ActualizacionesVisuales != 0) return;
            IntPtr Ventana = _VentanaOculta;
            _VentanaOculta = IntPtr.Zero;
            if (Ventana == IntPtr.Zero || IsDisposed || Disposing || !IsHandleCreated || Handle != Ventana) return;
            SendMessage(Ventana, 0x000B, new IntPtr(1), IntPtr.Zero);
            RedrawWindow(Ventana, IntPtr.Zero, IntPtr.Zero, 0x0485);
        }
    }
}
