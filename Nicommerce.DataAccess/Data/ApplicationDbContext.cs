using Microsoft.EntityFrameworkCore;
using Nicommerce.Models;

namespace Nicommerce.DataAccess.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
        // RUN THOSE COMMANDS AFTER CHANGES:
        // dotnet ef migrations add <MIGRATION_NAME> --startup-project ../NicommerceWeb
        // dotnet ef database update --startup-project ../NicommerceWeb
    }

    public DbSet<Category> Categories { get; set; }
    public DbSet<Product> Products { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Category>().HasData(
            new Category { Id = 1, Name = "Action", DisplayOrder = 1 },
            new Category { Id = 2, Name = "SciFi", DisplayOrder = 2 },
            new Category { Id = 3, Name = "History", DisplayOrder = 3 }
        );

                modelBuilder.Entity<Product>().HasData(
            new Product
            {
                Id = 1,
                Title = "C# Programming",
                Description = "A comprehensive guide to C# programming.",
                ISBN = "978-1234567890",
                Author = "John Doe",
                ListPrice = 49.99,
                Price = 39.99
            },
            new Product
            {
                Id = 2,
                Title = "ASP.NET Core",
                Description = "Learn how to build web applications using ASP.NET Core.",
                ISBN = "978-0987654321",
                Author = "Jane Smith",
                ListPrice = 59.99,
                Price = 49.99
            },
            new Product
            {
                Id = 3,
                Title = "Entity Framework",
                Description = "Master data access with Entity Framework.",
                ISBN = "978-1122334455",
                Author = "Alice Johnson",
                ListPrice = 39.99,
                Price = 29.99
            },
            new Product
            {
                Id = 4,
                Title = "LINQ in Action",
                Description = "Explore LINQ and its powerful features.",
                ISBN = "978-2233445566",
                Author = "Bob Brown",
                ListPrice = 29.99,
                Price = 19.99
            },
            new Product
            {
                Id = 5,
                Title = "Design Patterns",
                Description = "Understand and apply design patterns in software development.",
                ISBN = "978-3344556677",
                Author = "Charlie Green",
                ListPrice = 69.99,
                Price = 59.99
            },
            new Product
            {
                Id = 6,
                Title = "Microservices Architecture",
                Description = "Learn about microservices and how to implement them.",
                ISBN = "978-4455667788",
                Author = "David White",
                ListPrice = 79.99,
                Price = 69.99
            }
        );
    }
}