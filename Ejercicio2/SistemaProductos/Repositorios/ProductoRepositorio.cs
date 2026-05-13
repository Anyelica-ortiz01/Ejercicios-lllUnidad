using Microsoft.EntityFrameworkCore;
using SistemaProductos.Datos;
using SistemaProductos.Entidades;

namespace SistemaProductos.Repositorios;

public class ProductoRepositorio : IProductoRepository
{
    public void InicializarBaseDatos()
    {
        using var db = new AppDbContext();
        db.Database.EnsureCreated();
    }

    public void Insertar(Producto producto)
    {
        using var db = new AppDbContext();
        db.Productos.Add(producto);
        db.SaveChanges();
    }

    public bool Actualizar(Producto producto)
    {
        using var db = new AppDbContext();
        var existente = db.Productos.Find(producto.Id);
        if (existente is null)
            return false;

        existente.Nombre = producto.Nombre;
        existente.Precio = producto.Precio;
        existente.Stock = producto.Stock;
        db.SaveChanges();
        return true;
    }

    public IReadOnlyList<Producto> BuscarPorNombre(string termino)
    {
        using var db = new AppDbContext();
        return db.Productos
            .AsNoTracking()
            .Where(p => p.Nombre.Contains(termino))
            .OrderBy(p => p.Id)
            .ToList();
    }

    public IReadOnlyList<Producto> ObtenerTodos()
    {
        using var db = new AppDbContext();
        return db.Productos.AsNoTracking().OrderBy(p => p.Id).ToList();
    }
}
