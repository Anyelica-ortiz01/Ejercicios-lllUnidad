using Microsoft.Data.SqlClient;
using SistemaMedico.Data;
using SistemaMedico.Models;

namespace SistemaMedico;

public partial class Form1 : Form
{
    private PacienteRepositorio? _repo;

    public Form1()
    {
        InitializeComponent();
    }

    public Form1(PacienteRepositorio repo) : this()
    {
        _repo = repo;
    }

    private PacienteRepositorio Repo =>
        _repo ?? throw new InvalidOperationException(
            "Este formulario se abre desde Program.cs con el repositorio. Si ves esto en diseño, es normal usar el constructor sin parámetros.");

    private void btnRegistrar_Click(object? sender, EventArgs e)
    {
        var nombre = txtNombre.Text.Trim();
        if (nombre.Length == 0)
        {
            MessageBox.Show("Escribe el nombre.");
            return;
        }

        if (!int.TryParse(txtEdad.Text.Trim(), out var edad) || edad < 0)
        {
            MessageBox.Show("Escribe una edad válida.");
            return;
        }

        var diagnostico = txtDiagnostico.Text.Trim();
        if (diagnostico.Length == 0)
        {
            MessageBox.Show("Escribe el diagnóstico.");
            return;
        }

        try
        {
            Repo.Registrar(nombre, edad, diagnostico);
            txtNombre.Clear();
            txtEdad.Clear();
            txtDiagnostico.Clear();
            MessageBox.Show("Paciente registrado.");
        }
        catch (Exception ex)
        {
            MostrarError(ex);
        }
    }

    private void btnBuscarNombre_Click(object? sender, EventArgs e)
    {
        try
        {
            LlenarTabla(Repo.BuscarPorNombre(txtBuscarNombre.Text.Trim()));
        }
        catch (Exception ex)
        {
            MostrarError(ex);
        }
    }

    private void btnMayores60_Click(object? sender, EventArgs e)
    {
        try
        {
            LlenarTabla(Repo.ListarMayoresDe60Anios());
        }
        catch (Exception ex)
        {
            MostrarError(ex);
        }
    }

    private static void MostrarError(Exception ex)
    {
        var extra = ex is SqlException
            ? "\n\nRevisa la cadena en ConexionDB/CadenaConexion.cs y que la base BD_Medico exista."
            : "";

        MessageBox.Show(ex.Message + extra, "Error",
            MessageBoxButtons.OK, MessageBoxIcon.Warning);
    }

    private void LlenarTabla(List<Paciente> lista)
    {
        dgvPacientes.Rows.Clear();
        foreach (var p in lista)
            dgvPacientes.Rows.Add(p.Id, p.Nombre, p.Edad, p.Diagnostico);
    }
}
