using CRUD_Project.Data;
using CRUD_Project.DTOs;
using CRUD_Project.Models;
using Microsoft.AspNetCore.Mvc;

namespace CRUD_Project.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CategoriesController : ControllerBase
    {
        private readonly AppDbContext _context;

        public CategoriesController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var categories = _context.Categories
                .Select(c => new CategoryDto { Id = c.Id, Name = c.Name })
                .ToList();
            return Ok(categories);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var category = _context.Categories.FirstOrDefault(c => c.Id == id);
            if (category == null) return NotFound();

            return Ok(new CategoryDto { Id = category.Id, Name = category.Name });
        }

        [HttpPost]
        public IActionResult Create(CreateCategoryDto dto)
        {
            var category = new Category { Name = dto.Name };
            _context.
                Categories.Add(category);
            _context.SaveChanges();
            return Ok(category);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, CreateCategoryDto dto)
        {
            var category = _context.Categories.FirstOrDefault(c => c.Id == id);
            if (category == null) return NotFound();

            category.Name = dto.Name;
            _context.SaveChanges();
            return Ok(category);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var category = _context.Categories.FirstOrDefault(c => c.Id == id);
            if (category == null) return NotFound();

            _context.Categories.Remove(category);
            _context.SaveChanges();
            return Ok(category);
        }
    }
}