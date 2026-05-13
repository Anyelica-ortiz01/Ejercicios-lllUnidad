using ControlInventario.Modelo;
using ControlInventario.Repositories;

namespace ControlInventario
{
    public partial class Form1 : Form
    {
        IInventarioRepository repo = new InventarioRepository();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtProducto.Text) ||
                string.IsNullOrWhiteSpace(txtCategoria.Text))
            {
                MessageBox.Show("Producto y categoria son obligatorios.");
                return;
            }

            if (!int.TryParse(txtCantidad.Text, out int cantidad) || cantidad < 0)
            {
                MessageBox.Show("Cantidad invalida.");
                return;
            }

            if (!decimal.TryParse(txtPrecio.Text, out decimal precio) || precio < 0)
            {
                MessageBox.Show("Precio invalido.");
                return;
            }

            Inventario producto = new Inventario();
            producto.Producto = txtProducto.Text.Trim();
            producto.Categoria = txtCategoria.Text.Trim();
            producto.Cantidad = cantidad;
            producto.PrecioCompra = precio;

            repo.RegistrarProducto(producto);

            RefrescarListaCompleta();

            MessageBox.Show("Producto registrado correctamente");
            LimpiarCampos();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RefrescarListaCompleta();
        }

        private void RefrescarListaCompleta()
        {
            dvgInventario.DataSource = null;
            dvgInventario.DataSource = repo.ObtenerTodos();
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            dvgInventario.DataSource = null;

            dvgInventario.DataSource = repo.ObtenerStockMenorA5();
        }

        private void btnValorTotal_Click(object sender, EventArgs e)
        {
            decimal total =
                repo.ObtenerValorTotalInventario();

            txtTotal.Text = total.ToString();
        }
        public void LimpiarCampos()
        {
            txtProducto.Clear();
            txtCategoria.Clear();
            txtCantidad.Clear();
            txtPrecio.Clear();

            txtProducto.Focus();
        }
    }
}
