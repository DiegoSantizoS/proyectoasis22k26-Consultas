using System.Collections.Generic;

namespace CapaModelo_Consultas.Repositorios
{
    internal sealed class ClsConsultaPreparada
    {
        internal string Texto { get; set; }
        internal string Orden { get; set; }
        internal List<object> Valores { get; } = new List<object>();
    }
}
