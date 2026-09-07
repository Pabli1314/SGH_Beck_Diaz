
using Entidades;
using Datos;

namespace Logica
{
    public class IniciarSesion
    {

        public Usuario? AutenticarUsuario(string nomUsuario, string password)
        {
            Usuario? usuario = UsuarioDAO.ObtenerPorUsername(nomUsuario);

            if (usuario == null || usuario.Pasword != password || !usuario.Estado)
            {
                return null;
            }

            return usuario;
        }

        public int ValidarUsuarioYRol(string nomUsuario, string password)
        {
            Usuario? usuario = AutenticarUsuario(nomUsuario, password);

            if (usuario == null)
            {
                return 0;
            }

            // Evaluar según el IdRol (o NomRol)
            switch (usuario.IdRol)
            {
                case 1:
                    return 1; // Administrador

                case 2:
                    return 2; // Supervisor

                case 3:
                    return 3; // Recepcionista / Empleado

                default:
                    return 0; // Por defecto para otros roles habilitados
            }
        }
    }
}
