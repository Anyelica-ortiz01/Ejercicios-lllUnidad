CREATE DATABASE SistemaEmpleadosDB;
go

USE SistemaEmpleadosDB;
go

CREATE TABLE dbo.Empleados(
Id INT PRIMARY KEY IDENTITY(1,1),
Nombre VARCHAR(100),
Cargo VARCHAR(100),
Salario DECIMAL(10,2),
);
go