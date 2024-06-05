using BookStoreAPI.Models;
using BookStoreAPI.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Microsoft.AspNetCore.JsonPatch;

namespace BookStoreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IBookRepository bookRepository;

        public BooksController(IBookRepository iBookRepository)
        {
            bookRepository = iBookRepository;
        }

        [HttpGet("")]
        public async Task<IActionResult> GetAllBooks()
        {
            var books = await bookRepository.GetAllBooksAsync();
            return Ok(books);
        }

        [HttpGet("{bookId}")]
        public async Task<IActionResult> GetBookById([FromRoute] int bookId)
        {
            var book = await bookRepository.GetBookByIdAsync(bookId);

            if (book == null)
            {
                return NotFound();
            }
            return Ok(book);
        }

        [HttpPost("")]
        public async Task<IActionResult> AddNewBook([FromBody] BookModel bookModel)
        {
            var id = await bookRepository.AddBookAsync(bookModel);
            return CreatedAtAction(nameof(GetBookById), new { id = id, controller = "books" }, id);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateBook([FromBody] BookModel bookModel, [FromRoute] int id)
        {
            await bookRepository.UpdateBookAsync(id, bookModel);
            return Ok();
        }

        [HttpPatch("{id}")]
        public async Task<IActionResult> UpdateBookPatch([FromBody] JsonPatchDocument bookModel, [FromRoute] int id)
        {
            await bookRepository.UpdateBookPatchAsync(id, bookModel);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBook([FromRoute] int id)
        {
            await bookRepository.DeleteBookAsync(id);
            return Ok();
        }
    }
}
