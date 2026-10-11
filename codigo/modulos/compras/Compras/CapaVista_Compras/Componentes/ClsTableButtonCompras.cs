using System;
using System.Drawing;
using System.Windows.Forms;

namespace CapaVista_Compras.Componentes
{
    internal class ClsTableButtonCompras : Button
    {
        
        private static readonly Color _Primario = ClsTemaCompras.PrincipalNavegador;
        private static readonly Color _Secundario = ClsTemaCompras.AcentoNavegador;
        private bool _EsActivo;

        public bool EsActivo
        {
            get => _EsActivo;
            set
            {
                _EsActivo = value;
                ComprasProcActualizarEstado();
            }
        }

        public ClsTableButtonCompras()
        {
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Size = new Size(36, 30);
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;
            FlatAppearance.MouseOverBackColor = _Secundario;
            FlatAppearance.MouseDownBackColor = _Primario;
            BackColor = _Primario;
            ForeColor = Color.White;
            Cursor = Cursors.Hand;
            UseVisualStyleBackColor = false;
            TextAlign = ContentAlignment.MiddleCenter;
            Margin = new Padding(2);
        }

        protected override Size DefaultSize => new Size(36, 30);

        protected override void OnMouseEnter(EventArgs Evento)
        {
            base.OnMouseEnter(Evento);

            if (!EsActivo)
            {
                BackColor = _Secundario;
                ForeColor = Color.White;
            }
        }

        protected override void OnMouseLeave(EventArgs Evento)
        {
            base.OnMouseLeave(Evento);
            ComprasProcActualizarEstado();
        }

        protected override void OnEnabledChanged(EventArgs Evento)
        {
            base.OnEnabledChanged(Evento);
            Cursor = Enabled ? Cursors.Hand : Cursors.Default;
            ComprasProcActualizarEstado();
        }

        private void ComprasProcActualizarEstado()
        {
            BackColor = !Enabled ? ClsTemaCompras.FondoBotones : EsActivo ? _Secundario : _Primario;
            ForeColor = Enabled ? Color.White : ClsTemaCompras.PrincipalNavegador;
            if (Font.Name != "Segoe UI" || Font.Size != 9F || Font.Style != FontStyle.Regular || Font.Unit != GraphicsUnit.Point) Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
        }
        
    }
}
