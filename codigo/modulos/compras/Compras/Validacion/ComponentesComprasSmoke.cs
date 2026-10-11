using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using CapaVista_Compras.Componentes;
using CapaVista_Compras;

internal static class ComponentesComprasSmoke
{
    private static int comprobaciones;
    private static void Verificar(bool condicion, string mensaje)
    {
        if (!condicion) throw new Exception(mensaje);
        comprobaciones++;
    }

    private static void Emitir(Control control, string metodo, EventArgs argumentos)
    {
        typeof(Control).GetMethod(metodo, BindingFlags.Instance | BindingFlags.NonPublic)
            .Invoke(control, new object[] { argumentos });
    }

    [STAThread]
    private static int Main(string[] args)
    {
        try
        {
            var assembly = typeof(UsrTextBoxCompras).Assembly;
            var tipos = assembly.GetTypes().Where(t => t.Namespace == "CapaVista_Compras.Componentes"
                && typeof(Control).IsAssignableFrom(t) && !t.IsAbstract).ToArray();
            Verificar(tipos.Length == 13, "Inventario de controles incompleto");
            foreach (var tipo in tipos)
            {
                using (var control = (Control)Activator.CreateInstance(tipo, true))
                {
                    control.CreateControl();
                    Verificar(!control.IsDisposed, "Inicialización: " + tipo.Name);
                }
            }
            var recursos = assembly.GetManifestResourceNames().Where(n => n.StartsWith("CapaVista_Compras.Componentes.")).ToArray();
            Verificar(recursos.Length == 6, "Recursos incrustados");
            Verificar(TemaCompras.PrincipalNavegador.ToArgb() == Color.FromArgb(30, 42, 90).ToArgb(), "Principal");
            Verificar(TemaCompras.AcentoNavegador.ToArgb() == Color.FromArgb(61, 86, 166).ToArgb(), "Acento");
            Verificar(TemaCompras.FondoEtiquetasDestacadas.ToArgb() == Color.FromArgb(217, 145, 62).ToArgb(), "Destacadas");
            Verificar(TemaCompras.FondoGeneral.ToArgb() == Color.FromArgb(246, 247, 250).ToArgb(), "Fondo general");
            Verificar(TemaCompras.FondoBotones.ToArgb() == Color.FromArgb(213, 220, 239).ToArgb(), "Fondo botones");
            using (var boton = new ClsButtonCompras())
            {
                Verificar(boton.BackColor == TemaCompras.FondoBotones && boton.ForeColor == TemaCompras.PrincipalNavegador, "Botón estándar");
                Verificar(boton.FlatAppearance.MouseOverBackColor == TemaCompras.BotonHover && boton.FlatAppearance.MouseDownBackColor == TemaCompras.BotonPresionado, "Estados de botón");
                boton.BackColor = Color.Yellow;
                boton.ForeColor = Color.Black;
                boton.Enabled = false;
                boton.Enabled = true;
                Verificar(boton.BackColor == Color.Yellow && boton.ForeColor == Color.Black, "Apariencia explícita de botón");
            }
            using (var navegacion = (Button)Activator.CreateInstance(assembly.GetType("CapaVista_Compras.Componentes.ClsTableButtonCompras"), true))
            {
                Verificar(navegacion.BackColor == TemaCompras.PrincipalNavegador, "Navegación en reposo");
                Emitir(navegacion, "OnMouseEnter", EventArgs.Empty);
                Verificar(navegacion.BackColor == TemaCompras.AcentoNavegador, "Hover navegación");
                Emitir(navegacion, "OnMouseLeave", EventArgs.Empty);
                Verificar(navegacion.BackColor == TemaCompras.PrincipalNavegador, "Fin de hover");
                navegacion.GetType().GetProperty("EsActivo").SetValue(navegacion, true, null);
                Verificar(navegacion.BackColor == TemaCompras.AcentoNavegador, "Navegación activa");
                navegacion.Enabled = false;
                Verificar(navegacion.BackColor == TemaCompras.FondoBotones, "Navegación deshabilitada");
                navegacion.Enabled = true;
                Verificar(navegacion.BackColor == TemaCompras.AcentoNavegador, "Restauración de estado activo");
            }
            foreach (var nombre in recursos)
                using (var stream = assembly.GetManifestResourceStream(nombre))
                    Verificar(stream != null && stream.Length > 0 && !nombre.Contains("Consultas"), nombre);

            using (var texto = new UsrTextBoxCompras())
            {
                int cambios = 0;
                texto.TextChanged += (s, e) => { Verificar(s == texto, "Remitente TextChanged"); cambios++; };
                texto.Text = "abc";
                Verificar(cambios == 1 && texto.Entrada.Text == "abc", "TextChanged sin handle");
                texto.Text = "abc";
                Verificar(cambios == 1, "Asignación idéntica");
                texto.CreateControl();
                texto.Text = "def";
                Verificar(cambios == 2, "TextChanged con handle");
                texto.Entrada.Text = "ghi";
                Verificar(cambios == 3 && texto.Text == "ghi", "Edición interna");
                texto.Select(1, 2);
                Verificar(texto.SelectionStart == 1 && texto.SelectedText == "hi", "Selección");
                texto.SelectAll();
                Verificar(texto.SelectionLength == 3, "SelectAll");
                texto.ReadOnly = true;
                Verificar(texto.Entrada.BackColor == TemaCompras.FondoGeneral && texto.Entrada.ForeColor == TemaCompras.PrincipalNavegador, "Tema editor interno");
                texto.MaxLength = 12;
                Verificar(texto.Entrada.ReadOnly && texto.Entrada.MaxLength == 12, "Propiedades editor");
                int teclas = 0, alias = 0;
                ((Control)texto).KeyDown += (s, e) => { teclas++; e.SuppressKeyPress = true; };
                texto.TextoKeyDown += (s, e) => alias++;
                var tecla = new KeyEventArgs(Keys.Enter);
                Emitir(texto.Entrada, "OnKeyDown", tecla);
                Verificar(teclas == 1 && alias == 1 && tecla.SuppressKeyPress, "Teclado y cancelación");
                texto.CausesValidation = false;
                Verificar(!texto.Entrada.CausesValidation, "CausesValidation");
                texto.Enabled = false;
                Verificar(!texto.Entrada.Enabled, "Enabled");
                texto.Enabled = true;
                texto.ComprasMetMostrarError("Error");
                texto.Text = "válido";
                var error = texto.Controls.Find("ComprasUsrError", true).Single();
                Verificar(error.Text == "", "Limpiar error al editar");
            }

            using (var texto = new UsrTextBoxCompras())
            {
                var panel = (TableLayoutPanel)texto.Controls[0];
                var error = texto.Controls.Find("ComprasUsrError", true).Single();
                int altura = texto.Height;
                Verificar(texto.MostrarEtiquetaError && panel.RowStyles[1].Height == 30, "Espacio de error inicial");
                texto.MostrarEtiquetaError = false;
                Verificar(texto.Height == altura - 30 && panel.RowStyles[1].Height == 0 && !error.Visible, "Quitar espacio de error");
                texto.ComprasMetMostrarError("Error conservado");
                Verificar(texto.Height == altura - 30 && panel.RowStyles[1].Height == 0 && error.Text == "Error conservado", "Error sin reabrir etiqueta oculta");
                texto.MostrarEtiquetaError = true;
                Verificar(texto.Height == altura && panel.RowStyles[1].Height == 30 && error.Text == "Error conservado", "Restaurar espacio y mensaje");
                texto.AlturaEtiquetaError = 40;
                Verificar(texto.Height == altura + 18 && panel.RowStyles[1].Height == 48, "Altura configurable de etiqueta");
                texto.ComprasMetLimpiarError();
                Verificar(panel.RowStyles[1].Height == 48 && error.Text == "", "Conservar espacio diseñado al limpiar");
                texto.MostrarEtiquetaError = false;
                texto.Height = 70;
                texto.AlturaEtiquetaError = 30;
                Verificar(texto.Height == 70, "Altura de etiqueta sin alterar estado oculto");
                texto.MostrarEtiquetaError = true;
                Verificar(texto.Height == 108 && panel.RowStyles[1].Height == 38, "Conservar tamaño personalizado al alternar");
                texto.MostrarEtiquetaError = true;
                Verificar(texto.Height == 108, "Asignación repetida sin acumular altura");
                texto.MostrarEtiquetaError = false;
                Verificar(texto.Height == 70, "Restaurar tamaño sin etiqueta");
                Verificar(texto.MaximumSize == Size.Empty, "Redimensionamiento libre");
                var propiedad = TypeDescriptor.GetProperties(texto)["MostrarEtiquetaError"];
                Verificar(propiedad.IsBrowsable && propiedad.SerializationVisibility == DesignerSerializationVisibility.Visible, "Propiedad visible y serializable");
                Verificar(propiedad.ShouldSerializeValue(texto), "Serializar estado oculto");
                propiedad.ResetValue(texto);
                Verificar(texto.MostrarEtiquetaError && !propiedad.ShouldSerializeValue(texto), "Restaurar predeterminado del diseñador");
                bool rechazo = false;
                try { texto.AlturaEtiquetaError = 0; } catch (ArgumentOutOfRangeException) { rechazo = true; }
                Verificar(rechazo && texto.AlturaEtiquetaError == 30, "Rechazar altura inválida");
            }

            using (var combo = new UsrComboBoxCompras())
            {
                Verificar(combo.Entrada is ClsComboBoxCompras && combo.DropDownStyle == ComboBoxStyle.DropDownList, "Combo interno heredado");
                combo.Items.AddRange(new object[] { "Primero", "Segundo" });
                int selecciones = 0, textos = 0;
                combo.SelectedIndexChanged += (s, e) => { Verificar(s == combo, "Remitente selección combo"); selecciones++; };
                combo.TextChanged += (s, e) => textos++;
                combo.SelectedIndex = 1;
                Verificar(combo.SelectedItem.Equals("Segundo") && combo.Text == "Segundo" && selecciones == 1, "Seleccionar elemento combo");
                combo.SelectedIndex = 1;
                Verificar(selecciones == 1, "Selección repetida sin evento duplicado");
                Verificar(combo.FindStringExact("Primero") == 0 && combo.GetItemText(combo.SelectedItem) == "Segundo", "Búsqueda combo");
                var borde = combo.Controls.Find("ComprasPnlBorde", true).Single();
                var error = combo.Controls.Find("ComprasUsrError", true).Single();
                combo.ComprasMetMostrarError("Seleccione un proveedor");
                Verificar(error.Text == "Seleccione un proveedor" && borde.BackColor == Color.Red, "Texto y borde de error combo");
                int altura = combo.Height;
                combo.MostrarEtiquetaError = false;
                Verificar(combo.Height == altura - 30 && !error.Visible && borde.BackColor == Color.Red, "Ocultar etiqueta combo conservando error");
                combo.MostrarEtiquetaError = true;
                Verificar(combo.Height == altura && error.Text == "Seleccione un proveedor", "Restaurar etiqueta combo");
                combo.SelectedIndex = 0;
                Verificar(error.Text == "" && borde.BackColor != Color.Red && selecciones == 2, "Limpiar error al seleccionar");
                combo.DropDownStyle = ComboBoxStyle.DropDown;
                textos = 0;
                combo.Text = "Editable";
                Verificar(combo.Text == "Editable" && textos == 1, "Texto editable combo sin duplicados");
                combo.CreateControl();
                textos = 0;
                combo.Text = "Otro texto";
                Verificar(textos == 1, "Texto editable combo con handle");
                int teclas = 0;
                ((Control)combo).KeyDown += (s, e) => { teclas++; e.SuppressKeyPress = true; };
                var tecla = new KeyEventArgs(Keys.Enter);
                Emitir(combo.Entrada, "OnKeyDown", tecla);
                Verificar(teclas == 1 && tecla.SuppressKeyPress, "Teclado combo cancelable");
                combo.Enabled = false;
                Verificar(!combo.Entrada.Enabled, "Habilitación combo");
                combo.Enabled = true;
                combo.CausesValidation = false;
                Verificar(!combo.Entrada.CausesValidation, "Validación combo");
                combo.BackColor = Color.White;
                combo.ForeColor = Color.Black;
                Verificar(combo.Entrada.BackColor == Color.White && combo.Entrada.ForeColor == Color.Black, "Apariencia combo delegada");
                combo.AlturaEtiquetaError = 35;
                Verificar(((TableLayoutPanel)combo.Controls[0]).RowStyles[1].Height == 43, "Altura etiqueta combo configurable");
                Verificar(TypeDescriptor.GetProperties(combo)["Items"].SerializationVisibility == DesignerSerializationVisibility.Content, "Items en diseñador");
            }

            using (var form = new Form())
            using (var combo = new UsrComboBoxCompras())
            using (var datos = new DataTable())
            using (var registro = new DataTable())
            {
                form.ShowInTaskbar = false;
                form.StartPosition = FormStartPosition.Manual;
                form.Location = new Point(-10000, -10000);
                form.Controls.Add(combo);
                form.Show();
                datos.Columns.Add("Id", typeof(int));
                datos.Columns.Add("Nombre", typeof(string));
                datos.Rows.Add(1, "Proveedor A");
                datos.Rows.Add(2, "Proveedor B");
                combo.DisplayMember = "Nombre";
                combo.ValueMember = "Id";
                combo.DataSource = datos;
                combo.SelectedValue = 2;
                Verificar((int)combo.SelectedValue == 2 && combo.Text == "Proveedor B", "Enlace de datos combo");
                registro.Columns.Add("ProveedorId", typeof(int));
                registro.Rows.Add(1);
                combo.DataBindings.Add("SelectedValue", registro, "ProveedorId", true, DataSourceUpdateMode.OnPropertyChanged);
                Verificar((int)combo.SelectedValue == 1, "Lectura SelectedValue enlazado");
                combo.SelectedIndex = 1;
                Verificar((int)registro.Rows[0]["ProveedorId"] == 2, "Escritura SelectedValue enlazado");
                combo.Focus();
                Verificar(combo.Entrada.Focused, "Foco combo interno");
                int validaciones = 0;
                combo.Validating += (s, e) => { validaciones++; e.Cancel = true; };
                Verificar(!form.ValidateChildren() && validaciones == 1, "Validación cancelable combo");
            }

            using (var etiqueta = new UsrLabelCompras())
            {
                int cambios = 0;
                etiqueta.TextChanged += (s, e) => cambios++;
                etiqueta.Texto = "Primero";
                Verificar(etiqueta.BackColor == TemaCompras.FondoGeneral, "Etiqueta normal sin naranja");
                etiqueta.BackColor = TemaCompras.FondoEtiquetasDestacadas;
                Verificar(etiqueta.Controls[0].BackColor == TemaCompras.FondoEtiquetasDestacadas, "Fondo destacado explícito");
                Verificar(etiqueta.Text == "Primero" && cambios == 1, "Alias de etiqueta");
                etiqueta.Text = "Segundo";
                Verificar(etiqueta.Texto == "Segundo" && cambios == 2, "Text de etiqueta");
                etiqueta.ColorTexto = Color.Blue;
                Verificar(etiqueta.ForeColor == Color.Blue, "Color de etiqueta");
                etiqueta.TextAlign = ContentAlignment.MiddleLeft;
                Verificar(etiqueta.AlineacionTexto == ContentAlignment.MiddleLeft, "Alineación");
                var asterisco = etiqueta.Controls.Find("ComprasLblAsterisco", true).Single();
                etiqueta.MostrarAsterisco = false;
                etiqueta.MostrarAsterisco = true;
                Verificar(asterisco.Parent != null, "Restaurar asterisco");
                etiqueta.MostrarAsterisco = false;
                etiqueta.Dispose();
                Verificar(asterisco.IsDisposed, "Liberar asterisco separado");
            }

            using (var form = new Form())
            using (var texto = new UsrTextBoxCompras())
            using (var tabla = new UsrDataGridViewCompras())
            using (var datos = new DataTable())
            {
                form.Controls.Add(texto);
                form.Controls.Add(tabla);
                form.ShowInTaskbar = false;
                form.StartPosition = FormStartPosition.Manual;
                form.Location = new Point(-10000, -10000);
                form.Show();
                form.CreateControl();
                var ventana = form.Handle;
                var entradaHandle = texto.Handle;
                var tablaHandle = tabla.Handle;
                form.BindingContext = new BindingContext();
                datos.Columns.Add("Nombre", typeof(string));
                datos.Rows.Add("Inicial");
                texto.DataBindings.Add("Text", datos, "Nombre", false, DataSourceUpdateMode.OnPropertyChanged);
                texto.DataBindings["Text"].ReadValue();
                Verificar(texto.Text == "Inicial", "Enlace de lectura de texto");
                texto.Text = "Actualizado";
                Verificar((string)datos.Rows[0]["Nombre"] == "Actualizado", "Enlace de escritura de texto");
                texto.Focus();
                Verificar(texto.Entrada.Focused, "Foco del editor");
                int validacionesTexto = 0;
                CancelEventHandler cancelar = (s, e) => { validacionesTexto++; e.Cancel = true; };
                texto.Validating += cancelar;
                Verificar(!form.ValidateChildren() && validacionesTexto == 1, "Validación cancelable de la entrada");
                texto.Validating -= cancelar;
                tabla.Focus();
                Verificar(tabla.Tabla.Focused, "Foco de tabla");
                int enlaces = 0;
                tabla.DataBindingComplete += (s, e) => enlaces++;
                tabla.DataSource = datos;
                Verificar(tabla.Tabla.ColumnHeadersDefaultCellStyle.BackColor == TemaCompras.PrincipalNavegador, "Encabezado tabla");
                Verificar(tabla.Tabla.DefaultCellStyle.SelectionBackColor == TemaCompras.AcentoNavegador && tabla.Tabla.DefaultCellStyle.SelectionForeColor == Color.White, "Selección legible");
                tabla.CreateControl();
                Verificar(tabla.Rows.Count == 1 && tabla.Columns.Count == 1 && enlaces > 0, "Enlace tabla");
                Verificar((string)tabla[0, 0].Value == "Actualizado", "Valor tabla");
                tabla.CurrentCell = tabla[0, 0];
                Verificar(tabla.CurrentRow.Index == 0, "Selección tabla");
                tabla.ClearSelection();
                Verificar(tabla.SelectedRows.Count == 0, "Limpiar selección tabla");
                int teclas = 0;
                ((Control)tabla).KeyDown += (s, e) => teclas++;
                Emitir(tabla.Tabla, "OnKeyDown", new KeyEventArgs(Keys.Enter));
                Verificar(teclas == 1, "Teclado mediante Control");
                int validaciones = 0;
                tabla.CellValidating += (s, e) => { validaciones++; e.Cancel = true; };
                var validacion = (DataGridViewCellValidatingEventArgs)Activator.CreateInstance(
                    typeof(DataGridViewCellValidatingEventArgs), BindingFlags.Instance | BindingFlags.NonPublic,
                    null, new object[] { 0, 0, "valor" }, null);
                typeof(DataGridView).GetMethod("OnCellValidating", BindingFlags.Instance | BindingFlags.NonPublic,
                    null, new[] { typeof(DataGridViewCellValidatingEventArgs) }, null)
                    .Invoke(tabla.Tabla, new object[] { validacion });
                Verificar(validaciones == 1 && validacion.Cancel, "Validación cancelable tabla");
                tabla.Enabled = false;
                Verificar(!tabla.Tabla.Enabled, "Habilitación tabla");
            }

            using (var surface = new DesignSurface(typeof(Form)))
            {
                var host = (IDesignerHost)surface.GetService(typeof(IDesignerHost));
                foreach (var tipo in tipos.Where(t => t.IsPublic))
                {
                    var control = (Control)host.CreateComponent(tipo, tipo.Name);
                    ((Form)host.RootComponent).Controls.Add(control);
                    Verificar(host.GetDesigner(control) != null, "Diseñador: " + tipo.Name);
                    if (control is UsrTextBoxCompras)
                    {
                        var propiedad = TypeDescriptor.GetProperties(control)["MostrarEtiquetaError"];
                        int altura = control.Height;
                        propiedad.SetValue(control, false);
                        Verificar(control.Height == altura - 30, "Ocultar espacio mediante propiedad del diseñador");
                        propiedad.SetValue(control, true);
                        Verificar(control.Height == altura, "Restaurar espacio mediante propiedad del diseñador");
                    }
                }
                Verificar(TypeDescriptor.GetProperties(typeof(UsrTextBoxCompras))["Text"].IsBrowsable, "Text en diseñador");
                Verificar(TypeDescriptor.GetProperties(typeof(UsrDataGridViewCompras))["Columns"].SerializationVisibility == DesignerSerializationVisibility.Content, "Serialización columnas");
            }
            if (args.Length > 0) Renderizar(args[0]);
            Console.WriteLine("Correcto: " + comprobaciones + " comprobaciones de componentes.");
            return 0;
        }
        catch (Exception e) { Console.Error.WriteLine(e); return 1; }
    }

    private static void Renderizar(string ruta)
    {
        using (var form = new Form { ClientSize = new Size(660, 400), BackColor = TemaCompras.FondoGeneral,
            ShowInTaskbar = false, StartPosition = FormStartPosition.Manual, Location = new Point(-10000, -10000) })
        {
            var titulo = new Label { Text = "Compras y cuentas por pagar", Dock = DockStyle.Top, Height = 40,
                BackColor = TemaCompras.PrincipalNavegador, ForeColor = Color.White, TextAlign = ContentAlignment.MiddleLeft };
            var etiqueta = new UsrLabelCompras { Location = new Point(20, 60), Texto = "Proveedor", MostrarAsterisco = true };
            var destacado = new UsrLabelCompras { Location = new Point(260, 60), Texto = "Pendiente de pago",
                MostrarAsterisco = false, BackColor = TemaCompras.FondoEtiquetasDestacadas };
            var entrada = new UsrTextBoxCompras { Location = new Point(20, 95), Text = "Proveedor de ejemplo" };
            var error = new UsrTextBoxCompras { Location = new Point(260, 95), Text = "" };
            error.ComprasMetMostrarError("Campo obligatorio");
            var boton = new ClsButtonCompras { Location = new Point(550, 60), Text = "Guardar" };
            var tabla = new UsrDataGridViewCompras { Location = new Point(20, 180), Size = new Size(610, 195) };
            tabla.Columns.Add("Documento", "Documento");
            tabla.Columns.Add("Estado", "Estado");
            tabla.Rows.Add("Factura 001", "Pendiente");
            tabla.Rows.Add("Factura 002", "Pagada");
            form.Controls.AddRange(new Control[] { titulo, etiqueta, destacado, entrada, error, boton, tabla });
            form.Show();
            tabla.CurrentCell = tabla[0, 0];
            Application.DoEvents();
            using (var bitmap = new Bitmap(form.ClientSize.Width, form.ClientSize.Height))
            {
                form.DrawToBitmap(bitmap, new Rectangle(Point.Empty, form.ClientSize));
                bitmap.Save(ruta, System.Drawing.Imaging.ImageFormat.Png);
            }
        }
    }
}
