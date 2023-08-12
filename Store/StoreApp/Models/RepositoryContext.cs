using Microsoft.EntityFrameworkCore;
using Entities.Models;

namespace StoreApp.Models
{
    public class RepositoryContext : DbContext
    {

        public DbSet<Product> Products { get; set; }

        public RepositoryContext(DbContextOptions<RepositoryContext> options)
        : base(options)
        {


        }

        protected override void OnModelCreating(ModelBuilder modelBuilder){

            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>()
            .HasData(
                new Product(){ProductID=1, ProductName="Computer", Price=1_000},
                new Product(){ProductID=2, ProductName="berat", Price=7_000},
                new Product(){ProductID=3, ProductName="asdf", Price=157_000},
                new Product(){ProductID=4, ProductName="asdfdsa", Price=47_000},
                new Product(){ProductID=5, ProductName="asdfs", Price=77_000}
            );
        }

    }
}