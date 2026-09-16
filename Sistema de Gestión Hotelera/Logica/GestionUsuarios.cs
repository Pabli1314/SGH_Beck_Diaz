using Datos;
using Entidades;
using System;
using System.Collections.Generic;

namespace Logica
{
    public class GestionUsuarios
    {
        public List<Usuario> ObtenerUsuarios() => UsuarioDAO.ObtenerTodos();

        public List<Rol> ObtenerRoles() => RolDAO.ObtenerTodos();

        public void CrearUsuario(Usuario usuario, string password, string confirmarPassword)
        {
            ValidarDatosBasicos(usuario);
            ValidarPassword(password, confirmarPassword, esObligatoria: true);

            if (UsuarioDAO.ExisteNombreUsuario(usuario.NomUsuario))
            {
                throw new ArgumentException($"Ya existe un usuario con el nombre \"{usuario.NomUsuario}\".");
            }

            usuario.Pasword = password;
            UsuarioDAO.Insertar(usuario);
        }

        public void EditarUsuario(Usuario usuario, string password, string confirmarPassword)
        {
            ValidarDatosBasicos(usuario);

            if (UsuarioDAO.ExisteNombreUsuario(usuario.NomUsuario, usuario.IdUsuario))
            {
                throw new ArgumentException($"Ya existe un usuario con el nombre \"{usuario.NomUsuario}\".");
            }

            bool cambiaPassword = !string.IsNullOrEmpty(password) || !string.IsNullOrEmpty(confirmarPassword);
            if (cambiaPassword)
            {
                ValidarPassword(password, confirmarPassword, esObligatoria: true);
                usuario.Pasword = password;
            }

            UsuarioDAO.Actualizar(usuario, actualizarPassword: cambiaPassword);
        }

        public void CambiarEstado(int idUsuario, bool activo) => UsuarioDAO.CambiarEstado(idUsuario, activo);

        public void CambiarPassword(int idUsuario, string passwordActual, string passwordNueva, string confirmarPassword)
        {
            Usuario usuario = UsuarioDAO.ObtenerPorId(idUsuario)
                ?? throw new InvalidOperationException("No se encontró el usuario.");

            if (usuario.Pasword != passwordActual)
            {
                throw new ArgumentException("La contraseña actual no es correcta.");
            }

            ValidarPassword(passwordNueva, confirmarPassword, esObligatoria: true);

            usuario.Pasword = passwordNueva;
            UsuarioDAO.Actualizar(usuario, actualizarPassword: true);
        }

        public void EliminarUsuario(int idUsuario) => UsuarioDAO.Eliminar(idUsuario);

        private static void ValidarDatosBasicos(Usuario usuario)
        {
            if (usuario == null)
            {
                throw new ArgumentException("No se recibieron datos del usuario.");
            }

            if (string.IsNullOrWhiteSpace(usuario.Nombre))
            {
                throw new ArgumentException("Debe ingresar el nombre.");
            }

            if (string.IsNullOrWhiteSpace(usuario.Apellido))
            {
                throw new ArgumentException("Debe ingresar el apellido.");
            }

            if (string.IsNullOrWhiteSpace(usuario.NomUsuario))
            {
                throw new ArgumentException("Debe ingresar un nombre de usuario.");
            }

            if (usuario.IdRol <= 0)
            {
                throw new ArgumentException("Debe seleccionar un rol para el usuario.");
            }
        }

        private static void ValidarPassword(string password, string confirmarPassword, bool esObligatoria)
        {
            if (esObligatoria && string.IsNullOrWhiteSpace(password))
            {
                throw new ArgumentException("Debe ingresar una contraseña.");
            }

            if (password != confirmarPassword)
            {
                throw new ArgumentException("Las contraseñas no coinciden.");
            }
        }
    }
}
