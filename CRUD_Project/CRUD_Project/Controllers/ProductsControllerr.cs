using CRUD_Project.Data;
using CRUD_Project.DTOs;
using CRUD_Project.Models;
using Microsoft.AspNetCore.Mvc;

namespace CRUD_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly AppDbContext dbContext;

        public ProductsController(AppDbContext dbContext) => this.dbContext = dbContext;

        [HttpGet]
        public IActionResult GetAll()
        {
            try
            {
                return Ok(dbContext.Products.ToList());
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error: {ex.Message}");
            }
        }

        [HttpPost]
        public IActionResult Add(CreateProductDto dto)
        {
            try
            {
                var product = new Product
                {
                    Name = dto.Name,
                    Description = dto.Description,
                    Price = dto.Price,
                    CategoryId = dto.CategoryId
                };

                dbContext.Products.Add(product);
                dbContext.SaveChanges();

                return Ok(product);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error: {ex.Message}");
            }
        }

        [HttpPut("{id:int}")]
        public IActionResult Update(int id, UpdateProductDto dto)
        {
            try
            {
                var product = dbContext.Products.Find(id);
                if (product == null) return NotFound();

                product.Name = dto.Name;
                product.Description = dto.Description;
                product.Price = dto.Price;
                product.CategoryId = dto.CategoryId;

                dbContext.SaveChanges();

                return Ok(product);
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
                var product = dbContext.Products.Find(id);
                if (product == null) return NotFound();

                dbContext.Products.Remove(product);
                dbContext.SaveChanges();

                return Ok(product);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error: {ex.Message}");
            }
        }
    }
}
