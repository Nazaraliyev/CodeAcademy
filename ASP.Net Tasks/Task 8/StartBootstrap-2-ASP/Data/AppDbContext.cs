using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using StartBootstrap_2_ASP.Models;

namespace StartBootstrap_2_ASP.Data
{
    public class AppDbContext:IdentityDbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Settings> settings { get; set; }
        public DbSet<Product> products { get; set; }
        public DbSet<Cart> carts { get; set; }
        public DbSet<Category> categories { get; set; }
        public DbSet<CostumeUser> costumeUsers { get; set; }
    }
}
