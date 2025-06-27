using System.ComponentModel.DataAnnotations;

namespace CRUD_Project.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        // Navigation
        public ICollection<Product>? Products { get; set; }
    }
}
