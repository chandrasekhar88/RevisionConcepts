using AutoMapper;
using BookStore.Data;
using BookStore.DataContext;
using BookStore.Models;
using BookStore.Repository;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace bookstore.Repository
{
    public class BookRepository : IBookRepository
    {
        private readonly BookStoreContext _context;
        private readonly IMapper _mapper;
        public BookRepository(BookStoreContext context, IMapper IMapper)
        {
            _context = context;
            _mapper = IMapper;
        }

        public async Task<List<BookModel>> GetAllbooksAsync()
        {
            var records = await _context.books.ToListAsync();
            return _mapper.Map<List<BookModel>>(records);
        }

        public async Task<BookModel> GetBookByIdAsync(int bookId)
        {
            var book = await _context.books.FindAsync(bookId);
            return _mapper.Map<BookModel>(book);
        }

        public async Task<int> AddBookAsync(BookModel BookModel)
        {
            var book = new Books()
            {
                name = BookModel.name,
                description = BookModel.description
            };
            _context.Add(book);
            await _context.SaveChangesAsync();
            return book.id;
        }

        public async Task UpdateBookAsync(int bookId, BookModel BookModel)
        {
            var book = new Books()
            {
                id = bookId,
                name = BookModel.name,
                description = BookModel.description
            };
            _context.books.Update(book);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateBookPatchAsync(int bookId, JsonPatchDocument BookModel)
        {
            var book = await _context.books.FindAsync(bookId);
            if (BookModel != null)
            {
                BookModel.ApplyTo(book);
                await _context.SaveChangesAsync();
            }
        }

        public async Task DeleteBookAsync(int bookId)
        {
            var book = new Books() { id = bookId };
            _context.books.Remove(book);
            await _context.SaveChangesAsync();
        }
    }
}
