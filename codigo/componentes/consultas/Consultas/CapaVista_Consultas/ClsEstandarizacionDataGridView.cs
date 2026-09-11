using System.Drawing;
using System.Windows.Forms;

namespace CapaVista_Consultas
{
    public static class ClsEstandarizacionDataGridView
    {
        private static readonly Color _Primario =
            ColorTranslator.FromHtml("#2E4A63");

        private static readonly Color _Secundario =
            ColorTranslator.FromHtml("#4E8078");

        private static readonly Color _Fondo =
            ColorTranslator.FromHtml("#EDE7DA");

        public static void Estandarizar(DataGridView Dgv)
        {
            if (Dgv == null)
                return;

            Dgv.BackgroundColor = _Fondo;
            Dgv.BorderStyle = BorderStyle.FixedSingle;
            Dgv.GridColor = _Primario;

            Dgv.EnableHeadersVisualStyles = false;

            Dgv.ColumnHeadersDefaultCellStyle.BackColor = _Primario;
            Dgv.ColumnHeadersDefaultCellStyle.ForeColor = _Fondo;
            Dgv.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 10F, FontStyle.Bold);
            Dgv.ColumnHeadersDefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;

            Dgv.ColumnHeadersHeight = 35;
            Dgv.ColumnHeadersHeightSizeMode =
                DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            Dgv.DefaultCellStyle.BackColor = _Fondo;
            Dgv.DefaultCellStyle.ForeColor = _Primario;
            Dgv.DefaultCellStyle.Font =
                new Font("Segoe UI", 10F, FontStyle.Regular);
            Dgv.DefaultCellStyle.SelectionBackColor = _Secundario;
            Dgv.DefaultCellStyle.SelectionForeColor = _Fondo;
            Dgv.DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleLeft;

            Dgv.AlternatingRowsDefaultCellStyle.BackColor =
                ControlPaint.Light(_Fondo, 0.3f);
            Dgv.AlternatingRowsDefaultCellStyle.ForeColor = _Primario;
            Dgv.AlternatingRowsDefaultCellStyle.SelectionBackColor = _Secundario;
            Dgv.AlternatingRowsDefaultCellStyle.SelectionForeColor = _Fondo;

            Dgv.RowTemplate.Height = 30;

            Dgv.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.AllCells;

            Dgv.AutoSizeRowsMode =
                DataGridViewAutoSizeRowsMode.None;

            Dgv.ScrollBars = ScrollBars.Both;

            Dgv.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            Dgv.MultiSelect = false;
            Dgv.AllowUserToAddRows = false;
            Dgv.AllowUserToDeleteRows = false;
            Dgv.AllowUserToResizeRows = false;
            Dgv.AllowUserToResizeColumns = true;
            Dgv.RowHeadersVisible = false;

            foreach (DataGridViewColumn Columna in Dgv.Columns)
            {
                Columna.SortMode =
                    DataGridViewColumnSortMode.Automatic;
            }

            Dgv.ClearSelection();
        }
    }
}