using Generic_Repository_Pattern.Model.Entity;
using Microsoft.EntityFrameworkCore;

namespace Generic_Repository_Pattern.DB
{
    public class LibraryDBContext : DbContext
    {
        public LibraryDBContext(DbContextOptions<LibraryDBContext> options) : base(options) { }

        public DbSet<Book> Books { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}






