using RegistroClientes.Models;
using RegistroClientes.Repositories;

namespace RegistroClientes;

public partial class Form1 : Form
{
    private readonly IClienteRepository _repositorio;

    public Form1()
    {
        InitializeComponent();
        _repositorio = new ClienteRepository();
    }

    public Form1(IClienteRepository repositorio)
    {
        InitializeComponent();
        _repositorio = repositorio;
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        CargarClientes();
    }

    private void CargarClientes()
    {
        try
        {
            var lista = _repositorio.ObtenerTodos();
            dgvClientes.DataSource = null;
            dgvClientes.AutoGenerateColumns = true;
            dgvClientes.DataSource = lista;
            if (dgvClientes.Columns.Count > 0)
                dgvClientes.Columns["Id"]!.HeaderText = "Id";
        }
        catch (Exception ex)
        {
            MessageBox.Show(
                "No se pudo cargar los clientes. Verifique la base de datos y la cadena en App.config.\n\n" + ex.Message,
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
    }

    private void btnGuardar_Click(object sender, EventArgs e)
    {
        var nombre = txtNombre.Text.Trim();
        var telefono = txtTelefono.Text.Trim();
        var correo = txtCorreo.Text.Trim();

        if (string.IsNullOrWhiteSpace(nombre) ||
            string.IsNullOrWhiteSpace(telefono) ||
            string.IsNullOrWhiteSpace(correo))
        {
            MessageBox.Show(
                "Complete todos los campos: Nombre, Teléfono y Correo.",
                "Validación",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            return;
        }

        try
        {
            var cliente = new Cliente
            {
                Nombre = nombre,
                Telefono = telefono,
                Correo = correo
            };
            _repositorio.Guardar(cliente);
            LimpiarCampos();
            CargarClientes();
            MessageBox.Show("Cliente guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (Exception ex)
        {
            MessageBox.Show("No se pudo guardar el cliente.\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void btnEliminar_Click(object sender, EventArgs e)
    {
        if (dgvClientes.CurrentRow is null || dgvClientes.CurrentRow.DataBoundItem is not Cliente seleccionado)
        {
            MessageBox.Show("Seleccione un cliente en la tabla.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        var confirmar = MessageBox.Show(
            $"¿Eliminar al cliente «{seleccionado.Nombre}»?",
            "Confirmar",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);
        if (confirmar != DialogResult.Yes)
            return;

        try
        {
            if (_repositorio.EliminarPorId(seleccionado.Id))
            {
                CargarClientes();
                MessageBox.Show("Cliente eliminado.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("No se encontró el registro.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        catch (Exception ex)
        {
            MessageBox.Show("No se pudo eliminar.\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void btnActualizar_Click(object sender, EventArgs e)
    {
        CargarClientes();
    }

    private void LimpiarCampos()
    {
        txtNombre.Clear();
        txtTelefono.Clear();
        txtCorreo.Clear();
    }

    private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {

    }

    private void lblNombre_Click(object sender, EventArgs e)
    {

    }
}
