using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace CapaVista_Compras.Componentes
{
    [DefaultBindingProperty("Text")]
    [DefaultEvent("Click")]
    public partial class UsrLabelCompras : UserControl
    {
        
        private bool _MostrarAsterisco = true;

        internal void ComprasProcConservarRojo()
        {
            ((ClsEtiquetaCompras)ComprasLblTexto).ComprasConservarRojo = true;
            ColorTexto = Color.Red;
            ComprasLblTexto.Invalidate();
        }

        public UsrLabelCompras()
        {
            InitializeComponent();
            DoubleBuffered = true;
            Font = new Font("Tahoma",9F,FontStyle.Regular);
            ComprasLblTexto.Font = Font;
            TabStop = false;
            ComprasLblTexto.TextChanged += (Sender, Evento) => OnTextChanged(Evento);
            ComprasLblTexto.Click += (Sender, Evento) => OnClick(Evento);
            ComprasLblTexto.DoubleClick += (Sender, Evento) => OnDoubleClick(Evento);
            ComprasLblAsterisco.Click += (Sender, Evento) => OnClick(Evento);
        }

        [Browsable(true)]
        [Bindable(true)]
        [DefaultValue("Label de Compras")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public override string Text
        {
            get => ComprasLblTexto == null ? base.Text : ComprasLblTexto.Text;
            set
            {
                if (ComprasLblTexto == null) base.Text = value;
                else ComprasLblTexto.Text = value ?? string.Empty;
            }
        }

        [DefaultValue(ContentAlignment.MiddleRight)]
        public ContentAlignment TextAlign
        {
            get => AlineacionTexto;
            set => AlineacionTexto = value;
        }

        protected override void OnFontChanged(EventArgs Evento)
        {
            base.OnFontChanged(Evento);
            if (ComprasLblTexto != null) ComprasLblTexto.Font = Font;
            if (ComprasLblAsterisco != null) ComprasLblAsterisco.Font = Font;
        }

        protected override void OnForeColorChanged(EventArgs Evento)
        {
            base.OnForeColorChanged(Evento);
            if (ComprasLblTexto != null) ComprasLblTexto.ForeColor = ForeColor;
        }

        protected override void OnBackColorChanged(EventArgs Evento)
        {
            base.OnBackColorChanged(Evento);
            if (ComprasTlpMain != null) ComprasTlpMain.BackColor = BackColor;
        }

        [Category("Compras")]
        [Description("Texto que se mostrará en el label.")]
        [DefaultValue("Label de Compras")]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string Texto
        {
            get { return Text; }
            set { Text = value; }
        }

        [Category("Compras")]
        [Description("Color del texto del label.")]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Color ColorTexto
        {
            get { return ForeColor; }
            set { ForeColor = value; }
        }

        public bool ShouldSerializeColorTexto() => ColorTexto != ClsTemaCompras.PrincipalNavegador;
        public void ResetColorTexto() => ColorTexto = ClsTemaCompras.PrincipalNavegador;

        [Category("Compras")]
        [Description("Muestra u oculta el asterisco y su columna.")]
        [DefaultValue(true)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public bool MostrarAsterisco
        {
            get { return _MostrarAsterisco; }
            set { ComprasMetMostrarAsterisco(value); }
        }

        [Category("Compras")]
        [Description("Define la alineación del texto de la etiqueta.")]
        [DefaultValue(ContentAlignment.MiddleRight)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public ContentAlignment AlineacionTexto
        {
            get { return ComprasLblTexto.TextAlign; }
            set { ComprasLblTexto.TextAlign = value; }
        }


        public void ComprasMetMostrarAsterisco(bool Mostrar)
        {
            if (_MostrarAsterisco == Mostrar && ComprasTlpMain.ColumnCount == (Mostrar ? 2 : 1)) return;
            using (new ClsActualizacionDisenoCompras(ComprasTlpMain))
            {
                if (Mostrar)
                {
                    if (ComprasTlpMain.ColumnCount == 1)
                    {
                        ComprasTlpMain.ColumnCount = 2;
                        ComprasTlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
                    }

                    if (!ComprasTlpMain.Controls.Contains(ComprasLblAsterisco))
                    {
                        ComprasTlpMain.Controls.Add(ComprasLblAsterisco, 1, 0);
                    }

                    if (!ComprasLblAsterisco.Visible) ComprasLblAsterisco.Visible = true;
                }
                else
                {
                    if (ComprasLblAsterisco.Visible) ComprasLblAsterisco.Visible = false;
                    ComprasTlpMain.Controls.Remove(ComprasLblAsterisco);

                    while (ComprasTlpMain.ColumnStyles.Count > 1)
                    {
                        ComprasTlpMain.ColumnStyles.RemoveAt(1);
                    }

                    ComprasTlpMain.ColumnCount = 1;
                }

                _MostrarAsterisco = Mostrar;
            }
        }
        
    }
}
