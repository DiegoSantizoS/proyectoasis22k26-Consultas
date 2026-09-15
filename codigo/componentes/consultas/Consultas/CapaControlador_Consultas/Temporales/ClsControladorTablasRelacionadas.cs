// pedro inicio
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaModelo_Consultas.Repositorios;

namespace CapaControlador_Consultas.Temporales
{
    public class ClsControladorTablasRelacionadas
    {
        ClsTablasRelacionadas _ModeloTablas = new ClsTablasRelacionadas();

        public List<string> ConsultasFuncObtenerTablasRelacionadas(string TablaBase)
        {
            // validar
            if (string.IsNullOrEmpty(TablaBase))
            {
                return new List<string>();
            }
            // vista
            List<string> ListaResultado = _ModeloTablas.ConsultasFuncObtenerTablasRelacionadas(TablaBase);

            return ListaResultado;
        }
    }
}
//fin