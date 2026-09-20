using CapaModelo_CbCampos;
using CapaModelo_CbCampos.Repositorio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaControlador_CbCampos
{
   public class ClsObtenerDatos
    {
        
        private ClsComboCampos _Filtros = new ClsComboCampos();

        
        public DataTable enviarDatos(string _tabla)
        {
            var dtTabla = _Filtros.ObtenerCampos(_tabla);

           return dtTabla;
        }

        public string ObtenerCampoSeleccionado(string campo)
        {
            return campo;
        }


    }




    }

