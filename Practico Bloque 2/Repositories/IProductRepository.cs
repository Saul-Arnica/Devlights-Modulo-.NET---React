using Practico_Bloque_2.Models;

namespace Practico_Bloque_2.Repositories
{
    public interface IProductRepository
    {
        void Add(Product producto);
        List<Product> GetAll();
        Product? GetForID(int id);
        List<Product> SearchForCategory(string categoria);
        void Update(Product producto);
        void Delete(int id);
    }
}
