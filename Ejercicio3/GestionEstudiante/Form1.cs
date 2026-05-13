using Ejercicio3.Data;
using Ejercicio3.Models;

namespace Ejercicio3;

public partial class Form1 : Form
{
    private readonly EstudianteRepositorio _repo;

    public Form1(EstudianteRepositorio repo)
    {
        _repo = repo;
        InitializeComponent();
    }

    private void Form1_Load(object? sender, EventArgs e)
    {
        try
        {
            ActualizarGrillaPorPromedioDescendente();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }

    private void btnRegistrar_Click(object? sender, EventArgs e)
    {
        if (!decimal.TryParse(txtPromedio.Text.Trim(), out var promedio))
        {
            MessageBox.Show("Escribe un promedio válido.");
            return;
        }

        try
        {
            _repo.Registrar(txtNombre.Text.Trim(), txtCarrera.Text.Trim(), promedio);
            txtNombre.Clear();
            txtCarrera.Clear();
            txtPromedio.Clear();
            ActualizarGrillaPorPromedioDescendente();
            MessageBox.Show("Estudiante registrado.");
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }


    }

    private void btnMostrarTodos_Click(object? sender, EventArgs e)
    {
        try
        {
            ActualizarGrillaPorPromedioDescendente();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }

    private void ActualizarGrillaPorPromedioDescendente()
    {
        LlenarTabla(_repo.ListarPorPromedioDescendente());
    }

    private void btnBuscar_Click(object? sender, EventArgs e)
    {
        try
        {
            LlenarTabla(_repo.BuscarPorCarrera(txtBuscarCarrera.Text.Trim()));
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }

    private void LlenarTabla(List<Estudiante> lista)
    {
        dgvEstudiantes.Rows.Clear();
        foreach (var est in lista)
            dgvEstudiantes.Rows.Add(est.Id, est.Nombre, est.Carrera, est.Promedio);
    }

    private void dgvEstudiantes_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {

    }
}
