using Microsoft.AspNetCore.Mvc;

namespace ASPCoreWebAPI.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class FruitsAPIController : Controller
    {

        public List<string> fruits = new List<string>()
     {
         "Apple",
         "Mango",
         "PineApple",
         "banana",
         "grapes"
     };

        [HttpGet]
        public List<string> GetFruits()
        {
            return fruits;
        }

        [HttpGet("{id}")]
        public string GetFruitsBId(int id)
        {
            return fruits.ElementAt(id);
        }

    }
}
