using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaModelo_Consultas.Repositorios
{
    public class clsObtenciónCampos
    {

        public string Tabla { get; set; }

        private ClsConexion _Conexion = new ClsConexion();
        private void ConsultasMetPopularComboBox(string Pub_sTabla, ComboBox cboDestino)
        {
            cboDestino.Items.Clear();

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
                    Cmd.Parameters.AddWithValue("@tabla", Pub_sTabla);

                    using (OdbcDataReader Reader = Cmd.ExecuteReader())
                    {
                        while (Reader.Read())
                        {
                            cboDestino.Items.Add(Reader["COLUMN_NAME"].ToString());
                        }
                    }
                }
            }
            finally
            {
                _Conexion.ConsultasProcDesconexion(Conn);
            }
        }

        public void ConsultasMetPopularComboBox(ComboBox cboDestino)
        {
            ConsultasMetPopularComboBox(this.Tabla, cboDestino);
        }

     
      



    }
}
