--//VISTAS//
IF OBJECT_ID('VISTA_ANIMALES') IS NOT NULL DROP VIEW VISTA_ANIMALES
IF OBJECT_ID('VISTA_ARTICULOS') IS NOT NULL DROP VIEW VISTA_ARTICULOS
IF OBJECT_ID('VISTA_CLIENTES') IS NOT NULL DROP VIEW VISTA_CLIENTES
IF OBJECT_ID('VISTA_EXCEPCIONES') IS NOT NULL DROP VIEW VISTA_EXCEPCIONES
IF OBJECT_ID('VISTA_MARCAS') IS NOT NULL DROP VIEW VISTA_MARCAS
IF OBJECT_ID('VISTA_PRODUCTOS') IS NOT NULL DROP VIEW VISTA_PRODUCTOS
IF OBJECT_ID('VISTA_TIPOPRODUCTOS') IS NOT NULL DROP VIEW VISTA_TIPOPRODUCTOS
IF OBJECT_ID('VISTA_VENTAS') IS NOT NULL DROP VIEW VISTA_VENTAS
IF OBJECT_ID('VISTA_DETALLES') IS NOT NULL DROP VIEW VISTA_DETALLES
GO
CREATE VIEW VISTA_ANIMALES AS
	SELECT cod_animal, descripcion_corta as 'animales.descripcion_corta', descripcion_larga as 'animales.descripcion_larga'
	FROM Animales
GO
CREATE VIEW VISTA_ARTICULOS AS
	SELECT *
	FROM Articulos;
GO
CREATE VIEW VISTA_CLIENTES AS
	SELECT *
	FROM Clientes;
GO
CREATE VIEW VISTA_EXCEPCIONES AS
	SELECT *
	FROM Excepciones_Ventas;
GO
CREATE VIEW VISTA_MARCAS AS
	SELECT cod_marca, descripcion_corta as 'marcas.descripcion_corta', descripcion_larga as 'marcas.descripcion_larga'
	 FROM Marcas
GO
CREATE VIEW VISTA_PRODUCTOS AS
	SELECT pro.cod_producto, pro.nombre_producto, pro.fecha_ingreso, PRO.fecha_modificacion, pro.stock_limite, pro.habilitado,
	ani.cod_animal, ani.descripcion_corta as 'animales.descripcion_corta', ani.descripcion_larga as 'animales.descripcion_larga',
	mar.cod_marca, mar.descripcion_corta as 'marcas.descripcion_corta', mar.descripcion_larga as 'marcas.descripcion_larga',
	tip.cod_tipoproducto, tip.descripcion_corta as 'tipoproductos.descripcion_corta', tip.descripcion_larga as 'tipoproductos.descripcion_larga'
	FROM PRODUCTOS pro, Marcas mar, TipoProductos tip, Animales ani
	WHERE mar.cod_marca = pro.cod_animal AND tip.cod_tipoproducto = pro.cod_tipoproducto AND
	 ani.cod_animal = pro.cod_animal;
GO
CREATE VIEW VISTA_TIPOPRODUCTOS AS
	SELECT cod_tipoproducto, descripcion_corta as'tipoproductos.descripcion_corta', descripcion_larga as 'tipoproductos.descripcion_larga'
	FROM TipoProductos
GO
CREATE VIEW VISTA_VENTAS AS
	SELECT *
	FROM Ventas;
GO
CREATE VIEW VISTA_DETALLES AS
	SELECT *
	FROM Ventas_Detalles






-- P R O C E D I M I E N T O S
GO
IF OBJECT_ID('LEER_ANIMALES') IS NOT NULL DROP PROCEDURE LEER_ANIMALES
GO
CREATE PROCEDURE LEER_ANIMALES AS
BEGIN
	SELECT * FROM VISTA_ANIMALES;
END
GO

IF OBJECT_ID('LEER_ARTICULOS') IS NOT NULL DROP PROCEDURE LEER_ARTICULOS
GO
CREATE PROCEDURE LEER_ARTICULOS AS
BEGIN
	SELECT * FROM VISTA_ARTICULOS;
END
GO

IF OBJECT_ID('LEER_CLIENTES') IS NOT NULL DROP PROCEDURE LEER_CLIENTES
GO
CREATE PROCEDURE LEER_CLIENTES AS
BEGIN
	SELECT * FROM VISTA_CLIENTES;
END
GO

IF OBJECT_ID('LEER_EXCEPCIONES') IS NOT NULL DROP PROCEDURE LEER_EXCEPCIONES
GO
CREATE PROCEDURE LEER_EXCEPCIONES AS
BEGIN
	SELECT * FROM VISTA_EXCEPCIONES;
END
GO

GO
IF OBJECT_ID('LEER_MARCAS') IS NOT NULL DROP PROCEDURE LEER_MARCAS
GO
CREATE PROCEDURE LEER_MARCAS AS
BEGIN
	SELECT * FROM VISTA_MARCAS;
END
GO

IF OBJECT_ID('LEER_PRODUCTOS') IS NOT NULL DROP PROCEDURE LEER_PRODUCTOS
GO
CREATE PROCEDURE LEER_PRODUCTOS AS
BEGIN
	SELECT * FROM VISTA_PRODUCTOS
END

GO
IF OBJECT_ID('LEER_TIPOPRODUCTOS') IS NOT NULL DROP PROCEDURE LEER_TIPOPRODUCTOS
GO
CREATE PROCEDURE LEER_TIPOPRODUCTOS AS
BEGIN
	SELECT * FROM VISTA_TIPOPRODUCTOS;
END
GO

IF OBJECT_ID('LEER_VENTAS') IS NOT NULL DROP PROCEDURE LEER_VENTAS
GO
CREATE PROCEDURE LEER_VENTAS AS
BEGIN
	SELECT * FROM VISTA_VENTAS;
END
GO

IF OBJECT_ID('LEER_DETALLES') IS NOT NULL DROP PROCEDURE LEER_DETALLES
GO
CREATE PROCEDURE LEER_DETALLES AS
BEGIN
	SELECT * FROM VISTA_DETALLES;
END
GO
-- //// LEER_BYID
IF OBJECT_ID('PRODUCTOBY_COD') IS NOT NULL DROP PROCEDURE PRODUCTOBY_COD
GO
CREATE PROCEDURE PRODUCTOBY_COD (@cod as char(6)) AS
BEGIN
	SELECT COUNT(*) FROM Productos
	WHERE cod_producto = @cod;
END
GO


IF OBJECT_ID('PRODUCTO_ADD') IS NOT NULL DROP PROCEDURE PRODUCTO_ADD
GO
CREATE PROCEDURE PRODUCTO_ADD (@codproducto as char(6), @codmarca as char(6),
@codtipoproducto as char(4), @codanimal as char(4), @nombre as varchar(50),
@ingreso as datetime, @modificacion as datetime, @stock as float,
@habilitado as bit) AS
BEGIN
	INSERT INTO Productos (cod_producto, cod_marca, cod_tipoproducto, cod_animal, nombre_producto,
	fecha_ingreso, fecha_modificacion, stock_limite, habilitado)
	VALUES (@codproducto, @codmarca, @codtipoproducto, @codanimal, @nombre, @ingreso,
	@modificacion, @stock, @habilitado)
END
GO


