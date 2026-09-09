using System;
using System.Drawing;
using System.Windows.Forms;

namespace CapaVista_Consultas
{
    /*
    Inicio de código de "José Pablo Cano Cóbar" - carné: "0901-23-1727" - Fecha: "07/09/26"
    Clase de apoyo para aplicar la estandarización visual EST-10 del Proyecto Terminus
    al Componente Consultas. Centraliza paleta, tipografías y el formato de ventanas y
    cuadrículas para no repetir valores en cada formulario.
    */
    public static class ClsEstandarizacionConsultas
    {
        // ---------------------------------------------------------------
        // Paleta oficial del Componente Consultas  (EST-10, sección 14.1)
        // ---------------------------------------------------------------
        public static readonly Color Primario   = ColorTranslator.FromHtml("#2E4A63");
        public static readonly Color Secundario = ColorTranslator.FromHtml("#4E8078");
        public static readonly Color Acento     = ColorTranslator.FromHtml("#C4573F");
        public static readonly Color Fondo      = ColorTranslator.FromHtml("#EDE7DA");

        // Color de fila alterna: el fondo aclarado, para no salirse de la paleta
        public static readonly Color FilaAlterna = ColorTranslator.FromHtml("#F6F2E9");
        public static readonly Color TextoClaro  = ColorTranslator.FromHtml("#EDE7DA");

        // ---------------------------------------------------------------
        // Tipografías oficiales  (EST-10, sección 2.3)
        // ---------------------------------------------------------------
        public static readonly Font FuenteTitulo =
            new Font("Lucida Sans", 18F, FontStyle.Bold | FontStyle.Italic);

        public static readonly Font FuenteSubtitulo =
            new Font("Lucida Sans", 12F, FontStyle.Bold | FontStyle.Italic);

        public static readonly Font FuenteCampo = new Font("Segoe UI", 11F, FontStyle.Regular);
        public static readonly Font FuenteEtiqueta = new Font("Tahoma", 10F, FontStyle.Regular);
        public static readonly Font FuenteBoton = new Font("Segoe UI", 10F, FontStyle.Bold);

        /// <summary>
        /// Aplica a un formulario secundario las reglas de las secciones 5, 9 y 10:
        /// fondo general, título con código de aplicación, ícono del componente,
        /// centrado sobre el contenedor y botón Maximizar deshabilitado.
        /// </summary>
        public static void ConsultasMetAplicarFormatoVentana(Form Ventana,
                                                             string CodigoAplicacion,
                                                             string NombreVentana)
        {
            if (Ventana == null) return;

            Ventana.BackColor = Fondo;
            Ventana.Font = FuenteCampo;
            Ventana.Text = CodigoAplicacion + " – " + NombreVentana;
            Ventana.StartPosition = FormStartPosition.CenterParent;
            Ventana.MaximizeBox = false;      // EST-10 sección 5.2
            Ventana.MinimizeBox = true;
            Ventana.FormBorderStyle = FormBorderStyle.FixedDialog;

            // Idioma y formatos (EST-10 sección 9): fecha DD/MM/AAAA y moneda Q
            System.Threading.Thread.CurrentThread.CurrentCulture =
                new System.Globalization.CultureInfo("es-GT");
        }

        /// <summary>
        /// Aplica a un DataGridView las reglas de la sección 8:
        /// filas alternadas, ordenamiento por encabezado y encabezados con la paleta.
        /// </summary>
        public static void ConsultasMetAplicarFormatoCuadricula(DataGridView Cuadricula)
        {
            if (Cuadricula == null) return;

            Cuadricula.BackgroundColor = Fondo;
            Cuadricula.BorderStyle = BorderStyle.FixedSingle;
            Cuadricula.EnableHeadersVisualStyles = false;
            Cuadricula.GridColor = Secundario;

            // Encabezados
            Cuadricula.ColumnHeadersDefaultCellStyle.BackColor = Primario;
            Cuadricula.ColumnHeadersDefaultCellStyle.ForeColor = TextoClaro;
            Cuadricula.ColumnHeadersDefaultCellStyle.Font = FuenteBoton;
            Cuadricula.ColumnHeadersDefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
            Cuadricula.ColumnHeadersHeight = 34;
            Cuadricula.ColumnHeadersHeightSizeMode =
                DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            // Filas y filas alternadas  (EST-10 sección 8)
            Cuadricula.DefaultCellStyle.BackColor = Color.White;
            Cuadricula.DefaultCellStyle.ForeColor = Color.Black;
            Cuadricula.DefaultCellStyle.Font = FuenteCampo;
            Cuadricula.DefaultCellStyle.SelectionBackColor = Secundario;
            Cuadricula.DefaultCellStyle.SelectionForeColor = TextoClaro;
            Cuadricula.AlternatingRowsDefaultCellStyle.BackColor = FilaAlterna;
            Cuadricula.RowTemplate.Height = 26;

            // Comportamiento
            Cuadricula.AllowUserToAddRows = false;
            Cuadricula.AllowUserToDeleteRows = false;
            Cuadricula.ReadOnly = true;
            Cuadricula.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Cuadricula.MultiSelect = false;
            Cuadricula.RowHeadersVisible = false;
            Cuadricula.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Ordenamiento por clic en el encabezado (EST-10 sección 8)
            foreach (DataGridViewColumn Columna in Cuadricula.Columns)
            {
                Columna.SortMode = DataGridViewColumnSortMode.Automatic;
            }
        }

        /// <summary>
        /// Da formato de botón principal según la paleta del componente.
        /// </summary>
        public static void ConsultasMetAplicarFormatoBoton(Button Boton)
        {
            if (Boton == null) return;

            Boton.FlatStyle = FlatStyle.Flat;
            Boton.FlatAppearance.BorderSize = 2;
            Boton.FlatAppearance.BorderColor = Primario;
            Boton.FlatAppearance.MouseOverBackColor = Acento;
            Boton.BackColor = Secundario;
            Boton.ForeColor = TextoClaro;
            Boton.Font = FuenteBoton;
            Boton.Cursor = Cursors.Hand;
            Boton.TextImageRelation = TextImageRelation.ImageAboveText;
        }

        /// <summary>
        /// Estado deshabilitado de un botón (EST-10 sección 7): gris claro y sin efecto.
        /// </summary>
        public static void ConsultasMetCambiarEstadoBoton(Button Boton, Boolean Habilitado)
        {
            if (Boton == null) return;

            Boton.Enabled = Habilitado;
            if (Habilitado)
            {
                Boton.BackColor = Secundario;
                Boton.ForeColor = TextoClaro;
                Boton.FlatAppearance.BorderColor = Primario;
            }
            else
            {
                Boton.BackColor = Color.FromArgb(214, 214, 214);
                Boton.ForeColor = Color.FromArgb(120, 120, 120);
                Boton.FlatAppearance.BorderColor = Color.FromArgb(180, 180, 180);
            }
        }

        /// <summary>
        /// Marca una etiqueta como campo obligatorio (EST-10 sección 7): asterisco rojo.
        /// </summary>
        public static void ConsultasMetMarcarObligatorio(Label Etiqueta)
        {
            if (Etiqueta == null) return;
            if (!Etiqueta.Text.EndsWith("*"))
            {
                Etiqueta.Text = Etiqueta.Text + " *";
            }
            Etiqueta.ForeColor = Primario;
            Etiqueta.Font = FuenteEtiqueta;
        }
    }
    // Fin del código de "José Pablo Cano Cóbar" - Carné: "0901-23-1727" - Fecha: "07/09/26"
}
