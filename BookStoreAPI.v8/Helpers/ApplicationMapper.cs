using AutoMapper;
using BookStoreAPI.v8.Data;
using BookStoreAPI.v8.Models;

namespace BookStoreAPI.v8.Helpers
{
    public class ApplicationMapper : Profile
    {
        public ApplicationMapper()
        {
            CreateMap<Books, BooksModel>().ReverseMap();
        }
    }
}
