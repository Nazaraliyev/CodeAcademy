using Microsoft.EntityFrameworkCore;
using Simple_API.Model;

namespace Simple_API.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions options):base(options)
        {

        }

        public DbSet<Faculty> faculties { get; set; }
        public DbSet<Qualification> qualifications { get; set; }
        public DbSet<Class> classes { get; set; }
        public DbSet<Student> students { get; set; }
        public DbSet<Degre> degres { get; set; }
        public DbSet<Level> levels { get; set; }
    }
}
