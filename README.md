# pruebatele

CREATE TABLE Productos(
	id int IDENTITY(1,1) NOT NULL,
	Nombre varchar(100) NOT NULL,
	IDProvedor int NOT NULL,
	IDTipo int NOT NULL,
	Cantidad int NOT NULL,
	Fecha DATE NOT NULL,
	Modelo varchar(20) NOT NULL,
	Marca varchar(30) NOT NULL,
	PRIMARY KEY(id)
);

CREATE TABLE cat_provedores(
	id int IDENTITY(1,1) NOT NULL,
	Nombre varchar(100) NOT NULL,
	RFC varchar(13) NOT NULL,
	PRIMARY KEY(id)
);

CREATE TABLE cat_TipoProducto(
	id int IDENTITY(1,1) NOT NULL,
	Nombre varchar(50) NOT NULL,
	PRIMARY KEY(id)
);


pruebatele
