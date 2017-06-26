CREATE TABLE [dbo].Facturas
(
    [Id] INT NOT NULL IDENTITY(1,1),
	CONSTRAINT [PK_Facturas] PRIMARY KEY ([Id]),
    datFecha datetime NOT NULL,
    Total numeric(10,2) NOT NULL,
	NombredelCliente varchar(255),
);

CREATE TABLE [dbo].Articulos
(
    [Id] INT NOT NULL IDENTITY(1,1),
	CONSTRAINT [PK_Articulos] PRIMARY KEY ([Id]),
    Codigo varchar(255) NOT NULL,
    Descripcion varchar(255) NOT NULL,
	Precio numeric(8,2),
);

CREATE TABLE [dbo].DetalleFacturas
(
    [Id] INT NOT NULL IDENTITY(1,1),
	CONSTRAINT [PK_DetalleFacturas] PRIMARY KEY ([Id]),
	IdFactura int not null, 
	CONSTRAINT [FK_Facturas] FOREIGN KEY ([IdFactura])
    REFERENCES [Facturas] ([Id]),
    datFecha datetime NOT NULL,
	IdArticulo int not null, 
	CONSTRAINT [FK_Articuos] FOREIGN KEY ([IdArticulo])
    REFERENCES [Articulos] ([Id]),
    Cantidad int NOT NULL,
	Precio numeric(8,2),
);