using System;
using System.Data;
using System.Data.Odbc;
using System.Text.RegularExpressions;

namespace CapaModelo_Consultas
{
    public class ClsSentenciasTablas
    {
        private readonly ClsConexion _Conexion = new ClsConexion();

        public DataTable ConsultasFuncObtenerTabla(
            string NombreTabla,
            int Pagina,
            int RegistrosPorPagina)
        {
            try
            {
                ConsultasMetValidarNombreTabla(NombreTabla);
                ConsultasMetValidarPaginacion(
                    Pagina,
                    RegistrosPorPagina);

                DataTable DtTabla = new DataTable();

                int Inicio =
                    (Pagina - 1) * RegistrosPorPagina;

                string Consulta =
                    "SELECT * FROM " +
                    NombreTabla +
                    " LIMIT ? OFFSET ?;";

                using (OdbcConnection Conexion =
                    _Conexion.ConsultasFuncConexion())
                {
                    using (OdbcCommand Cmd =
                        new OdbcCommand(
                            Consulta,
                            Conexion))
                    {
                        Cmd.Parameters.Add(
                            "?",
                            OdbcType.Int).Value =
                            RegistrosPorPagina;

                        Cmd.Parameters.Add(
                            "?",
                            OdbcType.Int).Value =
                            Inicio;

                        using (OdbcDataAdapter DaTabla =
                            new OdbcDataAdapter(Cmd))
                        {
                            DaTabla.Fill(DtTabla);
                        }
                    }
                }

                return DtTabla;
            }
            catch (OdbcException Ex)
            {
                throw new InvalidOperationException(
                    "Error al cargar la tabla '" +
                    NombreTabla + "'.",
                    Ex);
            }
        }

        public DataTable ConsultasFuncCargarConsulta(
        string Consulta,
        int Pagina,
        int RegistrosPorPagina)
        {
            try
            {
                ConsultasMetValidarConsulta(Consulta);

                ConsultasMetValidarPaginacion(
                    Pagina,
                    RegistrosPorPagina);

                int Inicio =
                    (Pagina - 1) * RegistrosPorPagina;

                Consulta =
                    Consulta.Trim().TrimEnd(';');

                string ConsultaPaginada =
                    Consulta +
                    " LIMIT " +
                    RegistrosPorPagina +
                    " OFFSET " +
                    Inicio +
                    ";";

                DataTable DtConsultaSeleccionada =
                    new DataTable();

                using (OdbcConnection Conexion =
                    _Conexion.ConsultasFuncConexion())
                {
                    using (OdbcCommand Cmd =
                        new OdbcCommand(
                            ConsultaPaginada,
                            Conexion))
                    {
                        using (OdbcDataAdapter DaConsultas =
                            new OdbcDataAdapter(Cmd))
                        {
                            DaConsultas.Fill(
                                DtConsultaSeleccionada);
                        }
                    }
                }

                return DtConsultaSeleccionada;
            }
            catch (OdbcException Ex)
            {
                foreach (OdbcError Error in Ex.Errors)
                {
                    if (Error.NativeError == 1146 ||
                        Error.SQLState == "42S02")
                    {
                        throw new InvalidOperationException(
                            "La consulta hace referencia a una tabla " +
                            "que no existe en la base de datos.",
                            Ex);
                    }
                }

                throw new InvalidOperationException(
                    "No fue posible ejecutar la consulta seleccionada.",
                    Ex);
            }
        }

        public DataTable ConsultasFuncObtenerTablas()
        {
            try
            {
                DataTable DtTablas =
                    new DataTable();

                string Consulta =
                    "SHOW TABLES;";

                using (OdbcConnection Conexion =
                    _Conexion.ConsultasFuncConexion())
                {
                    using (OdbcCommand Cmd =
                        new OdbcCommand(
                            Consulta,
                            Conexion))
                    {
                        using (OdbcDataAdapter DaTablas =
                            new OdbcDataAdapter(Cmd))
                        {
                            DaTablas.Fill(DtTablas);
                        }
                    }
                }

                return DtTablas;
            }
            catch (OdbcException Ex)
            {
                throw new InvalidOperationException(
                    "Error al obtener las tablas de la base de datos.",
                    Ex);
            }
        }

        public int ConsultasFuncContarRegistros(
            string NombreTabla)
        {
            try
            {
                ConsultasMetValidarNombreTabla(
                    NombreTabla);

                string Consulta =
                    "SELECT COUNT(*) FROM " +
                    NombreTabla + ";";

                using (OdbcConnection Conexion =
                    _Conexion.ConsultasFuncConexion())
                {
                    if (Conexion.State !=
                        ConnectionState.Open)
                    {
                        Conexion.Open();
                    }

                    using (OdbcCommand Cmd =
                        new OdbcCommand(
                            Consulta,
                            Conexion))
                    {
                        return Convert.ToInt32(
                            Cmd.ExecuteScalar());
                    }
                }
            }
            catch (OdbcException Ex)
            {
                throw new InvalidOperationException(
                    "Error al contar los registros de la tabla '" +
                    NombreTabla + "'.",
                    Ex);
            }
        }

        public DataTable ConsultasFuncObtenerConsultas(
            string NombreTabla)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(NombreTabla))
                {
                    throw new ArgumentException(
                        "No se ha seleccionado una tabla.");
                }

                DataTable DtConsultas =
                    new DataTable();

                string Consulta =
                    "SELECT " +
                    "nombreConsulta AS Consulta, " +
                    "queryConsulta AS Query, " +
                    "tablaConsulta AS Tabla " +
                    "FROM tblConsulta " +
                    "WHERE tablaConsulta = ?;";

                using (OdbcConnection Conexion =
                    _Conexion.ConsultasFuncConexion())
                {
                    using (OdbcCommand Cmd =
                        new OdbcCommand(
                            Consulta,
                            Conexion))
                    {
                        Cmd.Parameters.Add(
                            "?",
                            OdbcType.VarChar).Value =
                            NombreTabla;

                        using (OdbcDataAdapter DaConsultas =
                            new OdbcDataAdapter(Cmd))
                        {
                            DaConsultas.Fill(
                                DtConsultas);
                        }
                    }
                }

                return DtConsultas;
            }
            catch (OdbcException Ex)
            {
                throw new InvalidOperationException(
                    "Error al cargar las consultas de la tabla '" +
                    NombreTabla + "'.",
                    Ex);
            }
        }

        public int ConsultasFuncContarResultadosQuery(
            string Consulta)
        {
            try
            {
                ConsultasMetValidarConsulta(Consulta);

                Consulta =
                    Consulta.Trim().TrimEnd(';');

                string QueryConteo =
                    "SELECT COUNT(*) FROM (" +
                    Consulta +
                    ") AS ConsultaResultado;";

                using (OdbcConnection Conexion =
                    _Conexion.ConsultasFuncConexion())
                {
                    if (Conexion.State !=
                        ConnectionState.Open)
                    {
                        Conexion.Open();
                    }

                    using (OdbcCommand Cmd =
                        new OdbcCommand(
                            QueryConteo,
                            Conexion))
                    {
                        return Convert.ToInt32(
                            Cmd.ExecuteScalar());
                    }
                }
            }
            catch (OdbcException Ex)
            {
                throw new InvalidOperationException(
                    "Error al contar los resultados de la consulta.",
                    Ex);
            }
        }

        private void ConsultasMetValidarNombreTabla(
            string NombreTabla)
        {
            if (string.IsNullOrWhiteSpace(
                NombreTabla))
            {
                throw new ArgumentException(
                    "El nombre de la tabla no puede estar vacío.");
            }

            if (!Regex.IsMatch(
                NombreTabla,
                @"^[A-Za-z_][A-Za-z0-9_]*$"))
            {
                throw new ArgumentException(
                    "El nombre de la tabla contiene caracteres no válidos.");
            }
        }

        private void ConsultasMetValidarPaginacion(
            int Pagina,
            int RegistrosPorPagina)
        {
            if (Pagina < 1)
            {
                throw new ArgumentOutOfRangeException(
                    nameof(Pagina),
                    "La página debe ser mayor o igual a 1.");
            }

            if (RegistrosPorPagina < 1)
            {
                throw new ArgumentOutOfRangeException(
                    nameof(RegistrosPorPagina),
                    "Los registros por página deben ser mayores a 0.");
            }
        }

        private void ConsultasMetValidarConsulta(
            string Consulta)
        {
            if (string.IsNullOrWhiteSpace(
                Consulta))
            {
                throw new ArgumentException(
                    "La consulta no puede estar vacía.");
            }

            string ConsultaValidada =
                Consulta.TrimStart();

            if (!ConsultaValidada.StartsWith(
                    "SELECT",
                    StringComparison.OrdinalIgnoreCase) &&
                !ConsultaValidada.StartsWith(
                    "WITH",
                    StringComparison.OrdinalIgnoreCase))
            {
                throw new ArgumentException(
                    "Solo se permiten consultas de lectura.");
            }
        }
    }
}