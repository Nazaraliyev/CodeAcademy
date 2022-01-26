using Biziness.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Biziness.Data
{
    public class AppDbContext:IdentityDbContext
    {
        public AppDbContext(DbContextOptions options) :base(options)
        {

        }


        public DbSet<CustomUser> customUsers { get; set; }
        public DbSet<Banner> banners { get; set; }
        public DbSet<Message> messages { get; set; }
        public DbSet<Service> services { get; set; }
        public DbSet<Setting> settings { get; set; }
        public DbSet<SocialMedia> socialMedias { get; set; }
    }
}
