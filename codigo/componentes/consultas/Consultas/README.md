# Persona 3 — Consultas Simples

Paquete parcial de revisión y trabajo. Contiene Consultas.sln y los tres proyectos originales con únicamente los tipos asignados a esta persona y la infraestructura necesaria. No es una solución autónoma completa.

## Responsabilidad

Captura de filtros simples, validación, búsqueda y coordinación de la selección.

## Clases e interfaces incluidas

| Tipo | Archivo principal |
| --- | --- |
| `ClsControladorConsultasSimples` | `CapaControlador_Consultas/ClsControladorConsultasSimples.cs` |
| `UsrConsultasSimples` | `CapaVista_Consultas/UsrConsultasSimples.cs` |

Cada formulario y UserControl conserva sus archivos Designer y resx existentes junto al archivo principal. Código, namespaces y recursos se copiaron sin alterarlos.

## Dependencias

Módulo 1: motor, entidades y contexto. Módulo 5: controles, resultados y presentación de errores. Módulo 6: fachada compatible y alojamiento/configuración.

Las referencias originales entre capas y a bibliotecas externas se conservan. Los HintPath de las DLL entre capas apuntan a bin/$(Configuration), como en la solución completa. No se incluyen DLL precompiladas, stubs, implementaciones ficticias ni código de otras personas para resolver dependencias. Los errores de compilación por tipos o dependencias ausentes son esperados.

## Estructura e infraestructura

Vista utiliza Componentes y la raíz; Modelo utiliza Contratos, Entidades y Repositorios; Controlador mantiene sus clases en la raíz. Los tres proyectos se conservan aunque una capa solo contenga metadatos de ensamblado. Se incluyen las carpetas permitidas vacías cuando no hay tipos asignados.

Properties contiene AssemblyInfo.cs en los tres proyectos como infraestructura mínima, incluso en las capas sin clases funcionales asignadas. Los recursos compartidos de Properties de Vista están asignados al paquete de la persona 5; los recursos propios de cada familia visual están en su paquete correspondiente.

Se excluyen bin, obj, .vs, Git y archivos temporales.

## Integración y pruebas

Los cambios deben integrarse en la solución completa para compilar y probar con todos los módulos y el consumidor. Estos paquetes no habilitan pruebas independientes del diseñador ni de la base de datos.

**No reemplazar los .csproj ni Consultas.sln de la solución completa con los de este paquete parcial.** Sus inclusiones están recortadas exclusivamente para la entrega. Integrar únicamente los cambios a archivos de código, Designer y recursos que correspondan, y coordinar cambios de contratos con sus propietarios. Si se crean archivos nuevos, registrarlos en los proyectos completos sin copiar los proyectos parciales.

## Contraste de distribución

El documento de arquitectura no está presente actualmente en la solución original. Se contrastó esta distribución con su último inventario disponible y los archivos actuales; las ubicaciones del inventario antiguo se sustituyen por las rutas actuales de esta tabla. No hubo clases eliminadas o renombradas respecto a la lista solicitada.
