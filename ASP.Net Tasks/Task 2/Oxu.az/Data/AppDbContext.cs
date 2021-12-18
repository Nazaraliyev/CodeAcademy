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
        public DbSet<Author> Authors { get; set; }
        public DbSet<Setting> Settings { get; set; }
        public DbSet<AuthorNews> AuthorNews { get; set; }
        public DbSet<CategoryNews> CategoryNews { get; set; }
        public DbSet<Images> Images { get; set; }
    }
}
