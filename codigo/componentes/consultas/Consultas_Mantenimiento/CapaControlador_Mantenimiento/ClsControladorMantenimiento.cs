using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;
using CapaModelo_Consultas;

namespace CapaControlador_Consultas
{
   
    public class ClsControladorMantenimiento
    {
        private readonly ClsModeloMantenimiento _modelo = new ClsModeloMantenimiento();

        private static readonly string[] _OperadoresValidos =
            { "=", "<>", ">", "<", ">=", "<=", "LIKE", "NOT LIKE", "IS NULL", "IS NOT NULL" };

        private static readonly HashSet<string> _TiposNumericos = new HashSet<string>(
            new string[] { "int", "integer", "bigint", "smallint", "mediumint", "tinyint",
                           "decimal", "numeric", "float", "double" });


        //Comentado por temas de debug, ya que no se esta usando en el proyecto
        /* public List<string> ObtenerTablas()
         {
             return _modelo.ObtenerTablas();
         }*/

        public List<KeyValuePair<string, string>> ConsultasMetObtenerColumnas(string tabla)
        {
            ConsultasProcValidarIdentificador(tabla, "tabla");
            return _modelo.ConsultasFuncObtenerColumnas(tabla);
        }


        public void ConsultasProcValidarCondicion(ClsCondicion c, Dictionary<string, string> tipos)
        {
            ConsultasProcValidarIdentificador(c.Campo, "campo");
            if (!string.IsNullOrEmpty(c.Operador))
            {
                ConsultasFuncFormatearCondicion(c, tipos);
            }
        }

        public string ConsultasFuncConstruirQuery(string tabla, List<ClsCondicion> filas, Dictionary<string, string> tipos)
        {
            ConsultasProcValidarIdentificador(tabla, "tabla");

            StringBuilder where = new StringBuilder();
            List<string> orden = new List<string>();

            foreach (ClsCondicion f in filas)
            {
                ConsultasProcValidarIdentificador(f.Campo, "campo");
                if (tipos != null && tipos.Count > 0 && !tipos.ContainsKey(f.Campo))
                {
                    throw new ArgumentException("El campo " + f.Campo + " no existe en " + tabla + ".");
                }

                if (!string.IsNullOrEmpty(f.Operador))
                {
                    if (where.Length > 0)
                    {
                        where.Append(f.Conector == "OR" ? " OR " : " AND ");
                    }
                    where.Append(ConsultasFuncFormatearCondicion(f, tipos));
                }

                if (f.Orden == "ASC" || f.Orden == "DESC")
                {
                    orden.Add(f.Campo + " " + f.Orden);
                }
            }

            StringBuilder sql = new StringBuilder("SELECT * FROM " + tabla);
            if (where.Length > 0)
            {
                sql.Append(" WHERE ").Append(where.ToString());
            }
            if (orden.Count > 0)
            {
                sql.Append(" ORDER BY ").Append(string.Join(", ", orden));
            }
            sql.Append(";");
            return sql.ToString();
        }

        private static string ConsultasFuncFormatearCondicion(ClsCondicion c, Dictionary<string, string> tipos)
        {
            if (Array.IndexOf(_OperadoresValidos, c.Operador) < 0)
            {
                throw new ArgumentException("Operador no valido: " + c.Operador);
            }

            if (c.Operador == "IS NULL" || c.Operador == "IS NOT NULL")
            {
                return c.Campo + " " + c.Operador;
            }

            string valor = (c.Valor ?? "").Trim();
            if (valor.Length == 0)
            {
                throw new ArgumentException("Escribe un valor para el campo " + c.Campo + ".");
            }

            bool esLike = c.Operador.EndsWith("LIKE");
            string tipo = null;
            if (tipos != null)
            {
                tipos.TryGetValue(c.Campo, out tipo);
            }

            string literal;
            if (!esLike && tipo != null && _TiposNumericos.Contains(tipo.ToLowerInvariant()))
            {
                decimal numero;
                if (!decimal.TryParse(valor,
                        NumberStyles.AllowLeadingSign | NumberStyles.AllowDecimalPoint,
                        CultureInfo.InvariantCulture, out numero))
                {
                    throw new ArgumentException("El campo " + c.Campo + " es numerico. Escribe un numero, por ejemplo 5000 o 12.50.");
                }
                literal = numero.ToString(CultureInfo.InvariantCulture);
            }
            else
            {
                literal = "'" + valor.Replace("\\", "\\\\").Replace("'", "''") + "'";
            }

            return c.Campo + " " + c.Operador + " " + literal;
        }

        private static void ConsultasProcValidarIdentificador(string nombre, string que)
        {
            if (string.IsNullOrWhiteSpace(nombre))
            {
                throw new ArgumentException("Selecciona " + (que == "tabla" ? "una tabla o vista." : "un campo."));
            }
            if (!Regex.IsMatch(nombre, "^[A-Za-z0-9_]+$"))
            {
                throw new ArgumentException("El nombre de " + que + " no es valido: " + nombre);
            }
        }

    

        public void ConsultasProcGuardar(string nombre, string tabla, string query)
        {
            nombre = (nombre ?? "").Trim();

            if (nombre.Length == 0)
            {
                throw new ArgumentException("Escribe un nombre para la consulta.");
            }
            if (nombre.Length > 100)
            {
                throw new ArgumentException("El nombre no puede pasar de 100 caracteres.");
            }
            if (string.IsNullOrWhiteSpace(tabla))
            {
                throw new ArgumentException("Selecciona una tabla o vista.");
            }
            ConsultasProcValidarEsSelect(query);

            if (_modelo.ConsultasFuncExisteNombre(nombre))
            {
                throw new ArgumentException("Ya existe una consulta con ese nombre. Usa otro.");
            }

            _modelo.ConsultasProcInsertar(nombre, tabla, query);
        }

        public DataTable ConsultasFuncProbar(string query)
        {
            ConsultasProcValidarEsSelect(query);
            return _modelo.ConsultasFuncEjecutar(query, 500);
        }

        private static void ConsultasProcValidarEsSelect(string query)
        {
            if (string.IsNullOrWhiteSpace(query) ||
                !query.TrimStart().StartsWith("SELECT ", StringComparison.OrdinalIgnoreCase))
            {
                throw new ArgumentException("Primero arma la consulta: elige una tabla o vista.");
            }
        }
    }
}