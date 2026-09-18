using System.Data.Odbc;
using System.Windows.Forms;

namespace CapaModelo_Consultas.Repositorios
{
    public class ClsObtenciónCampos
    {
        public string Tabla { get; set; }

        private ClsConexion _Conexion = new ClsConexion();
        private void ConsultasMetPopularComboBox(string Tabla, ComboBox CboDestino)
        {
            CboDestino.Items.Clear();

            string Query = @"SELECT COLUMN_NAME
                             FROM INFORMATION_SCHEMA.COLUMNS
                             WHERE TABLE_SCHEMA = DATABASE()
                             AND TABLE_NAME = ?
                             ORDER BY ORDINAL_POSITION ";

            OdbcConnection Conn = _Conexion.ConsultasFuncConexion();

            try
            {
                using (OdbcCommand Cmd = new OdbcCommand(Query, Conn))
                {
                    Cmd.Parameters.AddWithValue("@tabla", Tabla);

                    using (OdbcDataReader Reader = Cmd.ExecuteReader())
                    {
                        while (Reader.Read())
                        {
                            CboDestino.Items.Add(Reader["COLUMN_NAME"].ToString());
                        }
                    }
                }
            }
            finally
            {
                _Conexion.ConsultasProcDesconexion(Conn);
            }
        }
        public void ConsultasMetPopularComboBox(ComboBox CboDestino)
        {
            ConsultasMetPopularComboBox(this.Tabla, CboDestino);
        }


    }
}
