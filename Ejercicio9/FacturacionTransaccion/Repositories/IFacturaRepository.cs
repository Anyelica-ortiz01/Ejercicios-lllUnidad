using FacturacionTransaccion.Models;

namespace FacturacionTransaccion.Repositories;

public interface IFacturaRepository
{
    void RegistrarFacturaConDetalles(Factura factura, IReadOnlyList<DetalleFactura> detalles);
}
