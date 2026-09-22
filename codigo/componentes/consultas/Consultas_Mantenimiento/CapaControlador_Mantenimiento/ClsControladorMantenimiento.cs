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

        private static readonly string[] OperadoresValidos =
            { "=", "<>", ">", "<", ">=", "<=", "LIKE", "NOT LIKE", "IS NULL", "IS NOT NULL" };

        private static readonly HashSet<string> TiposNumericos = new HashSet<string>(
            new string[] { "int", "integer", "bigint", "smallint", "mediumint", "tinyint",
                           "decimal", "numeric", "float", "double" });

        

        public List<string> ObtenerTablas()
        {
            return _modelo.ObtenerTablas();
        }

        public List<KeyValuePair<string, string>> ObtenerColumnas(string tabla)
        {
            ValidarIdentificador(tabla, "tabla");
            return _modelo.ObtenerColumnas(tabla);
        }


        public void ValidarCondicion(ClsCondicion c, Dictionary<string, string> tipos)
        {
            ValidarIdentificador(c.Campo, "campo");
            if (!string.IsNullOrEmpty(c.Operador))
            {
                FormatearCondicion(c, tipos);
            }
        }

        public string ConstruirQuery(string tabla, List<ClsCondicion> filas, Dictionary<string, string> tipos)
        {
            ValidarIdentificador(tabla, "tabla");

            StringBuilder where = new StringBuilder();
            List<string> orden = new List<string>();

            foreach (ClsCondicion f in filas)
            {
                ValidarIdentificador(f.Campo, "campo");
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
                    where.Append(FormatearCondicion(f, tipos));
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

        private static string FormatearCondicion(ClsCondicion c, Dictionary<string, string> tipos)
        {
            if (Array.IndexOf(OperadoresValidos, c.Operador) < 0)
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
            if (!esLike && tipo != null && TiposNumericos.Contains(tipo.ToLowerInvariant()))
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

        private static void ValidarIdentificador(string nombre, string que)
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

    

        public void Guardar(string nombre, string tabla, string query)
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
            ValidarEsSelect(query);

            if (_modelo.ExisteNombre(nombre))
            {
                throw new ArgumentException("Ya existe una consulta con ese nombre. Usa otro.");
            }

            _modelo.Insertar(nombre, tabla, query);
        }

        public DataTable Probar(string query)
        {
            ValidarEsSelect(query);
            return _modelo.Ejecutar(query, 500);
        }

        private static void ValidarEsSelect(string query)
        {
            if (string.IsNullOrWhiteSpace(query) ||
                !query.TrimStart().StartsWith("SELECT ", StringComparison.OrdinalIgnoreCase))
            {
                throw new ArgumentException("Primero arma la consulta: elige una tabla o vista.");
            }
        }
    }
}