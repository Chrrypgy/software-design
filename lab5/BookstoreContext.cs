using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace lab5
{
    public class BookstoreContext : DbContext
    {
        public DbSet<Book> Books { get; set; } = new HashSet<Book>();
        public DbSet<Author> Authors { get; set; } = new HashSet<Author>();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)  // Fixed typo
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Userdb;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");
        }
    }

    public class Author
    {
        public int AuthorID { get; set; }
        public required string Name { get; set; }
        public List<Book> Books { get; set; } = new();
    }

    public class Book
    {
        public int BookID { get; set; }
        public required string Title { get; set; }
        public int AuthorID { get; set; }
        public required Author Author { get; set; }
    }
}
