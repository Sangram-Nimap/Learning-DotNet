namespace CRUD_Project.Models
{
    public class User
    {
        public  int Id { get; set; }
        public required String UserName { get; set; }
        public required String PassWordHash { get; set; }
        public required string Role { get; set; }

        public ICollection<Order>? Orders { get; set; }
    }
}
