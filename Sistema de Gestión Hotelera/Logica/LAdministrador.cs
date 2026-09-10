using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class LAdministrador{
       UsuarioDAO usuarioDAO = new UsuarioDAO();


        public List<object> ObtenerUsuariosParaGrilla()
        {
            List<Usuario> usuarios = UsuarioDAO.ObtenerTodos();

            return usuarios.Select(u => new
            {
                ID = u.IdUsuario,
                Usuario = u.NomUsuario,
                pass = u.Pasword,
                Rol = u.Rol.NomRol, // Accedemos al nombre del rol mediante el objeto anidado
                Estado = u.Estado ? "Activo" : "Inactivo"
            }).Cast<object>().ToList();
        }

        public void agegarUsuario(string p_nombre, int p_rol){
            if (string.IsNullOrWhiteSpace(p_nombre))
            {
                throw new ArgumentException("Debe ingresar un nombre de usuario.");
            }

            // 2. Validar que se haya seleccionado un rol válido (1, 2 o 3)
            if (p_rol <= 0)
            {
                throw new ArgumentException("Debe seleccionar un rol para el usuario.");
            }

        }
    }
}
