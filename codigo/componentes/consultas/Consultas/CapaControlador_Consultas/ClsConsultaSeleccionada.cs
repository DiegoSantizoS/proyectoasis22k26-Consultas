using CapaModelo_Consultas;
using System;
using System.Data;

namespace CapaControlador_Consultas
{
    public class ClsConsultaSeleccionada
    {
        //Inicio del código de Carlos Andres Arriaza Lara 0901-23-13862 el 16/09/2026

        private readonly ClsSentenciasTablas _SentenciasTablas =
            new ClsSentenciasTablas();

        public DataTable ConsultasFuncCargarConsultas()
        {
            string NombreTabla =
                ClsTablaSeleccionada
                    .ConsultasFuncObtenerTabla();

            if (string.IsNullOrWhiteSpace(NombreTabla))
            {
                throw new InvalidOperationException(
                    "No se ha seleccionado una tabla.");
            }

            return _SentenciasTablas
                .ConsultasFuncObtenerConsultas(
                    NombreTabla);
        }

        public DataTable ConsultasFuncCargarConsulta(
            string Consulta,
            int Pagina,
            int RegistrosPorPagina)
        {
            return _SentenciasTablas
                .ConsultasFuncCargarConsulta(
                    Consulta,
                    Pagina,
                    RegistrosPorPagina);
        }

        public int ConsultasFuncContarResultadosQuery(
            string Consulta)
        {
            return _SentenciasTablas
                .ConsultasFuncContarResultadosQuery(
                    Consulta);
        }

        //Fin del código de Carlos Andres Arriaza Lara 0901-23-13862 el 16/09/2026
    }
}