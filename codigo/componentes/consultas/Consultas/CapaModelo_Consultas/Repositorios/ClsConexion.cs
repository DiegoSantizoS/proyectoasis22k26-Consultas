using System;
using System.Data.Odbc;

namespace CapaModelo_Consultas
{
    // Inicio de código de "Diego Fernando Santizo Samayoa" - carné: "0901-22-15950" - Fecha: "20/09/26"
    internal class ClsConexion
    {
        public OdbcConnection ConsultasFuncConexion()
        {
            OdbcConnection Conexion = new OdbcConnection("Dsn=EmbutidosS.A");
            try
            {
                Conexion.Open();
            }
            catch (OdbcException Exception)
            {
                Console.WriteLine("Conexion fallida. Error: " + Exception.Message);
            }
            return Conexion;
        }

        public void ConsultasProcDesconexion(OdbcConnection Conexion)
        {
            try
            {
                Conexion.Close();
            }
            catch (OdbcException Exception)
            {
                Console.WriteLine("Error al cerrar la conexión. Error: " + Exception.Message);
            }
        }
    }
    // Fin de código de "Diego Fernando Santizo Samayoa" - carné: "0901-22-15950" - Fecha: "20/09/26"
}
