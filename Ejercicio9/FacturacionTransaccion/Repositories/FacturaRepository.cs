using System.Data;
using FacturacionTransaccion.Data;
using FacturacionTransaccion.Models;
using Microsoft.Data.SqlClient;

namespace FacturacionTransaccion.Repositories;

public class FacturaRepository : IFacturaRepository
{
    public void RegistrarFacturaConDetalles(Factura factura, IReadOnlyList<DetalleFactura> detalles)
    {
        ArgumentNullException.ThrowIfNull(factura);
        if (detalles is null || detalles.Count == 0)
            throw new ArgumentException("La factura debe tener al menos un registro en DetalleFactura.", nameof(detalles));

        using var conexion = ConexionDB.CrearConexion();
        conexion.Open();
        using var transaccion = conexion.BeginTransaction();
        try
        {
            const string sqlFactura =
                "INSERT INTO Facturas (Cliente, Fecha) OUTPUT INSERTED.Id VALUES (@Cliente, @Fecha);";
            int facturaId;
            using (var cmd = new SqlCommand(sqlFactura, conexion, transaccion))
            {
                cmd.Parameters.Add("@Cliente", SqlDbType.VarChar, 100).Value = factura.Cliente;
                cmd.Parameters.Add("@Fecha", SqlDbType.DateTime).Value = factura.Fecha;
                var escalar = cmd.ExecuteScalar();
                facturaId = Convert.ToInt32(escalar);
            }

            const string sqlDetalle =
                "INSERT INTO DetalleFactura (FacturaId, Producto, Cantidad, Precio) VALUES (@FacturaId, @Producto, @Cantidad, @Precio);";
            foreach (var detalle in detalles)
            {
                using var cmd = new SqlCommand(sqlDetalle, conexion, transaccion);
                cmd.Parameters.Add("@FacturaId", SqlDbType.Int).Value = facturaId;
                cmd.Parameters.Add("@Producto", SqlDbType.VarChar, 100).Value = detalle.Producto;
                cmd.Parameters.Add("@Cantidad", SqlDbType.Int).Value = detalle.Cantidad;
                var pPrecio = cmd.Parameters.Add("@Precio", SqlDbType.Decimal);
                pPrecio.Precision = 10;
                pPrecio.Scale = 2;
                pPrecio.Value = detalle.Precio;
                cmd.ExecuteNonQuery();
            }

            transaccion.Commit();
        }
        catch
        {
            transaccion.Rollback();
            throw;
        }
    }
}
