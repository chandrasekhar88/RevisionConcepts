using AutoMapper;
using BookStoreAPI.v8.Data;
using BookStoreAPI.v8.Models;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.EntityFrameworkCore;

namespace BookStoreAPI.v8.Repository
{
    public class BookRepository : IBookRepository
    {
        private readonly BooksContext _context;
        private readonly IMapper _mapper;

        public BookRepository(BooksContext context, IMapper IMapper) 
        {
            _context = context;
            _mapper = IMapper;
        }

        public async Task<List<BooksModel>> GetAllBooksAsync()
        {
            var records = await _context.Books.ToListAsync();
            return _mapper.Map<List<BooksModel>>(records);            
        }

        public async Task<BooksModel> GetBookByIdAsync(int bookId)
        {
            var book = await _context.Books.FindAsync(bookId);
            return _mapper.Map<BooksModel>(book);
        }

        public async Task<int> AddBookAsync(BooksModel booksModel)
        {
            var book = new Books()
            {
                Title = booksModel.Title,
                Description = booksModel.Description
            };
            _context.Add(book);
            await _context.SaveChangesAsync();
            return book.Id;
        }

        public async Task UpdateBookAsync(int bookId, BooksModel booksModel)
        {
            var book = new Books()
            {
                Id = bookId,
                Title = booksModel.Title,
                Description = booksModel.Description
            };
            _context.Books.Update(book);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateBookPatchAsync(int bookId, JsonPatchDocument bookModel)
        {
            var book = await _context.Books.FindAsync(bookId);
            if (bookModel != null) 
            {
                bookModel.ApplyTo(book);
                await _context.SaveChangesAsync();
            }
        }

        public async Task DeleteBookAsync(int bookId)
        {
            var book = new Books() { Id = bookId };
            _context.Books.Remove(book);
            await _context.SaveChangesAsync();            
        }

    }
}
