using Microsoft.EntityFrameworkCore;
using Starx.Models;

namespace Starx.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions  options): base(options)
        {

        }


        public DbSet<Category> categories { get; set; }
        public DbSet<Author> authors { get; set; }
        public DbSet<Service> services  { get; set; }
        public DbSet<CategoyToService> categoyToServices { get; set; }
    }
}
