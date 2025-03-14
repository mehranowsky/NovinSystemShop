using Microsoft.EntityFrameworkCore;
using ModelLayer.Models;

namespace ModelLayer.Context
{
    public class NovinSystemDbContext : DbContext
    {
        public NovinSystemDbContext(DbContextOptions<NovinSystemDbContext> options):base(options)
        {
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
    }
}
