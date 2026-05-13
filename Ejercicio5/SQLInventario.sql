CREATE DATABASE BD_Inventario;
GO

USE BD_Inventario;
GO

CREATE TABLE Inventario(
    Id INT PRIMARY KEY IDENTITY(1,1),
    Producto VARCHAR(100),
    Categoria VARCHAR(100),
    Cantidad INT,
    PrecioCompra DECIMAL(10,2)
);
GO