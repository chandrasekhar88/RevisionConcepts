using BookStoreAPI.v8.Models;
using Microsoft.AspNetCore.JsonPatch;

namespace BookStoreAPI.v8.Repository
{
    public interface IBookRepository
    {
        Task<List<BooksModel>> GetAllBooksAsync();
        Task<BooksModel> GetBookByIdAsync(int bookId);
        Task<int> AddBookAsync(BooksModel booksModel);
        Task UpdateBookAsync(int bookId, BooksModel booksModel);
        Task UpdateBookPatchAsync(int bookId, JsonPatchDocument bookModel);
        Task DeleteBookAsync(int bookId);
    }
}
