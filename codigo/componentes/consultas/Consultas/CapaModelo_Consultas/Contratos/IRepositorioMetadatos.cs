using System.Collections.Generic;
using CapaModelo_Consultas.Entidades;

namespace CapaModelo_Consultas.Contratos
{
    public interface IRepositorioMetadatos
    {
        IList<string> ConsultasFuncObtenerTablas();
        IList<ClsCampoConsulta> ConsultasFuncObtenerCampos(string Tabla);
    }
}
