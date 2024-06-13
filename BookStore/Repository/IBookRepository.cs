using BookStore.Models;
using Microsoft.AspNetCore.JsonPatch;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BookStore.Repository
{
    public interface IBookRepository
    {
        Task<List<BookModel>> GetAllbooksAsync();
        Task<BookModel> GetBookByIdAsync(int bookId);
        Task<int> AddBookAsync(BookModel BookModel);
        Task UpdateBookAsync(int bookId, BookModel BookModel);
        Task UpdateBookPatchAsync(int bookId, JsonPatchDocument BookModel);
        Task DeleteBookAsync(int bookId);
    }
}
