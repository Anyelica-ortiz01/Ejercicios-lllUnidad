using Microsoft.Data.SqlClient;
using Microsoft.Win32.SafeHandles;
using SistemaEmpleados.Conexion;
using System.Data;
namespace SistemaEmpleados
{
    public partial class Form1 : Form
    {
        ConexionDB conexion = new ConexionDB();
        SqlCommand comando = new SqlCommand();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "INSERT INTO dbo.Empleados(Nombre, Cargo, Salario) VALUES(@Nombre,@Cargo,@Salario)";

                comando.Parameters.Clear();

                comando.Parameters.AddWithValue("@Nombre", txtNombre.Text);
                comando.Parameters.AddWithValue("@Cargo", txtCargo.Text);
                comando.Parameters.AddWithValue("@Salario", decimal.Parse(txtSalario.Text));

                comando.ExecuteNonQuery();
                MessageBox.Show("Empleado Guardado.");

                conexion.CerrarConexion();
                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Limpiar()
        {
            txtId.Clear();
            txtNombre.Clear();
            txtCargo.Clear();
            txtSalario.Clear();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM dbo.Empleados", conexion.AbrirConexion());

            DataTable dt = new DataTable();
            da.Fill(dt);

            dgvEmpleados.DataSource = dt;

            conexion.CerrarConexion();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtId.Text))
                {
                    MessageBox.Show("Ingrese un Id.");
                    return;
                }
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "UPDATE dbo.Empleados SET Nombre=@Nombre, Cargo=@Cargo, Salario=@Salario WHERE Id=@Id";

                comando.Parameters.Clear();

                comando.Parameters.AddWithValue("@Id", int.Parse(txtId.Text));
                comando.Parameters.AddWithValue("@Nombre", txtNombre.Text);
                comando.Parameters.AddWithValue("@Cargo", txtCargo.Text);
                comando.Parameters.AddWithValue("@Salario", decimal.Parse(txtSalario.Text));

                comando.ExecuteNonQuery();
                MessageBox.Show("Empleado Actualizado.");

                conexion.CerrarConexion();

                Limpiar();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "DELETE FROM dbo.Empleados WHERE Id=@Id";

            comando.Parameters.AddWithValue("@Id", int.Parse(txtId.Text));

            comando.ExecuteNonQuery();
            MessageBox.Show("Empleado Eliminado.");

            conexion.CerrarConexion();
            Limpiar();
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SELECT SUM(Salario) FROM dbo.empleados";

            object total = comando.ExecuteScalar();
            lblResultados.Text = "Total Salarios: C$ " + total.ToString();

            conexion.CerrarConexion();
        }

        private void btnMayor_Click(object sender, EventArgs e)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = @"SELECT TOP 1 Nombre, Salario FROM dbo.Empleados ORDER BY Salario DESC";

            SqlDataReader leer = comando.ExecuteReader();

            if (leer.Read())
            {
                lblResultados.Text = "Mayor Salario: " + leer["Nombre"].ToString() + "-C$ " + leer["Salario"].ToString();
            }

            leer.Close();

            conexion.CerrarConexion();
        }
    }
}
