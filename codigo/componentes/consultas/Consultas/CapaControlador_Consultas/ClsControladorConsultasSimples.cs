using CapaModelo_Consultas.Entidades;

namespace CapaControlador_Consultas
{
    public sealed class ClsControladorConsultasSimples
    {
        private readonly ClsServicioConsultasCompartidas _Compartidas;
        public IContextoConsulta Contexto => _Compartidas;

        internal ClsControladorConsultasSimples(ClsServicioConsultasCompartidas Compartidas)
        {
            _Compartidas = Compartidas;
        }

        public void ConsultasProcFiltrar(string Campo, string Operador, string Valor)
        {
            ClsDefinicionConsulta Definicion = new ClsDefinicionConsulta { Tabla = _Compartidas.Tabla };
            Definicion.Condiciones.Add(_Compartidas.Validador.ConsultasFuncValidarCondicion(Campo, Operador, Valor, "", "", false));
            _Compartidas.Definicion = Definicion;
        }
    }
}
