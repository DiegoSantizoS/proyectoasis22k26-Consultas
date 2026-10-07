using System.Collections.Generic;

namespace CapaModelo_Consultas.Entidades
{
    public sealed class ClsDefinicionConsulta
    {
        public string Tabla { get; set; }
        public List<ClsCondicion> Condiciones { get; set; } = new List<ClsCondicion>();
        public int? Limite { get; set; }
        public int Desplazamiento { get; set; }
    }
}
