using System;
using System.Collections.Generic;
using System.Data.Odbc;
using CapaModelo_Consultas.Contratos;
using CapaModelo_Consultas.Entidades;

namespace CapaModelo_Consultas.Repositorios
{
    public sealed class ClsRepositorioMetadatos : ClsRepositorio, IRepositorioMetadatos
    {
        private readonly int _TiempoEspera;

        public ClsRepositorioMetadatos(string CadenaConexion = null, int TiempoEspera = 30) : base(CadenaConexion)
        {
            if (TiempoEspera < 1) throw new ArgumentOutOfRangeException(nameof(TiempoEspera));
            _TiempoEspera = TiempoEspera;
        }

        public IList<string> ConsultasFuncObtenerTablas()
        {
            List<string> Tablas = new List<string>();
            using (OdbcConnection Conexion = ConsultasFuncAbrirConexion())
            using (OdbcCommand Comando = new OdbcCommand("SELECT TABLE_NAME FROM information_schema.TABLES WHERE TABLE_SCHEMA = DATABASE() AND TABLE_TYPE = 'BASE TABLE' AND TABLE_SCHEMA NOT IN ('information_schema', 'mysql', 'performance_schema', 'sys') ORDER BY TABLE_NAME", Conexion))
            {
                Comando.CommandTimeout = _TiempoEspera;
                using (OdbcDataReader Lector = Comando.ExecuteReader())
                {
                    while (Lector.Read()) Tablas.Add(Lector.GetString(0));
                }
            }
            return Tablas;
        }

        public IList<ClsCampoConsulta> ConsultasFuncObtenerCampos(string Tabla)
        {
            ConsultasFuncIdentificador(Tabla);
            List<ClsCampoConsulta> Campos = new List<ClsCampoConsulta>();
            using (OdbcConnection Conexion = ConsultasFuncAbrirConexion())
            using (OdbcCommand Comando = new OdbcCommand("SELECT COLUMN_NAME, DATA_TYPE, COLUMN_KEY, COALESCE(CHARACTER_MAXIMUM_LENGTH, 0) FROM information_schema.COLUMNS WHERE TABLE_SCHEMA = DATABASE() AND TABLE_NAME = ? ORDER BY ORDINAL_POSITION", Conexion))
            {
                Comando.CommandTimeout = _TiempoEspera;
                ConsultasProcAgregarParametro(Comando, Tabla);
                using (OdbcDataReader Lector = Comando.ExecuteReader())
                {
                    while (Lector.Read())
                    {
                        Campos.Add(new ClsCampoConsulta { Nombre = Lector.GetString(0), Tipo = Lector.GetString(1), EsPrimario = Lector.GetString(2) == "PRI", Longitud = Convert.ToInt64(Lector.GetValue(3)) });
                    }
                }
            }
            if (Campos.Count == 0)
            {
                throw new InvalidOperationException("La tabla no existe o no tiene columnas accesibles en la conexión actual.");
            }
            return Campos;
        }
    }
}
