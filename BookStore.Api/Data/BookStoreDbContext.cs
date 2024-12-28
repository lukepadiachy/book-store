using BookStore.Api.Model;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Api.Data
{
    public class BookStoreDbContext : DbContext
    {

        public BookStoreDbContext(DbContextOptions<BookStoreDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new BookConfiguration());
        }

        public DbSet<Book> Books { get; set; }


    }
}
