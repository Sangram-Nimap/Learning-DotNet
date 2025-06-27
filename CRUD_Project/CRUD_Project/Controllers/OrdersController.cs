using CRUD_Project.Data;
using CRUD_Project.DTOs;
using CRUD_Project.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CRUD_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly AppDbContext dbContext;

        public OrdersController(AppDbContext dbContext) => this.dbContext = dbContext;

        [HttpGet]
        public IActionResult GetAll()
        {
            try
            {
                var orders = dbContext.Order
                    .Include(o => o.User) //  Include related User entity
                    .ToList();

                return Ok(orders);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error: {ex.Message}");
            }
        }

        [HttpPost]
        public IActionResult Add(CreateOrderDto dto)
        {
            try
            {
                var order = new Order
                {
                    UserId = dto.UserId,
                    OrderDate = DateTime.Now
                };
                dbContext.Order.Add(order);
                dbContext.SaveChanges();
                return Ok(order);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error: {ex.Message}");
            }
        }

        [HttpDelete("{id:int}")]
        public IActionResult Delete(int id)
        {
            try
            {
                var order = dbContext.Order.Find(id);
                if (order == null) return NotFound();
                dbContext.Order.Remove(order);
                dbContext.SaveChanges();
                return Ok(order);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error: {ex.Message}");
            }
        }
    }
}
