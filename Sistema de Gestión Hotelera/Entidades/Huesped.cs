using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Huesped
    {
        public string DniHuesped { get; set; } // VARCHAR(8)
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Telefono { get; set; }

        public string Direccion { get; set; }
    }
}
