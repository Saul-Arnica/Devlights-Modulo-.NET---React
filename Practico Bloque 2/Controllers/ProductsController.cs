using Microsoft.AspNetCore.Mvc;
using Practico_Bloque_2.DTO_s;
using Practico_Bloque_2.Services;

namespace Practico_Bloque_2.Controllers
{
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _service;
        public ProductsController(IProductService service)
        {
            _service = service;
        }
        [HttpGet]
        public ActionResult<List<ProductDTO>> GetAll()
        {
            return Ok(_service.GetAll());
        }
        [HttpGet("{id}")]
        public ActionResult<ProductDTO> GetForID(int id)
        {
            var product = _service.GetForID(id);
            if (product == null) return NotFound();
            return Ok(product);
        }
        [HttpPost]
        public ActionResult<ProductDTO> Add(CreateProductDTO dto)
        {
            var newProduct = _service.Add(dto);
            return CreatedAtAction(nameof(GetForID), new { id = newProduct.Id }, newProduct);
        }
        [HttpPut("{id}")]
        public IActionResult Update(int id, CreateProductDTO dto)
        {
            var updated = _service.Update(id, dto);
            if (!updated) return NotFound();
            return NoContent();
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var deleted = _service.Delete(id);
            if (!deleted) return NotFound();
            return NoContent();
        }
    }
    {
    }
}
