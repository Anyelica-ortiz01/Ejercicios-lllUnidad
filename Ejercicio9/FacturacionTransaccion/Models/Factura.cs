namespace FacturacionTransaccion.Models;

public class Factura
{
    public int Id { get; set; }
    public string Cliente { get; set; } = string.Empty;
    public DateTime Fecha { get; set; }
}
