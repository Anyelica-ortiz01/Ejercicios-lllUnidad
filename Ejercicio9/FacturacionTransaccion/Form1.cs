using System.Globalization;
using FacturacionTransaccion.Models;
using FacturacionTransaccion.Repositories;

namespace FacturacionTransaccion
{
    public partial class Form1 : Form
    {
        private const decimal PrecioMaxSql = 99999999.99m;
        private readonly IFacturaRepository _facturaRepository = new FacturaRepository();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object? sender, EventArgs e)
        {
            dgvDetalle.AllowUserToAddRows = true;
            dgvDetalle.AllowUserToDeleteRows = true;
            txtCliente.MaxLength = 100;
            colProducto.MaxInputLength = 100;
        }

        private void btnRegistrar_Click(object? sender, EventArgs e)
        {
            var cliente = txtCliente.Text.Trim();
            if (string.IsNullOrEmpty(cliente))
            {
                MessageBox.Show("Indique el cliente.", Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var cultura = CultureInfo.CurrentCulture;
            var detalles = new List<DetalleFactura>();
            foreach (DataGridViewRow fila in dgvDetalle.Rows)
            {
                if (fila.IsNewRow) continue;
                var producto = Convert.ToString(fila.Cells[colProducto.Index].Value)?.Trim() ?? "";
                if (string.IsNullOrEmpty(producto)) continue;

                var txtCant = Convert.ToString(fila.Cells[colCantidad.Index].Value);
                if (!int.TryParse(txtCant, NumberStyles.Integer, cultura, out var cantidad) || cantidad <= 0)
                {
                    MessageBox.Show("Cantidad inválida en una fila con producto.", Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var txtPrecio = Convert.ToString(fila.Cells[colPrecio.Index].Value);
                if (!decimal.TryParse(txtPrecio, NumberStyles.Number, cultura, out var precio) || precio < 0 || precio > PrecioMaxSql)
                {
                    MessageBox.Show("Precio inválido o fuera de rango DECIMAL(10,2).", Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                precio = Math.Round(precio, 2, MidpointRounding.AwayFromZero);
                detalles.Add(new DetalleFactura { Producto = producto, Cantidad = cantidad, Precio = precio });
            }

            if (detalles.Count == 0)
            {
                MessageBox.Show("Agregue al menos un detalle (producto, cantidad, precio).", Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var factura = new Factura { Cliente = cliente, Fecha = dtpFecha.Value };

            try
            {
                _facturaRepository.RegistrarFacturaConDetalles(factura, detalles);
                MessageBox.Show("Factura y detalles guardados correctamente (COMMIT).", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCliente.Clear();
                dgvDetalle.Rows.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se guardó nada en la base de datos (ROLLBACK).\n" + ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvDetalle_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
