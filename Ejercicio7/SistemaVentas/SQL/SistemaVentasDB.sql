USE SistemaVentasDB;
go
CREATE TABLE Ventas(
Id INT PRIMARY KEY IDENTITY(1,1),
Cliente VARCHAR(100),
Producto VARCHAR(100),
Cantidad INT,
Precio DECIMAL(10,2)
);