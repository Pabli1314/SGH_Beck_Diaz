using Entidades;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace Datos
{
    public class UsuarioDAO
    {
        private static readonly Conexion _conexion = new Conexion();

        public static Usuario? ObtenerPorUsername(string nomUsuario)
        {
            Usuario? usuario = null;

            string query = @"
                SELECT id_usuario, nom_usuario, pasword
                FROM Usuario 
                WHERE nom_usuario = @nomUsuario";

            using (SqlConnection con = _conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.CommandType = CommandType.Text;
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

        public static List<Usuario> ObtenerTodos()
        {
            List<Usuario> listaUsuarios = new List<Usuario>();

            string query = "SELECT u.id_usuario, u.nom_usuario, estado, r.nom_rol FROM Usuario u INNER JOIN Rol r ON u.id_rol = r.id_rol";

            using (SqlConnection con = _conexion.ObtenerConexion())
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.CommandType = CommandType.Text;

                    con.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Reutilizamos el método MapearUsuario para instanciar el objeto
                            listaUsuarios.Add(MapearUsuario(reader));
                        }
                    }
                }
            }

            return listaUsuarios;
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