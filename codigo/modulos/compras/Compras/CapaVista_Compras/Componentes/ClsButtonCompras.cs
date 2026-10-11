using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace CapaVista_Compras.Componentes
{
    public partial class ClsButtonCompras : Button
    {
        

        private Image _ImagenDeshabilitado;
        private Image _ImagenNormal;
        private bool _ActualizandoImagen;

        [Category("Compras")]
        [Description("Imagen de fondo que se muestra cuando el botón está deshabilitado.")]
        [DefaultValue(null)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Image ImagenDeshabilitado
        {
            get { return _ImagenDeshabilitado; }
            set
            {
                _ImagenDeshabilitado = value;
                ComprasProcActualizarImagen();
            }
        }

        public ClsButtonCompras()
        {
            AutoSize = false;
            Size = new Size(80, 80);
            MinimumSize = new Size(80, 80);
            MaximumSize = new Size(80, 80);
            BackColor = ClsTemaCompras.FondoBotones;
            ForeColor = ClsTemaCompras.PrincipalNavegador;
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;
            FlatAppearance.BorderColor = ClsTemaCompras.PrincipalNavegador;
            FlatAppearance.MouseOverBackColor = ClsTemaCompras.BotonHover;
            FlatAppearance.MouseDownBackColor = ClsTemaCompras.BotonPresionado;
            UseVisualStyleBackColor = false;
            BackgroundImageLayout = ImageLayout.Stretch;
            Cursor = Cursors.Hand;
            Margin = new Padding(0);
            Anchor = AnchorStyles.None;
        }

        protected override Size DefaultSize => new Size(80, 80);

        protected override void OnPaint(PaintEventArgs Evento)
        {
            base.OnPaint(Evento);
            if (Focused && ShowFocusCues)
            {
                var Area = ClientRectangle;
                Area.Inflate(-2, -2);
                ControlPaint.DrawBorder(Evento.Graphics, Area, ClsTemaCompras.AcentoNavegador, ButtonBorderStyle.Solid);
            }
        }

        protected override void OnBackgroundImageChanged(EventArgs Evento)
        {
            if (!_ActualizandoImagen)
            {
                _ImagenNormal = BackgroundImage;
                ComprasProcActualizarImagen();
            }

            base.OnBackgroundImageChanged(Evento);
        }

        protected override void OnEnabledChanged(EventArgs Evento)
        {
            ComprasProcActualizarImagen();
            Cursor = Enabled ? Cursors.Hand : Cursors.Default;

            base.OnEnabledChanged(Evento);
        }

        private void ComprasProcActualizarImagen()
        {
            Image ImagenActual = !Enabled && _ImagenDeshabilitado != null ? _ImagenDeshabilitado : _ImagenNormal;

            if (ReferenceEquals(BackgroundImage, ImagenActual))
            {
                return;
            }

            _ActualizandoImagen = true;

            try
            {
                BackgroundImage = ImagenActual;
            }
            finally
            {
                _ActualizandoImagen = false;
            }
        }
        
    }
}
