using System;

namespace CapaVista_Consultas
{
    public sealed class ClsSeleccionConsulta : EventArgs
    {
        public object Valor { get; }
        public string Pk { get; }

        public ClsSeleccionConsulta(object Valor) : this(Valor, null)
        {
        }

        public ClsSeleccionConsulta(object Valor, string Pk)
        {
            this.Valor = Valor;
            this.Pk = Pk;
        }
    }
}
