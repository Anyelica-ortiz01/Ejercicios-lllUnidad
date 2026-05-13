namespace FacturacionTransaccion.Models;

public class DetalleFactura
{
    public int Id { get; set; }
    public int FacturaId { get; set; }
    public string Producto { get; set; } = string.Empty;
    public int Cantidad { get; set; }
    public decimal Precio { get; set; }
}
