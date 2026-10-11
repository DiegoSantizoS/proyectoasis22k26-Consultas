# Migración de componentes

Origen: `codigo/componentes/consultas/Consultas/CapaVista_Consultas/Componentes`.
La carpeta `compras/Componentes` contiene una copia idéntica de sus 25 archivos,
verificada mediante SHA-256 antes de migrar. Ambas se conservan intactas.
No se encontraron instrucciones AGENTS.md en el árbol inspeccionado ni sus ancestros.

Destino: `CapaVista_Compras/Componentes`, C#, WinForms, .NET Framework 4.8.
Se mantiene el prefijo Cls/Usr y se sustituye el sufijo y prefijo Consultas por Compras
en clases, miembros propios, nombres de controles, namespaces, archivos y recursos.

| Anterior → nuevo (Consultas → Compras) | Base / función |
| --- | --- |
| ClsActualizacionDisenoConsultas → ClsActualizacionDisenoCompras | IDisposable; suspensión y restauración del diseño |
| ClsButtonConsultas → ClsButtonCompras | Button; imagen al deshabilitar |
| ClsComboBoxConsultas → ClsComboBoxCompras | ComboBox; selección y estilo |
| ClsEtiquetaConsultas → ClsEtiquetaCompras | Label; texto rojo aun deshabilitado, dependencia interna |
| ClsGroupBoxConsultas → ClsGroupBoxCompras | GroupBox; estilo |
| ClsPanelConsultas → ClsPanelCompras | Panel; doble buffer |
| ClsRadioButtonConsultas → ClsRadioButtonCompras | RadioButton; estilo |
| ClsTableButtonConsultas → ClsTableButtonCompras | Button; estado activo y hover |
| ClsTableLayoutPanelConsultas → ClsTableLayoutPanelCompras | TableLayoutPanel; doble buffer y actualización visual |
| UsrBaseConsultas → UsrBaseCompras | UserControl; escalado y tamaño para controles derivados |
| UsrTextBoxConsultas → UsrTextBoxCompras | UserControl que encapsula RichTextBox y etiqueta de error |
| UsrLabelConsultas → UsrLabelCompras | UserControl que encapsula Label y asterisco |
| UsrDataGridViewConsultas → UsrDataGridViewCompras | UserControl que encapsula DataGridView con borde |

No implementan interfaces adicionales. Se incluyen todas las clases parciales,
sus siete diseñadores y cinco recursos resx. Se mantienen las visibilidades originales.
Los únicos ensamblados añadidos son System.Drawing y System.Windows.Forms.
El panel conserva las llamadas nativas a user32.dll; no se requieren paquetes externos.

## Compatibilidad

Se revisaron los consumidores de Consultas: UsrConsultasSimples, UsrConsultasComplejas,
UsrTabla y ClsConvertidorControlRetornoConsultas, además de sus diseñadores.
Usan texto, longitud máxima, eventos de teclado, selección y edición del RichTextBox,
mensajes de error, etiquetas con asterisco, DataSource, columnas, selección y eventos
de tabla. La API existente conserva esas funciones con los nombres de Compras.

Las envolturas conservan la composición para mantener el borde, el error y el asterisco.
No son asignables a RichTextBox, Label ni DataGridView. Cuando se necesita el control
nativo se dispone de Entrada (RichTextBox) o Tabla (DataGridView); los eventos específicos
delegados de Tabla y TextoKeyDown conservan como remitente el control interno.
Los eventos estándar de teclado se propagan mediante OnKeyDown/OnKeyPress/OnKeyUp,
también para consumidores declarados como Control, conservando los argumentos cancelables.

La entrada expone selección, edición, ReadOnly, Multiline y MaxLength, sincroniza
fuente/color y CausesValidation, y redirige el foco al editor. TextChanged se emite
una sola vez por cambio, incluso antes de crear el handle; Text es enlazable y visible
en el diseñador. La entrada comienza sin un mensaje de error ficticio; editar limpia
el error mostrado. La validación del UserControl y la habilitación se conservan.

La etiqueta unifica Text/Texto y ForeColor/ColorTexto, conserva AlineacionTexto y expone
TextAlign, propaga cambios de fuente y clics, y libera el asterisco aunque se haya
quitado temporalmente de Controls. El texto predeterminado pasa a Label de Compras.

La tabla mantiene enlace, edición, selección, altura de filas, hover y API delegada;
Columns permite serialización de contenido en el diseñador y el foco se dirige a Tabla.
Las propiedades de estilo específicas siguen disponibles mediante Tabla.

La solución Compras solo tenía proyectos vacíos y AssemblyInfo; no había formularios
ni consumidores que actualizar. Form1 en Ejecucion_Compras también es un formulario vacío
sin referencias a componentes. No se añadieron formularios o lógica de negocio ajenos
a esta migración ni referencias innecesarias entre proyectos.

## Validación reproducible

Ejecutar en Windows con Visual Studio/MSBuild y .NET Framework 4.8:

```powershell
powershell -NoProfile -ExecutionPolicy Bypass -File Compras/Validacion/ValidarComponentes.ps1
```

La prueba STA verifica inventario, creación de controles y handles, recursos incrustados,
notificaciones de texto antes/después del handle, selección, teclado y cancelación,
enlace de texto en ambas direcciones, enlace/selección/validación de tabla, foco,
habilitación, mensajes de error, liberación del asterisco y creación de diseñadores
mediante DesignSurface/IDesignerHost. Abre brevemente un formulario fuera de la pantalla
para activar el ciclo real de WinForms. Los binarios de prueba se generan en un directorio
temporal y se eliminan al terminar.

Pendiente: inspección visual interactiva del diseñador de Visual Studio y prueba manual
de navegación con teclado físico. DesignSurface valida la creación programática de los
diseñadores, pero no sustituye esa inspección visual. No hay formularios de Compras
implementados para validar flujos de negocio.
