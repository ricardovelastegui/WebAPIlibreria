using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPILibros.Controlers
{
    [ApiController]
    [Route("[controller]")]
    [Authorize(Roles = "Client")]
    public class ClientController : ControllerBase
    {
        [HttpGet("books")]
        public IActionResult GetBooks()
        {
            
            return Ok(new[] { new Book { Title = "Book 1", Author = "Author 1" }, new Book { Title = "Book 2", Author = "Author 2" } });
        }
    }

}
