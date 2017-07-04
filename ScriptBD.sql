CREATE TABLE Turnos (
	Id INT IDENTITY(1, 1),
	Hora_Inicio DATETIME,
	Hora_Fin DATETIME,
	Caja_Inicial DECIMAL(11, 2),
	Caja_Final DECIMAL(11, 2),
	CONSTRAINT Turnos_pk PRIMARY KEY (Id)
)

CREATE TABLE Rubros(
	Id INT IDENTITY(1, 1),
	Nombre varchar(50) UNIQUE NOT NULL,
	CONSTRAINT Rubros_pk PRIMARY KEY(Id)
)

CREATE TABLE Articulos(
	Id INT,
	Id_Rubro INT,
	Nombre VARCHAR(50) NOT NULL,
	Precio_Lista DECIMAL(13, 4),
	Precio_Venta DECIMAL(13, 4),
	Stock int,
	CONSTRAINT Articulos_pk PRIMARY KEY (Id),
	CONSTRAINT Articulos_fk FOREIGN KEY (Id_Rubro) REFERENCES Rubros (id)
)

CREATE TABLE Tipos_Gasto (
	Id INT IDENTITY (1, 1),
	Nombre VARCHAR(50),
	CONSTRAINT TiposGasto_pk PRIMARY KEY (Id)
)

CREATE TABLE Gastos (
	Id INT IDENTITY (1, 1),
	Id_TipoGasto INT,
	Monto DECIMAL(11, 2),
	Descripcion VARCHAR(150),
	Fecha DATETIME DEFAULT getDate() NOT NULL,
	CONSTRAINT Gastos_pk PRIMARY KEY(Id),
	CONSTRAINT Gastos_fk FOREIGN KEY(Id_TipoGasto) REFERENCES Tipos_Gasto(Id)
)

CREATE TABLE Proveedores(
	Id int identity(1, 1),
	Nombre varchar(200) UNIQUE NOT NULL,
	CONSTRAINT Proveedores_pk PRIMARY KEY(Id)
)

CREATE TABLE Compras(
	Id INT IDENTITY(1, 1),
	Fecha DATETIME DEFAULT getDate() NOT NULL,
	Id_Proveedor INT,
	CONSTRAINT Compras_pk PRIMARY KEY (Id),
	CONSTRAINT Compras_fk FOREIGN KEY (Id_Proveedor) REFERENCES Proveedores(Id)
)

CREATE TABLE Detalles_Compras(
	Id_Articulo INT,
	Id_Compra INT,
	Cantidad INT,
	Precio_Lista DECIMAL(13, 4),
	CONSTRAINT Detalles_Compras_pk PRIMARY KEY(Id_Articulo, Id_Compra),
	CONSTRAINT Detalles_Compras_fk_1 FOREIGN KEY(Id_Articulo) REFERENCES Articulos (Id),
	CONSTRAINT Detalles_Compras_fk_2 FOREIGN KEY (Id_Compra) REFERENCES Compras(Id) ON DELETE CASCADE
)

CREATE TABLE Tipos_Doc (
	Id INT IDENTITY(1, 1),
	Nombre VARCHAR(50) NOT NULL,
	CONSTRAINT TiposDoc_pk PRIMARY KEY (Id)
)

CREATE TABLE Tipos_Cliente (
	Id INT IDENTITY(1, 1),
	Nombre VARCHAR(50) NOT NULL,
	AlCosto BIT,
	CONSTRAINT TiposCliente_pk PRIMARY KEY (Id)
)

CREATE TABLE Clientes (
	Id_TipoDoc INT,
	Nro_Doc INT,
	Id_TipoCliente INT,
	Nombre VARCHAR(50),
	Apellido VARCHAR(50),
	Fecha_Alta DATE DEFAULT getDate() NOT NULL,
	CONSTRAINT Clientes_pk PRIMARY KEY (Id_TipoDoc, Nro_Doc),
	CONSTRAINT Clientes_fk1 FOREIGN KEY (Id_TipoCliente) REFERENCES Tipos_Cliente(Id),
	CONSTRAINT Clientes_fk2 FOREIGN KEY (Id_TipoDoc) REFERENCES Tipos_Doc(Id)
)

CREATE TABLE Ventas(
	Id INT IDENTITY(1, 1),
	Tipo_Doc_Cliente INT,
	Nro_Doc_Cliente INT,
	Fecha DATETIME DEFAULT getdate() NOT NULL,
	AlCosto BIT,
	Descuento DECIMAL(11, 2),
	Realizada BIT,
	CONSTRAINT Ventas_pk PRIMARY KEY (Id),
	CONSTRAINT Ventas_fk FOREIGN KEY (Tipo_Doc_Cliente, Nro_Doc_Cliente) REFERENCES Clientes(Id_TipoDoc, Nro_Doc)
)

CREATE TABLE Detalles_Ventas(
	Id_Articulo INT,
	Id_Venta INT,
	Cantidad INT,
	Precio DECIMAL(13, 4),
	CONSTRAINT Detalles_Ventas_pk PRIMARY KEY(Id_Articulo, Id_Venta),
	CONSTRAINT Detalles_Ventas_fk_1 FOREIGN KEY (Id_Articulo) REFERENCES Articulos (Id),
	CONSTRAINT Detalles_Ventas_fk_2 FOREIGN KEY (Id_Venta) REFERENCES Ventas (Id) ON DELETE CASCADE
)

CREATE TABLE Extras (
	Id INT,
	Descuento DECIMAL(11, 2)
	CONSTRAINT Extras_pk PRIMARY KEY (Id)
)

INSERT INTO Extras VALUES(1, 0.33)

SELECT c.Fecha, p.Nombre, a.Id, a.Nombre, SUM(dc.Cantidad * dc.Precio_Lista) as 'Total' FROM Compras c JOIN Proveedores p ON (c.Id_Proveedor = p.Id) 
	JOIN Detalles_Compras dc ON (c.Id = dc.Id_Compra) JOIN Articulos a ON (dc.Id_Articulo = a.Id) 
	GROUP BY c.Fecha, p.Nombre, a.Id, a.Nombre

--DROP TABLE Detalles_Compras
--DROP TABLE Compras
--DROP TABLE Proveedores

--DROP TABLE Detalles_Ventas
--DROP TABLE Ventas


--DROP TABLE Articulos
--DROP TABLE Rubros

--DROP TABLE Turnos
--DROP TABLE Gastos
--DROP TABLE Tipos_Gasto

--DROP TABLE Clientes
--DROP TABLE Tipos_Cliente
--DROP TABLE Tipos_Doc

