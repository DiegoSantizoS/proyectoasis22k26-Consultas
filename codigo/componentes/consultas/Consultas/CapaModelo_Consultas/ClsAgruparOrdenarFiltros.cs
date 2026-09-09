using System.Data.SqlClient;
using System.Windows.Forms;

namespace CapaModelo_Consultas
{
    /// Mishel loeiza 9959-23-3457
    /// Representa los filtros de agrupamiento/ordenamiento elegidos por el usuario.
    
    public class ClsAgruparOrdenarFiltros
    {
        private string _cadenaConexion = "Data Source=.;Initial Catalog=TU_BD;Integrated Security=True";

        public string Pub_sTabla { get; set; }
        public string Pub_sOrdenamiento { get; set; }
        public string Pub_sCampoTabla { get; set; }
        public string Pub_sOperador { get; set; }
        public string Pub_sValor { get; set; }

        public ClsAgruparOrdenarFiltros()
        {
            Pub_sOrdenamiento = "ASC";
        }

        private void PopularComboBox(string Pub_sTabla, ComboBox cboDestino)
        {
            cboDestino.Items.Clear();

            string query = @"SELECT COLUMN_NAME 
                              FROM INFORMATION_SCHEMA.COLUMNS 
                              WHERE TABLE_NAME = @tabla";

            using (SqlConnection conn = new SqlConnection(_cadenaConexion))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@tabla", Pub_sTabla);
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        cboDestino.Items.Add(reader["COLUMN_NAME"].ToString());
                    }
                }
            }
        }

        public void Pub_PopularComboBox(ComboBox cboDestino)
        {
            PopularComboBox(this.Pub_sTabla, cboDestino);
        }
    }
}
