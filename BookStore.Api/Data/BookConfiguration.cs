using BookStore.Api.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookStore.Api.Data
{
    public class BookConfiguration : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.HasData(
                new Book
                {
                    BookId = 1,
                    Title = "The Great Gatsby",
                    Author = "F. Scott Fitzgerald",
                    Genre = "Fiction",
                    Price = 7.99M,
                    Pages = 180,
                    Publisher = "Scribner"
                },
                new Book
                {
                    BookId = 2,
                    Title = "To Kill a Mockingbird",
                    Author = "Harper Lee",
                    Genre = "Fiction",
                    Price = 8.99M,
                    Pages = 281,
                    Publisher = "J.B. Lippincott & Co."
                },
                new Book
                {
                    BookId = 3,
                    Title = "1984",
                    Author = "George Orwell",
                    Genre = "Dystopian",
                    Price = 6.99M,
                    Pages = 328,
                    Publisher = "Secker & Warburg"
                },
                new Book
                {
                    BookId = 4,
                    Title = "Moby Dick",
                    Author = "Herman Melville",
                    Genre = "Adventure",
                    Price = 9.99M,
                    Pages = 635,
                    Publisher = "Harper & Brothers"
                },
                new Book
                {
                    BookId = 5,
                    Title = "War and Peace",
                    Author = "Leo Tolstoy",
                    Genre = "Historical",
                    Price = 12.99M,
                    Pages = 1225,
                    Publisher = "The Russian Messenger"
                },
                new Book
                {
                    BookId = 6,
                    Title = "Pride and Prejudice",
                    Author = "Jane Austen",
                    Genre = "Romance",
                    Price = 5.99M,
                    Pages = 279,
                    Publisher = "T. Egerton"
                },
                new Book
                {
                    BookId = 7,
                    Title = "The Catcher in the Rye",
                    Author = "J.D. Salinger",
                    Genre = "Fiction",
                    Price = 6.99M,
                    Pages = 214,
                    Publisher = "Little, Brown and Company"
                },
                new Book
                {
                    BookId = 8,
                    Title = "The Hobbit",
                    Author = "J.R.R. Tolkien",
                    Genre = "Fantasy",
                    Price = 8.99M,
                    Pages = 310,
                    Publisher = "George Allen & Unwin"
                },
                new Book
                {
                    BookId = 9,
                    Title = "Fahrenheit 451",
                    Author = "Ray Bradbury",
                    Genre = "Dystopian",
                    Price = 7.99M,
                    Pages = 194,
                    Publisher = "Ballantine Books"
                },
                new Book
                {
                    BookId = 10,
                    Title = "Jane Eyre",
                    Author = "Charlotte Brontë",
                    Genre = "Romance",
                    Price = 6.99M,
                    Pages = 500,
                    Publisher = "Smith, Elder & Co."
                }
            );
        }
    }
}
