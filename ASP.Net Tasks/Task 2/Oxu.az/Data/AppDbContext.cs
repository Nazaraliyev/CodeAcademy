using Microsoft.EntityFrameworkCore;
using Oxu.az.Models;

namespace Oxu.az.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions option) : base(option)
        {
                
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<News> News { get; set; }
        public DbSet<CategoryNews> CategoryNews { get; set; }

    }
}
