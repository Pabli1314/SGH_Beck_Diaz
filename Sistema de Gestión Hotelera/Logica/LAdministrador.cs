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

            // Transformamos el valor de 'Estado' a texto y seleccionamos solo lo necesario para la UI
            return usuarios.Select(u => new
            {
                ID = u.IdUsuario,
                Usuario = u.NomUsuario,
                Rol = u.IdRol,
                Estado = u.Estado ? "Activo" : "Inactivo"
            }).Cast<object>().ToList();
        }
    }
}
