using BookStore.Data;
using Microsoft.EntityFrameworkCore;

namespace BookStore.DataContext
{
    public class BookStoreContext : DbContext
    {
        public BookStoreContext(DbContextOptions<BookStoreContext> options)
            : base(options)
        {            
        }

        public DbSet<Books> books { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("Server=.;DataBase=BookStore;Integrated Security=True");
        //    base.OnConfiguring(optionsBuilder); 
        //}


    }
}
