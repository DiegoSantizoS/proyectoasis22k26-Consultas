using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaModelo_Consultas { 
    public class ClsSentenciasTablas { 
        ClsConexion _Conexion = new ClsConexion();
        public OdbcDataAdapter ConsultasFuncObtenerTabla(string Tabla, int pagina, int registrosPorPagina)
        {
            try
            {
                int Inicio = (pagina - 1) * registrosPorPagina;

                string Consulta =
                    "SELECT * FROM " + Tabla +
                    " LIMIT ? OFFSET ?;";

                OdbcCommand Cmd = new OdbcCommand(Consulta, _Conexion.ConsultasFuncConexion());

                Cmd.Parameters.AddWithValue("?", registrosPorPagina);
                Cmd.Parameters.AddWithValue("?", Inicio);

                OdbcDataAdapter DaTabla = new OdbcDataAdapter(Cmd);

                return DaTabla;
            }
            catch (Exception Ex)
            {
                Console.WriteLine("Error al cargar la tabla: " + Ex.Message);
                Environment.Exit(0);
                return null;
            }
        }

        public OdbcDataAdapter ConsultasFuncObtenerTablas() {
            try
            {
                string Consulta = "SHOW TABLES;"; 
            OdbcDataAdapter DaTablas = new OdbcDataAdapter(Consulta, _Conexion.ConsultasFuncConexion()); 
            return DaTablas;
            }
            catch (Exception Ex)
            {
                MessageBox.Show(
               "No se pudieron obtener las tablas.\n\n" +
               Ex.Message,
               "Error",
               MessageBoxButtons.OK,
               MessageBoxIcon.Error
           );
                Environment.Exit(0);


                return null;
            }

        }
        public int ConsultasFuncContarRegistros(string NombreTabla)
        {
            try
            {
                string Consulta =
                "SELECT COUNT(*) FROM " + NombreTabla;

            OdbcCommand Cmd = new OdbcCommand(
                Consulta,
                _Conexion.ConsultasFuncConexion()
            );

            return Convert.ToInt32(Cmd.ExecuteScalar());
            }
            catch (OdbcException)
            {
                MessageBox.Show(
                    "La tabla '" + NombreTabla + "' no existe o no se puede consultar.",
                    "Tabla no encontrada",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                Environment.Exit(0);

                return 0;
            }


        }
    } 
}