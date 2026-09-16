using System;
using Microsoft.Data.SqlClient;
using Entidades;

namespace Datos
{
    public class HuespedDAO
    {
        private static readonly Conexion _conexion = new Conexion();

        public static Huesped? ObtenerPorDni(string dniHuesped)
        {
            Huesped? huesped = null;

            string query = @"
                SELECT dni_huesped, nombre, apellido, telefono, direccion
                FROM Huesped
                WHERE dni_huesped = @dniHuesped";

            using (SqlConnection con = _conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@dniHuesped", dniHuesped);

                con.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        huesped = new Huesped
                        {
                            DniHuesped = reader["dni_huesped"].ToString() ?? string.Empty,
                            Nombre = reader["nombre"].ToString() ?? string.Empty,
                            Apellido = reader["apellido"].ToString() ?? string.Empty,
                            Telefono = reader["telefono"].ToString() ?? string.Empty,
                            Direccion = reader["direccion"].ToString() ?? string.Empty
                        };
                    }
                }
            }

            return huesped;
        }

        public static void Crear(Huesped huesped)
        {
            string query = @"
                INSERT INTO Huesped (dni_huesped, nombre, apellido, telefono, direccion)
                VALUES (@dni, @nombre, @apellido, @telefono, @direccion)";

            using (SqlConnection con = _conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@dni", huesped.DniHuesped);
                cmd.Parameters.AddWithValue("@nombre", huesped.Nombre);
                cmd.Parameters.AddWithValue("@apellido", huesped.Apellido);
                cmd.Parameters.AddWithValue("@telefono", huesped.Telefono);
                cmd.Parameters.AddWithValue("@direccion", huesped.Direccion);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
