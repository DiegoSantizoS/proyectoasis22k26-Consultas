using System;
using System.Drawing;
using System.Windows.Forms;

namespace CapaVista_Compras.Componentes
{
    public partial class UsrBaseCompras : UserControl
    {
        
        private Size _TamanoDiseno;
        private float _EscalaAltura = 1F;
        internal event EventHandler ComprasEvtTamanoNecesario;
        internal Size ComprasTamanoDiseno => _TamanoDiseno;

        internal void ComprasProcRegistrarDiseno()
        {
            _TamanoDiseno = ClientSize;
            MaximumSize = Size.Empty;
        }

        internal int ComprasFuncEscalarAltura(float Altura)
        {
            return (int)Math.Ceiling(Altura * _EscalaAltura);
        }

        internal void ComprasProcNotificarTamano()
        {
            ComprasEvtTamanoNecesario?.Invoke(this, EventArgs.Empty);
        }

        internal virtual Size ComprasFuncTamanoNecesario()
        {
            return _TamanoDiseno;
        }

        protected override void ScaleControl(SizeF Factor, BoundsSpecified Especificado)
        {
            base.ScaleControl(Factor, Especificado);
            if (_TamanoDiseno.IsEmpty) return;
            _TamanoDiseno = new Size((int)Math.Ceiling(_TamanoDiseno.Width * Factor.Width), (int)Math.Ceiling(_TamanoDiseno.Height * Factor.Height));
            _EscalaAltura *= Factor.Height;
            ComprasProcNotificarTamano();
        }

        public UsrBaseCompras()
        {
            InitializeComponent();
            DoubleBuffered = true;
        }
        
    }
}
