using Microsoft.AspNetCore.Mvc;
using SportsWebAPI.Responses;

namespace SportsWebAPI.Controllers // This is a comment to start a merge conflict
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        [HttpGet]
        [ProducesResponseType(typeof(TodoResponse), StatusCodes.Status200OK)]
        public ActionResult<IEnumerable<string>> GetProducts()
        {
            TodoResponse response = new()
            {
                IsDone = true,
                Todo = "This is a todo"
            };

            return Ok(response);
        }

        [HttpGet("{id}")]
        public ActionResult<string> GetProductsById(int id)
        {
            return $"Product {id}";
        }

        [HttpPost]
        public ActionResult<string> AddProduct([FromBody] string value)
        {
            return $"Posted: {value}";
        }
    }
}
