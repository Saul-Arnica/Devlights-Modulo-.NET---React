using Practico_Bloque_1.Models;

namespace Practico_Bloque_1.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private List<Product> _productos;
        public ProductRepository()
        {
            // aca inicializamo con un makup o como se diga 
            _productos = new List<Product>()
            {
            new Product { Id = 1, Name = "Notebook Lenovo LOQ 15", Price = 1250000m, Category = "Electrónica", Active = true },
            new Product { Id = 2, Name = "Bajo Mesada de Pino", Price = 185000m, Category = "Muebles", Active = true },
            new Product { Id = 3, Name = "Alacena con Cornisa", Price = 145000m, Category = "Muebles", Active = true },
            new Product { Id = 4, Name = "Mouse Inalámbrico", Price = 35000m, Category = "Electrónica", Active = false }
            };

        }
        //Aca agregamos métodos para manipular la lista de productos :P
        public void Add(Product producto)
        {
            _productos.Add(producto);
        }
        public List<Product> GetAll()
        {
            return _productos;
        }
        public Product GetForID(int id)
        {
            return _productos.FirstOrDefault(p => p.Id == id);
        }
        public List<Product> SearchForCategory(string categoria)
        {
            return _productos.Where(p => p.Category.Equals(categoria, StringComparison.OrdinalIgnoreCase)).ToList();
        }
    }
}
