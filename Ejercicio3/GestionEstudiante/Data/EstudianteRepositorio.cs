using Ejercicio3.Models;
using Microsoft.Data.SqlClient;

namespace Ejercicio3.Data;

public class EstudianteRepositorio
{
    private readonly string _cadenaConexion;

    public EstudianteRepositorio(string cadenaConexion)
    {
        _cadenaConexion = cadenaConexion;
    }

    public void Registrar(string nombre, string carrera, decimal promedio)
    {
        using var conexion = new SqlConnection(_cadenaConexion);
        conexion.Open();
        using var comando = new SqlCommand(
            "INSERT INTO Estudiantes (Nombre, Carrera, Promedio) VALUES (@n, @c, @p)",
            conexion);
        comando.Parameters.AddWithValue("@n", nombre);
        comando.Parameters.AddWithValue("@c", carrera);
        comando.Parameters.AddWithValue("@p", promedio);
        comando.ExecuteNonQuery();
    }

    private List<Estudiante> CargarTodos()
    {
        var lista = new List<Estudiante>();
        using var conexion = new SqlConnection(_cadenaConexion);
        conexion.Open();
        using var comando = new SqlCommand(
            "SELECT Id, Nombre, Carrera, Promedio FROM Estudiantes",
            conexion);
        using var lector = comando.ExecuteReader();
        while (lector.Read())
        {
            lista.Add(new Estudiante
            {
                Id = lector.GetInt32(lector.GetOrdinal("Id")),
                Nombre = lector.GetString(lector.GetOrdinal("Nombre")),
                Carrera = lector.GetString(lector.GetOrdinal("Carrera")),
                Promedio = lector.GetDecimal(lector.GetOrdinal("Promedio"))
            });
        }

        return lista;
    }

    public List<Estudiante> ListarPorPromedioDescendente()
    {
        return CargarTodos().OrderByDescending(e => e.Promedio).ToList();
    }

    public List<Estudiante> BuscarPorCarrera(string carrera)
    {
        return CargarTodos()
            .Where(e => e.Carrera.Equals(carrera, StringComparison.OrdinalIgnoreCase))
            .ToList();
    }
}
