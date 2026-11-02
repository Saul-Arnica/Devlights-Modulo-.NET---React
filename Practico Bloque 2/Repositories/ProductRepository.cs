using Practico_Bloque_2.Models;

namespace Practico_Bloque_2.Repositories
{
    public class ProductRepository : IProductRepository
    {
        //Lo hago static pa que se quede entre las petitcione de HTTP
        private static List<Product> _products = new List<Product>()
        {
            new Product { Id = 1, Name = "Notebook Lenovo LOQ 15", Price = 1250000m, Category = "Electrónica", Active = true },
            new Product { Id = 2, Name = "Bajo Mesada de Pino", Price = 185000m, Category = "Muebles", Active = true },
            new Product { Id = 3, Name = "Alacena con Cornisa", Price = 145000m, Category = "Muebles", Active = true },
            new Product { Id = 4, Name = "Mouse Inalámbrico", Price = 35000m, Category = "Electrónica", Active = false }
        };
        private static int _nextId = 5;
        public void Add(Product producto)
        {
            producto.Id = _nextId++;
            _products.Add(producto);
        }

        public List<Product> GetAll() => _products;

        public Product? GetForID(int id) => _products.FirstOrDefault(p => p.Id == id);
        
        public List<Product> SearchForCategory(string categoria)
        {
            return _products.Where(p => p.Category == categoria).ToList();
        }

        public void Update(Product producto)
        {
            var index = _products.FindIndex(p => p.Id == producto.Id);
            if (index != -1) _products[index] = producto;
        }

        public void Delete(int id)
        {
            var p = GetForID(id);
            if (p != null) _products.Remove(p);
        }
    }
}
