using System.Drawing;
using System.Windows.Forms;

namespace CapaVista_Compras.Componentes
{

    public partial class ClsComboBoxCompras : ComboBox
    {
        
        public ClsComboBoxCompras()
        {
            Font = new Font("Segoe UI",10F,FontStyle.Regular,GraphicsUnit.Point);
            ForeColor = ClsTemaCompras.PrincipalNavegador;
            BackColor = ClsTemaCompras.FondoGeneral;
            DropDownStyle = ComboBoxStyle.DropDownList;
            FlatStyle = FlatStyle.Flat;
            IntegralHeight = true;
            MaxDropDownItems = 8;
            Margin = new Padding(3);
        }

        protected override Size DefaultSize =>
            new Size(200, 27);
    }
    

}
