CREATE DATABASE BD_Medico;
GO

USE BD_Medico;
GO

CREATE TABLE Pacientes(
    Id INT PRIMARY KEY IDENTITY(1,1),
    Nombre VARCHAR(100),
    Edad INT,
    Diagnostico VARCHAR(200)
);