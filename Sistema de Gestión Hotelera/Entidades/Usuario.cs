using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Usuario
    {
        public int IdUsuario { get; set; }
        public string NomUsuario { get; set; }
        public string Pasword { get; set; }
        public bool Estado { get; set; } // BIT se convierte en bool (DEFAULT 1 = true)
        public int IdRol { get; set; }
        public Rol Rol { get; set; } = new Rol();
    }
}
