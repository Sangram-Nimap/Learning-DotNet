using ASPCoreWebAPI.AppDbContext.cs;
using ASPCoreWebAPI.Dtos;
using ASPCoreWebAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace ASPCoreWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly StudentDbContext dbContext;

        public StudentsController(StudentDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        /* [HttpGet]
         public async Task<IActionResult>  GetAllStudents()
         {
            var GetAllData = dbContext.Students.ToList();
             return Ok(GetAllData);
         }


         [HttpGet("{id}")]
         public IActionResult GetByid(int id)
         {
             var GetById = dbContext.Students.FindAsync(id);
             return Ok(GetById);
         }

         [HttpPost]
         public async Task<IActionResult> AddStudents(StudentDtocs studentsDto)
         {
             var students = new Students()
             {
                 Name = dbContext.studentsDto.Name,

             };

         }*/


        [HttpGet]
        public IActionResult GetAllStudent()
        {
            var allStudents = dbContext.Students.ToList();
            return Ok(allStudents);

        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var GetById = dbContext.Students.Find(id);
            return Ok(GetById);
        }


        [HttpPost]
        public IActionResult AddStudents(StudentDtocs studentsDto)
        {
            var students = new Student()
            {
                Name = studentsDto.Name,
                age = studentsDto.age,
                stander = studentsDto.stander,
                percentage = studentsDto.percentage,
            };
            dbContext.Students.Add(students);
            dbContext.SaveChanges();
            return Ok(students);
        }
        [HttpPut("{id}")]
        public IActionResult UpdateStudent(int id,UpdateStudentsDto updateStudents)
        {
            var students = dbContext.Students.Find(id);
           if (students is null)
            {
                return NotFound();
            }
            students.Name = updateStudents.Name;
            students.age = updateStudents.age;
            students.stander = updateStudents.stander;  
            students.percentage = updateStudents.percentage;

            dbContext.SaveChanges();
            return Ok(students);

        }

        [HttpDelete("{id}")]
        public IActionResult DeleteStudents(int id)
        {
            var students = dbContext.Students.Find(id);
            if (students is null)
            {
                return NotFound();
            }
            dbContext.Students.Remove(students);
            dbContext.SaveChanges();
            return Ok();
        }

        }

        }


