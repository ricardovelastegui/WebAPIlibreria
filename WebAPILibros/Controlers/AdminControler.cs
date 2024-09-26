using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebAPILibros.Controlers
{
    [ApiController]
    [Route("[controller]")]
    [Authorize(Roles = "Admin")]
    public class AdminController : ControllerBase
    {
        [HttpPost("add")]
        public IActionResult AddBook([FromBody] Book book)
        {
            // Simular agregar un libro
            return Ok($"Book {book.Title} added.");
        }

        
    }

    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
    }

}
