namespace crud.Model
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }

        // Navigation property for products in the category
        public ICollection<Product> Products { get; set; }
    }
}
