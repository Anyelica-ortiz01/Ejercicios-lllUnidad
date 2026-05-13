CREATE DATABASE BD_Estudiantes;
GO

USE BD_Estudiantes;
GO

CREATE TABLE Estudiantes(
    Id INT PRIMARY KEY IDENTITY(1,1),
    Nombre VARCHAR(100),
    Carrera VARCHAR(100),
    Promedio DECIMAL(4,2)
);
GO