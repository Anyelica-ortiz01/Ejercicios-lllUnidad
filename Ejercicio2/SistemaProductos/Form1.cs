using System.Globalization;
using SistemaProductos.Entidades;
using SistemaProductos.Repositorios;

namespace SistemaProductos;

public partial class Form1 : Form
{
    private readonly IProductoRepository _productos = new ProductoRepositorio();

    public Form1()
    {
        InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        _productos.InicializarBaseDatos();
        CargarListaCompleta();
    }

    private void CargarListaCompleta()
    {
        var lista = _productos.ObtenerTodos();
        EnlazarGrid(lista);
    }

    private void EnlazarGrid(IReadOnlyList<Producto> lista)
    {
        dgvProductos.DataSource = lista.ToList();
        if (dgvProductos.Columns.Count > 0)
        {
            dgvProductos.Columns["Id"]!.HeaderText = "Id";
            dgvProductos.Columns["Nombre"]!.HeaderText = "Nombre";
            dgvProductos.Columns["Precio"]!.HeaderText = "Precio";
            dgvProductos.Columns["Stock"]!.HeaderText = "Stock";
        }
    }

    private void btnInsertar_Click(object sender, EventArgs e)
    {
        if (!TryLeerCampos(out var nombre, out var precio, out var stock))
            return;

        _productos.Insertar(new Producto
        {
            Nombre = nombre,
            Precio = precio,
            Stock = stock
        });
        LimpiarCampos();
        CargarListaCompleta();
        MessageBox.Show("Producto insertado.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void btnActualizar_Click(object sender, EventArgs e)
    {
        if (dgvProductos.CurrentRow?.DataBoundItem is not Producto seleccionado)
        {
            MessageBox.Show("Seleccione un producto en la lista para actualizar.", "Atención",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        if (!TryLeerCampos(out var nombre, out var precio, out var stock))
            return;

        var ok = _productos.Actualizar(new Producto
        {
            Id = seleccionado.Id,
            Nombre = nombre,
            Precio = precio,
            Stock = stock
        });

        if (!ok)
        {
            MessageBox.Show("No se encontró el producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        CargarListaCompleta();
        MessageBox.Show("Producto actualizado.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void btnBuscar_Click(object sender, EventArgs e)
    {
        var termino = txtBuscar.Text.Trim();
        if (string.IsNullOrEmpty(termino))
        {
            MessageBox.Show("Escriba parte del nombre a buscar.", "Buscar",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        var resultado = _productos.BuscarPorNombre(termino);
        EnlazarGrid(resultado);
        lblResultadoBusqueda.Text = $"Resultados: {resultado.Count}";
    }

    private void btnMostrarLista_Click(object sender, EventArgs e)
    {
        txtBuscar.Clear();
        lblResultadoBusqueda.Text = "";
        CargarListaCompleta();
    }

    private void dgvProductos_SelectionChanged(object sender, EventArgs e)
    {
        if (dgvProductos.CurrentRow?.DataBoundItem is not Producto p)
            return;

        txtNombre.Text = p.Nombre;
        txtPrecio.Text = p.Precio.ToString(CultureInfo.CurrentCulture);
        txtStock.Text = p.Stock.ToString(CultureInfo.CurrentCulture);
    }

    private bool TryLeerCampos(out string nombre, out decimal precio, out int stock)
    {
        nombre = txtNombre.Text.Trim();
        if (string.IsNullOrEmpty(nombre))
        {
            MessageBox.Show("El nombre es obligatorio.", "Validación",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            precio = 0;
            stock = 0;
            return false;
        }

        if (!decimal.TryParse(txtPrecio.Text.Trim(), NumberStyles.Number, CultureInfo.CurrentCulture, out precio)
            || precio < 0)
        {
            MessageBox.Show("Precio no válido (use un número mayor o igual que 0).", "Validación",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            stock = 0;
            return false;
        }

        if (!int.TryParse(txtStock.Text.Trim(), NumberStyles.Integer, CultureInfo.CurrentCulture, out stock)
            || stock < 0)
        {
            MessageBox.Show("Stock no válido (use un entero mayor o igual que 0).", "Validación",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        return true;
    }

    private void LimpiarCampos()
    {
        txtNombre.Clear();
        txtPrecio.Clear();
        txtStock.Clear();
    }

    private void btnLimpiar_Click(object sender, EventArgs e)
    {
        LimpiarCampos();
        dgvProductos.ClearSelection();
    }

    private void txtBuscar_TextChanged(object sender, EventArgs e)
    {

    }

    private void flowBuscar_Paint(object sender, PaintEventArgs e)
    {

    }

    private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {

    }
}
