// pedro inicio
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;

namespace CapaModelo_Consultas.Repositorios
{
    public class ClsTablasRelacionadas
    {
        // conexion
        ClsConexion _Conexion = new ClsConexion();

        public List<string> ConsultasFuncObtenerTablasRelacionadas(string TablaBase)
        {
            List<string> ListaTablas = new List<string>();

            // primera opcion tabla principal
            ListaTablas.Add(TablaBase);

            // consultar el INFORMATION_SCHEMA
            string QueryConsulta = @"
                SELECT TABLE_NAME 
                FROM INFORMATION_SCHEMA.KEY_COLUMN_USAGE 
                WHERE REFERENCED_TABLE_NAME = ? 
                  AND TABLE_SCHEMA = DATABASE();";

            try
            {
                using (OdbcConnection ConexionOdbc = _Conexion.ConsultasFuncConexion())
                {
                    using (OdbcCommand ComandoObtenerTablas = new OdbcCommand(QueryConsulta, ConexionOdbc))
                    {
                        // no inyección sql
                        ComandoObtenerTablas.Parameters.AddWithValue("?", TablaBase);

                        using (OdbcDataReader LectorTablas = ComandoObtenerTablas.ExecuteReader())
                        {
                            while (LectorTablas.Read())
                            {
                                // recodar nombre de tabla relacionada
                                string TablaRelacionada = LectorTablas["TABLE_NAME"].ToString();
                                ListaTablas.Add(TablaRelacionada);
                            }
                        }
                    }
                }
            }
            catch (OdbcException ExcepcionOdbc)
            {
                Console.WriteLine("Error ODBC: " + ExcepcionOdbc.Message);
            }
            catch (Exception ExcepcionGeneral)
            {
                Console.WriteLine("Error General: " + ExcepcionGeneral.Message);
            }

            return ListaTablas;
        }
    }
}
//fin