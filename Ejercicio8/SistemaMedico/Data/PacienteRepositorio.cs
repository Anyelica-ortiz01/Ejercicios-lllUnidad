using Microsoft.Data.SqlClient;
using SistemaMedico.Models;

namespace SistemaMedico.Data;

public class PacienteRepositorio
{
    private readonly string _cadenaConexion;

    public PacienteRepositorio(string cadenaConexion)
    {
        _cadenaConexion = cadenaConexion;
    }

    public void Registrar(string nombre, int edad, string diagnostico)
    {
        using var conexion = new SqlConnection(_cadenaConexion);
        conexion.Open();
        using var comando = new SqlCommand(
            "INSERT INTO Pacientes (Nombre, Edad, Diagnostico) VALUES (@n, @e, @d)",
            conexion);
        comando.Parameters.AddWithValue("@n", nombre);
        comando.Parameters.AddWithValue("@e", edad);
        comando.Parameters.AddWithValue("@d", diagnostico);
        comando.ExecuteNonQuery();
    }

    public List<Paciente> BuscarPorNombre(string fragmentoNombre)
    {
        var lista = new List<Paciente>();
        using var conexion = new SqlConnection(_cadenaConexion);
        conexion.Open();

        var sql =
            string.IsNullOrWhiteSpace(fragmentoNombre)
                ? "SELECT Id, Nombre, Edad, Diagnostico FROM Pacientes ORDER BY Nombre"
                : """
                  SELECT Id, Nombre, Edad, Diagnostico FROM Pacientes
                  WHERE Nombre LIKE @patron ORDER BY Nombre
                  """;

        using var comando = new SqlCommand(sql, conexion);
        if (!string.IsNullOrWhiteSpace(fragmentoNombre))
            comando.Parameters.AddWithValue("@patron", $"%{fragmentoNombre.Trim()}%");

        using var lector = comando.ExecuteReader();
        while (lector.Read())
            lista.Add(LeerPaciente(lector));

        return lista;
    }

    public List<Paciente> ListarMayoresDe60Anios()
    {
        var lista = new List<Paciente>();
        using var conexion = new SqlConnection(_cadenaConexion);
        conexion.Open();
        using var comando = new SqlCommand(
            """
            SELECT Id, Nombre, Edad, Diagnostico FROM Pacientes
            WHERE Edad >= 60 ORDER BY Edad DESC, Nombre
            """,
            conexion);
        using var lector = comando.ExecuteReader();
        while (lector.Read())
            lista.Add(LeerPaciente(lector));

        return lista;
    }

    private static Paciente LeerPaciente(SqlDataReader lector)
    {
        var ordDiag = lector.GetOrdinal("Diagnostico");

        return new Paciente
        {
            Id = lector.GetInt32(lector.GetOrdinal("Id")),
            Nombre = lector.GetString(lector.GetOrdinal("Nombre")),
            Edad = lector.GetInt32(lector.GetOrdinal("Edad")),
            Diagnostico = lector.IsDBNull(ordDiag) ? "" : lector.GetString(ordDiag)
        };
    }
}
