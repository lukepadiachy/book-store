using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BookStore.Api.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    BookId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Genre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Pages = table.Column<int>(type: "int", nullable: false),
                    Publisher = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.BookId);
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "Author", "Genre", "Pages", "Price", "Publisher", "Title" },
                values: new object[,]
                {
                    { 1, "F. Scott Fitzgerald", "Fiction", 180, 7.99m, "Scribner", "The Great Gatsby" },
                    { 2, "Harper Lee", "Fiction", 281, 8.99m, "J.B. Lippincott & Co.", "To Kill a Mockingbird" },
                    { 3, "George Orwell", "Dystopian", 328, 6.99m, "Secker & Warburg", "1984" },
                    { 4, "Herman Melville", "Adventure", 635, 9.99m, "Harper & Brothers", "Moby Dick" },
                    { 5, "Leo Tolstoy", "Historical", 1225, 12.99m, "The Russian Messenger", "War and Peace" },
                    { 6, "Jane Austen", "Romance", 279, 5.99m, "T. Egerton", "Pride and Prejudice" },
                    { 7, "J.D. Salinger", "Fiction", 214, 6.99m, "Little, Brown and Company", "The Catcher in the Rye" },
                    { 8, "J.R.R. Tolkien", "Fantasy", 310, 8.99m, "George Allen & Unwin", "The Hobbit" },
                    { 9, "Ray Bradbury", "Dystopian", 194, 7.99m, "Ballantine Books", "Fahrenheit 451" },
                    { 10, "Charlotte Brontë", "Romance", 500, 6.99m, "Smith, Elder & Co.", "Jane Eyre" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");
        }
    }
}
