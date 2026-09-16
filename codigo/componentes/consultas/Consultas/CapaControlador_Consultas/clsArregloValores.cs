using CapaModelo_Consultas;
using CapaModelo_Consultas.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaControlador_Consultas
{
    public class clsArregloValores
    {

        private ClsCondicionComparacion _Condiciones = new ClsCondicionComparacion();

     
            public void ConsultasMetAgregarCondicion(
               string Campo,
              string Operador,
               string Valor)
        {
            _Condiciones.ConsultasMetAgregarCondicion(
                Campo,
                Operador,
                Valor
            );
        }

        public List<string[]> ConsultasMetObtenerCondiciones() 
        {
            List<string[]> ListaSalida = new List<string[]>();
            foreach (ClsCondicionComparacion Condicion in _Condiciones.ConsultasMetObtenerCondiciones())
            { ListaSalida.Add(new string[] {
                Condicion.Campo, Condicion.OperadorComparacion, Condicion.Valor }); 
            } return ListaSalida;
        }
    }





}


