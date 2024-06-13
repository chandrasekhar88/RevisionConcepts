using BookStoreAPI.v8.Models;
using BookStoreAPI.v8.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;

namespace BookStoreAPI.v8.Controllers
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

        [HttpGet("")]
        public async Task<IActionResult> GetAllBooks(BooksModel booksModel)
        {
            var books = await _bookRepository.GetAllBooksAsync();
            return Ok(books);
        }

        [HttpGet("{bookId}")]
        public async Task<IActionResult> GetBookById([FromRoute] int bookId)
        {
            var book = await _bookRepository.GetBookByIdAsync(bookId);
            return Ok(book);
        }

        [HttpPost("")]
        public async Task<IActionResult> AddBook([FromBody] BooksModel booksModel)
        {
            var bookId = await _bookRepository.AddBookAsync(booksModel);

            return CreatedAtAction(nameof(GetBookById), new { bookId = bookId, controller = "Books" }, bookId);
        }

        [HttpPut("{bookId}")]
        public async Task<IActionResult> UpdateBook([FromRoute] int bookId, [FromBody] BooksModel booksModel)
        {
            await _bookRepository.UpdateBookAsync(bookId,booksModel);
            return Ok();
        }

        [HttpPatch("{bookId}")]
        public async Task<IActionResult> UpdateBookPatch([FromRoute] int bookId, [FromBody] JsonPatchDocument booksModel)
        {
            await _bookRepository.UpdateBookPatchAsync(bookId, booksModel);
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
