using Microsoft.EntityFrameworkCore;
using SistemaProductos.Entidades;

namespace SistemaProductos.Datos;

public class AppDbContext : DbContext
{
    public DbSet<Producto> Productos => Set<Producto>();

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
            optionsBuilder.UseSqlServer(DatabaseConfig.ConnectionString);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Producto>(e =>
        {
            e.ToTable("Productos");
            e.HasKey(p => p.Id);
            e.Property(p => p.Nombre).IsRequired().HasMaxLength(200);
            e.Property(p => p.Precio).HasPrecision(18, 2);
        });
    }
}
