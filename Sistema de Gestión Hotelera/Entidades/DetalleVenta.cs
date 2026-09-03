using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    internal class DetalleVenta
    {
        public int IdVenta { get; set; }      // Clave Primaria / Foránea
        public int CodProducto { get; set; }  // Clave Primaria / Foránea
        public decimal PrecioUnitario { get; set; }
        public int Cantidad { get; set; }
        public decimal Subtotal { get; set; }
    }
}
