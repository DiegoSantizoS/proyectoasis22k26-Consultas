using System;

namespace CapaControlador_Consultas
{
    public sealed class ClsErrorValidacion : ArgumentException
    {
        public string Campo { get; }

        public ClsErrorValidacion(string Campo, string Mensaje) : base(Mensaje)
        {
            this.Campo = Campo;
        }
    }
}
