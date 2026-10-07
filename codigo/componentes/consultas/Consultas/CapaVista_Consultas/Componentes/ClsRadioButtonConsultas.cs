using System.Drawing;
using System.Windows.Forms;

namespace CapaVista_Consultas.Componentes
{
    internal class ClsRadioButtonConsultas : RadioButton
    {
        private static readonly Color _ColorTexto =
            ColorTranslator.FromHtml("#2E4A63");

        public ClsRadioButtonConsultas()
        {
            Font = new Font("Tahoma",9.0F,FontStyle.Regular,GraphicsUnit.Point);

            ForeColor = _ColorTexto;
            BackColor = Color.Transparent;
            AutoSize = true;
            Cursor = Cursors.Hand;
            UseVisualStyleBackColor = true;
            Margin = new Padding(3);
        }
    }
}
