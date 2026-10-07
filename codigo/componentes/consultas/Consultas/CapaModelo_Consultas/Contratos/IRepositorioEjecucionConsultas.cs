using CapaModelo_Consultas.Entidades;

namespace CapaModelo_Consultas.Contratos
{
    public interface IRepositorioEjecucionConsultas
    {
        ClsResultadoPaginado ConsultasFuncEjecutar(ClsDefinicionConsulta Definicion, int Pagina, int RegistrosPorPagina, string CampoOrden, bool Descendente);
    }
}
