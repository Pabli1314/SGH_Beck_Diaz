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
                SELECT id_usuario, nom_usuario, pasword, estado, id_rol, nombre, apellido, ultimo_acceso
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
                        usuario = MapearUsuario(reader, incluyeRol: false);
                    }
                }
            }

            return usuario;
        }

        public static List<Usuario> ObtenerTodos()
        {
            List<Usuario> listaUsuarios = new List<Usuario>();

            string query = @"
                SELECT u.id_usuario, u.nom_usuario, u.pasword, u.estado, u.id_rol, u.nombre, u.apellido, u.ultimo_acceso, r.nom_rol
                FROM Usuario u
                INNER JOIN Rol r ON u.id_rol = r.id_rol
                ORDER BY u.id_usuario";

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
                            listaUsuarios.Add(MapearUsuario(reader, incluyeRol: true));
                        }
                    }
                }
            }

            return listaUsuarios;
        }

        public static Usuario? ObtenerPorId(int idUsuario)
        {
            Usuario? usuario = null;

            string query = @"
                SELECT u.id_usuario, u.nom_usuario, u.pasword, u.estado, u.id_rol, u.nombre, u.apellido, u.ultimo_acceso, r.nom_rol
                FROM Usuario u
                INNER JOIN Rol r ON u.id_rol = r.id_rol
                WHERE u.id_usuario = @idUsuario";

            using (SqlConnection con = _conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@idUsuario", idUsuario);

                con.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        usuario = MapearUsuario(reader, incluyeRol: true);
                    }
                }
            }

            return usuario;
        }

        public static bool ExisteNombreUsuario(string nomUsuario, int idExcluir = 0)
        {
            string query = @"
                SELECT COUNT(1)
                FROM Usuario
                WHERE nom_usuario = @nomUsuario AND id_usuario <> @idExcluir";

            using (SqlConnection con = _conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@nomUsuario", nomUsuario);
                cmd.Parameters.AddWithValue("@idExcluir", idExcluir);

                con.Open();
                int cantidad = (int)cmd.ExecuteScalar();
                return cantidad > 0;
            }
        }

        public static void Insertar(Usuario usuario)
        {
            string query = @"
                INSERT INTO Usuario (nom_usuario, pasword, estado, id_rol, nombre, apellido)
                VALUES (@nomUsuario, @pasword, @estado, @idRol, @nombre, @apellido)";

            using (SqlConnection con = _conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@nomUsuario", usuario.NomUsuario);
                cmd.Parameters.AddWithValue("@pasword", usuario.Pasword);
                cmd.Parameters.AddWithValue("@estado", usuario.Estado);
                cmd.Parameters.AddWithValue("@idRol", usuario.IdRol);
                cmd.Parameters.AddWithValue("@nombre", usuario.Nombre);
                cmd.Parameters.AddWithValue("@apellido", usuario.Apellido);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public static void Actualizar(Usuario usuario, bool actualizarPassword)
        {
            string query = actualizarPassword
                ? @"UPDATE Usuario
                    SET nom_usuario = @nomUsuario, pasword = @pasword, id_rol = @idRol,
                        nombre = @nombre, apellido = @apellido, estado = @estado
                    WHERE id_usuario = @idUsuario"
                : @"UPDATE Usuario
                    SET nom_usuario = @nomUsuario, id_rol = @idRol,
                        nombre = @nombre, apellido = @apellido, estado = @estado
                    WHERE id_usuario = @idUsuario";

            using (SqlConnection con = _conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@nomUsuario", usuario.NomUsuario);
                cmd.Parameters.AddWithValue("@idRol", usuario.IdRol);
                cmd.Parameters.AddWithValue("@nombre", usuario.Nombre);
                cmd.Parameters.AddWithValue("@apellido", usuario.Apellido);
                cmd.Parameters.AddWithValue("@estado", usuario.Estado);
                cmd.Parameters.AddWithValue("@idUsuario", usuario.IdUsuario);

                if (actualizarPassword)
                {
                    cmd.Parameters.AddWithValue("@pasword", usuario.Pasword);
                }

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public static void CambiarEstado(int idUsuario, bool activo)
        {
            string query = "UPDATE Usuario SET estado = @estado WHERE id_usuario = @idUsuario";

            using (SqlConnection con = _conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@estado", activo);
                cmd.Parameters.AddWithValue("@idUsuario", idUsuario);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public static void Eliminar(int idUsuario)
        {
            string query = "DELETE FROM Usuario WHERE id_usuario = @idUsuario";

            using (SqlConnection con = _conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@idUsuario", idUsuario);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public static void ActualizarUltimoAcceso(int idUsuario, DateTime momento)
        {
            string query = "UPDATE Usuario SET ultimo_acceso = @momento WHERE id_usuario = @idUsuario";

            using (SqlConnection con = _conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@momento", momento);
                cmd.Parameters.AddWithValue("@idUsuario", idUsuario);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        private static Usuario MapearUsuario(SqlDataReader reader, bool incluyeRol)
        {
            var usuario = new Usuario
            {
                IdUsuario = Convert.ToInt32(reader["id_usuario"]),
                NomUsuario = reader["nom_usuario"].ToString() ?? string.Empty,
                Pasword = reader["pasword"].ToString() ?? string.Empty,
                Estado = Convert.ToBoolean(reader["estado"]),
                IdRol = Convert.ToInt32(reader["id_rol"]),
                Nombre = reader["nombre"]?.ToString() ?? string.Empty,
                Apellido = reader["apellido"]?.ToString() ?? string.Empty,
                UltimoAcceso = reader["ultimo_acceso"] is DBNull ? null : Convert.ToDateTime(reader["ultimo_acceso"])
            };

            if (incluyeRol)
            {
                usuario.Rol = new Rol
                {
                    IdRol = usuario.IdRol,
                    NomRol = reader["nom_rol"].ToString() ?? string.Empty
                };
            }

            return usuario;
        }
    }
}
