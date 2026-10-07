using System.Collections.Generic;
using CapaModelo_Consultas.Entidades;

namespace CapaModelo_Consultas.Contratos
{
    public interface IRepositorioConsultasGuardadas
    {
        IList<ClsConsultaGuardada> ConsultasFuncListar(string Tabla);
        ClsConsultaGuardada ConsultasFuncObtener(int Id, string Tabla);
        bool ConsultasFuncExisteNombre(string Nombre, int IdExcluir = 0);
        void ConsultasProcGuardar(ClsConsultaGuardada Consulta);
        void ConsultasProcActualizar(ClsConsultaGuardada Consulta);
        void ConsultasProcEliminar(int Id, string Tabla);
    }
}
