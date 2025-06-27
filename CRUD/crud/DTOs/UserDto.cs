using System.ComponentModel.DataAnnotations;

namespace crud.DTOs
{
    public class UserDto
    {
        [Required]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
