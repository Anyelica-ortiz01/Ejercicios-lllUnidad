namespace SistemaProductos.Datos;

public static class DatabaseConfig
{
    public static string ConnectionString =>
        @"Data Source=localhost;Initial Catalog=BD_Productos;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=False;TrustServerCertificate=False;Application Name=""SQL Server Management Studio"";Command Timeout=0";
}
