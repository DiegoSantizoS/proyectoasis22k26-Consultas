using System.Data;
using System.Data.SqlClient;

namespace CapaModelo_Consultas
{
    /// mishel loeiza 9959-23-3457
    /// Ejecuta las consultas reales contra la base de datos usando
    /// los valores guardados en un ClsAgruparOrdenarFiltros.
    
    public class ClsConsultasDatos
    {
        private string _cadenaConexion = "Data Source=.;Initial Catalog=TU_BD;Integrated Security=True";

        public DataTable ObtenerDatosFiltrados(ClsAgruparOrdenarFiltros filtros)
        {
            string query = $"SELECT * FROM {filtros.Pub_sTabla}";

            bool hayFiltro = !string.IsNullOrEmpty(filtros.Pub_sOperador)
                              && !string.IsNullOrEmpty(filtros.Pub_sValor);

            if (hayFiltro)
                query += $" WHERE {filtros.Pub_sCampoTabla} {TraducirOperador(filtros.Pub_sOperador)} @valor";

            query += $" ORDER BY {filtros.Pub_sCampoTabla} {filtros.Pub_sOrdenamiento}";

            return Ejecutar(query, filtros, hayFiltro);
        }

        public DataTable ObtenerDatosAgrupados(ClsAgruparOrdenarFiltros filtros)
        {
            string query = $@"SELECT {filtros.Pub_sCampoTabla}, COUNT(*) AS Total
                               FROM {filtros.Pub_sTabla}
                               GROUP BY {filtros.Pub_sCampoTabla}
                               ORDER BY {filtros.Pub_sCampoTabla} {filtros.Pub_sOrdenamiento}";

            return Ejecutar(query, filtros, aplicarFiltro: false);
        }

        private string TraducirOperador(string operadorTexto)
        {
            switch (operadorTexto)
            {
                case "Contiene":
                case "Comienza con":
                case "Termina con":
                    return "LIKE";
                default:
                    return operadorTexto;
            }
        }

        private DataTable Ejecutar(string query, ClsAgruparOrdenarFiltros filtros, bool aplicarFiltro)
        {
            DataTable dt = new DataTable();

            using (SqlConnection conn = new SqlConnection(_cadenaConexion))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                if (aplicarFiltro)
                {
                    string valorParametro = filtros.Pub_sValor;

                    if (filtros.Pub_sOperador == "Contiene")
                        valorParametro = $"%{filtros.Pub_sValor}%";
                    else if (filtros.Pub_sOperador == "Comienza con")
                        valorParametro = $"{filtros.Pub_sValor}%";
                    else if (filtros.Pub_sOperador == "Termina con")
                        valorParametro = $"%{filtros.Pub_sValor}";

                    cmd.Parameters.AddWithValue("@valor", valorParametro);
                }

                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    da.Fill(dt);
                }
            }

            return dt;
        }
    }
}