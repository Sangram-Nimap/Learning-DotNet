using System.ComponentModel.DataAnnotations;

namespace SampleWebApiCRUD.Model
{
    public class Student
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int Stander { get; set; }
        public string? Email{ get; set; }
    }
}
