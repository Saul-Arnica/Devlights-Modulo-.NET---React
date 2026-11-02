using Practico_Bloque_2.DTO_s;
using Practico_Bloque_2.Models;
using Practico_Bloque_2.Repositories;

namespace Practico_Bloque_2.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _repo;

        public ProductService(IProductRepository repo)
        {
            _repo = repo;
        }

        public List<ProductDTO> GetAll()
        {
            return _repo.GetAll().Select(p => new ProductDTO
            {
                Id = p.Id,
                Name = p.Name,
                Price = p.Price,
                Category = p.Category,
                Active = p.Active
            }).ToList();
        }

        public ProductDTO? GetForID(int id)
        {
            var p = _repo.GetForID(id);
            if (p == null) return null;
            return new ProductDTO { Id = p.Id, Name = p.Name, Price = p.Price, Category = p.Category, Active = p.Active };
        }

        public ProductDTO Add(CreateProductDTO dto)
        {
            var nuevoProducto = new Product
            {
                Name = dto.Name,
                Price = dto.Price,
                Category = dto.Category,
                Active = true
            };

            _repo.Add(nuevoProducto);

            return new ProductDTO { Id = nuevoProducto.Id, Name = nuevoProducto.Name, Price = nuevoProducto.Price, Category = nuevoProducto.Category, Active = nuevoProducto.Active };
        }

        public bool Update(int id, CreateProductDTO dto)
        {
            var existente = _repo.GetForID(id);
            if (existente == null) return false;

            existente.Name = dto.Name;
            existente.Price = dto.Price;
            existente.Category = dto.Category;

            _repo.Update(existente);
            return true;
        }

        public bool Delete(int id)
        {
            var existente = _repo.GetForID(id);
            if (existente == null) return false;

            _repo.Delete(id);
            return true;
        }
    }
}