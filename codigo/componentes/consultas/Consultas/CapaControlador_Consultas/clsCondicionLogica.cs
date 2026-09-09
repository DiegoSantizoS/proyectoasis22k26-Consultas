using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaControlador_Consultas
{
    public class clsCondicionLogica
    {

        public string Campo { get; set; }
        public string Valor { get; set; }
        public string OperadorLogico { get; set; }

        public clsCondicionLogica(
            string campo,
            string valor,
            string operadorLogico)
        {
            Campo = campo;
            Valor = valor;
            OperadorLogico = operadorLogico;
        }

        public string GenerarCondicion()
        {
            return $"{Campo} = '{Valor}'";
        }

        public string GenerarOperadorLogico()
        {
            return OperadorLogico;
        }
    }
    
}
