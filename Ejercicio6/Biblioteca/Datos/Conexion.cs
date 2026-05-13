using Microsoft.Data.SqlClient;

namespace Biblioteca.Datos
{
    public static class Conexion
    {
        public static readonly string Cadena =
            @"Data Source=localhost;Initial Catalog=BD_Biblioteca;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=False;TrustServerCertificate=False;Application Name=""SQL Server Management Studio""";

        public static SqlConnection Crear() => new SqlConnection(Cadena);

        public static SqlCommand CrearComando(string commandText, SqlConnection cn)
        {
            return new SqlCommand(commandText, cn) { CommandTimeout = 0 };
        }
    }
}
