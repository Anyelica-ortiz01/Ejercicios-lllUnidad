CREATE DATABASE BD_Clientes;
GO

USE BD_Clientes;
GO

CREATE TABLE Clientes(
    Id INT PRIMARY KEY IDENTITY(1,1),
    Nombre VARCHAR(100),
    Telefono VARCHAR(20),
    Correo VARCHAR(100)
);