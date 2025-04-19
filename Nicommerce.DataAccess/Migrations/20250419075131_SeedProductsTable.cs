using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Nicommerce.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class SeedProductsTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Author", "Description", "ISBN", "ListPrice", "Price", "Title" },
                values: new object[,]
                {
                    { 1, "John Doe", "A comprehensive guide to C# programming.", "978-1234567890", 49.990000000000002, 39.990000000000002, "C# Programming" },
                    { 2, "Jane Smith", "Learn how to build web applications using ASP.NET Core.", "978-0987654321", 59.990000000000002, 49.990000000000002, "ASP.NET Core" },
                    { 3, "Alice Johnson", "Master data access with Entity Framework.", "978-1122334455", 39.990000000000002, 29.989999999999998, "Entity Framework" },
                    { 4, "Bob Brown", "Explore LINQ and its powerful features.", "978-2233445566", 29.989999999999998, 19.989999999999998, "LINQ in Action" },
                    { 5, "Charlie Green", "Understand and apply design patterns in software development.", "978-3344556677", 69.989999999999995, 59.990000000000002, "Design Patterns" },
                    { 6, "David White", "Learn about microservices and how to implement them.", "978-4455667788", 79.989999999999995, 69.989999999999995, "Microservices Architecture" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);
        }
    }
}
