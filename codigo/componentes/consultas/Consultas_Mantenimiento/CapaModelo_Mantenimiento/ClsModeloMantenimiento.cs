using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;

namespace CapaModelo_Consultas
{
    public class ClsModeloMantenimiento
    {
        private static OdbcConnection ConsultasFuncAbrir()
        {
            OdbcConnection con = new ClsConexion().ConsultasFuncConexion();
            if (con.State != ConnectionState.Open)
            {
                throw new InvalidOperationException(
                    "No se pudo conectar a la base de datos. Revisa que el DSN \"EmbutidosS.A\" exista y apunte a dbConsulta.");
            }
            return con;
        }
        
        public List<string> ConsultasFuncObtenerTablas()
        {
            List<string> lista = new List<string>();
            const string sql =
                "SELECT TABLE_NAME FROM information_schema.TABLES " +
                "WHERE TABLE_SCHEMA = DATABASE() ORDER BY TABLE_NAME";

            using (OdbcConnection con = ConsultasFuncAbrir())
            using (OdbcCommand cmd = new OdbcCommand(sql, con))
            {
                using (OdbcDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        lista.Add(Convert.ToString(rd[0]));
                    }
                }
            }
            return lista;
        }

        
        public List<KeyValuePair<string, string>> ConsultasFuncObtenerColumnas(string tabla)
        {
            List<KeyValuePair<string, string>> lista = new List<KeyValuePair<string, string>>();
            const string sql =
                "SELECT COLUMN_NAME, DATA_TYPE FROM information_schema.COLUMNS " +
                "WHERE TABLE_SCHEMA = DATABASE() AND TABLE_NAME = ? ORDER BY ORDINAL_POSITION";

            using (OdbcConnection con = ConsultasFuncAbrir())
            using (OdbcCommand cmd = new OdbcCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@tabla", tabla);
                using (OdbcDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        lista.Add(new KeyValuePair<string, string>(
                            Convert.ToString(rd[0]), Convert.ToString(rd[1])));
                    }
                }
            }
            return lista;
        }

        public bool ConsultasFuncExisteNombre(string nombre)
        {
            const string sql = "SELECT COUNT(*) FROM tblConsulta WHERE nombreConsulta = ?";

            using (OdbcConnection con = ConsultasFuncAbrir())
            using (OdbcCommand cmd = new OdbcCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@nombre", nombre);
                return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
            }
        }

        public void ConsultasProcInsertar(string nombre, string tabla, string query)
        {
            const string sql =
                "INSERT INTO tblConsulta (nombreConsulta, tablaConsulta, queryConsulta) VALUES (?, ?, ?)";

            using (OdbcConnection con = ConsultasFuncAbrir())
            using (OdbcCommand cmd = new OdbcCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@tabla", tabla);
                cmd.Parameters.AddWithValue("@query", query);
                cmd.ExecuteNonQuery();
            }
        }

      
        public DataTable ConsultasFuncEjecutar(string query, int maxFilas)
        {
            using (OdbcConnection con = ConsultasFuncAbrir())
            using (OdbcDataAdapter da = new OdbcDataAdapter(query, con))
            {
                DataSet ds = new DataSet();
                da.Fill(ds, 0, maxFilas, "resultado");
                return ds.Tables["resultado"];
            }
        }
    }
}