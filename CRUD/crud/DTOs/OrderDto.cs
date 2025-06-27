namespace crud.DTOs
{
    public class OrderDto
    {
        public int UserId { get; set; }
        public List<int> ProductIds { get; set; }  // Added to associate products with an order
    }
}
