using System;
using System.Data;
using System.Windows.Forms;

namespace CapaVista_Consultas
{
    public partial class TablaSimple : UserControl
    {
        public TablaSimple()
        {
            InitializeComponent();

            DataSet DtsEmpleados = new DataSet("EmpleadosDataSet");

            DataTable TblConsulta = new DataTable("Empleados");

            TblConsulta.Rows.Add(1, "Carlos", "López", "Desarrollador", 6500.00m);
            TblConsulta.Rows.Add(2, "María", "García", "Analista de Sistemas", 7200.00m);
            TblConsulta.Rows.Add(3, "Juan", "Martínez", "Administrador", 5800.00m);
            TblConsulta.Rows.Add(4, "Ana", "Hernández", "Diseñadora", 6100.00m);
            TblConsulta.Rows.Add(5, "Luis", "Ramírez", "Soporte Técnico", 4800.00m);

            DtsEmpleados.Tables.Add(TblConsulta);

            ConsultasDgvEmpleados.DataSource = DtsEmpleados.Tables["Empleados"];
        }
    }
}