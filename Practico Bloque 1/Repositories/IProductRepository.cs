using Practico_Bloque_1.Models;
using System.Collections.Generic;

namespace Practico_Bloque_1.Repositories
{
    public interface IProductRepository
    {
        void Add(Product producto);
        List<Product> GetAll();
        Product GetForID(int id);
        List<Product> SearchForCategory(string categoria);
    }
}
