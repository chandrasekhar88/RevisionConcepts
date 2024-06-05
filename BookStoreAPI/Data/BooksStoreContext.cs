using BookStoreAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace BookStoreAPI.Data
{
    public class BooksStoreContext : DbContext
    {
        public BooksStoreContext(DbContextOptions<BooksStoreContext> options)
           : base(options)
        {

        }

        public DbSet<Books> books { get; set; }

        /*protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server =.;Database=BookStoreAPI;Integrated Security=true");
            base.OnConfiguring(optionsBuilder);
        }*/
    }
}
