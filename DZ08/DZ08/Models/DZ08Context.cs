using Microsoft.EntityFrameworkCore;

namespace DZ08.Models
{
    public class DZ08Context : DbContext
    {
        public DZ08Context(DbContextOptions<DZ08Context> options) : base(options)
        {
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure relationships
            modelBuilder.Entity<Book>()
                .HasOne(b => b.Author)
                .WithMany(a => a.Books)
                .HasForeignKey(b => b.AuthorID);

            // Seed initial data
            modelBuilder.Entity<Author>().HasData(
                new Author
                {
                    AuthorID = 1,
                    FirstName = "J.K.",
                    LastName = "Rowling"
                },
                new Author
                {
                    AuthorID = 2,
                    FirstName = "George",
                    LastName = "Orwell"
                },
                new Author
                {
                    AuthorID = 3,
                    FirstName = "Jane",
                    LastName = "Austen"
                }
            );

            modelBuilder.Entity<Book>().HasData(
                new Book
                {
                    BookID = 1,
                    Title = "Harry Potter and the Philosopher's Stone",
                    AuthorID = 1,
                    Genre = "Fantasy",
                    ISBN = "9780747532699",
                    Price = 15.99m,
                    PublicationDate = new DateTime(1997, 6, 26),
                    Rating = 5,
                    Description = "A young wizard discovers his magical heritage and attends Hogwarts School."
                },
                new Book
                {
                    BookID = 2,
                    Title = "1984",
                    AuthorID = 2,
                    Genre = "Dystopian Fiction",
                    ISBN = "9780451524935",
                    Price = 12.99m,
                    PublicationDate = new DateTime(1949, 6, 8),
                    Rating = 5,
                    Description = "A dystopian social science fiction novel about totalitarian control."
                },
                new Book
                {
                    BookID = 3,
                    Title = "Pride and Prejudice",
                    AuthorID = 3,
                    Genre = "Romance",
                    ISBN = "9780141439518",
                    Price = 10.99m,
                    PublicationDate = new DateTime(1813, 1, 28),
                    Rating = 4,
                    Description = "A romantic novel about the complex relationship between Elizabeth Bennet and Mr. Darcy."
                }
            );
        }
    }
}