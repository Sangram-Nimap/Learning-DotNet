using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASPCoreWebAPI.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
       
        [Required]
        
        public required string Name { get; set; }
        public required  int  age { get; set; }
        public int percentage { get; set; }
        public int stander { get; set;}


    }
}
