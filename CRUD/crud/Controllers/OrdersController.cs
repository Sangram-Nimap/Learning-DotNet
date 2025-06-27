using crud.Data;
using crud.DTOs;
using crud.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace crud.Controllers
{
    [ApiController]
    [Route("api/orders")]
    public class OrdersController : ControllerBase
    {
        private readonly AppDbContext _context;

        public OrdersController(AppDbContext context) { _context = context; }

        [HttpPost]
        public IActionResult PlaceOrder(OrderDto orderDto)
        {
            var order = new Order { UserId = orderDto.UserId, OrderDate = DateTime.UtcNow };

            // Add Products to Order
            var products = _context.Products.Where(p => orderDto.ProductIds.Contains(p.Id)).ToList();
            if (products.Count != orderDto.ProductIds.Count)
            {
                return BadRequest("Some products are invalid.");
            }

            foreach (var product in products)
            {
                _context.OrderProducts.Add(new OrderProduct
                {
                    Order = order,
                    Product = product
                });
            }

            _context.Orders.Add(order);
            _context.SaveChanges();

            return CreatedAtAction(nameof(GetById), new { id = order.Id }, order);
        }

        [HttpGet]
        public IActionResult GetAll() => Ok(_context.Orders.Include(o => o.OrderProducts).ThenInclude(op => op.Product).ToList());

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var order = _context.Orders.Include(o => o.OrderProducts).ThenInclude(op => op.Product).FirstOrDefault(o => o.Id == id);
            if (order == null) return NotFound();
            return Ok(order);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, OrderDto orderDto)
        {
            var order = _context.Orders.Find(id);
            if (order == null) return NotFound();

            order.UserId = orderDto.UserId;
            _context.SaveChanges();

            return Ok(order);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var order = _context.Orders.Find(id);
            if (order == null) return NotFound();

            order.IsDeleted = true;  // Soft delete
            _context.SaveChanges();

            return NoContent();
        }
    }
}
