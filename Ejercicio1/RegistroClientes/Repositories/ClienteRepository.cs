using Microsoft.Data.SqlClient;
using RegistroClientes.Data;
using RegistroClientes.Models;

namespace RegistroClientes.Repositories;

public class ClienteRepository : IClienteRepository
{
    private readonly string? _cadenaExplicita;

    public ClienteRepository()
    {
    }

    public ClienteRepository(string cadenaConexion)
    {
        _cadenaExplicita = cadenaConexion;
    }

    private SqlConnection CrearConexion()
    {
        if (!string.IsNullOrWhiteSpace(_cadenaExplicita))
            return new SqlConnection(_cadenaExplicita);
        return new ConexionDB().ObtenerConexion();
    }

    public IReadOnlyList<Cliente> ObtenerTodos()
    {
        var lista = new List<Cliente>();
        const string sql =
            "SELECT Id, Nombre, Telefono, Correo FROM Clientes ORDER BY Id;";

        using var conexion = CrearConexion();
        conexion.Open();
        using var comando = new SqlCommand(sql, conexion);
        using var lector = comando.ExecuteReader();

        while (lector.Read())
        {
            lista.Add(new Cliente
            {
                Id = lector.GetInt32(0),
                Nombre = lector.IsDBNull(1) ? string.Empty : lector.GetString(1),
                Telefono = lector.IsDBNull(2) ? string.Empty : lector.GetString(2),
                Correo = lector.IsDBNull(3) ? string.Empty : lector.GetString(3)
            });
        }

        return lista;
    }

    public int Guardar(Cliente cliente)
    {
        const string sql =
            """
            INSERT INTO Clientes (Nombre, Telefono, Correo)
            OUTPUT INSERTED.Id
            VALUES (@Nombre, @Telefono, @Correo);
            """;

        using var conexion = CrearConexion();
        conexion.Open();
        using var comando = new SqlCommand(sql, conexion);

        comando.Parameters.AddWithValue("@Nombre", cliente.Nombre);
        comando.Parameters.AddWithValue("@Telefono", cliente.Telefono);
        comando.Parameters.AddWithValue("@Correo", cliente.Correo);

        var resultado = comando.ExecuteScalar();

        return resultado is int id ? id : Convert.ToInt32(resultado);
    }

    public bool EliminarPorId(int id)
    {
        const string sql = "DELETE FROM Clientes WHERE Id = @Id;";

        using var conexion = CrearConexion();
        conexion.Open();
        using var comando = new SqlCommand(sql, conexion);

        comando.Parameters.AddWithValue("@Id", id);

        return comando.ExecuteNonQuery() > 0;
    }
}