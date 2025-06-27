namespace CRUD_Project.DTOs
{
    public class UpdateUserDto
    {
        public string UserName { get; set; }
        public string PassWordHash { get; set; }
        public string Role { get; set; }
    }
}
