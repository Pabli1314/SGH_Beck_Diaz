using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Logica
{
    /// <summary>
    /// Todavía no existe una tabla de inventario en la base de datos: se administra en memoria
    /// (estática) con datos de ejemplo. El día que exista ProductoDAO, esta clase pasa a
    /// delegarle las operaciones sin cambiar su forma pública.
    /// </summary>
    public class GestionInventario
    {
        private static readonly List<Producto> _productos = new();
        private static bool _inicializado;

        public List<Producto> ObtenerProductos()
        {
            AsegurarSembrado();
            return _productos.OrderBy(p => p.Categoria).ThenBy(p => p.Nombre).ToList();
        }

        public void CrearProducto(Producto producto)
        {
            AsegurarSembrado();
            Validar(producto);

            if (_productos.Any(p => p.Codigo == producto.Codigo))
            {
                throw new ArgumentException($"Ya existe un producto con el código \"{producto.Codigo}\".");
            }

            _productos.Add(producto);
        }

        public void EditarProducto(Producto producto)
        {
            AsegurarSembrado();
            Validar(producto);

            Producto existente = _productos.FirstOrDefault(p => p.Codigo == producto.Codigo)
                ?? throw new InvalidOperationException("No se encontró el producto a editar.");

            existente.Nombre = producto.Nombre;
            existente.Categoria = producto.Categoria;
            existente.StockMinimo = producto.StockMinimo;
            existente.Precio = producto.Precio;
            existente.Activo = producto.Activo;
        }

        public void EliminarProducto(string codigo)
        {
            AsegurarSembrado();
            _productos.RemoveAll(p => p.Codigo == codigo);
        }

        public void AjustarStock(string codigo, int cantidad)
        {
            AsegurarSembrado();
            Producto existente = _productos.FirstOrDefault(p => p.Codigo == codigo)
                ?? throw new InvalidOperationException("No se encontró el producto.");

            int nuevoStock = existente.Stock + cantidad;
            if (nuevoStock < 0)
            {
                throw new ArgumentException("El stock no puede quedar negativo.");
            }

            existente.Stock = nuevoStock;
        }

        private static void Validar(Producto producto)
        {
            if (string.IsNullOrWhiteSpace(producto.Codigo))
            {
                throw new ArgumentException("Debe ingresar un código de producto.");
            }

            if (string.IsNullOrWhiteSpace(producto.Nombre))
            {
                throw new ArgumentException("Debe ingresar un nombre de producto.");
            }

            if (producto.Precio < 0)
            {
                throw new ArgumentException("El precio no puede ser negativo.");
            }

            if (producto.StockMinimo < 0)
            {
                throw new ArgumentException("El stock mínimo no puede ser negativo.");
            }
        }

        private static void AsegurarSembrado()
        {
            if (_inicializado)
            {
                return;
            }

            _productos.AddRange(new[]
            {
                new Producto { Codigo = "BEB-001", Nombre = "Coca-Cola 500ml", Categoria = "Bebidas", Stock = 4, StockMinimo = 10, Precio = 1500 },
                new Producto { Codigo = "BEB-002", Nombre = "Agua Mineral 500ml", Categoria = "Bebidas", Stock = 30, StockMinimo = 10, Precio = 1000 },
                new Producto { Codigo = "SNK-001", Nombre = "Papas Fritas", Categoria = "Snacks", Stock = 0, StockMinimo = 5, Precio = 1800 },
                new Producto { Codigo = "SNK-002", Nombre = "Barra de Cereal", Categoria = "Snacks", Stock = 18, StockMinimo = 8, Precio = 1200 },
                new Producto { Codigo = "VAR-001", Nombre = "Kit de Amenities", Categoria = "Varios", Stock = 25, StockMinimo = 10, Precio = 2500 }
            });

            _inicializado = true;
        }
    }
}
