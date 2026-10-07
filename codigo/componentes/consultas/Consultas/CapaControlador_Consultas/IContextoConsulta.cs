using System.Data;

namespace CapaControlador_Consultas
{
    public interface IContextoConsulta
    {
        string Tabla { get; }
        string CampoRetorno { get; }
        string[] ConsultasFuncObtenerCampos();
        string[] ConsultasFuncObtenerOperadores(string Nombre);
        void ConsultasProcLimpiarFiltro();
        ClsPaginaConsulta ConsultasFuncEjecutar(int Pagina, int RegistrosPorPagina, string CampoOrden, bool Descendente);
        object ConsultasFuncSeleccionar(DataRow Registro);
        string ConsultasFuncMensajeSinResultados(string NombreCampo);
    }
}
