using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaModelo_CbCampos.Repositorio
{
    public class ClsComboCampos : ClsConexion
    {
        public string Campo { get; set; }


        public DataTable ObtenerCampos(string tabla)
        {
            string sql = "SELECT * FROM " + tabla + ";";

            using (OdbcCommand command = new OdbcCommand(sql, ConsultasFuncConexion()))
            {
                using (OdbcDataAdapter adaptador = new OdbcDataAdapter(command))
                {
                    DataTable dtDatos = new DataTable();
                    adaptador.Fill(dtDatos);

                    return dtDatos;
                }
            }
        }


       

    }
}
