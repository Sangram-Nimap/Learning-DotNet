using System.ComponentModel.DataAnnotations;

namespace crud.DTOs
{
    public class ProductDto
    {
        [Required]
        public string Name { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "Price must be a positive value.")]
        public decimal Price { get; set; }

        public int CategoryId { get; set; }  // Added to associate product with category
    }
}
