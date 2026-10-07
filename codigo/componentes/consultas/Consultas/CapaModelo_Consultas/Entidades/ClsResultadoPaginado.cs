using System.Data;

namespace CapaModelo_Consultas.Entidades
{
    public sealed class ClsResultadoPaginado
    {
        public DataTable Datos { get; set; }
        public long TotalRegistros { get; set; }
        public int Pagina { get; set; }
        public int RegistrosPorPagina { get; set; }
    }
}
