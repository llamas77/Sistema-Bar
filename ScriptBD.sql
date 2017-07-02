CREATE TABLE Turnos (
	Id INT IDENTITY(1, 1),
	Hora_Inicio DATETIME,
	Hora_Fin DATETIME,
	Caja_Inicial DECIMAL(11, 2),
	Caja_Final DECIMAL(11, 2),
	CONSTRAINT Turnos_pk PRIMARY KEY (Id)
)

INSERT INTO Turnos (Hora_Inicio, Caja_Inicial) VALUES (getDate(), 200)
SELECT * FROM Turnos
DROP TABLE Turnos

CREATE TABLE Rubros(
	Id INT IDENTITY(1, 1),
	Nombre varchar(50) UNIQUE NOT NULL,
	CONSTRAINT Rubros_pk PRIMARY KEY(Id)
)

CREATE TABLE Articulos(
	Id INT,
	Id_Rubro INT,
	Nombre VARCHAR(50) NOT NULL,
	Precio_Lista DECIMAL(11, 2),
	Precio_Venta DECIMAL(11, 2),
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
	Precio_Lista DECIMAL(11, 2),
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
	Id INT,
	Id_Tipo_Cliente INT,
	Tipo_Doc_Cliente INT,
	Nro_Doc_Cliente INT,
	Fecha DATETIME DEFAULT getdate() NOT NULL,
	CONSTRAINT Ventas_pk PRIMARY KEY (Id),
	CONSTRAINT Ventas_fk_1 FOREIGN KEY(Id_Tipo_Cliente) REFERENCES Tipos_Cliente(Id),
	CONSTRAINT Ventas_fk_2 FOREIGN KEY (Tipo_Doc_Cliente, Nro_Doc_Cliente) REFERENCES Clientes(Id_TipoDoc, Nro_Doc)
)

CREATE TABLE Detalles_Ventas(
	Id_Articulo INT,
	Id_Venta INT,
	Cantidad INT,
	Precio_Venta DECIMAL(11, 2),
	CONSTRAINT Detalles_Ventas_pk PRIMARY KEY(Id_Articulo, Id_Venta),
	CONSTRAINT Detalles_Ventas_fk_1 FOREIGN KEY (Id_Articulo) REFERENCES Articulos (Id),
	CONSTRAINT Detalles_Ventas_fk_2 FOREIGN KEY (Id_Venta) REFERENCES Ventas (Id) ON DELETE CASCADE
)


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