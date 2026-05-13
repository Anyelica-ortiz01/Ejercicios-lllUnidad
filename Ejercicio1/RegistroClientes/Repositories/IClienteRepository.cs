using RegistroClientes.Models;

namespace RegistroClientes.Repositories;

public interface IClienteRepository
{
    IReadOnlyList<Cliente> ObtenerTodos();
    int Guardar(Cliente cliente);
    bool EliminarPorId(int id);
}
