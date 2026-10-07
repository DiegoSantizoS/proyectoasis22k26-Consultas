using System.Data;

namespace CapaControlador_Consultas
{
    public sealed class ClsPaginaConsulta
    {
        public DataTable Datos { get; internal set; }
        public long TotalRegistros { get; internal set; }
        public int Pagina { get; internal set; }
        public int RegistrosPorPagina { get; internal set; }
    }
}
