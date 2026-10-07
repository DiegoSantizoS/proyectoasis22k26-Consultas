using System;

namespace CapaVista_Consultas
{
    public sealed class ClsSeleccionConsulta : EventArgs
    {
        public object Valor { get; }

        public ClsSeleccionConsulta(object Valor)
        {
            this.Valor = Valor;
        }
    }
}
