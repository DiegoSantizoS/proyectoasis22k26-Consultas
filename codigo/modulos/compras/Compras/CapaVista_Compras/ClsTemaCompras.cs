using System.Drawing;

namespace CapaVista_Compras
{
    public static class ClsTemaCompras
    {
        public static readonly Color PrincipalNavegador = Color.FromArgb(30, 42, 90);
        public static readonly Color AcentoNavegador = Color.FromArgb(61, 86, 166);
        public static readonly Color FondoEtiquetasDestacadas = Color.FromArgb(217, 145, 62);
        public static readonly Color FondoGeneral = Color.FromArgb(246, 247, 250);
        public static readonly Color FondoBotones = Color.FromArgb(213, 220, 239);

        public static Color BotonHover => Mezclar(FondoBotones, AcentoNavegador, 20);
        public static Color BotonPresionado => Mezclar(FondoBotones, AcentoNavegador, 35);

        private static Color Mezclar(Color Fondo, Color Acento, int Porcentaje)
        {
            return Color.FromArgb(
                (Fondo.R * (100 - Porcentaje) + Acento.R * Porcentaje) / 100,
                (Fondo.G * (100 - Porcentaje) + Acento.G * Porcentaje) / 100,
                (Fondo.B * (100 - Porcentaje) + Acento.B * Porcentaje) / 100);
        }
    }
}
