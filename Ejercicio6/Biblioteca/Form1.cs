using Biblioteca.Datos;
using Microsoft.Data.SqlClient;
using System.Data;

namespace Biblioteca
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dgvLibros.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLibros.MultiSelect = false;
            dgvLibros.ReadOnly = true;
            dgvLibros.AllowUserToAddRows = false;
            dgvLibros.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLibros.SelectionChanged += DgvLibros_SelectionChanged;
            Load += Form1_Load;
        }

        private void Form1_Load(object? sender, EventArgs e)
        {
            try
            {
                CargarTodosLosLibros();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarTodosLosLibros()
        {
            using var cn = Conexion.Crear();
            cn.Open();
            const string query =
                "SELECT Id, Titulo, Autor, AnioPublicacion, Disponible FROM dbo.Libros ORDER BY Id DESC";
            using var cmd = Conexion.CrearComando(query, cn);
            using var da = new SqlDataAdapter(cmd);
            var dt = new DataTable();
            da.Fill(dt);
            dgvLibros.DataSource = dt;
        }

        private void DgvLibros_SelectionChanged(object? sender, EventArgs e)
        {
            if (dgvLibros.CurrentRow is null || dgvLibros.CurrentRow.IsNewRow)
                return;

            var row = dgvLibros.CurrentRow;
            if (row.Cells.Count == 0)
                return;

            if (TryGetCell(row, "Id", out var idVal) && idVal is not null && idVal is not DBNull)
                txtId.Text = Convert.ToString(idVal) ?? string.Empty;

            if (TryGetCell(row, "Disponible", out var dispVal) && dispVal is not null && dispVal is not DBNull)
                chkDisponible.Checked = dispVal is bool b ? b : Convert.ToBoolean(dispVal);
        }

        private static bool TryGetCell(DataGridViewRow row, string columnName, out object? value)
        {
            value = null;
            if (!row.DataGridView!.Columns.Contains(columnName))
                return false;
            value = row.Cells[columnName].Value;
            return true;
        }

        private bool ValidarAlta(out int año)
        {
            año = 0;
            if (string.IsNullOrWhiteSpace(txtTitulo.Text))
            {
                MessageBox.Show("Escribe el título del libro.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTitulo.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtAutor.Text))
            {
                MessageBox.Show("Escribe el autor.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAutor.Focus();
                return false;
            }

            if (!int.TryParse(txtAño.Text.Trim(), out año) || año < 1 || año > 9999)
            {
                MessageBox.Show("Escribe un año válido (número entre 1 y 9999).", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAño.Focus();
                return false;
            }

            return true;
        }

        private bool ValidarId(out int id)
        {
            id = 0;
            if (!int.TryParse(txtId.Text.Trim(), out id) || id < 1)
            {
                MessageBox.Show("Escribe el Id del libro (número entero) o selecciona una fila en la tabla.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtId.Focus();
                return false;
            }

            return true;
        }

        private void LimpiarCamposAlta()
        {
            txtTitulo.Clear();
            txtAutor.Clear();
            txtAño.Clear();
            chkDisponible.Checked = true;
            txtTitulo.Focus();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (!ValidarAlta(out var año))
                return;

            try
            {
                using var cn = Conexion.Crear();
                cn.Open();

                const string query =
                    "INSERT INTO dbo.Libros (Titulo, Autor, AnioPublicacion, Disponible) " +
                    "VALUES (@Titulo, @Autor, @Año, @Disponible)";

                using var cmd = Conexion.CrearComando(query, cn);
                cmd.Parameters.AddWithValue("@Titulo", txtTitulo.Text.Trim());
                cmd.Parameters.AddWithValue("@Autor", txtAutor.Text.Trim());
                cmd.Parameters.AddWithValue("@Año", año);
                cmd.Parameters.AddWithValue("@Disponible", chkDisponible.Checked);

                cmd.ExecuteNonQuery();
                CargarTodosLosLibros();
                MessageBox.Show("Libro registrado correctamente.", "Biblioteca", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCamposAlta();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMostrarDisponibles_Click(object sender, EventArgs e)
        {
            try
            {
                using var cn = Conexion.Crear();
                cn.Open();

                const string query =
                    "SELECT Id, Titulo, Autor, AnioPublicacion, Disponible FROM dbo.Libros WHERE Disponible = 1";
                using var cmd = Conexion.CrearComando(query, cn);
                using var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                dgvLibros.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscarAutor_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBuscarAutor.Text))
            {
                MessageBox.Show("Escribe parte del nombre del autor a buscar.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBuscarAutor.Focus();
                return;
            }

            try
            {
                using var cn = Conexion.Crear();
                cn.Open();

                const string query =
                    "SELECT Id, Titulo, Autor, AnioPublicacion, Disponible FROM dbo.Libros WHERE Autor LIKE @Autor";
                using var cmd = Conexion.CrearComando(query, cn);
                cmd.Parameters.AddWithValue("@Autor", "%" + txtBuscarAutor.Text.Trim() + "%");

                using var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                dgvLibros.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (!ValidarId(out var id))
                return;

            try
            {
                using var cn = Conexion.Crear();
                cn.Open();

                const string query =
                    "UPDATE dbo.Libros SET Disponible = @Disponible WHERE Id = @Id";

                using var cmd = Conexion.CrearComando(query, cn);
                cmd.Parameters.AddWithValue("@Disponible", chkDisponible.Checked);
                cmd.Parameters.AddWithValue("@Id", id);

                var filas = cmd.ExecuteNonQuery();
                if (filas == 0)
                    MessageBox.Show("No existe un libro con ese Id.", "Biblioteca", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    CargarTodosLosLibros();
                    MessageBox.Show("Disponibilidad actualizada.", "Biblioteca", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
