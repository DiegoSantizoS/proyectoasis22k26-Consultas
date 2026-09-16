using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaControlador_Consultas
{
    public class ClsCondicionComparacion
    {
        public string Campo { get; set; }
        public string OperadorComparacion { get; set; }
        public string Valor { get; set; }

        private List<ClsCondicionComparacion> ListaCondiciones =
       new List<ClsCondicionComparacion>();



        public ClsCondicionComparacion()
        {


        }

      
            public void ConsultasMetAgregarCondicion(
              string campo,
               string operadorComparacion,
              string valor)
        {
            ClsCondicionComparacion Condicion =
                new ClsCondicionComparacion();

            Condicion.Campo = campo;
            Condicion.OperadorComparacion = operadorComparacion;
            Condicion.Valor = valor;

             ListaCondiciones.Add(Condicion);
        }



        
        public List<ClsCondicionComparacion>
            ConsultasMetObtenerCondiciones()
        {
            return ListaCondiciones;
        }
    }
}
