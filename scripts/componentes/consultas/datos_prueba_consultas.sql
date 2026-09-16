-- ============================================================================
--  Datos de prueba para el Componente Consultas
--  Proyecto ERP "Embutidos de Calidad, S.A."  |  Terminus, S.A.
--  José Pablo Cano Cóbar - carné 0901-23-1727 - 16/09/26
--
--  USO LOCAL. Este archivo NO se commitea al repositorio salvo que el equipo
--  lo apruebe. Sirve para poder demostrar el filtrado de la Consulta Simple
--  mientras la tabla real sigue vacía.
--
--  Ejecutar en MySQL Workbench, o desde consola:
--      mysql -u USUARIO -p < datos_prueba_consultas.sql
-- ============================================================================

USE dbConsulta;

-- Deja la tabla en un estado conocido antes de insertar.
-- Si ya tienes registros reales que quieras conservar, COMENTA estas 3 líneas.
SET FOREIGN_KEY_CHECKS = 0;
TRUNCATE TABLE tblConsulta;
SET FOREIGN_KEY_CHECKS = 1;

INSERT INTO tblConsulta (nombreConsulta, aplicacionConsulta, queryConsulta) VALUES
-- Compras y Cuentas por Pagar
('Ordenes de compra pendientes',        'Compras',       'SELECT * FROM tblOrdenCompra WHERE estado = ''P'''),
('Ordenes de compra del mes',           'Compras',       'SELECT * FROM tblOrdenCompra WHERE MONTH(fecha) = MONTH(CURDATE())'),
('Proveedores activos',                 'Compras',       'SELECT * FROM tblProveedor WHERE activo = 1'),
('Antiguedad de saldos por proveedor',  'CuentasPagar',  'SELECT proveedor, SUM(saldo) FROM tblCuentaPagar GROUP BY proveedor'),
('Facturas vencidas',                   'CuentasPagar',  'SELECT * FROM tblFactura WHERE fechaVence < CURDATE()'),
('Pagos programados',                   'CuentasPagar',  'SELECT * FROM tblPago WHERE estado = ''PROGRAMADO'''),

-- Inventario y Produccion
('Existencias bajo minimo',             'Inventario',    'SELECT * FROM tblProducto WHERE existencia < minimo'),
('Movimientos de bodega',               'Inventario',    'SELECT * FROM tblMovimiento ORDER BY fecha DESC'),
('Lotes de embutidos por vencer',       'Produccion',    'SELECT * FROM tblLote WHERE fechaVence <= DATE_ADD(CURDATE(), INTERVAL 30 DAY)'),
('Rendimiento de produccion diario',    'Produccion',    'SELECT fecha, SUM(kilos) FROM tblProduccion GROUP BY fecha'),

-- Ventas y Recursos Humanos
('Ventas por vendedor',                 'Ventas',        'SELECT vendedor, SUM(total) FROM tblVenta GROUP BY vendedor'),
('Clientes sin compras recientes',      'Ventas',        'SELECT * FROM tblCliente WHERE ultimaCompra < DATE_SUB(CURDATE(), INTERVAL 90 DAY)'),
('Planilla quincenal',                  'RecursosHum',   'SELECT * FROM tblEmpleado WHERE tipoPago = ''QUINCENAL'''),
('Empleados por departamento',          'RecursosHum',   'SELECT departamento, COUNT(*) FROM tblEmpleado GROUP BY departamento'),

-- Casos especiales para probar el escape de comodines de LIKE.
-- Si el escape funciona, buscar "100%" con Contiene devuelve SOLO la primera
-- de estas dos filas. Si estuviera roto, devolvería muchas más o ninguna.
('Descuento 100% aplicado',             'Ventas',        'SELECT * FROM tblVenta WHERE descuento = 100'),
('Reporte_mensual consolidado',         'Contabilidad',  'SELECT * FROM tblAsiento WHERE periodo = MONTH(CURDATE())');

-- ============================================================================
--  PRUEBAS SUGERIDAS EN EL FORMULARIO 4001 - ConsultasSimples
-- ============================================================================
--
--  1. Campo: aplicacionConsulta | Operador: =            | Valor: Compras
--     Esperado: 3 registros
--
--  2. Campo: nombreConsulta     | Operador: Contiene     | Valor: proveedor
--     Esperado: 2 registros (Proveedores activos, Antiguedad de saldos)
--
--  3. Campo: nombreConsulta     | Operador: Comienza con | Valor: Ordenes
--     Esperado: 2 registros
--
--  4. Campo: Pk_Consulta        | Operador: >=           | Valor: 10
--     Esperado: 7 registros
--
--  5. Campo: nombreConsulta     | Operador: Contiene     | Valor: 100%
--     Esperado: 1 registro. Esta es la prueba del escape de comodines:
--     sin el escape, el % se interpretaria como comodin y devolveria
--     todas las filas que contengan "100".
--
--  6. Campo: nombreConsulta     | Operador: Contiene     | Valor: Reporte_
--     Esperado: 1 registro. El guion bajo tambien es comodin en LIKE
--     (equivale a un caracter cualquiera) y tambien debe ir escapado.
--
--  7. Campo: aplicacionConsulta | Operador: =            | Valor: Logistica
--     Esperado: 0 registros y el mensaje "Ningun registro cumple con el filtro"
--
-- ============================================================================

SELECT COUNT(*) AS 'Registros insertados' FROM tblConsulta;
