
using Entidades;
using Datos;

namespace Logica
{
    public class IniciarSesion
    {

        public int ValidarUsuarioYRol(string nomUsuario, string password)
        {
            // 1. Buscar el usuario en la base de datos
            Usuario? usuario = UsuarioDAO.ObtenerPorUsername(nomUsuario);

            // 2. Si no existe, la clave no coincide o está deshabilitado -> Retorna 0
            if (usuario == null || usuario.Pasword != password || !usuario.Estado)
            {
                return 0;
            }

            // 3. Evaluar según el IdRol (o NomRol)
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
