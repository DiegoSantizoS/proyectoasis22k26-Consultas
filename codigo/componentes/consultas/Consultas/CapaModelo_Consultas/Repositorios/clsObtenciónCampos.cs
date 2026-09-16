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

        // Obtener el tipo de dato de un campo
        public string ConsultasMetObtenerTipoCampo( string Campo)
        { 
            string TipoCampo = "";
            string Query = @" SELECT DATA_TYPE FROM INFORMATION_SCHEMA.COLUMNS WHERE
                            TABLE_SCHEMA = DATABASE() AND TABLE_NAME = ? AND COLUMN_NAME = ?"; 
            OdbcConnection Conn = _Conexion.ConsultasFuncConexion(); 
            try { using (OdbcCommand Cmd = new OdbcCommand(Query, Conn))
                { Cmd.Parameters.AddWithValue("?", Tabla);
                    Cmd.Parameters.AddWithValue("?", Campo); object Resultado = Cmd.ExecuteScalar(); 
                    if (Resultado != null) { TipoCampo = Resultado.ToString().ToLower();
                    } 
                }
            } 
            finally 
            { _Conexion.ConsultasProcDesconexion(Conn); } return TipoCampo; }



    }
}
