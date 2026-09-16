using System;

namespace Entidades
{
    /// <summary>
    /// Todavía no existe una tabla de inventario en la base: Logica.GestionInventario la
    /// administra en memoria hasta que se agregue la persistencia real.
    /// </summary>
    public class Producto
    {
        public string Codigo { get; set; } = string.Empty;
        public string Nombre { get; set; } = string.Empty;
        public string Categoria { get; set; } = string.Empty;
        public int Stock { get; set; }
        public int StockMinimo { get; set; }
        public decimal Precio { get; set; }
        public bool Activo { get; set; } = true;

        public bool Agotado => Stock <= 0;
        public bool StockBajo => !Agotado && Stock <= StockMinimo;
    }
}
