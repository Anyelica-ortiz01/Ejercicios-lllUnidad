using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVentas.Conexion
{
    public class ConexionDB
    {
        SqlConnection conexion = new SqlConnection("Data Source=DESKTOP-27FQEJ8\\SQLEXPRESS;Initial Catalog=SistemaVentasDB;Integrated Security=True;Encrypt=False");
        
        public SqlConnection AbrirConexion()
        {
            if (conexion.State == System.Data.ConnectionState.Closed)
            {
                conexion.Open();
            }
            return conexion;
        }

        public SqlConnection CerrarConexion()
        {
            if (conexion.State == System.Data.ConnectionState.Open)
            {
                conexion.Close();
            }
            return conexion;
        } 
    }
}
