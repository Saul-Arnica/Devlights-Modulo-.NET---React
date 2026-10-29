using Practico_Bloque_1.Models;
using Practico_Bloque_1.Repositories;
using System;

namespace Practico_Bloque_1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Instanciamo a través de la interfaz para desacoplar
            IProductRepository repo = new ProductRepository();

            // a. Impresión de la lista completa
            Console.WriteLine("--- CATÁLOGO COMPLETO ---");
            var todos = repo.GetAll();
            foreach (var p in todos)
            {
                Console.WriteLine($"[{p.Id}] {p.Name} - {p.Category} - ${p.Price} - Activo: {p.Active}");
            }

            // b. Búsqueda de un producto por ID
            Console.WriteLine("\n--- BÚSQUEDA POR ID (2) ---");
            var productoEncontrado = repo.GetForID(2);
            if (productoEncontrado != null)
            {
                Console.WriteLine($"Encontrado: {productoEncontrado.Name} (${productoEncontrado.Price})");
            }
            else
            {
                Console.WriteLine("Producto no encontrado.");
            }

            // c. Filtrado de productos por categoría
            Console.WriteLine("\n--- FILTRADO POR CATEGORÍA ('Muebles') ---");
            var muebles = repo.SearchForCategory("Muebles");
            foreach (var m in muebles)
            {
                Console.WriteLine($"[{m.Id}] {m.Name}");
            }

            // d. Incorporación de un nuevo producto
            Console.WriteLine("\n--- AGREGANDO NUEVO PRODUCTO ---");
            var nuevoProducto = new Product
            {
                Id = 5,
                Name = "Auriculares Bluetooth",
                Price = 45000m,
                Category = "Electrónica",
                Active = true
            };

            repo.Add(nuevoProducto);
            Console.WriteLine("Producto agregado correctamente.");

            // Verificación del agregado
            Console.WriteLine("\n--- CATÁLOGO ACTUALIZADO ---");
            var catalogoActualizado = repo.GetAll();
            foreach (var p in catalogoActualizado)
            {
                Console.WriteLine($"[{p.Id}] {p.Name}");
            }

            Console.ReadLine();
        }
    }
}

