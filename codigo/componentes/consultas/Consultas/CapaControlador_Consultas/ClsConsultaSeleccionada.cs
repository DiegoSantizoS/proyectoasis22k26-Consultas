using System;
using System.Data;
using CapaModelo_Consultas;

namespace CapaControlador_Consultas
{
    public class ClsConsultaSeleccionada
    {
        //Inicio del código de Carlos Andres Arriaza Lara 0901-23-13862 el 16/09/2026
        private readonly ClsSentenciasTablas _Sentencias = new ClsSentenciasTablas();

        public DataTable ConsultasFuncCargarConsultas()
        {
            return _Sentencias.ConsltasFuncObtenerConsultas();
        }
        public DataTable ConsultasFuncCargarConsulta(string Consulta, int Pagina, int RegistrosPorPagina)
        {
            return _Sentencias.ConsultasFuncCargarConsulta(Consulta, Pagina, RegistrosPorPagina);
        }
        public int ConsultasFuncContarResultadosQuery(string Consulta)
        {
            return _Sentencias.ConsultasFuncContarResultadosQuery(Consulta);
        }
        //Fin del código de Carlos Andres Arriaza Lara 0901-23-13862 el 16/09/2026
    }
        
}
