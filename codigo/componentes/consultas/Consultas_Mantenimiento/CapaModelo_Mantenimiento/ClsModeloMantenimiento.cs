using CapaControlador_Consultas;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Globalization;
using System.Text;

namespace CapaModelo_Consultas
{
    //Inicio del código realizado por Diana Mishel Loeiza Ramírez 9959-23-3457 20/09/2026
    public class ClsModeloMantenimiento
    {
        // Estas listas son conocimiento de SQL puro (operadores válidos, tipos numéricos),
        // por lo que pertenecen al Modelo y no al Controlador.
        private static readonly string[] _OperadoresValidos =
            { "=", "<>", ">", "<", ">=", "<=", "LIKE", "NOT LIKE", "IS NULL", "IS NOT NULL" };

        private static readonly HashSet<string> _TiposNumericos = new HashSet<string>(
            new string[] { "int", "integer", "bigint", "smallint", "mediumint", "tinyint",
                           "decimal", "numeric", "float", "double" });

        private static OdbcConnection ConsultasFuncAbrirConexion()
        {
            OdbcConnection Conexion = new ClsConexion().ConsultasFuncConexion();
            if (Conexion.State != ConnectionState.Open)
            {
                throw new InvalidOperationException(
                    "No se pudo conectar a la base de datos. Revisa que el DSN \"EmbutidosS.A\" exista y apunte a dbConsulta.");
            }
            return Conexion;
        }

        public List<string> ConsultasFuncObtenerTablas()
        {
            List<string> Lista = new List<string>();
            const string Sql =
                "SELECT TABLE_NAME FROM information_schema.TABLES " +
                "WHERE TABLE_SCHEMA = DATABASE() ORDER BY TABLE_NAME";

            using (OdbcConnection Conexion = ConsultasFuncAbrirConexion())
            using (OdbcCommand Comando = new OdbcCommand(Sql, Conexion))
            {
                using (OdbcDataReader DataReader = Comando.ExecuteReader())
                {
                    while (DataReader.Read())
                    {
                        Lista.Add(Convert.ToString(DataReader[0]));
                    }
                }
            }
            return Lista;
        }

        public List<KeyValuePair<string, string>> ConsultasFuncObtenerColumnas(string Tabla)
        {
            List<KeyValuePair<string, string>> Lista = new List<KeyValuePair<string, string>>();
            const string Sql =
                "SELECT COLUMN_NAME, DATA_TYPE FROM information_schema.COLUMNS " +
                "WHERE TABLE_SCHEMA = DATABASE() AND TABLE_NAME = ? ORDER BY ORDINAL_POSITION";

            using (OdbcConnection Conexion = ConsultasFuncAbrirConexion())
            using (OdbcCommand Comando = new OdbcCommand(Sql, Conexion))
            {
                Comando.Parameters.AddWithValue("@tabla", Tabla);
                using (OdbcDataReader DataReader = Comando.ExecuteReader())
                {
                    while (DataReader.Read())
                    {
                        Lista.Add(new KeyValuePair<string, string>(
                            Convert.ToString(DataReader[0]), Convert.ToString(DataReader[1])));
                    }
                }
            }
            return Lista;
        }

        public bool ConsultasFuncExisteNombre(string Nombre)
        {
            const string Sql = "SELECT COUNT(*) FROM tblConsulta WHERE nombreConsulta = ?";

            using (OdbcConnection Conexion = ConsultasFuncAbrirConexion())
            using (OdbcCommand Comando = new OdbcCommand(Sql, Conexion))
            {
                Comando.Parameters.AddWithValue("@nombre", Nombre);
                return Convert.ToInt32(Comando.ExecuteScalar()) > 0;
            }
        }

        public void ConsultasProcInsertarConsulta(string Nombre, string Tabla, string Query)
        {
            const string Sql =
                "INSERT INTO tblConsulta (nombreConsulta, tablaConsulta, queryConsulta) VALUES (?, ?, ?)";

            using (OdbcConnection Conexion = ConsultasFuncAbrirConexion())
            using (OdbcCommand Comando = new OdbcCommand(Sql, Conexion))
            {
                Comando.Parameters.AddWithValue("@nombre", Nombre);
                Comando.Parameters.AddWithValue("@tabla", Tabla);
                Comando.Parameters.AddWithValue("@query", Query);
                Comando.ExecuteNonQuery();
            }
        }

        public DataTable ConsultasFuncEjecutarConsulta(string Query, int FilasMaximas)
        {
            using (OdbcConnection Conexion = ConsultasFuncAbrirConexion())
            using (OdbcDataAdapter DataAdapter = new OdbcDataAdapter(Query, Conexion))
            {
                DataSet Datos = new DataSet();
                DataAdapter.Fill(Datos, 0, FilasMaximas, "resultado");
                return Datos.Tables["resultado"];
            }
        }

        // ===== Construcción de SQL (antes vivía en el Controlador; se movió aquí porque
        // implica conocimiento del dialecto SQL, que es responsabilidad del Modelo) =====

        public string ConsultasFuncConstruirQuery(string Tabla, List<ClsCondicion> Filas, Dictionary<string, string> Tipos)
        {
            StringBuilder Where = new StringBuilder();
            List<string> Orden = new List<string>();

            foreach (ClsCondicion Condicion in Filas)
            {
                if (Tipos != null && Tipos.Count > 0 && !Tipos.ContainsKey(Condicion.Campo))
                {
                    throw new ArgumentException("El campo " + Condicion.Campo + " no existe en " + Tabla + ".");
                }

                if (!string.IsNullOrEmpty(Condicion.Operador))
                {
                    if (Where.Length > 0)
                    {
                        Where.Append(Condicion.Conector == "OR" ? " OR " : " AND ");
                    }
                    Where.Append(ConsultasFuncFormatearCondicion(Condicion, Tipos));
                }

                if (Condicion.Orden == "ASC" || Condicion.Orden == "DESC")
                {
                    Orden.Add(Condicion.Campo + " " + Condicion.Orden);
                }
            }

            StringBuilder Sql = new StringBuilder("SELECT * FROM " + Tabla);
            if (Where.Length > 0)
            {
                Sql.Append(" WHERE ").Append(Where.ToString());
            }
            if (Orden.Count > 0)
            {
                Sql.Append(" ORDER BY ").Append(string.Join(", ", Orden));
            }
            Sql.Append(";");
            return Sql.ToString();
        }

        public string ConsultasFuncFormatearCondicion(ClsCondicion Condicion, Dictionary<string, string> Tipos)
        {
            if (Array.IndexOf(_OperadoresValidos, Condicion.Operador) < 0)
            {
                throw new ArgumentException("Operador no valido: " + Condicion.Operador);
            }

            if (Condicion.Operador == "IS NULL" || Condicion.Operador == "IS NOT NULL")
            {
                return Condicion.Campo + " " + Condicion.Operador;
            }

            string Valor = (Condicion.Valor ?? "").Trim();
            if (Valor.Length == 0)
            {
                throw new ArgumentException("Escribe un valor para el campo " + Condicion.Campo + ".");
            }

            bool ConfirmarLike = Condicion.Operador.EndsWith("LIKE");
            string Tipo = null;
            if (Tipos != null)
            {
                Tipos.TryGetValue(Condicion.Campo, out Tipo);
            }

            string literal;
            if (!ConfirmarLike && Tipo != null && _TiposNumericos.Contains(Tipo.ToLowerInvariant()))
            {
                decimal numero;
                if (!decimal.TryParse(Valor,
                        NumberStyles.AllowLeadingSign | NumberStyles.AllowDecimalPoint,
                        CultureInfo.InvariantCulture, out numero))
                {
                    throw new ArgumentException("El campo " + Condicion.Campo + " es numerico. Escribe un numero, por ejemplo 5000 o 12.50.");
                }
                literal = numero.ToString(CultureInfo.InvariantCulture);
            }
            else
            {
                literal = "'" + Valor.Replace("\\", "\\\\").Replace("'", "''") + "'";
            }

            return Condicion.Campo + " " + Condicion.Operador + " " + literal;
        }

        public bool ConsultasFuncEsInstruccionSelect(string Query)
        {
            return !string.IsNullOrWhiteSpace(Query) &&
                   Query.TrimStart().StartsWith("SELECT ", StringComparison.OrdinalIgnoreCase);
        }
    }
    //Fin del código realizado por Diana Mishel Loeiza Ramírez 9959-23-3457
}