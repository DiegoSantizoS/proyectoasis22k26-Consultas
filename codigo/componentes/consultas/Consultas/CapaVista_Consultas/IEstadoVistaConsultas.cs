using CapaControlador_Consultas;

namespace CapaVista_Consultas
{
    internal interface IEstadoVistaConsultas
    {
        void ConsultasProcMostrarError(ClsErrorValidacion Error);
        void ConsultasProcActualizarEstado();
    }
}
