using Microsoft.EntityFrameworkCore;
using SolevogueBackend.Models;
namespace SolevogueBackend.Datas
{
    public class SolevogueContext:DbContext
    {

        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }

        public DbSet<CartItem> CartItems { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<OrderItem> OrderItems { get; set; }

        public DbSet<WishList> WishLists { get; set; }



        public SolevogueContext(DbContextOptions<SolevogueContext> options) : base(options) { }

    }
}
