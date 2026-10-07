namespace CapaModelo_Consultas.Entidades
{
    public sealed class ClsCondicion
    {
        public string Campo { get; set; }
        public string Operador { get; set; }
        public string Valor { get; set; }
        public string Orden { get; set; }
        public string Conector { get; set; }
        public object ValorTipado { get; set; }
    }
}
