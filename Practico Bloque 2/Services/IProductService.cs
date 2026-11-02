using Practico_Bloque_2.DTO_s;

namespace Practico_Bloque_2.Services
{
    public interface IProductService
    {
        List<ProductDTO> GetAll();
        ProductDTO? GetForID(int id);
        ProductDTO Add(CreateProductDTO dto);
        bool Update(int id, CreateProductDTO dto);
        bool Delete(int id);
    }
}
