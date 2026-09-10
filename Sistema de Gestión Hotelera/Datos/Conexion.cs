using System;
using Microsoft.Data.SqlClient;

namespace Datos
{
    public class Conexion
    {
        private string stringConexion = "Server=MCBECKMUSIC\\SQLEXPRESS01;Database=beck_diaz_db;Integrated Security=True;TrustServerCertificate=True;";

        public SqlConnection ObtenerConexion()
        { 
            return new SqlConnection(stringConexion);
        }

        // Método para probar la conexión desde WinForms
        public bool ProbarConexion()
        {
            using (SqlConnection con = ObtenerConexion())
            {
                con.Open(); // Si falla, lanza SqlException
                return true;
            }
        }
    }
}