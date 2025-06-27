namespace crud.Model
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }

        // Navigation property for Order-Product many-to-many relationship
        public ICollection<OrderProduct> OrderProducts { get; set; }
    }
}
