CREATE DATABASE BD_Biblioteca;
GO

USE BD_Biblioteca;
GO

CREATE TABLE Libros(
    Id INT PRIMARY KEY IDENTITY(1,1),
    Titulo VARCHAR(100),
    Autor VARCHAR(100),
    AnioPublicacion INT,
    Disponible BIT
);
GO