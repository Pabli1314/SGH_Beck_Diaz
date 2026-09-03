using System;
using Microsoft.Data.SqlClient;
using Entidades;

namespace Datos
{
    public class UsuarioDAO
    {
        private static readonly Conexion _conexion = new Conexion();

        public static Usuario? ObtenerPorUsername(string nomUsuario)
        {
            Usuario? usuario = null;

            string query = @"
                SELECT id_usuario, nom_usuario, pasword, estado, id_rol 
                FROM Usuario 
                WHERE nom_usuario = @nomUsuario";

            using (SqlConnection con = _conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@nomUsuario", nomUsuario);

                con.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        usuario = MapearUsuario(reader);
                    }
                }
            }

            return usuario;
        }

        // Método privado para desacoplar la conversión SqlDataReader -> Objeto Usuario
        private static Usuario MapearUsuario(SqlDataReader reader)
        {
            return new Usuario
            {
                IdUsuario = Convert.ToInt32(reader["id_usuario"]),
                NomUsuario = reader["nom_usuario"].ToString() ?? string.Empty,
                Pasword = reader["pasword"].ToString() ?? string.Empty,
                Estado = Convert.ToBoolean(reader["estado"]),
                IdRol = Convert.ToInt32(reader["id_rol"])
            };
        }
    }
}