using CapaModelo_CbCampos;
using CapaModelo_CbCampos.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaControlador_CbCampos
{
   public class ClsObtenerDatos
    {
        ClsComboCampos _Filtros = new ClsComboCampos();


        public void ConsultasMetPoblarComboCampos(string tabla, ComboBox cboDestino)
        {
            _Filtros.Tabla = tabla;
            _Filtros.ConsultasMetPopularComboBox(cboDestino);
        }

        
    }
}
