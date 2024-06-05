using AutoMapper;
using BookStoreAPI.Data;
using BookStoreAPI.Models;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BookStoreAPI.Repository
{
    public class BookRepository : IBookRepository
    {
        private readonly BooksStoreContext booksStoreContext;
        private readonly IMapper mapper;

        public BookRepository(BooksStoreContext context, IMapper iMapper)
        {
            booksStoreContext = context;
            mapper = iMapper;
        }

        public async Task<List<BookModel>> GetAllBooksAsync()
        {
            var records = await booksStoreContext.books.ToListAsync();

            return mapper.Map<List<BookModel>>(records);
        }

        public async Task<BookModel> GetBookByIdAsync(int bookId)
        {
            var book = await booksStoreContext.books.FindAsync(bookId);

            return mapper.Map<BookModel>(book);
        }

        public async Task<int> AddBookAsync(BookModel bookModel)
        {
            var book = new Books()
            {
                title = bookModel.title,
                description = bookModel.description
            };

            booksStoreContext.books.Add(book);
            await booksStoreContext.SaveChangesAsync();

            return book.id;
        }

        public async Task UpdateBookAsync(int bookId, BookModel bookModel)
        {
            var book = new Books()
            {
                id = bookId,
                title = bookModel.title,
                description = bookModel.description
            };

            booksStoreContext.books.Update(book);
            await booksStoreContext.SaveChangesAsync();
        }

        public async Task UpdateBookPatchAsync(int bookId, JsonPatchDocument bookModel)
        {
            var book = await booksStoreContext.books.FindAsync(bookId);

            if (bookModel != null)
            {
                bookModel.ApplyTo(book);
                await booksStoreContext.SaveChangesAsync();
            }
        }

        public async Task DeleteBookAsync(int bookId)
        {
            var book = new Books() { id = bookId };

            booksStoreContext.books.Remove(book);

            await booksStoreContext.SaveChangesAsync();

        }
    }
}
