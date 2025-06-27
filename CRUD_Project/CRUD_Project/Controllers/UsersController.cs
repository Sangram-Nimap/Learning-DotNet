using CRUD_Project.Data;
using CRUD_Project.Models;
using CRUD_Project.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace CRUD_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly AppDbContext dbContext;

        public UsersController(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult GetAllUsers()
        {
            var users = dbContext.User.ToList();
            return Ok(users);
        }

        [HttpGet("{id:int}")]
        public IActionResult GetUserById(int id)
        {
            var user = dbContext.User.Find(id);
            if (user == null)
            {
                return NotFound();
            }
            return Ok(user);
        }

        [HttpPost]
        public IActionResult AddUser(AddUserDto addUserDto)
        {
            var userEntity = new User
            {
                UserName = addUserDto.UserName,
                PassWordHash = addUserDto.PassWordHash,
                Role = addUserDto.Role
            };

            dbContext.User.Add(userEntity);
            dbContext.SaveChanges();

            return Ok(userEntity);
        }

        [HttpPut("{id:int}")]
        public IActionResult UpdateUser(int id, UpdateUserDto updateUserDto)
        {
            var user = dbContext.User.Find(id);
            if (user == null)
            {
                return NotFound();
            }

            user.UserName = updateUserDto.UserName;
            user.PassWordHash = updateUserDto.PassWordHash;
            user.Role = updateUserDto.Role;

            dbContext.SaveChanges();

            return Ok(user);
        }

        [HttpDelete("{id:int}")]
        public IActionResult DeleteUser(int id)
        {
            var user = dbContext.User.Find(id);
            if (user == null)
            {
                return NotFound();
            }

            dbContext.User.Remove(user);
            dbContext.SaveChanges();

            return Ok(user);
        }
    }
}
