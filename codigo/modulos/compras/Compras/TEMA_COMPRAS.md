# Tema de Compras y cuentas por pagar

La paleta se define en `CapaVista_Compras/TemaCompras.cs`. No había mecanismo de temas
previo: los colores estaban en constructores, diseñadores y métodos de cambio de estado.
Los resx solo contienen sus cabeceras; las muestras de colores dentro de comentarios
XML no son recursos aplicados a controles.

| Definición | Uso |
| --- | --- |
| PrincipalNavegador (#1E2A5A) | Navegación en reposo, encabezados de tabla, texto sobre fondos claros, bordes |
| AcentoNavegador (#3D56A6) | Navegación activa y hover, selección de filas y encabezados, foco de entrada |
| FondoEtiquetasDestacadas (#D9913E) | Fondo optativo de distintivos y etiquetas destacadas, con texto principal |
| FondoGeneral (#F6F7FA) | Contenedores, control base, etiquetas normales, entrada y área de tabla |
| FondoBotones (#D5DCEF) | Botones estándar y navegación deshabilitada; separadores de tabla |

BotonHover y BotonPresionado se derivan mezclando el fondo de botones con el acento
al 20 % y 35 %. Así mantienen contraste con el texto principal. Los botones conservan
el renderizado nativo de deshabilitado, los iconos y la imagen deshabilitada personalizada.
El botón estándar añade un borde de foco, sin cambiar dimensiones ni posiciones.
Los controles nativos ComboBox, GroupBox y RadioButton conservan sus indicadores
de selección, foco y deshabilitado del sistema.

Se actualizaron los constructores y diseñadores de Button, ComboBox, GroupBox,
RadioButton, Panel, TableLayoutPanel, TableButton, UsrBase, UsrLabel, UsrTextBox y
UsrDataGridView. El dibujo de hover de tabla sigue usando los estilos de selección
configurables. Los errores, su borde y el asterisco obligatorio conservan el rojo;
al limpiar el error se recupera el borde principal o de foco.

La solución `Compras.sln` no contiene formularios, navegador o menús implementados.
Por tanto no hay formularios de producto que actualizar o ejecutar. Los componentes
y el control base quedan preparados con el tema. No se colorearon todas las etiquetas
de naranja: no existen distintivos destacados en el producto actual. Para uno nuevo,
asignar BackColor = TemaCompras.FondoEtiquetasDestacadas y
ForeColor = TemaCompras.PrincipalNavegador. UsrLabel propaga ese fondo a su contenedor
interno y mantiene configurables ColorTexto y AlineacionTexto.

La entrada propaga BackColor y ForeColor al editor; las personalizaciones explícitas
de texto, fondo y estilos específicos de la tabla siguen disponibles. No se aplica
un recoloreado global en cada evento que destruya los colores funcionales del consumidor.

## Comprobaciones

MSBuild: Debug y Release de los tres proyectos, sin errores ni advertencias.
`Validacion/ValidarComponentes.ps1`: 82 comprobaciones de compatibilidad y tema,
incluidos los cinco colores exactos, estados de navegación, estilos de selección,
colores del editor interno, apariencia explícita de botones y fondo destacado optativo.
También pasan las comprobaciones de enlace de datos, eventos, foco, validación cancelable,
recursos y creación de los diseñadores mediante DesignSurface.

Para repetir y generar una muestra de QA:

```powershell
./Compras/Validacion/ValidarComponentes.ps1 -Imagen "$PWD/Compras/Validacion/TemaCompras.png"
```

Se inspeccionó la imagen DrawToBitmap de una muestra temporal: encabezado oscuro,
selección con texto blanco, botón claro, etiquetas normales y destacado optativo.
Limitación de esa imagen: WinForms DrawToBitmap no dibuja correctamente RichTextBox;
su texto y superficie requieren inspección visual interactiva. Sus propiedades sí se
comprobaron en ejecución. También queda pendiente abrir el diseñador de Visual Studio
y revisar manualmente iconos reales y navegación con teclado físico; no hay formularios
de producto ni iconos asignados disponibles para esa revisión.
