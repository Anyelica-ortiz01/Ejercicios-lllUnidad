using Microsoft.Data.SqlClient;
using SistemaVentas.Conexion;
using System.Data;
namespace SistemaVentas
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

                comando.CommandText = "INSERT INTO dbo.Ventas(Cliente,Producto,Cantidad,Precio) VALUES(@Cliente,@Producto,@Cantidad,@Precio)";

                comando.Parameters.Clear();

                comando.Parameters.AddWithValue("@Cliente", txtCliente.Text);
                comando.Parameters.AddWithValue("@Producto", txtProducto.Text);
                comando.Parameters.AddWithValue("@Cantidad", int.Parse(txtCantidad.Text));
                comando.Parameters.AddWithValue("@Precio", decimal.Parse(txtPrecio.Text));

                comando.ExecuteNonQuery();

                MessageBox.Show("Venta guardada");

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
            txtCliente.Clear();
            txtProducto.Clear();
            txtCantidad.Clear();
            txtPrecio.Clear();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT *, (Cantidad * Precio) AS TotalVenta FROM dbo.Ventas", conexion.AbrirConexion());

            DataTable dt = new DataTable();

            da.Fill(dt);

            dgvVentas.DataSource = dt;

            conexion.CerrarConexion();
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            comando.Connection = conexion.AbrirConexion();

            comando.CommandText =
            "SELECT SUM(Cantidad * Precio) FROM dbo.Ventas";

            object resultado = comando.ExecuteScalar();

            lblResultado.Text =
            "Total General: C$ " + resultado.ToString();

            conexion.CerrarConexion();
        }

        private void btnMasvendido_Click(object sender, EventArgs e)
        {
            comando.Connection = conexion.AbrirConexion();

            comando.CommandText = @"SELECT TOP 1 Producto, SUM(Cantidad) AS Total FROM dbo.Ventas GROUP BY Producto ORDER BY Total DESC";

            SqlDataReader leer = comando.ExecuteReader();

            if (leer.Read())
            {
                lblResultado.Text =
                "Más vendido: " +
                leer["Producto"].ToString() +
                " (" +
                leer["Total"].ToString() +
                ")";
            }

            leer.Close();

            conexion.CerrarConexion();
        }

    }
}
