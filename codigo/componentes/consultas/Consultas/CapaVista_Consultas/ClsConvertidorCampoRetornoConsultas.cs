using System.ComponentModel;

namespace CapaVista_Consultas
{
    public sealed class ClsConvertidorCampoRetornoConsultas : ClsConvertidorTablaConsultas
    {
        public override StandardValuesCollection GetStandardValues(ITypeDescriptorContext Contexto)
        {
            Consultas Boton = Contexto?.Instance as Consultas;
            return new StandardValuesCollection(Metadatos.ConsultasFuncObtenerCampos(Boton?.Tabla));
        }
    }
}
