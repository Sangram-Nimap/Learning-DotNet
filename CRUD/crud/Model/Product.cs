namespace crud.Model
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public bool IsDeleted { get; set; }  // Added for soft delete

        // Foreign key to Category
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        // Navigation property for Order-Product many-to-many relationship
        public ICollection<OrderProduct> OrderProducts { get; set; }
    }
}
