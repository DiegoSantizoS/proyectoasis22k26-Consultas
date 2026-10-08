using System;

namespace CapaVista_Consultas
{
    public sealed class ClsSeleccionConsulta : EventArgs
    {
        /*Inicio de código de Carlos Andres Arriaza Lara 0901-23-13862 el 5/10/2026*/
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
        /*Fin del código de Carlos Andres Arriaza Lara 0901-23-13862 el 5/10/2026*/
    }
}
