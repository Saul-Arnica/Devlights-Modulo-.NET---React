using System.ComponentModel.DataAnnotations;

namespace Practico_Bloque_2.DTO_s
{
    public class CreateProductDTO
    {
        [Required(ErrorMessage = "El nombre es requerido pa")]
        [StringLength(100, MinimumLength = 3)]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "El precio es requerido")]
        [Range(0.01, 99999999)]
        public decimal Price { get; set; }

        [Required]
        public string Category { get; set; } = string.Empty;
    } 
}