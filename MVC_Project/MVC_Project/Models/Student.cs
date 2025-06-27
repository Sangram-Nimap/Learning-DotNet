using System.ComponentModel.DataAnnotations;

namespace MVC_Project.Models
{
    public class Student
    {
        [Key]
        public required int Id { get; set;  }
        public required  string Name { get; set; }
        public int Class { get; set; }
        public int age { get; set; }

    }
}
