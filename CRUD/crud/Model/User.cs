namespace crud.Model
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public bool IsDeleted { get; set; }  // Added for soft delete

        // Navigation property for orders
        public ICollection<Order> Orders { get; set; }
    }
}
