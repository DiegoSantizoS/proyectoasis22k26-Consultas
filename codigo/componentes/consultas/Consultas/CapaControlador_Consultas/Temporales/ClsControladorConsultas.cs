using CapaModelo_Consultas;
using CapaModelo_Consultas.Repositorios;
using System.Data;
using System.Windows.Forms;

namespace CapaControlador_Consultas
{
  
    public class ClsControladorConsultas
    {
        private ClsObtenciónCampos _Filtros = new ClsObtenciónCampos();
        

        public void ConsultasMetPoblarComboCampos(string tabla, ComboBox cboDestino)
        {
            _Filtros.Tabla = tabla;
            _Filtros.ConsultasMetPopularComboBox(cboDestino);
        }
       
    }
}