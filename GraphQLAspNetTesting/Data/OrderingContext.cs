using Microsoft.EntityFrameworkCore;
using GraphQLAspNetTesting.Data.Entities;

namespace GraphQLAspNetTesting.Data
{
    public class OrderingContext : DbContext
    {
        public OrderingContext(DbContextOptions<OrderingContext> options) : base(options)
        { }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}
