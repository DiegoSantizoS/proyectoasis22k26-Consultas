using System.Data.Odbc;
using System.Windows.Forms;

namespace CapaModelo_Consultas.Repositorios
{
    public class ClsObtenciónCampos
    {
        public string Tabla { get; set; }

        private ClsConexion _Conexion = new ClsConexion();
        private void ConsultasMetPopularComboBox(string Tabla, ComboBox ComboDestino)
        {
            ComboDestino.Items.Clear();

            string Query = @"SELECT COLUMN_NAME
                             FROM INFORMATION_SCHEMA.COLUMNS
                             WHERE TABLE_SCHEMA = DATABASE()
                             AND TABLE_NAME = ?
                             ORDER BY ORDINAL_POSITION ";

            OdbcConnection Conexion = _Conexion.ConsultasFuncConexion();

            try
            {
                using (OdbcCommand Comando = new OdbcCommand(Query, Conexion))
                {
                    Comando.Parameters.AddWithValue("@tabla", Tabla);

                    using (OdbcDataReader Reader = Comando.ExecuteReader())
                    {
                        while (Reader.Read())
                        {
                            ComboDestino.Items.Add(Reader["COLUMN_NAME"].ToString());
                        }
                    }
                }
            }
            finally
            {
                _Conexion.ConsultasProcDesconexion(Conexion);
            }
        }
        public void ConsultasMetPopularComboBox(ComboBox ComboDestino)
        {
            ConsultasMetPopularComboBox(this.Tabla, ComboDestino);
        }


    }
}
