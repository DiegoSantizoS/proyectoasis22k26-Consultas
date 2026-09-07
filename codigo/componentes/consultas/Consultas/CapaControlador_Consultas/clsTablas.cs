using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaModelo_Consultas;

namespace CapaControlador_Consultas
{
    public class clsTablas
    {
        clsSentenciasTablas sentencias = new clsSentenciasTablas();

        public DataTable LlenarTabla (string NombreTabla)
        {
            OdbcDataAdapter daLlenarTablas = sentencias.OBtenerTabla(NombreTabla);
            DataTable dtLlenarTablas = new DataTable();
            try { daLlenarTablas.Fill(dtLlenarTablas); 
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al llenar la tabla: " + ex.Message);
            }

            return dtLlenarTablas;
        }
        public DataTable ObtenerTablas()
        {
            OdbcDataAdapter daObtenerTablas = sentencias.GetTables();
            DataTable dtObtenerTablas = new DataTable();
            daObtenerTablas.Fill(dtObtenerTablas);
            return dtObtenerTablas;
        }
    }
}
