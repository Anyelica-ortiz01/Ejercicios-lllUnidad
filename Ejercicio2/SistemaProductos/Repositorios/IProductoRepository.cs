using SistemaProductos.Entidades;

namespace SistemaProductos.Repositorios;

public interface IProductoRepository
{
    void InicializarBaseDatos();
    void Insertar(Producto producto);
    bool Actualizar(Producto producto);
    IReadOnlyList<Producto> BuscarPorNombre(string termino);
    IReadOnlyList<Producto> ObtenerTodos();
}
