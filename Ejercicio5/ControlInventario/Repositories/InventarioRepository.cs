using Microsoft.Data.SqlClient;
using ControlInventario.Data;
using ControlInventario.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlInventario.Repositories
{
    public class InventarioRepository : IInventarioRepository
    {
        private readonly Conexion conexion = new Conexion();

        public InventarioRepository()
        {
            InicializarTabla();
        }

        public void RegistrarProducto(Inventario producto)
        {
            using (SqlConnection conn =
                new SqlConnection(conexion.Cadena))
            {
                string query =
                    @"INSERT INTO Inventario
                    (Producto, Categoria, Cantidad, PrecioCompra)
                    VALUES
                    (@Producto, @Categoria, @Cantidad, @PrecioCompra)";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@Producto", producto.Producto);
                cmd.Parameters.AddWithValue("@Categoria", producto.Categoria);
                cmd.Parameters.AddWithValue("@Cantidad", producto.Cantidad);
                cmd.Parameters.AddWithValue("@PrecioCompra", producto.PrecioCompra);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public List<Inventario> ObtenerTodos()
        {
            return Consultar("SELECT Id, Producto, Categoria, Cantidad, PrecioCompra FROM Inventario ORDER BY Id");
        }

        public List<Inventario> ObtenerStockMenorA5()
        {
            return Consultar("SELECT Id, Producto, Categoria, Cantidad, PrecioCompra FROM Inventario WHERE Cantidad < 5 ORDER BY Id");
        }

        private List<Inventario> Consultar(string query)
        {
            List<Inventario> lista = new List<Inventario>();

            using (SqlConnection conn = new SqlConnection(conexion.Cadena))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                using SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    lista.Add(Mapear(reader));
                }
            }

            return lista;
        }

        private static Inventario Mapear(SqlDataReader reader)
        {
            return new Inventario
            {
                Id = Convert.ToInt32(reader["Id"]),
                Producto = Convert.ToString(reader["Producto"]) ?? string.Empty,
                Categoria = Convert.ToString(reader["Categoria"]) ?? string.Empty,
                Cantidad = Convert.ToInt32(reader["Cantidad"]),
                PrecioCompra = Convert.ToDecimal(reader["PrecioCompra"])
            };
        }

        public decimal ObtenerValorTotalInventario()
        {
            decimal total = 0;

            using (SqlConnection conn =
                new SqlConnection(conexion.Cadena))
            {
                string query =
                    "SELECT SUM(Cantidad * PrecioCompra) FROM Inventario";

                SqlCommand cmd = new SqlCommand(query, conn);

                conn.Open();

                object resultado = cmd.ExecuteScalar();

                if (resultado != DBNull.Value)
                {
                    total = Convert.ToDecimal(resultado);
                }
            }

            return total;
        }

        private void InicializarTabla()
        {
            using (SqlConnection conn = new SqlConnection(conexion.Cadena))
            {
                string query =
                    @"IF OBJECT_ID('Inventario', 'U') IS NULL
                      BEGIN
                          CREATE TABLE Inventario(
                              Id INT IDENTITY(1,1) PRIMARY KEY,
                              Producto NVARCHAR(100) NOT NULL,
                              Categoria NVARCHAR(100) NOT NULL,
                              Cantidad INT NOT NULL,
                              PrecioCompra DECIMAL(18,2) NOT NULL
                          )
                      END";

                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
      
   
