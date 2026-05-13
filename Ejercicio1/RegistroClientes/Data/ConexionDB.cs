using System.Configuration;
using Microsoft.Data.SqlClient;

namespace RegistroClientes.Data
{
    internal class ConexionDB
    {
        private const string CadenaPorDefecto =
            "Data Source=localhost;Initial Catalog=BD_Clientes;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=False;TrustServerCertificate=False;Application Name=\"SQL Server Management Studio\";Command Timeout=0";

        public SqlConnection ObtenerConexion()
        {
            var desdeArchivo =
                ConfigurationManager.ConnectionStrings["BD_Clientes"]?.ConnectionString;
            var cadena = string.IsNullOrWhiteSpace(desdeArchivo)
                ? CadenaPorDefecto
                : desdeArchivo;
            return new SqlConnection(cadena);
        }
    }
}

