using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEmpleados.Conexion
{
    public class ConexionDB
    {
        SqlConnection conexion = new SqlConnection("Server=DESKTOP-27FQEJ8\\SQLEXPRESS;DataBase=SistemaEmpleadosDB;Trusted_Connection=True;Encrypt=False");

        public SqlConnection AbrirConexion()
        {
            if(conexion.State == System.Data.ConnectionState.Closed)
            {
                conexion.Open();
            }
            return conexion;
        }

        public SqlConnection CerrarConexion()
        {
            if(conexion.State == System.Data.ConnectionState.Open)
            {
                conexion.Close();
            }
            return conexion;
        }
    }
}
