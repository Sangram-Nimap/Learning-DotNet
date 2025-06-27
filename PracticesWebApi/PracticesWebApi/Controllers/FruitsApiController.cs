using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PracticesWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FruitsApiController : ControllerBase
    {
        public List<string> Fruit = new List<string>
        {
            "Apple",
            "JackFruit",
            "PineApple",
            "Sitafhal",
            "Ramfhal",
            "Orange"

        };


        [HttpGet]
        public List<string> GetAll()
        {
            return Fruit;
        }


        [HttpGet("{id}")]
        public string GetAllById(int id)
        {
            return Fruit.ElementAt(id);
        }

/*
        [HttpDelete]
        public string  DeleteById(int id) {


            return Fruit.ElementAt(id);*/

    }

     
}
