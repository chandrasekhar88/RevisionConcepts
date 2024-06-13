using BookStore.Models;
using BookStore.Repository;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BookStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IBookRepository _bookRepository;

        public BooksController(IBookRepository bookRepository) 
        {
            _bookRepository = bookRepository;
        }
        
        public async Task<IActionResult> GetAllBooks()
        {
            var books = await _bookRepository.GetAllbooksAsync();
            return Ok(books);
        }

        [HttpGet("{bookId}")]
        public async Task<IActionResult> GetBookById([FromRoute] int bookId)
        {
            var book = await _bookRepository.GetBookByIdAsync(bookId);
            return Ok(book);
        }

        [HttpPost("")]
        public async Task<IActionResult> AddBook([FromBody] BookModel BookModel)
        {
            var bookId = await _bookRepository.AddBookAsync(BookModel);

            return CreatedAtAction(nameof(GetBookById), new { bookId = bookId, controller = "Books" }, bookId);
        }

        [HttpPut("{bookId}")]
        public async Task<IActionResult> UpdateBook([FromRoute] int bookId, [FromBody] BookModel BookModel)
        {
            await _bookRepository.UpdateBookAsync(bookId, BookModel);
            return Ok();
        }

        [HttpPatch("{bookId}")]
        public async Task<IActionResult> UpdateBookPatch([FromRoute] int bookId, [FromBody] JsonPatchDocument BookModel)
        {
            await _bookRepository.UpdateBookPatchAsync(bookId, BookModel);
            return Ok();
        }

        [HttpDelete("{bookId}")]
        public async Task<IActionResult> DeleteBook([FromRoute] int bookId)
        {
            await _bookRepository.DeleteBookAsync(bookId);
            return Ok();
        }

    }
}
