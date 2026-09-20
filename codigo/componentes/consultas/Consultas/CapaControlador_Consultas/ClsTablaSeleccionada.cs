using System;

namespace CapaControlador_Consultas
{
    public static class ClsTablaSeleccionada
    {
        private static string _NombreTabla;
        // Inicio de código de "Pedro José Gómez Villalobos" - carné: "0901-23-4868" - Fecha: "20/09/26"
        private static string[] _ArregloTablas;
        // Fin de código de "Pedro José Gómez Villalobos" - carné: "0901-23-4868" - Fecha: "20/09/26"

        public static void ConsultasMetGuardarTabla(string NombreTabla)
        {
            if (string.IsNullOrWhiteSpace(NombreTabla))
            {
                throw new ArgumentException(
                    "El nombre de la tabla no puede estar vacío.");
            }

            _NombreTabla = NombreTabla;
            // Inicio de código de "Pedro José Gómez Villalobos" - carné: "0901-23-4868" - Fecha: "20/09/26"
            switch (NombreTabla)
            {
                case "tblConsulta":
                    _ArregloTablas = new string[] { "tblConsulta", "vwDetalleCompras", "vwComprasPorProveedor", "vwComprasPorProducto" };
                    break;
                case "tbl_rrhh_empleados":
                    _ArregloTablas = new string[] { "tbl_rrhh_empleados", "tbl_rrhh_asistencias", "tbl_rrhh_nominas" };
                    break;
                case "tbl_bancos":
                    _ArregloTablas = new string[] { "tbl_bancos", "tbl_bancos_cuentas", "tbl_bancos_transacciones" };
                    break;
                case "tbl_comercial_clientes":
                    _ArregloTablas = new string[] { "tbl_comercial_clientes", "tbl_comercial_ventas", "tbl_comercial_cotizaciones" };
                    break;
                default:
                    _ArregloTablas = new string[] { NombreTabla };
                    break;
            }
            // Fin de código de "Pedro José Gómez Villalobos" - carné: "0901-23-4868" - Fecha: "20/09/26"
        }

        public static string ConsultasFuncObtenerTabla()
        {
            return _NombreTabla;
        }
        // Inicio de código de "Pedro José Gómez Villalobos" - carné: "0901-23-4868" - Fecha: "20/09/26"
        public static string[] ConsultasFuncObtenerArreglo()
        {
            return _ArregloTablas;
        }
        // Fin de código de "Pedro José Gómez Villalobos" - carné: "0901-23-4868" - Fecha: "20/09/26"
        public static void ConsultasMetLimpiarTabla()
        {
            _NombreTabla = null;
            // Inicio de código de "Pedro José Gómez Villalobos" - carné: "0901-23-4868" - Fecha: "20/09/26"
            _ArregloTablas = null;
            // Fin de código de "Pedro José Gómez Villalobos" - carné: "0901-23-4868" - Fecha: "20/09/26"
        }
    }
}