namespace CapaControlador_Consultas
{
    public class ClsCondicionLogica
    {

        public string Campo { get; set; }
        public string Valor { get; set; }
        public string OperadorLogico { get; set; }

        public ClsCondicionLogica(
            string campo,
            string valor,
            string operadorLogico)
        {
            Campo = campo;
            Valor = valor;
            OperadorLogico = operadorLogico;
        }

        public string ConsultasMetGenerarCondicion()
        {
            return $"{Campo} = '{Valor}'";
        }

        public string ConsultasMetGenerarOperadorLogico()
        {
            return OperadorLogico;
        }
    }
    
}
