namespace CapaModelo_Consultas.Entidades
{
    public sealed class ClsConsultaGuardada
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Tabla { get; set; }
        public ClsDefinicionConsulta Definicion { get; set; }
    }
}
