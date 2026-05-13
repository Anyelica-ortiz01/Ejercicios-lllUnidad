CREATE DATABASE BD_Productos;
GO

USE BD_Productos;
GO

CREATE TABLE Productos(
    Id INT PRIMARY KEY IDENTITY(1,1),
    Nombre VARCHAR(100),
    Precio DECIMAL(10,2),
    Stock INT
);