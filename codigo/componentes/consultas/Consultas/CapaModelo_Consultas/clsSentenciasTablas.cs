using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModelo_Consultas { 
    public class clsSentenciasTablas { 
        Conexion con = new Conexion(); 
        public OdbcDataAdapter OBtenerTabla(string Tabla) 
        { string consulta = "SELECT * FROM " + Tabla + ";"; 
            Console.WriteLine(consulta); 
            OdbcDataAdapter daTabla = new OdbcDataAdapter(consulta, con.conexion()); return daTabla; 
        } 
        public OdbcDataAdapter GetTables() { 
            string consulta = "SHOW TABLES;"; 
            OdbcDataAdapter daTablas = new OdbcDataAdapter(consulta, con.conexion()); 
            return daTablas; 
        } 
    } 
}