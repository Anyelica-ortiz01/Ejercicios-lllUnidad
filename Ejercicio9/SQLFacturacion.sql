CREATE DATABASE BD_Facturacion;
GO

USE BD_Facturacion;
GO

CREATE TABLE Facturas(
    Id INT PRIMARY KEY IDENTITY(1,1),
    Cliente VARCHAR(100),
    Fecha DATETIME
);

CREATE TABLE DetalleFactura(
    Id INT PRIMARY KEY IDENTITY(1,1),
    FacturaId INT,
    Producto VARCHAR(100),
    Cantidad INT,
    Precio DECIMAL(10,2),

    FOREIGN KEY(FacturaId) REFERENCES Facturas(Id)
);