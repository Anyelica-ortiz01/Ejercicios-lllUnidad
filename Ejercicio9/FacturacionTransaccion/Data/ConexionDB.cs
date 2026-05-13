using Microsoft.Data.SqlClient;

namespace FacturacionTransaccion.Data;

public static class ConexionDB
{
    private const string Cadena =
        "Data Source=localhost;Initial Catalog=BD_Facturacion;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=False;TrustServerCertificate=False;Application Name=\"SQL Server Management Studio\";Command Timeout=0";

    public static string CadenaConexion => Cadena;

    public static SqlConnection CrearConexion() => new(Cadena);
}
